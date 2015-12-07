CREATE PROCEDURE pr_tor_get_cenario_item(@id_cenario int)
AS



	SELECT 	id_cenario,
		nr_item,
		nr_faixa_de,
		nr_faixa_ate,
		ds_ponto_medio,
		vl_faixa,
		vl_frequencia_faixa,
		vl_frequencia_acum
	FROM 	tb_tor_cenario 
	WHERE 	id_cenario = @id_cenario 
	ORDER BY nr_item

GO


