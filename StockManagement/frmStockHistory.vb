Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text

Public Class FrmStockHistory

#Region "変数"
    Structure SearchCondition
        Public crdDtFrom As String
        Public crdDtTo As String
        Public itemCd As String
        Public chkIn As Boolean
        Public chkOut As Boolean
        Public chkExclude As Boolean
    End Structure

    Private _srchCondition As New SearchCondition
#End Region

#Region "EVENT"
    Private Sub FrmStockHistory_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtPickerFrom.setDateTime(Now.AddMonths(-1 * Consts.DATA_INTERVAL))
        dtPickerTo.setDateTime(Now)

        getSearchCondition()
        bindingNavi.initBindingSource(getTotalCount(), Consts.PAGE_COUNT)
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
        bindingNavi.initBindingSource(getTotalCount(), Consts.PAGE_COUNT)
    End Sub

    Private Sub chkIn_CheckedChanged(sender As Object, e As EventArgs) Handles chkIn.CheckedChanged
        If chkIn.Checked AndAlso chkOut.Checked Then
            chkOut.Checked = False
        End If
    End Sub
    Private Sub chkOut_CheckedChanged(sender As Object, e As EventArgs) Handles chkOut.CheckedChanged
        If chkIn.Checked And chkOut.Checked Then
            chkIn.Checked = False
        End If
    End Sub

    Private Sub bindingNavi_CurrentChanged(sender As Object, e As EventArgs) Handles bindingNavi.CurrentChanged
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
            sb.Append("    ,M1.VALUE1 AS LOCATIONNM ")
            sb.Append("    ,M2.VALUE1 AS IOKBNNM ")
        End If
        sb.Append(" ")
        sb.Append(" FROM T_StockHistory T1 ")
        If Not isGetTotalCount Then
            sb.Append(" LEFT JOIN M_Code AS M1 ")
            sb.Append(" ON     M1.CODE = T1.LOCATIONCD ")
            sb.Append(" AND    M1.CATEGORY = 'LOCATIONCD' ")
            sb.Append(" ")
            sb.Append(" LEFT JOIN M_Code AS M2 ")
            sb.Append(" ON     M2.CODE = T1.IOKBN ")
            sb.Append(" AND    M2.CATEGORY = 'IOKBN' ")
            sb.Append(" ")
        End If
        sb.Append(" WHERE ")
        sb.Append(" 1 = 1 ")

        Dim param As New List(Of SqlParameter)
        If _srchCondition.itemCd <> "" Then
            sb.Append(" AND T1.ITEMCD Like @ITEMCD")
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
        If _srchCondition.chkIn Then
            sb.Append(" AND T1.IOKBN = 'I' ")
        End If
        If _srchCondition.chkOut Then
            sb.Append(" AND T1.IOKBN = 'O' ")
        End If
        If _srchCondition.chkExclude Then
            sb.Append(" AND T1.REMARKS NOT IN ('代理店受注自動出庫', '発送済自動出庫') ")
        End If


        Return New DbParamEnt(sb, param.ToArray)
    End Function

    Public Sub getSearchCondition()
        _srchCondition.crdDtFrom = dtPickerFrom.getDateTime
        _srchCondition.crdDtTo = dtPickerTo.getDateTime
        _srchCondition.itemCd = txtItemCd.Text
        _srchCondition.chkIn = chkIn.Checked
        _srchCondition.chkOut = chkOut.Checked
        _srchCondition.chkExclude = chkExclude.Checked
    End Sub

    Public Function isSearchConditionChanged() As Boolean
    End Function


End Class