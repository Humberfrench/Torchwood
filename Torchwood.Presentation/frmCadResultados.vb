Imports Consumer.Structs
Imports System

Public Class frmCadResultados

    Private Sub frmCadResultados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Limpar()

    End Sub

    Sub CarregaComboLoteria()

        Dim lstResult As List(Of Struct.Loteria)

        Try
            Me.Cursor = Cursors.WaitCursor

            Using objBusiness As Torchwood.Core.Data.Loterias = New Torchwood.Core.Data.Loterias(GetKey())
                lstResult = objBusiness.List
                objBusiness.Dispose()
            End Using

            If Not IsNothing(lstResult) AndAlso lstResult.Count > 0 Then
                Me.ddlLoterias.Items.Clear()
                For Each itnDados As Struct.Loteria In lstResult
                    Me.ddlLoterias.Items.Add(itnDados)
                Next

                lstResult = Nothing
                Me.Cursor = Cursors.Arrow

            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            ShowErro(ex, "Erro carregando Combo de Loterias", "frmCadLoteria.CarregaComboLoteria")
        Finally
            lstResult = Nothing
        End Try

    End Sub

    Sub CarregaComboTimeMania()

        Dim lstTimeMania As List(Of Struct.TimeManiaTimes)

        Try
            Me.Cursor = Cursors.WaitCursor

            Using objBusiness As Torchwood.Core.Data.Timemania = New Torchwood.Core.Data.Timemania(GetKey())
                lstTimeMania = objBusiness.List
                objBusiness.Dispose()
            End Using

            If Not IsNothing(lstTimeMania) AndAlso lstTimeMania.Count > 0 Then
                Me.ddlTime.Items.Clear()
                For Each itnData As Struct.TimeManiaTimes In lstTimeMania
                    Me.ddlTime.Items.Add(itnData)
                Next
                Me.Cursor = Cursors.Arrow

            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            ShowErro(ex, "Erro carregando Combo de Times", "frmCadLoteria.CarregaComboTimeMania")
        Finally
            lstTimeMania = Nothing
        End Try

    End Sub

    Function EfetuaSeparacao(ByRef strDezenas As String, _
                             ByVal intLoteriaDez As Integer) As List(Of String)

        Dim strDezenaCol As New List(Of String)
        Dim aStrDezena As String()

        Try
            Me.Cursor = Cursors.WaitCursor
            'acertando valores diferentes
            strDezenas = strDezenas.Replace(" "c, ";")
            strDezenas = strDezenas.Replace("-"c, ";")
            strDezenas = strDezenas.Replace(","c, ";")

            aStrDezena = strDezenas.Split(";")
            If lvDezenas.Items.Count <> CInt(txtDezSorteio.Text) Then
                ShowErro("Dezenas não conferem , foram inseridas" + _
                         (aStrDezena.Length + 1).ToString + " dezenas!", _
                         "Erros nas Dezenas", _
                         "frmCadLoteria.EfetuaSeparacao")
                strDezenaCol = Nothing
                Exit Try
            End If
            For Each oItem As ListViewItem In lvDezenas.Items
                strDezenaCol.Add(CInt(oItem.SubItems(1).Text))
            Next
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            strDezenaCol = Nothing
            ShowErro(ex, "Erro carregando Dezenas", "frmCadLoteria.EfetuaSeparacao")
        Finally
            aStrDezena = Nothing
        End Try
        Return strDezenaCol

    End Function

    Private Sub btnGravaLoteria_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGravaLoteria.Click

        'consistir
        Dim strMensagem As String = ""
        Dim blnRetorno As Boolean = False
        Dim lstDezenaCol As New List(Of String)
        Dim oTimeManiaTimes As Struct.TimeManiaTimes

        blnRetorno = ConsisteLoteria(strMensagem)

        If blnRetorno Then
            'erro
            ShowErro(strMensagem, "Campos Inconsistentes", "frmCadLoteria.btnGravaLoteria_Click")
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim objLoteria As Torchwood.Struct.Loteria
        objLoteria = CType(ddlLoterias.SelectedItem, Torchwood.Struct.Loteria)

        Try
            lstDezenaCol = EfetuaSeparacao(Me.txtDezenas.Text, objLoteria.QtdeDezenas)
            oTimeManiaTimes = Me.ddlTime.SelectedItem
            Using objGravar As Torchwood.Core.Data.Dezenas = New Torchwood.Core.Data.Dezenas("torchConn")
                Select Case objLoteria.Codigo
                    Case 1, 2, 3
                        objGravar.Sena.Concurso = Convert.ToInt16(Me.txtConcurso.Text)
                        objGravar.Sena.Data = Me.dtpDataConcurso.Value
                        objGravar.Sena.Loteria = objLoteria.Codigo
                        objGravar.Sena.Dezena01 = Convert.ToInt16(lstDezenaCol.Item(0).ToString)
                        objGravar.Sena.Dezena02 = Convert.ToInt16(lstDezenaCol.Item(1).ToString)
                        objGravar.Sena.Dezena03 = Convert.ToInt16(lstDezenaCol.Item(2).ToString)
                        objGravar.Sena.Dezena04 = Convert.ToInt16(lstDezenaCol.Item(3).ToString)
                        objGravar.Sena.Dezena05 = Convert.ToInt16(lstDezenaCol.Item(4).ToString)
                        objGravar.Sena.Dezena06 = Convert.ToInt16(lstDezenaCol.Item(5).ToString)
                        objGravar.GravarSena()
                    Case 4
                        objGravar.LotoMania.Concurso = Convert.ToInt16(Me.txtConcurso.Text)
                        objGravar.LotoMania.Data = Me.dtpDataConcurso.Value
                        objGravar.LotoMania.Dezena01 = Convert.ToInt16(lstDezenaCol.Item(0).ToString)
                        objGravar.LotoMania.Dezena02 = Convert.ToInt16(lstDezenaCol.Item(1).ToString)
                        objGravar.LotoMania.Dezena03 = Convert.ToInt16(lstDezenaCol.Item(2).ToString)
                        objGravar.LotoMania.Dezena04 = Convert.ToInt16(lstDezenaCol.Item(3).ToString)
                        objGravar.LotoMania.Dezena05 = Convert.ToInt16(lstDezenaCol.Item(4).ToString)
                        objGravar.LotoMania.Dezena06 = Convert.ToInt16(lstDezenaCol.Item(5).ToString)
                        objGravar.LotoMania.Dezena07 = Convert.ToInt16(lstDezenaCol.Item(0).ToString)
                        objGravar.LotoMania.Dezena08 = Convert.ToInt16(lstDezenaCol.Item(1).ToString)
                        objGravar.LotoMania.Dezena09 = Convert.ToInt16(lstDezenaCol.Item(2).ToString)
                        objGravar.LotoMania.Dezena10 = Convert.ToInt16(lstDezenaCol.Item(3).ToString)
                        objGravar.LotoMania.Dezena11 = Convert.ToInt16(lstDezenaCol.Item(4).ToString)
                        objGravar.LotoMania.Dezena12 = Convert.ToInt16(lstDezenaCol.Item(5).ToString)
                        objGravar.LotoMania.Dezena13 = Convert.ToInt16(lstDezenaCol.Item(0).ToString)
                        objGravar.LotoMania.Dezena14 = Convert.ToInt16(lstDezenaCol.Item(1).ToString)
                        objGravar.LotoMania.Dezena15 = Convert.ToInt16(lstDezenaCol.Item(2).ToString)
                        objGravar.LotoMania.Dezena16 = Convert.ToInt16(lstDezenaCol.Item(3).ToString)
                        objGravar.LotoMania.Dezena17 = Convert.ToInt16(lstDezenaCol.Item(4).ToString)
                        objGravar.LotoMania.Dezena18 = Convert.ToInt16(lstDezenaCol.Item(5).ToString)
                        objGravar.LotoMania.Dezena19 = Convert.ToInt16(lstDezenaCol.Item(0).ToString)
                        objGravar.LotoMania.Dezena20 = Convert.ToInt16(lstDezenaCol.Item(1).ToString)
                        objGravar.GravarLotoMania()
                    Case 5
                        objGravar.LotoFacil.Concurso = Convert.ToInt16(Me.txtConcurso.Text)
                        objGravar.LotoFacil.Data = Me.dtpDataConcurso.Value
                        objGravar.LotoFacil.Dezena01 = Convert.ToInt16(lstDezenaCol.Item(0).ToString)
                        objGravar.LotoFacil.Dezena02 = Convert.ToInt16(lstDezenaCol.Item(1).ToString)
                        objGravar.LotoFacil.Dezena03 = Convert.ToInt16(lstDezenaCol.Item(2).ToString)
                        objGravar.LotoFacil.Dezena04 = Convert.ToInt16(lstDezenaCol.Item(3).ToString)
                        objGravar.LotoFacil.Dezena05 = Convert.ToInt16(lstDezenaCol.Item(4).ToString)
                        objGravar.LotoFacil.Dezena06 = Convert.ToInt16(lstDezenaCol.Item(5).ToString)
                        objGravar.LotoFacil.Dezena07 = Convert.ToInt16(lstDezenaCol.Item(0).ToString)
                        objGravar.LotoFacil.Dezena08 = Convert.ToInt16(lstDezenaCol.Item(1).ToString)
                        objGravar.LotoFacil.Dezena09 = Convert.ToInt16(lstDezenaCol.Item(2).ToString)
                        objGravar.LotoFacil.Dezena10 = Convert.ToInt16(lstDezenaCol.Item(3).ToString)
                        objGravar.LotoFacil.Dezena11 = Convert.ToInt16(lstDezenaCol.Item(4).ToString)
                        objGravar.LotoFacil.Dezena12 = Convert.ToInt16(lstDezenaCol.Item(5).ToString)
                        objGravar.LotoFacil.Dezena13 = Convert.ToInt16(lstDezenaCol.Item(0).ToString)
                        objGravar.LotoFacil.Dezena14 = Convert.ToInt16(lstDezenaCol.Item(1).ToString)
                        objGravar.LotoFacil.Dezena15 = Convert.ToInt16(lstDezenaCol.Item(2).ToString)
                        objGravar.GravarLotoFacil()
                    Case 6
                        objGravar.Quina.Concurso = Convert.ToInt16(Me.txtConcurso.Text)
                        objGravar.Quina.Data = Me.dtpDataConcurso.Value
                        objGravar.Quina.Dezena01 = Convert.ToInt16(lstDezenaCol.Item(0).ToString)
                        objGravar.Quina.Dezena02 = Convert.ToInt16(lstDezenaCol.Item(1).ToString)
                        objGravar.Quina.Dezena03 = Convert.ToInt16(lstDezenaCol.Item(2).ToString)
                        objGravar.Quina.Dezena04 = Convert.ToInt16(lstDezenaCol.Item(3).ToString)
                        objGravar.Quina.Dezena05 = Convert.ToInt16(lstDezenaCol.Item(4).ToString)
                        objGravar.GravarQuina()
                    Case 7, 8 'timemania
                        objGravar.TimeMania.Concurso = Convert.ToInt16(Me.txtConcurso.Text)
                        objGravar.TimeMania.Data = Me.dtpDataConcurso.Value
                        objGravar.TimeMania.Dezena01 = Convert.ToInt16(lstDezenaCol.Item(0).ToString)
                        objGravar.TimeMania.Dezena02 = Convert.ToInt16(lstDezenaCol.Item(1).ToString)
                        objGravar.TimeMania.Dezena03 = Convert.ToInt16(lstDezenaCol.Item(2).ToString)
                        objGravar.TimeMania.Dezena04 = Convert.ToInt16(lstDezenaCol.Item(3).ToString)
                        objGravar.TimeMania.Dezena05 = Convert.ToInt16(lstDezenaCol.Item(4).ToString)
                        objGravar.TimeMania.Dezena06 = Convert.ToInt16(lstDezenaCol.Item(5).ToString)
                        objGravar.TimeMania.Dezena07 = Convert.ToInt16(lstDezenaCol.Item(6).ToString)
                        objGravar.TimeMania.Time = oTimeManiaTimes
                        objGravar.GravarTimeMania()
                    Case Else
                        ShowErro("Loteria Inválida!", "Combinações", "FrmCombinar")
                        Exit Sub
                End Select
                objGravar.Dispose()
                Limpar()
                lstDezenaCol = Nothing
                Me.Cursor = Cursors.Arrow
            End Using
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            ShowErro(ex, "Erro Gravando as Loterias", "frmCadLoteria.EfetuaSeparacao")
        Finally
            lstDezenaCol = Nothing
            objLoteria = Nothing
        End Try

    End Sub

    Function ConsisteLoteria(ByRef strMensagem As String) As Boolean

        Dim blnRetorno As Boolean = False
        strMensagem = ""

        If Me.ddlLoterias.SelectedItem Is Nothing Then
            blnRetorno = True
            strMensagem = strMensagem + "Combo de Loterias não foi preenchido!" + vbNewLine
        End If

        If Me.txtConcurso.Text = "" Then
            blnRetorno = True
            strMensagem = strMensagem + "Número do Concurso não foi preenchido!" + vbNewLine
        End If

        If Me.dtpDataConcurso.Text = "" Then
            blnRetorno = True
            strMensagem = strMensagem + "Data do Concurso não foi preenchido!" + vbNewLine
        End If

        'If Me.txtDezenas.Text = "" Then
        '    blnRetorno = True
        '    strMensagem = strMensagem + "As Dezenas não foram preenchidas!" + vbNewLine
        'End If

        Return blnRetorno

    End Function

    Private Sub ddlLoterias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlLoterias.SelectedIndexChanged

        Dim oLoteria As Struct.Loteria
        oLoteria = ddlLoterias.SelectedItem
        If IsNothing(oLoteria) Then
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor

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

        Me.Cursor = Cursors.Arrow

    End Sub


    Private Sub btnAddDezenas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDezenas.Click

        Dim itnDados As ListViewItem
        If Me.txtDezenas.Text = "" Then
            ShowErro("As Dezenas não foram preenchidas!", "Inconsistência nos Dados", "frmCadLoteria.btnAddDezenas_Click")
            Exit Sub
        Else
            itnDados = New ListViewItem
            itnDados.Text = ((lvDezenas.Items.Count + 1).ToString())
            itnDados.SubItems.Add(txtDezenas.Text)
            lvDezenas.Items.Add(itnDados)
        End If

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        'limpar a tela
        Limpar()
    End Sub

    Sub Limpar()

        dtpDataConcurso.Value = DateTime.Now.ToString

        Me.CarregaComboLoteria()
        Me.CarregaComboTimeMania()

        Me.txtDezSorteio.Text = ""
        Me.txtDezTotais.Text = ""
        Me.txtDezInicial.Text = ""
        Me.txtDezFinal.Text = ""
        Me.txtPremMin.Text = ""
        Me.txtPremMax.Text = ""

        Me.txtConcurso.Text = ""
        Me.txtDezenas.Text = ""

    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click

        Me.Close()

    End Sub
End Class