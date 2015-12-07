GO
/****** Object:  StoredProcedure [dbo].[pr_cor_get_servico]    Script Date: 07/28/2008 10:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_get_servico]
(
	@id_servico int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[id_servico],
		[ds_servico],
		[vl_custo],
		[id_unidade]
	FROM [tb_cor_servico]
	WHERE
		([id_servico] = @id_servico)

	SET @Err = @@Error

	RETURN @Err
END
