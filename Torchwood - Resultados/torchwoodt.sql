USE [Torchwood]
GO
/****** Object:  Table [dbo].[tb_tor_temp_dezena]    Script Date: 03/29/2011 06:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_tor_temp_dezena]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_tor_temp_dezena](
	[id_guid_dezena] [uniqueidentifier] NOT NULL,
	[id_loteria] [tinyint] NOT NULL,
	[nr_dezena] [int] NOT NULL,
	[ds_nome_consulta] [varchar](50) NOT NULL,
	[dt_consulta] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_tb_tor_temp_dezena] PRIMARY KEY CLUSTERED 
(
	[id_guid_dezena] ASC,
	[id_loteria] ASC,
	[nr_dezena] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_tor_loteria_timemania]    Script Date: 03/29/2011 06:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_tor_loteria_timemania]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_tor_loteria_timemania](
	[id_time] [int] IDENTITY(1,1) NOT NULL,
	[nm_time] [varchar](100) NOT NULL,
	[uf_time] [varchar](2) NULL,
 CONSTRAINT [PK_tb_tor_loteria_timemania] PRIMARY KEY CLUSTERED 
(
	[id_time] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_tor_loteria]    Script Date: 03/29/2011 06:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_tor_loteria]') AND type in (N'U'))
BEGIN
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
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_exist_sequencias_repetidas]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_exist_sequencias_repetidas]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[pr_tor_exist_sequencias_repetidas]
(@id_loteria tinyint, @nr_concurso int)
AS

SELECT	1
FROM tb_tor_sequencias_repetidas 
WHERE id_loteria = @id_loteria
AND   nr_concurso = @nr_concurso 

' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_add_sequencias_repetidas]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_add_sequencias_repetidas]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
create procedure [dbo].[pr_tor_add_sequencias_repetidas]
(@id_loteria tinyint,  @nr_concurso int,  @qt_item_ocorrencias tinyint)
as

INSERT INTO tb_tor_sequencias_repetidas
(id_loteria,  nr_concurso, qt_item_ocorrencias)
values (@id_loteria,  @nr_concurso, @qt_item_ocorrencias)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_sel_loterias_names]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_sel_loterias_names]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pr_tor_sel_loterias_names]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT	id_loteria, 
			nm_loteria, 
			st_loteria 
	FROM	tb_tor_loteria
	WHERE	st_loteria = ''A''
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_upd_status_loteria]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_upd_status_loteria]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[pr_tor_upd_status_loteria]
(@id_loteria tinyint,
 @st_loteria varchar(01))
AS

BEGIN
		
	UPDATE tb_tor_loteria
	SET    st_loteria = @st_loteria	
	WHERE  id_loteria = @id_loteria
	    
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_upd_loteria]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_upd_loteria]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[pr_tor_upd_loteria]
(@id_loteria tinyint,
 @nm_loteria varchar(50),
 @qt_dezenas tinyint,
 @qt_min_occurs tinyint,
 @nr_dez_min tinyint,
 @nr_dez_max tinyint,
 @nr_qt_dezenas_total tinyint,
 @st_loteria varchar(01))
AS

BEGIN
		
	UPDATE tb_tor_loteria
	SET nm_loteria = @nm_loteria,
	    qt_dezenas = @qt_dezenas,
	    qt_min_occurs = @qt_min_occurs,
	    nr_dez_min = @nr_dez_min,
	    nr_dez_max = @nr_dez_max,
	    nr_qt_dezenas_total = @nr_qt_dezenas_total,
	    st_loteria = @st_loteria	
	WHERE  id_loteria = @id_loteria
	    
	
END
' 
END
GO
/****** Object:  Table [dbo].[tb_tor_cenario]    Script Date: 03/29/2011 06:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_tor_cenario]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_tor_cenario](
	[id_cenario] [int] IDENTITY(1,1) NOT NULL,
	[id_loteria] [tinyint] NOT NULL,
	[ds_cenario] [varchar](50) NOT NULL,
	[dt_cenario] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_tb_tor_cenario] PRIMARY KEY CLUSTERED 
(
	[id_cenario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_list_sequencias_repetidas]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_list_sequencias_repetidas]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
create procedure [dbo].[pr_tor_list_sequencias_repetidas]
(@id_loteria tinyint, @qt_item_ocorrencias int = 0)
AS

SELECT	a.id_sequencia, 
		a.id_loteria,  
		a.nr_concurso, 
		a.qt_item_ocorrencias,
		b.nm_loteria
FROM tb_tor_sequencias_repetidas a
JOIN	tb_tor_loteria b
ON a.id_loteria = b.id_loteria
AND a.id_loteria = @id_loteria
AND (a.qt_item_ocorrencias = @qt_item_ocorrencias 
     OR @qt_item_ocorrencias = 0)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_list_loteria_all]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_list_loteria_all]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[pr_tor_list_loteria_all]

AS

	select 	id_loteria,
		nm_loteria,
		qt_dezenas,
		qt_min_occurs,
		nr_dez_min,
		nr_dez_max,
		nr_qt_dezenas_total,
		st_loteria	
	from 	tb_tor_loteria
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_list_loteria]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_list_loteria]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[pr_tor_list_loteria]

AS

	select 	id_loteria,
		nm_loteria,
		qt_dezenas,
		qt_min_occurs,
		nr_dez_min,
		nr_dez_max,
		nr_qt_dezenas_total,
		st_loteria	
	from 	tb_tor_loteria
	WHERE st_loteria = ''A''
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_add_loteria]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_add_loteria]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[pr_tor_add_loteria]
(@nm_loteria varchar(50),
 @qt_dezenas tinyint,
 @qt_min_occurs tinyint,
 @nr_dez_min tinyint,
 @nr_dez_max tinyint,
 @nr_qt_dezenas_total tinyint,
 @st_loteria varchar(01))
AS

BEGIN
	
	DECLARE @id_loteria tinyint

	SELECT @id_loteria = (Max(id_loteria) + 1)
	FROM tb_tor_loteria
	
	INSERT INTO tb_tor_loteria
	(id_loteria,
	 nm_loteria,
	 qt_dezenas,
	 qt_min_occurs,
	 nr_dez_min,
	 nr_dez_max,
	 nr_qt_dezenas_total,
	 st_loteria)	
	VALUES
	(@id_loteria,
	 @nm_loteria,
	 @qt_dezenas,
	 @qt_min_occurs,
	 @nr_dez_min,
	 @nr_dez_max,
	 @nr_qt_dezenas_total,
	 @st_loteria)

	--retorno da proc.
	SELECT @id_loteria
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_loteria]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_loteria]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pr_tor_get_loteria] (@id_loteria int)
AS
BEGIN
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	SELECT a.id_loteria, 
		   a.nm_loteria, 
		   a.nr_dez_max, 
		   a.nr_dez_min, 
		   a.nr_qt_dezenas_total,
		   a.qt_dezenas,
		   a.qt_min_occurs,
		   a.st_loteria
	FROM   tb_tor_loteria a
	inner join tb_tor_loteria b
	on a.id_loteria = @id_loteria
	ORDER BY a.id_loteria 
		   
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_add_dezena_temp]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_add_dezena_temp]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pr_tor_add_dezena_temp] (
	                          @id_guid_dezena uniqueidentifier,
		             @nr_dezena int)
AS
INSERT INTO tb_tor_temp_dezena
(id_guid_dezena, nr_dezena)
VALUES (@id_guid_dezena, @nr_dezena)
' 
END
GO
/****** Object:  Table [dbo].[tb_tor_dezenas]    Script Date: 03/29/2011 06:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_tor_dezenas]') AND type in (N'U'))
BEGIN
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
END
GO
/****** Object:  Table [dbo].[tb_tor_set_dados]    Script Date: 03/29/2011 06:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_tor_set_dados]') AND type in (N'U'))
BEGIN
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
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_list_set_dados]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_list_set_dados]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

CREATE PROCEDURE [dbo].[pr_tor_list_set_dados]
AS

BEGIN
	
	SELECT a.id_set,
		   a.id_loteria,
	       a.ds_nome,
	       a.dt_consulta,
	       b.nm_loteria
	FROM tb_tor_set_dados a
	INNER JOIN tb_tor_loteria b
	ON     a.id_loteria = b.id_loteria
	AND    b.st_loteria = ''A''
	
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_add_set_dados]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_add_set_dados]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[pr_tor_add_set_dados]
(@id_loteria tinyint,
 @ds_nome varchar(50))
AS

BEGIN
	
	
	INSERT INTO tb_tor_set_dados
	(id_loteria,
	 ds_nome,
	 dt_consulta)	
	VALUES
	(@id_loteria,
	 @ds_nome,
	 getdate())

	--retorno da proc.
	SELECT @@identity
	
	
END
' 
END
GO
/****** Object:  Table [dbo].[tb_tor_set_dados_dezenas]    Script Date: 03/29/2011 06:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_tor_set_dados_dezenas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_tor_set_dados_dezenas](
	[id_set] [int] NOT NULL,
	[nr_dezena] [int] NOT NULL,
 CONSTRAINT [PK_tb_tor_set_dados_dezenas] PRIMARY KEY CLUSTERED 
(
	[id_set] ASC,
	[nr_dezena] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[tb_tor_cenario_detalhe]    Script Date: 03/29/2011 06:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_tor_cenario_detalhe]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_tor_cenario_detalhe](
	[id_cenario] [int] NOT NULL,
	[nr_item] [tinyint] NOT NULL,
	[nr_faixa_de] [tinyint] NOT NULL,
	[nr_faixa_ate] [tinyint] NOT NULL,
	[ds_ponto_medio] [tinyint] NOT NULL,
	[vl_faixa] [int] NULL,
	[vl_frequencia_faixa] [numeric](10, 2) NULL,
	[vl_frequencia_acum] [numeric](10, 2) NULL,
 CONSTRAINT [PK_tb_tor_cenario_detalhe] PRIMARY KEY CLUSTERED 
(
	[id_cenario] ASC,
	[nr_item] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_add_dezena]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_add_dezena]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pr_tor_add_dezena](@id_loteria integer, 
								   @nr_concurso integer,
								   @dt_concurso smalldatetime,
							  	   @nr_dezena integer)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO tb_tor_dezenas
			(id_loteria, 
			 nr_concurso,
			 dt_concurso,
			 nr_dezena)
	VALUES  (@id_loteria,
			 @nr_concurso,
			 @dt_concurso,
			 @nr_dezena)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_last_concurso_number]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_last_concurso_number]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE   procedure [dbo].[pr_tor_get_last_concurso_number] (@id_loteria integer = 0)
AS
select 	id_loteria , 
	max(nr_concurso) , 
	convert(varchar(10),max(dt_concurso), 103) dt_concurso
from tb_tor_dezenas
where (id_loteria = @id_loteria
or     @id_loteria = 0)
group by id_loteria 
order by id_loteria
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_last_concurso_all]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_last_concurso_all]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pr_tor_get_last_concurso_all] 
AS
BEGIN
	SET NOCOUNT ON;
	SELECT 	 id_loteria, max(nr_concurso) nr_concurso
	INTO	#tb_concurso
	FROM 	tb_tor_dezenas 
	GROUP BY id_loteria
        SELECT 	a.nr_dezena, 
	       	a.nr_concurso,
	       	 convert(varchar(10),a.dt_concurso,103) dt_concurso,
	       	b.nm_loteria
	FROM 	tb_tor_dezenas a
	JOIN 	tb_tor_loteria b
	ON 	a.id_loteria = b.id_loteria
	JOIN	#tb_concurso c
	ON 	a.id_loteria = c.id_loteria
	AND	a.nr_concurso = c.nr_concurso
	ORDER BY a.id_loteria, a.nr_dezena 
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_last_concurso]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_last_concurso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE  PROCEDURE [dbo].[pr_tor_get_last_concurso] (@id_loteria integer)
AS
BEGIN
	SET NOCOUNT ON;
	
	declare @int_concurso int
	SELECT 	@int_concurso = max(nr_concurso)
	FROM 	tb_tor_dezenas 
	GROUP BY id_loteria
	HAVING id_loteria = @id_loteria
        SELECT 	a.nr_dezena, 
	       	a.nr_concurso,
	       	convert(varchar(10),a.dt_concurso,103) dt_concurso,
	       	b.nm_loteria
	FROM 	tb_tor_dezenas a
	JOIN tb_tor_loteria b
	on 	a.id_loteria = b.id_loteria
	AND 	a.id_loteria = @id_loteria
	AND 	a.nr_concurso = @int_concurso
	ORDER BY a.nr_dezena 
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_exists_concurs]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_exists_concurs]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[pr_tor_get_exists_concurs]
(@id_loteria integer, @nr_concurso integer)

AS 

SELECT	DISTINCT 1 
FROM	tb_tor_dezenas
WHERE	id_loteria = @id_loteria
AND		nr_concurso = @nr_concurso

' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_best_results_all]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_best_results_all]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pr_tor_get_best_results_all] (@id_loteria int, 
												 @id_guid uniqueidentifier,
												 @conc_ini int = 0,
												 @conc_fim int = 0)
AS
--cadastrar as dezenas primeiro, com um guid unico, depois, executar esta proc e ele pega as dezenasdo guid para conferir.
SELECT count(id_dezena) qt_dezenas,  nr_concurso , dt_concurso
FROM tb_tor_dezenas
WHERE id_loteria = @id_loteria
AND nr_dezena  in ( SELECT nr_dezena 
		    from tb_tor_temp_dezena
		    WHERE  id_guid_dezena = @id_guid)
AND	(nr_concurso >= @conc_ini OR @conc_ini = 0)
AND (nr_concurso <= @conc_fim OR @conc_fim = 0)
GROUP BY nr_concurso , dt_concurso
ORDER BY qt_dezenas desc, nr_concurso asc

' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_best_results]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_best_results]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pr_tor_get_best_results] (@id_loteria int, 
												 @id_guid uniqueidentifier,
												 @conc_ini int = 0,
												 @conc_fim int = 0)
AS
--cadastrar as dezenas primeiro, com um guid unico, 
--depois, executar esta proc e ele pega as dezenasdo guid para conferir.
declare @nrMinOccurs tinyint

select @nrMinOccurs = qt_min_occurs
from tb_tor_loteria
where id_loteria = @id_loteria

SELECT count(id_dezena) qt_dezenas,  nr_concurso , dt_concurso
FROM tb_tor_dezenas
WHERE id_loteria = @id_loteria
AND nr_dezena  in ( SELECT nr_dezena 
		    from tb_tor_temp_dezena
		    WHERE  id_guid_dezena = @id_guid)
AND	(nr_concurso >= @conc_ini OR @conc_ini = 0)
AND (nr_concurso <= @conc_fim OR @conc_fim = 0)
GROUP BY nr_concurso , dt_concurso
having count(id_dezena) >= @nrMinOccurs
ORDER BY qt_dezenas desc, nr_concurso asc

' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_best_dezenas_top_impar]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_best_dezenas_top_impar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE  PROCEDURE [dbo].[pr_tor_get_best_dezenas_top_impar] (@id_loteria integer)
AS
BEGIN
	SET NOCOUNT ON;
	declare @int_total_lines float
        SELECT @int_total_lines = Count(a.nr_dezena)
	FROM tb_tor_dezenas a
	WHERE a.id_loteria = @id_loteria
	AND (nr_concurso%2) = 1
        SELECT a.nr_dezena, 
	       Count(a.nr_dezena) AS qt_dezena,
	       Count(a.nr_dezena) * 100 / @int_total_lines AS pc_dezena
	FROM tb_tor_dezenas a
	WHERE (nr_concurso%2) = 1
	GROUP BY a.nr_dezena, a.id_loteria
	HAVING a.id_loteria = @id_loteria
	ORDER BY Count(a.nr_dezena) DESC;
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_best_dezenas_top]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_best_dezenas_top]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE  PROCEDURE [dbo].[pr_tor_get_best_dezenas_top] (@id_loteria integer, @occurs integer)
AS
BEGIN
	SET NOCOUNT ON;
	--proc de verifcação de concursos multiplos de 2,5,6,10 (par, multpl de 3, multpl de 5 e final 0)
	declare @int_total_lines NUMERIC(8,3)
	declare @int_lines_conc NUMERIC(8,3)
	declare @qt_dezenas NUMERIC(8,3)
    
	SELECT	@qt_dezenas = qt_dezenas 
	FROM	tb_tor_loteria
	WHERE	id_loteria = @id_loteria

    SELECT	@int_lines_conc = (Count(a.nr_dezena) / @qt_dezenas),
			@int_total_lines = Count(a.nr_dezena) 
	FROM	tb_tor_dezenas a
	WHERE	a.id_loteria = @id_loteria
	AND (nr_concurso%@occurs) = 0

        SELECT a.nr_dezena, 
	       Count(a.nr_dezena) AS qt_dezena,
	       CONVERT(NUMERIC(8,3),Count(a.nr_dezena) * 100 / @int_total_lines) AS pc_dezena,
		   CONVERT(NUMERIC(8,3),Count(a.nr_dezena) * 100 / @int_lines_conc) AS pc_dezena_total,
		   @int_lines_conc total_concursos,
		   @int_total_lines total_dezenas
		FROM tb_tor_dezenas a
		WHERE (nr_concurso%@occurs) = 0
		GROUP BY a.nr_dezena, a.id_loteria
		HAVING a.id_loteria = @id_loteria
		ORDER BY Count(a.nr_dezena) DESC;

END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_best_dezenas_byrol_in_range]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_best_dezenas_byrol_in_range]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pr_tor_get_best_dezenas_byrol_in_range]
(@id_loteria integer, @conc_ini integer, @conc_fim integer) 
AS

	--proc especifica para listar dados para calculos estatísticos

	
	declare @int_total_lines NUMERIC(8,3)
	
        SELECT @int_total_lines = Count(a.nr_dezena)
		FROM tb_tor_dezenas a
		WHERE a.id_loteria = @id_loteria
		AND a.nr_concurso <= @conc_fim 
		AND a.nr_concurso >= @conc_ini 
	
        SELECT b.ds_rol, b.ds_ponto_medio,
	       Count(a.nr_dezena) AS qt_dezena,
	       CONVERT(NUMERIC(8,3),Count(a.nr_dezena) * 100 / @int_total_lines) AS pc_dezena
		FROM tb_tor_dezenas a
		JOIN tb_tor_loteria_rol b
		ON a.id_loteria = b.id_loteria
		JOIN tb_tor_loteria_rol_item c
		ON b.id_loteria = c.id_loteria
		AND b.id_rol = c.id_rol
		AND a.nr_dezena = c.nr_dezena
		WHERE a.nr_concurso <= @conc_fim 
		AND a.nr_concurso >= @conc_ini 
		GROUP BY b.ds_rol, a.id_loteria, b.ds_ponto_medio
		HAVING a.id_loteria = @id_loteria
		ORDER BY b.ds_rol
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_best_dezenas_byrol]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_best_dezenas_byrol]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pr_tor_get_best_dezenas_byrol](@id_loteria int) 
AS
	--proc especifica para listar dados para calculos estatísticos
	
	declare @int_total_lines NUMERIC(8,3)
	
        SELECT @int_total_lines = Count(a.nr_dezena)
	FROM tb_tor_dezenas a
	WHERE a.id_loteria = @id_loteria
	
        SELECT b.ds_rol, 
	       Count(a.nr_dezena) AS qt_dezena,
	       CONVERT(NUMERIC(8,3),Count(a.nr_dezena) * 100 / @int_total_lines) AS pc_dezena
	FROM tb_tor_dezenas a
	JOIN tb_tor_loteria_rol b
	ON a.id_loteria = b.id_loteria
	JOIN tb_tor_loteria_rol_item c
	ON b.id_loteria = c.id_loteria
	AND b.id_rol = c.id_rol
	AND a.nr_dezena = c.nr_dezena
	GROUP BY b.ds_rol, a.id_loteria
	HAVING a.id_loteria = @id_loteria
	ORDER BY b.ds_rol
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_best_dezenas]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_best_dezenas]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pr_tor_get_best_dezenas] (@id_loteria integer)
AS
BEGIN
	SET NOCOUNT ON;
	declare @int_total_lines NUMERIC(8,3)
	declare @int_lines_conc NUMERIC(8,3)
	declare @qt_dezenas NUMERIC(8,3)
    
	SELECT	@qt_dezenas = qt_dezenas 
	FROM	tb_tor_loteria
	WHERE	id_loteria = @id_loteria

    SELECT	@int_lines_conc = (Count(a.nr_dezena) / @qt_dezenas),
			@int_total_lines = Count(a.nr_dezena) 
	FROM	tb_tor_dezenas a
	WHERE	a.id_loteria = @id_loteria
	
        SELECT a.nr_dezena, 
	       Count(a.nr_dezena) AS qt_dezena,
	       CONVERT(NUMERIC(8,3),Count(a.nr_dezena) * 100 / @int_total_lines) AS pc_dezena,
		   CONVERT(NUMERIC(8,3),Count(a.nr_dezena) * 100 / @int_lines_conc) AS pc_dezena_total,
		   @int_lines_conc total_concursos,
		   @int_total_lines total_dezenas
	FROM tb_tor_dezenas a
	GROUP BY a.nr_dezena, a.id_loteria
	HAVING a.id_loteria = @id_loteria
	ORDER BY Count(a.nr_dezena) DESC;

END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_del_loteria]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_del_loteria]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[pr_tor_del_loteria] (@id_loteria int)
AS

BEGIN

	DECLARE @qtde_valores int

	--verifica se existe linhas nas dezenas
	SELECT 	@qtde_valores = Count(1)	
	FROM 	tb_tor_dezenas
	WHERE	id_loteria = @id_loteria

	--existindo linghas nas dezenas, atualiza o status, se não deleto 
	IF @qtde_valores > 0
	BEGIN
		UPDATE tb_tor_loteria
		SET st_loteria = ''I''
	END
	ELSE
	BEGIN
		DELETE 
		from 	tb_tor_loteria
		WHERE	id_loteria = @id_loteria
 	END

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_exist_loteria_dezena]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_exist_loteria_dezena]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pr_tor_exist_loteria_dezena] (@id_loteria int)
AS
BEGIN
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	SELECT 1
	FROM   tb_tor_dezenas a
	WHERE  a.id_loteria = @id_loteria
		   
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_resultados_timemania]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_resultados_timemania]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pr_tor_get_resultados_timemania] (@conc_ini int = 0, @conc_fim int = 0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
        -- Insert statements for procedure here
	
	create table #tb_timemania(
	nr_concurso integer,
	dt_concurso smalldatetime,
	nr_dezena1 integer, 
	nr_dezena2 integer, 
	nr_dezena3 integer, 
	nr_dezena4 integer, 
	nr_dezena5 integer, 
	nr_dezena6 integer,
	nr_dezena7 integer,
	nr_dezena_time integer,
	ds_time varchar(100) null,
	Uf_time varchar(2) null)

	/*variaveis do cursor*/
	DECLARE @nr_concurso integer
	DECLARE @dt_concurso smalldatetime
	DECLARE @nr_dezena integer 
	DECLARE @id_concurso_tmp integer
	DECLARE @dt_concurso_tmp smalldatetime
	/*variaveis do insert*/
	DECLARE @nr_dezena1 integer 
	DECLARE @nr_dezena2 integer 
	DECLARE @nr_dezena3 integer 
	DECLARE @nr_dezena4 integer 
	DECLARE @nr_dezena5 integer 
	DECLARE @nr_dezena6 integer
	DECLARE @nr_dezena7 integer
	DECLARE @nr_dezena_time integer
	DECLARE @int_cont   integer
	DECLARE @ds_time    varchar(100)
	DECLARE @uf_time    varchar(2)

	DECLARE cur_loteria_s1 CURSOR LOCAL
	FORWARD_ONLY
	FOR 
	SELECT nr_concurso,
		   dt_concurso,
		   nr_dezena
	FROM tb_tor_dezenas
	WHERE id_loteria = 7
	AND		(nr_concurso >= @conc_ini or @conc_ini = 0)
	AND		(nr_concurso <= @conc_fim or @conc_fim = 0)
	order by nr_concurso
	SELECT @int_cont = 0
	OPEN cur_loteria_s1
	FETCH NEXT FROM cur_loteria_s1 
	INTO @nr_concurso, @dt_concurso, @nr_dezena
	WHILE @@FETCH_STATUS = 0
		BEGIN
			SELECT @int_cont = @int_cont + 1
			
			IF @int_cont = 8
				SELECT @int_cont = 1
			--dezena 1
			IF @int_cont = 1
				SELECT @nr_dezena1 = @nr_dezena
			--dezena 2
			IF @int_cont = 2
				SELECT @nr_dezena2 = @nr_dezena
			--dezena 3
			IF @int_cont = 3
				SELECT @nr_dezena3 = @nr_dezena
			--dezena 4
			IF @int_cont = 4
				SELECT @nr_dezena4 = @nr_dezena
			--dezena 5
			IF @int_cont = 5
				SELECT @nr_dezena5 = @nr_dezena
			--dezena 6
			IF @int_cont = 6
				SELECT @nr_dezena6 = @nr_dezena
			--dezena 7
			IF @int_cont = 7
			BEGIN

				SELECT @nr_dezena7 = @nr_dezena
				SELECT	@nr_dezena_time = nr_dezena
				FROM	tb_tor_dezenas
				WHERE	id_loteria = 8
				and		nr_concurso = @nr_concurso

				SELECT @ds_time = nm_time , @uf_time = uf_time
				FROM	tb_tor_loteria_timemania
				WHERE	id_time = @nr_dezena_time	
				INSERT INTO #tb_timemania
					(nr_concurso,
					 dt_concurso,
					 nr_dezena1, 
					 nr_dezena2, 
					 nr_dezena3, 
					 nr_dezena4, 
					 nr_dezena5, 
					 nr_dezena6,
					 nr_dezena7,
					 nr_dezena_time,
					 ds_time,
					 uf_time)
				VALUES(
					   @nr_concurso,
					   @dt_concurso,
					   @nr_dezena1,
					   @nr_dezena2,
					   @nr_dezena3,
					   @nr_dezena4,
					   @nr_dezena5,
					   @nr_dezena6,
					   @nr_dezena7,
					   @nr_dezena_time,
					   @ds_time,
					   @uf_time)
			END
			FETCH NEXT FROM cur_loteria_s1 
			INTO @nr_concurso, @dt_concurso, @nr_dezena
			
		END
	CLOSE cur_loteria_s1
	DEALLOCATE cur_loteria_s1

	SELECT * 
	FROM #tb_timemania
	ORDER BY nr_concurso desc
	
	
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_resultados_quina]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_resultados_quina]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Humberto Almeida
-- Create date: 24/09/2007
-- Description:	Torchwood - liberação de dezenas por loteria
-- =============================================
CREATE PROCEDURE [dbo].[pr_tor_get_resultados_quina] (@conc_ini int = 0, @conc_fim int = 0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	
	create table #tb_quina(
	nr_concurso integer,
	dt_concurso smalldatetime,
	nr_dezena1 integer, 
	nr_dezena2 integer, 
	nr_dezena3 integer, 
	nr_dezena4 integer, 
	nr_dezena5 integer)
	/*variaveis do cursor*/
	DECLARE @nr_concurso integer
	DECLARE @dt_concurso smalldatetime
	DECLARE @nr_dezena integer 
	/*variaveis do insert*/
	DECLARE @nr_dezena1 integer 
	DECLARE @nr_dezena2 integer 
	DECLARE @nr_dezena3 integer 
	DECLARE @nr_dezena4 integer 
	DECLARE @nr_dezena5 integer 
	DECLARE @int_cont   integer
	DECLARE cur_loteria CURSOR LOCAL
	FORWARD_ONLY
	FOR 
	SELECT nr_concurso,
		   dt_concurso,
		   nr_dezena
	FROM tb_tor_dezenas
	WHERE id_loteria = 6
	AND		(nr_concurso >= @conc_ini or @conc_ini = 0)
	AND		(nr_concurso <= @conc_fim or @conc_fim = 0)
	order by nr_concurso
	SELECT @int_cont = 0
	OPEN cur_loteria
	FETCH NEXT FROM cur_loteria 
	INTO @nr_concurso, @dt_concurso, @nr_dezena
	WHILE @@FETCH_STATUS = 0
		BEGIN
			SELECT @int_cont = @int_cont + 1
			
			IF @int_cont = 6
				SELECT @int_cont = 1
			--dezena 1
			IF @int_cont = 1
				SELECT @nr_dezena1 = @nr_dezena
			--dezena 2
			IF @int_cont = 2
				SELECT @nr_dezena2 = @nr_dezena
			--dezena 3
			IF @int_cont = 3
				SELECT @nr_dezena3 = @nr_dezena
			--dezena 4
			IF @int_cont = 4
				SELECT @nr_dezena4 = @nr_dezena
			--dezena 5
			IF @int_cont = 5
			BEGIN
				SELECT @nr_dezena5 = @nr_dezena
				INSERT INTO #tb_quina
					(nr_concurso,
					 dt_concurso,
					 nr_dezena1, 
					 nr_dezena2, 
					 nr_dezena3, 
					 nr_dezena4, 
					 nr_dezena5)
				VALUES(
					   @nr_concurso,
					   @dt_concurso,
					   @nr_dezena1,
					   @nr_dezena2,
					   @nr_dezena3,
					   @nr_dezena4,
					   @nr_dezena5)
			END
			FETCH NEXT FROM cur_loteria 
			INTO @nr_concurso, @dt_concurso, @nr_dezena
			
		END
	CLOSE cur_loteria
	DEALLOCATE cur_loteria
	SELECT * 
	FROM #tb_quina
	order by dt_concurso desc
	
	
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_resultados_mega_sena]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_resultados_mega_sena]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Humberto Almeida
-- Create date: 24/09/2007
-- Description:	Torchwood - liberação de dezenas por loteria
-- =============================================
CREATE PROCEDURE [dbo].[pr_tor_get_resultados_mega_sena] (@conc_ini int = 0, @conc_fim int = 0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	
	create table #tb_mega_sena(
	nr_concurso integer,
	dt_concurso smalldatetime,
	nr_dezena1 integer, 
	nr_dezena2 integer, 
	nr_dezena3 integer, 
	nr_dezena4 integer, 
	nr_dezena5 integer, 
	nr_dezena6 integer)
	/*variaveis do cursor*/
	DECLARE @nr_concurso integer
	DECLARE @dt_concurso smalldatetime
	DECLARE @nr_dezena integer 
	DECLARE @id_concurso_tmp integer
	DECLARE @dt_concurso_tmp smalldatetime
	/*variaveis do insert*/
	DECLARE @nr_dezena1 integer 
	DECLARE @nr_dezena2 integer 
	DECLARE @nr_dezena3 integer 
	DECLARE @nr_dezena4 integer 
	DECLARE @nr_dezena5 integer 
	DECLARE @nr_dezena6 integer
	DECLARE @int_cont   integer
	DECLARE cur_loteria CURSOR LOCAL
	FORWARD_ONLY
	FOR 
	SELECT nr_concurso,
		   dt_concurso,
		   nr_dezena
	FROM tb_tor_dezenas
	WHERE id_loteria = 1
	AND		(nr_concurso >= @conc_ini or @conc_ini = 0)
	AND		(nr_concurso <= @conc_fim or @conc_fim = 0)
	order by nr_concurso
	SELECT @int_cont = 0
	OPEN cur_loteria
	FETCH NEXT FROM cur_loteria 
	INTO @nr_concurso, @dt_concurso, @nr_dezena
	WHILE @@FETCH_STATUS = 0
		BEGIN
			SELECT @int_cont = @int_cont + 1
			
			IF @int_cont = 7
				SELECT @int_cont = 1
			--dezena 1
			IF @int_cont = 1
				SELECT @nr_dezena1 = @nr_dezena
			--dezena 2
			IF @int_cont = 2
				SELECT @nr_dezena2 = @nr_dezena
			--dezena 3
			IF @int_cont = 3
				SELECT @nr_dezena3 = @nr_dezena
			--dezena 4
			IF @int_cont = 4
				SELECT @nr_dezena4 = @nr_dezena
			--dezena 5
			IF @int_cont = 5
				SELECT @nr_dezena5 = @nr_dezena
			--dezena 6
			IF @int_cont = 6
			BEGIN
				SELECT @nr_dezena6 = @nr_dezena
				INSERT INTO #tb_mega_sena
					(nr_concurso,
					 dt_concurso,
					 nr_dezena1, 
					 nr_dezena2, 
					 nr_dezena3, 
					 nr_dezena4, 
					 nr_dezena5, 
					 nr_dezena6)
				VALUES(
					   @nr_concurso, 
					   @dt_concurso,
					   @nr_dezena1,
					   @nr_dezena2,
					   @nr_dezena3,
					   @nr_dezena4,
					   @nr_dezena5,
					   @nr_dezena6)
			END
			FETCH NEXT FROM cur_loteria 
			INTO @nr_concurso, @dt_concurso, @nr_dezena
			
		END
	CLOSE cur_loteria
	DEALLOCATE cur_loteria
	SELECT * 
	FROM #tb_mega_sena
	order by nr_concurso desc
	
	
	
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_resultados_lotomania]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_resultados_lotomania]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Humberto Almeida
-- ALTER  date: 24/09/2007
-- Description:	Torchwood - liberação de dezenas por loteria
-- =============================================
CREATE PROCEDURE [dbo].[pr_tor_get_resultados_lotomania] (@conc_ini int = 0, @conc_fim int = 0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	
	create table #tb_lotomania(
	nr_concurso integer,
	dt_concurso varchar(12),
	nr_dezena01 integer, 
	nr_dezena02 integer, 
	nr_dezena03 integer, 
	nr_dezena04 integer, 
	nr_dezena05 integer,
	nr_dezena06 integer, 
	nr_dezena07 integer, 
	nr_dezena08 integer, 
	nr_dezena09 integer, 
	nr_dezena10 integer,
	nr_dezena11 integer, 
	nr_dezena12 integer, 
	nr_dezena13 integer, 
	nr_dezena14 integer, 
	nr_dezena15 integer,
	nr_dezena16 integer, 
	nr_dezena17 integer, 
	nr_dezena18 integer, 
	nr_dezena19 integer, 
	nr_dezena20 integer)
	/*variaveis do cursor*/
	DECLARE @nr_concurso integer
	DECLARE @dt_concurso varchar(12)
	DECLARE @nr_dezena integer 
	/*variaveis do insert*/
	DECLARE @nr_dezena01 integer,
			@nr_dezena02 integer,
			@nr_dezena03 integer,
			@nr_dezena04 integer,
			@nr_dezena05 integer,
			@nr_dezena06 integer,
			@nr_dezena07 integer,
			@nr_dezena08 integer,
			@nr_dezena09 integer,
			@nr_dezena10 integer,
			@nr_dezena11 integer,
			@nr_dezena12 integer,
			@nr_dezena13 integer,
			@nr_dezena14 integer,
			@nr_dezena15 integer,
			@nr_dezena16 integer,
			@nr_dezena17 integer,
			@nr_dezena18 integer,
			@nr_dezena19 integer,
			@nr_dezena20 integer,
		    @int_cont    integer
	DECLARE cur_loteria CURSOR LOCAL
	FORWARD_ONLY
	FOR 
	SELECT nr_concurso,
		   convert(varchar(12),dt_concurso,113),
		   nr_dezena
	FROM tb_tor_dezenas
	WHERE id_loteria = 4
	AND		(nr_concurso >= @conc_ini or @conc_ini = 0)
	AND		(nr_concurso <= @conc_fim or @conc_fim = 0)
	order by nr_concurso , nr_dezena
	SELECT @int_cont = 0
	OPEN cur_loteria
	FETCH NEXT FROM cur_loteria 
	INTO @nr_concurso, @dt_concurso, @nr_dezena
	WHILE @@FETCH_STATUS = 0
		BEGIN
			SELECT @int_cont = @int_cont + 1
			
			IF @int_cont = 21
				SELECT @int_cont = 1
			--dezena 01
			IF @int_cont = 1
				SELECT @nr_dezena01 = @nr_dezena
			--dezena 02
			IF @int_cont = 2
				SELECT @nr_dezena02 = @nr_dezena
			--dezena 03
			IF @int_cont = 3
				SELECT @nr_dezena03 = @nr_dezena
			--dezena 04
			IF @int_cont = 4
				SELECT @nr_dezena04 = @nr_dezena
			--dezena 05
			IF @int_cont = 5
				SELECT @nr_dezena05 = @nr_dezena
			--dezena 06
			IF @int_cont = 6
				SELECT @nr_dezena06 = @nr_dezena
			--dezena 07
			IF @int_cont = 7
				SELECT @nr_dezena07 = @nr_dezena
			--dezena 08
			IF @int_cont = 8
				SELECT @nr_dezena08 = @nr_dezena
			--dezena 09
			IF @int_cont = 9
				SELECT @nr_dezena09 = @nr_dezena
			--dezena 10
			IF @int_cont = 10
				SELECT @nr_dezena10 = @nr_dezena
			--dezena 11
			IF @int_cont = 11
				SELECT @nr_dezena11 = @nr_dezena
			--dezena 12
			IF @int_cont = 12
				SELECT @nr_dezena12 = @nr_dezena
			--dezena 13
			IF @int_cont = 13
				SELECT @nr_dezena13 = @nr_dezena
			--dezena 14
			IF @int_cont = 14
				SELECT @nr_dezena14 = @nr_dezena
			--dezena 15
			IF @int_cont = 15
				SELECT @nr_dezena15 = @nr_dezena
			--dezena 16
			IF @int_cont = 16
				SELECT @nr_dezena16 = @nr_dezena
			--dezena 17
			IF @int_cont = 17
				SELECT @nr_dezena17 = @nr_dezena
			--dezena 18
			IF @int_cont = 18
				SELECT @nr_dezena18 = @nr_dezena
			
			--dezena 19
			IF @int_cont = 19
				SELECT @nr_dezena19 = @nr_dezena
			--dezena 20
			IF @int_cont = 20
			BEGIN
				SELECT @nr_dezena20 = @nr_dezena
				INSERT INTO #tb_lotomania
					(nr_concurso,
					 dt_concurso,
					 nr_dezena01,
					 nr_dezena02,
					 nr_dezena03,
					 nr_dezena04,
					 nr_dezena05,
					 nr_dezena06,
				         nr_dezena07,
					 nr_dezena08,
					 nr_dezena09,
					 nr_dezena10,
					 nr_dezena11,
					 nr_dezena12,
					 nr_dezena13,
					 nr_dezena14,
					 nr_dezena15,
					 nr_dezena16,
					 nr_dezena17,
					 nr_dezena18,
					 nr_dezena19,
					 nr_dezena20)
				VALUES(
					 @nr_concurso,
					 @dt_concurso,
					 @nr_dezena01,
					 @nr_dezena02,
					 @nr_dezena03,
					 @nr_dezena04,
					 @nr_dezena05,
					 @nr_dezena06,
				         @nr_dezena07,
					 @nr_dezena08,
					 @nr_dezena09,
					 @nr_dezena10,
					 @nr_dezena11,
					 @nr_dezena12,
					 @nr_dezena13,
					 @nr_dezena14,
					 @nr_dezena15,
					 @nr_dezena16,
					 @nr_dezena17,
					 @nr_dezena18,
					 @nr_dezena19,
					 @nr_dezena20)
			
			END
			FETCH NEXT FROM cur_loteria 
			INTO @nr_concurso, @dt_concurso, @nr_dezena
			
		END
	CLOSE cur_loteria
	DEALLOCATE cur_loteria
	SELECT * 
	FROM #tb_lotomania
	order by nr_concurso desc
	
	
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_resultados_lotofacil]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_resultados_lotofacil]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Humberto Almeida
-- ALTER  date: 24/09/2007
-- Description:	Torchwood - liberação de dezenas por loteria
-- =============================================
CREATE PROCEDURE [dbo].[pr_tor_get_resultados_lotofacil] (@conc_ini int = 0, @conc_fim int = 0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	
	create table #tb_lotofacil(
	nr_concurso integer,
	dt_concurso varchar(12),
	nr_dezena01 integer, 
	nr_dezena02 integer, 
	nr_dezena03 integer, 
	nr_dezena04 integer, 
	nr_dezena05 integer,
	nr_dezena06 integer, 
	nr_dezena07 integer, 
	nr_dezena08 integer, 
	nr_dezena09 integer, 
	nr_dezena10 integer,
	nr_dezena11 integer, 
	nr_dezena12 integer, 
	nr_dezena13 integer, 
	nr_dezena14 integer, 
	nr_dezena15 integer)
	/*variaveis do cursor*/
	DECLARE @nr_concurso integer
	DECLARE @dt_concurso varchar(12)
	DECLARE @nr_dezena integer 
	/*variaveis do insert*/
	DECLARE @nr_dezena01 integer,
			@nr_dezena02 integer,
			@nr_dezena03 integer,
			@nr_dezena04 integer,
			@nr_dezena05 integer,
			@nr_dezena06 integer,
			@nr_dezena07 integer,
			@nr_dezena08 integer,
			@nr_dezena09 integer,
			@nr_dezena10 integer,
			@nr_dezena11 integer,
			@nr_dezena12 integer,
			@nr_dezena13 integer,
			@nr_dezena14 integer,
			@nr_dezena15 integer,
		    @int_cont    integer
	DECLARE cur_loteria CURSOR LOCAL
	FORWARD_ONLY
	FOR 
	SELECT nr_concurso,
		   convert(varchar(12),dt_concurso,113),
		   nr_dezena
	FROM tb_tor_dezenas
	WHERE id_loteria = 5
	AND		(nr_concurso >= @conc_ini or @conc_ini = 0)
	AND		(nr_concurso <= @conc_fim or @conc_fim = 0)
	order by nr_concurso , nr_dezena
	SELECT @int_cont = 0
	OPEN cur_loteria
	FETCH NEXT FROM cur_loteria 
	INTO @nr_concurso, @dt_concurso, @nr_dezena
	WHILE @@FETCH_STATUS = 0
		BEGIN
			SELECT @int_cont = @int_cont + 1
			
			IF @int_cont = 16
				SELECT @int_cont = 1
			--dezena 01
			IF @int_cont = 1
				SELECT @nr_dezena01 = @nr_dezena
			--dezena 02
			IF @int_cont = 2
				SELECT @nr_dezena02 = @nr_dezena
			--dezena 03
			IF @int_cont = 3
				SELECT @nr_dezena03 = @nr_dezena
			--dezena 04
			IF @int_cont = 4
				SELECT @nr_dezena04 = @nr_dezena
			--dezena 05
			IF @int_cont = 5
				SELECT @nr_dezena05 = @nr_dezena
			--dezena 06
			IF @int_cont = 6
				SELECT @nr_dezena06 = @nr_dezena
			--dezena 07
			IF @int_cont = 7
				SELECT @nr_dezena07 = @nr_dezena
			--dezena 08
			IF @int_cont = 8
				SELECT @nr_dezena08 = @nr_dezena
			--dezena 09
			IF @int_cont = 9
				SELECT @nr_dezena09 = @nr_dezena
			--dezena 10
			IF @int_cont = 10
				SELECT @nr_dezena10 = @nr_dezena
			--dezena 11
			IF @int_cont = 11
				SELECT @nr_dezena11 = @nr_dezena
			--dezena 12
			IF @int_cont = 12
				SELECT @nr_dezena12 = @nr_dezena
			--dezena 13
			IF @int_cont = 13
				SELECT @nr_dezena13 = @nr_dezena
			--dezena 14
			IF @int_cont = 14
				SELECT @nr_dezena14 = @nr_dezena
			--dezena 5
			IF @int_cont = 15
			BEGIN
				SELECT @nr_dezena15 = @nr_dezena
				INSERT INTO #tb_lotofacil
					(nr_concurso,
					 dt_concurso,
					 nr_dezena01,
					 nr_dezena02,
					 nr_dezena03,
					 nr_dezena04,
					 nr_dezena05,
					 nr_dezena06,
				         nr_dezena07,
					 nr_dezena08,
					 nr_dezena09,
					 nr_dezena10,
					 nr_dezena11,
					 nr_dezena12,
					 nr_dezena13,
					 nr_dezena14,
					 nr_dezena15)
				VALUES(
					 @nr_concurso,
					 @dt_concurso,
					 @nr_dezena01,
					 @nr_dezena02,
					 @nr_dezena03,
					 @nr_dezena04,
					 @nr_dezena05,
					 @nr_dezena06,
				     @nr_dezena07,
					 @nr_dezena08,
					 @nr_dezena09,
					 @nr_dezena10,
					 @nr_dezena11,
					 @nr_dezena12,
					 @nr_dezena13,
					 @nr_dezena14,
					 @nr_dezena15)
			
			END
			FETCH NEXT FROM cur_loteria 
			INTO @nr_concurso, @dt_concurso, @nr_dezena
			
		END
	CLOSE cur_loteria
	DEALLOCATE cur_loteria
	SELECT nr_concurso ,
	dt_concurso,
	nr_dezena01 , 
	nr_dezena02 , 
	nr_dezena03 , 
	nr_dezena04 , 
	nr_dezena05 ,
	nr_dezena06 , 
	nr_dezena07 , 
	nr_dezena08 , 
	nr_dezena09 , 
	nr_dezena10 ,
	nr_dezena11 , 
	nr_dezena12 , 
	nr_dezena13 , 
	nr_dezena14 , 
	nr_dezena15  
	FROM #tb_lotofacil
	order by nr_concurso desc
	
	
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_resultados_dupla_sena_s2]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_resultados_dupla_sena_s2]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Humberto Almeida
-- Create date: 24/09/2007
-- Description:	Torchwood - liberação de dezenas por loteria
-- =============================================
CREATE PROCEDURE [dbo].[pr_tor_get_resultados_dupla_sena_s2] (@conc_ini int = 0, @conc_fim int = 0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	
	create table #tb_dupla_sena(
	nr_concurso integer,
	dt_concurso smalldatetime,
	nr_dezena1 integer, 
	nr_dezena2 integer, 
	nr_dezena3 integer, 
	nr_dezena4 integer, 
	nr_dezena5 integer, 
	nr_dezena6 integer)
	/*variaveis do cursor*/
	DECLARE @nr_concurso integer
	DECLARE @dt_concurso smalldatetime
	DECLARE @nr_dezena integer 
	DECLARE @id_concurso_tmp integer
	DECLARE @dt_concurso_tmp smalldatetime
	/*variaveis do insert*/
	DECLARE @nr_dezena1 integer 
	DECLARE @nr_dezena2 integer 
	DECLARE @nr_dezena3 integer 
	DECLARE @nr_dezena4 integer 
	DECLARE @nr_dezena5 integer 
	DECLARE @nr_dezena6 integer
	DECLARE @int_cont   integer
	DECLARE cur_loteria_s1 CURSOR LOCAL
	FORWARD_ONLY
	FOR 
	SELECT nr_concurso,
		   dt_concurso,
		   nr_dezena
	FROM tb_tor_dezenas
	WHERE id_loteria = 3
	AND		(nr_concurso >= @conc_ini or @conc_ini = 0)
	AND		(nr_concurso <= @conc_fim or @conc_fim = 0)
	order by nr_concurso
	SELECT @int_cont = 0
	OPEN cur_loteria_s1
	FETCH NEXT FROM cur_loteria_s1 
	INTO @nr_concurso, @dt_concurso, @nr_dezena
	WHILE @@FETCH_STATUS = 0
		BEGIN
			SELECT @int_cont = @int_cont + 1
			
			IF @int_cont = 7
				SELECT @int_cont = 1
			--dezena 1
			IF @int_cont = 1
				SELECT @nr_dezena1 = @nr_dezena
			--dezena 2
			IF @int_cont = 2
				SELECT @nr_dezena2 = @nr_dezena
			--dezena 3
			IF @int_cont = 3
				SELECT @nr_dezena3 = @nr_dezena
			--dezena 4
			IF @int_cont = 4
				SELECT @nr_dezena4 = @nr_dezena
			--dezena 5
			IF @int_cont = 5
				SELECT @nr_dezena5 = @nr_dezena
			--dezena 6
			IF @int_cont = 6
			BEGIN
				SELECT @nr_dezena6 = @nr_dezena
				INSERT INTO #tb_dupla_sena
					(nr_concurso,
					 dt_concurso,
					 nr_dezena1, 
					 nr_dezena2, 
					 nr_dezena3, 
					 nr_dezena4, 
					 nr_dezena5, 
					 nr_dezena6)
				VALUES(
					   @nr_concurso,
					   @dt_concurso,
					   @nr_dezena1,
					   @nr_dezena2,
					   @nr_dezena3,
					   @nr_dezena4,
					   @nr_dezena5,
					   @nr_dezena6)
			END
			FETCH NEXT FROM cur_loteria_s1 
			INTO @nr_concurso, @dt_concurso, @nr_dezena
			
		END
	CLOSE cur_loteria_s1
	DEALLOCATE cur_loteria_s1
	SELECT * 
	FROM #tb_dupla_sena
	ORDER BY nr_concurso desc
	
	
