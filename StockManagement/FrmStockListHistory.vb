Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class FrmStockListHistory

#Region "EVENT"
    Private Sub FrmStockListHistory_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtPickerFrom.setDateTime(Now)

        search()
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        If grd.Rows.Count = 0 Then
            Return
        End If
        Util.CopyDataGridView(grd)
        AutoClosingMessageBox.Show("すべての明細をコピーしました。", "情報")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        search()
    End Sub

#End Region

    Private Function search() As AsyncVoidMethodBuilder

        ShowWaitForm()

        Async.Process(
            Function()
                Me.Invoke(Sub()
                              Dim dt As DataTable = DbHandler.executeSelect(getSqlAndParam())
                              grd.DataSource = dt
                          End Sub)
            End Function,
            Sub()
                CloseForm()
            End Sub)

    End Function


    Private Function getSqlAndParam() As DbParamEnt

        Dim sb As New StringBuilder
        Dim param As New List(Of SqlParameter)

        sb.Append(" SELECT * FROM (")
        sb.Append(" SELECT ")
        sb.Append("   T1.CRTDT ")
        sb.Append("  ,T1.ITEMCD ")
        sb.Append("  ,M.VALUE1 AS LOCATIONNM ")
        sb.Append("  ,T1.QTY ")
        sb.Append("  ,T1.UPDDT ")
        sb.Append("  ,ROW_NUMBER() OVER(PARTITION BY T1.CRTDT, T1.ITEMCD, T1.LOCATIONCD ORDER BY T1.CRTDT DESC) AS RNUM ")
        sb.Append(" FROM T_ActStockHistory T1 ")
        sb.Append(" LEFT JOIN M_CODE M ")
        sb.Append("  ON M.CODE = T1.LOCATIONCD ")
        sb.Append(" AND M.CATEGORY = 'LOCATIONCD' ")
        sb.Append(" WHERE ")
        sb.Append("     1 = 1 ")
        If dtPickerFrom.getDate <> "" Then
            sb.Append(" AND T1.CRTDT <= @DT ")
            param.Add(New SqlParameter("@DT", Util.toDateStr(dtPickerFrom.getDate, "yyyy/MM/dd")))
        End If
        If Me.txtItemCd.Text <> "" Then
            sb.Append(" AND T1.ITEMCD Like @ITEMCD")
            param.Add(New SqlParameter("@ITEMCD", "%" & Me.txtItemCd.Text & "%"))
        End If

        sb.Append(" ) AS T WHERE T.RNUM = 1 ")
        'sb.Append(" ORDER BY ")
        'sb.Append("     CRTDT DESC ")

        Return New DbParamEnt(sb, param.ToArray)
    End Function

End Class