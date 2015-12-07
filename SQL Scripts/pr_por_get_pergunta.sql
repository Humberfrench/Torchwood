GO
/****** Object:  StoredProcedure [dbo].[pr_por_get_pergunta]    Script Date: 07/28/2008 10:48:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Humberto Almeida
-- Create date: 28/09/2007
-- Description:	Lista a Pergunta de uma enquete
-- =============================================
CREATE PROCEDURE [dbo].[pr_por_get_pergunta] 
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT	id_pergunta, 
			ds_pergunta, 
			st_pergunta 
	FROM	tb_por_pergunta_enquete 
	WHERE	st_pergunta = 'A';

END
