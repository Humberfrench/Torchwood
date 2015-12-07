GO
/****** Object:  StoredProcedure [dbo].[pr_cor_lista_notas]    Script Date: 07/28/2008 10:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_cor_lista_notas](@ano integer, @cliente integer)
AS

SELECT	a.nr_nota, 
		a.nr_cod_verificacao, 
		a.dt_nota, 
		a.vl_nota, 
		isnull(a.ir_retido,0) ir_retido,
		isnull(a.vl_retido,0) vl_retido,
		isnull(a.vl_devido,0) vl_devido,
		isnull(a.ds_caminho,'javascript:void(0);') ds_caminho,
		a.st_nota, 
		b.nm_cliente, 
		b.nr_CNPJ
FROM	tb_cor_notafiscal a 
INNER JOIN tb_cor_cliente b
ON		a.id_cliente = b.id_cliente
WHERE  Year(dt_nota) = @ano
AND	   a.id_cliente_prestador = @cliente
ORDER BY a.nr_nota;

