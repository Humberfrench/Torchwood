GO
/****** Object:  StoredProcedure [dbo].[pr_cor_get_mes]    Script Date: 07/28/2008 10:48:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_get_mes]

AS

BEGIN

	SELECT	
			nr_mes,
			ds_mes 
	FROM    tb_cor_mes 

END
