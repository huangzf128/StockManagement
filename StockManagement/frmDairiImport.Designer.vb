<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDairiImport
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
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdCheck = New System.Windows.Forms.Button()
        Me.cmdExec = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(509, 112)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(137, 58)
        Me.cmdSearch.TabIndex = 0
        Me.cmdSearch.Text = "..."
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdCheck
        '
        Me.cmdCheck.Location = New System.Drawing.Point(67, 270)
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.Size = New System.Drawing.Size(182, 69)
        Me.cmdCheck.TabIndex = 1
        Me.cmdCheck.Text = "取込済再チェック＆引当試行"
        Me.cmdCheck.UseVisualStyleBackColor = True
        '
        'cmdExec
        '
        Me.cmdExec.Location = New System.Drawing.Point(354, 269)
        Me.cmdExec.Name = "cmdExec"
        Me.cmdExec.Size = New System.Drawing.Size(141, 65)
        Me.cmdExec.TabIndex = 2
        Me.cmdExec.Text = "取込み"
        Me.cmdExec.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(543, 269)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(145, 70)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "閉じる"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(91, 112)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(368, 31)
        Me.txtFilePath.TabIndex = 4
        '
        'frmDairiImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdExec)
        Me.Controls.Add(Me.cmdCheck)
        Me.Controls.Add(Me.cmdSearch)
        Me.Name = "frmDairiImport"
        Me.Text = "frmDairiImport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdSearch As Button
    Friend WithEvents cmdCheck As Button
    Friend WithEvents cmdExec As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents txtFilePath As TextBox
End Class
