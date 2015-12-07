GO
/****** Object:  StoredProcedure [dbo].[pr_cor_set_indice]    Script Date: 07/28/2008 10:48:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_set_indice]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[id_indice],
		[sg_indice],
		[ds_indice],
		[ds_obs]
	FROM [tb_fin_indice]

	SET @Err = @@Error

	RETURN @Err
END