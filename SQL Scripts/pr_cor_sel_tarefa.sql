GO
/****** Object:  StoredProcedure [dbo].[pr_cor_sel_tarefa]    Script Date: 07/28/2008 10:48:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[pr_cor_sel_tarefa]

as

select	id_tarefa,
		id_servico,
		id_cliente,
		ds_tarefa,
		vl_custo_total,
		convert(varchar(10),dt_cadastro,103) dt_cadastro,
		convert(varchar(10),dt_pagamento,103) dt_pagamento,
		convert(varchar(10),dt_prev_inicio,103) dt_prev_inicio,
		convert(varchar(10),dt_prev_final,103) dt_prev_final,
		ds_observacao
 from tb_cor_tarefa