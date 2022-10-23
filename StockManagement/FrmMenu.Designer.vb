<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnStockIn = New System.Windows.Forms.Button()
        Me.btnStockHistory = New System.Windows.Forms.Button()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnStockReserve = New System.Windows.Forms.Button()
        Me.btnStockOut = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.pnlFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("MS PGothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(227, 41)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "承天　在庫管理システム"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStockIn
        '
        Me.btnStockIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStockIn.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStockIn.Location = New System.Drawing.Point(16, 220)
        Me.btnStockIn.Name = "btnStockIn"
        Me.btnStockIn.Size = New System.Drawing.Size(117, 27)
        Me.btnStockIn.TabIndex = 0
        Me.btnStockIn.Text = "入　庫"
        Me.btnStockIn.UseVisualStyleBackColor = True
        '
        'btnStockHistory
        '
        Me.btnStockHistory.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStockHistory.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStockHistory.Location = New System.Drawing.Point(16, 121)
        Me.btnStockHistory.Name = "btnStockHistory"
        Me.btnStockHistory.Size = New System.Drawing.Size(117, 27)
        Me.btnStockHistory.TabIndex = 1
        Me.btnStockHistory.Text = "入出庫履歴"
        Me.btnStockHistory.UseVisualStyleBackColor = True
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.Transparent
        Me.pnlFooter.Controls.Add(Me.btnClose)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 489)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(227, 50)
        Me.pnlFooter.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Goldenrod
        Me.btnClose.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnClose.Location = New System.Drawing.Point(118, 13)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 27)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "終了"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MS PGothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "サーバー最終自動処理日時："
        '
        'btnStockReserve
        '
        Me.btnStockReserve.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStockReserve.BackColor = System.Drawing.SystemColors.Control
        Me.btnStockReserve.FlatAppearance.BorderSize = 0
        Me.btnStockReserve.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStockReserve.Location = New System.Drawing.Point(16, 154)
        Me.btnStockReserve.Name = "btnStockReserve"
        Me.btnStockReserve.Size = New System.Drawing.Size(117, 27)
        Me.btnStockReserve.TabIndex = 3
        Me.btnStockReserve.Text = "受注引当履歴"
        Me.btnStockReserve.UseVisualStyleBackColor = False
        '
        'btnStockOut
        '
        Me.btnStockOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStockOut.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStockOut.Location = New System.Drawing.Point(16, 187)
        Me.btnStockOut.Name = "btnStockOut"
        Me.btnStockOut.Size = New System.Drawing.Size(117, 27)
        Me.btnStockOut.TabIndex = 2
        Me.btnStockOut.Text = "出　庫"
        Me.btnStockOut.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Location = New System.Drawing.Point(16, 83)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(117, 27)
        Me.btnDashboard.TabIndex = 4
        Me.btnDashboard.Text = "ダッシュボード"
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StockManagement.My.Resources.Resources.Dark_Ocean
        Me.ClientSize = New System.Drawing.Size(227, 539)
        Me.Controls.Add(Me.btnDashboard)
        Me.Controls.Add(Me.btnStockReserve)
        Me.Controls.Add(Me.btnStockHistory)
        Me.Controls.Add(Me.btnStockIn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.btnStockOut)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "メニュー"
        Me.pnlFooter.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents btnStockIn As Button
    Friend WithEvents btnStockHistory As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnStockOut As Button
    Friend WithEvents btnStockReserve As Button
    Friend WithEvents btnDashboard As Button
End Class
