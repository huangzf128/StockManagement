Public Class Log

    Public Shared Sub Write(contents As String)
        Dim con As String = Now.ToString(Consts.DATE_LONG) + ": ====================================" + vbNewLine
        con += contents + vbNewLine
        con += Now.ToString(Consts.DATE_LONG) + ": ====================================" + vbNewLine

        Util.WriteFile(IO.Path.Combine(Util.GetPgFolderPath(), Consts.LOG_FILE_NAME), vbNewLine + con)
    End Sub

    Public Shared Function Read()
        Return String.Empty
    End Function


End Class
