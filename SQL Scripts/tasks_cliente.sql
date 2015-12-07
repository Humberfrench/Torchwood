select * from tb_cor_tarefa
where id_cliente = 10

select id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa 
from tb_cor_tarefa_item

dbo.pr_cor_lista_custo_tarefas

begin tran
insert into tb_cor_tarefa
(id_servico, id_cliente, ds_tarefa, vl_custo, vl_custo_extra, vl_custo_total, vl_custo_desconto, 
ds_custo_extra, ds_custo_desconto, dt_cadastro, dt_pagamento, dt_prev_inicio, dt_prev_final)
values (2,10, 'Faxina e Passagem de Roupa - Julho',0,0,0,0,'Reembolso de Condução e Arredondamento',
'Outros', getdate(), '20080812','20080722','20080731')

insert into tb_cor_tarefa
(id_servico, id_cliente, ds_tarefa, vl_custo, vl_custo_extra, vl_custo_total, vl_custo_desconto, 
ds_custo_extra, ds_custo_desconto, dt_cadastro, dt_pagamento, dt_prev_inicio, dt_prev_final)
values (2,10, 'Faxina e Passagem de Roupa - Agosto',0,0,0,0,'Reembolso de Condução e Arredondamento',
'Outros', getdate(), '20080912','20080801','20080831')

insert into tb_cor_tarefa
(id_servico, id_cliente, ds_tarefa, vl_custo, vl_custo_extra, vl_custo_total, vl_custo_desconto, 
ds_custo_extra, ds_custo_desconto, dt_cadastro, dt_pagamento, dt_prev_inicio, dt_prev_final)
values (2,10, 'Faxina e Passagem de Roupa - Setembro',0,0,0,0,'Reembolso de Condução e Arredondamento',
'Outros', getdate(), '20081014','20080901','20080930')

insert into tb_cor_tarefa
(id_servico, id_cliente, ds_tarefa, vl_custo, vl_custo_extra, vl_custo_total, vl_custo_desconto, 
ds_custo_extra, ds_custo_desconto, dt_cadastro, dt_pagamento, dt_prev_inicio, dt_prev_final)
values (2,10, 'Faxina e Passagem de Roupa - Outubro',0,0,0,0,'Reembolso de Condução e Arredondamento',
'Outros', getdate(), '20081111','20081001','20081031')

insert into tb_cor_tarefa
(id_servico, id_cliente, ds_tarefa, vl_custo, vl_custo_extra, vl_custo_total, vl_custo_desconto, 
ds_custo_extra, ds_custo_desconto, dt_cadastro, dt_pagamento, dt_prev_inicio, dt_prev_final)
values (2,10, 'Faxina e Passagem de Roupa - Novembro',0,0,0,0,'Reembolso de Condução e Arredondamento',
'Outros', getdate(), '20081212','20081101','20081130')

insert into tb_cor_tarefa
(id_servico, id_cliente, ds_tarefa, vl_custo, vl_custo_extra, vl_custo_total, vl_custo_desconto, 
ds_custo_extra, ds_custo_desconto, dt_cadastro, dt_pagamento, dt_prev_inicio, dt_prev_final)
values (2,10, 'Faxina e Passagem de Roupa - Dezembro',0,0,0,0,'Reembolso de Condução e Arredondamento',
'Outros', getdate(), '20090113','20081201','20081231')

commit tran

rollback tran

begin tran

insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(14,1,'Passar Roupa',1,'20080722')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(14,2,'Faxina',1,'20080725')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(14,3,'Passar Roupa',1,'20080729')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(15,1,'Faxina',1,'20080801')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(15,2,'Passar Roupa',1,'20080505')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(15,3,'Faxina',1,'20080808')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(15,4,'Passar Roupa',1,'20080812')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(15,5,'Faxina',1,'20080815')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(15,6,'Passar Roupa',1,'20080819')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(15,7,'Faxina',1,'20080822')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(15,8,'Passar Roupa',1,'20080826')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(15,9,'Faxina',1,'20080829')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(16,1,'Passar Roupa',1,'20080902')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(16,2,'Faxina',1,'20080905')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(16,3,'Passar Roupa',1,'20080909')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(16,4,'Faxina',1,'20080912')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(16,5,'Passar Roupa',1,'20080916')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(16,6,'Faxina',1,'20080919')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(16,7,'Passar Roupa',1,'20080923')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(16,8,'Faxina',1,'20080926')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(16,9,'Passar Roupa',1,'20080930')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(17,1,'Faxina',1,'20081003')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(17,2,'Passar Roupa',1,'20081007')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(17,3,'Faxina',1,'20081010')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(17,4,'Passar Roupa',1,'20081014')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(17,5,'Faxina',1,'20081017')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(17,6,'Passar Roupa',1,'20081021')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(17,7,'Faxina',1,'20081024')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(17,8,'Passar Roupa',1,'20081028')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(17,9,'Faxina',1,'20081031')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(18,1,'Passar Roupa',1,'20081104')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(18,2,'Faxina',1,'20081107')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(18,3,'Passar Roupa',1,'20081111')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(18,4,'Faxina',1,'20081114')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(18,5,'Passar Roupa',1,'20081118')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(18,6,'Faxina',1,'20081121')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(18,7,'Passar Roupa',1,'20081125')
insert into tb_cor_tarefa_item (id_tarefa, id_tarefa_item, ds_item, qt_tarefa, dt_tarefa) values(18,8,'Faxina',1,'20081128')

commit tran

rollback tran

pr_cor_atualiza_custo_task 14
go
pr_cor_atualiza_custo_task 15
go
pr_cor_atualiza_custo_task 16
go
pr_cor_atualiza_custo_task 17
go
pr_cor_atualiza_custo_task 18
go
pr_cor_atualiza_custo_task 19
go

alter procedure pr_cor_atualiza_custo_task (@id_tarefa int)
as
set nocount on

declare @vl_custo_servico numeric(10,2)
declare @vl_custo_total numeric(10,2)
declare @id_servico int
declare @qt_total_task numeric(10, 2)

select @id_servico = id_servico 
from tb_cor_tarefa 
where id_tarefa = @id_tarefa

select @vl_custo_servico = vl_custo
from tb_cor_servico
where id_servico = @id_servico

select @vl_custo_total = (isnull(sum(qt_tarefa),0) * @vl_custo_servico),
       @qt_total_task = isnull(sum(qt_tarefa),0)
from tb_cor_tarefa_item
where id_tarefa = @id_tarefa

update tb_cor_tarefa
set vl_custo = isnull(@vl_custo_total,0),
qt_total_tarefa = isnull(@qt_total_task,0),
vl_custo_total = ((isnull(@vl_custo_total,0) + isnull(vl_custo_extra,0)) - isnull(vl_custo_desconto,0))
where id_tarefa = @id_tarefa

go