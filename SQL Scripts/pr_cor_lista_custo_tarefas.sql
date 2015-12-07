GO
/****** Object:  StoredProcedure [dbo].[pr_cor_lista_custo_tarefas]    Script Date: 07/28/2008 10:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pr_cor_lista_custo_tarefas]
as
select 	a.id_tarefa , 
	a.ds_tarefa, 
	(sum(b.qt_tarefa) * c.vl_custo) as  total
from tb_cor_tarefa a
join tb_cor_tarefa_item b
on   a.id_tarefa = b.id_tarefa
join tb_cor_servico c
on   a.id_servico = c.id_servico
group by a.id_tarefa , 
	a.ds_tarefa, 
	c.vl_custo 
