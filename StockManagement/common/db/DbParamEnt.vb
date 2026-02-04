Imports System.Data.SqlClient
Imports System.Text

Public Class DbParamEnt

    Public sbSql As StringBuilder
    Public parameters() As SqlParameter

    Sub New(ByVal sql As StringBuilder, ByRef param() As SqlParameter)
        sbSql = sql
        parameters = param

        'Dim sqlStr = OutputSql()
        'Console.WriteLine(sqlStr)

    End Sub

    ''' <summary>
    ''' 调试用：输出参数已替换的 SQL（仅用于日志/调试）
    ''' </summary>
    Public Function OutputSql() As String
        If sbSql Is Nothing Then
            Return String.Empty
        End If

        Dim sql As String = sbSql.ToString()

        If parameters Is Nothing OrElse parameters.Length = 0 Then
            Return sql
        End If

        ' 参数名长度倒序，避免 @A / @AB 误替换
        Dim orderedParams = parameters _
            .OrderByDescending(Function(p) p.ParameterName.Length)

        For Each p As SqlParameter In orderedParams
            sql = sql.Replace(p.ParameterName, ToSqlLiteral(p))
        Next

        Return sql
    End Function

    Private Function ToSqlLiteral(p As SqlParameter) As String
        If p.Value Is Nothing OrElse p.Value Is DBNull.Value Then
            Return "NULL"
        End If

        Select Case p.SqlDbType
            Case SqlDbType.Char, SqlDbType.NChar,
                 SqlDbType.VarChar, SqlDbType.NVarChar,
                 SqlDbType.Text, SqlDbType.NText
                ' N 前缀，日文环境必须
                Return "N'" & p.Value.ToString().Replace("'", "''") & "'"

            Case SqlDbType.Date, SqlDbType.DateTime,
                 SqlDbType.DateTime2, SqlDbType.SmallDateTime
                Return "'" & CType(p.Value, DateTime).ToString("yyyy-MM-dd HH:mm:ss.fff") & "'"

            Case SqlDbType.Bit
                Return If(CBool(p.Value), "1", "0")

            Case Else
                Return p.Value.ToString()
        End Select
    End Function
End Class
