GO
/****** Object:  StoredProcedure [dbo].[pr_por_get_portal_usuario]    Script Date: 07/28/2008 10:48:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_por_get_portal_usuario] 
				(@id_usuario int)

AS

SELECT	a.*,
		c.ds_portal
FROM	tb_por_usuario a
inner join tb_por_portal_usuario b
on a.id_usuario = b.id_usuario
AND a.id_usuario = @id_usuario 
inner join tb_por_portal c
on b.id_portal = c.id_portal
