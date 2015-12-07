GO
/****** Object:  StoredProcedure [dbo].[pr_cor_add_tarefa_item]    Script Date: 07/28/2008 10:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pr_cor_add_tarefa_item]	(@id_tarefa int, 
										         @ds_item varchar(100),
										         @qt_tarefa numeric(10,2),
										         @dt_tarefa smalldatetime)

	AS

	declare @id_tarefa_item int

	select @id_tarefa_item = (isnull(max(id_tarefa_item),0) + 1)
	from tb_cor_tarefa_item
	where id_tarefa = @id_tarefa

	insert into tb_cor_tarefa_item(
							id_tarefa,
							id_tarefa_item,
							ds_item,
							qt_tarefa,
							dt_tarefa)
					values( @id_tarefa,
							@id_tarefa_item,
							@ds_item,
							@qt_tarefa,
							@dt_tarefa)

