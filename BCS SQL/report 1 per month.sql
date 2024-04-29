select tr3.fldBudID, year(tr3.fldMonthBudgeted) as Byear, tr3.fldBCRefNo, tr3.fldDept, tr3.fldStatus, tr3.fldCurrency, tr3.fldAmount, 
(CASE 
WHEN tr3.fldCurrency = 'USD' then (select if(tr2.fldAmount is not null,tr2.fldAmount,0) from tblBudget tr2 where tr2.fldStatus != 'CLOSE' AND tr2.fldBudID = tr3.fldBudID) 
WHEN tr3.fldCurrency = 'PHP' then (select if(tr2.fldAmount is not null,tr2.fldAmount,0) from tblBudget tr2 where tr2.fldStatus != 'CLOSE' AND tr2.fldBudID = tr3.fldBudID) / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'PHP-USD') 
WHEN tr3.fldCurrency = 'JPY' then (select if(tr2.fldAmount is not null,tr2.fldAmount,0) from tblBudget tr2 where tr2.fldStatus != 'CLOSE' AND tr2.fldBudID = tr3.fldBudID) / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'USD-JPY') END) as USD, 
(CASE 
WHEN tr3.fldCurrency = 'PHP' then (select if(tr2.fldAmount is not null,tr2.fldAmount,0) from tblBudget tr2 where tr2.fldStatus != 'CLOSE' AND tr2.fldBudID = tr3.fldBudID) 
WHEN tr3.fldCurrency = 'USD' then (select if(tr2.fldAmount is not null,tr2.fldAmount,0) from tblBudget tr2 where tr2.fldStatus != 'CLOSE' AND tr2.fldBudID = tr3.fldBudID) * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'PHP-USD') 
WHEN tr3.fldCurrency = 'JPY' then (select if(tr2.fldAmount is not null,tr2.fldAmount,0) from tblBudget tr2 where tr2.fldStatus != 'CLOSE' AND tr2.fldBudID = tr3.fldBudID) * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'JPY-PHP') END) as PHP, 
(CASE 
WHEN tr3.fldCurrency = 'JPY' then (select if(tr2.fldAmount is not null,tr2.fldAmount,0) from tblBudget tr2 where tr2.fldStatus != 'CLOSE' AND tr2.fldBudID = tr3.fldBudID) 
WHEN tr3.fldCurrency = 'USD' then (select if(tr2.fldAmount is not null,tr2.fldAmount,0) from tblBudget tr2 where tr2.fldStatus != 'CLOSE' AND tr2.fldBudID = tr3.fldBudID) * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'USD-JPY') 
WHEN tr3.fldCurrency = 'PHP' then (select if(tr2.fldAmount is not null,tr2.fldAmount,0) from tblBudget tr2 where tr2.fldStatus != 'CLOSE' AND tr2.fldBudID = tr3.fldBudID) / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'JPY-PHP') END) as JPY, 

tr3.fldClass,tr3.fldProcess,tr3.fldUOM,
(If (fldQTY is not NULL, fldQTY, 0)) as fldQTY,tr3.fldDesc,tr3.fldSOU,tr3.fldMonthBudgeted, 

(select tr4.fldAmount from tblBudget tr4 where month(tr4.fldMonthBudgeted) = '01' AND tr4.fldBudID = tr3.fldBudID) as 'January',
(select tr4.fldAmount from tblBudget tr4 where month(tr4.fldMonthBudgeted) = '02' AND tr4.fldBudID = tr3.fldBudID) as 'February',
(select tr4.fldAmount from tblBudget tr4 where month(tr4.fldMonthBudgeted) = '03' AND tr4.fldBudID = tr3.fldBudID) as 'March',
(select tr4.fldAmount from tblBudget tr4 where month(tr4.fldMonthBudgeted) = '04' AND tr4.fldBudID = tr3.fldBudID) as 'April',
(select tr4.fldAmount from tblBudget tr4 where month(tr4.fldMonthBudgeted) = '05' AND tr4.fldBudID = tr3.fldBudID) as 'May',
(select tr4.fldAmount from tblBudget tr4 where month(tr4.fldMonthBudgeted) = '06' AND tr4.fldBudID = tr3.fldBudID) as 'June',
(select tr4.fldAmount from tblBudget tr4 where month(tr4.fldMonthBudgeted) = '07' AND tr4.fldBudID = tr3.fldBudID) as 'July',
(select tr4.fldAmount from tblBudget tr4 where month(tr4.fldMonthBudgeted) = '08' AND tr4.fldBudID = tr3.fldBudID) as 'August',
(select tr4.fldAmount from tblBudget tr4 where month(tr4.fldMonthBudgeted) = '09' AND tr4.fldBudID = tr3.fldBudID) as 'September',
(select tr4.fldAmount from tblBudget tr4 where month(tr4.fldMonthBudgeted) = '10' AND tr4.fldBudID = tr3.fldBudID) as 'October',
(select tr4.fldAmount from tblBudget tr4 where month(tr4.fldMonthBudgeted) = '11' AND tr4.fldBudID = tr3.fldBudID) as 'November',
(select tr4.fldAmount from tblBudget tr4 where month(tr4.fldMonthBudgeted) = '12' AND tr4.fldBudID = tr3.fldBudID) as 'December'

from tblBudget tr3 where fldStatus != 'DELETED' ORDER BY tr3.fldBudID Desc