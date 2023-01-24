
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/16/2022 18:52:58
-- Generated from EDMX file: D:\VisualStudioProjects\source\repos\Password Manager\Password Manager\ProgramModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ProgramDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserPlatform]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Platforms] DROP CONSTRAINT [FK_UserPlatform];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Platforms]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Platforms];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Platforms'
CREATE TABLE [dbo].[Platforms] (
    [id] smallint IDENTITY(1,1) NOT NULL,
    [programName] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [User_id] int  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Platforms'
ALTER TABLE [dbo].[Platforms]
ADD CONSTRAINT [PK_Platforms]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [User_id] in table 'Platforms'
ALTER TABLE [dbo].[Platforms]
ADD CONSTRAINT [FK_UserPlatform]
    FOREIGN KEY ([User_id])
    REFERENCES [dbo].[Users]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserPlatform'
CREATE INDEX [IX_FK_UserPlatform]
ON [dbo].[Platforms]
    ([User_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------