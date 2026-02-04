<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRanking
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtPickerTo = New StockManagement.UDataTimePicker()
        Me.dtPickerFrom = New StockManagement.UDataTimePicker()
        Me.txtItemCd = New System.Windows.Forms.TextBox()
        Me.btnSearch = New StockManagement.ButtonBase()
        Me.grd = New StockManagement.DataGridViewBase()
        Me.ITEMCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.分類2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SumSumQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SumQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnStaying = New StockManagement.ButtonBase()
        Me.bindingNavi = New StockManagement.UBindingNavigator()
        Me.btnCopy = New StockManagement.ButtonBase()
        Me.txtQtyMax = New StockManagement.TextBoxBase()
        Me.cmbTenpo = New System.Windows.Forms.ComboBox()
        Me.LabelBase1 = New StockManagement.LabelBase()
        Me.lblTenpo = New StockManagement.LabelBase()
        Me.lblWavy = New StockManagement.LabelBase()
        Me.lblQty = New StockManagement.LabelBase()
        Me.chkExact = New StockManagement.CheckBoxBase()
        Me.rdoConfirm = New System.Windows.Forms.RadioButton()
        Me.grpDate = New System.Windows.Forms.GroupBox()
        Me.rdoShip = New System.Windows.Forms.RadioButton()
        Me.pnlCondition.SuspendLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCondition
        '
        Me.pnlCondition.Controls.Add(Me.grpDate)
        Me.pnlCondition.Controls.Add(Me.chkExact)
        Me.pnlCondition.Controls.Add(Me.lblQty)
        Me.pnlCondition.Controls.Add(Me.lblWavy)
        Me.pnlCondition.Controls.Add(Me.lblTenpo)
        Me.pnlCondition.Controls.Add(Me.LabelBase1)
        Me.pnlCondition.Controls.Add(Me.cmbTenpo)
        Me.pnlCondition.Controls.Add(Me.txtQtyMax)
        Me.pnlCondition.Controls.Add(Me.btnCopy)
        Me.pnlCondition.Controls.Add(Me.btnStaying)
        Me.pnlCondition.Controls.Add(Me.btnSearch)
        Me.pnlCondition.Controls.Add(Me.dtPickerTo)
        Me.pnlCondition.Controls.Add(Me.dtPickerFrom)
        Me.pnlCondition.Controls.Add(Me.txtItemCd)
        '
        'dtPickerTo
        '
        Me.dtPickerTo.Location = New System.Drawing.Point(246, 15)
        Me.dtPickerTo.Name = "dtPickerTo"
        Me.dtPickerTo.Size = New System.Drawing.Size(217, 20)
        Me.dtPickerTo.TabIndex = 2
        '
        'dtPickerFrom
        '
        Me.dtPickerFrom.Location = New System.Drawing.Point(20, 15)
        Me.dtPickerFrom.Name = "dtPickerFrom"
        Me.dtPickerFrom.Size = New System.Drawing.Size(190, 20)
        Me.dtPickerFrom.TabIndex = 1
        '
        'txtItemCd
        '
        Me.txtItemCd.Location = New System.Drawing.Point(88, 45)
        Me.txtItemCd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemCd.Name = "txtItemCd"
        Me.txtItemCd.Size = New System.Drawing.Size(163, 19)
        Me.txtItemCd.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSearch.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSearch.Location = New System.Drawing.Point(730, 15)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 30)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "検索"
        Me.btnSearch.Type = 2
        Me.btnSearch.UseVisualStyleBackColor = False
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
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEMCD, Me.分類2, Me.SumSumQTY, Me.SumQTY})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd.DefaultCellStyle = DataGridViewCellStyle4
        Me.grd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grd.EnableHeadersVisualStyles = False
        Me.grd.Location = New System.Drawing.Point(0, 90)
        Me.grd.Name = "grd"
        Me.grd.RowHeadersVisible = False
        Me.grd.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.grd.Size = New System.Drawing.Size(910, 445)
        Me.grd.TabIndex = 1
        Me.grd.Type = 0
        '
        'ITEMCD
        '
        Me.ITEMCD.DataPropertyName = "ITEMCD"
        Me.ITEMCD.Frozen = True
        Me.ITEMCD.HeaderText = "変更商品名"
        Me.ITEMCD.Name = "ITEMCD"
        Me.ITEMCD.Width = 120
        '
        '分類2
        '
        Me.分類2.DataPropertyName = "分類2"
        Me.分類2.HeaderText = "店舗"
        Me.分類2.Name = "分類2"
        '
        'SumSumQTY
        '
        Me.SumSumQTY.DataPropertyName = "SumSumQTY"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SumSumQTY.DefaultCellStyle = DataGridViewCellStyle3
        Me.SumSumQTY.HeaderText = "全店合計"
        Me.SumSumQTY.Name = "SumSumQTY"
        Me.SumSumQTY.Width = 60
        '
        'SumQTY
        '
        Me.SumQTY.DataPropertyName = "SumQTY"
        Me.SumQTY.HeaderText = "合计数量"
        Me.SumQTY.Name = "SumQTY"
        '
        'btnStaying
        '
        Me.btnStaying.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnStaying.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStaying.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStaying.Location = New System.Drawing.Point(731, 51)
        Me.btnStaying.Name = "btnStaying"
        Me.btnStaying.Size = New System.Drawing.Size(70, 30)
        Me.btnStaying.TabIndex = 8
        Me.btnStaying.Text = "滞留在庫"
        Me.btnStaying.Type = 3
        Me.btnStaying.UseVisualStyleBackColor = False
        '
        'bindingNavi
        '
        Me.bindingNavi.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bindingNavi.Location = New System.Drawing.Point(0, 535)
        Me.bindingNavi.Name = "bindingNavi"
        Me.bindingNavi.Size = New System.Drawing.Size(910, 25)
        Me.bindingNavi.TabIndex = 2
        '
        'btnCopy
        '
        Me.btnCopy.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCopy.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnCopy.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCopy.Location = New System.Drawing.Point(810, 15)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(70, 30)
        Me.btnCopy.TabIndex = 7
        Me.btnCopy.Text = "全コピー"
        Me.btnCopy.Type = 5
        Me.btnCopy.UseVisualStyleBackColor = False
        '
        'txtQtyMax
        '
        Me.txtQtyMax.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtQtyMax.Location = New System.Drawing.Point(661, 57)
        Me.txtQtyMax.MaxLength = 4
        Me.txtQtyMax.Name = "txtQtyMax"
        Me.txtQtyMax.Size = New System.Drawing.Size(39, 19)
        Me.txtQtyMax.TabIndex = 5
        Me.txtQtyMax.Type = 1
        '
        'cmbTenpo
        '
        Me.cmbTenpo.FormattingEnabled = True
        Me.cmbTenpo.Location = New System.Drawing.Point(292, 44)
        Me.cmbTenpo.Name = "cmbTenpo"
        Me.cmbTenpo.Size = New System.Drawing.Size(143, 20)
        Me.cmbTenpo.TabIndex = 4
        '
        'LabelBase1
        '
        Me.LabelBase1.AutoSize = True
        Me.LabelBase1.Location = New System.Drawing.Point(18, 49)
        Me.LabelBase1.Name = "LabelBase1"
        Me.LabelBase1.Size = New System.Drawing.Size(65, 12)
        Me.LabelBase1.TabIndex = 39
        Me.LabelBase1.Text = "変更商品名"
        Me.LabelBase1.Type = 0
        '
        'lblTenpo
        '
        Me.lblTenpo.AutoSize = True
        Me.lblTenpo.Location = New System.Drawing.Point(257, 49)
        Me.lblTenpo.Name = "lblTenpo"
        Me.lblTenpo.Size = New System.Drawing.Size(29, 12)
        Me.lblTenpo.TabIndex = 40
        Me.lblTenpo.Text = "店舗"
        Me.lblTenpo.Type = 0
        '
        'lblWavy
        '
        Me.lblWavy.AutoSize = True
        Me.lblWavy.Location = New System.Drawing.Point(219, 18)
        Me.lblWavy.Name = "lblWavy"
        Me.lblWavy.Size = New System.Drawing.Size(17, 12)
        Me.lblWavy.TabIndex = 41
        Me.lblWavy.Text = "～"
        Me.lblWavy.Type = 0
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(588, 61)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(65, 12)
        Me.lblQty.TabIndex = 42
        Me.lblQty.Text = "販売数上限"
        Me.lblQty.Type = 0
        '
        'chkExact
        '
        Me.chkExact.AutoSize = True
        Me.chkExact.Location = New System.Drawing.Point(590, 40)
        Me.chkExact.Name = "chkExact"
        Me.chkExact.Size = New System.Drawing.Size(72, 16)
        Me.chkExact.TabIndex = 43
        Me.chkExact.Text = "完全一致"
        Me.chkExact.Type = 0
        Me.chkExact.UseVisualStyleBackColor = True
        '
        'rdoConfirm
        '
        Me.rdoConfirm.AutoSize = True
        Me.rdoConfirm.Location = New System.Drawing.Point(6, 10)
        Me.rdoConfirm.Name = "rdoConfirm"
        Me.rdoConfirm.Size = New System.Drawing.Size(59, 16)
        Me.rdoConfirm.TabIndex = 46
        Me.rdoConfirm.Text = "販売日"
        Me.rdoConfirm.UseVisualStyleBackColor = True
        '
        'grpDate
        '
        Me.grpDate.Controls.Add(Me.rdoShip)
        Me.grpDate.Controls.Add(Me.rdoConfirm)
        Me.grpDate.Location = New System.Drawing.Point(449, 7)
        Me.grpDate.Name = "grpDate"
        Me.grpDate.Size = New System.Drawing.Size(146, 32)
        Me.grpDate.TabIndex = 47
        Me.grpDate.TabStop = False
        '
        'rdoShip
        '
        Me.rdoShip.AutoSize = True
        Me.rdoShip.Location = New System.Drawing.Point(76, 10)
        Me.rdoShip.Name = "rdoShip"
        Me.rdoShip.Size = New System.Drawing.Size(59, 16)
        Me.rdoShip.TabIndex = 47
        Me.rdoShip.TabStop = True
        Me.rdoShip.Text = "発送日"
        Me.rdoShip.UseVisualStyleBackColor = True
        '
        'FrmRanking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 560)
        Me.Controls.Add(Me.grd)
        Me.Controls.Add(Me.bindingNavi)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmRanking"
        Me.Text = "売上ランキング"
        Me.Controls.SetChildIndex(Me.pnlCondition, 0)
        Me.Controls.SetChildIndex(Me.bindingNavi, 0)
        Me.Controls.SetChildIndex(Me.grd, 0)
        Me.pnlCondition.ResumeLayout(False)
        Me.pnlCondition.PerformLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDate.ResumeLayout(False)
        Me.grpDate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtPickerTo As UDataTimePicker
    Friend WithEvents dtPickerFrom As UDataTimePicker
    Friend WithEvents txtItemCd As TextBox
    Friend WithEvents btnSearch As ButtonBase
    Friend WithEvents grd As DataGridViewBase
    Friend WithEvents btnStaying As ButtonBase
    Friend WithEvents bindingNavi As UBindingNavigator
    Friend WithEvents btnCopy As ButtonBase
    Friend WithEvents txtQtyMax As TextBoxBase
    Friend WithEvents cmbTenpo As ComboBox
    Friend WithEvents LabelBase1 As LabelBase
    Friend WithEvents lblWavy As LabelBase
    Friend WithEvents lblTenpo As LabelBase
    Friend WithEvents lblQty As LabelBase
    Friend WithEvents chkExact As CheckBoxBase
    Friend WithEvents ITEMCD As DataGridViewTextBoxColumn
    Friend WithEvents 分類2 As DataGridViewTextBoxColumn
    Friend WithEvents SumSumQTY As DataGridViewTextBoxColumn
    Friend WithEvents SumQTY As DataGridViewTextBoxColumn
    Friend WithEvents grpDate As GroupBox
    Friend WithEvents rdoShip As RadioButton
    Friend WithEvents rdoConfirm As RadioButton
End Class
