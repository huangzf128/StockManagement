Imports System.Security.Cryptography

Public Class frmDairiImport
    Private Sub cmdExec_Click(sender As Object, e As EventArgs) Handles cmdExec.Click
        Dim Cmd As New OleDb.OleDbCommand
        Cmd.Connection = Cm.Conn
        Dim varIpAddress As String
        varIpAddress = Cm.DLookup("VALUE1", "M_CODE_CL", "CATEGORY = 'PREVUSER'")
        ' TODO
        'Dim objDB As DAO.Database
        'Dim objRS As DAO.Recordset
        Dim varItem(5) As String
        Dim varValue() As String
        Dim varSplitVal As String
        Dim strItem As String
        Dim strQty As String
        Dim i As Integer

        Dim strFileName As String

        Dim Dta As New OleDb.OleDbDataAdapter
        Dim Dts As New DataSet

        If Trim(Cm.Nz(txtFilePath.Text, "")) <> "" Then
            strFileName = Mid(txtFilePath.Text, InStrRev(txtFilePath.Text, "\", , vbTextCompare) + 1)

            If Len(strFileName) > 4 And strFileName.Substring(strFileName.Length - 3) = "csv" Then
                ' テーブルクリア
                Cmd.CommandText = "Delete From T_ImportCSV;"
                Cmd.CommandText = "Delete From T_ImportCSV_Sum;"
                Cmd.CommandText = "Delete From T_ErrorAlert_CL;"
                Cmd.ExecuteNonQuery()

                ' CSVファイルの取込み
                Cm.ImportDBFromFile("T_ImportCSV", txtFilePath.Text)


                'レコードセットのセット
                Cmd.Connection = Cm.Conn
                Cmd.CommandText = "SELECT * FROM T_ImpYahooOrd"
                Dta.SelectCommand = Cmd
                Dta.Fill(Dts)

                ' CSV取込みテーブルを全件ループ
                Cmd.CommandText = ""
                For j = 0 To Dts.Tables(0).Rows.Count
                    varItem(0) = Dts.Tables(0).Rows(j).Item("品名１")
                    varItem(1) = Dts.Tables(0).Rows(j).Item("品名２")
                    varItem(2) = Dts.Tables(0).Rows(j).Item("品名３")
                    varItem(3) = Dts.Tables(0).Rows(j).Item("品名４")
                    varItem(4) = Dts.Tables(0).Rows(j).Item("品名５")
                    For i = 0 To 4 Step 1
                        If Cm.Nz(varItem(i), "") <> "" Then
                            varValue = Split(varItem(i), "/")
                            For Each varSplitVal In varValue
                                varSplitVal = Trim(Cm.Nz(varSplitVal, ""))
                                If InStr(Cm.Nz(varSplitVal, ""), "*") > 0 And Len(Cm.Nz(varSplitVal, "")) > InStr(Cm.Nz(varSplitVal, ""), "*") Then
                                    strItem = Mid(varSplitVal, 1, InStr(Cm.Nz(varSplitVal, ""), "*") - 1)
                                    strQty = Mid(varSplitVal, InStr(Cm.Nz(varSplitVal, ""), "*") + 1)
                                    ' 数量の数値チェック
                                    If IsNumeric(strQty) Then
                                        ' サマリテーブルに格納
                                        Cmd.CommandText = "Insert Into T_ImportCSV_Sum(SHOPNAME, ORDERITEMCD, QTY) " &
"Values('" & Cm.Nz(Dts.Tables(0).Rows(j).Item("ご依頼主名称１"), "") & "', '" & strItem & "', " & strQty & ")"
                                    Else
                                        ' エラーテーブルに格納
                                        Cmd.CommandText = "INSERT INTO T_ErrorAlert_CL ( KEYCODE, MESSAGE, CRTDT ) " &
"Values('" & strItem & "', '受注数量が数字ではありません。確認してください。', Now())"
                                    End If
                                End If
                            Next
                        End If
                    Next
                Next

                If Cm.DCount("KEYCODE", "T_ErrorAlert_CL", "") > 0 Then
                        frmErrorAlertTbl.ShowDialog()
                        Exit Sub
                    Else
                        ' 取込データチェック
                        Cmd.CommandText = "INSERT INTO T_ErrorAlert_CL ( KEYCODE, MESSAGE, CRTDT ) " &
                                 "SELECT ImportCSV.ORDERITEMCD, '商品コードが商品管理コードマスタに登録されていません。登録して下さい。', Now() " &
                                 "FROM (SELECT ORDERITEMCD " &
"FROM T_ImportCSV_Sum GROUP BY ORDERITEMCD " &
"HAVING ORDERITEMCD Is Not Null And ORDERITEMCD<>'')  AS ImportCSV " &
                                 "LEFT JOIN M_ConvItem ON ImportCSV.ORDERITEMCD=M_ConvItem.ORDERITEMCD " &
                                 "WHERE M_ConvItem.ORDERITEMCD Is Null;"
                        Cmd.ExecuteNonQuery()
                        '                ' 論理エラー分無視の確認メッセージ
                        '                If DCount("KEYCODE", "T_ErrorAlert_CL") > 0 Then
                        '                    If MsgBox("代理店受注の取込みデータにエラーがありますが" & vbCrLf & "このままエラーが無い受注分の引当てを行いますか？", vbYesNo, "") = vbNo Then
                        '                        DoCmd.OpenForm "F_ErrorAlertTbl", acFormDS, , , acFormReadOnly, acDialog
                        '                        Exit Sub
                        '                    End If
                        '                End If
                        '            End If

                        ' サーバーのサマリテーブルにデータ移行
                        Cmd.CommandText = "INSERT INTO T_ImportCSV_Sum Select * From T_ImportCSV_Sum;"

                        ' 引当てテーブルにデータ移行
                        Cmd.CommandText = "INSERT INTO T_StockReserv ( CRTDT, ITEMCD, ORDERID, IOKBN, DELFLG, ORDERSTATUS, RESERVQTY, " &
"ORDERKBN, ORDERCODE, CUSTID, ORDERDT, INCHARGE, CUSTNAME, CUSTNAMEKANA, TELNO, ZIPCODE, SENDADD1, " &
"SENDADD2, DESIREDMONTH, DESIREDDATE, DESIREDTIME, DLVCOMPANY, DLVSLIPNO, UPDDT, UPDIP ) " &
"Select Now(), T.ITEMCD, 0, 'O', 0, 3, Sum(T.TotalQty), Max(T.SHOPNAME), " &
"Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Now(), '" & Cm.Nz(varIpAddress, "") & "' " &
"From " &
"(SELECT M_ConvItem.ITEMCD, CSVORD.QTY*M_ConvItem.QTY As TotalQty, CSVORD.SHOPNAME " &
"FROM (SELECT CSV.SHOPNAME, CSV.ORDERITEMCD AS ORDERITEMCD, Sum(CSV.QTY) AS QTY " &
"FROM (SELECT * FROM T_ImportCSV_Sum WHERE ORDERITEMCD Is Not Null And QTY Is Not Null) AS CSV " &
"GROUP BY CSV.SHOPNAME, CSV.ORDERITEMCD) AS CSVORD " &
"LEFT JOIN M_ConvItem AS M_ConvItem ON CSVORD.ORDERITEMCD=M_ConvItem.ORDERITEMCD " &
"WHERE M_ConvItem.ITEMCD Is Not Null " &
") As T " &
"Group By ITEMCD;"

                        ' 引当て分の取込みデータ削除
                        Cmd.CommandText = "DELETE DISTINCTROW T1.*, M_ConvItem.ORDERITEMCD" &
"From T_ImportCSV_Sum As T1 LEFT Join M_ConvItem On T1.ORDERITEMCD=M_ConvItem.ORDERITEMCD" &
"Where (((M_ConvItem.ORDERITEMCD) Is Not Null));"
                        Cmd.ExecuteNonQuery()
                    End If
                    ElseIf Len(strFileName) > 4 And strFileName.Substring(strFileName.Length - 3) = "xls" Then
                    ' エクセルファイルの取込み
                    ' TODO
                    'Cmd.CommandText = "Delete From T_ImportXLS"
                    'DoCmd.TransferSpreadsheet acImport, acSpreadsheetTypeExcel8, "T_ImportXLS", txtFilePath.Text, True

                    Cmd.CommandText = "Delete From T_ErrorAlert_CL;"
                    ' 取込データチェック
                    Cmd.CommandText = "INSERT INTO T_ErrorAlert_CL ( KEYCODE, MESSAGE, CRTDT ) " &
"Select ImportXLS.変更商品名, '変更商品名が変換商品名マスタに登録されていません。登録して下さい。', Now() " &
"FROM (SELECT 変更商品名 " &
"FROM T_ImportXLS GROUP BY 変更商品名 " &
"HAVING 変更商品名 Is Not Null And 変更商品名<>'')  AS ImportXLS " &
"LEFT JOIN M_Item ON ImportXLS.変更商品名=M_Item.ITEMCD " &
"WHERE M_Item.ITEMCD Is Null;"
                    Cmd.ExecuteNonQuery()

                    '            ' 論理エラー分無視の確認メッセージ
                    '            If DCount("KEYCODE", "T_ErrorAlert_CL") > 0 Then
                    '                If MsgBox("代理店受注の取込みデータにエラーがありますが" & vbCrLf & "このままエラーが無い受注分の引当てを行いますか？", vbYesNo, "") = vbNo Then
                    '                    DoCmd.OpenForm "F_ErrorAlertTbl", acFormDS, , , acFormReadOnly, acDialog
                    '                    Exit Sub
                    '                End If
                    '            End If

                    ' サーバーのサマリテーブルにデータ移行
                    Cmd.CommandText = "INSERT INTO T_ImportXLS([商品ＣＤ],[商品名],[変更商品名],[単位],[数量],[単価],[金額(税抜）],[納期]) Select [商品ＣＤ],[商品名],[変更商品名],[単位],[数量],[単価],[金額(税抜）],[納　期] From T_ImportXLS;"

                    ' 引当てテーブルにデータ移行
                    Cmd.CommandText = "INSERT INTO T_StockReserv ( CRTDT, ITEMCD, ORDERID, IOKBN, DELFLG, ORDERSTATUS, RESERVQTY, " &
                         "ORDERKBN, ORDERCODE, CUSTID, ORDERDT, INCHARGE, CUSTNAME, CUSTNAMEKANA, TELNO, ZIPCODE, SENDADD1, " &
                         "SENDADD2, DESIREDMONTH, DESIREDDATE, DESIREDTIME, DLVCOMPANY, DLVSLIPNO, UPDDT, UPDIP ) " &
                         "SELECT Now(), M_Item.ITEMCD, 0, 'O', 0, 3, XLSORD.QTY, 'DISCOM', " &
                         "Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Now(), '" & Cm.Nz(varIpAddress, "") & "' " &
                         "FROM (SELECT XLS.変更商品名 AS ITEMCD, Sum(XLS.数量) AS QTY " &
                         "FROM (SELECT * FROM T_ImportXLS WHERE 変更商品名 Is Not Null And 数量 Is Not Null) AS XLS " &
                         "GROUP BY XLS.変更商品名)  AS XLSORD LEFT JOIN M_Item AS M_Item ON XLSORD.ITEMCD=M_Item.ITEMCD " &
                         "WHERE M_Item.ITEMCD Is Not Null;"

                ' 引当て分の取込みデータ削除
                Cmd.CommandText = "DELETE DISTINCTROW T1.*, M_Item.ITEMCD" &
                         "FROM T_ImportXLS AS T1 LEFT JOIN M_Item ON T1.変更商品名=M_Item.ITEMCD" &
                         "WHERE (((M_Item.ITEMCD) Is Not Null));"
                Cmd.ExecuteNonQuery()
            End If
            If Cm.DCount("KEYCODE", "T_ErrorAlert_CL", "") > 0 Then
                frmErrorAlertTbl.ShowDialog()
            Else
                MessageBox.Show("代理店受注の取込みと引当てが完了しました。", "代理店受注取込み", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("受注ファイルを選択してください。", "代理店受注取込み", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click

        Dim ofd As New OpenFileDialog()
        'ダイアログのタイトルを設定
        ofd.Title = "ファイルを開くダイアログ"
        'ファイルの種類を設定
        ofd.Filter = "Microsoft Office Excelファイル|*.xls,*.csv"
        '複数ファイル選択を許可しない
        ofd.Multiselect = False
        '初期パスを設定
        ofd.InitialDirectory = "./"
        'ダイアログを表示
        If ofd.ShowDialog() = DialogResult.OK Then
            '選択されたフルパスをテキストボックスへ表示
            txtFilePath.Text = ofd.FileName
        End If

    End Sub

    Private Sub cmdCheck_Click(sender As Object, e As EventArgs) Handles cmdCheck.Click
        CheckImportData()
    End Sub

    ' 取込み済代理店受注情報チェック
    Private Sub CheckImportData()
        Dim varIpAddress As String
        Dim Cmd As New OleDb.OleDbCommand

        Cmd.Connection = Cm.Conn

        varIpAddress = Cm.DLookup("VALUE1", "M_CODE_CL", "CATEGORY = 'PREVUSER'")

        Cmd.CommandText = "Delete From T_ErrorAlert_CL"
        Cmd.ExecuteNonQuery()

        ' 取込データチェック
        Cmd.CommandText = "INSERT INTO T_ErrorAlert_CL ( KEYCODE, MESSAGE, CRTDT ) " &
                 "SELECT ImportCSV.ORDERITEMCD, '商品コードが商品管理コードマスタに登録されていません。登録して下さい。', Now() " &
                 "FROM (SELECT ORDERITEMCD " &
                 "FROM T_ImportCSV_Sum GROUP BY ORDERITEMCD " &
                 "HAVING ORDERITEMCD Is Not Null And ORDERITEMCD<>'')  AS ImportCSV " &
                 "LEFT JOIN M_ConvItem ON ImportCSV.ORDERITEMCD=M_ConvItem.ORDERITEMCD " &
                 "WHERE M_ConvItem.ORDERITEMCD Is Null;"

        ' 取込データチェック
        Cmd.CommandText = "INSERT INTO T_ErrorAlert_CL ( KEYCODE, MESSAGE, CRTDT ) " &
                 "SELECT ImportXLS.変更商品名, '変更商品名が変換商品名マスタに登録されていません。登録して下さい。', Now() " &
                 "FROM (SELECT 変更商品名 " &
                 "FROM T_ImportXLS GROUP BY 変更商品名 " &
                 "HAVING 変更商品名 Is Not Null And 変更商品名<>'')  AS ImportXLS " &
                 "LEFT JOIN M_Item ON ImportXLS.変更商品名=M_Item.ITEMCD " &
                 "WHERE M_Item.ITEMCD Is Null;"

        ' 引当てテーブルにデータ移行（CSV分）
        Cmd.CommandText = "INSERT INTO T_StockReserv ( CRTDT, ITEMCD, ORDERID, IOKBN, DELFLG, ORDERSTATUS, RESERVQTY, " &
                 "ORDERKBN, ORDERCODE, CUSTID, ORDERDT, INCHARGE, CUSTNAME, CUSTNAMEKANA, TELNO, ZIPCODE, SENDADD1, " &
                 "SENDADD2, DESIREDMONTH, DESIREDDATE, DESIREDTIME, DLVCOMPANY, DLVSLIPNO, UPDDT, UPDIP ) " &
                 "Select Now(), T.ITEMCD, 0, 'O', 0, 3, Sum(T.TotalQty), Max(T.SHOPNAME), " &
                 "Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Now(), '" & Cm.Nz(varIpAddress, "") & "' " &
                 "From " &
                 "(SELECT M_ConvItem.ITEMCD, CSVORD.QTY*M_ConvItem.QTY As TotalQty, CSVORD.SHOPNAME " &
                 "FROM (SELECT CSV.SHOPNAME, CSV.ORDERITEMCD AS ORDERITEMCD, Sum(CSV.QTY) AS QTY " &
                 "FROM (SELECT * FROM T_ImportCSV_Sum WHERE ORDERITEMCD Is Not Null And QTY Is Not Null) AS CSV " &
                 "GROUP BY CSV.SHOPNAME, CSV.ORDERITEMCD) AS CSVORD " &
                 "LEFT JOIN M_ConvItem AS M_ConvItem ON CSVORD.ORDERITEMCD=M_ConvItem.ORDERITEMCD " &
                 "WHERE M_ConvItem.ITEMCD Is Not Null " &
                 ") As T " &
                 "Group By ITEMCD;"

        ' 引当て分の取込みデータ削除
        Cmd.CommandText = "DELETE DISTINCTROW T1.*, M_ConvItem.ORDERITEMCD" &
                 "FROM T_ImportCSV_Sum AS T1 LEFT JOIN M_ConvItem ON T1.ORDERITEMCD=M_ConvItem.ORDERITEMCD" &
                 "WHERE (((M_ConvItem.ORDERITEMCD) Is Not Null));"

        ' 引当てテーブルにデータ移行（XLS分）
        Cmd.CommandText = "INSERT INTO T_StockReserv ( CRTDT, ITEMCD, ORDERID, IOKBN, DELFLG, ORDERSTATUS, RESERVQTY, " &
                 "ORDERKBN, ORDERCODE, CUSTID, ORDERDT, INCHARGE, CUSTNAME, CUSTNAMEKANA, TELNO, ZIPCODE, SENDADD1, " &
                 "SENDADD2, DESIREDMONTH, DESIREDDATE, DESIREDTIME, DLVCOMPANY, DLVSLIPNO, UPDDT, UPDIP ) " &
                 "SELECT Now(), M_Item.ITEMCD, 0, 'O', 0, 3, XLSORD.QTY, 'DISCOM', " &
                 "Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Null, Now(), '" & Cm.Nz(varIpAddress, "") & "' " &
                 "FROM (SELECT XLS.変更商品名 AS ITEMCD, Sum(XLS.数量) AS QTY " &
                 "FROM (SELECT * FROM T_ImportXLS WHERE 変更商品名 Is Not Null And 数量 Is Not Null) AS XLS " &
                 "GROUP BY XLS.変更商品名)  AS XLSORD LEFT JOIN M_Item AS M_Item ON XLSORD.ITEMCD=M_Item.ITEMCD " &
                 "WHERE M_Item.ITEMCD Is Not Null;"

        ' 引当て分の取込みデータ削除
        Cmd.CommandText = "DELETE DISTINCTROW T1.*, M_Item.ITEMCD" &
                 "FROM T_ImportXLS AS T1 LEFT JOIN M_Item ON T1.変更商品名=M_Item.ITEMCD" &
                 "WHERE (((M_Item.ITEMCD) Is Not Null));"
        Cmd.ExecuteNonQuery()

        If Cm.DCount("KEYCODE", "T_ErrorAlert_CL", "") > 0 Then
            frmErrorAlertTbl.ShowDialog()
        Else
            MessageBox.Show("取込済の代理店受注にエラーはありませんでした。", "代理店受注チェック", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub
End Class