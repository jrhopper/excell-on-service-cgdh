/* ---------------------------------------------------------------------- */
/* Script generated with: DeZign for Databases v4.1.3                     */
/* Target DBMS:           MS SQL Server 2005                              */
/* Project file:          ExcellOnService.dez                             */
/* Project name:                                                          */
/* Author:                                                                */
/* Script type:           Database creation script                        */
/* Created on:            2012-04-09 09:26                                */
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
    [Description] NVARCHAR(200),
    [Image] VARCHAR(2000),
    [Charges] INTEGER,
    CONSTRAINT [PK_ServiceType] PRIMARY KEY ([Id])
)
GO

/* ---------------------------------------------------------------------- */
/* Add table "SeviceOrderDetail"                                          */
/* ---------------------------------------------------------------------- */

CREATE TABLE [SeviceOrderDetail] (
    [Id] INTEGER IDENTITY(0,1) NOT NULL,
    [ServiceOrderId] INTEGER,
    [EmpId] INTEGER,
    [TaskName] NVARCHAR(200),
    [Description] NVARCHAR(200),
    CONSTRAINT [PK_SeviceOrderDetail] PRIMARY KEY ([Id])
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
    [Description] NVARCHAR(200),
    [Price] INTEGER,
    [CustomerID] INTEGER,
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
    [Description] NVARCHAR(200),
    [Complete] INTEGER,
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
    CONSTRAINT [PK_StatusPayment] PRIMARY KEY ([Id])
)
GO

/* ---------------------------------------------------------------------- */
/* Foreign key constraints                                                */
/* ---------------------------------------------------------------------- */

ALTER TABLE [Employee] ADD CONSTRAINT [Department_Employee] 
    FOREIGN KEY ([Department]) REFERENCES [Department] ([Id])
GO

ALTER TABLE [SeviceOrderDetail] ADD CONSTRAINT [ServiceOrder_SeviceOrderDetail] 
    FOREIGN KEY ([ServiceOrderId]) REFERENCES [ServiceOrder] ([Id])
GO

ALTER TABLE [SeviceOrderDetail] ADD CONSTRAINT [Employee_SeviceOrderDetail] 
    FOREIGN KEY ([EmpId]) REFERENCES [Employee] ([Id])
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
