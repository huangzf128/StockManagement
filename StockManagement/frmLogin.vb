Public Class frmLogin

    ' キャンセルボタン押下時イベント
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Cm.Conn.Close()
        Cm.Conn.Dispose()
        Close()
    End Sub

    ' ログインボタン押下時イベント
    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        Dim varAuthLv As String

        ' ログイン情報の問い合わせ
        varAuthLv = Cm.DLookup("AUTHLV", "M_USER", "USERID = '" & txtUser.Text & "' And PASSWD = '" & txtPass.Text & "'")
        If IsNothing(varAuthLv) Then
            MessageBox.Show("ユーザーもしくはパスワードが誤っています。", "ログインエラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' ログイン権限の更新とログイン情報の保存
            Dim Cmd As New OleDb.OleDbCommand
            Cmd.Connection = Cm.Conn
            Cmd.CommandText = "Update M_CODE Set CODE = '" & varAuthLv & "' Where CATEGORY = 'USERAUTH';" &
                "Update M_CODE Set VALUE1 = '" & txtUser.Text & "' Where CATEGORY = 'PREVUSER';"
            Cmd.ExecuteNonQuery()

            ' メニュー画面に遷移
            frmMenu.ShowDialog()
        End If
    End Sub

    ' フォームロード時イベント
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim varUser As String

        Cm.Conn.ConnectionString = "Provider=sqloledb;Data Source=ocalhost\sqlexpress;Initial Catalog=master;Integrated Security=SSPI;"

        Try
            Cm.Conn.Open()
        Catch
            MessageBox.Show("データベースに接続できませんでした。", "起動エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End Try


        '[2.0] M_CODE_CLをM_CODEに統合
        varUser = Cm.DLookup("VALUE1", "M_CODE", "CATEGORY = 'PREVUSER'")
        If IsNothing(varUser) Then
            txtPass.Select()
        Else
            txtUser.Text = varUser
            txtPass.Select()
        End If

    End Sub

End Class