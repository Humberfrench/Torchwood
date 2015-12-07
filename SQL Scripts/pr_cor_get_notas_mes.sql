GO
/****** Object:  StoredProcedure [dbo].[pr_cor_get_notas_mes]    Script Date: 07/28/2008 10:48:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_cor_get_notas_mes] (@cliente integer) 
AS

SELECT	a.nr_nota, 
		isnull(a.nr_cod_verificacao,'N.D.') nr_cod_verificacao,
		a.id_cliente, 
		a.dt_nota, 
		a.vl_nota, 
		a.st_nota, 
		a.ds_observacao, 
		isnull(a.ir_retido,0) ir_retido,
		isnull(a.vl_retido,0) vl_retido,
		isnull(a.vl_devido,0) vl_devido,
		isnull(a.ds_caminho,'javascript:void(0);') ds_caminho,
		a.st_nota,
		b.nm_cliente, 
		b.nr_CNPJ, 
		c.nm_cliente nm_cliente_prest,
		Year([dt_nota]) AS Ano, 
		Month([dt_nota]) AS Mes
FROM	tb_cor_notafiscal a
INNER JOIN tb_cor_cliente b 
ON		a.id_cliente = b.id_cliente
INNER JOIN tb_cor_cliente c 
ON		a.id_cliente_prestador = c.id_cliente
WHERE	Year([dt_nota]) = Year(GETDATE()) 
AND		Month([dt_nota]) = (Month(GETDATE())-1) 
AND		id_cliente_prestador = @cliente