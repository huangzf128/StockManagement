Imports System.Data.SqlClient
Imports System.Text

Public Class FrmStockOut

    Protected locationDt As DataTable = Nothing

    Protected Overridable Function processName()
        Return "出庫処理"
    End Function


#Region "EVENT"

    Private Sub FrmStockOut_Load(sender As Object, e As EventArgs) Handles Me.Load

        grd.CellBorderStyle = DataGridViewCellBorderStyle.Single

        Clear()

        Dim dt As New DataTable
        dt.Columns.Add("ITEMCD", GetType(String))
        dt.Columns.Add("LOCATIONCD", GetType(String))
        dt.Columns.Add("LOCATIONNM", GetType(String))
        dt.Columns.Add("QTY", GetType(Integer))
        dt.Columns.Add("REMARKS", GetType(String))

        grd.DataSource = dt

        If locationDt Is Nothing Then
            locationDt = CommonService.GetLocation()
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If Util.obj2String(lblItemCd.Text, "") = "" Then
            Msg.warning("商品を選択してください。", "入力エラー")
            txtQty.Select()
            Return
        End If

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

            If returnParamsPop IsNot Nothing Then
                Me.lblItemCd.Text = returnParamsPop(0)
                Me.lblLocationCd.Text = returnParamsPop(1)
                Me.lblLocationNm.Text = returnParamsPop(2)
                Me.lblActQty.Text = returnParamsPop(3)

            End If

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

    Private Function check(dt As DataTable) As Boolean

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim row As DataRow = dt.Rows(i)

            Dim itemDt As DataTable = DbHandler.executeSelect(getSqlAndParamItem(row("ITEMCD")))
            If itemDt.Rows.Count <= 0 Then
                Msg.info("変換商品名は登録されていません。", "入力エラー")
                grd(1, i).Selected = True
                Return False
            End If

            If Util.isEmpty(row("LOCATIONCD")) Then
                Msg.info("ロケーションCDは必須入力項目です。", "入力エラー")
                grd(2, i).Selected = True
                Return False
                'ElseIf Util.isEmpty(row("LOCATIONNM")) Then
                '    Msg.info("ロケーションCDは登録されていません。", "入力エラー")
                '    grd(3, i).Selected = True
                '    Return False
            End If

            If Util.isEmpty(row("QTY")) Then
                Msg.info("数量は必須入力項目です。", "入力エラー")
                grd(4, i).Selected = True
                Return False
            End If
            If Util.isEmpty(row("REMARKS")) Then
                Msg.info("備考は必須入力項目です。", "入力エラー")
                grd(5, i).Selected = True
                Return False
            End If
        Next

        Return True
    End Function


    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click

        If grd.DataSource Is Nothing OrElse grd.RowCount = 0 Then
            Return
        End If

        ' check
        Dim dt As DataTable = grd.DataSource
        If Not check(dt) Then
            Return
        End If

        Dim result As DialogResult = MessageBox.Show(processName() & "を行います。よろしいですか？",
                                             "確認",
                                             MessageBoxButtons.OKCancel,
                                             MessageBoxIcon.Exclamation,
                                             MessageBoxDefaultButton.Button2)

        If result = DialogResult.Cancel Then
            Return
        End If

        Dim lockDt As DataTable = DbHandler.executeSelect(getSqlAndParamLock())
        If lockDt IsNot Nothing AndAlso lockDt.Rows.Count > 0 AndAlso lockDt.Rows(0).Item("LOCKST") Then
            MessageBox.Show("サーバーで定時処理が稼働中です。暫く経ってから実行してください。", processName(), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using db = New DbHandler

            Try
                db.open()
                db.trnStart()

                For Each row As DataRow In dt.Rows
                    db.execute(getSqlAndParamStockHistory(row))
                    db.execute(getSqlAndParamActStock(row))
                Next

                db.commit()

                Msg.info("サーバーへの" & processName() & "が完了しました。", processName())
                Dim d As DataTable = grd.DataSource
                d.Rows.Clear()
                grd.Refresh()

            Catch ex As Exception
                Msg.info("サーバーへの" & processName() & "が失敗しました。", processName())
            End Try
        End Using

    End Sub

    Private Sub btnPaste_Click(sender As Object, e As EventArgs) Handles btnPaste.Click

        Dim dt As DataTable = grd.DataSource

        Try
            For Each line As String In Clipboard.GetText.Split(vbNewLine)

                If Not line.Trim.ToString = "" Then

                    Dim item() As String = line.Split(vbTab)

                    Dim row As DataRow = dt.NewRow
                    row("ITEMCD") = item(0).Trim
                    row("LOCATIONCD") = item(1).Trim
                    row("LOCATIONNM") = CommonService.GetLocationCdName(locationDt, item(1))
                    row("QTY") = IIf(item(2).Trim = "", DBNull.Value, item(2).Trim)
                    If item.Count > 3 Then
                        row("REMARKS") = item(3).Trim
                    End If

                    dt.Rows.Add(row)
                End If
            Next

        Catch ex As Exception
            Msg.info("データのフォーマットを確認してください。" & vbNewLine & " [商品名、倉庫コード、数量、コメント(任意)]", "エラー")
        End Try
    End Sub

#End Region


#Region "SQL"

    Private Function getSqlAndParamItem(itemCd As String) As DbParamEnt

        Dim sb As New StringBuilder
        sb.Append(" SELECT  ")
        sb.Append("   1 ")
        sb.Append(" FROM M_Item ")

        Dim param As New List(Of SqlParameter)

        sb.Append(" WHERE ")
        sb.Append("    ITEMCD = @ITEMCD ")
        param.Add(New SqlParameter("@ITEMCD", itemCd))

        Return New DbParamEnt(sb, param.ToArray)
    End Function


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
            If row("ITEMCD") = itemCd AndAlso row("LOCATIONNM") = locationNm Then
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

    Private Sub grd_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles grd.DataError
        If e.ColumnIndex = 4 Then
            Msg.info("数量は必須入力項目です。", "入力エラー")
        End If

        e.Cancel = False
    End Sub

    Private Sub grd_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles grd.CellValidated
        If e.ColumnIndex = 2 Then
            Dim ds As DataTable = grd.DataSource
            Dim locationCd As String = ds.Rows(e.RowIndex).Item(e.ColumnIndex - 1)
            Dim locationNm As String = CommonService.GetLocationName(locationDt, locationCd)
            ds.Rows(e.RowIndex).Item(e.ColumnIndex) = locationNm
        End If
    End Sub


#End Region



End Class