
ALTER PROCEDURE [dbo].TickTrade4
AS
BEGIN


CREATE TABLE #TEMP1(
Id int IDENTITY(1,1) NOT NULL,
SecurityId int,
Ticker varchar(20),
CUSIP varchar(20),
ISIN varchar(20),
SEDOL varchar(20),
Price int,
TransactionType varchar(20));

CREATE TABLE #TEMP2(
 Id int IDENTITY(1,1) NOT NULL,
 SecurityId int,
 Position int
);

insert into #TEMP1
select t.SecurityId,Ticker,CUSIP,ISIN,SEDOL,Price,TransactionType from Securities as s INNER JOIN Trades as t ON s.SecurityId = t.SecurityId;

select * from #Temp1;
UPDATE #TEMP1
SET Price = Price*(-1)
WHERE TransactionType ='Sell'


insert into #TEMP2
select SecurityId, Sum(Price) from #TEMP1 Group BY SecurityId;


select s.Ticker,s.CUSIP,s.ISIN,s.SEDOL,Position from #TEMP2 as t INNER JOIN Securities as s ON t.SecurityId = s.SecurityId;





END 
GO

EXEC [dbo].TickTrade4;

