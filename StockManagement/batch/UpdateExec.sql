USE STOCKDB;
SET QUOTED_IDENTIFIER ON;
GO

/* ---------------------------------------------------------------------------
    1. 排他制御（二重起動防止）
--------------------------------------------------------------------------- */
PRINT '●ロックテーブルチェック開始';

-- LOCKSTが0の場合のみ1に更新し、処理権限を取得する
UPDATE dbo.T_Lock 
SET UPDDT = GETDATE(), LOCKST = 1, UPDIP = '192.168.1.101'
WHERE LOCKST = 0;

-- 更新件数が0件の場合、既に他のプロセスが実行中と判断し終了する
IF @@ROWCOUNT = 0
BEGIN
    PRINT '【警告】別のバッチプロセスが実行中です。処理を中断します。';
    RETURN; 
END


/* トランザクション開始 */
PRINT '◆トランザクション開始';
BEGIN TRANSACTION
GO

BEGIN TRY

/* エラー情報格納テーブルクリア */
PRINT '●エラー情報格納テーブルクリア';
Delete From dbo.T_ErrorAlert;
PRINT ' 更新件数=' + CAST(@@ROWCOUNT AS VARCHAR) + '件削除しました';

/* 受注情報で変換商品名マスタに登録されていない商品コードチェック */
PRINT '●商品コードチェック';
Insert Into dbo.T_ErrorAlert(KEYCODE,MESSAGE,CRTDT) 
SELECT 
Distinct RECVDAT.商品CODE, 
'商品管理コードが商品管理コードマスタに登録されていません。登録して下さい。', 
GETDATE() 
FROM 
(Select * From JPONDATA.dbo.ORDERDAT Where (状況 = '確定' Or 状況 = '完了後クレカ待ち' Or 状況 = '欠品連絡中' Or 状況 = '入金待ち' Or 状況 = '入金不足' Or 状況 = 'チャータ発送待ち') And OrderDate > '2018/02/01' And OrderDate > DATEADD(day, -360, GETDATE())) As ORDERDAT 
LEFT JOIN JPONDATA.dbo.RECVDAT As RECVDAT 
 ON ORDERDAT.ID = RECVDAT.ID 
LEFT JOIN dbo.M_ConvItem As M_ConvItem 
 ON RECVDAT.商品CODE = M_ConvItem.ORDERITEMCD 
LEFT JOIN (Select ORDERID From dbo.T_StockReserv) As T_StockReserv 
 ON ORDERDAT.ID = T_StockReserv.ORDERID 
Where RECVDAT.商品CODE Is Not Null And M_ConvItem.ITEMCD Is Null And RECVDAT.ID Is Not Null And T_StockReserv.ORDERID Is Null;
PRINT ' 更新件数=' + CAST(@@ROWCOUNT AS VARCHAR) + '件追加しました';

/* 商品管理コードマスタ⇒変換商品名マスタの変更商品名存在チェック */
PRINT '●変換商品名マスタチェック';
Insert Into dbo.T_ErrorAlert(KEYCODE,MESSAGE,CRTDT) 
Select Distinct M_ConvItem.ITEMCD, '受注商品コードが変換商品名マスタに登録されていません。登録して下さい。', GETDATE() 
From dbo.M_ConvItem 
Left Join dbo.M_Item 
 ON M_ConvItem.ITEMCD = M_Item.ITEMCD 
Where M_ConvItem.ITEMCD Is Not Null And M_Item.ITEMCD Is Null;
PRINT ' 更新件数=' + CAST(@@ROWCOUNT AS VARCHAR) + '件追加しました';


