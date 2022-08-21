<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockReserv
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
        Me.cboOrdStatus = New System.Windows.Forms.ComboBox()
        Me.chkValid = New System.Windows.Forms.CheckBox()
        Me.cmdView = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.dgStockReserv = New System.Windows.Forms.DataGridView()
        CType(Me.dgStockReserv, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'cboOrdStatus
        '
        Me.cboOrdStatus.FormattingEnabled = True
        Me.cboOrdStatus.Location = New System.Drawing.Point(363, 139)
        Me.cboOrdStatus.Name = "cboOrdStatus"
        Me.cboOrdStatus.Size = New System.Drawing.Size(121, 29)
        Me.cboOrdStatus.TabIndex = 7
        '
        'chkValid
        '
        Me.chkValid.AutoSize = True
        Me.chkValid.Location = New System.Drawing.Point(569, 139)
        Me.chkValid.Name = "chkValid"
        Me.chkValid.Size = New System.Drawing.Size(141, 25)
        Me.chkValid.TabIndex = 8
        Me.chkValid.Text = "引当中のみ"
        Me.chkValid.UseVisualStyleBackColor = True
        '
        'cmdView
        '
        Me.cmdView.Location = New System.Drawing.Point(753, 140)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(94, 38)
        Me.cmdView.TabIndex = 9
        Me.cmdView.Text = "検索"
        Me.cmdView.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(883, 140)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(95, 38)
        Me.cmdClose.TabIndex = 10
        Me.cmdClose.Text = "閉じる"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'dgStockReserv
        '
        Me.dgStockReserv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStockReserv.Location = New System.Drawing.Point(97, 273)
        Me.dgStockReserv.Name = "dgStockReserv"
        Me.dgStockReserv.RowHeadersWidth = 72
        Me.dgStockReserv.RowTemplate.Height = 33
        Me.dgStockReserv.Size = New System.Drawing.Size(240, 150)
        Me.dgStockReserv.TabIndex = 11
        '
        'frmStockReserv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 719)
        Me.Controls.Add(Me.dgStockReserv)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdView)
        Me.Controls.Add(Me.chkValid)
        Me.Controls.Add(Me.cboOrdStatus)
        Me.Controls.Add(Me.txtItemCd)
        Me.Controls.Add(Me.cboMinTo)
        Me.Controls.Add(Me.cboHourTo)
        Me.Controls.Add(Me.cboMinFrom)
        Me.Controls.Add(Me.cboHourFrom)
        Me.Controls.Add(Me.dateTo)
        Me.Controls.Add(Me.dateFrom)
        Me.Name = "frmStockReserv"
        Me.Text = "frmStockReserv"
        CType(Me.dgStockReserv, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cboOrdStatus As ComboBox
    Friend WithEvents chkValid As CheckBox
    Friend WithEvents cmdView As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents dgStockReserv As DataGridView
End Class
