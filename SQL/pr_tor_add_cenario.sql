CREATE PROCEDURE pr_tor_add_cenario(@id_loteria Tinyint,
				    @ds_cenario varchar(50),
				    @nr_conc_ini int = 1,
				    @nr_conc_fim int = 0,
				    @id_cenario int OUTPUT)
AS

	-- se concurso inicial for = 1 entao é o numero um, se não é o valor que for passado.
	-- se concurso final for = 0 entao é o numero um, se não é o valor que for passado.
	-- sendo ambos diferentes dos valores iniciais, devem ter consistencia no sistema.

	if (@nr_conc_fim = 0) then
	begin
		SELECT @nr_conc_fim = MAX(nr_concurso)
		FROM tb_tor_dezenas
		WHERE id_loteria = @id_loteria
	end



	INSERT INTO tb_tor_cenario
	(id_loteria,
	ds_cenario,
	dt_cenario,
	nr_conc_ini,
	nr_conc_fim)
	VALUES(
	@id_loteria ,
	@ds_cenario,
	getdate(),
	@nr_conc_ini,
	@nr_conc_fim)

	SELECT @id_cenario = @@identity

GO






