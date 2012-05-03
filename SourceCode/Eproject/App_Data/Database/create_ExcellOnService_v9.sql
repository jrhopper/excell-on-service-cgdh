/* ---------------------------------------------------------------------- */
/* Script generated with: DeZign for Databases v4.1.3                     */
/* Target DBMS:           MS SQL Server 2005                              */
/* Project file:          ExcellOnService_v5.dez                          */
/* Project name:                                                          */
/* Author:                                                                */
/* Script type:           Database creation script                        */
/* Created on:            2012-05-03 15:03                                */
/* ---------------------------------------------------------------------- */


/* ---------------------------------------------------------------------- */
/* Tables                                                                 */
/* ---------------------------------------------------------------------- */

/* ---------------------------------------------------------------------- */
/* Add table "Employee"                                                   */
/* ---------------------------------------------------------------------- */

CREATE TABLE [Employee] (
    [Id] INTEGER IDENTITY(0,1) NOT NULL,
    [UserName] VARCHAR(50),
    [Password] VARCHAR(50),
    [Department] INTEGER,
    [RoleId] INTEGER,
    [Name] NVARCHAR(100),
    [Birthday] DATETIME,
    [Sex] INTEGER,
    [Address] NVARCHAR(200),
    [Phone] VARCHAR(20),
    [Email] VARCHAR(50),
    CONSTRAINT [PK_Employee] PRIMARY KEY ([Id])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "Department"                                                 */
/* ---------------------------------------------------------------------- */

CREATE TABLE [Department] (
    [Id] INTEGER IDENTITY(0,1) NOT NULL,
    [Name] NVARCHAR(100),
    [Description] VARCHAR(200),
    CONSTRAINT [PK_Department] PRIMARY KEY ([Id])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "ServiceType"                                                */
/* ---------------------------------------------------------------------- */

CREATE TABLE [ServiceType] (
    [Id] INTEGER IDENTITY(0,1) NOT NULL,
    [Name] NVARCHAR(100),
    [Image] VARCHAR(2000),
    [Charges] INTEGER,
    [Description] NVARCHAR(200),
    CONSTRAINT [PK_ServiceType] PRIMARY KEY ([Id])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "ServiceOrderDetail"                                         */
/* ---------------------------------------------------------------------- */

CREATE TABLE [ServiceOrderDetail] (
    [Id] INTEGER IDENTITY(0,1) NOT NULL,
    [ServiceOrderId] INTEGER,
    [EmpId] INTEGER,
    [ServiceType] INTEGER,
    [TaskName] NVARCHAR(200),
    [Description] NVARCHAR(200),
    CONSTRAINT [PK_ServiceOrderDetail] PRIMARY KEY ([Id])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "Customer"                                                   */
/* ---------------------------------------------------------------------- */

CREATE TABLE [Customer] (
    [Id] INTEGER IDENTITY(0,1) NOT NULL,
    [Name] NVARCHAR(100),
    [Address] NVARCHAR(100),
    [Phone] NVARCHAR(100),
    [Email] VARCHAR(50),
    [Contact] NVARCHAR(100),
    [Company] NVARCHAR(100),
    CONSTRAINT [PK_Customer] PRIMARY KEY ([Id])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "Product"                                                    */
/* ---------------------------------------------------------------------- */

CREATE TABLE [Product] (
    [Id] INTEGER IDENTITY(0,1) NOT NULL,
    [Name] NVARCHAR(100) NOT NULL,
    [Company] NVARCHAR(200),
    [Price] INTEGER,
    [CustomerID] INTEGER,
    [Description] NVARCHAR(200),
    CONSTRAINT [PK_Product] PRIMARY KEY ([Id])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "ServiceOrder"                                               */
/* ---------------------------------------------------------------------- */

CREATE TABLE [ServiceOrder] (
    [Id] INTEGER IDENTITY(0,1) NOT NULL,
    [EmpId] INTEGER,
    [Name] NVARCHAR(100),
    [Customer] INTEGER,
    [ServiceType] INTEGER,
    [BeginDate] DATETIME,
    [EndDate] DATETIME,
    [Complete] INTEGER,
    [Description] NVARCHAR(200),
    CONSTRAINT [PK_ServiceOrder] PRIMARY KEY ([Id])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "StatusPayment"                                              */
/* ---------------------------------------------------------------------- */

CREATE TABLE [StatusPayment] (
    [Id] INTEGER IDENTITY(0,1) NOT NULL,
    [ServiceOrderId] INTEGER,
    [Status] INTEGER,
    [Date] DATETIME,
    [Description] NVARCHAR(200),
    CONSTRAINT [PK_StatusPayment] PRIMARY KEY ([Id])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "Role"                                                       */
/* ---------------------------------------------------------------------- */

CREATE TABLE [Role] (
    [Id] INTEGER IDENTITY(0,1) NOT NULL,
    [Name] NVARCHAR(100),
    [Description] VARCHAR(40),
    CONSTRAINT [PK_Role] PRIMARY KEY ([Id])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "Action"                                                     */
/* ---------------------------------------------------------------------- */

CREATE TABLE [Action] (
    [Id] INTEGER IDENTITY(0,1) NOT NULL,
    [Name] NVARCHAR(100),
    [Link] VARCHAR(100),
    [Description] NVARCHAR(200),
    CONSTRAINT [PK_Action] PRIMARY KEY ([Id])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "Menu"                                                       */
/* ---------------------------------------------------------------------- */

CREATE TABLE [Menu] (
    [Id] INTEGER IDENTITY(0,1) NOT NULL,
    [Name] NVARCHAR(100),
    [Link] VARCHAR(100),
    [Description] NVARCHAR(20),
    CONSTRAINT [PK_Menu] PRIMARY KEY ([Id])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "RoleDetail"                                                 */
/* ---------------------------------------------------------------------- */

CREATE TABLE [RoleDetail] (
    [Id] INTEGER IDENTITY(0,1) NOT NULL,
    [MenuId] INTEGER,
    [RoleId] INTEGER,
    [ActionId] INTEGER,
    [Description] NVARCHAR(200),
    CONSTRAINT [PK_RoleDetail] PRIMARY KEY ([Id])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "temp"                                                       */
/* ---------------------------------------------------------------------- */

CREATE TABLE [temp] (
    [serviceorderid] VARCHAR(100) NOT NULL,
    [serviceordername] VARCHAR(100),
    [employeeid] VARCHAR(100),
    [employeename] VARCHAR(100),
    [customerid] VARCHAR(100),
    [customername] VARCHAR(100),
    [charges] VARCHAR(100),
    [begindate] VARCHAR(100),
    [enddate] VARCHAR(100),
    CONSTRAINT [PK_temp] PRIMARY KEY ([serviceorderid])
)
GO

/* ---------------------------------------------------------------------- */
/* Foreign key constraints                                                */
/* ---------------------------------------------------------------------- */

ALTER TABLE [Employee] ADD CONSTRAINT [Department_Employee] 
    FOREIGN KEY ([Department]) REFERENCES [Department] ([Id])
GO

ALTER TABLE [Employee] ADD CONSTRAINT [Role_Employee] 
    FOREIGN KEY ([RoleId]) REFERENCES [Role] ([Id])
GO

ALTER TABLE [ServiceOrderDetail] ADD CONSTRAINT [ServiceOrder_ServiceOrderDetail] 
    FOREIGN KEY ([ServiceOrderId]) REFERENCES [ServiceOrder] ([Id])
GO

ALTER TABLE [ServiceOrderDetail] ADD CONSTRAINT [Employee_ServiceOrderDetail] 
    FOREIGN KEY ([EmpId]) REFERENCES [Employee] ([Id])
GO

ALTER TABLE [ServiceOrderDetail] ADD CONSTRAINT [ServiceType_ServiceOrderDetail] 
    FOREIGN KEY ([ServiceType]) REFERENCES [ServiceType] ([Id])
GO

ALTER TABLE [Product] ADD CONSTRAINT [Customer_Product] 
    FOREIGN KEY ([CustomerID]) REFERENCES [Customer] ([Id])
GO

ALTER TABLE [ServiceOrder] ADD CONSTRAINT [Customer_ServiceOrder] 
    FOREIGN KEY ([Customer]) REFERENCES [Customer] ([Id])
GO

ALTER TABLE [ServiceOrder] ADD CONSTRAINT [Employee_ServiceOrder] 
    FOREIGN KEY ([EmpId]) REFERENCES [Employee] ([Id])
GO

ALTER TABLE [ServiceOrder] ADD CONSTRAINT [ServiceType_ServiceOrder] 
    FOREIGN KEY ([ServiceType]) REFERENCES [ServiceType] ([Id])
GO

ALTER TABLE [StatusPayment] ADD CONSTRAINT [ServiceOrder_StatusPayment] 
    FOREIGN KEY ([ServiceOrderId]) REFERENCES [ServiceOrder] ([Id])
GO

ALTER TABLE [RoleDetail] ADD CONSTRAINT [Role_RoleDetail] 
    FOREIGN KEY ([RoleId]) REFERENCES [Role] ([Id])
GO

ALTER TABLE [RoleDetail] ADD CONSTRAINT [Action_RoleDetail] 
    FOREIGN KEY ([ActionId]) REFERENCES [Action] ([Id])
GO

ALTER TABLE [RoleDetail] ADD CONSTRAINT [Menu_RoleDetail] 
    FOREIGN KEY ([MenuId]) REFERENCES [Menu] ([Id])
GO
