<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStockOut
    Inherits System.Windows.Forms.Form

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
        Me.txtItemCd = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtActQty = New System.Windows.Forms.TextBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cboLocation = New System.Windows.Forms.ComboBox()
        Me.cmdAll = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdExec = New System.Windows.Forms.Button()
        Me.dgStockOut = New System.Windows.Forms.DataGridView()
        CType(Me.dgStockOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtItemCd
        '
        Me.txtItemCd.Location = New System.Drawing.Point(94, 56)
        Me.txtItemCd.Name = "txtItemCd"
        Me.txtItemCd.Size = New System.Drawing.Size(100, 31)
        Me.txtItemCd.TabIndex = 0
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(94, 120)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(100, 31)
        Me.txtQty.TabIndex = 1
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(94, 194)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(362, 31)
        Me.txtRemarks.TabIndex = 2
        '
        'txtActQty
        '
        Me.txtActQty.Location = New System.Drawing.Point(259, 120)
        Me.txtActQty.Name = "txtActQty"
        Me.txtActQty.Size = New System.Drawing.Size(100, 31)
        Me.txtActQty.TabIndex = 3
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(259, 56)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(125, 39)
        Me.cmdSearch.TabIndex = 4
        Me.cmdSearch.Text = "商品検索"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(523, 184)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(122, 57)
        Me.cmdAdd.TabIndex = 5
        Me.cmdAdd.Text = "追加"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(706, 184)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(115, 57)
        Me.cmdClose.TabIndex = 6
        Me.cmdClose.Text = "閉じる"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cboLocation
        '
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.Location = New System.Drawing.Point(507, 105)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(121, 29)
        Me.cboLocation.TabIndex = 7
        '
        'cmdAll
        '
        Me.cmdAll.Location = New System.Drawing.Point(94, 474)
        Me.cmdAll.Name = "cmdAll"
        Me.cmdAll.Size = New System.Drawing.Size(158, 60)
        Me.cmdAll.TabIndex = 9
        Me.cmdAll.Text = "一括メンテナンス"
        Me.cmdAll.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(491, 474)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(137, 60)
        Me.cmdDelete.TabIndex = 10
        Me.cmdDelete.Text = "対象削除"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdExec
        '
        Me.cmdExec.Location = New System.Drawing.Point(695, 474)
        Me.cmdExec.Name = "cmdExec"
        Me.cmdExec.Size = New System.Drawing.Size(146, 60)
        Me.cmdExec.TabIndex = 11
        Me.cmdExec.Text = "出庫処理"
        Me.cmdExec.UseVisualStyleBackColor = True
        '
        'dgStockOut
        '
        Me.dgStockOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStockOut.Location = New System.Drawing.Point(272, 281)
        Me.dgStockOut.Name = "dgStockOut"
        Me.dgStockOut.RowHeadersWidth = 72
        Me.dgStockOut.RowTemplate.Height = 33
        Me.dgStockOut.Size = New System.Drawing.Size(240, 150)
        Me.dgStockOut.TabIndex = 12
        '
        'frmStockOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 567)
        Me.Controls.Add(Me.dgStockOut)
        Me.Controls.Add(Me.cmdExec)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdAll)
        Me.Controls.Add(Me.cboLocation)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.txtActQty)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtItemCd)
        Me.Name = "frmStockOut"
        Me.Text = "frmStockOut"
        CType(Me.dgStockOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtItemCd As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtActQty As TextBox
    Friend WithEvents cmdSearch As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents cboLocation As ComboBox
    Friend WithEvents cmdAll As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdExec As Button
    Friend WithEvents ITEMCDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LOCATIONCDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QTYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REMARKSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TARGETFLGDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents dgStockOut As DataGridView
End Class