END




' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_resultados_dupla_sena_s1]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_resultados_dupla_sena_s1]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Humberto Almeida
-- Create date: 24/09/2007
-- Description:	Torchwood - liberação de dezenas por loteria
-- =============================================
CREATE PROCEDURE [dbo].[pr_tor_get_resultados_dupla_sena_s1] (@conc_ini int = 0, @conc_fim int = 0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	
	create table #tb_dupla_sena(
	nr_concurso integer,
	dt_concurso smalldatetime,
	nr_dezena1 integer, 
	nr_dezena2 integer, 
	nr_dezena3 integer, 
	nr_dezena4 integer, 
	nr_dezena5 integer, 
	nr_dezena6 integer)
	/*variaveis do cursor*/
	DECLARE @nr_concurso integer
	DECLARE @dt_concurso smalldatetime
	DECLARE @nr_dezena integer 
	DECLARE @id_concurso_tmp integer
	DECLARE @dt_concurso_tmp smalldatetime
	/*variaveis do insert*/
	DECLARE @nr_dezena1 integer 
	DECLARE @nr_dezena2 integer 
	DECLARE @nr_dezena3 integer 
	DECLARE @nr_dezena4 integer 
	DECLARE @nr_dezena5 integer 
	DECLARE @nr_dezena6 integer
	DECLARE @int_cont   integer
	DECLARE cur_loteria_s1 CURSOR LOCAL
	FORWARD_ONLY
	FOR 
	SELECT	nr_concurso,
			dt_concurso,
			nr_dezena
	FROM	tb_tor_dezenas
	WHERE	id_loteria = 2
	AND		(nr_concurso >= @conc_ini or @conc_ini = 0)
	AND		(nr_concurso <= @conc_fim or @conc_fim = 0)
	order by nr_concurso
	SELECT @int_cont = 0
	OPEN cur_loteria_s1
	FETCH NEXT FROM cur_loteria_s1 
	INTO @nr_concurso, @dt_concurso, @nr_dezena
	WHILE @@FETCH_STATUS = 0
		BEGIN
			SELECT @int_cont = @int_cont + 1
			
			IF @int_cont = 7
				SELECT @int_cont = 1
			--dezena 1
			IF @int_cont = 1
				SELECT @nr_dezena1 = @nr_dezena
			--dezena 2
			IF @int_cont = 2
				SELECT @nr_dezena2 = @nr_dezena
			--dezena 3
			IF @int_cont = 3
				SELECT @nr_dezena3 = @nr_dezena
			--dezena 4
			IF @int_cont = 4
				SELECT @nr_dezena4 = @nr_dezena
			--dezena 5
			IF @int_cont = 5
				SELECT @nr_dezena5 = @nr_dezena
			--dezena 6
			IF @int_cont = 6
			BEGIN
				SELECT @nr_dezena6 = @nr_dezena
				INSERT INTO #tb_dupla_sena
					(nr_concurso,
					 dt_concurso,
					 nr_dezena1, 
					 nr_dezena2, 
					 nr_dezena3, 
					 nr_dezena4, 
					 nr_dezena5, 
					 nr_dezena6)
				VALUES(
					   @nr_concurso,
					   @dt_concurso,
					   @nr_dezena1,
					   @nr_dezena2,
					   @nr_dezena3,
					   @nr_dezena4,
					   @nr_dezena5,
					   @nr_dezena6)
			END
			FETCH NEXT FROM cur_loteria_s1 
			INTO @nr_concurso, @dt_concurso, @nr_dezena
			
		END
	CLOSE cur_loteria_s1
	DEALLOCATE cur_loteria_s1
	SELECT * 
	FROM #tb_dupla_sena
	ORDER BY nr_concurso desc
	
	
