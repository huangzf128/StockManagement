Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class FrmRanking

    Private Const SRCH_TYPE_SHOP = 0
    Private Const SRCH_TYPE_ITEM = 1
    Private Const SRCH_TYPE_STAYING = 2
    Private Const COL_NM_PREFIX = "_col_"

#Region "EVENT"
    Private Sub FrmRanking_Load(sender As Object, e As EventArgs) Handles Me.Load
        grd.CellBorderStyle = DataGridViewCellBorderStyle.Single

        dtPickerFrom.setDateTime(Now.AddMonths(-1 * Consts.DATA_INTERVAL))
        dtPickerTo.setDateTime(Now)

        initCombo()

        search()
    End Sub

    Private Sub initCombo()
        With cmbTenpo
            .Items.Add("AmazonDIYtools")
            .Items.Add("AmazonDIY倉庫")
            .Items.Add("AmazonGLMALL")
            .Items.Add("DIY倉庫")
            .Items.Add("YahooDIYtools")
            .Items.Add("YahooGLMALL")
            .Items.Add("YahooP-GeneratioN")
            .Items.Add("Yahooエターナルチャーム")
            .Items.Add("Yahooオートゲージジャパン")
            .Items.Add("Yahooマルビ")
            .Items.Add("auPayマーケット")
            .Items.Add("エターナルチャーム")
            .Items.Add("オートゲージジャパン")
            .Items.Add("メルカリアシスタント")
            .Items.Add("メルカリ昌隆")
            .Items.Add("ヤフオクDIYtools")
            .Items.Add("ヤフオクGLMALL")
            .Items.Add("ヤフオク丸美")
            .Items.Add("楽天GLMALL")
            .Items.Add("楽天ガジガジ")
            .Items.Add("承天貿易")
            .Items.Add("直販")
            .Items.Add("(株)フルクリエーション")
            .Items.Add("DISCOM")
            .Items.Add("オオトモ")
            .Items.Add("株式会社C&J")
            .Items.Add("株式会社創能")
            .Items.Add("興和貿易株式会社")
            .Items.Add("大友株式会社")
            .Items.Add("中哲商事株式会社")
        End With
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        If grd.Rows.Count = 0 Then
            Return
        End If
        Util.CopyDataGridView(grd)
        AutoClosingMessageBox.Show("すべての明細をコピーしました。", "情報")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        search()
    End Sub

    Private Sub btnStaying_Click(sender As Object, e As EventArgs) Handles btnStaying.Click

        If Util.isEmpty(Me.txtQtyMax.Text) Then
            Msg.warning("販売数上限を入力してください。", "入力エラー")
            Return
        End If

        ShowWaitForm()
        resetDataGridView()

        Async.Process(
            Function()
                Me.Invoke(Sub()
                              Dim srchDt As DataTable = DbHandler.executeSelect(getStayingSqlAndParam())
                              Dim dt As DataTable = editDataSource(srchDt)
                              grd.DataSource = dt
                              bindingNavi.initBindingSource(dt.Rows.Count)
                          End Sub)
            End Function,
            Sub()
                CloseLoadingForm()
            End Sub)
    End Sub

