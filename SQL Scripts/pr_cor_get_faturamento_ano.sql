GO
/****** Object:  StoredProcedure [dbo].[pr_cor_get_faturamento_ano]    Script Date: 07/28/2008 10:48:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_cor_get_faturamento_ano] (@id_cliente int, @ano int)
AS

select DATEPART(mm,dt_nota) mes,  sum(vl_nota) valor 
from tb_cor_notafiscal
where id_cliente_prestador = @id_cliente
and year(dt_nota) = @ano
group by DATEPART(mm,dt_nota)
order by DATEPART(mm,dt_nota)