END




' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_resultados_dupla_sena]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_resultados_dupla_sena]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Humberto Almeida
-- Create date: 24/09/2007
-- Description:	Torchwood - liberação de dezenas por loteria
-- =============================================
CREATE PROCEDURE [dbo].[pr_tor_get_resultados_dupla_sena] (@conc_ini int = 0, @conc_fim int = 0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	
	create table #tb_dupla_sena(
	nr_concurso integer,
	tp_sorteio varchar(10),
	dt_concurso smalldatetime,
	nr_dezena1 integer, 
	nr_dezena2 integer, 
	nr_dezena3 integer, 
	nr_dezena4 integer, 
	nr_dezena5 integer, 
	nr_dezena6 integer)
	/*variaveis do cursor*/
	DECLARE @nr_concurso integer
	DECLARE @dt_concurso smalldatetime
	DECLARE @nr_dezena integer 
	DECLARE @id_concurso_tmp integer
	DECLARE @dt_concurso_tmp smalldatetime
	/*variaveis do insert*/
	DECLARE @nr_dezena1 integer 
	DECLARE @nr_dezena2 integer 
	DECLARE @nr_dezena3 integer 
	DECLARE @nr_dezena4 integer 
	DECLARE @nr_dezena5 integer 
	DECLARE @nr_dezena6 integer
	DECLARE @int_cont   integer
	DECLARE cur_loteria_s1 CURSOR LOCAL
	FORWARD_ONLY
	FOR 
	SELECT nr_concurso,
		   dt_concurso,
		   nr_dezena
	FROM tb_tor_dezenas
	WHERE id_loteria = 2
	AND		(nr_concurso >= @conc_ini or @conc_ini = 0)
	AND		(nr_concurso <= @conc_fim or @conc_fim = 0)
	order by nr_concurso
	SELECT @int_cont = 0
	OPEN cur_loteria_s1
	FETCH NEXT FROM cur_loteria_s1 
	INTO @nr_concurso, @dt_concurso, @nr_dezena
	WHILE @@FETCH_STATUS = 0
		BEGIN
			SELECT @int_cont = @int_cont + 1
			
			IF @int_cont = 7
				SELECT @int_cont = 1
			--dezena 1
			IF @int_cont = 1
				SELECT @nr_dezena1 = @nr_dezena
			--dezena 2
			IF @int_cont = 2
				SELECT @nr_dezena2 = @nr_dezena
			--dezena 3
			IF @int_cont = 3
				SELECT @nr_dezena3 = @nr_dezena
			--dezena 4
			IF @int_cont = 4
				SELECT @nr_dezena4 = @nr_dezena
			--dezena 5
			IF @int_cont = 5
				SELECT @nr_dezena5 = @nr_dezena
			--dezena 6
			IF @int_cont = 6
			BEGIN
				SELECT @nr_dezena6 = @nr_dezena
				INSERT INTO #tb_dupla_sena
					(nr_concurso,
					 tp_sorteio,
					 dt_concurso,
					 nr_dezena1, 
					 nr_dezena2, 
					 nr_dezena3, 
					 nr_dezena4, 
					 nr_dezena5, 
					 nr_dezena6)
				VALUES(
					   @nr_concurso,
					   ''SORTEIO 01'', 
					   @dt_concurso,
					   @nr_dezena1,
					   @nr_dezena2,
					   @nr_dezena3,
					   @nr_dezena4,
					   @nr_dezena5,
					   @nr_dezena6)
			END
			FETCH NEXT FROM cur_loteria_s1 
			INTO @nr_concurso, @dt_concurso, @nr_dezena
			
		END
	CLOSE cur_loteria_s1
	DEALLOCATE cur_loteria_s1
	DECLARE cur_loteria_s2 CURSOR LOCAL
	FORWARD_ONLY
	FOR 
	SELECT nr_concurso,
		   dt_concurso,
		   nr_dezena
	FROM tb_tor_dezenas
	WHERE id_loteria = 3
	order by nr_concurso
	SELECT @int_cont = 0
	OPEN cur_loteria_s2
	FETCH NEXT FROM cur_loteria_s2 
	INTO @nr_concurso, @dt_concurso, @nr_dezena
	WHILE @@FETCH_STATUS = 0
		BEGIN
			SELECT @int_cont = @int_cont + 1
			
			IF @int_cont = 7
				SELECT @int_cont = 1
			--dezena 1
			IF @int_cont = 1
				SELECT @nr_dezena1 = @nr_dezena
			--dezena 2
			IF @int_cont = 2
				SELECT @nr_dezena2 = @nr_dezena
			--dezena 3
			IF @int_cont = 3
				SELECT @nr_dezena3 = @nr_dezena
			--dezena 4
			IF @int_cont = 4
				SELECT @nr_dezena4 = @nr_dezena
			--dezena 5
			IF @int_cont = 5
				SELECT @nr_dezena5 = @nr_dezena
			--dezena 6
			IF @int_cont = 6
			BEGIN
				SELECT @nr_dezena6 = @nr_dezena
				INSERT INTO #tb_dupla_sena
					(nr_concurso,
					 tp_sorteio,
					 dt_concurso,
					 nr_dezena1, 
					 nr_dezena2, 
					 nr_dezena3, 
					 nr_dezena4, 
					 nr_dezena5, 
					 nr_dezena6)
				VALUES(
					   @nr_concurso,
					   ''SORTEIO 02'', 
					   @dt_concurso,
					   @nr_dezena1,
					   @nr_dezena2,
					   @nr_dezena3,
					   @nr_dezena4,
					   @nr_dezena5,
					   @nr_dezena6)
			END
			FETCH NEXT FROM cur_loteria_s2 
			INTO @nr_concurso, @dt_concurso, @nr_dezena
			
		END
	CLOSE cur_loteria_s2
	DEALLOCATE cur_loteria_s2
	SELECT * 
	FROM #tb_dupla_sena
	ORDER BY nr_concurso desc, tp_sorteio asc
	
	
