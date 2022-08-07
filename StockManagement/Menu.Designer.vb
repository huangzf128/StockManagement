<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tabPnl = New System.Windows.Forms.TableLayoutPanel()
        Me.btnStockIn = New System.Windows.Forms.Button()
        Me.btnStockHistory = New System.Windows.Forms.Button()
        Me.btnStockOut = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.lblTitleLeft = New System.Windows.Forms.Label()
        Me.lblTitleRight = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabPnl.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(360, 41)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "承天　在庫管理システム"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabPnl
        '
        Me.tabPnl.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabPnl.AutoSize = True
        Me.tabPnl.BackColor = System.Drawing.Color.Transparent
        Me.tabPnl.ColumnCount = 2
        Me.tabPnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tabPnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tabPnl.Controls.Add(Me.btnStockIn, 0, 1)
        Me.tabPnl.Controls.Add(Me.btnStockHistory, 1, 1)
        Me.tabPnl.Controls.Add(Me.btnStockOut, 0, 2)
        Me.tabPnl.Controls.Add(Me.Button4, 1, 2)
        Me.tabPnl.Controls.Add(Me.Button5, 0, 3)
        Me.tabPnl.Controls.Add(Me.Button6, 1, 3)
        Me.tabPnl.Controls.Add(Me.lblTitleLeft, 0, 0)
        Me.tabPnl.Controls.Add(Me.lblTitleRight, 1, 0)
        Me.tabPnl.Controls.Add(Me.Button7, 0, 4)
        Me.tabPnl.Controls.Add(Me.Button8, 1, 4)
        Me.tabPnl.Controls.Add(Me.Button9, 0, 5)
        Me.tabPnl.Location = New System.Drawing.Point(49, 101)
        Me.tabPnl.Name = "tabPnl"
        Me.tabPnl.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.tabPnl.RowCount = 6
        Me.tabPnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabPnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tabPnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tabPnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tabPnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tabPnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tabPnl.Size = New System.Drawing.Size(252, 238)
        Me.tabPnl.TabIndex = 1
        '
        'btnStockIn
        '
        Me.btnStockIn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStockIn.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStockIn.Location = New System.Drawing.Point(3, 30)
        Me.btnStockIn.Name = "btnStockIn"
        Me.btnStockIn.Size = New System.Drawing.Size(120, 35)
        Me.btnStockIn.TabIndex = 0
        Me.btnStockIn.Text = "入　庫"
        Me.btnStockIn.UseVisualStyleBackColor = True
        '
        'btnStockHistory
        '
        Me.btnStockHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStockHistory.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStockHistory.Location = New System.Drawing.Point(129, 30)
        Me.btnStockHistory.Name = "btnStockHistory"
        Me.btnStockHistory.Size = New System.Drawing.Size(120, 35)
        Me.btnStockHistory.TabIndex = 1
        Me.btnStockHistory.Text = "入出庫履歴"
        Me.btnStockHistory.UseVisualStyleBackColor = True
        '
        'btnStockOut
        '
        Me.btnStockOut.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStockOut.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStockOut.Location = New System.Drawing.Point(3, 71)
        Me.btnStockOut.Name = "btnStockOut"
        Me.btnStockOut.Size = New System.Drawing.Size(120, 35)
        Me.btnStockOut.TabIndex = 2
        Me.btnStockOut.Text = "出　庫"
        Me.btnStockOut.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button4.Location = New System.Drawing.Point(129, 71)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(120, 35)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button5.Location = New System.Drawing.Point(3, 112)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(120, 35)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button6.Location = New System.Drawing.Point(129, 112)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(120, 35)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'lblTitleLeft
        '
        Me.lblTitleLeft.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitleLeft.AutoSize = True
        Me.lblTitleLeft.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTitleLeft.ForeColor = System.Drawing.Color.White
        Me.lblTitleLeft.Location = New System.Drawing.Point(3, 5)
        Me.lblTitleLeft.Name = "lblTitleLeft"
        Me.lblTitleLeft.Size = New System.Drawing.Size(120, 22)
        Me.lblTitleLeft.TabIndex = 6
        Me.lblTitleLeft.Text = "入　力"
        Me.lblTitleLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitleRight
        '
        Me.lblTitleRight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitleRight.AutoSize = True
        Me.lblTitleRight.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTitleRight.ForeColor = System.Drawing.Color.White
        Me.lblTitleRight.Location = New System.Drawing.Point(129, 5)
        Me.lblTitleRight.Name = "lblTitleRight"
        Me.lblTitleRight.Size = New System.Drawing.Size(120, 22)
        Me.lblTitleRight.TabIndex = 7
        Me.lblTitleRight.Text = "出　力"
        Me.lblTitleRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button7
        '
        Me.Button7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button7.Location = New System.Drawing.Point(3, 153)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(120, 35)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button8.Location = New System.Drawing.Point(129, 153)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(120, 35)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button9.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button9.Location = New System.Drawing.Point(3, 194)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(120, 36)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "Button9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.Transparent
        Me.pnlFooter.Controls.Add(Me.btnClose)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 398)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(360, 52)
        Me.pnlFooter.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Goldenrod
        Me.btnClose.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnClose.Location = New System.Drawing.Point(260, 13)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 27)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "終了"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(28, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "サーバー最終自動処理日時："
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StockManagement.My.Resources.Resources.Dark_Ocean
        Me.ClientSize = New System.Drawing.Size(360, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.tabPnl)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "メニュー"
        Me.tabPnl.ResumeLayout(False)
        Me.tabPnl.PerformLayout()
        Me.pnlFooter.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents tabPnl As TableLayoutPanel
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents btnStockIn As Button
    Friend WithEvents btnStockHistory As Button
    Friend WithEvents btnStockOut As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents lblTitleLeft As Label
    Friend WithEvents lblTitleRight As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClose As Button
End Class
