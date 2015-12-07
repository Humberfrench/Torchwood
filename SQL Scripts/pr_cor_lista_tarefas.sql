GO
/****** Object:  StoredProcedure [dbo].[pr_cor_lista_tarefas]    Script Date: 07/28/2008 10:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[pr_cor_lista_tarefas]

AS

SELECT 	a.id_tarefa, 
	a.id_servico, 
	a.id_cliente, 
	a.ds_tarefa, 
	a.dt_cadastro, 
	a.ds_observacao,
	b.ds_servico 
FROM 	tb_cor_tarefa a
JOIN 	tb_cor_servico b
ON	a.id_servico = b.id_servico

