if exists (select * from sysobjects where name = 'SP_UpdateCustomer')
begin
	drop proc SP_UpdateCustomer
end
go
create proc SP_UpdateCustomer 
@id int,
@name nvarchar(100),
@address nvarchar(100),
@phone nvarchar(100),
@email varchar(50),
@contact nvarchar(100),
@company nvarchar(100)
as
begin
	update [customer] set [name] = @name, address = @address, phone = @phone, email = @email, contact = @contact, company = @company where id = @id
end