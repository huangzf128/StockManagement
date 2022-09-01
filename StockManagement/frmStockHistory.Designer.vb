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
        Me.dateFrom = New System.Windows.Forms.DateTimePicker()
        Me.dateTo = New System.Windows.Forms.DateTimePicker()
        Me.cboHourFrom = New System.Windows.Forms.ComboBox()
        Me.cboMinFrom = New System.Windows.Forms.ComboBox()
        Me.cboHourTo = New System.Windows.Forms.ComboBox()
        Me.cboMinTo = New System.Windows.Forms.ComboBox()
        Me.txtItemCd = New System.Windows.Forms.TextBox()
        Me.dgStockHistory = New System.Windows.Forms.DataGridView()
        Me.btnClose = New StockManagement.ButtonBase()
        Me.btnSearch = New StockManagement.ButtonBase()
        Me.chkIn = New StockManagement.CheckBoxBase()
        Me.chkOut = New StockManagement.CheckBoxBase()
        Me.pnlCondition.SuspendLayout()
        CType(Me.dgStockHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCondition
        '
        Me.pnlCondition.Controls.Add(Me.chkOut)
        Me.pnlCondition.Controls.Add(Me.chkIn)
        Me.pnlCondition.Controls.Add(Me.btnSearch)
        Me.pnlCondition.Controls.Add(Me.cboHourTo)
        Me.pnlCondition.Controls.Add(Me.cboMinTo)
        Me.pnlCondition.Controls.Add(Me.btnClose)
        Me.pnlCondition.Controls.Add(Me.txtItemCd)
        Me.pnlCondition.Size = New System.Drawing.Size(944, 100)
        '
        'dateFrom
        '
        Me.dateFrom.Location = New System.Drawing.Point(53, 34)
        Me.dateFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.dateFrom.Name = "dateFrom"
        Me.dateFrom.Size = New System.Drawing.Size(111, 19)
        Me.dateFrom.TabIndex = 0
        '
        'dateTo
        '
        Me.dateTo.Location = New System.Drawing.Point(323, 35)
        Me.dateTo.Margin = New System.Windows.Forms.Padding(2)
        Me.dateTo.Name = "dateTo"
        Me.dateTo.Size = New System.Drawing.Size(111, 19)
        Me.dateTo.TabIndex = 1
        '
        'cboHourFrom
        '
        Me.cboHourFrom.FormattingEnabled = True
        Me.cboHourFrom.Location = New System.Drawing.Point(166, 35)
        Me.cboHourFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.cboHourFrom.Name = "cboHourFrom"
        Me.cboHourFrom.Size = New System.Drawing.Size(68, 20)
        Me.cboHourFrom.TabIndex = 2
        '
        'cboMinFrom
        '
        Me.cboMinFrom.FormattingEnabled = True
        Me.cboMinFrom.Location = New System.Drawing.Point(243, 35)
        Me.cboMinFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.cboMinFrom.Name = "cboMinFrom"
        Me.cboMinFrom.Size = New System.Drawing.Size(68, 20)
        Me.cboMinFrom.TabIndex = 3
        '
        'cboHourTo
        '
        Me.cboHourTo.FormattingEnabled = True
        Me.cboHourTo.Location = New System.Drawing.Point(485, 36)
        Me.cboHourTo.Margin = New System.Windows.Forms.Padding(2)
        Me.cboHourTo.Name = "cboHourTo"
        Me.cboHourTo.Size = New System.Drawing.Size(68, 20)
        Me.cboHourTo.TabIndex = 4
        '
        'cboMinTo
        '
        Me.cboMinTo.FormattingEnabled = True
        Me.cboMinTo.Location = New System.Drawing.Point(574, 36)
        Me.cboMinTo.Margin = New System.Windows.Forms.Padding(2)
        Me.cboMinTo.Name = "cboMinTo"
        Me.cboMinTo.Size = New System.Drawing.Size(68, 20)
        Me.cboMinTo.TabIndex = 5
        '
        'txtItemCd
        '
        Me.txtItemCd.Location = New System.Drawing.Point(53, 67)
        Me.txtItemCd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemCd.Name = "txtItemCd"
        Me.txtItemCd.Size = New System.Drawing.Size(56, 19)
        Me.txtItemCd.TabIndex = 6
        '
        'dgStockHistory
        '
        Me.dgStockHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStockHistory.Location = New System.Drawing.Point(53, 156)
        Me.dgStockHistory.Margin = New System.Windows.Forms.Padding(2)
        Me.dgStockHistory.Name = "dgStockHistory"
        Me.dgStockHistory.RowHeadersWidth = 72
        Me.dgStockHistory.RowTemplate.Height = 33
        Me.dgStockHistory.Size = New System.Drawing.Size(131, 86)
        Me.dgStockHistory.TabIndex = 11
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnClose.Location = New System.Drawing.Point(847, 59)
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
        Me.btnSearch.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(760, 59)
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
        Me.chkIn.ForeColor = System.Drawing.Color.Red
        Me.chkIn.Location = New System.Drawing.Point(172, 69)
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
        Me.chkOut.ForeColor = System.Drawing.Color.Red
        Me.chkOut.Location = New System.Drawing.Point(250, 69)
        Me.chkOut.Name = "chkOut"
        Me.chkOut.Size = New System.Drawing.Size(72, 16)
        Me.chkOut.TabIndex = 15
        Me.chkOut.Text = "出庫のみ"
        Me.chkOut.Type = 0
        Me.chkOut.UseVisualStyleBackColor = True
        '
        'FrmStockHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 729)
        Me.Controls.Add(Me.dgStockHistory)
        Me.Controls.Add(Me.cboMinFrom)
        Me.Controls.Add(Me.cboHourFrom)
        Me.Controls.Add(Me.dateTo)
        Me.Controls.Add(Me.dateFrom)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmStockHistory"
        Me.Text = "frmStockHistory"
        Me.Controls.SetChildIndex(Me.pnlCondition, 0)
        Me.Controls.SetChildIndex(Me.dateFrom, 0)
        Me.Controls.SetChildIndex(Me.dateTo, 0)
        Me.Controls.SetChildIndex(Me.cboHourFrom, 0)
        Me.Controls.SetChildIndex(Me.cboMinFrom, 0)
        Me.Controls.SetChildIndex(Me.dgStockHistory, 0)
        Me.pnlCondition.ResumeLayout(False)
        Me.pnlCondition.PerformLayout()
        CType(Me.dgStockHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dateFrom As DateTimePicker
    Friend WithEvents dateTo As DateTimePicker
    Friend WithEvents cboHourFrom As ComboBox
    Friend WithEvents cboMinFrom As ComboBox
    Friend WithEvents cboHourTo As ComboBox
    Friend WithEvents cboMinTo As ComboBox
    Friend WithEvents txtItemCd As TextBox
    Friend WithEvents dgStockHistory As DataGridView
    Friend WithEvents btnClose As ButtonBase
    Friend WithEvents btnSearch As ButtonBase
    Friend WithEvents chkIn As CheckBoxBase
    Friend WithEvents chkOut As CheckBoxBase
End Class
