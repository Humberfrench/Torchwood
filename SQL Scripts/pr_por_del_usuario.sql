GO
/****** Object:  StoredProcedure [dbo].[pr_por_del_usuario]    Script Date: 07/28/2008 10:48:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_por_del_usuario] 
				(@id_usuario int)

AS

DELETE FROM tb_por_portal_usuario
WHERE id_usuario = @id_usuario 

DELETE FROM tb_por_usuario
WHERE id_usuario = @id_usuario 