/* 受注情報自動引当 */
PRINT '●受注情報自動引当';
INSERT INTO dbo.T_StockReserv (
    CRTDT, ITEMCD, ORDERID, IOKBN, DELFLG, ORDERSTATUS, RESERVQTY,
    ORDERKBN, ORDERCODE, CUSTID, ORDERDT, INCHARGE, CUSTNAME,
    CUSTNAMEKANA, TELNO, ZIPCODE, SENDADD1, SENDADD2,
    DESIREDMONTH, DESIREDDATE, DESIREDTIME, DLVCOMPANY, DLVSLIPNO,
    UPDDT, UPDIP
)
SELECT
    CRTDT, ITEMCD, ORDERID,
    MAX(IOKBN), MAX(DELFLG), MAX(ORDERSTATUS), SUM(RESERVQTY),
    MAX(ORDERKBN), MAX(ORDERCODE), MAX(CUSTID), MAX(ORDERDT),
    MAX(INCHARGE), MAX(CUSTNAME), MAX(CUSTNAMEKANA), MAX(TELNO),
    MAX(ZIPCODE), MAX(SENDADD1), MAX(SENDADD2), MAX(DESIREDMONTH),
    MAX(DESIREDDATE), MAX(DESIREDTIME), MAX(DLVCOMPANY), MAX(DLVSLIPNO),
    MAX(UPDDT), MAX(UPDIP)
FROM (
    SELECT
        GETDATE() AS CRTDT,
        M_ConvItem.ITEMCD,
        ORDERDAT.ID AS ORDERID,
        'O' AS IOKBN,            -- 出庫区分：Order
        0 AS DELFLG,             -- 削除フラグ：有効
        -- 入金ステータスの判定ロジック
        CASE
            WHEN ORDERDAT.お支払い IN ('クレジットカード', '代金引換', 'Yahoo!マネー/預金払い') THEN 1 -- 即時出荷可
            WHEN ORDERDAT.請求額 <= ORDERDAT.入金額 THEN 1 -- 入金済み
            ELSE 2 -- 未入金・入金不足
        END AS ORDERSTATUS,
        SUM(RECVDAT.合計数量) * M_ConvItem.QTY AS RESERVQTY, -- 引当数量計算
        ORDERDAT.分類2 AS ORDERKBN,
        ORDERDAT.JID AS ORDERCODE,
        ORDERDAT.顧客CODE AS CUSTID,
        ORDERDAT.OrderDate AS ORDERDT,
        ORDERDAT.担当者 AS INCHARGE,
        ORDERDAT.お名前 AS CUSTNAME,
        ORDERDAT.フリガナ AS CUSTNAMEKANA,
        ORDERDAT.電話番号 AS TELNO,
        ORDERDAT.郵便番号 AS ZIPCODE,
        ORDERDAT.ご住所 AS SENDADD1,
        ORDERDAT.ご住所2 AS SENDADD2,
        ORDERDAT.配送希望月 AS DESIREDMONTH,
        ORDERDAT.配送希望日 AS DESIREDDATE,
        ORDERDAT.お届け時間帯 AS DESIREDTIME,
        ORDERDAT.配送業者 AS DLVCOMPANY,
        ORDERDAT.配送伝票 AS DLVSLIPNO,
        GETDATE() AS UPDDT,
        '192.168.1.101' AS UPDIP
    FROM JPONDATA.dbo.ORDERDAT AS ORDERDAT
    
    -- 1. 受注詳細データとの結合（事前に商品コードごとに数量を集計し、行数膨張を防ぐ）
    INNER JOIN (
        SELECT ID, 商品CODE, SUM(数量) AS 合計数量
        FROM JPONDATA.dbo.RECVDAT
        GROUP BY ID, 商品CODE
    ) AS RECVDAT ON ORDERDAT.ID = RECVDAT.ID
    
    -- 2. 商品変換マスタとの結合（INNER JOINにすることで、マスタ未登録の商品は自動的に除外）
    INNER JOIN dbo.M_ConvItem AS M_ConvItem ON RECVDAT.商品CODE = M_ConvItem.ORDERITEMCD
    
    -- 3. Yahoo連携済データのチェック用結合
    LEFT JOIN (
        SELECT 受注ID, MAX(メッセージ1) AS YAHOOID FROM JPONDATA.dbo.MSメッセージ GROUP BY 受注ID
    ) AS ORDERMSG ON ORDERDAT.ID = ORDERMSG.受注ID
    LEFT JOIN dbo.T_StockReserv AS T_SR2 ON ORDERMSG.YAHOOID = T_SR2.ORDERCODE 
        AND ORDERDAT.メールアドレス = T_SR2.TELNO AND T_SR2.ORDERSTATUS = 5

    WHERE 
        -- A. 【受注条件】 対象となるステータスと期間の絞り込み
        ORDERDAT.状況 IN ('確定', '完了後クレカ待ち', '欠品連絡中', '入金待ち', '入金不足', 'チャータ発送待ち')
        AND ORDERDAT.OrderDate > '2018/02/01'
        AND ORDERDAT.OrderDate > DATEADD(day, -360, GETDATE())
        
        -- B. 【不備データ除外】 注文明細の中に「マスタ未登録の商品(NULL)」が1つでもあれば、注文ごと除外する
        -- （旧SQLの ERRORD サブクエリと同等のロジックを高速化）
        AND NOT EXISTS (
            SELECT 1 
            FROM JPONDATA.dbo.RECVDAT AS R_SUB
            LEFT JOIN dbo.M_ConvItem AS M_SUB ON R_SUB.商品CODE = M_SUB.ORDERITEMCD
            WHERE R_SUB.ID = ORDERDAT.ID 
              AND M_SUB.ITEMCD IS NULL
        )

        -- C. 【除外条件】 クーポン商品は引当対象外とする
        AND M_ConvItem.ITEMCD <> 'coupon'
        AND M_ConvItem.ITEMCD IS NOT NULL

        -- D. 【重複防止】 既に引当テーブル(T_StockReserv)に存在する注文は除外
        AND NOT EXISTS (SELECT 1 FROM dbo.T_StockReserv AS T_SR1 WHERE T_SR1.ORDERID = ORDERDAT.ID)
        
        -- E. 【Yahoo連携除外】 Yahoo側で処理済みの注文は除外
        AND T_SR2.ORDERCODE IS NULL

    GROUP BY 
        M_ConvItem.ITEMCD, ORDERDAT.ID, ORDERDAT.お支払い, ORDERDAT.請求額, ORDERDAT.入金額,
        M_ConvItem.QTY, ORDERDAT.分類2, ORDERDAT.JID, ORDERDAT.顧客CODE, ORDERDAT.OrderDate,
        ORDERDAT.担当者, ORDERDAT.お名前, ORDERDAT.フリガナ, ORDERDAT.電話番号, ORDERDAT.郵便番号,
        ORDERDAT.ご住所, ORDERDAT.ご住所2, ORDERDAT.配送希望月, ORDERDAT.配送希望日, 
        ORDERDAT.お届け時間帯, 
        ORDERDAT.配送業者, ORDERDAT.配送伝票
) AS T
GROUP BY CRTDT, ITEMCD, ORDERID;

