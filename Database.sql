/*
    OOP2_Project - Database Setup
    Run this script in SQL Server Management Studio (SSMS).
    It creates the database and all tables required by the current C# project.

    IMPORTANT:
    The C# project currently uses:
        Data Source=MSI\SQLExpress;
        Initial Catalog=Project;
        Integrated Security=True;
        TrustServerCertificate=True

    If your SQL Server instance name is different, change DbHelper.cs accordingly.
*/

IF DB_ID(N'Project') IS NULL
BEGIN
    CREATE DATABASE [Project];
END
GO

USE [Project];
GO

/* Re-running the script is safe: create tables only if they do not exist. */

IF OBJECT_ID(N'dbo.ManageUser', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.ManageUser
    (
        UserId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        Name NVARCHAR(100) NOT NULL,
        Email NVARCHAR(150) NOT NULL,
        Password NVARCHAR(100) NOT NULL,
        UserType NVARCHAR(30) NOT NULL
    );
END
GO

IF OBJECT_ID(N'dbo.SignUp', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.SignUp
    (
        ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        FullName NVARCHAR(100) NOT NULL,
        Email NVARCHAR(150) NOT NULL,
        Password NVARCHAR(100) NOT NULL,
        Gender NVARCHAR(20) NOT NULL,
        MobileNumber NVARCHAR(20) NOT NULL
    );
END
GO

IF OBJECT_ID(N'dbo.CompanyManage', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.CompanyManage
    (
        CompanyID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        CompanyName NVARCHAR(150) NOT NULL,
        CompanyType NVARCHAR(100) NOT NULL,
        LicenseNo NVARCHAR(100) NOT NULL,
        ApprovedBy NVARCHAR(100) NOT NULL
    );
END
GO

IF OBJECT_ID(N'dbo.VehicleManage', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.VehicleManage
    (
        VehicleID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        VehicleType NVARCHAR(100) NOT NULL,
        Capacity INT NOT NULL,
        FitnessInfo NVARCHAR(100) NOT NULL,
        StartingPoint NVARCHAR(100) NOT NULL,
        Destination NVARCHAR(100) NOT NULL,
        [Date] DATETIME NOT NULL,
        TicketPrice INT NOT NULL,
        VehicleComId INT NOT NULL,
        driverId INT NULL
    );
END
GO

IF OBJECT_ID(N'dbo.Booking', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Booking
    (
        BookId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        BookedVehicleId INT NOT NULL,
        BookedCompanyID INT NOT NULL,
        BookedFrom NVARCHAR(100) NOT NULL,
        BookedTo NVARCHAR(100) NOT NULL,
        Bookeddate DATETIME NOT NULL,
        BookedTicketPrice INT NOT NULL,
        BookedTicketCount INT NOT NULL,
        BookedTotalPrice INT NOT NULL,
        BookedPayment NVARCHAR(50) NOT NULL
    );
END
GO

IF OBJECT_ID(N'dbo.DriverDetails', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.DriverDetails
    (
        DriDetId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        DriDetVehicleId INT NOT NULL,
        DriDetCompanyName NVARCHAR(150) NOT NULL,
        DriDetFrom NVARCHAR(100) NOT NULL,
        DriDetTo NVARCHAR(100) NOT NULL,
        DriDetDate DATETIME NOT NULL,
        DriDetTrip NVARCHAR(50) NOT NULL
    );
END
GO

/* Add the foreign keys only when the current database does not already have them.
   These relationships match the joins/deletes used by the application. */

IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = N'FK_Vehicle_Company')
BEGIN
    ALTER TABLE dbo.VehicleManage
    ADD CONSTRAINT FK_Vehicle_Company
        FOREIGN KEY (VehicleComId) REFERENCES dbo.CompanyManage(CompanyID);
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = N'FK_Booking_Company')
BEGIN
    ALTER TABLE dbo.Booking
    ADD CONSTRAINT FK_Booking_Company
        FOREIGN KEY (BookedCompanyID) REFERENCES dbo.CompanyManage(CompanyID);
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = N'FK_Booking_Vehicle')
BEGIN
    ALTER TABLE dbo.Booking
    ADD CONSTRAINT FK_Booking_Vehicle
        FOREIGN KEY (BookedVehicleId) REFERENCES dbo.VehicleManage(VehicleID);
END
GO

/* Sample login accounts.
   Admin:  admin@gmail.com / 1234
   Driver: driver@gmail.com / 1234
*/
IF NOT EXISTS (SELECT 1 FROM dbo.ManageUser WHERE Email = N'admin@gmail.com')
BEGIN
    INSERT INTO dbo.ManageUser (Name, Email, Password, UserType)
    VALUES (N'Admin', N'admin@gmail.com', N'1234', N'Admin');
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.ManageUser WHERE Email = N'driver@gmail.com')
BEGIN
    INSERT INTO dbo.ManageUser (Name, Email, Password, UserType)
    VALUES (N'Demo Driver', N'driver@gmail.com', N'1234', N'Driver');
END
GO

/* Sample company. */
IF NOT EXISTS (SELECT 1 FROM dbo.CompanyManage WHERE CompanyName = N'Demo Transport')
BEGIN
    INSERT INTO dbo.CompanyManage (CompanyName, CompanyType, LicenseNo, ApprovedBy)
    VALUES (N'Demo Transport', N'Bus', N'LIC-001', N'Admin');
END
GO

/* Sample vehicle assigned to the demo driver.
   driverId = the UserId of driver@gmail.com. */
IF NOT EXISTS (SELECT 1 FROM dbo.VehicleManage WHERE VehicleType = N'Bus' AND StartingPoint = N'Dhaka' AND Destination = N'Chittagong')
BEGIN
    DECLARE @CompanyId INT = (SELECT TOP 1 CompanyID FROM dbo.CompanyManage WHERE CompanyName = N'Demo Transport');
    DECLARE @DriverId INT = (SELECT TOP 1 UserId FROM dbo.ManageUser WHERE Email = N'driver@gmail.com');

    INSERT INTO dbo.VehicleManage
        (VehicleType, Capacity, FitnessInfo, StartingPoint, Destination, [Date], TicketPrice, VehicleComId, driverId)
    VALUES
        (N'Bus', 40, N'Fit', N'Dhaka', N'Chittagong',
         DATEADD(DAY, 1, CAST(GETDATE() AS DATE)), 800, @CompanyId, @DriverId);
END
GO

SELECT 'Database setup completed successfully.' AS Message;
SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE'
  AND TABLE_NAME IN ('ManageUser','SignUp','CompanyManage','VehicleManage','Booking','DriverDetails')
ORDER BY TABLE_NAME;
GO
