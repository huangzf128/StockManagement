Imports System.Text

Public Class FrmStockOut


    Private Sub FrmStockOut_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetLocation()

        Dim dt As New DataTable
        dt.Columns.Add("ITEMCD", GetType(String))
        dt.Columns.Add("LOCATIONCD", GetType(String))
        dt.Columns.Add("QTY", GetType(Integer))
        dt.Columns.Add("REMARKS", GetType(String))

        grd.DataSource = dt
    End Sub


    ' 商品検索ボタン押下時イベント
    Private Sub btnItemSearch_Click(sender As Object, e As EventArgs) Handles btnItemSearch.Click
        Cm.StrSearchItemCd = Cm.Nz(txtItemCd.Text, "")
        frmItemSearch.ShowDialog()
    End Sub


    ' 対象削除ボタン押下時イベント
    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim Cmd As New OleDb.OleDbCommand
        Cmd.Connection = Cm.Conn
        Cmd.CommandText = "Delete From T_StockOut Where TARGETFLG = True"
        Cmd.ExecuteNonQuery()
        grd.Refresh()
    End Sub

    ' 出庫処理ボタン押下時イベント
    Private Sub cmdExec_Click(sender As Object, e As EventArgs) Handles cmdExec.Click
        Dim varIpAddress As String = ""

        Dim Cmd As New OleDb.OleDbCommand
        Dim Dta As New OleDb.OleDbDataAdapter
        Dim Dts As New DataSet

        Cmd.Connection = Cm.Conn
        varIpAddress = Cm.DLookup("VALUE1", "M_CODE_CL", "CATEGORY = 'PREVUSER'")
        If Cm.DLookup("LOCKST", "T_Lock", "") <> 0 Then
            MessageBox.Show("サーバーで定時処理が稼働中です。暫く経ってから実行してください。", "出庫処理", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' 更新データチェック
        Cmd.CommandText = "Delete From T_ErrorAlert_CL"
        Cmd.ExecuteNonQuery()
        Cmd.CommandText = "Insert Into T_ErrorAlert_CL(KEYCODE, MESSAGE, CRTDT) " &
                 "Select T_StockOut.ITEMCD, '変更商品名がマスタに登録されていません。出庫前に登録して下さい。', Now() From T_StockOut Left Join M_Item " &
                 "On T_StockOut.ITEMCD = M_Item.ITEMCD Where M_Item.ITEMCD Is Null"
        Cmd.ExecuteNonQuery()
        Cmd.CommandText = "Insert Into T_ErrorAlert_CL(KEYCODE, MESSAGE, CRTDT) " &
                 "Select T_StockOut.ITEMCD, 'ロケーションがマスタに登録されていません。確認して下さい。', Now() " &
                 "From T_StockOut Left Join (Select * From M_Code Where CATEGORY = 'LOCATIONCD') As CODE " &
                 "On T_StockOut.LOCATIONCD = CODE.CODE Where CODE.VALUE1 Is Null"
        Cmd.ExecuteNonQuery()

        If Cm.DCount("KEYCODE", "T_ErrorAlert_CL", "") > 0 Then
            frmErrorAlertTbl.ShowDialog()
        Else
            ' サーバーテーブルに更新
            Cmd.CommandText = "Insert Into T_StockHistory(CRTDT, ITEMCD, LOCATIONCD, IOKBN, QTY, REMARKS, UPDIP) " &
                     "Select Now(), ITEMCD, LOCATIONCD, 'O', QTY, REMARKS, '" & Cm.Nz(varIpAddress, "") & "' " &
                     "From T_StockOut"
            Cmd.ExecuteNonQuery()
            Cmd.CommandText = "Update T_ActStock " &
                     "Inner Join T_StockOut On T_ActStock.ITEMCD = T_StockOut.ITEMCD And T_ActStock.LOCATIONCD = T_StockOut.LOCATIONCD " &
                     "Set T_ActStock.ACTQTY = T_ActStock.ACTQTY - T_StockOut.QTY, T_ActStock.UPDDT = Now()"
            Cmd.ExecuteNonQuery()
            Cmd.CommandText = "Insert Into T_ActStock(ITEMCD, LOCATIONCD, ACTQTY, UPDDT) " &
                     "Select T1.ITEMCD, T1.LOCATIONCD, T1.QTY * -1, Now() " &
                     "From T_StockOut As T1 Left Join T_ActStock As T2 On T1.ITEMCD = T2.ITEMCD And T1.LOCATIONCD = T2.LOCATIONCD " &
                     "Where T2.ITEMCD Is Null"
            Cmd.ExecuteNonQuery()
            Cmd.CommandText = "Delete From T_StockOut"
            Cmd.ExecuteNonQuery()
            MessageBox.Show("サーバーへの出庫処理が完了しました。", "出庫処理", MessageBoxButtons.OK, MessageBoxIcon.Information)
            grd.Refresh()
        End If
    End Sub



    ' 商品検索ボタン押下時イベント
    Private Sub cmdSearch_Click()
        Cm.StrSearchItemCd = Cm.Nz(txtItemCd.Text, "")
        Cm.StrSearchItemFormName = Me.Name
        frmItemSearch.ShowDialog()
    End Sub

    ' 一括メンテンスボタン押下時イベント
    Private Sub cmdAll_Click(sender As Object, e As EventArgs) Handles cmdAll.Click
        frmStockOutTbl.ShowDialog()
    End Sub



    ' フォームロードイベント

    ' 商品名フォーカス喪失時イベント
    Private Sub txtItemCd_LostFocus(sender As Object, e As EventArgs) Handles txtItemCd.LostFocus
        GetActQty()
    End Sub

    ' ロケーションフォーカス喪失時イベント
    Private Sub cboLocation_LostFocus(sender As Object, e As EventArgs) Handles cmbLocation.LostFocus
        GetActQty()
    End Sub

    ' ロケーション変更時イベント
    Private Sub cboLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLocation.SelectedIndexChanged
        GetActQty()
    End Sub


    Private Sub SetLocation()

        Dim sb As New StringBuilder
        sb.Append(" SELECT  ")
        sb.Append("   CODE ")
        sb.Append("  ,CODE + '-' + VALUE1 AS NAME ")
        sb.Append(" FROM M_Code ")
        sb.Append(" WHERE CATEGORY = 'LOCATIONCD' ")
        sb.Append(" ORDER BY CODE ")

        Dim dt As DataTable = DbHandler.executeSelect(New DbParamEnt(sb, Nothing))
        cmbLocation.DataSource = dt
        cmbLocation.DisplayMember = "NAME"
        cmbLocation.ValueMember = "CODE"

    End Sub

    ' 実在庫数取得
    Private Sub GetActQty()
        Return
        If txtItemCd.Text = "" Then
            Return
        End If
        Dim varQty As String
        varQty = Cm.DLookup("ACTQTY", "T_ActStock", "ITEMCD = '" & txtItemCd.Text & "' And LOCATIONCD = '" & cmbLocation.SelectedValue & "'")
        txtActQty.Text = Cm.Nz(varQty, "")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If Util.obj2String(txtItemCd.Text, "") = "" Then
            Msg.warning("変更商品名を入力してください。", "入力エラー")
            txtItemCd.Select()
            Return
        ElseIf Util.obj2String(txtQty.Text, "") = "" Then
            Msg.warning("数量を入力してください。", "入力エラー")
            txtQty.Select()
            Return
        End If

        If isExists(txtItemCd.Text, cmbLocation.Text) Then
            Msg.warning("既に追加済みです。", "入力エラー")
            Return
        End If

        Dim dt As DataTable = grd.DataSource

        dt.Rows.Add(New Object() {txtItemCd.Text, cmbLocation.Text, txtQty.Text, txtRemarks.Text})
        grd.Refresh()

        Clear()
    End Sub

    Private Function isExists(ByVal itemCd As String, ByVal locationNm As String) As Boolean
        Dim dt As DataTable = grd.DataSource
        For Each row As DataRow In dt.Rows
            If row("ITEMCD") = itemCd AndAlso row("LOCATIONCD") = locationNm Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Clear()
        txtItemCd.Text = ""
        txtQty.Text = ""
        txtRemarks.Text = ""
        txtActQty.Text = ""
        txtItemCd.Select()
    End Sub

End Class