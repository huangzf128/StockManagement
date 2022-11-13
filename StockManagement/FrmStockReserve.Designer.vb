<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmStockReserve
    Inherits FrmBase

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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtItemCd = New System.Windows.Forms.TextBox()
        Me.cmbOrdStatus = New System.Windows.Forms.ComboBox()
        Me.chkReserving = New System.Windows.Forms.CheckBox()
        Me.dgStockReserve = New System.Windows.Forms.DataGridView()
        Me.CRTDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESERVQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDERKBN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DELFLGNM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDERID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDSTATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDDLVDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INCHARGE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblOrdStatus = New System.Windows.Forms.Label()
        Me.btnSearch = New StockManagement.ButtonBase()
        Me.lblWavy = New System.Windows.Forms.Label()
        Me.UBindingNavigator1 = New StockManagement.UBindingNavigator()
        Me.dtPickerFrom = New StockManagement.UDataTimePicker()
        Me.dtPickerTo = New StockManagement.UDataTimePicker()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.pnlCondition.SuspendLayout()
        CType(Me.dgStockReserve, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCondition
        '
        Me.pnlCondition.Controls.Add(Me.dtPickerTo)
        Me.pnlCondition.Controls.Add(Me.dtPickerFrom)
        Me.pnlCondition.Controls.Add(Me.lblWavy)
        Me.pnlCondition.Controls.Add(Me.btnSearch)
        Me.pnlCondition.Controls.Add(Me.lblItemName)
        Me.pnlCondition.Controls.Add(Me.txtItemCd)
        Me.pnlCondition.Controls.Add(Me.chkReserving)
        Me.pnlCondition.Controls.Add(Me.lblOrdStatus)
        Me.pnlCondition.Controls.Add(Me.cmbOrdStatus)
        '
        'txtItemCd
        '
        Me.txtItemCd.Location = New System.Drawing.Point(88, 45)
        Me.txtItemCd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemCd.Name = "txtItemCd"
        Me.txtItemCd.Size = New System.Drawing.Size(120, 19)
        Me.txtItemCd.TabIndex = 6
        '
        'cmbOrdStatus
        '
        Me.cmbOrdStatus.FormattingEnabled = True
        Me.cmbOrdStatus.Location = New System.Drawing.Point(307, 44)
        Me.cmbOrdStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbOrdStatus.Name = "cmbOrdStatus"
        Me.cmbOrdStatus.Size = New System.Drawing.Size(129, 20)
        Me.cmbOrdStatus.TabIndex = 7
        '
        'chkReserving
        '
        Me.chkReserving.AutoSize = True
        Me.chkReserving.ForeColor = System.Drawing.SystemColors.Control
        Me.chkReserving.Location = New System.Drawing.Point(472, 46)
        Me.chkReserving.Margin = New System.Windows.Forms.Padding(2)
        Me.chkReserving.Name = "chkReserving"
        Me.chkReserving.Size = New System.Drawing.Size(84, 16)
        Me.chkReserving.TabIndex = 8
        Me.chkReserving.Text = "引当中のみ"
        Me.chkReserving.UseVisualStyleBackColor = True
        '
        'dgStockReserve
        '
        Me.dgStockReserve.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgStockReserve.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgStockReserve.AutoGenerateColumns = False
        Me.dgStockReserve.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgStockReserve.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.Font = New System.Drawing.Font("MS PGothic", 9.0!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgStockReserve.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgStockReserve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStockReserve.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CRTDT, Me.ITEMCD, Me.RESERVQTY, Me.ORDERKBN, Me.DELFLGNM, Me.ORDERID, Me.ORDSTATUS, Me.ORDDLVDT, Me.INCHARGE, Me.CUSTNAME})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(178, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgStockReserve.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgStockReserve.EnableHeadersVisualStyles = False
        Me.dgStockReserve.Location = New System.Drawing.Point(10, 90)
        Me.dgStockReserve.Margin = New System.Windows.Forms.Padding(2)
        Me.dgStockReserve.Name = "dgStockReserve"
        Me.dgStockReserve.RowHeadersVisible = False
        Me.dgStockReserve.RowHeadersWidth = 72
        Me.dgStockReserve.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.dgStockReserve.RowTemplate.ReadOnly = True
        Me.dgStockReserve.Size = New System.Drawing.Size(890, 440)
        Me.dgStockReserve.TabIndex = 11
        '
        'CRTDT
        '
        Me.CRTDT.DataPropertyName = "CRTDT"
        DataGridViewCellStyle11.Format = "yyyy-MM-dd hh:mm:ss"
        Me.CRTDT.DefaultCellStyle = DataGridViewCellStyle11
        Me.CRTDT.Frozen = True
        Me.CRTDT.HeaderText = "引当日時"
        Me.CRTDT.Name = "CRTDT"
        Me.CRTDT.Width = 120
        '
        'ITEMCD
        '
        Me.ITEMCD.DataPropertyName = "ITEMCD"
        Me.ITEMCD.Frozen = True
        Me.ITEMCD.HeaderText = "変更商品名"
        Me.ITEMCD.Name = "ITEMCD"
        Me.ITEMCD.Width = 120
        '
        'RESERVQTY
        '
        Me.RESERVQTY.DataPropertyName = "RESERVQTY"
        Me.RESERVQTY.HeaderText = "引当数"
        Me.RESERVQTY.Name = "RESERVQTY"
        Me.RESERVQTY.Width = 65
        '
        'ORDERKBN
        '
        Me.ORDERKBN.DataPropertyName = "ORDERKBN"
        Me.ORDERKBN.HeaderText = "受注区分"
        Me.ORDERKBN.Name = "ORDERKBN"
        Me.ORDERKBN.Width = 120
        '
        'DELFLGNM
        '
        Me.DELFLGNM.DataPropertyName = "DELFLGNM"
        Me.DELFLGNM.HeaderText = "引当状態"
        Me.DELFLGNM.Name = "DELFLGNM"
        Me.DELFLGNM.Width = 80
        '
        'ORDERID
        '
        Me.ORDERID.DataPropertyName = "ORDERID"
        Me.ORDERID.HeaderText = "受注ID"
        Me.ORDERID.Name = "ORDERID"
        Me.ORDERID.Width = 70
        '
        'ORDSTATUS
        '
        Me.ORDSTATUS.DataPropertyName = "ORDSTATUS"
        Me.ORDSTATUS.HeaderText = "状況"
        Me.ORDSTATUS.Name = "ORDSTATUS"
        Me.ORDSTATUS.Width = 60
        '
        'ORDDLVDT
        '
        Me.ORDDLVDT.DataPropertyName = "ORDDLVDT"
        Me.ORDDLVDT.HeaderText = "発送日"
        Me.ORDDLVDT.Name = "ORDDLVDT"
        Me.ORDDLVDT.Width = 80
        '
        'INCHARGE
        '
        Me.INCHARGE.DataPropertyName = "INCHARGE"
        Me.INCHARGE.HeaderText = "担当者"
        Me.INCHARGE.Name = "INCHARGE"
        '
        'CUSTNAME
        '
        Me.CUSTNAME.DataPropertyName = "CUSTNAME"
        Me.CUSTNAME.HeaderText = "お客様氏名"
        Me.CUSTNAME.Name = "CUSTNAME"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblItemName.Location = New System.Drawing.Point(20, 48)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(65, 12)
        Me.lblItemName.TabIndex = 19
        Me.lblItemName.Text = "変更商品名"
        '
        'lblOrdStatus
        '
        Me.lblOrdStatus.AutoSize = True
        Me.lblOrdStatus.ForeColor = System.Drawing.SystemColors.Control
        Me.lblOrdStatus.Location = New System.Drawing.Point(244, 48)
        Me.lblOrdStatus.Name = "lblOrdStatus"
        Me.lblOrdStatus.Size = New System.Drawing.Size(59, 12)
        Me.lblOrdStatus.TabIndex = 20
        Me.lblOrdStatus.Text = "JPON状況"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSearch.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(731, 15)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 30)
        Me.btnSearch.TabIndex = 21
        Me.btnSearch.Text = "検索"
        Me.btnSearch.Type = 2
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblWavy
        '
        Me.lblWavy.AutoSize = True
        Me.lblWavy.ForeColor = System.Drawing.SystemColors.Control
        Me.lblWavy.Location = New System.Drawing.Point(218, 18)
        Me.lblWavy.Name = "lblWavy"
        Me.lblWavy.Size = New System.Drawing.Size(17, 12)
        Me.lblWavy.TabIndex = 23
        Me.lblWavy.Text = "～"
        '
        'UBindingNavigator1
        '
        Me.UBindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UBindingNavigator1.Location = New System.Drawing.Point(0, 535)
        Me.UBindingNavigator1.Name = "UBindingNavigator1"
        Me.UBindingNavigator1.Size = New System.Drawing.Size(910, 25)
        Me.UBindingNavigator1.TabIndex = 12
        '
        'dtPickerFrom
        '
        Me.dtPickerFrom.Location = New System.Drawing.Point(20, 15)
        Me.dtPickerFrom.Name = "dtPickerFrom"
        Me.dtPickerFrom.Size = New System.Drawing.Size(190, 20)
        Me.dtPickerFrom.TabIndex = 24
        '
        'dtPickerTo
        '
        Me.dtPickerTo.Location = New System.Drawing.Point(246, 15)
        Me.dtPickerTo.Name = "dtPickerTo"
        Me.dtPickerTo.Size = New System.Drawing.Size(217, 20)
        Me.dtPickerTo.TabIndex = 25
        '
        'FrmStockReserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 560)
        Me.Controls.Add(Me.UBindingNavigator1)
        Me.Controls.Add(Me.dgStockReserve)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmStockReserve"
        Me.Text = "自動引当履歴"
        Me.Controls.SetChildIndex(Me.pnlCondition, 0)
        Me.Controls.SetChildIndex(Me.dgStockReserve, 0)
        Me.Controls.SetChildIndex(Me.UBindingNavigator1, 0)
        Me.pnlCondition.ResumeLayout(False)
        Me.pnlCondition.PerformLayout()
        CType(Me.dgStockReserve, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtItemCd As TextBox
    Friend WithEvents cmbOrdStatus As ComboBox
    Friend WithEvents chkReserving As CheckBox
    Friend WithEvents dgStockReserve As DataGridView
    Friend WithEvents lblItemName As Label
    Friend WithEvents lblOrdStatus As Label
    Friend WithEvents btnSearch As ButtonBase
    Friend WithEvents lblWavy As Label
    Friend WithEvents UBindingNavigator1 As UBindingNavigator
    Friend WithEvents dtPickerFrom As UDataTimePicker
    Friend WithEvents dtPickerTo As UDataTimePicker
    Friend WithEvents CRTDT As DataGridViewTextBoxColumn
    Friend WithEvents ITEMCD As DataGridViewTextBoxColumn
    Friend WithEvents RESERVQTY As DataGridViewTextBoxColumn
    Friend WithEvents ORDERKBN As DataGridViewTextBoxColumn
    Friend WithEvents DELFLGNM As DataGridViewTextBoxColumn
    Friend WithEvents ORDERID As DataGridViewTextBoxColumn
    Friend WithEvents ORDSTATUS As DataGridViewTextBoxColumn
    Friend WithEvents ORDDLVDT As DataGridViewTextBoxColumn
    Friend WithEvents INCHARGE As DataGridViewTextBoxColumn
    Friend WithEvents CUSTNAME As DataGridViewTextBoxColumn
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
