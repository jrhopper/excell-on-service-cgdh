if(exists(select * from sysobjects where name = 'SP_CheckMenu'))
begin
	drop proc SP_CheckMenu
end
go
create proc SP_CheckMenu 
@id int,
@rs int output
as 
begin
	set @rs = 0	
	if((select count(*) from roledetail where menuid = @id) > 0)
	begin
		set @rs = 1
	end
end

/*
declare @rs int
exec SP_CheckMenu 7,@rs output
print @rs

*/