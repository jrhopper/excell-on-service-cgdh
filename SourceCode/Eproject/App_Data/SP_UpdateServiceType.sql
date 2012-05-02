if exists (select * from sysobjects where name = 'SP_UpdateServiceType')
begin
	drop proc SP_UpdateServiceType
end
go
create proc SP_UpdateServiceType 
@id int,
@name nvarchar(100),
@image varchar(2000),
@charges int,
@description nvarchar(200)
as
begin
	update [servicetype] set name = @name, image = @image,charges = @charges,description=@description where id = @id
end