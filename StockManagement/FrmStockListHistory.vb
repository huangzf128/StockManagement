Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class FrmStockListHistory

#Region "EVENT"
    Private Sub FrmStockListHistory_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtPickerFrom.setDateTime(Now)
        btnSumSearch.Visible = FrmDashboard.isAuthUser

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

    Private Sub grd_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd.CellDoubleClick

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = grd.Rows(e.RowIndex)
            Dim f = New FrmStockHistory()
            Dim p = New List(Of String) From {selectedRow.Cells.Item("ITEMCD").Value, selectedRow.Cells.Item("CRTDT").Value}
            moveTo(f, p)
        End If

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
                CloseLoadingForm()
            End Sub)

    End Function


#Region "SQL"

    Private Function getSqlAndParam() As DbParamEnt

        Dim sb As New StringBuilder
        Dim param As New List(Of SqlParameter)

        sb.Append(" SELECT * FROM (")
        sb.Append(" SELECT ")
        sb.Append("   T1.CRTDT ")
        sb.Append("  ,T1.ITEMCD ")
        sb.Append("  ,T1.LOCATIONCD ")
        sb.Append("  ,M.VALUE1 AS LOCATIONNM ")
        sb.Append("  ,T1.QTY ")
        sb.Append("  ,T1.UPDDT ")
        sb.Append("  ,ROW_NUMBER() OVER(PARTITION BY T1.ITEMCD, T1.LOCATIONCD ORDER BY T1.CRTDT DESC) AS RNUM ")

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

        Return New DbParamEnt(sb, param.ToArray)
    End Function

    Private Function getSqlAndParamSum() As DbParamEnt

        Dim sb As New StringBuilder
        Dim param As New List(Of SqlParameter)
        Dim dateStr = Util.toDateStr(dtPickerFrom.getDate, "yyyy/MM/dd")

        sb.Append(" SELECT ")

        sb.Append("   T1.CRTDT ")
        sb.Append("  ,T1.ITEMCD ")
        sb.Append("  ,T1.LOCATIONCD ")
        sb.Append("  ,T1.LOCATIONNM ")
        sb.Append("  ,T1.QTY ")
        sb.Append("  ,T2.QTYI ")
        sb.Append("  ,T2.QTYO ")

        sb.Append(" FROM ( ")

        sb.Append(" SELECT * FROM (")
        sb.Append(" SELECT ")
        sb.Append("   T1.CRTDT ")
        sb.Append("  ,T1.ITEMCD ")
        sb.Append("  ,T1.LOCATIONCD ")
        sb.Append("  ,M.VALUE1 AS LOCATIONNM ")
        sb.Append("  ,T1.QTY ")
        sb.Append("  ,T1.UPDDT ")
        sb.Append("  ,ROW_NUMBER() OVER(PARTITION BY T1.ITEMCD, T1.LOCATIONCD ORDER BY T1.CRTDT DESC) AS RNUM ")

        sb.Append(" FROM T_ActStockHistory T1 ")
        sb.Append(" LEFT JOIN M_CODE M ")
        sb.Append("  ON M.CODE = T1.LOCATIONCD ")
        sb.Append(" AND M.CATEGORY = 'LOCATIONCD' ")

        sb.Append(" WHERE ")
        sb.Append("     1 = 1 ")
        If dtPickerFrom.getDate <> "" Then
            sb.Append(" AND T1.CRTDT <= @DT ")
            param.Add(New SqlParameter("@DT", dateStr))
        End If
        If Me.txtItemCd.Text <> "" Then
            sb.Append(" AND T1.ITEMCD Like @ITEMCD")
            param.Add(New SqlParameter("@ITEMCD", "%" & Me.txtItemCd.Text & "%"))
        End If

        sb.Append(" ) AS T WHERE T.RNUM = 1 ")
        sb.Append(" ) T1 ")
        sb.Append(" LEFT JOIN ( ")
        sb.Append("     SELECT ")
        sb.Append("          ITEMCD ")
        sb.Append("         ,LOCATIONCD ")
        sb.Append("         ,SUM(case when  IOKBN = 'I' then QTY ELSE 0 END) AS QTYI ")
        sb.Append("         ,SUM(case when  IOKBN = 'O' then QTY ELSE 0 END) AS QTYO ")
        sb.Append("     FROM T_StockHistory")
        sb.Append("     WHERE ")
        sb.Append("             CRTDT BETWEEN @CRTDTFROM AND @CRTDTTO")
        param.Add(New SqlParameter("@CRTDTFROM", dateStr.Substring(0, 8) + "01"))
        param.Add(New SqlParameter("@CRTDTTO", dateStr))
        sb.Append("     GROUP BY ")
        sb.Append("             ITEMCD, LOCATIONCD ")
        sb.Append(" ) T2 ")
        sb.Append(" ON  T2.ITEMCD       = T1.ITEMCD ")
        sb.Append(" AND T2.LOCATIONCD   = T1.LOCATIONCD ")


        Return New DbParamEnt(sb, param.ToArray)
    End Function


    Private Sub btnSumSearch_Click(sender As Object, e As EventArgs) Handles btnSumSearch.Click

        ShowWaitForm()

        Async.Process(
            Function()
                Me.Invoke(Sub()
                              Dim dt As DataTable = DbHandler.executeSelect(getSqlAndParamSum())
                              grd.DataSource = dt
                          End Sub)
            End Function,
            Sub()
                CloseLoadingForm()
            End Sub)
    End Sub

#End Region

End Class