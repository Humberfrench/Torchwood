GO
/****** Object:  StoredProcedure [dbo].[pr_cor_get_servico_por_tarefa]    Script Date: 07/28/2008 10:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pr_cor_get_servico_por_tarefa] (@id_tarefa integer)

AS
select a.id_tarefa, a.id_tarefa_item, a.ds_item, a.qt_tarefa, a.dt_tarefa,
	   b.id_servico, b.id_cliente, b.ds_tarefa, b.vl_custo, b.vl_custo_extra,
	   b.vl_custo_desconto, b.vl_custo_total, b.ds_custo_extra, b.ds_custo_desconto, 
	   b.dt_prev_inicio, b.dt_prev_final, c.nm_cliente, c.nr_cnpj
from  tb_cor_tarefa_item a
inner join tb_cor_tarefa b
on a.id_tarefa = b.id_tarefa
and a.id_tarefa = @id_tarefa
inner join tb_cor_cliente c
on b.id_cliente = c.id_cliente	

GO