GO
/****** Object:  StoredProcedure [dbo].[pr_cor_get_ano_indice]    Script Date: 07/28/2008 10:48:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_get_ano_indice] (@id_indice integer)

AS

BEGIN

	SELECT DISTINCT ds_ano 
	FROM tb_cor_taxas WHERE (id_indice = @id_indice) 
	ORDER BY ds_ano DESC

END
