Public Class GridStyle
    Implements Style

    Public Sub setStyle(control As Control) Implements Style.setStyle

        Dim grd As DataGridView = TryCast(control, DataGridView)
        grd.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

        With grd.ColumnHeadersDefaultCellStyle
            .BackColor = SystemColors.Highlight
            .ForeColor = SystemColors.Window
            .SelectionBackColor = SystemColors.Highlight
            .SelectionForeColor = SystemColors.HighlightText
            .WrapMode = DataGridViewTriState.True
            .Alignment = DataGridViewContentAlignment.TopCenter
            .Padding = New Padding(0, 4, 0, 4)
            .Font = New Font("MS PGothic", 9)
        End With

        With grd.RowTemplate
            '.ReadOnly = False
            .DefaultCellStyle.Padding = New Padding(3, 0, 3, 0)
            .Height = 22
        End With

        With grd.DefaultCellStyle
            .SelectionBackColor = Color.FromArgb(218, 242, 222)
            .SelectionForeColor = Color.Black
        End With

        grd.AutoGenerateColumns = False
        grd.AllowUserToResizeRows = False
        grd.EnableHeadersVisualStyles = False
        grd.RowHeadersVisible = False
        ' ヘッダの高さ変更禁止
        grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize

        grd.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        'grd.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None
        'grd.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None
        grd.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        grd.AllowUserToAddRows = False
    End Sub
End Class
