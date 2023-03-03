
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/24/2023 10:33:42
-- Generated from EDMX file: F:\DXCOOPsPrjs\ASPDotnetMVCPrjs\MVCDatabaseFirstEFCrud\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DXCDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[tbl_employee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbl_employee];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'tbl_employee'
CREATE TABLE [dbo].[tbl_employee] (
    [ecode] int  NOT NULL,
    [ename] varchar(20)  NULL,
    [salary] int  NULL,
    [deptid] int  NULL
   
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ecode] in table 'tbl_employee'
ALTER TABLE [dbo].[tbl_employee]
ADD CONSTRAINT [PK_tbl_employee]
    PRIMARY KEY CLUSTERED ([ecode] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------