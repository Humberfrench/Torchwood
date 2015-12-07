GO
/****** Object:  StoredProcedure [dbo].[pr_cor_del_recibo]    Script Date: 07/28/2008 10:47:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_del_recibo] (@id_recibo int)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [tb_cor_recibo]
	WHERE
		[id_recibo] = @id_recibo
	SET @Err = @@Error

	RETURN @Err
END

GO