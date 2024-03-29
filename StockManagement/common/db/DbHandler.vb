﻿Imports System.Collections.ObjectModel
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO

Public Class DbHandler

    'これを記述するだけでデストラクタが自動生成される
    Implements IDisposable

    'デストラクト済みか否かのフラグ
    Private disposedValue As Boolean '自動生成コード

    '(接続文字列)
    Private Shared ReadOnly conStr As String = ConfigurationManager.AppSettings.Get("DBConnStr").ToString
    Private Property sqlCon As SqlConnection
    Private Property sqlTrn As SqlTransaction

    'コンストラクタ
    'クラスをインスタンス化した時、DB接続を開始する
    Public Sub New()
        'Me.open()
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
            Try
                sqlTrn.Rollback()
            Catch ex As Exception
            End Try
        End If
    End Sub

    ''' <summary>
    ''' トランザクションを伴うSQLを実行(主にINSERT,UPDATE,DELETE文)
    ''' </summary>
    ''' <param name="dbParamEnt"></param>
    Public Function execute(ByRef dbParamEnt As DbParamEnt) As Integer

        Try
            Dim command As New SqlCommand(dbParamEnt.sbSql.ToString, Me.sqlCon, Me.sqlTrn)
            If dbParamEnt.parameters IsNot Nothing AndAlso dbParamEnt.parameters.Length > 0 Then
                command.Parameters.AddRange(dbParamEnt.parameters)
            End If
            Return command.ExecuteNonQuery()

        Catch ex As Exception

            Log.Write(ex.Message + vbNewLine + ex.StackTrace)
            Msg.warning("DBエラーが発生しました。システム管理者に連絡してください。", "エラー")

            rollback()
            close()
            Environment.Exit(0)
        End Try

        Return -1
    End Function

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


    ''' <summary>
    ''' トランザクションを伴わないSQLを実行(主にSELECT文)
    ''' </summary>
    ''' <param name="dbParamEnt"></param>
    ''' <returns>Datatable</returns>
    Public Shared Function executeSelect(ByRef dbParamEnt As DbParamEnt) As DataTable
        '結果を格納するDataTableを宣言
        Dim returnDt As New DataTable

        Try
            Using connection As New SqlConnection(conStr)

                Dim command As New SqlCommand(dbParamEnt.sbSql.ToString, connection)
                command.Connection.Open()
                If dbParamEnt.parameters IsNot Nothing AndAlso dbParamEnt.parameters.Length > 0 Then
                    command.Parameters.AddRange(dbParamEnt.parameters)
                End If

                Dim sqlAdp As SqlDataAdapter = New SqlDataAdapter(command)
                sqlAdp.Fill(returnDt)
            End Using

        Catch ex As Exception
            Log.Write(ex.Message + vbNewLine + ex.StackTrace)
            Msg.warning("DBエラーが発生しました。システム管理者に連絡してください。", "エラー")
            Environment.Exit(0)
        End Try
        'Try
        '    Dim command As New SqlCommand(dbParamEnt.sbSql.ToString, connection)
        '    command.Connection.Open()
        '    If dbParamEnt.parameters IsNot Nothing AndAlso dbParamEnt.parameters.Length > 0 Then
        '        command.Parameters.AddRange(dbParamEnt.parameters)
        '    End If

        '    Dim sqlAdp As SqlDataAdapter = New SqlDataAdapter(command)
        '    sqlAdp.Fill(returnDt)

        'Catch ex As Exception
        '    Log.Write(ex.Message + vbNewLine + ex.StackTrace)
        '    Msg.warning("DBエラーが発生しました。システム管理者に連絡してください。", "エラー")
        '    Environment.Exit(0)
        'Finally
        '    connection.Dispose()
        'End Try

        Return returnDt
    End Function
End Class