#End Region

    Private Function search() As AsyncVoidMethodBuilder

        ShowWaitForm()
        resetDataGridView()

        Async.Process(
            Function()
                Me.Invoke(Sub()
                              Dim srchDt As DataTable = DbHandler.executeSelect(getRankingSqlAndParam())
                              Dim dt As DataTable
                              If Me.txtItemCd.Text <> "" Then
                                  dt = editDataSourceItem(srchDt)
                                  grd.DataSource = dt
                              Else
                                  dt = editDataSource(srchDt)
                                  grd.DataSource = dt
                              End If
                              bindingNavi.initBindingSource(dt.Rows.Count)
                          End Sub)
            End Function,
            Sub()
                CloseLoadingForm()
            End Sub)

    End Function

    Private Sub resetDataGridView()

        grd.DataSource = Nothing

        For i As Integer = grd.Columns.Count - 1 To 0 Step -1
            If grd.Columns(i).DataPropertyName.StartsWith(COL_NM_PREFIX) Then

                grd.Columns.RemoveAt(i)

            ElseIf grd.Columns(i).Name <> "SumQTY" AndAlso
                    grd.Columns(i).Name <> "分類2" AndAlso
                    grd.Columns(i).Name <> "ITEMCD" Then

                grd.Columns(i).Visible = False
            End If
        Next
    End Sub

    Private Function editDataSourceItem(ByRef srchDt As DataTable) As DataTable

        grd.Columns.Item("SumQTY").Visible = True
        grd.Columns.Item("分類2").Visible = True
        grd.Columns.Item("ITEMCD").Visible = False

        Return srchDt
    End Function

    Private Function editDataSource(ByRef srchDt As DataTable) As DataTable
        Dim lastItemCd As String = ""
        Dim dt As DataTable = createDt()
        Dim row As DataRow = Nothing

        For i As Integer = 0 To srchDt.Rows.Count - 1
            Dim srchRow As DataRow = srchDt.Rows(i)

            If lastItemCd <> srchRow.Item("ITEMCD") OrElse lastItemCd = "" Then
                row = dt.NewRow
                dt.Rows.Add(row)

                lastItemCd = srchRow.Item("ITEMCD")

                row.Item("ITEMCD") = srchRow.Item("ITEMCD")
                row.Item("SumSumQTY") = srchRow.Item("SumSumQTY")
            End If

            Dim colNm As String = If(IsDBNull(srchRow.Item("分類2")), "", srchRow.Item("分類2"))
            If Util.isEmpty(colNm) Then
                Continue For
            End If

            colNm = COL_NM_PREFIX & colNm
            If Not dt.Columns.Contains(colNm) Then
                dt.Columns.Add(colNm, GetType(Integer))
                row.Item(colNm) = srchRow.Item("SumQTY")
                grd.Columns.Add(colNm, colNm)
                Dim col As DataGridViewColumn = grd.Columns(colNm)

                col.HeaderText = colNm.Replace(COL_NM_PREFIX, "")
                col.DataPropertyName = colNm
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopLeft
            Else
                row.Item(colNm) = srchRow.Item("SumQTY")
            End If

        Next

        grd.Columns.Item("SumQTY").Visible = False
        grd.Columns.Item("分類2").Visible = False
        grd.Columns.Item("ITEMCD").Visible = True
        grd.Columns.Item("SumSumQTY").Visible = True
        Return dt
    End Function

    Private Function createDt() As DataTable

        Dim dt As New DataTable
        dt.Columns.Add("ITEMCD", GetType(String))
        dt.Columns.Add("SumSumQTY", GetType(String))
        Return dt
    End Function

