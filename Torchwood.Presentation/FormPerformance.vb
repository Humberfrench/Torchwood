Imports System
Imports Torchwood.Struct

Public Class FormPerformance
    Private ListaStatsTorch As IList(Of Struct.StatsNumbers)

    Private Sub FormPerformance_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ListaStatsTorch = New List(Of Struct.StatsNumbers)
        LoadCombo()
    End Sub

    Sub LoadCombo()

        Dim oTorch As New Torchwood.Core.Data.Loterias(Util.GetKey)
        Dim lTorch As IList(Of Struct.Loteria)

        lTorch = oTorch.List()
        For Each oLoteria As Struct.Loteria In lTorch
            ddlLoteria.Items.Add(oLoteria)
        Next
        ddlLoteria.SelectedIndex = 0
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As System.EventArgs) Handles btnPesquisar.Click

        Dim oTorch As New Torchwood.Core.Data.Statics(Util.GetKey)
        Dim lTorch As IList(Of Struct.StatsNumbers)
        Dim oLoteria As Struct.Loteria

        'Estatisticos
        Try
            Me.Cursor = Cursors.WaitCursor
            oLoteria = CType(ddlLoteria.SelectedItem, Struct.Loteria)

            lTorch = oTorch.GenerateStatsData(oLoteria.Codigo, _
                                              Convert.ToInt16(txtQtdeFaixas.Text))
            ListaStatsTorch = lTorch

            If ListaStatsTorch.Count > 0 Then
                CarregaCombo()
            End If

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

    Sub CarregaCombo()

        Dim iPesq = From oDado In ListaStatsTorch
                    Select oDado.Faixa, oDado.DescFaixa Distinct

        Dim iList = iPesq.ToList()
        Dim oBasicObject As Struct.BasicObject

        ddlFaixa.Items.Clear()

        For Each oDado In iList
            oBasicObject = New BasicObject()
            oBasicObject.Codigo = oDado.Faixa
            oBasicObject.Descricao = oDado.DescFaixa
            ddlFaixa.Items.Add(oBasicObject)
        Next
        ddlFaixa.SelectedIndex = 0
        oBasicObject = Nothing
        iPesq = Nothing
        iList = Nothing

    End Sub
    Sub CarregaGrid(intFaixa As Integer)

        Dim iPesq = From oDado In ListaStatsTorch
                    Where oDado.Faixa = intFaixa
                    Select oDado

        Dim iList = iPesq.ToList()
        Dim lvItem As ListViewItem = Nothing

        lvLoterias.Items.Clear()
        For Each oDado As StatsNumbers In iList
            lvItem = New ListViewItem(oDado.FaixaInicio)
            lvItem.SubItems.Add(oDado.FaixaFinal) '1
            lvItem.SubItems.Add(oDado.Dezena) '2
            lvItem.SubItems.Add(oDado.QuantidadeDezenas) '3
            lvItem.SubItems.Add(oDado.PercentualDezena.ToString("F2")) '4
            lvItem.SubItems.Add(oDado.PercentualDezenaTotal.ToString("F2")) '5
            lvItem.SubItems.Add(oDado.MediaAritimetica.ToString("F2")) '6
            lvItem.SubItems.Add(oDado.TotalConcursos) '7
            lvItem.SubItems.Add(oDado.TotalDezenas) '8
            lvItem.SubItems.Add(oDado.MediaFaixa.ToString("F2")) '9
            lvItem.SubItems.Add(oDado.MediaFaixaRound.ToString("F2")) '10
            lvItem.SubItems.Add(oDado.IsSuperiorFaixa) '11
            lvItem.SubItems.Add(oDado.IsSuperiorRound) '12
            lvItem.SubItems.Add(oDado.QuantidadeDezenaSuperiorFaixa) '13
            lvItem.SubItems.Add(oDado.QuantidadeDezenaSuperiorRound) '14
            If oDado.IsSuperiorFaixa = "S" Then
                lvItem.ForeColor = Color.White
                lvItem.BackColor = Color.Red
            Else
                lvItem.ForeColor = Color.MidnightBlue
            End If
            lvLoterias.Items.Add(lvItem)
        Next

    End Sub

    Private Sub ddlFaixa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlFaixa.SelectedIndexChanged
        If ddlFaixa.Text <> "" Then
            Dim oDado = CType(ddlFaixa.SelectedItem, Struct.BasicObject)
            CarregaGrid(CInt(oDado.Codigo))
            oDado = Nothing
        End If
    End Sub
End Class