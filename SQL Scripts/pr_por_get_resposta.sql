GO
/****** Object:  StoredProcedure [dbo].[pr_por_get_resposta]    Script Date: 07/28/2008 10:48:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Humberto Almeida
-- Create date: 28/09/2007
-- Description:	Lista a Pergunta de uma enquete
-- =============================================
CREATE PROCEDURE [dbo].[pr_por_get_resposta] (@id_pergunta integer)
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT	id_resposta, 
			id_pergunta, 
			ds_resposta, 
			qt_voto 
	FROM	tb_por_resposta_enquete 
	WHERE	id_pergunta = @id_pergunta 
	ORDER BY id_resposta

END