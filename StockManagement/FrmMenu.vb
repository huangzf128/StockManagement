Public Class FrmMenu
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnStockHistory_Click(sender As Object, e As EventArgs) Handles btnStockHistory.Click
        frmStockHistory.ShowDialog()
    End Sub

End Class
