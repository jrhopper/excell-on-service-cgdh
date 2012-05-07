/*
Author: La Quoc Chuong
Purpose: check role is exists in employee or roledetail.
*/
if(exists(select * from sysobjects where name = 'SP_CheckRole'))
begin
	drop proc SP_CheckRole
end
go
create proc SP_CheckRole 
@id int,
@rs int output
as 
begin
	set @rs = 0	
	if((select count(*) from employee where roleid = @id) > 0)
	begin
		set @rs = 1
	end
	if((select count(*) from roledetail where roleid = @id) > 0)
	begin
		set @rs = 1
	end
end

/*
declare @rs int
exec SP_CheckRole 4,@rs output
print @rs

*/