USE [torchwood]
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_list_loteria_all]    Script Date: 09/13/2010 23:05:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP procedure [dbo].[pr_tor_list_loteria_all]
GO
CREATE procedure [dbo].[pr_tor_list_loteria_all]

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
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_list_loteria]    Script Date: 09/13/2010 23:05:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP procedure [dbo].[pr_tor_list_loteria]
GO
CREATE procedure [dbo].[pr_tor_list_loteria]

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
	WHERE st_loteria = 'A'
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_sel_loteria]    Script Date: 09/13/2010 23:05:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP procedure [dbo].[pr_tor_sel_loteria]
GO
CREATE PROCEDURE [dbo].[pr_tor_sel_loteria]
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
GO
