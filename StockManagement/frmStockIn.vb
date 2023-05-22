Imports System.Data.SqlClient
Imports System.Text

Public Class FrmStockIn

    Protected Overrides Function processName()
        Return "入庫処理"
    End Function


    Private Sub FrmStockIn_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.pnlCondition.BackColor = Color.Transparent
        Me.BackgroundImage = My.Resources.ResourceManager.GetObject("Dark_Green")
    End Sub

    Protected Overrides Function getSqlAndParamStockHistory(row As DataRow) As DbParamEnt
        Dim sb As New StringBuilder
        sb.Append(" Insert Into    ")
        sb.Append("   T_StockHistory(CRTDT, ITEMCD, LOCATIONCD, IOKBN, QTY, REMARKS, UPDIP) ")
        sb.Append(" Values (  GETDATE(), @ITEMCD, @LOCATIONCD, 'I', @QTY, @REMARKS, @UPDIP )")

        Dim param As New List(Of SqlParameter)
        param.Add(New SqlParameter("@ITEMCD", row("ITEMCD")))
        param.Add(New SqlParameter("@LOCATIONCD", row("LOCATIONCD")))
        param.Add(New SqlParameter("@QTY", row("QTY")))
        param.Add(New SqlParameter("@REMARKS", row("REMARKS")))
        param.Add(New SqlParameter("@UPDIP", Util.getPcName()))

        Return New DbParamEnt(sb, param.ToArray)

    End Function


    Protected Overrides Function getSqlAndParamActStock(row As DataRow) As DbParamEnt
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
        sb.Append("      ACTQTY = ACTQTY + DATA.QTY ")
        sb.Append("     ,UPDDT = GETDATE() ")
        sb.Append(" WHEN NOT MATCHED BY Target THEN ")
        sb.Append("   INSERT (ITEMCD, LOCATIONCD, ACTQTY, UPDDT) ")
        sb.Append("   VALUES (DATA.ITEMCD, DATA.LOCATIONCD, DATA.QTY, GETDATE());")

        Dim param As New List(Of SqlParameter)
        param.Add(New SqlParameter("@ITEMCD", row("ITEMCD")))
        param.Add(New SqlParameter("@LOCATIONCD", row("LOCATIONCD")))
        param.Add(New SqlParameter("@QTY", row("QTY")))

        Return New DbParamEnt(sb, param.ToArray)
    End Function


End Class