USE [Torchwood]
GO
/****** Object:  StoredProcedure [dbo].[pr_tor_add_loteria]    Script Date: 03/29/2011 12:45:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[pr_tor_add_loteria]
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
	
	--DECLARE @id_loteria tinyint

	--SELECT @id_loteria = (Max(id_loteria) + 1)
	--FROM tb_tor_loteria
	
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
	--SELECT @id_loteria
	
END
