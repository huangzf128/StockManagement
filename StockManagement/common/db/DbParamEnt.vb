Imports System.Data.SqlClient
Imports System.Text

Public Class DbParamEnt

    Public sbSql As StringBuilder
    Public parameters() As SqlParameter

    Sub New(ByVal sql As StringBuilder, ByRef param() As SqlParameter)
        sbSql = sql
        parameters = param
    End Sub
End Class
