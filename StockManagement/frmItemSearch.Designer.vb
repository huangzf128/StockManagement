﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItemSearch
    Inherits SubFrmBase

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtItemCd = New System.Windows.Forms.TextBox()
        Me.grd = New StockManagement.DataGridViewBase()
        Me.ITEMCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOCATIONNM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACTQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOCATIONCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSearch = New StockManagement.ButtonBase()
        Me.btnClose = New StockManagement.ButtonBase()
        Me.cmbLocation = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblItemName = New StockManagement.LabelBase()
        Me.lblLocation = New StockManagement.LabelBase()
        Me.pnlCondition.SuspendLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Size = New System.Drawing.Size(126, 16)
        Me.lblTitle.Text = "変更商品名検索"
        '
        'pnlCondition
        '
        Me.pnlCondition.Controls.Add(Me.lblLocation)
        Me.pnlCondition.Controls.Add(Me.lblItemName)
        Me.pnlCondition.Controls.Add(Me.cmbLocation)
        Me.pnlCondition.Controls.Add(Me.btnClose)
        Me.pnlCondition.Controls.Add(Me.btnSearch)
        Me.pnlCondition.Controls.Add(Me.txtItemCd)
        Me.pnlCondition.Size = New System.Drawing.Size(411, 60)
        '
        'txtItemCd
        '
        Me.txtItemCd.Location = New System.Drawing.Point(92, 8)
        Me.txtItemCd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemCd.Name = "txtItemCd"
        Me.txtItemCd.Size = New System.Drawing.Size(131, 19)
        Me.txtItemCd.TabIndex = 1
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS PGothic", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEMCD, Me.LOCATIONNM, Me.ACTQTY, Me.LOCATIONCD})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd.DefaultCellStyle = DataGridViewCellStyle4
        Me.grd.EnableHeadersVisualStyles = False
        Me.grd.Location = New System.Drawing.Point(10, 116)
        Me.grd.Margin = New System.Windows.Forms.Padding(2)
        Me.grd.Name = "grd"
        Me.grd.RowHeadersVisible = False
        Me.grd.RowHeadersWidth = 72
        Me.grd.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.grd.Size = New System.Drawing.Size(394, 297)
        Me.grd.TabIndex = 2
        Me.grd.Type = 0
        '
        'ITEMCD
        '
        Me.ITEMCD.DataPropertyName = "ITEMCD"
        Me.ITEMCD.HeaderText = "変更商品名"
        Me.ITEMCD.Name = "ITEMCD"
        Me.ITEMCD.Width = 200
        '
        'LOCATIONNM
        '
        Me.LOCATIONNM.DataPropertyName = "LOCATIONNM"
        Me.LOCATIONNM.HeaderText = "ロケーション"
        Me.LOCATIONNM.Name = "LOCATIONNM"
        Me.LOCATIONNM.Width = 90
        '
        'ACTQTY
        '
        Me.ACTQTY.DataPropertyName = "ACTQTY"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ACTQTY.DefaultCellStyle = DataGridViewCellStyle3
        Me.ACTQTY.HeaderText = "実在庫数"
        Me.ACTQTY.Name = "ACTQTY"
        Me.ACTQTY.Width = 80
        '
        'LOCATIONCD
        '
        Me.LOCATIONCD.DataPropertyName = "LOCATIONCD"
        Me.LOCATIONCD.HeaderText = "ロケーションコード"
        Me.LOCATIONCD.Name = "LOCATIONCD"
        Me.LOCATIONCD.Visible = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSearch.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(244, 18)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 30)
        Me.btnSearch.TabIndex = 23
        Me.btnSearch.Text = "検索"
        Me.btnSearch.Type = 2
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Goldenrod
        Me.btnClose.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnClose.Location = New System.Drawing.Point(327, 18)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(70, 30)
        Me.btnClose.TabIndex = 24
        Me.btnClose.Text = "閉じる"
        Me.btnClose.Type = 1
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'cmbLocation
        '
        Me.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLocation.FormattingEnabled = True
        Me.cmbLocation.Location = New System.Drawing.Point(92, 32)
        Me.cmbLocation.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.Size = New System.Drawing.Size(131, 20)
        Me.cmbLocation.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(79, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "※商品を選択するには、該当明細をダブルクリックしてください。"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Location = New System.Drawing.Point(19, 12)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(65, 12)
        Me.lblItemName.TabIndex = 28
        Me.lblItemName.Text = "変更商品名"
        Me.lblItemName.Type = 0
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(19, 36)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(67, 12)
        Me.lblLocation.TabIndex = 29
        Me.lblLocation.Text = "ロケーション"
        Me.lblLocation.Type = 0
        '
        'FrmItemSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(415, 426)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grd)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmItemSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "変更商品名検索"
        Me.Controls.SetChildIndex(Me.pnlCondition, 0)
        Me.Controls.SetChildIndex(Me.grd, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.pnlCondition.ResumeLayout(False)
        Me.pnlCondition.PerformLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtItemCd As TextBox
    Friend WithEvents grd As DataGridViewBase
    Friend WithEvents btnSearch As ButtonBase
    Friend WithEvents btnClose As ButtonBase
    Friend WithEvents cmbLocation As ComboBox
    Friend WithEvents ITEMCD As DataGridViewTextBoxColumn
    Friend WithEvents LOCATIONNM As DataGridViewTextBoxColumn
    Friend WithEvents ACTQTY As DataGridViewTextBoxColumn
    Friend WithEvents LOCATIONCD As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLocation As LabelBase
    Friend WithEvents lblItemName As LabelBase
End Class
