GO
/****** Object:  StoredProcedure [dbo].[pr_cor_get_unidade]    Script Date: 07/28/2008 10:48:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_get_unidade]
(
	@id_unidade int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[id_unidade],
		[sg_unidade],
		[ds_unidade]
	FROM [tb_cor_unidade]
	WHERE
		([id_unidade] = @id_unidade)

	SET @Err = @@Error

	RETURN @Err
END