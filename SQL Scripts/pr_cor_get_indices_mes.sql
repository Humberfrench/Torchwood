GO
/****** Object:  StoredProcedure [dbo].[pr_cor_get_indices_mes]    Script Date: 07/28/2008 10:48:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_get_indices_mes]

AS

BEGIN

	SELECT	a.sg_indice,
			a.ds_indice,
			a.id_indice, 
			b.ds_ano, 
			b.vl_taxa, 
			b.nr_mes,
			c.ds_mes 
	FROM    tb_cor_indice a 
	INNER JOIN tb_cor_taxas  b
	ON		a.id_indice = b.id_indice
	AND     b.ds_ano = Year(getdate()) 
	INNER JOIN tb_cor_mes c
	ON		b.nr_mes = c.nr_mes
	AND		c.nr_mes = Month(getdate()) - 1

END