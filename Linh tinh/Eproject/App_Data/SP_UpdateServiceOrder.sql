if exists (select * from sysobjects where name = 'SP_UpdateServiceOrder')
begin
	drop proc SP_UpdateServiceOrder
end
go
create proc SP_UpdateServiceOrder 
@id int,
@empid int,
@name nvarchar(100),
@customer int,
@servicetype int,
@begindate datetime,
@enddate datetime,
@complete int,
@description nvarchar(200)
as
begin
	update [serviceorder] set empid = @empid, name = @name,customer = @customer,servicetype = @servicetype,begindate=@begindate,enddate=@enddate,complete=@complete,description=@description where id = @id
end