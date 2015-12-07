GO
/****** Object:  StoredProcedure [dbo].[pr_cor_upd_custo_task]    Script Date: 07/28/2008 10:47:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[pr_cor_upd_custo_task] (@id_tarefa int)
as
set nocount on

declare @vl_custo_servico numeric(10,2)
declare @vl_custo_total numeric(10,2)
declare @id_servico int
declare @qt_total_task numeric(10, 2)

select @id_servico = id_servico 
from tb_cor_tarefa 
where id_tarefa = @id_tarefa

select @vl_custo_servico = vl_custo
from tb_cor_servico
where id_servico = @id_servico

select @vl_custo_total = (isnull(sum(qt_tarefa),0) * @vl_custo_servico),
       @qt_total_task = isnull(sum(qt_tarefa),0)
from tb_cor_tarefa_item
where id_tarefa = @id_tarefa

update tb_cor_tarefa
set vl_custo = isnull(@vl_custo_total,0),
qt_total_tarefa = isnull(@qt_total_task,0),
vl_custo_total = ((isnull(@vl_custo_total,0) + isnull(vl_custo_extra,0)) - isnull(vl_custo_desconto,0))
where id_tarefa = @id_tarefa

go