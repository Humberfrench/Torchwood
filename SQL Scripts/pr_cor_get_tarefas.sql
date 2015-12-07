GO
/****** Object:  StoredProcedure [dbo].[pr_cor_get_tarefas]    Script Date: 07/28/2008 10:48:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[pr_cor_get_tarefas] (@id_tarefa integer, @id_cliente integer)

AS

SELECT	a.id_tarefa, 
	a.id_servico, 
	a.id_cliente, 
	a.ds_tarefa, 
	convert(varchar(10),a.dt_cadastro,101) dt_cadastro,  
	a.ds_observacao,
	b.ds_servico 
FROM 	tb_cor_tarefa a
JOIN 	tb_cor_servico b
ON	a.id_servico = b.id_servico
and 	a.id_tarefa = @id_tarefa
and 	id_cliente = @id_cliente
