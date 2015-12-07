GO
/****** Object:  StoredProcedure [dbo].[pr_cor_add_servico]    Script Date: 07/28/2008 10:47:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_add_servico]
(
	@id_servico int = NULL output,
	@ds_servico varchar(100),
	@vl_custo numeric(10,2),
	@id_unidade int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [tb_cor_servico]
	(
		[ds_servico],
		[vl_custo],
		[id_unidade]
	)
	VALUES
	(
		@ds_servico,
		@vl_custo,
		@id_unidade
	)

	SET @Err = @@Error

	SELECT @id_servico = SCOPE_IDENTITY()

	RETURN @Err
END
