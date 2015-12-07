Imports Consumer.Structs

Public Class frmCadLoteria

    Private Sub frmCadLoteria_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CarregaComboLoteria()
        CarregaComboTimeMania()
    End Sub

    Sub CarregaComboLoteria()

        Dim lstResult As List(Of Struct.Loteria)
        Dim itnData As New ItemData

        Using objBusiness As TorchWood.Core.Data.Loterias = New TorchWood.Core.Data.Loterias("torchConn")
            lstResult = objBusiness.List
            objBusiness.Dispose()
        End Using

        If Not IsNothing(lstResult) AndAlso lstResult.Count > 0 Then

            For Each itnDados As Struct.Loteria In lstResult
                Me.ddlLoterias.Items.Add(itnDados)
            Next

            itnData.Dispose()
            itnData = Nothing
            lstResult = Nothing

        End If

    End Sub

    Sub CarregaComboTimeMania()

        Dim dtResult As New DataTable
        Dim objTimeMania As TorchWood.Struct.TimeManiaTimes

        Try
            Using objBusiness As TorchWood.Core.Data.Loterias = New TorchWood.Core.Data.Loterias("torchConn")
                'dtResult = objBusiness.List
                objBusiness.Dispose()
            End Using

            If Not IsNothing(dtResult) AndAlso dtResult.Rows.Count > 0 Then

                For Each drDados As DataRow In dtResult.Rows
                    objTimeMania = New TorchWood.Struct.TimeManiaTimes
                    objTimeMania.Codigo = drDados.Item("id_loteria")
                    objTimeMania.Time = drDados.Item("nm_loteria")
                    objTimeMania.UFTime = drDados.Item("qt_dezenas")

                    Me.ddlTime.Items.Add(objTimeMania)
                Next

            End If
        Catch ex As Exception
            ShowErro(ex, "Erro carregando Combo de Times", "frmCadLoteria.CarregaComboTimeMania")
        Finally
            dtResult = Nothing
            objTimeMania = Nothing
        End Try

    End Sub

    Function EfetuaSeparacao(ByVal strDezenas As String, _
                             ByVal intLoteriaDez As Integer) As List(Of String)

        Dim strDezenaCol As New List(Of String)
        Dim aStrDezena As String()

        Try

            aStrDezena = strDezenas.Split(";")
            If aStrDezena.Length <> intLoteriaDez Then
                ShowErro("Dezenas não conferem , foram inseridas" + _
                         (aStrDezena.Length + 1).ToString + " dezenas!", _
                         "Erros nas Dezenas", _
                         "frmCadLoteria.EfetuaSeparacao")
                strDezenaCol = Nothing
                Exit Try
            End If
            For Each strDez As String In aStrDezena
                strDezenaCol.Add(strDez)
            Next

        Catch ex As Exception
            strDezenaCol = Nothing
            ShowErro(ex, "Erro carregando Combo de Times", "frmCadLoteria.EfetuaSeparacao")
        Finally
            aStrDezena = Nothing
        End Try
        Return strDezenaCol

    End Function

    Private Sub btnGravaLoteria_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGravaLoteria.Click

        'consistir
        Dim strMensagem As String = ""
        Dim blnRetorno As Boolean = False
        Dim strDezenaCol As New List(Of String)

        blnRetorno = ConsisteLoteria(strMensagem)

        If blnRetorno Then
            'erro
            ShowErro(strMensagem, "Campos Inconsistentes", "frmCadLoteria.btnGravaLoteria_Click")
            Exit Sub
        End If

        Dim objLoteria As TorchWood.Struct.Loteria
        objLoteria = CType(ddlLoterias.SelectedItem, TorchWood.Struct.Loteria)

        Try
            strDezenaCol = EfetuaSeparacao(Me.txtDezenas.Text, objLoteria.QtdeDezenas)
            Using objGravar As TorchWood.Core.Data.Dezenas = New TorchWood.Core.Data.Dezenas("torchConn")
                Select Case objLoteria.Codigo
                    Case 1, 2, 3
                        objGravar.Sena.Concurso = Convert.ToInt16(Me.txtConcurso.Text)
                        objGravar.Sena.Data = Me.txtDtConcurso.Text
                        objGravar.Sena.Loteria = objLoteria.Codigo
                        objGravar.Sena.Dezena01 = Convert.ToInt16(strDezenaCol.Item(0).ToString)
                        objGravar.Sena.Dezena02 = Convert.ToInt16(strDezenaCol.Item(1).ToString)
                        objGravar.Sena.Dezena03 = Convert.ToInt16(strDezenaCol.Item(2).ToString)
                        objGravar.Sena.Dezena04 = Convert.ToInt16(strDezenaCol.Item(3).ToString)
                        objGravar.Sena.Dezena05 = Convert.ToInt16(strDezenaCol.Item(4).ToString)
                        objGravar.Sena.Dezena06 = Convert.ToInt16(strDezenaCol.Item(5).ToString)
                        objGravar.GravarSena()
                    Case 4
                        objGravar.LotoMania.Concurso = Convert.ToInt16(Me.txtConcurso.Text)
                        objGravar.LotoMania.Data = Me.txtDtConcurso.Text
                        objGravar.LotoMania.Dezena01 = Convert.ToInt16(strDezenaCol.Item(0).ToString)
                        objGravar.LotoMania.Dezena02 = Convert.ToInt16(strDezenaCol.Item(1).ToString)
                        objGravar.LotoMania.Dezena03 = Convert.ToInt16(strDezenaCol.Item(2).ToString)
                        objGravar.LotoMania.Dezena04 = Convert.ToInt16(strDezenaCol.Item(3).ToString)
                        objGravar.LotoMania.Dezena05 = Convert.ToInt16(strDezenaCol.Item(4).ToString)
                        objGravar.LotoMania.Dezena06 = Convert.ToInt16(strDezenaCol.Item(5).ToString)
                        objGravar.LotoMania.Dezena07 = Convert.ToInt16(strDezenaCol.Item(0).ToString)
                        objGravar.LotoMania.Dezena08 = Convert.ToInt16(strDezenaCol.Item(1).ToString)
                        objGravar.LotoMania.Dezena09 = Convert.ToInt16(strDezenaCol.Item(2).ToString)
                        objGravar.LotoMania.Dezena10 = Convert.ToInt16(strDezenaCol.Item(3).ToString)
                        objGravar.LotoMania.Dezena11 = Convert.ToInt16(strDezenaCol.Item(4).ToString)
                        objGravar.LotoMania.Dezena12 = Convert.ToInt16(strDezenaCol.Item(5).ToString)
                        objGravar.LotoMania.Dezena13 = Convert.ToInt16(strDezenaCol.Item(0).ToString)
                        objGravar.LotoMania.Dezena14 = Convert.ToInt16(strDezenaCol.Item(1).ToString)
                        objGravar.LotoMania.Dezena15 = Convert.ToInt16(strDezenaCol.Item(2).ToString)
                        objGravar.LotoMania.Dezena16 = Convert.ToInt16(strDezenaCol.Item(3).ToString)
                        objGravar.LotoMania.Dezena17 = Convert.ToInt16(strDezenaCol.Item(4).ToString)
                        objGravar.LotoMania.Dezena18 = Convert.ToInt16(strDezenaCol.Item(5).ToString)
                        objGravar.LotoMania.Dezena19 = Convert.ToInt16(strDezenaCol.Item(0).ToString)
                        objGravar.LotoMania.Dezena20 = Convert.ToInt16(strDezenaCol.Item(1).ToString)
                        objGravar.GravarLotoMania()
                    Case 5
                        objGravar.LotoFacil.Concurso = Convert.ToInt16(Me.txtConcurso.Text)
                        objGravar.LotoFacil.Data = Me.txtDtConcurso.Text
                        objGravar.LotoFacil.Dezena01 = Convert.ToInt16(strDezenaCol.Item(0).ToString)
                        objGravar.LotoFacil.Dezena02 = Convert.ToInt16(strDezenaCol.Item(1).ToString)
                        objGravar.LotoFacil.Dezena03 = Convert.ToInt16(strDezenaCol.Item(2).ToString)
                        objGravar.LotoFacil.Dezena04 = Convert.ToInt16(strDezenaCol.Item(3).ToString)
                        objGravar.LotoFacil.Dezena05 = Convert.ToInt16(strDezenaCol.Item(4).ToString)
                        objGravar.LotoFacil.Dezena06 = Convert.ToInt16(strDezenaCol.Item(5).ToString)
                        objGravar.LotoFacil.Dezena07 = Convert.ToInt16(strDezenaCol.Item(0).ToString)
                        objGravar.LotoFacil.Dezena08 = Convert.ToInt16(strDezenaCol.Item(1).ToString)
                        objGravar.LotoFacil.Dezena09 = Convert.ToInt16(strDezenaCol.Item(2).ToString)
                        objGravar.LotoFacil.Dezena10 = Convert.ToInt16(strDezenaCol.Item(3).ToString)
                        objGravar.LotoFacil.Dezena11 = Convert.ToInt16(strDezenaCol.Item(4).ToString)
                        objGravar.LotoFacil.Dezena12 = Convert.ToInt16(strDezenaCol.Item(5).ToString)
                        objGravar.LotoFacil.Dezena13 = Convert.ToInt16(strDezenaCol.Item(0).ToString)
                        objGravar.LotoFacil.Dezena14 = Convert.ToInt16(strDezenaCol.Item(1).ToString)
                        objGravar.LotoFacil.Dezena15 = Convert.ToInt16(strDezenaCol.Item(2).ToString)
                        objGravar.GravarLotoFacil()
                    Case 6
                        objGravar.Quina.Concurso = Convert.ToInt16(Me.txtConcurso.Text)
                        objGravar.Quina.Data = Me.txtDtConcurso.Text
                        objGravar.Quina.Dezena01 = Convert.ToInt16(strDezenaCol.Item(0).ToString)
                        objGravar.Quina.Dezena02 = Convert.ToInt16(strDezenaCol.Item(1).ToString)
                        objGravar.Quina.Dezena03 = Convert.ToInt16(strDezenaCol.Item(2).ToString)
                        objGravar.Quina.Dezena04 = Convert.ToInt16(strDezenaCol.Item(3).ToString)
                        objGravar.Quina.Dezena05 = Convert.ToInt16(strDezenaCol.Item(4).ToString)
                        objGravar.GravarQuina()
                End Select
            End Using
        Catch ex As Exception

        Finally

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

        If Me.txtDtConcurso.Text = "" Then
            blnRetorno = True
            strMensagem = strMensagem + "Data do Concurso não foi preenchido!" + vbNewLine
        End If

        If Me.txtDezenas.Text = "" Then
            blnRetorno = True
            strMensagem = strMensagem + "As Dezenas não foram preenchidas!" + vbNewLine
        End If

        Return blnRetorno

    End Function

    Private Sub btnAjeitarDados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjeitarDados.Click
        Me.txtDezenas.Text.Replace(Char.Parse(" "), Char.Parse(";"))
        Me.txtDezenas.Text.Replace(Char.Parse(","), Char.Parse(";"))
        Me.txtDezenas.Text.Replace(Char.Parse("."), Char.Parse(";"))
    End Sub
End Class