Public Class Cm
    'データベース接続
    Public Shared Conn As New OleDb.OleDbConnection

    '商品CD（商品検索の画面遷移時用）
    Public Shared StrSearchItemCd As String = ""

    'NULL→空文字列変換処理
    Public Shared Function Nz(strOri As String, strAlt As String)
        Dim rtn As String = strOri
        If strOri Is Nothing Then
            rtn = strAlt
        End If
        Return rtn
    End Function

    '単一列値のデータベース検索処理
    Public Shared Function DLookup(colName As String, tableName As String, cond As String)
        Dim rtn As Object = Nothing
        Dim whereString As String = cond

        Dim Cmd As New OleDb.OleDbCommand
        Dim Dta As New OleDb.OleDbDataAdapter
        Dim Dts As New DataSet

        If Nz(whereString, "") <> "" Then
            whereString = " WHERE " & cond
        End If

        Cmd.Connection = Conn
        Cmd.CommandText = "SELECT " & colName & " FROM " & tableName & whereString
        Dta.SelectCommand = Cmd
        Dta.Fill(Dts)

        If Dts.Tables(0).Rows.Count > 0 Then
            rtn = Dts.Tables(0).Rows(0).Item(colName)
        End If

        Return rtn

    End Function

    '単一列のデータ件数取得処理
    Public Shared Function DCount(colName As String, tableName As String, cond As String)
        Dim rtn As Long
        Dim whereString As String = cond

        Dim Cmd As New OleDb.OleDbCommand
        Dim Dta As New OleDb.OleDbDataAdapter
        Dim Dts As New DataSet

        If Nz(whereString, "") <> "" Then
            whereString = " WHERE " & cond
        End If

        Cmd.Connection = Conn
        Cmd.CommandText = "SELECT COUNT(" & colName & ") FROM " & tableName & whereString
        Dta.SelectCommand = Cmd
        Dta.Fill(Dts)

        If Dts.Tables(0).Rows.Count > 0 Then
            rtn = Dts.Tables(0).Rows(0).Item(0)
        End If

        Return rtn

    End Function

End Class
