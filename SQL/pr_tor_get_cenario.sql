CREATE PROCEDURE pr_tor_get_cenario(@id_cenario int)
AS



	SELECT 	a.id_cenario,
		a.id_loteria,
		a.ds_cenario,
		a.dt_cenario,
		a.nr_conc_ini,
		a.nr_conc_fim,
		b.ds_loteria
	FROM 	tb_tor_cenario a
	INNER JOIN tb_tor_loteria b
	ON 	a.id_loteria = b.id_loteria
	WHERE 	a.id_cenario = @id_cenario 

GO


