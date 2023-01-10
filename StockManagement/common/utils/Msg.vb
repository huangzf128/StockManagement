Public Class Msg
    Public Shared Sub warning(msg As String, title As String)
        MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

End Class
