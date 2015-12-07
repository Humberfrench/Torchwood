GO
/****** Object:  StoredProcedure [dbo].[pr_cor_del_cliente]    Script Date: 07/28/2008 10:47:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_del_cliente](@id_cliente int)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [tb_cor_cliente]
	WHERE
		[id_cliente] = @id_cliente
	SET @Err = @@Error

	RETURN @Err
END