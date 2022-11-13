<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmStockHistory
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
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtItemCd = New System.Windows.Forms.TextBox()
        Me.dgStockHistory = New System.Windows.Forms.DataGridView()
        Me.CRTDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOCATIONNM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IOKBNNM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REMARKS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UPDIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSearch = New StockManagement.ButtonBase()
        Me.chkIn = New StockManagement.CheckBoxBase()
        Me.chkOut = New StockManagement.CheckBoxBase()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblWavy = New System.Windows.Forms.Label()
        Me.dtPickerTo = New StockManagement.UDataTimePicker()
        Me.dtPickerFrom = New StockManagement.UDataTimePicker()
        Me.bindingNavi = New StockManagement.UBindingNavigator()
        Me.btnClose = New StockManagement.ButtonBase()
        Me.pnlCondition.SuspendLayout()
        CType(Me.dgStockHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCondition
        '
        Me.pnlCondition.Controls.Add(Me.btnClose)
        Me.pnlCondition.Controls.Add(Me.dtPickerFrom)
        Me.pnlCondition.Controls.Add(Me.dtPickerTo)
        Me.pnlCondition.Controls.Add(Me.lblWavy)
        Me.pnlCondition.Controls.Add(Me.btnSearch)
        Me.pnlCondition.Controls.Add(Me.lblItemName)
        Me.pnlCondition.Controls.Add(Me.txtItemCd)
        Me.pnlCondition.Controls.Add(Me.chkIn)
        Me.pnlCondition.Controls.Add(Me.chkOut)
        '
        'txtItemCd
        '
        Me.txtItemCd.Location = New System.Drawing.Point(88, 45)
        Me.txtItemCd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemCd.Name = "txtItemCd"
        Me.txtItemCd.Size = New System.Drawing.Size(120, 19)
        Me.txtItemCd.TabIndex = 6
        '
        'dgStockHistory
        '
        Me.dgStockHistory.AllowUserToResizeRows = False
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgStockHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgStockHistory.AutoGenerateColumns = False
        Me.dgStockHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgStockHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.Font = New System.Drawing.Font("MS PGothic", 9.0!)
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgStockHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgStockHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStockHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CRTDT, Me.ITEMCD, Me.LOCATIONNM, Me.IOKBNNM, Me.QTY, Me.REMARKS, Me.UPDIP})
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle20.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(178, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgStockHistory.DefaultCellStyle = DataGridViewCellStyle20
        Me.dgStockHistory.EnableHeadersVisualStyles = False
        Me.dgStockHistory.Location = New System.Drawing.Point(10, 90)
        Me.dgStockHistory.Margin = New System.Windows.Forms.Padding(2)
        Me.dgStockHistory.Name = "dgStockHistory"
        DataGridViewCellStyle21.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.dgStockHistory.RowHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.dgStockHistory.RowHeadersVisible = False
        Me.dgStockHistory.RowHeadersWidth = 72
        Me.dgStockHistory.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.dgStockHistory.RowTemplate.ReadOnly = True
        Me.dgStockHistory.Size = New System.Drawing.Size(890, 440)
        Me.dgStockHistory.TabIndex = 11
        '
        'CRTDT
        '
        Me.CRTDT.DataPropertyName = "CRTDT"
        DataGridViewCellStyle17.Format = "yyyy-MM-dd hh:mm:ss"
        DataGridViewCellStyle17.NullValue = Nothing
        Me.CRTDT.DefaultCellStyle = DataGridViewCellStyle17
        Me.CRTDT.HeaderText = "入出庫日時"
        Me.CRTDT.Name = "CRTDT"
        Me.CRTDT.Width = 135
        '
        'ITEMCD
        '
        Me.ITEMCD.DataPropertyName = "ITEMCD"
        Me.ITEMCD.HeaderText = "変更商品名"
        Me.ITEMCD.Name = "ITEMCD"
        Me.ITEMCD.Width = 210
        '
        'LOCATIONNM
        '
        Me.LOCATIONNM.DataPropertyName = "LOCATIONNM"
        Me.LOCATIONNM.HeaderText = "ロケーション"
        Me.LOCATIONNM.Name = "LOCATIONNM"
        '
        'IOKBNNM
        '
        Me.IOKBNNM.DataPropertyName = "IOKBNNM"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.IOKBNNM.DefaultCellStyle = DataGridViewCellStyle18
        Me.IOKBNNM.HeaderText = "区分"
        Me.IOKBNNM.Name = "IOKBNNM"
        Me.IOKBNNM.Width = 55
        '
        'QTY
        '
        Me.QTY.DataPropertyName = "QTY"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.QTY.DefaultCellStyle = DataGridViewCellStyle19
        Me.QTY.HeaderText = "数量"
        Me.QTY.Name = "QTY"
        Me.QTY.Width = 60
        '
        'REMARKS
        '
        Me.REMARKS.DataPropertyName = "REMARKS"
        Me.REMARKS.HeaderText = "備考"
        Me.REMARKS.Name = "REMARKS"
        Me.REMARKS.Width = 200
        '
        'UPDIP
        '
        Me.UPDIP.DataPropertyName = "UPDIP"
        Me.UPDIP.HeaderText = "更新者"
        Me.UPDIP.Name = "UPDIP"
        Me.UPDIP.Width = 110
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSearch.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(731, 15)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 30)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "検索"
        Me.btnSearch.Type = 2
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'chkIn
        '
        Me.chkIn.AutoSize = True
        Me.chkIn.ForeColor = System.Drawing.SystemColors.Info
        Me.chkIn.Location = New System.Drawing.Point(246, 46)
        Me.chkIn.Name = "chkIn"
        Me.chkIn.Size = New System.Drawing.Size(72, 16)
        Me.chkIn.TabIndex = 14
        Me.chkIn.Text = "入庫のみ"
        Me.chkIn.Type = 0
        Me.chkIn.UseVisualStyleBackColor = True
        '
        'chkOut
        '
        Me.chkOut.AutoSize = True
        Me.chkOut.ForeColor = System.Drawing.SystemColors.Info
        Me.chkOut.Location = New System.Drawing.Point(350, 46)
        Me.chkOut.Name = "chkOut"
        Me.chkOut.Size = New System.Drawing.Size(72, 16)
        Me.chkOut.TabIndex = 15
        Me.chkOut.Text = "出庫のみ"
        Me.chkOut.Type = 0
        Me.chkOut.UseVisualStyleBackColor = True
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblItemName.Location = New System.Drawing.Point(20, 48)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(65, 12)
        Me.lblItemName.TabIndex = 18
        Me.lblItemName.Text = "変更商品名"
        '
        'lblWavy
        '
        Me.lblWavy.AutoSize = True
        Me.lblWavy.ForeColor = System.Drawing.SystemColors.Control
        Me.lblWavy.Location = New System.Drawing.Point(218, 18)
        Me.lblWavy.Name = "lblWavy"
        Me.lblWavy.Size = New System.Drawing.Size(17, 12)
        Me.lblWavy.TabIndex = 19
        Me.lblWavy.Text = "～"
        '
        'dtPickerTo
        '
        Me.dtPickerTo.Location = New System.Drawing.Point(246, 15)
        Me.dtPickerTo.Name = "dtPickerTo"
        Me.dtPickerTo.Size = New System.Drawing.Size(196, 20)
        Me.dtPickerTo.TabIndex = 20
        '
        'dtPickerFrom
        '
        Me.dtPickerFrom.Location = New System.Drawing.Point(20, 15)
        Me.dtPickerFrom.Name = "dtPickerFrom"
        Me.dtPickerFrom.Size = New System.Drawing.Size(190, 20)
        Me.dtPickerFrom.TabIndex = 21
        '
        'bindingNavi
        '
        Me.bindingNavi.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bindingNavi.Location = New System.Drawing.Point(0, 535)
        Me.bindingNavi.Name = "bindingNavi"
        Me.bindingNavi.Size = New System.Drawing.Size(910, 25)
        Me.bindingNavi.TabIndex = 12
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Goldenrod
        Me.btnClose.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnClose.Location = New System.Drawing.Point(819, 15)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(70, 30)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "閉じる"
        Me.btnClose.Type = 1
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'FrmStockHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 560)
        Me.Controls.Add(Me.bindingNavi)
        Me.Controls.Add(Me.dgStockHistory)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmStockHistory"
        Me.Text = "入出庫履歴"
        Me.Controls.SetChildIndex(Me.pnlCondition, 0)
        Me.Controls.SetChildIndex(Me.dgStockHistory, 0)
        Me.Controls.SetChildIndex(Me.bindingNavi, 0)
        Me.pnlCondition.ResumeLayout(False)
        Me.pnlCondition.PerformLayout()
        CType(Me.dgStockHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtItemCd As TextBox
    Friend WithEvents dgStockHistory As DataGridView
    Friend WithEvents btnSearch As ButtonBase
    Friend WithEvents chkIn As CheckBoxBase
    Friend WithEvents chkOut As CheckBoxBase
    Friend WithEvents lblItemName As Label
    Friend WithEvents lblWavy As Label
    Friend WithEvents dtPickerTo As UDataTimePicker
    Friend WithEvents dtPickerFrom As UDataTimePicker
    Friend WithEvents bindingNavi As UBindingNavigator
    Friend WithEvents CRTDT As DataGridViewTextBoxColumn
    Friend WithEvents ITEMCD As DataGridViewTextBoxColumn
    Friend WithEvents LOCATIONNM As DataGridViewTextBoxColumn
    Friend WithEvents IOKBNNM As DataGridViewTextBoxColumn
    Friend WithEvents QTY As DataGridViewTextBoxColumn
    Friend WithEvents REMARKS As DataGridViewTextBoxColumn
    Friend WithEvents UPDIP As DataGridViewTextBoxColumn
    Friend WithEvents btnClose As ButtonBase
End Class
