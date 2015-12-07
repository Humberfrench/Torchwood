GO
/****** Object:  StoredProcedure [dbo].[pr_cor_del_unidade]    Script Date: 07/28/2008 10:48:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_del_unidade]
(
	@id_unidade int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [tb_cor_unidade]
	WHERE
		[id_unidade] = @id_unidade
	SET @Err = @@Error

	RETURN @Err
END