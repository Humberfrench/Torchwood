Imports System
Imports SourceGrid.Cells

Public Class frmPerformanceStatists

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

    Private Sub frmPerformanceStatists_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click

        'Dados da Faixa
        ConfigGridDadosFaixa()
        CarregaDadosFaixa()

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
                    oColCell.Value = oItem.Faixa
                    .Item(intLinha, COLS.FAIXA_ID) = oColCell

                    'col faixa de 
                    oColCell = New Cell
                    'oColCell.BackColor = oColorLine
                    'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                    oColCell.Value = oItem.FaixaInicio
                    .Item(intLinha, COLS.FAIXA_DE) = oColCell

                    'col faixaate
                    oColCell = New Cell
                    'oColCell.BackColor = oColorLine
                    'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                    oColCell.Value = oItem.FaixaFinal
                    .Item(intLinha, COLS.FAIXA_ATE) = oColCell

                    'col faixa 
                    oColCell = New Cell
                    'oColCell.BackColor = oColorLine
                    'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                    oColCell.Value = oItem.Dezena
                    .Item(intLinha, COLS.DEZ_NUMERO) = oColCell

                    'col faixa 
                    oColCell = New Cell
                    'oColCell.BackColor = oColorLine
                    'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                    oColCell.Value = oItem.QuantidadeDezenas
                    .Item(intLinha, COLS.DEZ_QTDE) = oColCell

                    'col faixa 
                    oColCell = New Cell
                    'oColCell.BackColor = oColorLine
                    'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                    oColCell.Value = FormatNumber(oItem.PercentualDezena, 4)
                    .Item(intLinha, COLS.PERC_DEZENA) = oColCell

                    'col faixa 
                    oColCell = New Cell
                    'oColCell.BackColor = oColorLine
                    'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                    oColCell.Value = FormatNumber(oItem.PercentualDezenaTotal, 4)
                    .Item(intLinha, COLS.PERC_TOTAL) = oColCell


                    'col PERC_MEDIO_NORMAL
                    oColCell = New Cell
                    'oColCell.BackColor = oColorLine
                    'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                    oColCell.Value = FormatNumber(oItem.MediaFaixa, 4)
                    .Item(intLinha, COLS.PERC_MEDIO_NORMAL) = oColCell

                    'col PERC_MEDIO_NORMAL_ACIMA
                    oColCell = New Cell
                    'oColCell.BackColor = oColorLine
                    If oItem.IsSuperiorFaixa = "S" Then
                        'oColCell.ForeColor = Color.Red
                    Else
                        'oColCell.ForeColor = Color.Black
                    End If

                    'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                    oColCell.Value = oItem.IsSuperiorFaixa
                    .Item(intLinha, COLS.PERC_MEDIO_NORMAL_ACIMA) = oColCell

                    'col PERC_MEDIO_ARRED
                    oColCell = New Cell
                    'oColCell.BackColor = oColorLine
                    'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                    oColCell.Value = FormatNumber(oItem.MediaFaixaRound, 4)
                    .Item(intLinha, COLS.PERC_MEDIO_ARRED) = oColCell

                    'col PERC_MEDIO_ARRED_ACIMA
                    oColCell = New Cell
                    'oColCell.BackColor = oColorLine
                    If oItem.IsSuperiorRound = "S" Then
                        'oColCell.ForeColor = Color.Red
                    Else
                        'oColCell.ForeColor = Color.Black
                    End If
                    'oColCell.TextAlignment = ContentAlignment.MiddleCenter
                    oColCell.Value = oItem.IsSuperiorRound
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


End Class