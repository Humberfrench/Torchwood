GO
/****** Object:  StoredProcedure [dbo].[pr_cor_get_ano_notas]    Script Date: 07/28/2008 10:48:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_cor_get_ano_notas]
AS

SELECT DISTINCT YEAR (dt_nota) AS Ano 
FROM tb_cor_notafiscal
order by YEAR (dt_nota) desc
