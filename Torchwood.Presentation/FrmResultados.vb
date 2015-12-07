Imports Torchwood
Imports Torchwood.Core.Data
Imports Torchwood.Struct
Imports System

Public Class FrmResultados

    Private Sub FrmResultados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        LoadCombo()
        Me.lvLoterias.Columns.Clear()

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

        oLoteria = ddlLoteria.SelectedItem
        If IsNothing(oLoteria) Then
            Exit Sub
        End If

        Me.txtDezSorteio.Text = oLoteria.QtdeDezenas.ToString()
        Me.txtDezTotais.Text = oLoteria.QtdeDezenasTotais.ToString()
        Me.txtDezInicial.Text = oLoteria.DezMinima.ToString()
        Me.txtDezFinal.Text = oLoteria.DezMaxima.ToString()
        Me.txtPremMin.Text = oLoteria.QtdeMinOccurs.ToString()
        Me.txtPremMax.Text = oLoteria.QtdeDezenas.ToString()

        If oLoteria.Status = "S" Then
            chkAtivo.Checked = True
        Else
            chkAtivo.Checked = False
        End If

        ObterGrid(oLoteria)
        Select Case oLoteria.Codigo
            Case 1
                CarregaDadosMegaSena()
            Case 2
                'CarregaDadosSena()
            Case 3
                'CarregaDadosSena()
            Case 4
                CarregaDadosLotoMania()
            Case 5
                CarregaDadosLotoFacil()
            Case 6
                CarregaDadosQuina()
            Case 7, 8
                CarregaDadosTimeMania()
            Case Else
                'erro
        End Select

    End Sub

    Sub ObterGrid(ByVal oLoteria As Struct.Loteria)

        Dim oColum As ColumnHeader

        Me.lvLoterias.Columns.Clear()
        Me.lvLoterias.Scrollable = False

        'primeira coluna
        oColum = New ColumnHeader()
        oColum.Text = "Concurso"
        oColum.Width = 75
        Me.lvLoterias.Columns.Add(oColum)

        'primeira coluna
        oColum = New ColumnHeader()
        oColum.Text = "Data"
        oColum.Width = 100
        Me.lvLoterias.Columns.Add(oColum)

        If oLoteria.Codigo = 7 Or oLoteria.Codigo = 8 Then 'timemania times
            'coluna times
            oColum = New ColumnHeader()
            oColum.Text = "Time"
            oColum.Width = 100
            Me.lvLoterias.Columns.Add(oColum)
        End If

        For intCont As Integer = 1 To oLoteria.QtdeDezenas
            'Coluna de Dezenas
            oColum = New ColumnHeader()
            oColum.Text = "D" + intCont.ToString("0#")
            oColum.Width = 50
            Me.lvLoterias.Columns.Add(oColum)
        Next
        Me.lvLoterias.Scrollable = True
        Me.lvLoterias.Update()
        oColum = Nothing

    End Sub

    Sub CarregaDadosMegaSena()

        Dim oDados As Resultados
        Dim lstDados As List(Of MegaSena)
        Dim itnDados As ListViewItem

        Try

            oDados = New Resultados
            lstDados = oDados.GetMegaSenaResults()

            For Each oItem As MegaSena In lstDados
                itnDados = New ListViewItem
                itnDados.Text = oItem.Concurso
                itnDados.SubItems.Add(oItem.Data)
                itnDados.SubItems.Add(oItem.Dezena01)
                itnDados.SubItems.Add(oItem.Dezena02)
                itnDados.SubItems.Add(oItem.Dezena03)
                itnDados.SubItems.Add(oItem.Dezena04)
                itnDados.SubItems.Add(oItem.Dezena05)
                itnDados.SubItems.Add(oItem.Dezena06)
                lvLoterias.Items.Add(itnDados)
            Next

            lstDados = Nothing
            itnDados = Nothing

        Catch ex As Exception
            lstDados = Nothing
            itnDados = Nothing
            ShowErro(ex, "Erro Carregando Dados de Resultados", Me.Name)
        End Try

    End Sub

    Sub CarregaDadosDuplaSenaS1()

        Dim oDados As Resultados
        Dim lstDados As List(Of DuplaSena)
        Dim itnDados As ListViewItem

        Try

            oDados = New Resultados
            lstDados = oDados.GetDuplaSenaS1Results()

            For Each oItem As DuplaSena In lstDados
                itnDados = New ListViewItem
                itnDados.Text = oItem.Concurso
                itnDados.SubItems.Add(oItem.Data)
                itnDados.SubItems.Add(oItem.Dezena01)
                itnDados.SubItems.Add(oItem.Dezena02)
                itnDados.SubItems.Add(oItem.Dezena03)
                itnDados.SubItems.Add(oItem.Dezena04)
                itnDados.SubItems.Add(oItem.Dezena05)
                itnDados.SubItems.Add(oItem.Dezena06)
                lvLoterias.Items.Add(itnDados)
            Next

            lstDados = Nothing
            itnDados = Nothing

        Catch ex As Exception
            lstDados = Nothing
            itnDados = Nothing
            ShowErro(ex, "Erro Carregando Dados de Resultados", Me.Name)
        End Try

    End Sub

    Sub CarregaDadosDuplaSenaS2()

        Dim oDados As Resultados
        Dim lstDados As List(Of DuplaSena)
        Dim itnDados As ListViewItem

        Try

            oDados = New Resultados
            lstDados = oDados.GetDuplaSenaS1Results()

            For Each oItem As DuplaSena In lstDados
                itnDados = New ListViewItem
                itnDados.Text = oItem.Concurso
                itnDados.SubItems.Add(oItem.Data)
                itnDados.SubItems.Add(oItem.Dezena01)
                itnDados.SubItems.Add(oItem.Dezena02)
                itnDados.SubItems.Add(oItem.Dezena03)
                itnDados.SubItems.Add(oItem.Dezena04)
                itnDados.SubItems.Add(oItem.Dezena05)
                itnDados.SubItems.Add(oItem.Dezena06)
                lvLoterias.Items.Add(itnDados)
            Next

            lstDados = Nothing
            itnDados = Nothing

        Catch ex As Exception
            lstDados = Nothing
            itnDados = Nothing
            ShowErro(ex, "Erro Carregando Dados de Resultados", Me.Name)
        End Try

    End Sub

    Sub CarregaDadosQuina()

        Dim oDados As Resultados
        Dim lstDados As List(Of Quina)
        Dim itnDados As ListViewItem

        Try

            oDados = New Resultados
            lstDados = oDados.GetQuinaResults()

            For Each oItem As Quina In lstDados
                itnDados = New ListViewItem
                itnDados.Text = oItem.Concurso
                itnDados.SubItems.Add(oItem.Data)
                itnDados.SubItems.Add(oItem.Dezena01)
                itnDados.SubItems.Add(oItem.Dezena02)
                itnDados.SubItems.Add(oItem.Dezena03)
                itnDados.SubItems.Add(oItem.Dezena04)
                itnDados.SubItems.Add(oItem.Dezena05)
                lvLoterias.Items.Add(itnDados)
            Next

            lstDados = Nothing
            itnDados = Nothing

        Catch ex As Exception
            lstDados = Nothing
            itnDados = Nothing
            ShowErro(ex, "Erro Carregando Dados de Resultados", Me.Name)
        End Try

    End Sub

    Sub CarregaDadosLotoFacil()

        Dim oDados As Resultados
        Dim lstDados As List(Of LotoFacil)
        Dim itnDados As ListViewItem

        Try

            oDados = New Resultados
            lstDados = oDados.GetLotoFacilResults()

            For Each oItem As LotoFacil In lstDados
                itnDados = New ListViewItem
                itnDados.Text = oItem.Concurso
                itnDados.SubItems.Add(oItem.Data)
                itnDados.SubItems.Add(oItem.Dezena01)
                itnDados.SubItems.Add(oItem.Dezena02)
                itnDados.SubItems.Add(oItem.Dezena03)
                itnDados.SubItems.Add(oItem.Dezena04)
                itnDados.SubItems.Add(oItem.Dezena05)
                itnDados.SubItems.Add(oItem.Dezena06)
                itnDados.SubItems.Add(oItem.Dezena07)
                itnDados.SubItems.Add(oItem.Dezena08)
                itnDados.SubItems.Add(oItem.Dezena09)
                itnDados.SubItems.Add(oItem.Dezena10)
                itnDados.SubItems.Add(oItem.Dezena11)
                itnDados.SubItems.Add(oItem.Dezena12)
                itnDados.SubItems.Add(oItem.Dezena13)
                itnDados.SubItems.Add(oItem.Dezena14)
                itnDados.SubItems.Add(oItem.Dezena15)
                lvLoterias.Items.Add(itnDados)
            Next

            lstDados = Nothing
            itnDados = Nothing

        Catch ex As Exception '
            lstDados = Nothing
            itnDados = Nothing
            ShowErro(ex, "Erro Carregando Dados de Resultados", Me.Name)
        End Try

    End Sub

    Sub CarregaDadosLotoMania()

        Dim oDados As Resultados
        Dim lstDados As List(Of LotoMania)
        Dim itnDados As ListViewItem

        Try

            oDados = New Resultados
            lstDados = oDados.GetLotoManiaResults()

            For Each oItem As LotoMania In lstDados
                itnDados = New ListViewItem
                itnDados.Text = oItem.Concurso
                itnDados.SubItems.Add(oItem.Data)
                itnDados.SubItems.Add(oItem.Dezena01)
                itnDados.SubItems.Add(oItem.Dezena02)
                itnDados.SubItems.Add(oItem.Dezena03)
                itnDados.SubItems.Add(oItem.Dezena04)
                itnDados.SubItems.Add(oItem.Dezena05)
                itnDados.SubItems.Add(oItem.Dezena06)
                itnDados.SubItems.Add(oItem.Dezena07)
                itnDados.SubItems.Add(oItem.Dezena08)
                itnDados.SubItems.Add(oItem.Dezena09)
                itnDados.SubItems.Add(oItem.Dezena10)
                itnDados.SubItems.Add(oItem.Dezena11)
                itnDados.SubItems.Add(oItem.Dezena12)
                itnDados.SubItems.Add(oItem.Dezena13)
                itnDados.SubItems.Add(oItem.Dezena14)
                itnDados.SubItems.Add(oItem.Dezena15)
                itnDados.SubItems.Add(oItem.Dezena16)
                itnDados.SubItems.Add(oItem.Dezena17)
                itnDados.SubItems.Add(oItem.Dezena18)
                itnDados.SubItems.Add(oItem.Dezena19)
                itnDados.SubItems.Add(oItem.Dezena20)
                lvLoterias.Items.Add(itnDados)
            Next

            lstDados = Nothing
            itnDados = Nothing

        Catch ex As Exception '
            lstDados = Nothing
            itnDados = Nothing
            ShowErro(ex, "Erro Carregando Dados de Resultados", Me.Name)
        End Try

    End Sub

    Sub CarregaDadosTimeMania()

        Dim oDados As Resultados
        Dim lstDados As List(Of Struct.TimeMania)
        Dim itnDados As ListViewItem

        Try

            oDados = New Resultados
            lstDados = oDados.GetTimeManiaResults()

            For Each oItem As Struct.TimeMania In lstDados
                itnDados = New ListViewItem
                itnDados.Text = oItem.Concurso
                itnDados.SubItems.Add(oItem.Data)
                itnDados.SubItems.Add(oItem.Time.Time + "-" + oItem.Time.UFTime)
                itnDados.SubItems.Add(oItem.Dezena01)
                itnDados.SubItems.Add(oItem.Dezena02)
                itnDados.SubItems.Add(oItem.Dezena03)
                itnDados.SubItems.Add(oItem.Dezena04)
                itnDados.SubItems.Add(oItem.Dezena05)
                itnDados.SubItems.Add(oItem.Dezena06)
                itnDados.SubItems.Add(oItem.Dezena07)
                lvLoterias.Items.Add(itnDados)
            Next

            lstDados = Nothing
            itnDados = Nothing

        Catch ex As Exception
            lstDados = Nothing
            itnDados = Nothing
            ShowErro(ex, "Erro Carregando Dados de Resultados", Me.Name)
        End Try

    End Sub

    Private Sub btnFechar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

End Class
