<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBase
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlCondition = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'pnlCondition
        '
        Me.pnlCondition.BackColor = System.Drawing.Color.Transparent
        Me.pnlCondition.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCondition.Location = New System.Drawing.Point(0, 0)
        Me.pnlCondition.Name = "pnlCondition"
        Me.pnlCondition.Size = New System.Drawing.Size(910, 80)
        Me.pnlCondition.TabIndex = 0
        '
        'FrmBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.StockManagement.My.Resources.Resources.Dark_Ocean
        Me.ClientSize = New System.Drawing.Size(910, 560)
        Me.Controls.Add(Me.pnlCondition)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBase"
        Me.Text = "Base"
        Me.ResumeLayout(False)

    End Sub

    Protected Friend WithEvents pnlCondition As Panel
End Class
