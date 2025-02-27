
/* ------------------------------------------------------------------*/
-- STEP 1 :: Create database with name Employee 
/* ------------------------------------------------------------------*/
 

 USE [master];
 IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'EmployeeDB')
 BEGIN
    CREATE DATABASE EmployeeDB;
 END;


/* ------------------------------------------------------------------*/ 
-- STEP 2 :: 
-- Create Table - Employee 
-- ADD CONTRAINITS : Id as Identity and PK & DepartmentId as FK
/* ------------------------------------------------------------------*/

USE [EmployeeDB];

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name ='Employee')
BEGIN
    CREATE TABLE Employee(
	    ID INT NOT NULL IDENTITY PRIMARY KEY,
	    EmployeeName VARCHAR(50) NOT NULL,
	    Email NVARCHAR(50) NOT NULL UNIQUE,
	    DepartmentId INT
     );
END;

/* ------------------------------------------------------------------*/ 
-- STEP 3 :: 
-- Create Table - Department 
-- ADD CONTRAINITS : Id as Identity and PK
/* ------------------------------------------------------------------*/

USE [EmployeeDB];

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name ='Department')
BEGIN
    CREATE TABLE Department(
	    ID INT NOT NULL IDENTITY PRIMARY KEY,
	    DepartmentName VARCHAR(50) NOT NULL
    );
END;

/* ------------------------------------------------------------------*/ 
-- STEP 4 :: 
-- Link above table using DepartmentId as FK 
/* ------------------------------------------------------------------*/

ALTER TABLE Employee ADD CONSTRAINT Employee_DepartmentId_FK
FOREIGN KEY (DepartmentId) REFERENCES Department(ID);


/* ------------------------------------------------------------------*/ 
-- STEP 5 :: 
-- Write a query to Add/Remove column in table 
/* ------------------------------------------------------------------*/


ALTER TABLE Employee
ADD Age INT;

ALTER TABLE Employee
ADD CONSTRAINT CK_Employee_Age CHECK (AGE > 18 AND AGE < 60);

ALTER TABLE Employee
DROP CONSTRAINT CK_Employee_Age; 

ALTER TABLE Employee
DROP COLUMN Age;



/* ------------------------------------------------------------------*/ 
-- STEP 6 :: 
-- Insert/Update/Delete queries on both the table 
/* ------------------------------------------------------------------*/

-- INSERT
INSERT INTO dbo.Department (DepartmentName) VALUES ('HR');
INSERT INTO dbo.Department (DepartmentName) VALUES ('Production');
INSERT INTO dbo.Department (DepartmentName) VALUES ('Sales');
INSERT INTO dbo.Department (DepartmentName) VALUES ('Finance');
INSERT INTO dbo.Department (DepartmentName) VALUES ('IT');


INSERT INTO dbo.Employee (EmployeeName, Email, DepartmentId) VALUES ('John', 'john@testa.com', 1);
INSERT INTO dbo.Employee (EmployeeName, Email, DepartmentId) VALUES ('Marsh', 'Marsh@testa.com', 2);
INSERT INTO dbo.Employee (EmployeeName, Email, DepartmentId) VALUES ('Ronny', 'Ronny@testa.com', 3);
INSERT INTO dbo.Employee (EmployeeName, Email, DepartmentId) VALUES ('Mark', 'Mark@testa.com', 5);
INSERT INTO dbo.Employee (EmployeeName, Email, DepartmentId) VALUES ('Sara', 'Sara@testa.com', 4);
INSERT INTO dbo.Employee (EmployeeName, Email, DepartmentId) VALUES ('Mike', 'Mike@testa.com', NULL);


-- UPDATE
UPDATE dbo.Employee SET EmployeeName = 'Rocky', Email = 'rockey@testa.com'
WHERE DepartmentId = 2 AND EmployeeName = 'Mark';

UPDATE dbo.Employee SET EmployeeName = 'Mark', Email = 'Mark@testa.com'
WHERE DepartmentId = 2 AND EmployeeName = 'Rocky';

UPDATE dbo.Department SET DepartmentName = 'Human Resource' WHERE ID = 1 AND DepartmentName = 'HR';
UPDATE dbo.Department SET DepartmentName = 'Information Technology' WHERE ID = 5 AND DepartmentName = 'IT';


-- DELETE
DELETE FROM Employee;
DELETE FROM Department;

--DELETED USING WHERE CLAUSE CONDITION
--DELETE FROM Employee WHERE ID = 1;
--DELETE FROM Employee WHERE ID = 2;
--DELETE FROM Employee WHERE ID = 3;
--DELETE FROM Employee WHERE ID = 4;
--DELETE FROM Employee WHERE ID = 5;
--DELETE FROM Employee WHERE ID = 6;

--DELETE FROM Department WHERE ID = 1;
--DELETE FROM Department WHERE ID = 2;
--DELETE FROM Department WHERE ID = 3;
--DELETE FROM Department WHERE ID = 4;
--DELETE FROM Department WHERE ID = 5;


/* ------------------------------------------------------------------*/ 
-- STEP 7 :: 
-- Write Stored Procedure to insert dummy data in Employee and Department 
/* ------------------------------------------------------------------*/

USE [EmployeeDB];
GO

SET QUOTED_IDENTIFIER ON;
GO

