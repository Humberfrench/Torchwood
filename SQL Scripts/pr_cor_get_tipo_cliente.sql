GO
/****** Object:  StoredProcedure [dbo].[pr_cor_get_tipo_cliente]    Script Date: 07/28/2008 10:48:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_get_tipo_cliente]
(
	@id_tipo_cliente tinyint
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[id_tipo_cliente],
		[ds_tipo_cliente]
	FROM [tb_cor_tipo_cliente]
	WHERE
		([id_tipo_cliente] = @id_tipo_cliente)

	SET @Err = @@Error

	RETURN @Err
END