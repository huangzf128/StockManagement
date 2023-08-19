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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.grd = New StockManagement.DataGridViewBase()
        Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ITEMCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOCATIONCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOCATIONNM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REMARKS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdd = New StockManagement.ButtonBase()
        Me.btnDelete = New StockManagement.ButtonBase()
        Me.btnItemSearch = New StockManagement.ButtonBase()
        Me.btnExecute = New StockManagement.ButtonBase()
        Me.LabelBase1 = New StockManagement.LabelBase()
        Me.txtQty = New StockManagement.TextBoxBase()
        Me.btnPaste = New StockManagement.ButtonBase()
        Me.lblQty = New StockManagement.LabelBase()
        Me.lblRemarks = New StockManagement.LabelBase()
        Me.LabelBase2 = New StockManagement.LabelBase()
        Me.lblLocation = New StockManagement.LabelBase()
        Me.lblLocationNm = New StockManagement.LabelBase()
        Me.lblActQty = New StockManagement.LabelBase()
        Me.lblLocationCd = New StockManagement.LabelBase()
        Me.lblBar = New StockManagement.LabelBase()
        Me.LabelBase3 = New StockManagement.LabelBase()
        Me.lblItemCd = New StockManagement.LabelBase()
        Me.pnlCondition.SuspendLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCondition
        '
        Me.pnlCondition.Controls.Add(Me.lblItemCd)
        Me.pnlCondition.Controls.Add(Me.LabelBase3)
        Me.pnlCondition.Controls.Add(Me.lblBar)
        Me.pnlCondition.Controls.Add(Me.lblLocationCd)
        Me.pnlCondition.Controls.Add(Me.lblActQty)
        Me.pnlCondition.Controls.Add(Me.lblLocationNm)
        Me.pnlCondition.Controls.Add(Me.lblLocation)
        Me.pnlCondition.Controls.Add(Me.LabelBase2)
        Me.pnlCondition.Controls.Add(Me.lblRemarks)
        Me.pnlCondition.Controls.Add(Me.lblQty)
        Me.pnlCondition.Controls.Add(Me.btnPaste)
        Me.pnlCondition.Controls.Add(Me.txtQty)
        Me.pnlCondition.Controls.Add(Me.LabelBase1)
        Me.pnlCondition.Controls.Add(Me.btnItemSearch)
        Me.pnlCondition.Controls.Add(Me.btnAdd)
        Me.pnlCondition.Controls.Add(Me.txtRemarks)
        Me.pnlCondition.Size = New System.Drawing.Size(910, 112)
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(61, 77)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(495, 19)
        Me.txtRemarks.TabIndex = 2
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS PGothic", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk, Me.ITEMCD, Me.LOCATIONCD, Me.LOCATIONNM, Me.QTY, Me.REMARKS})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd.DefaultCellStyle = DataGridViewCellStyle4
        Me.grd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grd.EnableHeadersVisualStyles = False
        Me.grd.Location = New System.Drawing.Point(11, 117)
        Me.grd.Margin = New System.Windows.Forms.Padding(2)
        Me.grd.Name = "grd"
        Me.grd.RowHeadersVisible = False
        Me.grd.RowHeadersWidth = 72
        Me.grd.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.grd.Size = New System.Drawing.Size(888, 394)
        Me.grd.TabIndex = 12
        Me.grd.Type = 1
        '
        'chk
        '
        Me.chk.HeaderText = "選択"
        Me.chk.Name = "chk"
        Me.chk.Width = 40
        '
        'ITEMCD
        '
        Me.ITEMCD.DataPropertyName = "ITEMCD"
        Me.ITEMCD.HeaderText = "変更商品名"
        Me.ITEMCD.Name = "ITEMCD"
        Me.ITEMCD.ReadOnly = True
        Me.ITEMCD.Width = 180
        '
        'LOCATIONCD
        '
        Me.LOCATIONCD.DataPropertyName = "LOCATIONCD"
        Me.LOCATIONCD.HeaderText = "Loc"
        Me.LOCATIONCD.Name = "LOCATIONCD"
        Me.LOCATIONCD.Width = 50
        '
        'LOCATIONNM
        '
        Me.LOCATIONNM.DataPropertyName = "LOCATIONNM"
        Me.LOCATIONNM.HeaderText = "ロケーション名"
        Me.LOCATIONNM.Name = "LOCATIONNM"
        Me.LOCATIONNM.ReadOnly = True
        Me.LOCATIONNM.Width = 110
        '
        'QTY
        '
        Me.QTY.DataPropertyName = "QTY"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = Nothing
        Me.QTY.DefaultCellStyle = DataGridViewCellStyle3
        Me.QTY.HeaderText = "数量"
        Me.QTY.Name = "QTY"
        Me.QTY.Width = 70
        '
        'REMARKS
        '
        Me.REMARKS.DataPropertyName = "REMARKS"
        Me.REMARKS.HeaderText = "備考"
        Me.REMARKS.Name = "REMARKS"
        Me.REMARKS.Width = 320
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAdd.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAdd.Location = New System.Drawing.Point(731, 15)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(70, 30)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "追加"
        Me.btnAdd.Type = 5
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnDelete.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDelete.Location = New System.Drawing.Point(11, 518)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(70, 30)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "対象削除"
        Me.btnDelete.Type = 6
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnItemSearch
        '
        Me.btnItemSearch.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnItemSearch.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnItemSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnItemSearch.Location = New System.Drawing.Point(20, 10)
        Me.btnItemSearch.Name = "btnItemSearch"
        Me.btnItemSearch.Size = New System.Drawing.Size(70, 30)
        Me.btnItemSearch.TabIndex = 31
        Me.btnItemSearch.Text = "商品検索"
        Me.btnItemSearch.Type = 2
        Me.btnItemSearch.UseVisualStyleBackColor = False
        '
        'btnExecute
        '
        Me.btnExecute.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnExecute.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnExecute.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExecute.Location = New System.Drawing.Point(810, 519)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(70, 30)
        Me.btnExecute.TabIndex = 12
        Me.btnExecute.Text = "出庫"
        Me.btnExecute.Type = 5
        Me.btnExecute.UseVisualStyleBackColor = False
        '
        'LabelBase1
        '
        Me.LabelBase1.AutoSize = True
        Me.LabelBase1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LabelBase1.Location = New System.Drawing.Point(694, 92)
        Me.LabelBase1.Name = "LabelBase1"
        Me.LabelBase1.Size = New System.Drawing.Size(186, 12)
        Me.LabelBase1.TabIndex = 32
        Me.LabelBase1.Text = "※数量と備考は直接編集できます。"
        Me.LabelBase1.Type = 0
        '
        'txtQty
        '
        Me.txtQty.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtQty.Location = New System.Drawing.Point(61, 45)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(45, 19)
        Me.txtQty.TabIndex = 1
        Me.txtQty.Type = 1
        '
        'btnPaste
        '
        Me.btnPaste.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnPaste.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnPaste.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPaste.Location = New System.Drawing.Point(810, 15)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(70, 30)
        Me.btnPaste.TabIndex = 11
        Me.btnPaste.Text = "貼付け"
        Me.btnPaste.Type = 4
        Me.btnPaste.UseVisualStyleBackColor = False
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(26, 50)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(29, 12)
        Me.lblQty.TabIndex = 35
        Me.lblQty.Text = "数量"
        Me.lblQty.Type = 0
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Location = New System.Drawing.Point(25, 80)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(29, 12)
        Me.lblRemarks.TabIndex = 36
        Me.lblRemarks.Text = "備考"
        Me.lblRemarks.Type = 0
        '
        'LabelBase2
        '
        Me.LabelBase2.AutoSize = True
        Me.LabelBase2.Location = New System.Drawing.Point(153, 50)
        Me.LabelBase2.Name = "LabelBase2"
        Me.LabelBase2.Size = New System.Drawing.Size(53, 12)
        Me.LabelBase2.TabIndex = 37
        Me.LabelBase2.Text = "現在庫数"
        Me.LabelBase2.Type = 0
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(290, 50)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(67, 12)
        Me.lblLocation.TabIndex = 38
        Me.lblLocation.Text = "ロケーション"
        Me.lblLocation.Type = 0
        '
        'lblLocationNm
        '
        Me.lblLocationNm.AutoSize = True
        Me.lblLocationNm.Location = New System.Drawing.Point(402, 50)
        Me.lblLocationNm.Name = "lblLocationNm"
        Me.lblLocationNm.Size = New System.Drawing.Size(37, 12)
        Me.lblLocationNm.TabIndex = 39
        Me.lblLocationNm.Text = "NAME"
        Me.lblLocationNm.Type = 0
        '
        'lblActQty
        '
        Me.lblActQty.AutoSize = True
        Me.lblActQty.Location = New System.Drawing.Point(211, 50)
        Me.lblActQty.Name = "lblActQty"
        Me.lblActQty.Size = New System.Drawing.Size(23, 12)
        Me.lblActQty.TabIndex = 40
        Me.lblActQty.Text = "999"
        Me.lblActQty.Type = 0
        '
        'lblLocationCd
        '
        Me.lblLocationCd.AutoSize = True
        Me.lblLocationCd.Location = New System.Drawing.Point(368, 50)
        Me.lblLocationCd.Name = "lblLocationCd"
        Me.lblLocationCd.Size = New System.Drawing.Size(21, 12)
        Me.lblLocationCd.TabIndex = 41
        Me.lblLocationCd.Text = "CD"
        Me.lblLocationCd.Type = 0
        '
        'lblBar
        '
        Me.lblBar.AutoSize = True
        Me.lblBar.Location = New System.Drawing.Point(388, 50)
        Me.lblBar.Name = "lblBar"
        Me.lblBar.Size = New System.Drawing.Size(17, 12)
        Me.lblBar.TabIndex = 42
        Me.lblBar.Text = "―"
        Me.lblBar.Type = 0
        '
        'LabelBase3
        '
        Me.LabelBase3.AutoSize = True
        Me.LabelBase3.Location = New System.Drawing.Point(112, 18)
        Me.LabelBase3.Name = "LabelBase3"
        Me.LabelBase3.Size = New System.Drawing.Size(65, 12)
        Me.LabelBase3.TabIndex = 43
        Me.LabelBase3.Text = "変更商品名"
        Me.LabelBase3.Type = 0
        '
        'lblItemCd
        '
        Me.lblItemCd.AutoSize = True
        Me.lblItemCd.Location = New System.Drawing.Point(184, 18)
        Me.lblItemCd.Name = "lblItemCd"
        Me.lblItemCd.Size = New System.Drawing.Size(23, 12)
        Me.lblItemCd.TabIndex = 44
        Me.lblItemCd.Text = "999"
        Me.lblItemCd.Type = 0
        '
        'FrmStockOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 560)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.grd)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmStockOut"
        Me.Text = "出庫処理"
        Me.Controls.SetChildIndex(Me.pnlCondition, 0)
        Me.Controls.SetChildIndex(Me.grd, 0)
        Me.Controls.SetChildIndex(Me.btnDelete, 0)
        Me.Controls.SetChildIndex(Me.btnExecute, 0)
        Me.pnlCondition.ResumeLayout(False)
        Me.pnlCondition.PerformLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents ITEMCDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LOCATIONCDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QTYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REMARKSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TARGETFLGDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents btnAdd As ButtonBase
    Friend WithEvents grd As DataGridViewBase
    Friend WithEvents btnDelete As ButtonBase
    Friend WithEvents btnItemSearch As ButtonBase
    Protected Friend WithEvents btnExecute As ButtonBase
    Friend WithEvents LabelBase1 As LabelBase
    Friend WithEvents txtQty As TextBoxBase
    Friend WithEvents btnPaste As ButtonBase
    Friend WithEvents lblQty As LabelBase
    Friend WithEvents lblRemarks As LabelBase
    Friend WithEvents LabelBase2 As LabelBase
    Friend WithEvents lblLocation As LabelBase
    Friend WithEvents lblLocationNm As LabelBase
    Friend WithEvents lblLocationCd As LabelBase
    Friend WithEvents lblActQty As LabelBase
    Friend WithEvents lblBar As LabelBase
    Friend WithEvents lblItemCd As LabelBase
    Friend WithEvents LabelBase3 As LabelBase
    Friend WithEvents chk As DataGridViewCheckBoxColumn
    Friend WithEvents ITEMCD As DataGridViewTextBoxColumn
    Friend WithEvents LOCATIONCD As DataGridViewTextBoxColumn
    Friend WithEvents LOCATIONNM As DataGridViewTextBoxColumn
    Friend WithEvents QTY As DataGridViewTextBoxColumn
    Friend WithEvents REMARKS As DataGridViewTextBoxColumn
End Class
