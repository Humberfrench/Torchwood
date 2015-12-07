

GO
/****** Object:  StoredProcedure [dbo].[pr_cor_lista_tarefas_cliente]    Script Date: 07/28/2008 10:48:19 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[pr_cor_lista_tarefas_cliente]  (@id_cliente integer)

AS

SELECT a.id_tarefa, 
	 a.id_servico, 
	 a.id_cliente, 
	 a.ds_tarefa, 
	 a.vl_custo_total,
              convert(varchar(10),a.dt_cadastro,103)  dt_cadastro, 
	 convert(varchar(10),a.dt_prev_inicio,103) dt_prev_inicio, 
	 convert(varchar(10),a.dt_prev_final,103) dt_prev_final,
	 a.ds_observacao,
	 b.ds_servico
FROM 	tb_cor_tarefa a
inner join tb_cor_servico b
on a.id_servico = b.id_servico
WHERE a.id_cliente = @id_cliente