GO
/****** Object:  StoredProcedure [dbo].[pr_por_banner]    Script Date: 07/28/2008 10:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_por_banner]
AS

BEGIN

SELECT	id_banner, 
		ds_image, 
		ds_link, 
		ds_alt_description, 
		qt_impressions 
FROM	tb_por_ab_banners
ORDER BY id_banner

END

