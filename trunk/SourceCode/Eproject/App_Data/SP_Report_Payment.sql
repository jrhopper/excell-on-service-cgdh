select * from statuspayment
select * from serviceorder

select so.id as serviceorderid, so.empid as employeename, so.name as serviceordername, 
so.customer as customerid, cust.name as customername, st.