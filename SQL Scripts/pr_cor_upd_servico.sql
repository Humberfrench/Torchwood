GO
/****** Object:  StoredProcedure [dbo].[pr_cor_upd_servico]    Script Date: 07/28/2008 10:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_upd_servico]
(
	@id_servico int,
	@ds_servico varchar(100),
	@vl_custo numeric(10,2),
	@id_unidade int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [tb_cor_servico]
	SET
		[ds_servico] = @ds_servico,
		[vl_custo] = @vl_custo,
		[id_unidade] = @id_unidade
	WHERE
		[id_servico] = @id_servico


	SET @Err = @@Error


	RETURN @Err
END