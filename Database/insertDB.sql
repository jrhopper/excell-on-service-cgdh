insert into department (name) values ('HR management')
insert into department (name) values ('Administration')
insert into department (name) values ('Service')
insert into department (name) values ('Training')
insert into department (name) values ('Internet security')
insert into department (name) values ('Auditors')

------------------------------------------------------------------------------------------------
insert into servicetype (name,image,charges) values ('In-bound','',4500)
insert into servicetype (name,image,charges) values ('Out-bound','',6000)
insert into servicetype (name,image,charges) values ('Tele marketing','',5500)
------------------------------------------------------------------------------------------------
insert into action (name,link) values ('Manage Employee','ManageEmployee.aspx')
insert into action (name,link) values ('Manage Customer','ManageCustomer.aspx')
insert into action (name,link) values ('Manage Service Type','ManageServiceType.aspx')
insert into action (name,link) values ('Manage Service Order','ManageServiceOrder.aspx')
insert into action (name,link) values ('Manage Service Order Detail','ManageOrderDetail.aspx')
insert into action (name,link) values ('Manage Department','ManageDepartment.aspx')
insert into action (name,link) values ('Manage Menu','ManageMenu.aspx')
insert into action (name,link) values ('Manage Product','ManageProduct.aspx')
insert into action (name,link) values ('Manage Status Payment','ManageStatusPayment.aspx')
insert into action (name,link) values ('Manage Role Detail','ManageRoleDetail.aspx')
insert into action (name,link) values ('Manage Action','ManageAction.aspx')
insert into action (name,link) values ('Manage Role','ManageRole.aspx')
insert into action (name,link) values ('Advanced Search','AdvancedSearch.aspx')
------------------------------------------------------------------------------------------------
insert into role (name) values ('Admin')
insert into role (name) values ('HR manager')
insert into role (name) values ('Service manager')
insert into role (name) values ('Service order manager')
------------------------------------------------------------------------------------------------
insert into menu (name,link) values ('Employee','ManageEmployee.aspx')
insert into menu (name,link) values ('Customer','ManageCustomer.aspx')
insert into menu (name,link) values ('Service','ManageServiceOrder.aspx')
insert into menu (name,link) values ('Department','ManageDepartment.aspx')
insert into menu (name,link) values ('Search','Search.aspx')
insert into menu (name,link) values ('Role','ManageRole.aspx')
------------------------------------------------------------------------------------------------
insert into roledetail (menuid,roleid,actionid) values (0,0,0)
insert into roledetail (menuid,roleid,actionid) values (1,0,1)
insert into roledetail (menuid,roleid,actionid) values (2,0,2)
insert into roledetail (menuid,roleid,actionid) values (2,0,3)
insert into roledetail (menuid,roleid,actionid) values (2,0,4)
insert into roledetail (menuid,roleid,actionid) values (2,0,7)
insert into roledetail (menuid,roleid,actionid) values (2,0,8)
insert into roledetail (menuid,roleid,actionid) values (3,0,5)
insert into roledetail (menuid,roleid,actionid) values (4,0,12)
insert into roledetail (menuid,roleid,actionid) values (5,0,6)
insert into roledetail (menuid,roleid,actionid) values (5,0,9)
insert into roledetail (menuid,roleid,actionid) values (5,0,10)
insert into roledetail (menuid,roleid,actionid) values (5,0,11)
--end admin

insert into roledetail (menuid,roleid,actionid) values (1,1,1)
insert into roledetail (menuid,roleid,actionid) values (4,1,12)
--end HR Manager

insert into roledetail (menuid,roleid,actionid) values (1,2,1)
insert into roledetail (menuid,roleid,actionid) values (2,2,2)
insert into roledetail (menuid,roleid,actionid) values (2,2,3)
insert into roledetail (menuid,roleid,actionid) values (2,2,4)
insert into roledetail (menuid,roleid,actionid) values (2,2,7)
insert into roledetail (menuid,roleid,actionid) values (2,2,8)
insert into roledetail (menuid,roleid,actionid) values (4,2,12)
--end service manager

insert into roledetail (menuid,roleid,actionid) values (1,3,1)
insert into roledetail (menuid,roleid,actionid) values (2,3,2)
insert into roledetail (menuid,roleid,actionid) values (2,3,3)
insert into roledetail (menuid,roleid,actionid) values (2,3,4)
insert into roledetail (menuid,roleid,actionid) values (2,3,8)
insert into roledetail (menuid,roleid,actionid) values (4,3,12)
--end service order manager

