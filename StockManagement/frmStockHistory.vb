Public Class FrmStockHistory

    Dim Q_RefStockHistory As String = "SELECT dbo_T_StockHistory.CRTDT, dbo_T_StockHistory.ITEMCD, dbo_T_StockHistory.LOCATIONCD, dbo_T_StockHistory.IOKBN, dbo_T_StockHistory.QTY, dbo_T_StockHistory.REMARKS, dbo_T_StockHistory.UPDIP, CODE1.VALUE1 AS LOCATIONNM, CODE2.VALUE1 AS IOKBNNM
FROM (dbo_T_StockHistory LEFT JOIN (SELECT CODE, VALUE1 FROM dbo_M_Code WHERE CATEGORY='LOCATIONCD')  AS CODE1 ON dbo_T_StockHistory.LOCATIONCD=CODE1.CODE) LEFT JOIN (SELECT CODE, VALUE1 FROM dbo_M_Code WHERE CATEGORY='IOKBN')  AS CODE2 ON dbo_T_StockHistory.IOKBN=CODE2.CODE;"

    'Private Sub chkIn_Click(sender As Object, e As EventArgs) Handles chkIn.Click
    '    If chkIn.Checked And chkOut.Checked Then
    '        chkOut.Checked = False
    '    End If
    'End Sub

    'Private Sub chkOut_Click(sender As Object, e As EventArgs) Handles chkOut.Click
    '    If chkIn.Checked And chkOut.Checked Then
    '        chkIn.Checked = False
    '    End If
    'End Sub

    'Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
    '    Close()
    'End Sub

    '' 検索ボタンクリック時イベント
    'Private Sub cmdView_Click(sender As Object, e As EventArgs) Handles cmdView.Click
    '    Dim Cmd As New OleDb.OleDbCommand
    '    Dim Dta As New OleDb.OleDbDataAdapter
    '    Dim Dts As New DataSet
    '    Dim strWhere As String = ""
    '    Dim strDateFrom As String = ""
    '    Dim strDateTo As String = ""

    '    strDateFrom = dateFrom.ToString("yyyy/MM/dd")
    '    If Cm.Nz(strDateFrom, "") <> "" Then
    '        strWhere = strWhere & IIf(strWhere = "", "Where", "And") & " CRTDT >= #" & dateFrom.Text & " " & cboHourFrom.SelectedText & ":" & cboMinFrom.SelectedText & ":00# "
    '    End If
    '    strDateTo = dateTo.ToString("yyyy/MM/dd")
    '    If Cm.Nz(strDateTo, "") <> "" Then
    '        strWhere = strWhere & IIf(strWhere = "", "Where", "And") & " CRTDT <= #" & dateTo.Text & " " & cboHourTo.SelectedText & ":" & cboMinTo.SelectedText & ":00# "
    '    End If

    '    If Cm.Nz(txtItemCd.Text, "") <> "" Then
    '        strWhere = strWhere & IIf(strWhere = "", "Where", "And") & " ITEMCD Like '*" & txtItemCd.Text & "*' "
    '    End If
    '    If chkIn.Checked Then
    '        strWhere = strWhere & IIf(strWhere = "", "Where", "And") & " IOKBN = 'I' "
    '    End If
    '    If chkOut.Checked Then
    '        strWhere = strWhere & IIf(strWhere = "", "Where", "And") & " IOKBN = 'O' "
    '    End If

    '    ' 初期表示状態
    '    Cmd.Connection = Cm.Conn
    '    Cmd.CommandText = "Select * From (" & Q_RefStockHistory & ") " & strWhere
    '    Dta.Fill(Dts)

    '    dgStockHistory.DataSource = Dts
    '    dgStockHistory.Refresh()


    'End Sub

    'Private Sub frmStockHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Dim Cmd As New OleDb.OleDbCommand
    '    Dim Dta As New OleDb.OleDbDataAdapter
    '    Dim Dts As New DataSet

    '    dateFrom.Value = DateAdd("d", -1, Now())
    '    dateTo.Format = DateTimePickerFormat.Custom
    '    dateTo.CustomFormat = ""
    '    chkIn.Checked = False
    '    chkOut.Checked = False

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
    '    Cmd.CommandText = "Select * From Q_RefStockHistory Where CRTDT >= #" & Format(DateAdd("d", -1, Now()), "yyyy/mm/dd") & "#"
    '    Dta.SelectCommand = Cmd
    '    Dta.Fill(Dts)

    '    dgStockHistory.DataSource = Dts
    '    dgStockHistory.Refresh()

    '    dgStockHistory.Select()
    '    dgStockHistory.ReadOnly = True

    'End Sub

End Class