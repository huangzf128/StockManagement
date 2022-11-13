Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.SqlServer.Server

Public Class FrmStockList

    Private locationDt As DataTable = Nothing

#Region "EVENT"


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        ShowWaitForm()

        Async.Process(
            AddressOf search,
            Sub()
                CloseForm()
            End Sub)
    End Sub


    Private Sub FrmStockList_Load(sender As Object, e As EventArgs) Handles Me.Load
        grd.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        grd.CellBorderStyle = DataGridViewCellBorderStyle.Single
        grd.RowTemplate.DefaultCellStyle.Padding = New Padding(0, 2, 0, 2)

        ShowWaitForm()

        Async.Process(
            AddressOf search,
            Sub()
                CloseForm()
            End Sub)
    End Sub

    Private Sub grd_Paint(sender As Object, e As PaintEventArgs) Handles grd.Paint

        If locationDt Is Nothing Then
            locationDt = DbHandler.executeSelect(getSqlAndParamLocation())
            For i As Integer = 1 To locationDt.Rows.Count - 1
                Dim r As DataRow = locationDt.Rows(i)
                grd.Columns.Add("ACTQTY" + r.Item("CODE"), r.Item("LOCATIONNM") + vbCrLf + vbCrLf + "実")
                Dim col As DataGridViewColumn = grd.Columns("ACTQTY" + r.Item("CODE"))
                col.Width = 50
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
                col.DataPropertyName = "ACTQTY" + r.Item("CODE")
                col.SortMode = DataGridViewColumnSortMode.NotSortable
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Next
        End If

        Dim location As String() = {"合計", locationDt.Rows(0).Item("LOCATIONNM")}

        For j As Integer = 4 To 7
            Dim r1 As Rectangle = grd.GetCellDisplayRectangle(j, -1, True)
            Dim w2 As Integer = grd.GetCellDisplayRectangle(j + 1, -1, True).Width
            Dim w3 As Integer = grd.GetCellDisplayRectangle(j + 2, -1, True).Width
            r1.X = r1.X + 1
            r1.Y = r1.Y + 1
            r1.Width = r1.Width + w2 + w3 - 2
            r1.Height = r1.Height / 2 - 2

            e.Graphics.FillRectangle(New SolidBrush(grd.ColumnHeadersDefaultCellStyle.BackColor), r1)
            Dim format As New StringFormat
            format.Alignment = StringAlignment.Center
            format.LineAlignment = StringAlignment.Center

            e.Graphics.DrawString(location((j - 4) \ 2),
                                  grd.ColumnHeadersDefaultCellStyle.Font,
                                  New SolidBrush(grd.ColumnHeadersDefaultCellStyle.ForeColor), r1, format)
            j = j + 2
        Next

    End Sub

    Private Sub grd_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles grd.CellPainting

        'If e.RowIndex = -1 AndAlso e.ColumnIndex > -1 Then
        '    Dim r2 As Rectangle = e.CellBounds
        '    r2.Height = e.CellBounds.Height / 2
        '    e.PaintBackground(r2, True)
        '    e.PaintContent(r2)
        '    e.Handled = True
        'End If
    End Sub

