Imports System.Data.SqlClient
Imports System.Text

Public Class FrmItemSearch

#Region "EVENT"

    Private Sub frmItemSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim srchDt As DataTable = DbHandler.executeSelect(getSqlAndParam())
        grd.DataSource = srchDt

        Dim cmdSrchDt As DataTable = CommonService.GetLocation()
        cmbLocation.DisplayMember = "NAME"
        cmbLocation.ValueMember = "CODE"
        cmbLocation.DataSource = cmdSrchDt

    End Sub

    Private Sub grd_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = grd.Rows(e.RowIndex)

            Me.lblTitle.Text = FrmStockReserve.Text

            Dim param = New List(Of String) From {selectedRow.Cells.Item("ITEMCD").Value,
                                                    selectedRow.Cells.Item("LOCATIONCD").Value,
                                                    selectedRow.Cells.Item("LOCATIONNM").Value,
                                                    selectedRow.Cells.Item("ACTQTY").Value}
            ClosePop(param)
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim srchDt As DataTable = DbHandler.executeSelect(getSqlAndParam())
        grd.DataSource = srchDt
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cmbLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLocation.SelectedIndexChanged
        Dim srchDt As DataTable = DbHandler.executeSelect(getSqlAndParam())
        grd.DataSource = srchDt
    End Sub

#End Region


#Region "SQL"
    Private Function getSqlAndParam（） As DbParamEnt

        Dim sb As New StringBuilder
        sb.Append(" SELECT ")
        sb.Append("      ITEM.ITEMCD ")
        sb.Append("     ,ACTST.LOCATIONCD ")
        sb.Append("     ,CODE1.VALUE1 AS LOCATIONNM ")
        sb.Append("     ,ACTST.ACTQTY ")
        sb.Append(" ")
        sb.Append(" FROM M_ITEM AS ITEM ")
        sb.Append(" LEFT JOIN ")
        sb.Append("     T_ActStock As ACTST ")
        sb.Append(" ON  ITEM.ITEMCD = ACTST.ITEMCD ")
        sb.Append(" LEFT JOIN ")
        sb.Append("     M_CODE As CODE1 ")
        sb.Append(" ON  ACTST.LOCATIONCD = CODE1.CODE ")
        sb.Append(" AND CATEGORY = 'LOCATIONCD' ")

        sb.Append(" WHERE ")
        sb.Append(" 1 = 1 ")

        Dim param As New List(Of SqlParameter)
        If Me.txtItemCd.Text <> "" Then
            sb.Append(" AND ITEM.ITEMCD Like @ITEMCD")
            param.Add(New SqlParameter("@ITEMCD", "%" & Me.txtItemCd.Text & "%"))
        End If

        If Me.cmbLocation.SelectedValue IsNot Nothing AndAlso Me.cmbLocation.SelectedValue <> String.Empty Then
            sb.Append(" AND ACTST.LOCATIONCD = @LOCATIONCD ")
            param.Add(New SqlParameter("@LOCATIONCD", Me.cmbLocation.SelectedValue))
        Else
            ' TODO: 倉庫  西京を除外
            sb.Append(" AND ACTST.LOCATIONCD <> 2 ")
        End If

        sb.Append(" ORDER BY ")
        sb.Append("      ITEM.ITEMCD ")
        sb.Append("     ,ACTST.LOCATIONCD ")

        Return New DbParamEnt(sb, param.ToArray)
    End Function

#End Region


End Class