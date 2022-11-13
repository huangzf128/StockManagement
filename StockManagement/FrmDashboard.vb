Imports System.Drawing.Imaging
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports Microsoft.VisualBasic.ApplicationServices

Public Class FrmDashboard

#Region "API"

    <DllImport("user32.dll", EntryPoint:="SendMessageW")>
    Private Shared Function SendMessageW(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

#End Region

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
        Me.lblTitle.Text = FrmStockHistory.Text
        switchForm(FrmStockHistory)
    End Sub

    Private Sub btnStockReserve_Click(sender As Object, e As EventArgs) Handles btnStockReserve.Click
        Me.lblTitle.Text = FrmStockReserve.Text
        switchForm(FrmStockReserve)
    End Sub

    Private Sub btnStockList_Click(sender As Object, e As EventArgs) Handles btnStockList.Click
        Me.lblTitle.Text = FrmStockList.Text
        switchForm(FrmStockList)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.lblTitle.Text = Me.Text
        Me.pnlDashboard.Visible = True

        If Me.ActiveMdiChild IsNot Nothing Then
            Me.ActiveMdiChild.Close()
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

    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_SYSCOMMAND As Integer = &H112
        Const SC_RESTORE As Integer = &HF120
        Const SC_MAXIMIZE As Integer = &HF030

        If m.Msg = WM_SYSCOMMAND Then
            If m.WParam = New IntPtr(SC_RESTORE) Then
                ' do something before restore
                'Me.Refresh()
                'Me.MinimizeBox = False

            ElseIf m.WParam = New IntPtr(SC_MAXIMIZE) Then
                ' do something before maximize
            End If
        End If

        MyBase.WndProc(m)  ' allow form to process this message
    End Sub

#End Region


    Private Sub switchForm(ByVal frm As FrmBase)

        Me.pnlDashboard.Visible = False

        If frm Is Me.ActiveMdiChild Then
            Return
        End If

        If Me.ActiveMdiChild IsNot Nothing Then
            Me.ActiveMdiChild.Close()
        End If

        frm.TopLevel = False
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

End Class