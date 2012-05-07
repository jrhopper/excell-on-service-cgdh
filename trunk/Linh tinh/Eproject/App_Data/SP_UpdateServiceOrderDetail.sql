if exists (select * from sysobjects where name = 'SP_UpdateServiceOrderDetail')
begin
	drop proc SP_UpdateServiceOrderDetail
end
go
create proc SP_UpdateServiceOrderDetail 
@id int,
@serviceorderid int,
@empid int,
@servicetype int,
@taskname nvarchar(200),
@description nvarchar(200)
as
begin
	update [serviceorderdetail] set serviceorderid = @serviceorderid, empid = @empid,servicetype = @servicetype,taskname = @taskname,description=@description where id = @id
end