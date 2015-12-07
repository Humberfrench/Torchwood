GO
/****** Object:  StoredProcedure [dbo].[pr_cor_add_cliente]    Script Date: 07/28/2008 10:47:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_cor_add_cliente]
(
	@id_cliente int = NULL output,
	@id_tipo_cliente tinyint,
	@nm_cliente varchar(100) = NULL,
	@nm_razao varchar(100) = NULL,
	@nr_CNPJ varchar(20) = NULL,
	@nr_CCM varchar(10) = NULL,
	@nr_inscr_estadual varchar(20) = NULL,
	@nm_representante varchar(50) = NULL,
	@nr_fone varchar(20) = NULL,
	@nr_celular varchar(20) = NULL,
	@ds_email1 varchar(100) = NULL,
	@ds_email2 varchar(100) = NULL,
	@ds_endereco varchar(100) = NULL,
	@ds_numero varchar(5) = NULL,
	@ds_compl varchar(50) = NULL,
	@ds_bairro varchar(50) = NULL,
	@ds_cep varchar(9) = NULL,
	@id_UF varchar(2),
	@id_cidade int,
	@id_cliente_rel int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [tb_cor_cliente]
	(
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
	)
	VALUES
	(
		@id_tipo_cliente,
		@nm_cliente,
		@nm_razao,
		@nr_CNPJ,
		@nr_CCM,
		@nr_inscr_estadual,
		@nm_representante,
		@nr_fone,
		@nr_celular,
		@ds_email1,
		@ds_email2,
		@ds_endereco,
		@ds_numero,
		@ds_compl,
		@ds_bairro,
		@ds_cep,
		@id_UF,
		@id_cidade,
		@id_cliente_rel
	)

	SET @Err = @@Error

	SELECT @id_cliente = SCOPE_IDENTITY()

	RETURN @Err
END
