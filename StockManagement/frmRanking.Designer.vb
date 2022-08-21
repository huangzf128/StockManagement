<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRanking
    Inherits System.Windows.Forms.Form

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
        Me.dateFrom1 = New System.Windows.Forms.DateTimePicker()
        Me.dateTo1 = New System.Windows.Forms.DateTimePicker()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.txtItemCd = New System.Windows.Forms.TextBox()
        Me.tabRanking = New System.Windows.Forms.TabControl()
        Me.tabShop = New System.Windows.Forms.TabPage()
        Me.cmdClose1 = New System.Windows.Forms.Button()
        Me.cmdExec1 = New System.Windows.Forms.Button()
        Me.tabItem = New System.Windows.Forms.TabPage()
        Me.cboShop = New System.Windows.Forms.ComboBox()
        Me.cmdClose2 = New System.Windows.Forms.Button()
        Me.cmdExec2 = New System.Windows.Forms.Button()
        Me.dateFrom2 = New System.Windows.Forms.DateTimePicker()
        Me.dateTo2 = New System.Windows.Forms.DateTimePicker()
        Me.dgOrderShopRanking = New System.Windows.Forms.DataGridView()
        Me.dgOrderRanking = New System.Windows.Forms.DataGridView()
        Me.tabRanking.SuspendLayout()
        Me.tabShop.SuspendLayout()
        Me.tabItem.SuspendLayout()
        CType(Me.dgOrderShopRanking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgOrderRanking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dateFrom1
        '
        Me.dateFrom1.Location = New System.Drawing.Point(26, 24)
        Me.dateFrom1.Name = "dateFrom1"
        Me.dateFrom1.Size = New System.Drawing.Size(200, 31)
        Me.dateFrom1.TabIndex = 0
        '
        'dateTo1
        '
        Me.dateTo1.Location = New System.Drawing.Point(288, 24)
        Me.dateTo1.Name = "dateTo1"
        Me.dateTo1.Size = New System.Drawing.Size(200, 31)
        Me.dateTo1.TabIndex = 1
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(307, 110)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(168, 49)
        Me.cmdSearch.TabIndex = 2
        Me.cmdSearch.Text = "商品検索"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'txtItemCd
        '
        Me.txtItemCd.Location = New System.Drawing.Point(37, 98)
        Me.txtItemCd.Name = "txtItemCd"
        Me.txtItemCd.Size = New System.Drawing.Size(50, 31)
        Me.txtItemCd.TabIndex = 3
        '
        'tabRanking
        '
        Me.tabRanking.Controls.Add(Me.tabShop)
        Me.tabRanking.Controls.Add(Me.tabItem)
        Me.tabRanking.Location = New System.Drawing.Point(38, 64)
        Me.tabRanking.Name = "tabRanking"
        Me.tabRanking.SelectedIndex = 0
        Me.tabRanking.Size = New System.Drawing.Size(1223, 688)
        Me.tabRanking.TabIndex = 4
        '
        'tabShop
        '
        Me.tabShop.Controls.Add(Me.dgOrderShopRanking)
        Me.tabShop.Controls.Add(Me.cmdClose1)
        Me.tabShop.Controls.Add(Me.cmdExec1)
        Me.tabShop.Controls.Add(Me.dateFrom1)
        Me.tabShop.Controls.Add(Me.cmdSearch)
        Me.tabShop.Controls.Add(Me.txtItemCd)
        Me.tabShop.Controls.Add(Me.dateTo1)
        Me.tabShop.Location = New System.Drawing.Point(4, 31)
        Me.tabShop.Name = "tabShop"
        Me.tabShop.Padding = New System.Windows.Forms.Padding(3)
        Me.tabShop.Size = New System.Drawing.Size(1215, 653)
        Me.tabShop.TabIndex = 0
        Me.tabShop.Text = "期間-商品-店舗毎"
        Me.tabShop.UseVisualStyleBackColor = True
        '
        'cmdClose1
        '
        Me.cmdClose1.Location = New System.Drawing.Point(792, 110)
        Me.cmdClose1.Name = "cmdClose1"
        Me.cmdClose1.Size = New System.Drawing.Size(113, 49)
        Me.cmdClose1.TabIndex = 5
        Me.cmdClose1.Text = "閉じる"
        Me.cmdClose1.UseVisualStyleBackColor = True
        '
        'cmdExec1
        '
        Me.cmdExec1.Location = New System.Drawing.Point(606, 110)
        Me.cmdExec1.Name = "cmdExec1"
        Me.cmdExec1.Size = New System.Drawing.Size(140, 49)
        Me.cmdExec1.TabIndex = 4
        Me.cmdExec1.Text = "検索"
        Me.cmdExec1.UseVisualStyleBackColor = True
        '
        'tabItem
        '
        Me.tabItem.Controls.Add(Me.dgOrderRanking)
        Me.tabItem.Controls.Add(Me.cboShop)
        Me.tabItem.Controls.Add(Me.cmdClose2)
        Me.tabItem.Controls.Add(Me.cmdExec2)
        Me.tabItem.Controls.Add(Me.dateFrom2)
        Me.tabItem.Controls.Add(Me.dateTo2)
        Me.tabItem.Location = New System.Drawing.Point(4, 31)
        Me.tabItem.Name = "tabItem"
        Me.tabItem.Padding = New System.Windows.Forms.Padding(3)
        Me.tabItem.Size = New System.Drawing.Size(1215, 653)
        Me.tabItem.TabIndex = 1
        Me.tabItem.Text = "期間-店舗毎"
        Me.tabItem.UseVisualStyleBackColor = True
        '
        'cboShop
        '
        Me.cboShop.FormattingEnabled = True
        Me.cboShop.Location = New System.Drawing.Point(168, 234)
        Me.cboShop.Name = "cboShop"
        Me.cboShop.Size = New System.Drawing.Size(121, 29)
        Me.cboShop.TabIndex = 10
        '
        'cmdClose2
        '
        Me.cmdClose2.Location = New System.Drawing.Point(934, 234)
        Me.cmdClose2.Name = "cmdClose2"
        Me.cmdClose2.Size = New System.Drawing.Size(113, 49)
        Me.cmdClose2.TabIndex = 9
        Me.cmdClose2.Text = "閉じる"
        Me.cmdClose2.UseVisualStyleBackColor = True
        '
        'cmdExec2
        '
        Me.cmdExec2.Location = New System.Drawing.Point(748, 234)
        Me.cmdExec2.Name = "cmdExec2"
        Me.cmdExec2.Size = New System.Drawing.Size(140, 49)
        Me.cmdExec2.TabIndex = 8
        Me.cmdExec2.Text = "検索"
        Me.cmdExec2.UseVisualStyleBackColor = True
        '
        'dateFrom2
        '
        Me.dateFrom2.Location = New System.Drawing.Point(168, 148)
        Me.dateFrom2.Name = "dateFrom2"
        Me.dateFrom2.Size = New System.Drawing.Size(200, 31)
        Me.dateFrom2.TabIndex = 6
        '
        'dateTo2
        '
        Me.dateTo2.Location = New System.Drawing.Point(430, 148)
        Me.dateTo2.Name = "dateTo2"
        Me.dateTo2.Size = New System.Drawing.Size(200, 31)
        Me.dateTo2.TabIndex = 7
        '
        'dgOrderShopRanking
        '
        Me.dgOrderShopRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOrderShopRanking.Location = New System.Drawing.Point(129, 253)
        Me.dgOrderShopRanking.Name = "dgOrderShopRanking"
        Me.dgOrderShopRanking.RowHeadersWidth = 72
        Me.dgOrderShopRanking.RowTemplate.Height = 33
        Me.dgOrderShopRanking.Size = New System.Drawing.Size(240, 150)
        Me.dgOrderShopRanking.TabIndex = 6
        '
        'dgOrderRanking
        '
        Me.dgOrderRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOrderRanking.Location = New System.Drawing.Point(226, 374)
        Me.dgOrderRanking.Name = "dgOrderRanking"
        Me.dgOrderRanking.RowHeadersWidth = 72
        Me.dgOrderRanking.RowTemplate.Height = 33
        Me.dgOrderRanking.Size = New System.Drawing.Size(240, 150)
        Me.dgOrderRanking.TabIndex = 11
        '
        'frmRanking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1407, 815)
        Me.Controls.Add(Me.tabRanking)
        Me.Name = "frmRanking"
        Me.Text = "frmRanking"
        Me.tabRanking.ResumeLayout(False)
        Me.tabShop.ResumeLayout(False)
        Me.tabShop.PerformLayout()
        Me.tabItem.ResumeLayout(False)
        CType(Me.dgOrderShopRanking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgOrderRanking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dateFrom1 As DateTimePicker
    Friend WithEvents cmdSearch As Button
    Friend WithEvents txtItemCd As TextBox
    Friend WithEvents tabRanking As TabControl
    Friend WithEvents tabShop As TabPage
    Friend WithEvents tabItem As TabPage
    Friend WithEvents dateTo1 As DateTimePicker
    Friend WithEvents cmdClose1 As Button
    Friend WithEvents cmdExec1 As Button
    Friend WithEvents cmdClose2 As Button
    Friend WithEvents cmdExec2 As Button
    Friend WithEvents dateFrom2 As DateTimePicker
    Friend WithEvents dateTo2 As DateTimePicker
    Friend WithEvents cboShop As ComboBox
    Friend WithEvents dgOrderShopRanking As DataGridView
    Friend WithEvents dgOrderRanking As DataGridView
End Class
