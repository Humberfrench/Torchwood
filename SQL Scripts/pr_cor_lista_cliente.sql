GO
/****** Object:  StoredProcedure [dbo].[pr_cor_lista_cliente]    Script Date: 07/28/2008 10:48:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_lista_cliente] 
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[id_cliente],
		[id_tipo_cliente],
		[nm_cliente],
		[nm_razao],
		[nr_CNPJ],
		[nr_CCM],
		[nr_inscr_estadual],
		[nm_representante],
		[nr_fone],
		[nr_celular],
		[ds_email1],
		[ds_email2],
		[ds_endereco],
		[ds_numero],
		[ds_compl],
		[ds_bairro],
		[ds_cep],
		[id_UF],
		[id_cidade],
		[id_cliente_rel]
	FROM [tb_cor_cliente]
	
	
	SET @Err = @@Error

	RETURN @Err
END