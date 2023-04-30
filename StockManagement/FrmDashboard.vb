Imports System.Data.SqlClient
Imports System.Deployment.Application
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Public Class FrmDashboard

    Public isAuthUser As Boolean = False

#Region "API"

    <DllImport("user32.dll", EntryPoint:="SendMessageW")>
    Private Shared Function SendMessageW(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

#End Region

#Region "EVENT"

    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' create folder
        Util.CreateFolder(Util.GetPgFolderPath())

        ' 未処理受注
        Dim dt As DataTable = getStockReservInfo()
        grdBacklogReserv.DataSource = dt
        grdBacklogReserv.Rows(0).DefaultCellStyle.BackColor = Color.LightYellow
        grdBacklogReserv.Rows(1).DefaultCellStyle.BackColor = Color.PaleVioletRed
        grdBacklogReserv.Rows(2).DefaultCellStyle.BackColor = Color.LightGray
        grdBacklogReserv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grdBacklogReserv.AllowUserToOrderColumns = False

        Dim lastBatchUpdDt As String = getLastBatDt()
        lblServerLastUpdatedTime.Text = lastBatchUpdDt

        grdBacklogReserv.CurrentCell = Nothing
        grdBacklogReserv.ClearSelection()

        If ApplicationDeployment.IsNetworkDeployed Then
            Dim appVersion As Version = ApplicationDeployment.CurrentDeployment.CurrentVersion
            linkVersion.Text = "AppVer:" & appVersion.ToString
        End If

    End Sub

    ''' <summary>
    ''' draggble header panel 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pnlHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseMove
        Const HT_CAPTION As Integer = &H2
        Const WM_NCLBUTTONDOWN As Integer = &HA1

        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessageW(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub


    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.lblTitle.Text = Me.Text
        Me.pnlDashboard.Visible = True

        If Me.ActiveMdiChild IsNot Nothing Then
            Me.ActiveMdiChild.Close()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnCloseMenu.Click
        Me.Close()
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub pnlDashboard_ControlAdded(sender As Object, e As ControlEventArgs) Handles pnlDashboard.ControlAdded
        If TypeOf (e.Control) Is DataGridView Then
            Dim grd As DataGridView = TryCast(e.Control, DataGridView)
            Call New GridStyle().setStyle(grd)
        End If
    End Sub

    Private Sub grdReserv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdBacklogReserv.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = grdBacklogReserv.Rows(e.RowIndex)

            Me.lblTitle.Text = FrmStockReserve.Text
            FrmStockReserve.setSrchCondition(selectedRow.Cells.Item("dateFrom").Value, selectedRow.Cells.Item("dateTo").Value)
            switchForm(FrmStockReserve)
        End If
    End Sub

    Private Sub grdReserv_SelectionChanged(sender As Object, e As EventArgs) Handles grdBacklogReserv.SelectionChanged
        grdBacklogReserv.ClearSelection()
    End Sub

#End Region

#Region "BUTTON EVENT"

    Private Sub btnRanking_Click(sender As Object, e As EventArgs) Handles btnRanking.Click
        Me.lblTitle.Text = FrmRanking.Text
        switchForm(FrmRanking)
    End Sub

    Private Sub btnStockOut_Click(sender As Object, e As EventArgs) Handles btnStockOut.Click

        Me.lblTitle.Text = FrmStockOut.Text
        switchForm(FrmStockOut)
    End Sub

    Private Sub btnStockIn_Click(sender As Object, e As EventArgs) Handles btnStockIn.Click
        Me.lblTitle.Text = FrmStockIn.Text
        switchForm(FrmStockIn)
    End Sub

    Private Sub btnStockHistory_Click(sender As Object, e As EventArgs) Handles btnStockHistory.Click
        Me.lblTitle.Text = FrmStockHistory.Text
        switchForm(FrmStockHistory)
    End Sub

    Private Sub btnStockReserve_Click(sender As Object, e As EventArgs) Handles btnStockReserve.Click
        Me.lblTitle.Text = FrmStockReserve.Text
        switchForm(FrmStockReserve)
    End Sub

    Private Sub btnStockList_Click(sender As Object, e As EventArgs) Handles btnStockList.Click
        Me.lblTitle.Text = FrmStockList.Text
        switchForm(FrmStockList)
    End Sub

    Private Sub btnStockListHistory_Click(sender As Object, e As EventArgs) Handles btnStockListHistory.Click
        Me.lblTitle.Text = FrmStockListHistory.Text
        switchForm(FrmStockListHistory)
    End Sub

    Private Sub linkVersion_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkVersion.LinkClicked
        'System.Diagnostics.Process.Start("http://www.bpoint-nouki.com/public/publish/updHistory.html")
        System.Diagnostics.Process.Start(Path.GetDirectoryName(My.Application.Log.DefaultFileLogWriter.FullLogFileName))
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Using f = FrmLogin
            f.ShowDialog()

            If isAuthUser Then
                btnStockIn.Visible = True
                btnStockOut.Visible = True
                btnLogin.Visible = False
                btnLogout.Visible = True
            End If
        End Using

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        btnStockIn.Visible = False
        btnStockOut.Visible = False
        btnLogin.Visible = True
        btnLogout.Visible = False
        isAuthUser = False
    End Sub

#End Region

#Region "Overrides"

    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_SYSCOMMAND As Integer = &H112
        Const SC_RESTORE As Integer = &HF120
        Const SC_MAXIMIZE As Integer = &HF030

        If m.Msg = WM_SYSCOMMAND Then
            If m.WParam = New IntPtr(SC_RESTORE) Then
                ' do something before restore
                'Me.Refresh()
                'Me.MinimizeBox = False

            ElseIf m.WParam = New IntPtr(SC_MAXIMIZE) Then
                ' do something before maximize
            End If
        End If

        MyBase.WndProc(m)  ' allow form to process this message
    End Sub

#End Region


    Private Sub switchForm(ByVal frm As FrmBase)

        Me.pnlDashboard.Visible = False

        If frm Is Me.ActiveMdiChild Then
            Return
        End If

        If Me.MdiChildren IsNot Nothing Then
            For Each f As Form In Me.MdiChildren
                f.Close()
            Next
        End If

        'If Me.ActiveMdiChild IsNot Nothing Then
        '    Me.ActiveMdiChild.Close()
        'End If

        frm.TopLevel = False
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub


    Private Function getStockReservInfo() As DataTable

        Dim dbParamEnt As DbParamEnt = getReservSqlAndParam(Util.removeTime(Now.AddDays(-14)), Util.removeTime(Now.AddDays(-7)))
        Dim dt As DataTable = DbHandler.executeSelect(dbParamEnt)
        dt.Rows(0).Item("interval") = "1週間前"

        dbParamEnt = getReservSqlAndParam(Util.removeTime(Now.AddDays(-21)), Util.removeTime(Now.AddDays(-14)))
        Dim tempDt As DataTable = DbHandler.executeSelect(dbParamEnt)
        If tempDt.Rows.Count > 0 Then
            Dim r As DataRow = dt.NewRow
            dt.Rows.Add(r)
            r.ItemArray = tempDt.Rows(0).ItemArray
            r.Item("interval") = "2週間前"
        End If
        dbParamEnt = getReservSqlAndParam(Util.removeTime(Now.AddYears(-3)), Util.removeTime(Now.AddDays(-21)))
        tempDt = DbHandler.executeSelect(dbParamEnt)
        If tempDt.Rows.Count > 0 Then
            Dim r As DataRow = dt.NewRow
            dt.Rows.Add(r)
            r.ItemArray = tempDt.Rows(0).ItemArray
            r.Item("interval") = "3週間以前"
        End If

        Return dt
    End Function



#Region "SQL"

    Private Function getLastBatDt() As String
        Dim sb As New StringBuilder

        sb.Append(" SELECT ")
        sb.Append("     M.VALUE1 ")
        sb.Append(" FROM M_Code M ")
        sb.Append(" WHERE ")
        sb.Append("     M.CATEGORY = 'LASTBATDT' ")
        Dim dt As DataTable = DbHandler.executeSelect(New DbParamEnt(sb, Nothing))
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("VALUE1")
        End If

        Return ""
    End Function

    Private Function getReservSqlAndParam(ByRef dateFrom As Date?, dateTo As Date) As DbParamEnt
        Dim sb As New StringBuilder

        sb.Append(" SELECT ")
        sb.Append("     COUNT(*) AS dataCount ")
        If dateFrom IsNot Nothing Then
            sb.Append("     ,@CRTDTFrom AS dateFrom ")
        Else
            sb.Append("     ,null AS dateFrom ")
        End If
        sb.Append("     ,@CRTDTTo AS dateTo ")
        sb.Append("     , '' AS interval")
        sb.Append(" FROM T_StockReserv T1 ")
        'sb.Append(" LEFT JOIN [JPONDATA].[dbo].ORDERDAT AS T2 ")
        'sb.Append(" WITH (INDEX(UIX_ORDERDAT_ID)) ")
        'sb.Append(" ON     T2.ID = T1.ORDERID ")
        'sb.Append(" AND    T2.OrderDate > CONVERT(Date, '2018-1-1') ")

        sb.Append(" WHERE ")
        sb.Append("     T1.DELFLG = 0 ")
        sb.Append(" AND T1.RESERVQTY > 0 ")

        Dim param As New List(Of SqlParameter)
        sb.Append(" AND T1.CRTDT <= @CRTDTTo ")
        param.Add(New SqlParameter("@CRTDTTo", dateTo))
        If dateFrom IsNot Nothing Then
            sb.Append(" AND T1.CRTDT > @CRTDTFrom ")
            param.Add(New SqlParameter("@CRTDTFrom", dateFrom))
        End If
        'sb.Append(" AND T2.[状況] not in ( @ORDSTATUS )")
        'param.Add(New SqlParameter("@ORDSTATUS", "02"))

        Return New DbParamEnt(sb, param.ToArray)
    End Function

#End Region



End Class