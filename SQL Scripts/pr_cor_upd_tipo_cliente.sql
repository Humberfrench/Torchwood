
GO
/****** Object:  StoredProcedure [dbo].[pr_cor_upd_tipo_cliente]    Script Date: 07/28/2008 10:48:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_upd_tipo_cliente]
(
	@id_tipo_cliente tinyint,
	@ds_tipo_cliente varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [tb_cor_tipo_cliente]
	SET
		[ds_tipo_cliente] = @ds_tipo_cliente
	WHERE
		[id_tipo_cliente] = @id_tipo_cliente


	SET @Err = @@Error


	RETURN @Err
END
