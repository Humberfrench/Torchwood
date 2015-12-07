CREATE PROCEDURE pr_tor_del_cenario_item_all(@id_cenario int)
AS


	DELETE
	FROM 	tb_tor_cenario_item 
	WHERE 	id_cenario = @id_cenario 

GO
