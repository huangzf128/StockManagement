Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports Microsoft.VisualBasic.ApplicationServices

Public Class FrmLogin

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Select()

        txtUser.Text = Session.info.userId
        txtPass.Select()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If Util.isEmpty(txtUser.Text) Then
            Msg.warning("ユーザ名を入力してください。", "入力エラー")
            txtUser.Select()
            Return
        End If

        If Util.isEmpty(txtPass.Text) Then
            Msg.warning("パスワードを入力してください。", "入力エラー")
            txtPass.Select()
            Return
        End If

        Dim dbParamEnt As DbParamEnt = getSqlAndParam()
        Dim dt As DataTable = DbHandler.executeSelect(dbParamEnt)
        If dt.Rows.Count > 0 Then
            If dt.Rows(0).Item("AUTHLV") = 99 Then
                Session.isAuthUser = True

                Session.info.userId = txtUser.Text
                Util.Write2Xml(IO.Path.Combine(Util.GetPgFolderPath(), Consts.INFO_FILE_NAME), Session.info)
                Me.Close()
            Else
                Msg.warning("管理者しかログインできません。", "ログインエラー")
            End If
        Else
            Msg.warning("ユーザ名/パスワードが間違っています。", "ログインエラー")
        End If
    End Sub


    Private Function getSqlAndParam() As DbParamEnt
        Dim param As New List(Of SqlParameter)

        Dim sb As New StringBuilder
        sb.Append(" SELECT ")
        sb.Append("   AUTHLV ")
        sb.Append(" ")
        sb.Append(" FROM M_User  ")
        sb.Append(" WHERE ")
        sb.Append("     USERID = @USERID ")
        param.Add(New SqlParameter("@USERID", txtUser.Text))
        sb.Append(" AND PASSWD = @PASSWD ")
        param.Add(New SqlParameter("@PASSWD", txtPass.Text))

        Return New DbParamEnt(sb, param.ToArray)
    End Function

End Class