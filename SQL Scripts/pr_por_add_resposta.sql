GO
/****** Object:  StoredProcedure [dbo].[pr_por_add_resposta]    Script Date: 07/28/2008 10:48:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Humberto Almeida
-- Create date: 28/09/2007
-- Description:	Grava a resposta de uma enquete
-- =============================================
CREATE PROCEDURE [dbo].[pr_por_add_resposta] (@id_resposta integer)
AS
BEGIN
	
	SET NOCOUNT ON;

	UPDATE	tb_por_resposta_enquete 
	SET		qt_voto = qt_voto + 1 
	WHERE	id_resposta =  @id_resposta

END