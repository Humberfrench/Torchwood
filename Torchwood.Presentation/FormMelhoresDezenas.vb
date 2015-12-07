Imports System

Public Class FormMelhoresDezenas

    Private Sub FormMelhoresDezenas_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load

        Me.ddlTipo.Items.Add(New Consumer.Structs.ItemData(0, "Concursos Normais"))
        Me.ddlTipo.Items.Add(New Consumer.Structs.ItemData(2, "Concursos Pares"))
        Me.ddlTipo.Items.Add(New Consumer.Structs.ItemData(1, "Concursos Impares"))
        Me.ddlTipo.Items.Add(New Consumer.Structs.ItemData(3, "Concursos Multiplos de Três"))
        Me.ddlTipo.Items.Add(New Consumer.Structs.ItemData(4, "Concursos Multiplos de Quatro"))
        Me.ddlTipo.Items.Add(New Consumer.Structs.ItemData(5, "Concursos Multiplos de Cinco"))
        Me.ddlTipo.Items.Add(New Consumer.Structs.ItemData(6, "Concursos Multiplos de Seis"))
        Me.ddlTipo.Items.Add(New Consumer.Structs.ItemData(7, "Concursos Multiplos de Sete"))
        Me.ddlTipo.Items.Add(New Consumer.Structs.ItemData(8, "Concursos Multiplos de Oito"))
        Me.ddlTipo.Items.Add(New Consumer.Structs.ItemData(9, "Concursos Multiplos de Nove"))
        Me.ddlTipo.Items.Add(New Consumer.Structs.ItemData(10, "Concursos Multiplos de Dez"))
        Me.ddlTipo.Items.Add(New Consumer.Structs.ItemData(15, "Concursos Multiplos de Quinze"))
        Me.ddlTipo.Items.Add(New Consumer.Structs.ItemData(20, "Concursos Multiplos de Vinte"))
        Me.ddlTipo.Items.Add(New Consumer.Structs.ItemData(25, "Concursos Multiplos de Vinte e Cinco"))

        LoadCombo()

    End Sub

    Sub LoadCombo()
        Dim oLoterias As Core.Data.Loterias
        Dim lLoterias As List(Of Struct.Loteria)

        oLoterias = New Core.Data.Loterias(GetKey())
        lLoterias = oLoterias.List

        For Each oItem As Struct.Loteria In lLoterias
            Me.ddlLoteria.Items.Add(oItem)
        Next

        oLoterias = Nothing
        lLoterias = Nothing

    End Sub

    Private Sub btnPesquisar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click

        Dim oLoteria As Struct.Loteria
        Dim oItem As Consumer.Structs.ItemData
        Dim lstResult As List(Of Struct.BestDezenas) = Nothing
        Dim oTorch As Core.Statistics.GameStats
        Dim oItemGrid As ListViewItem = Nothing
        Dim intCont As Integer = 0

        Try

            oLoteria = ddlLoteria.SelectedItem
            If IsNothing(oLoteria) Then
                Exit Sub
            End If

            picLoteria.ImageLocation = oLoteria.Codigo.ToString + ".gif"

            Me.txtDezSorteio.Text = oLoteria.QtdeDezenas.ToString()
            Me.txtDezTotais.Text = oLoteria.QtdeDezenasTotais.ToString()
            Me.txtDezInicial.Text = oLoteria.DezMinima.ToString()
            Me.txtDezFinal.Text = oLoteria.DezMaxima.ToString()
            Me.txtPremMin.Text = oLoteria.QtdeMinOccurs.ToString()
            Me.txtPremMax.Text = oLoteria.QtdeDezenas.ToString()

            If oLoteria.Status = "A" Then
                chkAtivo.Checked = True
            Else
                chkAtivo.Checked = False
            End If

            oItem = ddlTipo.SelectedItem
            If IsNothing(oItem) Then
                oItem = New Consumer.Structs.ItemData(0, "")
            End If

            oTorch = New Core.Statistics.GameStats(GetKey())
            oTorch.Loteria = oLoteria.Codigo
            Select Case oItem.Value
                Case 0
                    lstResult = oTorch.GetBestDezenas
                Case 1
                    lstResult = oTorch.GetBestDezenasTopImpar
                Case Else
                    lstResult = oTorch.GetBestDezenasTop(oItem.Value)
            End Select

            'carregando o grid
            Me.lvLoterias.Items.Clear()
            For Each oDado As Struct.BestDezenas In lstResult
                oItemGrid = New ListViewItem
                intCont = intCont + 1
                oItemGrid.Text = intCont
                oItemGrid.SubItems.Add(oDado.Dezena)
                oItemGrid.SubItems.Add(oDado.QuantidadeDezena.ToString())
                oItemGrid.SubItems.Add(oDado.PercentualDezena.ToString())
                oItemGrid.SubItems.Add(oDado.PercentualDezenaTotal.ToString())
                Me.lvLoterias.Items.Add(oItemGrid)
            Next

            If lstResult.Count > 0 Then
                Me.txtTotalConcursos.Text = lstResult.Item(0).NumeroConcursos.ToString()
                Me.txtTotalDezenas.Text = lstResult.Item(0).TotalDezenas.ToString()
            End If

            oLoteria = Nothing
            oItem = Nothing
            lstResult = Nothing
            oTorch = Nothing
            oItemGrid = Nothing

        Catch ex As Exception
            oLoteria = Nothing
            oItem = Nothing
            lstResult = Nothing
            oTorch = Nothing
            oItemGrid = Nothing
            MessageBox.Show("Ocorreu o seguinte Erro:" + vbNewLine + ex.Message.ToString(), _
                            "Erro Ocorrido", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click

        Me.Close()

    End Sub

End Class

