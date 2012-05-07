if(exists(select * from sysobjects where name = 'SP_CheckCustomer'))
begin
	drop proc SP_CheckCustomer
end
go
create proc SP_CheckCustomer 
@id int,
@rs int output
as 
begin
	set @rs = 0	
	if((select count(*) from product where customerid = @id) > 0)
	begin
		set @rs = 1
	end
	if((select count(*) from serviceorder where customer = @id) > 0)
	begin
		set @rs = 1
	end
end