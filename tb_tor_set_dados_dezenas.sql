USE [torchwood]
GO
/****** Object:  Table [dbo].[tb_tor_set_dados_dezenas]    Script Date: 09/16/2010 13:25:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_tor_set_dados_dezenas](
	[id_set] [int] NOT NULL,
	[nr_dezena] [int] NOT NULL,
 CONSTRAINT [PK_tb_tor_set_dados_dezenas] PRIMARY KEY CLUSTERED 
(
	[id_set] ASC,
	[nr_dezena] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[tb_tor_set_dados_dezenas]  WITH CHECK ADD  CONSTRAINT [FK_tb_tor_set_dados_dezenas_tb_tor_set_dados] FOREIGN KEY([id_set])
REFERENCES [dbo].[tb_tor_set_dados] ([id_set])
GO
ALTER TABLE [dbo].[tb_tor_set_dados_dezenas] CHECK CONSTRAINT [FK_tb_tor_set_dados_dezenas_tb_tor_set_dados]