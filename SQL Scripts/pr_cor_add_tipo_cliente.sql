GO
/****** Object:  StoredProcedure [dbo].[pr_cor_add_tipo_cliente]    Script Date: 07/28/2008 10:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_add_tipo_cliente]
(
	@id_tipo_cliente tinyint = NULL output,
	@ds_tipo_cliente varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [tb_cor_tipo_cliente]
	(
		[ds_tipo_cliente]
	)
	VALUES
	(
		@ds_tipo_cliente
	)

	SET @Err = @@Error

	SELECT @id_tipo_cliente = SCOPE_IDENTITY()

	RETURN @Err
END
