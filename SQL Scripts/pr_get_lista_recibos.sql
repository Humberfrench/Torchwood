GO
/****** Object:  StoredProcedure [dbo].[pr_get_lista_recibos]    Script Date: 07/28/2008 10:48:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[pr_get_lista_recibos](@id_recibo int)

AS

SELECT 	a.id_recibo,  
	a.id_tarefa, 
	a.ds_recibo, 
	a.qt_servico_total, 
	a.vl_recibo, 
	a.dt_recibo, 
	a.nr_nota ,
	b.ds_tarefa,
	c.id_cliente,
	c.nm_cliente,
	d.ds_servico
FROM 	tb_cor_recibo a
JOIN	tb_cor_tarefa b
ON	a.id_tarefa = b.id_tarefa
AND 	a.id_recibo = @id_recibo
JOIN	tb_cor_cliente c
ON 	b.id_cliente = c.id_cliente
JOIN 	tb_cor_servico d
ON	b.id_servico = d.id_servico