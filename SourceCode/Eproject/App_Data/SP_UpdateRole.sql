if exists (select * from sysobjects where name = 'SP_UpdateRole')
begin
	drop proc SP_UpdateRole
end
go
create proc SP_UpdateRole 
@id int,
@name varchar(50),
@description varchar(50)
as
begin
	update [role] set [name] = @name, description = @description where id = @id
end

/*
exec SP_UpdateRole 0,'Admin','Admin'
select * from role
select * from roledetail
select * from employee
*/