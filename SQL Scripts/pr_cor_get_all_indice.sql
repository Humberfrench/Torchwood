GO
/****** Object:  StoredProcedure [dbo].[pr_cor_get_all_indice]    Script Date: 07/28/2008 10:48:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_get_all_indice] 
(@id_indice integer, @id_ano integer)
AS

BEGIN

SELECT	a.id_indice, 
		a.ds_ano, 
		a.ds_mes, 
		a.vl_taxa, 
		b.sg_indice, 
		b.ds_indice 
FROM tb_cor_taxas a
INNER JOIN tb_cor_indice b  
ON a.id_indice = b.id_indice
AND a.ds_ano = @id_ano
AND b.id_indice =  @id_indice
order by a.ds_mes

END