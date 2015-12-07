GO
/****** Object:  StoredProcedure [dbo].[pr_cor_upd_recibo]    Script Date: 07/28/2008 10:48:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_upd_recibo]
(
	@id_recibo int,
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

	UPDATE [tb_cor_recibo]
	SET
		[id_tarefa] = @id_tarefa,
		[id_tomador] = @id_tomador,
		[ds_recibo] = @ds_recibo,
		[qt_servico_total] = @qt_servico_total,
		[vl_recibo] = @vl_recibo,
		[dt_recibo] = @dt_recibo,
		[nr_nota] = @nr_nota,
		[ds_observacao] = @ds_observacao
	WHERE
		[id_recibo] = @id_recibo


	SET @Err = @@Error


	RETURN @Err
END
