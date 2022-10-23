Public Class FrmMenu
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnStockHistory_Click(sender As Object, e As EventArgs) Handles btnStockHistory.Click

        FrmDashboard.pnlDashboard.Visible = False

        FrmStockHistory.TopLevel = False
        FrmStockHistory.MdiParent = Me.Parent
        FrmStockHistory.Dock = DockStyle.Fill
        FrmStockHistory.Show()

    End Sub

    Private Sub btnStockIn_Click(sender As Object, e As EventArgs) Handles btnStockIn.Click

    End Sub

    Private Sub btnStockReserve_Click(sender As Object, e As EventArgs) Handles btnStockReserve.Click
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        FrmDashboard.pnlDashboard.Visible = True
    End Sub
End Class
