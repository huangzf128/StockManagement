<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDashboard
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
        Me.pnlDashboard = New System.Windows.Forms.Panel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnStockIn = New System.Windows.Forms.Button()
        Me.btnStockOut = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnStockReserve = New System.Windows.Forms.Button()
        Me.btnStockHistory = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDashboard
        '
        Me.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDashboard.Location = New System.Drawing.Point(140, 45)
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Size = New System.Drawing.Size(924, 596)
        Me.pnlDashboard.TabIndex = 3
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.DarkCyan
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.btnMin)
        Me.pnlHeader.Controls.Add(Me.btnClose)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1064, 45)
        Me.pnlHeader.TabIndex = 4
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("MS PGothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTitle.Location = New System.Drawing.Point(23, 11)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(149, 22)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "ダッシュボード"
        '
        'btnMin
        '
        Me.btnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnMin.ForeColor = System.Drawing.SystemColors.Control
        Me.btnMin.Location = New System.Drawing.Point(988, 4)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(30, 24)
        Me.btnMin.TabIndex = 1
        Me.btnMin.Text = "―"
        Me.btnMin.UseCompatibleTextRendering = True
        Me.btnMin.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Goldenrod
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.Control
        Me.btnClose.Location = New System.Drawing.Point(1024, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 24)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "×"
        Me.btnClose.UseCompatibleTextRendering = True
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pnlMenu
        '
        Me.pnlMenu.BackgroundImage = Global.StockManagement.My.Resources.Resources.Dark_Ocean
        Me.pnlMenu.Controls.Add(Me.Button1)
        Me.pnlMenu.Controls.Add(Me.btnStockIn)
        Me.pnlMenu.Controls.Add(Me.btnStockOut)
        Me.pnlMenu.Controls.Add(Me.btnDashboard)
        Me.pnlMenu.Controls.Add(Me.btnStockReserve)
        Me.pnlMenu.Controls.Add(Me.btnStockHistory)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 45)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(140, 596)
        Me.pnlMenu.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Goldenrod
        Me.Button1.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(54, 545)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "終了"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnStockIn
        '
        Me.btnStockIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStockIn.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStockIn.Location = New System.Drawing.Point(12, 231)
        Me.btnStockIn.Name = "btnStockIn"
        Me.btnStockIn.Size = New System.Drawing.Size(117, 27)
        Me.btnStockIn.TabIndex = 8
        Me.btnStockIn.Text = "入　庫"
        Me.btnStockIn.UseVisualStyleBackColor = True
        '
        'btnStockOut
        '
        Me.btnStockOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStockOut.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStockOut.Location = New System.Drawing.Point(12, 198)
        Me.btnStockOut.Name = "btnStockOut"
        Me.btnStockOut.Size = New System.Drawing.Size(117, 27)
        Me.btnStockOut.TabIndex = 9
        Me.btnStockOut.Text = "出　庫"
        Me.btnStockOut.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDashboard.Location = New System.Drawing.Point(12, 49)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(117, 27)
        Me.btnDashboard.TabIndex = 7
        Me.btnDashboard.Text = "ダッシュボード"
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'btnStockReserve
        '
        Me.btnStockReserve.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStockReserve.BackColor = System.Drawing.SystemColors.Control
        Me.btnStockReserve.FlatAppearance.BorderSize = 0
        Me.btnStockReserve.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStockReserve.Location = New System.Drawing.Point(12, 134)
        Me.btnStockReserve.Name = "btnStockReserve"
        Me.btnStockReserve.Size = New System.Drawing.Size(117, 27)
        Me.btnStockReserve.TabIndex = 6
        Me.btnStockReserve.Text = "受注引当履歴"
        Me.btnStockReserve.UseVisualStyleBackColor = False
        '
        'btnStockHistory
        '
        Me.btnStockHistory.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStockHistory.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStockHistory.Location = New System.Drawing.Point(12, 101)
        Me.btnStockHistory.Name = "btnStockHistory"
        Me.btnStockHistory.Size = New System.Drawing.Size(117, 27)
        Me.btnStockHistory.TabIndex = 5
        Me.btnStockHistory.Text = "入出庫履歴"
        Me.btnStockHistory.UseVisualStyleBackColor = True
        '
        'FrmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 641)
        Me.Controls.Add(Me.pnlDashboard)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlHeader)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "FrmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ダシュボード"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnMin As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnStockReserve As Button
    Friend WithEvents btnStockHistory As Button
    Friend WithEvents btnStockIn As Button
    Friend WithEvents btnStockOut As Button
    Friend WithEvents Button1 As Button
End Class
