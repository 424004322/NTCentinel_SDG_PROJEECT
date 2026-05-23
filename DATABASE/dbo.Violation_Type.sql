USE [StudentRecords]
GO

/****** Object: Table [dbo].[Violation_Type] Script Date: 5/23/2026 10:37:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Violation_Type] (
    [Violation_Type_ID] INT           NOT NULL,
    [Category]          NVARCHAR (50) NOT NULL,
    [Penalty]           NVARCHAR (50) NOT NULL
);


