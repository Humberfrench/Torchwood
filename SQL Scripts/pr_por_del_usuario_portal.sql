GO
/****** Object:  StoredProcedure [dbo].[pr_por_del_usuario_portal]    Script Date: 07/28/2008 10:48:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_por_del_usuario_portal]
				(@id_portal int ,@id_usuario int)

AS

DELETE FROM  tb_por_portal_usuario
WHERE id_portal = @id_portal
AND  id_usuario = @id_usuario

