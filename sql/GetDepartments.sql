USE [AdventureWorks2014]
GO

/****** Object:  StoredProcedure [dbo].[GetDepartments]    Script Date: 17.01.2019 17:39:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetDepartments]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [DepartmentID]
      ,[Name]
     
  FROM [AdventureWorks2014].[HumanResources].[Department]
END

GO