PRINT ' 更新件数=' + CAST(@@ROWCOUNT AS VARCHAR) + '件追加しました';

/* 満額未入金受注から満額入金に変更分の引当て情報更新 */
/*
PRINT '●満額入金に変更分の引当て情報更新';
UPDATE TR 
Set ORDERSTATUS = 1, UPDDT = GETDATE(), UPDIP = '192.168.1.101' 
FROM dbo.T_StockReserv AS TR 
INNER JOIN (Select CRTDT, ITEMCD, ORDERID From dbo.T_StockReserv Where DELFLG = 0 And ORDERSTATUS = 2) AS T 
 ON TR.CRTDT = T.CRTDT And TR.ITEMCD = T.ITEMCD And TR.ORDERID = T.ORDERID 
INNER JOIN (Select Distinct ID From JPONDATA.dbo.ORDERDAT Where (状況 = '確定' Or 状況 = '完了後クレカ待ち' Or 状況 = '欠品連絡中' Or 状況 = '入金待ち' Or 状況 = '入金不足') And 請求額 <= 入金額 And OrderDate > '2018/02/01' And OrderDate > DATEADD(day, -360, GETDATE())) As T1 
 ON T.ORDERID = T1.ID;
PRINT ' 更新件数=' + CAST(@@ROWCOUNT AS VARCHAR) + '件更新しました';
*/

