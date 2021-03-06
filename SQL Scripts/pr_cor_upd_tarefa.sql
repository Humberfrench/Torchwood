set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[pr_cor_upd_tarefa] (@id_tarefa int,
											@id_servico int,
											@id_cliente int,
											@ds_tarefa varchar(100),
											@is_valor_fechado varchar(01),
											@qt_total_tarefa numeric(10,2),
											@vl_custo numeric(10,2),
											@vl_custo_extra numeric(10,2),
											@vl_custo_desconto numeric(10,2),
											@ds_custo_extra varchar(50),
											@ds_custo_desconto varchar(50),
											@dt_cadastro smalldatetime,
											@dt_pagamento smalldatetime,
											@dt_prev_inicio smalldatetime,
											@dt_prev_final smalldatetime,
											@ds_observacao varchar(255) = null)

AS

		set nocount on

		UPDATE tb_cor_tarefa
		SET id_servico=@id_servico,
		id_cliente=@id_cliente,
		ds_tarefa=@ds_tarefa,
		is_valor_fechado=@is_valor_fechado,
		qt_total_tarefa=@qt_total_tarefa,
		vl_custo=@vl_custo,
		vl_custo_extra=@vl_custo_extra,
		vl_custo_desconto=@vl_custo_desconto,
		ds_custo_extra=@ds_custo_extra,
		ds_custo_desconto=@ds_custo_desconto,
		dt_pagamento=@dt_pagamento,
		dt_prev_inicio=@dt_prev_inicio,
		dt_prev_final=@dt_prev_final,
		ds_observacao=@ds_observacao
		WHERE id_tarefa = @id_tarefa
				
		set nocount off

