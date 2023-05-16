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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlDashboard = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lblServerLastUpdatedTime = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblSystemTitle = New System.Windows.Forms.Label()
        Me.grdBacklogReserv = New System.Windows.Forms.DataGridView()
        Me.interval = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblUntreated = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnLogout = New StockManagement.ButtonBase()
        Me.btnLogin = New StockManagement.ButtonBase()
        Me.linkVersion = New System.Windows.Forms.LinkLabel()
        Me.btnStockListHistory = New System.Windows.Forms.Button()
        Me.btnRanking = New System.Windows.Forms.Button()
        Me.btnStockList = New System.Windows.Forms.Button()
        Me.btnCloseMenu = New System.Windows.Forms.Button()
        Me.btnStockIn = New System.Windows.Forms.Button()
        Me.btnStockOut = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnStockReserve = New System.Windows.Forms.Button()
        Me.btnStockHistory = New System.Windows.Forms.Button()
        Me.pnlDashboard.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdBacklogReserv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDashboard
        '
        Me.pnlDashboard.BackColor = System.Drawing.Color.Bisque
        Me.pnlDashboard.Controls.Add(Me.GroupBox1)
        Me.pnlDashboard.Controls.Add(Me.lblServerLastUpdatedTime)
        Me.pnlDashboard.Controls.Add(Me.lbl1)
        Me.pnlDashboard.Controls.Add(Me.lblSystemTitle)
        Me.pnlDashboard.Controls.Add(Me.grdBacklogReserv)
        Me.pnlDashboard.Controls.Add(Me.lblUntreated)
        Me.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDashboard.Location = New System.Drawing.Point(140, 40)
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Size = New System.Drawing.Size(924, 575)
        Me.pnlDashboard.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(17, 464)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 75)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "システムツール"
        Me.GroupBox1.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(21, 21)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(65, 12)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "マニュアル"
        '
        'lblServerLastUpdatedTime
        '
        Me.lblServerLastUpdatedTime.AutoSize = True
        Me.lblServerLastUpdatedTime.Font = New System.Drawing.Font("メイリオ", 10.0!)
        Me.lblServerLastUpdatedTime.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.lblServerLastUpdatedTime.Location = New System.Drawing.Point(213, 73)
        Me.lblServerLastUpdatedTime.Name = "lblServerLastUpdatedTime"
        Me.lblServerLastUpdatedTime.Size = New System.Drawing.Size(165, 21)
        Me.lblServerLastUpdatedTime.TabIndex = 4
        Me.lblServerLastUpdatedTime.Text = "2001/01/01 01:01:01"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("メイリオ", 11.0!)
        Me.lbl1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.lbl1.Location = New System.Drawing.Point(16, 72)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(205, 23)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "サーバー最終自動処理日時："
        '
        'lblSystemTitle
        '
        Me.lblSystemTitle.AutoSize = True
        Me.lblSystemTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSystemTitle.Font = New System.Drawing.Font("メイリオ", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblSystemTitle.ForeColor = System.Drawing.Color.Brown
        Me.lblSystemTitle.Location = New System.Drawing.Point(5, 5)
        Me.lblSystemTitle.Name = "lblSystemTitle"
        Me.lblSystemTitle.Padding = New System.Windows.Forms.Padding(10, 10, 150, 6)
        Me.lblSystemTitle.Size = New System.Drawing.Size(570, 61)
        Me.lblSystemTitle.TabIndex = 2
        Me.lblSystemTitle.Text = "承天貿易　在庫管理システム"
        '
        'grdBacklogReserv
        '
        Me.grdBacklogReserv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBacklogReserv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.interval, Me.dateFrom, Me.dateTo, Me.dataCount})
        Me.grdBacklogReserv.Location = New System.Drawing.Point(24, 153)
        Me.grdBacklogReserv.Name = "grdBacklogReserv"
        Me.grdBacklogReserv.RowHeadersVisible = False
        Me.grdBacklogReserv.RowTemplate.Height = 23
        Me.grdBacklogReserv.Size = New System.Drawing.Size(333, 97)
        Me.grdBacklogReserv.TabIndex = 0
        '
        'interval
        '
        Me.interval.DataPropertyName = "interval"
        Me.interval.HeaderText = "期間"
        Me.interval.Name = "interval"
        Me.interval.Width = 80
        '
        'dateFrom
        '
        Me.dateFrom.DataPropertyName = "dateFrom"
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.dateFrom.DefaultCellStyle = DataGridViewCellStyle4
        Me.dateFrom.HeaderText = "開始日"
        Me.dateFrom.Name = "dateFrom"
        Me.dateFrom.Width = 80
        '
        'dateTo
        '
        Me.dateTo.DataPropertyName = "dateTo"
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.dateTo.DefaultCellStyle = DataGridViewCellStyle5
        Me.dateTo.HeaderText = "終了日"
        Me.dateTo.Name = "dateTo"
        Me.dateTo.Width = 80
        '
        'dataCount
        '
        Me.dataCount.DataPropertyName = "dataCount"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.dataCount.DefaultCellStyle = DataGridViewCellStyle6
        Me.dataCount.HeaderText = "未処理件数"
        Me.dataCount.Name = "dataCount"
        Me.dataCount.Width = 90
        '
        'lblUntreated
        '
        Me.lblUntreated.AutoSize = True
        Me.lblUntreated.Font = New System.Drawing.Font("メイリオ", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblUntreated.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblUntreated.Location = New System.Drawing.Point(13, 129)
        Me.lblUntreated.Name = "lblUntreated"
        Me.lblUntreated.Size = New System.Drawing.Size(85, 23)
        Me.lblUntreated.TabIndex = 1
        Me.lblUntreated.Text = "未処理受注"
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
        Me.pnlHeader.Size = New System.Drawing.Size(1064, 40)
        Me.pnlHeader.TabIndex = 4
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
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
        Me.btnMin.Location = New System.Drawing.Point(988, 8)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(30, 24)
        Me.btnMin.TabIndex = 1
        Me.btnMin.TabStop = False
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
        Me.btnClose.Location = New System.Drawing.Point(1024, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 24)
        Me.btnClose.TabIndex = 0
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "×"
        Me.btnClose.UseCompatibleTextRendering = True
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pnlMenu
        '
        Me.pnlMenu.BackgroundImage = Global.StockManagement.My.Resources.Resources.Dark_Ocean
        Me.pnlMenu.Controls.Add(Me.btnLogout)
        Me.pnlMenu.Controls.Add(Me.btnLogin)
        Me.pnlMenu.Controls.Add(Me.linkVersion)
        Me.pnlMenu.Controls.Add(Me.btnStockListHistory)
        Me.pnlMenu.Controls.Add(Me.btnRanking)
        Me.pnlMenu.Controls.Add(Me.btnStockList)
        Me.pnlMenu.Controls.Add(Me.btnCloseMenu)
        Me.pnlMenu.Controls.Add(Me.btnStockIn)
        Me.pnlMenu.Controls.Add(Me.btnStockOut)
        Me.pnlMenu.Controls.Add(Me.btnDashboard)
        Me.pnlMenu.Controls.Add(Me.btnStockReserve)
        Me.pnlMenu.Controls.Add(Me.btnStockHistory)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 40)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(140, 575)
        Me.pnlMenu.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.DimGray
        Me.btnLogout.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogout.Location = New System.Drawing.Point(58, 464)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(70, 30)
        Me.btnLogout.TabIndex = 12
        Me.btnLogout.Text = "ログアウト"
        Me.btnLogout.Type = 4
        Me.btnLogout.UseVisualStyleBackColor = False
        Me.btnLogout.Visible = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.DarkGreen
        Me.btnLogin.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogin.Location = New System.Drawing.Point(58, 463)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(70, 30)
        Me.btnLogin.TabIndex = 11
        Me.btnLogin.Text = "ログイン"
        Me.btnLogin.Type = 3
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'linkVersion
        '
        Me.linkVersion.AutoSize = True
        Me.linkVersion.BackColor = System.Drawing.Color.Transparent
        Me.linkVersion.ForeColor = System.Drawing.SystemColors.Control
        Me.linkVersion.LinkColor = System.Drawing.SystemColors.Control
        Me.linkVersion.Location = New System.Drawing.Point(33, 554)
        Me.linkVersion.Name = "linkVersion"
        Me.linkVersion.Size = New System.Drawing.Size(89, 12)
        Me.linkVersion.TabIndex = 10
        Me.linkVersion.TabStop = True
        Me.linkVersion.Text = "AppVer:1.0.0.0"
        Me.linkVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnStockListHistory
        '
        Me.btnStockListHistory.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!)
        Me.btnStockListHistory.Location = New System.Drawing.Point(12, 200)
        Me.btnStockListHistory.Name = "btnStockListHistory"
        Me.btnStockListHistory.Size = New System.Drawing.Size(117, 25)
        Me.btnStockListHistory.TabIndex = 5
        Me.btnStockListHistory.Text = "在庫履歴一覧"
        Me.btnStockListHistory.UseVisualStyleBackColor = True
        '
        'btnRanking
        '
        Me.btnRanking.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!)
        Me.btnRanking.Location = New System.Drawing.Point(12, 251)
        Me.btnRanking.Name = "btnRanking"
        Me.btnRanking.Size = New System.Drawing.Size(117, 25)
        Me.btnRanking.TabIndex = 6
        Me.btnRanking.Text = "売上ランキング"
        Me.btnRanking.UseVisualStyleBackColor = True
        '
        'btnStockList
        '
        Me.btnStockList.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnStockList.Location = New System.Drawing.Point(12, 170)
        Me.btnStockList.Name = "btnStockList"
        Me.btnStockList.Size = New System.Drawing.Size(117, 25)
        Me.btnStockList.TabIndex = 4
        Me.btnStockList.Text = "在庫一覧"
        Me.btnStockList.UseVisualStyleBackColor = True
        '
        'btnCloseMenu
        '
        Me.btnCloseMenu.BackColor = System.Drawing.Color.Goldenrod
        Me.btnCloseMenu.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnCloseMenu.Location = New System.Drawing.Point(54, 512)
        Me.btnCloseMenu.Name = "btnCloseMenu"
        Me.btnCloseMenu.Size = New System.Drawing.Size(75, 27)
        Me.btnCloseMenu.TabIndex = 9
        Me.btnCloseMenu.Text = "終了"
        Me.btnCloseMenu.UseVisualStyleBackColor = False
        '
        'btnStockIn
        '
        Me.btnStockIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStockIn.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStockIn.Location = New System.Drawing.Point(12, 384)
        Me.btnStockIn.Name = "btnStockIn"
        Me.btnStockIn.Size = New System.Drawing.Size(117, 27)
        Me.btnStockIn.TabIndex = 8
        Me.btnStockIn.Text = "入　庫"
        Me.btnStockIn.UseVisualStyleBackColor = True
        Me.btnStockIn.Visible = False
        '
        'btnStockOut
        '
        Me.btnStockOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStockOut.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStockOut.Location = New System.Drawing.Point(12, 351)
        Me.btnStockOut.Name = "btnStockOut"
        Me.btnStockOut.Size = New System.Drawing.Size(117, 27)
        Me.btnStockOut.TabIndex = 7
        Me.btnStockOut.Text = "出　庫"
        Me.btnStockOut.UseVisualStyleBackColor = True
        Me.btnStockOut.Visible = False
        '
        'btnDashboard
        '
        Me.btnDashboard.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDashboard.FlatAppearance.BorderSize = 3
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnDashboard.Location = New System.Drawing.Point(12, 11)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(117, 25)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "ダッシュボード"
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'btnStockReserve
        '
        Me.btnStockReserve.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStockReserve.BackColor = System.Drawing.SystemColors.Control
        Me.btnStockReserve.FlatAppearance.BorderSize = 0
        Me.btnStockReserve.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStockReserve.Location = New System.Drawing.Point(12, 117)
        Me.btnStockReserve.Name = "btnStockReserve"
        Me.btnStockReserve.Size = New System.Drawing.Size(117, 25)
        Me.btnStockReserve.TabIndex = 3
        Me.btnStockReserve.Text = "自動引当履歴"
        Me.btnStockReserve.UseVisualStyleBackColor = False
        '
        'btnStockHistory
        '
        Me.btnStockHistory.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStockHistory.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStockHistory.Location = New System.Drawing.Point(12, 87)
        Me.btnStockHistory.Name = "btnStockHistory"
        Me.btnStockHistory.Size = New System.Drawing.Size(117, 25)
        Me.btnStockHistory.TabIndex = 2
        Me.btnStockHistory.Text = "入出庫履歴"
        Me.btnStockHistory.UseVisualStyleBackColor = True
        '
        'FrmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 615)
        Me.Controls.Add(Me.pnlDashboard)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlHeader)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "FrmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ダッシュボード"
        Me.pnlDashboard.ResumeLayout(False)
        Me.pnlDashboard.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdBacklogReserv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
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
    Friend WithEvents btnCloseMenu As Button
    Friend WithEvents btnStockList As Button
    Friend WithEvents btnRanking As Button
    Friend WithEvents grdBacklogReserv As DataGridView
    Friend WithEvents lblUntreated As Label
    Friend WithEvents btnStockListHistory As Button
    Friend WithEvents lblSystemTitle As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lblServerLastUpdatedTime As Label
    Friend WithEvents linkVersion As LinkLabel
    Friend WithEvents btnLogin As ButtonBase
    Friend WithEvents btnLogout As ButtonBase
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents interval As DataGridViewTextBoxColumn
    Friend WithEvents dateFrom As DataGridViewTextBoxColumn
    Friend WithEvents dateTo As DataGridViewTextBoxColumn
    Friend WithEvents dataCount As DataGridViewTextBoxColumn
End Class
