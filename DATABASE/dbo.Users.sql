USE [StudentRecords]
GO

/****** Object: Table [dbo].[Users] Script Date: 5/23/2026 10:38:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users] (
    [User_ID]       INT           NOT NULL,
    [User_Name]     NVARCHAR (50) NOT NULL,
    [Password_Hash] NVARCHAR (50) NOT NULL,
    [Role]          NVARCHAR (50) NOT NULL
);


