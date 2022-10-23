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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtItemCd = New System.Windows.Forms.TextBox()
        Me.dgStockHistory = New System.Windows.Forms.DataGridView()
        Me.CRTDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOCATIONNM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IOKBNNM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REMARKS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UPDIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnClose = New StockManagement.ButtonBase()
        Me.btnSearch = New StockManagement.ButtonBase()
        Me.chkIn = New StockManagement.CheckBoxBase()
        Me.chkOut = New StockManagement.CheckBoxBase()
        Me.dtPickerFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtPickerTo = New System.Windows.Forms.DateTimePicker()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblWavy = New System.Windows.Forms.Label()
        Me.pnlCondition.SuspendLayout()
        CType(Me.dgStockHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCondition
        '
        Me.pnlCondition.Controls.Add(Me.dtPickerFrom)
        Me.pnlCondition.Controls.Add(Me.dtPickerTo)
        Me.pnlCondition.Controls.Add(Me.lblWavy)
        Me.pnlCondition.Controls.Add(Me.btnClose)
        Me.pnlCondition.Controls.Add(Me.btnSearch)
        Me.pnlCondition.Controls.Add(Me.lblItemName)
        Me.pnlCondition.Controls.Add(Me.txtItemCd)
        Me.pnlCondition.Controls.Add(Me.chkIn)
        Me.pnlCondition.Controls.Add(Me.chkOut)
        Me.pnlCondition.Size = New System.Drawing.Size(910, 84)
        '
        'txtItemCd
        '
        Me.txtItemCd.Location = New System.Drawing.Point(88, 43)
        Me.txtItemCd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemCd.Name = "txtItemCd"
        Me.txtItemCd.Size = New System.Drawing.Size(114, 19)
        Me.txtItemCd.TabIndex = 6
        '
        'dgStockHistory
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgStockHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgStockHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgStockHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStockHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CRTDT, Me.ITEMCD, Me.LOCATIONNM, Me.IOKBNNM, Me.QTY, Me.REMARKS, Me.UPDIP})
        Me.dgStockHistory.EnableHeadersVisualStyles = False
        Me.dgStockHistory.Location = New System.Drawing.Point(9, 111)
        Me.dgStockHistory.Margin = New System.Windows.Forms.Padding(2)
        Me.dgStockHistory.Name = "dgStockHistory"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgStockHistory.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgStockHistory.RowHeadersVisible = False
        Me.dgStockHistory.RowHeadersWidth = 72
        Me.dgStockHistory.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.dgStockHistory.RowTemplate.ReadOnly = True
        Me.dgStockHistory.Size = New System.Drawing.Size(890, 440)
        Me.dgStockHistory.TabIndex = 11
        '
        'CRTDT
        '
        Me.CRTDT.DataPropertyName = "CRTDT"
        DataGridViewCellStyle3.Format = "F"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.CRTDT.DefaultCellStyle = DataGridViewCellStyle3
        Me.CRTDT.HeaderText = "入出庫日時"
        Me.CRTDT.Name = "CRTDT"
        Me.CRTDT.Width = 130
        '
        'ITEMCD
        '
        Me.ITEMCD.DataPropertyName = "ITEMCD"
        Me.ITEMCD.HeaderText = "変更商品名"
        Me.ITEMCD.Name = "ITEMCD"
        Me.ITEMCD.Width = 215
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.IOKBNNM.DefaultCellStyle = DataGridViewCellStyle4
        Me.IOKBNNM.HeaderText = "区分"
        Me.IOKBNNM.Name = "IOKBNNM"
        Me.IOKBNNM.Width = 55
        '
        'QTY
        '
        Me.QTY.DataPropertyName = "QTY"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.QTY.DefaultCellStyle = DataGridViewCellStyle5
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
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Goldenrod
        Me.btnClose.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnClose.Location = New System.Drawing.Point(795, 25)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(70, 30)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "閉じる"
        Me.btnClose.Type = 1
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSearch.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(710, 25)
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
        Me.chkIn.Location = New System.Drawing.Point(231, 45)
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
        Me.chkOut.Location = New System.Drawing.Point(334, 45)
        Me.chkOut.Name = "chkOut"
        Me.chkOut.Size = New System.Drawing.Size(72, 16)
        Me.chkOut.TabIndex = 15
        Me.chkOut.Text = "出庫のみ"
        Me.chkOut.Type = 0
        Me.chkOut.UseVisualStyleBackColor = True
        '
        'dtPickerFrom
        '
        Me.dtPickerFrom.CustomFormat = "yyyy年MM月dd   HH時mm分"
        Me.dtPickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtPickerFrom.Location = New System.Drawing.Point(20, 10)
        Me.dtPickerFrom.Name = "dtPickerFrom"
        Me.dtPickerFrom.Size = New System.Drawing.Size(180, 19)
        Me.dtPickerFrom.TabIndex = 16
        '
        'dtPickerTo
        '
        Me.dtPickerTo.CustomFormat = "yyyy年MM月dd   HH時mm分"
        Me.dtPickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtPickerTo.Location = New System.Drawing.Point(231, 10)
        Me.dtPickerTo.Name = "dtPickerTo"
        Me.dtPickerTo.Size = New System.Drawing.Size(180, 19)
        Me.dtPickerTo.TabIndex = 17
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblItemName.Location = New System.Drawing.Point(18, 46)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(65, 12)
        Me.lblItemName.TabIndex = 18
        Me.lblItemName.Text = "変更商品名"
        '
        'lblWavy
        '
        Me.lblWavy.AutoSize = True
        Me.lblWavy.ForeColor = System.Drawing.SystemColors.Control
        Me.lblWavy.Location = New System.Drawing.Point(208, 15)
        Me.lblWavy.Name = "lblWavy"
        Me.lblWavy.Size = New System.Drawing.Size(17, 12)
        Me.lblWavy.TabIndex = 19
        Me.lblWavy.Text = "～"
        '
        'FrmStockHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 560)
        Me.Controls.Add(Me.dgStockHistory)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmStockHistory"
        Me.Text = "入出庫履歴"
        Me.Controls.SetChildIndex(Me.pnlCondition, 0)
        Me.Controls.SetChildIndex(Me.dgStockHistory, 0)
        Me.pnlCondition.ResumeLayout(False)
        Me.pnlCondition.PerformLayout()
        CType(Me.dgStockHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtItemCd As TextBox
    Friend WithEvents dgStockHistory As DataGridView
    Friend WithEvents btnClose As ButtonBase
    Friend WithEvents btnSearch As ButtonBase
    Friend WithEvents chkIn As CheckBoxBase
    Friend WithEvents chkOut As CheckBoxBase
    Friend WithEvents dtPickerTo As DateTimePicker
    Friend WithEvents dtPickerFrom As DateTimePicker
    Friend WithEvents CRTDT As DataGridViewTextBoxColumn
    Friend WithEvents ITEMCD As DataGridViewTextBoxColumn
    Friend WithEvents LOCATIONNM As DataGridViewTextBoxColumn
    Friend WithEvents IOKBNNM As DataGridViewTextBoxColumn
    Friend WithEvents QTY As DataGridViewTextBoxColumn
    Friend WithEvents REMARKS As DataGridViewTextBoxColumn
    Friend WithEvents UPDIP As DataGridViewTextBoxColumn
    Friend WithEvents lblItemName As Label
    Friend WithEvents lblWavy As Label
End Class
