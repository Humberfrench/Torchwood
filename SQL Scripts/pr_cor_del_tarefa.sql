GO
/****** Object:  StoredProcedure [dbo].[pr_cor_del_tarefa]    Script Date: 07/28/2008 10:48:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pr_cor_del_tarefa] (@id_tarefa integer)

as

	delete from tb_cor_tarefa_item
	where id_tarefa = @id_tarefa


	delete from tb_cor_tarefa
	where id_tarefa = @id_tarefa

go