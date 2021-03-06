USE [torchwood]
GO
/****** Object:  Table [dbo].[tb_tor_set_dados]    Script Date: 09/16/2010 14:27:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_tor_set_dados](
	[id_set] [int] IDENTITY(1,1) NOT NULL,
	[id_loteria] [tinyint] NOT NULL,
	[ds_nome] [varchar](50) NOT NULL,
	[dt_consulta] [datetime] NOT NULL,
 CONSTRAINT [PK_tb_tor_set_dados_1] PRIMARY KEY CLUSTERED 
(
	[id_set] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tb_tor_set_dados]  WITH CHECK ADD  CONSTRAINT [FK_tb_tor_set_dados_tb_tor_loteria] FOREIGN KEY([id_loteria])
REFERENCES [dbo].[tb_tor_loteria] ([id_loteria])
GO
ALTER TABLE [dbo].[tb_tor_set_dados] CHECK CONSTRAINT [FK_tb_tor_set_dados_tb_tor_loteria]