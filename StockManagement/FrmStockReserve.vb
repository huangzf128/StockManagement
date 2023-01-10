Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text
Imports System.Threading

Public Class FrmStockReserve

#Region "変数"
    Structure SearchCondition
        Public crdDtFrom As String
        Public crdDtTo As String
        Public itemCd As String
        Public chkReserving As Boolean
        Public chkExclude As Boolean
        Public ordStatus As String
    End Structure

    Private _srchCondition As New SearchCondition

    Public needInit As Boolean = True
#End Region

#Region "EVENT"
    Private Sub FrmStockReserve_Load(sender As Object, e As EventArgs) Handles Me.Load

        grd.CellBorderStyle = DataGridViewCellBorderStyle.Single

        If needInit Then
            dtPickerFrom.setDateTime(Now.AddMonths(-1 * Consts.DATA_INTERVAL))
            dtPickerTo.setDateTime(Now)
        End If
        chkExclude.Checked = True
        getOrdStatus()

        getSearchCondition()
        UBindingNavigator1.initBindingSource(getTotalCount(), Consts.PAGE_COUNT)
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        If grd.Rows.Count = 0 Then
            Return
        End If
        Util.CopyDataGridView(grd)
        AutoClosingMessageBox.Show("すべての明細をコピーしました。", "情報")
    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        getSearchCondition()
        UBindingNavigator1.initBindingSource(getTotalCount(), Consts.PAGE_COUNT)
    End Sub

    Private Sub UBindingNavigator1_CurrentChanged(sender As Object, e As EventArgs) Handles UBindingNavigator1.CurrentChanged
        ShowWaitForm()

        Async.Process(
            Function()
                Dim dt As DataTable = getSqlWithOffset(TryCast(sender, BindingSource).Current)
                If Not grd.IsHandleCreated Then
                    Return Nothing
                End If
                grd.Invoke(New SetDataSourceDelegate(AddressOf SetDataSource), grd, dt)
            End Function,
            Sub()
                CloseForm()
            End Sub)
    End Sub

#End Region

    Public Sub setSrchCondition(dtFrom As Date?, dtTo As Date)
        Me.dtPickerFrom.setDateTime(dtFrom)
        Me.dtPickerTo.setDateTime(dtTo)
        Me.chkReserving.Checked = True
        needInit = False
    End Sub

    Private Function getTotalCount() As Integer

        Dim dbParamEnt As DbParamEnt = getSqlAndParam(True)
        Dim dt As DataTable = DbHandler.executeSelect(dbParamEnt)
        If dt.Rows.Count = 0 Then
            Return 0
        End If
        Return dt.Rows(0).Item("CNT")
    End Function

    Private Function getSqlWithOffset(ByVal offset As Integer) As DataTable

        Dim dbParamEnt As DbParamEnt = getSqlAndParam(False)

        dbParamEnt.sbSql.Append(" ORDER BY T1.CRTDT DESC ")
        dbParamEnt.sbSql.Append(" OFFSET " & offset & " ROWS ")
        dbParamEnt.sbSql.Append(" FETCH Next " & Consts.PAGE_COUNT & " ROWS ONLY ")

        Dim dt As DataTable = DbHandler.executeSelect(dbParamEnt)
        Return dt
    End Function

    Private Function getSqlAndParam(ByVal isGetTotalCount As Boolean) As DbParamEnt
        Dim sb As New StringBuilder

        sb.Append(" SELECT ")
        If isGetTotalCount Then
            sb.Append(" count(*) AS CNT ")
        Else
            sb.Append("     T1.* ")
            sb.Append("    ,M1.VALUE1 As DELFLGNM ")
            sb.Append("    ,M2.VALUE1 AS ORDERSTATUSNM ")
            sb.Append("    ,T2.[状況] As ORDSTATUS ")
            sb.Append("    ,T2.[発送日] As ORDDLVDT ")
        End If
        sb.Append(" FROM T_StockReserv T1 ")
        If Not isGetTotalCount Then
            sb.Append(" LEFT JOIN M_Code AS M1 ")
            sb.Append(" ON     CASE M1.CODE WHEN '0' THEN 0 ELSE 1 END = T1.DELFLG ")
            sb.Append(" AND    M1.CATEGORY = 'RESERVDEL' ")
            sb.Append(" LEFT JOIN M_Code AS M2 ")
            sb.Append(" ON     M2.CODE = T1.ORDERSTATUS ")
            sb.Append(" AND    M2.CATEGORY = 'RESERVODST' ")
        End If
        sb.Append(" LEFT JOIN [JPONDATA].[dbo].ORDERDAT AS T2 ")
        sb.Append(" WITH (INDEX(UIX_ORDERDAT_ID)) ")
        sb.Append(" ON     T2.ID = T1.ORDERID ")
        'sb.Append(" AND    T2.OrderDate > CONVERT(Date, '2018-1-1') ")

        sb.Append(" WHERE ")
        sb.Append(" 1 = 1 ")

        Dim param As New List(Of SqlParameter)
        If _srchCondition.itemCd <> "" Then
            sb.Append(" AND T1.ITEMCD Like @ITEMCD ")
            param.Add(New SqlParameter("@ITEMCD", "%" & _srchCondition.itemCd & "%"))
        End If
        If _srchCondition.crdDtFrom <> "" Then
            sb.Append(" AND T1.CRTDT >= @CRTDTFROM ")
            param.Add(New SqlParameter("@CRTDTFROM", _srchCondition.crdDtFrom))
        End If
        If _srchCondition.crdDtTo <> "" Then
            sb.Append(" AND T1.CRTDT <= @CRTDTTO ")
            param.Add(New SqlParameter("@CRTDTTO", _srchCondition.crdDtTo))
        End If
        If _srchCondition.chkReserving Then
            sb.Append(" AND T1.DELFLG = 0 ")
        End If
        If _srchCondition.ordStatus <> "" Then
            sb.Append(" AND T2.[状況] = @ORDSTATUS ")
            param.Add(New SqlParameter("@ORDSTATUS", _srchCondition.ordStatus))
        End If
        If _srchCondition.chkExclude Then
            sb.Append(" AND T1.RESERVQTY > 0 ")
        End If

        Return New DbParamEnt(sb, param.ToArray)
    End Function

    Public Sub getOrdStatus()
        Dim sb As New StringBuilder
        sb.Append(" SELECT ")
        sb.Append("  CODE ")
        sb.Append(" ,VALUE1 ")
        sb.Append(" FROM ")
        sb.Append("  M_Code ")
        sb.Append(" WHERE ")
        sb.Append("  CATEGORY = 'ORDSTATUS' ")

        Dim dt As DataTable = DbHandler.executeSelect(New DbParamEnt(sb, Nothing))

        cmbOrdStatus.DataSource = dt
        cmbOrdStatus.ValueMember = "CODE"
        cmbOrdStatus.DisplayMember = "VALUE1"
    End Sub

    Public Sub getSearchCondition()
        _srchCondition.crdDtFrom = dtPickerFrom.getDateTime
        _srchCondition.crdDtTo = dtPickerTo.getDateTime
        _srchCondition.itemCd = txtItemCd.Text
        _srchCondition.chkReserving = chkReserving.Checked
        _srchCondition.chkExclude = chkExclude.Checked
        _srchCondition.ordStatus = cmbOrdStatus.Text
    End Sub

End Class