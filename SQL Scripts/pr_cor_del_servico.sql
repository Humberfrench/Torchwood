GO
/****** Object:  StoredProcedure [dbo].[pr_cor_del_servico]    Script Date: 07/28/2008 10:48:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_del_servico] (@id_servico int)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [tb_cor_servico]
	WHERE
		[id_servico] = @id_servico
	SET @Err = @@Error

	RETURN @Err
END