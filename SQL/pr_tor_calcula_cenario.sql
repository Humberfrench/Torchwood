CREATE PROCEDURE pr_tor_calcula_cenario(@id_cenario int)
AS


	DECLARE @vl_freq_abs numeric(10,8)
	DECLARE @vl_freq_acum numeric(10,8)
	DECLARE @pc_freq_abs numeric(10,8)
	DECLARE @pc_freq_acum numeric(10,8)
	DECLARE @vl_freq_total numeric(10,8)
	DECLARE @id_loteria tinyint
	DECLARE @nr_conc_ini int
	DECLARE @nr_conc_fim int
	DECLARE @nr_item tinyint
	DECLARE @nr_faixa_de tinyint
	DECLARE @nr_faixa_ate tinyint

	-- inicia a frequencia a cumulada
	SELECT @freq_acum = 0

	-- busca os dados do cenário
	SELECT 	@id_loteria = id_loteria
		@nr_conc_ini = nr_conc_ini
		@nr_conc_fim = nr_conc_fim
	FROM 	tb_tor_cenario
	WHERE	id_cenario = @id_cenario

	-- cursor para ler os itens
	DECLARE cur_dados CURSOR LOCAL
	FORWARD_ONLY
	FOR 
	SELECT 	nr_item,
		nr_faixa_de,
		nr_faixa_ate
	FROM 	tb_tor_cenario_item
	WHERE 	id_cenario = @id_cenario 
	ORDER BY nr_item


	-- abre o cursor
	OPEN cur_dados
	FETCH NEXT FROM cur_dados 
	INTO @nr_item, @nr_faixa_de, @nr_faixa_ate
	
	-- obtem a soma total dos valores
	SELECT 	@vl_freq_total = COUNT(nr_dezena) 
	FROM 	tb_tor_dezenas
	WHERE 	id_loteria = @id_loteria
	AND 	nr_conc >= @nr_conc_ini
	AND 	nr_conc <= @nr_conc_fim
	
	--lendo o cursor
	WHILE @@FETCH_STATUS = 0
	BEGIN

		-- obtem a soma dos valores
		SELECT 	@freq_abs = COUNT(nr_dezena) 
		FROM 	tb_tor_dezenas
		WHERE 	id_loteria = @id_loteria
		AND 	nr_dezena >= @nr_faixa_de
		AND 	nr_dezena <= @nr_faixa_ate
		AND 	nr_conc >= @nr_conc_ini
		AND 	nr_conc <= @nr_conc_fim

		SELECT 	@freq_acum = @freq_acum + @freq_abs
		
		SELECT 	@pc_freq_abs = ((@vl_freq_abs / @vl_freq_total) * 100)

		SELECT 	@pc_freq_acum = ((@freq_acum / @vl_freq_total) * 100)

		UPDATE 	tb_tor_cenario_item
		SET	vl_faixa = @vl_freq_abs,
			vl_faixa_acumulada = @vl_freq_acum, 
			pc_frequencia_faixa = @pc_freq_abs,
			pc_frequencia_acum = @pc_freq_acum
		WHERE	id_cenario = @id_cenario
		AND	nr_item = @nr_item

		FETCH NEXT FROM cur_dados 
		INTO @nr_item, @nr_faixa_de, @nr_faixa_ate

	END
	CLOSE cur_dados
	DEALLOCATE cur_dados

GO
