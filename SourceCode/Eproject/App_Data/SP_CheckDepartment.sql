if(exists(select * from sysobjects where name = 'SP_CheckDepartment'))
begin
	drop proc SP_CheckDepartment
end
go
create proc SP_CheckDepartment 
@id int,
@rs int output
as 
begin
	set @rs = 0	
	if((select count(*) from employee where department = @id) > 0)
	begin
		set @rs = 1
	end
end