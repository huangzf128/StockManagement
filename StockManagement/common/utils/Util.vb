Public Class Util
    Public Shared Function obj2Integer(value As Object, Optional defVal As Integer = 0) As Integer

        If IsDBNull(value) OrElse value Is Nothing Then
            Return defVal
        End If

        Return value
    End Function
End Class
