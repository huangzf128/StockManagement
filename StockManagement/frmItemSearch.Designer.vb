<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemSearch
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
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.txtItemCd = New System.Windows.Forms.TextBox()
        Me.dgItems = New System.Windows.Forms.DataGridView()
        CType(Me.dgItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(381, 96)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(177, 68)
        Me.cmdSearch.TabIndex = 0
        Me.cmdSearch.Text = "商品検索"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'txtItemCd
        '
        Me.txtItemCd.Location = New System.Drawing.Point(108, 106)
        Me.txtItemCd.Name = "txtItemCd"
        Me.txtItemCd.Size = New System.Drawing.Size(100, 31)
        Me.txtItemCd.TabIndex = 1
        '
        'dgItems
        '
        Me.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItems.Location = New System.Drawing.Point(126, 199)
        Me.dgItems.Name = "dgItems"
        Me.dgItems.RowHeadersWidth = 72
        Me.dgItems.RowTemplate.Height = 33
        Me.dgItems.Size = New System.Drawing.Size(548, 212)
        Me.dgItems.TabIndex = 2
        '
        'frmItemSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgItems)
        Me.Controls.Add(Me.txtItemCd)
        Me.Controls.Add(Me.cmdSearch)
        Me.Name = "frmItemSearch"
        Me.Text = "frmItemSearch"
        CType(Me.dgItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdSearch As Button
    Friend WithEvents txtItemCd As TextBox
    Friend WithEvents dgItems As DataGridView
End Class