/* 引当てより7日経過分の満額未入金受注の引当て情報論理削除 */
/*
PRINT '●7日経過分の満額未入金受注の引当て情報論理削除';
UPDATE TR 
Set DELFLG = 1, UPDDT = GETDATE(), UPDIP = '192.168.1.101' 
FROM dbo.T_StockReserv AS TR 
INNER JOIN (Select CRTDT, ITEMCD, ORDERID From dbo.T_StockReserv Where DELFLG = 0 And ORDERSTATUS = 2 And DATEADD(day, 7, CRTDT) < GETDATE()) AS T 
 ON TR.CRTDT = T.CRTDT And TR.ITEMCD = T.ITEMCD And TR.ORDERID = T.ORDERID;
PRINT ' 更新件数=' + CAST(@@ROWCOUNT AS VARCHAR) + '件更新しました';
*/

/* キャンセルに変更分の引当て情報論理削除 */
PRINT '●キャンセルに変更分の引当て情報論理削除';
UPDATE TR 
Set DELFLG = 1, UPDDT = GETDATE(), UPDIP = '192.168.1.101' 
FROM dbo.T_StockReserv AS TR 
INNER JOIN (Select CRTDT, ITEMCD, ORDERID From dbo.T_StockReserv Where DELFLG = 0) AS T 
 ON TR.CRTDT = T.CRTDT And TR.ITEMCD = T.ITEMCD And TR.ORDERID = T.ORDERID 
INNER JOIN (Select Distinct ID From JPONDATA.dbo.ORDERDAT Where (状況 = 'キャンセル' Or 状況 = 'ブラックリスト' Or 状況 = '長期保留' Or 受注FLG = 1) And OrderDate > '2018/02/01' And OrderDate > DATEADD(day, -360, GETDATE())) As T1 
 ON T.ORDERID = T1.ID;
PRINT ' 更新件数=' + CAST(@@ROWCOUNT AS VARCHAR) + '件更新しました';


/* ----------------------------------
    受注変更分の引当て情報更新 
 ----------------------------------*/
PRINT '●受注変更分の引当て情報更新';
UPDATE TR 
Set ORDERSTATUS = 4, UPDDT = GETDATE(), UPDIP = '192.168.1.101' 
FROM dbo.T_StockReserv AS TR 
INNER JOIN (
	Select BASE.CRTDT, BASE.ORDERID 
	From 
	(select T.CRTDT, T.ORDERID, 
	    ( select ''+X.ITEMCD
	        from dbo.T_StockReserv as X
	        where X.ORDERID=T.ORDERID
	          AND X.ITEMCD <> 'coupon' -- ★ 【除外条件】 クーポン商品は引当対象外とする
			  AND X.DELFLG = 0   -- ★ 必?
	        order by X.ITEMCD
	        for xml path(''),type).value('.','nvarchar(max)'
	    ) as GPITEMCD 
	from (Select CRTDT, ITEMCD, ORDERID From dbo.T_StockReserv Where DELFLG = 0 And ORDERID != 0) as T
	group by CRTDT, ORDERID) As BASE 
	Inner Join 
	(Select T.ID, 
	 (select ''+X.ITEMCD
	  from (Select T1.ID, M_ConvItem.ITEMCD 
	        From (Select Distinct ID From JPONDATA.dbo.ORDERDAT 
	              Where (状況 = '確定' Or 状況 = '完了後クレカ待ち' Or 状況 = '欠品連絡中' Or 状況 = '入金待ち' Or 状況 = '入金不足' Or 状況 = 'チャータ発送待ち') And OrderDate > '2018/02/01' And OrderDate > DATEADD(day, -360, GETDATE())
	              And ID In (Select ORDERID From dbo.T_StockReserv Where DELFLG = 0)) As T1 
	              LEFT JOIN (Select ID, 商品CODE, Sum(数量) As 合計数量 From JPONDATA.dbo.RECVDAT Group By ID, 商品CODE) As RECVDAT 
	               ON T1.ID = RECVDAT.ID 
	              LEFT JOIN dbo.M_ConvItem As M_ConvItem 
	               ON RECVDAT.商品CODE = M_ConvItem.ORDERITEMCD 
	              WHERE M_ConvItem.ITEMCD <> 'coupon' -- ★ 【除外条件】 クーポン商品は引当対象外とする
	        ) as X
	   where X.ID=T.ID
	   order by X.ITEMCD
	   for xml path(''),type).value('.','nvarchar(max)'
	 ) as GPITEMCD 
	 From 
	 (Select T1.ID, M_ConvItem.ITEMCD 
	 From (Select Distinct ID From JPONDATA.dbo.ORDERDAT 
	  Where (状況 = '確定' Or 状況 = '完了後クレカ待ち' Or 状況 = '欠品連絡中' Or 状況 = '入金待ち' Or 状況 = '入金不足' Or 状況 = 'チャータ発送待ち') And OrderDate > '2018/02/01' And OrderDate > DATEADD(day, -360, GETDATE())
	  And ID In (Select ORDERID From dbo.T_StockReserv Where DELFLG = 0)) As T1 
	 LEFT JOIN (Select ID, 商品CODE, Sum(数量) As 合計数量 From JPONDATA.dbo.RECVDAT Group By ID, 商品CODE) As RECVDAT 
	  ON T1.ID = RECVDAT.ID 
	 LEFT JOIN dbo.M_ConvItem As M_ConvItem 
	  ON RECVDAT.商品CODE = M_ConvItem.ORDERITEMCD 
	 WHERE M_ConvItem.ITEMCD <> 'coupon' -- ★ 【除外条件】 クーポン商品は引当対象外とする
	 ) As T 
	 Group By ID) As BASE2
	On BASE.ORDERID = BASE2.ID 
	Where BASE.GPITEMCD != BASE2.GPITEMCD 
) AS MT 
 ON TR.CRTDT = MT.CRTDT And TR.ORDERID = MT.ORDERID;
