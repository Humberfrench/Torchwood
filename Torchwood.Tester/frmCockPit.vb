Public Class frmCockPit

    Private Sub frmCockPit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadCombo()
    End Sub
    Sub LoadCombo()

        Dim oTorch As New Torchwood.Core.Data.GenericQueries(Util.GetKey)
        Dim lTorch As IList(Of Struct.Loteria)

        lTorch = oTorch.ListaLoterias()
        For Each oLoteria As Struct.Loteria In lTorch
            ddlLoteria.Items.Add(oLoteria)
        Next

    End Sub

    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click

        Dim oTorch As New Torchwood.Core.Data.Statics(Util.GetKey)
        Dim lTorch As IList(Of Struct.StatsNumbers)
        Dim oItemView As ListViewItem
        Dim oLoteria As Struct.Loteria

        'Estatisticos
        Try
            Me.Cursor = Cursors.WaitCursor
            oLoteria = CType(ddlLoteria.SelectedItem, Struct.Loteria)

            lTorch = oTorch.GenerateStatsData(oLoteria.Codigo, _
                                              Convert.ToInt16(txtFaixas.Text), _
                                              False)

            For Each oItem As Struct.StatsNumbers In lTorch
                oItemView = New ListViewItem
                oItemView.Text = oItem.GuidValue.ToString()
                oItemView.SubItems.Add(oItem.Faixa.ToString())
                oItemView.SubItems.Add(oItem.DescFaixa.ToString())
                oItemView.SubItems.Add(oItem.FaixaInicio.ToString())
                oItemView.SubItems.Add(oItem.FaixaFinal.ToString())
                oItemView.SubItems.Add(oItem.Dezena.ToString())
                oItemView.SubItems.Add(oItem.QuantidadeDezenas.ToString())
                oItemView.SubItems.Add(FormatNumber(oItem.PercentualDezena.ToString(), 2))
                oItemView.SubItems.Add(oItem.TotalConcursos.ToString())
                oItemView.SubItems.Add(oItem.TotalDezenas.ToString())
                oItemView.SubItems.Add(FormatNumber(oItem.PercentualDezenaTotal.ToString(), 2))
                oItemView.SubItems.Add(oItem.MediaAritimetica.ToString())
                oItemView.SubItems.Add(oItem.MediaFaixa.ToString())
                oItemView.SubItems.Add(oItem.IsSuperiorFaixa.ToString())
                oItemView.SubItems.Add(oItem.QuantidadeDezenaSuperiorFaixa.ToString())
                oItemView.SubItems.Add(oItem.MediaFaixaRound.ToString())
                oItemView.SubItems.Add(oItem.IsSuperiorRound.ToString())
                oItemView.SubItems.Add(oItem.QuantidadeDezenaSuperiorRound.ToString())
                lvStats.Items.Add(oItemView)
            Next
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString(), "Erro Ocorrido", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class