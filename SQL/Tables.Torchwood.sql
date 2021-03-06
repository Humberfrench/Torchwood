USE [Torchwood_Dev]
GO
/****** Object:  Table [dbo].[tb_tor_dezenas]    Script Date: 11/21/2009 17:36:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_tor_dezenas](
	[id_dezena] [int] IDENTITY(1,1) NOT NULL,
	[id_loteria] [tinyint] NOT NULL,
	[nr_concurso] [smallint] NOT NULL,
	[dt_concurso] [datetime] NOT NULL,
	[nr_dezena] [tinyint] NOT NULL,
 CONSTRAINT [PK_tb_tor_dezenas] PRIMARY KEY CLUSTERED 
(
	[id_dezena] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_tor_loteria]    Script Date: 11/21/2009 17:36:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_tor_loteria](
	[id_loteria] [tinyint] NOT NULL,
	[nm_loteria] [varchar](50) NOT NULL,
	[qt_dezenas] [tinyint] NOT NULL,
	[qt_min_occurs] [tinyint] NOT NULL,
	[nr_dez_min] [tinyint] NOT NULL,
	[nr_dez_max] [tinyint] NOT NULL,
	[nr_qt_dezenas_total] [tinyint] NOT NULL,
	[st_loteria] [varchar](1) NOT NULL,
 CONSTRAINT [PK_tb_tor_loteria] PRIMARY KEY CLUSTERED 
(
	[id_loteria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_tor_loteria_rol]    Script Date: 11/21/2009 17:36:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_tor_loteria_rol](
	[id_loteria] [tinyint] NOT NULL,
	[id_rol] [tinyint] NOT NULL,
	[ds_rol] [varchar](50) NOT NULL,
	[ds_ponto_medio] [smallint] NULL,
 CONSTRAINT [PK_tb_tor_loteria_rol] PRIMARY KEY CLUSTERED 
(
	[id_loteria] ASC,
	[id_rol] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_tor_loteria_rol_item]    Script Date: 11/21/2009 17:36:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_tor_loteria_rol_item](
	[id_loteria] [tinyint] NOT NULL,
	[id_rol] [tinyint] NOT NULL,
	[nr_dezena] [tinyint] NOT NULL,
 CONSTRAINT [PK_tb_tor_rol_item] PRIMARY KEY CLUSTERED 
(
	[id_loteria] ASC,
	[id_rol] ASC,
	[nr_dezena] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_tor_loteria_timemania]    Script Date: 11/21/2009 17:36:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_tor_loteria_timemania](
	[id_time] [int] IDENTITY(1,1) NOT NULL,
	[nm_time] [varchar](100) NOT NULL,
	[uf_time] [varchar](2) NULL,
 CONSTRAINT [PK_tb_tor_loteria_timemania] PRIMARY KEY CLUSTERED 
(
	[id_time] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_tor_sequencias_repetidas]    Script Date: 11/21/2009 17:36:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_tor_sequencias_repetidas](
	[id_sequencia] [int] IDENTITY(1,1) NOT NULL,
	[id_loteria] [tinyint] NOT NULL,
	[nr_concurso] [int] NOT NULL,
	[qt_item_ocorrencias] [tinyint] NOT NULL,
 CONSTRAINT [PK_tb_tor_sequencias_repetidas] PRIMARY KEY CLUSTERED 
(
	[id_sequencia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_tor_temp_dezena]    Script Date: 11/21/2009 17:36:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_tor_temp_dezena](
	[id_guid_dezena] [uniqueidentifier] NOT NULL,
	[nr_dezena] [int] NOT NULL,
 CONSTRAINT [PK_tb_tor_temp_dezena] PRIMARY KEY CLUSTERED 
(
	[id_guid_dezena] ASC,
	[nr_dezena] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[tb_tor_dezenas]  WITH CHECK ADD  CONSTRAINT [FK_tb_tor_dezenas_tb_tor_loteria] FOREIGN KEY([id_loteria])
REFERENCES [dbo].[tb_tor_loteria] ([id_loteria])
GO
ALTER TABLE [dbo].[tb_tor_dezenas] CHECK CONSTRAINT [FK_tb_tor_dezenas_tb_tor_loteria]
GO
ALTER TABLE [dbo].[tb_tor_loteria_rol]  WITH CHECK ADD  CONSTRAINT [FK_tb_tor_loteria_rol_tb_tor_loteria] FOREIGN KEY([id_loteria])
REFERENCES [dbo].[tb_tor_loteria] ([id_loteria])
GO
ALTER TABLE [dbo].[tb_tor_loteria_rol] CHECK CONSTRAINT [FK_tb_tor_loteria_rol_tb_tor_loteria]
GO
ALTER TABLE [dbo].[tb_tor_loteria_rol_item]  WITH CHECK ADD  CONSTRAINT [FK_tb_tor_loteria_rol_item_tb_tor_loteria_rol] FOREIGN KEY([id_loteria], [id_rol])
REFERENCES [dbo].[tb_tor_loteria_rol] ([id_loteria], [id_rol])
GO
ALTER TABLE [dbo].[tb_tor_loteria_rol_item] CHECK CONSTRAINT [FK_tb_tor_loteria_rol_item_tb_tor_loteria_rol]
GO
ALTER TABLE [dbo].[tb_tor_sequencias_repetidas]  WITH CHECK ADD  CONSTRAINT [FK_tb_tor_sequencias_repetidas_tb_tor_loteria] FOREIGN KEY([id_loteria])
REFERENCES [dbo].[tb_tor_loteria] ([id_loteria])
GO
ALTER TABLE [dbo].[tb_tor_sequencias_repetidas] CHECK CONSTRAINT [FK_tb_tor_sequencias_repetidas_tb_tor_loteria]