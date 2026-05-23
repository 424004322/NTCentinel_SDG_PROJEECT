USE [StudentRecords]
GO

/****** Object: Table [dbo].[Student] Script Date: 5/23/2026 10:38:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Student] (
    [Student_ID]            INT           NOT NULL,
    [First_Name]            NVARCHAR (20) NOT NULL,
    [Last_Name]             NVARCHAR (20) NOT NULL,
    [Total_Violation_Count] INT           NULL
);


