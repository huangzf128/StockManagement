Imports System.Threading

Public Class LoadingForm

    Public Sub SetMessage(ByVal msg As String)
        lblMessage.Text = msg
    End Sub

    Private Sub LoadingForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        picBox.Image = System.Drawing.Image.FromFile("image/loading_cat.gif")
    End Sub
End Class