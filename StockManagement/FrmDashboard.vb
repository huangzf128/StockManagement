Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports Microsoft.VisualBasic.ApplicationServices

Public Class FrmDashboard

    <DllImport("user32.dll", EntryPoint:="SendMessageW")>
    Private Shared Function SendMessageW(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

#Region "EVENT"

    ''' <summary>
    ''' draggble header panel 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pnlHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseMove
        Const HT_CAPTION As Integer = &H2
        Const WM_NCLBUTTONDOWN As Integer = &HA1

        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessageW(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub btnStockHistory_Click(sender As Object, e As EventArgs) Handles btnStockHistory.Click

        showForm(FrmStockHistory)
    End Sub

    Private Sub btnStockReserve_Click(sender As Object, e As EventArgs) Handles btnStockReserve.Click

        showForm(FrmStockReserve)
    End Sub

    ''' <summary>
    ''' show Dashboard
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.pnlDashboard.Visible = True

        If Me.MdiChildren.Length > 0 AndAlso TypeOf Me.MdiChildren(0) Is FrmBase Then
            TryCast(Me.MdiChildren(0), FrmBase).Close()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

#End Region

#Region "Overrides"

    ''' <summary>
    ''' flickering対策
    ''' </summary>
    ''' <returns></returns>
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            'cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property


    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_SYSCOMMAND As Integer = &H112
        Const SC_RESTORE As Integer = &HF120
        Const SC_MAXIMIZE As Integer = &HF030

        If m.Msg = WM_SYSCOMMAND Then
            If m.WParam = New IntPtr(SC_RESTORE) Then
                ' do something before restore
                Me.Refresh()
                Me.MinimizeBox = False

            ElseIf m.WParam = New IntPtr(SC_MAXIMIZE) Then
                ' do something before maximize
            End If
        End If

        MyBase.WndProc(m)  ' allow form to process this message
    End Sub

#End Region


    Private Sub showForm(ByVal frm As Form)

        Me.pnlDashboard.Visible = False


        'If Me.MdiChildren.Length > 0 AndAlso TypeOf Me.MdiChildren(0) Is FrmBase Then
        '    If frm Is Me.MdiChildren(0) Then
        '        Return
        '    End If
        '    TryCast(Me.MdiChildren(0), FrmBase).Close()
        'End If

        'tabControl.SelectedTab = tabForm

        frm.SuspendLayout()


        frm.TopLevel = False
        'frm.MdiParent = Me
        Me.Controls().Add(frm)
        'frm.Dock = DockStyle.Fill
        frm.Show()

        frm.ResumeLayout()

        'frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        'tabControl.ItemSize = New Size(0, 1)
        'tabControl.SizeMode = TabSizeMode.Fixed
        'tabControl.Appearance = TabAppearance.FlatButtons
    End Sub
End Class