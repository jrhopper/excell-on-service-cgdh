insert into department (name,description) values ('HR management','')
insert into department (name,description) values ('Administration','')
insert into department (name,description) values ('Service','')
insert into department (name,description) values ('Training','')
insert into department (name,description) values ('Internet security','')
insert into department (name,description) values ('Auditors','')

insert into role (name,description) values ('Admin','')
insert into role (name,description) values ('HR manager','')
insert into role (name,description) values ('Service manager','')
insert into role (name,description) values ('Service order manager','')

insert into servicetype (name,image,charges,description) values ('In-bound','',4500,'')
insert into servicetype (name,image,charges,description) values ('Out-bound','',6000,'')
insert into servicetype (name,image,charges,description) values ('Tele marketing','',5500,'')

insert into action (name,description) values ('Add','')
insert into action (name,description) values ('Update','')
insert into action (name,description) values ('Delete','')
insert into action (name,description) values ('Search','')
insert into action (name,description) values ('Print','')

insert into menu (name,description) values ('Employee','')
insert into menu (name,description) values ('Customer','')
insert into menu (name,description) values ('Service','')
insert into menu (name,description) values ('Department','')

insert into customer (name,address,phone,email,contact,company) values ('Michael','145 abc','0908054823','michael@gmail.com','','')
insert into customer (name,address,phone,email,contact,company) values ('Philip','156 abc','0908632699','philip@gmail.com','','')
insert into customer (name,address,phone,email,contact,company) values ('Marry','178 abc','0908745212','marry@gmail.com','','')
insert into customer (name,address,phone,email,contact,company) values ('Sam','189 abc','0921525785','sam@gmail.com','','')
insert into customer (name,address,phone,email,contact,company) values ('Jackie','55 abc','0907521586','jackie@gmail.com','','')
insert into customer (name,address,phone,email,contact,company) values ('Kevin','987 abc','0907515822','kevin@gmail.com','','')
insert into customer (name,address,phone,email,contact,company) values ('Tim','678 abc','0908752158','tim@gmail.com','','')
insert into customer (name,address,phone,email,contact,company) values ('Kathy','235 abc','0907820152','kathy@gmail.com','','')

--insert into product (name,company,price,customerid,description) values ()

insert into employee (username,password,department,roleid,name,birthday,sex,address,phone,email) 
values ('qchuong100','123',2,1,'Quoc Chuong','1990-09-09',1,'Thanh pho HCM','0907226148','qchuong100@gmail.com')
insert into employee (username,password,department,roleid,name,birthday,sex,address,phone,email) 
values ('qchuong100','123',2,1,'Quoc Chuong','1990-09-09',1,'Thanh pho HCM','0907226148','qchuong100@gmail.com')
insert into employee (username,password,department,roleid,name,birthday,sex,address,phone,email) 
values ('qchuong100','123',2,1,'Quoc Chuong','1990-09-09',1,'Thanh pho HCM','0907226148','qchuong100@gmail.com')
insert into employee (username,password,department,roleid,name,birthday,sex,address,phone,email) 
values ('qchuong100','123',2,1,'Quoc Chuong','1990-09-09',1,'Thanh pho HCM','0907226148','qchuong100@gmail.com')


insert into serviceorder (empid,name,customer,servicetype,begindate,enddate,complete,description) 
values ()

insert into serviceorderdetail (empid,name,customer,servicetype,begindate,enddate,complete,description) 
values ()



insert into statuspayment (serviceorderid,status,date,description) values ()