USE [french]
GO
/****** Object:  Table [dbo].[tb_cor_cidade]    Script Date: 09/01/2008 14:16:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_cor_cidade](
	[id_cidade] [int] IDENTITY(1,1) NOT NULL,
	[nm_cidade] [varchar](100) COLLATE Latin1_General_CI_AI NOT NULL,
	[sg_uf] [varchar](2) COLLATE Latin1_General_CI_AI NOT NULL,
 CONSTRAINT [PK_tb_por_cidade] PRIMARY KEY CLUSTERED 
(
	[id_cidade] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cidade', @level2type=N'COLUMN',@level2name=N'id_cidade'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nome' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cidade', @level2type=N'COLUMN',@level2name=N'nm_cidade'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'UF' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cidade', @level2type=N'COLUMN',@level2name=N'sg_uf'
GO
/****** Object:  Table [dbo].[tb_cor_cliente]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_cor_cliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo_cliente] [tinyint] NOT NULL,
	[nm_cliente] [varchar](100) COLLATE Latin1_General_CI_AI NULL,
	[nm_razao] [varchar](100) COLLATE Latin1_General_CI_AI NULL,
	[nr_CNPJ] [varchar](20) COLLATE Latin1_General_CI_AI NULL,
	[nr_CCM] [varchar](10) COLLATE Latin1_General_CI_AI NULL,
	[nr_inscr_estadual] [varchar](20) COLLATE Latin1_General_CI_AI NULL,
	[nm_representante] [varchar](50) COLLATE Latin1_General_CI_AI NULL,
	[nr_fone] [varchar](20) COLLATE Latin1_General_CI_AI NULL,
	[nr_celular] [varchar](20) COLLATE Latin1_General_CI_AI NULL,
	[ds_email1] [varchar](100) COLLATE Latin1_General_CI_AI NULL,
	[ds_email2] [varchar](100) COLLATE Latin1_General_CI_AI NULL,
	[ds_endereco] [varchar](100) COLLATE Latin1_General_CI_AI NULL,
	[ds_numero] [varchar](5) COLLATE Latin1_General_CI_AI NULL,
	[ds_compl] [varchar](50) COLLATE Latin1_General_CI_AI NULL,
	[ds_bairro] [varchar](50) COLLATE Latin1_General_CI_AI NULL,
	[ds_cep] [varchar](9) COLLATE Latin1_General_CI_AI NULL,
	[id_UF] [varchar](2) COLLATE Latin1_General_CI_AI NOT NULL,
	[id_cidade] [int] NOT NULL,
	[id_cliente_rel] [int] NULL,
 CONSTRAINT [PK_tb_por_cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cliente', @level2type=N'COLUMN',@level2name=N'id_cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tipo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cliente', @level2type=N'COLUMN',@level2name=N'id_tipo_cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'NomeFantasia' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cliente', @level2type=N'COLUMN',@level2name=N'nm_cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'RazaoSocial' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cliente', @level2type=N'COLUMN',@level2name=N'nm_razao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CNPJ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cliente', @level2type=N'COLUMN',@level2name=N'nr_CNPJ'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CCM' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cliente', @level2type=N'COLUMN',@level2name=N'nr_CCM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'InscricaoEstadual' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cliente', @level2type=N'COLUMN',@level2name=N'nr_inscr_estadual'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Representante' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cliente', @level2type=N'COLUMN',@level2name=N'nm_representante'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Telefone' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cliente', @level2type=N'COLUMN',@level2name=N'nr_fone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Celular' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cliente', @level2type=N'COLUMN',@level2name=N'nr_celular'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Email' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cliente', @level2type=N'COLUMN',@level2name=N'ds_email1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'EmailAdicional' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cliente', @level2type=N'COLUMN',@level2name=N'ds_email2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Endereco' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cliente', @level2type=N'COLUMN',@level2name=N'ds_endereco'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Numero' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cliente', @level2type=N'COLUMN',@level2name=N'ds_numero'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Complemento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cliente', @level2type=N'COLUMN',@level2name=N'ds_compl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Bairro' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cliente', @level2type=N'COLUMN',@level2name=N'ds_bairro'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CEP' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cliente', @level2type=N'COLUMN',@level2name=N'ds_cep'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'UF' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cliente', @level2type=N'COLUMN',@level2name=N'id_UF'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cidade' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cliente', @level2type=N'COLUMN',@level2name=N'id_cidade'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ClientePai' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cliente', @level2type=N'COLUMN',@level2name=N'id_cliente_rel'
GO
/****** Object:  Table [dbo].[tb_cor_cores]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_cor_cores](
	[id_cor] [int] IDENTITY(1,1) NOT NULL,
	[nm_cor] [varchar](50) COLLATE Latin1_General_CI_AI NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cores', @level2type=N'COLUMN',@level2name=N'id_cor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descricao' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_cores', @level2type=N'COLUMN',@level2name=N'nm_cor'
GO
/****** Object:  Table [dbo].[tb_cor_estado]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_cor_estado](
	[sg_uf] [varchar](2) COLLATE Latin1_General_CI_AI NOT NULL,
	[ds_uf] [varchar](50) COLLATE Latin1_General_CI_AI NOT NULL,
 CONSTRAINT [PK_tb_por_estado] PRIMARY KEY CLUSTERED 
(
	[sg_uf] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'UF' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_estado', @level2type=N'COLUMN',@level2name=N'sg_uf'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descricao' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_estado', @level2type=N'COLUMN',@level2name=N'ds_uf'
GO
/****** Object:  Table [dbo].[tb_cor_indice]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_cor_indice](
	[id_indice] [int] IDENTITY(1,1) NOT NULL,
	[sg_indice] [varchar](10) COLLATE Latin1_General_CI_AI NOT NULL,
	[ds_indice] [varchar](50) COLLATE Latin1_General_CI_AI NULL,
	[ds_obs] [varchar](100) COLLATE Latin1_General_CI_AI NULL,
 CONSTRAINT [PK_tb_fin_indice] PRIMARY KEY CLUSTERED 
(
	[id_indice] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_indice', @level2type=N'COLUMN',@level2name=N'id_indice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Sigla' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_indice', @level2type=N'COLUMN',@level2name=N'sg_indice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descricao' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_indice', @level2type=N'COLUMN',@level2name=N'ds_indice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Observacao' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_indice', @level2type=N'COLUMN',@level2name=N'ds_obs'
GO
/****** Object:  Table [dbo].[tb_cor_mes]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_cor_mes](
	[nr_mes] [int] NOT NULL,
	[ds_mes] [varchar](15) COLLATE Latin1_General_CI_AI NOT NULL,
 CONSTRAINT [PK_tb_fwk_mes] PRIMARY KEY CLUSTERED 
(
	[nr_mes] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Numero' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_mes', @level2type=N'COLUMN',@level2name=N'nr_mes'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nome' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_mes', @level2type=N'COLUMN',@level2name=N'ds_mes'
GO
/****** Object:  Table [dbo].[tb_cor_notafiscal]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_cor_notafiscal](
	[nr_nota] [varchar](4) COLLATE Latin1_General_CI_AI NOT NULL,
	[id_cliente_prestador] [int] NOT NULL,
	[nr_cod_verificacao] [varchar](50) COLLATE Latin1_General_CI_AI NULL,
	[id_cliente] [int] NOT NULL,
	[dt_nota] [datetime] NOT NULL,
	[vl_nota] [numeric](10, 2) NOT NULL,
	[ir_retido] [numeric](10, 2) NULL,
	[vl_retido] [numeric](10, 2) NULL,
	[vl_devido] [numeric](10, 2) NULL,
	[st_nota] [varchar](1) COLLATE Latin1_General_CI_AI NOT NULL,
	[ds_caminho] [varchar](50) COLLATE Latin1_General_CI_AI NULL,
	[ds_observacao] [varchar](100) COLLATE Latin1_General_CI_AI NULL,
 CONSTRAINT [PK_tb_por_notafiscal] PRIMARY KEY CLUSTERED 
(
	[nr_nota] ASC,
	[id_cliente_prestador] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Numero' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_notafiscal', @level2type=N'COLUMN',@level2name=N'nr_nota'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ClientePrestador' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_notafiscal', @level2type=N'COLUMN',@level2name=N'id_cliente_prestador'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CodigoVerificacao' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_notafiscal', @level2type=N'COLUMN',@level2name=N'nr_cod_verificacao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_notafiscal', @level2type=N'COLUMN',@level2name=N'id_cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Data' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_notafiscal', @level2type=N'COLUMN',@level2name=N'dt_nota'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Valor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_notafiscal', @level2type=N'COLUMN',@level2name=N'vl_nota'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'IR' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_notafiscal', @level2type=N'COLUMN',@level2name=N'ir_retido'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ValorRetido' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_notafiscal', @level2type=N'COLUMN',@level2name=N'vl_retido'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ValorDevido' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_notafiscal', @level2type=N'COLUMN',@level2name=N'vl_devido'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Status' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_notafiscal', @level2type=N'COLUMN',@level2name=N'st_nota'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Caminho' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_notafiscal', @level2type=N'COLUMN',@level2name=N'ds_caminho'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Observacao' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_notafiscal', @level2type=N'COLUMN',@level2name=N'ds_observacao'
GO
/****** Object:  Table [dbo].[tb_cor_notafiscal_aviso]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_cor_notafiscal_aviso](
	[id_cliente] [int] NOT NULL,
	[ds_nome] [varchar](50) COLLATE Latin1_General_CI_AI NOT NULL,
	[ds_mail] [varchar](100) COLLATE Latin1_General_CI_AI NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_notafiscal_aviso', @level2type=N'COLUMN',@level2name=N'id_cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nome' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_notafiscal_aviso', @level2type=N'COLUMN',@level2name=N'ds_nome'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Email' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_notafiscal_aviso', @level2type=N'COLUMN',@level2name=N'ds_mail'
GO
/****** Object:  Table [dbo].[tb_cor_recibo]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_cor_recibo](
	[id_recibo] [int] IDENTITY(1,1) NOT NULL,
	[id_tarefa] [int] NULL,
	[id_tomador] [int] NULL,
	[ds_recibo] [varchar](100) COLLATE Latin1_General_CI_AI NOT NULL,
	[dt_recibo] [smalldatetime] NOT NULL,
	[nr_nota] [varchar](4) COLLATE Latin1_General_CI_AI NULL,
	[ds_observacao] [varchar](255) COLLATE Latin1_General_CI_AI NULL,
 CONSTRAINT [PK_tb_cor_recibo] PRIMARY KEY CLUSTERED 
(
	[id_recibo] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_recibo', @level2type=N'COLUMN',@level2name=N'id_recibo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tarefa' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_recibo', @level2type=N'COLUMN',@level2name=N'id_tarefa'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tomador' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_recibo', @level2type=N'COLUMN',@level2name=N'id_tomador'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descricao' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_recibo', @level2type=N'COLUMN',@level2name=N'ds_recibo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Data' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_recibo', @level2type=N'COLUMN',@level2name=N'dt_recibo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'NotaFiscal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_recibo', @level2type=N'COLUMN',@level2name=N'nr_nota'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Observacao' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_recibo', @level2type=N'COLUMN',@level2name=N'ds_observacao'
GO
/****** Object:  Table [dbo].[tb_cor_servico]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_cor_servico](
	[id_servico] [int] IDENTITY(1,1) NOT NULL,
	[ds_servico] [varchar](100) COLLATE Latin1_General_CI_AI NOT NULL,
	[vl_custo] [numeric](10, 2) NOT NULL,
	[id_unidade] [int] NULL,
 CONSTRAINT [PK_tb_cor_servico] PRIMARY KEY CLUSTERED 
(
	[id_servico] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_servico', @level2type=N'COLUMN',@level2name=N'id_servico'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descricao' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_servico', @level2type=N'COLUMN',@level2name=N'ds_servico'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Custo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_servico', @level2type=N'COLUMN',@level2name=N'vl_custo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Unidade' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_servico', @level2type=N'COLUMN',@level2name=N'id_unidade'
GO
/****** Object:  Table [dbo].[tb_cor_tarefa]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_cor_tarefa](
	[id_tarefa] [int] IDENTITY(1,1) NOT NULL,
	[id_servico] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[ds_tarefa] [varchar](50) COLLATE Latin1_General_CI_AI NOT NULL,
	[qt_total_tarefa] [numeric](10, 2) NULL,
	[vl_custo] [numeric](10, 2) NULL,
	[vl_custo_extra] [numeric](10, 2) NULL,
	[vl_custo_total] [numeric](10, 2) NULL,
	[vl_custo_desconto] [numeric](10, 2) NULL,
	[ds_custo_extra] [varchar](50) COLLATE Latin1_General_CI_AI NULL,
	[ds_custo_desconto] [varchar](50) COLLATE Latin1_General_CI_AI NULL,
	[dt_cadastro] [smalldatetime] NOT NULL,
	[dt_pagamento] [smalldatetime] NULL,
	[dt_prev_inicio] [smalldatetime] NULL,
	[dt_prev_final] [smalldatetime] NULL,
	[ds_observacao] [varchar](255) COLLATE Latin1_General_CI_AI NULL,
 CONSTRAINT [PK_tb_cor_tarefa] PRIMARY KEY CLUSTERED 
(
	[id_tarefa] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tarefa' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tarefa', @level2type=N'COLUMN',@level2name=N'id_tarefa'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Servico' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tarefa', @level2type=N'COLUMN',@level2name=N'id_servico'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tarefa', @level2type=N'COLUMN',@level2name=N'id_cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descricao' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tarefa', @level2type=N'COLUMN',@level2name=N'ds_tarefa'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'QuantidadeTarefa' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tarefa', @level2type=N'COLUMN',@level2name=N'qt_total_tarefa'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ValorCusto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tarefa', @level2type=N'COLUMN',@level2name=N'vl_custo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ValorCustoExtra' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tarefa', @level2type=N'COLUMN',@level2name=N'vl_custo_extra'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ValorCustoTotal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tarefa', @level2type=N'COLUMN',@level2name=N'vl_custo_total'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ValorCustoDesconto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tarefa', @level2type=N'COLUMN',@level2name=N'vl_custo_desconto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DescricaoCustoExtra' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tarefa', @level2type=N'COLUMN',@level2name=N'ds_custo_extra'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DescricaoCustoDesconto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tarefa', @level2type=N'COLUMN',@level2name=N'ds_custo_desconto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DataCadastro' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tarefa', @level2type=N'COLUMN',@level2name=N'dt_cadastro'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DataPagamento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tarefa', @level2type=N'COLUMN',@level2name=N'dt_pagamento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DataInicio' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tarefa', @level2type=N'COLUMN',@level2name=N'dt_prev_inicio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DataFinal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tarefa', @level2type=N'COLUMN',@level2name=N'dt_prev_final'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Observacao' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tarefa', @level2type=N'COLUMN',@level2name=N'ds_observacao'
GO
/****** Object:  Table [dbo].[tb_cor_tarefa_item]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_cor_tarefa_item](
	[id_tarefa] [int] NOT NULL,
	[id_tarefa_item] [int] NOT NULL,
	[ds_item] [varchar](50) COLLATE Latin1_General_CI_AI NOT NULL,
	[qt_tarefa] [numeric](10, 2) NOT NULL,
	[dt_tarefa] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_tb_cor_tarefa_item] PRIMARY KEY CLUSTERED 
(
	[id_tarefa] ASC,
	[id_tarefa_item] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CodigoTarefa' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tarefa_item', @level2type=N'COLUMN',@level2name=N'id_tarefa'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CodigoItem' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tarefa_item', @level2type=N'COLUMN',@level2name=N'id_tarefa_item'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descricao' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tarefa_item', @level2type=N'COLUMN',@level2name=N'ds_item'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'QuantidadeTarefa' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tarefa_item', @level2type=N'COLUMN',@level2name=N'qt_tarefa'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DataTarefa' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tarefa_item', @level2type=N'COLUMN',@level2name=N'dt_tarefa'
GO
/****** Object:  Table [dbo].[tb_cor_taxas]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_cor_taxas](
	[id_indice] [int] NOT NULL,
	[ds_ano] [smallint] NOT NULL,
	[nr_mes] [int] NOT NULL,
	[ds_mes] [varchar](25) COLLATE Latin1_General_CI_AI NULL,
	[vl_taxa] [float] NULL,
 CONSTRAINT [PK_tb_fin_taxas] PRIMARY KEY CLUSTERED 
(
	[id_indice] ASC,
	[ds_ano] ASC,
	[nr_mes] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Indice' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_taxas', @level2type=N'COLUMN',@level2name=N'id_indice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ano' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_taxas', @level2type=N'COLUMN',@level2name=N'ds_ano'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'NumeroMes' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_taxas', @level2type=N'COLUMN',@level2name=N'nr_mes'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mes' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_taxas', @level2type=N'COLUMN',@level2name=N'ds_mes'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Taxa' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_taxas', @level2type=N'COLUMN',@level2name=N'vl_taxa'
GO
/****** Object:  Table [dbo].[tb_cor_tipo_cliente]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_cor_tipo_cliente](
	[id_tipo_cliente] [tinyint] IDENTITY(1,1) NOT NULL,
	[ds_tipo_cliente] [varchar](50) COLLATE Latin1_General_CI_AI NOT NULL,
 CONSTRAINT [PK_tb_cor_tipo_cliente] PRIMARY KEY CLUSTERED 
(
	[id_tipo_cliente] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tipo_cliente', @level2type=N'COLUMN',@level2name=N'id_tipo_cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descricao' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tipo_cliente', @level2type=N'COLUMN',@level2name=N'ds_tipo_cliente'
GO
/****** Object:  Table [dbo].[tb_cor_tributo]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_cor_tributo](
	[id_tributo] [int] IDENTITY(1,1) NOT NULL,
	[ds_tributo] [varchar](50) COLLATE Latin1_General_CI_AI NOT NULL,
	[vl_inicial] [numeric](10, 2) NOT NULL,
	[is_nf_retido] [varchar](1) COLLATE Latin1_General_CI_AI NOT NULL,
 CONSTRAINT [PK_tb_fin_tributo] PRIMARY KEY CLUSTERED 
(
	[id_tributo] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tributo', @level2type=N'COLUMN',@level2name=N'id_tributo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descricao' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tributo', @level2type=N'COLUMN',@level2name=N'ds_tributo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Valor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tributo', @level2type=N'COLUMN',@level2name=N'vl_inicial'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'IsRetido' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tributo', @level2type=N'COLUMN',@level2name=N'is_nf_retido'
GO
/****** Object:  Table [dbo].[tb_cor_tributo_cliente]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_cor_tributo_cliente](
	[id_tributo] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[nr_nota] [varchar](4) COLLATE Latin1_General_CI_AI NOT NULL,
	[vl_tributo] [numeric](10, 2) NOT NULL,
	[ds_observacao] [varchar](50) COLLATE Latin1_General_CI_AI NULL,
 CONSTRAINT [PK_tb_fin_tributo_cliente] PRIMARY KEY CLUSTERED 
(
	[id_tributo] ASC,
	[id_cliente] ASC,
	[nr_nota] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CodigoTributo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tributo_cliente', @level2type=N'COLUMN',@level2name=N'id_tributo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tributo_cliente', @level2type=N'COLUMN',@level2name=N'id_cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'NotaFiscal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tributo_cliente', @level2type=N'COLUMN',@level2name=N'nr_nota'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Valor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tributo_cliente', @level2type=N'COLUMN',@level2name=N'vl_tributo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Observacao' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_tributo_cliente', @level2type=N'COLUMN',@level2name=N'ds_observacao'
GO
/****** Object:  Table [dbo].[tb_cor_unidade]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_cor_unidade](
	[id_unidade] [int] IDENTITY(1,1) NOT NULL,
	[sg_unidade] [varchar](10) COLLATE Latin1_General_CI_AI NOT NULL,
	[ds_unidade] [varchar](50) COLLATE Latin1_General_CI_AI NOT NULL,
 CONSTRAINT [PK_tb_cor_unidade] PRIMARY KEY CLUSTERED 
(
	[id_unidade] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_unidade', @level2type=N'COLUMN',@level2name=N'id_unidade'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Sigla' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_unidade', @level2type=N'COLUMN',@level2name=N'sg_unidade'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descricao' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_cor_unidade', @level2type=N'COLUMN',@level2name=N'ds_unidade'
GO
/****** Object:  Table [dbo].[tb_por_acesso]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_por_acesso](
	[id_acesso] [int] IDENTITY(1,1) NOT NULL,
	[ds_acesso] [varchar](50) COLLATE Latin1_General_CI_AI NOT NULL,
 CONSTRAINT [PK_tb_por_acesso] PRIMARY KEY CLUSTERED 
(
	[id_acesso] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_por_banners]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_por_banners](
	[id_banner] [int] IDENTITY(1,1) NOT NULL,
	[id_portal] [int] NULL,
	[ds_image] [varchar](100) COLLATE Latin1_General_CI_AI NULL,
	[ds_link] [varchar](100) COLLATE Latin1_General_CI_AI NULL,
	[ds_alt_description] [varchar](100) COLLATE Latin1_General_CI_AI NULL,
	[qt_impressions] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_banners', @level2type=N'COLUMN',@level2name=N'id_banner'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Portal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_banners', @level2type=N'COLUMN',@level2name=N'id_portal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Imagem' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_banners', @level2type=N'COLUMN',@level2name=N'ds_image'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Link' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_banners', @level2type=N'COLUMN',@level2name=N'ds_link'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descricao' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_banners', @level2type=N'COLUMN',@level2name=N'ds_alt_description'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'QuantidadeMostradas' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_banners', @level2type=N'COLUMN',@level2name=N'qt_impressions'
GO
/****** Object:  Table [dbo].[tb_por_blog]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_por_blog](
	[id_blog] [int] IDENTITY(1,1) NOT NULL,
	[id_portal] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[ds_title] [varchar](50) COLLATE Latin1_General_CI_AI NULL,
	[dt_create] [smalldatetime] NULL,
 CONSTRAINT [PK_tb_por_blog] PRIMARY KEY CLUSTERED 
(
	[id_blog] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_blog', @level2type=N'COLUMN',@level2name=N'id_blog'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Portal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_blog', @level2type=N'COLUMN',@level2name=N'id_portal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_blog', @level2type=N'COLUMN',@level2name=N'id_usuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Titulo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_blog', @level2type=N'COLUMN',@level2name=N'ds_title'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Data' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_blog', @level2type=N'COLUMN',@level2name=N'dt_create'
GO
/****** Object:  Table [dbo].[tb_por_blog_post]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_por_blog_post](
	[id_post] [int] IDENTITY(1,1) NOT NULL,
	[id_blog] [int] NOT NULL,
	[dt_post] [varchar](50) COLLATE Latin1_General_CI_AI NULL,
	[ds_title] [varchar](50) COLLATE Latin1_General_CI_AI NULL,
	[ds_post] [text] COLLATE Latin1_General_CI_AI NULL,
 CONSTRAINT [PK_tb_por_blog_post] PRIMARY KEY CLUSTERED 
(
	[id_post] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_blog_post', @level2type=N'COLUMN',@level2name=N'id_post'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CodigoBlog' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_blog_post', @level2type=N'COLUMN',@level2name=N'id_blog'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Post' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_blog_post', @level2type=N'COLUMN',@level2name=N'dt_post'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Titulo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_blog_post', @level2type=N'COLUMN',@level2name=N'ds_title'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descricao' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_blog_post', @level2type=N'COLUMN',@level2name=N'ds_post'
GO
/****** Object:  Table [dbo].[tb_por_categoria]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_por_categoria](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[ds_categoria] [varchar](50) COLLATE Latin1_General_CI_AI NULL,
 CONSTRAINT [PK_tb_por_categoria] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_categoria', @level2type=N'COLUMN',@level2name=N'id_categoria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descricao' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_categoria', @level2type=N'COLUMN',@level2name=N'ds_categoria'
GO
/****** Object:  Table [dbo].[tb_por_menu]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_por_menu](
	[id_usuario] [int] NOT NULL,
	[id_modulo] [int] NOT NULL,
	[nr_ordem] [int] NULL,
 CONSTRAINT [PK_tb_por_menu] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[id_modulo] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_menu', @level2type=N'COLUMN',@level2name=N'id_usuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Modulo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_menu', @level2type=N'COLUMN',@level2name=N'id_modulo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ordem' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_menu', @level2type=N'COLUMN',@level2name=N'nr_ordem'
GO
/****** Object:  Table [dbo].[tb_por_menu_geral]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_por_menu_geral](
	[id_modulo] [int] NOT NULL,
	[nr_ordem] [int] NOT NULL,
 CONSTRAINT [PK_tb_por_menu_geral] PRIMARY KEY CLUSTERED 
(
	[id_modulo] ASC,
	[nr_ordem] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Modulo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_menu_geral', @level2type=N'COLUMN',@level2name=N'id_modulo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ordem' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_menu_geral', @level2type=N'COLUMN',@level2name=N'nr_ordem'
GO
/****** Object:  Table [dbo].[tb_por_modulo]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_por_modulo](
	[id_modulo] [int] IDENTITY(1,1) NOT NULL,
	[ds_modulo] [varchar](50) COLLATE Latin1_General_CI_AI NULL,
	[ds_caption] [varchar](20) COLLATE Latin1_General_CI_AI NOT NULL,
	[ds_tooltip] [varchar](50) COLLATE Latin1_General_CI_AI NULL,
	[ds_caminho] [varchar](50) COLLATE Latin1_General_CI_AI NOT NULL,
	[tp_modulo] [varchar](1) COLLATE Latin1_General_CI_AI NULL,
	[nr_ordem] [int] NULL,
 CONSTRAINT [PK_tb_por_modulo] PRIMARY KEY CLUSTERED 
(
	[id_modulo] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_modulo', @level2type=N'COLUMN',@level2name=N'id_modulo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Modulo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_modulo', @level2type=N'COLUMN',@level2name=N'ds_modulo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Caption' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_modulo', @level2type=N'COLUMN',@level2name=N'ds_caption'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ToolTip' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_modulo', @level2type=N'COLUMN',@level2name=N'ds_tooltip'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Caminho' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_modulo', @level2type=N'COLUMN',@level2name=N'ds_caminho'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tipo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_modulo', @level2type=N'COLUMN',@level2name=N'tp_modulo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ordem' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_modulo', @level2type=N'COLUMN',@level2name=N'nr_ordem'
GO
/****** Object:  Table [dbo].[tb_por_noticia]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_por_noticia](
	[id_noticia] [int] IDENTITY(1,1) NOT NULL,
	[id_portal] [int] NULL,
	[ds_titulo] [varchar](150) COLLATE Latin1_General_CI_AI NOT NULL,
	[ds_resumo] [varchar](255) COLLATE Latin1_General_CI_AI NULL,
	[ds_noticia] [text] COLLATE Latin1_General_CI_AI NULL,
	[dt_noticia] [datetime] NOT NULL,
	[dt_expira] [datetime] NULL,
	[id_usuario] [int] NOT NULL,
	[id_categoria] [int] NOT NULL,
	[nr_acessos] [int] NULL,
	[is_principal] [varchar](1) COLLATE Latin1_General_CI_AI NULL,
	[ds_fonte] [varchar](100) COLLATE Latin1_General_CI_AI NULL,
	[ds_link_fonte] [varchar](50) COLLATE Latin1_General_CI_AI NULL,
 CONSTRAINT [PK_tb_por_noticia] PRIMARY KEY CLUSTERED 
(
	[id_noticia] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_noticia', @level2type=N'COLUMN',@level2name=N'id_noticia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Portal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_noticia', @level2type=N'COLUMN',@level2name=N'id_portal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Titulo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_noticia', @level2type=N'COLUMN',@level2name=N'ds_titulo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Resumo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_noticia', @level2type=N'COLUMN',@level2name=N'ds_resumo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Noticia' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_noticia', @level2type=N'COLUMN',@level2name=N'ds_noticia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Data' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_noticia', @level2type=N'COLUMN',@level2name=N'dt_noticia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Expiracao' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_noticia', @level2type=N'COLUMN',@level2name=N'dt_expira'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_noticia', @level2type=N'COLUMN',@level2name=N'id_usuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Categoria' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_noticia', @level2type=N'COLUMN',@level2name=N'id_categoria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Acessos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_noticia', @level2type=N'COLUMN',@level2name=N'nr_acessos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'IsPrincipal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_noticia', @level2type=N'COLUMN',@level2name=N'is_principal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fonte' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_noticia', @level2type=N'COLUMN',@level2name=N'ds_fonte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'LinkFonte' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_noticia', @level2type=N'COLUMN',@level2name=N'ds_link_fonte'
GO
/****** Object:  Table [dbo].[tb_por_pergunta_enquete]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_por_pergunta_enquete](
	[id_pergunta] [int] IDENTITY(1,1) NOT NULL,
	[id_portal] [int] NOT NULL,
	[ds_pergunta] [varchar](100) COLLATE Latin1_General_CI_AI NOT NULL,
	[st_pergunta] [varchar](1) COLLATE Latin1_General_CI_AI NOT NULL,
 CONSTRAINT [PK_tb_por_pergunta_enquete] PRIMARY KEY CLUSTERED 
(
	[id_pergunta] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_pergunta_enquete', @level2type=N'COLUMN',@level2name=N'id_pergunta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Portal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_pergunta_enquete', @level2type=N'COLUMN',@level2name=N'id_portal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Pergunta' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_pergunta_enquete', @level2type=N'COLUMN',@level2name=N'ds_pergunta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Status' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_pergunta_enquete', @level2type=N'COLUMN',@level2name=N'st_pergunta'
GO
/****** Object:  Table [dbo].[tb_por_portal]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_por_portal](
	[id_portal] [int] IDENTITY(1,1) NOT NULL,
	[ds_portal] [varchar](50) COLLATE Latin1_General_CI_AI NULL,
	[ds_endereco] [varchar](50) COLLATE Latin1_General_CI_AI NULL,
	[st_portal] [varchar](1) COLLATE Latin1_General_CI_AI NOT NULL,
 CONSTRAINT [PK_tb_por_portal] PRIMARY KEY CLUSTERED 
(
	[id_portal] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_portal', @level2type=N'COLUMN',@level2name=N'id_portal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descricao' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_portal', @level2type=N'COLUMN',@level2name=N'ds_portal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Endereco' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_portal', @level2type=N'COLUMN',@level2name=N'ds_endereco'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Status' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_portal', @level2type=N'COLUMN',@level2name=N'st_portal'
GO
/****** Object:  Table [dbo].[tb_por_portal_cliente]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_por_portal_cliente](
	[id_cliente] [int] NOT NULL,
	[id_portal] [int] NOT NULL,
 CONSTRAINT [PK_tb_por_portal_cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC,
	[id_portal] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_portal_cliente', @level2type=N'COLUMN',@level2name=N'id_cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Portal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_portal_cliente', @level2type=N'COLUMN',@level2name=N'id_portal'
GO
/****** Object:  Table [dbo].[tb_por_portal_usuario]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_por_portal_usuario](
	[id_portal] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
 CONSTRAINT [PK_tb_por_portal_usuario] PRIMARY KEY CLUSTERED 
(
	[id_portal] ASC,
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Portal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_portal_usuario', @level2type=N'COLUMN',@level2name=N'id_portal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_portal_usuario', @level2type=N'COLUMN',@level2name=N'id_usuario'
GO
/****** Object:  Table [dbo].[tb_por_resposta_enquete]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_por_resposta_enquete](
	[id_resposta] [int] IDENTITY(1,1) NOT NULL,
	[id_pergunta] [int] NOT NULL,
	[ds_resposta] [varchar](100) COLLATE Latin1_General_CI_AI NOT NULL,
	[qt_voto] [int] NULL,
 CONSTRAINT [PK_tb_por_resposta_enquete] PRIMARY KEY CLUSTERED 
(
	[id_resposta] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_resposta_enquete', @level2type=N'COLUMN',@level2name=N'id_resposta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CodigoPergunta' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_resposta_enquete', @level2type=N'COLUMN',@level2name=N'id_pergunta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Resposta' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_resposta_enquete', @level2type=N'COLUMN',@level2name=N'ds_resposta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Votos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_resposta_enquete', @level2type=N'COLUMN',@level2name=N'qt_voto'
GO
/****** Object:  Table [dbo].[tb_por_upload]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_por_upload](
	[id_upload] [int] IDENTITY(1,1) NOT NULL,
	[id_portal] [int] NOT NULL,
	[ds_nome_upload] [varchar](50) COLLATE Latin1_General_CI_AI NOT NULL,
	[ds_pasta_upload] [varchar](50) COLLATE Latin1_General_CI_AI NOT NULL,
 CONSTRAINT [PK_tb_por_upload] PRIMARY KEY CLUSTERED 
(
	[id_upload] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_upload', @level2type=N'COLUMN',@level2name=N'id_upload'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Portal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_upload', @level2type=N'COLUMN',@level2name=N'id_portal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nome' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_upload', @level2type=N'COLUMN',@level2name=N'ds_nome_upload'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Pasta' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_upload', @level2type=N'COLUMN',@level2name=N'ds_pasta_upload'
GO
/****** Object:  Table [dbo].[tb_por_usuario]    Script Date: 09/01/2008 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_por_usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_acesso] [int] NOT NULL,
	[ds_login] [varchar](10) COLLATE Latin1_General_CI_AI NOT NULL,
	[ds_senha] [varchar](15) COLLATE Latin1_General_CI_AI NOT NULL,
	[ds_dica_senha] [varchar](50) COLLATE Latin1_General_CI_AI NULL,
	[ds_nome] [varchar](50) COLLATE Latin1_General_CI_AI NULL,
	[ds_telefone] [varchar](15) COLLATE Latin1_General_CI_AI NULL,
	[ds_email] [varchar](100) COLLATE Latin1_General_CI_AI NULL,
	[ds_last_acess] [smalldatetime] NULL,
 CONSTRAINT [PK_tb_por_usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_usuario', @level2type=N'COLUMN',@level2name=N'id_usuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CodigoAcesso' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_usuario', @level2type=N'COLUMN',@level2name=N'id_acesso'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Login' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_usuario', @level2type=N'COLUMN',@level2name=N'ds_login'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Senha' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_usuario', @level2type=N'COLUMN',@level2name=N'ds_senha'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Dica' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_usuario', @level2type=N'COLUMN',@level2name=N'ds_dica_senha'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nome' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_usuario', @level2type=N'COLUMN',@level2name=N'ds_nome'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Telefone' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_usuario', @level2type=N'COLUMN',@level2name=N'ds_telefone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Email' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_usuario', @level2type=N'COLUMN',@level2name=N'ds_email'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'UltimoAcesso' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_por_usuario', @level2type=N'COLUMN',@level2name=N'ds_last_acess'
GO
ALTER TABLE [dbo].[tb_cor_cidade]  WITH CHECK ADD  CONSTRAINT [FK_tb_por_cidade_tb_por_estado] FOREIGN KEY([sg_uf])
REFERENCES [dbo].[tb_cor_estado] ([sg_uf])
GO
ALTER TABLE [dbo].[tb_cor_cidade] CHECK CONSTRAINT [FK_tb_por_cidade_tb_por_estado]
GO
ALTER TABLE [dbo].[tb_cor_cliente]  WITH NOCHECK ADD  CONSTRAINT [FK_tb_cor_cliente_tb_cor_cliente] FOREIGN KEY([id_cliente_rel])
REFERENCES [dbo].[tb_cor_cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[tb_cor_cliente] NOCHECK CONSTRAINT [FK_tb_cor_cliente_tb_cor_cliente]
GO
ALTER TABLE [dbo].[tb_cor_cliente]  WITH CHECK ADD  CONSTRAINT [FK_tb_cor_cliente_tb_cor_tipo_cliente] FOREIGN KEY([id_tipo_cliente])
REFERENCES [dbo].[tb_cor_tipo_cliente] ([id_tipo_cliente])
GO
ALTER TABLE [dbo].[tb_cor_cliente] CHECK CONSTRAINT [FK_tb_cor_cliente_tb_cor_tipo_cliente]
GO
ALTER TABLE [dbo].[tb_cor_notafiscal]  WITH NOCHECK ADD  CONSTRAINT [FK_tb_por_notafiscal_tb_por_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[tb_cor_cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[tb_cor_notafiscal] CHECK CONSTRAINT [FK_tb_por_notafiscal_tb_por_cliente]
GO
ALTER TABLE [dbo].[tb_cor_notafiscal_aviso]  WITH CHECK ADD  CONSTRAINT [FK_tb_cor_notafiscal_aviso_tb_cor_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[tb_cor_cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[tb_cor_notafiscal_aviso] CHECK CONSTRAINT [FK_tb_cor_notafiscal_aviso_tb_cor_cliente]
GO
ALTER TABLE [dbo].[tb_cor_recibo]  WITH NOCHECK ADD  CONSTRAINT [FK_tb_cor_recibo_tb_cor_tarefa] FOREIGN KEY([id_tarefa])
REFERENCES [dbo].[tb_cor_tarefa] ([id_tarefa])
GO
ALTER TABLE [dbo].[tb_cor_recibo] CHECK CONSTRAINT [FK_tb_cor_recibo_tb_cor_tarefa]
GO
ALTER TABLE [dbo].[tb_cor_servico]  WITH CHECK ADD  CONSTRAINT [FK_tb_cor_servico_tb_cor_unidade] FOREIGN KEY([id_unidade])
REFERENCES [dbo].[tb_cor_unidade] ([id_unidade])
GO
ALTER TABLE [dbo].[tb_cor_servico] CHECK CONSTRAINT [FK_tb_cor_servico_tb_cor_unidade]
GO
ALTER TABLE [dbo].[tb_cor_tarefa]  WITH NOCHECK ADD  CONSTRAINT [FK_tb_cor_tarefa_tb_cor_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[tb_cor_cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[tb_cor_tarefa] CHECK CONSTRAINT [FK_tb_cor_tarefa_tb_cor_cliente]
GO
ALTER TABLE [dbo].[tb_cor_tarefa]  WITH NOCHECK ADD  CONSTRAINT [FK_tb_cor_tarefa_tb_cor_servico] FOREIGN KEY([id_servico])
REFERENCES [dbo].[tb_cor_servico] ([id_servico])
GO
ALTER TABLE [dbo].[tb_cor_tarefa] CHECK CONSTRAINT [FK_tb_cor_tarefa_tb_cor_servico]
GO
ALTER TABLE [dbo].[tb_cor_tarefa_item]  WITH NOCHECK ADD  CONSTRAINT [FK_tb_cor_tarefa_item_tb_cor_tarefa] FOREIGN KEY([id_tarefa])
REFERENCES [dbo].[tb_cor_tarefa] ([id_tarefa])
GO
ALTER TABLE [dbo].[tb_cor_tarefa_item] CHECK CONSTRAINT [FK_tb_cor_tarefa_item_tb_cor_tarefa]
GO
ALTER TABLE [dbo].[tb_cor_taxas]  WITH CHECK ADD  CONSTRAINT [FK_tb_fin_taxas_tb_fin_indice] FOREIGN KEY([id_indice])
REFERENCES [dbo].[tb_cor_indice] ([id_indice])
GO
ALTER TABLE [dbo].[tb_cor_taxas] CHECK CONSTRAINT [FK_tb_fin_taxas_tb_fin_indice]
GO
ALTER TABLE [dbo].[tb_cor_taxas]  WITH CHECK ADD  CONSTRAINT [FK_tb_fin_taxas_tb_fwk_mes] FOREIGN KEY([nr_mes])
REFERENCES [dbo].[tb_cor_mes] ([nr_mes])
GO
ALTER TABLE [dbo].[tb_cor_taxas] CHECK CONSTRAINT [FK_tb_fin_taxas_tb_fwk_mes]
GO
ALTER TABLE [dbo].[tb_por_banners]  WITH CHECK ADD  CONSTRAINT [FK_tb_por_ab_banners_tb_por_portal] FOREIGN KEY([id_portal])
REFERENCES [dbo].[tb_por_portal] ([id_portal])
GO
ALTER TABLE [dbo].[tb_por_banners] CHECK CONSTRAINT [FK_tb_por_ab_banners_tb_por_portal]
GO
ALTER TABLE [dbo].[tb_por_blog]  WITH CHECK ADD  CONSTRAINT [FK_tb_por_blog_tb_por_portal] FOREIGN KEY([id_portal])
REFERENCES [dbo].[tb_por_portal] ([id_portal])
GO
ALTER TABLE [dbo].[tb_por_blog] CHECK CONSTRAINT [FK_tb_por_blog_tb_por_portal]
GO
ALTER TABLE [dbo].[tb_por_blog_post]  WITH CHECK ADD  CONSTRAINT [FK_tb_por_blog_post_tb_por_blog] FOREIGN KEY([id_blog])
REFERENCES [dbo].[tb_por_blog] ([id_blog])
GO
ALTER TABLE [dbo].[tb_por_blog_post] CHECK CONSTRAINT [FK_tb_por_blog_post_tb_por_blog]
GO
ALTER TABLE [dbo].[tb_por_menu]  WITH CHECK ADD  CONSTRAINT [FK_tb_por_menu_tb_por_modulo] FOREIGN KEY([id_modulo])
REFERENCES [dbo].[tb_por_modulo] ([id_modulo])
GO
ALTER TABLE [dbo].[tb_por_menu] CHECK CONSTRAINT [FK_tb_por_menu_tb_por_modulo]
GO
ALTER TABLE [dbo].[tb_por_menu]  WITH NOCHECK ADD  CONSTRAINT [FK_tb_por_menu_tb_por_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[tb_por_usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[tb_por_menu] CHECK CONSTRAINT [FK_tb_por_menu_tb_por_usuario]
GO
ALTER TABLE [dbo].[tb_por_menu_geral]  WITH CHECK ADD  CONSTRAINT [FK_tb_por_menu_geral_tb_por_modulo] FOREIGN KEY([id_modulo])
REFERENCES [dbo].[tb_por_modulo] ([id_modulo])
GO
ALTER TABLE [dbo].[tb_por_menu_geral] CHECK CONSTRAINT [FK_tb_por_menu_geral_tb_por_modulo]
GO
ALTER TABLE [dbo].[tb_por_noticia]  WITH CHECK ADD  CONSTRAINT [FK_tb_por_noticia_tb_por_categoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[tb_por_categoria] ([id_categoria])
GO
ALTER TABLE [dbo].[tb_por_noticia] CHECK CONSTRAINT [FK_tb_por_noticia_tb_por_categoria]
GO
ALTER TABLE [dbo].[tb_por_noticia]  WITH CHECK ADD  CONSTRAINT [FK_tb_por_noticia_tb_por_portal] FOREIGN KEY([id_portal])
REFERENCES [dbo].[tb_por_portal] ([id_portal])
GO
ALTER TABLE [dbo].[tb_por_noticia] CHECK CONSTRAINT [FK_tb_por_noticia_tb_por_portal]
GO
ALTER TABLE [dbo].[tb_por_pergunta_enquete]  WITH CHECK ADD  CONSTRAINT [FK_tb_por_pergunta_enquete_tb_por_portal] FOREIGN KEY([id_portal])
REFERENCES [dbo].[tb_por_portal] ([id_portal])
GO
ALTER TABLE [dbo].[tb_por_pergunta_enquete] CHECK CONSTRAINT [FK_tb_por_pergunta_enquete_tb_por_portal]
GO
ALTER TABLE [dbo].[tb_por_portal_cliente]  WITH CHECK ADD  CONSTRAINT [FK_tb_por_portal_cliente_tb_cor_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[tb_cor_cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[tb_por_portal_cliente] CHECK CONSTRAINT [FK_tb_por_portal_cliente_tb_cor_cliente]
GO
ALTER TABLE [dbo].[tb_por_portal_cliente]  WITH CHECK ADD  CONSTRAINT [FK_tb_por_portal_cliente_tb_por_portal] FOREIGN KEY([id_portal])
REFERENCES [dbo].[tb_por_portal] ([id_portal])
GO
ALTER TABLE [dbo].[tb_por_portal_cliente] CHECK CONSTRAINT [FK_tb_por_portal_cliente_tb_por_portal]
GO
ALTER TABLE [dbo].[tb_por_portal_usuario]  WITH CHECK ADD  CONSTRAINT [FK_tb_por_portal_usuario_tb_por_portal] FOREIGN KEY([id_portal])
REFERENCES [dbo].[tb_por_portal] ([id_portal])
GO
ALTER TABLE [dbo].[tb_por_portal_usuario] CHECK CONSTRAINT [FK_tb_por_portal_usuario_tb_por_portal]
GO
ALTER TABLE [dbo].[tb_por_portal_usuario]  WITH NOCHECK ADD  CONSTRAINT [FK_tb_por_portal_usuario_tb_por_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[tb_por_usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[tb_por_portal_usuario] CHECK CONSTRAINT [FK_tb_por_portal_usuario_tb_por_usuario]
GO
ALTER TABLE [dbo].[tb_por_resposta_enquete]  WITH CHECK ADD  CONSTRAINT [FK_tb_por_resposta_enquete_tb_por_pergunta_enquete] FOREIGN KEY([id_pergunta])
REFERENCES [dbo].[tb_por_pergunta_enquete] ([id_pergunta])
GO
ALTER TABLE [dbo].[tb_por_resposta_enquete] CHECK CONSTRAINT [FK_tb_por_resposta_enquete_tb_por_pergunta_enquete]
GO
ALTER TABLE [dbo].[tb_por_upload]  WITH CHECK ADD  CONSTRAINT [FK_tb_por_upload_tb_por_portal] FOREIGN KEY([id_portal])
REFERENCES [dbo].[tb_por_portal] ([id_portal])
GO
ALTER TABLE [dbo].[tb_por_upload] CHECK CONSTRAINT [FK_tb_por_upload_tb_por_portal]
GO
ALTER TABLE [dbo].[tb_por_usuario]  WITH NOCHECK ADD  CONSTRAINT [FK_tb_por_usuario_tb_por_acesso] FOREIGN KEY([id_acesso])
REFERENCES [dbo].[tb_por_acesso] ([id_acesso])
GO
ALTER TABLE [dbo].[tb_por_usuario] CHECK CONSTRAINT [FK_tb_por_usuario_tb_por_acesso]