#Region "SQL"

    Private Function getStayingSqlAndParam() As DbParamEnt

        Dim dbParamEnt As DbParamEnt = getRankingSqlAndParam()
        Dim sbR As StringBuilder = dbParamEnt.sbSql

        Dim sb As New StringBuilder
        Dim param As List(Of SqlParameter) = dbParamEnt.parameters.ToList

        sb.Append(" SELECT * FROM (")
        sb.Append(sbR)
        sb.Append(" Union All ")

        sb.Append(" SELECT ")
        sb.Append("   '' AS 分類2 ")
        sb.Append("  ,M.ITEMCD ")
        sb.Append("  ,0 AS SumQTY ")
        sb.Append("  ,0 AS SumSumQTY ")
        sb.Append(" FROM ")
        sb.Append("     M_Item M")
        sb.Append(" WHERE ")
        sb.Append("   NOT EXISTS (")
        sb.Append("     SELECT 1")
        sb.Append("     FROM T_StockHistory T ")
        sb.Append("     WHERE T.ITEMCD = M.ITEMCD ")
        sb.Append("       AND T.IOKBN =  'O' ")
        If dtPickerFrom.getDateTime <> "" Then
            sb.Append(" AND T.CRTDT >= @CRTDTFROM ")
            param.Add(New SqlParameter("@CRTDTFROM", dtPickerFrom.getDateTime))
        End If
        If dtPickerTo.getDateTime <> "" Then
            sb.Append(" AND T.CRTDT <= @CRTDTTO ")
            param.Add(New SqlParameter("@CRTDTTO", dtPickerTo.getDateTime))
        End If
        sb.Append(" ) ")
        If Me.txtItemCd.Text <> "" Then
            sb.Append(" AND M.ITEMCD Like @ITEMCD")
        End If
        sb.Append(" ) T ")
        sb.Append(" WHERE T.SumSumQTY <= 5 ")
        sb.Append(" ORDER BY ")
        sb.Append("     T.SumSumQTY DESC, T.ITEMCD, T.分類2 ")

        Return New DbParamEnt(sb, param.ToArray)
    End Function

    Private Function getRankingSqlAndParam() As DbParamEnt

        Dim sb As New StringBuilder
        Dim param As New List(Of SqlParameter)

        sb.Append(" SELECT ")
        sb.Append("   T1.分類2 ")
        sb.Append("  ,T3.ITEMCD ")
        sb.Append("  ,Sum(T2.数量*T3.QTY) AS SumQTY")
        sb.Append("  ,Sum(Sum(T2.数量*T3.QTY)) OVER(PARTITION BY T3.ITEMCD) AS SumSumQTY")
        sb.Append(" FROM JPONDATA.dbo.ORDERDAT T1 ")
        sb.Append(" LEFT JOIN [JPONDATA].[dbo].RECVDAT T2 ")
        sb.Append("  ON T1.ID = T2.ID ")
        sb.Append(" LEFT JOIN M_ConvItem T3 ")
        sb.Append("  ON T2.商品CODE = T3.ORDERITEMCD ")
        sb.Append(" WHERE ")
        sb.Append("     T1.状況='確定' ")
        sb.Append(" And T1.分類2 Is Not Null ")
        sb.Append(" And T3.ITEMCD Is Not Null ")
        If dtPickerFrom.getDateTime <> "" Then
            sb.Append(" AND T1.OrderDate >= @ORDERFROM ")
            param.Add(New SqlParameter("@ORDERFROM", dtPickerFrom.getDateTime))
        End If
        If dtPickerTo.getDateTime <> "" Then
            sb.Append(" AND T1.OrderDate <= @ORDERTO ")
            param.Add(New SqlParameter("@ORDERTO", dtPickerTo.getDateTime))
        End If
        If Not Util.isEmpty(Me.txtItemCd.Text) Then
            sb.Append(" AND T3.ITEMCD Like @ITEMCD")
            param.Add(New SqlParameter("@ITEMCD", "%" & Me.txtItemCd.Text & "%"))
        End If
        If Not Util.isEmpty(cmbTenpo.Text) Then
            sb.Append(" AND T1.分類2 Like @分類2")
            param.Add(New SqlParameter("@分類2", Me.cmbTenpo.Text & "%"))
        End If
        sb.Append(" GROUP BY ")
        sb.Append("  T3.ITEMCD")
        sb.Append(" ,T1.分類2 ")

        sb.Append(" Union All ")
        sb.Append(" SELECT ")
        sb.Append("   T1.ORDERKBN As 分類2 ")
        sb.Append("  ,T1.ITEMCD ")
        sb.Append("  ,Sum(T1.RESERVQTY) As SumQTY ")
        sb.Append("  ,Sum(Sum(T1.RESERVQTY)) OVER(PARTITION BY T1.ITEMCD) AS SumSumQTY")
        sb.Append(" FROM T_StockReserv T1 ")
        sb.Append(" WHERE  ")
        sb.Append("    T1.ORDERSTATUS = 3")
        If dtPickerFrom.getDateTime <> "" Then
            sb.Append(" AND T1.CRTDT >= @ORDERFROM ")
        End If
        If dtPickerTo.getDateTime <> "" Then
            sb.Append(" AND T1.CRTDT <= @ORDERTO ")
        End If
        If Not Util.isEmpty(Me.txtItemCd.Text) Then
            sb.Append(" AND T1.ITEMCD Like @ITEMCD")
        End If
        If Not Util.isEmpty(cmbTenpo.Text) Then
            sb.Append(" AND T1.ORDERKBN Like @ORDERKBN")
            param.Add(New SqlParameter("@ORDERKBN", Me.cmbTenpo.Text & "%"))
        End If
        sb.Append(" GROUP BY ")
        sb.Append("  T1.ITEMCD")
        sb.Append(" ,T1.ORDERKBN ")

        sb.Append(" ORDER BY ")
        sb.Append("     SumSumQTY DESC, ITEMCD, 分類2 ")
        sb.Append(" OFFSET 0 ROWS ")

        Return New DbParamEnt(sb, param.ToArray)
    End Function
#End Region


End Class