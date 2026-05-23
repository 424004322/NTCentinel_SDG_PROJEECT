USE [StudentRecords]
GO

/****** Object: Table [dbo].[Violation_Records] Script Date: 5/23/2026 10:38:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Violation_Records] (
    [Violation_Record_ID] INT           IDENTITY (1, 1) NOT NULL,
    [Student_ID]          INT           NOT NULL,
    [User_ID]             INT           NOT NULL,
    [Violation_Type_ID]   INT           NOT NULL,
    [DATE_TIME]           DATETIME      NULL,
    [Imposed_Sanction]    NVARCHAR (50) NOT NULL,
    [Previous_Sanction]   NVARCHAR (50) NOT NULL
);


