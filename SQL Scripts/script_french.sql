select * from tb_cor_cidade

select * from "8.8.246.34".french.dbo.tb_cor_cidade


select * from french_remote.french.dbo.tb_cor_cidade


-- 01 - estado
insert into french_remote.french.dbo.tb_cor_estado
SELECT * from tb_cor_estado

-- 02 - cidade
insert into french_remote.french.dbo.tb_cor_cidade
(nm_cidade, sg_uf)
SELECT nm_cidade, sg_uf from tb_cor_cidade
ORDER BY id_cidade

-- 03 - cores
insert into french_remote.french.dbo.tb_cor_cores (nm_cor)
SELECT nm_cor from tb_cor_cores

-- 04 - mes
insert into french_remote.french.dbo.tb_cor_mes
SELECT * from tb_cor_mes

-- 05 - indice
insert into french_remote.french.dbo.tb_cor_indice
(sg_indice, ds_indice, ds_obs)
SELECT sg_indice, ds_indice, ds_obs from tb_cor_indice

-- 06 - Tipo Cliente
insert into french_remote.french.dbo.tb_cor_tipo_cliente
(ds_tipo_cliente)
select ds_tipo_cliente from tb_cor_tipo_cliente
order by id_tipo_cliente

-- 07 - cliente
insert into french_remote.french.dbo.tb_cor_cliente
(id_tipo_cliente,nm_cliente,nm_razao,nr_CNPJ,
 nr_CCM,nr_inscr_estadual,nm_representante,nr_fone,
 nr_celular,ds_email1,ds_email2,ds_endereco,
 ds_numero,ds_compl,ds_bairro,ds_cep,id_UF,id_cidade,id_cliente_rel)
SELECT 
id_tipo_cliente,nm_cliente,nm_razao,nr_CNPJ,
 nr_CCM,nr_inscr_estadual,nm_representante,nr_fone,
 nr_celular,ds_email1,ds_email2,ds_endereco,
 ds_numero,ds_compl,ds_bairro,ds_cep,id_UF,id_cidade,id_cliente_rel
from tb_cor_cliente

-- 08 - Nota Fiscal
insert into french_remote.french.dbo.tb_cor_notafiscal
select * from tb_cor_notafiscal

-- 09 - Unidade
insert into french_remote.french.dbo.tb_cor_unidade
(sg_unidade, ds_unidade)
select sg_unidade, ds_unidade from tb_cor_unidade

-- 10 - Serviço
insert into french_remote.french.dbo.tb_cor_servico
(ds_servico, vl_custo, id_unidade)
select ds_servico, vl_custo, id_unidade from tb_cor_servico

-- 11 - Tarefa
insert into french_remote.french.dbo.tb_cor_tarefa
(id_servico,id_cliente,ds_tarefa,qt_total_tarefa,is_valor_fechado,
vl_custo,vl_custo_extra,vl_custo_total,vl_custo_desconto,
ds_custo_extra,ds_custo_desconto,dt_cadastro,dt_pagamento,
dt_prev_inicio,dt_prev_final,ds_observacao)
select 
id_servico,id_cliente,ds_tarefa,qt_total_tarefa,is_valor_fechado,
vl_custo,vl_custo_extra,vl_custo_total,vl_custo_desconto,
ds_custo_extra,ds_custo_desconto,dt_cadastro,dt_pagamento,
dt_prev_inicio,dt_prev_final,ds_observacao
from tb_cor_tarefa

-- 12 - Item de Tarefa
insert into french_remote.french.dbo.tb_cor_tarefa_item
select * from  tb_cor_tarefa_item

-- 13 - Recibo
insert into french_remote.french.dbo.tb_cor_recibo
(id_tarefa,id_tomador,ds_recibo,dt_recibo,nr_nota,ds_observacao)
select id_tarefa,id_tomador,ds_recibo,dt_recibo,nr_nota,ds_observacao
from  tb_cor_recibo

-- 14 - taxas
insert into french_remote.french.dbo.tb_cor_taxas
select * from tb_cor_taxas

-- 15 - tributos
insert into french_remote.french.dbo.tb_cor_tributo
(ds_tributo,vl_inicial,is_nf_retido)
select ds_tributo,vl_inicial,is_nf_retido
from tb_cor_tributo

-- 16 - tributos - cliente
insert into french_remote.french.dbo.tb_cor_tributo_cliente
SELECT * FROM tb_cor_tributo_cliente


-- portal
-- 01 - Acesso
insert into french_remote.french.dbo.tb_por_acesso
(ds_acesso)
SELECT ds_acesso FROM tb_por_acesso

-- 02 -Portal
insert into french_remote.french.dbo.tb_por_portal
(ds_portal,ds_endereco,st_portal)
select ds_portal,ds_endereco,st_portal from tb_por_portal

-- 03 - banners
insert into french_remote.french.dbo.tb_por_banners
(id_portal,ds_image,ds_link,ds_alt_description,qt_impressions)
SELECT id_portal,ds_image,ds_link,ds_alt_description,qt_impressions
FROM tb_por_banners

-- 04 - Categoria
insert into french_remote.french.dbo.tb_por_categoria
(ds_categoria)
select ds_categoria from tb_por_categoria

--modulo
insert into french_remote.french.dbo.tb_por_modulo
(ds_modulo,ds_caption,ds_tooltip,ds_caminho,tp_modulo,nr_ordem)
select ds_modulo,ds_caption,ds_tooltip,ds_caminho,tp_modulo,nr_ordem
from tb_por_modulo

-- menu geral
insert into french_remote.french.dbo.tb_por_menu_geral
select * from tb_por_menu_geral

-- usuario
insert into french_remote.french.dbo.tb_por_usuario
(id_acesso,ds_login,ds_senha,ds_dica_senha,ds_nome,ds_telefone,ds_email,ds_last_acess)
select id_acesso,ds_login,ds_senha,ds_dica_senha,ds_nome,ds_telefone,ds_email,ds_last_acess 
from tb_por_usuario

-- noticia
insert into french_remote.french.dbo.tb_por_noticia
(id_portal,ds_titulo,ds_resumo,ds_noticia,dt_noticia,dt_expira,
id_usuario,id_categoria,nr_acessos,is_principal,ds_fonte,ds_link_fonte)
select
id_portal,ds_titulo,ds_resumo,ds_noticia,dt_noticia,dt_expira,
id_usuario,id_categoria,nr_acessos,is_principal,ds_fonte,ds_link_fonte
from tb_por_noticia

-- portal usuario
insert into french_remote.french.dbo.tb_por_portal_usuario
select * from tb_por_portal_usuario

-- pergunta
insert into french_remote.french.dbo.tb_por_pergunta_enquete
(id_portal,ds_pergunta,st_pergunta)
select id_portal,ds_pergunta,st_pergunta
from tb_por_pergunta_enquete

--resposta
-- portal usuario
insert into french_remote.french.dbo.tb_por_resposta_enquete
(id_pergunta,ds_resposta,qt_voto)
select id_pergunta,ds_resposta,qt_voto 
from tb_por_resposta_enquete
