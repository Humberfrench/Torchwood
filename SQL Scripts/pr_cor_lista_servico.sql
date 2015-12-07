GO
/****** Object:  StoredProcedure [dbo].[pr_cor_lista_servico]    Script Date: 07/28/2008 10:48:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_lista_servico] 
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[id_servico],
		[ds_servico],
		[vl_custo],
		[id_unidade]
	FROM [tb_cor_servico]
	
	
	SET @Err = @@Error

	RETURN @Err
END