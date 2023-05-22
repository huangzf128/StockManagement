Imports System.Windows.Forms


Module Program

    <STAThread()>
    Public Sub Main()

        Application.EnableVisualStyles()

        If Not System.Diagnostics.Debugger.IsAttached Then
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException)
            AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf LogUnhandledExceptions
        End If

        Application.Run(New FrmDashboard)
    End Sub

    Sub LogUnhandledExceptions(sender As Object, args As UnhandledExceptionEventArgs)

        Dim e As Exception = DirectCast(args.ExceptionObject, Exception)
        Log.Write(e.Message + vbNewLine + vbNewLine + e.StackTrace)
        Msg.warning("システムエラーが発生しました。システム管理者に連絡してください。", "エラー")
        Environment.Exit(0)
    End Sub
End Module

