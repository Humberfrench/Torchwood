GO
/****** Object:  StoredProcedure [dbo].[pr_cor_del_indice]    Script Date: 07/28/2008 10:47:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_del_indice] (@id_indice int)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [tb_fin_indice]
	WHERE
		[id_indice] = @id_indice
	SET @Err = @@Error

	RETURN @Err
END

go