------------------------------------------------------------------------------------------------
insert into customer (name,address,phone,email) values ('Michael','145 Nguyen Trai','0908054823','michael@gmail.com')
insert into customer (name,address,phone,email) values ('Philip','156 Nguyen Tri Phuong','0908632699','philip@gmail.com')
insert into customer (name,address,phone,email) values ('Marry','178 Hoc Lac','0908745212','marry@gmail.com')
insert into customer (name,address,phone,email) values ('Sam','189 Phung Hung','0921525785','sam@gmail.com')
insert into customer (name,address,phone,email) values ('Jackie','55 Le Loi','0907521586','jackie@gmail.com')
insert into customer (name,address,phone,email) values ('Kevin','987 Le Lai','0907515822','kevin@gmail.com')
insert into customer (name,address,phone,email) values ('Tim','678 Nguyen Trai','0908752158','tim@gmail.com')
insert into customer (name,address,phone,email) values ('Kathy','235 Cao Thang','0907820152','kathy@gmail.com')
------------------------------------------------------------------------------------------------
insert into product (name,company,price,customerid) values ('SamSung Galaxy SII','SamSung',8000000,0)
insert into product (name,company,price,customerid) values ('SamSung Galaxy SI','SamSung',6000000,1)
insert into product (name,company,price,customerid) values ('SamSung Galaxy SIII','SamSung',7000000,2)
insert into product (name,company,price,customerid) values ('SamSung Galaxy Wave','SamSung',9000000,5)
insert into product (name,company,price,customerid) values ('SamSung Galaxy Ave','SamSung',18000000,3)
------------------------------------------------------------------------------------------------
insert into employee (username,password,department,roleid,name,birthday,sex,address,phone,email) 
values ('qchuong100','123',2,1,'Quoc Chuong','1990-09-09',1,'Thanh pho HCM','0907226148','qchuong100@gmail.com')

insert into employee (username,password,department,roleid,name,birthday,sex,address,phone,email) 
values ('hoang89','456',4,1,'Nguyen Kim Hoang','1989-10-24',1,'Thanh pho HCM','01692199954','hoangnk.hv@gmail.com')

insert into employee (username,password,department,roleid,name,birthday,sex,address,phone,email) 
values ('anhdai','789',3,2,'Le Anh Dai','1990-09-09',1,'Thanh pho HCM','0000005555','daile1503@gmail.com')

insert into employee (username,password,department,roleid,name,birthday,sex,address,phone,email) 
values ('tronggia','012',1,1,'Huynh Trong Gia','1990-09-09',1,'Thanh pho HCM','05151515151','tronggia@gmail.com')
------------------------------------------------------------------------------------------------
insert into serviceorder (empid,name,customer,servicetype,begindate,enddate) 
values (0,'Serivce order 1',0,0,'2012-01-24','2012-02-16')
insert into serviceorder (empid,name,customer,servicetype,begindate,enddate) 
values (1,'Serivce order 2',2,2,'2012-03-17','2012-03-29')
insert into serviceorder (empid,name,customer,servicetype,begindate,enddate) 
values (2,'Serivce order 3',3,1,'2012-01-14','2012-02-22')
insert into serviceorder (empid,name,customer,servicetype,begindate,enddate) 
values (3,'Serivce order 4',5,0,'2012-03-08','2012-03-20')
------------------------------------------------------------------------------------------------
insert into serviceorderdetail (ServiceOrderId,EmpId,TaskName) values (0,0,'cong viec 1')
insert into serviceorderdetail (ServiceOrderId,EmpId,TaskName) values (0,0,'cong viec 2')
insert into serviceorderdetail (ServiceOrderId,EmpId,TaskName) values (0,0,'cong viec 5')
insert into serviceorderdetail (ServiceOrderId,EmpId,TaskName) values (0,0,'cong viec 8')
insert into serviceorderdetail (ServiceOrderId,EmpId,TaskName) values (1,3,'cong viec 7')
insert into serviceorderdetail (ServiceOrderId,EmpId,TaskName) values (1,3,'cong viec 15')
insert into serviceorderdetail (ServiceOrderId,EmpId,TaskName) values (1,3,'cong viec 18')
insert into serviceorderdetail (ServiceOrderId,EmpId,TaskName) values (1,3,'cong viec 17')
insert into serviceorderdetail (ServiceOrderId,EmpId,TaskName) values (2,2,'cong viec 14')
insert into serviceorderdetail (ServiceOrderId,EmpId,TaskName) values (2,2,'cong viec 19')
insert into serviceorderdetail (ServiceOrderId,EmpId,TaskName) values (3,1,'cong viec 13')
insert into serviceorderdetail (ServiceOrderId,EmpId,TaskName) values (3,1,'cong viec 12')
insert into serviceorderdetail (ServiceOrderId,EmpId,TaskName) values (3,1,'cong viec 11')
------------------------------------------------------------------------------------------------
insert into statuspayment (serviceorderid,status,date) values (0,1,'2012-02-16')
insert into statuspayment (serviceorderid,status,date) values (1,0,'2012-03-30')
insert into statuspayment (serviceorderid,status,date) values (2,0,'2012-02-25')
insert into statuspayment (serviceorderid,status,date) values (3,1,'2012-03-20')