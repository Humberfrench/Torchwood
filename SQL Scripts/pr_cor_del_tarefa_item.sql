GO
/****** Object:  StoredProcedure [dbo].[pr_cor_del_tarefa_item]    Script Date: 07/28/2008 10:48:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[pr_cor_del_tarefa_item]	(@id_tarefa int, @id_tarefa_item int)
AS

		DELETE tb_cor_tarefa_item
		WHERE	id_tarefa = @id_tarefa
		AND		id_tarefa_item = @id_tarefa_item
		
GO