PRINT ' 更新件数=' + CAST(@@ROWCOUNT AS VARCHAR) + '件更新しました';


/* 変更受注情報再引当 */
PRINT '●変更受注情報再引当';
INSERT INTO dbo.T_StockReserv(CRTDT,ITEMCD,ORDERID,IOKBN,DELFLG,ORDERSTATUS,RESERVQTY,ORDERKBN,ORDERCODE,CUSTID,ORDERDT,INCHARGE,CUSTNAME,CUSTNAMEKANA,TELNO,ZIPCODE,SENDADD1,SENDADD2,DESIREDMONTH,DESIREDDATE,DESIREDTIME,DLVCOMPANY,DLVSLIPNO,UPDDT,UPDIP) 
SELECT CRTDT,ITEMCD,ORDERID,MAX(IOKBN),MAX(DELFLG),MAX(ORDERSTATUS),SUM(RESERVQTY),MAX(ORDERKBN),MAX(ORDERCODE),MAX(CUSTID),MAX(ORDERDT),MAX(INCHARGE),MAX(CUSTNAME),MAX(CUSTNAMEKANA),MAX(TELNO),MAX(ZIPCODE),MAX(SENDADD1),MAX(SENDADD2),MAX(DESIREDMONTH),MAX(DESIREDDATE),MAX(DESIREDTIME),MAX(DLVCOMPANY),MAX(DLVSLIPNO),MAX(UPDDT),MAX(UPDIP) 
FROM 
(SELECT 
    GETDATE() AS CRTDT, 
    M_ConvItem.ITEMCD, 
    ORDERDAT.ID AS ORDERID, 
    'O' AS IOKBN, 
    0 AS DELFLG, 
    CASE
      WHEN ORDERDAT.お支払い = 'クレジットカード' OR ORDERDAT.お支払い = '代金引換' OR ORDERDAT.お支払い = 'Yahoo!マネー/預金払い' THEN 1 
      WHEN ORDERDAT.請求額 <= ORDERDAT.入金額 THEN 1 
      WHEN ORDERDAT.請求額 >= ORDERDAT.入金額 THEN 2 
      ELSE 2 
    END AS ORDERSTATUS, 
    SUM(RECVDAT.合計数量) * M_ConvItem.QTY AS RESERVQTY, 
    ORDERDAT.分類2 AS ORDERKBN, 
    ORDERDAT.JID AS ORDERCODE, 
    ORDERDAT.顧客CODE AS CUSTID, 
    ORDERDAT.OrderDate AS ORDERDT, 
    ORDERDAT.担当者 AS INCHARGE, 
    ORDERDAT.お名前 AS CUSTNAME, 
    ORDERDAT.フリガナ AS CUSTNAMEKANA, 
    ORDERDAT.電話番号 AS TELNO, 
    ORDERDAT.郵便番号 AS ZIPCODE, 
    ORDERDAT.ご住所 AS SENDADD1, 
    ORDERDAT.ご住所2 AS SENDADD2, 
    ORDERDAT.配送希望月 AS DESIREDMONTH, 
    ORDERDAT.配送希望日 AS DESIREDDATE, 
    ORDERDAT.お届け時間帯 AS DESIREDTIME, 
    ORDERDAT.配送業者 AS DLVCOMPANY, 
    ORDERDAT.配送伝票 AS DLVSLIPNO, 
    GETDATE() AS UPDDT, 
    '192.168.1.101' AS UPDIP 
FROM 
    (SELECT ORDERID FROM (SELECT ORDERID FROM dbo.T_StockReserv WHERE DELFLG = 0 AND ORDERSTATUS = 4) AS T GROUP BY ORDERID) AS T_StockReserv 
INNER JOIN 
    (SELECT * FROM JPONDATA.dbo.ORDERDAT WHERE (状況 = '確定' OR 状況 = '完了後クレカ待ち' OR 状況 = '欠品連絡中' OR 状況 = '入金待ち' OR 状況 = '入金不足' OR 状況 = 'チャータ発送待ち') AND OrderDate > '2018/02/01' AND OrderDate > DATEADD(DAY, -360, GETDATE())) AS ORDERDAT 
     ON T_StockReserv.ORDERID = ORDERDAT.ID 
LEFT JOIN (SELECT ID, 商品CODE, SUM(数量) AS 合計数量 FROM JPONDATA.dbo.RECVDAT GROUP BY ID, 商品CODE) AS RECVDAT 
     ON ORDERDAT.ID = RECVDAT.ID 
LEFT JOIN dbo.M_ConvItem AS M_ConvItem 
     ON RECVDAT.商品CODE = M_ConvItem.ORDERITEMCD 
GROUP BY M_ConvItem.ITEMCD, ORDERDAT.ID, ORDERDAT.お支払い, ORDERDAT.請求額, ORDERDAT.入金額, M_ConvItem.QTY, 
 ORDERDAT.分類2, ORDERDAT.JID, ORDERDAT.顧客CODE, ORDERDAT.OrderDate, ORDERDAT.担当者, ORDERDAT.お名前, 
 ORDERDAT.フリガナ, ORDERDAT.電話番号, ORDERDAT.郵便番号, ORDERDAT.ご住所, ORDERDAT.ご住所2, ORDERDAT.配送希望月, 
 ORDERDAT.配送希望日, ORDERDAT.お届け時間帯, ORDERDAT.配送業者, ORDERDAT.配送伝票, T_StockReserv.ORDERID 
HAVING M_ConvItem.ITEMCD IS NOT NULL 
   AND M_ConvItem.ITEMCD <> 'coupon' -- ★【除外条件】 クーポン商品は引当対象外とする
) AS T GROUP BY CRTDT, ITEMCD, ORDERID;
PRINT ' 更新件数=' + CAST(@@ROWCOUNT AS VARCHAR) + '件追加しました';

PRINT '●変更前受注引当情報論理削除';
Update dbo.T_StockReserv Set DELFLG = 1, UPDDT = GETDATE(), UPDIP = '192.168.1.101' 
Where DELFLG = 0 And ORDERSTATUS = 4;
PRINT ' 更新件数=' + CAST(@@ROWCOUNT AS VARCHAR) + '件更新しました';


/* 最終バッチ実行日時更新 */
UPDATE dbo.M_Code 
Set VALUE1 = CONVERT(VARCHAR, GETDATE(), 111) + ' ' + CONVERT(VARCHAR, GETDATE(), 108)  
WHERE CATEGORY = 'LASTBATDT';

 /* コミット */
PRINT '◆トランザクションコミット';
 COMMIT TRANSACTION;
END TRY
BEGIN CATCH
 PRINT ERROR_MESSAGE();
 /* ロールバック */
PRINT '◆トランザクションロールバック';
 ROLLBACK TRANSACTION;
END CATCH
GO

/* ロックテーブル解除 */
PRINT '●ロックテーブル解除';
Update dbo.T_Lock Set UPDDT = GETDATE(), LOCKST = 0, UPDIP = '192.168.1.101';


