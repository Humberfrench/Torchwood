GO
/****** Object:  StoredProcedure [dbo].[pr_cor_lista_unidade]    Script Date: 07/28/2008 10:48:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_lista_unidade]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[id_unidade],
		[sg_unidade],
		[ds_unidade]
	FROM [tb_cor_unidade]

	SET @Err = @@Error

	RETURN @Err
END