<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockHistory
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
        Me.dateFrom = New System.Windows.Forms.DateTimePicker()
        Me.dateTo = New System.Windows.Forms.DateTimePicker()
        Me.cboHourFrom = New System.Windows.Forms.ComboBox()
        Me.cboMinFrom = New System.Windows.Forms.ComboBox()
        Me.cboHourTo = New System.Windows.Forms.ComboBox()
        Me.cboMinTo = New System.Windows.Forms.ComboBox()
        Me.txtItemCd = New System.Windows.Forms.TextBox()
        Me.chkIn = New System.Windows.Forms.CheckBox()
        Me.cmdView = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.dgStockHistory = New System.Windows.Forms.DataGridView()
        Me.chkOut = New System.Windows.Forms.CheckBox()
        CType(Me.dgStockHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dateFrom
        '
        Me.dateFrom.Location = New System.Drawing.Point(97, 60)
        Me.dateFrom.Name = "dateFrom"
        Me.dateFrom.Size = New System.Drawing.Size(200, 31)
        Me.dateFrom.TabIndex = 0
        '
        'dateTo
        '
        Me.dateTo.Location = New System.Drawing.Point(593, 62)
        Me.dateTo.Name = "dateTo"
        Me.dateTo.Size = New System.Drawing.Size(200, 31)
        Me.dateTo.TabIndex = 1
        '
        'cboHourFrom
        '
        Me.cboHourFrom.FormattingEnabled = True
        Me.cboHourFrom.Location = New System.Drawing.Point(304, 61)
        Me.cboHourFrom.Name = "cboHourFrom"
        Me.cboHourFrom.Size = New System.Drawing.Size(121, 29)
        Me.cboHourFrom.TabIndex = 2
        '
        'cboMinFrom
        '
        Me.cboMinFrom.FormattingEnabled = True
        Me.cboMinFrom.Location = New System.Drawing.Point(445, 62)
        Me.cboMinFrom.Name = "cboMinFrom"
        Me.cboMinFrom.Size = New System.Drawing.Size(121, 29)
        Me.cboMinFrom.TabIndex = 3
        '
        'cboHourTo
        '
        Me.cboHourTo.FormattingEnabled = True
        Me.cboHourTo.Location = New System.Drawing.Point(800, 63)
        Me.cboHourTo.Name = "cboHourTo"
        Me.cboHourTo.Size = New System.Drawing.Size(121, 29)
        Me.cboHourTo.TabIndex = 4
        '
        'cboMinTo
        '
        Me.cboMinTo.FormattingEnabled = True
        Me.cboMinTo.Location = New System.Drawing.Point(927, 63)
        Me.cboMinTo.Name = "cboMinTo"
        Me.cboMinTo.Size = New System.Drawing.Size(121, 29)
        Me.cboMinTo.TabIndex = 5
        '
        'txtItemCd
        '
        Me.txtItemCd.Location = New System.Drawing.Point(97, 139)
        Me.txtItemCd.Name = "txtItemCd"
        Me.txtItemCd.Size = New System.Drawing.Size(100, 31)
        Me.txtItemCd.TabIndex = 6
        '
        'chkIn
        '
        Me.chkIn.AutoSize = True
        Me.chkIn.Location = New System.Drawing.Point(488, 153)
        Me.chkIn.Name = "chkIn"
        Me.chkIn.Size = New System.Drawing.Size(120, 25)
        Me.chkIn.TabIndex = 8
        Me.chkIn.Text = "入庫のみ"
        Me.chkIn.UseVisualStyleBackColor = True
        '
        'cmdView
        '
        Me.cmdView.Location = New System.Drawing.Point(827, 140)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(94, 38)
        Me.cmdView.TabIndex = 9
        Me.cmdView.Text = "検索"
        Me.cmdView.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(953, 140)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(95, 38)
        Me.cmdClose.TabIndex = 10
        Me.cmdClose.Text = "閉じる"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'dgStockHistory
        '
        Me.dgStockHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStockHistory.Location = New System.Drawing.Point(97, 273)
        Me.dgStockHistory.Name = "dgStockHistory"
        Me.dgStockHistory.RowHeadersWidth = 72
        Me.dgStockHistory.RowTemplate.Height = 33
        Me.dgStockHistory.Size = New System.Drawing.Size(240, 150)
        Me.dgStockHistory.TabIndex = 11
        '
        'chkOut
        '
        Me.chkOut.AutoSize = True
        Me.chkOut.Location = New System.Drawing.Point(634, 152)
        Me.chkOut.Name = "chkOut"
        Me.chkOut.Size = New System.Drawing.Size(120, 25)
        Me.chkOut.TabIndex = 12
        Me.chkOut.Text = "出庫のみ"
        Me.chkOut.UseVisualStyleBackColor = True
        '
        'frmStockHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 719)
        Me.Controls.Add(Me.chkOut)
        Me.Controls.Add(Me.dgStockHistory)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdView)
        Me.Controls.Add(Me.chkIn)
        Me.Controls.Add(Me.txtItemCd)
        Me.Controls.Add(Me.cboMinTo)
        Me.Controls.Add(Me.cboHourTo)
        Me.Controls.Add(Me.cboMinFrom)
        Me.Controls.Add(Me.cboHourFrom)
        Me.Controls.Add(Me.dateTo)
        Me.Controls.Add(Me.dateFrom)
        Me.Name = "frmStockHistory"
        Me.Text = "frmStockHistory"
        CType(Me.dgStockHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dateFrom As DateTimePicker
    Friend WithEvents dateTo As DateTimePicker
    Friend WithEvents cboHourFrom As ComboBox
    Friend WithEvents cboMinFrom As ComboBox
    Friend WithEvents cboHourTo As ComboBox
    Friend WithEvents cboMinTo As ComboBox
    Friend WithEvents txtItemCd As TextBox
    Friend WithEvents chkIn As CheckBox
    Friend WithEvents cmdView As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents dgStockHistory As DataGridView
    Friend WithEvents chkOut As CheckBox
End Class
