CREATE PROCEDURE pr_tor_add_cenario_item(@id_cenario	Tinyint,	
					 @nr_item	Tinyint,	
					 @nr_faixa_de	Tinyint,	
					 @nr_faixa_ate	Tinyint,	
					 @ds_ponto_medio	Tinyint)	


	--esta proc,insere os detalhes um a um das frequencias


	INSERT INTO tb_tor_cenario_item
	(id_cenario,
	nr_item,
	nr_faixa_de,
	nr_faixa_ate,
	ds_ponto_medio)
	VALUES(
	@id_cenario ,
	@nr_item,
	@nr_faixa_de,
	@nr_faixa_ate,
	@ds_ponto_medio)

GO