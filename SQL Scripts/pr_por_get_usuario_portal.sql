GO
/****** Object:  StoredProcedure [dbo].[pr_por_get_usuario_portal]    Script Date: 07/28/2008 10:48:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[0]
				(@id_portal int)

AS

SELECT	a.*,
		c.ds_portal
FROM	tb_por_usuario a
inner join tb_por_portal_usuario b
on a.id_usuario = b.id_usuario
inner join tb_por_portal c
on b.id_portal = c.id_portal
AND b.id_portal = @id_portal 
