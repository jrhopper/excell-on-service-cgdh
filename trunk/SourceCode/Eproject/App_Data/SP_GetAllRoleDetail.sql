/*
Author: La Quoc Chuong
Purpose: get all role detail
*/
if exists (select * from sysobjects where name = 'SP_GetAllRoleDetail')
begin
	drop proc SP_GetAllRoleDetail
end
go
create proc SP_GetAllRoleDetail
@id int
as
begin
	select d.id as RoleDetailId,d.menuid as MenuId,d.roleid as RoleId,d.actionid as ActionId,d.description as RoleDetailDescription,a.name as ActionName,m.name as MenuName,r.name as RoleName 
	from roledetail d inner join [role] r on d.roleid = r.id 
	inner join menu m on d.menuid = m.id 
	inner join [action] a on d.actionid = a.id 
	where d.roleid  =2
end

/*
exec SP_GetAllRoleDetail 2
*/

