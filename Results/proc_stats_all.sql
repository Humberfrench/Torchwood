set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [pr_tor_get_stats_all] (@id_loteria int, @faixa int)
AS
BEGIN
	SET NOCOUNT ON;
	declare @int_total_lines NUMERIC(8,3)
	declare @int_lines_conc NUMERIC(8,3)
	declare @qt_dezenas NUMERIC(8,3)
	declare @nr_conc_ini int, @nr_conc_fim int, @nr_last_conc int
    declare @id_faixa int
    declare @ds_faixa varchar(50)

	create table #tb_results(
	id_faixa				int null,				-- código da faixa
	ds_faixa				varchar(50) null,		-- descrição da faixa
	nr_dezena				int null,				-- numero dadezena
	qt_dezena				int null,				-- qtde de ocorrencias
	pc_dezena				numeric(8,3) null,		-- percentual de ocorrencias no intervalo (qtde concursos)
	pc_dezena_total			numeric(8,3) null,		-- percentual de ocorrenciasem relacao ao evento amostral todo
	total_concursos			int null,				-- quantidade de concursos
	total_dezenas			int null,				-- quantidade total de dezenas envolvidas
	pc_media_faixa			numeric(8,3) null,		-- percentual médio de todos os percentuais
	pc_media_faixa_round	int null,				-- percentual arredondado
	ind_dezena_sup_faixa	varchar(01) null,		-- indicador da dezena estar com percentual superior a medis
	ind_dezena_sup_round	varchar(01) null,		-- indicador da dezena estar com percentual superior a medis arredondada

	-- inicializando variáveis
	SELECT	id_faixa = 1, 
			@nr_conc_ini = 1, 
			@nr_conc_fim = @nr_conc_ini + @faixa

	SELECT	@nr_last_conc = max(nr_concurso)
	FROM	tb_tor_dezenas
	WHERE	id_loteria = @id_loteria

	SELECT	@qt_dezenas = qt_dezenas 
	FROM	tb_tor_loteria
	WHERE	id_loteria = @id_loteria

    SELECT	@int_lines_conc = (Count(a.nr_dezena) / @qt_dezenas),
			@int_total_lines = Count(a.nr_dezena) 
	FROM	tb_tor_dezenas a
	WHERE	a.id_loteria = @id_loteria
	
    SELECT a.nr_dezena, 
	       Count(a.nr_dezena) AS qt_dezena,
	       CONVERT(NUMERIC(8,3),Count(a.nr_dezena) * 100 / @int_total_lines) AS pc_dezena,
		   CONVERT(NUMERIC(8,3),Count(a.nr_dezena) * 100 / @int_lines_conc) AS pc_dezena_total,
		   @int_lines_conc total_concursos,
		   @int_total_lines total_dezenas
	FROM tb_tor_dezenas a
	GROUP BY a.nr_dezena, a.id_loteria
	HAVING a.id_loteria = @id_loteria
	ORDER BY Count(a.nr_dezena) DESC;

END

