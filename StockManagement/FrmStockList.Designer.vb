<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmStockList
    Inherits FrmBase

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.txtItemCd = New System.Windows.Forms.TextBox()
        Me.btnSearch = New StockManagement.ButtonBase()
        Me.grd = New StockManagement.DataGridViewBase()
        Me.ITEMCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SAFEQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUMACTQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUMRESERVTOTALQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUMRemainQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblItemNm = New System.Windows.Forms.Label()
        Me.txtItemNm = New System.Windows.Forms.TextBox()
        Me.chkWarning = New System.Windows.Forms.CheckBox()
        Me.btnCopy = New StockManagement.ButtonBase()
        Me.bindingNavi = New StockManagement.UBindingNavigator()
        Me.lblRemainQty = New System.Windows.Forms.Label()
        Me.txtRemainQty = New StockManagement.TextBoxBase()
        Me.pnlCondition.SuspendLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCondition
        '
        Me.pnlCondition.Controls.Add(Me.txtRemainQty)
        Me.pnlCondition.Controls.Add(Me.lblRemainQty)
        Me.pnlCondition.Controls.Add(Me.btnCopy)
        Me.pnlCondition.Controls.Add(Me.chkWarning)
        Me.pnlCondition.Controls.Add(Me.txtItemNm)
        Me.pnlCondition.Controls.Add(Me.lblItemNm)
        Me.pnlCondition.Controls.Add(Me.btnSearch)
        Me.pnlCondition.Controls.Add(Me.lblItemName)
        Me.pnlCondition.Controls.Add(Me.txtItemCd)
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblItemName.Location = New System.Drawing.Point(20, 18)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(65, 12)
        Me.lblItemName.TabIndex = 21
        Me.lblItemName.Text = "変更商品名"
        '
        'txtItemCd
        '
        Me.txtItemCd.Location = New System.Drawing.Point(90, 15)
        Me.txtItemCd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemCd.Name = "txtItemCd"
        Me.txtItemCd.Size = New System.Drawing.Size(120, 19)
        Me.txtItemCd.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSearch.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(730, 15)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 30)
        Me.btnSearch.TabIndex = 10
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEMCD, Me.SCODE, Me.ITEMNAME, Me.SAFEQTY, Me.SUMACTQTY, Me.SUMRESERVTOTALQTY, Me.SUMRemainQTY})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd.DefaultCellStyle = DataGridViewCellStyle8
        Me.grd.EnableHeadersVisualStyles = False
        Me.grd.Location = New System.Drawing.Point(10, 90)
        Me.grd.Name = "grd"
        Me.grd.RowHeadersVisible = False
        Me.grd.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.grd.Size = New System.Drawing.Size(890, 440)
        Me.grd.TabIndex = 12
        Me.grd.Type = 0
        '
        'ITEMCD
        '
        Me.ITEMCD.DataPropertyName = "ITEMCD"
        Me.ITEMCD.Frozen = True
        Me.ITEMCD.HeaderText = "変換商品名"
        Me.ITEMCD.Name = "ITEMCD"
        Me.ITEMCD.Width = 130
        '
        'SCODE
        '
        Me.SCODE.DataPropertyName = "SCODE"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SCODE.DefaultCellStyle = DataGridViewCellStyle3
        Me.SCODE.HeaderText = "S-Code"
        Me.SCODE.Name = "SCODE"
        Me.SCODE.Width = 65
        '
        'ITEMNAME
        '
        Me.ITEMNAME.DataPropertyName = "ITEMNAME"
        Me.ITEMNAME.HeaderText = "商品名"
        Me.ITEMNAME.Name = "ITEMNAME"
        Me.ITEMNAME.Width = 160
        '
        'SAFEQTY
        '
        Me.SAFEQTY.DataPropertyName = "SAFEQTY"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.NullValue = Nothing
        Me.SAFEQTY.DefaultCellStyle = DataGridViewCellStyle4
        Me.SAFEQTY.HeaderText = "安全在庫数"
        Me.SAFEQTY.Name = "SAFEQTY"
        Me.SAFEQTY.Width = 46
        '
        'SUMACTQTY
        '
        Me.SUMACTQTY.DataPropertyName = "SUMACTQTY"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SUMACTQTY.DefaultCellStyle = DataGridViewCellStyle5
        Me.SUMACTQTY.HeaderText = "実在庫数"
        Me.SUMACTQTY.Name = "SUMACTQTY"
        Me.SUMACTQTY.Width = 60
        '
        'SUMRESERVTOTALQTY
        '
        Me.SUMRESERVTOTALQTY.DataPropertyName = "SUMRESERVTOTALQTY"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SUMRESERVTOTALQTY.DefaultCellStyle = DataGridViewCellStyle6
        Me.SUMRESERVTOTALQTY.HeaderText = "引当数"
        Me.SUMRESERVTOTALQTY.Name = "SUMRESERVTOTALQTY"
        Me.SUMRESERVTOTALQTY.Width = 50
        '
        'SUMRemainQTY
        '
        Me.SUMRemainQTY.DataPropertyName = "SUMRemainQTY"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SUMRemainQTY.DefaultCellStyle = DataGridViewCellStyle7
        Me.SUMRemainQTY.HeaderText = "有効在庫数"
        Me.SUMRemainQTY.Name = "SUMRemainQTY"
        Me.SUMRemainQTY.Width = 70
        '
        'lblItemNm
        '
        Me.lblItemNm.AutoSize = True
        Me.lblItemNm.ForeColor = System.Drawing.SystemColors.Control
        Me.lblItemNm.Location = New System.Drawing.Point(20, 48)
        Me.lblItemNm.Name = "lblItemNm"
        Me.lblItemNm.Size = New System.Drawing.Size(41, 12)
        Me.lblItemNm.TabIndex = 23
        Me.lblItemNm.Text = "商品名"
        '
        'txtItemNm
        '
        Me.txtItemNm.Location = New System.Drawing.Point(90, 45)
        Me.txtItemNm.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemNm.Name = "txtItemNm"
        Me.txtItemNm.Size = New System.Drawing.Size(120, 19)
        Me.txtItemNm.TabIndex = 5
        '
        'chkWarning
        '
        Me.chkWarning.AutoSize = True
        Me.chkWarning.ForeColor = System.Drawing.SystemColors.Control
        Me.chkWarning.Location = New System.Drawing.Point(233, 48)
        Me.chkWarning.Name = "chkWarning"
        Me.chkWarning.Size = New System.Drawing.Size(271, 16)
        Me.chkWarning.TabIndex = 6
        Me.chkWarning.Text = "有効在庫が安全在庫数を下回った商品のみ表示"
        Me.chkWarning.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.BackColor = System.Drawing.Color.Sienna
        Me.btnCopy.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnCopy.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCopy.Location = New System.Drawing.Point(810, 15)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(70, 30)
        Me.btnCopy.TabIndex = 11
        Me.btnCopy.Text = "全コピー"
        Me.btnCopy.Type = 5
        Me.btnCopy.UseVisualStyleBackColor = False
        '
        'bindingNavi
        '
        Me.bindingNavi.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bindingNavi.Location = New System.Drawing.Point(0, 535)
        Me.bindingNavi.Name = "bindingNavi"
        Me.bindingNavi.Size = New System.Drawing.Size(910, 25)
        Me.bindingNavi.TabIndex = 6
        '
        'lblRemainQty
        '
        Me.lblRemainQty.AutoSize = True
        Me.lblRemainQty.ForeColor = System.Drawing.SystemColors.Control
        Me.lblRemainQty.Location = New System.Drawing.Point(231, 18)
        Me.lblRemainQty.Name = "lblRemainQty"
        Me.lblRemainQty.Size = New System.Drawing.Size(65, 12)
        Me.lblRemainQty.TabIndex = 26
        Me.lblRemainQty.Text = "有効在庫数"
        '
        'txtRemainQty
        '
        Me.txtRemainQty.Location = New System.Drawing.Point(302, 15)
        Me.txtRemainQty.MaxLength = 4
        Me.txtRemainQty.Name = "txtRemainQty"
        Me.txtRemainQty.Size = New System.Drawing.Size(51, 19)
        Me.txtRemainQty.TabIndex = 27
        Me.txtRemainQty.Type = 1
        '
        'FrmStockList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 560)
        Me.Controls.Add(Me.bindingNavi)
        Me.Controls.Add(Me.grd)
        Me.Name = "FrmStockList"
        Me.Text = "在庫一覧"
        Me.Controls.SetChildIndex(Me.pnlCondition, 0)
        Me.Controls.SetChildIndex(Me.grd, 0)
        Me.Controls.SetChildIndex(Me.bindingNavi, 0)
        Me.pnlCondition.ResumeLayout(False)
        Me.pnlCondition.PerformLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblItemName As Label
    Friend WithEvents txtItemCd As TextBox
    Friend WithEvents btnSearch As ButtonBase
    Friend WithEvents grd As DataGridViewBase
    Friend WithEvents lblItemNm As Label
    Friend WithEvents txtItemNm As TextBox
    Friend WithEvents chkWarning As CheckBox
    Friend WithEvents btnCopy As ButtonBase
    Friend WithEvents bindingNavi As UBindingNavigator
    Friend WithEvents lblRemainQty As Label
    Friend WithEvents txtRemainQty As TextBoxBase
    Friend WithEvents ITEMCD As DataGridViewTextBoxColumn
    Friend WithEvents SCODE As DataGridViewTextBoxColumn
    Friend WithEvents ITEMNAME As DataGridViewTextBoxColumn
    Friend WithEvents SAFEQTY As DataGridViewTextBoxColumn
    Friend WithEvents SUMACTQTY As DataGridViewTextBoxColumn
    Friend WithEvents SUMRESERVTOTALQTY As DataGridViewTextBoxColumn
    Friend WithEvents SUMRemainQTY As DataGridViewTextBoxColumn
End Class
