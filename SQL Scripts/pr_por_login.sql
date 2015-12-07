GO
/****** Object:  StoredProcedure [dbo].[pr_por_login]    Script Date: 07/28/2008 10:48:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pr_por_login] (@ds_login varchar(10))

AS

	SELECT  a.id_usuario, a.id_acesso,
			a.ds_login, a.ds_senha, 
			a.ds_nome, a.ds_telefone, 
			a.ds_email, b.ds_acesso
	FROM	tb_por_usuario a
	INNER JOIN tb_por_acesso b
	ON	a.id_acesso = b.id_acesso
	AND		a.ds_login = @ds_login


GO
/****** Object:  StoredProcedure [dbo].[pr_por_menu]    Script Date: 07/28/2008 10:48:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_por_menu]
AS

BEGIN

SELECT	a.id_modulo, 
		a.ds_modulo, 
		a.ds_caption, 
		a.ds_tooltip, 
		a.ds_caminho, 
		b.nr_ordem
FROM tb_por_modulo  a
INNER JOIN tb_por_menu_geral b
ON	a.id_modulo = b.id_modulo
ORDER BY b.nr_ordem;

END
