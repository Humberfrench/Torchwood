GO
/****** Object:  StoredProcedure [dbo].[pr_cor_get_lista_tarefa_item]    Script Date: 07/28/2008 10:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pr_cor_get_lista_tarefa_item](@id_tarefa int)

as

SELECT 	id_tarefa, 
	    id_tarefa_item, 
	    ds_item, 
	    qt_tarefa, 
	    dt_tarefa 
FROM 	tb_cor_tarefa_item
where	id_tarefa = @id_tarefa