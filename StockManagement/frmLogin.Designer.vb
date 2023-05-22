<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits SubFrmBase

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtPass = New StockManagement.TextBoxBase()
        Me.txtUser = New StockManagement.TextBoxBase()
        Me.btnClose = New StockManagement.ButtonBase()
        Me.btnLogin = New StockManagement.ButtonBase()
        Me.lblUser = New StockManagement.LabelBase()
        Me.lblPass = New StockManagement.LabelBase()
        Me.pnlCondition.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Size = New System.Drawing.Size(118, 16)
        Me.lblTitle.Text = "管理者ログイン"
        '
        'pnlCondition
        '
        Me.pnlCondition.Controls.Add(Me.lblPass)
        Me.pnlCondition.Controls.Add(Me.lblUser)
        Me.pnlCondition.Controls.Add(Me.txtUser)
        Me.pnlCondition.Controls.Add(Me.txtPass)
        Me.pnlCondition.Size = New System.Drawing.Size(296, 60)
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(97, 34)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(113, 19)
        Me.txtPass.TabIndex = 2
        Me.txtPass.Type = 0
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(97, 12)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(113, 19)
        Me.txtUser.TabIndex = 1
        Me.txtUser.Type = 0
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Goldenrod
        Me.btnClose.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnClose.Location = New System.Drawing.Point(5, 146)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(70, 30)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "閉じる"
        Me.btnClose.Type = 1
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Sienna
        Me.btnLogin.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogin.Location = New System.Drawing.Point(182, 99)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(70, 30)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "ログイン"
        Me.btnLogin.Type = 5
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUser.Location = New System.Drawing.Point(25, 15)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(53, 12)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = "ユーザ名"
        Me.lblUser.Type = 1
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPass.Location = New System.Drawing.Point(25, 37)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(59, 12)
        Me.lblPass.TabIndex = 3
        Me.lblPass.Text = "パスワード"
        Me.lblPass.Type = 1
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(300, 181)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnClose)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ログイン"
        Me.Controls.SetChildIndex(Me.pnlCondition, 0)
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.btnLogin, 0)
        Me.pnlCondition.ResumeLayout(False)
        Me.pnlCondition.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtUser As TextBoxBase
    Friend WithEvents txtPass As TextBoxBase
    Friend WithEvents btnClose As ButtonBase
    Friend WithEvents btnLogin As ButtonBase
    Friend WithEvents lblPass As LabelBase
    Friend WithEvents lblUser As LabelBase
End Class
