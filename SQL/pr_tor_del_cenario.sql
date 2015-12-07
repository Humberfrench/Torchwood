CREATE PROCEDURE pr_tor_del_cenario(@id_cenario int)
AS


	DELETE
	FROM 	tb_tor_cenario 
	WHERE 	id_cenario = @id_cenario 


GO
