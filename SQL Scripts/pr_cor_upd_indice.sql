GO
/****** Object:  StoredProcedure [dbo].[pr_cor_upd_indice]    Script Date: 07/28/2008 10:48:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_upd_indice]
(
	@id_indice int,
	@sg_indice varchar(10),
	@ds_indice varchar(50) = NULL,
	@ds_obs varchar(100) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [tb_fin_indice]
	SET
		[sg_indice] = @sg_indice,
		[ds_indice] = @ds_indice,
		[ds_obs] = @ds_obs
	WHERE
		[id_indice] = @id_indice


	SET @Err = @@Error


	RETURN @Err
END