CREATE OR ALTER PROCEDURE spInsertDummyData
AS
BEGIN
    SET NOCOUNT ON;

    -- Insert dummy departments
    SET IDENTITY_INSERT [dbo].[Department] ON; 

    IF NOT EXISTS (SELECT 1 FROM [dbo].[Department] WHERE ID = 1)
    BEGIN
        INSERT INTO [dbo].[Department](ID, DepartmentName) VALUES (1, 'HR');
    END

    IF NOT EXISTS (SELECT 1 FROM [dbo].[Department] WHERE ID = 2)
    BEGIN
        INSERT INTO [dbo].[Department](ID, DepartmentName) VALUES (2, 'Production');
    END

    IF NOT EXISTS (SELECT 1 FROM [dbo].[Department] WHERE ID = 3)
    BEGIN 
        INSERT INTO [dbo].[Department](ID, DepartmentName) VALUES (3, 'Sales');
    END

    IF NOT EXISTS (SELECT 1 FROM [dbo].[Department] WHERE ID = 4)
    BEGIN
        INSERT INTO [dbo].[Department](ID, DepartmentName) VALUES (4, 'Finance');
    END

    IF NOT EXISTS (SELECT 1 FROM [dbo].[Department] WHERE ID = 5)
    BEGIN
        INSERT INTO [dbo].[Department](ID, DepartmentName) VALUES (5, 'IT');
    END
    SET IDENTITY_INSERT [dbo].[Department] OFF; 
  

    -- Insert dummy employees
   SET IDENTITY_INSERT [dbo].[Employee] ON; 
   IF NOT EXISTS (SELECT 1 FROM [dbo].[Employee] WHERE ID = 1)
   BEGIN 
      INSERT INTO [dbo].[Employee](ID, EmployeeName, Email, DepartmentId) VALUES (1, 'John', 'john@testa.com', 1);
   END

    IF NOT EXISTS (SELECT 1 FROM [dbo].[Employee] WHERE ID = 2)
    BEGIN
      INSERT INTO [dbo].[Employee](ID, EmployeeName, Email, DepartmentId) VALUES (2, 'Marsh', 'Marsh@testa.com', 2);
    END

    IF NOT EXISTS (SELECT 1 FROM [dbo].[Employee] WHERE ID = 3)
    BEGIN 
        INSERT INTO [dbo].[Employee](ID, EmployeeName, Email, DepartmentId) VALUES (3, 'Ronny', 'Ronny@testa.com', 3);
    END

    IF NOT EXISTS (SELECT 1 FROM [dbo].[Employee] WHERE ID = 4)
    BEGIN   
      INSERT INTO [dbo].[Employee](ID, EmployeeName, Email, DepartmentId) VALUES (4, 'Mark', 'Mark@testa.com', 5);
    END

    IF NOT EXISTS (SELECT 1 FROM [dbo].[Employee] WHERE ID = 5)
    BEGIN
      INSERT INTO [dbo].[Employee](ID, EmployeeName, Email, DepartmentId) VALUES (5, 'Sara', 'Sara@testa.com', 4);
    END

    IF NOT EXISTS (SELECT 1 FROM [dbo].[Employee] WHERE ID = 6)
    BEGIN
      INSERT INTO [dbo].[Employee](ID, EmployeeName, Email, DepartmentId) VALUES (6, 'Mike', 'Mike@testa.com', NULL);
    END
    SET IDENTITY_INSERT [dbo].[Employee] OFF;
       
END;

SET QUOTED_IDENTIFIER OFF
GO


EXECUTE [dbo].[spInsertDummyData]
GO



/* ------------------------------------------------------------------*/ 
-- STEP 8 : 
-- Write Inner Join Query 
/* ------------------------------------------------------------------*/
CREATE VIEW dbo.vGetDataUsingInnerJoin 
AS 
    SELECT e.ID, e.EmployeeName, e.Email, d.DepartmentName FROM dbo.Employee e
    INNER JOIN dbo.Department d ON e.DepartmentId = d.ID
GO



/* ------------------------------------------------------------------*/ 
-- STEP 9 :: 
-- Write Left Join Query 
/* ------------------------------------------------------------------*/

CREATE VIEW dbo.vGetDataUsingLeftJoin
AS
    SELECT e.ID, e.EmployeeName, e.Email, d.DepartmentName FROM dbo.Employee e
    LEFT JOIN dbo.Department d ON e.DepartmentId = d.ID;
GO



/* ------------------------------------------------------------------*/ 
-- STEP 10 :: 
-- Write Right Join Query 
/* ------------------------------------------------------------------*/
CREATE VIEW dbo.vGetDataUsingRightJoin
AS
    SELECT e.ID, e.EmployeeName, e.Email, d.DepartmentName FROM dbo.Employee e
    RIGHT JOIN dbo.Department d ON e.DepartmentId = d.ID;
GO


/* ------------------------------------------------------------------*/ 
-- STEP 11 :: 
-- Write Full Outer Join Query 
/* ------------------------------------------------------------------*/

CREATE VIEW dbo.vGetDataUsingFullOuterJoin
AS
    SELECT e.ID, e.EmployeeName, e.Email, d.DepartmentName FROM dbo.Employee e
    FULL OUTER JOIN dbo.Department d ON e.DepartmentId = d.ID;
GO


/* ------------------------------------------------------------------*/
-- For validate restoring data
/* ------------------------------------------------------------------*/
SELECT * FROM Employee;
SELECT * FROM Department;
SELECT * FROM dbo.vGetDataUsingInnerJoin;
SELECT * FROM dbo.vGetDataUsingLeftJoin;
SELECT * FROM dbo.vGetDataUsingRightJoin;
SELECT * FROM dbo.vGetDataUsingFullOuterJoin;
/* ------------------------------------------------------------------*/


