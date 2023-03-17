Imports System.Data.SqlClient
Imports System.Text
Imports System.Windows
Imports StockManagement.Consts

Public Class FrmStockOut

#Region "EVENT"

    Private Sub FrmStockOut_Load(sender As Object, e As EventArgs) Handles Me.Load

        Clear()

        AddHandler txtQty.KeyPress, AddressOf TxtNumber_keyPress

        Dim dt As New DataTable
        dt.Columns.Add("ITEMCD", GetType(String))
        dt.Columns.Add("LOCATIONCD", GetType(String))
        dt.Columns.Add("LOCATIONNM", GetType(String))
        dt.Columns.Add("QTY", GetType(Integer))
        dt.Columns.Add("REMARKS", GetType(String))

        grd.DataSource = dt
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If Util.obj2String(txtQty.Text, "") = "" Then
            Msg.warning("数量を入力してください。", "入力エラー")
            txtQty.Select()
            Return
        End If

        If isExists(lblItemCd.Text, lblLocationNm.Text) Then
            Msg.warning("既に追加済みです。", "入力エラー")
            Return
        End If

        Dim dt As DataTable = grd.DataSource
        Dim row As DataRow = dt.NewRow
        row("ITEMCD") = lblItemCd.Text
        row("LOCATIONCD") = lblLocationCd.Text
        row("LOCATIONNM") = lblLocationNm.Text
        row("QTY") = txtQty.Text
        row("REMARKS") = txtRemarks.Text
        dt.Rows.Add(row)

        grd.Refresh()

        Clear()
    End Sub

    Private Sub grd_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grd.EditingControlShowing

        If grd.CurrentCell.OwningColumn.Name = "QTY" Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TxtNumber_keyPress
        ElseIf grd.CurrentCell.OwningColumn.Name = "REMARKS" Then
            RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf TxtNumber_keyPress
        End If
    End Sub

    Private Sub btnItemSearch_Click(sender As Object, e As EventArgs) Handles btnItemSearch.Click
        Using frm = New FrmItemSearch
            OpenPop(frm, Nothing)

            Me.lblItemCd.Text = returnParamsPop(0)
            Me.lblLocationCd.Text = returnParamsPop(1)
            Me.lblLocationNm.Text = returnParamsPop(2)
            Me.lblActQty.Text = returnParamsPop(3)

        End Using
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        For i = grd.RowCount - 1 To 0 Step -1
            Dim cell As DataGridViewCell = grd.Item(0, i)
            If cell.Value Then
                grd.Rows.RemoveAt(i)
            End If
        Next

        Dim dt = grd.DataSource
    End Sub

#End Region


#Region "SQL"

    Private Function getSqlAndParamLock() As DbParamEnt

        Dim sb As New StringBuilder
        sb.Append(" SELECT  ")
        sb.Append("   LOCKST ")
        sb.Append(" FROM T_Lock ")
        sb.Append(" WHERE ")
        sb.Append("    UPDIP = '192.168.1.101' ")

        Return New DbParamEnt(sb, Nothing)
    End Function


    Protected Overridable Function getSqlAndParamStockHistory(row As DataRow) As DbParamEnt
        Dim sb As New StringBuilder
        sb.Append(" Insert Into    ")
        sb.Append("   T_StockHistory(CRTDT, ITEMCD, LOCATIONCD, IOKBN, QTY, REMARKS, UPDIP) ")
        sb.Append(" Values (  GETDATE(), @ITEMCD, @LOCATIONCD, 'O', @QTY, @REMARKS, @UPDIP )")

        Dim param As New List(Of SqlParameter)
        param.Add(New SqlParameter("@ITEMCD", row("ITEMCD")))
        param.Add(New SqlParameter("@LOCATIONCD", row("LOCATIONCD")))
        param.Add(New SqlParameter("@QTY", row("QTY")))
        param.Add(New SqlParameter("@REMARKS", row("REMARKS")))
        param.Add(New SqlParameter("@UPDIP", Util.getPcName()))

        Return New DbParamEnt(sb, param.ToArray)

    End Function


    Protected Overridable Function getSqlAndParamActStock(row As DataRow) As DbParamEnt
        Dim sb As New StringBuilder
        sb.Append(" MERGE T_ActStock AS ACT ")
        sb.Append(" USING (values( ")
        sb.Append("    @ITEMCD ")
        sb.Append("   ,@LOCATIONCD ")
        sb.Append("   ,@QTY ")
        sb.Append(" )) AS DATA(ITEMCD, LOCATIONCD, QTY) ")
        sb.Append(" ON (")
        sb.Append("     ACT.ITEMCD = DATA.ITEMCD ")
        sb.Append(" AND ACT.LOCATIONCD = DATA.LOCATIONCD ) ")
        sb.Append(" WHEN MATCHED THEN ")
        sb.Append("   UPDATE SET ")
        sb.Append("      ACTQTY = ACTQTY - DATA.QTY ")
        sb.Append("     ,UPDDT = GETDATE() ")
        sb.Append(" WHEN NOT MATCHED BY Target THEN ")
        sb.Append("   INSERT (ITEMCD, LOCATIONCD, ACTQTY, UPDDT) ")
        sb.Append("   VALUES (DATA.ITEMCD, DATA.LOCATIONCD, DATA.QTY * -1, GETDATE());")

        Dim param As New List(Of SqlParameter)
        param.Add(New SqlParameter("@ITEMCD", row("ITEMCD")))
        param.Add(New SqlParameter("@LOCATIONCD", row("LOCATIONCD")))
        param.Add(New SqlParameter("@QTY", row("QTY")))

        Return New DbParamEnt(sb, param.ToArray)
    End Function

#End Region

#Region "mothed"
    Private Function isExists(ByVal itemCd As String, ByVal locationNm As String) As Boolean
        Dim dt As DataTable = grd.DataSource
        If dt Is Nothing Then
            Return False
        End If

        For Each row As DataRow In dt.Rows
            If row("ITEMCD") = itemCd AndAlso row("LOCATIONCD") = locationNm Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Clear()
        lblItemCd.Text = ""
        txtQty.Text = ""
        txtRemarks.Text = ""
        lblActQty.Text = ""
        lblLocationCd.Text = ""
        lblLocationNm.Text = ""
        lblItemCd.Select()
    End Sub



#End Region

    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click

        If grd.DataSource Is Nothing OrElse grd.RowCount = 0 Then
            Return
        End If

        Dim lockDt As DataTable = DbHandler.executeSelect(getSqlAndParamLock())
        If lockDt IsNot Nothing AndAlso lockDt.Rows.Count > 0 AndAlso lockDt.Rows(0).Item("LOCKST") Then
            MessageBox.Show("サーバーで定時処理が稼働中です。暫く経ってから実行してください。", "出庫処理", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Using db = New DbHandler

            Try
                db.open()
                db.trnStart()

                Dim dt = grd.DataSource
                For Each row As DataRow In dt.rows
                    db.execute(getSqlAndParamStockHistory(row))
                    db.execute(getSqlAndParamActStock(row))
                Next

                db.commit()

                Msg.info("サーバーへの出庫処理が完了しました。", "出庫処理")
                Dim d As DataTable = grd.DataSource
                d.Rows.Clear()
                grd.Refresh()

            Catch ex As Exception
                Msg.info("サーバーへの出庫処理が失敗しました。", "出庫処理")
            End Try
        End Using

    End Sub


End Class