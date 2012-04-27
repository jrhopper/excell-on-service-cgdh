create proc SP_ChangePassword  
@NewPass varchar(50),
@UserName varchar(50) 
as
begin
	update employee set password = @NewPass where username = @UserName
end

/*
exec SP_ChangePassword '5555','qchuong100'

select * from employee
select * from role
select * from 
*/