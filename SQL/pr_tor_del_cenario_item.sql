CREATE PROCEDURE pr_tor_del_cenario_item(@id_cenario int, @id_item int)
AS


	DELETE
	FROM 	tb_tor_cenario_item 
	WHERE 	id_cenario = @id_cenario 
	AND	id_item = @id_item

GO
