Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Text

''' <summary>
''' 在庫一覧
''' </summary>
Public Class FrmStockList

    Private locationDt As DataTable = Nothing

#Region "EVENT"

    Private Sub FrmStockList_Load(sender As Object, e As EventArgs) Handles Me.Load

        initGrid()
        ShowWaitForm()

        Async.Process(
            AddressOf search,
            Sub()
                CloseLoadingForm()
            End Sub)
    End Sub

    Private Sub initGrid()
        grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing  'タイトルの高さを固定
        grd.ColumnHeadersHeight = 36
        grd.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        grd.CellBorderStyle = DataGridViewCellBorderStyle.Single
        grd.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grd.RowTemplate.DefaultCellStyle.Padding = New Padding(0, 2, 0, 2)

        ' grd.Paintイベントに入れると、　画面の反応がすごく遅くなる
        grd.Columns(4).HeaderText = "合計" & vbCrLf & "実在庫数"
        grd.Columns(5).HeaderText = "合計" & vbCrLf & "引当数"
        grd.Columns(6).HeaderText = "合計" & vbCrLf & "有効在庫数"

    End Sub


    Private Sub grd_Paint(sender As Object, e As PaintEventArgs) Handles grd.Paint

        If locationDt Is Nothing Then
            locationDt = CommonService.GetLocation(False)
        End If

        If grd.Columns.Count <= 7 Then
            For i As Integer = 0 To locationDt.Rows.Count - 1
                Dim r As DataRow = locationDt.Rows(i)
                grd.Columns.Add("ACTQTY" + r.Item("CODE"), r.Item("LOCATIONNM"))
                Dim col As DataGridViewColumn = grd.Columns("ACTQTY" + r.Item("CODE"))
                col.Width = 66
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
                col.DataPropertyName = "ACTQTY" + r.Item("CODE")
                col.SortMode = DataGridViewColumnSortMode.Automatic
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Next
        End If


        Dim location As String() = {"合計", locationDt.Rows(0).Item("LOCATIONNM")}

        For j As Integer = 4 To 4
            Dim r1 As Rectangle = grd.GetCellDisplayRectangle(j, -1, True)
            Dim w2 As Integer = grd.GetCellDisplayRectangle(j + 1, -1, True).Width
            Dim w3 As Integer = grd.GetCellDisplayRectangle(j + 2, -1, True).Width
            r1.X = r1.X + 1
            r1.Y = r1.Y + 1
            r1.Width = r1.Width + w2 + w3 - 2
            r1.Height = r1.Height / 2 - 1

            e.Graphics.FillRectangle(New SolidBrush(grd.ColumnHeadersDefaultCellStyle.BackColor), r1)
            Dim format As New StringFormat
            format.Alignment = StringAlignment.Center
            format.LineAlignment = StringAlignment.Far

            e.Graphics.DrawString(location((j - 4) \ 2),
                                  grd.ColumnHeadersDefaultCellStyle.Font,
                                  New SolidBrush(grd.ColumnHeadersDefaultCellStyle.ForeColor), r1, format)
            j = j + 2
        Next

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        ShowWaitForm()
        Async.Process(
            AddressOf search,
            Sub()
                CloseLoadingForm()
            End Sub)
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        If grd.Rows.Count = 0 Then
            Return
        End If
        Util.CopyDataGridView(grd)
        AutoClosingMessageBox.Show("すべての明細をコピーしました。", "情報")
    End Sub

#End Region


#Region "METHOD"

    Private Function search() As AsyncVoidMethodBuilder
        Dim srchDt As DataTable = DbHandler.executeSelect(getSqlAndParam())
        Dim dt As DataTable = createDt()

        Dim lastItemCd As String = ""
        Dim row As DataRow = Nothing
        Dim sumActQty As Integer = 0

        Dim conRemainQty As Integer = Util.obj2Integer(txtRemainQty.Text, -999)

        For Each srchRow As DataRow In srchDt.Rows

            If lastItemCd <> srchRow.Item("ITEMCD") OrElse lastItemCd = "" Then

                'If row IsNot Nothing AndAlso Util.obj2Integer(row.Item("SUMRemainQTY"), -999) <> conRemainQty Then
                '    dt.Rows.Remove(row)
                'End If

                row = dt.NewRow
                dt.Rows.Add(row)

                lastItemCd = srchRow.Item("ITEMCD")
                sumActQty = 0
                row.Item("ITEMCD") = srchRow.Item("ITEMCD")
                row.Item("SCODE") = srchRow.Item("SCODE")
                row.Item("ITEMNAME") = srchRow.Item("ITEMNAME")
                row.Item("SAFEQTY") = srchRow.Item("SAFEQTY")
                row.Item("SUMACTQTY") = 0
            End If


            row.Item("ACTQTY" + srchRow.Item("LOCATIONCD")) = srchRow.Item("ACTQTY")
            row.Item("RESERVTOTALQTY" + srchRow.Item("LOCATIONCD")) = srchRow.Item("RESERVTOTALQTY")
            If srchRow.Item("LOCATIONCD") = 0 Then
                ' 合計　引当数 = 他の津　引当数
                row.Item("SUMRESERVTOTALQTY") = srchRow.Item("RESERVTOTALQTY")
            End If
            row.Item("RemainQTY" + srchRow.Item("LOCATIONCD")) = srchRow.Item("RemainQTY")

            row.Item("SUMACTQTY") += Util.obj2Integer(srchRow.Item("ACTQTY"))
            row.Item("SUMRemainQTY") = row.Item("SUMACTQTY") - Util.obj2Integer(row.Item("SUMRESERVTOTALQTY"))
        Next

        'If row IsNot Nothing AndAlso Util.obj2Integer(row.Item("SUMRemainQTY"), -999) <> conRemainQty Then
        '    dt.Rows.Remove(row)
        'End If

        srchDt = Nothing

        If Util.isNumber(txtRemainQty.Text) Then
            For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                If dt.Rows(i).Item("SUMRemainQTY") <> txtRemainQty.Text Then
                    dt.Rows.RemoveAt(i)
                End If
            Next
        End If

        If grd.Parent Is Nothing Then
            Return Nothing
        End If
        'grd.Invoke(New SetDataSourceDelegate(AddressOf SetDataSource), grd, dt)
        grd.Invoke(Sub()
                       grd.DataSource = dt

                       For i As Integer = grd.DataSource.Rows.Count - 1 To 0 Step -1
                           'If Util.obj2Integer(grd.DataSource.Rows(i).Item("SUMRemainQTY")) <
                           '    Util.obj2Integer(grd.DataSource.Rows(i).Item("SAFEQTY")) Then

                           '    grd.Rows(i).DefaultCellStyle.BackColor = Color.IndianRed
                           'End If
                           If Me.chkWarning.Checked Then
                               If Util.obj2Integer(grd.DataSource.Rows(i).Item("SUMRemainQTY")) >=
                                   Util.obj2Integer(grd.DataSource.Rows(i).Item("SAFEQTY")) Then

                                   grd.DataSource.Rows(i).Delete
                               End If
                           End If
                           grd.Rows(i).Cells().Item("SUMACTQTY").Style.BackColor = Color.FromArgb(247, 241, 203)
                           grd.Rows(i).Cells().Item("SUMRESERVTOTALQTY").Style.BackColor = Color.FromArgb(247, 241, 203)
                           grd.Rows(i).Cells().Item("SUMRemainQTY").Style.BackColor = Color.FromArgb(247, 241, 203)
                       Next
                       bindingNavi.initBindingSource(dt.Rows.Count)
                   End Sub)

    End Function

    Private Function createDt() As DataTable

        If locationDt Is Nothing Then
            locationDt = CommonService.GetLocation(False)
        End If

        Dim dt As New DataTable
        dt.Columns.Add("ITEMCD", GetType(String))
        dt.Columns.Add("SCODE", GetType(String))
        dt.Columns.Add("ITEMNAME", GetType(String))
        dt.Columns.Add("SUMACTQTY", GetType(Integer))
        dt.Columns.Add("SUMRESERVTOTALQTY", GetType(Integer))
        dt.Columns.Add("SUMRemainQTY", GetType(Integer))

        For i As Integer = 0 To locationDt.Rows.Count - 1
            Dim r As DataRow = locationDt.Rows(i)
            dt.Columns.Add("ACTQTY" + r.Item("CODE"), GetType(Integer))
            dt.Columns.Add("RESERVTOTALQTY" + r.Item("CODE"), GetType(Integer))
            dt.Columns.Add("RemainQTY" + r.Item("CODE"), GetType(Integer))
        Next

        dt.Columns.Add("SAFEQTY", GetType(Integer))

        Return dt
    End Function

#End Region


#Region "SQL"

    Private Function getSqlAndParam（） As DbParamEnt

        Dim sb As New StringBuilder
        sb.Append(" SELECT ")
        sb.Append("     StockQty.* ")
        sb.Append(" FROM ")
        sb.Append(ViewManager.V_StockQty())
        sb.Append(" AS StockQty ") ' 必须起别名
        sb.Append(" WHERE ")
        sb.Append(" 1 = 1 ")

        Dim param As New List(Of SqlParameter)
        If Me.txtItemCd.Text <> "" Then
            sb.Append(" AND StockQty.ITEMCD Like @ITEMCD")
            param.Add(New SqlParameter("@ITEMCD", "%" & Me.txtItemCd.Text & "%"))
        End If
        If Me.txtItemNm.Text <> "" Then
            sb.Append(" AND StockQty.ITEMNAME Like @ITEMNAME")
            param.Add(New SqlParameter("@ITEMNAME", "%" & Me.txtItemNm.Text & "%"))
        End If
        If Me.txtSCode.Text <> "" Then
            sb.Append(" AND StockQty.SCODE Like @SCODE")
            param.Add(New SqlParameter("@SCODE", "%" & Me.txtSCode.Text & "%"))
        End If

        ' TODO: 倉庫  西京を除外
        sb.Append(" AND StockQty.LOCATIONCD <> 2 ")

        sb.Append(" ORDER BY ")
        sb.Append("     StockQty.ITEMCD ")
        sb.Append("    ,StockQty.LOCATIONCD ")

        Return New DbParamEnt(sb, param.ToArray)
    End Function

#End Region

End Class