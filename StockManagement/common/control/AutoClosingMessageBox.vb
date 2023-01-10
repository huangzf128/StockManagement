Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class AutoClosingMessageBox
    Private _timeoutTimer As System.Threading.Timer
    Private _caption As String

    Sub New(text As String, caption As String, timeout As Integer)
        _caption = caption
        _timeoutTimer = New System.Threading.Timer(AddressOf OnTimerElapsed,
            Nothing, timeout, System.Threading.Timeout.Infinite)
        Using (_timeoutTimer)
            MessageBox.Show(text, caption)
        End Using
    End Sub

    Public Shared Sub Show(text As String, caption As String, Optional timeout As Integer = 1000)
        Dim msg = New AutoClosingMessageBox(text, caption, timeout)
    End Sub

    Private Sub OnTimerElapsed(state As Object)
        Dim mbWnd As IntPtr = FindWindow("#32770", _caption)
        If mbWnd <> IntPtr.Zero Then
            SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero)
            _timeoutTimer.Dispose()
        End If
    End Sub

#Region "API"

    Private Const WM_CLOSE As Integer = &H10

    <System.Runtime.InteropServices.DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function FindWindow(
        ByVal lpClassName As String,
        ByVal lpWindowName As String) As IntPtr
    End Function

    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto)>
    Private Shared Function SendMessage(
        hWnd As IntPtr, Msg As UInt32, wParam As IntPtr, lParam As IntPtr) As IntPtr
    End Function
#End Region

End Class
