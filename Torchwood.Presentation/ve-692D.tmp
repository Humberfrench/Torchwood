Imports System
Imports System.Text

Public Class frmSetPesquisaHistorico

    Private Sub frmCenarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        LoadLoterias()
        LoadSets()
        Limpar()

    End Sub

    Sub LoadLoterias()

        Dim oLoterias As Core.Data.Loterias = Nothing
        Dim lLoterias As List(Of Struct.Loteria) = Nothing

        oLoterias = New Core.Data.Loterias(GetKey())
        lLoterias = oLoterias.ListAll

        For Each oItem As Struct.Loteria In lLoterias
            Me.ddlLoteria.Items.Add(oItem)
        Next

        oLoterias = Nothing
        lLoterias = Nothing

    End Sub

    Sub LoadSets()

        Dim oSet As Core.Data.SetPesquisas = Nothing
        Dim lstSet As List(Of Struct.SetPesquisa) = Nothing
        Dim oItem As ListViewItem = Nothing

        oSet = New Core.Data.SetPesquisas(GetKey())
        oSet.LoadAll = False
        lstSet = oSet.List

        'limpando o combo
        ddlSetDados.Items.Clear()
        lvSets.Items.Clear()
        For Each iSet As Struct.SetPesquisa In lstSet
            oItem = New ListViewItem
            oItem.Text = iSet.Codigo.ToString()
            oItem.SubItems.Add(iSet.DataConsulta.ToShortDateString())
            oItem.SubItems.Add(iSet.Nome)
            oItem.SubItems.Add(iSet.NomeLoteria)
            oItem.SubItems.Add(iSet.Dezenas.Count.ToString())
            lvSets.Items.Add(oItem)
            ddlSetDados.Items.Add(iSet)
        Next

        oItem = Nothing
        lstSet = Nothing
        oSet = Nothing

    End Sub

    Private Sub lvSets_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvSets.Click

        Dim oLoteria As Struct.Loteria = Nothing
        Dim oTorch As Core.Data.SetPesquisas = Nothing
        Dim lDezenas As List(Of Integer) = Nothing

        Me.txtCodigo.Text = lvSets.SelectedItems(0).SubItems(0).Text
        Me.txtData.Text = lvSets.SelectedItems(0).SubItems(1).Text
        Me.txtDescricao.Text = lvSets.SelectedItems(0).SubItems(2).Text
        Me.btnExcluir.Enabled = True

        'falta obter as dezenas
        oTorch = New Core.Data.SetPesquisas(GetKey())
        oTorch.Item.Codigo = CInt(Me.txtCodigo.Text)
        lDezenas = oTorch.GetDezenas

        lstDezenas.DataSource = lDezenas

        'combo cliente
        For intCont As Integer = 0 To Me.ddlLoteria.Items.Count - 1
            ddlLoteria.SelectedIndex = intCont
            oLoteria = CType(ddlLoteria.Items.Item(intCont), Struct.Loteria)
            If oLoteria.Descricao = lvSets.SelectedItems(0).SubItems(3).Text Then
                Exit For
            End If
        Next

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim intDezMin As Short = 0
        Dim intDezMax As Short = 0
        Dim oLoteria As Struct.Loteria = Nothing

        If Me.ddlLoteria.SelectedIndex > -1 Then
            oLoteria = Me.ddlLoteria.SelectedItem
        Else
            Me.ddlLoteria.Focus()
            ShowErro("Antes de Adicionar as dezenas é necessário selecionar a Loteria", "Dezena Inconsistente", Me.Name)
            Exit Sub
        End If

        If IsNumeric(Me.txtDezena.Text) Then
            'verificar as dezenas se já existem?:
            For intCont As Integer = 0 To lstDezenas.Items.Count - 1
                If Me.lstDezenas.Items(intCont).ToString() = Me.txtDezena.Text Then
                    ShowErro("Dezena já existente na Lista", "Dezena Repetida", Me.Name)
                    Exit Sub
                End If
            Next
            lstDezenas.Items.Add(Me.txtDezena.Text)
            txtQtdeDezenas.Text = lstDezenas.Items.Count.ToString()
        Else
            ShowErro("Adicione uma dezena válida", "Dezena Inconsistente", Me.Name)
            Exit Sub
        End If

    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click

        If lstDezenas.SelectedIndex > -1 Then
            lstDezenas.Items.RemoveAt(lstDezenas.SelectedIndex)
            txtQtdeDezenas.Text = lstDezenas.Items.Count.ToString()
        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If MessageBox.Show("Deseja Limpar a lista de Dezenas?", _
                           "Torchwood", _
                           MessageBoxButtons.YesNo, _
                           MessageBoxIcon.Question, _
                           MessageBoxDefaultButton.Button2, _
                           MessageBoxOptions.DefaultDesktopOnly) Then
            lstDezenas.Items.Clear()
            txtQtdeDezenas.Text = lstDezenas.Items.Count.ToString()
        End If
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        Limpar()
    End Sub

    Sub Limpar()

        Me.lstDezenas.Items.Clear()
        Me.txtDezena.Text = ""
        Me.txtDescricao.Text = ""
        Me.ddlLoteria.SelectedIndex = -1
        Me.txtCodigo.Text = ""
        Me.btnExcluir.Enabled = False

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        If Me.txtCodigo.Text = "" Or Me.txtCodigo.Text = "0" Then
            ShowErro("Não existe registros para serem excluidos", "Inconsistencia nos Registros", Me.Name)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim oTorch As Core.Data.SetPesquisas = Nothing

        Try
            oTorch = New Core.Data.SetPesquisas(GetKey())
            oTorch.Item.Codigo = CInt(txtCodigo.Text)
            oTorch.Del()
        Catch ex As Exception
            oTorch = Nothing
            Me.Cursor = Cursors.Arrow
            ShowErro(ex, "Excluindo Dados do Set", Me.Name)
        End Try
        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub btnGravaLoteria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGravaLoteria.Click
        'Efetua a gravação dos dados

        Dim oSetPesquisa As Core.Data.SetPesquisas = Nothing
        Dim oDezenas As List(Of Integer) = Nothing
        Dim intCodigo As Integer
        Dim oLoteria As Struct.Loteria
        Dim strMensagem As StringBuilder = Nothing

        Me.Cursor = Cursors.WaitCursor

        'consistir dados
        strMensagem = New StringBuilder
        'descrição
        If Me.txtDescricao.Text = "" Then
            strMensagem.Append("- Preencher o Campo de Descrição" + vbNewLine)
        End If
        'combo de loteria
        If Me.ddlLoteria.SelectedIndex = -1 Then
            strMensagem.Append("- Preencher o Campo de Loteria" + vbNewLine)
        End If
        'dezenas inseridas
        If Me.lstDezenas.Items.Count = 0 Then
            strMensagem.Append("- Inserir dezenas no Set" + vbNewLine)
        End If

        If strMensagem.Length > 0 Then
            Me.Cursor = Cursors.Arrow
            ShowErro(strMensagem.ToString(), "Inconsistências", Me.Name)
            Exit Sub
        End If

        Try
            oLoteria = CType(Me.ddlLoteria.SelectedItem, Struct.Loteria)
            If Me.txtCodigo.Text = "" Then
                intCodigo = 0
            Else
                intCodigo = CInt(Me.txtCodigo.Text)
            End If

            oDezenas = New List(Of Integer)
            For Each oItem As Integer In lstDezenas.Items
                oDezenas.Add(oItem)
            Next

            oSetPesquisa = New Core.Data.SetPesquisas(GetKey, _
                                                      intCodigo, _
                                                      oLoteria.Codigo, _
                                                      Me.txtDescricao.Text, _
                                                      New DateTime(), _
                                                      oDezenas)
            If intCodigo = 0 Then
                intCodigo = oSetPesquisa.Add()
                Me.txtCodigo.Text = intCodigo.ToString()
            Else
                oSetPesquisa.Update()
            End If
            'recarregando os grids
            LoadSets()
            Limpar()

            oSetPesquisa = Nothing
            oDezenas = Nothing
        Catch ex As Exception
            oDezenas = Nothing
            oSetPesquisa = Nothing
            Me.Cursor = Cursors.Arrow
            ShowErro(ex, "Gravando Dados do Set", Me.Name)
        End Try

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click, btnFechar2.Click
        Me.Close()
    End Sub

    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click

        Dim intConcursoInicial As Integer = Nothing
        Dim intConcursoFinal As Integer = Nothing
        Dim oSetPesquisa As Core.Data.SetPesquisas = Nothing
        Dim oItem As Struct.SetPesquisa = Nothing
        Dim lstPesquisa As List(Of Struct.SetResults) = Nothing
        Dim lDezenas As List(Of Integer) = Nothing
        Dim lItem As ListViewItem = Nothing

        Me.Cursor = Cursors.WaitCursor
        If Me.txtConcursoInicial.Text = "" Then
            Me.txtConcursoInicial.Text = "0"
            intConcursoInicial = 0
        Else
            intConcursoInicial = CInt(Me.txtConcursoInicial.Text)
        End If

        If Me.txtConcursoFinal.Text = "" Then
            Me.txtConcursoFinal.Text = "0"
            intConcursoFinal = 0
        Else
            intConcursoFinal = CInt(Me.txtConcursoFinal.Text)
        End If

        If ddlSetDados.SelectedIndex = -1 Then
            'erro
            Me.Cursor = Cursors.Arrow
            ShowErro("Preencher o Set das Dezenas para Pesquisa", "Gravando Dados do Set", Me.Name)
            Exit Sub
        End If

        If intConcursoInicial > intConcursoFinal Then
            'erro
            Me.Cursor = Cursors.Arrow
            ShowErro("Número da Faixa de Concurso final é maior que o da faixa inicial", "Gravando Dados do Set", Me.Name)
            Exit Sub
        End If

        Try
            oItem = CType(ddlSetDados.SelectedItem, Struct.SetPesquisa)
            oSetPesquisa = New Core.Data.SetPesquisas(GetKey(), _
                                                      oItem.Codigo, _
                                                      oItem.Loteria, _
                                                      oItem.ConcursoInicial, _
                                                      oItem.ConcursoFinal)

            lstPesquisa = oSetPesquisa.GetDezenaSet()
            lDezenas = oSetPesquisa.GetDezenas
            lstDezenasSet.DataSource = lDezenas
            lvPesquisas.Items.Clear()
            For Each oItemLista As Struct.SetResults In lstPesquisa
                lItem = New ListViewItem
                lItem.Text = oItemLista.Concurso.ToString()
                lItem.SubItems.Add(oItemLista.DataConcurso.ToShortDateString())
                lItem.SubItems.Add(oItem.NomeLoteria)
                lItem.SubItems.Add(oItemLista.QuantidadeDezenas.ToString())
                lItem.SubItems.Add(FormatNumber(oItemLista.PercentualEficiencia.ToString(), 5))
                lvPesquisas.Items.Add(lItem)
            Next
            oItem = Nothing
            lDezenas = Nothing
            lstPesquisa = Nothing
            oSetPesquisa = Nothing

        Catch ex As Exception
            oItem = Nothing
            lstPesquisa = Nothing
            lDezenas = Nothing
            oSetPesquisa = Nothing
            Me.Cursor = Cursors.Arrow
            ShowErro(ex, "Gravando Dados do Set", Me.Name)
        End Try

        Me.Cursor = Cursors.Arrow

    End Sub

End Class