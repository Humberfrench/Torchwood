USE [Torchwood]
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_exist_loteria_dezena]    Script Date: 09/14/2010 19:34:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_tor_exist_loteria_dezena] (@id_loteria int)
AS
BEGIN
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	SELECT 1
	FROM   tb_tor_dezenas a
	WHERE  a.id_loteria = @id_loteria
		   
END