Imports System.Text

Public Class ViewManager
    Public Shared Function V_StockQty() As String
        Dim n As String = Environment.NewLine
        Dim sql As New StringBuilder

        sql.Append("( " & n)
        ' --- 第一部分：在库为主体 ---
        sql.Append("  SELECT " & n)
        sql.Append("    T.ITEMCD, T.LOCATIONCD, M_C.VALUE1 AS LOCATIONNM, T.ACTQTY, " & n)
        sql.Append("    CASE WHEN T.LOCATIONCD = '0' THEN Q.RSV_QTY ELSE NULL END AS RESERVTOTALQTY, " & n)
        sql.Append("    CASE WHEN T.LOCATIONCD = '0' THEN (T.ACTQTY - ISNULL(Q.RSV_QTY, 0)) ELSE T.ACTQTY END AS RemainQTY, " & n)
        sql.Append("    M_I.SCODE, M_I.ITEMNAME, M_I.SAFEQTY, 0 AS ActOrReserv " & n)
        sql.Append("  FROM T_ActStock T " & n)
        ' 这里直接加上 6 个月的条件
        sql.Append("  LEFT JOIN (SELECT ITEMCD, Sum(RESERVQTY) AS RSV_QTY " & n)
        sql.Append("               FROM T_StockReserv " & n)
        sql.Append("               WHERE DELFLG = 0 " & n)
        sql.Append("                 AND CRTDT >= DATEADD(MONTH, -6, GETDATE()) " & n) ' <--- 关键过滤
        sql.Append("               GROUP BY ITEMCD) Q ON T.ITEMCD = Q.ITEMCD " & n)
        sql.Append("  LEFT JOIN M_Code M_C ON T.LOCATIONCD = M_C.CODE AND M_C.CATEGORY = 'LOCATIONCD' " & n)
        sql.Append("  LEFT JOIN M_Item M_I ON T.ITEMCD = M_I.ITEMCD " & n)

        sql.Append("  UNION ALL " & n)

        ' --- 第二部分：有引当无在库 ---
        sql.Append("  SELECT " & n)
        sql.Append("    Q.ITEMCD, '0' AS LOCATIONCD, M_C.VALUE1 AS LOCATIONNM, Null As ACTQTY, " & n)
        sql.Append("    Q.RSV_QTY AS RESERVTOTALQTY, (Q.RSV_QTY * -1) AS RemainQTY, " & n)
        sql.Append("    M_I.SCODE, M_I.ITEMNAME, M_I.SAFEQTY, 1 AS ActOrReserv " & n)
        ' 这里的预约汇总也要加同样的过滤，确保计算逻辑统一
        sql.Append("  FROM (SELECT ITEMCD, Sum(RESERVQTY) AS RSV_QTY " & n)
        sql.Append("          FROM T_StockReserv " & n)
        sql.Append("          WHERE DELFLG = 0 " & n)
        sql.Append("            AND CRTDT >= DATEADD(MONTH, -6, GETDATE()) " & n) ' <--- 关键过滤
        sql.Append("          GROUP BY ITEMCD) Q " & n)
        sql.Append("  LEFT JOIN T_ActStock T ON Q.ITEMCD = T.ITEMCD AND T.LOCATIONCD = '0' " & n)
        sql.Append("  LEFT JOIN M_Code M_C ON M_C.CODE = '0' AND M_C.CATEGORY = 'LOCATIONCD' " & n)
        sql.Append("  LEFT JOIN M_Item M_I ON Q.ITEMCD = M_I.ITEMCD " & n)
        sql.Append("  WHERE T.ITEMCD IS NULL " & n)
        sql.Append(") ")

        Return sql.ToString()
    End Function

End Class
