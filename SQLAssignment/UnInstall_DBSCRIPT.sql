

/* ------------------------------------------------------------------*/
-- For Dropping all the Table, Constraint, Views, Stored Procedure if exist
/* ------------------------------------------------------------------*/

USE [EmployeeDB];
GO
DROP PROCEDURE IF EXISTS dbo.spInsertDummyData;
ALTER TABLE Employee DROP CONSTRAINT Employee_DepartmentId_FK;
DROP VIEW IF EXISTS dbo.vGetDataUsingFullOuterJoin;
DROP VIEW IF EXISTS dbo.vGetDataUsingInnerJoin;
DROP VIEW IF EXISTS dbo.vGetDataUsingLeftJoin;
DROP VIEW IF EXISTS dbo.vGetDataUsingRightJoin;
DROP TABLE Employee;
DROP TABLE Department;
/* ------------------------------------------------------------------*/

 /*
 --USE [master];
 //It should be closed all open connection instance of EmployeeDB
 IF EXISTS(SELECT * FROM master.sys.databases WHERE name = 'EmployeeDB')
 BEGIN
     DROP DATABASE [EmployeeDB];
 END;
 */
 /* ------------------------------------------------------------------*/