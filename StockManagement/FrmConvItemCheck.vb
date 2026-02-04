Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Text

''' <summary>
''' 商品変換マスタチェック
''' </summary>
Public Class FrmConvItemCheck

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
        grd.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        grd.CellBorderStyle = DataGridViewCellBorderStyle.Single
        grd.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grd.RowTemplate.DefaultCellStyle.Padding = New Padding(0, 2, 0, 2)

    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs)

        ShowWaitForm()
        Async.Process(
            AddressOf search,
            Sub()
                CloseLoadingForm()
            End Sub)
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs)
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

        Dim row As DataRow = Nothing

        For Each srchRow As DataRow In srchDt.Rows

            row = dt.NewRow
            dt.Rows.Add(row)

            row.Item("ITEMCD") = srchRow.Item("ITEMCD")
            row.Item("MSG") = srchRow.Item("MSG")
            row.Item("ORDERDATE") = srchRow.Item("ORDERDATE")
        Next

        srchDt = Nothing

        If grd.Parent Is Nothing Then
            Return Nothing
        End If

        grd.Invoke(Sub()
                       grd.DataSource = dt
                       bindingNavi.initBindingSource(dt.Rows.Count)
                   End Sub)

    End Function

    Private Function createDt() As DataTable

        If locationDt Is Nothing Then
            locationDt = CommonService.GetLocation(False)
        End If

        Dim dt As New DataTable
        dt.Columns.Add("ITEMCD", GetType(String))
        dt.Columns.Add("MSG", GetType(String))
        dt.Columns.Add("ORDERDATE", GetType(String))

        Return dt
    End Function

#End Region


#Region "SQL"

    Private Function getSqlAndParam（） As DbParamEnt

        Dim sb As New StringBuilder
        sb.Append(" SELECT DISTINCT ")
        sb.Append("      RECVDAT.商品CODE AS ITEMCD, ")
        sb.Append("     '【変換商品マスタ未登録】受注ID ' + CAST(ORDERDAT.ID AS VARCHAR) + ' の引当がスキップされました。' AS MSG, ")
        sb.Append("     ORDERDAT.OrderDate AS ORDERDATE")
        sb.Append(" FROM ")
        sb.Append("     JPONDATA.dbo.ORDERDAT AS ORDERDAT ")
        sb.Append(" INNER JOIN ")
        sb.Append("     JPONDATA.dbo.RECVDAT AS RECVDAT ON ORDERDAT.ID = RECVDAT.ID ")
        sb.Append(" LEFT JOIN ")
        sb.Append("     dbo.M_ConvItem AS M_ConvItem ON RECVDAT.商品CODE = M_ConvItem.ORDERITEMCD ")
        sb.Append(" LEFT JOIN ")
        sb.Append("     dbo.T_StockReserv AS T_SR ON ORDERDAT.ID = T_SR.ORDERID ")
        sb.Append(" WHERE ")
        sb.Append("     ORDERDAT.状況 IN ('確定', '完了後クレカ待ち', '欠品連絡中', '入金待ち', '入金不足') ")
        ' 这里建议使用参数化，或者保持 DateAdd 的写法
        sb.Append("     AND ORDERDAT.OrderDate > DATEADD(day, -90, GETDATE()) ")
        sb.Append("     AND M_ConvItem.ITEMCD IS NULL ")
        sb.Append("     AND T_SR.ORDERID IS NULL ")
        sb.Append(" ORDER BY ")
        sb.Append("     ORDERDATE DESC ")

        Dim param As New List(Of SqlParameter)
        Return New DbParamEnt(sb, param.ToArray)
    End Function

#End Region

End Class