-- phpMyAdmin SQL Dump
-- version 3.4.10.1deb1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: May 22, 2015 at 04:33 PM
-- Server version: 5.5.37
-- PHP Version: 5.3.10-1ubuntu3.11

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `dbcihvbox`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`feap`@`%` PROCEDURE `FPO_Insert`(
IN OB_Line varchar(150),
IN Supplier varchar(50),
IN VCode varchar(150),
IN MOrdered date,
IN DDate date,
IN Stat varchar(15),
IN Currency varchar(5),
IN Discount decimal(65,6),
IN DAmount decimal(65,6),
IN TPO decimal(65,6),
IN POAmt decimal(65,6),
IN Remarks varchar(500),
IN Signature varchar(150)
)
begin
INSERT INTO `tblPO`( `OB_Line`, `fldSupplier`, `fldVCode`, `fldMOrdered`,`fldDDate`, 
`fldStat`, `fldCurrency`, `fldDiscount`, `fldDAmount`, `fldTPO`, `OB_POAmt`, `fldRemarks`, `fldSignature`) 
VALUES(OB_Line,Supplier,VCode,MOrdered,DDate,Stat,Currency,Discount,DAmount,TPO,POAmt,Remarks,Signature);
end$$

CREATE DEFINER=`feap`@`%` PROCEDURE `FPO_InsertItem`(
QTYSOut decimal(65,6),
OB_Detail_ID int,
MOIID int,
OB_Line varchar(150),
TransCode varchar(150),
BudRefNum varchar(30),
PRNo varchar(150),
ICode varchar(40),
FDesc varchar(40),
QTY decimal(65,6),
Unit varchar(3),
Stat varchar(50),
UID int,
MO date,
Signature varchar(150),
UPrice decimal(65,6),
TotalCost decimal(65,6),
Currency varchar(15),
MonthDelivery date,
Dept varchar(150),
Class varchar(50))
begin
INSERT INTO tblPOI(fldQTYSOut ,OB_Detail_ID, fldMOIID, OB_Line,fldTransCode,
 fldBudRefNum,fldPRNo, fldICode, fldDesc, fldQTY, 
fldUnit, fldStat,fldUID, fldMO,fldSignature,
fldUPrice, fldTotalCost, fldCurrency, fldMonthDelivery, fldDept,
 fldClass)
values
(QTYSOut,OB_Detail_ID,MOIID,OB_Line,TransCode,
BudRefNum,PRNo,ICode,FDesc,QTY,
Unit,Stat,UID,MO,Signature,
UPrice,TotalCost,Currency,MonthDelivery,Dept,
fldClass);
end$$

CREATE DEFINER=`feap`@`%` PROCEDURE `PR_Insert`(
	IN pryear varchar(100),
	IN TC varchar(200),
	IN dept varchar(200)
)
BEGIN
INSERT INTO tblPRNo(fldYear, fldTransCode, fldDept)
 VALUES (pryear,TC,dept);
END$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_AA`(
	IN D1    datetime,
	IN D2    datetime,
	IN DEPT   varchar(150),
	IN Class varchar(150)
)
BEGIN
SELECT 
Year(T2.DocDate) as 'Byear',
T1.U_Detail_ID, 
T1.U_BudgetRef, 
T2.U_HeaderID, 
T2.DocNum AS 'Purch-Ord', 
T2.DocDate AS 'Ord-Date', 
T2.CardCode AS 'Vend-Num', 
T1.ItemCode AS 'Product', 
T1.LineStatus AS 'Row-Stat', 
T1.Quantity AS 'Quantity', 
T1.OpenQty AS 'Open-Qty', 
T4.DocNum AS 'Goods-Rcpt', 
T4.DocDueDate AS 'Rcpt-Date', 
T3.Quantity as 'GRPO_QTY',
(SELECT group_concat(POI.fldPRNo) from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE') as 'PRNO', 
(SELECT bud.fldDept from tblBudget bud where bud.fldBudRefNum = T1.U_BudgetRef) as 'Dept', 
(SELECT POI.fldSignature from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE') as 'fldSignature', 
(SELECT POI.fldTotalCost from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE') as 'fldTotalCost', 
(SELECT POI.fldCurrency from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE') as 'fldCurrency', 
(SELECT POI.fldYen from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE') as 'fldYen', 
(SELECT TPO.fldSupplier from tblPO TPO where TPO.OB_Line = T2.U_HeaderID and TPO.fldStat != 'CLOSE') as 'fldSup', 
(SELECT POI.fldDesc from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE') as 'fldDesc',
(SELECT POI.fldClass from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE') as 'fldClass',
(SELECT TPO.fldRemarks from tblPO TPO where TPO.OB_Line = T2.U_HeaderID and TPO.fldStat != 'CLOSE') as 'fldRemarks',
(SELECT POI.fldSignature from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE') as 'fldSignature'
FROM POR1 T1 
LEFT OUTER JOIN OPOR T2 
ON T1.DocEntry = T2.DocEntry 
LEFT OUTER JOIN PDN1 T3 
ON T2.DocEntry = T3.BaseEntry 
AND T1.LineNum = T3.BaseLine 
AND T1.ItemCode = T3.ItemCode 
LEFT OUTER JOIN OPDN T4 
ON T3.DocEntry = T4.DocEntry 
LEFT OUTER JOIN RPD1 T5 
ON T4.DocEntry = T5.BaseEntry 
AND T3.LineNum = T5.BaseLine 
AND T3.ItemCode = T5.ItemCode 
LEFT OUTER JOIN ORPD T6 
ON T5.DocEntry = T6.DocEntry 
LEFT OUTER JOIN PCH1 T7 
ON T4.DocEntry = T7.BaseEntry 
AND T3.LineNum = T7.BaseLine 
AND T3.ItemCode = T7.ItemCode 
LEFT OUTER JOIN OPCH T8 
ON T7.DocEntry = T8.DocEntry 
LEFT OUTER JOIN RPC1 T9 
ON T8.DocEntry = T9.BaseEntry 
AND T7.LineNum = T9.BaseLine 
AND T7.ItemCode = T9.ItemCode 
LEFT OUTER JOIN ORPC T10 
ON T9.DocEntry = T10.DocEntry 
WHERE T2.U_HeaderID Is Not null 
and T6.DocNum is null 
and T10.DocNum is null 
and T4.DocNum is not null 
and
T2.DocDate >= D1 and T2.DocDate <= D2 
and
if(DEPT = 'ALL',
INSTR( ',' + T1.U_BudgetRef + ',', ',' + (select group_concat(fldDeptCode) as fldDeptCode from tblDepartment ) + ',' ) > 0, T1.U_BudgetRef = DEPT)
and
if(Class = 'ALL',
INSTR( ',' + (SELECT POI.fldClass from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE') + ',', ',' + (select group_concat(fldClassDesc) as fldClassDesc from tblClass) + ',' ) > 0,(SELECT POI.fldClass from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID) = Class and POI.fldStat != 'CLOSE');
END$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_AAItems`(
	IN TC222  VARCHAR(150)
)
BEGIN
SELECT tr3.fldTransCode, tr3.fldUOM,tr3.fldAACode,tr3.fldBudRefNum,tr3.fldPONo,tr3.fldPRNo,tr3.fldMonthAcquired
,tr3.fldOrderSupplier,tr3.fldOrderDesc,tr3.fldClassification,tr3.fldOrderDepartment,
(if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMAI tr4 where tr4.fldTransCode = tr3.fldTransCode),tr3.fldAmountJPY)) as 'fldAmountJPY'
,(if(tr3.fldTransCode is not null,(select sum(tr4.fldQTY) from tblMOI tr4 where tr4.fldTransCode = tr3.fldTransCode),tr3.fldQTY)) as 'fldQTY',
tr3.fldOrderRemarks,tr3.fldCurrenkcy,year(tr3.fldMonthAcquired) as Byear, 
(CASE 
WHEN tr3.fldCurrency = 'USD' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMAI tr4 where tr4.fldTransCode = tr3.fldTransCode),tr3.fldAmountJPY)) 
WHEN tr3.fldCurrency = 'PHP' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMAI tr4 where tr4.fldTransCode = tr3.fldTransCode),tr3.fldAmountJPY)) / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'PHP-USD') 
WHEN tr3.fldCurrency = 'YEN' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMAI tr4 where tr4.fldTransCode = tr3.fldTransCode),tr3.fldAmountJPY)) /(select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'USD-YEN') 
END) as USD,
(CASE 
WHEN tr3.fldCurrency = 'PHP' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMAI tr4 where tr4.fldTransCode = tr3.fldTransCode),tr3.fldAmountJPY)) 
WHEN tr3.fldCurrency = 'USD' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMAI tr4 where tr4.fldTransCode = tr3.fldTransCode),tr3.fldAmountJPY)) * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'PHP-USD') 
WHEN tr3.fldCurrency = 'YEN' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMAI tr4 where tr4.fldTransCode = tr3.fldTransCode),tr3.fldAmountJPY)) * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'YEN-PHP') 
END) as PHP,
(CASE 
WHEN tr3.fldCurrency = 'YEN' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMAI tr4 where tr4.fldTransCode = tr3.fldTransCode),tr3.fldAmountJPY)) 
WHEN tr3.fldCurrency = 'USD' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMAI tr4 where tr4.fldTransCode = tr3.fldTransCode),tr3.fldAmountJPY)) * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'USD-YEN') 
WHEN tr3.fldCurrency = 'PHP' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMAI tr4 where tr4.fldTransCode = tr3.fldTransCode),tr3.fldAmountJPY)) / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'YEN-PHP') 
END) as YEN 
FROM tblActualAcquisition tr3 where tr3.fldTransCode = TC222;

END$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_BPDept`(
	IN D1    datetime,
	IN D2    datetime,
	IN DEPT varchar(50)
)
BEGIN
select distinct year(tr4.fldMBudgeted) as 'Year',tr4.fldDept, 

(select (if(tr5.fldYen IS NOT NULL,sum(tr5.fldYen),0))
from tblBudget tr5 where tr5.fldDept = tr4.fldDept and tr5.fldStat = 'OPEN'
and tr5.fldMBudgeted >= D1 and tr5.fldMBudgeted <= D2
)as 'OrgAmount',
(select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) 
from tblUPO UPO where UPO.fldDept = tr4.fldDept and 
UPO.fldDDate >= D1 and UPO.fldDDate <= D2) 
AS 'UPO',
(select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) 
from tblUPO UPO where UPO.fldDept = tr4.fldDept and 
UPO.fldUDate >= D1 and UPO.fldUDate <= D2) 
AS 'UUPO',
(select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) 
from tblUPO UPO where UPO.fldDept = tr4.fldDept and 
UPO.fldDDate >= D1 and UPO.fldDDate <= D2
and left(UPO.fldBudRefNum,9) != 'NO BUDGET') 
AS 'WNUPO',
(select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) 
from tblUPO UPO where UPO.fldDept = tr4.fldDept and 
UPO.fldUDate >= D1 and UPO.fldUDate <= D2
and left(UPO.fldBudRefNum,9) != 'NO BUDGET') 
AS 'WNUUPO',
(
select if(tr7.fldYen is not null,sum(tr7.fldYen),0)
from tblRevision tr7 left join tblBudget trbud on tr7.fldBudRefNum = trbud.fldBudRefNum 
where  tr7.fldStat != 'Close' and trbud.fldDept = tr4.fldDept and trbud.fldMBudgeted >= D1 and trbud.fldMBudgeted <= D2
)
 as 'RevAmount'	
,
(
select if(COUNT(trRev.fldBudRevNum) != 0,if(trRev.fldYen is not null,sum(trRev.fldYen),0),0)
from tblRevision trRev left join tblBudget trbud on trRev.fldBudRefNum = trbud.fldBudRefNum 
where  trRev.fldStat != 'Close' and trbud.fldDept = tr4.fldDept and trbud.fldMBudgeted >= D1 and trbud.fldMBudgeted <= D2
)
 as 'RevAmount0'	
,

(
select if(POI.fldYenSap is not null,sum(POI.fldYenSap),0) as JPY
FROM tblPOI POI where POI.fldDept = tr4.fldDept and left(POI.fldBudRefNum,9) = 'NO BUDGET'
and POI.fldMO >= D1 and POI.fldMO <= D2 and POI.fldStat != 'CLOSE'
) as 'POWithoutBgt',

(
select if(POI.fldYenSap is not null,sum(POI.fldYenSap),0) as JPY
FROM tblPOI POI where POI.fldDept = tr4.fldDept and left(POI.fldBudRefNum,9) != 'NO BUDGET'
and POI.fldMO >= D1 and POI.fldMO <= D2 and POI.fldStat != 'CLOSE'
) as 'POWITHBgt',
(
select if(POI.fldYenSap is not null,sum(POI.fldYenSap),0) as JPY
FROM tblPOI POI where POI.fldDept = tr4.fldDept
and POI.fldMO >= D1 and POI.fldMO <= D2 and POI.fldStat != 'CLOSE'
) as 'POIBgt',
(
			SELECT 
			ifnull((SELECT
			(
			case 
			WHEN T3.Currency = 'JPY' THEN (T3.Price * T3.Quantity) - ((T3.Price * T3.Quantity)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'USD' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'PHP' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			End)
			FROM POR1 T1 
			LEFT OUTER JOIN OPOR T2 
			ON T1.DocEntry = T2.DocEntry 
			LEFT OUTER JOIN PDN1 T3 
			ON T2.DocEntry = T3.BaseEntry 
			AND T1.LineNum = T3.BaseLine 
			AND T1.ItemCode = T3.ItemCode 
			LEFT OUTER JOIN OPDN T4 
			ON T3.DocEntry = T4.DocEntry 
			LEFT OUTER JOIN RPD1 T5 
			ON T4.DocEntry = T5.BaseEntry 
			AND T3.LineNum = T5.BaseLine 
			AND T3.ItemCode = T5.ItemCode 
			LEFT OUTER JOIN ORPD T6 
			ON T5.DocEntry = T6.DocEntry 
			LEFT OUTER JOIN PCH1 T7 
			ON T4.DocEntry = T7.BaseEntry 
			AND T3.LineNum = T7.BaseLine 
			AND T3.ItemCode = T7.ItemCode 
			LEFT OUTER JOIN OPCH T8 
			ON T7.DocEntry = T8.DocEntry 
			LEFT OUTER JOIN RPC1 T9 
			ON T8.DocEntry = T9.BaseEntry 
			AND T7.LineNum = T9.BaseLine 
			AND T7.ItemCode = T9.ItemCode 
			LEFT OUTER JOIN ORPC T10 
			ON T9.DocEntry = T10.DocEntry 
			WHERE T2.U_HeaderID Is Not null 
			and T6.DocNum is null 
			and T10.DocNum is null 
			and T4.DocNum is not null 
			and (SELECT bud.fldDept from tblBudget bud where bud.fldBudRefNum = T1.U_BudgetRef) = tr4.fldDept
			and left(T1.U_BudgetRef,9) = 'NO BUDGET'
			and T2.DocDate >= D1 and T2.DocDate <= D2 ),0)
) as 'GRPOWithoutBgt',
(
			SELECT
			ifnull((SELECT 
			(
			case 
			WHEN T3.Currency = 'JPY' THEN (T3.Price * T3.Quantity) - ((T3.Price * T3.Quantity)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'USD' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'PHP' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			End)
			FROM POR1 T1 
			LEFT OUTER JOIN OPOR T2 
			ON T1.DocEntry = T2.DocEntry 
			LEFT OUTER JOIN PDN1 T3 
			ON T2.DocEntry = T3.BaseEntry 
			AND T1.LineNum = T3.BaseLine 
			AND T1.ItemCode = T3.ItemCode 
			LEFT OUTER JOIN OPDN T4 
			ON T3.DocEntry = T4.DocEntry 
			LEFT OUTER JOIN RPD1 T5 
			ON T4.DocEntry = T5.BaseEntry 
			AND T3.LineNum = T5.BaseLine 
			AND T3.ItemCode = T5.ItemCode 
			LEFT OUTER JOIN ORPD T6 
			ON T5.DocEntry = T6.DocEntry 
			LEFT OUTER JOIN PCH1 T7 
			ON T4.DocEntry = T7.BaseEntry 
			AND T3.LineNum = T7.BaseLine 
			AND T3.ItemCode = T7.ItemCode 
			LEFT OUTER JOIN OPCH T8 
			ON T7.DocEntry = T8.DocEntry 
			LEFT OUTER JOIN RPC1 T9 
			ON T8.DocEntry = T9.BaseEntry 
			AND T7.LineNum = T9.BaseLine 
			AND T7.ItemCode = T9.ItemCode 
			LEFT OUTER JOIN ORPC T10 
			ON T9.DocEntry = T10.DocEntry 
			WHERE T2.U_HeaderID Is Not null 
			and T6.DocNum is null 
			and T10.DocNum is null 
			and T4.DocNum is Not null 
			and (SELECT bud.fldDept from tblBudget bud where bud.fldBudRefNum = T1.U_BudgetRef) = tr4.fldDept
			and left(T1.U_BudgetRef,9) != 'NO BUDGET'
			and T2.DocDate >= D1 and T2.DocDate <= D2 ),0)
) as 'GRPOWithBgt',
((select if(tr1.fldYEN is not null,sum(tr1.fldYEN),0) - 
(SELECT if(tr2.fldYenSap is not null,sum(tr2.fldYenSap),0) FROM tblPOI tr2 where tr2.fldDept = tr4.fldDept
and tr2.fldMO >= D1 and tr2.fldMO <= D2 and tr2.fldStat != 'CLOSE') 
from tblRevision tr1 left join
tblBudget tr2 on tr1.fldBudRefNum = tr2.fldBudRefNum
where tr1.fldStat != 'CLOSE' and tr2.fldDept= tr4.fldDept
and left(tr1.fldBudRefNum,9) != 'NO BUDGET' 
and tr2.fldMBudgeted >= D1 and tr2.fldMBudgeted <= D2)) as 'RemBudNB',
((select if(tr1.fldYEN is not null,sum(tr1.fldYEN),0) - 
(SELECT if(tr2.fldYenSap is not null,sum(tr2.fldYenSap),0)FROM tblPOI tr2 where tr2.fldDept = tr4.fldDept
and tr2.fldMO >= D1 and tr2.fldMO <= D2 and tr2.fldStat != 'CLOSE') 
from tblRevision tr1 left join
tblBudget tr2 on tr1.fldBudRefNum = tr2.fldBudRefNum
where tr1.fldStat != 'CLOSE' and tr2.fldDept= tr4.fldDept
and tr2.fldMBudgeted >= D1 and tr2.fldMBudgeted <= D2)) as 'RemBudWNB'
 from tblBudget tr4 
 where tr4.fldMBudgeted >= D1 and tr4.fldMBudgeted <= D2 and if(DEPT = 'ALL',
INSTR( ',' + tr4.fldDept + ',', ',' + (select group_concat(fldDeptCode) as fldDeptCode from tblDepartment ) + ',' ) > 0,tr4.fldDept = DEPT)

;
end$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_BPDeptEDIT`(
	IN D1    datetime,
	IN D2    datetime,
	IN DEPT varchar(50)
)
BEGIN
select distinct year(tr4.fldMBudgeted) as 'Year',tr4.fldDept, 

(select (if(tr5.fldYen IS NOT NULL,sum(tr5.fldYen),0))
from tblBudget tr5 where tr5.fldDept = tr4.fldDept and tr5.fldStat = 'OPEN'
and tr5.fldMBudgeted >= D1 and tr5.fldMBudgeted <= D2
)as 'OrgAmount',
(select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) 
from tblUPO UPO where UPO.fldDept = tr4.fldDept and 
UPO.fldDDate >= D1 and UPO.fldDDate <= D2) 
AS 'UPO',
(select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) 
from tblUPO UPO where UPO.fldDept = tr4.fldDept and 
UPO.fldDDate >= D1 and UPO.fldDDate <= D2
and left(UPO.fldBudRefNum,9) != 'NO BUDGET') 
AS 'WNUPO',
(
select if(tr7.fldYen is not null,sum(tr7.fldYen),0)
from tblRevision tr7 left join tblBudget trbud on tr7.fldBudRefNum = trbud.fldBudRefNum 
where  tr7.fldStat != 'Close' and trbud.fldDept = tr4.fldDept and trbud.fldMBudgeted >= D1 and trbud.fldMBudgeted <= D2
)
 as 'RevAmount'	
,
(
select if(COUNT(trRev.fldBudRevNum) != 0,if(trRev.fldYen is not null,sum(trRev.fldYen),0),0)
from tblRevision trRev left join tblBudget trbud on trRev.fldBudRefNum = trbud.fldBudRefNum 
where  trRev.fldStat != 'Close' and trbud.fldDept = tr4.fldDept and trbud.fldMBudgeted >= D1 and trbud.fldMBudgeted <= D2
)
 as 'RevAmount0'	
,

(
select if(POI.fldYenSap is not null,sum(POI.fldYenSap),0) as JPY
FROM tblPOI POI where POI.fldDept = tr4.fldDept and left(POI.fldBudRefNum,9) = 'NO BUDGET'
and POI.fldMO >= D1 and POI.fldMO <= D2 and POI.fldStat != 'CLOSE'
) as 'POWithoutBgt',

(
select if(POI.fldYenSap is not null,sum(POI.fldYenSap),0) as JPY
FROM tblPOI POI where POI.fldDept = tr4.fldDept and left(POI.fldBudRefNum,9) != 'NO BUDGET'
and POI.fldMO >= D1 and POI.fldMO <= D2 and POI.fldStat != 'CLOSE'
) as 'POWITHBgt',
(
select if(POI.fldYenSap is not null,sum(POI.fldYenSap),0) as JPY
FROM tblPOI POI where POI.fldDept = tr4.fldDept
and POI.fldMO >= D1 and POI.fldMO <= D2 and POI.fldStat != 'CLOSE'
) as 'POIBgt',
(
			SELECT 
			ifnull((SELECT
			(
			case 
			WHEN T3.Currency = 'JPY' THEN (T3.Price * T3.Quantity) - ((T3.Price * T3.Quantity)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'USD' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'PHP' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			End)
			FROM POR1 T1 
			LEFT OUTER JOIN OPOR T2 
			ON T1.DocEntry = T2.DocEntry 
			LEFT OUTER JOIN PDN1 T3 
			ON T2.DocEntry = T3.BaseEntry 
			AND T1.LineNum = T3.BaseLine 
			AND T1.ItemCode = T3.ItemCode 
			LEFT OUTER JOIN OPDN T4 
			ON T3.DocEntry = T4.DocEntry 
			LEFT OUTER JOIN RPD1 T5 
			ON T4.DocEntry = T5.BaseEntry 
			AND T3.LineNum = T5.BaseLine 
			AND T3.ItemCode = T5.ItemCode 
			LEFT OUTER JOIN ORPD T6 
			ON T5.DocEntry = T6.DocEntry 
			LEFT OUTER JOIN PCH1 T7 
			ON T4.DocEntry = T7.BaseEntry 
			AND T3.LineNum = T7.BaseLine 
			AND T3.ItemCode = T7.ItemCode 
			LEFT OUTER JOIN OPCH T8 
			ON T7.DocEntry = T8.DocEntry 
			LEFT OUTER JOIN RPC1 T9 
			ON T8.DocEntry = T9.BaseEntry 
			AND T7.LineNum = T9.BaseLine 
			AND T7.ItemCode = T9.ItemCode 
			LEFT OUTER JOIN ORPC T10 
			ON T9.DocEntry = T10.DocEntry 
			WHERE T2.U_HeaderID Is Not null 
			and T6.DocNum is null 
			and T10.DocNum is null 
			and T4.DocNum is not null 
			and (SELECT bud.fldDept from tblBudget bud where bud.fldBudRefNum = T1.U_BudgetRef) = tr4.fldDept
			and left(T1.U_BudgetRef,9) = 'NO BUDGET'
			and T2.DocDate >= D1 and T2.DocDate <= D2 ),0)
) as 'GRPOWithoutBgt',
(
			SELECT
			ifnull((SELECT 
			(
			case 
			WHEN T3.Currency = 'JPY' THEN (T3.Price * T3.Quantity) - ((T3.Price * T3.Quantity)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'USD' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'PHP' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			End)
			FROM POR1 T1 
			LEFT OUTER JOIN OPOR T2 
			ON T1.DocEntry = T2.DocEntry 
			LEFT OUTER JOIN PDN1 T3 
			ON T2.DocEntry = T3.BaseEntry 
			AND T1.LineNum = T3.BaseLine 
			AND T1.ItemCode = T3.ItemCode 
			LEFT OUTER JOIN OPDN T4 
			ON T3.DocEntry = T4.DocEntry 
			LEFT OUTER JOIN RPD1 T5 
			ON T4.DocEntry = T5.BaseEntry 
			AND T3.LineNum = T5.BaseLine 
			AND T3.ItemCode = T5.ItemCode 
			LEFT OUTER JOIN ORPD T6 
			ON T5.DocEntry = T6.DocEntry 
			LEFT OUTER JOIN PCH1 T7 
			ON T4.DocEntry = T7.BaseEntry 
			AND T3.LineNum = T7.BaseLine 
			AND T3.ItemCode = T7.ItemCode 
			LEFT OUTER JOIN OPCH T8 
			ON T7.DocEntry = T8.DocEntry 
			LEFT OUTER JOIN RPC1 T9 
			ON T8.DocEntry = T9.BaseEntry 
			AND T7.LineNum = T9.BaseLine 
			AND T7.ItemCode = T9.ItemCode 
			LEFT OUTER JOIN ORPC T10 
			ON T9.DocEntry = T10.DocEntry 
			WHERE T2.U_HeaderID Is Not null 
			and T6.DocNum is null 
			and T10.DocNum is null 
			and T4.DocNum is Not null 
			and (SELECT bud.fldDept from tblBudget bud where bud.fldBudRefNum = T1.U_BudgetRef) = tr4.fldDept
			and left(T1.U_BudgetRef,9) != 'NO BUDGET'
			and T2.DocDate >= D1 and T2.DocDate <= D2 ),0)
) as 'GRPOWithBgt',
((select if(tr1.fldYEN is not null,sum(tr1.fldYEN),0) - 
(SELECT if(tr2.fldYenSap is not null,sum(tr2.fldYenSap),0) FROM tblPOI tr2 where tr2.fldDept = tr4.fldDept
and tr2.fldMO >= D1 and tr2.fldMO <= D2 and tr2.fldStat != 'CLOSE') 
from tblRevision tr1 left join
tblBudget tr2 on tr1.fldBudRefNum = tr2.fldBudRefNum
where tr1.fldStat != 'CLOSE' and tr2.fldDept= tr4.fldDept
and left(tr1.fldBudRefNum,9) != 'NO BUDGET' 
and tr2.fldMBudgeted >= D1 and tr2.fldMBudgeted <= D2)) as 'RemBudNB',
((select if(tr1.fldYEN is not null,sum(tr1.fldYEN),0) - 
(SELECT if(tr2.fldYenSap is not null,sum(tr2.fldYenSap),0)FROM tblPOI tr2 where tr2.fldDept = tr4.fldDept
and tr2.fldMO >= D1 and tr2.fldMO <= D2 and tr2.fldStat != 'CLOSE') 
from tblRevision tr1 left join
tblBudget tr2 on tr1.fldBudRefNum = tr2.fldBudRefNum
where tr1.fldStat != 'CLOSE' and tr2.fldDept= tr4.fldDept
and tr2.fldMBudgeted >= D1 and tr2.fldMBudgeted <= D2)) as 'RemBudWNB'
 from tblBudget tr4 
 where tr4.fldMBudgeted >= D1 and tr4.fldMBudgeted <= D2 and if(DEPT = 'ALL',
INSTR( ',' + tr4.fldDept + ',', ',' + (select group_concat(fldDeptCode) as fldDeptCode from tblDepartment ) + ',' ) > 0,tr4.fldDept = DEPT)

;
end$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_BudUpdated`(
	IN D1    datetime,
	IN D2    datetime,
	IN Dept varchar(100),
	IN Class varchar(200)
)
BEGIN
select year(tr1.fldMBudgeted) as Byear,tr1.fldBudRefNum,tr1.fldUOM,tr1.fldSOU,tr1.fldClass,tr1.fldProcess,tr1.fldDept,tr1.fldStat,tr1.fldCurrency,tr2.fldRevAmount,
(case
WHEN tr1.fldCurrency = 'USD' then tr2.fldRevAmount 
WHEN tr1.fldCurrency = 'PHP' then tr2.fldRevAmount / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'PHP-USD') 
WHEN tr1.fldCurrency = 'JPY' then tr2.fldRevAmount /(select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'USD-JPY') 
END) as USD, 
(CASE 
WHEN tr1.fldCurrency = 'PHP' then tr2.fldRevAmount 
 WHEN tr1.fldCurrency = 'USD' then tr2.fldRevAmount * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'PHP-USD') 
 WHEN tr1.fldCurrency = 'JPY' then tr2.fldRevAmount * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'JPY-PHP') 
 END) as PHP, 
 (CASE 
 WHEN tr1.fldCurrency = 'JPY' then tr2.fldRevAmount 
 WHEN tr1.fldCurrency = 'USD' then tr2.fldRevAmount * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'USD-JPY') 
 WHEN tr1.fldCurrency = 'PHP' then tr2.fldRevAmount / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'JPY-PHP') 
 END) as YEN,(
select if(trv.fldYEN is not null,trv.fldYEN,0) - 
(SELECT if(tr2.fldYEN is not null,sum(tr2.fldYEN),0)FROM tblPOI tr2 where tr2.fldBudRefNum = tr1.fldBudRefNum and tr2.fldStat != 'CLOSE') 
from tblRevision trv 
where trv.fldStat != 'CLOSE' and trv.fldBudRefNum = tr1.fldBudRefNum
)as RemBal,
(
select 
if(TRQTYF.fldQTY is not null,TRQTYF.fldQTY,0) - 
(Select If(TPO.fldQTY Is Not null, sum(TPO.fldQTY), 0) 
from tblPOI TPO WHERE TPO.fldBudRefNum = tr1.fldBudRefNum and TPO.fldStat != 'CLOSE') 
from tblRevision TRQTYF where TRQTYF.fldBudRefNum = tr1.fldBudRefNum AND TRQTYF.fldStat != 'CLOSE'
) as 'REMQTY'
from tblBudget tr1 left join tblRevision tr2 on tr2.fldBudRefNum = tr1.fldBudRefNum
where tr2.fldStat = 'OPEN' and
tr1.fldMBudgeted >= D1 and tr1.fldMBudgeted <= D2
and 
if(DEPT = 'ALL',
INSTR( ',' + tr1.fldDept + ',', ',' + (select group_concat(fldDeptCode) as fldDeptCode from tblDepartment ) + ',' ) > 0,tr1.fldDept = DEPT)
and
if(Class = 'ALL',
INSTR( ',' + tr1.fldClass + ',', ',' + (select group_concat(fldClassCode) from tblClass) + ',' ) > 0,tr1.fldClass = Class);

END$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_CPOReport`(
	IN CPONo   varchar(50)

)
BEGIN
SELECT T1.OB_Line,T1.OB_Detail_ID, T1.fldUC4S, T1.fldPONO, T1.OB_Line, T1.fldTransCode, 
(select MOI.fldQTYSIN from tblMOI MOI where MOI.fldMOIID = T1.fldMOIID) as MOIQTYSIN, 
T1.fldRD, T1.fldBudRefNum, T1.fldPRNo, T1.fldICode, T1.fldDesc, T1.fldQTY, 
T1.fldUnit, T1.fldUPrice, T1.fldTotalCost, T1.fldYen, T1.fldCurrency, T1.fldQTYSOut, 
T1.fldMonthDelivery, T1.fldStat, T1.fldSignature, T1.fldUID, T1.fldMO, (T1.fldUPrice * (T1.fldQTY - fldQTYSOUT))as TUPrice,
(select CPO.OB_POAmt from tblPO CPO where
 CPO.OB_Line = T1.OB_Line and CPO.fldIndex = if((T1.fldIndex - 1) < 0,T1.fldIndex,T1.fldIndex -1)) as 'LTPO',
T1.fldPOIID, T1.fldMOIID, T1.fldIndex, (select TPO.OB_POAmt from tblPO TPO where TPO.OB_Line = T1.OB_Line and TPO.fldStat !='CLOSE') as TPO, 
( 
Select sum(T3.Quantity) 
FROM POR1 T1 
LEFT OUTER JOIN OPOR T2 
ON T1.DocEntry = T2.DocEntry 
LEFT OUTER JOIN PDN1 T3 
ON T2.DocEntry = T3.BaseEntry 
AND T1.LineNum = T3.BaseLine 
AND T1.ItemCode = T3.ItemCode 
LEFT OUTER JOIN OPDN T4 
ON T3.DocEntry = T4.DocEntry 
LEFT OUTER JOIN RPD1 T5 
ON T4.DocEntry = T5.BaseEntry 
AND T3.LineNum = T5.BaseLine 
AND T3.ItemCode = T5.ItemCode 
LEFT OUTER JOIN ORPD T6 
ON T5.DocEntry = T6.DocEntry 
LEFT OUTER JOIN PCH1 T7 
ON T4.DocEntry = T7.BaseEntry 
AND T3.LineNum = T7.BaseLine 
AND T3.ItemCode = T7.ItemCode 
LEFT OUTER JOIN OPCH T8 
ON T7.DocEntry = T8.DocEntry 
LEFT OUTER JOIN RPC1 T9 
ON T8.DocEntry = T9.BaseEntry 
AND T7.LineNum = T9.BaseLine 
AND T7.ItemCode = T9.ItemCode 
LEFT OUTER JOIN ORPC T10 
ON T9.DocEntry = T10.DocEntry 
WHERE T2.U_HeaderID Is Not null 
and T6.DocNum is null 
and T10.DocNum is null 
and T1.U_Detail_ID = T1.OB_Detail_ID 
) as GRPOQTY, 
if(( 
Select sum(T3.Quantity) 
FROM POR1 T1 
LEFT OUTER JOIN OPOR T2 
ON T1.DocEntry = T2.DocEntry 
LEFT OUTER JOIN PDN1 T3 
ON T2.DocEntry = T3.BaseEntry 
AND T1.LineNum = T3.BaseLine 
AND T1.ItemCode = T3.ItemCode 
LEFT OUTER JOIN OPDN T4 
ON T3.DocEntry = T4.DocEntry 
LEFT OUTER JOIN RPD1 T5 
ON T4.DocEntry = T5.BaseEntry 
AND T3.LineNum = T5.BaseLine 
AND T3.ItemCode = T5.ItemCode 
LEFT OUTER JOIN ORPD T6 
ON T5.DocEntry = T6.DocEntry 
LEFT OUTER JOIN PCH1 T7 
ON T4.DocEntry = T7.BaseEntry 
AND T3.LineNum = T7.BaseLine 
AND T3.ItemCode = T7.ItemCode 
LEFT OUTER JOIN OPCH T8 
ON T7.DocEntry = T8.DocEntry 
LEFT OUTER JOIN RPC1 T9 
ON T8.DocEntry = T9.BaseEntry 
AND T7.LineNum = T9.BaseLine 
AND T7.ItemCode = T9.ItemCode 
LEFT OUTER JOIN ORPC T10 
ON T9.DocEntry = T10.DocEntry 
WHERE T2.U_HeaderID Is Not null 
and T6.DocNum is null 
and T10.DocNum is null 
and T1.U_Detail_ID = T1.OB_Detail_ID 
) is not null,'CLOSE','OPEN') AS STAT 
FROM tblPOI T1 WHERE T1.fldStat != 'CLOSE' AND 
T1.fldCPONo = CPONo;
END$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_FOrderItems`(
	IN POB_Line varchar(150),
	IN DEPT varchar(150)
)
BEGIN
SELECT `OB_Detail_ID`, `fldUC4S`, `fldPONO`, `OB_Line`,
 `fldTransCode`, `fldBudRefNum`, `fldPRNo`, `fldICode`,
 `fldDesc`, `fldQTY`, `fldUnit`, `fldUPrice`, `fldTotalCost`, 
`fldYen`, `fldCurrency`, `fldMonthDelivery`, `fldStat`, `fldSignature`,
 `fldUID`, `fldMO`, `fldPOIID`, `fldMOIID`, `fldDept`, `fldClass` 
FROM `tblPOI`
WHERE OB_Line = POB_Line and
fldForcePO = 'YES' AND
if(DEPT = 'ALL',
INSTR( ',' + fldDept + ',', ',' + (select group_concat(fldDeptCode) as fldDeptCode from tblDepartment) + ',' ) > 0,fldDept = DEPT)
and fldStat != 'CLOSE'
;
END$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_FrderList`(
	IN DEPT varchar(150),
	IN D1 datetime,
	IN D2 datetime
)
BEGIN
SELECT distinct tr1.fldPOID,(select group_concat(t2.docnum) from OPOR t2 where t2.U_HeaderID = tr1.OB_Line) AS PO,
  tr1.OB_Line,(select group_concat(tr2.fldPRNo) from tblPOI tr2 where tr2.OB_Line = tr1.OB_Line and tr2.fldStat != 'CLOSE') as PRNo, tr1.fldSupplier,  tr1.fldVCode,
(select sum(tr2.fldQTY) from tblPOI tr2 where tr2.OB_Line = tr1.OB_Line and tr2.fldStat != 'CLOSE') as SumQTY,
(select sum(tr2.fldYen) from tblPOI tr2 where tr2.OB_Line = tr1.OB_Line and tr2.fldStat != 'CLOSE') as SumJPY,
(CASE 
WHEN tr1.fldCurrency = 'USD' then tr1.OB_POAmt
WHEN tr1.fldCurrency = 'PHP' then tr1.OB_POAmt / (select fldAmount from tblConversion where Year(fldDate) = YEAR(tr1.fldMOrdered) and fldcurrency = 'PHP-USD') 
WHEN tr1.fldCurrency = 'JPY' then tr1.OB_POAmt /(select fldAmount from tblConversion where Year(fldDate) = YEAR(tr1.fldMOrdered) and fldcurrency = 'USD-JPY') 
END) as USD, 
(CASE 
WHEN tr1.fldCurrency = 'PHP' then tr1.OB_POAmt
WHEN tr1.fldCurrency = 'USD' then tr1.OB_POAmt * (select fldAmount from tblConversion where Year(fldDate) = YEAR(tr1.fldMOrdered) and fldcurrency = 'PHP-USD') 
WHEN tr1.fldCurrency = 'JPY' then tr1.OB_POAmt * (select fldAmount from tblConversion where Year(fldDate) = YEAR(tr1.fldMOrdered) and fldcurrency = 'JPY-PHP') 
END) as PHP, 
(CASE 
WHEN tr1.fldCurrency = 'JPY' then tr1.OB_POAmt
WHEN tr1.fldCurrency = 'USD' then tr1.OB_POAmt * (select fldAmount from tblConversion where Year(fldDate) = YEAR(tr1.fldMOrdered) and fldcurrency = 'USD-JPY') 
WHEN tr1.fldCurrency = 'PHP' then tr1.OB_POAmt / (select fldAmount from tblConversion where Year(fldDate) = YEAR(tr1.fldMOrdered) and fldcurrency = 'JPY-PHP') 
END) as JPY, 

tr1.fldDDate,  tr1.fldStat,  tr1.fldCurrency,  tr1.fldDiscount,
  tr1.fldDAmount,  tr1.fldTPO,  tr1.OB_POAmt,  tr1.fldRemarks,  tr1.fldSignature
 FROM  tblPO tr1 LEFT JOIN tblPOI POI on tr1.OB_Line = POI.OB_Line
where
 tr1.fldMOrdered >= D1 and tr1.fldMOrdered  <= D2 AND
tr1.fldForcePO = 'YES' AND
if(DEPT = 'ALL',
INSTR( ',' + POI.fldDept + ',', ',' + (select group_concat(fldDeptCode) as fldDeptCode from tblDepartment) + ',' ) > 0,POI.fldDept = DEPT)

AND
/*if(DEPT = 'ALL',
INSTR( ',' + tr3.fldOrderDepartment + ',', ',' + (select group_concat(fldDeptCode) as fldDeptCode from tblDepartment ) + ',' ) > 0,tr3.fldOrderDepartment = DEPT)
and  */
/*if(PO = 'ALL',
INSTR( ',' + (select group_concat(t2.docnum) from OPOR t2 where t2.U_HeaderID = tr1.OB_Line) + ',', ',' + (select group_concat(t2.docnum) from OPOR t2 where t2.U_HeaderID = tr1.OB_Line) + ',' ) > 0,(select t2.docnum from OPOR t2 where t2.U_HeaderID = tr1.OB_Line) = PO)

and */
POI.fldStat != 'CLOSE'
and tr1.fldStat != 'CLOSE'
;
END$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_GetSubDataIR`(
IN ParamItemCode varchar(250))
BEGIN
SELECT * FROM tblPOI WHERE fldICode = ParamItemCode;
END$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_InserPO`(
	IN PO varchar(500)
)
BEGIN
insert into tblActualAcquisition(fldBudRefNum, fldPONo, fldPRNo, fldMonthAcquired,
 fldOrderSupplier, fldOrderDesc,fldClassification, fldOrderDepartment, fldCurrency, 
fldYen, fldQTY, fldUOM, fldAmountJPY, fldOrderRemarks, 
fldSignature)select fldBudRefNum,fldPONo, fldPRNo,fldMonthDelivery as 'fldMonthAcquired',
 fldOrderSupplier, fldOrderDesc,fldClassification, fldOrderDepartment, fldCurrency, 
fldYen, fldQTY, fldUOM, fldAmountJPY, fldOrderRemarks,
fldSignature
 from tblOrder where fldPONo = PO;
end$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_InsertHPO`(
	IN ID varchar(500)
)
BEGIN
INSERT INTO `tblHPO` 
(fldBudRefNum, fldPONo, fldPRNo,fldTransCode, fldMonthOrder, fldOrderSupplier, fldOrderDesc, 
fldClassification, fldOrderDepartment, fldProcess, fldQTY, fldUOM, fldMonthDelivery, 
fldReason, fldOrderStatus, fldOrderRemarks,fldNB, fldSignature, fldMO)
select 
fldBudRefNum,fldPONo,fldPRNo,fldTransCode,fldMonthOrder,fldOrderSupplier,fldOrderDesc,
fldClassification,fldOrderDepartment,fldProcess,fldQTY, fldUOM, fldMonthDelivery,
fldReason, fldOrderStatus,fldOrderRemarks,fldNB,fldSignature,fldMO
from tblOrder where fldOrderID = ID;
end$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_InsertPOI`(
	IN ID varchar(500)
)
BEGIN
INSERT INTO tblPOI(fldMOIID,fldTransCode, fldBudRefNum, fldICode, fldDesc, fldQTY, 
fldUnit, fldStat, 
fldUID, fldMO,fldSignature,fldPOUID) 
SELECT fldMOIID,fldTransCode,fldBudRefNum,fldICode,fldDesc,fldQTY,
fldUnit,fldStat,
fldUID,fldMO,fldSignature,'sample' FROM tblMOI WHERE fldMOIID = ID;
END$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_MonthList`(
	IN date_from datetime,
	IN date_to datetime
)
BEGIN
set @tempDate=date(date_from) - interval 1 day;
select
date(@tempDate := (date(@tempDate) + interval 1 day)) as theDate
from tblOrder x,tblOrder y
group by theDate
having theDate <= date_to;
END$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_OrderItems`(
	IN POB_Line varchar(150),
	IN DEPT varchar(150)
)
BEGIN
SELECT `OB_Detail_ID`, `fldUC4S`, `fldPONO`, `OB_Line`,
 `fldTransCode`, `fldBudRefNum`, `fldPRNo`, `fldICode`,
 `fldDesc`, `fldQTY`, `fldUnit`, `fldUPrice`, `fldTotalCost`, 
`fldYen`, `fldCurrency`, `fldMonthDelivery`, `fldStat`, `fldSignature`,
 `fldUID`, `fldMO`, `fldPOIID`, `fldMOIID`, `fldDept`, `fldClass` ,`fldYenSap`
FROM `tblPOI`
WHERE OB_Line = POB_Line and
if(DEPT = 'ALL',
INSTR( ',' + fldDept + ',', ',' + (select group_concat(fldDeptCode) as fldDeptCode from tblDepartment) + ',' ) > 0,fldDept = DEPT)
and fldStat != 'CLOSE'
;
END$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_OrderList`(
	IN DEPT varchar(150),
	IN PO varchar(50),
	IN D1 datetime,
	IN D2 datetime
)
BEGIN
SELECT distinct tr1.fldPOID,(select group_concat(t2.docnum) from OPOR t2 where t2.U_HeaderID = tr1.OB_Line) AS PO,
  tr1.OB_Line,(select group_concat(tr2.fldPRNo) from tblPOI tr2 where tr2.OB_Line = tr1.OB_Line and tr2.fldStat != 'CLOSE') as PRNo, tr1.fldSupplier,  tr1.fldVCode,
(select sum(tr2.fldQTY) from tblPOI tr2 where tr2.OB_Line = tr1.OB_Line and tr2.fldStat != 'CLOSE') as SumQTY,
(select sum(tr2.fldYenSap) from tblPOI tr2 where tr2.OB_Line = tr1.OB_Line and tr2.fldStat != 'CLOSE') as SumJPY,
(CASE 
WHEN tr1.fldCurrency = 'USD' then tr1.OB_POAmt
WHEN tr1.fldCurrency = 'PHP' then tr1.OB_POAmt / (select fldAmount from tblConversion where Year(fldDate) = YEAR(tr1.fldMOrdered) and fldcurrency = 'PHP-USD') 
WHEN tr1.fldCurrency = 'JPY' then tr1.OB_POAmt /(select fldAmount from tblConversion where Year(fldDate) = YEAR(tr1.fldMOrdered) and fldcurrency = 'USD-JPY') 
END) as USD, 
(CASE 
WHEN tr1.fldCurrency = 'PHP' then tr1.OB_POAmt
WHEN tr1.fldCurrency = 'USD' then tr1.OB_POAmt * (select fldAmount from tblConversion where Year(fldDate) = YEAR(tr1.fldMOrdered) and fldcurrency = 'PHP-USD') 
WHEN tr1.fldCurrency = 'JPY' then tr1.OB_POAmt * (select fldAmount from tblConversion where Year(fldDate) = YEAR(tr1.fldMOrdered) and fldcurrency = 'JPY-PHP') 
END) as PHP, 
(CASE 
WHEN tr1.fldCurrency = 'JPY' then tr1.OB_POAmt
WHEN tr1.fldCurrency = 'USD' then tr1.OB_POAmt * (select fldAmount from tblConversion where Year(fldDate) = YEAR(tr1.fldMOrdered) and fldcurrency = 'USD-JPY') 
WHEN tr1.fldCurrency = 'PHP' then tr1.OB_POAmt / (select fldAmount from tblConversion where Year(fldDate) = YEAR(tr1.fldMOrdered) and fldcurrency = 'JPY-PHP') 
END) as JPY, 

tr1.fldDDate,  tr1.fldStat,  tr1.fldCurrency,  tr1.fldDiscount,
  tr1.fldDAmount,  tr1.fldTPO,  tr1.OB_POAmt,  tr1.fldRemarks,  tr1.fldSignature
 FROM  tblPO tr1 LEFT JOIN tblPOI POI on tr1.OB_Line = POI.OB_Line
where
 tr1.fldMOrdered >= D1 and tr1.fldMOrdered  <= D2 AND
if(DEPT = 'ALL',
INSTR( ',' + POI.fldDept + ',', ',' + (select group_concat(fldDeptCode) as fldDeptCode from tblDepartment) + ',' ) > 0,POI.fldDept = DEPT)

AND
/*if(DEPT = 'ALL',
INSTR( ',' + tr3.fldOrderDepartment + ',', ',' + (select group_concat(fldDeptCode) as fldDeptCode from tblDepartment ) + ',' ) > 0,tr3.fldOrderDepartment = DEPT)
and  */
if(PO = 'ALL',
INSTR( ',' + (select group_concat(t2.docnum) from OPOR t2 where t2.U_HeaderID = tr1.OB_Line) + ',', ',' + (select group_concat(t2.docnum) from OPOR t2 where t2.U_HeaderID = tr1.OB_Line) + ',' ) > 0,(select t2.docnum from OPOR t2 where t2.U_HeaderID = tr1.OB_Line) = PO)
and POI.fldStat != 'CLOSE'
and tr1.fldStat != 'CLOSE'
;
END$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_PRForm`(
	IN PR varchar(150)
)
BEGIN
SELECT if(Odr.fldPRNo = '',concat(PR.fldYear,'-',PR.fldPRKey),Odr.fldPRNo) as fldPRNo, MOI.fldUC4S, MOI.fldMOIID, MOI.fldTransCode, MOI.fldBudRefNum, MOI.fldICode, 
MOI.fldDesc, MOI.fldQTY, MOI.fldQTYSIN, MOI.fldQTYSOUT, MOI.fldQTYEB, MOI.fldUnit, 
MOI.fldMonthDelivery,Odr.fldDN,
MOI.fldStat, substring_index(MOI.fldSignature,'-',-1) as fldSignature, MOI.fldRS, Odr.fldRBLPR,Odr.fldRN,
MOI.fldUID, MOI.fldMO, MOI.fldClass, MOI.fldDept, MOI.fldProcess,
(select if(tr1.fldYEN is not null,tr1.fldYEN,0)  - (select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) from tblUPO UPO where UPO.fldBudRefNum = MOI.fldBudRefNum) - 
(SELECT if(tr2.fldYEN is not null,sum(tr2.fldYEN),0)FROM tblPOI tr2 where tr2.fldBudRefNum = MOI.fldBudRefNum and tr2.fldStat != 'CLOSE') 
from tblRevision tr1 
where tr1.fldStat != 'CLOSE' and tr1.fldBudRefNum = MOI.fldBudRefNum) as RemBud,
(SELECT if(PR.fldEJPY is not null,sum(PR.fldEJPY),0)
FROM tblOrder PR where PR.fldOrderStatus = 'OPEN'
and PR.fldBudRefNum = MOI.fldBudRefNum) as 'TJPY',
(
SELECT if(PRD.fldEJPY is not null,sum(PRD.fldEJPY),0) FROM tblOrder PRD
left join tblPRNo PRNo on PRD.fldTransCode = PRNo.fldTransCode
where PRD.fldOrderStatus = 'OPEN'
and PRD.fldPRNo = PR or concat(PRNo.fldYear,'-',PRNo.fldPRKey) = PR
) as TPR,
(
SELECT if(PRD.fldEOA is not null,sum(PRD.fldEOA),0) FROM tblOrder PRD
left join tblPRNo PRNo on PRD.fldTransCode = PRNo.fldTransCode
where PRD.fldOrderStatus = 'OPEN'
and PRD.fldPRNo = PR or concat(PRNo.fldYear,'-',PRNo.fldPRKey) = PR
) as TPRO
 FROM tblMOI MOI 
left join tblOrder Odr on Odr.fldTransCode = MOI.fldTransCode
left join tblPRNo PR on Odr.fldTransCode = PR.fldTransCode
WHERE (if(Odr.fldPRNo = '',concat(PR.fldYear,'-',PR.fldPRKey),Odr.fldPRNo)) = PR;
END$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_PRList`(
	IN DEPT varchar(150),
	IN D1 datetime,
	IN D2 datetime
)
BEGIN
SELECT tr1.fldUC4S, tr1.fldMOIID, tr1.fldTransCode, tr1.fldBudRefNum, tr1.fldICode, 
tr1.fldDesc, tr1.fldQTY, tr1.fldQTYSOUT, tr1.fldQTYEB, tr1.fldUnit, 
tr1.fldMonthDelivery, 
tr1.fldStat, tr1.fldSignature, tr1.fldRS, tr1.fldUID, tr1.fldMO, tr1.fldClass, 
tr1.fldDept, tr1.fldProcess,tr2.fldPRNo 
FROM tblMOI tr1 left join tblOrder tr2 on tr1.fldTransCode = tr2.fldTransCode
where
if(DEPT = 'ALL',
INSTR( ',' + tr1.fldDept + ',', ',' + (select group_concat(fldDeptCode) as fldDeptCode from tblDepartment ) + ',' ) > 0,tr1.fldDept = DEPT);
end$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_RefNum`(
)
BEGIN
SELECT `fldBudRefNum` FROM `tblBudget` WHERE `fldStat` = 'OPEN';
END$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_RPBudget`(
	IN D1    datetime,
	IN D2    datetime,
	IN DEPT varchar(50)
)
BEGIN
select tr1.fldBudRefNum,tr1.fldDesc,tr1.fldDept,tr1.fldMBudgeted,tr1.fldMForecasted,tr1.fldYen as 'OAmount',
(
select if(tr7.fldYen is not null,tr7.fldYen,0)
from tblRevision tr7 left join tblBudget trbud on tr7.fldBudRefNum = trbud.fldBudRefNum 
where  tr7.fldStat != 'Close' and tr7.fldBudRefNum = tr1.fldBudRefNum
 and trbud.fldMBudgeted >= D1 and trbud.fldMBudgeted <= D2
)
 as 'RevAmount',
(
select if(trRev.fldBudRevNum is not null,if(trRev.fldYen is not null,trRev.fldYen,0),0)
from tblRevision trRev left join tblBudget trbud on trRev.fldBudRefNum = trbud.fldBudRefNum 
where  trRev.fldStat != 'Close' and trRev.fldBudRefNum = tr1.fldBudRefNum
 and trbud.fldMBudgeted >= D1 and trbud.fldMBudgeted <= D2
)
 as 'RevAmount0',
(select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) 
from tblUPO UPO where UPO.fldBudRefNum = tr1.fldBudRefNum and 
UPO.fldDDate >= D1 and UPO.fldDDate <= D2)
 AS 'UPO',
(select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) 
from tblUPO UPO where UPO.fldBudRefNum = tr1.fldBudRefNum and 
UPO.fldUDate >= D1 and UPO.fldUDate <= D2)
 AS 'UUPO',

/*(
select (if(tr2.fldYen is not null,sum(tr2.fldYen),0))
from tblOrder tr2
where tr2.fldOrderStatus = 'OPEN' and tr2.fldBudRefNum = tr1.fldBudRefNum
and tr2.fldMonthOrder >= D1 and tr2.fldMonthOrder <= D2 and tr2.fldTransCode is null
) AS 'OnGoingOrderS',
(
select distinct if(tr6.fldYen is not null,sum(tr6.fldYen),0)
from tblMOI tr6 left join tblOrder tr8 on tr6.fldTransCode = tr8.fldTransCode
where tr8.fldBudRefNum = tr1.fldBudRefNum and tr6.fldStat = 'OPEN' and tr8.fldTransCode is not null
) as 'OnGoingOrderMOI', 

(
select if(POI.fldYen is not null,sum(POI.fldYen),0) as JPY
FROM tblPOI POI where POI.fldBudRefNum = tr1.fldBudRefNum and left(POI.fldBudRefNum,9) = 'NO BUDGET'
and POI.fldMO >= D1 and POI.fldMO <= D2
) as 'POWithoutBgt',

(
select if(POI.fldYen is not null,sum(POI.fldYen),0) as JPY
FROM tblPOI POI where POI.fldBudRefNum = tr1.fldBudRefNum and left(POI.fldBudRefNum,9) != 'NO BUDGET'
and POI.fldMO >= D1 and POI.fldMO <= D2
) as 'POWITHBgt',*/
(
select if(POI.fldYenSap is not null,sum(POI.fldYenSap),0) as JPY
FROM tblPOI POI where POI.fldBudRefNum = tr1.fldBudRefNum
and POI.fldMO >= D1 and POI.fldMO <= D2
) as 'PO',
(

select if(FPO.fldYenSap is not null,sum(FPO.fldYenSap),0) as JPY
FROM tblPOI FPO left join tblPO PO on FPO.OB_Line = PO.OB_Line 
where FPO.fldBudRefNum = tr1.fldBudRefNum
and FPO.fldMO >= D1 and FPO.fldMO <= D2 AND PO.fldForcePO = 'YES'
) AS 'FPO',
(
			SELECT
			ifnull((SELECT 
			(
			case 
			WHEN T3.Currency = 'JPY' THEN (T3.Price * T3.Quantity) - ((T3.Price * T3.Quantity)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'USD' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'PHP' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			End)
			FROM POR1 T1 
			LEFT OUTER JOIN OPOR T2 
			ON T1.DocEntry = T2.DocEntry 
			LEFT OUTER JOIN PDN1 T3 
			ON T2.DocEntry = T3.BaseEntry 
			AND T1.LineNum = T3.BaseLine 
			AND T1.ItemCode = T3.ItemCode 
			LEFT OUTER JOIN OPDN T4 
			ON T3.DocEntry = T4.DocEntry 
			LEFT OUTER JOIN RPD1 T5 
			ON T4.DocEntry = T5.BaseEntry 
			AND T3.LineNum = T5.BaseLine 
			AND T3.ItemCode = T5.ItemCode 
			LEFT OUTER JOIN ORPD T6 
			ON T5.DocEntry = T6.DocEntry 
			LEFT OUTER JOIN PCH1 T7 
			ON T4.DocEntry = T7.BaseEntry 
			AND T3.LineNum = T7.BaseLine 
			AND T3.ItemCode = T7.ItemCode 
			LEFT OUTER JOIN OPCH T8 
			ON T7.DocEntry = T8.DocEntry 
			LEFT OUTER JOIN RPC1 T9 
			ON T8.DocEntry = T9.BaseEntry 
			AND T7.LineNum = T9.BaseLine 
			AND T7.ItemCode = T9.ItemCode 
			LEFT OUTER JOIN ORPC T10 
			ON T9.DocEntry = T10.DocEntry 
			WHERE T2.U_HeaderID Is Not null 
			and T6.DocNum is null 
			and T10.DocNum is null 
			and T4.docnum is not null
			and T1.U_BudgetRef = tr1.fldBudRefNum
			and T2.DocDate >= D1 and T2.DocDate <= D2),0) 
) as 'GRPO',
/*(
			SELECT 
			if(T3.U_fldYen is not null,SUM(T3.U_fldYen),0)
			FROM POR1 T1 
			LEFT OUTER JOIN OPOR T2 
			ON T1.DocEntry = T2.DocEntry 
			LEFT OUTER JOIN PDN1 T3 
			ON T2.DocEntry = T3.BaseEntry 
			AND T1.LineNum = T3.BaseLine 
			AND T1.ItemCode = T3.ItemCode 
			LEFT OUTER JOIN OPDN T4 
			ON T3.DocEntry = T4.DocEntry 
			LEFT OUTER JOIN RPD1 T5 
			ON T4.DocEntry = T5.BaseEntry 
			AND T3.LineNum = T5.BaseLine 
			AND T3.ItemCode = T5.ItemCode 
			LEFT OUTER JOIN ORPD T6 
			ON T5.DocEntry = T6.DocEntry 
			LEFT OUTER JOIN PCH1 T7 
			ON T4.DocEntry = T7.BaseEntry 
			AND T3.LineNum = T7.BaseLine 
			AND T3.ItemCode = T7.ItemCode 
			LEFT OUTER JOIN OPCH T8 
			ON T7.DocEntry = T8.DocEntry 
			LEFT OUTER JOIN RPC1 T9 
			ON T8.DocEntry = T9.BaseEntry 
			AND T7.LineNum = T9.BaseLine 
			AND T7.ItemCode = T9.ItemCode 
			LEFT OUTER JOIN ORPC T10 
			ON T9.DocEntry = T10.DocEntry 
			WHERE T2.U_HeaderID Is Not null 
			and T6.DocNum is null 
			and T10.DocNum is null 
			and T4.docnum is not null
			and T1.U_BudgetRef = tr1.fldBudRefNum
			and left(T1.U_BudgetRef,9) = 'NO BUDGET'
			and T2.DocDate >= D1 and T2.DocDate <= D2 
) as 'GRPOWithoutBgt',
(
			SELECT 
			if(T3.U_fldYen is not null,SUM(T3.U_fldYen),0)
			FROM POR1 T1 
			LEFT OUTER JOIN OPOR T2 
			ON T1.DocEntry = T2.DocEntry 
			LEFT OUTER JOIN PDN1 T3 
			ON T2.DocEntry = T3.BaseEntry 
			AND T1.LineNum = T3.BaseLine 
			AND T1.ItemCode = T3.ItemCode 
			LEFT OUTER JOIN OPDN T4 
			ON T3.DocEntry = T4.DocEntry 
			LEFT OUTER JOIN RPD1 T5 
			ON T4.DocEntry = T5.BaseEntry 
			AND T3.LineNum = T5.BaseLine 
			AND T3.ItemCode = T5.ItemCode 
			LEFT OUTER JOIN ORPD T6 
			ON T5.DocEntry = T6.DocEntry 
			LEFT OUTER JOIN PCH1 T7 
			ON T4.DocEntry = T7.BaseEntry 
			AND T3.LineNum = T7.BaseLine 
			AND T3.ItemCode = T7.ItemCode 
			LEFT OUTER JOIN OPCH T8 
			ON T7.DocEntry = T8.DocEntry 
			LEFT OUTER JOIN RPC1 T9 
			ON T8.DocEntry = T9.BaseEntry 
			AND T7.LineNum = T9.BaseLine 
			AND T7.ItemCode = T9.ItemCode 
			LEFT OUTER JOIN ORPC T10 
			ON T9.DocEntry = T10.DocEntry 
			WHERE T2.U_HeaderID Is Not null 
			and T6.DocNum is null 
			and T10.DocNum is null 
			and T4.docnum is not null
			and T1.U_BudgetRef = tr1.fldBudRefNum
			and left(T1.U_BudgetRef,9) != 'NO BUDGET'
			and T2.DocDate >= D1 and T2.DocDate <= D2 
) as 'GRPOWithBgt'
,*/
((select if(trv.fldYEN is not null,trv.fldYEN,0) - 
(SELECT if(TPOI.fldYenSap is not null,sum(TPOI.fldYenSap),0) FROM tblPOI TPOI where TPOI.fldBudRefNum = tr1.fldBudRefNum
and TPOI.fldMO >= D1 and TPOI.fldMO <= D2) 
from tblRevision trv Left join
tblBudget trbud on trv.fldBudRefNum = trbud.fldBudRefNum
where trv.fldStat != 'CLOSE' and trv.fldBudRefNum = tr1.fldBudRefNum
and trbud.fldMBudgeted >= D1 and trbud.fldMBudgeted <= D2)) as 'RemBud'
	
from tblBudget tr1 where tr1.fldMBudgeted >= D1 and tr1.fldMBudgeted <= D2 and
if(DEPT = 'ALL',
INSTR( ',' + tr1.fldDept + ',', ',' + (select group_concat(fldDeptCode) as fldDeptCode from tblDepartment ) + ',' ) > 0,tr1.fldDept = DEPT)
order by tr1.fldDept;
END$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_RPMonth`(
	IN D1    datetime,
	IN D2    datetime,
	IN DEPT VARCHAR(50)
)
BEGIN
select tr1.fldCode,tr1.fldMonth,
(
select (if(tr8.fldYen IS NOT NULL,sum(tr8.fldYen),0))
from tblBudget tr8 where month(tr8.fldMBudgeted) = tr1.fldCode and tr8.fldStat = 'OPEN' 
and tr8.fldDept = DEPT
)as 'OrgAmount',
(
select (IF(tr6.fldYen IS NOT NULL,sum(tr6.fldYen),0)) 
from tblRevision tr6 left join tblBudget trmain on tr6.fldBudRefNum = trmain.fldBudRefNum
where  tr6.fldStat != 'CLOSE' and month(trmain.fldMBudgeted) = tr1.fldCode
and trmain.fldDept = DEPT
)
as 'RevAmount',
(select if(COUNT(tr6.fldBudRevNum) != 0,IF(tr6.fldYen IS NOT NULL,sum(tr6.fldYen),0),0) 
from tblRevision tr6 left join tblBudget trmain on tr6.fldBudRefNum = trmain.fldBudRefNum
where  tr6.fldStat != 'CLOSE' and month(trmain.fldMBudgeted) = tr1.fldCode
and trmain.fldDept = DEPT
)
as 'RevAmount0',
(select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) 
from tblUPO UPO where month(UPO.fldDDate) = tr1.fldCode and 
UPO.fldDept = DEPT)
 AS 'UPO',
/*(
select (IF(tr3.fldYen IS NOT NULL,Sum(tr3.fldYen),0))
from tblOrder tr3
where tr3.fldOrderStatus = 'OPEN' and month(fldMonthOrder) = tr1.fldCode and tr3.fldTransCode is null
and tr3.fldNB = 'NO'
) as 'OnGoingOrderS',
(
select distinct if(tr9.fldYen is not null,sum(tr9.fldYen),0)
from tblMOI tr9 left join tblOrder tr10 on tr9.fldTransCode = tr10.fldTransCode
where month(tr10.fldMonthOrder) = tr1.fldCode and tr9.fldStat = 'OPEN' and tr10.fldTransCode is not null
and tr10.fldNB = 'NO'
) as 'OnGoingOrderMOI', */
(
select if(POI.fldYenSap is not null,sum(POI.fldYenSap),0) as JPY
FROM tblPOI POI where month(POI.fldMO) = tr1.fldCode and left(POI.fldBudRefNum,9) = 'NO BUDGET'
and POI.fldDept = DEPT and POI.fldStat != 'CLOSE'
) as 'POWithoutBgt',

(
select if(POI.fldYenSap is not null,sum(POI.fldYenSap),0) as JPY
FROM tblPOI POI where month(POI.fldMO) = tr1.fldCode and left(POI.fldBudRefNum,9) != 'NO BUDGET'
and POI.fldDept = DEPT and POI.fldStat != 'CLOSE'
) as 'POWITHBgt',
(
select if(POI.fldYenSap is not null,sum(POI.fldYenSap),0) as JPY
FROM tblPOI POI where month(POI.fldMO) = tr1.fldCode and left(POI.fldBudRefNum,9) = 'NO BUDGET'
and POI.fldDept = DEPT and POI.fldStat != 'CLOSE' and POI.fldForcePO = 'YES'
) as 'FPOWithoutBgt',
(
select if(POI.fldYenSap is not null,sum(POI.fldYenSap),0) as JPY
FROM tblPOI POI where month(POI.fldMO) = tr1.fldCode and left(POI.fldBudRefNum,9) != 'NO BUDGET'
and POI.fldDept = DEPT and POI.fldStat != 'CLOSE'  and POI.fldForcePO = 'YES'
) as 'FPOWITHBgt',
(
			SELECT
			ifnull((SELECT 
			(
			case 
			WHEN T3.Currency = 'JPY' THEN (T3.Price * T3.Quantity) - ((T3.Price * T3.Quantity)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'USD' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'PHP' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			End)
			FROM POR1 T1 
			LEFT OUTER JOIN OPOR T2 
			ON T1.DocEntry = T2.DocEntry 
			LEFT OUTER JOIN PDN1 T3 
			ON T2.DocEntry = T3.BaseEntry 
			AND T1.LineNum = T3.BaseLine 
			AND T1.ItemCode = T3.ItemCode 
			LEFT OUTER JOIN OPDN T4 
			ON T3.DocEntry = T4.DocEntry 
			LEFT OUTER JOIN RPD1 T5 
			ON T4.DocEntry = T5.BaseEntry 
			AND T3.LineNum = T5.BaseLine 
			AND T3.ItemCode = T5.ItemCode 
			LEFT OUTER JOIN ORPD T6 
			ON T5.DocEntry = T6.DocEntry 
			LEFT OUTER JOIN PCH1 T7 
			ON T4.DocEntry = T7.BaseEntry 
			AND T3.LineNum = T7.BaseLine 
			AND T3.ItemCode = T7.ItemCode 
			LEFT OUTER JOIN OPCH T8 
			ON T7.DocEntry = T8.DocEntry 
			LEFT OUTER JOIN RPC1 T9 
			ON T8.DocEntry = T9.BaseEntry 
			AND T7.LineNum = T9.BaseLine 
			AND T7.ItemCode = T9.ItemCode 
			LEFT OUTER JOIN ORPC T10 
			ON T9.DocEntry = T10.DocEntry 
			WHERE T2.U_HeaderID Is Not null 
			and T6.DocNum is null 
			and T10.DocNum is null 
			and T4.DocNum is not null 
			and month(T3.DocDate) = tr1.fldCode
			and left(T1.U_BudgetRef,9) != 'NO BUDGET'
			and (SELECT bud.fldDept from tblBudget bud where bud.fldBudRefNum = T1.U_BudgetRef) = DEPT),0)		
) as 'GRPOWithoutBgt',
(
			SELECT
			ifnull((SELECT 
			(
			case 
			WHEN T3.Currency = 'JPY' THEN (T3.Price * T3.Quantity) - ((T3.Price * T3.Quantity)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'USD' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'PHP' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			End)
			FROM POR1 T1 
			LEFT OUTER JOIN OPOR T2 
			ON T1.DocEntry = T2.DocEntry 
			LEFT OUTER JOIN PDN1 T3 
			ON T2.DocEntry = T3.BaseEntry 
			AND T1.LineNum = T3.BaseLine 
			AND T1.ItemCode = T3.ItemCode 
			LEFT OUTER JOIN OPDN T4 
			ON T3.DocEntry = T4.DocEntry 
			LEFT OUTER JOIN RPD1 T5 
			ON T4.DocEntry = T5.BaseEntry 
			AND T3.LineNum = T5.BaseLine 
			AND T3.ItemCode = T5.ItemCode 
			LEFT OUTER JOIN ORPD T6 
			ON T5.DocEntry = T6.DocEntry 
			LEFT OUTER JOIN PCH1 T7 
			ON T4.DocEntry = T7.BaseEntry 
			AND T3.LineNum = T7.BaseLine 
			AND T3.ItemCode = T7.ItemCode 
			LEFT OUTER JOIN OPCH T8 
			ON T7.DocEntry = T8.DocEntry 
			LEFT OUTER JOIN RPC1 T9 
			ON T8.DocEntry = T9.BaseEntry 
			AND T7.LineNum = T9.BaseLine 
			AND T7.ItemCode = T9.ItemCode 
			LEFT OUTER JOIN ORPC T10 
			ON T9.DocEntry = T10.DocEntry 
			WHERE T2.U_HeaderID Is Not null 
			and T6.DocNum is null 
			and T10.DocNum is null 
			and T4.DocNum is not null 
			and month(T3.DocDate) = tr1.fldCode
			and left(T1.U_BudgetRef,9) = 'NO BUDGET'
			and (SELECT bud.fldDept from tblBudget bud where bud.fldBudRefNum = T1.U_BudgetRef) = DEPT),0)	
) as 'GRPOWithBgt',
((select if(tr1.fldYEN is not null,sum(tr1.fldYEN),0) - 
(SELECT if(tr2.fldYenSap is not null,sum(tr2.fldYenSap),0)FROM tblPOI tr2 where month(tr2.fldMO) = tr1.fldCode) 
from tblRevision tr1 left join
tblBudget tr2 on tr1.fldBudRefNum = tr2.fldBudRefNum
where tr1.fldStat != 'CLOSE' and month(tr2.fldMBudgeted) = tr1.fldCode
and left(tr1.fldBudRefNum,9) != 'NO BUDGET'
and tr2.fldDept = DEPT)) as 'RemBudNB',
((select if(tr1.fldYEN is not null,sum(tr1.fldYEN),0) - 
(SELECT if(tr2.fldYenSap is not null,sum(tr2.fldYenSap),0)FROM tblPOI tr2 where month(tr2.fldMO) = tr1.fldCode) 
from tblRevision tr1 left join
tblBudget tr2 on tr1.fldBudRefNum = tr2.fldBudRefNum
where tr1.fldStat != 'CLOSE' and month(tr2.fldMBudgeted) = tr1.fldCode
and tr2.fldDept = DEPT)) as 'RemBudWNB'
from tblMonth tr1;
end$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_RPMonthALL`(
	IN D1    datetime,
	IN D2    datetime
)
BEGIN
select tr1.fldCode,tr1.fldMonth,
(
select (if(tr8.fldYen IS NOT NULL,sum(tr8.fldYen),0))
from tblBudget tr8 where month(tr8.fldMBudgeted) = tr1.fldCode and tr8.fldStat = 'OPEN' 

)as 'OrgAmount',
(
select (IF(tr6.fldYen IS NOT NULL,sum(tr6.fldYen),0)) 
from tblRevision tr6 left join tblBudget trmain on tr6.fldBudRefNum = trmain.fldBudRefNum
where  tr6.fldStat != 'CLOSE' and month(trmain.fldMBudgeted) = tr1.fldCode

)
as 'RevAmount',
(select if(COUNT(tr6.fldBudRevNum) != 0,IF(tr6.fldYen IS NOT NULL,sum(tr6.fldYen),0),0) 
from tblRevision tr6 left join tblBudget trmain on tr6.fldBudRefNum = trmain.fldBudRefNum
where  tr6.fldStat != 'CLOSE' and month(trmain.fldMBudgeted) = tr1.fldCode
)
as 'RevAmount0',
(select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) 
from tblUPO UPO where month(UPO.fldDDate) = tr1.fldCode)
 AS 'UPO',
/*(
select (IF(tr3.fldYen IS NOT NULL,Sum(tr3.fldYen),0))
from tblOrder tr3
where tr3.fldOrderStatus = 'OPEN' and month(fldMonthOrder) = tr1.fldCode and tr3.fldTransCode is null
and tr3.fldNB = 'NO'
) as 'OnGoingOrderS',
(
select distinct if(tr9.fldYen is not null,sum(tr9.fldYen),0)
from tblMOI tr9 left join tblOrder tr10 on tr9.fldTransCode = tr10.fldTransCode
where month(tr10.fldMonthOrder) = tr1.fldCode and tr9.fldStat = 'OPEN' and tr10.fldTransCode is not null
and tr10.fldNB = 'NO'
) as 'OnGoingOrderMOI', */
(
select if(POI.fldYen is not null,sum(POI.fldYen),0) as JPY
FROM tblPOI POI where month(POI.fldMO) = tr1.fldCode and left(POI.fldBudRefNum,9) = 'NO BUDGET'
and POI.fldStat != 'CLOSE'
) as 'POWithoutBgt',

(
select if(POI.fldYen is not null,sum(POI.fldYen),0) as JPY
FROM tblPOI POI where month(POI.fldMO) = tr1.fldCode and left(POI.fldBudRefNum,9) != 'NO BUDGET'
and POI.fldStat != 'CLOSE'
) as 'POWITHBgt',
(
select if(POI.fldYen is not null,sum(POI.fldYen),0) as JPY
FROM tblPOI POI where month(POI.fldMO) = tr1.fldCode and left(POI.fldBudRefNum,9) = 'NO BUDGET'
 and POI.fldStat != 'CLOSE' and POI.fldForcePO = 'YES'
) as 'FPOWithoutBgt',
(
select if(POI.fldYen is not null,sum(POI.fldYen),0) as JPY
FROM tblPOI POI where month(POI.fldMO) = tr1.fldCode and left(POI.fldBudRefNum,9) != 'NO BUDGET'
 and POI.fldStat != 'CLOSE'  and POI.fldForcePO = 'YES'
) as 'FPOWITHBgt',
(
			SELECT
			ifnull((SELECT 
			(
			case 
			WHEN T3.Currency = 'JPY' THEN (T3.Price * T3.Quantity) - ((T3.Price * T3.Quantity)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'USD' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'PHP' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			End)
			FROM POR1 T1 
			LEFT OUTER JOIN OPOR T2 
			ON T1.DocEntry = T2.DocEntry 
			LEFT OUTER JOIN PDN1 T3 
			ON T2.DocEntry = T3.BaseEntry 
			AND T1.LineNum = T3.BaseLine 
			AND T1.ItemCode = T3.ItemCode 
			LEFT OUTER JOIN OPDN T4 
			ON T3.DocEntry = T4.DocEntry 
			LEFT OUTER JOIN RPD1 T5 
			ON T4.DocEntry = T5.BaseEntry 
			AND T3.LineNum = T5.BaseLine 
			AND T3.ItemCode = T5.ItemCode 
			LEFT OUTER JOIN ORPD T6 
			ON T5.DocEntry = T6.DocEntry 
			LEFT OUTER JOIN PCH1 T7 
			ON T4.DocEntry = T7.BaseEntry 
			AND T3.LineNum = T7.BaseLine 
			AND T3.ItemCode = T7.ItemCode 
			LEFT OUTER JOIN OPCH T8 
			ON T7.DocEntry = T8.DocEntry 
			LEFT OUTER JOIN RPC1 T9 
			ON T8.DocEntry = T9.BaseEntry 
			AND T7.LineNum = T9.BaseLine 
			AND T7.ItemCode = T9.ItemCode 
			LEFT OUTER JOIN ORPC T10 
			ON T9.DocEntry = T10.DocEntry 
			WHERE T2.U_HeaderID Is Not null 
			and T6.DocNum is null 
			and T10.DocNum is null 
			and T4.DocNum is not null 
			and month(T3.DocDate) = tr1.fldCode
			and left(T1.U_BudgetRef,9) != 'NO BUDGET'),0)
	
) as 'GRPOWithoutBgt',
(
			SELECT
			ifnull((SELECT 
			(
			case 
			WHEN T3.Currency = 'JPY' THEN (T3.Price * T3.Quantity) - ((T3.Price * T3.Quantity)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'USD' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'PHP' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			End)
			FROM POR1 T1 
			LEFT OUTER JOIN OPOR T2 
			ON T1.DocEntry = T2.DocEntry 
			LEFT OUTER JOIN PDN1 T3 
			ON T2.DocEntry = T3.BaseEntry 
			AND T1.LineNum = T3.BaseLine 
			AND T1.ItemCode = T3.ItemCode 
			LEFT OUTER JOIN OPDN T4 
			ON T3.DocEntry = T4.DocEntry 
			LEFT OUTER JOIN RPD1 T5 
			ON T4.DocEntry = T5.BaseEntry 
			AND T3.LineNum = T5.BaseLine 
			AND T3.ItemCode = T5.ItemCode 
			LEFT OUTER JOIN ORPD T6 
			ON T5.DocEntry = T6.DocEntry 
			LEFT OUTER JOIN PCH1 T7 
			ON T4.DocEntry = T7.BaseEntry 
			AND T3.LineNum = T7.BaseLine 
			AND T3.ItemCode = T7.ItemCode 
			LEFT OUTER JOIN OPCH T8 
			ON T7.DocEntry = T8.DocEntry 
			LEFT OUTER JOIN RPC1 T9 
			ON T8.DocEntry = T9.BaseEntry 
			AND T7.LineNum = T9.BaseLine 
			AND T7.ItemCode = T9.ItemCode 
			LEFT OUTER JOIN ORPC T10 
			ON T9.DocEntry = T10.DocEntry 
			WHERE T2.U_HeaderID Is Not null 
			and T6.DocNum is null 
			and T10.DocNum is null 
			and T4.DocNum is not null 
			and month(T3.DocDate) = tr1.fldCode
			and left(T1.U_BudgetRef,9) = 'NO BUDGET'),0)
	
) as 'GRPOWithBgt',
((select if(tr1.fldYEN is not null,sum(tr1.fldYEN),0) - 
(SELECT if(tr2.fldYEN is not null,sum(tr2.fldYEN),0)FROM tblPOI tr2 where month(tr2.fldMO) = tr1.fldCode) 
from tblRevision tr1 left join
tblBudget tr2 on tr1.fldBudRefNum = tr2.fldBudRefNum
where tr1.fldStat != 'CLOSE' and month(tr2.fldMBudgeted) = tr1.fldCode
and left(tr1.fldBudRefNum,9) != 'NO BUDGET'
)) as 'RemBudNB',
((select if(tr1.fldYEN is not null,sum(tr1.fldYEN),0) - 
(SELECT if(tr2.fldYEN is not null,sum(tr2.fldYEN),0)FROM tblPOI tr2 where month(tr2.fldMO) = tr1.fldCode) 
from tblRevision tr1 left join
tblBudget tr2 on tr1.fldBudRefNum = tr2.fldBudRefNum
where tr1.fldStat != 'CLOSE' and month(tr2.fldMBudgeted) = tr1.fldCode
)) as 'RemBudWNB'
from tblMonth tr1;
end$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_RWG`(
	IN D1    datetime,
	IN D2    datetime
)
BEGIN
select tr1.fldDeptCode ,
 CONCAT('Department Expense ',(if(YEAR(D1) != YEAR(D2),CONCAT(MONTHNAME(D1),' ',YEAR(D1) , ' - ' , YEAR(D2)),CONCAT(MONTHNAME(D1),' ',YEAR(D1))))) AS 'Byear'
,
(
select if(tr2.fldYen is not null,sum(tr2.fldYen),0) from tblBudget tr2 where
 tr2.fldMBudgeted >= D1 and tr2.fldMBudgeted <= D2 and
 tr2.fldDept = tr1.fldDeptCode
) as Budget
,
(
SELECT 
			(
			case 
			WHEN T3.Currency = 'JPY' THEN (T3.Price * T3.Quantity) - ((T3.Price * T3.Quantity)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'USD' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'PHP' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			End)
			FROM POR1 T1 
			LEFT OUTER JOIN OPOR T2 
			ON T1.DocEntry = T2.DocEntry 
			LEFT OUTER JOIN PDN1 T3 
			ON T2.DocEntry = T3.BaseEntry 
			AND T1.LineNum = T3.BaseLine 
			AND T1.ItemCode = T3.ItemCode 
			LEFT OUTER JOIN OPDN T4 
			ON T3.DocEntry = T4.DocEntry 
			LEFT OUTER JOIN RPD1 T5 
			ON T4.DocEntry = T5.BaseEntry 
			AND T3.LineNum = T5.BaseLine 
			AND T3.ItemCode = T5.ItemCode 
			LEFT OUTER JOIN ORPD T6 
			ON T5.DocEntry = T6.DocEntry 
			LEFT OUTER JOIN PCH1 T7 
			ON T4.DocEntry = T7.BaseEntry 
			AND T3.LineNum = T7.BaseLine 
			AND T3.ItemCode = T7.ItemCode 
			LEFT OUTER JOIN OPCH T8 
			ON T7.DocEntry = T8.DocEntry 
			LEFT OUTER JOIN RPC1 T9 
			ON T8.DocEntry = T9.BaseEntry 
			AND T7.LineNum = T9.BaseLine 
			AND T7.ItemCode = T9.ItemCode 
			LEFT OUTER JOIN ORPC T10 
			ON T9.DocEntry = T10.DocEntry 
			WHERE T2.U_HeaderID Is Not null 
			and T6.DocNum is null 
			and T10.DocNum is null 
			and T4.DocNum is not null 
			and (SELECT bud.fldDept from tblBudget bud where bud.fldBudRefNum = T1.U_BudgetRef) = tr1.fldDeptCode and
			T4.DocDueDate >= D1 and T4.DocDueDate <= D2

) as Actual
,
(
SELECT 
			((
			case 
			WHEN T3.Currency = 'JPY' THEN (T3.Price * T3.Quantity) - ((T3.Price * T3.Quantity)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'USD' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'PHP' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			End)- T3.U_fldYen)
			FROM POR1 T1 
			LEFT OUTER JOIN OPOR T2 
			ON T1.DocEntry = T2.DocEntry 
			LEFT OUTER JOIN PDN1 T3 
			ON T2.DocEntry = T3.BaseEntry 
			AND T1.LineNum = T3.BaseLine 
			AND T1.ItemCode = T3.ItemCode 
			LEFT OUTER JOIN OPDN T4 
			ON T3.DocEntry = T4.DocEntry 
			LEFT OUTER JOIN RPD1 T5 
			ON T4.DocEntry = T5.BaseEntry 
			AND T3.LineNum = T5.BaseLine 
			AND T3.ItemCode = T5.ItemCode 
			LEFT OUTER JOIN ORPD T6 
			ON T5.DocEntry = T6.DocEntry 
			LEFT OUTER JOIN PCH1 T7 
			ON T4.DocEntry = T7.BaseEntry 
			AND T3.LineNum = T7.BaseLine 
			AND T3.ItemCode = T7.ItemCode 
			LEFT OUTER JOIN OPCH T8 
			ON T7.DocEntry = T8.DocEntry 
			LEFT OUTER JOIN RPC1 T9 
			ON T8.DocEntry = T9.BaseEntry 
			AND T7.LineNum = T9.BaseLine 
			AND T7.ItemCode = T9.ItemCode 
			LEFT OUTER JOIN ORPC T10 
			ON T9.DocEntry = T10.DocEntry 
			WHERE T2.U_HeaderID Is Not null 
			and T6.DocNum is null 
			and T10.DocNum is null 
			and T4.DocNum is not null 
			and (SELECT bud.fldDept from tblBudget bud where bud.fldBudRefNum = T1.U_BudgetRef) = tr1.fldDeptCode and
			T4.DocDueDate >= D1 and T4.DocDueDate <= D2

) as Forex,
(
SELECT IF(POI.fldYenSap IS NOT NULL,SUM(POI.fldYenSap),0) from tblPOI POI
 where POI.fldDept = tr1.fldDeptCode
 and POI.fldStat != 'CLOSE' and POI.fldMO >= D1 and POI.fldMO <= D2
AND POI.fldForcePO = 'YES'
) +
(select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) 
from tblUPO UPO where UPO.fldDept = tr1.fldDeptCode and 
UPO.fldDDate >= D1 and UPO.fldDDate <= D2)
  as FActual,
(
SELECT IF(POI.fldYenSap IS NOT NULL,SUM(POI.fldYenSap),0) - IF(POI.fldYen IS NOT NULL,SUM(POI.fldYen),0) from tblPOI POI
 where POI.fldDept = tr1.fldDeptCode
 and POI.fldStat != 'CLOSE' and POI.fldMO >= D1 and POI.fldMO <= D2
AND POI.fldForcePO = 'YES'
) +
(select if(UPO.fldForex is not null,sum(UPO.fldForex),0) 
from tblUPO UPO where UPO.fldDept = tr1.fldDeptCode and 
UPO.fldDDate >= D1 and UPO.fldDDate <= D2)
  as FActualForex,
(
select if(tr3.fldYen is not null,sum(tr3.fldYen),0) from tblBudget tr3 where
 tr3.fldMBudgeted >= YEAR(D1)+'-'+'01-01' and tr3.fldMBudgeted <= D2 and
 tr3.fldDept = tr1.fldDeptCode
) as BudgetYTD
,
(
SELECT 
			(
			case 
			WHEN T3.Currency = 'JPY' THEN (T3.Price * T3.Quantity) - ((T3.Price * T3.Quantity)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'USD' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'PHP' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			End)
			FROM POR1 T1 
			LEFT OUTER JOIN OPOR T2 
			ON T1.DocEntry = T2.DocEntry 
			LEFT OUTER JOIN PDN1 T3 
			ON T2.DocEntry = T3.BaseEntry 
			AND T1.LineNum = T3.BaseLine 
			AND T1.ItemCode = T3.ItemCode 
			LEFT OUTER JOIN OPDN T4 
			ON T3.DocEntry = T4.DocEntry 
			LEFT OUTER JOIN RPD1 T5 
			ON T4.DocEntry = T5.BaseEntry 
			AND T3.LineNum = T5.BaseLine 
			AND T3.ItemCode = T5.ItemCode 
			LEFT OUTER JOIN ORPD T6 
			ON T5.DocEntry = T6.DocEntry 
			LEFT OUTER JOIN PCH1 T7 
			ON T4.DocEntry = T7.BaseEntry 
			AND T3.LineNum = T7.BaseLine 
			AND T3.ItemCode = T7.ItemCode 
			LEFT OUTER JOIN OPCH T8 
			ON T7.DocEntry = T8.DocEntry 
			LEFT OUTER JOIN RPC1 T9 
			ON T8.DocEntry = T9.BaseEntry 
			AND T7.LineNum = T9.BaseLine 
			AND T7.ItemCode = T9.ItemCode 
			LEFT OUTER JOIN ORPC T10 
			ON T9.DocEntry = T10.DocEntry 
			WHERE T2.U_HeaderID Is Not null 
			and T6.DocNum is null 
			and T10.DocNum is null 
			and T4.DocNum is not null 
			and (SELECT bud.fldDept from tblBudget bud where bud.fldBudRefNum = T1.U_BudgetRef) = tr1.fldDeptCode and
T4.DocDueDate >= YEAR(D1)+'-'+'01-01' and T4.DocDueDate <= D2
) as ActualYTD,
(
SELECT 
			((
			case 
			WHEN T3.Currency = 'JPY' THEN (T3.Price * T3.Quantity) - ((T3.Price * T3.Quantity)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'USD' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'PHP' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			End) - T3.U_fldYen)
			FROM POR1 T1 
			LEFT OUTER JOIN OPOR T2 
			ON T1.DocEntry = T2.DocEntry 
			LEFT OUTER JOIN PDN1 T3 
			ON T2.DocEntry = T3.BaseEntry 
			AND T1.LineNum = T3.BaseLine 
			AND T1.ItemCode = T3.ItemCode 
			LEFT OUTER JOIN OPDN T4 
			ON T3.DocEntry = T4.DocEntry 
			LEFT OUTER JOIN RPD1 T5 
			ON T4.DocEntry = T5.BaseEntry 
			AND T3.LineNum = T5.BaseLine 
			AND T3.ItemCode = T5.ItemCode 
			LEFT OUTER JOIN ORPD T6 
			ON T5.DocEntry = T6.DocEntry 
			LEFT OUTER JOIN PCH1 T7 
			ON T4.DocEntry = T7.BaseEntry 
			AND T3.LineNum = T7.BaseLine 
			AND T3.ItemCode = T7.ItemCode 
			LEFT OUTER JOIN OPCH T8 
			ON T7.DocEntry = T8.DocEntry 
			LEFT OUTER JOIN RPC1 T9 
			ON T8.DocEntry = T9.BaseEntry 
			AND T7.LineNum = T9.BaseLine 
			AND T7.ItemCode = T9.ItemCode 
			LEFT OUTER JOIN ORPC T10 
			ON T9.DocEntry = T10.DocEntry 
			WHERE T2.U_HeaderID Is Not null 
			and T6.DocNum is null 
			and T10.DocNum is null 
			and T4.DocNum is not null 
			and (SELECT bud.fldDept from tblBudget bud where bud.fldBudRefNum = T1.U_BudgetRef) = tr1.fldDeptCode and
T4.DocDueDate >= YEAR(D1)+'-'+'01-01' and T4.DocDueDate <= D2
) as ForexYTD,
(
SELECT IF(POI.fldYenSap IS NOT NULL,SUM(POI.fldYenSap),0) from tblPOI POI
 where POI.fldDept = tr1.fldDeptCode
 and POI.fldStat != 'CLOSE' and POI.fldMO >= YEAR(D1)+'-'+'01-01' and POI.fldMO <= D2
AND POI.fldForcePO = 'YES'
) 
+
(select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) 
from tblUPO UPO where UPO.fldDept = tr1.fldDeptCode and 
UPO.fldDDate >= YEAR(D1)+'-'+'01-01' and UPO.fldDDate <= D2)
  as FActualYTD
,
(
SELECT IF(POI.fldYenSap IS NOT NULL,SUM(POI.fldYenSap),0) - IF(POI.fldYen IS NOT NULL,SUM(POI.fldYen),0) from tblPOI POI
 where POI.fldDept = tr1.fldDeptCode
 and POI.fldStat != 'CLOSE' and POI.fldMO >= YEAR(D1)+'-'+'01-01' and POI.fldMO <= D2
AND POI.fldForcePO = 'YES'
) 
+
(select if(UPO.fldForex is not null,sum(UPO.fldForex),0) 
from tblUPO UPO where UPO.fldDept = tr1.fldDeptCode and 
UPO.fldDDate >= YEAR(D1)+'-'+'01-01' and UPO.fldDDate <= D2)
  as FActualYTDForex
from tblDepartment tr1 where tr1.fldDeptCode != 'ALL';
END$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_RWGC`(
	IN D1    datetime,
	IN D2    datetime,
	IN Class varchar(150)
)
BEGIN
select tr1.fldDeptCode,Class as 'Class1',D1 as 'M1',D2 as 'M2',
 CONCAT(Class,' Classification ',(if(MONTHNAME(D1) != MONTHNAME(D2),CONCAT(MONTHNAME(D1) , ' - ' , MONTHNAME(D2)),MONTHNAME(D1)))) AS 'Bmonth' 
,
(
select if(tr2.fldYen is not null,sum(tr2.fldYen),0) from tblBudget tr2 where
 tr2.fldMBudgeted >= D1 and tr2.fldMBudgeted <= D2 and
 tr2.fldDept = tr1.fldDeptCode and
if(Class = 'ALL',
INSTR( ',' + tr2.fldClass + ',', ',' + (select group_concat(fldClassCode) as fldClass from tblClass ) + ',' ) > 0,tr2.fldClass = Class)
) as Budget
,
(
SELECT 
			(
			case 
			WHEN T3.Currency = 'JPY' THEN (T3.Price * T3.Quantity) - ((T3.Price * T3.Quantity)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'USD' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'PHP' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			End)
			FROM POR1 T1 
			LEFT OUTER JOIN OPOR T2 
			ON T1.DocEntry = T2.DocEntry 
			LEFT OUTER JOIN PDN1 T3 
			ON T2.DocEntry = T3.BaseEntry 
			AND T1.LineNum = T3.BaseLine 
			AND T1.ItemCode = T3.ItemCode 
			LEFT OUTER JOIN OPDN T4 
			ON T3.DocEntry = T4.DocEntry 
			LEFT OUTER JOIN RPD1 T5 
			ON T4.DocEntry = T5.BaseEntry 
			AND T3.LineNum = T5.BaseLine 
			AND T3.ItemCode = T5.ItemCode 
			LEFT OUTER JOIN ORPD T6 
			ON T5.DocEntry = T6.DocEntry 
			LEFT OUTER JOIN PCH1 T7 
			ON T4.DocEntry = T7.BaseEntry 
			AND T3.LineNum = T7.BaseLine 
			AND T3.ItemCode = T7.ItemCode 
			LEFT OUTER JOIN OPCH T8 
			ON T7.DocEntry = T8.DocEntry 
			LEFT OUTER JOIN RPC1 T9 
			ON T8.DocEntry = T9.BaseEntry 
			AND T7.LineNum = T9.BaseLine 
			AND T7.ItemCode = T9.ItemCode 
			LEFT OUTER JOIN ORPC T10 
			ON T9.DocEntry = T10.DocEntry 
			WHERE T2.U_HeaderID Is Not null 
			and T6.DocNum is null 
			and T10.DocNum is null 
			and T4.DocNum is not null 
			and (SELECT bud.fldDept from tblBudget bud where bud.fldBudRefNum = T1.U_BudgetRef) = tr1.fldDeptCode and
			T4.DocDueDate >= D1 and T4.DocDueDate <= D2 AND
if(Class = 'ALL',
INSTR( ',' + (SELECT POI.fldClass from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE') + ',', ',' + (select group_concat(fldClassDesc) as fldClassDesc from tblClass) + ',' ) > 0,(SELECT POI.fldClass from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE') = Class)

) as Actual,
(
SELECT 
			((
			case 
			WHEN T3.Currency = 'JPY' THEN (T3.Price * T3.Quantity) - ((T3.Price * T3.Quantity)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'USD' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'PHP' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			End) - T3.U_fldYen)
			FROM POR1 T1 
			LEFT OUTER JOIN OPOR T2 
			ON T1.DocEntry = T2.DocEntry 
			LEFT OUTER JOIN PDN1 T3 
			ON T2.DocEntry = T3.BaseEntry 
			AND T1.LineNum = T3.BaseLine 
			AND T1.ItemCode = T3.ItemCode 
			LEFT OUTER JOIN OPDN T4 
			ON T3.DocEntry = T4.DocEntry 
			LEFT OUTER JOIN RPD1 T5 
			ON T4.DocEntry = T5.BaseEntry 
			AND T3.LineNum = T5.BaseLine 
			AND T3.ItemCode = T5.ItemCode 
			LEFT OUTER JOIN ORPD T6 
			ON T5.DocEntry = T6.DocEntry 
			LEFT OUTER JOIN PCH1 T7 
			ON T4.DocEntry = T7.BaseEntry 
			AND T3.LineNum = T7.BaseLine 
			AND T3.ItemCode = T7.ItemCode 
			LEFT OUTER JOIN OPCH T8 
			ON T7.DocEntry = T8.DocEntry 
			LEFT OUTER JOIN RPC1 T9 
			ON T8.DocEntry = T9.BaseEntry 
			AND T7.LineNum = T9.BaseLine 
			AND T7.ItemCode = T9.ItemCode 
			LEFT OUTER JOIN ORPC T10 
			ON T9.DocEntry = T10.DocEntry 
			WHERE T2.U_HeaderID Is Not null 
			and T6.DocNum is null 
			and T10.DocNum is null 
			and T4.DocNum is not null 
			and (SELECT bud.fldDept from tblBudget bud where bud.fldBudRefNum = T1.U_BudgetRef) = tr1.fldDeptCode and
			T4.DocDueDate >= D1 and T4.DocDueDate <= D2 AND
if(Class = 'ALL',
INSTR( ',' + (SELECT POI.fldClass from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE') + ',', ',' + (select group_concat(fldClassDesc) as fldClassDesc from tblClass) + ',' ) > 0,(SELECT POI.fldClass from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE') = Class)

) as Forex,
(
SELECT IF(POI.fldYenSap IS NOT NULL,SUM(POI.fldYenSap),0) from tblPOI POI
 where POI.fldDept = tr1.fldDeptCode
 and POI.fldStat != 'CLOSE' and POI.fldMO >= D1 and POI.fldMO <= D2 and
POI.fldForcePO = 'YES' and
if(Class = 'ALL',
INSTR( ',' + (POI.fldClass) + ',', ',' + (select group_concat(fldClassDesc) as fldClassDesc from tblClass) + ',' ) > 0,(POI.fldClass) = Class)
)
+
(select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) 
from tblUPO UPO where UPO.fldDept = tr1.fldDeptCode and 
UPO.fldDDate >= D1 and UPO.fldDDate <= D2 and
if(Class = 'ALL',
INSTR( ',' + (UPO.fldClass) + ',', ',' + (select group_concat(fldClassDesc) as fldClassDesc from tblClass) + ',' ) > 0,(UPO.fldClass) = Class)
)as FActual,
(
SELECT IF(POI.fldYenSap IS NOT NULL,SUM(POI.fldYenSap),0) - IF(POI.fldYen IS NOT NULL,SUM(POI.fldYen),0) from tblPOI POI
 where POI.fldDept = tr1.fldDeptCode
 and POI.fldStat != 'CLOSE' and POI.fldMO >= D1 and POI.fldMO <= D2 and
POI.fldForcePO = 'YES' and
if(Class = 'ALL',
INSTR( ',' + (POI.fldClass) + ',', ',' + (select group_concat(fldClassDesc) as fldClassDesc from tblClass) + ',' ) > 0,(POI.fldClass) = Class)
)
+
(select if(UPO.fldForex is not null,sum(UPO.fldForex),0) 
from tblUPO UPO where UPO.fldDept = tr1.fldDeptCode and 
UPO.fldDDate >= D1 and UPO.fldDDate <= D2 and
if(Class = 'ALL',
INSTR( ',' + (UPO.fldClass) + ',', ',' + (select group_concat(fldClassDesc) as fldClassDesc from tblClass) + ',' ) > 0,(UPO.fldClass) = Class)
)as FActualForex,
(
select if(tr3.fldYen is not null,sum(tr3.fldYen),0) from tblBudget tr3 where
 tr3.fldMBudgeted >= YEAR(D1)+'-'+'01-01' and tr3.fldMBudgeted <= D2 and
 tr3.fldDept = tr1.fldDeptCode and
if(Class = 'ALL',
INSTR( ',' + tr3.fldClass + ',', ',' + (select group_concat(fldClassCode) as fldClass from tblClass ) + ',' ) > 0,tr3.fldClass = Class)

) as BudgetYTD
,
(
SELECT 
			(
			case 
			WHEN T3.Currency = 'JPY' THEN (T3.Price * T3.Quantity) - ((T3.Price * T3.Quantity)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'USD' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'PHP' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			End)
			FROM POR1 T1 
			LEFT OUTER JOIN OPOR T2 
			ON T1.DocEntry = T2.DocEntry 
			LEFT OUTER JOIN PDN1 T3 
			ON T2.DocEntry = T3.BaseEntry 
			AND T1.LineNum = T3.BaseLine 
			AND T1.ItemCode = T3.ItemCode 
			LEFT OUTER JOIN OPDN T4 
			ON T3.DocEntry = T4.DocEntry 
			LEFT OUTER JOIN RPD1 T5 
			ON T4.DocEntry = T5.BaseEntry 
			AND T3.LineNum = T5.BaseLine 
			AND T3.ItemCode = T5.ItemCode 
			LEFT OUTER JOIN ORPD T6 
			ON T5.DocEntry = T6.DocEntry 
			LEFT OUTER JOIN PCH1 T7 
			ON T4.DocEntry = T7.BaseEntry 
			AND T3.LineNum = T7.BaseLine 
			AND T3.ItemCode = T7.ItemCode 
			LEFT OUTER JOIN OPCH T8 
			ON T7.DocEntry = T8.DocEntry 
			LEFT OUTER JOIN RPC1 T9 
			ON T8.DocEntry = T9.BaseEntry 
			AND T7.LineNum = T9.BaseLine 
			AND T7.ItemCode = T9.ItemCode 
			LEFT OUTER JOIN ORPC T10 
			ON T9.DocEntry = T10.DocEntry 
			WHERE T2.U_HeaderID Is Not null 
			and T6.DocNum is null 
			and T10.DocNum is null 
			and T4.DocNum is not null 
			and (SELECT bud.fldDept from tblBudget bud where bud.fldBudRefNum = T1.U_BudgetRef) = tr1.fldDeptCode and
T4.DocDueDate >= YEAR(D1)+'-'+'01-01' and T4.DocDueDate <= D2 AND
if(Class = 'ALL',
INSTR( ',' + (SELECT POI.fldClass from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE') + ',', ',' + (select group_concat(fldClassDesc) as fldClassDesc from tblClass) + ',' ) > 0,(SELECT POI.fldClass from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE') = Class)

) as ActualYTD,
(
SELECT 
			((
			case 
			WHEN T3.Currency = 'JPY' THEN (T3.Price * T3.Quantity) - ((T3.Price * T3.Quantity)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'USD' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			WHEN T3.Currency = 'PHP' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
			End) - T3.U_fldYen)
			FROM POR1 T1 
			LEFT OUTER JOIN OPOR T2 
			ON T1.DocEntry = T2.DocEntry 
			LEFT OUTER JOIN PDN1 T3 
			ON T2.DocEntry = T3.BaseEntry 
			AND T1.LineNum = T3.BaseLine 
			AND T1.ItemCode = T3.ItemCode 
			LEFT OUTER JOIN OPDN T4 
			ON T3.DocEntry = T4.DocEntry 
			LEFT OUTER JOIN RPD1 T5 
			ON T4.DocEntry = T5.BaseEntry 
			AND T3.LineNum = T5.BaseLine 
			AND T3.ItemCode = T5.ItemCode 
			LEFT OUTER JOIN ORPD T6 
			ON T5.DocEntry = T6.DocEntry 
			LEFT OUTER JOIN PCH1 T7 
			ON T4.DocEntry = T7.BaseEntry 
			AND T3.LineNum = T7.BaseLine 
			AND T3.ItemCode = T7.ItemCode 
			LEFT OUTER JOIN OPCH T8 
			ON T7.DocEntry = T8.DocEntry 
			LEFT OUTER JOIN RPC1 T9 
			ON T8.DocEntry = T9.BaseEntry 
			AND T7.LineNum = T9.BaseLine 
			AND T7.ItemCode = T9.ItemCode 
			LEFT OUTER JOIN ORPC T10 
			ON T9.DocEntry = T10.DocEntry 
			WHERE T2.U_HeaderID Is Not null 
			and T6.DocNum is null 
			and T10.DocNum is null 
			and T4.DocNum is not null 
			and (SELECT bud.fldDept from tblBudget bud where bud.fldBudRefNum = T1.U_BudgetRef) = tr1.fldDeptCode and
T4.DocDueDate >= YEAR(D1)+'-'+'01-01' and T4.DocDueDate <= D2 AND
if(Class = 'ALL',
INSTR( ',' + (SELECT POI.fldClass from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE') + ',', ',' + (select group_concat(fldClassDesc) as fldClassDesc from tblClass) + ',' ) > 0,(SELECT POI.fldClass from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE') = Class)

) as ForexYTD,
(
SELECT IF(POI.fldYenSap IS NOT NULL,SUM(POI.fldYenSap),0) from tblPOI POI
 where POI.fldDept = tr1.fldDeptCode and
POI.fldForcePO = 'YES' 
 and POI.fldStat != 'CLOSE' and POI.fldMO >= YEAR(D1)+'-'+'01-01' and POI.fldMO <= D2 and
if(Class = 'ALL',
INSTR( ',' + (POI.fldClass) + ',', ',' + (select group_concat(fldClassDesc) as fldClassDesc from tblClass) + ',' ) > 0,(POI.fldClass) = Class)
)
+
(select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) 
from tblUPO UPO where UPO.fldDept = tr1.fldDeptCode and 
UPO.fldDDate >= YEAR(D1)+'-'+'01-01' and UPO.fldDDate <= D2 and
if(Class = 'ALL',
INSTR( ',' + (UPO.fldClass) + ',', ',' + (select group_concat(fldClassDesc) as fldClassDesc from tblClass) + ',' ) > 0,(UPO.fldClass) = Class)
)as FActualYTD,
(
SELECT IF(POI.fldYenSap IS NOT NULL,SUM(POI.fldYenSap),0) - IF(POI.fldYen IS NOT NULL,SUM(POI.fldYen),0) from tblPOI POI
 where POI.fldDept = tr1.fldDeptCode and
POI.fldForcePO = 'YES' 
 and POI.fldStat != 'CLOSE' and POI.fldMO >= YEAR(D1)+'-'+'01-01' and POI.fldMO <= D2 and
if(Class = 'ALL',
INSTR( ',' + (POI.fldClass) + ',', ',' + (select group_concat(fldClassDesc) as fldClassDesc from tblClass) + ',' ) > 0,(POI.fldClass) = Class)
)
+
(select if(UPO.fldForex is not null,sum(UPO.fldForex),0) 
from tblUPO UPO where UPO.fldDept = tr1.fldDeptCode and 
UPO.fldDDate >= YEAR(D1)+'-'+'01-01' and UPO.fldDDate <= D2 and
if(Class = 'ALL',
INSTR( ',' + (UPO.fldClass) + ',', ',' + (select group_concat(fldClassDesc) as fldClassDesc from tblClass) + ',' ) > 0,(UPO.fldClass) = Class)
)as FActualYTDForex
from tblDepartment tr1 where fldDeptCode != 'ALL';
END$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_RWGCPO`(
	IN D1    datetime,
	IN D2    datetime,
	IN Class varchar(150)
)
BEGIN
select tr1.fldDeptCode,Class as 'Class1',D1 as 'M1',D2 as 'M2',
 CONCAT(Class,' Classification ',(if(MONTHNAME(D1) != MONTHNAME(D2),CONCAT(MONTHNAME(D1) , ' - ' , MONTHNAME(D2)),MONTHNAME(D1)))) AS 'Bmonth' 
,
(
select if(tr2.fldYen is not null,sum(tr2.fldYen),0) from tblBudget tr2 where
 tr2.fldMBudgeted >= D1 and tr2.fldMBudgeted <= D2 and
 tr2.fldDept = tr1.fldDeptCode and
if(Class = 'ALL',
INSTR( ',' + tr2.fldClass + ',', ',' + (select group_concat(fldClassCode) as fldClass from tblClass ) + ',' ) > 0,tr2.fldClass = Class)
) as Budget
,

(select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) 
from tblUPO UPO where UPO.fldDept = tr1.fldDeptCode and 
UPO.fldDDate >= D1 and UPO.fldDDate <= D2 and
if(Class = 'ALL',
INSTR( ',' + (UPO.fldClass) + ',', ',' + (select group_concat(fldClassDesc) as fldClassDesc from tblClass) + ',' ) > 0,(UPO.fldClass) = Class)
)as FActual,

(select if(UPO.fldForex is not null,sum(UPO.fldForex),0) 
from tblUPO UPO where UPO.fldDept = tr1.fldDeptCode and 
UPO.fldDDate >= D1 and UPO.fldDDate <= D2 and
if(Class = 'ALL',
INSTR( ',' + (UPO.fldClass) + ',', ',' + (select group_concat(fldClassDesc) as fldClassDesc from tblClass) + ',' ) > 0,(UPO.fldClass) = Class)
)as FActualForex,
(
select if(tr3.fldYen is not null,sum(tr3.fldYen),0) from tblBudget tr3 where
 tr3.fldMBudgeted >= YEAR(D1)+'-'+'01-01' and tr3.fldMBudgeted <= D2 and
 tr3.fldDept = tr1.fldDeptCode and
if(Class = 'ALL',
INSTR( ',' + tr3.fldClass + ',', ',' + (select group_concat(fldClassCode) as fldClass from tblClass ) + ',' ) > 0,tr3.fldClass = Class)

) as BudgetYTD
,
(
SELECT IF(POI.fldYenSap IS NOT NULL,SUM(POI.fldYenSap),0) from tblPOI POI
 where POI.fldDept = tr1.fldDeptCode
 and POI.fldStat != 'CLOSE' and POI.fldMO >= D1 and POI.fldMO <= D2 and
if(Class = 'ALL',
INSTR( ',' + (POI.fldClass) + ',', ',' + (select group_concat(fldClassDesc) as fldClassDesc from tblClass) + ',' ) > 0,(POI.fldClass) = Class)

) as Actual,
(
SELECT IF(POI.fldYenSap IS NOT NULL,SUM(POI.fldYenSap),0) 
- if(POI.fldYen is not null,sum(POI.fldYen),0)
from tblPOI POI
 where POI.fldDept = tr1.fldDeptCode
 and POI.fldStat != 'CLOSE' and POI.fldMO >= D1 and POI.fldMO <= D2 and
if(Class = 'ALL',
INSTR( ',' + (POI.fldClass) + ',', ',' + (select group_concat(fldClassDesc) as fldClassDesc from tblClass) + ',' ) > 0,(POI.fldClass) = Class)

) as ActualForex,
(
SELECT IF(POI.fldYenSap IS NOT NULL,SUM(POI.fldYenSap),0) from tblPOI POI
 where POI.fldDept = tr1.fldDeptCode
 and POI.fldStat != 'CLOSE' and POI.fldMO >= YEAR(D1)+'-'+'01-01' and POI.fldMO <= D2 and
if(Class = 'ALL',
INSTR( ',' + (POI.fldClass) + ',', ',' + (select group_concat(fldClassDesc) as fldClassDesc from tblClass) + ',' ) > 0,(POI.fldClass) = Class)
) as ActualYTD,
(
SELECT IF(POI.fldYenSap IS NOT NULL,SUM(POI.fldYenSap),0) 
- if(POI.fldYen is not null,sum(POI.fldYen),0)
from tblPOI POI
 where POI.fldDept = tr1.fldDeptCode
 and POI.fldStat != 'CLOSE' and POI.fldMO >= YEAR(D1)+'-'+'01-01' and POI.fldMO <= D2 and
if(Class = 'ALL',
INSTR( ',' + (POI.fldClass) + ',', ',' + (select group_concat(fldClassDesc) as fldClassDesc from tblClass) + ',' ) > 0,(POI.fldClass) = Class)
) as ActualYTDForex,

(select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) 
from tblUPO UPO where UPO.fldDept = tr1.fldDeptCode and 
UPO.fldDDate >= YEAR(D1)+'-'+'01-01'  and UPO.fldDDate <= D2 and
if(Class = 'ALL',
INSTR( ',' + (UPO.fldClass) + ',', ',' + (select group_concat(fldClassDesc) as fldClassDesc from tblClass) + ',' ) > 0,(UPO.fldClass) = Class)
)as FActualYTD,

(select if(UPO.fldForex is not null,sum(UPO.fldForex),0) 
from tblUPO UPO where UPO.fldDept = tr1.fldDeptCode and 
UPO.fldDDate >= YEAR(D1)+'-'+'01-01'  and UPO.fldDDate <= D2 and
if(Class = 'ALL',
INSTR( ',' + (UPO.fldClass) + ',', ',' + (select group_concat(fldClassDesc) as fldClassDesc from tblClass) + ',' ) > 0,(UPO.fldClass) = Class)
)as FActualYTDForex

from tblDepartment tr1 where fldDeptCode != 'ALL';
END$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_RWGPO`(
	IN D1    datetime,
	IN D2    datetime
)
BEGIN
select tr1.fldDeptCode ,
 CONCAT('Department Expense  ',(if(YEAR(D1) != YEAR(D2),CONCAT(YEAR(D1) , ' - ' , YEAR(D2)),YEAR(D1)))) AS 'Byear'
,
(
select if(tr2.fldYen is not null,sum(tr2.fldYen),0) from tblBudget tr2 where
 tr2.fldMBudgeted >= D1 and tr2.fldMBudgeted <= D2 and
 tr2.fldDept = tr1.fldDeptCode
) as Budget
,
(
SELECT IF(POI.fldYenSap IS NOT NULL,SUM(POI.fldYenSap),0) from tblPOI POI
 where POI.fldDept = tr1.fldDeptCode
 and POI.fldStat != 'CLOSE' and POI.fldMO >= D1 and POI.fldMO <= D2
) as Actual,
(
SELECT IF(POI.fldYenSap IS NOT NULL,SUM(POI.fldYenSap),0)
- if(POI.fldYen is not null,sum(POI.fldYen),0)
 from tblPOI POI
 where POI.fldDept = tr1.fldDeptCode
 and POI.fldStat != 'CLOSE' and POI.fldMO >= D1 and POI.fldMO <= D2
) as ActualForex,

(select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) 
from tblUPO UPO where UPO.fldDept = tr1.fldDeptCode and 
UPO.fldDDate >= D1 and UPO.fldDDate <= D2 
)as FActual,

(select if(UPO.fldForex is not null,sum(UPO.fldForex),0) 
from tblUPO UPO where UPO.fldDept = tr1.fldDeptCode and 
UPO.fldDDate >= D1 and UPO.fldDDate <= D2 
)as FActualForex,
(
select if(tr3.fldYen is not null,sum(tr3.fldYen),0) from tblBudget tr3 where
 tr3.fldMBudgeted >= YEAR(D1)+'-'+'01-01' and tr3.fldMBudgeted <= D2 and
 tr3.fldDept = tr1.fldDeptCode
) as BudgetYTD
,
(
SELECT IF(POI.fldYenSap IS NOT NULL,SUM(POI.fldYenSap),0) from tblPOI POI
 where POI.fldDept = tr1.fldDeptCode
 and POI.fldStat != 'CLOSE' and POI.fldMO >= YEAR(D1)+'-'+'01-01' and POI.fldMO <= D2
) as ActualYTD
,
(
SELECT IF(POI.fldYenSap IS NOT NULL,SUM(POI.fldYenSap),0)
 - if(POI.fldYen is not null,sum(POI.fldYen),0)
from tblPOI POI
 where POI.fldDept = tr1.fldDeptCode
 and POI.fldStat != 'CLOSE' and POI.fldMO >= YEAR(D1)+'-'+'01-01' and POI.fldMO <= D2
) as ActualYTDForex
,

(select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) 
from tblUPO UPO where UPO.fldDept = tr1.fldDeptCode and 
UPO.fldDDate >= YEAR(D1)+'-'+'01-01' and UPO.fldDDate <= D2 
)as FActualYTD,

(select if(UPO.fldForex is not null,sum(UPO.fldForex),0) 
from tblUPO UPO where UPO.fldDept = tr1.fldDeptCode and 
UPO.fldDDate >= YEAR(D1)+'-'+'01-01' and UPO.fldDDate <= D2 
)as FActualYTDForex
from tblDepartment tr1 where tr1.fldDeptCode != 'ALL';
END$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_SAA`(
	IN D1    datetime,
	IN D2    datetime,
	IN DEPT   varchar(150),
	IN Class varchar(150)
)
BEGIN

SELECT 
Year(T2.DocDate) as 'Byear',
T1.U_Detail_ID, 
T1.U_BudgetRef, 
T2.U_HeaderID, 
T2.DocNum AS 'Purch-Ord', 
T2.DocDate AS 'Ord-Date', 
T2.CardCode AS 'Vend-Num', 
T1.ItemCode AS 'Product', 
T1.LineStatus AS 'Row-Stat', 
T1.Quantity AS 'Quantity', 
T1.OpenQty AS 'Open-Qty', 
T4.DocNum AS 'Goods-Rcpt', 
T4.DocDueDate AS 'Rcpt-Date', 
T3.Quantity as 'GRPO_QTY',
T3.Price,
T3.Currency,
(
case 
WHEN T3.Currency = 'JPY' THEN (T3.Price * T3.Quantity) - ((T3.Price * T3.Quantity)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
WHEN T3.Currency = 'USD' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
WHEN T3.Currency = 'PHP' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) 
End) as SAPYEN,

(select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) 
from tblUPO UPO where UPO.fldBudRefNum = T1.U_BudgetRef and 
UPO.fldDDate >= D1 and UPO.fldDDate <= D2)
 AS 'UPO',
(SELECT group_concat(POI.fldPRNo) from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE' and POI.fldMO >= D1 and POI.fldMO <= D2 ) as 'PRNO', 
(SELECT bud.fldDept from tblBudget bud where bud.fldBudRefNum = T1.U_BudgetRef) as 'Dept', 
(SELECT POI.fldSignature from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE' ) as 'fldSignature', 
(SELECT POI.fldTotalCost from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE'and POI.fldMO >= D1 and POI.fldMO <= D2 ) as 'fldTotalCost', 
(SELECT POI.fldCurrency from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE') as 'fldCurrency', 
(SELECT POI.fldYenSap from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE' and POI.fldMO >= D1 and POI.fldMO <= D2 ) as 'fldYen', 
(SELECT TPO.fldSupplier from tblPO TPO where TPO.OB_Line = T2.U_HeaderID and TPO.fldStat != 'CLOSE') as 'fldSup',  	
(SELECT POI.fldDesc from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE') as 'fldDesc',
(SELECT POI.fldClass from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE') as 'fldClass',
(SELECT TPO.fldRemarks from tblPO TPO where TPO.OB_Line = T2.U_HeaderID and TPO.fldStat != 'CLOSE' ) as 'fldRemarks',
(SELECT POI.fldSignature from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE') as 'fldSignature',
(SELECT POI.fldUnit from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID and POI.fldStat != 'CLOSE') as 'fldUnit'
FROM POR1 T1 
LEFT OUTER JOIN OPOR T2 
ON T1.DocEntry = T2.DocEntry 
LEFT OUTER JOIN PDN1 T3 
ON T2.DocEntry = T3.BaseEntry 
AND T1.LineNum = T3.BaseLine 
AND T1.ItemCode = T3.ItemCode 
LEFT OUTER JOIN OPDN T4 
ON T3.DocEntry = T4.DocEntry 
LEFT OUTER JOIN RPD1 T5 
ON T4.DocEntry = T5.BaseEntry 
AND T3.LineNum = T5.BaseLine 
AND T3.ItemCode = T5.ItemCode 
LEFT OUTER JOIN ORPD T6 
ON T5.DocEntry = T6.DocEntry 
LEFT OUTER JOIN PCH1 T7 
ON T4.DocEntry = T7.BaseEntry 
AND T3.LineNum = T7.BaseLine 
AND T3.ItemCode = T7.ItemCode 
LEFT OUTER JOIN OPCH T8 
ON T7.DocEntry = T8.DocEntry 
LEFT OUTER JOIN RPC1 T9 
ON T8.DocEntry = T9.BaseEntry 
AND T7.LineNum = T9.BaseLine 
AND T7.ItemCode = T9.ItemCode 
LEFT OUTER JOIN ORPC T10 
ON T9.DocEntry = T10.DocEntry 
WHERE T2.U_HeaderID Is Not null 
and T6.DocNum is null 
and T10.DocNum is null 
and T4.DocNum is not null 
and
T2.DocDate >= D1 and T2.DocDate <= D2 
and
if(DEPT = 'ALL',
INSTR( ',' + (SELECT bud.fldDept from tblBudget bud where bud.fldBudRefNum = T1.U_BudgetRef)  + ',', ',' + (select group_concat(fldDeptCode) as fldDeptCode from tblDepartment ) + ',' ) > 0, (SELECT bud.fldDept from tblBudget bud where bud.fldBudRefNum = T1.U_BudgetRef) = DEPT)
and
if(Class = 'ALL',
INSTR( ',' + (SELECT POI.fldClass from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID AND POI.fldStat != 'CLOSE') + ',', ',' + (select group_concat(fldClassDesc) as fldClassDesc from tblClass) + ',' ) > 0,(SELECT POI.fldClass from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID  AND POI.fldStat != 'CLOSE') = Class);

END$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_Select_UPO`(
	IN DEPT varchar(150),
	IN D1 datetime,
	IN D2 datetime
)
BEGIN

SELECT * FROM tblUPO;

END$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_SOrderList`(
	IN DEPT varchar(150),
	IN PO varchar(50),
	IN D1 datetime,
	IN D2 datetime
)
BEGIN
SELECT if(tr3.fldTransCode is not null,tr3.fldTransCode,'no transcode') as 'transcode', tr3.fldUOM,tr3.fldOrderID,tr3.fldBudRefNum,tr3.fldPONo,tr3.fldPRNo,tr3.fldMonthOrder 
,tr3.fldOrderSupplier,tr3.fldOrderDesc,tr3.fldClassification,tr3.fldReason 
,tr3.fldOrderDepartment,tr3.fldProcess,(if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) 
from tblMOI tr4 where tr4.fldTransCode = tr3.fldTransCode and tr4.fldStat = 'OPEN'),tr3.fldAmountJPY)) as 'fldAmountJPY',
tr3.fldMonthDelivery,tr3.fldOrderStatus,tr3.fldOrderRemarks,tr3.fldCurrency,year(tr3.fldMonthOrder) as Byear, 
(CASE 
WHEN tr3.fldCurrency = 'USD' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMOI tr4 where tr4.fldTransCode = tr3.fldTransCode and tr4.fldStat = 'OPEN'),tr3.fldAmountJPY)) 
WHEN tr3.fldCurrency = 'PHP' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMOI tr4 where tr4.fldTransCode = tr3.fldTransCode and tr4.fldStat = 'OPEN'),tr3.fldAmountJPY)) / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'PHP-USD') 
WHEN tr3.fldCurrency = 'YEN' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMOI tr4 where tr4.fldTransCode = tr3.fldTransCode and tr4.fldStat = 'OPEN'),tr3.fldAmountJPY)) /(select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'USD-YEN') 
END) as USD, 
(CASE 
WHEN tr3.fldCurrency = 'PHP' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMOI tr4 where tr4.fldTransCode = tr3.fldTransCode and tr4.fldStat = 'OPEN'),tr3.fldAmountJPY)) 
WHEN tr3.fldCurrency = 'USD' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMOI tr4 where tr4.fldTransCode = tr3.fldTransCode and tr4.fldStat = 'OPEN'),tr3.fldAmountJPY)) * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'PHP-USD') 
WHEN tr3.fldCurrency = 'YEN' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMOI tr4 where tr4.fldTransCode = tr3.fldTransCode and tr4.fldStat = 'OPEN'),tr3.fldAmountJPY)) * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'YEN-PHP') 
END) as PHP, 
(CASE 
WHEN tr3.fldCurrency = 'YEN' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMOI tr4 where tr4.fldTransCode = tr3.fldTransCode and tr4.fldStat = 'OPEN'),tr3.fldAmountJPY)) 
WHEN tr3.fldCurrency = 'USD' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMOI tr4 where tr4.fldTransCode = tr3.fldTransCode and tr4.fldStat = 'OPEN'),tr3.fldAmountJPY)) * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'USD-YEN') 
WHEN tr3.fldCurrency = 'PHP' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMOI tr4 where tr4.fldTransCode = tr3.fldTransCode and tr4.fldStat = 'OPEN'),tr3.fldAmountJPY)) / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'YEN-PHP') 
END) as YEN 
,
(select trqty.fldQTY -
(((Select (If(tr5.fldQTY Is Not null, sum(tr5.fldQTY), 0)) from tblOrder tr5 
where tr5.fldOrderStatus = 'OPEN' and tr5.fldBudRefNum = tr3.fldBudRefNum 
and tr5.fldTransCode is null) + 
(select distinct if(tr6.fldQTY is not null,sum(tr6.fldQTY),0) 
from tblMOI tr6 left join tblOrder tr8 on tr6.fldTransCode = tr8.fldTransCode 
where tr8.fldBudRefNum = tr3.fldBudRefNum and tr6.fldStat = 'OPEN' and tr8.fldTransCode is not null
)) + 
((select (IF(tr4.fldQTY IS NOT NULL,sum(tr4.fldQTY),0)) 
from tblActualAcquisition tr4 left join tblBudget trmain on trmain.fldBudRefNum = tr4.fldBudRefNum 
where trmain.fldBudRefNum = tr3.fldBudRefNum 
and tr4.fldTransCode is null and left(tr4.fldBudRefNum,9) != 'NO BUDGET') + 
(select 
IF(tr9.fldQTY IS NOT NULL,sum(tr9.fldQTY),0) 
from tblMAI tr9 left join tblOrder trqty0 on tr9.fldTransCode = trqty0.fldTransCode 
where trqty0.fldBudRefNum = tr3.fldBudRefNum AND tr9.fldStat = 'OPEN' AND trqty0.fldTransCode is not null))) 
from tblRevision trqty where trqty.fldBudRefNum = tr3.fldBudRefNum and trqty.fldRevNum = (SELECT MAX(`fldRevNum`) 
FROM tblRevision WHERE fldBudRefNum = tr3.fldBudRefNum)) as 'fldQTY'
FROM tblOrder tr3 where  tr3.fldMonthOrder >= D1 and tr3.fldMonthOrder <= D2
and
if(DEPT = 'ALL',
INSTR( ',' + tr3.fldOrderDepartment + ',', ',' + (select group_concat(fldDeptCode) as fldDeptCode from tblDepartment ) + ',' ) > 0,tr3.fldOrderDepartment = DEPT)
and
if(PO = 'ALL',
INSTR( ',' + tr3.fldPONo + ',', ',' + (select group_concat(fldPONo) as fldPONo from tblOrder) + ',' ) > 0,tr3.fldPONo = PO)
;
END$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_Test`()
BEGIN
select * from tblPO where fldPONO is not null = false;
END$$

CREATE DEFINER=`feap`@`%` PROCEDURE `SP_Update`(
	IN PO varchar(500),
	IN OL varchar(500)
)
BEGIN
UPDATE tblPO SET  fldPONO = PO  where OB_Line = OL;
UPDATE tblPOI SET  fldPONO = PO  where OB_Line = OL;
end$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `OPCH`
--

CREATE TABLE IF NOT EXISTS `OPCH` (
  `DocEntry` int(11) NOT NULL,
  `DocNum` int(11) NOT NULL,
  `DocType` char(1) DEFAULT 'I',
  `CANCELED` char(1) DEFAULT 'N',
  `Handwrtten` char(1) DEFAULT 'N',
  `Printed` char(1) DEFAULT 'N',
  `DocStatus` char(1) DEFAULT 'O',
  `InvntSttus` char(1) DEFAULT 'O',
  `Transfered` char(1) DEFAULT 'N',
  `ObjType` varchar(20) DEFAULT '18',
  `DocDate` datetime DEFAULT NULL,
  `DocDueDate` datetime DEFAULT NULL,
  `CardCode` varchar(15) DEFAULT NULL,
  `CardName` varchar(100) DEFAULT NULL,
  `Address` varchar(254) DEFAULT NULL,
  `NumAtCard` varchar(100) DEFAULT NULL,
  `VatPercent` decimal(19,6) DEFAULT NULL,
  `VatSum` decimal(19,6) DEFAULT NULL,
  `VatSumFC` decimal(19,6) DEFAULT NULL,
  `DiscPrcnt` decimal(19,6) DEFAULT NULL,
  `DiscSum` decimal(19,6) DEFAULT NULL,
  `DiscSumFC` decimal(19,6) DEFAULT NULL,
  `DocCur` varchar(3) DEFAULT NULL,
  `DocRate` decimal(19,6) DEFAULT NULL,
  `DocTotal` decimal(19,6) DEFAULT NULL,
  `DocTotalFC` decimal(19,6) DEFAULT NULL,
  `PaidToDate` decimal(19,6) DEFAULT NULL,
  `PaidFC` decimal(19,6) DEFAULT NULL,
  `GrosProfit` decimal(19,6) DEFAULT NULL,
  `GrosProfFC` decimal(19,6) DEFAULT NULL,
  `Ref1` varchar(11) DEFAULT NULL,
  `Ref2` varchar(11) DEFAULT NULL,
  `Comments` varchar(254) DEFAULT NULL,
  `JrnlMemo` varchar(50) DEFAULT NULL,
  `TransId` int(11) DEFAULT NULL,
  `ReceiptNum` int(11) DEFAULT NULL,
  `GroupNum` smallint(6) DEFAULT NULL,
  `DocTime` smallint(6) DEFAULT NULL,
  `SlpCode` smallint(6) DEFAULT '-1',
  `TrnspCode` smallint(6) DEFAULT '-1',
  `PartSupply` char(1) DEFAULT 'Y',
  `Confirmed` char(1) DEFAULT 'Y',
  `GrossBase` smallint(6) DEFAULT '0',
  `ImportEnt` int(11) DEFAULT NULL,
  `CreateTran` char(1) DEFAULT 'N',
  `SummryType` char(1) DEFAULT 'N',
  `UpdInvnt` char(1) DEFAULT 'N',
  `UpdCardBal` char(1) DEFAULT 'N',
  `Instance` smallint(6) NOT NULL DEFAULT '0',
  `Flags` int(11) DEFAULT '0',
  `InvntDirec` char(1) DEFAULT 'X',
  `CntctCode` int(11) DEFAULT NULL,
  `ShowSCN` char(1) DEFAULT 'N',
  `FatherCard` varchar(15) DEFAULT NULL,
  `SysRate` decimal(19,6) DEFAULT NULL,
  `CurSource` char(1) DEFAULT 'C',
  `VatSumSy` decimal(19,6) DEFAULT NULL,
  `DiscSumSy` decimal(19,6) DEFAULT NULL,
  `DocTotalSy` decimal(19,6) DEFAULT NULL,
  `PaidSys` decimal(19,6) DEFAULT NULL,
  `FatherType` char(1) DEFAULT 'P',
  `GrosProfSy` decimal(19,6) DEFAULT NULL,
  `UpdateDate` datetime DEFAULT NULL,
  `IsICT` char(1) DEFAULT 'N',
  `CreateDate` datetime DEFAULT NULL,
  `Volume` decimal(19,6) DEFAULT NULL,
  `VolUnit` smallint(6) DEFAULT NULL,
  `Weight` decimal(19,6) DEFAULT NULL,
  `WeightUnit` smallint(6) DEFAULT NULL,
  `Series` smallint(6) DEFAULT NULL,
  `TaxDate` datetime DEFAULT NULL,
  `Filler` varchar(8) DEFAULT NULL,
  `DataSource` char(1) DEFAULT 'N',
  `StampNum` varchar(16) DEFAULT NULL,
  `isCrin` char(1) DEFAULT 'N',
  `FinncPriod` int(11) DEFAULT NULL,
  `UserSign` smallint(6) DEFAULT NULL,
  `selfInv` char(1) DEFAULT 'N',
  `VatPaid` decimal(19,6) DEFAULT NULL,
  `VatPaidFC` decimal(19,6) DEFAULT NULL,
  `VatPaidSys` decimal(19,6) DEFAULT NULL,
  `UserSign2` smallint(6) DEFAULT NULL,
  `WddStatus` char(1) DEFAULT '-',
  `draftKey` int(11) DEFAULT '-1',
  `TotalExpns` decimal(19,6) DEFAULT NULL,
  `TotalExpFC` decimal(19,6) DEFAULT NULL,
  `TotalExpSC` decimal(19,6) DEFAULT NULL,
  `DunnLevel` int(11) DEFAULT NULL,
  `Address2` varchar(254) DEFAULT NULL,
  `LogInstanc` smallint(6) DEFAULT '0',
  `Exported` char(1) DEFAULT 'N',
  `StationID` int(11) DEFAULT NULL,
  `Indicator` varchar(2) DEFAULT NULL,
  `NetProc` char(1) DEFAULT 'N',
  `AqcsTax` decimal(19,6) DEFAULT NULL,
  `AqcsTaxFC` decimal(19,6) DEFAULT NULL,
  `AqcsTaxSC` decimal(19,6) DEFAULT NULL,
  `CashDiscPr` decimal(19,6) DEFAULT NULL,
  `CashDiscnt` decimal(19,6) DEFAULT NULL,
  `CashDiscFC` decimal(19,6) DEFAULT NULL,
  `CashDiscSC` decimal(19,6) DEFAULT NULL,
  `ShipToCode` varchar(50) DEFAULT NULL,
  `LicTradNum` varchar(32) DEFAULT NULL,
  `PaymentRef` varchar(27) DEFAULT NULL,
  `WTSum` decimal(19,6) DEFAULT NULL,
  `WTSumFC` decimal(19,6) DEFAULT NULL,
  `WTSumSC` decimal(19,6) DEFAULT NULL,
  `RoundDif` decimal(19,6) DEFAULT NULL,
  `RoundDifFC` decimal(19,6) DEFAULT NULL,
  `RoundDifSy` decimal(19,6) DEFAULT NULL,
  `CheckDigit` char(1) DEFAULT NULL,
  `Form1099` int(11) DEFAULT NULL,
  `Box1099` varchar(20) DEFAULT NULL,
  `submitted` char(1) DEFAULT 'N',
  `PoPrss` char(1) DEFAULT 'N',
  `Rounding` char(1) DEFAULT 'N',
  `RevisionPo` char(1) DEFAULT 'N',
  `Segment` smallint(6) NOT NULL DEFAULT '0',
  `ReqDate` datetime DEFAULT NULL,
  `CancelDate` datetime DEFAULT NULL,
  `PickStatus` char(1) DEFAULT 'N',
  `Pick` char(1) DEFAULT 'N',
  `BlockDunn` char(1) DEFAULT 'N',
  `PeyMethod` varchar(15) DEFAULT NULL,
  `PayBlock` char(1) DEFAULT 'N',
  `PayBlckRef` int(11) DEFAULT NULL,
  `MaxDscn` char(1) DEFAULT 'N',
  `Reserve` char(1) DEFAULT 'N',
  `Max1099` decimal(19,6) DEFAULT NULL,
  `CntrlBnk` varchar(15) DEFAULT NULL,
  `PickRmrk` varchar(254) DEFAULT NULL,
  `ISRCodLine` varchar(53) DEFAULT NULL,
  `ExpAppl` decimal(19,6) DEFAULT NULL,
  `ExpApplFC` decimal(19,6) DEFAULT NULL,
  `ExpApplSC` decimal(19,6) DEFAULT NULL,
  `Project` varchar(20) DEFAULT NULL,
  `DeferrTax` char(1) DEFAULT NULL,
  `LetterNum` varchar(20) DEFAULT NULL,
  `FromDate` datetime DEFAULT NULL,
  `ToDate` datetime DEFAULT NULL,
  `WTApplied` decimal(19,6) DEFAULT NULL,
  `WTAppliedF` decimal(19,6) DEFAULT NULL,
  `BoeReserev` char(1) DEFAULT 'N',
  `AgentCode` varchar(32) DEFAULT NULL,
  `WTAppliedS` decimal(19,6) DEFAULT NULL,
  `EquVatSum` decimal(19,6) DEFAULT NULL,
  `EquVatSumF` decimal(19,6) DEFAULT NULL,
  `EquVatSumS` decimal(19,6) DEFAULT NULL,
  `Installmnt` smallint(6) DEFAULT '1',
  `VATFirst` char(1) DEFAULT NULL,
  `NnSbAmnt` decimal(19,6) DEFAULT NULL,
  `NnSbAmntSC` decimal(19,6) DEFAULT NULL,
  `NbSbAmntFC` decimal(19,6) DEFAULT NULL,
  `ExepAmnt` decimal(19,6) DEFAULT NULL,
  `ExepAmntSC` decimal(19,6) DEFAULT NULL,
  `ExepAmntFC` decimal(19,6) DEFAULT NULL,
  `VatDate` datetime DEFAULT NULL,
  `CorrExt` varchar(25) DEFAULT NULL,
  `CorrInv` int(11) DEFAULT NULL,
  `NCorrInv` int(11) DEFAULT NULL,
  `CEECFlag` char(1) DEFAULT 'N',
  `BaseAmnt` decimal(19,6) DEFAULT NULL,
  `BaseAmntSC` decimal(19,6) DEFAULT NULL,
  `BaseAmntFC` decimal(19,6) DEFAULT NULL,
  `CtlAccount` varchar(15) DEFAULT NULL,
  `BPLId` int(11) DEFAULT NULL,
  `BPLName` varchar(20) DEFAULT NULL,
  `VATRegNum` varchar(12) DEFAULT NULL,
  `TxInvRptNo` varchar(10) DEFAULT NULL,
  `TxInvRptDt` datetime DEFAULT NULL,
  `KVVATCode` longtext,
  `WTDetails` varchar(100) DEFAULT NULL,
  `SumAbsId` int(11) DEFAULT '-1',
  `SumRptDate` datetime DEFAULT NULL,
  `PIndicator` varchar(10) NOT NULL DEFAULT ' ',
  `ManualNum` varchar(20) DEFAULT NULL,
  `UseShpdGd` char(1) DEFAULT 'N',
  `BaseVtAt` decimal(19,6) DEFAULT NULL,
  `BaseVtAtSC` decimal(19,6) DEFAULT NULL,
  `BaseVtAtFC` decimal(19,6) DEFAULT NULL,
  `NnSbVAt` decimal(19,6) DEFAULT NULL,
  `NnSbVAtSC` decimal(19,6) DEFAULT NULL,
  `NbSbVAtFC` decimal(19,6) DEFAULT NULL,
  `ExptVAt` decimal(19,6) DEFAULT NULL,
  `ExptVAtSC` decimal(19,6) DEFAULT NULL,
  `ExptVAtFC` decimal(19,6) DEFAULT NULL,
  `LYPmtAt` decimal(19,6) DEFAULT NULL,
  `LYPmtAtSC` decimal(19,6) DEFAULT NULL,
  `LYPmtAtFC` decimal(19,6) DEFAULT NULL,
  `ExpAnSum` decimal(19,6) DEFAULT NULL,
  `ExpAnSys` decimal(19,6) DEFAULT NULL,
  `ExpAnFrgn` decimal(19,6) DEFAULT NULL,
  `DocSubType` varchar(2) NOT NULL DEFAULT '--',
  `DpmStatus` char(1) DEFAULT 'O',
  `DpmAmnt` decimal(19,6) DEFAULT NULL,
  `DpmAmntSC` decimal(19,6) DEFAULT NULL,
  `DpmAmntFC` decimal(19,6) DEFAULT NULL,
  `DpmDrawn` char(1) DEFAULT 'N',
  `DpmPrcnt` decimal(19,6) DEFAULT NULL,
  `PaidSum` decimal(19,6) DEFAULT NULL,
  `PaidSumFc` decimal(19,6) DEFAULT NULL,
  `PaidSumSc` decimal(19,6) DEFAULT NULL,
  `FolioPref` varchar(2) DEFAULT NULL,
  `FolioNum` int(11) DEFAULT NULL,
  `DpmAppl` decimal(19,6) DEFAULT NULL,
  `DpmApplFc` decimal(19,6) DEFAULT NULL,
  `DpmApplSc` decimal(19,6) DEFAULT NULL,
  `LPgFolioN` int(11) DEFAULT NULL,
  `Header` longtext,
  `Footer` longtext,
  `Posted` char(1) DEFAULT 'Y',
  `OwnerCode` int(11) DEFAULT NULL,
  `BPChCode` varchar(15) DEFAULT NULL,
  `BPChCntc` int(11) DEFAULT NULL,
  `PayToCode` varchar(50) DEFAULT NULL,
  `IsPaytoBnk` char(1) DEFAULT NULL,
  `BnkCntry` varchar(3) DEFAULT NULL,
  `BankCode` varchar(30) DEFAULT NULL,
  `BnkAccount` varchar(50) DEFAULT NULL,
  `BnkBranch` varchar(50) DEFAULT NULL,
  `isIns` char(1) DEFAULT 'N',
  `TrackNo` varchar(30) DEFAULT NULL,
  `VersionNum` varchar(11) DEFAULT NULL,
  `LangCode` int(11) DEFAULT NULL,
  `BPNameOW` char(1) DEFAULT 'N',
  `BillToOW` char(1) DEFAULT 'N',
  `ShipToOW` char(1) DEFAULT 'N',
  `RetInvoice` char(1) DEFAULT 'N',
  `ClsDate` datetime DEFAULT NULL,
  `MInvNum` int(11) DEFAULT NULL,
  `MInvDate` datetime DEFAULT NULL,
  `SeqCode` smallint(6) DEFAULT NULL,
  `Serial` int(11) DEFAULT NULL,
  `SeriesStr` varchar(3) DEFAULT NULL,
  `SubStr` varchar(3) DEFAULT NULL,
  `Model` varchar(10) DEFAULT '0',
  `TaxOnExp` decimal(19,6) DEFAULT NULL,
  `TaxOnExpFc` decimal(19,6) DEFAULT NULL,
  `TaxOnExpSc` decimal(19,6) DEFAULT NULL,
  `TaxOnExAp` decimal(19,6) DEFAULT NULL,
  `TaxOnExApF` decimal(19,6) DEFAULT NULL,
  `TaxOnExApS` decimal(19,6) DEFAULT NULL,
  `LastPmnTyp` char(1) DEFAULT NULL,
  `LndCstNum` int(11) DEFAULT NULL,
  `UseCorrVat` char(1) DEFAULT 'N',
  `BlkCredMmo` char(1) DEFAULT 'N',
  `OpenForLaC` char(1) DEFAULT 'Y',
  `Excised` char(1) DEFAULT 'O',
  `ExcRefDate` datetime DEFAULT NULL,
  `ExcRmvTime` varchar(8) DEFAULT NULL,
  `SrvGpPrcnt` decimal(19,6) DEFAULT NULL,
  `DepositNum` int(11) DEFAULT NULL,
  `CertNum` varchar(31) DEFAULT NULL,
  `DutyStatus` char(1) DEFAULT 'Y',
  `AutoCrtFlw` char(1) DEFAULT 'N',
  `FlwRefDate` datetime DEFAULT NULL,
  `FlwRefNum` varchar(100) DEFAULT NULL,
  `VatJENum` int(11) DEFAULT '-1',
  `DpmVat` decimal(19,6) DEFAULT NULL,
  `DpmVatFc` decimal(19,6) DEFAULT NULL,
  `DpmVatSc` decimal(19,6) DEFAULT NULL,
  `DpmAppVat` decimal(19,6) DEFAULT NULL,
  `DpmAppVatF` decimal(19,6) DEFAULT NULL,
  `DpmAppVatS` decimal(19,6) DEFAULT NULL,
  `InsurOp347` char(1) DEFAULT 'N',
  `IgnRelDoc` char(1) DEFAULT 'N',
  `BuildDesc` varchar(50) DEFAULT NULL,
  `ResidenNum` char(1) DEFAULT '1',
  `Checker` int(11) DEFAULT NULL,
  `Payee` int(11) DEFAULT NULL,
  `CopyNumber` int(11) DEFAULT '0',
  `NTSApprov` char(1) DEFAULT 'N',
  `NTSWebSite` smallint(6) DEFAULT NULL,
  `NTSeTaxNo` varchar(50) DEFAULT NULL,
  `NTSApprNo` varchar(50) DEFAULT NULL,
  `PayDuMonth` char(1) DEFAULT NULL,
  `ExtraMonth` smallint(6) DEFAULT NULL,
  `ExtraDays` smallint(6) DEFAULT NULL,
  `CdcOffset` smallint(6) DEFAULT '0',
  `SignMsg` longtext,
  `SignDigest` longtext,
  `CertifNum` varchar(50) DEFAULT NULL,
  `KeyVersion` int(11) DEFAULT NULL,
  `EDocGenTyp` char(1) DEFAULT 'N',
  `ESeries` smallint(6) DEFAULT NULL,
  `EDocNum` varchar(30) DEFAULT NULL,
  `EDocExpFrm` int(11) DEFAULT NULL,
  `SSIExmpt` char(1) DEFAULT NULL,
  `PQTGrpSer` smallint(6) DEFAULT NULL,
  `PQTGrpNum` int(11) DEFAULT NULL,
  `PQTGrpHW` char(1) DEFAULT 'N',
  `ReopOriDoc` char(1) DEFAULT NULL,
  `ReopManCls` char(1) DEFAULT NULL,
  `DocManClsd` char(1) DEFAULT 'N',
  `U_OB_RefNo` longtext,
  `U_OB_DONo` longtext,
  `U_OB_FOC` longtext,
  `U_OB_RecUpToNWeek` decimal(19,6) DEFAULT NULL,
  `U_OB_ConUpToNWeek` decimal(19,6) DEFAULT NULL,
  `U_OB_ETA_MNL` datetime DEFAULT NULL,
  `U_OB_ISSUE_DATE` datetime DEFAULT NULL,
  `U_OB_Assembly_Line` longtext,
  `U_OB_TradeTerms` longtext,
  `U_OB_PrioLevel` longtext,
  `U_OB_PCNum` longtext,
  `U_OB_Package` longtext,
  `U_OB_LotNumber` longtext,
  `U_OB_FreightTerm` longtext,
  `U_OB_PackageNo` decimal(19,6) DEFAULT NULL,
  `U_OB_RevReason` longtext,
  `U_OB_PrepBy` longtext,
  `U_OB_RevReason1` longtext,
  `U_OB_TotalQty` decimal(19,6) DEFAULT NULL,
  `U_OB_Activity` longtext,
  `U_OB_Notes` longtext,
  `U_OB_PEZAPN` longtext,
  `U_OB_IssueDoc` int(11) DEFAULT NULL,
  `U_OB_CheckedBy` longtext,
  `U_HeaderID` longtext,
  PRIMARY KEY (`DocEntry`),
  UNIQUE KEY `OPCH_NUM` (`DocNum`,`Instance`,`Segment`,`DocSubType`,`PIndicator`),
  KEY `OPCH_AT_CARD` (`NumAtCard`,`CardCode`),
  KEY `OPCH_CUSTOMER` (`CardCode`),
  KEY `OPCH_DOC_STATUS` (`DocStatus`,`CANCELED`),
  KEY `OPCH_FTHR_CARD` (`FatherCard`,`FatherType`),
  KEY `OPCH_SERIES` (`Series`),
  KEY `OPCH_OWNER_CODE` (`OwnerCode`),
  KEY `OPCH_DATE_PIND` (`DocDate`,`PIndicator`),
  KEY `OPCH_ESERIES` (`ESeries`,`EDocNum`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `OPCH`
--

INSERT INTO `OPCH` (`DocEntry`, `DocNum`, `DocType`, `CANCELED`, `Handwrtten`, `Printed`, `DocStatus`, `InvntSttus`, `Transfered`, `ObjType`, `DocDate`, `DocDueDate`, `CardCode`, `CardName`, `Address`, `NumAtCard`, `VatPercent`, `VatSum`, `VatSumFC`, `DiscPrcnt`, `DiscSum`, `DiscSumFC`, `DocCur`, `DocRate`, `DocTotal`, `DocTotalFC`, `PaidToDate`, `PaidFC`, `GrosProfit`, `GrosProfFC`, `Ref1`, `Ref2`, `Comments`, `JrnlMemo`, `TransId`, `ReceiptNum`, `GroupNum`, `DocTime`, `SlpCode`, `TrnspCode`, `PartSupply`, `Confirmed`, `GrossBase`, `ImportEnt`, `CreateTran`, `SummryType`, `UpdInvnt`, `UpdCardBal`, `Instance`, `Flags`, `InvntDirec`, `CntctCode`, `ShowSCN`, `FatherCard`, `SysRate`, `CurSource`, `VatSumSy`, `DiscSumSy`, `DocTotalSy`, `PaidSys`, `FatherType`, `GrosProfSy`, `UpdateDate`, `IsICT`, `CreateDate`, `Volume`, `VolUnit`, `Weight`, `WeightUnit`, `Series`, `TaxDate`, `Filler`, `DataSource`, `StampNum`, `isCrin`, `FinncPriod`, `UserSign`, `selfInv`, `VatPaid`, `VatPaidFC`, `VatPaidSys`, `UserSign2`, `WddStatus`, `draftKey`, `TotalExpns`, `TotalExpFC`, `TotalExpSC`, `DunnLevel`, `Address2`, `LogInstanc`, `Exported`, `StationID`, `Indicator`, `NetProc`, `AqcsTax`, `AqcsTaxFC`, `AqcsTaxSC`, `CashDiscPr`, `CashDiscnt`, `CashDiscFC`, `CashDiscSC`, `ShipToCode`, `LicTradNum`, `PaymentRef`, `WTSum`, `WTSumFC`, `WTSumSC`, `RoundDif`, `RoundDifFC`, `RoundDifSy`, `CheckDigit`, `Form1099`, `Box1099`, `submitted`, `PoPrss`, `Rounding`, `RevisionPo`, `Segment`, `ReqDate`, `CancelDate`, `PickStatus`, `Pick`, `BlockDunn`, `PeyMethod`, `PayBlock`, `PayBlckRef`, `MaxDscn`, `Reserve`, `Max1099`, `CntrlBnk`, `PickRmrk`, `ISRCodLine`, `ExpAppl`, `ExpApplFC`, `ExpApplSC`, `Project`, `DeferrTax`, `LetterNum`, `FromDate`, `ToDate`, `WTApplied`, `WTAppliedF`, `BoeReserev`, `AgentCode`, `WTAppliedS`, `EquVatSum`, `EquVatSumF`, `EquVatSumS`, `Installmnt`, `VATFirst`, `NnSbAmnt`, `NnSbAmntSC`, `NbSbAmntFC`, `ExepAmnt`, `ExepAmntSC`, `ExepAmntFC`, `VatDate`, `CorrExt`, `CorrInv`, `NCorrInv`, `CEECFlag`, `BaseAmnt`, `BaseAmntSC`, `BaseAmntFC`, `CtlAccount`, `BPLId`, `BPLName`, `VATRegNum`, `TxInvRptNo`, `TxInvRptDt`, `KVVATCode`, `WTDetails`, `SumAbsId`, `SumRptDate`, `PIndicator`, `ManualNum`, `UseShpdGd`, `BaseVtAt`, `BaseVtAtSC`, `BaseVtAtFC`, `NnSbVAt`, `NnSbVAtSC`, `NbSbVAtFC`, `ExptVAt`, `ExptVAtSC`, `ExptVAtFC`, `LYPmtAt`, `LYPmtAtSC`, `LYPmtAtFC`, `ExpAnSum`, `ExpAnSys`, `ExpAnFrgn`, `DocSubType`, `DpmStatus`, `DpmAmnt`, `DpmAmntSC`, `DpmAmntFC`, `DpmDrawn`, `DpmPrcnt`, `PaidSum`, `PaidSumFc`, `PaidSumSc`, `FolioPref`, `FolioNum`, `DpmAppl`, `DpmApplFc`, `DpmApplSc`, `LPgFolioN`, `Header`, `Footer`, `Posted`, `OwnerCode`, `BPChCode`, `BPChCntc`, `PayToCode`, `IsPaytoBnk`, `BnkCntry`, `BankCode`, `BnkAccount`, `BnkBranch`, `isIns`, `TrackNo`, `VersionNum`, `LangCode`, `BPNameOW`, `BillToOW`, `ShipToOW`, `RetInvoice`, `ClsDate`, `MInvNum`, `MInvDate`, `SeqCode`, `Serial`, `SeriesStr`, `SubStr`, `Model`, `TaxOnExp`, `TaxOnExpFc`, `TaxOnExpSc`, `TaxOnExAp`, `TaxOnExApF`, `TaxOnExApS`, `LastPmnTyp`, `LndCstNum`, `UseCorrVat`, `BlkCredMmo`, `OpenForLaC`, `Excised`, `ExcRefDate`, `ExcRmvTime`, `SrvGpPrcnt`, `DepositNum`, `CertNum`, `DutyStatus`, `AutoCrtFlw`, `FlwRefDate`, `FlwRefNum`, `VatJENum`, `DpmVat`, `DpmVatFc`, `DpmVatSc`, `DpmAppVat`, `DpmAppVatF`, `DpmAppVatS`, `InsurOp347`, `IgnRelDoc`, `BuildDesc`, `ResidenNum`, `Checker`, `Payee`, `CopyNumber`, `NTSApprov`, `NTSWebSite`, `NTSeTaxNo`, `NTSApprNo`, `PayDuMonth`, `ExtraMonth`, `ExtraDays`, `CdcOffset`, `SignMsg`, `SignDigest`, `CertifNum`, `KeyVersion`, `EDocGenTyp`, `ESeries`, `EDocNum`, `EDocExpFrm`, `SSIExmpt`, `PQTGrpSer`, `PQTGrpNum`, `PQTGrpHW`, `ReopOriDoc`, `ReopManCls`, `DocManClsd`, `U_OB_RefNo`, `U_OB_DONo`, `U_OB_FOC`, `U_OB_RecUpToNWeek`, `U_OB_ConUpToNWeek`, `U_OB_ETA_MNL`, `U_OB_ISSUE_DATE`, `U_OB_Assembly_Line`, `U_OB_TradeTerms`, `U_OB_PrioLevel`, `U_OB_PCNum`, `U_OB_Package`, `U_OB_LotNumber`, `U_OB_FreightTerm`, `U_OB_PackageNo`, `U_OB_RevReason`, `U_OB_PrepBy`, `U_OB_RevReason1`, `U_OB_TotalQty`, `U_OB_Activity`, `U_OB_Notes`, `U_OB_PEZAPN`, `U_OB_IssueDoc`, `U_OB_CheckedBy`, `U_HeaderID`) VALUES
(35721, 170012307, 'I', 'N', 'N', 'N', 'O', 'O', 'N', '18', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, -1, -1, 'Y', 'Y', 0, NULL, 'N', 'N', 'N', 'N', 0, 0, 'X', NULL, 'N', NULL, NULL, 'C', NULL, NULL, NULL, NULL, 'P', NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, 'N', NULL, NULL, 'N', NULL, NULL, NULL, NULL, '-', -1, NULL, NULL, NULL, NULL, NULL, 0, 'N', NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', 'N', 'N', 'N', 0, NULL, NULL, 'N', 'N', 'N', NULL, 'N', NULL, 'N', 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, -1, NULL, ' ', NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '--', 'O', NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Y', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, 'N', 'N', 'N', 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, '0', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', 'N', 'Y', 'O', NULL, NULL, NULL, NULL, NULL, 'Y', 'N', NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, NULL, 'N', 'N', NULL, '1', NULL, NULL, 0, 'N', NULL, NULL, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `OPDN`
--

CREATE TABLE IF NOT EXISTS `OPDN` (
  `DocEntry` int(11) NOT NULL,
  `DocNum` int(11) NOT NULL,
  `DocType` char(1) DEFAULT 'I',
  `CANCELED` char(1) DEFAULT 'N',
  `Handwrtten` char(1) DEFAULT 'N',
  `Printed` char(1) DEFAULT 'N',
  `DocStatus` char(1) DEFAULT 'O',
  `InvntSttus` char(1) DEFAULT 'O',
  `Transfered` char(1) DEFAULT 'N',
  `ObjType` varchar(20) DEFAULT '20',
  `DocDate` datetime DEFAULT NULL,
  `DocDueDate` datetime DEFAULT NULL,
  `CardCode` varchar(15) DEFAULT NULL,
  `CardName` varchar(100) DEFAULT NULL,
  `Address` varchar(254) DEFAULT NULL,
  `NumAtCard` varchar(100) DEFAULT NULL,
  `VatPercent` decimal(19,6) DEFAULT NULL,
  `VatSum` decimal(19,6) DEFAULT NULL,
  `VatSumFC` decimal(19,6) DEFAULT NULL,
  `DiscPrcnt` decimal(19,6) DEFAULT NULL,
  `DiscSum` decimal(19,6) DEFAULT NULL,
  `DiscSumFC` decimal(19,6) DEFAULT NULL,
  `DocCur` varchar(3) DEFAULT NULL,
  `DocRate` decimal(19,6) DEFAULT NULL,
  `DocTotal` decimal(19,6) DEFAULT NULL,
  `DocTotalFC` decimal(19,6) DEFAULT NULL,
  `PaidToDate` decimal(19,6) DEFAULT NULL,
  `PaidFC` decimal(19,6) DEFAULT NULL,
  `GrosProfit` decimal(19,6) DEFAULT NULL,
  `GrosProfFC` decimal(19,6) DEFAULT NULL,
  `Ref1` varchar(11) DEFAULT NULL,
  `Ref2` varchar(11) DEFAULT NULL,
  `Comments` varchar(254) DEFAULT NULL,
  `JrnlMemo` varchar(50) DEFAULT NULL,
  `TransId` int(11) DEFAULT NULL,
  `ReceiptNum` int(11) DEFAULT NULL,
  `GroupNum` smallint(6) DEFAULT NULL,
  `DocTime` smallint(6) DEFAULT NULL,
  `SlpCode` smallint(6) DEFAULT '-1',
  `TrnspCode` smallint(6) DEFAULT '-1',
  `PartSupply` char(1) DEFAULT 'Y',
  `Confirmed` char(1) DEFAULT 'Y',
  `GrossBase` smallint(6) DEFAULT '0',
  `ImportEnt` int(11) DEFAULT NULL,
  `CreateTran` char(1) DEFAULT 'N',
  `SummryType` char(1) DEFAULT 'N',
  `UpdInvnt` char(1) DEFAULT 'N',
  `UpdCardBal` char(1) DEFAULT 'N',
  `Instance` smallint(6) NOT NULL DEFAULT '0',
  `Flags` int(11) DEFAULT '0',
  `InvntDirec` char(1) DEFAULT 'X',
  `CntctCode` int(11) DEFAULT NULL,
  `ShowSCN` char(1) DEFAULT 'N',
  `FatherCard` varchar(15) DEFAULT NULL,
  `SysRate` decimal(19,6) DEFAULT NULL,
  `CurSource` char(1) DEFAULT 'C',
  `VatSumSy` decimal(19,6) DEFAULT NULL,
  `DiscSumSy` decimal(19,6) DEFAULT NULL,
  `DocTotalSy` decimal(19,6) DEFAULT NULL,
  `PaidSys` decimal(19,6) DEFAULT NULL,
  `FatherType` char(1) DEFAULT 'P',
  `GrosProfSy` decimal(19,6) DEFAULT NULL,
  `UpdateDate` datetime DEFAULT NULL,
  `IsICT` char(1) DEFAULT 'N',
  `CreateDate` datetime DEFAULT NULL,
  `Volume` decimal(19,6) DEFAULT NULL,
  `VolUnit` smallint(6) DEFAULT NULL,
  `Weight` decimal(19,6) DEFAULT NULL,
  `WeightUnit` smallint(6) DEFAULT NULL,
  `Series` smallint(6) DEFAULT NULL,
  `TaxDate` datetime DEFAULT NULL,
  `Filler` varchar(8) DEFAULT NULL,
  `DataSource` char(1) DEFAULT 'N',
  `StampNum` varchar(16) DEFAULT NULL,
  `isCrin` char(1) DEFAULT 'N',
  `FinncPriod` int(11) DEFAULT NULL,
  `UserSign` smallint(6) DEFAULT NULL,
  `selfInv` char(1) DEFAULT 'N',
  `VatPaid` decimal(19,6) DEFAULT NULL,
  `VatPaidFC` decimal(19,6) DEFAULT NULL,
  `VatPaidSys` decimal(19,6) DEFAULT NULL,
  `UserSign2` smallint(6) DEFAULT NULL,
  `WddStatus` char(1) DEFAULT '-',
  `draftKey` int(11) DEFAULT '-1',
  `TotalExpns` decimal(19,6) DEFAULT NULL,
  `TotalExpFC` decimal(19,6) DEFAULT NULL,
  `TotalExpSC` decimal(19,6) DEFAULT NULL,
  `DunnLevel` int(11) DEFAULT NULL,
  `Address2` varchar(254) DEFAULT NULL,
  `LogInstanc` smallint(6) DEFAULT '0',
  `Exported` char(1) DEFAULT 'N',
  `StationID` int(11) DEFAULT NULL,
  `Indicator` varchar(2) DEFAULT NULL,
  `NetProc` char(1) DEFAULT 'N',
  `AqcsTax` decimal(19,6) DEFAULT NULL,
  `AqcsTaxFC` decimal(19,6) DEFAULT NULL,
  `AqcsTaxSC` decimal(19,6) DEFAULT NULL,
  `CashDiscPr` decimal(19,6) DEFAULT NULL,
  `CashDiscnt` decimal(19,6) DEFAULT NULL,
  `CashDiscFC` decimal(19,6) DEFAULT NULL,
  `CashDiscSC` decimal(19,6) DEFAULT NULL,
  `ShipToCode` varchar(50) DEFAULT NULL,
  `LicTradNum` varchar(32) DEFAULT NULL,
  `PaymentRef` varchar(27) DEFAULT NULL,
  `WTSum` decimal(19,6) DEFAULT NULL,
  `WTSumFC` decimal(19,6) DEFAULT NULL,
  `WTSumSC` decimal(19,6) DEFAULT NULL,
  `RoundDif` decimal(19,6) DEFAULT NULL,
  `RoundDifFC` decimal(19,6) DEFAULT NULL,
  `RoundDifSy` decimal(19,6) DEFAULT NULL,
  `CheckDigit` char(1) DEFAULT NULL,
  `Form1099` int(11) DEFAULT NULL,
  `Box1099` varchar(20) DEFAULT NULL,
  `submitted` char(1) DEFAULT 'N',
  `PoPrss` char(1) DEFAULT 'N',
  `Rounding` char(1) DEFAULT 'N',
  `RevisionPo` char(1) DEFAULT 'N',
  `Segment` smallint(6) NOT NULL DEFAULT '0',
  `ReqDate` datetime DEFAULT NULL,
  `CancelDate` datetime DEFAULT NULL,
  `PickStatus` char(1) DEFAULT 'N',
  `Pick` char(1) DEFAULT 'N',
  `BlockDunn` char(1) DEFAULT 'N',
  `PeyMethod` varchar(15) DEFAULT NULL,
  `PayBlock` char(1) DEFAULT 'N',
  `PayBlckRef` int(11) DEFAULT NULL,
  `MaxDscn` char(1) DEFAULT 'N',
  `Reserve` char(1) DEFAULT 'N',
  `Max1099` decimal(19,6) DEFAULT NULL,
  `CntrlBnk` varchar(15) DEFAULT NULL,
  `PickRmrk` varchar(254) DEFAULT NULL,
  `ISRCodLine` varchar(53) DEFAULT NULL,
  `ExpAppl` decimal(19,6) DEFAULT NULL,
  `ExpApplFC` decimal(19,6) DEFAULT NULL,
  `ExpApplSC` decimal(19,6) DEFAULT NULL,
  `Project` varchar(20) DEFAULT NULL,
  `DeferrTax` char(1) DEFAULT NULL,
  `LetterNum` varchar(20) DEFAULT NULL,
  `FromDate` datetime DEFAULT NULL,
  `ToDate` datetime DEFAULT NULL,
  `WTApplied` decimal(19,6) DEFAULT NULL,
  `WTAppliedF` decimal(19,6) DEFAULT NULL,
  `BoeReserev` char(1) DEFAULT 'N',
  `AgentCode` varchar(32) DEFAULT NULL,
  `WTAppliedS` decimal(19,6) DEFAULT NULL,
  `EquVatSum` decimal(19,6) DEFAULT NULL,
  `EquVatSumF` decimal(19,6) DEFAULT NULL,
  `EquVatSumS` decimal(19,6) DEFAULT NULL,
  `Installmnt` smallint(6) DEFAULT '1',
  `VATFirst` char(1) DEFAULT NULL,
  `NnSbAmnt` decimal(19,6) DEFAULT NULL,
  `NnSbAmntSC` decimal(19,6) DEFAULT NULL,
  `NbSbAmntFC` decimal(19,6) DEFAULT NULL,
  `ExepAmnt` decimal(19,6) DEFAULT NULL,
  `ExepAmntSC` decimal(19,6) DEFAULT NULL,
  `ExepAmntFC` decimal(19,6) DEFAULT NULL,
  `VatDate` datetime DEFAULT NULL,
  `CorrExt` varchar(25) DEFAULT NULL,
  `CorrInv` int(11) DEFAULT NULL,
  `NCorrInv` int(11) DEFAULT NULL,
  `CEECFlag` char(1) DEFAULT 'N',
  `BaseAmnt` decimal(19,6) DEFAULT NULL,
  `BaseAmntSC` decimal(19,6) DEFAULT NULL,
  `BaseAmntFC` decimal(19,6) DEFAULT NULL,
  `CtlAccount` varchar(15) DEFAULT NULL,
  `BPLId` int(11) DEFAULT NULL,
  `BPLName` varchar(20) DEFAULT NULL,
  `VATRegNum` varchar(12) DEFAULT NULL,
  `TxInvRptNo` varchar(10) DEFAULT NULL,
  `TxInvRptDt` datetime DEFAULT NULL,
  `KVVATCode` longtext,
  `WTDetails` varchar(100) DEFAULT NULL,
  `SumAbsId` int(11) DEFAULT '-1',
  `SumRptDate` datetime DEFAULT NULL,
  `PIndicator` varchar(10) NOT NULL DEFAULT ' ',
  `ManualNum` varchar(20) DEFAULT NULL,
  `UseShpdGd` char(1) DEFAULT 'N',
  `BaseVtAt` decimal(19,6) DEFAULT NULL,
  `BaseVtAtSC` decimal(19,6) DEFAULT NULL,
  `BaseVtAtFC` decimal(19,6) DEFAULT NULL,
  `NnSbVAt` decimal(19,6) DEFAULT NULL,
  `NnSbVAtSC` decimal(19,6) DEFAULT NULL,
  `NbSbVAtFC` decimal(19,6) DEFAULT NULL,
  `ExptVAt` decimal(19,6) DEFAULT NULL,
  `ExptVAtSC` decimal(19,6) DEFAULT NULL,
  `ExptVAtFC` decimal(19,6) DEFAULT NULL,
  `LYPmtAt` decimal(19,6) DEFAULT NULL,
  `LYPmtAtSC` decimal(19,6) DEFAULT NULL,
  `LYPmtAtFC` decimal(19,6) DEFAULT NULL,
  `ExpAnSum` decimal(19,6) DEFAULT NULL,
  `ExpAnSys` decimal(19,6) DEFAULT NULL,
  `ExpAnFrgn` decimal(19,6) DEFAULT NULL,
  `DocSubType` varchar(2) NOT NULL DEFAULT '--',
  `DpmStatus` char(1) DEFAULT 'O',
  `DpmAmnt` decimal(19,6) DEFAULT NULL,
  `DpmAmntSC` decimal(19,6) DEFAULT NULL,
  `DpmAmntFC` decimal(19,6) DEFAULT NULL,
  `DpmDrawn` char(1) DEFAULT 'N',
  `DpmPrcnt` decimal(19,6) DEFAULT NULL,
  `PaidSum` decimal(19,6) DEFAULT NULL,
  `PaidSumFc` decimal(19,6) DEFAULT NULL,
  `PaidSumSc` decimal(19,6) DEFAULT NULL,
  `FolioPref` varchar(2) DEFAULT NULL,
  `FolioNum` int(11) DEFAULT NULL,
  `DpmAppl` decimal(19,6) DEFAULT NULL,
  `DpmApplFc` decimal(19,6) DEFAULT NULL,
  `DpmApplSc` decimal(19,6) DEFAULT NULL,
  `LPgFolioN` int(11) DEFAULT NULL,
  `Header` longtext,
  `Footer` longtext,
  `Posted` char(1) DEFAULT 'Y',
  `OwnerCode` int(11) DEFAULT NULL,
  `BPChCode` varchar(15) DEFAULT NULL,
  `BPChCntc` int(11) DEFAULT NULL,
  `PayToCode` varchar(50) DEFAULT NULL,
  `IsPaytoBnk` char(1) DEFAULT NULL,
  `BnkCntry` varchar(3) DEFAULT NULL,
  `BankCode` varchar(30) DEFAULT NULL,
  `BnkAccount` varchar(50) DEFAULT NULL,
  `BnkBranch` varchar(50) DEFAULT NULL,
  `isIns` char(1) DEFAULT 'N',
  `TrackNo` varchar(30) DEFAULT NULL,
  `VersionNum` varchar(11) DEFAULT NULL,
  `LangCode` int(11) DEFAULT NULL,
  `BPNameOW` char(1) DEFAULT 'N',
  `BillToOW` char(1) DEFAULT 'N',
  `ShipToOW` char(1) DEFAULT 'N',
  `RetInvoice` char(1) DEFAULT 'N',
  `ClsDate` datetime DEFAULT NULL,
  `MInvNum` int(11) DEFAULT NULL,
  `MInvDate` datetime DEFAULT NULL,
  `SeqCode` smallint(6) DEFAULT NULL,
  `Serial` int(11) DEFAULT NULL,
  `SeriesStr` varchar(3) DEFAULT NULL,
  `SubStr` varchar(3) DEFAULT NULL,
  `Model` varchar(10) DEFAULT '0',
  `TaxOnExp` decimal(19,6) DEFAULT NULL,
  `TaxOnExpFc` decimal(19,6) DEFAULT NULL,
  `TaxOnExpSc` decimal(19,6) DEFAULT NULL,
  `TaxOnExAp` decimal(19,6) DEFAULT NULL,
  `TaxOnExApF` decimal(19,6) DEFAULT NULL,
  `TaxOnExApS` decimal(19,6) DEFAULT NULL,
  `LastPmnTyp` char(1) DEFAULT NULL,
  `LndCstNum` int(11) DEFAULT NULL,
  `UseCorrVat` char(1) DEFAULT 'N',
  `BlkCredMmo` char(1) DEFAULT 'N',
  `OpenForLaC` char(1) DEFAULT 'Y',
  `Excised` char(1) DEFAULT 'O',
  `ExcRefDate` datetime DEFAULT NULL,
  `ExcRmvTime` varchar(8) DEFAULT NULL,
  `SrvGpPrcnt` decimal(19,6) DEFAULT NULL,
  `DepositNum` int(11) DEFAULT NULL,
  `CertNum` varchar(31) DEFAULT NULL,
  `DutyStatus` char(1) DEFAULT 'Y',
  `AutoCrtFlw` char(1) DEFAULT 'N',
  `FlwRefDate` datetime DEFAULT NULL,
  `FlwRefNum` varchar(100) DEFAULT NULL,
  `VatJENum` int(11) DEFAULT '-1',
  `DpmVat` decimal(19,6) DEFAULT NULL,
  `DpmVatFc` decimal(19,6) DEFAULT NULL,
  `DpmVatSc` decimal(19,6) DEFAULT NULL,
  `DpmAppVat` decimal(19,6) DEFAULT NULL,
  `DpmAppVatF` decimal(19,6) DEFAULT NULL,
  `DpmAppVatS` decimal(19,6) DEFAULT NULL,
  `InsurOp347` char(1) DEFAULT 'N',
  `IgnRelDoc` char(1) DEFAULT 'N',
  `BuildDesc` varchar(50) DEFAULT NULL,
  `ResidenNum` char(1) DEFAULT '1',
  `Checker` int(11) DEFAULT NULL,
  `Payee` int(11) DEFAULT NULL,
  `CopyNumber` int(11) DEFAULT '0',
  `NTSApprov` char(1) DEFAULT 'N',
  `NTSWebSite` smallint(6) DEFAULT NULL,
  `NTSeTaxNo` varchar(50) DEFAULT NULL,
  `NTSApprNo` varchar(50) DEFAULT NULL,
  `PayDuMonth` char(1) DEFAULT NULL,
  `ExtraMonth` smallint(6) DEFAULT NULL,
  `ExtraDays` smallint(6) DEFAULT NULL,
  `CdcOffset` smallint(6) DEFAULT '0',
  `SignMsg` longtext,
  `SignDigest` longtext,
  `CertifNum` varchar(50) DEFAULT NULL,
  `KeyVersion` int(11) DEFAULT NULL,
  `EDocGenTyp` char(1) DEFAULT 'N',
  `ESeries` smallint(6) DEFAULT NULL,
  `EDocNum` varchar(30) DEFAULT NULL,
  `EDocExpFrm` int(11) DEFAULT NULL,
  `SSIExmpt` char(1) DEFAULT NULL,
  `PQTGrpSer` smallint(6) DEFAULT NULL,
  `PQTGrpNum` int(11) DEFAULT NULL,
  `PQTGrpHW` char(1) DEFAULT 'N',
  `ReopOriDoc` char(1) DEFAULT NULL,
  `ReopManCls` char(1) DEFAULT NULL,
  `DocManClsd` char(1) DEFAULT 'N',
  `U_OB_RefNo` longtext,
  `U_OB_DONo` longtext,
  `U_OB_FOC` longtext,
  `U_OB_RecUpToNWeek` decimal(19,6) DEFAULT NULL,
  `U_OB_ConUpToNWeek` decimal(19,6) DEFAULT NULL,
  `U_OB_ETA_MNL` datetime DEFAULT NULL,
  `U_OB_ISSUE_DATE` datetime DEFAULT NULL,
  `U_OB_Assembly_Line` longtext,
  `U_OB_TradeTerms` longtext,
  `U_OB_PrioLevel` longtext,
  `U_OB_PCNum` longtext,
  `U_OB_Package` longtext,
  `U_OB_LotNumber` longtext,
  `U_OB_FreightTerm` longtext,
  `U_OB_PackageNo` decimal(19,6) DEFAULT NULL,
  `U_OB_RevReason` longtext,
  `U_OB_PrepBy` longtext,
  `U_OB_RevReason1` longtext,
  `U_OB_TotalQty` decimal(19,6) DEFAULT NULL,
  `U_OB_Activity` longtext,
  `U_OB_Notes` longtext,
  `U_OB_PEZAPN` longtext,
  `U_OB_IssueDoc` int(11) DEFAULT NULL,
  `U_OB_CheckedBy` longtext,
  `U_HeaderID` longtext,
  PRIMARY KEY (`DocEntry`),
  UNIQUE KEY `OPDN_NUM` (`DocNum`,`Instance`,`Segment`,`DocSubType`,`PIndicator`),
  KEY `OPDN_AT_CARD` (`NumAtCard`,`CardCode`),
  KEY `OPDN_CUSTOMER` (`CardCode`),
  KEY `OPDN_DOC_STATUS` (`DocStatus`,`CANCELED`),
  KEY `OPDN_FTHR_CARD` (`FatherCard`,`FatherType`),
  KEY `OPDN_SERIES` (`Series`),
  KEY `OPDN_OWNER_CODE` (`OwnerCode`),
  KEY `OPDN_DATE_PIND` (`DocDate`,`PIndicator`),
  KEY `OPDN_ESERIES` (`ESeries`,`EDocNum`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `OPDN`
--

INSERT INTO `OPDN` (`DocEntry`, `DocNum`, `DocType`, `CANCELED`, `Handwrtten`, `Printed`, `DocStatus`, `InvntSttus`, `Transfered`, `ObjType`, `DocDate`, `DocDueDate`, `CardCode`, `CardName`, `Address`, `NumAtCard`, `VatPercent`, `VatSum`, `VatSumFC`, `DiscPrcnt`, `DiscSum`, `DiscSumFC`, `DocCur`, `DocRate`, `DocTotal`, `DocTotalFC`, `PaidToDate`, `PaidFC`, `GrosProfit`, `GrosProfFC`, `Ref1`, `Ref2`, `Comments`, `JrnlMemo`, `TransId`, `ReceiptNum`, `GroupNum`, `DocTime`, `SlpCode`, `TrnspCode`, `PartSupply`, `Confirmed`, `GrossBase`, `ImportEnt`, `CreateTran`, `SummryType`, `UpdInvnt`, `UpdCardBal`, `Instance`, `Flags`, `InvntDirec`, `CntctCode`, `ShowSCN`, `FatherCard`, `SysRate`, `CurSource`, `VatSumSy`, `DiscSumSy`, `DocTotalSy`, `PaidSys`, `FatherType`, `GrosProfSy`, `UpdateDate`, `IsICT`, `CreateDate`, `Volume`, `VolUnit`, `Weight`, `WeightUnit`, `Series`, `TaxDate`, `Filler`, `DataSource`, `StampNum`, `isCrin`, `FinncPriod`, `UserSign`, `selfInv`, `VatPaid`, `VatPaidFC`, `VatPaidSys`, `UserSign2`, `WddStatus`, `draftKey`, `TotalExpns`, `TotalExpFC`, `TotalExpSC`, `DunnLevel`, `Address2`, `LogInstanc`, `Exported`, `StationID`, `Indicator`, `NetProc`, `AqcsTax`, `AqcsTaxFC`, `AqcsTaxSC`, `CashDiscPr`, `CashDiscnt`, `CashDiscFC`, `CashDiscSC`, `ShipToCode`, `LicTradNum`, `PaymentRef`, `WTSum`, `WTSumFC`, `WTSumSC`, `RoundDif`, `RoundDifFC`, `RoundDifSy`, `CheckDigit`, `Form1099`, `Box1099`, `submitted`, `PoPrss`, `Rounding`, `RevisionPo`, `Segment`, `ReqDate`, `CancelDate`, `PickStatus`, `Pick`, `BlockDunn`, `PeyMethod`, `PayBlock`, `PayBlckRef`, `MaxDscn`, `Reserve`, `Max1099`, `CntrlBnk`, `PickRmrk`, `ISRCodLine`, `ExpAppl`, `ExpApplFC`, `ExpApplSC`, `Project`, `DeferrTax`, `LetterNum`, `FromDate`, `ToDate`, `WTApplied`, `WTAppliedF`, `BoeReserev`, `AgentCode`, `WTAppliedS`, `EquVatSum`, `EquVatSumF`, `EquVatSumS`, `Installmnt`, `VATFirst`, `NnSbAmnt`, `NnSbAmntSC`, `NbSbAmntFC`, `ExepAmnt`, `ExepAmntSC`, `ExepAmntFC`, `VatDate`, `CorrExt`, `CorrInv`, `NCorrInv`, `CEECFlag`, `BaseAmnt`, `BaseAmntSC`, `BaseAmntFC`, `CtlAccount`, `BPLId`, `BPLName`, `VATRegNum`, `TxInvRptNo`, `TxInvRptDt`, `KVVATCode`, `WTDetails`, `SumAbsId`, `SumRptDate`, `PIndicator`, `ManualNum`, `UseShpdGd`, `BaseVtAt`, `BaseVtAtSC`, `BaseVtAtFC`, `NnSbVAt`, `NnSbVAtSC`, `NbSbVAtFC`, `ExptVAt`, `ExptVAtSC`, `ExptVAtFC`, `LYPmtAt`, `LYPmtAtSC`, `LYPmtAtFC`, `ExpAnSum`, `ExpAnSys`, `ExpAnFrgn`, `DocSubType`, `DpmStatus`, `DpmAmnt`, `DpmAmntSC`, `DpmAmntFC`, `DpmDrawn`, `DpmPrcnt`, `PaidSum`, `PaidSumFc`, `PaidSumSc`, `FolioPref`, `FolioNum`, `DpmAppl`, `DpmApplFc`, `DpmApplSc`, `LPgFolioN`, `Header`, `Footer`, `Posted`, `OwnerCode`, `BPChCode`, `BPChCntc`, `PayToCode`, `IsPaytoBnk`, `BnkCntry`, `BankCode`, `BnkAccount`, `BnkBranch`, `isIns`, `TrackNo`, `VersionNum`, `LangCode`, `BPNameOW`, `BillToOW`, `ShipToOW`, `RetInvoice`, `ClsDate`, `MInvNum`, `MInvDate`, `SeqCode`, `Serial`, `SeriesStr`, `SubStr`, `Model`, `TaxOnExp`, `TaxOnExpFc`, `TaxOnExpSc`, `TaxOnExAp`, `TaxOnExApF`, `TaxOnExApS`, `LastPmnTyp`, `LndCstNum`, `UseCorrVat`, `BlkCredMmo`, `OpenForLaC`, `Excised`, `ExcRefDate`, `ExcRmvTime`, `SrvGpPrcnt`, `DepositNum`, `CertNum`, `DutyStatus`, `AutoCrtFlw`, `FlwRefDate`, `FlwRefNum`, `VatJENum`, `DpmVat`, `DpmVatFc`, `DpmVatSc`, `DpmAppVat`, `DpmAppVatF`, `DpmAppVatS`, `InsurOp347`, `IgnRelDoc`, `BuildDesc`, `ResidenNum`, `Checker`, `Payee`, `CopyNumber`, `NTSApprov`, `NTSWebSite`, `NTSeTaxNo`, `NTSApprNo`, `PayDuMonth`, `ExtraMonth`, `ExtraDays`, `CdcOffset`, `SignMsg`, `SignDigest`, `CertifNum`, `KeyVersion`, `EDocGenTyp`, `ESeries`, `EDocNum`, `EDocExpFrm`, `SSIExmpt`, `PQTGrpSer`, `PQTGrpNum`, `PQTGrpHW`, `ReopOriDoc`, `ReopManCls`, `DocManClsd`, `U_OB_RefNo`, `U_OB_DONo`, `U_OB_FOC`, `U_OB_RecUpToNWeek`, `U_OB_ConUpToNWeek`, `U_OB_ETA_MNL`, `U_OB_ISSUE_DATE`, `U_OB_Assembly_Line`, `U_OB_TradeTerms`, `U_OB_PrioLevel`, `U_OB_PCNum`, `U_OB_Package`, `U_OB_LotNumber`, `U_OB_FreightTerm`, `U_OB_PackageNo`, `U_OB_RevReason`, `U_OB_PrepBy`, `U_OB_RevReason1`, `U_OB_TotalQty`, `U_OB_Activity`, `U_OB_Notes`, `U_OB_PEZAPN`, `U_OB_IssueDoc`, `U_OB_CheckedBy`, `U_HeaderID`) VALUES
(34460, 130006859, 'I', 'N', 'N', 'N', 'O', 'O', 'N', '20', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, -1, -1, 'Y', 'Y', 0, NULL, 'N', 'N', 'N', 'N', 0, 0, 'X', NULL, 'N', NULL, NULL, 'C', NULL, NULL, NULL, NULL, 'P', NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, 'N', NULL, NULL, 'N', NULL, NULL, NULL, NULL, '-', -1, NULL, NULL, NULL, NULL, NULL, 0, 'N', NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', 'N', 'N', 'N', 0, NULL, NULL, 'N', 'N', 'N', NULL, 'N', NULL, 'N', 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, -1, NULL, ' ', NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '--', 'O', NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Y', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, 'N', 'N', 'N', 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, '0', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', 'N', 'Y', 'O', NULL, NULL, NULL, NULL, NULL, 'Y', 'N', NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, NULL, 'N', 'N', NULL, '1', NULL, NULL, 0, 'N', NULL, NULL, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `OPOR`
--

CREATE TABLE IF NOT EXISTS `OPOR` (
  `DocEntry` int(11) NOT NULL,
  `DocNum` int(11) NOT NULL,
  `DocType` char(1) DEFAULT 'I',
  `CANCELED` char(1) DEFAULT 'N',
  `Handwrtten` char(1) DEFAULT 'N',
  `Printed` char(1) DEFAULT 'N',
  `DocStatus` char(1) DEFAULT 'O',
  `InvntSttus` char(1) DEFAULT 'O',
  `Transfered` char(1) DEFAULT 'N',
  `ObjType` varchar(20) DEFAULT '22',
  `DocDate` datetime DEFAULT NULL,
  `DocDueDate` datetime DEFAULT NULL,
  `CardCode` varchar(15) DEFAULT NULL,
  `CardName` varchar(100) DEFAULT NULL,
  `Address` varchar(254) DEFAULT NULL,
  `NumAtCard` varchar(100) DEFAULT NULL,
  `VatPercent` decimal(19,6) DEFAULT NULL,
  `VatSum` decimal(19,6) DEFAULT NULL,
  `VatSumFC` decimal(19,6) DEFAULT NULL,
  `DiscPrcnt` decimal(19,6) DEFAULT NULL,
  `DiscSum` decimal(19,6) DEFAULT NULL,
  `DiscSumFC` decimal(19,6) DEFAULT NULL,
  `DocCur` varchar(3) DEFAULT NULL,
  `DocRate` decimal(19,6) DEFAULT NULL,
  `DocTotal` decimal(19,6) DEFAULT NULL,
  `DocTotalFC` decimal(19,6) DEFAULT NULL,
  `PaidToDate` decimal(19,6) DEFAULT NULL,
  `PaidFC` decimal(19,6) DEFAULT NULL,
  `GrosProfit` decimal(19,6) DEFAULT NULL,
  `GrosProfFC` decimal(19,6) DEFAULT NULL,
  `Ref1` varchar(11) DEFAULT NULL,
  `Ref2` varchar(11) DEFAULT NULL,
  `Comments` varchar(254) DEFAULT NULL,
  `JrnlMemo` varchar(50) DEFAULT NULL,
  `TransId` int(11) DEFAULT NULL,
  `ReceiptNum` int(11) DEFAULT NULL,
  `GroupNum` smallint(6) DEFAULT NULL,
  `DocTime` smallint(6) DEFAULT NULL,
  `SlpCode` smallint(6) DEFAULT '-1',
  `TrnspCode` smallint(6) DEFAULT '-1',
  `PartSupply` char(1) DEFAULT 'Y',
  `Confirmed` char(1) DEFAULT 'Y',
  `GrossBase` smallint(6) DEFAULT '0',
  `ImportEnt` int(11) DEFAULT NULL,
  `CreateTran` char(1) DEFAULT 'N',
  `SummryType` char(1) DEFAULT 'N',
  `UpdInvnt` char(1) DEFAULT 'N',
  `UpdCardBal` char(1) DEFAULT 'N',
  `Instance` smallint(6) NOT NULL DEFAULT '0',
  `Flags` int(11) DEFAULT '0',
  `InvntDirec` char(1) DEFAULT 'X',
  `CntctCode` int(11) DEFAULT NULL,
  `ShowSCN` char(1) DEFAULT 'N',
  `FatherCard` varchar(15) DEFAULT NULL,
  `SysRate` decimal(19,6) DEFAULT NULL,
  `CurSource` char(1) DEFAULT 'C',
  `VatSumSy` decimal(19,6) DEFAULT NULL,
  `DiscSumSy` decimal(19,6) DEFAULT NULL,
  `DocTotalSy` decimal(19,6) DEFAULT NULL,
  `PaidSys` decimal(19,6) DEFAULT NULL,
  `FatherType` char(1) DEFAULT 'P',
  `GrosProfSy` decimal(19,6) DEFAULT NULL,
  `UpdateDate` datetime DEFAULT NULL,
  `IsICT` char(1) DEFAULT 'N',
  `CreateDate` datetime DEFAULT NULL,
  `Volume` decimal(19,6) DEFAULT NULL,
  `VolUnit` smallint(6) DEFAULT NULL,
  `Weight` decimal(19,6) DEFAULT NULL,
  `WeightUnit` smallint(6) DEFAULT NULL,
  `Series` smallint(6) DEFAULT NULL,
  `TaxDate` datetime DEFAULT NULL,
  `Filler` varchar(8) DEFAULT NULL,
  `DataSource` char(1) DEFAULT 'N',
  `StampNum` varchar(16) DEFAULT NULL,
  `isCrin` char(1) DEFAULT 'N',
  `FinncPriod` int(11) DEFAULT NULL,
  `UserSign` smallint(6) DEFAULT NULL,
  `selfInv` char(1) DEFAULT 'N',
  `VatPaid` decimal(19,6) DEFAULT NULL,
  `VatPaidFC` decimal(19,6) DEFAULT NULL,
  `VatPaidSys` decimal(19,6) DEFAULT NULL,
  `UserSign2` smallint(6) DEFAULT NULL,
  `WddStatus` char(1) DEFAULT '-',
  `draftKey` int(11) DEFAULT '-1',
  `TotalExpns` decimal(19,6) DEFAULT NULL,
  `TotalExpFC` decimal(19,6) DEFAULT NULL,
  `TotalExpSC` decimal(19,6) DEFAULT NULL,
  `DunnLevel` int(11) DEFAULT NULL,
  `Address2` varchar(254) DEFAULT NULL,
  `LogInstanc` smallint(6) DEFAULT '0',
  `Exported` char(1) DEFAULT 'N',
  `StationID` int(11) DEFAULT NULL,
  `Indicator` varchar(2) DEFAULT NULL,
  `NetProc` char(1) DEFAULT 'N',
  `AqcsTax` decimal(19,6) DEFAULT NULL,
  `AqcsTaxFC` decimal(19,6) DEFAULT NULL,
  `AqcsTaxSC` decimal(19,6) DEFAULT NULL,
  `CashDiscPr` decimal(19,6) DEFAULT NULL,
  `CashDiscnt` decimal(19,6) DEFAULT NULL,
  `CashDiscFC` decimal(19,6) DEFAULT NULL,
  `CashDiscSC` decimal(19,6) DEFAULT NULL,
  `ShipToCode` varchar(50) DEFAULT NULL,
  `LicTradNum` varchar(32) DEFAULT NULL,
  `PaymentRef` varchar(27) DEFAULT NULL,
  `WTSum` decimal(19,6) DEFAULT NULL,
  `WTSumFC` decimal(19,6) DEFAULT NULL,
  `WTSumSC` decimal(19,6) DEFAULT NULL,
  `RoundDif` decimal(19,6) DEFAULT NULL,
  `RoundDifFC` decimal(19,6) DEFAULT NULL,
  `RoundDifSy` decimal(19,6) DEFAULT NULL,
  `CheckDigit` char(1) DEFAULT NULL,
  `Form1099` int(11) DEFAULT NULL,
  `Box1099` varchar(20) DEFAULT NULL,
  `submitted` char(1) DEFAULT 'N',
  `PoPrss` char(1) DEFAULT 'N',
  `Rounding` char(1) DEFAULT 'N',
  `RevisionPo` char(1) DEFAULT 'N',
  `Segment` smallint(6) NOT NULL DEFAULT '0',
  `ReqDate` datetime DEFAULT NULL,
  `CancelDate` datetime DEFAULT NULL,
  `PickStatus` char(1) DEFAULT 'N',
  `Pick` char(1) DEFAULT 'N',
  `BlockDunn` char(1) DEFAULT 'N',
  `PeyMethod` varchar(15) DEFAULT NULL,
  `PayBlock` char(1) DEFAULT 'N',
  `PayBlckRef` int(11) DEFAULT NULL,
  `MaxDscn` char(1) DEFAULT 'N',
  `Reserve` char(1) DEFAULT 'N',
  `Max1099` decimal(19,6) DEFAULT NULL,
  `CntrlBnk` varchar(15) DEFAULT NULL,
  `PickRmrk` varchar(254) DEFAULT NULL,
  `ISRCodLine` varchar(53) DEFAULT NULL,
  `ExpAppl` decimal(19,6) DEFAULT NULL,
  `ExpApplFC` decimal(19,6) DEFAULT NULL,
  `ExpApplSC` decimal(19,6) DEFAULT NULL,
  `Project` varchar(20) DEFAULT NULL,
  `DeferrTax` char(1) DEFAULT NULL,
  `LetterNum` varchar(20) DEFAULT NULL,
  `FromDate` datetime DEFAULT NULL,
  `ToDate` datetime DEFAULT NULL,
  `WTApplied` decimal(19,6) DEFAULT NULL,
  `WTAppliedF` decimal(19,6) DEFAULT NULL,
  `BoeReserev` char(1) DEFAULT 'N',
  `AgentCode` varchar(32) DEFAULT NULL,
  `WTAppliedS` decimal(19,6) DEFAULT NULL,
  `EquVatSum` decimal(19,6) DEFAULT NULL,
  `EquVatSumF` decimal(19,6) DEFAULT NULL,
  `EquVatSumS` decimal(19,6) DEFAULT NULL,
  `Installmnt` smallint(6) DEFAULT '1',
  `VATFirst` char(1) DEFAULT NULL,
  `NnSbAmnt` decimal(19,6) DEFAULT NULL,
  `NnSbAmntSC` decimal(19,6) DEFAULT NULL,
  `NbSbAmntFC` decimal(19,6) DEFAULT NULL,
  `ExepAmnt` decimal(19,6) DEFAULT NULL,
  `ExepAmntSC` decimal(19,6) DEFAULT NULL,
  `ExepAmntFC` decimal(19,6) DEFAULT NULL,
  `VatDate` datetime DEFAULT NULL,
  `CorrExt` varchar(25) DEFAULT NULL,
  `CorrInv` int(11) DEFAULT NULL,
  `NCorrInv` int(11) DEFAULT NULL,
  `CEECFlag` char(1) DEFAULT 'N',
  `BaseAmnt` decimal(19,6) DEFAULT NULL,
  `BaseAmntSC` decimal(19,6) DEFAULT NULL,
  `BaseAmntFC` decimal(19,6) DEFAULT NULL,
  `CtlAccount` varchar(15) DEFAULT NULL,
  `BPLId` int(11) DEFAULT NULL,
  `BPLName` varchar(20) DEFAULT NULL,
  `VATRegNum` varchar(12) DEFAULT NULL,
  `TxInvRptNo` varchar(10) DEFAULT NULL,
  `TxInvRptDt` datetime DEFAULT NULL,
  `KVVATCode` longtext,
  `WTDetails` varchar(100) DEFAULT NULL,
  `SumAbsId` int(11) DEFAULT '-1',
  `SumRptDate` datetime DEFAULT NULL,
  `PIndicator` varchar(10) NOT NULL DEFAULT ' ',
  `ManualNum` varchar(20) DEFAULT NULL,
  `UseShpdGd` char(1) DEFAULT 'N',
  `BaseVtAt` decimal(19,6) DEFAULT NULL,
  `BaseVtAtSC` decimal(19,6) DEFAULT NULL,
  `BaseVtAtFC` decimal(19,6) DEFAULT NULL,
  `NnSbVAt` decimal(19,6) DEFAULT NULL,
  `NnSbVAtSC` decimal(19,6) DEFAULT NULL,
  `NbSbVAtFC` decimal(19,6) DEFAULT NULL,
  `ExptVAt` decimal(19,6) DEFAULT NULL,
  `ExptVAtSC` decimal(19,6) DEFAULT NULL,
  `ExptVAtFC` decimal(19,6) DEFAULT NULL,
  `LYPmtAt` decimal(19,6) DEFAULT NULL,
  `LYPmtAtSC` decimal(19,6) DEFAULT NULL,
  `LYPmtAtFC` decimal(19,6) DEFAULT NULL,
  `ExpAnSum` decimal(19,6) DEFAULT NULL,
  `ExpAnSys` decimal(19,6) DEFAULT NULL,
  `ExpAnFrgn` decimal(19,6) DEFAULT NULL,
  `DocSubType` varchar(2) NOT NULL DEFAULT '--',
  `DpmStatus` char(1) DEFAULT 'O',
  `DpmAmnt` decimal(19,6) DEFAULT NULL,
  `DpmAmntSC` decimal(19,6) DEFAULT NULL,
  `DpmAmntFC` decimal(19,6) DEFAULT NULL,
  `DpmDrawn` char(1) DEFAULT 'N',
  `DpmPrcnt` decimal(19,6) DEFAULT NULL,
  `PaidSum` decimal(19,6) DEFAULT NULL,
  `PaidSumFc` decimal(19,6) DEFAULT NULL,
  `PaidSumSc` decimal(19,6) DEFAULT NULL,
  `FolioPref` varchar(2) DEFAULT NULL,
  `FolioNum` int(11) DEFAULT NULL,
  `DpmAppl` decimal(19,6) DEFAULT NULL,
  `DpmApplFc` decimal(19,6) DEFAULT NULL,
  `DpmApplSc` decimal(19,6) DEFAULT NULL,
  `LPgFolioN` int(11) DEFAULT NULL,
  `Header` longtext,
  `Footer` longtext,
  `Posted` char(1) DEFAULT 'Y',
  `OwnerCode` int(11) DEFAULT NULL,
  `BPChCode` varchar(15) DEFAULT NULL,
  `BPChCntc` int(11) DEFAULT NULL,
  `PayToCode` varchar(50) DEFAULT NULL,
  `IsPaytoBnk` char(1) DEFAULT NULL,
  `BnkCntry` varchar(3) DEFAULT NULL,
  `BankCode` varchar(30) DEFAULT NULL,
  `BnkAccount` varchar(50) DEFAULT NULL,
  `BnkBranch` varchar(50) DEFAULT NULL,
  `isIns` char(1) DEFAULT 'N',
  `TrackNo` varchar(30) DEFAULT NULL,
  `VersionNum` varchar(11) DEFAULT NULL,
  `LangCode` int(11) DEFAULT NULL,
  `BPNameOW` char(1) DEFAULT 'N',
  `BillToOW` char(1) DEFAULT 'N',
  `ShipToOW` char(1) DEFAULT 'N',
  `RetInvoice` char(1) DEFAULT 'N',
  `ClsDate` datetime DEFAULT NULL,
  `MInvNum` int(11) DEFAULT NULL,
  `MInvDate` datetime DEFAULT NULL,
  `SeqCode` smallint(6) DEFAULT NULL,
  `Serial` int(11) DEFAULT NULL,
  `SeriesStr` varchar(3) DEFAULT NULL,
  `SubStr` varchar(3) DEFAULT NULL,
  `Model` varchar(10) DEFAULT '0',
  `TaxOnExp` decimal(19,6) DEFAULT NULL,
  `TaxOnExpFc` decimal(19,6) DEFAULT NULL,
  `TaxOnExpSc` decimal(19,6) DEFAULT NULL,
  `TaxOnExAp` decimal(19,6) DEFAULT NULL,
  `TaxOnExApF` decimal(19,6) DEFAULT NULL,
  `TaxOnExApS` decimal(19,6) DEFAULT NULL,
  `LastPmnTyp` char(1) DEFAULT NULL,
  `LndCstNum` int(11) DEFAULT NULL,
  `UseCorrVat` char(1) DEFAULT 'N',
  `BlkCredMmo` char(1) DEFAULT 'N',
  `OpenForLaC` char(1) DEFAULT 'Y',
  `Excised` char(1) DEFAULT 'O',
  `ExcRefDate` datetime DEFAULT NULL,
  `ExcRmvTime` varchar(8) DEFAULT NULL,
  `SrvGpPrcnt` decimal(19,6) DEFAULT NULL,
  `DepositNum` int(11) DEFAULT NULL,
  `CertNum` varchar(31) DEFAULT NULL,
  `DutyStatus` char(1) DEFAULT 'Y',
  `AutoCrtFlw` char(1) DEFAULT 'N',
  `FlwRefDate` datetime DEFAULT NULL,
  `FlwRefNum` varchar(100) DEFAULT NULL,
  `VatJENum` int(11) DEFAULT '-1',
  `DpmVat` decimal(19,6) DEFAULT NULL,
  `DpmVatFc` decimal(19,6) DEFAULT NULL,
  `DpmVatSc` decimal(19,6) DEFAULT NULL,
  `DpmAppVat` decimal(19,6) DEFAULT NULL,
  `DpmAppVatF` decimal(19,6) DEFAULT NULL,
  `DpmAppVatS` decimal(19,6) DEFAULT NULL,
  `InsurOp347` char(1) DEFAULT 'N',
  `IgnRelDoc` char(1) DEFAULT 'N',
  `BuildDesc` varchar(50) DEFAULT NULL,
  `ResidenNum` char(1) DEFAULT '1',
  `Checker` int(11) DEFAULT NULL,
  `Payee` int(11) DEFAULT NULL,
  `CopyNumber` int(11) DEFAULT '0',
  `NTSApprov` char(1) DEFAULT 'N',
  `NTSWebSite` smallint(6) DEFAULT NULL,
  `NTSeTaxNo` varchar(50) DEFAULT NULL,
  `NTSApprNo` varchar(50) DEFAULT NULL,
  `PayDuMonth` char(1) DEFAULT NULL,
  `ExtraMonth` smallint(6) DEFAULT NULL,
  `ExtraDays` smallint(6) DEFAULT NULL,
  `CdcOffset` smallint(6) DEFAULT '0',
  `SignMsg` longtext,
  `SignDigest` longtext,
  `CertifNum` varchar(50) DEFAULT NULL,
  `KeyVersion` int(11) DEFAULT NULL,
  `EDocGenTyp` char(1) DEFAULT 'N',
  `ESeries` smallint(6) DEFAULT NULL,
  `EDocNum` varchar(30) DEFAULT NULL,
  `EDocExpFrm` int(11) DEFAULT NULL,
  `SSIExmpt` char(1) DEFAULT NULL,
  `PQTGrpSer` smallint(6) DEFAULT NULL,
  `PQTGrpNum` int(11) DEFAULT NULL,
  `PQTGrpHW` char(1) DEFAULT 'N',
  `ReopOriDoc` char(1) DEFAULT NULL,
  `ReopManCls` char(1) DEFAULT NULL,
  `DocManClsd` char(1) DEFAULT 'N',
  `U_OB_RefNo` longtext,
  `U_OB_DONo` longtext,
  `U_OB_FOC` longtext,
  `U_OB_RecUpToNWeek` decimal(19,6) DEFAULT NULL,
  `U_OB_ConUpToNWeek` decimal(19,6) DEFAULT NULL,
  `U_OB_ETA_MNL` datetime DEFAULT NULL,
  `U_OB_ISSUE_DATE` datetime DEFAULT NULL,
  `U_OB_Assembly_Line` longtext,
  `U_OB_TradeTerms` longtext,
  `U_OB_PrioLevel` longtext,
  `U_OB_PCNum` longtext,
  `U_OB_Package` longtext,
  `U_OB_LotNumber` longtext,
  `U_OB_FreightTerm` longtext,
  `U_OB_PackageNo` decimal(19,6) DEFAULT NULL,
  `U_OB_RevReason` longtext,
  `U_OB_PrepBy` longtext,
  `U_OB_RevReason1` longtext,
  `U_OB_TotalQty` decimal(19,6) DEFAULT NULL,
  `U_OB_Activity` longtext,
  `U_OB_Notes` longtext,
  `U_OB_PEZAPN` longtext,
  `U_OB_IssueDoc` int(11) DEFAULT NULL,
  `U_OB_CheckedBy` longtext,
  `U_HeaderID` longtext,
  PRIMARY KEY (`DocEntry`),
  UNIQUE KEY `OPOR_NUM` (`DocNum`,`Instance`,`Segment`,`DocSubType`,`PIndicator`),
  KEY `OPOR_AT_CARD` (`NumAtCard`,`CardCode`),
  KEY `OPOR_CUSTOMER` (`CardCode`),
  KEY `OPOR_DOC_STATUS` (`DocStatus`,`CANCELED`),
  KEY `OPOR_FTHR_CARD` (`FatherCard`,`FatherType`),
  KEY `OPOR_SERIES` (`Series`),
  KEY `OPOR_OWNER_CODE` (`OwnerCode`),
  KEY `OPOR_DATE_PIND` (`DocDate`,`PIndicator`),
  KEY `OPOR_ESERIES` (`ESeries`,`EDocNum`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `OPOR`
--

INSERT INTO `OPOR` (`DocEntry`, `DocNum`, `DocType`, `CANCELED`, `Handwrtten`, `Printed`, `DocStatus`, `InvntSttus`, `Transfered`, `ObjType`, `DocDate`, `DocDueDate`, `CardCode`, `CardName`, `Address`, `NumAtCard`, `VatPercent`, `VatSum`, `VatSumFC`, `DiscPrcnt`, `DiscSum`, `DiscSumFC`, `DocCur`, `DocRate`, `DocTotal`, `DocTotalFC`, `PaidToDate`, `PaidFC`, `GrosProfit`, `GrosProfFC`, `Ref1`, `Ref2`, `Comments`, `JrnlMemo`, `TransId`, `ReceiptNum`, `GroupNum`, `DocTime`, `SlpCode`, `TrnspCode`, `PartSupply`, `Confirmed`, `GrossBase`, `ImportEnt`, `CreateTran`, `SummryType`, `UpdInvnt`, `UpdCardBal`, `Instance`, `Flags`, `InvntDirec`, `CntctCode`, `ShowSCN`, `FatherCard`, `SysRate`, `CurSource`, `VatSumSy`, `DiscSumSy`, `DocTotalSy`, `PaidSys`, `FatherType`, `GrosProfSy`, `UpdateDate`, `IsICT`, `CreateDate`, `Volume`, `VolUnit`, `Weight`, `WeightUnit`, `Series`, `TaxDate`, `Filler`, `DataSource`, `StampNum`, `isCrin`, `FinncPriod`, `UserSign`, `selfInv`, `VatPaid`, `VatPaidFC`, `VatPaidSys`, `UserSign2`, `WddStatus`, `draftKey`, `TotalExpns`, `TotalExpFC`, `TotalExpSC`, `DunnLevel`, `Address2`, `LogInstanc`, `Exported`, `StationID`, `Indicator`, `NetProc`, `AqcsTax`, `AqcsTaxFC`, `AqcsTaxSC`, `CashDiscPr`, `CashDiscnt`, `CashDiscFC`, `CashDiscSC`, `ShipToCode`, `LicTradNum`, `PaymentRef`, `WTSum`, `WTSumFC`, `WTSumSC`, `RoundDif`, `RoundDifFC`, `RoundDifSy`, `CheckDigit`, `Form1099`, `Box1099`, `submitted`, `PoPrss`, `Rounding`, `RevisionPo`, `Segment`, `ReqDate`, `CancelDate`, `PickStatus`, `Pick`, `BlockDunn`, `PeyMethod`, `PayBlock`, `PayBlckRef`, `MaxDscn`, `Reserve`, `Max1099`, `CntrlBnk`, `PickRmrk`, `ISRCodLine`, `ExpAppl`, `ExpApplFC`, `ExpApplSC`, `Project`, `DeferrTax`, `LetterNum`, `FromDate`, `ToDate`, `WTApplied`, `WTAppliedF`, `BoeReserev`, `AgentCode`, `WTAppliedS`, `EquVatSum`, `EquVatSumF`, `EquVatSumS`, `Installmnt`, `VATFirst`, `NnSbAmnt`, `NnSbAmntSC`, `NbSbAmntFC`, `ExepAmnt`, `ExepAmntSC`, `ExepAmntFC`, `VatDate`, `CorrExt`, `CorrInv`, `NCorrInv`, `CEECFlag`, `BaseAmnt`, `BaseAmntSC`, `BaseAmntFC`, `CtlAccount`, `BPLId`, `BPLName`, `VATRegNum`, `TxInvRptNo`, `TxInvRptDt`, `KVVATCode`, `WTDetails`, `SumAbsId`, `SumRptDate`, `PIndicator`, `ManualNum`, `UseShpdGd`, `BaseVtAt`, `BaseVtAtSC`, `BaseVtAtFC`, `NnSbVAt`, `NnSbVAtSC`, `NbSbVAtFC`, `ExptVAt`, `ExptVAtSC`, `ExptVAtFC`, `LYPmtAt`, `LYPmtAtSC`, `LYPmtAtFC`, `ExpAnSum`, `ExpAnSys`, `ExpAnFrgn`, `DocSubType`, `DpmStatus`, `DpmAmnt`, `DpmAmntSC`, `DpmAmntFC`, `DpmDrawn`, `DpmPrcnt`, `PaidSum`, `PaidSumFc`, `PaidSumSc`, `FolioPref`, `FolioNum`, `DpmAppl`, `DpmApplFc`, `DpmApplSc`, `LPgFolioN`, `Header`, `Footer`, `Posted`, `OwnerCode`, `BPChCode`, `BPChCntc`, `PayToCode`, `IsPaytoBnk`, `BnkCntry`, `BankCode`, `BnkAccount`, `BnkBranch`, `isIns`, `TrackNo`, `VersionNum`, `LangCode`, `BPNameOW`, `BillToOW`, `ShipToOW`, `RetInvoice`, `ClsDate`, `MInvNum`, `MInvDate`, `SeqCode`, `Serial`, `SeriesStr`, `SubStr`, `Model`, `TaxOnExp`, `TaxOnExpFc`, `TaxOnExpSc`, `TaxOnExAp`, `TaxOnExApF`, `TaxOnExApS`, `LastPmnTyp`, `LndCstNum`, `UseCorrVat`, `BlkCredMmo`, `OpenForLaC`, `Excised`, `ExcRefDate`, `ExcRmvTime`, `SrvGpPrcnt`, `DepositNum`, `CertNum`, `DutyStatus`, `AutoCrtFlw`, `FlwRefDate`, `FlwRefNum`, `VatJENum`, `DpmVat`, `DpmVatFc`, `DpmVatSc`, `DpmAppVat`, `DpmAppVatF`, `DpmAppVatS`, `InsurOp347`, `IgnRelDoc`, `BuildDesc`, `ResidenNum`, `Checker`, `Payee`, `CopyNumber`, `NTSApprov`, `NTSWebSite`, `NTSeTaxNo`, `NTSApprNo`, `PayDuMonth`, `ExtraMonth`, `ExtraDays`, `CdcOffset`, `SignMsg`, `SignDigest`, `CertifNum`, `KeyVersion`, `EDocGenTyp`, `ESeries`, `EDocNum`, `EDocExpFrm`, `SSIExmpt`, `PQTGrpSer`, `PQTGrpNum`, `PQTGrpHW`, `ReopOriDoc`, `ReopManCls`, `DocManClsd`, `U_OB_RefNo`, `U_OB_DONo`, `U_OB_FOC`, `U_OB_RecUpToNWeek`, `U_OB_ConUpToNWeek`, `U_OB_ETA_MNL`, `U_OB_ISSUE_DATE`, `U_OB_Assembly_Line`, `U_OB_TradeTerms`, `U_OB_PrioLevel`, `U_OB_PCNum`, `U_OB_Package`, `U_OB_LotNumber`, `U_OB_FreightTerm`, `U_OB_PackageNo`, `U_OB_RevReason`, `U_OB_PrepBy`, `U_OB_RevReason1`, `U_OB_TotalQty`, `U_OB_Activity`, `U_OB_Notes`, `U_OB_PEZAPN`, `U_OB_IssueDoc`, `U_OB_CheckedBy`, `U_HeaderID`) VALUES
(15411, 110004780, 'I', 'N', 'N', 'N', 'O', 'O', 'N', '22', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, -1, -1, 'Y', 'Y', 0, NULL, 'N', 'N', 'N', 'N', 0, 0, 'X', NULL, 'N', NULL, NULL, 'C', NULL, NULL, NULL, NULL, 'P', NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, 'N', NULL, NULL, 'N', NULL, NULL, NULL, NULL, '-', -1, NULL, NULL, NULL, NULL, NULL, 0, 'N', NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', 'N', 'N', 'N', 0, NULL, NULL, 'N', 'N', 'N', NULL, 'N', NULL, 'N', 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, -1, NULL, ' ', NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '--', 'O', NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Y', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, 'N', 'N', 'N', 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, '0', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', 'N', 'Y', 'O', NULL, NULL, NULL, NULL, NULL, 'Y', 'N', NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, NULL, 'N', 'N', NULL, '1', NULL, NULL, 0, 'N', NULL, NULL, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `ORPC`
--

CREATE TABLE IF NOT EXISTS `ORPC` (
  `DocEntry` int(11) NOT NULL,
  `DocNum` int(11) NOT NULL,
  `DocType` char(1) DEFAULT 'I',
  `CANCELED` char(1) DEFAULT 'N',
  `Handwrtten` char(1) DEFAULT 'N',
  `Printed` char(1) DEFAULT 'N',
  `DocStatus` char(1) DEFAULT 'O',
  `InvntSttus` char(1) DEFAULT 'O',
  `Transfered` char(1) DEFAULT 'N',
  `ObjType` varchar(20) DEFAULT '19',
  `DocDate` datetime DEFAULT NULL,
  `DocDueDate` datetime DEFAULT NULL,
  `CardCode` varchar(15) DEFAULT NULL,
  `CardName` varchar(100) DEFAULT NULL,
  `Address` varchar(254) DEFAULT NULL,
  `NumAtCard` varchar(100) DEFAULT NULL,
  `VatPercent` decimal(19,6) DEFAULT NULL,
  `VatSum` decimal(19,6) DEFAULT NULL,
  `VatSumFC` decimal(19,6) DEFAULT NULL,
  `DiscPrcnt` decimal(19,6) DEFAULT NULL,
  `DiscSum` decimal(19,6) DEFAULT NULL,
  `DiscSumFC` decimal(19,6) DEFAULT NULL,
  `DocCur` varchar(3) DEFAULT NULL,
  `DocRate` decimal(19,6) DEFAULT NULL,
  `DocTotal` decimal(19,6) DEFAULT NULL,
  `DocTotalFC` decimal(19,6) DEFAULT NULL,
  `PaidToDate` decimal(19,6) DEFAULT NULL,
  `PaidFC` decimal(19,6) DEFAULT NULL,
  `GrosProfit` decimal(19,6) DEFAULT NULL,
  `GrosProfFC` decimal(19,6) DEFAULT NULL,
  `Ref1` varchar(11) DEFAULT NULL,
  `Ref2` varchar(11) DEFAULT NULL,
  `Comments` varchar(254) DEFAULT NULL,
  `JrnlMemo` varchar(50) DEFAULT NULL,
  `TransId` int(11) DEFAULT NULL,
  `ReceiptNum` int(11) DEFAULT NULL,
  `GroupNum` smallint(6) DEFAULT NULL,
  `DocTime` smallint(6) DEFAULT NULL,
  `SlpCode` smallint(6) DEFAULT '-1',
  `TrnspCode` smallint(6) DEFAULT '-1',
  `PartSupply` char(1) DEFAULT 'Y',
  `Confirmed` char(1) DEFAULT 'Y',
  `GrossBase` smallint(6) DEFAULT '0',
  `ImportEnt` int(11) DEFAULT NULL,
  `CreateTran` char(1) DEFAULT 'N',
  `SummryType` char(1) DEFAULT 'N',
  `UpdInvnt` char(1) DEFAULT 'N',
  `UpdCardBal` char(1) DEFAULT 'N',
  `Instance` smallint(6) NOT NULL DEFAULT '0',
  `Flags` int(11) DEFAULT '0',
  `InvntDirec` char(1) DEFAULT 'X',
  `CntctCode` int(11) DEFAULT NULL,
  `ShowSCN` char(1) DEFAULT 'N',
  `FatherCard` varchar(15) DEFAULT NULL,
  `SysRate` decimal(19,6) DEFAULT NULL,
  `CurSource` char(1) DEFAULT 'C',
  `VatSumSy` decimal(19,6) DEFAULT NULL,
  `DiscSumSy` decimal(19,6) DEFAULT NULL,
  `DocTotalSy` decimal(19,6) DEFAULT NULL,
  `PaidSys` decimal(19,6) DEFAULT NULL,
  `FatherType` char(1) DEFAULT 'P',
  `GrosProfSy` decimal(19,6) DEFAULT NULL,
  `UpdateDate` datetime DEFAULT NULL,
  `IsICT` char(1) DEFAULT 'N',
  `CreateDate` datetime DEFAULT NULL,
  `Volume` decimal(19,6) DEFAULT NULL,
  `VolUnit` smallint(6) DEFAULT NULL,
  `Weight` decimal(19,6) DEFAULT NULL,
  `WeightUnit` smallint(6) DEFAULT NULL,
  `Series` smallint(6) DEFAULT NULL,
  `TaxDate` datetime DEFAULT NULL,
  `Filler` varchar(8) DEFAULT NULL,
  `DataSource` char(1) DEFAULT 'N',
  `StampNum` varchar(16) DEFAULT NULL,
  `isCrin` char(1) DEFAULT 'N',
  `FinncPriod` int(11) DEFAULT NULL,
  `UserSign` smallint(6) DEFAULT NULL,
  `selfInv` char(1) DEFAULT 'N',
  `VatPaid` decimal(19,6) DEFAULT NULL,
  `VatPaidFC` decimal(19,6) DEFAULT NULL,
  `VatPaidSys` decimal(19,6) DEFAULT NULL,
  `UserSign2` smallint(6) DEFAULT NULL,
  `WddStatus` char(1) DEFAULT '-',
  `draftKey` int(11) DEFAULT '-1',
  `TotalExpns` decimal(19,6) DEFAULT NULL,
  `TotalExpFC` decimal(19,6) DEFAULT NULL,
  `TotalExpSC` decimal(19,6) DEFAULT NULL,
  `DunnLevel` int(11) DEFAULT NULL,
  `Address2` varchar(254) DEFAULT NULL,
  `LogInstanc` smallint(6) DEFAULT '0',
  `Exported` char(1) DEFAULT 'N',
  `StationID` int(11) DEFAULT NULL,
  `Indicator` varchar(2) DEFAULT NULL,
  `NetProc` char(1) DEFAULT 'N',
  `AqcsTax` decimal(19,6) DEFAULT NULL,
  `AqcsTaxFC` decimal(19,6) DEFAULT NULL,
  `AqcsTaxSC` decimal(19,6) DEFAULT NULL,
  `CashDiscPr` decimal(19,6) DEFAULT NULL,
  `CashDiscnt` decimal(19,6) DEFAULT NULL,
  `CashDiscFC` decimal(19,6) DEFAULT NULL,
  `CashDiscSC` decimal(19,6) DEFAULT NULL,
  `ShipToCode` varchar(50) DEFAULT NULL,
  `LicTradNum` varchar(32) DEFAULT NULL,
  `PaymentRef` varchar(27) DEFAULT NULL,
  `WTSum` decimal(19,6) DEFAULT NULL,
  `WTSumFC` decimal(19,6) DEFAULT NULL,
  `WTSumSC` decimal(19,6) DEFAULT NULL,
  `RoundDif` decimal(19,6) DEFAULT NULL,
  `RoundDifFC` decimal(19,6) DEFAULT NULL,
  `RoundDifSy` decimal(19,6) DEFAULT NULL,
  `CheckDigit` char(1) DEFAULT NULL,
  `Form1099` int(11) DEFAULT NULL,
  `Box1099` varchar(20) DEFAULT NULL,
  `submitted` char(1) DEFAULT 'N',
  `PoPrss` char(1) DEFAULT 'N',
  `Rounding` char(1) DEFAULT 'N',
  `RevisionPo` char(1) DEFAULT 'N',
  `Segment` smallint(6) NOT NULL DEFAULT '0',
  `ReqDate` datetime DEFAULT NULL,
  `CancelDate` datetime DEFAULT NULL,
  `PickStatus` char(1) DEFAULT 'N',
  `Pick` char(1) DEFAULT 'N',
  `BlockDunn` char(1) DEFAULT 'N',
  `PeyMethod` varchar(15) DEFAULT NULL,
  `PayBlock` char(1) DEFAULT 'N',
  `PayBlckRef` int(11) DEFAULT NULL,
  `MaxDscn` char(1) DEFAULT 'N',
  `Reserve` char(1) DEFAULT 'N',
  `Max1099` decimal(19,6) DEFAULT NULL,
  `CntrlBnk` varchar(15) DEFAULT NULL,
  `PickRmrk` varchar(254) DEFAULT NULL,
  `ISRCodLine` varchar(53) DEFAULT NULL,
  `ExpAppl` decimal(19,6) DEFAULT NULL,
  `ExpApplFC` decimal(19,6) DEFAULT NULL,
  `ExpApplSC` decimal(19,6) DEFAULT NULL,
  `Project` varchar(20) DEFAULT NULL,
  `DeferrTax` char(1) DEFAULT NULL,
  `LetterNum` varchar(20) DEFAULT NULL,
  `FromDate` datetime DEFAULT NULL,
  `ToDate` datetime DEFAULT NULL,
  `WTApplied` decimal(19,6) DEFAULT NULL,
  `WTAppliedF` decimal(19,6) DEFAULT NULL,
  `BoeReserev` char(1) DEFAULT 'N',
  `AgentCode` varchar(32) DEFAULT NULL,
  `WTAppliedS` decimal(19,6) DEFAULT NULL,
  `EquVatSum` decimal(19,6) DEFAULT NULL,
  `EquVatSumF` decimal(19,6) DEFAULT NULL,
  `EquVatSumS` decimal(19,6) DEFAULT NULL,
  `Installmnt` smallint(6) DEFAULT '1',
  `VATFirst` char(1) DEFAULT NULL,
  `NnSbAmnt` decimal(19,6) DEFAULT NULL,
  `NnSbAmntSC` decimal(19,6) DEFAULT NULL,
  `NbSbAmntFC` decimal(19,6) DEFAULT NULL,
  `ExepAmnt` decimal(19,6) DEFAULT NULL,
  `ExepAmntSC` decimal(19,6) DEFAULT NULL,
  `ExepAmntFC` decimal(19,6) DEFAULT NULL,
  `VatDate` datetime DEFAULT NULL,
  `CorrExt` varchar(25) DEFAULT NULL,
  `CorrInv` int(11) DEFAULT NULL,
  `NCorrInv` int(11) DEFAULT NULL,
  `CEECFlag` char(1) DEFAULT 'N',
  `BaseAmnt` decimal(19,6) DEFAULT NULL,
  `BaseAmntSC` decimal(19,6) DEFAULT NULL,
  `BaseAmntFC` decimal(19,6) DEFAULT NULL,
  `CtlAccount` varchar(15) DEFAULT NULL,
  `BPLId` int(11) DEFAULT NULL,
  `BPLName` varchar(20) DEFAULT NULL,
  `VATRegNum` varchar(12) DEFAULT NULL,
  `TxInvRptNo` varchar(10) DEFAULT NULL,
  `TxInvRptDt` datetime DEFAULT NULL,
  `KVVATCode` longtext,
  `WTDetails` varchar(100) DEFAULT NULL,
  `SumAbsId` int(11) DEFAULT '-1',
  `SumRptDate` datetime DEFAULT NULL,
  `PIndicator` varchar(10) NOT NULL DEFAULT ' ',
  `ManualNum` varchar(20) DEFAULT NULL,
  `UseShpdGd` char(1) DEFAULT 'N',
  `BaseVtAt` decimal(19,6) DEFAULT NULL,
  `BaseVtAtSC` decimal(19,6) DEFAULT NULL,
  `BaseVtAtFC` decimal(19,6) DEFAULT NULL,
  `NnSbVAt` decimal(19,6) DEFAULT NULL,
  `NnSbVAtSC` decimal(19,6) DEFAULT NULL,
  `NbSbVAtFC` decimal(19,6) DEFAULT NULL,
  `ExptVAt` decimal(19,6) DEFAULT NULL,
  `ExptVAtSC` decimal(19,6) DEFAULT NULL,
  `ExptVAtFC` decimal(19,6) DEFAULT NULL,
  `LYPmtAt` decimal(19,6) DEFAULT NULL,
  `LYPmtAtSC` decimal(19,6) DEFAULT NULL,
  `LYPmtAtFC` decimal(19,6) DEFAULT NULL,
  `ExpAnSum` decimal(19,6) DEFAULT NULL,
  `ExpAnSys` decimal(19,6) DEFAULT NULL,
  `ExpAnFrgn` decimal(19,6) DEFAULT NULL,
  `DocSubType` varchar(2) NOT NULL DEFAULT '--',
  `DpmStatus` char(1) DEFAULT 'O',
  `DpmAmnt` decimal(19,6) DEFAULT NULL,
  `DpmAmntSC` decimal(19,6) DEFAULT NULL,
  `DpmAmntFC` decimal(19,6) DEFAULT NULL,
  `DpmDrawn` char(1) DEFAULT 'N',
  `DpmPrcnt` decimal(19,6) DEFAULT NULL,
  `PaidSum` decimal(19,6) DEFAULT NULL,
  `PaidSumFc` decimal(19,6) DEFAULT NULL,
  `PaidSumSc` decimal(19,6) DEFAULT NULL,
  `FolioPref` varchar(2) DEFAULT NULL,
  `FolioNum` int(11) DEFAULT NULL,
  `DpmAppl` decimal(19,6) DEFAULT NULL,
  `DpmApplFc` decimal(19,6) DEFAULT NULL,
  `DpmApplSc` decimal(19,6) DEFAULT NULL,
  `LPgFolioN` int(11) DEFAULT NULL,
  `Header` longtext,
  `Footer` longtext,
  `Posted` char(1) DEFAULT 'Y',
  `OwnerCode` int(11) DEFAULT NULL,
  `BPChCode` varchar(15) DEFAULT NULL,
  `BPChCntc` int(11) DEFAULT NULL,
  `PayToCode` varchar(50) DEFAULT NULL,
  `IsPaytoBnk` char(1) DEFAULT NULL,
  `BnkCntry` varchar(3) DEFAULT NULL,
  `BankCode` varchar(30) DEFAULT NULL,
  `BnkAccount` varchar(50) DEFAULT NULL,
  `BnkBranch` varchar(50) DEFAULT NULL,
  `isIns` char(1) DEFAULT 'N',
  `TrackNo` varchar(30) DEFAULT NULL,
  `VersionNum` varchar(11) DEFAULT NULL,
  `LangCode` int(11) DEFAULT NULL,
  `BPNameOW` char(1) DEFAULT 'N',
  `BillToOW` char(1) DEFAULT 'N',
  `ShipToOW` char(1) DEFAULT 'N',
  `RetInvoice` char(1) DEFAULT 'N',
  `ClsDate` datetime DEFAULT NULL,
  `MInvNum` int(11) DEFAULT NULL,
  `MInvDate` datetime DEFAULT NULL,
  `SeqCode` smallint(6) DEFAULT NULL,
  `Serial` int(11) DEFAULT NULL,
  `SeriesStr` varchar(3) DEFAULT NULL,
  `SubStr` varchar(3) DEFAULT NULL,
  `Model` varchar(10) DEFAULT '0',
  `TaxOnExp` decimal(19,6) DEFAULT NULL,
  `TaxOnExpFc` decimal(19,6) DEFAULT NULL,
  `TaxOnExpSc` decimal(19,6) DEFAULT NULL,
  `TaxOnExAp` decimal(19,6) DEFAULT NULL,
  `TaxOnExApF` decimal(19,6) DEFAULT NULL,
  `TaxOnExApS` decimal(19,6) DEFAULT NULL,
  `LastPmnTyp` char(1) DEFAULT NULL,
  `LndCstNum` int(11) DEFAULT NULL,
  `UseCorrVat` char(1) DEFAULT 'N',
  `BlkCredMmo` char(1) DEFAULT 'N',
  `OpenForLaC` char(1) DEFAULT 'Y',
  `Excised` char(1) DEFAULT 'O',
  `ExcRefDate` datetime DEFAULT NULL,
  `ExcRmvTime` varchar(8) DEFAULT NULL,
  `SrvGpPrcnt` decimal(19,6) DEFAULT NULL,
  `DepositNum` int(11) DEFAULT NULL,
  `CertNum` varchar(31) DEFAULT NULL,
  `DutyStatus` char(1) DEFAULT 'Y',
  `AutoCrtFlw` char(1) DEFAULT 'N',
  `FlwRefDate` datetime DEFAULT NULL,
  `FlwRefNum` varchar(100) DEFAULT NULL,
  `VatJENum` int(11) DEFAULT '-1',
  `DpmVat` decimal(19,6) DEFAULT NULL,
  `DpmVatFc` decimal(19,6) DEFAULT NULL,
  `DpmVatSc` decimal(19,6) DEFAULT NULL,
  `DpmAppVat` decimal(19,6) DEFAULT NULL,
  `DpmAppVatF` decimal(19,6) DEFAULT NULL,
  `DpmAppVatS` decimal(19,6) DEFAULT NULL,
  `InsurOp347` char(1) DEFAULT 'N',
  `IgnRelDoc` char(1) DEFAULT 'N',
  `BuildDesc` varchar(50) DEFAULT NULL,
  `ResidenNum` char(1) DEFAULT '1',
  `Checker` int(11) DEFAULT NULL,
  `Payee` int(11) DEFAULT NULL,
  `CopyNumber` int(11) DEFAULT '0',
  `NTSApprov` char(1) DEFAULT 'N',
  `NTSWebSite` smallint(6) DEFAULT NULL,
  `NTSeTaxNo` varchar(50) DEFAULT NULL,
  `NTSApprNo` varchar(50) DEFAULT NULL,
  `PayDuMonth` char(1) DEFAULT NULL,
  `ExtraMonth` smallint(6) DEFAULT NULL,
  `ExtraDays` smallint(6) DEFAULT NULL,
  `CdcOffset` smallint(6) DEFAULT '0',
  `SignMsg` longtext,
  `SignDigest` longtext,
  `CertifNum` varchar(50) DEFAULT NULL,
  `KeyVersion` int(11) DEFAULT NULL,
  `EDocGenTyp` char(1) DEFAULT 'N',
  `ESeries` smallint(6) DEFAULT NULL,
  `EDocNum` varchar(30) DEFAULT NULL,
  `EDocExpFrm` int(11) DEFAULT NULL,
  `SSIExmpt` char(1) DEFAULT NULL,
  `PQTGrpSer` smallint(6) DEFAULT NULL,
  `PQTGrpNum` int(11) DEFAULT NULL,
  `PQTGrpHW` char(1) DEFAULT 'N',
  `ReopOriDoc` char(1) DEFAULT NULL,
  `ReopManCls` char(1) DEFAULT NULL,
  `DocManClsd` char(1) DEFAULT 'N',
  `U_OB_RefNo` longtext,
  `U_OB_DONo` longtext,
  `U_OB_FOC` longtext,
  `U_OB_RecUpToNWeek` decimal(19,6) DEFAULT NULL,
  `U_OB_ConUpToNWeek` decimal(19,6) DEFAULT NULL,
  `U_OB_ETA_MNL` datetime DEFAULT NULL,
  `U_OB_ISSUE_DATE` datetime DEFAULT NULL,
  `U_OB_Assembly_Line` longtext,
  `U_OB_TradeTerms` longtext,
  `U_OB_PrioLevel` longtext,
  `U_OB_PCNum` longtext,
  `U_OB_Package` longtext,
  `U_OB_LotNumber` longtext,
  `U_OB_FreightTerm` longtext,
  `U_OB_PackageNo` decimal(19,6) DEFAULT NULL,
  `U_OB_RevReason` longtext,
  `U_OB_PrepBy` longtext,
  `U_OB_RevReason1` longtext,
  `U_OB_TotalQty` decimal(19,6) DEFAULT NULL,
  `U_OB_Activity` longtext,
  `U_OB_Notes` longtext,
  `U_OB_PEZAPN` longtext,
  `U_OB_IssueDoc` int(11) DEFAULT NULL,
  `U_OB_CheckedBy` longtext,
  `U_HeaderID` longtext,
  PRIMARY KEY (`DocEntry`),
  UNIQUE KEY `ORPC_NUM` (`DocNum`,`Instance`,`Segment`,`DocSubType`,`PIndicator`),
  KEY `ORPC_AT_CARD` (`NumAtCard`,`CardCode`),
  KEY `ORPC_CUSTOMER` (`CardCode`),
  KEY `ORPC_DOC_STATUS` (`DocStatus`,`CANCELED`),
  KEY `ORPC_FTHR_CARD` (`FatherCard`,`FatherType`),
  KEY `ORPC_SERIES` (`Series`),
  KEY `ORPC_OWNER_CODE` (`OwnerCode`),
  KEY `ORPC_DATE_PIND` (`DocDate`,`PIndicator`),
  KEY `ORPC_ESERIES` (`ESeries`,`EDocNum`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ORPC`
--

INSERT INTO `ORPC` (`DocEntry`, `DocNum`, `DocType`, `CANCELED`, `Handwrtten`, `Printed`, `DocStatus`, `InvntSttus`, `Transfered`, `ObjType`, `DocDate`, `DocDueDate`, `CardCode`, `CardName`, `Address`, `NumAtCard`, `VatPercent`, `VatSum`, `VatSumFC`, `DiscPrcnt`, `DiscSum`, `DiscSumFC`, `DocCur`, `DocRate`, `DocTotal`, `DocTotalFC`, `PaidToDate`, `PaidFC`, `GrosProfit`, `GrosProfFC`, `Ref1`, `Ref2`, `Comments`, `JrnlMemo`, `TransId`, `ReceiptNum`, `GroupNum`, `DocTime`, `SlpCode`, `TrnspCode`, `PartSupply`, `Confirmed`, `GrossBase`, `ImportEnt`, `CreateTran`, `SummryType`, `UpdInvnt`, `UpdCardBal`, `Instance`, `Flags`, `InvntDirec`, `CntctCode`, `ShowSCN`, `FatherCard`, `SysRate`, `CurSource`, `VatSumSy`, `DiscSumSy`, `DocTotalSy`, `PaidSys`, `FatherType`, `GrosProfSy`, `UpdateDate`, `IsICT`, `CreateDate`, `Volume`, `VolUnit`, `Weight`, `WeightUnit`, `Series`, `TaxDate`, `Filler`, `DataSource`, `StampNum`, `isCrin`, `FinncPriod`, `UserSign`, `selfInv`, `VatPaid`, `VatPaidFC`, `VatPaidSys`, `UserSign2`, `WddStatus`, `draftKey`, `TotalExpns`, `TotalExpFC`, `TotalExpSC`, `DunnLevel`, `Address2`, `LogInstanc`, `Exported`, `StationID`, `Indicator`, `NetProc`, `AqcsTax`, `AqcsTaxFC`, `AqcsTaxSC`, `CashDiscPr`, `CashDiscnt`, `CashDiscFC`, `CashDiscSC`, `ShipToCode`, `LicTradNum`, `PaymentRef`, `WTSum`, `WTSumFC`, `WTSumSC`, `RoundDif`, `RoundDifFC`, `RoundDifSy`, `CheckDigit`, `Form1099`, `Box1099`, `submitted`, `PoPrss`, `Rounding`, `RevisionPo`, `Segment`, `ReqDate`, `CancelDate`, `PickStatus`, `Pick`, `BlockDunn`, `PeyMethod`, `PayBlock`, `PayBlckRef`, `MaxDscn`, `Reserve`, `Max1099`, `CntrlBnk`, `PickRmrk`, `ISRCodLine`, `ExpAppl`, `ExpApplFC`, `ExpApplSC`, `Project`, `DeferrTax`, `LetterNum`, `FromDate`, `ToDate`, `WTApplied`, `WTAppliedF`, `BoeReserev`, `AgentCode`, `WTAppliedS`, `EquVatSum`, `EquVatSumF`, `EquVatSumS`, `Installmnt`, `VATFirst`, `NnSbAmnt`, `NnSbAmntSC`, `NbSbAmntFC`, `ExepAmnt`, `ExepAmntSC`, `ExepAmntFC`, `VatDate`, `CorrExt`, `CorrInv`, `NCorrInv`, `CEECFlag`, `BaseAmnt`, `BaseAmntSC`, `BaseAmntFC`, `CtlAccount`, `BPLId`, `BPLName`, `VATRegNum`, `TxInvRptNo`, `TxInvRptDt`, `KVVATCode`, `WTDetails`, `SumAbsId`, `SumRptDate`, `PIndicator`, `ManualNum`, `UseShpdGd`, `BaseVtAt`, `BaseVtAtSC`, `BaseVtAtFC`, `NnSbVAt`, `NnSbVAtSC`, `NbSbVAtFC`, `ExptVAt`, `ExptVAtSC`, `ExptVAtFC`, `LYPmtAt`, `LYPmtAtSC`, `LYPmtAtFC`, `ExpAnSum`, `ExpAnSys`, `ExpAnFrgn`, `DocSubType`, `DpmStatus`, `DpmAmnt`, `DpmAmntSC`, `DpmAmntFC`, `DpmDrawn`, `DpmPrcnt`, `PaidSum`, `PaidSumFc`, `PaidSumSc`, `FolioPref`, `FolioNum`, `DpmAppl`, `DpmApplFc`, `DpmApplSc`, `LPgFolioN`, `Header`, `Footer`, `Posted`, `OwnerCode`, `BPChCode`, `BPChCntc`, `PayToCode`, `IsPaytoBnk`, `BnkCntry`, `BankCode`, `BnkAccount`, `BnkBranch`, `isIns`, `TrackNo`, `VersionNum`, `LangCode`, `BPNameOW`, `BillToOW`, `ShipToOW`, `RetInvoice`, `ClsDate`, `MInvNum`, `MInvDate`, `SeqCode`, `Serial`, `SeriesStr`, `SubStr`, `Model`, `TaxOnExp`, `TaxOnExpFc`, `TaxOnExpSc`, `TaxOnExAp`, `TaxOnExApF`, `TaxOnExApS`, `LastPmnTyp`, `LndCstNum`, `UseCorrVat`, `BlkCredMmo`, `OpenForLaC`, `Excised`, `ExcRefDate`, `ExcRmvTime`, `SrvGpPrcnt`, `DepositNum`, `CertNum`, `DutyStatus`, `AutoCrtFlw`, `FlwRefDate`, `FlwRefNum`, `VatJENum`, `DpmVat`, `DpmVatFc`, `DpmVatSc`, `DpmAppVat`, `DpmAppVatF`, `DpmAppVatS`, `InsurOp347`, `IgnRelDoc`, `BuildDesc`, `ResidenNum`, `Checker`, `Payee`, `CopyNumber`, `NTSApprov`, `NTSWebSite`, `NTSeTaxNo`, `NTSApprNo`, `PayDuMonth`, `ExtraMonth`, `ExtraDays`, `CdcOffset`, `SignMsg`, `SignDigest`, `CertifNum`, `KeyVersion`, `EDocGenTyp`, `ESeries`, `EDocNum`, `EDocExpFrm`, `SSIExmpt`, `PQTGrpSer`, `PQTGrpNum`, `PQTGrpHW`, `ReopOriDoc`, `ReopManCls`, `DocManClsd`, `U_OB_RefNo`, `U_OB_DONo`, `U_OB_FOC`, `U_OB_RecUpToNWeek`, `U_OB_ConUpToNWeek`, `U_OB_ETA_MNL`, `U_OB_ISSUE_DATE`, `U_OB_Assembly_Line`, `U_OB_TradeTerms`, `U_OB_PrioLevel`, `U_OB_PCNum`, `U_OB_Package`, `U_OB_LotNumber`, `U_OB_FreightTerm`, `U_OB_PackageNo`, `U_OB_RevReason`, `U_OB_PrepBy`, `U_OB_RevReason1`, `U_OB_TotalQty`, `U_OB_Activity`, `U_OB_Notes`, `U_OB_PEZAPN`, `U_OB_IssueDoc`, `U_OB_CheckedBy`, `U_HeaderID`) VALUES
(729, 190000155, 'I', 'N', 'N', 'N', 'O', 'O', 'N', '19', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, -1, -1, 'Y', 'Y', 0, NULL, 'N', 'N', 'N', 'N', 0, 0, 'X', NULL, 'N', NULL, NULL, 'C', NULL, NULL, NULL, NULL, 'P', NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, 'N', NULL, NULL, 'N', NULL, NULL, NULL, NULL, '-', -1, NULL, NULL, NULL, NULL, NULL, 0, 'N', NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', 'N', 'N', 'N', 0, NULL, NULL, 'N', 'N', 'N', NULL, 'N', NULL, 'N', 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, -1, NULL, ' ', NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '--', 'O', NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Y', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, 'N', 'N', 'N', 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, '0', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', 'N', 'Y', 'O', NULL, NULL, NULL, NULL, NULL, 'Y', 'N', NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, NULL, 'N', 'N', NULL, '1', NULL, NULL, 0, 'N', NULL, NULL, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `ORPD`
--

CREATE TABLE IF NOT EXISTS `ORPD` (
  `DocEntry` int(11) NOT NULL,
  `DocNum` int(11) NOT NULL,
  `DocType` char(1) DEFAULT 'I',
  `CANCELED` char(1) DEFAULT 'N',
  `Handwrtten` char(1) DEFAULT 'N',
  `Printed` char(1) DEFAULT 'N',
  `DocStatus` char(1) DEFAULT 'O',
  `InvntSttus` char(1) DEFAULT 'O',
  `Transfered` char(1) DEFAULT 'N',
  `ObjType` varchar(20) DEFAULT '21',
  `DocDate` datetime DEFAULT NULL,
  `DocDueDate` datetime DEFAULT NULL,
  `CardCode` varchar(15) DEFAULT NULL,
  `CardName` varchar(100) DEFAULT NULL,
  `Address` varchar(254) DEFAULT NULL,
  `NumAtCard` varchar(100) DEFAULT NULL,
  `VatPercent` decimal(19,6) DEFAULT NULL,
  `VatSum` decimal(19,6) DEFAULT NULL,
  `VatSumFC` decimal(19,6) DEFAULT NULL,
  `DiscPrcnt` decimal(19,6) DEFAULT NULL,
  `DiscSum` decimal(19,6) DEFAULT NULL,
  `DiscSumFC` decimal(19,6) DEFAULT NULL,
  `DocCur` varchar(3) DEFAULT NULL,
  `DocRate` decimal(19,6) DEFAULT NULL,
  `DocTotal` decimal(19,6) DEFAULT NULL,
  `DocTotalFC` decimal(19,6) DEFAULT NULL,
  `PaidToDate` decimal(19,6) DEFAULT NULL,
  `PaidFC` decimal(19,6) DEFAULT NULL,
  `GrosProfit` decimal(19,6) DEFAULT NULL,
  `GrosProfFC` decimal(19,6) DEFAULT NULL,
  `Ref1` varchar(11) DEFAULT NULL,
  `Ref2` varchar(11) DEFAULT NULL,
  `Comments` varchar(254) DEFAULT NULL,
  `JrnlMemo` varchar(50) DEFAULT NULL,
  `TransId` int(11) DEFAULT NULL,
  `ReceiptNum` int(11) DEFAULT NULL,
  `GroupNum` smallint(6) DEFAULT NULL,
  `DocTime` smallint(6) DEFAULT NULL,
  `SlpCode` smallint(6) DEFAULT '-1',
  `TrnspCode` smallint(6) DEFAULT '-1',
  `PartSupply` char(1) DEFAULT 'Y',
  `Confirmed` char(1) DEFAULT 'Y',
  `GrossBase` smallint(6) DEFAULT '0',
  `ImportEnt` int(11) DEFAULT NULL,
  `CreateTran` char(1) DEFAULT 'N',
  `SummryType` char(1) DEFAULT 'N',
  `UpdInvnt` char(1) DEFAULT 'N',
  `UpdCardBal` char(1) DEFAULT 'N',
  `Instance` smallint(6) NOT NULL DEFAULT '0',
  `Flags` int(11) DEFAULT '0',
  `InvntDirec` char(1) DEFAULT 'X',
  `CntctCode` int(11) DEFAULT NULL,
  `ShowSCN` char(1) DEFAULT 'N',
  `FatherCard` varchar(15) DEFAULT NULL,
  `SysRate` decimal(19,6) DEFAULT NULL,
  `CurSource` char(1) DEFAULT 'C',
  `VatSumSy` decimal(19,6) DEFAULT NULL,
  `DiscSumSy` decimal(19,6) DEFAULT NULL,
  `DocTotalSy` decimal(19,6) DEFAULT NULL,
  `PaidSys` decimal(19,6) DEFAULT NULL,
  `FatherType` char(1) DEFAULT 'P',
  `GrosProfSy` decimal(19,6) DEFAULT NULL,
  `UpdateDate` datetime DEFAULT NULL,
  `IsICT` char(1) DEFAULT 'N',
  `CreateDate` datetime DEFAULT NULL,
  `Volume` decimal(19,6) DEFAULT NULL,
  `VolUnit` smallint(6) DEFAULT NULL,
  `Weight` decimal(19,6) DEFAULT NULL,
  `WeightUnit` smallint(6) DEFAULT NULL,
  `Series` smallint(6) DEFAULT NULL,
  `TaxDate` datetime DEFAULT NULL,
  `Filler` varchar(8) DEFAULT NULL,
  `DataSource` char(1) DEFAULT 'N',
  `StampNum` varchar(16) DEFAULT NULL,
  `isCrin` char(1) DEFAULT 'N',
  `FinncPriod` int(11) DEFAULT NULL,
  `UserSign` smallint(6) DEFAULT NULL,
  `selfInv` char(1) DEFAULT 'N',
  `VatPaid` decimal(19,6) DEFAULT NULL,
  `VatPaidFC` decimal(19,6) DEFAULT NULL,
  `VatPaidSys` decimal(19,6) DEFAULT NULL,
  `UserSign2` smallint(6) DEFAULT NULL,
  `WddStatus` char(1) DEFAULT '-',
  `draftKey` int(11) DEFAULT '-1',
  `TotalExpns` decimal(19,6) DEFAULT NULL,
  `TotalExpFC` decimal(19,6) DEFAULT NULL,
  `TotalExpSC` decimal(19,6) DEFAULT NULL,
  `DunnLevel` int(11) DEFAULT NULL,
  `Address2` varchar(254) DEFAULT NULL,
  `LogInstanc` smallint(6) DEFAULT '0',
  `Exported` char(1) DEFAULT 'N',
  `StationID` int(11) DEFAULT NULL,
  `Indicator` varchar(2) DEFAULT NULL,
  `NetProc` char(1) DEFAULT 'N',
  `AqcsTax` decimal(19,6) DEFAULT NULL,
  `AqcsTaxFC` decimal(19,6) DEFAULT NULL,
  `AqcsTaxSC` decimal(19,6) DEFAULT NULL,
  `CashDiscPr` decimal(19,6) DEFAULT NULL,
  `CashDiscnt` decimal(19,6) DEFAULT NULL,
  `CashDiscFC` decimal(19,6) DEFAULT NULL,
  `CashDiscSC` decimal(19,6) DEFAULT NULL,
  `ShipToCode` varchar(50) DEFAULT NULL,
  `LicTradNum` varchar(32) DEFAULT NULL,
  `PaymentRef` varchar(27) DEFAULT NULL,
  `WTSum` decimal(19,6) DEFAULT NULL,
  `WTSumFC` decimal(19,6) DEFAULT NULL,
  `WTSumSC` decimal(19,6) DEFAULT NULL,
  `RoundDif` decimal(19,6) DEFAULT NULL,
  `RoundDifFC` decimal(19,6) DEFAULT NULL,
  `RoundDifSy` decimal(19,6) DEFAULT NULL,
  `CheckDigit` char(1) DEFAULT NULL,
  `Form1099` int(11) DEFAULT NULL,
  `Box1099` varchar(20) DEFAULT NULL,
  `submitted` char(1) DEFAULT 'N',
  `PoPrss` char(1) DEFAULT 'N',
  `Rounding` char(1) DEFAULT 'N',
  `RevisionPo` char(1) DEFAULT 'N',
  `Segment` smallint(6) NOT NULL DEFAULT '0',
  `ReqDate` datetime DEFAULT NULL,
  `CancelDate` datetime DEFAULT NULL,
  `PickStatus` char(1) DEFAULT 'N',
  `Pick` char(1) DEFAULT 'N',
  `BlockDunn` char(1) DEFAULT 'N',
  `PeyMethod` varchar(15) DEFAULT NULL,
  `PayBlock` char(1) DEFAULT 'N',
  `PayBlckRef` int(11) DEFAULT NULL,
  `MaxDscn` char(1) DEFAULT 'N',
  `Reserve` char(1) DEFAULT 'N',
  `Max1099` decimal(19,6) DEFAULT NULL,
  `CntrlBnk` varchar(15) DEFAULT NULL,
  `PickRmrk` varchar(254) DEFAULT NULL,
  `ISRCodLine` varchar(53) DEFAULT NULL,
  `ExpAppl` decimal(19,6) DEFAULT NULL,
  `ExpApplFC` decimal(19,6) DEFAULT NULL,
  `ExpApplSC` decimal(19,6) DEFAULT NULL,
  `Project` varchar(20) DEFAULT NULL,
  `DeferrTax` char(1) DEFAULT NULL,
  `LetterNum` varchar(20) DEFAULT NULL,
  `FromDate` datetime DEFAULT NULL,
  `ToDate` datetime DEFAULT NULL,
  `WTApplied` decimal(19,6) DEFAULT NULL,
  `WTAppliedF` decimal(19,6) DEFAULT NULL,
  `BoeReserev` char(1) DEFAULT 'N',
  `AgentCode` varchar(32) DEFAULT NULL,
  `WTAppliedS` decimal(19,6) DEFAULT NULL,
  `EquVatSum` decimal(19,6) DEFAULT NULL,
  `EquVatSumF` decimal(19,6) DEFAULT NULL,
  `EquVatSumS` decimal(19,6) DEFAULT NULL,
  `Installmnt` smallint(6) DEFAULT '1',
  `VATFirst` char(1) DEFAULT NULL,
  `NnSbAmnt` decimal(19,6) DEFAULT NULL,
  `NnSbAmntSC` decimal(19,6) DEFAULT NULL,
  `NbSbAmntFC` decimal(19,6) DEFAULT NULL,
  `ExepAmnt` decimal(19,6) DEFAULT NULL,
  `ExepAmntSC` decimal(19,6) DEFAULT NULL,
  `ExepAmntFC` decimal(19,6) DEFAULT NULL,
  `VatDate` datetime DEFAULT NULL,
  `CorrExt` varchar(25) DEFAULT NULL,
  `CorrInv` int(11) DEFAULT NULL,
  `NCorrInv` int(11) DEFAULT NULL,
  `CEECFlag` char(1) DEFAULT 'N',
  `BaseAmnt` decimal(19,6) DEFAULT NULL,
  `BaseAmntSC` decimal(19,6) DEFAULT NULL,
  `BaseAmntFC` decimal(19,6) DEFAULT NULL,
  `CtlAccount` varchar(15) DEFAULT NULL,
  `BPLId` int(11) DEFAULT NULL,
  `BPLName` varchar(20) DEFAULT NULL,
  `VATRegNum` varchar(12) DEFAULT NULL,
  `TxInvRptNo` varchar(10) DEFAULT NULL,
  `TxInvRptDt` datetime DEFAULT NULL,
  `KVVATCode` longtext,
  `WTDetails` varchar(100) DEFAULT NULL,
  `SumAbsId` int(11) DEFAULT '-1',
  `SumRptDate` datetime DEFAULT NULL,
  `PIndicator` varchar(10) NOT NULL DEFAULT ' ',
  `ManualNum` varchar(20) DEFAULT NULL,
  `UseShpdGd` char(1) DEFAULT 'N',
  `BaseVtAt` decimal(19,6) DEFAULT NULL,
  `BaseVtAtSC` decimal(19,6) DEFAULT NULL,
  `BaseVtAtFC` decimal(19,6) DEFAULT NULL,
  `NnSbVAt` decimal(19,6) DEFAULT NULL,
  `NnSbVAtSC` decimal(19,6) DEFAULT NULL,
  `NbSbVAtFC` decimal(19,6) DEFAULT NULL,
  `ExptVAt` decimal(19,6) DEFAULT NULL,
  `ExptVAtSC` decimal(19,6) DEFAULT NULL,
  `ExptVAtFC` decimal(19,6) DEFAULT NULL,
  `LYPmtAt` decimal(19,6) DEFAULT NULL,
  `LYPmtAtSC` decimal(19,6) DEFAULT NULL,
  `LYPmtAtFC` decimal(19,6) DEFAULT NULL,
  `ExpAnSum` decimal(19,6) DEFAULT NULL,
  `ExpAnSys` decimal(19,6) DEFAULT NULL,
  `ExpAnFrgn` decimal(19,6) DEFAULT NULL,
  `DocSubType` varchar(2) NOT NULL DEFAULT '--',
  `DpmStatus` char(1) DEFAULT 'O',
  `DpmAmnt` decimal(19,6) DEFAULT NULL,
  `DpmAmntSC` decimal(19,6) DEFAULT NULL,
  `DpmAmntFC` decimal(19,6) DEFAULT NULL,
  `DpmDrawn` char(1) DEFAULT 'N',
  `DpmPrcnt` decimal(19,6) DEFAULT NULL,
  `PaidSum` decimal(19,6) DEFAULT NULL,
  `PaidSumFc` decimal(19,6) DEFAULT NULL,
  `PaidSumSc` decimal(19,6) DEFAULT NULL,
  `FolioPref` varchar(2) DEFAULT NULL,
  `FolioNum` int(11) DEFAULT NULL,
  `DpmAppl` decimal(19,6) DEFAULT NULL,
  `DpmApplFc` decimal(19,6) DEFAULT NULL,
  `DpmApplSc` decimal(19,6) DEFAULT NULL,
  `LPgFolioN` int(11) DEFAULT NULL,
  `Header` longtext,
  `Footer` longtext,
  `Posted` char(1) DEFAULT 'Y',
  `OwnerCode` int(11) DEFAULT NULL,
  `BPChCode` varchar(15) DEFAULT NULL,
  `BPChCntc` int(11) DEFAULT NULL,
  `PayToCode` varchar(50) DEFAULT NULL,
  `IsPaytoBnk` char(1) DEFAULT NULL,
  `BnkCntry` varchar(3) DEFAULT NULL,
  `BankCode` varchar(30) DEFAULT NULL,
  `BnkAccount` varchar(50) DEFAULT NULL,
  `BnkBranch` varchar(50) DEFAULT NULL,
  `isIns` char(1) DEFAULT 'N',
  `TrackNo` varchar(30) DEFAULT NULL,
  `VersionNum` varchar(11) DEFAULT NULL,
  `LangCode` int(11) DEFAULT NULL,
  `BPNameOW` char(1) DEFAULT 'N',
  `BillToOW` char(1) DEFAULT 'N',
  `ShipToOW` char(1) DEFAULT 'N',
  `RetInvoice` char(1) DEFAULT 'N',
  `ClsDate` datetime DEFAULT NULL,
  `MInvNum` int(11) DEFAULT NULL,
  `MInvDate` datetime DEFAULT NULL,
  `SeqCode` smallint(6) DEFAULT NULL,
  `Serial` int(11) DEFAULT NULL,
  `SeriesStr` varchar(3) DEFAULT NULL,
  `SubStr` varchar(3) DEFAULT NULL,
  `Model` varchar(10) DEFAULT '0',
  `TaxOnExp` decimal(19,6) DEFAULT NULL,
  `TaxOnExpFc` decimal(19,6) DEFAULT NULL,
  `TaxOnExpSc` decimal(19,6) DEFAULT NULL,
  `TaxOnExAp` decimal(19,6) DEFAULT NULL,
  `TaxOnExApF` decimal(19,6) DEFAULT NULL,
  `TaxOnExApS` decimal(19,6) DEFAULT NULL,
  `LastPmnTyp` char(1) DEFAULT NULL,
  `LndCstNum` int(11) DEFAULT NULL,
  `UseCorrVat` char(1) DEFAULT 'N',
  `BlkCredMmo` char(1) DEFAULT 'N',
  `OpenForLaC` char(1) DEFAULT 'Y',
  `Excised` char(1) DEFAULT 'O',
  `ExcRefDate` datetime DEFAULT NULL,
  `ExcRmvTime` varchar(8) DEFAULT NULL,
  `SrvGpPrcnt` decimal(19,6) DEFAULT NULL,
  `DepositNum` int(11) DEFAULT NULL,
  `CertNum` varchar(31) DEFAULT NULL,
  `DutyStatus` char(1) DEFAULT 'Y',
  `AutoCrtFlw` char(1) DEFAULT 'N',
  `FlwRefDate` datetime DEFAULT NULL,
  `FlwRefNum` varchar(100) DEFAULT NULL,
  `VatJENum` int(11) DEFAULT '-1',
  `DpmVat` decimal(19,6) DEFAULT NULL,
  `DpmVatFc` decimal(19,6) DEFAULT NULL,
  `DpmVatSc` decimal(19,6) DEFAULT NULL,
  `DpmAppVat` decimal(19,6) DEFAULT NULL,
  `DpmAppVatF` decimal(19,6) DEFAULT NULL,
  `DpmAppVatS` decimal(19,6) DEFAULT NULL,
  `InsurOp347` char(1) DEFAULT 'N',
  `IgnRelDoc` char(1) DEFAULT 'N',
  `BuildDesc` varchar(50) DEFAULT NULL,
  `ResidenNum` char(1) DEFAULT '1',
  `Checker` int(11) DEFAULT NULL,
  `Payee` int(11) DEFAULT NULL,
  `CopyNumber` int(11) DEFAULT '0',
  `NTSApprov` char(1) DEFAULT 'N',
  `NTSWebSite` smallint(6) DEFAULT NULL,
  `NTSeTaxNo` varchar(50) DEFAULT NULL,
  `NTSApprNo` varchar(50) DEFAULT NULL,
  `PayDuMonth` char(1) DEFAULT NULL,
  `ExtraMonth` smallint(6) DEFAULT NULL,
  `ExtraDays` smallint(6) DEFAULT NULL,
  `CdcOffset` smallint(6) DEFAULT '0',
  `SignMsg` longtext,
  `SignDigest` longtext,
  `CertifNum` varchar(50) DEFAULT NULL,
  `KeyVersion` int(11) DEFAULT NULL,
  `EDocGenTyp` char(1) DEFAULT 'N',
  `ESeries` smallint(6) DEFAULT NULL,
  `EDocNum` varchar(30) DEFAULT NULL,
  `EDocExpFrm` int(11) DEFAULT NULL,
  `SSIExmpt` char(1) DEFAULT NULL,
  `PQTGrpSer` smallint(6) DEFAULT NULL,
  `PQTGrpNum` int(11) DEFAULT NULL,
  `PQTGrpHW` char(1) DEFAULT 'N',
  `ReopOriDoc` char(1) DEFAULT NULL,
  `ReopManCls` char(1) DEFAULT NULL,
  `DocManClsd` char(1) DEFAULT 'N',
  `U_OB_RefNo` longtext,
  `U_OB_DONo` longtext,
  `U_OB_FOC` longtext,
  `U_OB_RecUpToNWeek` decimal(19,6) DEFAULT NULL,
  `U_OB_ConUpToNWeek` decimal(19,6) DEFAULT NULL,
  `U_OB_ETA_MNL` datetime DEFAULT NULL,
  `U_OB_ISSUE_DATE` datetime DEFAULT NULL,
  `U_OB_Assembly_Line` longtext,
  `U_OB_TradeTerms` longtext,
  `U_OB_PrioLevel` longtext,
  `U_OB_PCNum` longtext,
  `U_OB_Package` longtext,
  `U_OB_LotNumber` longtext,
  `U_OB_FreightTerm` longtext,
  `U_OB_PackageNo` decimal(19,6) DEFAULT NULL,
  `U_OB_RevReason` longtext,
  `U_OB_PrepBy` longtext,
  `U_OB_RevReason1` longtext,
  `U_OB_TotalQty` decimal(19,6) DEFAULT NULL,
  `U_OB_Activity` longtext,
  `U_OB_Notes` longtext,
  `U_OB_PEZAPN` longtext,
  `U_OB_IssueDoc` int(11) DEFAULT NULL,
  `U_OB_CheckedBy` longtext,
  `U_HeaderID` longtext,
  PRIMARY KEY (`DocEntry`),
  UNIQUE KEY `ORPD_NUM` (`DocNum`,`Instance`,`Segment`,`DocSubType`,`PIndicator`),
  KEY `ORPD_AT_CARD` (`NumAtCard`,`CardCode`),
  KEY `ORPD_CUSTOMER` (`CardCode`),
  KEY `ORPD_DOC_STATUS` (`DocStatus`,`CANCELED`),
  KEY `ORPD_FTHR_CARD` (`FatherCard`,`FatherType`),
  KEY `ORPD_SERIES` (`Series`),
  KEY `ORPD_OWNER_CODE` (`OwnerCode`),
  KEY `ORPD_DATE_PIND` (`DocDate`,`PIndicator`),
  KEY `ORPD_ESERIES` (`ESeries`,`EDocNum`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ORPD`
--

INSERT INTO `ORPD` (`DocEntry`, `DocNum`, `DocType`, `CANCELED`, `Handwrtten`, `Printed`, `DocStatus`, `InvntSttus`, `Transfered`, `ObjType`, `DocDate`, `DocDueDate`, `CardCode`, `CardName`, `Address`, `NumAtCard`, `VatPercent`, `VatSum`, `VatSumFC`, `DiscPrcnt`, `DiscSum`, `DiscSumFC`, `DocCur`, `DocRate`, `DocTotal`, `DocTotalFC`, `PaidToDate`, `PaidFC`, `GrosProfit`, `GrosProfFC`, `Ref1`, `Ref2`, `Comments`, `JrnlMemo`, `TransId`, `ReceiptNum`, `GroupNum`, `DocTime`, `SlpCode`, `TrnspCode`, `PartSupply`, `Confirmed`, `GrossBase`, `ImportEnt`, `CreateTran`, `SummryType`, `UpdInvnt`, `UpdCardBal`, `Instance`, `Flags`, `InvntDirec`, `CntctCode`, `ShowSCN`, `FatherCard`, `SysRate`, `CurSource`, `VatSumSy`, `DiscSumSy`, `DocTotalSy`, `PaidSys`, `FatherType`, `GrosProfSy`, `UpdateDate`, `IsICT`, `CreateDate`, `Volume`, `VolUnit`, `Weight`, `WeightUnit`, `Series`, `TaxDate`, `Filler`, `DataSource`, `StampNum`, `isCrin`, `FinncPriod`, `UserSign`, `selfInv`, `VatPaid`, `VatPaidFC`, `VatPaidSys`, `UserSign2`, `WddStatus`, `draftKey`, `TotalExpns`, `TotalExpFC`, `TotalExpSC`, `DunnLevel`, `Address2`, `LogInstanc`, `Exported`, `StationID`, `Indicator`, `NetProc`, `AqcsTax`, `AqcsTaxFC`, `AqcsTaxSC`, `CashDiscPr`, `CashDiscnt`, `CashDiscFC`, `CashDiscSC`, `ShipToCode`, `LicTradNum`, `PaymentRef`, `WTSum`, `WTSumFC`, `WTSumSC`, `RoundDif`, `RoundDifFC`, `RoundDifSy`, `CheckDigit`, `Form1099`, `Box1099`, `submitted`, `PoPrss`, `Rounding`, `RevisionPo`, `Segment`, `ReqDate`, `CancelDate`, `PickStatus`, `Pick`, `BlockDunn`, `PeyMethod`, `PayBlock`, `PayBlckRef`, `MaxDscn`, `Reserve`, `Max1099`, `CntrlBnk`, `PickRmrk`, `ISRCodLine`, `ExpAppl`, `ExpApplFC`, `ExpApplSC`, `Project`, `DeferrTax`, `LetterNum`, `FromDate`, `ToDate`, `WTApplied`, `WTAppliedF`, `BoeReserev`, `AgentCode`, `WTAppliedS`, `EquVatSum`, `EquVatSumF`, `EquVatSumS`, `Installmnt`, `VATFirst`, `NnSbAmnt`, `NnSbAmntSC`, `NbSbAmntFC`, `ExepAmnt`, `ExepAmntSC`, `ExepAmntFC`, `VatDate`, `CorrExt`, `CorrInv`, `NCorrInv`, `CEECFlag`, `BaseAmnt`, `BaseAmntSC`, `BaseAmntFC`, `CtlAccount`, `BPLId`, `BPLName`, `VATRegNum`, `TxInvRptNo`, `TxInvRptDt`, `KVVATCode`, `WTDetails`, `SumAbsId`, `SumRptDate`, `PIndicator`, `ManualNum`, `UseShpdGd`, `BaseVtAt`, `BaseVtAtSC`, `BaseVtAtFC`, `NnSbVAt`, `NnSbVAtSC`, `NbSbVAtFC`, `ExptVAt`, `ExptVAtSC`, `ExptVAtFC`, `LYPmtAt`, `LYPmtAtSC`, `LYPmtAtFC`, `ExpAnSum`, `ExpAnSys`, `ExpAnFrgn`, `DocSubType`, `DpmStatus`, `DpmAmnt`, `DpmAmntSC`, `DpmAmntFC`, `DpmDrawn`, `DpmPrcnt`, `PaidSum`, `PaidSumFc`, `PaidSumSc`, `FolioPref`, `FolioNum`, `DpmAppl`, `DpmApplFc`, `DpmApplSc`, `LPgFolioN`, `Header`, `Footer`, `Posted`, `OwnerCode`, `BPChCode`, `BPChCntc`, `PayToCode`, `IsPaytoBnk`, `BnkCntry`, `BankCode`, `BnkAccount`, `BnkBranch`, `isIns`, `TrackNo`, `VersionNum`, `LangCode`, `BPNameOW`, `BillToOW`, `ShipToOW`, `RetInvoice`, `ClsDate`, `MInvNum`, `MInvDate`, `SeqCode`, `Serial`, `SeriesStr`, `SubStr`, `Model`, `TaxOnExp`, `TaxOnExpFc`, `TaxOnExpSc`, `TaxOnExAp`, `TaxOnExApF`, `TaxOnExApS`, `LastPmnTyp`, `LndCstNum`, `UseCorrVat`, `BlkCredMmo`, `OpenForLaC`, `Excised`, `ExcRefDate`, `ExcRmvTime`, `SrvGpPrcnt`, `DepositNum`, `CertNum`, `DutyStatus`, `AutoCrtFlw`, `FlwRefDate`, `FlwRefNum`, `VatJENum`, `DpmVat`, `DpmVatFc`, `DpmVatSc`, `DpmAppVat`, `DpmAppVatF`, `DpmAppVatS`, `InsurOp347`, `IgnRelDoc`, `BuildDesc`, `ResidenNum`, `Checker`, `Payee`, `CopyNumber`, `NTSApprov`, `NTSWebSite`, `NTSeTaxNo`, `NTSApprNo`, `PayDuMonth`, `ExtraMonth`, `ExtraDays`, `CdcOffset`, `SignMsg`, `SignDigest`, `CertifNum`, `KeyVersion`, `EDocGenTyp`, `ESeries`, `EDocNum`, `EDocExpFrm`, `SSIExmpt`, `PQTGrpSer`, `PQTGrpNum`, `PQTGrpHW`, `ReopOriDoc`, `ReopManCls`, `DocManClsd`, `U_OB_RefNo`, `U_OB_DONo`, `U_OB_FOC`, `U_OB_RecUpToNWeek`, `U_OB_ConUpToNWeek`, `U_OB_ETA_MNL`, `U_OB_ISSUE_DATE`, `U_OB_Assembly_Line`, `U_OB_TradeTerms`, `U_OB_PrioLevel`, `U_OB_PCNum`, `U_OB_Package`, `U_OB_LotNumber`, `U_OB_FreightTerm`, `U_OB_PackageNo`, `U_OB_RevReason`, `U_OB_PrepBy`, `U_OB_RevReason1`, `U_OB_TotalQty`, `U_OB_Activity`, `U_OB_Notes`, `U_OB_PEZAPN`, `U_OB_IssueDoc`, `U_OB_CheckedBy`, `U_HeaderID`) VALUES
(1203, 160000220, 'I', 'N', 'N', 'N', 'O', 'O', 'N', '21', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, -1, -1, 'Y', 'Y', 0, NULL, 'N', 'N', 'N', 'N', 0, 0, 'X', NULL, 'N', NULL, NULL, 'C', NULL, NULL, NULL, NULL, 'P', NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, 'N', NULL, NULL, 'N', NULL, NULL, NULL, NULL, '-', -1, NULL, NULL, NULL, NULL, NULL, 0, 'N', NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', 'N', 'N', 'N', 0, NULL, NULL, 'N', 'N', 'N', NULL, 'N', NULL, 'N', 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, -1, NULL, ' ', NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '--', 'O', NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Y', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, 'N', 'N', 'N', 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, '0', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', 'N', 'Y', 'O', NULL, NULL, NULL, NULL, NULL, 'Y', 'N', NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, NULL, 'N', 'N', NULL, '1', NULL, NULL, 0, 'N', NULL, NULL, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `PCH1`
--

CREATE TABLE IF NOT EXISTS `PCH1` (
  `DocEntry` int(11) NOT NULL,
  `LineNum` int(11) NOT NULL,
  `TargetType` int(11) DEFAULT '-1',
  `TrgetEntry` int(11) DEFAULT NULL,
  `BaseRef` varchar(16) DEFAULT NULL,
  `BaseType` int(11) DEFAULT '-1',
  `BaseEntry` int(11) DEFAULT NULL,
  `BaseLine` int(11) DEFAULT NULL,
  `LineStatus` char(1) DEFAULT 'O',
  `ItemCode` varchar(20) DEFAULT NULL,
  `Dscription` varchar(100) DEFAULT NULL,
  `Quantity` decimal(19,6) DEFAULT NULL,
  `ShipDate` datetime DEFAULT NULL,
  `OpenQty` decimal(19,6) DEFAULT NULL,
  `Price` decimal(19,6) DEFAULT NULL,
  `Currency` varchar(3) DEFAULT NULL,
  `Rate` decimal(19,6) DEFAULT NULL,
  `DiscPrcnt` decimal(19,6) DEFAULT NULL,
  `LineTotal` decimal(19,6) DEFAULT NULL,
  `TotalFrgn` decimal(19,6) DEFAULT NULL,
  `OpenSum` decimal(19,6) DEFAULT NULL,
  `OpenSumFC` decimal(19,6) DEFAULT NULL,
  `VendorNum` varchar(17) DEFAULT NULL,
  `SerialNum` varchar(17) DEFAULT NULL,
  `WhsCode` varchar(8) DEFAULT NULL,
  `SlpCode` smallint(6) DEFAULT '-1',
  `Commission` decimal(19,6) DEFAULT NULL,
  `TreeType` char(1) DEFAULT 'N',
  `AcctCode` varchar(15) DEFAULT NULL,
  `TaxStatus` char(1) DEFAULT NULL,
  `GrossBuyPr` decimal(19,6) DEFAULT NULL,
  `PriceBefDi` decimal(19,6) DEFAULT NULL,
  `DocDate` datetime DEFAULT NULL,
  `Flags` int(11) DEFAULT '0',
  `OpenCreQty` decimal(19,6) DEFAULT NULL,
  `UseBaseUn` char(1) DEFAULT 'N',
  `SubCatNum` varchar(20) DEFAULT NULL,
  `BaseCard` varchar(15) DEFAULT NULL,
  `TotalSumSy` decimal(19,6) DEFAULT NULL,
  `OpenSumSys` decimal(19,6) DEFAULT NULL,
  `InvntSttus` char(1) DEFAULT 'O',
  `OcrCode` varchar(8) DEFAULT NULL,
  `Project` varchar(20) DEFAULT NULL,
  `CodeBars` varchar(16) DEFAULT NULL,
  `VatPrcnt` decimal(19,6) DEFAULT NULL,
  `VatGroup` varchar(8) DEFAULT NULL,
  `PriceAfVAT` decimal(19,6) DEFAULT NULL,
  `Height1` decimal(19,6) DEFAULT NULL,
  `Hght1Unit` smallint(6) DEFAULT NULL,
  `Height2` decimal(19,6) DEFAULT NULL,
  `Hght2Unit` smallint(6) DEFAULT NULL,
  `Width1` decimal(19,6) DEFAULT NULL,
  `Wdth1Unit` smallint(6) DEFAULT NULL,
  `Width2` decimal(19,6) DEFAULT NULL,
  `Wdth2Unit` smallint(6) DEFAULT NULL,
  `Length1` decimal(19,6) DEFAULT NULL,
  `Len1Unit` smallint(6) DEFAULT NULL,
  `length2` decimal(19,6) DEFAULT NULL,
  `Len2Unit` smallint(6) DEFAULT NULL,
  `Volume` decimal(19,6) DEFAULT NULL,
  `VolUnit` smallint(6) DEFAULT NULL,
  `Weight1` decimal(19,6) DEFAULT NULL,
  `Wght1Unit` smallint(6) DEFAULT NULL,
  `Weight2` decimal(19,6) DEFAULT NULL,
  `Wght2Unit` smallint(6) DEFAULT NULL,
  `Factor1` decimal(19,6) DEFAULT NULL,
  `Factor2` decimal(19,6) DEFAULT NULL,
  `Factor3` decimal(19,6) DEFAULT NULL,
  `Factor4` decimal(19,6) DEFAULT NULL,
  `PackQty` decimal(19,6) DEFAULT NULL,
  `UpdInvntry` char(1) DEFAULT 'Y',
  `BaseDocNum` int(11) DEFAULT NULL,
  `BaseAtCard` varchar(100) DEFAULT NULL,
  `SWW` varchar(16) DEFAULT NULL,
  `VatSum` decimal(19,6) DEFAULT NULL,
  `VatSumFrgn` decimal(19,6) DEFAULT NULL,
  `VatSumSy` decimal(19,6) DEFAULT NULL,
  `FinncPriod` int(11) DEFAULT NULL,
  `ObjType` varchar(20) DEFAULT '18',
  `LogInstanc` smallint(6) DEFAULT '0',
  `BlockNum` varchar(100) DEFAULT NULL,
  `ImportLog` varchar(20) DEFAULT NULL,
  `DedVatSum` decimal(19,6) DEFAULT NULL,
  `DedVatSumF` decimal(19,6) DEFAULT NULL,
  `DedVatSumS` decimal(19,6) DEFAULT NULL,
  `IsAqcuistn` char(1) DEFAULT 'N',
  `DistribSum` decimal(19,6) DEFAULT NULL,
  `DstrbSumFC` decimal(19,6) DEFAULT NULL,
  `DstrbSumSC` decimal(19,6) DEFAULT NULL,
  `GrssProfit` decimal(19,6) DEFAULT NULL,
  `GrssProfSC` decimal(19,6) DEFAULT NULL,
  `GrssProfFC` decimal(19,6) DEFAULT NULL,
  `VisOrder` int(11) DEFAULT NULL,
  `INMPrice` decimal(19,6) DEFAULT NULL,
  `PoTrgNum` int(11) DEFAULT NULL,
  `PoTrgEntry` varchar(11) DEFAULT NULL,
  `DropShip` char(1) DEFAULT 'N',
  `PoLineNum` int(11) DEFAULT NULL,
  `Address` varchar(254) DEFAULT NULL,
  `TaxCode` varchar(8) DEFAULT NULL,
  `TaxType` char(1) DEFAULT NULL,
  `OrigItem` varchar(20) DEFAULT NULL,
  `BackOrdr` char(1) DEFAULT NULL,
  `FreeTxt` varchar(100) DEFAULT NULL,
  `PickStatus` char(1) DEFAULT 'N',
  `PickOty` decimal(19,6) DEFAULT NULL,
  `PickIdNo` int(11) DEFAULT NULL,
  `TrnsCode` smallint(6) DEFAULT '-1',
  `VatAppld` decimal(19,6) DEFAULT NULL,
  `VatAppldFC` decimal(19,6) DEFAULT NULL,
  `VatAppldSC` decimal(19,6) DEFAULT NULL,
  `BaseQty` decimal(19,6) DEFAULT NULL,
  `BaseOpnQty` decimal(19,6) DEFAULT NULL,
  `VatDscntPr` decimal(19,6) DEFAULT NULL,
  `WtLiable` char(1) DEFAULT NULL,
  `DeferrTax` char(1) DEFAULT 'N',
  `EquVatPer` decimal(19,6) DEFAULT NULL,
  `EquVatSum` decimal(19,6) DEFAULT NULL,
  `EquVatSumF` decimal(19,6) DEFAULT NULL,
  `EquVatSumS` decimal(19,6) DEFAULT NULL,
  `LineVat` decimal(19,6) DEFAULT NULL,
  `LineVatlF` decimal(19,6) DEFAULT NULL,
  `LineVatS` decimal(19,6) DEFAULT NULL,
  `unitMsr` varchar(20) DEFAULT NULL,
  `NumPerMsr` decimal(19,6) DEFAULT NULL,
  `CEECFlag` char(1) DEFAULT 'S',
  `ToStock` decimal(19,6) DEFAULT NULL,
  `ToDiff` decimal(19,6) DEFAULT NULL,
  `ExciseAmt` decimal(19,6) DEFAULT NULL,
  `TaxPerUnit` decimal(19,6) DEFAULT NULL,
  `TotInclTax` decimal(19,6) DEFAULT NULL,
  `CountryOrg` varchar(3) DEFAULT NULL,
  `StckDstSum` decimal(19,6) DEFAULT NULL,
  `ReleasQtty` decimal(19,6) DEFAULT NULL,
  `LineType` char(1) DEFAULT 'R',
  `TranType` char(1) DEFAULT NULL,
  `Text` longtext,
  `OwnerCode` int(11) DEFAULT NULL,
  `StockPrice` decimal(19,6) DEFAULT NULL,
  `ConsumeFCT` char(1) DEFAULT NULL,
  `LstByDsSum` decimal(19,6) DEFAULT NULL,
  `StckINMPr` decimal(19,6) DEFAULT NULL,
  `LstBINMPr` decimal(19,6) DEFAULT NULL,
  `StckDstFc` decimal(19,6) DEFAULT NULL,
  `StckDstSc` decimal(19,6) DEFAULT NULL,
  `LstByDsFc` decimal(19,6) DEFAULT NULL,
  `LstByDsSc` decimal(19,6) DEFAULT NULL,
  `StockSum` decimal(19,6) DEFAULT NULL,
  `StockSumFc` decimal(19,6) DEFAULT NULL,
  `StockSumSc` decimal(19,6) DEFAULT NULL,
  `StckSumApp` decimal(19,6) DEFAULT NULL,
  `StckAppFc` decimal(19,6) DEFAULT NULL,
  `StckAppSc` decimal(19,6) DEFAULT NULL,
  `ShipToCode` varchar(50) DEFAULT NULL,
  `ShipToDesc` varchar(254) DEFAULT NULL,
  `StckAppD` decimal(19,6) DEFAULT NULL,
  `StckAppDFC` decimal(19,6) DEFAULT NULL,
  `StckAppDSC` decimal(19,6) DEFAULT NULL,
  `BasePrice` char(1) DEFAULT 'E',
  `GTotal` decimal(19,6) DEFAULT NULL,
  `GTotalFC` decimal(19,6) DEFAULT NULL,
  `GTotalSC` decimal(19,6) DEFAULT NULL,
  `DistribExp` char(1) DEFAULT NULL,
  `DescOW` char(1) DEFAULT 'N',
  `DetailsOW` char(1) DEFAULT 'N',
  `GrossBase` smallint(6) DEFAULT NULL,
  `VatWoDpm` decimal(19,6) DEFAULT NULL,
  `VatWoDpmFc` decimal(19,6) DEFAULT NULL,
  `VatWoDpmSc` decimal(19,6) DEFAULT NULL,
  `CFOPCode` varchar(6) DEFAULT NULL,
  `CSTCode` varchar(6) DEFAULT NULL,
  `Usage` int(11) DEFAULT NULL,
  `TaxOnly` char(1) DEFAULT NULL,
  `WtCalced` char(1) DEFAULT 'N',
  `QtyToShip` decimal(19,6) DEFAULT NULL,
  `DelivrdQty` decimal(19,6) DEFAULT NULL,
  `OrderedQty` decimal(19,6) DEFAULT NULL,
  `CogsOcrCod` varchar(8) DEFAULT NULL,
  `CiOppLineN` int(11) DEFAULT '-1',
  `CogsAcct` varchar(15) DEFAULT NULL,
  `ChgAsmBoMW` char(1) DEFAULT NULL,
  `ActDelDate` datetime DEFAULT NULL,
  `OcrCode2` varchar(8) DEFAULT NULL,
  `OcrCode3` varchar(8) DEFAULT NULL,
  `OcrCode4` varchar(8) DEFAULT NULL,
  `OcrCode5` varchar(8) DEFAULT NULL,
  `TaxDistSum` decimal(19,6) DEFAULT NULL,
  `TaxDistSFC` decimal(19,6) DEFAULT NULL,
  `TaxDistSSC` decimal(19,6) DEFAULT NULL,
  `PostTax` char(1) DEFAULT 'Y',
  `Excisable` char(1) DEFAULT NULL,
  `AssblValue` decimal(19,6) DEFAULT NULL,
  `RG23APart1` int(11) DEFAULT NULL,
  `RG23APart2` int(11) DEFAULT NULL,
  `RG23CPart1` int(11) DEFAULT NULL,
  `RG23CPart2` int(11) DEFAULT NULL,
  `CogsOcrCo2` varchar(8) DEFAULT NULL,
  `CogsOcrCo3` varchar(8) DEFAULT NULL,
  `CogsOcrCo4` varchar(8) DEFAULT NULL,
  `CogsOcrCo5` varchar(8) DEFAULT NULL,
  `LnExcised` char(1) DEFAULT NULL,
  `LocCode` int(11) DEFAULT NULL,
  `StockValue` decimal(19,6) DEFAULT NULL,
  `GPTtlBasPr` decimal(19,6) DEFAULT NULL,
  `unitMsr2` varchar(20) DEFAULT NULL,
  `NumPerMsr2` decimal(19,6) DEFAULT NULL,
  `SpecPrice` char(1) DEFAULT 'N',
  `CSTfIPI` varchar(2) DEFAULT NULL,
  `CSTfPIS` varchar(2) DEFAULT NULL,
  `CSTfCOFINS` varchar(2) DEFAULT NULL,
  `ExLineNo` varchar(10) DEFAULT NULL,
  `isSrvCall` char(1) DEFAULT 'N',
  `PQTReqQty` decimal(19,6) DEFAULT NULL,
  `PQTReqDate` datetime DEFAULT NULL,
  `PcDocType` int(11) DEFAULT '-1',
  `PcQuantity` decimal(19,6) DEFAULT NULL,
  `LinManClsd` char(1) DEFAULT 'N',
  `VatGrpSrc` char(1) DEFAULT 'N',
  `U_OB_RefNo` longtext,
  `U_OB_Price` decimal(19,6) DEFAULT NULL,
  `U_OB_Week01` decimal(19,6) DEFAULT NULL,
  `U_OB_Week02` decimal(19,6) DEFAULT NULL,
  `U_OB_Week03` decimal(19,6) DEFAULT NULL,
  `U_OB_Week04` decimal(19,6) DEFAULT NULL,
  `U_OB_Week05` decimal(19,6) DEFAULT NULL,
  `U_OB_Reason` longtext,
  `U_OB_Month_2` decimal(19,6) DEFAULT NULL,
  `U_OB_Month_3` decimal(19,6) DEFAULT NULL,
  `U_OB_Assembly_Line` longtext,
  `U_OB_PartNo` longtext,
  `U_OB_MatCost` decimal(19,6) DEFAULT NULL,
  `U_OB_LabCost` decimal(19,6) DEFAULT NULL,
  `U_OB_Box` decimal(19,6) DEFAULT NULL,
  `U_OB_PrioLevel` longtext,
  `U_OB_Shift` longtext,
  `U_OB_Process` longtext,
  `U_OB_AcctName` longtext,
  `U_OB_PRNO` longtext,
  `U_OB_Origin` longtext,
  `U_OB_SP_Assy_Line` longtext,
  `U_OB_IssueDoc` int(11) DEFAULT NULL,
  `U_NEC_ExpType` longtext,
  `U_Detail_ID` longtext,
  `U_Dept` longtext,
  `U_BudgetRef` longtext,
  PRIMARY KEY (`DocEntry`,`LineNum`),
  KEY `PCH1_STATUS` (`LineStatus`),
  KEY `PCH1_CURRENCY` (`Currency`),
  KEY `PCH1_ACCOUNT` (`AcctCode`),
  KEY `PCH1_BASE_ENTRY` (`BaseEntry`,`BaseType`,`BaseLine`),
  KEY `PCH1_VIS_ORDER` (`DocEntry`,`VisOrder`),
  KEY `PCH1_OWNER_CODE` (`OwnerCode`),
  KEY `PCH1_ITM_WHS_OQ` (`ItemCode`,`WhsCode`,`OpenQty`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `PCH1`
--

INSERT INTO `PCH1` (`DocEntry`, `LineNum`, `TargetType`, `TrgetEntry`, `BaseRef`, `BaseType`, `BaseEntry`, `BaseLine`, `LineStatus`, `ItemCode`, `Dscription`, `Quantity`, `ShipDate`, `OpenQty`, `Price`, `Currency`, `Rate`, `DiscPrcnt`, `LineTotal`, `TotalFrgn`, `OpenSum`, `OpenSumFC`, `VendorNum`, `SerialNum`, `WhsCode`, `SlpCode`, `Commission`, `TreeType`, `AcctCode`, `TaxStatus`, `GrossBuyPr`, `PriceBefDi`, `DocDate`, `Flags`, `OpenCreQty`, `UseBaseUn`, `SubCatNum`, `BaseCard`, `TotalSumSy`, `OpenSumSys`, `InvntSttus`, `OcrCode`, `Project`, `CodeBars`, `VatPrcnt`, `VatGroup`, `PriceAfVAT`, `Height1`, `Hght1Unit`, `Height2`, `Hght2Unit`, `Width1`, `Wdth1Unit`, `Width2`, `Wdth2Unit`, `Length1`, `Len1Unit`, `length2`, `Len2Unit`, `Volume`, `VolUnit`, `Weight1`, `Wght1Unit`, `Weight2`, `Wght2Unit`, `Factor1`, `Factor2`, `Factor3`, `Factor4`, `PackQty`, `UpdInvntry`, `BaseDocNum`, `BaseAtCard`, `SWW`, `VatSum`, `VatSumFrgn`, `VatSumSy`, `FinncPriod`, `ObjType`, `LogInstanc`, `BlockNum`, `ImportLog`, `DedVatSum`, `DedVatSumF`, `DedVatSumS`, `IsAqcuistn`, `DistribSum`, `DstrbSumFC`, `DstrbSumSC`, `GrssProfit`, `GrssProfSC`, `GrssProfFC`, `VisOrder`, `INMPrice`, `PoTrgNum`, `PoTrgEntry`, `DropShip`, `PoLineNum`, `Address`, `TaxCode`, `TaxType`, `OrigItem`, `BackOrdr`, `FreeTxt`, `PickStatus`, `PickOty`, `PickIdNo`, `TrnsCode`, `VatAppld`, `VatAppldFC`, `VatAppldSC`, `BaseQty`, `BaseOpnQty`, `VatDscntPr`, `WtLiable`, `DeferrTax`, `EquVatPer`, `EquVatSum`, `EquVatSumF`, `EquVatSumS`, `LineVat`, `LineVatlF`, `LineVatS`, `unitMsr`, `NumPerMsr`, `CEECFlag`, `ToStock`, `ToDiff`, `ExciseAmt`, `TaxPerUnit`, `TotInclTax`, `CountryOrg`, `StckDstSum`, `ReleasQtty`, `LineType`, `TranType`, `Text`, `OwnerCode`, `StockPrice`, `ConsumeFCT`, `LstByDsSum`, `StckINMPr`, `LstBINMPr`, `StckDstFc`, `StckDstSc`, `LstByDsFc`, `LstByDsSc`, `StockSum`, `StockSumFc`, `StockSumSc`, `StckSumApp`, `StckAppFc`, `StckAppSc`, `ShipToCode`, `ShipToDesc`, `StckAppD`, `StckAppDFC`, `StckAppDSC`, `BasePrice`, `GTotal`, `GTotalFC`, `GTotalSC`, `DistribExp`, `DescOW`, `DetailsOW`, `GrossBase`, `VatWoDpm`, `VatWoDpmFc`, `VatWoDpmSc`, `CFOPCode`, `CSTCode`, `Usage`, `TaxOnly`, `WtCalced`, `QtyToShip`, `DelivrdQty`, `OrderedQty`, `CogsOcrCod`, `CiOppLineN`, `CogsAcct`, `ChgAsmBoMW`, `ActDelDate`, `OcrCode2`, `OcrCode3`, `OcrCode4`, `OcrCode5`, `TaxDistSum`, `TaxDistSFC`, `TaxDistSSC`, `PostTax`, `Excisable`, `AssblValue`, `RG23APart1`, `RG23APart2`, `RG23CPart1`, `RG23CPart2`, `CogsOcrCo2`, `CogsOcrCo3`, `CogsOcrCo4`, `CogsOcrCo5`, `LnExcised`, `LocCode`, `StockValue`, `GPTtlBasPr`, `unitMsr2`, `NumPerMsr2`, `SpecPrice`, `CSTfIPI`, `CSTfPIS`, `CSTfCOFINS`, `ExLineNo`, `isSrvCall`, `PQTReqQty`, `PQTReqDate`, `PcDocType`, `PcQuantity`, `LinManClsd`, `VatGrpSrc`, `U_OB_RefNo`, `U_OB_Price`, `U_OB_Week01`, `U_OB_Week02`, `U_OB_Week03`, `U_OB_Week04`, `U_OB_Week05`, `U_OB_Reason`, `U_OB_Month_2`, `U_OB_Month_3`, `U_OB_Assembly_Line`, `U_OB_PartNo`, `U_OB_MatCost`, `U_OB_LabCost`, `U_OB_Box`, `U_OB_PrioLevel`, `U_OB_Shift`, `U_OB_Process`, `U_OB_AcctName`, `U_OB_PRNO`, `U_OB_Origin`, `U_OB_SP_Assy_Line`, `U_OB_IssueDoc`, `U_NEC_ExpType`, `U_Detail_ID`, `U_Dept`, `U_BudgetRef`) VALUES
(35721, 9, -1, NULL, NULL, -1, NULL, NULL, 'O', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, -1, NULL, 'N', NULL, NULL, NULL, NULL, NULL, 0, NULL, 'N', NULL, NULL, NULL, NULL, 'O', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Y', NULL, NULL, NULL, NULL, NULL, NULL, NULL, '18', 0, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'S', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'R', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'E', NULL, NULL, NULL, NULL, 'N', 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Y', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, 'N', NULL, NULL, -1, NULL, 'N', 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `PDN1`
--

CREATE TABLE IF NOT EXISTS `PDN1` (
  `DocEntry` int(11) NOT NULL,
  `LineNum` int(11) NOT NULL,
  `TargetType` int(11) DEFAULT '-1',
  `TrgetEntry` int(11) DEFAULT NULL,
  `BaseRef` varchar(16) DEFAULT NULL,
  `BaseType` int(11) DEFAULT '-1',
  `BaseEntry` int(11) DEFAULT NULL,
  `BaseLine` int(11) DEFAULT NULL,
  `LineStatus` char(1) DEFAULT 'O',
  `ItemCode` varchar(20) DEFAULT NULL,
  `Dscription` varchar(100) DEFAULT NULL,
  `Quantity` decimal(19,6) DEFAULT NULL,
  `ShipDate` datetime DEFAULT NULL,
  `OpenQty` decimal(19,6) DEFAULT NULL,
  `Price` decimal(19,6) DEFAULT NULL,
  `Currency` varchar(3) DEFAULT NULL,
  `Rate` decimal(19,6) DEFAULT NULL,
  `DiscPrcnt` decimal(19,6) DEFAULT NULL,
  `LineTotal` decimal(19,6) DEFAULT NULL,
  `TotalFrgn` decimal(19,6) DEFAULT NULL,
  `OpenSum` decimal(19,6) DEFAULT NULL,
  `OpenSumFC` decimal(19,6) DEFAULT NULL,
  `VendorNum` varchar(17) DEFAULT NULL,
  `SerialNum` varchar(17) DEFAULT NULL,
  `WhsCode` varchar(8) DEFAULT NULL,
  `SlpCode` smallint(6) DEFAULT '-1',
  `Commission` decimal(19,6) DEFAULT NULL,
  `TreeType` char(1) DEFAULT 'N',
  `AcctCode` varchar(15) DEFAULT NULL,
  `TaxStatus` char(1) DEFAULT NULL,
  `GrossBuyPr` decimal(19,6) DEFAULT NULL,
  `PriceBefDi` decimal(19,6) DEFAULT NULL,
  `DocDate` datetime DEFAULT NULL,
  `Flags` int(11) DEFAULT '0',
  `OpenCreQty` decimal(19,6) DEFAULT NULL,
  `UseBaseUn` char(1) DEFAULT 'N',
  `SubCatNum` varchar(20) DEFAULT NULL,
  `BaseCard` varchar(15) DEFAULT NULL,
  `TotalSumSy` decimal(19,6) DEFAULT NULL,
  `OpenSumSys` decimal(19,6) DEFAULT NULL,
  `InvntSttus` char(1) DEFAULT 'O',
  `OcrCode` varchar(8) DEFAULT NULL,
  `Project` varchar(20) DEFAULT NULL,
  `CodeBars` varchar(16) DEFAULT NULL,
  `VatPrcnt` decimal(19,6) DEFAULT NULL,
  `VatGroup` varchar(8) DEFAULT NULL,
  `PriceAfVAT` decimal(19,6) DEFAULT NULL,
  `Height1` decimal(19,6) DEFAULT NULL,
  `Hght1Unit` smallint(6) DEFAULT NULL,
  `Height2` decimal(19,6) DEFAULT NULL,
  `Hght2Unit` smallint(6) DEFAULT NULL,
  `Width1` decimal(19,6) DEFAULT NULL,
  `Wdth1Unit` smallint(6) DEFAULT NULL,
  `Width2` decimal(19,6) DEFAULT NULL,
  `Wdth2Unit` smallint(6) DEFAULT NULL,
  `Length1` decimal(19,6) DEFAULT NULL,
  `Len1Unit` smallint(6) DEFAULT NULL,
  `length2` decimal(19,6) DEFAULT NULL,
  `Len2Unit` smallint(6) DEFAULT NULL,
  `Volume` decimal(19,6) DEFAULT NULL,
  `VolUnit` smallint(6) DEFAULT NULL,
  `Weight1` decimal(19,6) DEFAULT NULL,
  `Wght1Unit` smallint(6) DEFAULT NULL,
  `Weight2` decimal(19,6) DEFAULT NULL,
  `Wght2Unit` smallint(6) DEFAULT NULL,
  `Factor1` decimal(19,6) DEFAULT NULL,
  `Factor2` decimal(19,6) DEFAULT NULL,
  `Factor3` decimal(19,6) DEFAULT NULL,
  `Factor4` decimal(19,6) DEFAULT NULL,
  `PackQty` decimal(19,6) DEFAULT NULL,
  `UpdInvntry` char(1) DEFAULT 'Y',
  `BaseDocNum` int(11) DEFAULT NULL,
  `BaseAtCard` varchar(100) DEFAULT NULL,
  `SWW` varchar(16) DEFAULT NULL,
  `VatSum` decimal(19,6) DEFAULT NULL,
  `VatSumFrgn` decimal(19,6) DEFAULT NULL,
  `VatSumSy` decimal(19,6) DEFAULT NULL,
  `FinncPriod` int(11) DEFAULT NULL,
  `ObjType` varchar(20) DEFAULT '20',
  `LogInstanc` smallint(6) DEFAULT '0',
  `BlockNum` varchar(100) DEFAULT NULL,
  `ImportLog` varchar(20) DEFAULT NULL,
  `DedVatSum` decimal(19,6) DEFAULT NULL,
  `DedVatSumF` decimal(19,6) DEFAULT NULL,
  `DedVatSumS` decimal(19,6) DEFAULT NULL,
  `IsAqcuistn` char(1) DEFAULT 'N',
  `DistribSum` decimal(19,6) DEFAULT NULL,
  `DstrbSumFC` decimal(19,6) DEFAULT NULL,
  `DstrbSumSC` decimal(19,6) DEFAULT NULL,
  `GrssProfit` decimal(19,6) DEFAULT NULL,
  `GrssProfSC` decimal(19,6) DEFAULT NULL,
  `GrssProfFC` decimal(19,6) DEFAULT NULL,
  `VisOrder` int(11) DEFAULT NULL,
  `INMPrice` decimal(19,6) DEFAULT NULL,
  `PoTrgNum` int(11) DEFAULT NULL,
  `PoTrgEntry` varchar(11) DEFAULT NULL,
  `DropShip` char(1) DEFAULT 'N',
  `PoLineNum` int(11) DEFAULT NULL,
  `Address` varchar(254) DEFAULT NULL,
  `TaxCode` varchar(8) DEFAULT NULL,
  `TaxType` char(1) DEFAULT NULL,
  `OrigItem` varchar(20) DEFAULT NULL,
  `BackOrdr` char(1) DEFAULT NULL,
  `FreeTxt` varchar(100) DEFAULT NULL,
  `PickStatus` char(1) DEFAULT 'N',
  `PickOty` decimal(19,6) DEFAULT NULL,
  `PickIdNo` int(11) DEFAULT NULL,
  `TrnsCode` smallint(6) DEFAULT '-1',
  `VatAppld` decimal(19,6) DEFAULT NULL,
  `VatAppldFC` decimal(19,6) DEFAULT NULL,
  `VatAppldSC` decimal(19,6) DEFAULT NULL,
  `BaseQty` decimal(19,6) DEFAULT NULL,
  `BaseOpnQty` decimal(19,6) DEFAULT NULL,
  `VatDscntPr` decimal(19,6) DEFAULT NULL,
  `WtLiable` char(1) DEFAULT NULL,
  `DeferrTax` char(1) DEFAULT 'N',
  `EquVatPer` decimal(19,6) DEFAULT NULL,
  `EquVatSum` decimal(19,6) DEFAULT NULL,
  `EquVatSumF` decimal(19,6) DEFAULT NULL,
  `EquVatSumS` decimal(19,6) DEFAULT NULL,
  `LineVat` decimal(19,6) DEFAULT NULL,
  `LineVatlF` decimal(19,6) DEFAULT NULL,
  `LineVatS` decimal(19,6) DEFAULT NULL,
  `unitMsr` varchar(20) DEFAULT NULL,
  `NumPerMsr` decimal(19,6) DEFAULT NULL,
  `CEECFlag` char(1) DEFAULT 'S',
  `ToStock` decimal(19,6) DEFAULT NULL,
  `ToDiff` decimal(19,6) DEFAULT NULL,
  `ExciseAmt` decimal(19,6) DEFAULT NULL,
  `TaxPerUnit` decimal(19,6) DEFAULT NULL,
  `TotInclTax` decimal(19,6) DEFAULT NULL,
  `CountryOrg` varchar(3) DEFAULT NULL,
  `StckDstSum` decimal(19,6) DEFAULT NULL,
  `ReleasQtty` decimal(19,6) DEFAULT NULL,
  `LineType` char(1) DEFAULT 'R',
  `TranType` char(1) DEFAULT NULL,
  `Text` longtext,
  `OwnerCode` int(11) DEFAULT NULL,
  `StockPrice` decimal(19,6) DEFAULT NULL,
  `ConsumeFCT` char(1) DEFAULT NULL,
  `LstByDsSum` decimal(19,6) DEFAULT NULL,
  `StckINMPr` decimal(19,6) DEFAULT NULL,
  `LstBINMPr` decimal(19,6) DEFAULT NULL,
  `StckDstFc` decimal(19,6) DEFAULT NULL,
  `StckDstSc` decimal(19,6) DEFAULT NULL,
  `LstByDsFc` decimal(19,6) DEFAULT NULL,
  `LstByDsSc` decimal(19,6) DEFAULT NULL,
  `StockSum` decimal(19,6) DEFAULT NULL,
  `StockSumFc` decimal(19,6) DEFAULT NULL,
  `StockSumSc` decimal(19,6) DEFAULT NULL,
  `StckSumApp` decimal(19,6) DEFAULT NULL,
  `StckAppFc` decimal(19,6) DEFAULT NULL,
  `StckAppSc` decimal(19,6) DEFAULT NULL,
  `ShipToCode` varchar(50) DEFAULT NULL,
  `ShipToDesc` varchar(254) DEFAULT NULL,
  `StckAppD` decimal(19,6) DEFAULT NULL,
  `StckAppDFC` decimal(19,6) DEFAULT NULL,
  `StckAppDSC` decimal(19,6) DEFAULT NULL,
  `BasePrice` char(1) DEFAULT 'E',
  `GTotal` decimal(19,6) DEFAULT NULL,
  `GTotalFC` decimal(19,6) DEFAULT NULL,
  `GTotalSC` decimal(19,6) DEFAULT NULL,
  `DistribExp` char(1) DEFAULT NULL,
  `DescOW` char(1) DEFAULT 'N',
  `DetailsOW` char(1) DEFAULT 'N',
  `GrossBase` smallint(6) DEFAULT NULL,
  `VatWoDpm` decimal(19,6) DEFAULT NULL,
  `VatWoDpmFc` decimal(19,6) DEFAULT NULL,
  `VatWoDpmSc` decimal(19,6) DEFAULT NULL,
  `CFOPCode` varchar(6) DEFAULT NULL,
  `CSTCode` varchar(6) DEFAULT NULL,
  `Usage` int(11) DEFAULT NULL,
  `TaxOnly` char(1) DEFAULT NULL,
  `WtCalced` char(1) DEFAULT 'N',
  `QtyToShip` decimal(19,6) DEFAULT NULL,
  `DelivrdQty` decimal(19,6) DEFAULT NULL,
  `OrderedQty` decimal(19,6) DEFAULT NULL,
  `CogsOcrCod` varchar(8) DEFAULT NULL,
  `CiOppLineN` int(11) DEFAULT '-1',
  `CogsAcct` varchar(15) DEFAULT NULL,
  `ChgAsmBoMW` char(1) DEFAULT NULL,
  `ActDelDate` datetime DEFAULT NULL,
  `OcrCode2` varchar(8) DEFAULT NULL,
  `OcrCode3` varchar(8) DEFAULT NULL,
  `OcrCode4` varchar(8) DEFAULT NULL,
  `OcrCode5` varchar(8) DEFAULT NULL,
  `TaxDistSum` decimal(19,6) DEFAULT NULL,
  `TaxDistSFC` decimal(19,6) DEFAULT NULL,
  `TaxDistSSC` decimal(19,6) DEFAULT NULL,
  `PostTax` char(1) DEFAULT 'Y',
  `Excisable` char(1) DEFAULT NULL,
  `AssblValue` decimal(19,6) DEFAULT NULL,
  `RG23APart1` int(11) DEFAULT NULL,
  `RG23APart2` int(11) DEFAULT NULL,
  `RG23CPart1` int(11) DEFAULT NULL,
  `RG23CPart2` int(11) DEFAULT NULL,
  `CogsOcrCo2` varchar(8) DEFAULT NULL,
  `CogsOcrCo3` varchar(8) DEFAULT NULL,
  `CogsOcrCo4` varchar(8) DEFAULT NULL,
  `CogsOcrCo5` varchar(8) DEFAULT NULL,
  `LnExcised` char(1) DEFAULT NULL,
  `LocCode` int(11) DEFAULT NULL,
  `StockValue` decimal(19,6) DEFAULT NULL,
  `GPTtlBasPr` decimal(19,6) DEFAULT NULL,
  `unitMsr2` varchar(20) DEFAULT NULL,
  `NumPerMsr2` decimal(19,6) DEFAULT NULL,
  `SpecPrice` char(1) DEFAULT 'N',
  `CSTfIPI` varchar(2) DEFAULT NULL,
  `CSTfPIS` varchar(2) DEFAULT NULL,
  `CSTfCOFINS` varchar(2) DEFAULT NULL,
  `ExLineNo` varchar(10) DEFAULT NULL,
  `isSrvCall` char(1) DEFAULT 'N',
  `PQTReqQty` decimal(19,6) DEFAULT NULL,
  `PQTReqDate` datetime DEFAULT NULL,
  `PcDocType` int(11) DEFAULT '-1',
  `PcQuantity` decimal(19,6) DEFAULT NULL,
  `LinManClsd` char(1) DEFAULT 'N',
  `VatGrpSrc` char(1) DEFAULT 'N',
  `U_OB_RefNo` longtext,
  `U_OB_Price` decimal(19,6) DEFAULT NULL,
  `U_OB_Week01` decimal(19,6) DEFAULT NULL,
  `U_OB_Week02` decimal(19,6) DEFAULT NULL,
  `U_OB_Week03` decimal(19,6) DEFAULT NULL,
  `U_OB_Week04` decimal(19,6) DEFAULT NULL,
  `U_OB_Week05` decimal(19,6) DEFAULT NULL,
  `U_OB_Reason` longtext,
  `U_OB_Month_2` decimal(19,6) DEFAULT NULL,
  `U_OB_Month_3` decimal(19,6) DEFAULT NULL,
  `U_OB_Assembly_Line` longtext,
  `U_OB_PartNo` longtext,
  `U_OB_MatCost` decimal(19,6) DEFAULT NULL,
  `U_OB_LabCost` decimal(19,6) DEFAULT NULL,
  `U_OB_Box` decimal(19,6) DEFAULT NULL,
  `U_OB_PrioLevel` longtext,
  `U_OB_Shift` longtext,
  `U_OB_Process` longtext,
  `U_OB_AcctName` longtext,
  `U_OB_PRNO` longtext,
  `U_OB_Origin` longtext,
  `U_OB_SP_Assy_Line` longtext,
  `U_OB_IssueDoc` int(11) DEFAULT NULL,
  `U_NEC_ExpType` longtext,
  `U_Detail_ID` longtext,
  `U_Dept` longtext,
  `U_BudgetRef` longtext,
  `U_fldYen` decimal(65,2) NOT NULL,
  PRIMARY KEY (`DocEntry`,`LineNum`),
  KEY `PDN1_STATUS` (`LineStatus`),
  KEY `PDN1_CURRENCY` (`Currency`),
  KEY `PDN1_ACCOUNT` (`AcctCode`),
  KEY `PDN1_BASE_ENTRY` (`BaseEntry`,`BaseType`,`BaseLine`),
  KEY `PDN1_VIS_ORDER` (`DocEntry`,`VisOrder`),
  KEY `PDN1_OWNER_CODE` (`OwnerCode`),
  KEY `PDN1_ITM_WHS_OQ` (`ItemCode`,`WhsCode`,`OpenQty`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `PDN1`
--

INSERT INTO `PDN1` (`DocEntry`, `LineNum`, `TargetType`, `TrgetEntry`, `BaseRef`, `BaseType`, `BaseEntry`, `BaseLine`, `LineStatus`, `ItemCode`, `Dscription`, `Quantity`, `ShipDate`, `OpenQty`, `Price`, `Currency`, `Rate`, `DiscPrcnt`, `LineTotal`, `TotalFrgn`, `OpenSum`, `OpenSumFC`, `VendorNum`, `SerialNum`, `WhsCode`, `SlpCode`, `Commission`, `TreeType`, `AcctCode`, `TaxStatus`, `GrossBuyPr`, `PriceBefDi`, `DocDate`, `Flags`, `OpenCreQty`, `UseBaseUn`, `SubCatNum`, `BaseCard`, `TotalSumSy`, `OpenSumSys`, `InvntSttus`, `OcrCode`, `Project`, `CodeBars`, `VatPrcnt`, `VatGroup`, `PriceAfVAT`, `Height1`, `Hght1Unit`, `Height2`, `Hght2Unit`, `Width1`, `Wdth1Unit`, `Width2`, `Wdth2Unit`, `Length1`, `Len1Unit`, `length2`, `Len2Unit`, `Volume`, `VolUnit`, `Weight1`, `Wght1Unit`, `Weight2`, `Wght2Unit`, `Factor1`, `Factor2`, `Factor3`, `Factor4`, `PackQty`, `UpdInvntry`, `BaseDocNum`, `BaseAtCard`, `SWW`, `VatSum`, `VatSumFrgn`, `VatSumSy`, `FinncPriod`, `ObjType`, `LogInstanc`, `BlockNum`, `ImportLog`, `DedVatSum`, `DedVatSumF`, `DedVatSumS`, `IsAqcuistn`, `DistribSum`, `DstrbSumFC`, `DstrbSumSC`, `GrssProfit`, `GrssProfSC`, `GrssProfFC`, `VisOrder`, `INMPrice`, `PoTrgNum`, `PoTrgEntry`, `DropShip`, `PoLineNum`, `Address`, `TaxCode`, `TaxType`, `OrigItem`, `BackOrdr`, `FreeTxt`, `PickStatus`, `PickOty`, `PickIdNo`, `TrnsCode`, `VatAppld`, `VatAppldFC`, `VatAppldSC`, `BaseQty`, `BaseOpnQty`, `VatDscntPr`, `WtLiable`, `DeferrTax`, `EquVatPer`, `EquVatSum`, `EquVatSumF`, `EquVatSumS`, `LineVat`, `LineVatlF`, `LineVatS`, `unitMsr`, `NumPerMsr`, `CEECFlag`, `ToStock`, `ToDiff`, `ExciseAmt`, `TaxPerUnit`, `TotInclTax`, `CountryOrg`, `StckDstSum`, `ReleasQtty`, `LineType`, `TranType`, `Text`, `OwnerCode`, `StockPrice`, `ConsumeFCT`, `LstByDsSum`, `StckINMPr`, `LstBINMPr`, `StckDstFc`, `StckDstSc`, `LstByDsFc`, `LstByDsSc`, `StockSum`, `StockSumFc`, `StockSumSc`, `StckSumApp`, `StckAppFc`, `StckAppSc`, `ShipToCode`, `ShipToDesc`, `StckAppD`, `StckAppDFC`, `StckAppDSC`, `BasePrice`, `GTotal`, `GTotalFC`, `GTotalSC`, `DistribExp`, `DescOW`, `DetailsOW`, `GrossBase`, `VatWoDpm`, `VatWoDpmFc`, `VatWoDpmSc`, `CFOPCode`, `CSTCode`, `Usage`, `TaxOnly`, `WtCalced`, `QtyToShip`, `DelivrdQty`, `OrderedQty`, `CogsOcrCod`, `CiOppLineN`, `CogsAcct`, `ChgAsmBoMW`, `ActDelDate`, `OcrCode2`, `OcrCode3`, `OcrCode4`, `OcrCode5`, `TaxDistSum`, `TaxDistSFC`, `TaxDistSSC`, `PostTax`, `Excisable`, `AssblValue`, `RG23APart1`, `RG23APart2`, `RG23CPart1`, `RG23CPart2`, `CogsOcrCo2`, `CogsOcrCo3`, `CogsOcrCo4`, `CogsOcrCo5`, `LnExcised`, `LocCode`, `StockValue`, `GPTtlBasPr`, `unitMsr2`, `NumPerMsr2`, `SpecPrice`, `CSTfIPI`, `CSTfPIS`, `CSTfCOFINS`, `ExLineNo`, `isSrvCall`, `PQTReqQty`, `PQTReqDate`, `PcDocType`, `PcQuantity`, `LinManClsd`, `VatGrpSrc`, `U_OB_RefNo`, `U_OB_Price`, `U_OB_Week01`, `U_OB_Week02`, `U_OB_Week03`, `U_OB_Week04`, `U_OB_Week05`, `U_OB_Reason`, `U_OB_Month_2`, `U_OB_Month_3`, `U_OB_Assembly_Line`, `U_OB_PartNo`, `U_OB_MatCost`, `U_OB_LabCost`, `U_OB_Box`, `U_OB_PrioLevel`, `U_OB_Shift`, `U_OB_Process`, `U_OB_AcctName`, `U_OB_PRNO`, `U_OB_Origin`, `U_OB_SP_Assy_Line`, `U_OB_IssueDoc`, `U_NEC_ExpType`, `U_Detail_ID`, `U_Dept`, `U_BudgetRef`, `U_fldYen`) VALUES
(15411, 10, -1, NULL, '100007542', -1, NULL, NULL, 'O', NULL, NULL, NULL, NULL, NULL, 0.000000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, -1, NULL, 'N', NULL, NULL, NULL, NULL, NULL, 0, NULL, 'N', NULL, NULL, NULL, NULL, 'O', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Y', NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20', 0, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'S', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'R', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'E', NULL, NULL, NULL, NULL, 'N', 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Y', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, 'N', NULL, NULL, -1, NULL, 'N', 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0.00);

--
-- Triggers `PDN1`
--
DROP TRIGGER IF EXISTS `triggerJPYinPDN1`;
DELIMITER //
CREATE TRIGGER `triggerJPYinPDN1` BEFORE INSERT ON `PDN1`
 FOR EACH ROW Begin
SET NEW.U_fldYen =
CASE 
 WHEN new.Currency = 'JPY' then (new.Price * new.Quantity) - ((new.Price * new.Quantity) * (select fldDiscount  / 100 from tblPO where OB_Line = (select T2.U_HeaderID FROM POR1 T1 LEFT OUTER JOIN OPOR T2 ON T1.DocEntry = T2.DocEntry where T1.ItemCode = new.ItemCode AND T1.LineNum = new.BaseLine AND T2.DocEntry = NEW.BaseEntry )))
 WHEN new.Currency = 'USD' then ((new.Price * new.Quantity) * (select fldAmount from tblConversion where Year(fldDate) = year(new.DocDate) and fldcurrency = 'USD-JPY'))-(((new.Price * new.Quantity) * (select fldAmount from tblConversion where Year(fldDate) = year(new.DocDate) and fldcurrency = 'USD-JPY')) * (select fldDiscount  / 100 from tblPO where OB_Line = (select T2.U_HeaderID FROM POR1 T1 LEFT OUTER JOIN OPOR T2 ON T1.DocEntry = T2.DocEntry where T1.ItemCode = new.ItemCode AND T1.LineNum = new.BaseLine AND T2.DocEntry = NEW.BaseEntry)))
 WHEN new.Currency = 'PHP' then ((new.Price * new.Quantity) / (select fldAmount from tblConversion where Year(fldDate) = year(new.DocDate) and fldcurrency = 'JPY-PHP'))-(((new.Price * new.Quantity) / (select fldAmount from tblConversion where Year(fldDate) = year(new.DocDate) and fldcurrency = 'JPY-PHP')) * (select fldDiscount  / 100 from tblPO where OB_Line = (select T2.U_HeaderID FROM POR1 T1 LEFT OUTER JOIN OPOR T2 ON T1.DocEntry = T2.DocEntry where T1.ItemCode = new.ItemCode AND T1.LineNum = new.BaseLine AND T2.DocEntry = NEW.BaseEntry)))
END;
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `POR1`
--

CREATE TABLE IF NOT EXISTS `POR1` (
  `DocEntry` int(11) NOT NULL,
  `LineNum` int(11) NOT NULL,
  `TargetType` int(11) DEFAULT '-1',
  `TrgetEntry` int(11) DEFAULT NULL,
  `BaseRef` varchar(16) DEFAULT NULL,
  `BaseType` int(11) DEFAULT '-1',
  `BaseEntry` int(11) DEFAULT NULL,
  `BaseLine` int(11) DEFAULT NULL,
  `LineStatus` char(1) DEFAULT 'O',
  `ItemCode` varchar(20) DEFAULT NULL,
  `Dscription` varchar(100) DEFAULT NULL,
  `Quantity` decimal(19,6) DEFAULT NULL,
  `ShipDate` datetime DEFAULT NULL,
  `OpenQty` decimal(19,6) DEFAULT NULL,
  `Price` decimal(19,6) DEFAULT NULL,
  `Currency` varchar(3) DEFAULT NULL,
  `Rate` decimal(19,6) DEFAULT NULL,
  `DiscPrcnt` decimal(19,6) DEFAULT NULL,
  `LineTotal` decimal(19,6) DEFAULT NULL,
  `TotalFrgn` decimal(19,6) DEFAULT NULL,
  `OpenSum` decimal(19,6) DEFAULT NULL,
  `OpenSumFC` decimal(19,6) DEFAULT NULL,
  `VendorNum` varchar(17) DEFAULT NULL,
  `SerialNum` varchar(17) DEFAULT NULL,
  `WhsCode` varchar(8) DEFAULT NULL,
  `SlpCode` smallint(6) DEFAULT '-1',
  `Commission` decimal(19,6) DEFAULT NULL,
  `TreeType` char(1) DEFAULT 'N',
  `AcctCode` varchar(15) DEFAULT NULL,
  `TaxStatus` char(1) DEFAULT NULL,
  `GrossBuyPr` decimal(19,6) DEFAULT NULL,
  `PriceBefDi` decimal(19,6) DEFAULT NULL,
  `DocDate` datetime DEFAULT NULL,
  `Flags` int(11) DEFAULT '0',
  `OpenCreQty` decimal(19,6) DEFAULT NULL,
  `UseBaseUn` char(1) DEFAULT 'N',
  `SubCatNum` varchar(20) DEFAULT NULL,
  `BaseCard` varchar(15) DEFAULT NULL,
  `TotalSumSy` decimal(19,6) DEFAULT NULL,
  `OpenSumSys` decimal(19,6) DEFAULT NULL,
  `InvntSttus` char(1) DEFAULT 'O',
  `OcrCode` varchar(8) DEFAULT NULL,
  `Project` varchar(20) DEFAULT NULL,
  `CodeBars` varchar(16) DEFAULT NULL,
  `VatPrcnt` decimal(19,6) DEFAULT NULL,
  `VatGroup` varchar(8) DEFAULT NULL,
  `PriceAfVAT` decimal(19,6) DEFAULT NULL,
  `Height1` decimal(19,6) DEFAULT NULL,
  `Hght1Unit` smallint(6) DEFAULT NULL,
  `Height2` decimal(19,6) DEFAULT NULL,
  `Hght2Unit` smallint(6) DEFAULT NULL,
  `Width1` decimal(19,6) DEFAULT NULL,
  `Wdth1Unit` smallint(6) DEFAULT NULL,
  `Width2` decimal(19,6) DEFAULT NULL,
  `Wdth2Unit` smallint(6) DEFAULT NULL,
  `Length1` decimal(19,6) DEFAULT NULL,
  `Len1Unit` smallint(6) DEFAULT NULL,
  `length2` decimal(19,6) DEFAULT NULL,
  `Len2Unit` smallint(6) DEFAULT NULL,
  `Volume` decimal(19,6) DEFAULT NULL,
  `VolUnit` smallint(6) DEFAULT NULL,
  `Weight1` decimal(19,6) DEFAULT NULL,
  `Wght1Unit` smallint(6) DEFAULT NULL,
  `Weight2` decimal(19,6) DEFAULT NULL,
  `Wght2Unit` smallint(6) DEFAULT NULL,
  `Factor1` decimal(19,6) DEFAULT NULL,
  `Factor2` decimal(19,6) DEFAULT NULL,
  `Factor3` decimal(19,6) DEFAULT NULL,
  `Factor4` decimal(19,6) DEFAULT NULL,
  `PackQty` decimal(19,6) DEFAULT NULL,
  `UpdInvntry` char(1) DEFAULT 'Y',
  `BaseDocNum` int(11) DEFAULT NULL,
  `BaseAtCard` varchar(100) DEFAULT NULL,
  `SWW` varchar(16) DEFAULT NULL,
  `VatSum` decimal(19,6) DEFAULT NULL,
  `VatSumFrgn` decimal(19,6) DEFAULT NULL,
  `VatSumSy` decimal(19,6) DEFAULT NULL,
  `FinncPriod` int(11) DEFAULT NULL,
  `ObjType` varchar(20) DEFAULT '22',
  `LogInstanc` smallint(6) DEFAULT '0',
  `BlockNum` varchar(100) DEFAULT NULL,
  `ImportLog` varchar(20) DEFAULT NULL,
  `DedVatSum` decimal(19,6) DEFAULT NULL,
  `DedVatSumF` decimal(19,6) DEFAULT NULL,
  `DedVatSumS` decimal(19,6) DEFAULT NULL,
  `IsAqcuistn` char(1) DEFAULT 'N',
  `DistribSum` decimal(19,6) DEFAULT NULL,
  `DstrbSumFC` decimal(19,6) DEFAULT NULL,
  `DstrbSumSC` decimal(19,6) DEFAULT NULL,
  `GrssProfit` decimal(19,6) DEFAULT NULL,
  `GrssProfSC` decimal(19,6) DEFAULT NULL,
  `GrssProfFC` decimal(19,6) DEFAULT NULL,
  `VisOrder` int(11) DEFAULT NULL,
  `INMPrice` decimal(19,6) DEFAULT NULL,
  `PoTrgNum` int(11) DEFAULT NULL,
  `PoTrgEntry` varchar(11) DEFAULT NULL,
  `DropShip` char(1) DEFAULT 'N',
  `PoLineNum` int(11) DEFAULT NULL,
  `Address` varchar(254) DEFAULT NULL,
  `TaxCode` varchar(8) DEFAULT NULL,
  `TaxType` char(1) DEFAULT NULL,
  `OrigItem` varchar(20) DEFAULT NULL,
  `BackOrdr` char(1) DEFAULT NULL,
  `FreeTxt` varchar(100) DEFAULT NULL,
  `PickStatus` char(1) DEFAULT 'N',
  `PickOty` decimal(19,6) DEFAULT NULL,
  `PickIdNo` int(11) DEFAULT NULL,
  `TrnsCode` smallint(6) DEFAULT '-1',
  `VatAppld` decimal(19,6) DEFAULT NULL,
  `VatAppldFC` decimal(19,6) DEFAULT NULL,
  `VatAppldSC` decimal(19,6) DEFAULT NULL,
  `BaseQty` decimal(19,6) DEFAULT NULL,
  `BaseOpnQty` decimal(19,6) DEFAULT NULL,
  `VatDscntPr` decimal(19,6) DEFAULT NULL,
  `WtLiable` char(1) DEFAULT NULL,
  `DeferrTax` char(1) DEFAULT 'N',
  `EquVatPer` decimal(19,6) DEFAULT NULL,
  `EquVatSum` decimal(19,6) DEFAULT NULL,
  `EquVatSumF` decimal(19,6) DEFAULT NULL,
  `EquVatSumS` decimal(19,6) DEFAULT NULL,
  `LineVat` decimal(19,6) DEFAULT NULL,
  `LineVatlF` decimal(19,6) DEFAULT NULL,
  `LineVatS` decimal(19,6) DEFAULT NULL,
  `unitMsr` varchar(20) DEFAULT NULL,
  `NumPerMsr` decimal(19,6) DEFAULT NULL,
  `CEECFlag` char(1) DEFAULT 'S',
  `ToStock` decimal(19,6) DEFAULT NULL,
  `ToDiff` decimal(19,6) DEFAULT NULL,
  `ExciseAmt` decimal(19,6) DEFAULT NULL,
  `TaxPerUnit` decimal(19,6) DEFAULT NULL,
  `TotInclTax` decimal(19,6) DEFAULT NULL,
  `CountryOrg` varchar(3) DEFAULT NULL,
  `StckDstSum` decimal(19,6) DEFAULT NULL,
  `ReleasQtty` decimal(19,6) DEFAULT NULL,
  `LineType` char(1) DEFAULT 'R',
  `TranType` char(1) DEFAULT NULL,
  `Text` longtext,
  `OwnerCode` int(11) DEFAULT NULL,
  `StockPrice` decimal(19,6) DEFAULT NULL,
  `ConsumeFCT` char(1) DEFAULT NULL,
  `LstByDsSum` decimal(19,6) DEFAULT NULL,
  `StckINMPr` decimal(19,6) DEFAULT NULL,
  `LstBINMPr` decimal(19,6) DEFAULT NULL,
  `StckDstFc` decimal(19,6) DEFAULT NULL,
  `StckDstSc` decimal(19,6) DEFAULT NULL,
  `LstByDsFc` decimal(19,6) DEFAULT NULL,
  `LstByDsSc` decimal(19,6) DEFAULT NULL,
  `StockSum` decimal(19,6) DEFAULT NULL,
  `StockSumFc` decimal(19,6) DEFAULT NULL,
  `StockSumSc` decimal(19,6) DEFAULT NULL,
  `StckSumApp` decimal(19,6) DEFAULT NULL,
  `StckAppFc` decimal(19,6) DEFAULT NULL,
  `StckAppSc` decimal(19,6) DEFAULT NULL,
  `ShipToCode` varchar(50) DEFAULT NULL,
  `ShipToDesc` varchar(254) DEFAULT NULL,
  `StckAppD` decimal(19,6) DEFAULT NULL,
  `StckAppDFC` decimal(19,6) DEFAULT NULL,
  `StckAppDSC` decimal(19,6) DEFAULT NULL,
  `BasePrice` char(1) DEFAULT 'E',
  `GTotal` decimal(19,6) DEFAULT NULL,
  `GTotalFC` decimal(19,6) DEFAULT NULL,
  `GTotalSC` decimal(19,6) DEFAULT NULL,
  `DistribExp` char(1) DEFAULT NULL,
  `DescOW` char(1) DEFAULT 'N',
  `DetailsOW` char(1) DEFAULT 'N',
  `GrossBase` smallint(6) DEFAULT NULL,
  `VatWoDpm` decimal(19,6) DEFAULT NULL,
  `VatWoDpmFc` decimal(19,6) DEFAULT NULL,
  `VatWoDpmSc` decimal(19,6) DEFAULT NULL,
  `CFOPCode` varchar(6) DEFAULT NULL,
  `CSTCode` varchar(6) DEFAULT NULL,
  `Usage` int(11) DEFAULT NULL,
  `TaxOnly` char(1) DEFAULT NULL,
  `WtCalced` char(1) DEFAULT 'N',
  `QtyToShip` decimal(19,6) DEFAULT NULL,
  `DelivrdQty` decimal(19,6) DEFAULT NULL,
  `OrderedQty` decimal(19,6) DEFAULT NULL,
  `CogsOcrCod` varchar(8) DEFAULT NULL,
  `CiOppLineN` int(11) DEFAULT '-1',
  `CogsAcct` varchar(15) DEFAULT NULL,
  `ChgAsmBoMW` char(1) DEFAULT NULL,
  `ActDelDate` datetime DEFAULT NULL,
  `OcrCode2` varchar(8) DEFAULT NULL,
  `OcrCode3` varchar(8) DEFAULT NULL,
  `OcrCode4` varchar(8) DEFAULT NULL,
  `OcrCode5` varchar(8) DEFAULT NULL,
  `TaxDistSum` decimal(19,6) DEFAULT NULL,
  `TaxDistSFC` decimal(19,6) DEFAULT NULL,
  `TaxDistSSC` decimal(19,6) DEFAULT NULL,
  `PostTax` char(1) DEFAULT 'Y',
  `Excisable` char(1) DEFAULT NULL,
  `AssblValue` decimal(19,6) DEFAULT NULL,
  `RG23APart1` int(11) DEFAULT NULL,
  `RG23APart2` int(11) DEFAULT NULL,
  `RG23CPart1` int(11) DEFAULT NULL,
  `RG23CPart2` int(11) DEFAULT NULL,
  `CogsOcrCo2` varchar(8) DEFAULT NULL,
  `CogsOcrCo3` varchar(8) DEFAULT NULL,
  `CogsOcrCo4` varchar(8) DEFAULT NULL,
  `CogsOcrCo5` varchar(8) DEFAULT NULL,
  `LnExcised` char(1) DEFAULT NULL,
  `LocCode` int(11) DEFAULT NULL,
  `StockValue` decimal(19,6) DEFAULT NULL,
  `GPTtlBasPr` decimal(19,6) DEFAULT NULL,
  `unitMsr2` varchar(20) DEFAULT NULL,
  `NumPerMsr2` decimal(19,6) DEFAULT NULL,
  `SpecPrice` char(1) DEFAULT 'N',
  `CSTfIPI` varchar(2) DEFAULT NULL,
  `CSTfPIS` varchar(2) DEFAULT NULL,
  `CSTfCOFINS` varchar(2) DEFAULT NULL,
  `ExLineNo` varchar(10) DEFAULT NULL,
  `isSrvCall` char(1) DEFAULT 'N',
  `PQTReqQty` decimal(19,6) DEFAULT NULL,
  `PQTReqDate` datetime DEFAULT NULL,
  `PcDocType` int(11) DEFAULT '-1',
  `PcQuantity` decimal(19,6) DEFAULT NULL,
  `LinManClsd` char(1) DEFAULT 'N',
  `VatGrpSrc` char(1) DEFAULT 'N',
  `U_OB_RefNo` longtext,
  `U_OB_Price` decimal(19,6) DEFAULT NULL,
  `U_OB_Week01` decimal(19,6) DEFAULT NULL,
  `U_OB_Week02` decimal(19,6) DEFAULT NULL,
  `U_OB_Week03` decimal(19,6) DEFAULT NULL,
  `U_OB_Week04` decimal(19,6) DEFAULT NULL,
  `U_OB_Week05` decimal(19,6) DEFAULT NULL,
  `U_OB_Reason` longtext,
  `U_OB_Month_2` decimal(19,6) DEFAULT NULL,
  `U_OB_Month_3` decimal(19,6) DEFAULT NULL,
  `U_OB_Assembly_Line` longtext,
  `U_OB_PartNo` longtext,
  `U_OB_MatCost` decimal(19,6) DEFAULT NULL,
  `U_OB_LabCost` decimal(19,6) DEFAULT NULL,
  `U_OB_Box` decimal(19,6) DEFAULT NULL,
  `U_OB_PrioLevel` longtext,
  `U_OB_Shift` longtext,
  `U_OB_Process` longtext,
  `U_OB_AcctName` longtext,
  `U_OB_PRNO` longtext,
  `U_OB_Origin` longtext,
  `U_OB_SP_Assy_Line` longtext,
  `U_OB_IssueDoc` int(11) DEFAULT NULL,
  `U_NEC_ExpType` longtext,
  `U_Detail_ID` longtext,
  `U_Dept` longtext,
  `U_BudgetRef` longtext,
  PRIMARY KEY (`DocEntry`,`LineNum`),
  KEY `POR1_STATUS` (`LineStatus`),
  KEY `POR1_CURRENCY` (`Currency`),
  KEY `POR1_ACCOUNT` (`AcctCode`),
  KEY `POR1_BASE_ENTRY` (`BaseEntry`,`BaseType`,`BaseLine`),
  KEY `POR1_VIS_ORDER` (`DocEntry`,`VisOrder`),
  KEY `POR1_OWNER_CODE` (`OwnerCode`),
  KEY `POR1_ITM_WHS_OQ` (`ItemCode`,`WhsCode`,`OpenQty`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `POR1`
--

INSERT INTO `POR1` (`DocEntry`, `LineNum`, `TargetType`, `TrgetEntry`, `BaseRef`, `BaseType`, `BaseEntry`, `BaseLine`, `LineStatus`, `ItemCode`, `Dscription`, `Quantity`, `ShipDate`, `OpenQty`, `Price`, `Currency`, `Rate`, `DiscPrcnt`, `LineTotal`, `TotalFrgn`, `OpenSum`, `OpenSumFC`, `VendorNum`, `SerialNum`, `WhsCode`, `SlpCode`, `Commission`, `TreeType`, `AcctCode`, `TaxStatus`, `GrossBuyPr`, `PriceBefDi`, `DocDate`, `Flags`, `OpenCreQty`, `UseBaseUn`, `SubCatNum`, `BaseCard`, `TotalSumSy`, `OpenSumSys`, `InvntSttus`, `OcrCode`, `Project`, `CodeBars`, `VatPrcnt`, `VatGroup`, `PriceAfVAT`, `Height1`, `Hght1Unit`, `Height2`, `Hght2Unit`, `Width1`, `Wdth1Unit`, `Width2`, `Wdth2Unit`, `Length1`, `Len1Unit`, `length2`, `Len2Unit`, `Volume`, `VolUnit`, `Weight1`, `Wght1Unit`, `Weight2`, `Wght2Unit`, `Factor1`, `Factor2`, `Factor3`, `Factor4`, `PackQty`, `UpdInvntry`, `BaseDocNum`, `BaseAtCard`, `SWW`, `VatSum`, `VatSumFrgn`, `VatSumSy`, `FinncPriod`, `ObjType`, `LogInstanc`, `BlockNum`, `ImportLog`, `DedVatSum`, `DedVatSumF`, `DedVatSumS`, `IsAqcuistn`, `DistribSum`, `DstrbSumFC`, `DstrbSumSC`, `GrssProfit`, `GrssProfSC`, `GrssProfFC`, `VisOrder`, `INMPrice`, `PoTrgNum`, `PoTrgEntry`, `DropShip`, `PoLineNum`, `Address`, `TaxCode`, `TaxType`, `OrigItem`, `BackOrdr`, `FreeTxt`, `PickStatus`, `PickOty`, `PickIdNo`, `TrnsCode`, `VatAppld`, `VatAppldFC`, `VatAppldSC`, `BaseQty`, `BaseOpnQty`, `VatDscntPr`, `WtLiable`, `DeferrTax`, `EquVatPer`, `EquVatSum`, `EquVatSumF`, `EquVatSumS`, `LineVat`, `LineVatlF`, `LineVatS`, `unitMsr`, `NumPerMsr`, `CEECFlag`, `ToStock`, `ToDiff`, `ExciseAmt`, `TaxPerUnit`, `TotInclTax`, `CountryOrg`, `StckDstSum`, `ReleasQtty`, `LineType`, `TranType`, `Text`, `OwnerCode`, `StockPrice`, `ConsumeFCT`, `LstByDsSum`, `StckINMPr`, `LstBINMPr`, `StckDstFc`, `StckDstSc`, `LstByDsFc`, `LstByDsSc`, `StockSum`, `StockSumFc`, `StockSumSc`, `StckSumApp`, `StckAppFc`, `StckAppSc`, `ShipToCode`, `ShipToDesc`, `StckAppD`, `StckAppDFC`, `StckAppDSC`, `BasePrice`, `GTotal`, `GTotalFC`, `GTotalSC`, `DistribExp`, `DescOW`, `DetailsOW`, `GrossBase`, `VatWoDpm`, `VatWoDpmFc`, `VatWoDpmSc`, `CFOPCode`, `CSTCode`, `Usage`, `TaxOnly`, `WtCalced`, `QtyToShip`, `DelivrdQty`, `OrderedQty`, `CogsOcrCod`, `CiOppLineN`, `CogsAcct`, `ChgAsmBoMW`, `ActDelDate`, `OcrCode2`, `OcrCode3`, `OcrCode4`, `OcrCode5`, `TaxDistSum`, `TaxDistSFC`, `TaxDistSSC`, `PostTax`, `Excisable`, `AssblValue`, `RG23APart1`, `RG23APart2`, `RG23CPart1`, `RG23CPart2`, `CogsOcrCo2`, `CogsOcrCo3`, `CogsOcrCo4`, `CogsOcrCo5`, `LnExcised`, `LocCode`, `StockValue`, `GPTtlBasPr`, `unitMsr2`, `NumPerMsr2`, `SpecPrice`, `CSTfIPI`, `CSTfPIS`, `CSTfCOFINS`, `ExLineNo`, `isSrvCall`, `PQTReqQty`, `PQTReqDate`, `PcDocType`, `PcQuantity`, `LinManClsd`, `VatGrpSrc`, `U_OB_RefNo`, `U_OB_Price`, `U_OB_Week01`, `U_OB_Week02`, `U_OB_Week03`, `U_OB_Week04`, `U_OB_Week05`, `U_OB_Reason`, `U_OB_Month_2`, `U_OB_Month_3`, `U_OB_Assembly_Line`, `U_OB_PartNo`, `U_OB_MatCost`, `U_OB_LabCost`, `U_OB_Box`, `U_OB_PrioLevel`, `U_OB_Shift`, `U_OB_Process`, `U_OB_AcctName`, `U_OB_PRNO`, `U_OB_Origin`, `U_OB_SP_Assy_Line`, `U_OB_IssueDoc`, `U_NEC_ExpType`, `U_Detail_ID`, `U_Dept`, `U_BudgetRef`) VALUES
(15411, 0, -1, NULL, NULL, -1, NULL, NULL, 'O', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, -1, NULL, 'N', NULL, NULL, NULL, NULL, NULL, 0, NULL, 'N', NULL, NULL, NULL, NULL, 'O', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Y', NULL, NULL, NULL, NULL, NULL, NULL, NULL, '22', 0, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'S', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'R', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'E', NULL, NULL, NULL, NULL, 'N', 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Y', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, 'N', NULL, NULL, -1, NULL, 'N', 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `RPC1`
--

CREATE TABLE IF NOT EXISTS `RPC1` (
  `DocEntry` int(11) NOT NULL,
  `LineNum` int(11) NOT NULL,
  `TargetType` int(11) DEFAULT '-1',
  `TrgetEntry` int(11) DEFAULT NULL,
  `BaseRef` varchar(16) DEFAULT NULL,
  `BaseType` int(11) DEFAULT '-1',
  `BaseEntry` int(11) DEFAULT NULL,
  `BaseLine` int(11) DEFAULT NULL,
  `LineStatus` char(1) DEFAULT 'O',
  `ItemCode` varchar(20) DEFAULT NULL,
  `Dscription` varchar(100) DEFAULT NULL,
  `Quantity` decimal(19,6) DEFAULT NULL,
  `ShipDate` datetime DEFAULT NULL,
  `OpenQty` decimal(19,6) DEFAULT NULL,
  `Price` decimal(19,6) DEFAULT NULL,
  `Currency` varchar(3) DEFAULT NULL,
  `Rate` decimal(19,6) DEFAULT NULL,
  `DiscPrcnt` decimal(19,6) DEFAULT NULL,
  `LineTotal` decimal(19,6) DEFAULT NULL,
  `TotalFrgn` decimal(19,6) DEFAULT NULL,
  `OpenSum` decimal(19,6) DEFAULT NULL,
  `OpenSumFC` decimal(19,6) DEFAULT NULL,
  `VendorNum` varchar(17) DEFAULT NULL,
  `SerialNum` varchar(17) DEFAULT NULL,
  `WhsCode` varchar(8) DEFAULT NULL,
  `SlpCode` smallint(6) DEFAULT '-1',
  `Commission` decimal(19,6) DEFAULT NULL,
  `TreeType` char(1) DEFAULT 'N',
  `AcctCode` varchar(15) DEFAULT NULL,
  `TaxStatus` char(1) DEFAULT NULL,
  `GrossBuyPr` decimal(19,6) DEFAULT NULL,
  `PriceBefDi` decimal(19,6) DEFAULT NULL,
  `DocDate` datetime DEFAULT NULL,
  `Flags` int(11) DEFAULT '0',
  `OpenCreQty` decimal(19,6) DEFAULT NULL,
  `UseBaseUn` char(1) DEFAULT 'N',
  `SubCatNum` varchar(20) DEFAULT NULL,
  `BaseCard` varchar(15) DEFAULT NULL,
  `TotalSumSy` decimal(19,6) DEFAULT NULL,
  `OpenSumSys` decimal(19,6) DEFAULT NULL,
  `InvntSttus` char(1) DEFAULT 'O',
  `OcrCode` varchar(8) DEFAULT NULL,
  `Project` varchar(20) DEFAULT NULL,
  `CodeBars` varchar(16) DEFAULT NULL,
  `VatPrcnt` decimal(19,6) DEFAULT NULL,
  `VatGroup` varchar(8) DEFAULT NULL,
  `PriceAfVAT` decimal(19,6) DEFAULT NULL,
  `Height1` decimal(19,6) DEFAULT NULL,
  `Hght1Unit` smallint(6) DEFAULT NULL,
  `Height2` decimal(19,6) DEFAULT NULL,
  `Hght2Unit` smallint(6) DEFAULT NULL,
  `Width1` decimal(19,6) DEFAULT NULL,
  `Wdth1Unit` smallint(6) DEFAULT NULL,
  `Width2` decimal(19,6) DEFAULT NULL,
  `Wdth2Unit` smallint(6) DEFAULT NULL,
  `Length1` decimal(19,6) DEFAULT NULL,
  `Len1Unit` smallint(6) DEFAULT NULL,
  `length2` decimal(19,6) DEFAULT NULL,
  `Len2Unit` smallint(6) DEFAULT NULL,
  `Volume` decimal(19,6) DEFAULT NULL,
  `VolUnit` smallint(6) DEFAULT NULL,
  `Weight1` decimal(19,6) DEFAULT NULL,
  `Wght1Unit` smallint(6) DEFAULT NULL,
  `Weight2` decimal(19,6) DEFAULT NULL,
  `Wght2Unit` smallint(6) DEFAULT NULL,
  `Factor1` decimal(19,6) DEFAULT NULL,
  `Factor2` decimal(19,6) DEFAULT NULL,
  `Factor3` decimal(19,6) DEFAULT NULL,
  `Factor4` decimal(19,6) DEFAULT NULL,
  `PackQty` decimal(19,6) DEFAULT NULL,
  `UpdInvntry` char(1) DEFAULT 'Y',
  `BaseDocNum` int(11) DEFAULT NULL,
  `BaseAtCard` varchar(100) DEFAULT NULL,
  `SWW` varchar(16) DEFAULT NULL,
  `VatSum` decimal(19,6) DEFAULT NULL,
  `VatSumFrgn` decimal(19,6) DEFAULT NULL,
  `VatSumSy` decimal(19,6) DEFAULT NULL,
  `FinncPriod` int(11) DEFAULT NULL,
  `ObjType` varchar(20) DEFAULT '19',
  `LogInstanc` smallint(6) DEFAULT '0',
  `BlockNum` varchar(100) DEFAULT NULL,
  `ImportLog` varchar(20) DEFAULT NULL,
  `DedVatSum` decimal(19,6) DEFAULT NULL,
  `DedVatSumF` decimal(19,6) DEFAULT NULL,
  `DedVatSumS` decimal(19,6) DEFAULT NULL,
  `IsAqcuistn` char(1) DEFAULT 'N',
  `DistribSum` decimal(19,6) DEFAULT NULL,
  `DstrbSumFC` decimal(19,6) DEFAULT NULL,
  `DstrbSumSC` decimal(19,6) DEFAULT NULL,
  `GrssProfit` decimal(19,6) DEFAULT NULL,
  `GrssProfSC` decimal(19,6) DEFAULT NULL,
  `GrssProfFC` decimal(19,6) DEFAULT NULL,
  `VisOrder` int(11) DEFAULT NULL,
  `INMPrice` decimal(19,6) DEFAULT NULL,
  `PoTrgNum` int(11) DEFAULT NULL,
  `PoTrgEntry` varchar(11) DEFAULT NULL,
  `DropShip` char(1) DEFAULT 'N',
  `PoLineNum` int(11) DEFAULT NULL,
  `Address` varchar(254) DEFAULT NULL,
  `TaxCode` varchar(8) DEFAULT NULL,
  `TaxType` char(1) DEFAULT NULL,
  `OrigItem` varchar(20) DEFAULT NULL,
  `BackOrdr` char(1) DEFAULT NULL,
  `FreeTxt` varchar(100) DEFAULT NULL,
  `PickStatus` char(1) DEFAULT 'N',
  `PickOty` decimal(19,6) DEFAULT NULL,
  `PickIdNo` int(11) DEFAULT NULL,
  `TrnsCode` smallint(6) DEFAULT '-1',
  `VatAppld` decimal(19,6) DEFAULT NULL,
  `VatAppldFC` decimal(19,6) DEFAULT NULL,
  `VatAppldSC` decimal(19,6) DEFAULT NULL,
  `BaseQty` decimal(19,6) DEFAULT NULL,
  `BaseOpnQty` decimal(19,6) DEFAULT NULL,
  `VatDscntPr` decimal(19,6) DEFAULT NULL,
  `WtLiable` char(1) DEFAULT NULL,
  `DeferrTax` char(1) DEFAULT 'N',
  `EquVatPer` decimal(19,6) DEFAULT NULL,
  `EquVatSum` decimal(19,6) DEFAULT NULL,
  `EquVatSumF` decimal(19,6) DEFAULT NULL,
  `EquVatSumS` decimal(19,6) DEFAULT NULL,
  `LineVat` decimal(19,6) DEFAULT NULL,
  `LineVatlF` decimal(19,6) DEFAULT NULL,
  `LineVatS` decimal(19,6) DEFAULT NULL,
  `unitMsr` varchar(20) DEFAULT NULL,
  `NumPerMsr` decimal(19,6) DEFAULT NULL,
  `CEECFlag` char(1) DEFAULT 'S',
  `ToStock` decimal(19,6) DEFAULT NULL,
  `ToDiff` decimal(19,6) DEFAULT NULL,
  `ExciseAmt` decimal(19,6) DEFAULT NULL,
  `TaxPerUnit` decimal(19,6) DEFAULT NULL,
  `TotInclTax` decimal(19,6) DEFAULT NULL,
  `CountryOrg` varchar(3) DEFAULT NULL,
  `StckDstSum` decimal(19,6) DEFAULT NULL,
  `ReleasQtty` decimal(19,6) DEFAULT NULL,
  `LineType` char(1) DEFAULT 'R',
  `TranType` char(1) DEFAULT NULL,
  `Text` longtext,
  `OwnerCode` int(11) DEFAULT NULL,
  `StockPrice` decimal(19,6) DEFAULT NULL,
  `ConsumeFCT` char(1) DEFAULT NULL,
  `LstByDsSum` decimal(19,6) DEFAULT NULL,
  `StckINMPr` decimal(19,6) DEFAULT NULL,
  `LstBINMPr` decimal(19,6) DEFAULT NULL,
  `StckDstFc` decimal(19,6) DEFAULT NULL,
  `StckDstSc` decimal(19,6) DEFAULT NULL,
  `LstByDsFc` decimal(19,6) DEFAULT NULL,
  `LstByDsSc` decimal(19,6) DEFAULT NULL,
  `StockSum` decimal(19,6) DEFAULT NULL,
  `StockSumFc` decimal(19,6) DEFAULT NULL,
  `StockSumSc` decimal(19,6) DEFAULT NULL,
  `StckSumApp` decimal(19,6) DEFAULT NULL,
  `StckAppFc` decimal(19,6) DEFAULT NULL,
  `StckAppSc` decimal(19,6) DEFAULT NULL,
  `ShipToCode` varchar(50) DEFAULT NULL,
  `ShipToDesc` varchar(254) DEFAULT NULL,
  `StckAppD` decimal(19,6) DEFAULT NULL,
  `StckAppDFC` decimal(19,6) DEFAULT NULL,
  `StckAppDSC` decimal(19,6) DEFAULT NULL,
  `BasePrice` char(1) DEFAULT 'E',
  `GTotal` decimal(19,6) DEFAULT NULL,
  `GTotalFC` decimal(19,6) DEFAULT NULL,
  `GTotalSC` decimal(19,6) DEFAULT NULL,
  `DistribExp` char(1) DEFAULT NULL,
  `DescOW` char(1) DEFAULT 'N',
  `DetailsOW` char(1) DEFAULT 'N',
  `GrossBase` smallint(6) DEFAULT NULL,
  `VatWoDpm` decimal(19,6) DEFAULT NULL,
  `VatWoDpmFc` decimal(19,6) DEFAULT NULL,
  `VatWoDpmSc` decimal(19,6) DEFAULT NULL,
  `CFOPCode` varchar(6) DEFAULT NULL,
  `CSTCode` varchar(6) DEFAULT NULL,
  `Usage` int(11) DEFAULT NULL,
  `TaxOnly` char(1) DEFAULT NULL,
  `WtCalced` char(1) DEFAULT 'N',
  `QtyToShip` decimal(19,6) DEFAULT NULL,
  `DelivrdQty` decimal(19,6) DEFAULT NULL,
  `OrderedQty` decimal(19,6) DEFAULT NULL,
  `CogsOcrCod` varchar(8) DEFAULT NULL,
  `CiOppLineN` int(11) DEFAULT '-1',
  `CogsAcct` varchar(15) DEFAULT NULL,
  `ChgAsmBoMW` char(1) DEFAULT NULL,
  `ActDelDate` datetime DEFAULT NULL,
  `OcrCode2` varchar(8) DEFAULT NULL,
  `OcrCode3` varchar(8) DEFAULT NULL,
  `OcrCode4` varchar(8) DEFAULT NULL,
  `OcrCode5` varchar(8) DEFAULT NULL,
  `TaxDistSum` decimal(19,6) DEFAULT NULL,
  `TaxDistSFC` decimal(19,6) DEFAULT NULL,
  `TaxDistSSC` decimal(19,6) DEFAULT NULL,
  `PostTax` char(1) DEFAULT 'Y',
  `Excisable` char(1) DEFAULT NULL,
  `AssblValue` decimal(19,6) DEFAULT NULL,
  `RG23APart1` int(11) DEFAULT NULL,
  `RG23APart2` int(11) DEFAULT NULL,
  `RG23CPart1` int(11) DEFAULT NULL,
  `RG23CPart2` int(11) DEFAULT NULL,
  `CogsOcrCo2` varchar(8) DEFAULT NULL,
  `CogsOcrCo3` varchar(8) DEFAULT NULL,
  `CogsOcrCo4` varchar(8) DEFAULT NULL,
  `CogsOcrCo5` varchar(8) DEFAULT NULL,
  `LnExcised` char(1) DEFAULT NULL,
  `LocCode` int(11) DEFAULT NULL,
  `StockValue` decimal(19,6) DEFAULT NULL,
  `GPTtlBasPr` decimal(19,6) DEFAULT NULL,
  `unitMsr2` varchar(20) DEFAULT NULL,
  `NumPerMsr2` decimal(19,6) DEFAULT NULL,
  `SpecPrice` char(1) DEFAULT 'N',
  `CSTfIPI` varchar(2) DEFAULT NULL,
  `CSTfPIS` varchar(2) DEFAULT NULL,
  `CSTfCOFINS` varchar(2) DEFAULT NULL,
  `ExLineNo` varchar(10) DEFAULT NULL,
  `isSrvCall` char(1) DEFAULT 'N',
  `PQTReqQty` decimal(19,6) DEFAULT NULL,
  `PQTReqDate` datetime DEFAULT NULL,
  `PcDocType` int(11) DEFAULT '-1',
  `PcQuantity` decimal(19,6) DEFAULT NULL,
  `LinManClsd` char(1) DEFAULT 'N',
  `VatGrpSrc` char(1) DEFAULT 'N',
  `U_OB_RefNo` longtext,
  `U_OB_Price` decimal(19,6) DEFAULT NULL,
  `U_OB_Week01` decimal(19,6) DEFAULT NULL,
  `U_OB_Week02` decimal(19,6) DEFAULT NULL,
  `U_OB_Week03` decimal(19,6) DEFAULT NULL,
  `U_OB_Week04` decimal(19,6) DEFAULT NULL,
  `U_OB_Week05` decimal(19,6) DEFAULT NULL,
  `U_OB_Reason` longtext,
  `U_OB_Month_2` decimal(19,6) DEFAULT NULL,
  `U_OB_Month_3` decimal(19,6) DEFAULT NULL,
  `U_OB_Assembly_Line` longtext,
  `U_OB_PartNo` longtext,
  `U_OB_MatCost` decimal(19,6) DEFAULT NULL,
  `U_OB_LabCost` decimal(19,6) DEFAULT NULL,
  `U_OB_Box` decimal(19,6) DEFAULT NULL,
  `U_OB_PrioLevel` longtext,
  `U_OB_Shift` longtext,
  `U_OB_Process` longtext,
  `U_OB_AcctName` longtext,
  `U_OB_PRNO` longtext,
  `U_OB_Origin` longtext,
  `U_OB_SP_Assy_Line` longtext,
  `U_OB_IssueDoc` int(11) DEFAULT NULL,
  `U_NEC_ExpType` longtext,
  `U_Detail_ID` longtext,
  `U_Dept` longtext,
  `U_BudgetRef` longtext,
  PRIMARY KEY (`DocEntry`,`LineNum`),
  KEY `RPC1_STATUS` (`LineStatus`),
  KEY `RPC1_CURRENCY` (`Currency`),
  KEY `RPC1_ACCOUNT` (`AcctCode`),
  KEY `RPC1_BASE_ENTRY` (`BaseEntry`,`BaseType`,`BaseLine`),
  KEY `RPC1_VIS_ORDER` (`DocEntry`,`VisOrder`),
  KEY `RPC1_OWNER_CODE` (`OwnerCode`),
  KEY `RPC1_ITM_WHS_OQ` (`ItemCode`,`WhsCode`,`OpenQty`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `RPC1`
--

INSERT INTO `RPC1` (`DocEntry`, `LineNum`, `TargetType`, `TrgetEntry`, `BaseRef`, `BaseType`, `BaseEntry`, `BaseLine`, `LineStatus`, `ItemCode`, `Dscription`, `Quantity`, `ShipDate`, `OpenQty`, `Price`, `Currency`, `Rate`, `DiscPrcnt`, `LineTotal`, `TotalFrgn`, `OpenSum`, `OpenSumFC`, `VendorNum`, `SerialNum`, `WhsCode`, `SlpCode`, `Commission`, `TreeType`, `AcctCode`, `TaxStatus`, `GrossBuyPr`, `PriceBefDi`, `DocDate`, `Flags`, `OpenCreQty`, `UseBaseUn`, `SubCatNum`, `BaseCard`, `TotalSumSy`, `OpenSumSys`, `InvntSttus`, `OcrCode`, `Project`, `CodeBars`, `VatPrcnt`, `VatGroup`, `PriceAfVAT`, `Height1`, `Hght1Unit`, `Height2`, `Hght2Unit`, `Width1`, `Wdth1Unit`, `Width2`, `Wdth2Unit`, `Length1`, `Len1Unit`, `length2`, `Len2Unit`, `Volume`, `VolUnit`, `Weight1`, `Wght1Unit`, `Weight2`, `Wght2Unit`, `Factor1`, `Factor2`, `Factor3`, `Factor4`, `PackQty`, `UpdInvntry`, `BaseDocNum`, `BaseAtCard`, `SWW`, `VatSum`, `VatSumFrgn`, `VatSumSy`, `FinncPriod`, `ObjType`, `LogInstanc`, `BlockNum`, `ImportLog`, `DedVatSum`, `DedVatSumF`, `DedVatSumS`, `IsAqcuistn`, `DistribSum`, `DstrbSumFC`, `DstrbSumSC`, `GrssProfit`, `GrssProfSC`, `GrssProfFC`, `VisOrder`, `INMPrice`, `PoTrgNum`, `PoTrgEntry`, `DropShip`, `PoLineNum`, `Address`, `TaxCode`, `TaxType`, `OrigItem`, `BackOrdr`, `FreeTxt`, `PickStatus`, `PickOty`, `PickIdNo`, `TrnsCode`, `VatAppld`, `VatAppldFC`, `VatAppldSC`, `BaseQty`, `BaseOpnQty`, `VatDscntPr`, `WtLiable`, `DeferrTax`, `EquVatPer`, `EquVatSum`, `EquVatSumF`, `EquVatSumS`, `LineVat`, `LineVatlF`, `LineVatS`, `unitMsr`, `NumPerMsr`, `CEECFlag`, `ToStock`, `ToDiff`, `ExciseAmt`, `TaxPerUnit`, `TotInclTax`, `CountryOrg`, `StckDstSum`, `ReleasQtty`, `LineType`, `TranType`, `Text`, `OwnerCode`, `StockPrice`, `ConsumeFCT`, `LstByDsSum`, `StckINMPr`, `LstBINMPr`, `StckDstFc`, `StckDstSc`, `LstByDsFc`, `LstByDsSc`, `StockSum`, `StockSumFc`, `StockSumSc`, `StckSumApp`, `StckAppFc`, `StckAppSc`, `ShipToCode`, `ShipToDesc`, `StckAppD`, `StckAppDFC`, `StckAppDSC`, `BasePrice`, `GTotal`, `GTotalFC`, `GTotalSC`, `DistribExp`, `DescOW`, `DetailsOW`, `GrossBase`, `VatWoDpm`, `VatWoDpmFc`, `VatWoDpmSc`, `CFOPCode`, `CSTCode`, `Usage`, `TaxOnly`, `WtCalced`, `QtyToShip`, `DelivrdQty`, `OrderedQty`, `CogsOcrCod`, `CiOppLineN`, `CogsAcct`, `ChgAsmBoMW`, `ActDelDate`, `OcrCode2`, `OcrCode3`, `OcrCode4`, `OcrCode5`, `TaxDistSum`, `TaxDistSFC`, `TaxDistSSC`, `PostTax`, `Excisable`, `AssblValue`, `RG23APart1`, `RG23APart2`, `RG23CPart1`, `RG23CPart2`, `CogsOcrCo2`, `CogsOcrCo3`, `CogsOcrCo4`, `CogsOcrCo5`, `LnExcised`, `LocCode`, `StockValue`, `GPTtlBasPr`, `unitMsr2`, `NumPerMsr2`, `SpecPrice`, `CSTfIPI`, `CSTfPIS`, `CSTfCOFINS`, `ExLineNo`, `isSrvCall`, `PQTReqQty`, `PQTReqDate`, `PcDocType`, `PcQuantity`, `LinManClsd`, `VatGrpSrc`, `U_OB_RefNo`, `U_OB_Price`, `U_OB_Week01`, `U_OB_Week02`, `U_OB_Week03`, `U_OB_Week04`, `U_OB_Week05`, `U_OB_Reason`, `U_OB_Month_2`, `U_OB_Month_3`, `U_OB_Assembly_Line`, `U_OB_PartNo`, `U_OB_MatCost`, `U_OB_LabCost`, `U_OB_Box`, `U_OB_PrioLevel`, `U_OB_Shift`, `U_OB_Process`, `U_OB_AcctName`, `U_OB_PRNO`, `U_OB_Origin`, `U_OB_SP_Assy_Line`, `U_OB_IssueDoc`, `U_NEC_ExpType`, `U_Detail_ID`, `U_Dept`, `U_BudgetRef`) VALUES
(729, 22, -1, NULL, NULL, -1, 35070, 22, 'O', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, -1, NULL, 'N', NULL, NULL, NULL, NULL, NULL, 0, NULL, 'N', NULL, NULL, NULL, NULL, 'O', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Y', NULL, NULL, NULL, NULL, NULL, NULL, NULL, '19', 0, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'S', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'R', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'E', NULL, NULL, NULL, NULL, 'N', 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Y', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, 'N', NULL, NULL, -1, NULL, 'N', 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `RPD1`
--

CREATE TABLE IF NOT EXISTS `RPD1` (
  `DocEntry` int(11) NOT NULL,
  `LineNum` int(11) NOT NULL,
  `TargetType` int(11) DEFAULT '-1',
  `TrgetEntry` int(11) DEFAULT NULL,
  `BaseRef` varchar(16) DEFAULT NULL,
  `BaseType` int(11) DEFAULT '-1',
  `BaseEntry` int(11) DEFAULT NULL,
  `BaseLine` int(11) DEFAULT NULL,
  `LineStatus` char(1) DEFAULT 'O',
  `ItemCode` varchar(20) DEFAULT NULL,
  `Dscription` varchar(100) DEFAULT NULL,
  `Quantity` decimal(19,6) DEFAULT NULL,
  `ShipDate` datetime DEFAULT NULL,
  `OpenQty` decimal(19,6) DEFAULT NULL,
  `Price` decimal(19,6) DEFAULT NULL,
  `Currency` varchar(3) DEFAULT NULL,
  `Rate` decimal(19,6) DEFAULT NULL,
  `DiscPrcnt` decimal(19,6) DEFAULT NULL,
  `LineTotal` decimal(19,6) DEFAULT NULL,
  `TotalFrgn` decimal(19,6) DEFAULT NULL,
  `OpenSum` decimal(19,6) DEFAULT NULL,
  `OpenSumFC` decimal(19,6) DEFAULT NULL,
  `VendorNum` varchar(17) DEFAULT NULL,
  `SerialNum` varchar(17) DEFAULT NULL,
  `WhsCode` varchar(8) DEFAULT NULL,
  `SlpCode` smallint(6) DEFAULT '-1',
  `Commission` decimal(19,6) DEFAULT NULL,
  `TreeType` char(1) DEFAULT 'N',
  `AcctCode` varchar(15) DEFAULT NULL,
  `TaxStatus` char(1) DEFAULT NULL,
  `GrossBuyPr` decimal(19,6) DEFAULT NULL,
  `PriceBefDi` decimal(19,6) DEFAULT NULL,
  `DocDate` datetime DEFAULT NULL,
  `Flags` int(11) DEFAULT '0',
  `OpenCreQty` decimal(19,6) DEFAULT NULL,
  `UseBaseUn` char(1) DEFAULT 'N',
  `SubCatNum` varchar(20) DEFAULT NULL,
  `BaseCard` varchar(15) DEFAULT NULL,
  `TotalSumSy` decimal(19,6) DEFAULT NULL,
  `OpenSumSys` decimal(19,6) DEFAULT NULL,
  `InvntSttus` char(1) DEFAULT 'O',
  `OcrCode` varchar(8) DEFAULT NULL,
  `Project` varchar(20) DEFAULT NULL,
  `CodeBars` varchar(16) DEFAULT NULL,
  `VatPrcnt` decimal(19,6) DEFAULT NULL,
  `VatGroup` varchar(8) DEFAULT NULL,
  `PriceAfVAT` decimal(19,6) DEFAULT NULL,
  `Height1` decimal(19,6) DEFAULT NULL,
  `Hght1Unit` smallint(6) DEFAULT NULL,
  `Height2` decimal(19,6) DEFAULT NULL,
  `Hght2Unit` smallint(6) DEFAULT NULL,
  `Width1` decimal(19,6) DEFAULT NULL,
  `Wdth1Unit` smallint(6) DEFAULT NULL,
  `Width2` decimal(19,6) DEFAULT NULL,
  `Wdth2Unit` smallint(6) DEFAULT NULL,
  `Length1` decimal(19,6) DEFAULT NULL,
  `Len1Unit` smallint(6) DEFAULT NULL,
  `length2` decimal(19,6) DEFAULT NULL,
  `Len2Unit` smallint(6) DEFAULT NULL,
  `Volume` decimal(19,6) DEFAULT NULL,
  `VolUnit` smallint(6) DEFAULT NULL,
  `Weight1` decimal(19,6) DEFAULT NULL,
  `Wght1Unit` smallint(6) DEFAULT NULL,
  `Weight2` decimal(19,6) DEFAULT NULL,
  `Wght2Unit` smallint(6) DEFAULT NULL,
  `Factor1` decimal(19,6) DEFAULT NULL,
  `Factor2` decimal(19,6) DEFAULT NULL,
  `Factor3` decimal(19,6) DEFAULT NULL,
  `Factor4` decimal(19,6) DEFAULT NULL,
  `PackQty` decimal(19,6) DEFAULT NULL,
  `UpdInvntry` char(1) DEFAULT 'Y',
  `BaseDocNum` int(11) DEFAULT NULL,
  `BaseAtCard` varchar(100) DEFAULT NULL,
  `SWW` varchar(16) DEFAULT NULL,
  `VatSum` decimal(19,6) DEFAULT NULL,
  `VatSumFrgn` decimal(19,6) DEFAULT NULL,
  `VatSumSy` decimal(19,6) DEFAULT NULL,
  `FinncPriod` int(11) DEFAULT NULL,
  `ObjType` varchar(20) DEFAULT '21',
  `LogInstanc` smallint(6) DEFAULT '0',
  `BlockNum` varchar(100) DEFAULT NULL,
  `ImportLog` varchar(20) DEFAULT NULL,
  `DedVatSum` decimal(19,6) DEFAULT NULL,
  `DedVatSumF` decimal(19,6) DEFAULT NULL,
  `DedVatSumS` decimal(19,6) DEFAULT NULL,
  `IsAqcuistn` char(1) DEFAULT 'N',
  `DistribSum` decimal(19,6) DEFAULT NULL,
  `DstrbSumFC` decimal(19,6) DEFAULT NULL,
  `DstrbSumSC` decimal(19,6) DEFAULT NULL,
  `GrssProfit` decimal(19,6) DEFAULT NULL,
  `GrssProfSC` decimal(19,6) DEFAULT NULL,
  `GrssProfFC` decimal(19,6) DEFAULT NULL,
  `VisOrder` int(11) DEFAULT NULL,
  `INMPrice` decimal(19,6) DEFAULT NULL,
  `PoTrgNum` int(11) DEFAULT NULL,
  `PoTrgEntry` varchar(11) DEFAULT NULL,
  `DropShip` char(1) DEFAULT 'N',
  `PoLineNum` int(11) DEFAULT NULL,
  `Address` varchar(254) DEFAULT NULL,
  `TaxCode` varchar(8) DEFAULT NULL,
  `TaxType` char(1) DEFAULT NULL,
  `OrigItem` varchar(20) DEFAULT NULL,
  `BackOrdr` char(1) DEFAULT NULL,
  `FreeTxt` varchar(100) DEFAULT NULL,
  `PickStatus` char(1) DEFAULT 'N',
  `PickOty` decimal(19,6) DEFAULT NULL,
  `PickIdNo` int(11) DEFAULT NULL,
  `TrnsCode` smallint(6) DEFAULT '-1',
  `VatAppld` decimal(19,6) DEFAULT NULL,
  `VatAppldFC` decimal(19,6) DEFAULT NULL,
  `VatAppldSC` decimal(19,6) DEFAULT NULL,
  `BaseQty` decimal(19,6) DEFAULT NULL,
  `BaseOpnQty` decimal(19,6) DEFAULT NULL,
  `VatDscntPr` decimal(19,6) DEFAULT NULL,
  `WtLiable` char(1) DEFAULT NULL,
  `DeferrTax` char(1) DEFAULT 'N',
  `EquVatPer` decimal(19,6) DEFAULT NULL,
  `EquVatSum` decimal(19,6) DEFAULT NULL,
  `EquVatSumF` decimal(19,6) DEFAULT NULL,
  `EquVatSumS` decimal(19,6) DEFAULT NULL,
  `LineVat` decimal(19,6) DEFAULT NULL,
  `LineVatlF` decimal(19,6) DEFAULT NULL,
  `LineVatS` decimal(19,6) DEFAULT NULL,
  `unitMsr` varchar(20) DEFAULT NULL,
  `NumPerMsr` decimal(19,6) DEFAULT NULL,
  `CEECFlag` char(1) DEFAULT 'S',
  `ToStock` decimal(19,6) DEFAULT NULL,
  `ToDiff` decimal(19,6) DEFAULT NULL,
  `ExciseAmt` decimal(19,6) DEFAULT NULL,
  `TaxPerUnit` decimal(19,6) DEFAULT NULL,
  `TotInclTax` decimal(19,6) DEFAULT NULL,
  `CountryOrg` varchar(3) DEFAULT NULL,
  `StckDstSum` decimal(19,6) DEFAULT NULL,
  `ReleasQtty` decimal(19,6) DEFAULT NULL,
  `LineType` char(1) DEFAULT 'R',
  `TranType` char(1) DEFAULT NULL,
  `Text` longtext,
  `OwnerCode` int(11) DEFAULT NULL,
  `StockPrice` decimal(19,6) DEFAULT NULL,
  `ConsumeFCT` char(1) DEFAULT NULL,
  `LstByDsSum` decimal(19,6) DEFAULT NULL,
  `StckINMPr` decimal(19,6) DEFAULT NULL,
  `LstBINMPr` decimal(19,6) DEFAULT NULL,
  `StckDstFc` decimal(19,6) DEFAULT NULL,
  `StckDstSc` decimal(19,6) DEFAULT NULL,
  `LstByDsFc` decimal(19,6) DEFAULT NULL,
  `LstByDsSc` decimal(19,6) DEFAULT NULL,
  `StockSum` decimal(19,6) DEFAULT NULL,
  `StockSumFc` decimal(19,6) DEFAULT NULL,
  `StockSumSc` decimal(19,6) DEFAULT NULL,
  `StckSumApp` decimal(19,6) DEFAULT NULL,
  `StckAppFc` decimal(19,6) DEFAULT NULL,
  `StckAppSc` decimal(19,6) DEFAULT NULL,
  `ShipToCode` varchar(50) DEFAULT NULL,
  `ShipToDesc` varchar(254) DEFAULT NULL,
  `StckAppD` decimal(19,6) DEFAULT NULL,
  `StckAppDFC` decimal(19,6) DEFAULT NULL,
  `StckAppDSC` decimal(19,6) DEFAULT NULL,
  `BasePrice` char(1) DEFAULT 'E',
  `GTotal` decimal(19,6) DEFAULT NULL,
  `GTotalFC` decimal(19,6) DEFAULT NULL,
  `GTotalSC` decimal(19,6) DEFAULT NULL,
  `DistribExp` char(1) DEFAULT NULL,
  `DescOW` char(1) DEFAULT 'N',
  `DetailsOW` char(1) DEFAULT 'N',
  `GrossBase` smallint(6) DEFAULT NULL,
  `VatWoDpm` decimal(19,6) DEFAULT NULL,
  `VatWoDpmFc` decimal(19,6) DEFAULT NULL,
  `VatWoDpmSc` decimal(19,6) DEFAULT NULL,
  `CFOPCode` varchar(6) DEFAULT NULL,
  `CSTCode` varchar(6) DEFAULT NULL,
  `Usage` int(11) DEFAULT NULL,
  `TaxOnly` char(1) DEFAULT NULL,
  `WtCalced` char(1) DEFAULT 'N',
  `QtyToShip` decimal(19,6) DEFAULT NULL,
  `DelivrdQty` decimal(19,6) DEFAULT NULL,
  `OrderedQty` decimal(19,6) DEFAULT NULL,
  `CogsOcrCod` varchar(8) DEFAULT NULL,
  `CiOppLineN` int(11) DEFAULT '-1',
  `CogsAcct` varchar(15) DEFAULT NULL,
  `ChgAsmBoMW` char(1) DEFAULT NULL,
  `ActDelDate` datetime DEFAULT NULL,
  `OcrCode2` varchar(8) DEFAULT NULL,
  `OcrCode3` varchar(8) DEFAULT NULL,
  `OcrCode4` varchar(8) DEFAULT NULL,
  `OcrCode5` varchar(8) DEFAULT NULL,
  `TaxDistSum` decimal(19,6) DEFAULT NULL,
  `TaxDistSFC` decimal(19,6) DEFAULT NULL,
  `TaxDistSSC` decimal(19,6) DEFAULT NULL,
  `PostTax` char(1) DEFAULT 'Y',
  `Excisable` char(1) DEFAULT NULL,
  `AssblValue` decimal(19,6) DEFAULT NULL,
  `RG23APart1` int(11) DEFAULT NULL,
  `RG23APart2` int(11) DEFAULT NULL,
  `RG23CPart1` int(11) DEFAULT NULL,
  `RG23CPart2` int(11) DEFAULT NULL,
  `CogsOcrCo2` varchar(8) DEFAULT NULL,
  `CogsOcrCo3` varchar(8) DEFAULT NULL,
  `CogsOcrCo4` varchar(8) DEFAULT NULL,
  `CogsOcrCo5` varchar(8) DEFAULT NULL,
  `LnExcised` char(1) DEFAULT NULL,
  `LocCode` int(11) DEFAULT NULL,
  `StockValue` decimal(19,6) DEFAULT NULL,
  `GPTtlBasPr` decimal(19,6) DEFAULT NULL,
  `unitMsr2` varchar(20) DEFAULT NULL,
  `NumPerMsr2` decimal(19,6) DEFAULT NULL,
  `SpecPrice` char(1) DEFAULT 'N',
  `CSTfIPI` varchar(2) DEFAULT NULL,
  `CSTfPIS` varchar(2) DEFAULT NULL,
  `CSTfCOFINS` varchar(2) DEFAULT NULL,
  `ExLineNo` varchar(10) DEFAULT NULL,
  `isSrvCall` char(1) DEFAULT 'N',
  `PQTReqQty` decimal(19,6) DEFAULT NULL,
  `PQTReqDate` datetime DEFAULT NULL,
  `PcDocType` int(11) DEFAULT '-1',
  `PcQuantity` decimal(19,6) DEFAULT NULL,
  `LinManClsd` char(1) DEFAULT 'N',
  `VatGrpSrc` char(1) DEFAULT 'N',
  `U_OB_RefNo` longtext,
  `U_OB_Price` decimal(19,6) DEFAULT NULL,
  `U_OB_Week01` decimal(19,6) DEFAULT NULL,
  `U_OB_Week02` decimal(19,6) DEFAULT NULL,
  `U_OB_Week03` decimal(19,6) DEFAULT NULL,
  `U_OB_Week04` decimal(19,6) DEFAULT NULL,
  `U_OB_Week05` decimal(19,6) DEFAULT NULL,
  `U_OB_Reason` longtext,
  `U_OB_Month_2` decimal(19,6) DEFAULT NULL,
  `U_OB_Month_3` decimal(19,6) DEFAULT NULL,
  `U_OB_Assembly_Line` longtext,
  `U_OB_PartNo` longtext,
  `U_OB_MatCost` decimal(19,6) DEFAULT NULL,
  `U_OB_LabCost` decimal(19,6) DEFAULT NULL,
  `U_OB_Box` decimal(19,6) DEFAULT NULL,
  `U_OB_PrioLevel` longtext,
  `U_OB_Shift` longtext,
  `U_OB_Process` longtext,
  `U_OB_AcctName` longtext,
  `U_OB_PRNO` longtext,
  `U_OB_Origin` longtext,
  `U_OB_SP_Assy_Line` longtext,
  `U_OB_IssueDoc` int(11) DEFAULT NULL,
  `U_NEC_ExpType` longtext,
  `U_Detail_ID` longtext,
  `U_Dept` longtext,
  `U_BudgetRef` longtext,
  PRIMARY KEY (`DocEntry`,`LineNum`),
  KEY `RPD1_STATUS` (`LineStatus`),
  KEY `RPD1_CURRENCY` (`Currency`),
  KEY `RPD1_ACCOUNT` (`AcctCode`),
  KEY `RPD1_BASE_ENTRY` (`BaseEntry`,`BaseType`,`BaseLine`),
  KEY `RPD1_VIS_ORDER` (`DocEntry`,`VisOrder`),
  KEY `RPD1_OWNER_CODE` (`OwnerCode`),
  KEY `RPD1_ITM_WHS_OQ` (`ItemCode`,`WhsCode`,`OpenQty`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `RPD1`
--

INSERT INTO `RPD1` (`DocEntry`, `LineNum`, `TargetType`, `TrgetEntry`, `BaseRef`, `BaseType`, `BaseEntry`, `BaseLine`, `LineStatus`, `ItemCode`, `Dscription`, `Quantity`, `ShipDate`, `OpenQty`, `Price`, `Currency`, `Rate`, `DiscPrcnt`, `LineTotal`, `TotalFrgn`, `OpenSum`, `OpenSumFC`, `VendorNum`, `SerialNum`, `WhsCode`, `SlpCode`, `Commission`, `TreeType`, `AcctCode`, `TaxStatus`, `GrossBuyPr`, `PriceBefDi`, `DocDate`, `Flags`, `OpenCreQty`, `UseBaseUn`, `SubCatNum`, `BaseCard`, `TotalSumSy`, `OpenSumSys`, `InvntSttus`, `OcrCode`, `Project`, `CodeBars`, `VatPrcnt`, `VatGroup`, `PriceAfVAT`, `Height1`, `Hght1Unit`, `Height2`, `Hght2Unit`, `Width1`, `Wdth1Unit`, `Width2`, `Wdth2Unit`, `Length1`, `Len1Unit`, `length2`, `Len2Unit`, `Volume`, `VolUnit`, `Weight1`, `Wght1Unit`, `Weight2`, `Wght2Unit`, `Factor1`, `Factor2`, `Factor3`, `Factor4`, `PackQty`, `UpdInvntry`, `BaseDocNum`, `BaseAtCard`, `SWW`, `VatSum`, `VatSumFrgn`, `VatSumSy`, `FinncPriod`, `ObjType`, `LogInstanc`, `BlockNum`, `ImportLog`, `DedVatSum`, `DedVatSumF`, `DedVatSumS`, `IsAqcuistn`, `DistribSum`, `DstrbSumFC`, `DstrbSumSC`, `GrssProfit`, `GrssProfSC`, `GrssProfFC`, `VisOrder`, `INMPrice`, `PoTrgNum`, `PoTrgEntry`, `DropShip`, `PoLineNum`, `Address`, `TaxCode`, `TaxType`, `OrigItem`, `BackOrdr`, `FreeTxt`, `PickStatus`, `PickOty`, `PickIdNo`, `TrnsCode`, `VatAppld`, `VatAppldFC`, `VatAppldSC`, `BaseQty`, `BaseOpnQty`, `VatDscntPr`, `WtLiable`, `DeferrTax`, `EquVatPer`, `EquVatSum`, `EquVatSumF`, `EquVatSumS`, `LineVat`, `LineVatlF`, `LineVatS`, `unitMsr`, `NumPerMsr`, `CEECFlag`, `ToStock`, `ToDiff`, `ExciseAmt`, `TaxPerUnit`, `TotInclTax`, `CountryOrg`, `StckDstSum`, `ReleasQtty`, `LineType`, `TranType`, `Text`, `OwnerCode`, `StockPrice`, `ConsumeFCT`, `LstByDsSum`, `StckINMPr`, `LstBINMPr`, `StckDstFc`, `StckDstSc`, `LstByDsFc`, `LstByDsSc`, `StockSum`, `StockSumFc`, `StockSumSc`, `StckSumApp`, `StckAppFc`, `StckAppSc`, `ShipToCode`, `ShipToDesc`, `StckAppD`, `StckAppDFC`, `StckAppDSC`, `BasePrice`, `GTotal`, `GTotalFC`, `GTotalSC`, `DistribExp`, `DescOW`, `DetailsOW`, `GrossBase`, `VatWoDpm`, `VatWoDpmFc`, `VatWoDpmSc`, `CFOPCode`, `CSTCode`, `Usage`, `TaxOnly`, `WtCalced`, `QtyToShip`, `DelivrdQty`, `OrderedQty`, `CogsOcrCod`, `CiOppLineN`, `CogsAcct`, `ChgAsmBoMW`, `ActDelDate`, `OcrCode2`, `OcrCode3`, `OcrCode4`, `OcrCode5`, `TaxDistSum`, `TaxDistSFC`, `TaxDistSSC`, `PostTax`, `Excisable`, `AssblValue`, `RG23APart1`, `RG23APart2`, `RG23CPart1`, `RG23CPart2`, `CogsOcrCo2`, `CogsOcrCo3`, `CogsOcrCo4`, `CogsOcrCo5`, `LnExcised`, `LocCode`, `StockValue`, `GPTtlBasPr`, `unitMsr2`, `NumPerMsr2`, `SpecPrice`, `CSTfIPI`, `CSTfPIS`, `CSTfCOFINS`, `ExLineNo`, `isSrvCall`, `PQTReqQty`, `PQTReqDate`, `PcDocType`, `PcQuantity`, `LinManClsd`, `VatGrpSrc`, `U_OB_RefNo`, `U_OB_Price`, `U_OB_Week01`, `U_OB_Week02`, `U_OB_Week03`, `U_OB_Week04`, `U_OB_Week05`, `U_OB_Reason`, `U_OB_Month_2`, `U_OB_Month_3`, `U_OB_Assembly_Line`, `U_OB_PartNo`, `U_OB_MatCost`, `U_OB_LabCost`, `U_OB_Box`, `U_OB_PrioLevel`, `U_OB_Shift`, `U_OB_Process`, `U_OB_AcctName`, `U_OB_PRNO`, `U_OB_Origin`, `U_OB_SP_Assy_Line`, `U_OB_IssueDoc`, `U_NEC_ExpType`, `U_Detail_ID`, `U_Dept`, `U_BudgetRef`) VALUES
(1203, 1, -1, NULL, NULL, -1, 34208, 1, 'O', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, -1, NULL, 'N', NULL, NULL, NULL, NULL, NULL, 0, NULL, 'N', NULL, NULL, NULL, NULL, 'O', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Y', NULL, NULL, NULL, NULL, NULL, NULL, NULL, '21', 0, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'S', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'R', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'E', NULL, NULL, NULL, NULL, 'N', 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, -1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Y', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'N', NULL, NULL, NULL, NULL, 'N', NULL, NULL, -1, NULL, 'N', 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `tblAARequest`
--

CREATE TABLE IF NOT EXISTS `tblAARequest` (
  `fldAACode` int(11) NOT NULL AUTO_INCREMENT,
  `fldBudRefNum` varchar(30) NOT NULL,
  `fldBudRevNum` varchar(30) NOT NULL,
  `fldWBudget` varchar(15) NOT NULL,
  `fldPONo` varchar(30) NOT NULL,
  `fldPRNo` varchar(30) NOT NULL,
  `fldMonthAcquired` date NOT NULL,
  `fldOrderSupplier` varchar(100) NOT NULL,
  `fldOrderDesc` varchar(100) NOT NULL,
  `fldClassification` varchar(50) NOT NULL,
  `fldOrderDepartment` varchar(50) NOT NULL,
  `fldAmountJPY` decimal(65,2) NOT NULL,
  `fldQTY` int(11) NOT NULL,
  `fldUOM` varchar(100) NOT NULL,
  `fldOrderRemarks` varchar(100) NOT NULL,
  `fldSignature` varchar(50) NOT NULL,
  UNIQUE KEY `AAPrimary` (`fldAACode`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `tblActualAcquisition`
--

CREATE TABLE IF NOT EXISTS `tblActualAcquisition` (
  `fldAACode` int(11) NOT NULL AUTO_INCREMENT,
  `fldBudRefNum` varchar(30) DEFAULT NULL,
  `fldTransCode` varchar(150) DEFAULT NULL,
  `fldWBudget` varchar(15) DEFAULT NULL,
  `fldPONo` varchar(30) NOT NULL,
  `fldPRNo` varchar(30) NOT NULL,
  `fldMonthAcquired` date DEFAULT NULL,
  `fldOrderSupplier` varchar(100) NOT NULL,
  `fldOrderDesc` varchar(100) NOT NULL,
  `fldClassification` varchar(50) NOT NULL,
  `fldOrderDepartment` varchar(50) NOT NULL,
  `fldCurrency` varchar(50) DEFAULT NULL,
  `fldYen` decimal(65,4) DEFAULT NULL,
  `fldAmountJPY` decimal(65,4) NOT NULL,
  `fldQTY` int(11) NOT NULL,
  `fldUOM` varchar(100) NOT NULL,
  `fldOrderRemarks` varchar(100) DEFAULT NULL,
  `fldSignature` varchar(50) NOT NULL,
  `fldNB` varchar(15) DEFAULT NULL,
  `fldUID` int(11) DEFAULT NULL,
  `fldMO` date DEFAULT NULL,
  UNIQUE KEY `AAPrimary` (`fldAACode`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Triggers `tblActualAcquisition`
--
DROP TRIGGER IF EXISTS `triggerNOBUDGETAA`;
DELIMITER //
CREATE TRIGGER `triggerNOBUDGETAA` BEFORE INSERT ON `tblActualAcquisition`
 FOR EACH ROW SET NEW.fldNB =
CASE 
 WHEN left(new.fldBudRefNum,9) = 'NO BUDGET' then 'YES'
 WHEN left(new.fldBudRefNum,9) != 'NO BUDGET' then 'NO'
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tblBudget`
--

CREATE TABLE IF NOT EXISTS `tblBudget` (
  `fldBudgetID` int(50) NOT NULL AUTO_INCREMENT,
  `fldBudRefNum` varchar(50) NOT NULL,
  `fldDept` varchar(50) NOT NULL,
  `fldDesc` varchar(500) DEFAULT NULL,
  `fldClass` varchar(50) DEFAULT NULL,
  `fldProcess` varchar(50) NOT NULL,
  `fldCurrency` varchar(10) DEFAULT NULL,
  `fldYen` decimal(65,6) DEFAULT NULL,
  `fldAmount` decimal(65,6) NOT NULL,
  `fldQTY` decimal(65,6) DEFAULT NULL,
  `fldUOM` varchar(100) DEFAULT NULL,
  `fldPHPAmount` decimal(65,6) NOT NULL,
  `fldUSDAmount` decimal(65,6) NOT NULL,
  `fldSOU` date DEFAULT NULL,
  `fldMBudgeted` date NOT NULL,
  `fldMForecasted` date DEFAULT NULL,
  `fldStat` varchar(50) NOT NULL,
  `fldRemarks` mediumtext NOT NULL,
  `fldMonth` int(11) DEFAULT NULL,
  `fldNB` varchar(15) DEFAULT NULL,
  `fldUID` int(11) DEFAULT NULL,
  PRIMARY KEY (`fldBudgetID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=1186 ;

--
-- Triggers `tblBudget`
--
DROP TRIGGER IF EXISTS `triggerNOBUDGET`;
DELIMITER //
CREATE TRIGGER `triggerNOBUDGET` BEFORE INSERT ON `tblBudget`
 FOR EACH ROW SET NEW.fldNB =
CASE 
 WHEN left(new.fldBudRefNum,9) = 'NO BUDGET' then 'YES'
 WHEN left(new.fldBudRefNum,9) != 'NO BUDGET' then 'NO'
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tblClass`
--

CREATE TABLE IF NOT EXISTS `tblClass` (
  `fldCCode` int(11) NOT NULL AUTO_INCREMENT,
  `fldClassCode` varchar(25) NOT NULL,
  `fldClassDesc` varchar(500) NOT NULL,
  PRIMARY KEY (`fldCCode`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=64 ;

--
-- Dumping data for table `tblClass`
--

INSERT INTO `tblClass` (`fldCCode`, `fldClassCode`, `fldClassDesc`) VALUES
(1, 'ALL', 'ALL'),
(16, 'OS', 'OFFICE SUPPLIES'),
(17, 'ADVERTISING', 'ADVERTISING'),
(18, 'FS', 'FACTORY SUPPLIES'),
(19, 'FS-SP', 'FACTORY SUPPLIES-SPAREPARTS'),
(20, 'GAS', 'GASOLINE & OIL'),
(21, 'JANSUP', 'JANITORIAL SUPPLIES AND SERVICES'),
(22, 'NC', 'NON-CONSUMABLES EXPENSES'),
(23, 'PACKAGING', 'PACKAGING SUPPLIES-SELLING'),
(24, 'PF', 'PROFESSIONAL FEES'),
(25, 'RM-LAB', 'REPAIRS & MAINTENANCE - LABOR'),
(26, 'RM-MAT', 'REPAIRS & MAINTENANCE - MAT'),
(27, 'SEB-CP', 'SEB - C. PARTY'),
(28, 'SEB-OUT', 'SEB - OUTING'),
(29, 'SEB-PA', 'SEB - PERFECT ATTENDANCE'),
(30, 'SEB-SP', 'SEB - SPORTS'),
(31, 'SEB-S&T', 'SEB - SEMINARS & TRAINING'),
(32, 'SEB-U', 'SEB - UNIFORM'),
(33, 'SECSER', 'SECURITY SERVICES'),
(34, 'TRANSPO', 'TRANSPORTATION & TRAVEL'),
(35, 'DONATION', 'DONATION'),
(36, 'CAO', 'COMPANIES ACTIVITY & OTHERS'),
(37, 'RF', 'REGISTRATION FEES'),
(38, 'SEB-O', 'SEB-OTHERS'),
(39, 'PPE', 'PROPERTY, PLANT AND EQUIPMENT'),
(40, 'WARRANTY ', 'WARRANTY EXPENSE'),
(41, 'FREIGHT SELLING', 'FREIGHT & OTHER SHIPPING CHARGES-SELLING'),
(42, 'FREIGHT OTHERS', 'FREIGHT & OTHER SHPNG CHARGE - OTHERS'),
(45, 'FREIGHT IN', 'FREIGHT-IN & SHIPPING CHARGES'),
(46, 'DOCS ', 'DOCS PROCESSING FEE'),
(47, 'ELECTRICITY ', 'ELECTRICITY '),
(48, 'WATER ', 'WATER '),
(49, 'SECSER ', 'SECURITY SERVICES'),
(50, 'RENT ', 'RENT '),
(51, 'ROYALTY ', 'ROYALTY '),
(52, 'COMM ', 'COMMUNICATION'),
(53, 'PERDIEM-ABROAD', 'PER DIEM & TRAVELNG EXP-ABROAD'),
(54, 'PERDIEM-LOCAL', 'PER DIEM & TRAVELNG EXP-LOCAL'),
(55, 'INSURANCE-SP', 'INSURANCE - SURETY BOND (PREM)'),
(56, 'INSURANCE-SR', 'INSURANCE - SURETY BOND (REIMBURSEABLE)'),
(57, 'INSURANCE-CP', 'INSURANCE - CAR (PREM)'),
(58, 'INSURANCE-OP', 'INSURANCE - OTHERS (PREM)'),
(59, 'INSURANCE-OR', 'INSURANCE - OTHERS (REIMBURSEABLE)'),
(60, 'REP ', 'REPRESENTATION'),
(61, 'DUES ', 'DUES & SUBSCRIPTIONS'),
(62, 'FBT ', 'FRINGE BENEFIT TAX'),
(63, 'XEROX ', 'XEROX AND PRINTING');

-- --------------------------------------------------------

--
-- Table structure for table `tblConversion`
--

CREATE TABLE IF NOT EXISTS `tblConversion` (
  `fldConCode` int(11) NOT NULL AUTO_INCREMENT,
  `fldcurrency` varchar(100) DEFAULT NULL,
  `fldAmount` decimal(65,4) DEFAULT NULL,
  `fldDate` date DEFAULT NULL,
  PRIMARY KEY (`fldConCode`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=30 ;

--
-- Dumping data for table `tblConversion`
--

INSERT INTO `tblConversion` (`fldConCode`, `fldcurrency`, `fldAmount`, `fldDate`) VALUES
(24, 'PHP-USD', 44.8870, '2014-01-01'),
(25, 'USD-JPY', 116.4988, '2014-01-01'),
(26, 'JPY-PHP', 0.3853, '2014-01-01'),
(27, 'PHP-USD', 44.0000, '2015-01-01'),
(28, 'USD-JPY', 110.0000, '2015-01-01'),
(29, 'JPY-PHP', 0.4000, '2015-01-01');

-- --------------------------------------------------------

--
-- Table structure for table `tblDepartment`
--

CREATE TABLE IF NOT EXISTS `tblDepartment` (
  `fldDeptID` int(11) NOT NULL AUTO_INCREMENT,
  `fldDeptCode` varchar(50) DEFAULT NULL,
  `fldDeptDesc` varchar(50) DEFAULT NULL,
  `fldLicense` int(9) NOT NULL,
  PRIMARY KEY (`fldDeptID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=16 ;

--
-- Dumping data for table `tblDepartment`
--

INSERT INTO `tblDepartment` (`fldDeptID`, `fldDeptCode`, `fldDeptDesc`, `fldLicense`) VALUES
(1, 'ALL', 'ALL', 0),
(2, 'PRESIDENT', 'PRESIDENT', 0),
(3, 'HRGA', 'HUMAN RESOURCES GA', 0),
(4, 'ACCTG', 'ACCOUNTING', 0),
(5, 'LOG', 'LOGISTICS', 0),
(6, 'EVAL', 'EVALUATION', 0),
(7, 'FACILITY', 'FACILITY', 0),
(8, 'ENGG', 'ENGINEERING', 0),
(9, 'PROD', 'PRODUCTION', 0),
(10, 'PC', 'PRODUCTION CONTROL', 0),
(11, 'QA', 'QUALITY ASSURANCE', 0),
(12, 'WH', 'WAREHOUSING', 0),
(13, 'FAB', 'FABRICATION', 0),
(14, 'FFCLAMI', 'FFC LAMINATION', 0);

-- --------------------------------------------------------

--
-- Table structure for table `tblHPO`
--

CREATE TABLE IF NOT EXISTS `tblHPO` (
  `fldUC4S` varchar(150) DEFAULT NULL,
  `fldOrderID` int(11) NOT NULL AUTO_INCREMENT,
  `OB_Line` varchar(150) NOT NULL,
  `fldBudRefNum` varchar(30) NOT NULL,
  `fldBudRevNum` varchar(30) DEFAULT NULL,
  `fldTransCode` varchar(150) DEFAULT NULL,
  `fldPONo` varchar(30) DEFAULT NULL,
  `fldPRNo` varchar(30) DEFAULT NULL,
  `fldOrderSupplier` varchar(100) NOT NULL,
  `fldOrderDesc` varchar(100) NOT NULL,
  `fldClassification` varchar(50) NOT NULL,
  `fldOrderDepartment` varchar(50) NOT NULL,
  `fldProcess` varchar(50) NOT NULL,
  `fldCurrency` varchar(15) DEFAULT NULL,
  `fldYen` decimal(65,4) NOT NULL,
  `fldAmountJPY` decimal(65,4) NOT NULL,
  `fldQTY` int(11) DEFAULT NULL,
  `fldUOM` varchar(100) DEFAULT NULL,
  `fldMonthDelivery` date NOT NULL,
  `fldOrderStatus` varchar(20) NOT NULL,
  `fldReason` varchar(300) DEFAULT NULL,
  `fldOrderRemarks` varchar(300) NOT NULL,
  `fldNB` varchar(15) DEFAULT NULL,
  `fldSignature` varchar(50) NOT NULL,
  `fldYear` date DEFAULT NULL,
  `fldMonthOrder` date DEFAULT NULL,
  `fldUID` int(11) DEFAULT NULL,
  `fldMO` date DEFAULT NULL,
  PRIMARY KEY (`fldOrderID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `tblIM`
--

CREATE TABLE IF NOT EXISTS `tblIM` (
  `fldIMID` int(11) NOT NULL AUTO_INCREMENT,
  `fldIMItemCode` varchar(500) NOT NULL,
  `fldIMItemDesc` varchar(500) NOT NULL,
  `fldIMCat` varchar(500) NOT NULL,
  `fldIMUOM` varchar(500) DEFAULT NULL,
  `fldStat` varchar(50) NOT NULL,
  `fldSignature` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`fldIMID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=187 ;

--
-- Dumping data for table `tblIM`
--

INSERT INTO `tblIM` (`fldIMID`, `fldIMItemCode`, `fldIMItemDesc`, `fldIMCat`, `fldIMUOM`, `fldStat`, `fldSignature`) VALUES
(151, 'OS000100A', 'Staple wire  - max staples hd 3ls 13', 'OFFICE SUPPLIES', NULL, 'OPEN', NULL),
(152, 'OS000100B', 'Staple wire #10 - max', 'OFFICE SUPPLIES', NULL, 'OPEN', NULL),
(153, 'OS000100C', 'Staple wire #35', 'OFFICE SUPPLIES', NULL, 'OPEN', NULL),
(154, 'OS000101A', 'Stapler #35', 'OFFICE SUPPLIES', NULL, 'OPEN', NULL),
(155, 'OS000102A', 'Stencil papers', 'OFFICE SUPPLIES', NULL, 'OPEN', NULL),
(156, 'OS000103A', 'Sticker paper, 10s/pack - white', 'OFFICE SUPPLIES', NULL, 'OPEN', NULL),
(157, 'OS000103B', 'Sticker paper, 3s/pack - red', 'OFFICE SUPPLIES', NULL, 'OPEN', NULL),
(158, 'OS000103C', 'Sticker paper, 5s/pack - green', 'OFFICE SUPPLIES', NULL, 'OPEN', NULL),
(159, 'OS000103D', 'Sticker paper, 5s/pack - pink', 'OFFICE SUPPLIES', NULL, 'OPEN', NULL),
(160, 'OS000103E', 'Sticker paper, 5s/pack - yellow', 'OFFICE SUPPLIES', NULL, 'OPEN', NULL),
(161, 'OS000103F', 'Sticker paper white, glossy', 'OFFICE SUPPLIES', NULL, 'OPEN', NULL),
(162, 'OS000103G', 'STICKER PAPER WHITE, MATTE', 'OFFICE SUPPLIES', NULL, 'OPEN', NULL),
(163, 'OS000104A', 'Tag board', 'OFFICE SUPPLIES', NULL, 'OPEN', NULL),
(164, 'OS000104B', 'TAG BOARD A4 WHITE', 'OFFICE SUPPLIES', NULL, 'OPEN', NULL),
(165, 'OS000105A', 'Tape dispenser', 'OFFICE SUPPLIES', NULL, 'OPEN', NULL),
(166, 'OS000106A', 'Thumbtacks', 'OFFICE SUPPLIES', NULL, 'OPEN', NULL),
(167, 'OS000107A', 'Time card', 'OFFICE SUPPLIES', NULL, 'OPEN', NULL),
(168, 'OS000108A', 'Tray in & out - blue', 'OFFICE SUPPLIES', NULL, 'OPEN', NULL),
(169, 'SP-SA-0468', 'INDICATOR SWITCH (AH164-ZTWE3)', 'SPAREPARTS INVTY- ENGINEERING', NULL, 'OPEN', NULL),
(170, 'SP-SA-0469', 'INDICATOR SWITCH (AH164-ZTYE3)', 'SPAREPARTS INVTY- ENGINEERING', NULL, 'OPEN', NULL),
(171, 'SP-SA-0521', 'VZ2130-5LZ-M5 SOLENOID VALVE', 'SPAREPARTS INVTY- ENGINEERING', NULL, 'OPEN', NULL),
(172, 'SP-UH-001', 'M0026 USW HORN', 'SPAREPARTS INVTY- ENGINEERING', NULL, 'OPEN', NULL),
(173, 'SP-UH-002', 'M0039 USW HORN (REQUEST FOR NEW CROWN)', 'SPAREPARTS INVTY- ENGINEERING', NULL, 'OPEN', NULL),
(174, 'SP-UH-003', 'M0054 USW HORN', 'SPAREPARTS INVTY- ENGINEERING', NULL, 'OPEN', NULL),
(175, 'SP-AC-0007', 'D-A93VL', 'SPAREPARTS INVTY- ENGINEERING', NULL, 'OPEN', NULL),
(176, 'SP-AC-0008', 'D-Y59BL', 'SPAREPARTS INVTY- ENGINEERING', NULL, 'OPEN', NULL),
(177, 'SP-AC-0009', 'D-Y69A', 'SPAREPARTS INVTY- ENGINEERING', NULL, 'OPEN', NULL),
(178, 'SP-AC-0010', 'D-M9B AUTO SWITCH SENSOR', 'SPAREPARTS INVTY- ENGINEERING', NULL, 'OPEN', NULL),
(179, 'SP-AC-0011', 'D-M9BVL SENSOR', 'SPAREPARTS INVTY- ENGINEERING', NULL, 'OPEN', NULL),
(180, 'SP-AC-0012', 'CU16-15S CYLINDER', 'SPAREPARTS INVTY- ENGINEERING', NULL, 'OPEN', NULL),
(181, 'SP-AC-0013', 'CUK20-15S', 'SPAREPARTS INVTY- ENGINEERING', NULL, 'OPEN', NULL),
(182, 'SP-AC-0014', 'CU25-15D', 'SPAREPARTS INVTY- ENGINEERING', NULL, 'OPEN', NULL),
(183, 'SP-AC-0015', 'CDU10-10D', 'SPAREPARTS INVTY- ENGINEERING', NULL, 'OPEN', NULL),
(184, 'SP-AC-0016', 'CDU10-15D', 'SPAREPARTS INVTY- ENGINEERING', NULL, 'OPEN', NULL),
(185, 'SP-AC-0017', 'CDU20-5D', 'SPAREPARTS INVTY- ENGINEERING', NULL, 'REMOVE', NULL),
(186, 'SP-AC-0018', 'CDU20-25D', 'SPAREPARTS INVTY- ENGINEERING', NULL, 'REMOVE', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `tblItemCategory`
--

CREATE TABLE IF NOT EXISTS `tblItemCategory` (
  `fldCatID` int(11) NOT NULL AUTO_INCREMENT,
  `fldCatCode` varchar(500) NOT NULL,
  `fldCatDesc` varchar(500) NOT NULL,
  `fldSignature` varchar(50) NOT NULL,
  PRIMARY KEY (`fldCatID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=10 ;

--
-- Dumping data for table `tblItemCategory`
--

INSERT INTO `tblItemCategory` (`fldCatID`, `fldCatCode`, `fldCatDesc`, `fldSignature`) VALUES
(3, 'OS', 'OFFICE SUPPLIES', ''),
(4, 'SP', 'SPAREPARTS INVTY- ENGINEERING', ''),
(5, 'PKM', 'PACKAGING MATERIAL', ''),
(6, 'FS', 'FACTORY SUPPLIES', ''),
(7, 'FC', 'SPAREPARTS INVTY-FABRICATION', ''),
(8, 'FM', 'SPAREPARTS INVTY-FFC LAMINATION', ''),
(9, 'OT', 'FIXED ASSET', '');

-- --------------------------------------------------------

--
-- Table structure for table `tblMAI`
--

CREATE TABLE IF NOT EXISTS `tblMAI` (
  `fldMAIID` int(11) NOT NULL AUTO_INCREMENT,
  `fldTransCode` varchar(150) DEFAULT NULL,
  `fldBudRefNum` varchar(30) DEFAULT NULL,
  `fldICode` varchar(40) DEFAULT NULL,
  `fldDesc` varchar(500) DEFAULT NULL,
  `fldQTY` int(11) DEFAULT NULL,
  `fldUnit` varchar(3) DEFAULT NULL,
  `fldUPrice` decimal(65,4) DEFAULT NULL,
  `fldTotalCost` decimal(65,4) DEFAULT NULL,
  `fldYen` decimal(65,2) DEFAULT NULL,
  `fldCurrency` varchar(15) DEFAULT NULL,
  `fldMonthDelivery` date DEFAULT NULL,
  `fldStat` varchar(50) DEFAULT NULL,
  `fldSignature` varchar(150) DEFAULT NULL,
  `fldUID` int(11) DEFAULT NULL,
  `fldMO` date DEFAULT NULL,
  PRIMARY KEY (`fldMAIID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Triggers `tblMAI`
--
DROP TRIGGER IF EXISTS `triggerJPYMAI`;
DELIMITER //
CREATE TRIGGER `triggerJPYMAI` BEFORE INSERT ON `tblMAI`
 FOR EACH ROW SET NEW.fldYen =
CASE 
 WHEN new.fldCurrency = 'YEN' then new.fldTotalCost
 WHEN new.fldCurrency = 'USD' then new.fldTotalCost * (select fldAmount from tblConversion where Year(fldDate) = year(new.fldMO) and fldcurrency = 'USD-YEN') 
 WHEN new.fldCurrency = 'PHP' then new.fldTotalCost / (select fldAmount from tblConversion where Year(fldDate) = year(new.fldMO) and fldcurrency = 'YEN-PHP') 
 END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tblMOI`
--

CREATE TABLE IF NOT EXISTS `tblMOI` (
  `fldUC4S` varchar(150) DEFAULT NULL,
  `fldMOIID` int(11) NOT NULL AUTO_INCREMENT,
  `fldTransCode` varchar(150) NOT NULL,
  `fldBudRefNum` varchar(30) NOT NULL,
  `fldICode` varchar(40) NOT NULL,
  `fldDesc` varchar(500) NOT NULL,
  `fldQTY` decimal(65,6) NOT NULL,
  `fldQTYSIN` decimal(65,6) NOT NULL,
  `fldQTYSOUT` decimal(65,6) NOT NULL,
  `fldQTYEB` decimal(65,6) NOT NULL,
  `fldUnit` varchar(3) NOT NULL,
  `fldMonthDelivery` date DEFAULT NULL,
  `fldStat` varchar(50) DEFAULT NULL,
  `fldSignature` varchar(150) DEFAULT NULL,
  `fldUID` int(11) DEFAULT NULL,
  `fldMO` date DEFAULT NULL,
  `fldRS` varchar(100) DEFAULT NULL,
  `fldClass` varchar(50) NOT NULL,
  `fldDept` varchar(50) NOT NULL,
  `fldProcess` varchar(50) NOT NULL,
  `fldRate` decimal(65,6) DEFAULT NULL,
  PRIMARY KEY (`fldMOIID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=367 ;

--
-- Triggers `tblMOI`
--
DROP TRIGGER IF EXISTS `triggerJPY`;
DELIMITER //
CREATE TRIGGER `triggerJPY` BEFORE INSERT ON `tblMOI`
 FOR EACH ROW Begin
SET NEW.fldUC4S =(select fldUC4S from tblOrder where fldTransCode = new.fldTransCode);
SET NEW.fldQTYEB = (NEW.fldQTY);
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tblMonth`
--

CREATE TABLE IF NOT EXISTS `tblMonth` (
  `fldMonthID` int(11) NOT NULL AUTO_INCREMENT,
  `fldCode` int(11) NOT NULL,
  `fldMonth` varchar(250) NOT NULL,
  PRIMARY KEY (`fldMonthID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=13 ;

--
-- Dumping data for table `tblMonth`
--

INSERT INTO `tblMonth` (`fldMonthID`, `fldCode`, `fldMonth`) VALUES
(1, 1, 'January'),
(2, 2, 'February'),
(3, 3, 'March'),
(4, 4, 'April'),
(5, 5, 'May'),
(6, 6, 'June'),
(7, 7, 'July'),
(8, 8, 'August'),
(9, 9, 'September'),
(10, 10, 'October'),
(11, 11, 'November'),
(12, 12, 'December');

-- --------------------------------------------------------

--
-- Table structure for table `tblOrder`
--

CREATE TABLE IF NOT EXISTS `tblOrder` (
  `fldUC4S` varchar(150) DEFAULT NULL,
  `fldOrderID` int(11) NOT NULL AUTO_INCREMENT,
  `fldBudRefNum` varchar(30) NOT NULL,
  `fldBudRevNum` varchar(30) DEFAULT NULL,
  `fldTransCode` varchar(150) DEFAULT NULL,
  `fldPRNo` varchar(30) DEFAULT NULL,
  `fldOrderDesc` varchar(100) NOT NULL,
  `fldClassification` varchar(50) NOT NULL,
  `fldOrderDepartment` varchar(50) NOT NULL,
  `fldProcess` varchar(50) NOT NULL,
  `fldQTY` decimal(65,6) DEFAULT NULL,
  `fldUOM` varchar(100) DEFAULT NULL,
  `fldMonthDelivery` date NOT NULL,
  `fldDN` date NOT NULL,
  `fldOrderStatus` varchar(20) NOT NULL,
  `fldReason` varchar(500) DEFAULT NULL,
  `fldOrderRemarks` varchar(500) NOT NULL,
  `fldNB` varchar(15) DEFAULT NULL,
  `fldSignature` varchar(50) NOT NULL,
  `fldYear` date DEFAULT NULL,
  `fldMonthOrder` date DEFAULT NULL,
  `fldUID` int(11) DEFAULT NULL,
  `fldMO` date DEFAULT NULL,
  `fldEOA` decimal(65,6) NOT NULL,
  `fldEJPY` decimal(65,6) NOT NULL,
  `fldEC` varchar(3) NOT NULL,
  `fldTOPRA` decimal(65,6) NOT NULL,
  `fldTDOPRA` decimal(65,6) NOT NULL,
  `fldRBLPR` decimal(65,6) NOT NULL,
  `fldRDBLPR` decimal(65,6) NOT NULL,
  `fldRB` decimal(65,6) NOT NULL,
  `fldRDB` decimal(65,6) NOT NULL,
  `fldPrint` varchar(3) DEFAULT NULL,
  `fldRN` varchar(150) DEFAULT NULL,
  `fldForcePO` varchar(3) DEFAULT NULL,
  `fldRate` decimal(65,6) DEFAULT NULL,
  PRIMARY KEY (`fldOrderID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=312 ;

--
-- Triggers `tblOrder`
--
DROP TRIGGER IF EXISTS `triggerNOBUDGETOrder`;
DELIMITER //
CREATE TRIGGER `triggerNOBUDGETOrder` BEFORE INSERT ON `tblOrder`
 FOR EACH ROW Begin
SET NEW.fldNB =
CASE 
 WHEN left(new.fldBudRefNum,9) = 'NO BUDGET' then 'YES'
 WHEN left(new.fldBudRefNum,9) != 'NO BUDGET' then 'NO'
END;
SET NEW.fldUC4S =concat('UC4S',(SELECT MAX(fldOrderID)+1 FROM tblOrder),new.fldOrderDepartment,year(new.fldMonthOrder));
IF new.fldPrNo = '' then
SET NEW.fldPrNo = (SELECT concat(PR.fldYear,'-',PR.fldPRKey) from tblPRNo PR
where PR.fldTransCode = NEW.fldTransCode);
end if;
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tblPO`
--

CREATE TABLE IF NOT EXISTS `tblPO` (
  `fldPOID` int(11) NOT NULL AUTO_INCREMENT,
  `fldIndex` int(11) NOT NULL,
  `OB_Line` varchar(150) NOT NULL,
  `fldPONO` int(11) DEFAULT NULL,
  `fldCPONo` varchar(500) DEFAULT NULL,
  `fldSupplier` varchar(50) NOT NULL,
  `fldVCode` varchar(150) DEFAULT NULL,
  `fldMOrdered` date NOT NULL,
  `fldDDate` date NOT NULL,
  `fldStat` varchar(15) DEFAULT NULL,
  `fldCurrency` varchar(5) DEFAULT NULL,
  `fldDiscount` decimal(65,6) NOT NULL,
  `fldDAmount` decimal(65,6) NOT NULL,
  `fldTPO` decimal(64,6) NOT NULL,
  `OB_POAmt` decimal(65,6) NOT NULL,
  `fldRemarks` varchar(500) NOT NULL,
  `fldSignature` varchar(150) DEFAULT NULL,
  `fldCPOSignature` varchar(100) DEFAULT NULL,
  `fldCancel` varchar(3) DEFAULT NULL,
  `fldForcePO` varchar(3) DEFAULT NULL,
  `fldRate` decimal(65,6) DEFAULT NULL,
  PRIMARY KEY (`fldPOID`,`OB_Line`,`fldIndex`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=340 ;

-- --------------------------------------------------------

--
-- Table structure for table `tblPOI`
--

CREATE TABLE IF NOT EXISTS `tblPOI` (
  `OB_Detail_ID` int(11) NOT NULL,
  `fldUC4S` varchar(150) DEFAULT NULL,
  `fldPONO` int(11) DEFAULT NULL,
  `fldCPONo` varchar(500) DEFAULT NULL,
  `fldRD` varchar(500) DEFAULT NULL,
  `fldQTYSOut` decimal(65,6) NOT NULL,
  `OB_Line` varchar(150) DEFAULT NULL,
  `fldTransCode` varchar(150) NOT NULL,
  `fldBudRefNum` varchar(30) NOT NULL,
  `fldPRNo` varchar(150) DEFAULT NULL,
  `fldICode` varchar(40) NOT NULL,
  `fldDesc` varchar(500) NOT NULL,
  `fldQTY` decimal(65,6) NOT NULL,
  `fldUnit` varchar(3) NOT NULL,
  `fldUPrice` decimal(65,6) NOT NULL,
  `fldTotalCost` decimal(65,6) NOT NULL,
  `fldYen` decimal(65,6) DEFAULT NULL,
  `fldCurrency` varchar(15) DEFAULT NULL,
  `fldMonthDelivery` date DEFAULT NULL,
  `fldStat` varchar(50) DEFAULT NULL,
  `fldSignature` varchar(150) DEFAULT NULL,
  `fldUID` int(11) DEFAULT NULL,
  `fldMO` date DEFAULT NULL,
  `fldPOIID` int(11) NOT NULL AUTO_INCREMENT,
  `fldMOIID` int(11) NOT NULL,
  `fldDept` varchar(150) DEFAULT NULL,
  `fldClass` varchar(50) DEFAULT NULL,
  `fldIndex` int(11) NOT NULL,
  `fldCPOSignature` varchar(100) DEFAULT NULL,
  `fldRemarks1` varchar(500) DEFAULT NULL,
  `fldRemarks2` varchar(500) DEFAULT NULL,
  `fldCancel` varchar(3) DEFAULT NULL,
  `fldDrop` varchar(3) NOT NULL,
  `fldForcePO` varchar(3) DEFAULT NULL,
  `fldRate` decimal(65,6) DEFAULT NULL,
  `fldYenSap` decimal(65,6) DEFAULT NULL,
  PRIMARY KEY (`fldPOIID`,`fldIndex`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=354 ;

--
-- Triggers `tblPOI`
--
DROP TRIGGER IF EXISTS `triggerJPYinPOI`;
DELIMITER //
CREATE TRIGGER `triggerJPYinPOI` BEFORE INSERT ON `tblPOI`
 FOR EACH ROW Begin
SET NEW.fldYen =
CASE 
 WHEN new.fldCurrency = 'JPY' then (new.fldUPrice * (new.fldQTY - new.fldQTYSOut)) - ((new.fldUPrice * (new.fldQTY - new.fldQTYSOut)) * (select fldDiscount  / 100 from tblPO where OB_Line =new.OB_Line and fldStat != 'CLOSE'))
 WHEN new.fldCurrency = 'USD' then ((new.fldUPrice * (new.fldQTY - new.fldQTYSOut)) * (select fldAmount from tblConversion where Year(fldDate) = year(new.fldMO) and fldcurrency = 'USD-JPY'))-(((new.fldUPrice * (new.fldQTY - new.fldQTYSOut)) * (select fldAmount from tblConversion where Year(fldDate) = year(new.fldMO) and fldcurrency = 'USD-JPY')) * (select fldDiscount  / 100 from tblPO where OB_Line =new.OB_Line and fldStat != 'CLOSE'))
 WHEN new.fldCurrency = 'PHP' then ((new.fldUPrice * (new.fldQTY - new.fldQTYSOut)) / (select fldAmount from tblConversion where Year(fldDate) = year(new.fldMO) and fldcurrency = 'JPY-PHP')) -(((new.fldUPrice * (new.fldQTY - new.fldQTYSOut)) / (select fldAmount from tblConversion where Year(fldDate) = year(new.fldMO) and fldcurrency = 'JPY-PHP')) * (select fldDiscount  / 100 from tblPO where OB_Line =new.OB_Line and fldStat != 'CLOSE'))
END;
SET NEW.fldYenSap =
CASE 
 WHEN new.fldCurrency = 'JPY' then (new.fldUPrice * (new.fldQTY - new.fldQTYSOut))
 - ((new.fldUPrice * (new.fldQTY - new.fldQTYSOut))
 * (select fldDiscount  / 100 from tblPO where OB_Line =new.OB_Line and fldStat != 'CLOSE'))


 WHEN new.fldCurrency = 'USD' then ((new.fldUPrice * (new.fldQTY - new.fldQTYSOut))
 * new.fldRate)
-(((new.fldUPrice * (new.fldQTY - new.fldQTYSOut)) * 
new.fldRate)
 * (select fldDiscount  / 100 from tblPO where OB_Line =new.OB_Line and fldStat != 'CLOSE'))


 WHEN new.fldCurrency = 'PHP' then ((new.fldUPrice * (new.fldQTY - new.fldQTYSOut)) * 
new.fldRate)
 -(((new.fldUPrice * (new.fldQTY - new.fldQTYSOut)) * new.fldRate)
 * (select fldDiscount  / 100 from tblPO where OB_Line =new.OB_Line and fldStat != 'CLOSE'))
END;
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tblPRNo`
--

CREATE TABLE IF NOT EXISTS `tblPRNo` (
  `fldPRKey` int(6) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `fldYear` year(4) NOT NULL,
  `fldTransCode` varchar(150) NOT NULL,
  `fldDept` varchar(50) NOT NULL,
  PRIMARY KEY (`fldPRKey`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `tblProcess`
--

CREATE TABLE IF NOT EXISTS `tblProcess` (
  `fldPCode` int(11) NOT NULL AUTO_INCREMENT,
  `fldProcessCode` varchar(50) NOT NULL,
  `fldProcessDesc` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`fldPCode`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=10 ;

--
-- Dumping data for table `tblProcess`
--

INSERT INTO `tblProcess` (`fldPCode`, `fldProcessCode`, `fldProcessDesc`) VALUES
(2, 'SRC', NULL),
(3, 'FFC ASSEMBLY', NULL),
(4, 'INJECTION', NULL),
(5, 'WAREHOUSE', NULL),
(6, 'PIGTAIL', NULL),
(7, 'TERMINAL CRIMPING', NULL),
(8, 'FFC MANUFACTURING', NULL),
(9, 'COMMON', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `tblQTY`
--

CREATE TABLE IF NOT EXISTS `tblQTY` (
  `fldqtyno` int(11) NOT NULL AUTO_INCREMENT,
  `fldBudRefNum` varchar(50) NOT NULL,
  `fldIn` int(11) NOT NULL,
  `fldOut` int(11) NOT NULL,
  `fldBalance` int(11) NOT NULL,
  PRIMARY KEY (`fldqtyno`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `tblQTY`
--

INSERT INTO `tblQTY` (`fldqtyno`, `fldBudRefNum`, `fldIn`, `fldOut`, `fldBalance`) VALUES
(2, 'MIS', 11, 1, 10),
(3, 'hrga', 10, 8, 2);

--
-- Triggers `tblQTY`
--
DROP TRIGGER IF EXISTS `triggerbalance`;
DELIMITER //
CREATE TRIGGER `triggerbalance` BEFORE INSERT ON `tblQTY`
 FOR EACH ROW BEGIN
if new.fldBalance = 0 then
SET NEW.fldBalance = NEW.fldIn - NEW.fldOut;
elseif new.fldBalance = 0 then
SET NEW.fldBalance = NEW.fldIn - NEW.fldOut;
end if;
END
//
DELIMITER ;
DROP TRIGGER IF EXISTS `triggerbalanceUpdate`;
DELIMITER //
CREATE TRIGGER `triggerbalanceUpdate` BEFORE UPDATE ON `tblQTY`
 FOR EACH ROW SET NEW.fldBalance = NEW.fldIn - NEW.fldOut
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tblRevision`
--

CREATE TABLE IF NOT EXISTS `tblRevision` (
  `fldRevID` int(11) NOT NULL AUTO_INCREMENT,
  `fldRevNum` int(11) NOT NULL,
  `fldBudRevNum` varchar(50) DEFAULT NULL,
  `fldBudRefNum` varchar(50) NOT NULL,
  `fldDesc` varchar(500) DEFAULT NULL,
  `fldCurrency` varchar(15) DEFAULT NULL,
  `fldYen` decimal(65,4) NOT NULL,
  `fldQTY` decimal(65,4) DEFAULT NULL,
  `fldUOM` varchar(50) DEFAULT NULL,
  `fldSOU` date DEFAULT NULL,
  `fldMRevise` date DEFAULT NULL,
  `fldOrgAmount` int(11) DEFAULT NULL,
  `fldStat` varchar(10) NOT NULL,
  `fldRevAmount` decimal(65,4) DEFAULT NULL,
  `fldRemBal` decimal(65,4) DEFAULT NULL,
  `FldRemarks` longtext NOT NULL,
  `fldReviseBy` varchar(100) DEFAULT NULL,
  `fldNB` varchar(15) DEFAULT NULL,
  `fldUID` int(11) DEFAULT NULL,
  PRIMARY KEY (`fldRevID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=1226 ;

--
-- Triggers `tblRevision`
--
DROP TRIGGER IF EXISTS `triggerNOBUDGETR`;
DELIMITER //
CREATE TRIGGER `triggerNOBUDGETR` BEFORE INSERT ON `tblRevision`
 FOR EACH ROW SET NEW.fldNB =
CASE 
 WHEN left(new.fldBudRefNum,9) = 'NO BUDGET' then 'YES'
 WHEN left(new.fldBudRefNum,9) != 'NO BUDGET' then 'NO'
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tblRevisionCode`
--

CREATE TABLE IF NOT EXISTS `tblRevisionCode` (
  `fldRevCodeID` int(11) NOT NULL AUTO_INCREMENT,
  `fldBudgetRefNo` varchar(100) NOT NULL,
  `fldRevCode` int(11) NOT NULL,
  `fldMEdited` date NOT NULL,
  `fldEditby` varchar(100) NOT NULL,
  PRIMARY KEY (`fldRevCodeID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `tblSettings`
--

CREATE TABLE IF NOT EXISTS `tblSettings` (
  `fldProID` int(11) NOT NULL AUTO_INCREMENT,
  `fldProName` varchar(500) NOT NULL,
  `fldLimit` int(11) NOT NULL,
  PRIMARY KEY (`fldProID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `tblSettings`
--

INSERT INTO `tblSettings` (`fldProID`, `fldProName`, `fldLimit`) VALUES
(1, 'Sync From SAP - BAP', 1),
(2, 'System Version', 1),
(3, 'Upload PO', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tblSubIRReport`
--

CREATE TABLE IF NOT EXISTS `tblSubIRReport` (
  `fldIC` varchar(250) NOT NULL,
  `fldDesc` text NOT NULL,
  `fldNewPrice` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblSubIRReport`
--

INSERT INTO `tblSubIRReport` (`fldIC`, `fldDesc`, `fldNewPrice`) VALUES
('PKM081', 'sadfasdfasdf jkasdhfklhaskldjfhkl', 1000.00);

-- --------------------------------------------------------

--
-- Table structure for table `tblUPO`
--

CREATE TABLE IF NOT EXISTS `tblUPO` (
  `fldUPONo` int(11) NOT NULL AUTO_INCREMENT,
  `fldBudRefNum` varchar(50) NOT NULL,
  `fldDept` varchar(50) NOT NULL,
  `fldCurrency` varchar(3) DEFAULT NULL,
  `fldOAmount` decimal(65,6) DEFAULT NULL,
  `fldJPY` decimal(65,6) NOT NULL,
  `fldJPYBAP` decimal(65,6) DEFAULT NULL,
  `fldForex` decimal(65,6) DEFAULT NULL,
  `fldPONo` varchar(200) NOT NULL,
  `fldUDate` date NOT NULL,
  `fldDDate` date NOT NULL,
  `fldVcode` varchar(150) DEFAULT NULL,
  `fldSupplier` varchar(500) DEFAULT NULL,
  `fldStat` varchar(15) DEFAULT NULL,
  `fldClass` varchar(250) NOT NULL,
  PRIMARY KEY (`fldUPONo`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=18 ;

--
-- Triggers `tblUPO`
--
DROP TRIGGER IF EXISTS `TriggerToday`;
DELIMITER //
CREATE TRIGGER `TriggerToday` BEFORE INSERT ON `tblUPO`
 FOR EACH ROW Begin
SET NEW.fldUDate  = NOW()
;
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tblUser`
--

CREATE TABLE IF NOT EXISTS `tblUser` (
  `fldUID` int(10) NOT NULL AUTO_INCREMENT,
  `fldUsername` varchar(50) NOT NULL,
  `fldPassword` varchar(50) NOT NULL,
  `fldName` varchar(100) NOT NULL,
  `fldDept` varchar(50) NOT NULL,
  `fldUserlvl` varchar(50) NOT NULL,
  `fldDateAdded` date NOT NULL,
  PRIMARY KEY (`fldUID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=27 ;

--
-- Dumping data for table `tblUser`
--

INSERT INTO `tblUser` (`fldUID`, `fldUsername`, `fldPassword`, `fldName`, `fldDept`, `fldUserlvl`, `fldDateAdded`) VALUES
(1, 'Admin', '0103050e86e3a9ff3202c6ddd1b845ae', 'MIS', 'HRGA', 'SUPERADMIN', '2014-09-09'),
(2, 'cihvbox', 'c4ca4238a0b923820dcc509a6f75849b', 'VHIC SARINGAN', 'HRGA', 'SUPERADMIN', '2014-09-09'),
(3, 'calersky', '08b5411f848a2581a41672a759c87380', 'CARLO SOTOMAYOR', 'HRGA', 'SUPERADMIN', '2014-09-09'),
(4, 'mark', 'c4ca4238a0b923820dcc509a6f75849b', 'MARK VIERNEZA', 'HRGA', 'SUPERADMIN', '2014-09-09'),
(5, '1001650', '1d6fea2e7d5f4839506d70b265d42496', 'JENNYLYN MENDOZA', 'ACCTG', 'SUPERADMIN', '2015-04-06'),
(6, '1401835', '08b5411f848a2581a41672a759c87380', 'OLIVIA DE SAGUN', 'ACCTG', 'USER', '2015-04-06'),
(7, '1401818', '08b5411f848a2581a41672a759c87380', 'ANNABELLE SANTOS', 'HRGA', 'USER', '2015-04-06'),
(8, '0701533', '08b5411f848a2581a41672a759c87380', 'GERLYN CERNIAS', 'EVAL', 'USER', '2015-04-06'),
(9, '0801586', '08b5411f848a2581a41672a759c87380', 'MADY MARIANO', 'FAB', 'USER', '2015-04-06'),
(10, '0801574', '08b5411f848a2581a41672a759c87380', 'JOY ARAMBULO', 'ENGG', 'USER', '2015-04-06'),
(11, '0000085', '08b5411f848a2581a41672a759c87380', 'HELEN MAMALAYAN', 'PROD', 'USER', '2015-04-06'),
(12, '0300828', '08b5411f848a2581a41672a759c87380', 'TERESA BARRIENTOS', 'QA', 'USER', '2015-04-06'),
(13, '1101688', '08b5411f848a2581a41672a759c87380', 'JEWEL ODEJAR', 'FACILITY', 'USER', '2015-04-06'),
(14, '1001668', '08b5411f848a2581a41672a759c87380', 'ELOISA ABULENCIA', 'PC', 'USER', '2015-04-06'),
(15, '0401112', '08b5411f848a2581a41672a759c87380', 'CRISTINA RAGUINDIN', 'PC', 'PROFESSIONAL', '2015-04-06'),
(16, '1201701', '08b5411f848a2581a41672a759c87380', 'CHARINA CAMARA', 'LOG', 'USER', '2015-04-06'),
(17, '0501149', '08b5411f848a2581a41672a759c87380', 'MARJIE TRINIDAD', 'PC', 'PROFESSIONAL', '2015-04-06'),
(18, '0701519', '08b5411f848a2581a41672a759c87380', 'MAAN ARELA', 'PC', 'PROFESSIONAL', '2015-04-06'),
(19, '1101686', '08b5411f848a2581a41672a759c87380', 'JENNELYN UMANDAL', 'PC', 'PROFESSIONAL', '2015-04-06'),
(20, '0300758', '08b5411f848a2581a41672a759c87380', 'IMEE COMIA', 'ACCTG', 'MANAGER', '2015-04-10'),
(21, '1001677', '08b5411f848a2581a41672a759c87380', 'MA. LOURDES CAGUICLA', 'HRGA', 'MANAGER', '2015-04-10'),
(22, '0701533', '08b5411f848a2581a41672a759c87380', 'SUNNY GARCIA', 'EVAL', 'MANAGER', '2015-04-10'),
(23, '9800002', '08b5411f848a2581a41672a759c87380', 'MHEL TADURAN', 'ENGG', 'MANAGER', '2015-04-10'),
(24, '0300828', '08b5411f848a2581a41672a759c87380', 'SETH FELIX', 'QA', 'MANAGER', '2015-04-10'),
(25, '1101688', '08b5411f848a2581a41672a759c87380', 'ALEX BARBON', 'FACILITY', 'MANAGER', '2015-04-10'),
(26, '0701427', '08b5411f848a2581a41672a759c87380', 'MALOU PELAGIO', 'PC', 'MANAGER', '2015-04-10');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
