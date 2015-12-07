GO
/****** Object:  StoredProcedure [dbo].[pr_cor_add_unidade]    Script Date: 07/28/2008 10:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_add_unidade]
(
	@id_unidade int = NULL output,
	@sg_unidade varchar(10),
	@ds_unidade varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [tb_cor_unidade]
	(
		[sg_unidade],
		[ds_unidade]
	)
	VALUES
	(
		@sg_unidade,
		@ds_unidade
	)

	SET @Err = @@Error

	SELECT @id_unidade = SCOPE_IDENTITY()

	RETURN @Err
END