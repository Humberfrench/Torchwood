GO
/****** Object:  StoredProcedure [dbo].[pr_cor_calcula_tributo_nota]    Script Date: 07/28/2008 10:48:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[pr_cor_calcula_tributo_nota] (@id_cliente integer, @nr_nota varchar(04), @id_tributo integer, @ds_observacao varchar(50) = null)

AS

--declara as variaveis
declare @pc_tributo numeric(10,2)
declare @vl_tributo numeric(10,2)
declare @vl_nota numeric(10,2)
declare @vl_devido numeric(10,2)
declare @vl_retido numeric(10,2)

--obtem o percentual do tributo
select	@pc_tributo = vl_inicial
from	tb_cor_tributo
where	id_tributo = @id_tributo

--obtem o valor da nota
select	@vl_nota = vl_nota
from	tb_cor_notafiscal
where   nr_nota = @nr_nota
and		id_cliente_prestador = @id_cliente

--calcula o tributo
select  @vl_tributo = (@vl_nota * (@pc_tributo / 100))

--insere o registro
insert into tb_cor_tributo_cliente
(id_tributo, id_cliente, nr_nota, vl_tributo, ds_observacao)
values
(@id_tributo,@id_cliente,@nr_nota,@vl_tributo,@ds_observacao)

--obtem a somatoria dos valores retidos
select	@vl_retido = sum(vl_tributo)
from	tb_cor_tributo_cliente
where	nr_nota = @nr_nota
and		id_tributo in(select id_tributo from tb_cor_tributo where is_nf_retido = 'S')

--obtem a somatoria dos valores a pagar/trimestalmente
select	@vl_devido = sum(vl_tributo)
from	tb_cor_tributo_cliente
where	nr_nota = @nr_nota
and		id_tributo in(select id_tributo from tb_cor_tributo where is_nf_retido = 'N')

UPDATE	tb_cor_notafiscal
SET		vl_retido = @vl_retido,
		vl_devido = @vl_devido
from	tb_cor_notafiscal
where   nr_nota = @nr_nota
and		id_cliente_prestador = @id_cliente

GO
