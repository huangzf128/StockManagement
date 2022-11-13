<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UDataTimePicker
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
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
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbHour = New System.Windows.Forms.ComboBox()
        Me.cmbMinute = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(0, 0)
        Me.dtpDate.MinDate = New Date(2018, 1, 1, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(97, 21)
        Me.dtpDate.TabIndex = 0
        '
        'cmbHour
        '
        Me.cmbHour.FormattingEnabled = True
        Me.cmbHour.Location = New System.Drawing.Point(106, 0)
        Me.cmbHour.Name = "cmbHour"
        Me.cmbHour.Size = New System.Drawing.Size(38, 20)
        Me.cmbHour.TabIndex = 1
        '
        'cmbMinute
        '
        Me.cmbMinute.FormattingEnabled = True
        Me.cmbMinute.Location = New System.Drawing.Point(150, 0)
        Me.cmbMinute.Name = "cmbMinute"
        Me.cmbMinute.Size = New System.Drawing.Size(38, 20)
        Me.cmbMinute.TabIndex = 2
        '
        'UDataTimePicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmbMinute)
        Me.Controls.Add(Me.cmbHour)
        Me.Controls.Add(Me.dtpDate)
        Me.Name = "UDataTimePicker"
        Me.Size = New System.Drawing.Size(191, 20)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents cmbHour As ComboBox
    Friend WithEvents cmbMinute As ComboBox
End Class
