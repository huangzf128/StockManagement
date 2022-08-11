Public Class frmItemSearch

    ' 検索ボタンクリック時イベント
    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        If Cm.Nz(txtItemCd.Text, "") <> "" Then
            ExecuteSearch(txtItemCd.Text)
        End If
    End Sub

    ' フォームロード時イベント
    Private Sub frmItemSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Cm.StrSearchItemCd <> "" Then
            txtItemCd.Text = Cm.StrSearchItemCd
            Cm.StrSearchItemCd = ""
            ExecuteSearch(txtItemCd.Text)
        End If
    End Sub


    ' 絞り込み検索実行
    Private Sub ExecuteSearch(strItemCd As String)
        Dim Cmd As New OleDb.OleDbCommand
        Dim Dta As New OleDb.OleDbDataAdapter
        Dim Dts As New DataSet

        Dim strSql As String
        strSql = "SELECT ITEM.ITEMCD, CODE1.VALUE1 AS LOCATIONNM, ACTST.ACTQTY " &
                 "FROM ((Select * From dbo_M_Item Where ITEMCD Like '*" & strItemCd & "*') As ITEM " &
                 "Left Join dbo_T_ActStock As ACTST " &
                 "ON ITEM.ITEMCD = ACTST.ITEMCD) " &
                 "LEFT JOIN (SELECT * FROM dbo_M_CODE WHERE CATEGORY='LOCATIONCD') AS CODE1 " &
                 "ON ACTST.LOCATIONCD=CODE1.CODE " &
                 "Order By ITEM.ITEMCD, ACTST.LOCATIONCD;"

        Cmd.Connection = Cm.Conn
        Cmd.CommandText = strSql
        Dta.SelectCommand = Cmd
        Dta.Fill(Dts)

        dgItems.DataSource = Dts
        dgItems.Refresh()

    End Sub
End Class