<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmStockListHistory
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
        Me.dtPickerFrom = New StockManagement.UDataTimePicker()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.txtItemCd = New System.Windows.Forms.TextBox()
        Me.btnSearch = New StockManagement.ButtonBase()
        Me.grd = New StockManagement.DataGridViewBase()
        Me.ITEMCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOCATIONNM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOCATIONCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CRTDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTYI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCopy = New StockManagement.ButtonBase()
        Me.pnlCondition.SuspendLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCondition
        '
        Me.pnlCondition.Controls.Add(Me.btnCopy)
        Me.pnlCondition.Controls.Add(Me.btnSearch)
        Me.pnlCondition.Controls.Add(Me.dtPickerFrom)
        Me.pnlCondition.Controls.Add(Me.lblItemName)
        Me.pnlCondition.Controls.Add(Me.txtItemCd)
        '
        'dtPickerFrom
        '
        Me.dtPickerFrom.Location = New System.Drawing.Point(20, 15)
        Me.dtPickerFrom.Name = "dtPickerFrom"
        Me.dtPickerFrom.Size = New System.Drawing.Size(190, 20)
        Me.dtPickerFrom.TabIndex = 29
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
        Me.txtItemCd.Size = New System.Drawing.Size(223, 19)
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
        Me.grd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEMCD, Me.LOCATIONNM, Me.LOCATIONCD, Me.QTY, Me.CRTDT, Me.QTYI, Me.QTYO})
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
        Me.ITEMCD.HeaderText = "変更商品名"
        Me.ITEMCD.Name = "ITEMCD"
        Me.ITEMCD.Width = 150
        '
        'LOCATIONNM
        '
        Me.LOCATIONNM.DataPropertyName = "LOCATIONNM"
        Me.LOCATIONNM.HeaderText = "ロケーション"
        Me.LOCATIONNM.Name = "LOCATIONNM"
        '
        'LOCATIONCD
        '
        Me.LOCATIONCD.DataPropertyName = "LOCATIONCD"
        Me.LOCATIONCD.HeaderText = "LOCATIONCD"
        Me.LOCATIONCD.Name = "LOCATIONCD"
        Me.LOCATIONCD.Visible = False
        '
        'QTY
        '
        Me.QTY.DataPropertyName = "QTY"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.QTY.DefaultCellStyle = DataGridViewCellStyle3
        Me.QTY.HeaderText = "数量"
        Me.QTY.Name = "QTY"
        '
        'CRTDT
        '
        Me.CRTDT.DataPropertyName = "CRTDT"
        Me.CRTDT.HeaderText = "最終移動日"
        Me.CRTDT.Name = "CRTDT"
        Me.CRTDT.Width = 90
        '
        'QTYI
        '
        Me.QTYI.DataPropertyName = "QTYI"
        Me.QTYI.HeaderText = "1日～入庫合計"
        Me.QTYI.Name = "QTYI"
        Me.QTYI.Width = 110
        '
        'QTYO
        '
        Me.QTYO.DataPropertyName = "QTYO"
        Me.QTYO.HeaderText = "1日～出庫合計"
        Me.QTYO.Name = "QTYO"
        Me.QTYO.Width = 110
        '
        'btnCopy
        '
        Me.btnCopy.BackColor = System.Drawing.Color.Sienna
        Me.btnCopy.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnCopy.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCopy.Location = New System.Drawing.Point(810, 15)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(70, 30)
        Me.btnCopy.TabIndex = 32
        Me.btnCopy.Text = "全コピー"
        Me.btnCopy.Type = 5
        Me.btnCopy.UseVisualStyleBackColor = False
        '
        'FrmStockListHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 560)
        Me.Controls.Add(Me.grd)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmStockListHistory"
        Me.Text = "在庫履歴一覧"
        Me.Controls.SetChildIndex(Me.pnlCondition, 0)
        Me.Controls.SetChildIndex(Me.grd, 0)
        Me.pnlCondition.ResumeLayout(False)
        Me.pnlCondition.PerformLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtPickerFrom As UDataTimePicker
    Friend WithEvents lblItemName As Label
    Friend WithEvents txtItemCd As TextBox
    Friend WithEvents btnSearch As ButtonBase
    Friend WithEvents grd As DataGridViewBase
    Friend WithEvents btnCopy As ButtonBase
    Friend WithEvents ITEMCD As DataGridViewTextBoxColumn
    Friend WithEvents LOCATIONNM As DataGridViewTextBoxColumn
    Friend WithEvents LOCATIONCD As DataGridViewTextBoxColumn
    Friend WithEvents QTY As DataGridViewTextBoxColumn
    Friend WithEvents CRTDT As DataGridViewTextBoxColumn
    Friend WithEvents QTYI As DataGridViewTextBoxColumn
    Friend WithEvents QTYO As DataGridViewTextBoxColumn
End Class
