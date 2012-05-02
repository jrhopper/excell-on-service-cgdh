if exists (select * from sysobjects where name = 'SP_UpdateStatusPayment')
begin
	drop proc SP_UpdateStatusPayment
end
go
create proc SP_UpdateStatusPayment 
@id int,
@serviceorderid int,
@status int,
@date datetime,
@description nvarchar(200)
as
begin
	update [servicetype] set serviceorderid = @serviceorderid, status = @status,date = @date,description=@description where id = @id
end