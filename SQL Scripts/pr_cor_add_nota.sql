GO
/****** Object:  StoredProcedure [dbo].[pr_cor_add_nota]    Script Date: 07/28/2008 10:47:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[pr_cor_add_nota] (@nr_nota varchar(04), 
										  @id_cliente_prestador int,
										  @nr_cod_verificacao varchar(50) = null, 
								  		  @id_cliente integer, 
										  @dt_nota smalldatetime, 
										  @vl_nota numeric(10,2), 
										  @ir_retido numeric(10,2),
										  @vl_retido numeric(10,2),
										  @vl_devido numeric(10,2),
										  @st_nota varchar(01), 
										  @ds_caminho varchar(100),
										  @ds_observacao varchar(100)) 
as



INSERT INTO tb_cor_notafiscal
	    (nr_nota,
		 id_cliente_prestador,
		 nr_cod_verificacao,
		 id_cliente,
		 dt_nota,
		 vl_nota,
		 ir_retido,
		 vl_retido,
		 vl_devido,
		 st_nota,
		 ds_caminho,
		 ds_observacao)
VALUES  (@nr_nota,
		 @id_cliente_prestador,
		 @nr_cod_verificacao,
		 @id_cliente,
		 @dt_nota,
		 @vl_nota,
		 @ir_retido,
		 @vl_retido,
		 @vl_devido,
		 @st_nota,
		 @ds_caminho,
		 @ds_observacao) 
		 
go

