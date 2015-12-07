GO
/****** Object:  StoredProcedure [dbo].[pr_cor_upd_tarefa_item]    Script Date: 07/28/2008 10:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[pr_cor_upd_tarefa_item]	(@id_tarefa int, 
										 @id_tarefa_item int,
										 @ds_item varchar(100),
										 @qt_tarefa int,
										 @dt_tarefa smalldatetime)

	AS



		UPDATE tb_cor_tarefa_item
		SET ds_item = @ds_item,
			qt_tarefa =  @qt_tarefa,
			dt_tarefa = @dt_tarefa
		WHERE	id_tarefa = @id_tarefa
		AND		id_tarefa_item = @id_tarefa_item


