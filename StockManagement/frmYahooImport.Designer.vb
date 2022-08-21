<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYahooImport
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.cmdExec = New System.Windows.Forms.Button()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(149, 99)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(100, 31)
        Me.txtFilePath.TabIndex = 0
        '
        'cmdExec
        '
        Me.cmdExec.Location = New System.Drawing.Point(110, 217)
        Me.cmdExec.Name = "cmdExec"
        Me.cmdExec.Size = New System.Drawing.Size(150, 84)
        Me.cmdExec.TabIndex = 1
        Me.cmdExec.Text = "ヤフオク受注CSV取込み"
        Me.cmdExec.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(543, 99)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 52)
        Me.cmdSearch.TabIndex = 2
        Me.cmdSearch.Text = "..."
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(327, 217)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(135, 84)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "キャンセルCSV取込み"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(531, 217)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(123, 72)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "閉じる"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frmYahooImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cmdExec)
        Me.Controls.Add(Me.txtFilePath)
        Me.Name = "frmYahooImport"
        Me.Text = "frmYahooImport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents cmdExec As Button
    Friend WithEvents cmdSearch As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdClose As Button
End Class
