Imports System.Runtime.InteropServices

Public Class SubFrmBase

#Region "API"

    <DllImport("user32.dll", EntryPoint:="SendMessageW")>
    Private Shared Function SendMessageW(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

#End Region

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            If Not DesignMode Then
                cp.ExStyle = cp.ExStyle Or &H2000000
            End If
            Return cp
        End Get
    End Property


    Private Sub pnlTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTitle.MouseMove
        Const HT_CAPTION As Integer = &H2
        Const WM_NCLBUTTONDOWN As Integer = &HA1

        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessageW(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle, Color.WhiteSmoke, ButtonBorderStyle.Solid)
    End Sub

    Private Sub SubFrmBase_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session.darkMode Then
            Me.FormBorderStyle = FormBorderStyle.None
        End If
    End Sub
End Class