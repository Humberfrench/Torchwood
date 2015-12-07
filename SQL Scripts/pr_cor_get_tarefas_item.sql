GO
/****** Object:  StoredProcedure [dbo].[pr_cor_get_tarefas_item]    Script Date: 07/28/2008 10:48:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[pr_cor_get_tarefas_item](@id_tarefa int, @id_tarefa_item int)

	AS


	SELECT					id_tarefa,
							id_tarefa_item,
							ds_item,
							qt_tarefa,
							dt_tarefa
	FROM					tb_cor_tarefa_item
	WHERE	id_tarefa = @id_tarefa
	AND		id_tarefa_item = @id_tarefa_item

