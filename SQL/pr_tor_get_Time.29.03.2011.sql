CREATE PROCEDURE pr_tor_get_Time (@id_time int output,@nm_time varchar(50), @nm_uf varchar(2))

AS

SELECT	@id_time  = id_time
FROM	tb_tor_loteria_timemania
WHERE	nm_time = @nm_time
AND		uf_time = @nm_uf


GO