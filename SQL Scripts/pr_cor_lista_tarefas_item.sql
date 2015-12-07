GO
/****** Object:  StoredProcedure [dbo].[pr_cor_lista_tarefas_item]    Script Date: 07/28/2008 10:48:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[pr_cor_lista_tarefas_item]  (@id_tarefa integer)

AS

SELECT   a.id_tarefa, 
	 a.id_tarefa_item, 
	 a.ds_item, 
	 a.qt_tarefa, 
	 convert(varchar(10),a.dt_tarefa,103) dt_tarefa, 
	 c.vl_custo,
	 d.sg_unidade
FROM 	tb_cor_tarefa_item a
inner join tb_cor_tarefa b
on a.id_tarefa = b.id_tarefa
and a.id_tarefa = @id_tarefa
inner join tb_cor_servico c
on b.id_servico = c.id_servico
inner join tb_cor_unidade d
on c.id_unidade = d.id_unidade