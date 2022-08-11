Public Class frmStockOut

    ' 商品検索ボタン押下時イベント
    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Cm.StrSearchItemCd = Cm.Nz(txtItemCd.Text, "")
        frmItemSearch.ShowDialog()
    End Sub

    ' 追加ボタン押下時イベント
    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        If Cm.Nz(txtItemCd.Text, "") <> "" And Cm.Nz(txtQty.Text, "") <> "" And Cm.Nz(cboLocation.SelectedValue, "") <> "" Then
            Dim Cmd As New OleDb.OleDbCommand
            Cmd.Connection = Cm.Conn
            Cmd.CommandText = "Insert Into T_StockOut(ITEMCD, LOCATIONCD, QTY, REMARKS, UPDDT) Values('" & txtItemCd.Text & "','" & cboLocation.SelectedValue & "'," & txtQty.Text & ",'" & Cm.Nz(txtRemarks.Text, "") & "', Now())"
            Cmd.ExecuteNonQuery()
            dgStockOut.Refresh()
            txtItemCd.Text = ""
            txtQty.Text = ""
            txtRemarks.Text = ""
            txtActQty.Text = ""
            txtItemCd.Select()
        Else
            MessageBox.Show("必要情報を入力してください。", "追加エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' 対象削除ボタン押下時イベント
    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim Cmd As New OleDb.OleDbCommand
        Cmd.Connection = Cm.Conn
        Cmd.CommandText = "Delete From T_StockOut Where TARGETFLG = True"
        Cmd.ExecuteNonQuery()
        dgStockOut.Refresh()
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
            dgStockOut.Refresh()
        End If
    End Sub


    ' 閉じるボタン押下時イベント
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    ' 商品検索ボタン押下時イベント
    Private Sub cmdSearch_Click()
        Cm.StrSearchItemCd = Cm.Nz(txtItemCd.Text, "")
        'TODO
        'strSearchItemFormName = Me.Form.Name
        frmItemSearch.ShowDialog()
    End Sub

    ' 一括メンテンスボタン押下時イベント
    Private Sub cmdAll_Click(sender As Object, e As EventArgs) Handles cmdAll.Click
        frmStockOutTbl.ShowDialog()
    End Sub


    Private Sub frmStockOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' フォームロードイベント
    Private Sub Form_Load()
        SetLocation()
    End Sub

    ' 商品名フォーカス喪失時イベント
    Private Sub txtItemCd_LostFocus(sender As Object, e As EventArgs) Handles txtItemCd.LostFocus
        GetActQty()
    End Sub

    ' ロケーションフォーカス喪失時イベント
    Private Sub cboLocation_LostFocus(sender As Object, e As EventArgs) Handles cboLocation.LostFocus
        GetActQty()
    End Sub

    ' ロケーション変更時イベント
    Private Sub cboLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLocation.SelectedIndexChanged
        GetActQty()
    End Sub


    Private Sub SetLocation()
        Dim Cmd As New OleDb.OleDbCommand
        Dim Dta As New OleDb.OleDbDataAdapter
        Dim Dts As New DataSet

        Cmd.Connection = Cm.Conn
        Cmd.CommandText = "SELECT CODE,VALUE1 FROM M_Code WHERE CATEGORY = 'LOCATIONCD' ORDER BY CODE;"
        Dta.SelectCommand = Cmd
        Dta.Fill(Dts)
        For i = 0 To Dts.Tables(0).Rows.Count
            cboLocation.Items.Add(New With {.Text = Dts.Tables(0).Rows(i).Item("VALUE1"), .Value = Dts.Tables(0).Rows(i).Item("CODE")})
        Next
    End Sub

    ' 実在庫数取得
    Private Sub GetActQty()
        Dim varQty As String
        varQty = Cm.DLookup("ACTQTY", "T_ActStock", "ITEMCD = '" & txtItemCd.Text & "' And LOCATIONCD = '" & cboLocation.SelectedValue & "'")
        txtActQty.Text = Cm.Nz(varQty, "")
    End Sub

End Class