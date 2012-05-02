if exists (select * from sysobjects where name = 'SP_UpdateEmployee')
begin
	drop proc SP_UpdateEmployee
end
go
create proc SP_UpdateEmployee 
@id int,
@username varchar(50),
@name nvarchar(100),
@birthday datetime,
@address nvarchar(100),
@phone nvarchar(100),
@email varchar(50)
as
begin
	update [employee] set [username] = @username, name = @name, birthday = @birthday, address = @address, phone = @phone, email = @email where id = @id
end