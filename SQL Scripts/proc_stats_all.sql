set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [pr_tor_get_stats_all] (@id_loteria int, 
										@faixa int, 
										@pesq_guid_habilitado VARCHAR(01) = 'N')
AS
BEGIN
	SET NOCOUNT ON
	--variaveis deajuste
	DECLARE @int_total_lines NUMERIC(10,5)
	DECLARE @int_lines_conc NUMERIC(10,5)
	DECLARE	@int_total_lines_faixa NUMERIC(10,5)
	DECLARE @qt_dezenas NUMERIC(10,5)
	DECLARE @pc_media NUMERIC(10,5)
	DECLARE @pc_media_rounded NUMERIC(10,5)
	DECLARE @nr_conc_ini INT
	DECLARE @nr_conc_fim INT 
	DECLARE @nr_last_conc INT
    DECLARE @id_faixa INT
    DECLARE @ds_faixa VARCHAR(50)
	DECLARE	@status INT
	DECLARE	@qt_dezena_sup_faixa	INT 
	DECLARE	@qt_dezena_sup_round	INT 
	DECLARE	@id_guid uniqueidentifier
	--variaveis do calculo do arredondamento
	DECLARE @round1 NUMERIC(10,5)
	DECLARE @round2 NUMERIC(10,5)
	DECLARE @media NUMERIC(10,5)

	CREATE TABLE #tb_results(
	id_guid				    uniqueidentifier,		-- guid da faixa
	id_faixa				INT null,				-- código da faixa
	ds_faixa				VARCHAR(50) null,		-- descrição da faixa
	id_faixa_ini			INT	null,				-- faixa inicial
	id_faixa_fim			INT	null,				-- faixa inicial
	nr_dezena				INT null,				-- numero dadezena
	qt_dezena				NUMERIC(10,5) null,		-- qtde de ocorrencias
	pc_dezena				NUMERIC(10,5) null,		-- percentual de ocorrencias no intervalo (qtde concursos)
	pc_dezena_total			NUMERIC(10,5) null,		-- percentual de ocorrenciasem relacao ao evento amostral todo
	total_concursos			NUMERIC(10,5) null,		-- quantidade de concursos - faixa
	total_dezenas			NUMERIC(10,5) null,		-- quantidade total de dezenas envolvidas
	pc_media_faixa			NUMERIC(10,5) null,		-- percentual médio de todos os percentuais
	pc_media_faixa_round	NUMERIC(10,5) null,		-- percentual arredondado
	ind_dezena_sup_faixa	VARCHAR(01) null,		-- indicador da dezena estar com percentual superior a media
	ind_dezena_sup_round	VARCHAR(01) null,		-- indicador da dezena estar com percentual superior a media arredondada
	qt_dezena_sup_faixa		INT null,				-- qtde da dezena estar com percentual superior a media - ttl da faixa
	qt_dezena_sup_round		INT null)				-- qtde da dezena estar com percentual superior a media arredondada - ttl da faixa

	-- inicializando variáveis
	-- numeros de concursos e faixas
	SELECT	@id_guid = NEWID(),
			@id_faixa = 1, 
			@nr_conc_ini = 1, 
			@nr_conc_fim = @nr_conc_ini + @faixa -1 ,
			@ds_faixa = 'Faixa de ' + convert(varchar(5),@nr_conc_ini) + ' até ' + convert(varchar(5),@nr_conc_fim)	

	--número do ultimo concurso
	SELECT	@nr_last_conc = max(nr_concurso)
	FROM	tb_tor_dezenas
	WHERE	id_loteria = @id_loteria

	-- quantidade de dezenas da loteria
	SELECT	@qt_dezenas = CONVERT(NUMERIC(10,5),qt_dezenas),
			@int_total_lines_faixa = @faixa * @qt_dezenas
	FROM	tb_tor_loteria
	WHERE	id_loteria = @id_loteria

	SELECT @status = 0
	
	WHILE (@status = 0)
	BEGIN

		SELECT	@int_total_lines = CONVERT(NUMERIC(10,5),COUNT(a.nr_dezena)) 
		FROM	tb_tor_dezenas a
		WHERE	a.id_loteria = @id_loteria
		AND		a.nr_concurso > = @nr_conc_ini
		AND		a.nr_concurso < = @nr_conc_fim

		SELECT	@int_lines_conc =  @int_total_lines / @qt_dezenas
		FROM	tb_tor_dezenas a
		WHERE	a.id_loteria = @id_loteria
		AND		a.nr_concurso > = @nr_conc_ini
		AND		a.nr_concurso < = @nr_conc_fim

		INSERT INTO #tb_results
		SELECT	@id_guid,
				@id_faixa,
				@ds_faixa,
				@nr_conc_ini,
				@nr_conc_fim,
				a.nr_dezena, 
				COUNT(a.nr_dezena),
				CONVERT(NUMERIC(10,5),Count(a.nr_dezena)) * 100 / @int_total_lines,
				CONVERT(NUMERIC(10,5),Count(a.nr_dezena)) * 100 / @int_lines_conc,
				@int_lines_conc,
				@int_total_lines,
				0,
				0,
				'N',
				'N',
				0,
				0
		FROM tb_tor_dezenas a
		WHERE	a.nr_concurso > = @nr_conc_ini
		AND		a.nr_concurso < = @nr_conc_fim
		GROUP BY a.nr_dezena, a.id_loteria
		HAVING	a.id_loteria = @id_loteria
		ORDER BY a.nr_dezena

		-- calcular a média da faixa
		SELECT	@pc_media = AVG(pc_dezena_total)
		FROM	#tb_results
		WHERE	id_faixa = @id_faixa
		
		UPDATE	#tb_results
		SET		pc_media_faixa = @pc_media
		WHERE	id_faixa = @id_faixa

		UPDATE	#tb_results
		SET		ind_dezena_sup_faixa = 'S'
		WHERE	id_faixa = @id_faixa
		AND		pc_dezena_total >= @pc_media
		
		-- arredondar
		SELECT	@pc_media_rounded = 0,
				@round1 = 0, 
				@round2 = @round1 + 10,
				@media = (@round2 + @round1)/2

		WHILE (@round2 < 100)
		BEGIN
			IF @pc_media BETWEEN @round1 AND @round2
				BEGIN
					IF @pc_media BETWEEN @round1 AND @media
						IF @pc_media = @round1
							SELECT @pc_media_rounded = @round1
						ELSE
							SELECT @pc_media_rounded = @media
					ELSE
						IF @pc_media = @media
							SELECT @pc_media_rounded = @media
						ELSE
							SELECT @pc_media_rounded = @round2
				END

			SELECT	@round1 = @round2, 
					@round2 = @round2 + 10,
					@media = (@round2 + @round1)/2

		END

		-- atualizar médias
		UPDATE	#tb_results
		SET		pc_media_faixa_round = @pc_media_rounded
		WHERE	id_faixa = @id_faixa

		UPDATE	#tb_results
		SET		ind_dezena_sup_round = 'S'
		WHERE	id_faixa = @id_faixa
		AND		pc_dezena_total >= @pc_media_rounded


		SELECT	@qt_dezena_sup_faixa = COUNT(1)
		FROM	#tb_results
		WHERE	ind_dezena_sup_faixa = 'S'
		AND		id_faixa = @id_faixa 

		SELECT	@qt_dezena_sup_round = COUNT(1)
		FROM	#tb_results
		WHERE	ind_dezena_sup_round = 'S'
		AND		id_faixa = @id_faixa 

		UPDATE	#tb_results
		SET		qt_dezena_sup_faixa = @qt_dezena_sup_faixa,
				qt_dezena_sup_round = @qt_dezena_sup_round
		WHERE	id_faixa = @id_faixa 

		if  @pesq_guid_habilitado = 'S'
		BEGIN
			INSERT INTO tb_tor_temp_dezena
			SELECT id_guid, nr_dezena
			FROM	#tb_results
			WHERE	id_faixa = @id_faixa 
		END
		-- numeros de concursos e faixas
		SELECT	@id_guid = NEWID(),
				@id_faixa = @id_faixa + 1, 
				@nr_conc_ini = @nr_conc_ini + @faixa, 
				@nr_conc_fim = @nr_conc_fim + @faixa,
				@ds_faixa = 'Faixa de ' + convert(varchar(5),@nr_conc_ini) + ' até ' + convert(varchar(5),@nr_conc_fim)  
		

		IF (@nr_conc_ini > @nr_last_conc AND @nr_conc_fim > @nr_last_conc)
			SELECT @status = 1

	END

	SELECT * FROM #tb_results
	
	/*
	SELECT	nr_dezena, 
			ind_dezena_sup_faixa,
			count(ind_dezena_sup_faixa)
	FROM	#tb_results
	GROUP BY nr_dezena, 
			ind_dezena_sup_faixa
	HAVING	ind_dezena_sup_faixa = 'S'
	ORDER BY nr_dezena

	SELECT	nr_dezena, 
			ind_dezena_sup_round,
			count(ind_dezena_sup_round)
	FROM	#tb_results
	GROUP BY nr_dezena, 
			ind_dezena_sup_round
	HAVING	ind_dezena_sup_round = 'S'
	ORDER BY nr_dezena
	*/

END
go

pr_tor_get_stats_all 5 , 10 , 'S'

