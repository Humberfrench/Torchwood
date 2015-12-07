GO
/****** Object:  StoredProcedure [dbo].[pr_por_add_usuario_portal]    Script Date: 07/28/2008 10:48:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_por_add_usuario_portal]
				(@id_portal int ,@id_usuario int)

AS

INSERT INTO tb_por_portal_usuario
(id_portal, id_usuario)
VALUES (@id_portal, @id_usuario)

