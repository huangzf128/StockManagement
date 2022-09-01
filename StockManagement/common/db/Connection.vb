Imports System.Data.SqlClient

Public Class Connection

    'これを記述するだけでデストラクタが自動生成される
    Implements IDisposable

    'デストラクト済みか否かのフラグ
    Private disposedValue As Boolean '自動生成コード

    '(接続文字列)
    Private Property conStr As String = ""
    Private Property sqlCon As SqlConnection
    Private Property sqlTrn As SqlTransaction
    Private Property sqlCmd As SqlCommand
    Private Property sqlAdp As SqlDataAdapter

    'コンストラクタ
    'クラスをインスタンス化した時、DB接続を開始する
    Public Sub New()
        Me.open()
    End Sub

    'DB接続を開始
    Public Sub open()
        If sqlCon Is Nothing Then
            sqlCon = New SqlConnection(conStr)
            sqlCon.Open()
        End If
    End Sub

    '全てのオブジェクトを破棄し、DB接続を終了
    Public Sub close()
        If Not sqlAdp Is Nothing Then
            sqlAdp.Dispose()
            sqlAdp = Nothing
        End If
        If Not sqlCmd Is Nothing Then
            sqlCmd.Dispose()
            sqlCmd = Nothing
        End If
        If Not sqlTrn Is Nothing Then
            sqlTrn.Dispose()
            sqlTrn = Nothing
        End If
        If Not sqlCon Is Nothing Then
            sqlCon.Close()
            sqlCon.Dispose()
            sqlCon = Nothing
        End If
    End Sub

    'トランザクション開始
    Public Sub trnStart()
        If sqlTrn Is Nothing Then
            sqlTrn = sqlCon.BeginTransaction
        End If
    End Sub

    'トランザクションコミット
    Public Sub commit()
        If Not sqlTrn Is Nothing Then
            sqlTrn.Commit()
        End If
    End Sub

    'トランザクションロールバック
    Public Sub rollback()
        If Not sqlTrn Is Nothing Then
            sqlTrn.Rollback()
        End If
    End Sub

    ''' <summary>
    ''' トランザクションを伴わないSQLを実行(主にSELECT文)
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <returns>Datatable</returns>
    Public Function getDateSql(sql As String) As DataTable
        '結果を格納するDataTableを宣言
        Dim returnDt As New DataTable

        Try
            sqlCmd = New SqlCommand(sql, sqlCon)
            sqlAdp = New SqlDataAdapter(sqlCmd)
            sqlAdp.Fill(returnDt)
        Catch ex As Exception
            Throw
        End Try

        Return returnDt

    End Function

    ''' <summary>
    ''' トランザクションを伴うSQLを実行(主にINSERT,UPDATE,DELETE文)
    ''' </summary>
    ''' <param name="sql"></param>
    Public Sub executeSql(sql As String)

        Try
            sqlCmd = New SqlCommand(sql, sqlCon, sqlTrn)
            sqlCmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw
        End Try

    End Sub

    '以下ほぼ自動生成コード
    Protected Overridable Sub Dispose(disposing As Boolean)
        '重複してデストラクタを実行しないためのIfステートメント
        'この中身の処理だけ自分で書く
        If Not disposedValue Then
            Me.close() 'クラスのインスタンスを破棄するとき、DB接続を終了する
            disposedValue = True
        End If
    End Sub

    Protected Overrides Sub Finalize()
        Dispose(disposing:=False)
        MyBase.Finalize()
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(disposing:=True)
        GC.SuppressFinalize(Me)
    End Sub
End Class