END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_resultado]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_resultado]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pr_tor_get_resultado](@id_loteria integer, @nr_concurso integer = 0)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id_loteria, 
		   nr_concurso,
		   dt_concurso,
		   nr_dezena
	FROM tb_tor_dezenas
	WHERE id_loteria = @id_loteria
	AND	  (nr_concurso = @nr_concurso OR @nr_concurso = 0)
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_list_concurso]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_list_concurso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create procedure [dbo].[pr_tor_list_concurso] (@id_loteria as integer)

AS

	select distinct nr_concurso 
	from tb_tor_dezenas
	where id_loteria = @id_loteria
	order by nr_concurso

' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_stats_all]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_stats_all]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pr_tor_get_stats_all] (@id_loteria int, 
										@faixa int)
AS
BEGIN
	SET NOCOUNT ON
	--variaveis deajuste
	DECLARE @int_total_lines NUMERIC(10,5)
	DECLARE @int_lines_conc NUMERIC(10,5)
	DECLARE	@int_total_lines_faixa NUMERIC(10,5)
	DECLARE @qt_dezenas NUMERIC(10,5)
	DECLARE @pc_media NUMERIC(10,5)
	DECLARE @pc_media_rounded NUMERIC(10,5)
	DECLARE @nr_conc_ini INT
	DECLARE @nr_conc_fim INT 
	DECLARE @nr_last_conc INT
    DECLARE @id_faixa INT
    DECLARE @ds_faixa VARCHAR(50)
	DECLARE	@status INT
	DECLARE	@qt_dezena_sup_faixa	INT 
	DECLARE	@qt_dezena_sup_round	INT 
	--variaveis do calculo do arredondamento
	DECLARE @round1 NUMERIC(10,5)
	DECLARE @round2 NUMERIC(10,5)
	DECLARE @media NUMERIC(10,5)
	--outras
	DECLARE @media_arit_sorteio NUMERIC(10,5)

	CREATE TABLE #tb_results(
	id_faixa				INT null,				-- código da faixa
	ds_faixa				VARCHAR(50) null,		-- descrição da faixa
	id_faixa_ini			INT	null,				-- faixa inicial
	id_faixa_fim			INT	null,				-- faixa inicial
	nr_dezena				INT null,				-- numero dadezena
	qt_dezena				NUMERIC(10,5) null,		-- qtde de ocorrencias
	pc_dezena				NUMERIC(10,5) null,		-- percentual de ocorrencias no intervalo (qtde concursos)
	pc_dezena_total			NUMERIC(10,5) null,		-- percentual de ocorrenciasem relacao ao evento amostral todo
	media_arit_sorteio		NUMERIC(10,5) null,		-- média aritimetica da faixa
	total_concursos			NUMERIC(10,5) null,		-- quantidade de concursos - faixa
	total_dezenas			NUMERIC(10,5) null,		-- quantidade total de dezenas envolvidas
	pc_media_faixa			NUMERIC(10,5) null,		-- percentual médio de todos os percentuais
	pc_media_faixa_round	NUMERIC(10,5) null,		-- percentual arredondado
	ind_dezena_sup_faixa	VARCHAR(01) null,		-- indicador da dezena estar com percentual superior a media
	ind_dezena_sup_round	VARCHAR(01) null,		-- indicador da dezena estar com percentual superior a media arredondada
	qt_dezena_sup_faixa		INT null,				-- qtde da dezena estar com percentual superior a media - ttl da faixa
	qt_dezena_sup_round		INT null)				-- qtde da dezena estar com percentual superior a media arredondada - ttl da faixa

	-- inicializando variáveis
	-- numeros de concursos e faixas
	SELECT	@id_faixa = 1, 
			@nr_conc_ini = 1, 
			@nr_conc_fim = @nr_conc_ini + @faixa -1 ,
			@ds_faixa = ''Faixa de '' + convert(varchar(5),@nr_conc_ini) + '' até '' + convert(varchar(5),@nr_conc_fim)	

	--número do ultimo concurso
	SELECT	@nr_last_conc = max(nr_concurso)
	FROM	tb_tor_dezenas
	WHERE	id_loteria = @id_loteria

	-- quantidade de dezenas da loteria
	SELECT	@qt_dezenas = CONVERT(NUMERIC(10,5),qt_dezenas),
			@int_total_lines_faixa = @faixa * @qt_dezenas
	FROM	tb_tor_loteria
	WHERE	id_loteria = @id_loteria

	SELECT @status = 0
	
	WHILE (@status = 0)
	BEGIN

		SELECT	@int_total_lines = CONVERT(NUMERIC(10,5),COUNT(a.nr_dezena)) 
		FROM	tb_tor_dezenas a
		WHERE	a.id_loteria = @id_loteria
		AND		a.nr_concurso > = @nr_conc_ini
		AND		a.nr_concurso < = @nr_conc_fim

		SELECT	@int_lines_conc =  @int_total_lines / @qt_dezenas
		FROM	tb_tor_dezenas a
		WHERE	a.id_loteria = @id_loteria
		AND		a.nr_concurso > = @nr_conc_ini
		AND		a.nr_concurso < = @nr_conc_fim

		INSERT INTO #tb_results
		SELECT	@id_faixa,
				@ds_faixa,
				@nr_conc_ini,
				@nr_conc_fim,
				a.nr_dezena, 
				COUNT(a.nr_dezena),
				CONVERT(NUMERIC(10,5),Count(a.nr_dezena)) * 100 / @int_total_lines,
				CONVERT(NUMERIC(10,5),Count(a.nr_dezena)) * 100 / @int_lines_conc,
				0,
				@int_lines_conc,
				@int_total_lines,
				0,
				0,
				''N'',
				''N'',
				0,
				0
		FROM tb_tor_dezenas a
		WHERE	a.nr_concurso > = @nr_conc_ini
		AND		a.nr_concurso < = @nr_conc_fim
		GROUP BY a.nr_dezena, a.id_loteria
		HAVING	a.id_loteria = @id_loteria
		ORDER BY a.nr_dezena

		-- calcular a média da faixa
		SELECT	@pc_media = AVG(pc_dezena_total)
		FROM	#tb_results
		WHERE	id_faixa = @id_faixa
		
		UPDATE	#tb_results
		SET		pc_media_faixa = @pc_media
		WHERE	id_faixa = @id_faixa

		UPDATE	#tb_results
		SET		ind_dezena_sup_faixa = ''S''
		WHERE	id_faixa = @id_faixa
		AND		pc_dezena_total >= @pc_media
		
		-- arredondar
		SELECT	@pc_media_rounded = 0,
				@round1 = 0, 
				@round2 = @round1 + 10,
				@media = (@round2 + @round1)/2

		WHILE (@round2 < 100)
		BEGIN
			IF @pc_media BETWEEN @round1 AND @round2
				BEGIN
					IF @pc_media BETWEEN @round1 AND @media
						IF @pc_media = @round1
							SELECT @pc_media_rounded = @round1
						ELSE
							SELECT @pc_media_rounded = @media
					ELSE
						IF @pc_media = @media
							SELECT @pc_media_rounded = @media
						ELSE
							SELECT @pc_media_rounded = @round2
				END

			SELECT	@round1 = @round2, 
					@round2 = @round2 + 10,
					@media = (@round2 + @round1)/2

		END

		-- atualizar médias
		UPDATE	#tb_results
		SET		pc_media_faixa_round = @pc_media_rounded
		WHERE	id_faixa = @id_faixa

		UPDATE	#tb_results
		SET		ind_dezena_sup_round = ''S''
		WHERE	id_faixa = @id_faixa
		AND		pc_dezena_total >= @pc_media_rounded


		SELECT	@qt_dezena_sup_faixa = COUNT(1)
		FROM	#tb_results
		WHERE	ind_dezena_sup_faixa = ''S''
		AND		id_faixa = @id_faixa 

		SELECT	@qt_dezena_sup_round = COUNT(1)
		FROM	#tb_results
		WHERE	ind_dezena_sup_round = ''S''
		AND		id_faixa = @id_faixa 
		
		SELECT  @media_arit_sorteio = AVG(CONVERT(numeric(10,5),nr_dezena))
		FROM	#tb_results
		WHERE	id_faixa = @id_faixa 
		
		UPDATE	#tb_results
		SET		qt_dezena_sup_faixa = @qt_dezena_sup_faixa,
				qt_dezena_sup_round = @qt_dezena_sup_round,
				media_arit_sorteio  = @media_arit_sorteio
		WHERE	id_faixa = @id_faixa 

		-- numeros de concursos e faixas
		SELECT	@id_faixa = @id_faixa + 1, 
				@nr_conc_ini = @nr_conc_ini + @faixa, 
				@nr_conc_fim = @nr_conc_fim + @faixa,
				@ds_faixa = ''Faixa de '' + convert(varchar(5),@nr_conc_ini) + '' até '' + convert(varchar(5),@nr_conc_fim)  
		

		IF (@nr_conc_ini > @nr_last_conc AND @nr_conc_fim > @nr_last_conc)
			SELECT @status = 1

	END

	SELECT * FROM #tb_results
	


