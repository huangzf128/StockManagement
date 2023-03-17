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
        Me.lblWavy = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.txtItemCd = New System.Windows.Forms.TextBox()
        Me.btnSearch = New StockManagement.ButtonBase()
        Me.grd = New StockManagement.DataGridViewBase()
        Me.ITEMCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.分類2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SumSumQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SumQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.btnStaying = New StockManagement.ButtonBase()
        Me.bindingNavi = New StockManagement.UBindingNavigator()
        Me.btnCopy = New StockManagement.ButtonBase()
        Me.txtQtyMax = New StockManagement.TextBoxBase()
        Me.lblTenpo = New System.Windows.Forms.Label()
        Me.cmbTenpo = New System.Windows.Forms.ComboBox()
        Me.pnlCondition.SuspendLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCondition
        '
        Me.pnlCondition.Controls.Add(Me.cmbTenpo)
        Me.pnlCondition.Controls.Add(Me.lblTenpo)
        Me.pnlCondition.Controls.Add(Me.txtQtyMax)
        Me.pnlCondition.Controls.Add(Me.btnCopy)
        Me.pnlCondition.Controls.Add(Me.btnStaying)
        Me.pnlCondition.Controls.Add(Me.lblQty)
        Me.pnlCondition.Controls.Add(Me.btnSearch)
        Me.pnlCondition.Controls.Add(Me.dtPickerTo)
        Me.pnlCondition.Controls.Add(Me.dtPickerFrom)
        Me.pnlCondition.Controls.Add(Me.lblWavy)
        Me.pnlCondition.Controls.Add(Me.lblItemName)
        Me.pnlCondition.Controls.Add(Me.txtItemCd)
        '
        'dtPickerTo
        '
        Me.dtPickerTo.Location = New System.Drawing.Point(246, 15)
        Me.dtPickerTo.Name = "dtPickerTo"
        Me.dtPickerTo.Size = New System.Drawing.Size(217, 20)
        Me.dtPickerTo.TabIndex = 30
        '
        'dtPickerFrom
        '
        Me.dtPickerFrom.Location = New System.Drawing.Point(20, 15)
        Me.dtPickerFrom.Name = "dtPickerFrom"
        Me.dtPickerFrom.Size = New System.Drawing.Size(190, 20)
        Me.dtPickerFrom.TabIndex = 29
        '
        'lblWavy
        '
        Me.lblWavy.AutoSize = True
        Me.lblWavy.ForeColor = System.Drawing.SystemColors.Control
        Me.lblWavy.Location = New System.Drawing.Point(218, 18)
        Me.lblWavy.Name = "lblWavy"
        Me.lblWavy.Size = New System.Drawing.Size(17, 12)
        Me.lblWavy.TabIndex = 28
        Me.lblWavy.Text = "～"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblItemName.Location = New System.Drawing.Point(20, 48)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(65, 12)
        Me.lblItemName.TabIndex = 27
        Me.lblItemName.Text = "変更商品名"
        '
        'txtItemCd
        '
        Me.txtItemCd.Location = New System.Drawing.Point(88, 45)
        Me.txtItemCd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemCd.Name = "txtItemCd"
        Me.txtItemCd.Size = New System.Drawing.Size(163, 19)
        Me.txtItemCd.TabIndex = 26
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSearch.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(730, 15)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 30)
        Me.btnSearch.TabIndex = 31
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
        Me.grd.AutoGenerateColumns = False
        Me.grd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEMCD, Me.分類2, Me.SumSumQTY, Me.SumQTY})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd.DefaultCellStyle = DataGridViewCellStyle4
        Me.grd.EnableHeadersVisualStyles = False
        Me.grd.Location = New System.Drawing.Point(10, 90)
        Me.grd.Name = "grd"
        Me.grd.RowHeadersVisible = False
        Me.grd.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.grd.Size = New System.Drawing.Size(890, 440)
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
        Me.SumQTY.HeaderText = "SumQTY"
        Me.SumQTY.Name = "SumQTY"
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.ForeColor = System.Drawing.SystemColors.Control
        Me.lblQty.Location = New System.Drawing.Point(588, 60)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(65, 12)
        Me.lblQty.TabIndex = 32
        Me.lblQty.Text = "販売数上限"
        '
        'btnStaying
        '
        Me.btnStaying.BackColor = System.Drawing.Color.DarkGreen
        Me.btnStaying.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStaying.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnStaying.Location = New System.Drawing.Point(731, 51)
        Me.btnStaying.Name = "btnStaying"
        Me.btnStaying.Size = New System.Drawing.Size(70, 30)
        Me.btnStaying.TabIndex = 33
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
        Me.btnCopy.BackColor = System.Drawing.Color.Sienna
        Me.btnCopy.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnCopy.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCopy.Location = New System.Drawing.Point(810, 15)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(70, 30)
        Me.btnCopy.TabIndex = 35
        Me.btnCopy.Text = "全コピー"
        Me.btnCopy.Type = 5
        Me.btnCopy.UseVisualStyleBackColor = False
        '
        'txtQtyMax
        '
        Me.txtQtyMax.Location = New System.Drawing.Point(661, 57)
        Me.txtQtyMax.MaxLength = 4
        Me.txtQtyMax.Name = "txtQtyMax"
        Me.txtQtyMax.Size = New System.Drawing.Size(39, 19)
        Me.txtQtyMax.TabIndex = 36
        Me.txtQtyMax.Type = 1
        '
        'lblTenpo
        '
        Me.lblTenpo.AutoSize = True
        Me.lblTenpo.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTenpo.Location = New System.Drawing.Point(260, 48)
        Me.lblTenpo.Name = "lblTenpo"
        Me.lblTenpo.Size = New System.Drawing.Size(29, 12)
        Me.lblTenpo.TabIndex = 37
        Me.lblTenpo.Text = "店舗"
        '
        'cmbTenpo
        '
        Me.cmbTenpo.FormattingEnabled = True
        Me.cmbTenpo.Location = New System.Drawing.Point(292, 45)
        Me.cmbTenpo.Name = "cmbTenpo"
        Me.cmbTenpo.Size = New System.Drawing.Size(143, 20)
        Me.cmbTenpo.TabIndex = 38
        '
        'FrmRanking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 560)
        Me.Controls.Add(Me.bindingNavi)
        Me.Controls.Add(Me.grd)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmRanking"
        Me.Text = "売上ランキング"
        Me.Controls.SetChildIndex(Me.pnlCondition, 0)
        Me.Controls.SetChildIndex(Me.grd, 0)
        Me.Controls.SetChildIndex(Me.bindingNavi, 0)
        Me.pnlCondition.ResumeLayout(False)
        Me.pnlCondition.PerformLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtPickerTo As UDataTimePicker
    Friend WithEvents dtPickerFrom As UDataTimePicker
    Friend WithEvents lblWavy As Label
    Friend WithEvents lblItemName As Label
    Friend WithEvents txtItemCd As TextBox
    Friend WithEvents btnSearch As ButtonBase
    Friend WithEvents grd As DataGridViewBase
    Friend WithEvents lblQty As Label
    Friend WithEvents btnStaying As ButtonBase
    Friend WithEvents bindingNavi As UBindingNavigator
    Friend WithEvents btnCopy As ButtonBase
    Friend WithEvents ITEMCD As DataGridViewTextBoxColumn
    Friend WithEvents 分類2 As DataGridViewTextBoxColumn
    Friend WithEvents SumSumQTY As DataGridViewTextBoxColumn
    Friend WithEvents SumQTY As DataGridViewTextBoxColumn
    Friend WithEvents txtQtyMax As TextBoxBase
    Friend WithEvents lblTenpo As Label
    Friend WithEvents cmbTenpo As ComboBox
End Class
