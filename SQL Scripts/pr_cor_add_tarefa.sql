GO
/****** Object:  StoredProcedure [dbo].[pr_cor_add_tarefa]    Script Date: 07/28/2008 10:47:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[pr_cor_add_tarefa] (@id_servico integer,
											@id_cliente integer,
											@ds_tarefa varchar(100),
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

		insert into tb_cor_tarefa
		(id_servico,
		id_cliente,
		ds_tarefa,
		qt_total_tarefa,
		vl_custo,
		vl_custo_extra,
		vl_custo_desconto,
		ds_custo_extra,
		ds_custo_desconto,
		dt_cadastro,
		dt_pagamento,
		dt_prev_inicio,
		dt_prev_final,
		ds_observacao)
		VALUES 
		(@id_servico,
		@id_cliente,
		@ds_tarefa,
		@qt_total_tarefa,
		@vl_custo,
		@vl_custo_extra,
		@vl_custo_desconto,
		@ds_custo_extra,
		@ds_custo_desconto,
		getdate(),
		@dt_pagamento,
		@dt_prev_inicio,
		@dt_prev_final,
		@ds_observacao)
		
		SELECT @@identity retorno

		
		
		set nocount off
