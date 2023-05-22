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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtItemCd = New System.Windows.Forms.TextBox()
        Me.cmbOrdStatus = New System.Windows.Forms.ComboBox()
        Me.grd = New StockManagement.DataGridViewBase()
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
        Me.TELNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZIPCODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SENDADD1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SENDADD2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DLVCOMPANY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DLVSLIPNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDERSTATUSNM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDERDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSearch = New StockManagement.ButtonBase()
        Me.lblWavy = New System.Windows.Forms.Label()
        Me.UBindingNavigator1 = New StockManagement.UBindingNavigator()
        Me.dtPickerFrom = New StockManagement.UDataTimePicker()
        Me.dtPickerTo = New StockManagement.UDataTimePicker()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnCopy = New StockManagement.ButtonBase()
        Me.lblItemName = New StockManagement.LabelBase()
        Me.lblOrdStatus = New StockManagement.LabelBase()
        Me.chkReserving = New StockManagement.CheckBoxBase()
        Me.chkExclude = New StockManagement.CheckBoxBase()
        Me.pnlCondition.SuspendLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCondition
        '
        Me.pnlCondition.Controls.Add(Me.chkExclude)
        Me.pnlCondition.Controls.Add(Me.chkReserving)
        Me.pnlCondition.Controls.Add(Me.lblOrdStatus)
        Me.pnlCondition.Controls.Add(Me.lblItemName)
        Me.pnlCondition.Controls.Add(Me.btnCopy)
        Me.pnlCondition.Controls.Add(Me.dtPickerTo)
        Me.pnlCondition.Controls.Add(Me.dtPickerFrom)
        Me.pnlCondition.Controls.Add(Me.lblWavy)
        Me.pnlCondition.Controls.Add(Me.btnSearch)
        Me.pnlCondition.Controls.Add(Me.txtItemCd)
        Me.pnlCondition.Controls.Add(Me.cmbOrdStatus)
        '
        'txtItemCd
        '
        Me.txtItemCd.Location = New System.Drawing.Point(88, 45)
        Me.txtItemCd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemCd.Name = "txtItemCd"
        Me.txtItemCd.Size = New System.Drawing.Size(120, 19)
        Me.txtItemCd.TabIndex = 3
        '
        'cmbOrdStatus
        '
        Me.cmbOrdStatus.FormattingEnabled = True
        Me.cmbOrdStatus.Location = New System.Drawing.Point(307, 44)
        Me.cmbOrdStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbOrdStatus.Name = "cmbOrdStatus"
        Me.cmbOrdStatus.Size = New System.Drawing.Size(129, 20)
        Me.cmbOrdStatus.TabIndex = 4
        '
        'grd
        '
        Me.grd.AllowUserToAddRows = False
        Me.grd.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grd.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS PGothic", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CRTDT, Me.ITEMCD, Me.RESERVQTY, Me.ORDERKBN, Me.DELFLGNM, Me.ORDERID, Me.ORDSTATUS, Me.ORDDLVDT, Me.INCHARGE, Me.CUSTNAME, Me.TELNO, Me.ZIPCODE, Me.SENDADD1, Me.SENDADD2, Me.DLVCOMPANY, Me.DLVSLIPNO, Me.ORDERSTATUSNM, Me.ORDERDT})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd.DefaultCellStyle = DataGridViewCellStyle5
        Me.grd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grd.EnableHeadersVisualStyles = False
        Me.grd.Location = New System.Drawing.Point(0, 90)
        Me.grd.Margin = New System.Windows.Forms.Padding(2)
        Me.grd.Name = "grd"
        Me.grd.RowHeadersVisible = False
        Me.grd.RowHeadersWidth = 72
        Me.grd.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.grd.Size = New System.Drawing.Size(910, 445)
        Me.grd.TabIndex = 8
        Me.grd.Type = 0
        '
        'CRTDT
        '
        Me.CRTDT.DataPropertyName = "CRTDT"
        DataGridViewCellStyle3.Format = "yyyy-MM-dd HH:mm:ss"
        Me.CRTDT.DefaultCellStyle = DataGridViewCellStyle3
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.RESERVQTY.DefaultCellStyle = DataGridViewCellStyle4
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
        'TELNO
        '
        Me.TELNO.DataPropertyName = "TELNO"
        Me.TELNO.HeaderText = "TEL"
        Me.TELNO.Name = "TELNO"
        Me.TELNO.Width = 90
        '
        'ZIPCODE
        '
        Me.ZIPCODE.DataPropertyName = "ZIPCODE"
        Me.ZIPCODE.HeaderText = "郵便番号"
        Me.ZIPCODE.Name = "ZIPCODE"
        Me.ZIPCODE.Width = 80
        '
        'SENDADD1
        '
        Me.SENDADD1.DataPropertyName = "SENDADD1"
        Me.SENDADD1.HeaderText = "住所1"
        Me.SENDADD1.Name = "SENDADD1"
        Me.SENDADD1.Width = 150
        '
        'SENDADD2
        '
        Me.SENDADD2.DataPropertyName = "SENDADD2"
        Me.SENDADD2.HeaderText = "住所2"
        Me.SENDADD2.Name = "SENDADD2"
        Me.SENDADD2.Width = 60
        '
        'DLVCOMPANY
        '
        Me.DLVCOMPANY.DataPropertyName = "DLVCOMPANY"
        Me.DLVCOMPANY.HeaderText = "配送業者"
        Me.DLVCOMPANY.Name = "DLVCOMPANY"
        Me.DLVCOMPANY.Width = 80
        '
        'DLVSLIPNO
        '
        Me.DLVSLIPNO.DataPropertyName = "DLVSLIPNO"
        Me.DLVSLIPNO.HeaderText = "配送伝票番号"
        Me.DLVSLIPNO.Name = "DLVSLIPNO"
        '
        'ORDERSTATUSNM
        '
        Me.ORDERSTATUSNM.DataPropertyName = "ORDERSTATUSNM"
        Me.ORDERSTATUSNM.HeaderText = "受注ステータス"
        Me.ORDERSTATUSNM.Name = "ORDERSTATUSNM"
        Me.ORDERSTATUSNM.Width = 110
        '
        'ORDERDT
        '
        Me.ORDERDT.DataPropertyName = "ORDERDT"
        Me.ORDERDT.HeaderText = "受注日"
        Me.ORDERDT.Name = "ORDERDT"
        Me.ORDERDT.Width = 120
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSearch.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(730, 15)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 30)
        Me.btnSearch.TabIndex = 7
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
        Me.dtPickerFrom.TabIndex = 1
        '
        'dtPickerTo
        '
        Me.dtPickerTo.Location = New System.Drawing.Point(246, 15)
        Me.dtPickerTo.Name = "dtPickerTo"
        Me.dtPickerTo.Size = New System.Drawing.Size(217, 20)
        Me.dtPickerTo.TabIndex = 2
        '
        'btnCopy
        '
        Me.btnCopy.BackColor = System.Drawing.Color.Sienna
        Me.btnCopy.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnCopy.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCopy.Location = New System.Drawing.Point(810, 15)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(70, 30)
        Me.btnCopy.TabIndex = 25
        Me.btnCopy.Text = "全コピー"
        Me.btnCopy.Type = 5
        Me.btnCopy.UseVisualStyleBackColor = False
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Location = New System.Drawing.Point(18, 49)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(65, 12)
        Me.lblItemName.TabIndex = 26
        Me.lblItemName.Text = "変更商品名"
        Me.lblItemName.Type = 0
        '
        'lblOrdStatus
        '
        Me.lblOrdStatus.AutoSize = True
        Me.lblOrdStatus.Location = New System.Drawing.Point(243, 49)
        Me.lblOrdStatus.Name = "lblOrdStatus"
        Me.lblOrdStatus.Size = New System.Drawing.Size(59, 12)
        Me.lblOrdStatus.TabIndex = 27
        Me.lblOrdStatus.Text = "JPON状況"
        Me.lblOrdStatus.Type = 0
        '
        'chkReserving
        '
        Me.chkReserving.AutoSize = True
        Me.chkReserving.Location = New System.Drawing.Point(465, 49)
        Me.chkReserving.Name = "chkReserving"
        Me.chkReserving.Size = New System.Drawing.Size(84, 16)
        Me.chkReserving.TabIndex = 28
        Me.chkReserving.Text = "引当中のみ"
        Me.chkReserving.Type = 0
        Me.chkReserving.UseVisualStyleBackColor = True
        '
        'chkExclude
        '
        Me.chkExclude.AutoSize = True
        Me.chkExclude.Location = New System.Drawing.Point(555, 49)
        Me.chkExclude.Name = "chkExclude"
        Me.chkExclude.Size = New System.Drawing.Size(92, 16)
        Me.chkExclude.TabIndex = 29
        Me.chkExclude.Text = "引当数０除外"
        Me.chkExclude.Type = 0
        Me.chkExclude.UseVisualStyleBackColor = True
        '
        'FrmStockReserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 560)
        Me.Controls.Add(Me.grd)
        Me.Controls.Add(Me.UBindingNavigator1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmStockReserve"
        Me.Text = "自動引当履歴"
        Me.Controls.SetChildIndex(Me.pnlCondition, 0)
        Me.Controls.SetChildIndex(Me.UBindingNavigator1, 0)
        Me.Controls.SetChildIndex(Me.grd, 0)
        Me.pnlCondition.ResumeLayout(False)
        Me.pnlCondition.PerformLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtItemCd As TextBox
    Friend WithEvents cmbOrdStatus As ComboBox
    Friend WithEvents grd As DataGridViewBase
    Friend WithEvents btnSearch As ButtonBase
    Friend WithEvents lblWavy As Label
    Friend WithEvents UBindingNavigator1 As UBindingNavigator
    Friend WithEvents dtPickerFrom As UDataTimePicker
    Friend WithEvents dtPickerTo As UDataTimePicker
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
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
    Friend WithEvents TELNO As DataGridViewTextBoxColumn
    Friend WithEvents ZIPCODE As DataGridViewTextBoxColumn
    Friend WithEvents SENDADD1 As DataGridViewTextBoxColumn
    Friend WithEvents SENDADD2 As DataGridViewTextBoxColumn
    Friend WithEvents DLVCOMPANY As DataGridViewTextBoxColumn
    Friend WithEvents DLVSLIPNO As DataGridViewTextBoxColumn
    Friend WithEvents ORDERSTATUSNM As DataGridViewTextBoxColumn
    Friend WithEvents ORDERDT As DataGridViewTextBoxColumn
    Friend WithEvents btnCopy As ButtonBase
    Friend WithEvents lblItemName As LabelBase
    Friend WithEvents lblOrdStatus As LabelBase
    Friend WithEvents chkReserving As CheckBoxBase
    Friend WithEvents chkExclude As CheckBoxBase
End Class