#End Region


    Private Function search() As AsyncVoidMethodBuilder
        Dim srchDt As DataTable = DbHandler.executeSelect(getSqlAndParam())
        Dim dt As DataTable = createDt()

        Dim lastItemCd As String = ""
        Dim row As DataRow = Nothing
        Dim sumActQty As Integer = 0

        For Each srchRow As DataRow In srchDt.Rows

            If lastItemCd <> srchRow.Item("ITEMCD") Then
                If lastItemCd <> "" Then
                    row.Item("SUMACTQTY") = sumActQty

                    row.Item("SUMRemainQTY") = sumActQty - Util.obj2Integer(row.Item("SUMRESERVTOTALQTY"))
                    dt.Rows.Add(row)
                End If

                lastItemCd = srchRow.Item("ITEMCD")

                row = dt.NewRow
                sumActQty = 0
                row.Item("ITEMCD") = srchRow.Item("ITEMCD")
                row.Item("SCODE") = srchRow.Item("SCODE")
                row.Item("ITEMNAME") = srchRow.Item("ITEMNAME")
                row.Item("SAFEQTY") = srchRow.Item("SAFEQTY")
            End If

            sumActQty += Util.obj2Integer(srchRow.Item("ACTQTY"))
            row.Item("ACTQTY" + srchRow.Item("LOCATIONCD")) = srchRow.Item("ACTQTY")
            row.Item("RESERVTOTALQTY" + srchRow.Item("LOCATIONCD")) = srchRow.Item("RESERVTOTALQTY")
            If srchRow.Item("LOCATIONCD") = 0 Then
                row.Item("SUMRESERVTOTALQTY") = srchRow.Item("RESERVTOTALQTY")
            End If
            row.Item("RemainQTY" + srchRow.Item("LOCATIONCD")) = srchRow.Item("RemainQTY")
        Next

        grd.Invoke(New SetDataSourceDelegate(AddressOf SetDataSource), grd, dt)
        grd.Invoke(Sub()
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
                           grd.Rows(i).Cells().Item("ACTQTY0").Style.BackColor = Color.FromArgb(247, 241, 203)
                           grd.Rows(i).Cells().Item("RESERVTOTALQTY0").Style.BackColor = Color.FromArgb(247, 241, 203)
                           grd.Rows(i).Cells().Item("RemainQTY0").Style.BackColor = Color.FromArgb(247, 241, 203)
                       Next
                   End Sub)

    End Function

    Private Function createDt() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("ITEMCD", GetType(String))
        dt.Columns.Add("SCODE", GetType(String))
        dt.Columns.Add("ITEMNAME", GetType(String))
        dt.Columns.Add("SUMACTQTY", GetType(String))
        dt.Columns.Add("SUMRESERVTOTALQTY", GetType(String))
        dt.Columns.Add("SUMRemainQTY", GetType(String))

        For i As Integer = 0 To locationDt.Rows.Count - 1
            Dim r As DataRow = locationDt.Rows(i)
            dt.Columns.Add("ACTQTY" + r.Item("CODE"), GetType(String))
            dt.Columns.Add("RESERVTOTALQTY" + r.Item("CODE"), GetType(String))
            dt.Columns.Add("RemainQTY" + r.Item("CODE"), GetType(String))
        Next

        dt.Columns.Add("SAFEQTY", GetType(String))

        Return dt
    End Function

    Private Function getSqlAndParamLocation() As DbParamEnt

        Dim sb As New StringBuilder
        sb.Append(" SELECT ")
        sb.Append("     CODE ")
        sb.Append("    ,M.VALUE1 AS LOCATIONNM ")
        sb.Append(" ")
        sb.Append(" FROM M_Code M ")
        sb.Append(" WHERE ")
        sb.Append("     CATEGORY = 'LOCATIONCD' ")
        sb.Append(" ORDER BY ")
        sb.Append("     CODE ")

        Return New DbParamEnt(sb, Nothing)
    End Function

    Private Function getSqlAndParam() As DbParamEnt

        Dim sb As New StringBuilder
        sb.Append(" SELECT ")
        sb.Append("     * ")
        sb.Append(" ")
        sb.Append(" FROM V_StockQty ")
        sb.Append(" WHERE ")
        sb.Append(" 1 = 1 ")

        Dim param As New List(Of SqlParameter)
        If Me.txtItemCd.Text <> "" Then
            sb.Append(" AND ITEMCD Like @ITEMCD")
            param.Add(New SqlParameter("@ITEMCD", "%" & Me.txtItemCd.Text & "%"))
        End If
        If Me.txtItemNm.Text <> "" Then
            sb.Append(" AND ITEMNAME Like @ITEMNAME")
            param.Add(New SqlParameter("@ITEMNAME", "%" & Me.txtItemNm.Text & "%"))
        End If

        sb.Append(" ORDER BY ")
        sb.Append("     ITEMCD ")
        sb.Append("    ,LOCATIONCD ")

        Return New DbParamEnt(sb, param.ToArray)
    End Function

End Class