/*
	Author: La Quoc Chuong
	Purpose: SP_Report
*/
--thong ke theo serviceorder,payment,employee,client
if exists (select * from sysobjects where name = 'SP_Report')
begin
	drop proc SP_Report
end
go
create proc SP_Report 
@serviceorderid nvarchar(100),
@month nvarchar(100),
@empid nvarchar(100),
@custid nvarchar(100)
--@charges nvarchar(100) 
as 
begin 
	declare @query nvarchar(max)
	set @query = 'select so.id as serviceorderid, so.name as serviceordername, so.empid as employeeid,
					 e.name as employeename, 
					so.customer as customerid, cust.name as customername, sum(st.charges) as charges, 
					cast(datepart(dd,begindate) as varchar(2))+''-''+cast(datepart(mm,begindate) as varchar(2))
					+''-''+cast(datepart(yyyy,begindate) as varchar(4)) as begindate, 
					cast(datepart(dd,enddate) as varchar(2))+''-''+cast(datepart(mm,enddate) as varchar(2))
					+''-''+cast(datepart(yyyy,enddate) as varchar(4)) as enddate 
					from serviceorder so inner join employee e on so.empid = e.id 
					inner join customer cust on so.customer = cust.id  
					inner join serviceorderdetail sod on sod.serviceorderid = so.id 
					inner join servicetype st on st.id = sod.servicetype 
					where 1 = 1 '
	if (@month = 'null')
	begin
		set @query = @query + ' '
	end
	if(@month != 'null')
	begin
		set @query = @query + ' and cast(datepart(mm,begindate) as varchar(2)) = '+@month+' '
	end

	if(@empid = 'null')
	begin
		set @query = @query + ' '
	end
	if(@empid != 'null')
	begin
		set @query = @query + ' and so.empid = '+@empid+' '
	end

	if(@custid = 'null')	
	begin
		set @query = @query + ' '
	end
	if(@custid != 'null')
	begin
		set @query = @query + ' and so.customer = '+@custid+' '
	end

	if(@serviceorderid = 'null')
	begin 
		set @query = @query +' '
	end
	if(@serviceorderid != 'null')
	begin
		set @query = @query + ' and so.id = '+@serviceorderid+' '
	end

	set @query = @query + ' group by so.id,so.name,so.empid,e.name,so.customer,cust.name,begindate,enddate '

--	if(@charges = 'null')
--	begin
--		set @query = @query + ' '
--	end
--	if(@charges != 'null')
--	begin
--		set @query = @query + ' having sum(st.charges) = '+@charges+' '
--	end
	
	exec (@query)

end


/*

exec SP_Report '0','01','null','null'

select * from serviceorder
select * from servicetype
select * from serviceorderdetail

*/