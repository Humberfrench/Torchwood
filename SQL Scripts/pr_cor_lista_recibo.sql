GO
/****** Object:  StoredProcedure [dbo].[pr_cor_lista_recibo]    Script Date: 07/28/2008 10:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_lista_recibo] 
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[id_recibo],
		[id_tarefa],
		[id_tomador],
		[ds_recibo],
		[qt_servico_total],
		[vl_recibo],
		[dt_recibo],
		[nr_nota],
		[ds_observacao]
	FROM [tb_cor_recibo]
	
	
	SET @Err = @@Error

	RETURN @Err
END
