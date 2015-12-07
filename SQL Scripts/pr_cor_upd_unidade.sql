GO
/****** Object:  StoredProcedure [dbo].[pr_cor_upd_unidade]    Script Date: 07/28/2008 10:48:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_upd_unidade]
(
	@id_unidade int,
	@sg_unidade varchar(10),
	@ds_unidade varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [tb_cor_unidade]
	SET
		[sg_unidade] = @sg_unidade,
		[ds_unidade] = @ds_unidade
	WHERE
		[id_unidade] = @id_unidade


	SET @Err = @@Error


	RETURN @Err
END