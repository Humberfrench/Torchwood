GO
/****** Object:  StoredProcedure [dbo].[pr_cor_lista_recibo_cliente]    Script Date: 07/28/2008 10:48:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[pr_cor_lista_recibo_cliente] (@id_cliente int)

AS
SELECT 	 a.id_recibo,
	     a.ds_recibo, 
	     a.vl_recibo, 
	     a.dt_recibo,
	     b.id_cliente,
		 c.nm_cliente
FROM	 tb_cor_recibo a
inner join tb_cor_tarefa b
on a.id_tarefa = b.id_tarefa
inner join tb_cor_cliente c
on b.id_cliente = c.id_cliente
AND b.id_cliente = @id_cliente

