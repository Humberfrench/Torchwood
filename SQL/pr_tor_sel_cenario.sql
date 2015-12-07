CREATE PROCEDURE pr_tor_sel_cenario(@id_cenario int)
AS



	SELECT 	a.id_cenario,
		a.id_loteria,
		a.ds_cenario,
		a.dt_cenario,
		a.nr_conc_ini,
		a.nr_conc_fim,
		b.nm_loteria
	FROM 	tb_tor_cenario a
	INNER JOIN tb_tor_loteria b
	ON 	a.id_loteria = b.id_loteria

GO


