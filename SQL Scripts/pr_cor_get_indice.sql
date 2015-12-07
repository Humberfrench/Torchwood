GO
/****** Object:  StoredProcedure [dbo].[pr_cor_get_indice]    Script Date: 07/28/2008 10:48:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_get_indice]
(
	@id_indice int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[id_indice],
		[sg_indice],
		[ds_indice],
		[ds_obs]
	FROM [tb_cor_indice]
	WHERE
		([id_indice] = @id_indice)

	SET @Err = @@Error

	RETURN @Err
END