<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.picBox = New System.Windows.Forms.PictureBox()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblMessage.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.lblMessage.Location = New System.Drawing.Point(0, 228)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(231, 16)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "Loading data. Please wait..."
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picBox
        '
        Me.picBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBox.Location = New System.Drawing.Point(0, 0)
        Me.picBox.Name = "picBox"
        Me.picBox.Size = New System.Drawing.Size(285, 228)
        Me.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox.TabIndex = 1
        Me.picBox.TabStop = False
        '
        'LoadingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(285, 244)
        Me.Controls.Add(Me.picBox)
        Me.Controls.Add(Me.lblMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoadingForm"
        Me.Opacity = 0.9R
        Me.Text = "WaitForm"
        Me.TopMost = True
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents picBox As PictureBox
End Class
