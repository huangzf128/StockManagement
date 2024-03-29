﻿SELECT Q_ReservSummary.* ,
	M_Code.VALUE1 AS LOCATIONNM, 
	M_Item.SCODE, 
	M_Item.ITEMNAME, 
    M_Item.SAFEQTY
FROM

(SELECT T_ActStock.ITEMCD, T_ActStock.LOCATIONCD, T_ActStock.ACTQTY, 
		IIf(T_ActStock.LOCATIONCD = '0', Q_ReservSummary.RESERVTOTALQTY, NULL) AS RESERVTOTALQTY, 
		IIf(T_ActStock.LOCATIONCD = '0', (T_ActStock.ACTQTY - IIf(Q_ReservSummary.RESERVTOTALQTY IS NULL, 0, Q_ReservSummary.RESERVTOTALQTY)), T_ActStock.ACTQTY) AS RemainQTY,  
		0 AS ActOrReserv
FROM      T_ActStock 
LEFT JOIN
        (SELECT   ITEMCD, Sum(RESERVQTY) AS RESERVTOTALQTY
            FROM      T_StockReserv
            WHERE   DELFLG = 0
            GROUP BY ITEMCD) AS Q_ReservSummary 
        ON T_ActStock.ITEMCD = Q_ReservSummary.ITEMCD 

UNION ALL

SELECT  Q_ReservSummary.ITEMCD, Q_ReservSummary.LOCATIONCD,  NULL AS ACTQTY, 
        Q_ReservSummary.RESERVTOTALQTY AS RESERVTOTALQTY, 
        Q_ReservSummary.RESERVTOTALQTY * - 1 AS RemainQTY, 
        1 AS ActOrReserv
FROM      
(SELECT   '0' AS LOCATIONCD, ITEMCD, Sum(RESERVQTY) AS RESERVTOTALQTY
    FROM      T_StockReserv
    WHERE   DELFLG = 0
    GROUP BY ITEMCD) AS Q_ReservSummary 

LEFT JOIN T_ActStock AS T_ActStock 
    ON Q_ReservSummary.ITEMCD = T_ActStock.ITEMCD AND T_ActStock.LOCATIONCD = '0' 


WHERE   T_ActStock.ITEMCD IS NULL) as Q_ReservSummary

LEFT JOIN M_Code AS M_Code ON Q_ReservSummary.LOCATIONCD = M_Code.CODE AND M_Code.CATEGORY = 'LOCATIONCD' 
LEFT JOIN M_Item AS M_Item ON Q_ReservSummary.ITEMCD = M_Item.ITEMCD