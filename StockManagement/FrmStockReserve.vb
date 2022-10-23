Public Class FrmStockReserve

    Dim Q_RefStockReserv As String = "Select Case dbo_T_StockReserv.CRTDT, dbo_T_StockReserv.DELFLG, dbo_T_StockReserv.ORDERSTATUS, dbo_T_StockReserv.ITEMCD, dbo_T_StockReserv.RESERVQTY, dbo_T_StockReserv.ORDERKBN, dbo_T_StockReserv.ORDERID, dbo_T_StockReserv.CUSTID, dbo_T_StockReserv.ORDERDT, dbo_T_StockReserv.INCHARGE, dbo_T_StockReserv.CUSTNAME, dbo_T_StockReserv.TELNO, dbo_T_StockReserv.ZIPCODE, dbo_T_StockReserv.SENDADD1, dbo_T_StockReserv.SENDADD2, dbo_T_StockReserv.DLVCOMPANY, dbo_T_StockReserv.DLVSLIPNO, CODE1.VALUE1 As DELFLGNM, CODE2.VALUE1 As ORDERSTATUSNM, ORDERDAT.[状況] As ORDSTATUS, ORDERDAT.[発送日] As ORDDLVDT
FROM((dbo_T_StockReserv LEFT JOIN (SELECT CODE, VALUE1 FROM dbo_M_Code WHERE CATEGORY='RESERVDEL')  AS CODE1 ON dbo_T_StockReserv.DELFLG=Val(CODE1.CODE)) LEFT JOIN (SELECT CODE, VALUE1 FROM dbo_M_Code WHERE CATEGORY='RESERVODST')  AS CODE2 ON dbo_T_StockReserv.ORDERSTATUS=Val(CODE2.CODE)) LEFT JOIN (SELECT ID, 状況, 発送日 FROM dbo_ORDERDAT WHERE OrderDate>#1/1/2018#)  AS ORDERDAT ON dbo_T_StockReserv.ORDERID=ORDERDAT.ID"

    Private Sub cmdClose_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    ' 検索ボタンクリック時イベント
    'Private Sub cmdView_Click(sender As Object, e As EventArgs) Handles cmdView.Click
    '    Dim Cmd As New OleDb.OleDbCommand
    '    Dim Dta As New OleDb.OleDbDataAdapter
    '    Dim Dts As New DataSet
    '    Dim strWhere As String = ""
    '    Dim strDateFrom As String = ""
    '    Dim strDateTo As String = ""

    '    strDateFrom = dateFrom.ToString("yyyy/MM/dd")
    '    If Cm.Nz(strDateFrom, "") <> "" Then
    '        strWhere = strWhere & " Where CRTDT >= #" & strDateFrom & " " & cboHourFrom.SelectedText & ":" & cboMinFrom.SelectedText & ":00# "
    '    End If
    '    strDateTo = dateTo.ToString("yyyy/MM/dd")
    '    If Cm.Nz(strDateTo, "") <> "" Then
    '        strWhere = strWhere & IIf(strWhere = "", " Where ", " And ") & "CRTDT <= #" & strDateTo & " " & cboHourTo.SelectedText & ":" & cboMinTo.SelectedText & ":00# "
    '    End If

    '    If Cm.Nz(txtItemCd.Text, "") <> "" Then
    '        strWhere = strWhere & IIf(strWhere = "", " Where ", " And ") & "ITEMCD Like '*" & txtItemCd.Text & "*' "
    '    End If
    '    If chkValid.Checked Then
    '        strWhere = strWhere & IIf(strWhere = "", " Where ", " And ") & "DELFLG = 0 "
    '    End If
    '    If Cm.Nz(cboOrdStatus.SelectedText, "") <> "" Then
    '        strWhere = strWhere & IIf(strWhere = "", " Where ", " And ") & "ORDSTATUS = '" & cboOrdStatus.SelectedText & "' "
    '    End If

    '    ' 初期表示状態
    '    Cmd.Connection = Cm.Conn
    '    Cmd.CommandText = "Select * From (" & Q_RefStockReserv & ") " & strWhere
    '    Dta.Fill(Dts)

    '    dgStockReserv.DataSource = Dts
    '    dgStockReserv.Refresh()


    'End Sub

    'Private Sub frmStockReserv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Dim Cmd As New OleDb.OleDbCommand
    '    Dim Dta As New OleDb.OleDbDataAdapter
    '    Dim Dts As New DataSet

    '    chkValid.Checked = True
    '    cboHourFrom.SelectedText = "08"
    '    cboMinFrom.SelectedText = "00"
    '    Select Case Hour(Now)
    '        Case 0, 1, 2, 3, 4, 5, 6
    '            cboHourTo.SelectedText = "08"
    '        Case 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18
    '            cboHourTo.SelectedText = Strings.Right("0" & Hour(Now) + 1, 2)
    '        Case 19, 20, 21, 22
    '            cboHourTo.SelectedText = "19"
    '    End Select
    '    cboMinTo.SelectedText = "00"

    '    Cmd.Connection = Cm.Conn
    '    Cmd.CommandText = "Select * From (" & Q_RefStockReserv & ") T Where T.DELFLG = 0"
    '    Dta.SelectCommand = Cmd
    '    Dta.Fill(Dts)

    '    dgStockReserv.DataSource = Dts
    '    dgStockReserv.Refresh()

    '    dgStockReserv.Select()
    '    dgStockReserv.ReadOnly = True

    'End Sub

End Class