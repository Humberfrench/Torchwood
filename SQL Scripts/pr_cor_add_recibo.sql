GO
/****** Object:  StoredProcedure [dbo].[pr_cor_add_recibo]    Script Date: 07/28/2008 10:47:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_add_recibo]
(
	@id_recibo int = NULL output,
	@id_tarefa int = NULL,
	@id_tomador int = NULL,
	@ds_recibo varchar(100),
	@qt_servico_total numeric(10,2) = NULL,
	@vl_recibo numeric(10,2),
	@dt_recibo smalldatetime,
	@nr_nota varchar(4) = NULL,
	@ds_observacao varchar(255) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [tb_cor_recibo]
	(
		[id_tarefa],
		[id_tomador],
		[ds_recibo],
		[qt_servico_total],
		[vl_recibo],
		[dt_recibo],
		[nr_nota],
		[ds_observacao]
	)
	VALUES
	(
		@id_tarefa,
		@id_tomador,
		@ds_recibo,
		@qt_servico_total,
		@vl_recibo,
		@dt_recibo,
		@nr_nota,
		@ds_observacao
	)

	SET @Err = @@Error

	SELECT @id_recibo = SCOPE_IDENTITY()

	RETURN @Err
END