END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_set_dados]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_set_dados]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[pr_tor_get_set_dados]
(@id_set int)
AS

BEGIN
	
	
	SELECT a.id_loteria,
	       a.ds_nome,
	       a.dt_consulta,
	       b.nm_loteria
	FROM tb_tor_set_dados a
	INNER JOIN tb_tor_loteria b
	ON     a.id_loteria = b.id_loteria
	AND    a.id_set = @id_set
	AND    b.st_loteria = ''A''
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_ver_sena_megasena]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_ver_sena_megasena]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pr_ver_sena_megasena]
(@id_dezena01 int, 
 @id_dezena02 int, 
 @id_dezena03 int, 
 @id_dezena04 int, 
 @id_dezena05 int)


AS


SELECT nr_concurso , count(1)
from tb_tor_dezenas 
where id_loteria = 1 
and nr_dezena in (@id_dezena01,@id_dezena02,@id_dezena03,@id_dezena04,@id_dezena05)
group by nr_concurso
having count(1) > 5

' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_ver_quina_megasena]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_ver_quina_megasena]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'


CREATE PROCEDURE [dbo].[pr_ver_quina_megasena]
(@id_dezena01 int, 
 @id_dezena02 int, 
 @id_dezena03 int, 
 @id_dezena04 int, 
 @id_dezena05 int)


AS


SELECT nr_concurso , count(1)
from tb_tor_dezenas 
where id_loteria = 1 
and nr_dezena in (@id_dezena01,@id_dezena02,@id_dezena03,@id_dezena04,@id_dezena05)
group by nr_concurso
having count(1) > 4


' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_ver_quadra_megasena]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_ver_quadra_megasena]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

CREATE PROCEDURE [dbo].[pr_ver_quadra_megasena]
(@id_dezena01 int, 
 @id_dezena02 int, 
 @id_dezena03 int, 
 @id_dezena04 int)


AS


SELECT nr_concurso , count(1)
from tb_tor_dezenas 
where id_loteria = 1 
and nr_dezena in (@id_dezena01,@id_dezena02,@id_dezena03,@id_dezena04)
group by nr_concurso
having count(1) > 3


' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_ver_15_lotofacil]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_ver_15_lotofacil]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[pr_ver_15_lotofacil]
(@id_dezena01 int,  @id_dezena02 int,  @id_dezena03 int, 
 @id_dezena04 int,  @id_dezena05 int,  @id_dezena06 int, 
 @id_dezena07 int,  @id_dezena08 int,  @id_dezena09 int, 
 @id_dezena10 int,  @id_dezena11 int,  @id_dezena12 int, 
 @id_dezena13 int,  @id_dezena14 int,  @id_dezena15 int)


AS


SELECT nr_concurso , count(1)
from tb_tor_dezenas 
where id_loteria = 5 
and nr_dezena in (@id_dezena01,@id_dezena02,@id_dezena03,@id_dezena04,@id_dezena05,
                  @id_dezena06,@id_dezena07,@id_dezena08,@id_dezena09,@id_dezena10,
                  @id_dezena11,@id_dezena12,@id_dezena13,@id_dezena14,@id_dezena15)
group by nr_concurso
having count(1) > 14

' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_ver_14_lotofacil]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_ver_14_lotofacil]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[pr_ver_14_lotofacil]
(@id_dezena01 int,  @id_dezena02 int,  @id_dezena03 int, 
 @id_dezena04 int,  @id_dezena05 int,  @id_dezena06 int, 
 @id_dezena07 int,  @id_dezena08 int,  @id_dezena09 int, 
 @id_dezena10 int,  @id_dezena11 int,  @id_dezena12 int, 
 @id_dezena13 int,  @id_dezena14 int)


AS


SELECT nr_concurso , count(1)
from tb_tor_dezenas 
where id_loteria = 5 
and nr_dezena in (@id_dezena01,@id_dezena02,@id_dezena03,@id_dezena04,@id_dezena05,
                  @id_dezena06,@id_dezena07,@id_dezena08,@id_dezena09,@id_dezena10,
                  @id_dezena11,@id_dezena12,@id_dezena13,@id_dezena14)
group by nr_concurso
having count(1) > 13

' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_ver_13_lotofacil]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_ver_13_lotofacil]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[pr_ver_13_lotofacil]
(@id_dezena01 int,  @id_dezena02 int,  @id_dezena03 int, 
 @id_dezena04 int,  @id_dezena05 int,  @id_dezena06 int, 
 @id_dezena07 int,  @id_dezena08 int,  @id_dezena09 int, 
 @id_dezena10 int,  @id_dezena11 int,  @id_dezena12 int, 
 @id_dezena13 int)


AS


SELECT nr_concurso , count(1)
from tb_tor_dezenas 
where id_loteria = 5 
and nr_dezena in (@id_dezena01,@id_dezena02,@id_dezena03,@id_dezena04,@id_dezena05,
                  @id_dezena06,@id_dezena07,@id_dezena08,@id_dezena09,@id_dezena10,
                  @id_dezena11,@id_dezena12,@id_dezena13)
group by nr_concurso
having count(1) > 12

' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_ver_12_lotofacil]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_ver_12_lotofacil]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[pr_ver_12_lotofacil]
(@id_dezena01 int,  @id_dezena02 int,  @id_dezena03 int, 
 @id_dezena04 int,  @id_dezena05 int,  @id_dezena06 int, 
 @id_dezena07 int,  @id_dezena08 int,  @id_dezena09 int, 
 @id_dezena10 int,  @id_dezena11 int,  @id_dezena12 int)


AS


SELECT nr_concurso , count(1)
from tb_tor_dezenas 
where id_loteria = 5 
and nr_dezena in (@id_dezena01,@id_dezena02,@id_dezena03,@id_dezena04,@id_dezena05,
                  @id_dezena06,@id_dezena07,@id_dezena08,@id_dezena09,@id_dezena10,
                  @id_dezena11,@id_dezena12)
group by nr_concurso
having count(1) > 11

' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_verify_loteria]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_verify_loteria]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[pr_tor_verify_loteria] (@id_loteria int)
AS

BEGIN

	DECLARE @qtde_valores int

	--verifica se existe linhas nas dezenas
	SELECT 	@qtde_valores = Count(1)	
	FROM 	tb_tor_dezenas
	WHERE	id_loteria = @id_loteria

	--devolvendo a quantidade de itens
	SELECT 	@qtde_valores
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_stats_dezena_concursos]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_stats_dezena_concursos]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- Batch submitted through debugger: SQLQuery13.sql|7|0|C:\Users\Beto\AppData\Local\Temp\~vs35CC.sql
CREATE procedure [dbo].[pr_tor_stats_dezena_concursos](@id_loteria tinyint, @nr_dezena int)
	AS 
	
	declare @qt_dezenas   tinyint
	declare @qt_occurs    numeric(10,2)
	declare @qt_tt_occurs numeric(10,2)
	
	create table #tb_stat_dezena(
	ds_occur	varchar(50)	null,
	qt_occur 	numeric(10,2)	null,
	qt_total_occur	numeric(10,2)	null,
	pc_relativo	numeric(10,2)	null)
	
	
	select  @qt_dezenas = qt_dezenas 
	from    tb_tor_loteria
	where	id_loteria = @id_loteria
	
	-------------
	--todos
	SELECT 	@qt_occurs = Count(1)
	FROM 	tb_tor_dezenas
	WHERE 	nr_dezena = @nr_dezena
	AND 	id_loteria = @id_loteria
	
	SELECT 	@qt_tt_occurs = (Count(1)/@qt_dezenas)
	FROM 	tb_tor_dezenas
	WHERE 	id_loteria = @id_loteria
	
	INSERT INTO #tb_stat_dezena
	SELECT ''TODOS CONCURSOS'', @qt_occurs, @qt_tt_occurs, ((@qt_occurs/@qt_tt_occurs) * 100)
	
	--pares
	SELECT 	@qt_occurs = Count(1)
	FROM 	tb_tor_dezenas
	WHERE 	nr_dezena = @nr_dezena
	AND 	id_loteria = @id_loteria
	AND     (nr_concurso%2 = 0)
	
	SELECT 	@qt_tt_occurs = (Count(1)/@qt_dezenas)
	FROM 	tb_tor_dezenas
	WHERE 	id_loteria = @id_loteria
	AND     (nr_concurso%2 = 0)
	
	INSERT INTO #tb_stat_dezena
	SELECT ''CONCURSOS PARES'', @qt_occurs, @qt_tt_occurs, ((@qt_occurs/@qt_tt_occurs) * 100)
	
	--Impares
	SELECT 	@qt_occurs = Count(1) 
	FROM 	tb_tor_dezenas
	WHERE 	nr_dezena = @nr_dezena
	AND 	id_loteria = @id_loteria
	AND     (nr_concurso%2 = 1)
	
	SELECT 	@qt_tt_occurs = (Count(1)/@qt_dezenas)
	FROM 	tb_tor_dezenas
	WHERE 	id_loteria = @id_loteria
	AND     (nr_concurso%2 = 1)
	
	INSERT INTO #tb_stat_dezena
	SELECT ''CONCURSOS IMPARES'', @qt_occurs, @qt_tt_occurs, ((@qt_occurs/@qt_tt_occurs) * 100)
	
	
	--Multiplos de 3
	SELECT 	@qt_occurs = Count(1) 
	FROM 	tb_tor_dezenas
	WHERE 	nr_dezena = @nr_dezena
	AND 	id_loteria = @id_loteria
	AND     (nr_concurso%3 = 0)
	
	SELECT 	@qt_tt_occurs = (Count(1)/@qt_dezenas)
	FROM 	tb_tor_dezenas
	WHERE 	id_loteria = @id_loteria
	AND     (nr_concurso%3 = 0)
	
	INSERT INTO #tb_stat_dezena
	SELECT ''MULTIPLOS DE 3'', @qt_occurs, @qt_tt_occurs, ((@qt_occurs/@qt_tt_occurs) * 100)
	
	
	--Multiplos de 4
	SELECT 	@qt_occurs = Count(1) 
	FROM 	tb_tor_dezenas
	WHERE 	nr_dezena = @nr_dezena
	AND 	id_loteria = @id_loteria
	AND     (nr_concurso%4 = 0)
	
	SELECT 	@qt_tt_occurs = (Count(1)/@qt_dezenas)
	FROM 	tb_tor_dezenas
	WHERE 	id_loteria = @id_loteria
	AND     (nr_concurso%4 = 0)
	
	INSERT INTO #tb_stat_dezena
	SELECT ''MULTIPLOS DE 4'', @qt_occurs, @qt_tt_occurs, ((@qt_occurs/@qt_tt_occurs) * 100)
	
	
	--Multiplos de 5
	SELECT 	@qt_occurs = Count(1) 
	FROM 	tb_tor_dezenas
	WHERE 	nr_dezena = @nr_dezena
	AND 	id_loteria = @id_loteria
	AND     (nr_concurso%5 = 0)
	
	SELECT 	@qt_tt_occurs = (Count(1)/@qt_dezenas)
	FROM 	tb_tor_dezenas
	WHERE 	id_loteria = @id_loteria
	AND     (nr_concurso%5 = 0)
	
	INSERT INTO #tb_stat_dezena
	SELECT ''MULTIPLOS DE 5'', @qt_occurs, @qt_tt_occurs, ((@qt_occurs/@qt_tt_occurs) * 100)
	
	
	--Multiplos de 6
	SELECT 	@qt_occurs = Count(1) 
	FROM 	tb_tor_dezenas
	WHERE 	nr_dezena = @nr_dezena
	AND 	id_loteria = @id_loteria
	AND     (nr_concurso%6 = 0)
	
	SELECT 	@qt_tt_occurs = (Count(1)/@qt_dezenas)
	FROM 	tb_tor_dezenas
	WHERE 	id_loteria = @id_loteria
	AND     (nr_concurso%6 = 0)
	
	INSERT INTO #tb_stat_dezena
	SELECT ''MULTIPLOS DE 6'', @qt_occurs, @qt_tt_occurs, ((@qt_occurs/@qt_tt_occurs) * 100)
	
	
	--Multiplos de 7
	SELECT 	@qt_occurs = Count(1)
	FROM 	tb_tor_dezenas
	WHERE 	nr_dezena = @nr_dezena
	AND 	id_loteria = @id_loteria
	AND     (nr_concurso%7 = 0)
	SELECT 	@qt_tt_occurs = (Count(1)/@qt_dezenas)
	FROM 	tb_tor_dezenas
	WHERE 	id_loteria = @id_loteria
	AND     (nr_concurso%7 = 0)
	
	INSERT INTO #tb_stat_dezena
	SELECT ''MULTIPLOS DE 7'', @qt_occurs, @qt_tt_occurs, ((@qt_occurs/@qt_tt_occurs) * 100)
	
	
	--Multiplos de 8
	SELECT 	@qt_occurs = Count(1) 
	FROM 	tb_tor_dezenas
	WHERE 	nr_dezena = @nr_dezena
	AND 	id_loteria = @id_loteria
	AND     (nr_concurso%8 = 0)
	
	SELECT 	@qt_tt_occurs = (Count(1)/@qt_dezenas)
	FROM 	tb_tor_dezenas
	WHERE 	id_loteria = @id_loteria
	AND     (nr_concurso%8 = 0)
	
	INSERT INTO #tb_stat_dezena
	SELECT ''MULTIPLOS DE 8'', @qt_occurs, @qt_tt_occurs, ((@qt_occurs/@qt_tt_occurs) * 100)
	
	
	--Multiplos de 9
	SELECT 	@qt_occurs = Count(1) 
	FROM 	tb_tor_dezenas
	WHERE 	nr_dezena = @nr_dezena
	AND 	id_loteria = @id_loteria
	AND     (nr_concurso%9 = 0)
	
	SELECT 	@qt_tt_occurs = (Count(1)/@qt_dezenas)
	FROM 	tb_tor_dezenas
	WHERE 	id_loteria = @id_loteria
	AND     (nr_concurso%9 = 0)
	
	INSERT INTO #tb_stat_dezena
	SELECT ''MULTIPLOS DE 9'', @qt_occurs, @qt_tt_occurs, ((@qt_occurs/@qt_tt_occurs) * 100)
	
	
	--Multiplos de 10
	SELECT 	@qt_occurs = Count(1) 
	FROM 	tb_tor_dezenas
	WHERE 	nr_dezena = @nr_dezena
	AND 	id_loteria = @id_loteria
	AND     (nr_concurso%10 = 0)
	
	SELECT 	@qt_tt_occurs = (Count(1)/@qt_dezenas)
	FROM 	tb_tor_dezenas
	WHERE 	id_loteria = @id_loteria
	AND     (nr_concurso%10 = 0)
	
	INSERT INTO #tb_stat_dezena
	SELECT ''MULTIPLOS DE 10'', @qt_occurs, @qt_tt_occurs, ((@qt_occurs/@qt_tt_occurs) * 100)
	
	
	--Multiplos de 11
	SELECT 	@qt_occurs = Count(1) 
	FROM 	tb_tor_dezenas
	WHERE 	nr_dezena = @nr_dezena
	AND 	id_loteria = @id_loteria
	AND     (nr_concurso%11 = 0)
	
	SELECT 	@qt_tt_occurs = (Count(1)/@qt_dezenas)
	FROM 	tb_tor_dezenas
	WHERE 	id_loteria = @id_loteria
	AND     (nr_concurso%11 = 0)
	
	INSERT INTO #tb_stat_dezena
	SELECT ''MULTIPLOS DE 11'', @qt_occurs, @qt_tt_occurs, ((@qt_occurs/@qt_tt_occurs) * 100)
	
	
	SELECT * FROM #tb_stat_dezena
	ORDER BY pc_relativo desc
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_sel_variacao_atraso]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_sel_variacao_atraso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[pr_tor_sel_variacao_atraso](@id_loteria int, @nr_dezena tinyint)
AS
	
	SET NOCOUNT ON
	DECLARE @int_last_conc integer
	DECLARE @int_concurso  integer
	DECLARE @qt_atrasos    integer
	DECLARE @nr_conc_ini   smallint
	DECLARE @nr_conc_fim   smallint
	DECLARE @id_variacao   smallint
	DECLARE @int_ocurs     smallint
	
	-- cria-se a tabela temporaria	
	CREATE TABLE #tb_atraso
	(id_variacao smallint not null,
	 qt_atrasos  smallint not null,
	 nr_conc_ini smallint not null,
	 nr_conc_fim smallint not null)
	 
	
	-- seleciona o ultimo concurso válido	
	select @int_last_conc = max(nr_concurso)
	from tb_tor_dezenas (nolock) 
	where id_loteria = @id_loteria
	
	SELECT  @int_concurso = 1, 
			@nr_conc_ini = 1, 
			@qt_atrasos = 0,
			@id_variacao = 1
	
	WHILE (@int_concurso < (@int_last_conc + 1))
	BEGIN
	 
		-- ver se o concurso que ocorreu a dezena desejada
		select @int_ocurs  = count(nr_dezena)
		from  tb_tor_dezenas (nolock)
		where id_loteria = @id_loteria
		and   nr_concurso = @int_concurso
		and   nr_dezena = @nr_dezena
	

		IF @int_ocurs = 0
		BEGIN
			SELECT @qt_atrasos = @qt_atrasos + 1
		END
		ELSE
		BEGIN
			IF @qt_atrasos > 0
			BEGIN
				--insert begin
				SELECT @nr_conc_fim = @int_concurso
				INSERT INTO #tb_atraso
				(id_variacao, qt_atrasos, nr_conc_ini, nr_conc_fim)
				VALUES (@id_variacao, @qt_atrasos, @nr_conc_ini, @nr_conc_fim)
				SELECT @id_variacao = @id_variacao + 1 
				SELECT @nr_conc_ini = @int_concurso, @qt_atrasos = 0

				--insert fim
			END		
			ELSE
			BEGIN
				SELECT @nr_conc_ini = @int_concurso
			END
		END		

		SELECT @int_concurso = @int_concurso + 1
	END
	SELECT * FROM #tb_atraso 
	ORDER BY qt_atrasos DESC

' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_sel_stats_best_dezenas]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_sel_stats_best_dezenas]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE  PROCEDURE [dbo].[pr_tor_sel_stats_best_dezenas](@id_loteria int)
AS
	SET NOCOUNT ON

	DECLARE @qt_dezenas    tinyint
	DECLARE @qt_tt_Dezenas integer
	DECLARE @qt_occurs     numeric(10,4)
	DECLARE @qt_tt_occurs  numeric(10,4)
	DECLARE @int_last_conc integer
	DECLARE @int_dez_fim   tinyint
	DECLARE	@nr_dezena     integer

	create table #tb_stat_dezena(
	nr_dezena	        integer  	null,
	qt_occur_all 	        numeric(10,4)	null,
	qt_concursos_all	numeric(10,4)	null,
	pc_relativo_all 	numeric(10,4)	null,
	pc_total_all 		numeric(10,4)	null,
	qt_occur_top_i 	        numeric(10,4)	null,
	qt_concursos_top_i	numeric(10,4)	null,
	pc_relativo_top_i 	numeric(10,4)	null,
	pc_total_top_i 		numeric(10,4)	null,
	qt_occur_top_2 	        numeric(10,4)	null,
	qt_concursos_top_2	numeric(10,4)	null,
	pc_relativo_top_2 	numeric(10,4)	null,
	pc_total_top_2 		numeric(10,4)	null,
	qt_occur_top_3 	        numeric(10,4)	null,
	qt_concursos_top_3	numeric(10,4)	null,
	pc_relativo_top_3 	numeric(10,4)	null,
	pc_total_top_3 		numeric(10,4)	null,
	qt_occur_top_4 	        numeric(10,4)	null,
	qt_concursos_top_4	numeric(10,4)	null,
	pc_relativo_top_4 	numeric(10,4)	null,
	pc_total_top_4 		numeric(10,4)	null,
	qt_occur_top_5	        numeric(10,4)	null,
	qt_concursos_top_5	numeric(10,4)	null,
	pc_relativo_top_5 	numeric(10,4)	null,
	pc_total_top_5 		numeric(10,4)	null,
	qt_occur_top_6 	        numeric(10,4)	null,
	qt_concursos_top_6	numeric(10,4)	null,
	pc_relativo_top_6 	numeric(10,4)	null,
	pc_total_top_6 		numeric(10,4)	null,
	qt_occur_top_7 	        numeric(10,4)	null,
	qt_concursos_top_7	numeric(10,4)	null,
	pc_relativo_top_7 	numeric(10,4)	null,
	pc_total_top_7 		numeric(10,4)	null,
	qt_occur_top_8 	        numeric(10,4)	null,
	qt_concursos_top_8	numeric(10,4)	null,
	pc_relativo_top_8 	numeric(10,4)	null,
	pc_total_top_8 		numeric(10,4)	null,
	qt_occur_top_9 	        numeric(10,4)	null,
	qt_concursos_top_9	numeric(10,4)	null,
	pc_relativo_top_9 	numeric(10,4)	null,
	pc_total_top_9 		numeric(10,4)	null,
	qt_occur_top_10 	numeric(10,4)	null,
	qt_concursos_top_10	numeric(10,4)	null,
	pc_relativo_top_10	numeric(10,4)	null,
	pc_total_top_10		numeric(10,4)	null,
	qt_occur_top_11 	numeric(10,4)	null,
	qt_concursos_top_11	numeric(10,4)	null,
	pc_relativo_top_11	numeric(10,4)	null,
	pc_total_top_11		numeric(10,4)	null)
	
	select  @qt_dezenas = qt_dezenas,
		    @nr_dezena  = nr_dez_min,
	        @int_dez_fim = nr_dez_max
	from    tb_tor_loteria (nolock)
	where	id_loteria = @id_loteria
	
	
	-- seleciona o ultimo concurso válido e	o total de Dezenas 
	select @int_last_conc = max(nr_concurso),
	       @qt_tt_Dezenas = count(1)
	from tb_tor_dezenas (nolock) 
	where id_loteria = @id_loteria

	WHILE (@nr_dezena < (@int_dez_fim + 1))
	BEGIN
		-------------
		--todos
		SELECT 	@qt_occurs = Count(1)
		FROM 	tb_tor_dezenas
		WHERE 	nr_dezena = @nr_dezena
		AND 	id_loteria = @id_loteria

		SELECT 	@qt_tt_occurs = (Count(1)/@qt_dezenas)
		FROM 	tb_tor_dezenas
		WHERE 	id_loteria = @id_loteria


		INSERT INTO #tb_stat_dezena
		(nr_dezena,qt_occur_all,qt_concursos_all,pc_relativo_all,pc_total_all )
		SELECT @nr_dezena, @qt_occurs, @qt_tt_occurs, 
		       ((@qt_occurs/@qt_tt_occurs) * 100), ((@qt_occurs/@qt_tt_Dezenas) * 100)

		--pares
		SELECT 	@qt_occurs = Count(1)
		FROM 	tb_tor_dezenas
		WHERE 	nr_dezena = @nr_dezena
		AND 	id_loteria = @id_loteria
		AND     (nr_concurso%2 = 0)

		SELECT 	@qt_tt_occurs = (Count(1)/@qt_dezenas)
		FROM 	tb_tor_dezenas
		WHERE 	id_loteria = @id_loteria
		AND     (nr_concurso%2 = 0)

		UPDATE	#tb_stat_dezena
		SET	qt_occur_top_2 = @qt_occurs,
			qt_concursos_top_2 = @qt_tt_occurs,
			pc_relativo_top_2 = ((@qt_occurs/@qt_tt_occurs) * 100),
			pc_total_top_2 = ((@qt_occurs/@qt_tt_Dezenas) * 100)
		WHERE 	nr_dezena = @nr_dezena

		--Impares
		SELECT 	@qt_occurs = Count(1) 
		FROM 	tb_tor_dezenas
		WHERE 	nr_dezena = @nr_dezena
		AND 	id_loteria = @id_loteria
		AND     (nr_concurso%2 = 1)

		SELECT 	@qt_tt_occurs = (Count(1)/@qt_dezenas)
		FROM 	tb_tor_dezenas
		WHERE 	id_loteria = @id_loteria
		AND     (nr_concurso%2 = 1)

		UPDATE	#tb_stat_dezena
		SET	qt_occur_top_i = @qt_occurs,
			qt_concursos_top_i = @qt_tt_occurs,
			pc_relativo_top_i = ((@qt_occurs/@qt_tt_occurs) * 100),
			pc_total_top_i = ((@qt_occurs/@qt_tt_Dezenas) * 100)
		WHERE 	nr_dezena = @nr_dezena


		--Multiplos de 3
		SELECT 	@qt_occurs = Count(1) 
		FROM 	tb_tor_dezenas
		WHERE 	nr_dezena = @nr_dezena
		AND 	id_loteria = @id_loteria
		AND     (nr_concurso%3 = 0)

		SELECT 	@qt_tt_occurs = (Count(1)/@qt_dezenas)
		FROM 	tb_tor_dezenas
		WHERE 	id_loteria = @id_loteria
		AND     (nr_concurso%3 = 0)

		UPDATE	#tb_stat_dezena
		SET	qt_occur_top_3 = @qt_occurs,
			qt_concursos_top_3 = @qt_tt_occurs,
			pc_relativo_top_3 = ((@qt_occurs/@qt_tt_occurs) * 100),
			pc_total_top_3 = ((@qt_occurs/@qt_tt_Dezenas) * 100)
		WHERE 	nr_dezena = @nr_dezena


		--Multiplos de 4
		SELECT 	@qt_occurs = Count(1) 
		FROM 	tb_tor_dezenas
		WHERE 	nr_dezena = @nr_dezena
		AND 	id_loteria = @id_loteria
		AND     (nr_concurso%4 = 0)

		SELECT 	@qt_tt_occurs = (Count(1)/@qt_dezenas)
		FROM 	tb_tor_dezenas
		WHERE 	id_loteria = @id_loteria
		AND     (nr_concurso%4 = 0)

		UPDATE	#tb_stat_dezena
		SET	qt_occur_top_4 = @qt_occurs,
			qt_concursos_top_4 = @qt_tt_occurs,
			pc_relativo_top_4 = ((@qt_occurs/@qt_tt_occurs) * 100),
			pc_total_top_4 = ((@qt_occurs/@qt_tt_Dezenas) * 100)
		WHERE 	nr_dezena = @nr_dezena


		--Multiplos de 5
		SELECT 	@qt_occurs = Count(1) 
		FROM 	tb_tor_dezenas
		WHERE 	nr_dezena = @nr_dezena
		AND 	id_loteria = @id_loteria
		AND     (nr_concurso%5 = 0)

		SELECT 	@qt_tt_occurs = (Count(1)/@qt_dezenas)
		FROM 	tb_tor_dezenas
		WHERE 	id_loteria = @id_loteria
		AND     (nr_concurso%5 = 0)

		UPDATE	#tb_stat_dezena
		SET	qt_occur_top_5 = @qt_occurs,
			qt_concursos_top_5 = @qt_tt_occurs,
			pc_relativo_top_5 = ((@qt_occurs/@qt_tt_occurs) * 100),
			pc_total_top_5 = ((@qt_occurs/@qt_tt_Dezenas) * 100)
		WHERE 	nr_dezena = @nr_dezena


		--Multiplos de 6
		SELECT 	@qt_occurs = Count(1) 
		FROM 	tb_tor_dezenas
		WHERE 	nr_dezena = @nr_dezena
		AND 	id_loteria = @id_loteria
		AND     (nr_concurso%6 = 0)

		SELECT 	@qt_tt_occurs = (Count(1)/@qt_dezenas)
		FROM 	tb_tor_dezenas
		WHERE 	id_loteria = @id_loteria
		AND     (nr_concurso%6 = 0)

		UPDATE	#tb_stat_dezena
		SET	qt_occur_top_6 = @qt_occurs,
			qt_concursos_top_6 = @qt_tt_occurs,
			pc_relativo_top_6 = ((@qt_occurs/@qt_tt_occurs) * 100),
			pc_total_top_6 = ((@qt_occurs/@qt_tt_Dezenas) * 100)
		WHERE 	nr_dezena = @nr_dezena


		--Multiplos de 7
		SELECT 	@qt_occurs = Count(1)
		FROM 	tb_tor_dezenas
		WHERE 	nr_dezena = @nr_dezena
		AND 	id_loteria = @id_loteria
		AND     (nr_concurso%7 = 0)
		SELECT 	@qt_tt_occurs = (Count(1)/@qt_dezenas)
		FROM 	tb_tor_dezenas
		WHERE 	id_loteria = @id_loteria
		AND     (nr_concurso%7 = 0)

		UPDATE	#tb_stat_dezena
		SET	qt_occur_top_7 = @qt_occurs,
			qt_concursos_top_7 = @qt_tt_occurs,
			pc_relativo_top_7 = ((@qt_occurs/@qt_tt_occurs) * 100),
			pc_total_top_7 = ((@qt_occurs/@qt_tt_Dezenas) * 100)
		WHERE 	nr_dezena = @nr_dezena


		--Multiplos de 8
		SELECT 	@qt_occurs = Count(1) 
		FROM 	tb_tor_dezenas
		WHERE 	nr_dezena = @nr_dezena
		AND 	id_loteria = @id_loteria
		AND     (nr_concurso%8 = 0)

		SELECT 	@qt_tt_occurs = (Count(1)/@qt_dezenas)
		FROM 	tb_tor_dezenas
		WHERE 	id_loteria = @id_loteria
		AND     (nr_concurso%8 = 0)

		UPDATE	#tb_stat_dezena
		SET	qt_occur_top_8 = @qt_occurs,
			qt_concursos_top_8 = @qt_tt_occurs,
			pc_relativo_top_8 = ((@qt_occurs/@qt_tt_occurs) * 100),
			pc_total_top_8 = ((@qt_occurs/@qt_tt_Dezenas) * 100)
		WHERE 	nr_dezena = @nr_dezena


		--Multiplos de 9
		SELECT 	@qt_occurs = Count(1) 
		FROM 	tb_tor_dezenas
		WHERE 	nr_dezena = @nr_dezena
		AND 	id_loteria = @id_loteria
		AND     (nr_concurso%9 = 0)

		SELECT 	@qt_tt_occurs = (Count(1)/@qt_dezenas)
		FROM 	tb_tor_dezenas
		WHERE 	id_loteria = @id_loteria
		AND     (nr_concurso%9 = 0)

		UPDATE	#tb_stat_dezena
		SET	qt_occur_top_9 = @qt_occurs,
			qt_concursos_top_9 = @qt_tt_occurs,
			pc_relativo_top_9 = ((@qt_occurs/@qt_tt_occurs) * 100),
			pc_total_top_9 = ((@qt_occurs/@qt_tt_Dezenas) * 100)
		WHERE 	nr_dezena = @nr_dezena


		--Multiplos de 10
		SELECT 	@qt_occurs = Count(1) 
		FROM 	tb_tor_dezenas
		WHERE 	nr_dezena = @nr_dezena
		AND 	id_loteria = @id_loteria
		AND     (nr_concurso%10 = 0)

		SELECT 	@qt_tt_occurs = (Count(1)/@qt_dezenas)
		FROM 	tb_tor_dezenas
		WHERE 	id_loteria = @id_loteria
		AND     (nr_concurso%10 = 0)

		UPDATE	#tb_stat_dezena
		SET	qt_occur_top_10 = @qt_occurs,
			qt_concursos_top_10 = @qt_tt_occurs,
			pc_relativo_top_10 = ((@qt_occurs/@qt_tt_occurs) * 100),
			pc_total_top_10 = ((@qt_occurs/@qt_tt_Dezenas) * 100)
		WHERE 	nr_dezena = @nr_dezena


		--Multiplos de 11
		SELECT 	@qt_occurs = Count(1) 
		FROM 	tb_tor_dezenas
		WHERE 	nr_dezena = @nr_dezena
		AND 	id_loteria = @id_loteria
		AND     (nr_concurso%11 = 0)

		SELECT 	@qt_tt_occurs = (Count(1)/@qt_dezenas)
		FROM 	tb_tor_dezenas
		WHERE 	id_loteria = @id_loteria
		AND     (nr_concurso%11 = 0)

		UPDATE	#tb_stat_dezena
		SET	qt_occur_top_11 = @qt_occurs,
			qt_concursos_top_11 = @qt_tt_occurs,
			pc_relativo_top_11 = ((@qt_occurs/@qt_tt_occurs) * 100),
			pc_total_top_11 = ((@qt_occurs/@qt_tt_Dezenas) * 100)
		WHERE 	nr_dezena = @nr_dezena
		
		SELECT @nr_dezena = @nr_dezena + 1 
	END
	
	SELECT * FROM #tb_stat_dezena
	ORDER BY nr_dezena 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_sel_loteria_filter]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_sel_loteria_filter]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pr_tor_sel_loteria_filter] (@id_loteria integer)
