GO
/****** Object:  StoredProcedure [dbo].[pr_cor_alter_recibo]    Script Date: 07/28/2008 10:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pr_cor_alter_recibo] (@id_recibo int,@id_tomador int,@ds_recibo varchar(100),@vl_recibo float,@dt_recibo smalldatetime)

AS
UPDATE   tb_cor_recibo
SET	 id_tomador = @id_tomador,
	 ds_recibo = @ds_recibo, 
	 vl_recibo = @vl_recibo, 
	 dt_recibo = @dt_recibo
WHERE	 id_recibo = @id_recibo

go
