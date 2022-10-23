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
        Me.dtPickerFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtPickerTo = New System.Windows.Forms.DateTimePicker()
        Me.txtItemCd = New System.Windows.Forms.TextBox()
        Me.cmbOrdStatus = New System.Windows.Forms.ComboBox()
        Me.chkReserving = New System.Windows.Forms.CheckBox()
        Me.dgStockReserv = New System.Windows.Forms.DataGridView()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblOrdStatus = New System.Windows.Forms.Label()
        Me.btnSearch = New StockManagement.ButtonBase()
        Me.btnClose = New StockManagement.ButtonBase()
        Me.pnlCondition.SuspendLayout()
        CType(Me.dgStockReserv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCondition
        '
        Me.pnlCondition.Controls.Add(Me.btnClose)
        Me.pnlCondition.Controls.Add(Me.btnSearch)
        Me.pnlCondition.Controls.Add(Me.dtPickerFrom)
        Me.pnlCondition.Controls.Add(Me.dtPickerTo)
        Me.pnlCondition.Controls.Add(Me.lblItemName)
        Me.pnlCondition.Controls.Add(Me.txtItemCd)
        Me.pnlCondition.Controls.Add(Me.chkReserving)
        Me.pnlCondition.Controls.Add(Me.lblOrdStatus)
        Me.pnlCondition.Controls.Add(Me.cmbOrdStatus)
        '
        'dtPickerFrom
        '
        Me.dtPickerFrom.CustomFormat = "yyyy年MM月dd   HH時mm分"
        Me.dtPickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtPickerFrom.Location = New System.Drawing.Point(29, 21)
        Me.dtPickerFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.dtPickerFrom.Name = "dtPickerFrom"
        Me.dtPickerFrom.Size = New System.Drawing.Size(177, 19)
        Me.dtPickerFrom.TabIndex = 0
        '
        'dtPickerTo
        '
        Me.dtPickerTo.CustomFormat = "yyyy年MM月dd   HH時mm分"
        Me.dtPickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtPickerTo.Location = New System.Drawing.Point(244, 21)
        Me.dtPickerTo.Margin = New System.Windows.Forms.Padding(2)
        Me.dtPickerTo.Name = "dtPickerTo"
        Me.dtPickerTo.Size = New System.Drawing.Size(176, 19)
        Me.dtPickerTo.TabIndex = 1
        '
        'txtItemCd
        '
        Me.txtItemCd.Location = New System.Drawing.Point(95, 54)
        Me.txtItemCd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemCd.Name = "txtItemCd"
        Me.txtItemCd.Size = New System.Drawing.Size(111, 19)
        Me.txtItemCd.TabIndex = 6
        '
        'cmbOrdStatus
        '
        Me.cmbOrdStatus.FormattingEnabled = True
        Me.cmbOrdStatus.Location = New System.Drawing.Point(306, 53)
        Me.cmbOrdStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbOrdStatus.Name = "cmbOrdStatus"
        Me.cmbOrdStatus.Size = New System.Drawing.Size(114, 20)
        Me.cmbOrdStatus.TabIndex = 7
        '
        'chkReserving
        '
        Me.chkReserving.AutoSize = True
        Me.chkReserving.ForeColor = System.Drawing.SystemColors.Control
        Me.chkReserving.Location = New System.Drawing.Point(447, 53)
        Me.chkReserving.Margin = New System.Windows.Forms.Padding(2)
        Me.chkReserving.Name = "chkReserving"
        Me.chkReserving.Size = New System.Drawing.Size(84, 16)
        Me.chkReserving.TabIndex = 8
        Me.chkReserving.Text = "引当中のみ"
        Me.chkReserving.UseVisualStyleBackColor = True
        '
        'dgStockReserv
        '
        Me.dgStockReserv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStockReserv.Location = New System.Drawing.Point(11, 100)
        Me.dgStockReserv.Margin = New System.Windows.Forms.Padding(2)
        Me.dgStockReserv.Name = "dgStockReserv"
        Me.dgStockReserv.RowHeadersWidth = 72
        Me.dgStockReserv.RowTemplate.Height = 33
        Me.dgStockReserv.Size = New System.Drawing.Size(888, 449)
        Me.dgStockReserv.TabIndex = 11
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblItemName.Location = New System.Drawing.Point(27, 57)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(65, 12)
        Me.lblItemName.TabIndex = 19
        Me.lblItemName.Text = "変更商品名"
        '
        'lblOrdStatus
        '
        Me.lblOrdStatus.AutoSize = True
        Me.lblOrdStatus.ForeColor = System.Drawing.SystemColors.Control
        Me.lblOrdStatus.Location = New System.Drawing.Point(242, 57)
        Me.lblOrdStatus.Name = "lblOrdStatus"
        Me.lblOrdStatus.Size = New System.Drawing.Size(59, 12)
        Me.lblOrdStatus.TabIndex = 20
        Me.lblOrdStatus.Text = "JPON状況"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSearch.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(713, 39)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 30)
        Me.btnSearch.TabIndex = 21
        Me.btnSearch.Text = "検索"
        Me.btnSearch.Type = 2
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Goldenrod
        Me.btnClose.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnClose.Location = New System.Drawing.Point(802, 39)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(70, 30)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "閉じる"
        Me.btnClose.Type = 1
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'FrmStockReserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 560)
        Me.Controls.Add(Me.dgStockReserv)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmStockReserve"
        Me.Text = "自動引当履歴"
        Me.Controls.SetChildIndex(Me.pnlCondition, 0)
        Me.Controls.SetChildIndex(Me.dgStockReserv, 0)
        Me.pnlCondition.ResumeLayout(False)
        Me.pnlCondition.PerformLayout()
        CType(Me.dgStockReserv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtPickerFrom As DateTimePicker
    Friend WithEvents dtPickerTo As DateTimePicker
    Friend WithEvents txtItemCd As TextBox
    Friend WithEvents cmbOrdStatus As ComboBox
    Friend WithEvents chkReserving As CheckBox
    Friend WithEvents dgStockReserv As DataGridView
    Friend WithEvents lblItemName As Label
    Friend WithEvents lblOrdStatus As Label
    Friend WithEvents btnSearch As ButtonBase
    Friend WithEvents btnClose As ButtonBase
End Class
