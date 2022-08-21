Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class frmRanking

    ' 検索ボタンクリック時処理（店舗毎）
    Private Sub cmdExec1_Click(sender As Object, e As EventArgs) Handles cmdExec1.Click
        Dim Cmd As New OleDb.OleDbCommand
        Dim Dta As New OleDb.OleDbDataAdapter
        Dim Dts As New DataSet
        Dim strSql As String
        Dim strWhere1 As String = ""
        Dim strWhere2 As String = ""
        Dim strWhere3 As String = ""
        Dim strDateFrom As String
        Dim strDateTo As String

        strDateFrom = dateFrom1.Value.ToString("yyyy/MM/dd")
        If Cm.Nz(strDateFrom, "") <> "" Then
            strWhere1 = "And OrderDate >= '" & strDateFrom & "' "
            strWhere3 = "And CRTDT >= '" & strDateFrom & "' "
        End If
        strDateTo = dateTo1.Value.ToString("yyyy/MM/dd")
        If Cm.Nz(strDateTo, "") <> "" Then
            strWhere1 = strWhere1 & "And OrderDate <= '" & strDateTo & "' "
            strWhere3 = strWhere3 & "And CRTDT <= '" & strDateTo & "' "
        End If
        If Cm.Nz(txtItemCd.Text, "") <> "" Then
            strWhere2 = "And [ITEMCD] Like '%" & txtItemCd.Text & "%' "
        End If

        strSql = "SELECT T1.分類2, T3.ITEMCD, Sum(T2.数量*T3.QTY) AS SumQTY " &
                 "FROM (SELECT ID, 分類2 FROM JPONDATA.dbo.ORDERDAT WHERE 状況='確定' And 分類2 Is Not Null " & strWhere1 & ") AS T1 " &
                 "LEFT JOIN (SELECT ID, 商品CODE, 数量 FROM JPONDATA.dbo.RECVDAT WHERE ID Is Not Null) AS T2 " &
                 "ON T1.ID=T2.ID " &
                 "LEFT JOIN dbo.M_ConvItem AS T3 " &
                 "ON T2.商品CODE=T3.ORDERITEMCD " &
                 "GROUP BY T3.ITEMCD, T1.分類2 " &
                 "HAVING T3.ITEMCD Is Not Null " & strWhere2 &
                 "Union All " &
                 "Select T1.ORDERKBN As 分類2, T1.ITEMCD, Sum(T1.RESERVQTY) As SumQTY " &
                 "From (Select ORDERKBN, ITEMCD, RESERVQTY From dbo.T_StockReserv " &
                 "Where ORDERSTATUS = 3 " & strWhere2 & strWhere3 & " ) As T1 " &
                 "Group By T1.ORDERKBN, T1.ITEMCD;"

        Cmd.Connection = Cm.Conn
        Cmd.CommandText = strSql
        Dta.SelectCommand = Cmd
        Dta.Fill(Dts)

        dgOrderShopRanking.DataSource = Dts
        dgOrderShopRanking.Refresh()

    End Sub

    ' 検索ボタンクリック時処理（期間毎）
    Private Sub cmdExec2_Click(sender As Object, e As EventArgs) Handles cmdExec2.Click
        Dim Cmd As New OleDb.OleDbCommand
        Dim Dta As New OleDb.OleDbDataAdapter
        Dim Dts As New DataSet
        Dim strSql As String
        Dim strWhere1 As String
        Dim strWhere2 As String
        strWhere1 = ""
        strWhere2 = ""

        If Cm.Nz(dateFrom2.Value, "") <> "" Then
            strWhere1 = "And OrderDate >= '" & dateFrom2.Value & "' "
            strWhere2 = "And CRTDT >= '" & dateFrom2.Value & "' "
        End If
        If Cm.Nz(dateTo2.Value, "") <> "" Then
            strWhere1 = strWhere1 & "And OrderDate <= '" & dateTo2.Value & "' "
            strWhere2 = strWhere2 & "And CRTDT <= '" & dateTo2.Value & "' "
        End If
        If Cm.Nz(cboShop.SelectedValue, "") <> "" Then
            strWhere1 = strWhere1 & "And 分類2 = '" & cboShop.SelectedValue & "' "
            strWhere2 = strWhere2 & "And ORDERKBN = '" & cboShop.SelectedValue & "' "
        End If

        strSql = "SELECT T1.分類2, T3.ITEMCD, Sum(T2.数量*T3.QTY) AS SumQTY " &
                 "FROM (SELECT ID, 分類2 FROM JPONDATA.dbo.ORDERDAT WHERE 状況='確定' " & strWhere1 & ") AS T1 " &
                 "LEFT JOIN (SELECT ID, 商品CODE, 数量 FROM JPONDATA.dbo.RECVDAT WHERE ID Is Not Null) AS T2 " &
                 "ON T1.ID=T2.ID " &
                 "LEFT JOIN dbo.M_ConvItem AS T3 " &
                 "ON T2.商品CODE=T3.ORDERITEMCD " &
                 "GROUP BY T3.ITEMCD, T1.分類2 " &
                 "HAVING T3.ITEMCD Is Not Null " &
                 "Union All " &
                 "Select T1.ORDERKBN As 分類2, T1.ITEMCD, Sum(T1.RESERVQTY) As SumQTY " &
                 "From (Select ORDERKBN, ITEMCD, RESERVQTY From dbo.T_StockReserv " &
                 "Where ORDERSTATUS = 3 " & strWhere2 & " ) As T1 " &
                 "Group By T1.ORDERKBN, T1.ITEMCD;"

        Cmd.Connection = Cm.Conn
        Cmd.CommandText = strSql
        Dta.SelectCommand = Cmd
        Dta.Fill(Dts)

        dgOrderRanking.DataSource = Dts
        dgOrderRanking.Refresh()

    End Sub



    ' 商品検索ボタン押下時イベント
    Private Sub cmdSearch_Click()
        Cm.StrSearchItemCd = Cm.Nz(txtItemCd.Text, "")
        Cm.StrSearchItemFormName = Me.Name
        frmItemSearch.ShowDialog()
    End Sub

    ' フォームロード時イベント
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Cmd As New OleDb.OleDbCommand
        Dim Dta As New OleDb.OleDbDataAdapter
        Dim Dts As New DataSet
        Dim strSql As String

        strSql = "SELECT T1.分類2, T3.ITEMCD, Sum(T2.数量*T3.QTY) AS SumQTY " &
                 "FROM (SELECT ID, 分類2 FROM JPONDATA.dbo.ORDERDAT WHERE 状況='確定' And 分類2 Is Not Null And OrderDate >= DATEADD(day,-30,GETDATE())) AS T1 " &
                 "LEFT JOIN (SELECT ID, 商品CODE, 数量 FROM JPONDATA.dbo.RECVDAT WHERE ID Is Not Null) AS T2 " &
                 "ON T1.ID=T2.ID " &
                 "LEFT JOIN dbo.M_ConvItem AS T3 " &
                 "ON T2.商品CODE=T3.ORDERITEMCD " &
                 "GROUP BY T3.ITEMCD, T1.分類2 " &
                 "HAVING T3.ITEMCD Is Not Null " &
                 "Union All " &
                 "Select T1.ORDERKBN As 分類2, T1.ITEMCD, Sum(T1.RESERVQTY) As SumQTY " &
                 "From (Select ORDERKBN, ITEMCD, RESERVQTY From dbo.T_StockReserv " &
                 "Where ORDERSTATUS = 3 And CRTDT >= DATEADD(day,-30,GETDATE())) As T1 " &
                 "Group By T1.ORDERKBN, T1.ITEMCD;"

        Cmd.Connection = Cm.Conn
        Cmd.CommandText = strSql
        Dta.SelectCommand = Cmd
        Dta.Fill(Dts)

        dgOrderShopRanking.DataSource = Dts
        dgOrderShopRanking.Refresh()

        dateFrom1.Value = Format(DateAdd("d", -30, Now()), "yyyy/mm/dd")
        dateFrom2.Value = Format(DateAdd("d", -30, Now()), "yyyy/mm/dd")

        dgOrderShopRanking.Select()
        dgOrderShopRanking.ReadOnly = True

    End Sub

    ' TODO：DataGridを使用するため必要なくなりそう
    '    Private Sub DispShopRanking()
    '        Dim i As Integer
    '        Dim RS As DAO.Recordset

    '    Set RS = CurrentDb.QueryDefs("Q_OrderShopRanking").OpenRecordset
    '    For i = 2 To RS.Fields.Count - 1
    '            S_OrderShopRanking.Form.Controls("lbl" & i - 1).Caption = RS(i).Name
    '            S_OrderShopRanking.Form.Controls("lbl" & i - 1).Visible = True
    '            S_OrderShopRanking.Form.Controls("txt" & i - 1).ControlSource = RS(i).Name
    '            S_OrderShopRanking.Form.Controls("txt" & i - 1).Visible = True
    '        Next
    '        For i = RS.Fields.Count To 41
    '            S_OrderShopRanking.Form.Controls("lbl" & i - 1).Caption = ""
    '            S_OrderShopRanking.Form.Controls("lbl" & i - 1).Visible = False
    '            S_OrderShopRanking.Form.Controls("txt" & i - 1).ControlSource = ""
    '            S_OrderShopRanking.Form.Controls("txt" & i - 1).Visible = False
    '        Next

    '    Set RS = Nothing
    'End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click

    End Sub

    Private Sub tabShop_Click(sender As Object, e As EventArgs) Handles tabShop.Click

    End Sub
End Class