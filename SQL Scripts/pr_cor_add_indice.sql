GO
/****** Object:  StoredProcedure [dbo].[pr_cor_add_indice]    Script Date: 07/28/2008 10:47:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_add_indice]
(
	@id_indice int = NULL output,
	@sg_indice varchar(10),
	@ds_indice varchar(50) = NULL,
	@ds_obs varchar(100) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [tb_cor_indice]
	(
		[sg_indice],
		[ds_indice],
		[ds_obs]
	)
	VALUES
	(
		@sg_indice,
		@ds_indice,
		@ds_obs
	)

	SET @Err = @@Error

	SELECT @id_indice = SCOPE_IDENTITY()

	RETURN @Err
END
