--thong ke theo serviceorder,payment,employee,client

select so.id as serviceorderid, so.name as serviceordername, so.empid as employeeid, e.name as employeename, 
so.customer as customerid, cust.name as customername, sum(st.charges) as charges, 
cast(datepart(dd,begindate) as varchar(2))+'-'+cast(datepart(mm,begindate) as varchar(2))
+'-'+cast(datepart(yyyy,begindate) as varchar(4)) as begindate, 
cast(datepart(dd,enddate) as varchar(2))+'-'+cast(datepart(mm,enddate) as varchar(2))
+'-'+cast(datepart(yyyy,enddate) as varchar(4)) as enddate 
from serviceorder so inner join employee e on so.empid = e.id 
inner join customer cust on so.customer = cust.id  
inner join serviceorderdetail sod on sod.serviceorderid = so.id 
inner join servicetype st on st.id = sod.servicetype 
where cast(datepart(mm,begindate) as varchar(2)) = '1' 
and so.empid = 0 and so.customer = 0 
group by so.id,so.name,so.empid,e.name,so.customer,cust.name,begindate,enddate


/*
select * from serviceorder
select * from servicetype
select * from serviceorderdetail

*/