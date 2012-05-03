if exists (select * from sysobjects where name = 'SP_UpdateProduct')
begin
	drop proc SP_UpdateProduct
end
go
create proc SP_UpdateProduct
@id int,
@name nvarchar(100),
@company nvarchar(200),
@price int,
@customerid int,
@description nvarchar(200)
as
begin
	update [product] set [name] = @name, company = @company, price = @price, customerid = @customerid, description = @description where id = @id
end