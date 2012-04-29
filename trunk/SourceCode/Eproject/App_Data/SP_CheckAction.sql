if(exists(select * from sysobjects where name = 'SP_CheckAction'))
begin
	drop proc SP_CheckAction
end
go
create proc SP_CheckAction 
@id int,
@rs int output
as 
begin
	set @rs = 0	
	if((select count(*) from roledetail where actionid = @id) > 0)
	begin
		set @rs = 1
	end
end

/*
declare @rs int
exec SP_CheckAction 7,@rs output
print @rs

*/