<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStockList
    Inherits FrmBase

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.txtItemCd = New System.Windows.Forms.TextBox()
        Me.btnSearch = New StockManagement.ButtonBase()
        Me.grd = New System.Windows.Forms.DataGridView()
        Me.lblItemNm = New System.Windows.Forms.Label()
        Me.txtItemNm = New System.Windows.Forms.TextBox()
        Me.ITEMCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SAFEQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUMACTQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUMRESERVTOTALQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUMRemainQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACTQTY0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESERVTOTALQTY0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemainQTY0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkWarning = New System.Windows.Forms.CheckBox()
        Me.pnlCondition.SuspendLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCondition
        '
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
        Me.lblItemName.Location = New System.Drawing.Point(20, 15)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(65, 12)
        Me.lblItemName.TabIndex = 21
        Me.lblItemName.Text = "変更商品名"
        '
        'txtItemCd
        '
        Me.txtItemCd.Location = New System.Drawing.Point(90, 11)
        Me.txtItemCd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemCd.Name = "txtItemCd"
        Me.txtItemCd.Size = New System.Drawing.Size(120, 19)
        Me.txtItemCd.TabIndex = 20
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSearch.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(731, 15)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 30)
        Me.btnSearch.TabIndex = 22
        Me.btnSearch.Text = "検索"
        Me.btnSearch.Type = 2
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'grd
        '
        Me.grd.AllowUserToResizeRows = False
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grd.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle12
        Me.grd.AutoGenerateColumns = False
        Me.grd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.Font = New System.Drawing.Font("MS PGothic", 9.0!)
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.grd.ColumnHeadersHeight = 46
        Me.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEMCD, Me.SCODE, Me.ITEMNAME, Me.SAFEQTY, Me.SUMACTQTY, Me.SUMRESERVTOTALQTY, Me.SUMRemainQTY, Me.ACTQTY0, Me.RESERVTOTALQTY0, Me.RemainQTY0})
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle22.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(178, Byte), Integer))
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd.DefaultCellStyle = DataGridViewCellStyle22
        Me.grd.EnableHeadersVisualStyles = False
        Me.grd.Location = New System.Drawing.Point(10, 90)
        Me.grd.Name = "grd"
        Me.grd.RowHeadersVisible = False
        Me.grd.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.grd.RowTemplate.ReadOnly = True
        Me.grd.Size = New System.Drawing.Size(890, 440)
        Me.grd.TabIndex = 1
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
        Me.txtItemNm.Location = New System.Drawing.Point(88, 45)
        Me.txtItemNm.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemNm.Name = "txtItemNm"
        Me.txtItemNm.Size = New System.Drawing.Size(120, 19)
        Me.txtItemNm.TabIndex = 24
        '
        'ITEMCD
        '
        Me.ITEMCD.DataPropertyName = "ITEMCD"
        Me.ITEMCD.HeaderText = "変換商品名"
        Me.ITEMCD.Name = "ITEMCD"
        Me.ITEMCD.Width = 130
        '
        'SCODE
        '
        Me.SCODE.DataPropertyName = "SCODE"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SCODE.DefaultCellStyle = DataGridViewCellStyle14
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
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SAFEQTY.DefaultCellStyle = DataGridViewCellStyle15
        Me.SAFEQTY.HeaderText = "安"
        Me.SAFEQTY.Name = "SAFEQTY"
        Me.SAFEQTY.Width = 30
        '
        'SUMACTQTY
        '
        Me.SUMACTQTY.DataPropertyName = "SUMACTQTY"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SUMACTQTY.DefaultCellStyle = DataGridViewCellStyle16
        Me.SUMACTQTY.HeaderText = "実"
        Me.SUMACTQTY.Name = "SUMACTQTY"
        Me.SUMACTQTY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SUMACTQTY.Width = 45
        '
        'SUMRESERVTOTALQTY
        '
        Me.SUMRESERVTOTALQTY.DataPropertyName = "SUMRESERVTOTALQTY"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SUMRESERVTOTALQTY.DefaultCellStyle = DataGridViewCellStyle17
        Me.SUMRESERVTOTALQTY.HeaderText = "引"
        Me.SUMRESERVTOTALQTY.Name = "SUMRESERVTOTALQTY"
        Me.SUMRESERVTOTALQTY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SUMRESERVTOTALQTY.Width = 40
        '
        'SUMRemainQTY
        '
        Me.SUMRemainQTY.DataPropertyName = "SUMRemainQTY"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SUMRemainQTY.DefaultCellStyle = DataGridViewCellStyle18
        Me.SUMRemainQTY.HeaderText = "理"
        Me.SUMRemainQTY.Name = "SUMRemainQTY"
        Me.SUMRemainQTY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SUMRemainQTY.Width = 45
        '
        'ACTQTY0
        '
        Me.ACTQTY0.DataPropertyName = "ACTQTY0"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ACTQTY0.DefaultCellStyle = DataGridViewCellStyle19
        Me.ACTQTY0.HeaderText = "実"
        Me.ACTQTY0.Name = "ACTQTY0"
        Me.ACTQTY0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ACTQTY0.Width = 45
        '
        'RESERVTOTALQTY0
        '
        Me.RESERVTOTALQTY0.DataPropertyName = "RESERVTOTALQTY0"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.RESERVTOTALQTY0.DefaultCellStyle = DataGridViewCellStyle20
        Me.RESERVTOTALQTY0.HeaderText = "引"
        Me.RESERVTOTALQTY0.Name = "RESERVTOTALQTY0"
        Me.RESERVTOTALQTY0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.RESERVTOTALQTY0.Width = 40
        '
        'RemainQTY0
        '
        Me.RemainQTY0.DataPropertyName = "RemainQTY0"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.RemainQTY0.DefaultCellStyle = DataGridViewCellStyle21
        Me.RemainQTY0.HeaderText = "理"
        Me.RemainQTY0.Name = "RemainQTY0"
        Me.RemainQTY0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.RemainQTY0.Width = 45
        '
        'chkWarning
        '
        Me.chkWarning.AutoSize = True
        Me.chkWarning.ForeColor = System.Drawing.SystemColors.Control
        Me.chkWarning.Location = New System.Drawing.Point(233, 48)
        Me.chkWarning.Name = "chkWarning"
        Me.chkWarning.Size = New System.Drawing.Size(271, 16)
        Me.chkWarning.TabIndex = 25
        Me.chkWarning.Text = "有効在庫が安全在庫数を下回った商品のみ表示"
        Me.chkWarning.UseVisualStyleBackColor = True
        '
        'FrmStockList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 560)
        Me.Controls.Add(Me.grd)
        Me.Name = "FrmStockList"
        Me.Text = "在庫一覧"
        Me.Controls.SetChildIndex(Me.pnlCondition, 0)
        Me.Controls.SetChildIndex(Me.grd, 0)
        Me.pnlCondition.ResumeLayout(False)
        Me.pnlCondition.PerformLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblItemName As Label
    Friend WithEvents txtItemCd As TextBox
    Friend WithEvents btnSearch As ButtonBase
    Friend WithEvents grd As DataGridView
    Friend WithEvents lblItemNm As Label
    Friend WithEvents txtItemNm As TextBox
    Friend WithEvents ITEMCD As DataGridViewTextBoxColumn
    Friend WithEvents SCODE As DataGridViewTextBoxColumn
    Friend WithEvents ITEMNAME As DataGridViewTextBoxColumn
    Friend WithEvents SAFEQTY As DataGridViewTextBoxColumn
    Friend WithEvents SUMACTQTY As DataGridViewTextBoxColumn
    Friend WithEvents SUMRESERVTOTALQTY As DataGridViewTextBoxColumn
    Friend WithEvents SUMRemainQTY As DataGridViewTextBoxColumn
    Friend WithEvents ACTQTY0 As DataGridViewTextBoxColumn
    Friend WithEvents RESERVTOTALQTY0 As DataGridViewTextBoxColumn
    Friend WithEvents RemainQTY0 As DataGridViewTextBoxColumn
    Friend WithEvents chkWarning As CheckBox
End Class
