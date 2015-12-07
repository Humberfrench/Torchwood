GO
/****** Object:  StoredProcedure [dbo].[pr_por_lista_noticia]    Script Date: 07/28/2008 10:48:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Humberto Almeida
-- Create date: 28/09/2007
-- Description:	Busca Noticias
-- =============================================
CREATE PROCEDURE [dbo].[pr_por_lista_noticia] (@id_portal integer)
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT	a.id_noticia,
			a.id_portal, 
			a.ds_titulo, 
			a.ds_resumo, 
			a.ds_noticia, 
			a.dt_noticia, 
			a.dt_expira, 
			a.id_usuario, 
			a.id_categoria, 
			a.nr_acessos, 
			a.is_principal, 
			b.ds_categoria, 
			c.ds_login 
	FROM	tb_por_noticia a
	INNER JOIN  tb_por_categoria b
	ON		a.id_categoria = b.id_categoria
	AND		(a.id_portal = @id_portal or id_portal = 0)
	INNER JOIN tb_por_usuario  c
	ON		a.id_usuario = c.id_usuario
	AND		a.is_principal = 'S'
	ORDER BY a.dt_noticia DESC

END
