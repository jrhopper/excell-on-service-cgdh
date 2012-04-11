/* ---------------------------------------------------------------------- */
/* Script generated with: DeZign for Databases v4.1.3                     */
/* Target DBMS:           MS SQL Server 2005                              */
/* Project file:          ExcellOnService.dez                             */
/* Project name:                                                          */
/* Author:                                                                */
/* Script type:           Database drop script                            */
/* Created on:            2012-04-09 09:42                                */
/* ---------------------------------------------------------------------- */


/* ---------------------------------------------------------------------- */
/* Drop foreign key constraints                                           */
/* ---------------------------------------------------------------------- */

ALTER TABLE [Employee] DROP CONSTRAINT [Department_Employee]
GO

ALTER TABLE [SeviceOrderDetail] DROP CONSTRAINT [ServiceOrder_SeviceOrderDetail]
GO

ALTER TABLE [SeviceOrderDetail] DROP CONSTRAINT [Employee_SeviceOrderDetail]
GO

ALTER TABLE [Product] DROP CONSTRAINT [Customer_Product]
GO

ALTER TABLE [ServiceOrder] DROP CONSTRAINT [Customer_ServiceOrder]
GO

ALTER TABLE [ServiceOrder] DROP CONSTRAINT [Employee_ServiceOrder]
GO

ALTER TABLE [ServiceOrder] DROP CONSTRAINT [ServiceType_ServiceOrder]
GO

ALTER TABLE [StatusPayment] DROP CONSTRAINT [ServiceOrder_StatusPayment]
GO

/* ---------------------------------------------------------------------- */
/* Drop table "Employee"                                                  */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [Employee] DROP CONSTRAINT [PK_Employee]
GO

/* Drop table */

DROP TABLE [Employee]
GO

/* ---------------------------------------------------------------------- */
/* Drop table "Department"                                                */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [Department] DROP CONSTRAINT [PK_Department]
GO

/* Drop table */

DROP TABLE [Department]
GO

/* ---------------------------------------------------------------------- */
/* Drop table "ServiceType"                                               */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [ServiceType] DROP CONSTRAINT [PK_ServiceType]
GO

/* Drop table */

DROP TABLE [ServiceType]
GO

/* ---------------------------------------------------------------------- */
/* Drop table "SeviceOrderDetail"                                         */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [SeviceOrderDetail] DROP CONSTRAINT [PK_SeviceOrderDetail]
GO

/* Drop table */

DROP TABLE [SeviceOrderDetail]
GO

/* ---------------------------------------------------------------------- */
/* Drop table "Customer"                                                  */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [Customer] DROP CONSTRAINT [PK_Customer]
GO

/* Drop table */

DROP TABLE [Customer]
GO

/* ---------------------------------------------------------------------- */
/* Drop table "Product"                                                   */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [Product] DROP CONSTRAINT [PK_Product]
GO

/* Drop table */

DROP TABLE [Product]
GO

/* ---------------------------------------------------------------------- */
/* Drop table "ServiceOrder"                                              */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [ServiceOrder] DROP CONSTRAINT [PK_ServiceOrder]
GO

/* Drop table */

DROP TABLE [ServiceOrder]
GO

/* ---------------------------------------------------------------------- */
/* Drop table "StatusPayment"                                             */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [StatusPayment] DROP CONSTRAINT [PK_StatusPayment]
GO

/* Drop table */

DROP TABLE [StatusPayment]
GO