AS
BEGIN
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	SELECT a.id_loteria, 
		   a.id_dezena, 
		   a.nr_concurso, 
		   a.dt_concurso, 
		   a.nr_dezena,
		   b.nm_loteria
	FROM   tb_tor_dezenas a
	inner join tb_tor_loteria b
	on a.id_loteria = b.id_loteria
	and b.id_loteria = @id_loteria
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_sel_loteria]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_sel_loteria]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pr_tor_sel_loteria] 
AS
BEGIN
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	SELECT a.id_loteria, 
		   a.id_dezena, 
		   a.nr_concurso, 
		   a.dt_concurso, 
		   a.nr_dezena,
		   b.nm_loteria
	FROM   tb_tor_dezenas a
	inner join tb_tor_loteria b
	on a.id_loteria = b.id_loteria
	ORDER BY a.id_loteria, 
		     a.nr_concurso 
		   
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_sel_atraso_top]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_sel_atraso_top]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE  PROCEDURE [dbo].[pr_tor_sel_atraso_top](@id_loteria int, @nr_multiplo tinyint)
AS
	SET NOCOUNT ON
	DECLARE @int_last_conc integer
	DECLARE @int_last_ocor integer
	DECLARE @int_atraso_dz integer
	DECLARE @int_dez_ini   tinyint
	DECLARE @int_dez_fim   tinyint
	DECLARE	@nr_dezena     integer
	-- cria-se a tabela temporaria	
	CREATE TABLE #tb_atraso
	(nr_dezena integer not null,
	 qt_atrasos smallint,
	 qt_max_atraso smallint)
	-- seleciona a faixa máxima e mínima das dezenas
	SELECT @int_dez_ini = nr_dez_min,
	       @int_dez_fim = nr_dez_max
	FROM tb_tor_loteria (nolock)
	WHERE id_loteria = @id_loteria
	
	-- seleciona o ultimo concurso válido	
	select @int_last_conc = max(nr_concurso)
	from tb_tor_dezenas (nolock) 
	where id_loteria = @id_loteria
	
	SELECT @nr_dezena = @int_dez_ini
	
	WHILE (@nr_dezena < (@int_dez_fim + 1))
	BEGIN
	 
		-- seleciona o ultimo concurso que ocorreu a dezena desejada
		select @int_last_ocor = max(nr_concurso)
		from tb_tor_dezenas (nolock)
		where id_loteria = @id_loteria
		and nr_dezena = @nr_dezena
		and ((nr_concurso % @nr_multiplo) = 0)
	
		SELECT @int_atraso_dz = (@int_last_conc - @int_last_ocor)
		
		INSERT INTO #tb_atraso
		(nr_dezena,qt_atrasos,qt_max_atraso)
		VALUES (@nr_dezena, @int_atraso_dz, 0)
		SELECT @nr_dezena = @nr_dezena + 1
	END
	SELECT * FROM #tb_atraso 
	ORDER BY qt_atrasos DESC

' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_sel_atraso_impar]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_sel_atraso_impar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE  PROCEDURE [dbo].[pr_tor_sel_atraso_impar](@id_loteria int)
AS
	SET NOCOUNT ON
	DECLARE @int_last_conc integer
	DECLARE @int_last_ocor integer
	DECLARE @int_atraso_dz integer
	DECLARE @int_dez_ini   tinyint
	DECLARE @int_dez_fim   tinyint
	DECLARE	@nr_dezena     integer
	-- cria-se a tabela temporaria	
	CREATE TABLE #tb_atraso
	(nr_dezena integer not null,
	 qt_atrasos smallint,
	 qt_max_atraso smallint)
	-- seleciona a faixa máxima e mínima das dezenas
	SELECT @int_dez_ini = nr_dez_min,
	       @int_dez_fim = nr_dez_max
	FROM tb_tor_loteria (nolock)
	WHERE id_loteria = @id_loteria
	
	-- seleciona o ultimo concurso válido	
	select @int_last_conc = max(nr_concurso)
	from tb_tor_dezenas (nolock) 
	where id_loteria = @id_loteria
	
	SELECT @nr_dezena = @int_dez_ini
	
	WHILE (@nr_dezena < (@int_dez_fim + 1))
	BEGIN
	 
		-- seleciona o ultimo concurso que ocorreu a dezena desejada
		select @int_last_ocor = max(nr_concurso)
		from tb_tor_dezenas (nolock)
		where id_loteria = @id_loteria
		and nr_dezena = @nr_dezena
		and ((nr_concurso % 2) = 1)
	
		SELECT @int_atraso_dz = (@int_last_conc - @int_last_ocor)
		
		INSERT INTO #tb_atraso
		(nr_dezena,qt_atrasos,qt_max_atraso)
		VALUES (@nr_dezena, @int_atraso_dz, 0)
		SELECT @nr_dezena = @nr_dezena + 1
	END
	SELECT * FROM #tb_atraso 
	ORDER BY qt_atrasos DESC

' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_sel_atraso]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_sel_atraso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE  PROCEDURE [dbo].[pr_tor_sel_atraso](@id_loteria int)
AS
	SET NOCOUNT ON
	DECLARE @int_last_conc integer
	DECLARE @int_last_ocor integer
	DECLARE @int_atraso_dz integer
	DECLARE @int_dez_ini   tinyint
	DECLARE @int_dez_fim   tinyint
	DECLARE	@nr_dezena     integer
	-- cria-se a tabela temporaria	
	CREATE TABLE #tb_atraso
	(nr_dezena integer not null,
	 qt_atrasos smallint,
	 qt_max_atraso smallint)
	-- seleciona a faixa máxima e mínima das dezenas
	SELECT @int_dez_ini = nr_dez_min,
	       @int_dez_fim = nr_dez_max
	FROM tb_tor_loteria (nolock)
	WHERE id_loteria = @id_loteria
	
	-- seleciona o ultimo concurso válido	
	select @int_last_conc = max(nr_concurso)
	from tb_tor_dezenas (nolock) 
	where id_loteria = @id_loteria
	
	SELECT @nr_dezena = @int_dez_ini
	
	WHILE (@nr_dezena < (@int_dez_fim + 1))
	BEGIN
	 
		-- seleciona o ultimo concurso que ocorreu a dezena desejada
		select @int_last_ocor = max(nr_concurso)
		from tb_tor_dezenas (nolock)
		where id_loteria = @id_loteria
		and nr_dezena = @nr_dezena
	
		SELECT @int_atraso_dz = (@int_last_conc - @int_last_ocor)
		
		INSERT INTO #tb_atraso
		(nr_dezena,qt_atrasos,qt_max_atraso)
		VALUES (@nr_dezena, @int_atraso_dz, 0)
		SELECT @nr_dezena = @nr_dezena + 1
	END
	SELECT * FROM #tb_atraso 
	ORDER BY qt_atrasos DESC
	
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_list_set_dados_dezenas]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_list_set_dados_dezenas]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[pr_tor_list_set_dados_dezenas]
(@id_set int)
AS

BEGIN
		
	SELECT nr_dezena
	FROM   tb_tor_set_dados_dezenas
	WHERE  id_set = @id_set
	ORDER BY nr_dezena

	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_results_set_all]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_results_set_all]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[pr_tor_get_results_set_all] (@id_loteria int, 
						     @id_set int,
					  	     @conc_ini int = 0,
						     @conc_fim int = 0)
AS
	--cadastrar as dezenas primeiro, com um ID unico, 
	--depois, executar esta proc e ele pega as dezenas do guid para conferir.
	DECLARE @qt_dezenas numeric(10,5)

	SELECT 	@qt_dezenas = qt_dezenas
	FROM tb_tor_loteria
	WHERE id_loteria = @id_loteria


	SELECT  count(id_dezena) qt_dezenas, 
		((count(id_dezena) / @qt_dezenas) * 100) pc_eficiencia,  
		nr_concurso , 
		dt_concurso
	FROM 	tb_tor_dezenas
	WHERE 	id_loteria = @id_loteria
	AND 	nr_dezena  in ( SELECT nr_dezena 
				    FROM tb_tor_set_dados_dezenas
				    WHERE  id_set = @id_set)
	AND	(nr_concurso >= @conc_ini OR @conc_ini = 0)
	AND 	(nr_concurso <= @conc_fim OR @conc_fim = 0)
	GROUP BY nr_concurso , dt_concurso
	ORDER BY qt_dezenas desc, nr_concurso asc


' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_get_results_set]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_get_results_set]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[pr_tor_get_results_set] (@id_loteria int, 
						 @id_set int,
						 @conc_ini int = 0,
						 @conc_fim int = 0)
AS
--cadastrar as dezenas primeiro, com um id unico, 
--depois, executar esta proc e ele pega as dezenasdo guid para conferir.
	
	DECLARE @nrMinOccurs tinyint
	DECLARE @qt_dezenas numeric(10,5)

	SELECT 	@nrMinOccurs = qt_min_occurs,
		@qt_dezenas = qt_dezenas
	FROM tb_tor_loteria
	WHERE id_loteria = @id_loteria

	SELECT  count(id_dezena) qt_dezenas, 
		((count(id_dezena) / @qt_dezenas) * 100) pc_eficiencia,
		nr_concurso , 
		dt_concurso
	FROM 	tb_tor_dezenas
	WHERE 	id_loteria = @id_loteria
	AND 	nr_dezena  in ( SELECT nr_dezena 
				    FROM tb_tor_set_dados_dezenas
				    WHERE  id_set = @id_set)
	AND	(nr_concurso >= @conc_ini OR @conc_ini = 0)
	AND 	(nr_concurso <= @conc_fim OR @conc_fim = 0)
	GROUP BY nr_concurso , dt_concurso
	HAVING COUNT(id_dezena) >= @nrMinOccurs
	ORDER BY qt_dezenas desc, nr_concurso asc


' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_del_set_dados_dezenas_all]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_del_set_dados_dezenas_all]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[pr_tor_del_set_dados_dezenas_all]
(@id_set int)
AS

BEGIN
		
	DELETE FROM tb_tor_set_dados_dezenas
	WHERE id_set = @id_set
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_del_set_dados_dezenas]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_del_set_dados_dezenas]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[pr_tor_del_set_dados_dezenas]
(@id_set int,
 @nr_dezena tinyint)
AS

BEGIN
		
	DELETE FROM tb_tor_set_dados_dezenas
	WHERE id_set = @id_set
	AND   nr_dezena	= @nr_dezena
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_del_set_dados]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_del_set_dados]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[pr_tor_del_set_dados]
(@id_set int)
AS

BEGIN
	
	--deletando registros filhos	
	DELETE 
	FROM  tb_tor_set_dados_dezenas 
	WHERE id_set = @id_set

	--deletando registos masters	
	DELETE 
	FROM  tb_tor_set_dados 
	WHERE id_set = @id_set
	
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_add_set_dados_dezenas]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_add_set_dados_dezenas]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

CREATE PROCEDURE [dbo].[pr_tor_add_set_dados_dezenas]
(@id_set int,
 @nr_dezena tinyint)
AS

BEGIN
	
	
	INSERT INTO tb_tor_set_dados_dezenas
	(id_set,
	 nr_dezena)	
	VALUES
	(@id_set,
	 @nr_dezena)

	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_add_dezena_timemania]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_add_dezena_timemania]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pr_tor_add_dezena_timemania](@nr_concurso integer,
								              @dt_concurso smalldatetime,
							  	              @nr_dezena01 integer,
							  	              @nr_dezena02 integer,
							  	              @nr_dezena03 integer,
							  	              @nr_dezena04 integer,
							  	              @nr_dezena05 integer,
							  	              @nr_dezena06 integer,
							  	              @nr_dezena07 integer,
											  @nr_time	   integer)
