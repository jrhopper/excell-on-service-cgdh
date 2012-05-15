/*
Author: La Quoc Chuong
Purpose: search
*/
if exists (select * from sysobjects where name = 'SP_Search')
begin
	drop proc SP_Search
end
go
create proc SP_Search 
@serviceordername nvarchar(100),
@employeename nvarchar(100),
@customername nvarchar(100),
@servicetype nvarchar(5),
@begindate nvarchar(20),
@enddate nvarchar(20),
@status nvarchar(5),
@customeraddress nvarchar(100), 
@customerphone nvarchar(100),
@customeremail nvarchar(100)
--exec sp_search 'null','null','null','null','null','null','null','null','null','null'
as
begin
	declare @str nvarchar(max)
	set @str = 'select so.id as ServiceOrderId, so.name as ServiceOrderName, 
					   so.empid as EmployeeId, e.name as EmployeeName, 
					   so.customer as CustomerID, cus.name as CustomerName,
					   so.servicetype as ServiceTypeId, st.name as ServiceTypeName, 
					   (case sp.status when 1 then ''Finished'' when 0 then ''Unfinish'' end)  as Status, cast(datepart(dd,begindate) as varchar(2))+''-''+cast(datepart(mm,begindate) as varchar(2))+''-''+cast(datepart(yyyy,begindate) as varchar(4)) as begin_date, cast(datepart(dd,enddate) as varchar(2))+''-''+cast(datepart(mm,enddate) as varchar(2))+''-''+cast(datepart(yyyy,enddate) as varchar(4)) as end_date, complete,so.description as serviceorderdescription,
					   cus.phone as customerphone,cus.email as customeremail,cus.address as customeraddress
				from 
				serviceorder so inner join employee e on so.empid = e.id 
								inner join customer cus on so.customer = cus.id 
								inner join servicetype st on so.servicetype = st.id 
								inner join statuspayment sp on so.id = sp.serviceorderid 
				where 1 = 1 '
	if(@serviceordername = 'null')
	begin
		set @str = @str + ' '
	end
	if(@serviceordername != 'null')
	begin
		set @str = @str + ' and so.name like ''%'+@serviceordername + '%'' '
	end
	
	if(@employeename = 'null')
	begin
		set @str = @str + ' '
	end
	if(@employeename != 'null')
	begin
		set @str = @str + ' and e.name like ''%'+@employeename + '%'' '
	end

	if(@customername = 'null')
	begin
		set @str = @str + ' '
	end
	if(@customername != 'null')
	begin
		set @str = @str + ' and cus.name like ''%'+@customername + '%'' '
	end

	if(@servicetype = 'null')
	begin
		set @str = @str + ' '
	end
	if(@servicetype != 'null')
	begin
		set @str = @str + ' and so.servicetype = '+@servicetype + ' '
	end

	if(@begindate = 'null')
	begin
		set @str = @str + ' '
	end
	if(@begindate != 'null')
	begin
		set @str = @str + ' and begindate = '''+@begindate+''' '
	end

	if(@enddate = 'null')
	begin
		set @str = @str + ' '
	end
	if(@enddate != 'null')
	begin
		set @str = @str + ' and enddate = '''+@enddate+''' '
	end

	if(@status = 'null')
	begin
		set @str = @str + ' '
	end
	if(@status != 'null')
	begin
		set @str = @str + ' and sp.status = '+@status+' '
	end

	if(@customeraddress = 'null')
	begin
		set @str = @str + ' '
	end
	if(@customeraddress != 'null')
	begin
		set @str = @str + ' and cus.address = '''+@customeraddress+''' '
	end

	if(@customerphone = 'null')
	begin
		set @str = @str + ' '
	end
	if(@customerphone != 'null')
	begin
		set @str = @str + ' and cus.phone = '''+@customerphone+''' '
	end

	if(@customeremail = 'null')
	begin
		set @str = @str + ' '
	end
	if(@customeremail != 'null')
	begin
		set @str = @str + ' and cus.email = '''+@customeremail+''' '
	end

	--select @str
	exec (@str)


end
/*

exec sp_search 'null','null','null','null','2012-01-24','null','1','null','null','null'
exec sp_search 'null','null','null','null','null','null','null','null','null','michael@gmail.com'

--test1
DECLARE @strVar VARCHAR(200)

SELECT @strVar = 'SELECT COUNT(*) FROM employee'

EXEC (@strVar)
--test 2
declare @str nvarchar(max)
set @str = 'select * from employee'
select @str

---
select * from serviceorder
--select * from serviceorderdetail
select * from servicetype
select * from statuspayment
select * from employee
select * from customer

*/