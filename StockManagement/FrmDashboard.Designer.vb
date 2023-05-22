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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDashboard))
        Me.pnlDashboard = New System.Windows.Forms.Panel()
        Me.grpSrvTime = New System.Windows.Forms.GroupBox()
        Me.lblSrvTime = New StockManagement.LabelBase()
        Me.lblServerLastUpdatedTime = New StockManagement.LabelBase()
        Me.lblUntreated = New StockManagement.LabelBase()
        Me.lblSystemTitle = New StockManagement.LabelBase()
        Me.grp = New System.Windows.Forms.GroupBox()
        Me.lnkShowLog = New StockManagement.LinkBase()
        Me.chkDarkMode = New StockManagement.CheckBoxBase()
        Me.lnkShowManual = New System.Windows.Forms.LinkLabel()
        Me.grdBacklogReserv = New System.Windows.Forms.DataGridView()
        Me.interval = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnCloseMenu = New StockManagement.ButtonBase()
        Me.btnLogout = New StockManagement.ButtonBase()
        Me.btnLogin = New StockManagement.ButtonBase()
        Me.btnStockListHistory = New System.Windows.Forms.Button()
        Me.btnRanking = New System.Windows.Forms.Button()
        Me.btnStockList = New System.Windows.Forms.Button()
        Me.btnStockIn = New System.Windows.Forms.Button()
        Me.btnStockOut = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnStockReserve = New System.Windows.Forms.Button()
        Me.btnStockHistory = New System.Windows.Forms.Button()
        Me.lblVersion = New StockManagement.LabelBase()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.pnlDashboard.SuspendLayout()
        Me.grpSrvTime.SuspendLayout()
        Me.grp.SuspendLayout()
        CType(Me.grdBacklogReserv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDashboard
        '
        Me.pnlDashboard.BackColor = System.Drawing.SystemColors.Control
        Me.pnlDashboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlDashboard.Controls.Add(Me.grpSrvTime)
        Me.pnlDashboard.Controls.Add(Me.lblUntreated)
        Me.pnlDashboard.Controls.Add(Me.lblSystemTitle)
        Me.pnlDashboard.Controls.Add(Me.grp)
        Me.pnlDashboard.Controls.Add(Me.grdBacklogReserv)
        Me.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDashboard.Location = New System.Drawing.Point(140, 32)
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Size = New System.Drawing.Size(924, 561)
        Me.pnlDashboard.TabIndex = 3
        '
        'grpSrvTime
        '
        Me.grpSrvTime.Controls.Add(Me.lblSrvTime)
        Me.grpSrvTime.Controls.Add(Me.lblServerLastUpdatedTime)
        Me.grpSrvTime.Location = New System.Drawing.Point(17, 67)
        Me.grpSrvTime.Name = "grpSrvTime"
        Me.grpSrvTime.Size = New System.Drawing.Size(429, 50)
        Me.grpSrvTime.TabIndex = 11
        Me.grpSrvTime.TabStop = False
        '
        'lblSrvTime
        '
        Me.lblSrvTime.AutoSize = True
        Me.lblSrvTime.Font = New System.Drawing.Font("Meiryo", 11.0!)
        Me.lblSrvTime.Location = New System.Drawing.Point(6, 17)
        Me.lblSrvTime.Name = "lblSrvTime"
        Me.lblSrvTime.Size = New System.Drawing.Size(205, 23)
        Me.lblSrvTime.TabIndex = 8
        Me.lblSrvTime.Text = "サーバー最終自動処理日時："
        Me.lblSrvTime.Type = 0
        '
        'lblServerLastUpdatedTime
        '
        Me.lblServerLastUpdatedTime.AutoSize = True
        Me.lblServerLastUpdatedTime.Font = New System.Drawing.Font("Meiryo", 10.0!)
        Me.lblServerLastUpdatedTime.Location = New System.Drawing.Point(206, 18)
        Me.lblServerLastUpdatedTime.Name = "lblServerLastUpdatedTime"
        Me.lblServerLastUpdatedTime.Size = New System.Drawing.Size(165, 21)
        Me.lblServerLastUpdatedTime.TabIndex = 9
        Me.lblServerLastUpdatedTime.Text = "2001/01/01 01:01:01"
        Me.lblServerLastUpdatedTime.Type = 0
        '
        'lblUntreated
        '
        Me.lblUntreated.AutoSize = True
        Me.lblUntreated.Font = New System.Drawing.Font("Meiryo", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblUntreated.Location = New System.Drawing.Point(19, 148)
        Me.lblUntreated.Name = "lblUntreated"
        Me.lblUntreated.Size = New System.Drawing.Size(85, 23)
        Me.lblUntreated.TabIndex = 10
        Me.lblUntreated.Text = "未処理受注"
        Me.lblUntreated.Type = 0
        '
        'lblSystemTitle
        '
        Me.lblSystemTitle.AutoSize = True
        Me.lblSystemTitle.Font = New System.Drawing.Font("Meiryo", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemTitle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblSystemTitle.Location = New System.Drawing.Point(3, 4)
        Me.lblSystemTitle.Name = "lblSystemTitle"
        Me.lblSystemTitle.Size = New System.Drawing.Size(396, 44)
        Me.lblSystemTitle.TabIndex = 7
        Me.lblSystemTitle.Text = "承天貿易　在庫管理システム"
        Me.lblSystemTitle.Type = 0
        '
        'grp
        '
        Me.grp.Controls.Add(Me.lnkShowLog)
        Me.grp.Controls.Add(Me.chkDarkMode)
        Me.grp.Controls.Add(Me.lnkShowManual)
        Me.grp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grp.Location = New System.Drawing.Point(17, 448)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(316, 91)
        Me.grp.TabIndex = 5
        Me.grp.TabStop = False
        Me.grp.Text = "システムツール"
        '
        'lnkShowLog
        '
        Me.lnkShowLog.AutoSize = True
        Me.lnkShowLog.Location = New System.Drawing.Point(14, 61)
        Me.lnkShowLog.Name = "lnkShowLog"
        Me.lnkShowLog.Size = New System.Drawing.Size(53, 12)
        Me.lnkShowLog.TabIndex = 7
        Me.lnkShowLog.TabStop = True
        Me.lnkShowLog.Text = "ログ表示"
        Me.lnkShowLog.Type = 0
        '
        'chkDarkMode
        '
        Me.chkDarkMode.AutoSize = True
        Me.chkDarkMode.Location = New System.Drawing.Point(16, 25)
        Me.chkDarkMode.Name = "chkDarkMode"
        Me.chkDarkMode.Size = New System.Drawing.Size(96, 16)
        Me.chkDarkMode.TabIndex = 6
        Me.chkDarkMode.Text = "ダークテーマ"
        Me.chkDarkMode.Type = 0
        Me.chkDarkMode.UseVisualStyleBackColor = True
        '
        'lnkShowManual
        '
        Me.lnkShowManual.AutoSize = True
        Me.lnkShowManual.Location = New System.Drawing.Point(91, 61)
        Me.lnkShowManual.Name = "lnkShowManual"
        Me.lnkShowManual.Size = New System.Drawing.Size(65, 12)
        Me.lnkShowManual.TabIndex = 0
        Me.lnkShowManual.TabStop = True
        Me.lnkShowManual.Text = "マニュアル"
        Me.lnkShowManual.Visible = False
        '
        'grdBacklogReserv
        '
        Me.grdBacklogReserv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBacklogReserv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.interval, Me.dateFrom, Me.dateTo, Me.dataCount})
        Me.grdBacklogReserv.Location = New System.Drawing.Point(24, 177)
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
        Me.interval.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.interval.Width = 80
        '
        'dateFrom
        '
        Me.dateFrom.DataPropertyName = "dateFrom"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.dateFrom.DefaultCellStyle = DataGridViewCellStyle1
        Me.dateFrom.HeaderText = "開始日"
        Me.dateFrom.Name = "dateFrom"
        Me.dateFrom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dateFrom.Width = 80
        '
        'dateTo
        '
        Me.dateTo.DataPropertyName = "dateTo"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.dateTo.DefaultCellStyle = DataGridViewCellStyle2
        Me.dateTo.HeaderText = "終了日"
        Me.dateTo.Name = "dateTo"
        Me.dateTo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dateTo.Width = 80
        '
        'dataCount
        '
        Me.dataCount.DataPropertyName = "dataCount"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.dataCount.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataCount.HeaderText = "未処理件数"
        Me.dataCount.Name = "dataCount"
        Me.dataCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dataCount.Width = 90
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
        Me.pnlHeader.Size = New System.Drawing.Size(1064, 32)
        Me.pnlHeader.TabIndex = 4
        Me.pnlHeader.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("MS PGothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTitle.Location = New System.Drawing.Point(23, 6)
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
        Me.btnClose.Location = New System.Drawing.Point(1024, 4)
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
        Me.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlMenu.Controls.Add(Me.btnCloseMenu)
        Me.pnlMenu.Controls.Add(Me.btnLogout)
        Me.pnlMenu.Controls.Add(Me.btnLogin)
        Me.pnlMenu.Controls.Add(Me.btnStockListHistory)
        Me.pnlMenu.Controls.Add(Me.btnRanking)
        Me.pnlMenu.Controls.Add(Me.btnStockList)
        Me.pnlMenu.Controls.Add(Me.btnStockIn)
        Me.pnlMenu.Controls.Add(Me.btnStockOut)
        Me.pnlMenu.Controls.Add(Me.btnDashboard)
        Me.pnlMenu.Controls.Add(Me.btnStockReserve)
        Me.pnlMenu.Controls.Add(Me.btnStockHistory)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 32)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(140, 561)
        Me.pnlMenu.TabIndex = 0
        '
        'btnCloseMenu
        '
        Me.btnCloseMenu.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCloseMenu.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnCloseMenu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCloseMenu.Location = New System.Drawing.Point(50, 488)
        Me.btnCloseMenu.Name = "btnCloseMenu"
        Me.btnCloseMenu.Size = New System.Drawing.Size(70, 30)
        Me.btnCloseMenu.TabIndex = 13
        Me.btnCloseMenu.Text = "終　了"
        Me.btnCloseMenu.Type = 1
        Me.btnCloseMenu.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnLogout.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLogout.Location = New System.Drawing.Point(50, 452)
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
        Me.btnLogin.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnLogin.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLogin.Location = New System.Drawing.Point(50, 451)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(70, 30)
        Me.btnLogin.TabIndex = 11
        Me.btnLogin.Text = "ログイン"
        Me.btnLogin.Type = 3
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnStockListHistory
        '
        Me.btnStockListHistory.Font = New System.Drawing.Font("MS PGothic", 9.0!)
        Me.btnStockListHistory.Location = New System.Drawing.Point(12, 200)
        Me.btnStockListHistory.Name = "btnStockListHistory"
        Me.btnStockListHistory.Size = New System.Drawing.Size(117, 25)
        Me.btnStockListHistory.TabIndex = 5
        Me.btnStockListHistory.Text = "在庫履歴一覧"
        Me.btnStockListHistory.UseVisualStyleBackColor = False
        '
        'btnRanking
        '
        Me.btnRanking.Font = New System.Drawing.Font("MS PGothic", 9.0!)
        Me.btnRanking.Location = New System.Drawing.Point(12, 251)
        Me.btnRanking.Name = "btnRanking"
        Me.btnRanking.Size = New System.Drawing.Size(117, 25)
        Me.btnRanking.TabIndex = 6
        Me.btnRanking.Text = "売上ランキング"
        Me.btnRanking.UseVisualStyleBackColor = False
        '
        'btnStockList
        '
        Me.btnStockList.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnStockList.Location = New System.Drawing.Point(12, 170)
        Me.btnStockList.Name = "btnStockList"
        Me.btnStockList.Size = New System.Drawing.Size(117, 25)
        Me.btnStockList.TabIndex = 4
        Me.btnStockList.Text = "在庫一覧"
        Me.btnStockList.UseVisualStyleBackColor = False
        '
        'btnStockIn
        '
        Me.btnStockIn.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStockIn.Location = New System.Drawing.Point(12, 376)
        Me.btnStockIn.Name = "btnStockIn"
        Me.btnStockIn.Size = New System.Drawing.Size(117, 27)
        Me.btnStockIn.TabIndex = 8
        Me.btnStockIn.Text = "入　庫"
        Me.btnStockIn.UseVisualStyleBackColor = True
        Me.btnStockIn.Visible = False
        '
        'btnStockOut
        '
        Me.btnStockOut.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStockOut.Location = New System.Drawing.Point(12, 343)
        Me.btnStockOut.Name = "btnStockOut"
        Me.btnStockOut.Size = New System.Drawing.Size(117, 27)
        Me.btnStockOut.TabIndex = 7
        Me.btnStockOut.Text = "出　庫"
        Me.btnStockOut.UseVisualStyleBackColor = True
        Me.btnStockOut.Visible = False
        '
        'btnDashboard
        '
        Me.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDashboard.FlatAppearance.BorderSize = 3
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnDashboard.Location = New System.Drawing.Point(12, 11)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(117, 25)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "ダッシュボード"
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'btnStockReserve
        '
        Me.btnStockReserve.BackColor = System.Drawing.SystemColors.Control
        Me.btnStockReserve.FlatAppearance.BorderSize = 0
        Me.btnStockReserve.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStockReserve.Location = New System.Drawing.Point(12, 117)
        Me.btnStockReserve.Name = "btnStockReserve"
        Me.btnStockReserve.Size = New System.Drawing.Size(117, 25)
        Me.btnStockReserve.TabIndex = 3
        Me.btnStockReserve.Text = "自動引当履歴"
        Me.btnStockReserve.UseVisualStyleBackColor = False
        '
        'btnStockHistory
        '
        Me.btnStockHistory.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStockHistory.Location = New System.Drawing.Point(12, 87)
        Me.btnStockHistory.Name = "btnStockHistory"
        Me.btnStockHistory.Size = New System.Drawing.Size(117, 25)
        Me.btnStockHistory.TabIndex = 2
        Me.btnStockHistory.Text = "入出庫履歴"
        Me.btnStockHistory.UseVisualStyleBackColor = False
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Location = New System.Drawing.Point(959, 5)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(47, 12)
        Me.lblVersion.TabIndex = 14
        Me.lblVersion.Text = "0.0.0.0"
        Me.lblVersion.Type = 0
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.SystemColors.Control
        Me.pnlFooter.Controls.Add(Me.lblVersion)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 593)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1064, 22)
        Me.pnlFooter.TabIndex = 12
        '
        'FrmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 615)
        Me.Controls.Add(Me.pnlDashboard)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlFooter)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "FrmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ダッシュボード"
        Me.pnlDashboard.ResumeLayout(False)
        Me.pnlDashboard.PerformLayout()
        Me.grpSrvTime.ResumeLayout(False)
        Me.grpSrvTime.PerformLayout()
        Me.grp.ResumeLayout(False)
        Me.grp.PerformLayout()
        CType(Me.grdBacklogReserv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
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
    Friend WithEvents btnStockList As Button
    Friend WithEvents btnRanking As Button
    Friend WithEvents grdBacklogReserv As DataGridView
    Friend WithEvents btnStockListHistory As Button
    Friend WithEvents btnLogin As ButtonBase
    Friend WithEvents btnLogout As ButtonBase
    Friend WithEvents grp As GroupBox
    Friend WithEvents lnkShowManual As LinkLabel
    Friend WithEvents chkDarkMode As CheckBoxBase
    Friend WithEvents lblSystemTitle As LabelBase
    Friend WithEvents lblServerLastUpdatedTime As LabelBase
    Friend WithEvents lblSrvTime As LabelBase
    Friend WithEvents grpSrvTime As GroupBox
    Friend WithEvents lblUntreated As LabelBase
    Friend WithEvents interval As DataGridViewTextBoxColumn
    Friend WithEvents dateFrom As DataGridViewTextBoxColumn
    Friend WithEvents dateTo As DataGridViewTextBoxColumn
    Friend WithEvents dataCount As DataGridViewTextBoxColumn
    Friend WithEvents btnCloseMenu As ButtonBase
    Friend WithEvents lblVersion As LabelBase
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents lnkShowLog As LinkBase
End Class
