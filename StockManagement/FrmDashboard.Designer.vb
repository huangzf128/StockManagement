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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlDashboard = New System.Windows.Forms.Panel()
        Me.lblShowMoving = New System.Windows.Forms.Label()
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
        Me.btnStockListHistory = New System.Windows.Forms.Button()
        Me.btnRanking = New System.Windows.Forms.Button()
        Me.btnStockList = New System.Windows.Forms.Button()
        Me.btnCloseMenu = New System.Windows.Forms.Button()
        Me.btnStockIn = New System.Windows.Forms.Button()
        Me.btnStockOut = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnStockReserve = New System.Windows.Forms.Button()
        Me.btnStockHistory = New System.Windows.Forms.Button()
        Me.linkVersion = New System.Windows.Forms.LinkLabel()
        Me.pnlDashboard.SuspendLayout()
        CType(Me.grdBacklogReserv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDashboard
        '
        Me.pnlDashboard.Controls.Add(Me.lblShowMoving)
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
        'lblShowMoving
        '
        Me.lblShowMoving.AutoSize = True
        Me.lblShowMoving.Font = New System.Drawing.Font("メイリオ", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblShowMoving.Location = New System.Drawing.Point(13, 276)
        Me.lblShowMoving.Name = "lblShowMoving"
        Me.lblShowMoving.Size = New System.Drawing.Size(0, 23)
        Me.lblShowMoving.TabIndex = 5
        '
        'lblServerLastUpdatedTime
        '
        Me.lblServerLastUpdatedTime.AutoSize = True
        Me.lblServerLastUpdatedTime.Font = New System.Drawing.Font("メイリオ", 10.0!)
        Me.lblServerLastUpdatedTime.Location = New System.Drawing.Point(197, 72)
        Me.lblServerLastUpdatedTime.Name = "lblServerLastUpdatedTime"
        Me.lblServerLastUpdatedTime.Size = New System.Drawing.Size(165, 21)
        Me.lblServerLastUpdatedTime.TabIndex = 4
        Me.lblServerLastUpdatedTime.Text = "2001/01/01 01:01:01"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("メイリオ", 10.0!)
        Me.lbl1.Location = New System.Drawing.Point(9, 72)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(192, 21)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "サーバー最終自動処理日時："
        '
        'lblSystemTitle
        '
        Me.lblSystemTitle.AutoSize = True
        Me.lblSystemTitle.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblSystemTitle.Font = New System.Drawing.Font("メイリオ", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblSystemTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSystemTitle.Location = New System.Drawing.Point(5, 5)
        Me.lblSystemTitle.Name = "lblSystemTitle"
        Me.lblSystemTitle.Padding = New System.Windows.Forms.Padding(10, 10, 150, 6)
        Me.lblSystemTitle.Size = New System.Drawing.Size(461, 49)
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
        DataGridViewCellStyle13.Format = "d"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.dateFrom.DefaultCellStyle = DataGridViewCellStyle13
        Me.dateFrom.HeaderText = "開始日"
        Me.dateFrom.Name = "dateFrom"
        Me.dateFrom.Width = 80
        '
        'dateTo
        '
        Me.dateTo.DataPropertyName = "dateTo"
        DataGridViewCellStyle14.Format = "d"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.dateTo.DefaultCellStyle = DataGridViewCellStyle14
        Me.dateTo.HeaderText = "終了日"
        Me.dateTo.Name = "dateTo"
        Me.dateTo.Width = 80
        '
        'dataCount
        '
        Me.dataCount.DataPropertyName = "dataCount"
        Me.dataCount.HeaderText = "未処理件数"
        Me.dataCount.Name = "dataCount"
        Me.dataCount.Width = 90
        '
        'lblUntreated
        '
        Me.lblUntreated.AutoSize = True
        Me.lblUntreated.Font = New System.Drawing.Font("メイリオ", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
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
        'btnStockListHistory
        '
        Me.btnStockListHistory.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!)
        Me.btnStockListHistory.Location = New System.Drawing.Point(12, 194)
        Me.btnStockListHistory.Name = "btnStockListHistory"
        Me.btnStockListHistory.Size = New System.Drawing.Size(117, 25)
        Me.btnStockListHistory.TabIndex = 5
        Me.btnStockListHistory.Text = "在庫履歴一覧"
        Me.btnStockListHistory.UseVisualStyleBackColor = True
        '
        'btnRanking
        '
        Me.btnRanking.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!)
        Me.btnRanking.Location = New System.Drawing.Point(12, 236)
        Me.btnRanking.Name = "btnRanking"
        Me.btnRanking.Size = New System.Drawing.Size(117, 25)
        Me.btnRanking.TabIndex = 6
        Me.btnRanking.Text = "売上ランキング"
        Me.btnRanking.UseVisualStyleBackColor = True
        '
        'btnStockList
        '
        Me.btnStockList.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnStockList.Location = New System.Drawing.Point(12, 163)
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
        Me.btnStockIn.Location = New System.Drawing.Point(12, 349)
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
        Me.btnStockOut.Location = New System.Drawing.Point(12, 316)
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
        Me.btnStockReserve.Location = New System.Drawing.Point(12, 121)
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
        Me.btnStockHistory.Location = New System.Drawing.Point(12, 90)
        Me.btnStockHistory.Name = "btnStockHistory"
        Me.btnStockHistory.Size = New System.Drawing.Size(117, 25)
        Me.btnStockHistory.TabIndex = 2
        Me.btnStockHistory.Text = "入出庫履歴"
        Me.btnStockHistory.UseVisualStyleBackColor = True
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
    Friend WithEvents interval As DataGridViewTextBoxColumn
    Friend WithEvents dateFrom As DataGridViewTextBoxColumn
    Friend WithEvents dateTo As DataGridViewTextBoxColumn
    Friend WithEvents dataCount As DataGridViewTextBoxColumn
    Friend WithEvents btnStockListHistory As Button
    Friend WithEvents lblSystemTitle As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lblServerLastUpdatedTime As Label
    Friend WithEvents lblShowMoving As Label
    Friend WithEvents linkVersion As LinkLabel
End Class
