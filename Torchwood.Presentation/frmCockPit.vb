Imports System
Imports SourceGrid.Cells

Public Class frmCockPit
    Enum COLS
        FAIXA = 0
        FAIXA_ID = FAIXA
        FAIXA_DE
        FAIXA_ATE
        DEZENA
        DEZ_NUMERO = DEZENA
        DEZ_QTDE
        PERCENTUAL
        PERC_DEZENA = PERCENTUAL
        PERC_TOTAL
        PERCENTUAL_MEDIO
        PERC_MEDIO_NORMAL = PERCENTUAL_MEDIO
        PERC_MEDIO_NORMAL_ACIMA
        PERC_MEDIO_ARRED
        PERC_MEDIO_ARRED_ACIMA
    End Enum

    Enum CSTAT

        DEZENA = 0
        TOP_ALL
        TOTAL_ALL = TOP_ALL
        CONCS_ALL
        PC_REL_ALL
        PC_TTL_ALL
        TOP_IMP
        TOTAL_IMP = TOP_IMP
        CONCS_IMP
        PC_REL_IMP
        PC_TTL_IMP
        TOP_2
        TOTAL_2 = TOP_2
        CONCS_2
        PC_REL_2
        PC_TTL_2
        TOP_3
        TOTAL_3 = TOP_3
        CONCS_3
        PC_REL_3
        PC_TTL_3
        TOP_4
        TOTAL_4 = TOP_4
        CONCS_4
        PC_REL_4
        PC_TTL_4
        TOP_5
        TOTAL_5 = TOP_5
        CONCS_5
        PC_REL_5
        PC_TTL_5
        TOP_6
        TOTAL_6 = TOP_6
        CONCS_6
        PC_REL_6
        PC_TTL_6
        TOP_7
        TOTAL_7 = TOP_7
        CONCS_7
        PC_REL_7
        PC_TTL_7
        TOP_8
        TOTAL_8 = TOP_8
        CONCS_8
        PC_REL_8
        PC_TTL_8
        TOP_9
        TOTAL_9 = TOP_9
        CONCS_9
        PC_REL_9
        PC_TTL_9
        TOP_10
        TOTAL_10 = TOP_10
        CONCS_10
        PC_REL_10
        PC_TTL_10
        TOP_11
        TOTAL_11 = TOP_11
        CONCS_11
        PC_REL_11
        PC_TTL_11

    End Enum

    Private Sub frmCockPit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadCombo()
    End Sub

    Sub LoadCombo()

        Dim oTorch As New Torchwood.Core.Data.Loterias(Util.GetKey)
        Dim lTorch As IList(Of Struct.Loteria)

        lTorch = oTorch.List()
        For Each oLoteria As Struct.Loteria In lTorch
            ddlLoteria.Items.Add(oLoteria)
        Next

    End Sub

    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click

        'Dados da Faixa
        ConfigGridDadosFaixa()
        CarregaDadosFaixa()

        ConfigGridDadosDezenas()
        CarregaDadosDezenas()

    End Sub

    Sub ConfigGridDadosFaixa()

        Dim oColHeader As ColumnHeader
        Dim oColor As Color = Color.Gainsboro

        With grdStats
            .ColumnsCount = 11
            .FixedColumns = 0
            .FixedRows = 2
            .RowsCount = 0

            .Columns(COLS.FAIXA_ID).Width = 40 'faixa_id
            .Columns(COLS.FAIXA_DE).Width = 40 'faixa_de
            .Columns(COLS.FAIXA_ATE).Width = 40 'faixa_ate
            .Columns(COLS.DEZ_NUMERO).Width = 40 'dez_numero
            .Columns(COLS.DEZ_QTDE).Width = 40 'dez_qtde
            .Columns(COLS.PERC_DEZENA).Width = 80 'perc_dezena
            .Columns(COLS.PERC_TOTAL).Width = 80 'perc_total
            .Columns(COLS.PERC_MEDIO_NORMAL).Width = 80 'perc_medio_normal
            .Columns(COLS.PERC_MEDIO_NORMAL_ACIMA).Width = 30 'perc_medio_normal_acima
            .Columns(COLS.PERC_MEDIO_ARRED).Width = 80 'perc_medio_arred
            .Columns(COLS.PERC_MEDIO_ARRED_ACIMA).Width = 30 'perc_medio_arred_acima

            .Rows.Insert(0)
            .Rows.Insert(1)

            'formatando grid
            'grupo de faixas
            oColHeader = New ColumnHeader("Faixa")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(0, COLS.FAIXA) = oColHeader
            'id
            oColHeader = New ColumnHeader("ID")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, COLS.FAIXA_ID) = oColHeader
            'de
            oColHeader = New ColumnHeader("De")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, COLS.FAIXA_DE) = oColHeader
            'até
            oColHeader = New ColumnHeader("Até")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, COLS.FAIXA_ATE) = oColHeader
            'formatando colspan
            .Item(0, COLS.FAIXA).ColumnSpan = 3

            'Grupo de dezenas
            'id
            oColHeader = New ColumnHeader("Dados")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(0, COLS.DEZENA) = oColHeader
            'id
            oColHeader = New ColumnHeader("Dez.")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, COLS.DEZ_NUMERO) = oColHeader
            'id
            oColHeader = New ColumnHeader("Qtde.")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, COLS.DEZ_QTDE) = oColHeader
            .Item(0, COLS.DEZENA).ColumnSpan = 2

            'grupo de percentuais
            'Percentual
            oColHeader = New ColumnHeader("Percentual")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(0, COLS.PERCENTUAL) = oColHeader
            'Dezena
            oColHeader = New ColumnHeader("Dezena")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, COLS.PERC_DEZENA) = oColHeader
            'Total
            oColHeader = New ColumnHeader("Total")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, COLS.PERC_TOTAL) = oColHeader
            .Item(0, COLS.PERCENTUAL).ColumnSpan = 2

            'grupo de analise de percentual
            'Percentual
            oColHeader = New ColumnHeader("Analise Faixas")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(0, COLS.PERCENTUAL_MEDIO) = oColHeader
            'Normal
            oColHeader = New ColumnHeader("Normal")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, COLS.PERC_MEDIO_NORMAL) = oColHeader
            '?+
            oColHeader = New ColumnHeader("?+")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, COLS.PERC_MEDIO_NORMAL_ACIMA) = oColHeader
            'Arred.
            oColHeader = New ColumnHeader("Arred.")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, COLS.PERC_MEDIO_ARRED) = oColHeader
            '?+
            oColHeader = New ColumnHeader("?+")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, COLS.PERC_MEDIO_ARRED_ACIMA) = oColHeader
            .Item(0, COLS.PERCENTUAL_MEDIO).ColumnSpan = 4

            oColHeader = Nothing
            oColor = Nothing
        End With

    End Sub

    Sub CarregaDadosFaixa()

        Dim oTorch As New Torchwood.Core.Data.Statics(Util.GetKey)
        Dim lTorch As IList(Of Struct.StatsNumbers)
        Dim oLoteria As Struct.Loteria

        'Estatisticos
        Try
            Me.Cursor = Cursors.WaitCursor
            oLoteria = CType(ddlLoteria.SelectedItem, Struct.Loteria)

            lTorch = oTorch.GenerateStatsData(oLoteria.Codigo, _
                                              Convert.ToInt16(txtFaixas.Text))
            LoadGridFaixa(lTorch)

            oTorch = Nothing
            lTorch = Nothing
            oLoteria = Nothing

            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            oTorch = Nothing
            lTorch = Nothing
            oLoteria = Nothing
            Me.Cursor = Cursors.Arrow
            ShowErro(ex, "Erro Ocorrido", Me.Name)
        End Try

    End Sub

    Sub LoadGridFaixa(ByVal lTorch As IList(Of Struct.StatsNumbers))

        Dim intLinha As Integer
        Dim oColCell As Cell
        Dim oColorLine As Color

        Try
            Me.Cursor = Cursors.WaitCursor

            For Each oItem As Struct.StatsNumbers In lTorch

                With grdStats

                    intLinha = .Rows.Count
                    .Rows.Insert(intLinha)
                    If oItem.Faixa Mod 2 = 0 Then
                        oColorLine = Color.AliceBlue
                    Else
                        oColorLine = Color.WhiteSmoke
                    End If

                    'col faixa 
                    oColCell = New Cell
                    ''oColCell.BackColor = oColorLine
                    ''oColCell.TextAlignment = ContentAlignment.MiddleCenter
                    'oColCell.Value = oItem.Faixa
                    .Item(intLinha, COLS.FAIXA_ID) = oColCell

                    'col faixa de 
                    oColCell = New Cell
                    ''oColCell.BackColor = oColorLine
                    ''oColCell.TextAlignment = ContentAlignment.MiddleCenter
                    'oColCell.Value = oItem.FaixaInicio
                    .Item(intLinha, COLS.FAIXA_DE) = oColCell

                    'col faixaate
                    oColCell = New Cell
                    ''oColCell.BackColor = oColorLine
                    ''oColCell.TextAlignment = ContentAlignment.MiddleCenter
                    'oColCell.Value = oItem.FaixaFinal
                    .Item(intLinha, COLS.FAIXA_ATE) = oColCell

                    'col faixa 
                    oColCell = New Cell
                    ''oColCell.BackColor = oColorLine
                    ''oColCell.TextAlignment = ContentAlignment.MiddleCenter
                    'oColCell.Value = oItem.Dezena
                    .Item(intLinha, COLS.DEZ_NUMERO) = oColCell

                    'col faixa 
                    oColCell = New Cell
                    ''oColCell.BackColor = oColorLine
                    ''oColCell.TextAlignment = ContentAlignment.MiddleCenter
                    'oColCell.Value = oItem.QuantidadeDezenas
                    .Item(intLinha, COLS.DEZ_QTDE) = oColCell

                    'col faixa 
                    oColCell = New Cell
                    ''oColCell.BackColor = oColorLine
                    ''oColCell.TextAlignment = ContentAlignment.MiddleCenter
                    'oColCell.Value = FormatNumber(oItem.PercentualDezena, 4)
                    .Item(intLinha, COLS.PERC_DEZENA) = oColCell

                    'col faixa 
                    oColCell = New Cell
                    ''oColCell.BackColor = oColorLine
                    ''oColCell.TextAlignment = ContentAlignment.MiddleCenter
                    'oColCell.Value = FormatNumber(oItem.PercentualDezenaTotal, 4)
                    .Item(intLinha, COLS.PERC_TOTAL) = oColCell


                    'col PERC_MEDIO_NORMAL
                    oColCell = New Cell
                    ''oColCell.BackColor = oColorLine
                    ''oColCell.TextAlignment = ContentAlignment.MiddleCenter
                    'oColCell.Value = FormatNumber(oItem.MediaFaixa, 4)
                    .Item(intLinha, COLS.PERC_MEDIO_NORMAL) = oColCell

                    'col PERC_MEDIO_NORMAL_ACIMA
                    oColCell = New Cell
                    ''oColCell.BackColor = oColorLine
                    If oItem.IsSuperiorFaixa = "S" Then
                        'oColCell.ForeColor = Color.Red
                    Else
                        'oColCell.ForeColor = Color.Black
                    End If

                    ''oColCell.TextAlignment = ContentAlignment.MiddleCenter
                    'oColCell.Value = oItem.IsSuperiorFaixa
                    .Item(intLinha, COLS.PERC_MEDIO_NORMAL_ACIMA) = oColCell

                    'col PERC_MEDIO_ARRED
                    oColCell = New Cell
                    ''oColCell.BackColor = oColorLine
                    ''oColCell.TextAlignment = ContentAlignment.MiddleCenter
                    'oColCell.Value = FormatNumber(oItem.MediaFaixaRound, 4)
                    .Item(intLinha, COLS.PERC_MEDIO_ARRED) = oColCell

                    'col PERC_MEDIO_ARRED_ACIMA
                    oColCell = New Cell
                    ''oColCell.BackColor = oColorLine
                    If oItem.IsSuperiorRound = "S" Then
                        'oColCell.ForeColor = Color.Red
                    Else
                        'oColCell.ForeColor = Color.Black
                    End If
                    ''oColCell.TextAlignment = ContentAlignment.MiddleCenter
                    'oColCell.Value = oItem.IsSuperiorRound
                    .Item(intLinha, COLS.PERC_MEDIO_ARRED_ACIMA) = oColCell

                End With
            Next
            oColCell = Nothing
            oColorLine = Nothing
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            oColCell = Nothing
            oColorLine = Nothing
            Me.Cursor = Cursors.Arrow
            ShowErro(ex, "Erro Ocorrido", Me.Name)
        End Try

    End Sub

    Sub ConfigGridDadosDezenas()

        Dim oColHeader As ColumnHeader
        Dim oColor As Color = Color.Gainsboro

        With grdOccurs
            .ColumnsCount = 49
            .FixedColumns = 1
            .FixedRows = 2
            .RowsCount = 0

            'tamanho das colunas.
            .Columns(CSTAT.DEZENA).Width = 40

            .Columns(CSTAT.TOP_ALL).Width = 60
            .Columns(CSTAT.TOTAL_ALL).Width = 60
            .Columns(CSTAT.CONCS_ALL).Width = 60
            .Columns(CSTAT.PC_REL_ALL).Width = 60
            .Columns(CSTAT.PC_TTL_ALL).Width = 60

            .Columns(CSTAT.TOP_IMP).Width = 60
            .Columns(CSTAT.TOTAL_IMP).Width = 60
            .Columns(CSTAT.CONCS_IMP).Width = 60
            .Columns(CSTAT.PC_REL_IMP).Width = 60
            .Columns(CSTAT.PC_TTL_IMP).Width = 60

            .Columns(CSTAT.TOP_2).Width = 60
            .Columns(CSTAT.TOTAL_2).Width = 60
            .Columns(CSTAT.CONCS_2).Width = 60
            .Columns(CSTAT.PC_REL_2).Width = 60
            .Columns(CSTAT.PC_TTL_2).Width = 60

            .Columns(CSTAT.TOP_3).Width = 60
            .Columns(CSTAT.TOTAL_3).Width = 60
            .Columns(CSTAT.CONCS_3).Width = 60
            .Columns(CSTAT.PC_REL_3).Width = 60
            .Columns(CSTAT.PC_TTL_3).Width = 60

            .Columns(CSTAT.TOP_4).Width = 60
            .Columns(CSTAT.TOTAL_4).Width = 60
            .Columns(CSTAT.CONCS_4).Width = 60
            .Columns(CSTAT.PC_REL_4).Width = 60
            .Columns(CSTAT.PC_TTL_4).Width = 60

            .Columns(CSTAT.TOP_5).Width = 60
            .Columns(CSTAT.TOTAL_5).Width = 60
            .Columns(CSTAT.CONCS_5).Width = 60
            .Columns(CSTAT.PC_REL_5).Width = 60
            .Columns(CSTAT.PC_TTL_5).Width = 60

            .Columns(CSTAT.TOP_6).Width = 60
            .Columns(CSTAT.TOTAL_6).Width = 60
            .Columns(CSTAT.CONCS_6).Width = 60
            .Columns(CSTAT.PC_REL_6).Width = 60
            .Columns(CSTAT.PC_TTL_6).Width = 60

            .Columns(CSTAT.TOP_7).Width = 60
            .Columns(CSTAT.TOTAL_7).Width = 60
            .Columns(CSTAT.CONCS_7).Width = 60
            .Columns(CSTAT.PC_REL_7).Width = 60
            .Columns(CSTAT.PC_TTL_7).Width = 60

            .Columns(CSTAT.TOP_8).Width = 60
            .Columns(CSTAT.TOTAL_8).Width = 60
            .Columns(CSTAT.CONCS_8).Width = 60
            .Columns(CSTAT.PC_REL_8).Width = 60
            .Columns(CSTAT.PC_TTL_8).Width = 60

            .Columns(CSTAT.TOP_9).Width = 60
            .Columns(CSTAT.TOTAL_9).Width = 60
            .Columns(CSTAT.CONCS_9).Width = 60
            .Columns(CSTAT.PC_REL_9).Width = 60
            .Columns(CSTAT.PC_TTL_9).Width = 60

            .Columns(CSTAT.TOP_10).Width = 60
            .Columns(CSTAT.TOTAL_10).Width = 60
            .Columns(CSTAT.CONCS_10).Width = 60
            .Columns(CSTAT.PC_REL_10).Width = 60
            .Columns(CSTAT.PC_TTL_10).Width = 60

            .Columns(CSTAT.TOP_11).Width = 60
            .Columns(CSTAT.TOTAL_11).Width = 60
            .Columns(CSTAT.CONCS_11).Width = 60
            .Columns(CSTAT.PC_REL_11).Width = 60
            .Columns(CSTAT.PC_TTL_11).Width = 60

            'inserindo as linhas
            .Rows.Insert(0)
            .Rows.Insert(1)

            'formatando grid
            oColHeader = New ColumnHeader("Dez.")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            oColHeader.RowSpan = 2
            .Item(0, CSTAT.DEZENA) = oColHeader

            'set de todas
            oColHeader = New ColumnHeader("Todos")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(0, CSTAT.TOP_ALL) = oColHeader

            oColHeader = New ColumnHeader("Total")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.TOTAL_ALL) = oColHeader

            oColHeader = New ColumnHeader("Concs")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.CONCS_ALL) = oColHeader

            oColHeader = New ColumnHeader("%Conc")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.PC_REL_ALL) = oColHeader

            oColHeader = New ColumnHeader("%Ttl")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.PC_TTL_ALL) = oColHeader

            'formatando colspan
            .Item(0, CSTAT.TOP_ALL).ColumnSpan = 4

            'set de impares
            oColHeader = New ColumnHeader("Impares")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(0, CSTAT.TOP_IMP) = oColHeader

            oColHeader = New ColumnHeader("Total")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.TOTAL_IMP) = oColHeader

            oColHeader = New ColumnHeader("Concs")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.CONCS_IMP) = oColHeader

            oColHeader = New ColumnHeader("%Conc")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.PC_REL_IMP) = oColHeader

            oColHeader = New ColumnHeader("%Ttl")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.PC_TTL_IMP) = oColHeader

            'formatando colspan
            .Item(0, CSTAT.TOP_IMP).ColumnSpan = 4

            'set de pares
            oColHeader = New ColumnHeader("Pares")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(0, CSTAT.TOP_2) = oColHeader

            oColHeader = New ColumnHeader("Total")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.TOTAL_2) = oColHeader

            oColHeader = New ColumnHeader("Concs")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.CONCS_2) = oColHeader

            oColHeader = New ColumnHeader("%Conc")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.PC_REL_2) = oColHeader

            oColHeader = New ColumnHeader("%Ttl")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.PC_TTL_2) = oColHeader

            'formatando colspan
            .Item(0, CSTAT.TOP_2).ColumnSpan = 4

            'set de 3
            oColHeader = New ColumnHeader("Top 3")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(0, CSTAT.TOP_3) = oColHeader

            oColHeader = New ColumnHeader("Total")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.TOTAL_3) = oColHeader

            oColHeader = New ColumnHeader("Concs")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.CONCS_3) = oColHeader

            oColHeader = New ColumnHeader("%Conc")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.PC_REL_3) = oColHeader

            oColHeader = New ColumnHeader("%Ttl")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.PC_TTL_3) = oColHeader

            'formatando colspan
            .Item(0, CSTAT.TOP_3).ColumnSpan = 4

            'set de 4
            oColHeader = New ColumnHeader("Top 4")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(0, CSTAT.TOP_4) = oColHeader

            oColHeader = New ColumnHeader("Total")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.TOTAL_4) = oColHeader

            oColHeader = New ColumnHeader("Concs")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.CONCS_4) = oColHeader

            oColHeader = New ColumnHeader("%Conc")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.PC_REL_4) = oColHeader

            oColHeader = New ColumnHeader("%Ttl")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.PC_TTL_4) = oColHeader

            'formatando colspan
            .Item(0, CSTAT.TOP_4).ColumnSpan = 4

            'set de 5
            oColHeader = New ColumnHeader("Top 5")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(0, CSTAT.TOP_5) = oColHeader

            oColHeader = New ColumnHeader("Total")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.TOTAL_5) = oColHeader

            oColHeader = New ColumnHeader("Concs")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.CONCS_5) = oColHeader

            oColHeader = New ColumnHeader("%Conc")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.PC_REL_5) = oColHeader

            oColHeader = New ColumnHeader("%Ttl")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.PC_TTL_5) = oColHeader

            'formatando colspan
            .Item(0, CSTAT.TOP_5).ColumnSpan = 4

            'set de 6
            oColHeader = New ColumnHeader("Top 6")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(0, CSTAT.TOP_6) = oColHeader

            oColHeader = New ColumnHeader("Total")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.TOTAL_6) = oColHeader

            oColHeader = New ColumnHeader("Concs")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.CONCS_6) = oColHeader

            oColHeader = New ColumnHeader("%Conc")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.PC_REL_6) = oColHeader

            oColHeader = New ColumnHeader("%Ttl")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.PC_TTL_6) = oColHeader

            'formatando colspan
            .Item(0, CSTAT.TOP_6).ColumnSpan = 4

            'set de 7
            oColHeader = New ColumnHeader("Top 7")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(0, CSTAT.TOP_7) = oColHeader

            oColHeader = New ColumnHeader("Total")
            ''oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            ''oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.TOTAL_7) = oColHeader

            oColHeader = New ColumnHeader("Concs")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.CONCS_7) = oColHeader

            oColHeader = New ColumnHeader("%Conc")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.PC_REL_7) = oColHeader

            oColHeader = New ColumnHeader("%Ttl")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.PC_TTL_7) = oColHeader

            'formatando colspan
            .Item(0, CSTAT.TOP_7).ColumnSpan = 4

            'set de 8
            oColHeader = New ColumnHeader("Top 8")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(0, CSTAT.TOP_8) = oColHeader

            oColHeader = New ColumnHeader("Total")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.TOTAL_8) = oColHeader

            oColHeader = New ColumnHeader("Concs")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.CONCS_8) = oColHeader

            oColHeader = New ColumnHeader("%Conc")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.PC_REL_8) = oColHeader

            oColHeader = New ColumnHeader("%Ttl")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.PC_TTL_8) = oColHeader

            'formatando colspan
            .Item(0, CSTAT.TOP_8).ColumnSpan = 4

            'set de 9
            oColHeader = New ColumnHeader("Top 9")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(0, CSTAT.TOP_9) = oColHeader

            oColHeader = New ColumnHeader("Total")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.TOTAL_9) = oColHeader

            oColHeader = New ColumnHeader("Concs")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.CONCS_9) = oColHeader

            oColHeader = New ColumnHeader("%Conc")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.PC_REL_9) = oColHeader

            oColHeader = New ColumnHeader("%Ttl")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.PC_TTL_9) = oColHeader

            'formatando colspan
            .Item(0, CSTAT.TOP_9).ColumnSpan = 4

            'set de 10
            oColHeader = New ColumnHeader("Top 10")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(0, CSTAT.TOP_10) = oColHeader

            oColHeader = New ColumnHeader("Total")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.TOTAL_10) = oColHeader

            oColHeader = New ColumnHeader("Concs")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.CONCS_10) = oColHeader

            oColHeader = New ColumnHeader("%Conc.")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.PC_REL_10) = oColHeader

            oColHeader = New ColumnHeader("%Ttl")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.PC_TTL_10) = oColHeader

            'formatando colspan
            .Item(0, CSTAT.TOP_10).ColumnSpan = 4

            'set de 11
            oColHeader = New ColumnHeader("Top 11")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(0, CSTAT.TOP_11) = oColHeader

            oColHeader = New ColumnHeader("Total")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.TOTAL_11) = oColHeader

            oColHeader = New ColumnHeader("Concs")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.CONCS_11) = oColHeader

            oColHeader = New ColumnHeader("%Conc")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.PC_REL_11) = oColHeader

            oColHeader = New ColumnHeader("%Ttl")
            'oColHeader.BackColor = oColor
            'oColHeader.EnableSort = False
            'oColHeader.TextAlignment = ContentAlignment.MiddleCenter
            .Item(1, CSTAT.PC_TTL_11) = oColHeader

            'formatando colspan
            .Item(0, CSTAT.TOP_11).ColumnSpan = 4

            oColHeader = Nothing

        End With
    End Sub

    Sub CarregaDadosDezenas()

        Dim oTorch As New Torchwood.Core.Data.Statics(Util.GetKey)
        Dim lstDezenas As IList(Of Struct.StatsData)
        Dim oLoteria As Struct.Loteria

        'Estatisticos
        Try
            Me.Cursor = Cursors.WaitCursor
            oLoteria = CType(ddlLoteria.SelectedItem, Struct.Loteria)

            lstDezenas = oTorch.GenerateStatsDataDezenas(oLoteria.Codigo)
            LoadGridDezenas(lstDezenas)

            oTorch = Nothing
            lstDezenas = Nothing
            oLoteria = Nothing

            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            oTorch = Nothing
            lstDezenas = Nothing
            oLoteria = Nothing
            Me.Cursor = Cursors.Arrow
            ShowErro(ex, "Erro Ocorrido", Me.Name)
        End Try

    End Sub

    Sub LoadGridDezenas(ByVal lstDezenas As List(Of Struct.StatsData))

        Dim intLinha As Integer
        Dim oColCell As Cell
        Dim oColorLine As Color

        For Each oDado As Struct.StatsData In lstDezenas

            With grdOccurs

                intLinha = .Rows.Count
                .Rows.Insert(intLinha)
                If intLinha Mod 2 = 0 Then
                    oColorLine = Color.White
                Else
                    oColorLine = Color.WhiteSmoke
                End If
                For intz As Integer = 0 To 48
                    .Item(intLinha, intz) = New Cell(intLinha.ToString + "," + intz.ToString)
                Next

                oColCell = New Cell
                'oColCell.BackColor = Color.Gainsboro
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.Dezena
                .Item(intLinha, CSTAT.DEZENA) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.ValorTodos.QuantidadeDezenas
                .Item(intLinha, CSTAT.TOTAL_ALL) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.ValorTodos.QuantidadeConcursos
                .Item(intLinha, CSTAT.CONCS_ALL) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = FormatNumber(oDado.ValorTodos.PercentualConcursos, 4)
                .Item(intLinha, CSTAT.PC_REL_ALL) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = FormatNumber(oDado.ValorTodos.PercentualTotal, 4)
                .Item(intLinha, CSTAT.PC_TTL_ALL) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.ValorImpares.QuantidadeDezenas
                .Item(intLinha, CSTAT.TOTAL_IMP) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.ValorImpares.QuantidadeConcursos
                .Item(intLinha, CSTAT.CONCS_IMP) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = FormatNumber(oDado.ValorImpares.PercentualConcursos, 4)
                .Item(intLinha, CSTAT.PC_REL_IMP) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = FormatNumber(oDado.ValorImpares.PercentualTotal, 4)
                .Item(intLinha, CSTAT.PC_TTL_IMP) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.ValorPares.QuantidadeDezenas
                .Item(intLinha, CSTAT.TOTAL_2) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.ValorPares.QuantidadeConcursos
                .Item(intLinha, CSTAT.CONCS_2) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = FormatNumber(oDado.ValorPares.PercentualConcursos, 4)
                .Item(intLinha, CSTAT.PC_REL_2) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = FormatNumber(oDado.ValorPares.PercentualTotal, 4)
                .Item(intLinha, CSTAT.PC_TTL_2) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.ValorTop3.QuantidadeDezenas
                .Item(intLinha, CSTAT.TOTAL_3) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.ValorTop3.QuantidadeConcursos
                .Item(intLinha, CSTAT.CONCS_3) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = FormatNumber(oDado.ValorTop3.PercentualConcursos, 4)
                .Item(intLinha, CSTAT.PC_REL_3) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = FormatNumber(oDado.ValorTop3.PercentualTotal, 4)
                .Item(intLinha, CSTAT.PC_TTL_3) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.ValorTop4.QuantidadeDezenas
                .Item(intLinha, CSTAT.TOTAL_4) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.ValorTop4.QuantidadeConcursos
                .Item(intLinha, CSTAT.CONCS_4) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = FormatNumber(oDado.ValorTop4.PercentualConcursos, 4)
                .Item(intLinha, CSTAT.PC_REL_4) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = FormatNumber(oDado.ValorTop4.PercentualTotal, 4)
                .Item(intLinha, CSTAT.PC_TTL_4) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.ValorTop5.QuantidadeDezenas
                .Item(intLinha, CSTAT.TOTAL_5) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.ValorTop5.QuantidadeConcursos
                .Item(intLinha, CSTAT.CONCS_5) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = FormatNumber(oDado.ValorTop5.PercentualConcursos, 4)
                .Item(intLinha, CSTAT.PC_REL_5) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = FormatNumber(oDado.ValorTop5.PercentualTotal, 4)
                .Item(intLinha, CSTAT.PC_TTL_5) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.ValorTop6.QuantidadeDezenas
                .Item(intLinha, CSTAT.TOTAL_6) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.ValorTop6.QuantidadeConcursos
                .Item(intLinha, CSTAT.CONCS_6) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = FormatNumber(oDado.ValorTop6.PercentualConcursos, 4)
                .Item(intLinha, CSTAT.PC_REL_6) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = FormatNumber(oDado.ValorTop6.PercentualTotal, 4)
                .Item(intLinha, CSTAT.PC_TTL_6) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.ValorTop7.QuantidadeDezenas
                .Item(intLinha, CSTAT.TOTAL_7) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.ValorTop7.QuantidadeConcursos
                .Item(intLinha, CSTAT.CONCS_7) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = FormatNumber(oDado.ValorTop7.PercentualConcursos, 4)
                .Item(intLinha, CSTAT.PC_REL_7) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = FormatNumber(oDado.ValorTop7.PercentualTotal, 4)
                .Item(intLinha, CSTAT.PC_TTL_7) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.ValorTop8.QuantidadeDezenas
                .Item(intLinha, CSTAT.TOTAL_8) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.ValorTop8.QuantidadeConcursos
                .Item(intLinha, CSTAT.CONCS_8) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = FormatNumber(oDado.ValorTop8.PercentualConcursos, 4)
                .Item(intLinha, CSTAT.PC_REL_8) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = FormatNumber(oDado.ValorTop8.PercentualTotal, 4)
                .Item(intLinha, CSTAT.PC_TTL_8) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.ValorTop9.QuantidadeDezenas
                .Item(intLinha, CSTAT.TOTAL_9) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.ValorTop9.QuantidadeConcursos
                .Item(intLinha, CSTAT.CONCS_9) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = FormatNumber(oDado.ValorTop9.PercentualConcursos, 4)
                .Item(intLinha, CSTAT.PC_REL_9) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = FormatNumber(oDado.ValorTop9.PercentualTotal, 4)
                .Item(intLinha, CSTAT.PC_TTL_9) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.ValorTop10.QuantidadeDezenas
                .Item(intLinha, CSTAT.TOTAL_10) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.ValorTop10.QuantidadeConcursos
                .Item(intLinha, CSTAT.CONCS_10) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = FormatNumber(oDado.ValorTop10.PercentualConcursos, 4)
                .Item(intLinha, CSTAT.PC_REL_10) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = FormatNumber(oDado.ValorTop10.PercentualTotal, 4)
                .Item(intLinha, CSTAT.PC_TTL_10) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.ValorTop11.QuantidadeDezenas
                .Item(intLinha, CSTAT.TOTAL_11) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = oDado.ValorTop11.QuantidadeConcursos
                .Item(intLinha, CSTAT.CONCS_11) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = FormatNumber(oDado.ValorTop11.PercentualConcursos, 4)
                .Item(intLinha, CSTAT.PC_REL_11) = oColCell

                oColCell = New Cell
                'oColCell.BackColor = oColorLine
                'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                'oColCell.Value = FormatNumber(oDado.ValorTop11.PercentualTotal, 4)
                .Item(intLinha, CSTAT.PC_TTL_11) = oColCell

            End With

        Next

    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


End Class