AS
BEGIN
	SET NOCOUNT ON;
	--procedure para timemania
	exec pr_tor_add_dezena 7, @nr_concurso, @dt_concurso, @nr_dezena01
	exec pr_tor_add_dezena 7, @nr_concurso, @dt_concurso, @nr_dezena02
	exec pr_tor_add_dezena 7, @nr_concurso, @dt_concurso, @nr_dezena03
	exec pr_tor_add_dezena 7, @nr_concurso, @dt_concurso, @nr_dezena04
	exec pr_tor_add_dezena 7, @nr_concurso, @dt_concurso, @nr_dezena05
	exec pr_tor_add_dezena 7, @nr_concurso, @dt_concurso, @nr_dezena06
	exec pr_tor_add_dezena 7, @nr_concurso, @dt_concurso, @nr_dezena07
	exec pr_tor_add_dezena 8, @nr_concurso, @dt_concurso, @nr_time

END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_add_dezena_sena]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_add_dezena_sena]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pr_tor_add_dezena_sena](@id_loteria integer, 
								        @nr_concurso integer,
								        @dt_concurso smalldatetime,
							  	        @nr_dezena1 integer,
							  	        @nr_dezena2 integer,
							  	        @nr_dezena3 integer,
							  	        @nr_dezena4 integer,
							  	        @nr_dezena5 integer,
							  	        @nr_dezena6 integer)
AS
BEGIN
	SET NOCOUNT ON;
	--procedure para senas
	--se id_loteria for 1 é megasena, 2 duplasena sorteio 1 e 3 duplasena sorteio 2
	exec pr_tor_add_dezena @id_loteria, @nr_concurso, @dt_concurso, @nr_dezena1
	exec pr_tor_add_dezena @id_loteria, @nr_concurso, @dt_concurso, @nr_dezena2
	exec pr_tor_add_dezena @id_loteria, @nr_concurso, @dt_concurso, @nr_dezena3
	exec pr_tor_add_dezena @id_loteria, @nr_concurso, @dt_concurso, @nr_dezena4
	exec pr_tor_add_dezena @id_loteria, @nr_concurso, @dt_concurso, @nr_dezena5
	exec pr_tor_add_dezena @id_loteria, @nr_concurso, @dt_concurso, @nr_dezena6
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_add_dezena_quina]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_add_dezena_quina]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pr_tor_add_dezena_quina](@nr_concurso integer,
								         @dt_concurso smalldatetime,
							  	         @nr_dezena1 integer,
							  	         @nr_dezena2 integer,
							  	         @nr_dezena3 integer,
							  	         @nr_dezena4 integer,
							  	         @nr_dezena5 integer)
AS
BEGIN
	SET NOCOUNT ON;
	--procedure para quina
	exec pr_tor_add_dezena 6, @nr_concurso, @dt_concurso, @nr_dezena1
	exec pr_tor_add_dezena 6, @nr_concurso, @dt_concurso, @nr_dezena2
	exec pr_tor_add_dezena 6, @nr_concurso, @dt_concurso, @nr_dezena3
	exec pr_tor_add_dezena 6, @nr_concurso, @dt_concurso, @nr_dezena4
	exec pr_tor_add_dezena 6, @nr_concurso, @dt_concurso, @nr_dezena5
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_add_dezena_megasena]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_add_dezena_megasena]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[pr_tor_add_dezena_megasena]
									   (@nr_concurso integer,
								        @dt_concurso smalldatetime,
							  	        @nr_dezena1 integer,
							  	        @nr_dezena2 integer,
							  	        @nr_dezena3 integer,
							  	        @nr_dezena4 integer,
							  	        @nr_dezena5 integer,
							  	        @nr_dezena6 integer)
AS
BEGIN
	SET NOCOUNT ON;
	--procedure para senas
	exec pr_tor_add_dezena 1, @nr_concurso, @dt_concurso, @nr_dezena1
	exec pr_tor_add_dezena 1, @nr_concurso, @dt_concurso, @nr_dezena2
	exec pr_tor_add_dezena 1, @nr_concurso, @dt_concurso, @nr_dezena3
	exec pr_tor_add_dezena 1, @nr_concurso, @dt_concurso, @nr_dezena4
	exec pr_tor_add_dezena 1, @nr_concurso, @dt_concurso, @nr_dezena5
	exec pr_tor_add_dezena 1, @nr_concurso, @dt_concurso, @nr_dezena6
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_add_dezena_loto_mania]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_add_dezena_loto_mania]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pr_tor_add_dezena_loto_mania](@nr_concurso integer,
								              @dt_concurso smalldatetime,
							  	              @nr_dezena01 integer,
							  	              @nr_dezena02 integer,
							  	              @nr_dezena03 integer,
							  	              @nr_dezena04 integer,
							  	              @nr_dezena05 integer,
							  	              @nr_dezena06 integer,
							  	              @nr_dezena07 integer,
							  	              @nr_dezena08 integer,
							  	              @nr_dezena09 integer,
							  	              @nr_dezena10 integer,
							  	              @nr_dezena11 integer,
							  	              @nr_dezena12 integer,
							  	              @nr_dezena13 integer,
							  	              @nr_dezena14 integer,
							  	              @nr_dezena15 integer,
							  	              @nr_dezena16 integer,
							  	              @nr_dezena17 integer,
							  	              @nr_dezena18 integer,
							  	              @nr_dezena19 integer,
							  	              @nr_dezena20 integer)
AS
BEGIN
	SET NOCOUNT ON;
	--procedure para lotomania
	exec pr_tor_add_dezena 4, @nr_concurso, @dt_concurso, @nr_dezena01
	exec pr_tor_add_dezena 4, @nr_concurso, @dt_concurso, @nr_dezena02
	exec pr_tor_add_dezena 4, @nr_concurso, @dt_concurso, @nr_dezena03
	exec pr_tor_add_dezena 4, @nr_concurso, @dt_concurso, @nr_dezena04
	exec pr_tor_add_dezena 4, @nr_concurso, @dt_concurso, @nr_dezena05
	exec pr_tor_add_dezena 4, @nr_concurso, @dt_concurso, @nr_dezena06
	exec pr_tor_add_dezena 4, @nr_concurso, @dt_concurso, @nr_dezena07
	exec pr_tor_add_dezena 4, @nr_concurso, @dt_concurso, @nr_dezena08
	exec pr_tor_add_dezena 4, @nr_concurso, @dt_concurso, @nr_dezena09
	exec pr_tor_add_dezena 4, @nr_concurso, @dt_concurso, @nr_dezena10
	exec pr_tor_add_dezena 4, @nr_concurso, @dt_concurso, @nr_dezena11
	exec pr_tor_add_dezena 4, @nr_concurso, @dt_concurso, @nr_dezena12
	exec pr_tor_add_dezena 4, @nr_concurso, @dt_concurso, @nr_dezena13
	exec pr_tor_add_dezena 4, @nr_concurso, @dt_concurso, @nr_dezena14
	exec pr_tor_add_dezena 4, @nr_concurso, @dt_concurso, @nr_dezena15
	exec pr_tor_add_dezena 4, @nr_concurso, @dt_concurso, @nr_dezena16
	exec pr_tor_add_dezena 4, @nr_concurso, @dt_concurso, @nr_dezena17
	exec pr_tor_add_dezena 4, @nr_concurso, @dt_concurso, @nr_dezena18
	exec pr_tor_add_dezena 4, @nr_concurso, @dt_concurso, @nr_dezena19
	exec pr_tor_add_dezena 4, @nr_concurso, @dt_concurso, @nr_dezena20
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_add_dezena_loto_facil]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_add_dezena_loto_facil]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pr_tor_add_dezena_loto_facil](@nr_concurso integer,
								              @dt_concurso smalldatetime,
							  	              @nr_dezena01 integer,
							  	              @nr_dezena02 integer,
							  	              @nr_dezena03 integer,
							  	              @nr_dezena04 integer,
							  	              @nr_dezena05 integer,
							  	              @nr_dezena06 integer,
							  	              @nr_dezena07 integer,
							  	              @nr_dezena08 integer,
							  	              @nr_dezena09 integer,
							  	              @nr_dezena10 integer,
							  	              @nr_dezena11 integer,
							  	              @nr_dezena12 integer,
							  	              @nr_dezena13 integer,
							  	              @nr_dezena14 integer,
							  	              @nr_dezena15 integer)
AS
BEGIN
	SET NOCOUNT ON;
	--procedure para quina
	exec pr_tor_add_dezena 5, @nr_concurso, @dt_concurso, @nr_dezena01
	exec pr_tor_add_dezena 5, @nr_concurso, @dt_concurso, @nr_dezena02
	exec pr_tor_add_dezena 5, @nr_concurso, @dt_concurso, @nr_dezena03
	exec pr_tor_add_dezena 5, @nr_concurso, @dt_concurso, @nr_dezena04
	exec pr_tor_add_dezena 5, @nr_concurso, @dt_concurso, @nr_dezena05
	exec pr_tor_add_dezena 5, @nr_concurso, @dt_concurso, @nr_dezena06
	exec pr_tor_add_dezena 5, @nr_concurso, @dt_concurso, @nr_dezena07
	exec pr_tor_add_dezena 5, @nr_concurso, @dt_concurso, @nr_dezena08
	exec pr_tor_add_dezena 5, @nr_concurso, @dt_concurso, @nr_dezena09
	exec pr_tor_add_dezena 5, @nr_concurso, @dt_concurso, @nr_dezena10
	exec pr_tor_add_dezena 5, @nr_concurso, @dt_concurso, @nr_dezena11
	exec pr_tor_add_dezena 5, @nr_concurso, @dt_concurso, @nr_dezena12
	exec pr_tor_add_dezena 5, @nr_concurso, @dt_concurso, @nr_dezena13
	exec pr_tor_add_dezena 5, @nr_concurso, @dt_concurso, @nr_dezena14
	exec pr_tor_add_dezena 5, @nr_concurso, @dt_concurso, @nr_dezena15
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_add_dezena_duplasena_s2]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_add_dezena_duplasena_s2]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[pr_tor_add_dezena_duplasena_s2]
									   (@nr_concurso integer,
								        @dt_concurso smalldatetime,
							  	        @nr_dezena1 integer,
							  	        @nr_dezena2 integer,
							  	        @nr_dezena3 integer,
							  	        @nr_dezena4 integer,
							  	        @nr_dezena5 integer,
							  	        @nr_dezena6 integer)
AS
BEGIN
	SET NOCOUNT ON;
	--procedure para senas
	exec pr_tor_add_dezena 3, @nr_concurso, @dt_concurso, @nr_dezena1
	exec pr_tor_add_dezena 3, @nr_concurso, @dt_concurso, @nr_dezena2
	exec pr_tor_add_dezena 3, @nr_concurso, @dt_concurso, @nr_dezena3
	exec pr_tor_add_dezena 3, @nr_concurso, @dt_concurso, @nr_dezena4
	exec pr_tor_add_dezena 3, @nr_concurso, @dt_concurso, @nr_dezena5
	exec pr_tor_add_dezena 3, @nr_concurso, @dt_concurso, @nr_dezena6
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_add_dezena_duplasena_s1]    Script Date: 03/29/2011 06:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_tor_add_dezena_duplasena_s1]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[pr_tor_add_dezena_duplasena_s1]
									   (@nr_concurso integer,
								        @dt_concurso smalldatetime,
							  	        @nr_dezena1 integer,
							  	        @nr_dezena2 integer,
							  	        @nr_dezena3 integer,
							  	        @nr_dezena4 integer,
							  	        @nr_dezena5 integer,
							  	        @nr_dezena6 integer)
AS
BEGIN
	SET NOCOUNT ON;
	--procedure para senas
	exec pr_tor_add_dezena 2, @nr_concurso, @dt_concurso, @nr_dezena1
	exec pr_tor_add_dezena 2, @nr_concurso, @dt_concurso, @nr_dezena2
	exec pr_tor_add_dezena 2, @nr_concurso, @dt_concurso, @nr_dezena3
	exec pr_tor_add_dezena 2, @nr_concurso, @dt_concurso, @nr_dezena4
	exec pr_tor_add_dezena 2, @nr_concurso, @dt_concurso, @nr_dezena5
	exec pr_tor_add_dezena 2, @nr_concurso, @dt_concurso, @nr_dezena6
END
' 
END
GO
/****** Object:  ForeignKey [FK_tb_tor_cenario_tb_tor_loteria]    Script Date: 03/29/2011 06:43:33 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_tor_cenario_tb_tor_loteria]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_tor_cenario]'))
ALTER TABLE [dbo].[tb_tor_cenario]  WITH CHECK ADD  CONSTRAINT [FK_tb_tor_cenario_tb_tor_loteria] FOREIGN KEY([id_loteria])
REFERENCES [dbo].[tb_tor_loteria] ([id_loteria])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_tor_cenario_tb_tor_loteria]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_tor_cenario]'))
ALTER TABLE [dbo].[tb_tor_cenario] CHECK CONSTRAINT [FK_tb_tor_cenario_tb_tor_loteria]
GO
/****** Object:  ForeignKey [FK_tb_tor_cenario_detalhe_tb_tor_cenario]    Script Date: 03/29/2011 06:43:33 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_tor_cenario_detalhe_tb_tor_cenario]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_tor_cenario_detalhe]'))
ALTER TABLE [dbo].[tb_tor_cenario_detalhe]  WITH CHECK ADD  CONSTRAINT [FK_tb_tor_cenario_detalhe_tb_tor_cenario] FOREIGN KEY([id_cenario])
REFERENCES [dbo].[tb_tor_cenario] ([id_cenario])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_tor_cenario_detalhe_tb_tor_cenario]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_tor_cenario_detalhe]'))
ALTER TABLE [dbo].[tb_tor_cenario_detalhe] CHECK CONSTRAINT [FK_tb_tor_cenario_detalhe_tb_tor_cenario]
GO
/****** Object:  ForeignKey [FK_tb_tor_dezenas_tb_tor_loteria]    Script Date: 03/29/2011 06:43:33 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_tor_dezenas_tb_tor_loteria]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_tor_dezenas]'))
ALTER TABLE [dbo].[tb_tor_dezenas]  WITH CHECK ADD  CONSTRAINT [FK_tb_tor_dezenas_tb_tor_loteria] FOREIGN KEY([id_loteria])
REFERENCES [dbo].[tb_tor_loteria] ([id_loteria])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_tor_dezenas_tb_tor_loteria]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_tor_dezenas]'))
ALTER TABLE [dbo].[tb_tor_dezenas] CHECK CONSTRAINT [FK_tb_tor_dezenas_tb_tor_loteria]
GO
/****** Object:  ForeignKey [FK_tb_tor_set_dados_tb_tor_loteria]    Script Date: 03/29/2011 06:43:33 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_tor_set_dados_tb_tor_loteria]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_tor_set_dados]'))
ALTER TABLE [dbo].[tb_tor_set_dados]  WITH CHECK ADD  CONSTRAINT [FK_tb_tor_set_dados_tb_tor_loteria] FOREIGN KEY([id_loteria])
REFERENCES [dbo].[tb_tor_loteria] ([id_loteria])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_tor_set_dados_tb_tor_loteria]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_tor_set_dados]'))
ALTER TABLE [dbo].[tb_tor_set_dados] CHECK CONSTRAINT [FK_tb_tor_set_dados_tb_tor_loteria]
GO
/****** Object:  ForeignKey [FK_tb_tor_set_dados_dezenas_tb_tor_set_dados]    Script Date: 03/29/2011 06:43:33 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_tor_set_dados_dezenas_tb_tor_set_dados]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_tor_set_dados_dezenas]'))
ALTER TABLE [dbo].[tb_tor_set_dados_dezenas]  WITH CHECK ADD  CONSTRAINT [FK_tb_tor_set_dados_dezenas_tb_tor_set_dados] FOREIGN KEY([id_set])
REFERENCES [dbo].[tb_tor_set_dados] ([id_set])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_tor_set_dados_dezenas_tb_tor_set_dados]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_tor_set_dados_dezenas]'))
ALTER TABLE [dbo].[tb_tor_set_dados_dezenas] CHECK CONSTRAINT [FK_tb_tor_set_dados_dezenas_tb_tor_set_dados]
GO
