Imports System.IO
Imports System.Net
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class frmYahooImport
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    ' 参照ボタンクリック時イベント
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

    ' 取込ボタンクリック時イベント
    Private Sub cmdExec_Click(sender As Object, e As EventArgs) Handles cmdExec.Click
        Dim varIpAddress As String = ""

        Dim varItem(4) As String
        Dim i As Integer

        Dim strFileName As String

        Dim Cmd As New OleDb.OleDbCommand
        Dim Dta As New OleDb.OleDbDataAdapter
        Dim Dts As New DataSet

        Dim strShopName As String

        Cmd.Connection = Cm.Conn

        varIpAddress = Cm.DLookup("VALUE1", "M_CODE_CL", "CATEGORY = 'PREVUSER'")

        ' 確認メッセージ
        If MessageBox.Show("ヤフオクの受注CSVファイルから引当てを行います。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        If Trim(Cm.Nz(txtFilePath.Text, "")) <> "" Then
            strFileName = Mid(txtFilePath.Text, InStrRev(txtFilePath.Text, "\", , vbTextCompare) + 1)

            ' ファイル使用中チェック
            If FileInUse(Cm.Nz(txtFilePath.Text, "")) Then
                MessageBox.Show("取込みファイルが使用中です。閉じてから実行して下さい。", "ヤフオク受注取込み", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' ファイル名チェック
            If Len(strFileName) < 13 Then
                MessageBox.Show("ヤフオク受注ファイルＣＳＶはルールに乗っ取ったファイル名を使用して下さい。" & vbCrLf & "ルール：YYYYMMDD＋ショップ名", "ヤフオク受注取込み", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            strShopName = "ヤフオク" & Mid(strFileName, 9, Len(strFileName) - 12)

            If Len(strFileName) > 4 And Strings.Right(strFileName, 3) = "csv" Then
                ' テーブルクリア
                Cmd.CommandText = "Delete From T_ImpYahooOrd;"
                Cmd.CommandText += "Delete From T_ErrorAlert_CL;"
                Cmd.ExecuteNonQuery()

                ' CSVファイルの取込み
                Cm.ImportDBFromFile("T_ImpYahooOrd", txtFilePath.Text)

                ' 取込データチェック
                Cmd.CommandText = "INSERT INTO T_ErrorAlert_CL ( KEYCODE, MESSAGE, CRTDT ) " &
                         "SELECT ImportCSV.[オークションID], 'ヤフオク引当てに必要な情報が格納されていません。確認して下さい。', Now() " &
                         "FROM (SELECT [オークションID] From T_ImpYahooOrd " &
                         "WHERE [オークションID] Is Null Or [オークションID] = '' Or [管理番号] Is Null Or [管理番号] = '' " &
                         "Or [落札個数] Is Null Or [落札者メールアドレス] Is Null Or [落札者メールアドレス] = '') As ImportCSV"
                Cmd.ExecuteNonQuery()
                ' 取込データチェック
                Cmd.CommandText = "INSERT INTO T_ErrorAlert_CL ( KEYCODE, MESSAGE, CRTDT ) " &
                         "SELECT ImportCSV.ORDERITEMCD, '商品コードが商品管理コードマスタに登録されていません。登録して下さい。', Now() " &
                         "FROM (SELECT [管理番号] As ORDERITEMCD " &
                         "FROM T_ImpYahooOrd GROUP BY [管理番号] " &
                         "HAVING [管理番号] Is Not Null And [管理番号]<>'')  AS ImportCSV " &
                         "LEFT JOIN dbo_M_ConvItem ON ImportCSV.ORDERITEMCD=dbo_M_ConvItem.ORDERITEMCD " &
                         "WHERE dbo_M_ConvItem.ORDERITEMCD Is Null"
                Cmd.ExecuteNonQuery()

                If Cm.DCount("KEYCODE", "T_ErrorAlert_CL", "") > 0 Then
                    frmErrorAlertTbl.ShowDialog()
                    Exit Sub
                End If

                ' レコードセットのセット
                Cmd.Connection = Cm.Conn
                Cmd.CommandText = "SELECT * FROM T_ImpYahooOrd"
                Dta.SelectCommand = Cmd
                Dta.Fill(Dts)

                ' CSV取込みテーブルを全件ループ
                Cmd.CommandText = ""
                For i = 0 To Dts.Tables(0).Rows.Count
                    varItem(0) = Dts.Tables(0).Rows(i).Item("オークションID")
                    varItem(1) = Dts.Tables(0).Rows(i).Item("管理番号")
                    varItem(2) = Dts.Tables(0).Rows(i).Item("落札個数")
                    varItem(3) = Dts.Tables(0).Rows(i).Item("落札者メールアドレス")


                    ' 数量の数値チェック
                    If IsNumeric(Cm.Nz(varItem(2), "")) Then

                        If Cm.DCount("ORDERID", "dbo_T_StockReserv", "ORDERSTATUS = 5 And ORDERCODE = '" & varItem(0) & "' And TELNO = '" & varItem(3) & "'") = 0 Then
                            ' 引当てテーブルにデータ移行
                            Cmd.CommandText = "INSERT INTO dbo_T_StockReserv ( CRTDT, ITEMCD, ORDERID, IOKBN, DELFLG, ORDERSTATUS, RESERVQTY, " &
                                "ORDERKBN, ORDERCODE, CUSTID, ORDERDT, INCHARGE, CUSTNAME, CUSTNAMEKANA, TELNO, ZIPCODE, SENDADD1, " &
                                "SENDADD2, DESIREDMONTH, DESIREDDATE, DESIREDTIME, DLVCOMPANY, DLVSLIPNO, UPDDT, UPDIP ) " &
                                "Select Now(), T.ITEMCD, 0, 'O', 0, 5, Sum(T.TotalQty), Max(T.SHOPNAME), '" & varItem(0) & "', " &
                                "Null, Null, Null, Null, Null, '" & varItem(3) & "', Null, Null, Null, Null, Null, Null, Null, Null, Now(), '" & Cm.Nz(varIpAddress, "") & "' " &
                                "From " &
                                "(SELECT M_ConvItem.ITEMCD, CSVORD.QTY*M_ConvItem.QTY As TotalQty, CSVORD.SHOPNAME " &
                                "FROM (SELECT '" & strShopName & "' As SHOPNAME, CSV.[管理番号] AS ORDERITEMCD, Sum(CSV.[落札個数]) AS QTY " &
                                "FROM (SELECT * FROM T_ImpYahooOrd " &
                                "WHERE [オークションID] = '" & varItem(0) & "' And [落札者メールアドレス] = '" & varItem(3) & "' ) AS CSV " &
                                "GROUP BY CSV.[管理番号]) AS CSVORD " &
                                "LEFT JOIN dbo_M_ConvItem AS M_ConvItem ON CSVORD.ORDERITEMCD=M_ConvItem.ORDERITEMCD " &
                                "WHERE M_ConvItem.ITEMCD Is Not Null " &
                                ") As T " &
                                "Group By ITEMCD"
                            Cmd.ExecuteNonQuery()
                            System.Threading.Thread.Sleep(1000)
                        Else
                            '                        ' エラーテーブルに格納
                            '                        DoCmd.RunSQL "INSERT INTO T_ErrorAlert_CL ( KEYCODE, MESSAGE, CRTDT ) " & _
                            '                                     "Values('" & varItem(0) & "', '取込み済みのヤフオク受注です。確認してください。', Now())"
                        End If
                    Else
                        ' エラーテーブルに格納
                        Cmd.CommandText = "INSERT INTO T_ErrorAlert_CL ( KEYCODE, MESSAGE, CRTDT ) " &
                            "Values('" & varItem(0) & "', '受注数量が数字ではありません。確認してください。', Now())"
                        Cmd.ExecuteNonQuery()
                    End If
                Next
            End If
            If Cm.DCount("KEYCODE", "T_ErrorAlert_CL", "") > 0 Then
                frmErrorAlertTbl.ShowDialog()
            Else
                MessageBox.Show("ヤフオク受注の取込みと引当てが完了しました", "ヤフオク受注取込み", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("ヤフオク受注ファイルを選択してください", "ヤフオク受注取込み", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    ' キャンセル分取込ボタンクリック時イベント
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Dim varIpAddress As String = ""

        Dim varItem(4) As String
        Dim i As Integer

        Dim strFileName As String

        Dim Cmd As New OleDb.OleDbCommand
        Dim Dta As New OleDb.OleDbDataAdapter
        Dim Dts As New DataSet

        Cmd.Connection = Cm.Conn

        varIpAddress = Cm.DLookup("VALUE1", "M_CODE_CL", "CATEGORY = 'PREVUSER'")

        ' 確認メッセージ
        If MsgBox("対象のCSVファイル分の引当てをキャンセルします。よろしいですか？", vbOKCancel, "") = vbCancel Then
            Exit Sub
        End If

        If Trim(Cm.Nz(txtFilePath.Text, "")) <> "" Then
            strFileName = Mid(txtFilePath.Text, InStrRev(txtFilePath.Text, "\", , vbTextCompare) + 1)

            ' ファイル使用中チェック
            If FileInUse(Cm.Nz(txtFilePath.Text, "")) Then
                MessageBox.Show("取込みファイルが使用中です。閉じてから実行して下さい。", "ヤフオク受注取込み", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Len(strFileName) > 4 And Strings.Right(strFileName, 3) = "csv" Then
                ' テーブルクリア
                Cmd.CommandText = "Delete From T_ImpYahooOrd;"
                Cmd.CommandText += "Delete From T_ErrorAlert_CL;"
                Cmd.ExecuteNonQuery()

                ' CSVファイルの取込み
                Cm.ImportDBFromFile("T_ImpYahooOrd", txtFilePath.Text)

                ' 取込データチェック
                Cmd.CommandText = "INSERT INTO T_ErrorAlert_CL ( KEYCODE, MESSAGE, CRTDT ) " &
                         "SELECT ImportCSV.[オークションID], 'キャンセルに必要な情報が格納されていません。確認して下さい。', Now() " &
                         "FROM (SELECT [オークションID] From T_ImpYahooOrd " &
                         "WHERE [オークションID] Is Null Or [オークションID] = '' Or [落札者メールアドレス] Is Null Or [落札者メールアドレス] = '') As ImportCSV"
                Cmd.ExecuteNonQuery()

                If Cm.DCount("KEYCODE", "T_ErrorAlert_CL", "") > 0 Then
                    frmErrorAlertTbl.ShowDialog()
                    Exit Sub
                End If

                ' レコードセットのセット
                Cmd.Connection = Cm.Conn
                Cmd.CommandText = "SELECT * FROM T_ImpYahooOrd"
                Dta.SelectCommand = Cmd
                Dta.Fill(Dts)

                ' CSV取込みテーブルを全件ループ
                Cmd.CommandText = ""
                For i = 0 To Dts.Tables(0).Rows.Count
                    varItem(0) = Dts.Tables(0).Rows(i).Item("オークションID")
                    varItem(1) = Dts.Tables(0).Rows(i).Item("管理番号")
                    varItem(2) = Dts.Tables(0).Rows(i).Item("落札個数")
                    varItem(3) = Dts.Tables(0).Rows(i).Item("落札者メールアドレス")

                    ' 引当てテーブルから論理削除
                    Cmd.CommandText += "Update dbo_T_StockReserv Set DELFLG = 1 Where ORDERCODE = '" & varItem(0) & "' And TELNO = '" & varItem(3) & "';"
                Next
                Cmd.ExecuteNonQuery()

            End If
            If Cm.DCount("KEYCODE", "T_ErrorAlert_CL", "") > 0 Then
                frmErrorAlertTbl.ShowDialog()
            Else
                MessageBox.Show("ヤフオク受注の引当てキャンセルが完了しました。", "キャンセル取込み", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("キャンセル分ファイルを選択してください。", "ヤフオク受注取込み", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' ファイルが使用中か調べる
    Private Function FileInUse(ByVal sFilename As String) As Boolean
        Dim result As Boolean = False
        Try
            Dim fOpen As IO.FileStream = IO.File.Open(sFilename, IO.FileMode.Open, IO.FileAccess.ReadWrite, IO.FileShare.None)
            fOpen.Close()
            fOpen.Dispose()
            fOpen = Nothing
        Catch e As IO.IOException
            result = True
        End Try
        Return result
    End Function

End Class