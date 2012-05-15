/*
	Author: La Quoc Chuong
	Purpose: SP_Report_Count
*/
--thong ke theo serviceorder,payment,employee,client
if exists (select * from sysobjects where name = 'SP_Report_Count')
begin
	drop proc SP_Report_Count
end
go
create proc SP_Report_Count 
@serviceorderid nvarchar(100),
@month nvarchar(100),
@empid nvarchar(100),
@custid nvarchar(100)
--@charges nvarchar(100) 
as 
begin 
delete temp
insert into temp exec SP_Report @serviceorderid,@month,@empid,@custid 
select count(*) as [count] from temp
end


/*
exec sp_report_count 'null','null','null','null'

select * from serviceorder
select * from servicetype
select * from serviceorderdetail

*/