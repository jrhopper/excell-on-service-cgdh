if exists (select * from sysobjects where name = 'SP_UpdateDepartment')
begin
	drop proc SP_UpdateDepartment
end
go
create proc SP_UpdateDepartment 
@id int,
@name nvarchar(100),
@description varchar(200)
as
begin
	update [department] set [name] = @name, description = @description where id = @id
end