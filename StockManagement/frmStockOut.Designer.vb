<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmStockOut
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtItemCd = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtActQty = New System.Windows.Forms.TextBox()
        Me.btnItemSearch = New System.Windows.Forms.Button()
        Me.cmbLocation = New System.Windows.Forms.ComboBox()
        Me.cmdAll = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdExec = New System.Windows.Forms.Button()
        Me.grd = New System.Windows.Forms.DataGridView()
        Me.ITEMCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOCATIONCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REMARKS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.btnClose = New StockManagement.ButtonBase()
        Me.btnAdd = New StockManagement.ButtonBase()
        Me.lblActQty = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.pnlCondition.SuspendLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCondition
        '
        Me.pnlCondition.Controls.Add(Me.lblLocation)
        Me.pnlCondition.Controls.Add(Me.lblActQty)
        Me.pnlCondition.Controls.Add(Me.btnAdd)
        Me.pnlCondition.Controls.Add(Me.btnClose)
        Me.pnlCondition.Controls.Add(Me.lblRemarks)
        Me.pnlCondition.Controls.Add(Me.lblQty)
        Me.pnlCondition.Controls.Add(Me.lblItemName)
        Me.pnlCondition.Controls.Add(Me.txtItemCd)
        Me.pnlCondition.Controls.Add(Me.btnItemSearch)
        Me.pnlCondition.Controls.Add(Me.cmbLocation)
        Me.pnlCondition.Controls.Add(Me.txtQty)
        Me.pnlCondition.Controls.Add(Me.txtActQty)
        Me.pnlCondition.Controls.Add(Me.txtRemarks)
        Me.pnlCondition.Size = New System.Drawing.Size(910, 112)
        '
        'txtItemCd
        '
        Me.txtItemCd.Location = New System.Drawing.Point(90, 15)
        Me.txtItemCd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemCd.Name = "txtItemCd"
        Me.txtItemCd.Size = New System.Drawing.Size(105, 19)
        Me.txtItemCd.TabIndex = 0
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(90, 45)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(2)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(105, 19)
        Me.txtQty.TabIndex = 1
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(90, 76)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(495, 19)
        Me.txtRemarks.TabIndex = 2
        '
        'txtActQty
        '
        Me.txtActQty.Location = New System.Drawing.Point(289, 45)
        Me.txtActQty.Margin = New System.Windows.Forms.Padding(2)
        Me.txtActQty.Name = "txtActQty"
        Me.txtActQty.Size = New System.Drawing.Size(56, 19)
        Me.txtActQty.TabIndex = 3
        '
        'btnItemSearch
        '
        Me.btnItemSearch.Location = New System.Drawing.Point(221, 13)
        Me.btnItemSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnItemSearch.Name = "btnItemSearch"
        Me.btnItemSearch.Size = New System.Drawing.Size(68, 22)
        Me.btnItemSearch.TabIndex = 4
        Me.btnItemSearch.Text = "商品検索"
        Me.btnItemSearch.UseVisualStyleBackColor = True
        '
        'cmbLocation
        '
        Me.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLocation.FormattingEnabled = True
        Me.cmbLocation.Location = New System.Drawing.Point(454, 44)
        Me.cmbLocation.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.Size = New System.Drawing.Size(131, 20)
        Me.cmbLocation.TabIndex = 7
        '
        'cmdAll
        '
        Me.cmdAll.Location = New System.Drawing.Point(51, 483)
        Me.cmdAll.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdAll.Name = "cmdAll"
        Me.cmdAll.Size = New System.Drawing.Size(115, 34)
        Me.cmdAll.TabIndex = 9
        Me.cmdAll.Text = "一括メンテナンス"
        Me.cmdAll.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(595, 483)
        Me.cmdDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 34)
        Me.cmdDelete.TabIndex = 10
        Me.cmdDelete.Text = "対象削除"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdExec
        '
        Me.cmdExec.Location = New System.Drawing.Point(701, 483)
        Me.cmdExec.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdExec.Name = "cmdExec"
        Me.cmdExec.Size = New System.Drawing.Size(80, 34)
        Me.cmdExec.TabIndex = 11
        Me.cmdExec.Text = "出庫処理"
        Me.cmdExec.UseVisualStyleBackColor = True
        '
        'grd
        '
        Me.grd.AllowUserToAddRows = False
        Me.grd.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grd.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grd.AutoGenerateColumns = False
        Me.grd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEMCD, Me.LOCATIONCD, Me.QTY, Me.REMARKS})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd.DefaultCellStyle = DataGridViewCellStyle6
        Me.grd.EnableHeadersVisualStyles = False
        Me.grd.Location = New System.Drawing.Point(11, 128)
        Me.grd.Margin = New System.Windows.Forms.Padding(2)
        Me.grd.Name = "grd"
        Me.grd.RowHeadersVisible = False
        Me.grd.RowHeadersWidth = 72
        Me.grd.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.grd.RowTemplate.ReadOnly = True
        Me.grd.Size = New System.Drawing.Size(888, 319)
        Me.grd.TabIndex = 12
        '
        'ITEMCD
        '
        Me.ITEMCD.DataPropertyName = "ITEMCD"
        Me.ITEMCD.HeaderText = "変更商品名"
        Me.ITEMCD.Name = "ITEMCD"
        Me.ITEMCD.Width = 150
        '
        'LOCATIONCD
        '
        Me.LOCATIONCD.DataPropertyName = "LOCATIONCD"
        Me.LOCATIONCD.HeaderText = "ロケーション"
        Me.LOCATIONCD.Name = "LOCATIONCD"
        '
        'QTY
        '
        Me.QTY.DataPropertyName = "QTY"
        Me.QTY.HeaderText = "数量"
        Me.QTY.Name = "QTY"
        '
        'REMARKS
        '
        Me.REMARKS.DataPropertyName = "REMARKS"
        Me.REMARKS.HeaderText = "備考"
        Me.REMARKS.Name = "REMARKS"
        Me.REMARKS.Width = 300
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblItemName.Location = New System.Drawing.Point(20, 18)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(65, 12)
        Me.lblItemName.TabIndex = 19
        Me.lblItemName.Text = "変更商品名"
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.ForeColor = System.Drawing.SystemColors.Control
        Me.lblQty.Location = New System.Drawing.Point(20, 48)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(29, 12)
        Me.lblQty.TabIndex = 20
        Me.lblQty.Text = "数量"
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.ForeColor = System.Drawing.SystemColors.Control
        Me.lblRemarks.Location = New System.Drawing.Point(20, 79)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(29, 12)
        Me.lblRemarks.TabIndex = 21
        Me.lblRemarks.Text = "備考"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Goldenrod
        Me.btnClose.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnClose.Location = New System.Drawing.Point(819, 15)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(70, 30)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "閉じる"
        Me.btnClose.Type = 1
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAdd.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(731, 15)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(70, 30)
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.Text = "追加"
        Me.btnAdd.Type = 2
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblActQty
        '
        Me.lblActQty.AutoSize = True
        Me.lblActQty.ForeColor = System.Drawing.SystemColors.Control
        Me.lblActQty.Location = New System.Drawing.Point(219, 48)
        Me.lblActQty.Name = "lblActQty"
        Me.lblActQty.Size = New System.Drawing.Size(53, 12)
        Me.lblActQty.TabIndex = 24
        Me.lblActQty.Text = "現在庫数"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.ForeColor = System.Drawing.SystemColors.Control
        Me.lblLocation.Location = New System.Drawing.Point(382, 48)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(67, 12)
        Me.lblLocation.TabIndex = 25
        Me.lblLocation.Text = "ロケーション"
        '
        'FrmStockOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 560)
        Me.Controls.Add(Me.grd)
        Me.Controls.Add(Me.cmdExec)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdAll)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmStockOut"
        Me.Text = "出庫処理"
        Me.Controls.SetChildIndex(Me.pnlCondition, 0)
        Me.Controls.SetChildIndex(Me.cmdAll, 0)
        Me.Controls.SetChildIndex(Me.cmdDelete, 0)
        Me.Controls.SetChildIndex(Me.cmdExec, 0)
        Me.Controls.SetChildIndex(Me.grd, 0)
        Me.pnlCondition.ResumeLayout(False)
        Me.pnlCondition.PerformLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtItemCd As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtActQty As TextBox
    Friend WithEvents btnItemSearch As Button
    Friend WithEvents cmbLocation As ComboBox
    Friend WithEvents cmdAll As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdExec As Button
    Friend WithEvents ITEMCDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LOCATIONCDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QTYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REMARKSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TARGETFLGDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents grd As DataGridView
    Friend WithEvents lblItemName As Label
    Friend WithEvents lblQty As Label
    Friend WithEvents lblRemarks As Label
    Friend WithEvents btnClose As ButtonBase
    Friend WithEvents btnAdd As ButtonBase
    Friend WithEvents lblActQty As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents ITEMCD As DataGridViewTextBoxColumn
    Friend WithEvents LOCATIONCD As DataGridViewTextBoxColumn
    Friend WithEvents QTY As DataGridViewTextBoxColumn
    Friend WithEvents REMARKS As DataGridViewTextBoxColumn
End Class
