GO
/****** Object:  StoredProcedure [dbo].[pr_list_get_indice]    Script Date: 07/28/2008 10:48:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_list_get_indice] 

AS

BEGIN

SELECT	DISTINCT id_indice, 
		sg_indice + ' - ' + ds_indice AS ds_indice 
FROM	tb_cor_indice 
ORDER BY sg_indice + ' - ' + ds_indice

END