GO
/****** Object:  StoredProcedure [dbo].[pr_cor_get_detalhe_tributonota]    Script Date: 07/28/2008 10:48:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[pr_cor_get_detalhe_tributonota] (@nr_nota varchar(04), @id_cliente int)
as
select a.id_tributo,
	   a.vl_tributo,
	   a.ds_observacao, 
	   b.ds_tributo
from tb_cor_tributo_cliente a
inner join tb_cor_tributo b
on a.id_tributo = b.id_tributo
and a.id_cliente = @id_cliente
and a.nr_nota = @nr_nota