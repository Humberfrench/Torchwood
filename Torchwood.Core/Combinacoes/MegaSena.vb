Imports Consumer.Math.Stats

Namespace Business.Combinacoes
    Public Class MegaSena

        ''' <summary>
        ''' Aqui Analisa todas as MiniRegras
        ''' </summary>
        ''' <returns>Boolean - > True = sequencia pode ir pra lista</returns>
        ''' <remarks></remarks>
        Private Function AnalisarRegras(ByVal strCombinacao As String) As Boolean

            Dim oSenaRegas As Business.Regras.Senas
            Dim strData As String
            Dim blnRetorno As Boolean
            Dim oSequence As ISequences
            Dim oList As IList(Of Integer)
            Dim oListSeqUni As IList(Of Integer)
            Dim oListSeqDuo As IList(Of Integer)
            Dim oListSeqTri As IList(Of Integer)
            Dim oListSeqQuad As IList(Of Integer)
            Dim oListSeqPenta As IList(Of Integer)
            Dim oListSeqHexa As IList(Of Integer)
            Dim oListSeqHepta As IList(Of Integer)
            Dim oListSeqOcta As IList(Of Integer)
            Dim oListSeqNona As IList(Of Integer)
            Dim oListSeqDec As IList(Of Integer)
            Dim oListSeqUnDec As IList(Of Integer)

            blnRetorno = False

            oSenaRegas = New Business.Regras.Senas
            oSequence = New Business.Sequences
            oList = oSequence.Convert(strCombinacao)

            'verifica as sequencias unitárias.
            oListSeqUni = oSequence.GetSequences(oList)

            'verifica as sequencias de dois a dois
            oListSeqDuo = oSequence.GetSequencesNbyN(oList, 2)

            'verifica as sequencias de tres a tres
            oListSeqTri = oSequence.GetSequencesNbyN(oList, 3)

            'verifica as sequencias de quatro a quatro
            oListSeqQuad = oSequence.GetSequencesNbyN(oList, 4)

            'verifica as sequencias de cinco a cinco
            oListSeqPenta = oSequence.GetSequencesNbyN(oList, 5)

            'verifica as sequencias de seis a seis
            oListSeqHexa = oSequence.GetSequencesNbyN(oList, 6)

            'verifica as sequencias de sete a sete
            oListSeqHepta = oSequence.GetSequencesNbyN(oList, 7)

            'verifica as sequencias de oito a oito
            oListSeqOcta = oSequence.GetSequencesNbyN(oList, 8)

            'verifica as sequencias de nove a nove
            oListSeqNona = oSequence.GetSequencesNbyN(oList, 9)

            'verifica as sequencias de dez a dez
            oListSeqDec = oSequence.GetSequencesNbyN(oList, 10)

            'verifica as sequencias de onze a onze
            oListSeqUnDec = oSequence.GetSequencesNbyN(oList, 11)

            'analisa as sequencias passadas
            If oSenaRegas.AnalisarRegrasUnitarias(oListSeqUni) Then
                blnRetorno = False
            Else
                'analisando regras para duo usando NbyN
                If oSenaRegas.AnalisaRegrasNbyN(oListSeqDuo) Then
                    blnRetorno = False
                Else
                    'analisando regras para tres a tres usando NbyN
                    If oSenaRegas.AnalisaRegrasNbyN(oListSeqTri) Then
                        blnRetorno = False
                    Else
                        'analisando regras para quatro a quatro usando NbyN
                        If oSenaRegas.AnalisaRegrasNbyN(oListSeqQuad) Then
                            blnRetorno = False
                            'para teste e nao passar por BD
                        Else
                            'analisando regras para cinco a cinco usando NbyN
                            If oSenaRegas.AnalisaRegrasNbyN(oListSeqPenta) Then
                                blnRetorno = False
                                'para teste e nao passar por BD
                            Else
                                'analisando regras para seis a seis usando NbyN
                                If oSenaRegas.AnalisaRegrasNbyN(oListSeqHexa) Then
                                    blnRetorno = False
                                    'para teste e nao passar por BD
                                Else
                                    'analisando regras para sete a sete usando NbyN
                                    If oSenaRegas.AnalisaRegrasNbyN(oListSeqHepta) Then
                                        blnRetorno = False
                                        'para teste e nao passar por BD
                                    Else
                                        'analisando regras para oito a cinco oito NbyN
                                        If oSenaRegas.AnalisaRegrasNbyN(oListSeqOcta) Then
                                            blnRetorno = False
                                            'para teste e nao passar por BD
                                        Else
                                            'analisando regras para nove a nove usando NbyN
                                            If oSenaRegas.AnalisaRegrasNbyN(oListSeqNona) Then
                                                blnRetorno = False
                                                'para teste e nao passar por BD
                                            Else
                                                If oSenaRegas.AnalisaRegrasNbyN(oListSeqDec) Then
                                                    blnRetorno = False
                                                    'para teste e nao passar por BD
                                                Else
                                                    If oSenaRegas.AnalisaRegrasNbyN(oListSeqUnDec) Then
                                                        blnRetorno = False
                                                        'para teste e nao passar por BD
                                                    Else
                                                        blnRetorno = True
                                                        'Retornou false, significa não é sequencia, então agora analisemos
                                                        'o procedimento passo a passo.
                                                        '1 - ver senas da sequencia
                                                        'CÓDIGO ABAIXO COMENTADO. EFEITO DE PERFORMANCE
                                                        'AQUI ANALISA SE EXISTE OCORRENCIA EM CONCURSOS PASSADOS
                                                        'If AnalisaSenas(strCombinacao) Then ' tem senas
                                                        '    blnRetorno = False
                                                        'Else
                                                        '    '2 - ver quinas da sequencia
                                                        '    If AnalisaQuinas(strCombinacao) Then ' tem quinas
                                                        '        blnRetorno = False
                                                        '    Else
                                                        '        '3 - ver quadras da sequencia
                                                        '        If AnalisaQuadras(strCombinacao) Then ' tem quinas
                                                        '            blnRetorno = False
                                                        '        Else
                                                        '            blnRetorno = True
                                                        '        End If
                                                        '    End If
                                                        'End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If

            oSenaRegas = Nothing
            strData = Nothing
            oSequence = Nothing
            oList = Nothing
            oListSeqUni = Nothing
            oListSeqDuo = Nothing
            oListSeqTri = Nothing
            oListSeqQuad = Nothing
            oListSeqPenta = Nothing
            oListSeqPenta = Nothing
            oListSeqHexa = Nothing
            oListSeqHepta = Nothing
            oListSeqOcta = Nothing
            oListSeqNona = Nothing
            oListSeqDec = Nothing
            oListSeqUnDec = Nothing

            Return blnRetorno

        End Function

        ''' <summary>
        ''' Analisa as Senas desta sequencia
        ''' </summary>
        ''' <param name="strSequence"></param>
        ''' <returns>True, se existe algo já dado na sequencia. O que diminui as chances</returns>
        ''' <remarks></remarks>
        Private Function AnalisaSenas(ByVal strSequence As String) As Boolean

            Dim blnRetorno As Boolean
            Dim blnDado As Boolean
            Dim strArray As String()
            Dim oVerify As Data.Combinacoes
            Dim oMegaSena As Struct.Combinacoes.MegaSena

            'criando objetos
            oVerify = New Data.Combinacoes

            'inicando as variaveis
            blnDado = False
            blnRetorno = False

            oMegaSena = New Struct.Combinacoes.MegaSena

            strArray = strSequence.Split(","c)

            oMegaSena.Dezena01 = CInt(strArray(0))
            oMegaSena.Dezena02 = CInt(strArray(1))
            oMegaSena.Dezena03 = CInt(strArray(2))
            oMegaSena.Dezena04 = CInt(strArray(3))
            oMegaSena.Dezena05 = CInt(strArray(4))
            oMegaSena.Dezena06 = CInt(strArray(5))

            oVerify.Key = "torchConn"
            blnDado = oVerify.VerificaQuinasNaMega(oMegaSena)
            'se ja tem, sai nem precisa analisar o resto
            If blnDado Then
                blnRetorno = True
            End If

            'destruindo objetos
            oMegaSena = Nothing
            oVerify = Nothing
            strArray = Nothing

            Return blnRetorno

        End Function

        ''' <summary>
        ''' Analisa as Quinas desta sequencia
        ''' </summary>
        ''' <param name="strSequence"></param>
        ''' <returns>True, se existe algo já dado na sequencia. O que diminui as chances</returns>
        ''' <remarks></remarks>
        Private Function AnalisaQuinas(ByVal strSequence As String) As Boolean

            Dim blnRetorno As Boolean
            Dim blnDado As Boolean
            Dim strArray As String()
            Dim oVerify As Data.Combinacoes
            Dim oCombine As Combinatory
            Dim lstCombinado As List(Of String)
            Dim oMegaSena As Struct.Combinacoes.MegaSena

            'criando objetos
            oCombine = New Combinatory
            oVerify = New Data.Combinacoes

            'inicando as variaveis
            blnDado = False
            blnRetorno = False
            lstCombinado = oCombine.CombinarValores(strSequence, 5)

            For Each strValor As String In lstCombinado

                oMegaSena = New Struct.Combinacoes.MegaSena
                strArray = strValor.Split(","c)
                oMegaSena.Dezena01 = CInt(strArray(0))
                oMegaSena.Dezena02 = CInt(strArray(1))
                oMegaSena.Dezena03 = CInt(strArray(2))
                oMegaSena.Dezena04 = CInt(strArray(3))
                oMegaSena.Dezena05 = CInt(strArray(4))

                oVerify.Key = "torchConn"
                blnDado = oVerify.VerificaQuinasNaMega(oMegaSena)
                'se ja tem, sai nem precisa analisar o resto
                If blnDado Then
                    blnRetorno = True
                    Exit For
                End If
            Next

            'destruindo objetos
            oCombine = Nothing
            oMegaSena = Nothing
            oVerify = Nothing
            strArray = Nothing
            lstCombinado = Nothing

            Return blnRetorno

        End Function

        ''' <summary>
        ''' Analisa as Quadras desta sequencia
        ''' </summary>
        ''' <param name="strSequence"></param>
        ''' <returns>True, se existe algo já dado na sequencia. O que diminui as chances</returns>
        ''' <remarks></remarks>
        Private Function AnalisaQuadras(ByVal strSequence As String) As Boolean

            Dim blnRetorno As Boolean
            Dim blnDado As Boolean
            Dim strArray As String()
            Dim oVerify As Data.Combinacoes
            Dim lstCombinado As List(Of String)
            Dim oCombine As Combinatory
            Dim oMegaSena As Struct.Combinacoes.MegaSena

            'criando objetos
            oCombine = New Combinatory
            oVerify = New Data.Combinacoes

            'inicando as variaveis
            blnDado = False
            blnRetorno = False
            lstCombinado = oCombine.CombinarValores(strSequence, 4)

            For Each strValor As String In lstCombinado

                oMegaSena = New Struct.Combinacoes.MegaSena
                strArray = strValor.Split(","c)
                oMegaSena.Dezena01 = CInt(strArray(0))
                oMegaSena.Dezena02 = CInt(strArray(1))
                oMegaSena.Dezena03 = CInt(strArray(2))
                oMegaSena.Dezena04 = CInt(strArray(3))

                oVerify.Key = "torchConn"
                blnDado = oVerify.VerificaQuadrasNaMega(oMegaSena)
                'se ja tem, sai nem precisa analisar o resto
                If blnDado Then
                    blnRetorno = True
                    Exit For
                End If
            Next

            'destruindo objetos
            oCombine = Nothing
            oMegaSena = Nothing
            oVerify = Nothing
            strArray = Nothing
            lstCombinado = Nothing

            Return blnRetorno

        End Function

        ''' <summary>
        ''' Gera n milhares de combinações da Mega-Sena. Excluindo sequencias
        ''' repetidas e dados de concursos.
        ''' Inicialmente vamos remover apenas dados que existam exatamente em concursos,
        ''' Apos isto remover os que tem "quina coincidentes"
        ''' </summary>
        ''' <returns>List(Of String) das Dezenas</returns>
        ''' <remarks></remarks>
        Public Function CombinarValoresSena() As List(Of String)

            Dim strElementos As String = String.Empty
            Dim shtCombinacao_N As Short
            Dim shtCombinacao_P As Short
            Dim dblCombinacao As Double
            Dim strCombinacao As String = String.Empty
            Dim shtContador As Short
            Dim shtPtr As Short
            Dim shtNivel As Short
            Dim shtOffSet As Short
            Dim lstCombinacoes As New List(Of String)
            Dim aStrElementos() As String
            Dim aShtPtr() As Short
            Dim strValues As String = String.Empty

            Try

                'monta a sequencia da mega sena de todas as dezenas
                strValues = ""
                For intCont As Integer = 0 To 59
                    strValues = strValues + intCont.ToString() + ","
                Next

                ' Retira Brancos
                strElementos = General.Trans(Trim(strValues), " ", "")
                Do While InStr(TAG_SEPARADOR, Right(strElementos, 1)) > 0
                    strElementos = Left(strElementos, Len(strElementos) - 1)
                Loop

                ' Busca Posicao do 1o Caracter DIREFERENTE do Separados ( TAG_SEPARADOR )
                shtPtr = 1
                Do While InStr(TAG_SEPARADOR, Mid(strElementos, Convert.ToInt32(shtPtr), 1)) > 0
                    shtPtr = CShort(shtPtr + 1)
                Loop

                shtContador = 0
                ReDim aStrElementos(1) 'As String

                ' Cadastra os Elementos a serem combinados
                Do While shtPtr <= Len(strElementos)
                    shtContador = CShort(shtContador + 1)
                    ReDim Preserve aStrElementos(shtContador) 'As String
                    aStrElementos(Convert.ToInt32(shtContador)) = ""
                    Do While shtPtr <= Len(strElementos) And InStr(TAG_SEPARADOR, Mid(strElementos, shtPtr, 1)) = 0
                        aStrElementos(shtContador) = aStrElementos(shtContador) & Mid(strElementos, shtPtr, 1)
                        shtPtr = CShort(shtPtr + 1)
                    Loop
                    Do While shtPtr <= Len(strElementos) And InStr(TAG_SEPARADOR, Mid(strElementos, shtPtr, 1)) > 0
                        shtPtr = CShort(shtPtr + 1)
                    Loop
                Loop

                'mega sena = 6
                shtCombinacao_N = CShort(UBound(aStrElementos))
                shtCombinacao_P = 6

                ' Pointer para a Montagem das Combinacoes
                ReDim aShtPtr(shtCombinacao_P) 'As Integer

                For shtPtr = 1 To CShort(UBound(aShtPtr))
                    aShtPtr(shtPtr) = shtPtr
                Next

                dblCombinacao = 0
                Do While True
                    dblCombinacao = dblCombinacao + 1
                    strCombinacao = ""
                    For shtPtr = 1 To CShort(UBound(aShtPtr))
                        strCombinacao = strCombinacao & aStrElementos(aShtPtr(shtPtr)) & ", "
                    Next
                    strCombinacao = Left(strCombinacao, Len(strCombinacao) - 2)
                    strCombinacao = strCombinacao.Replace(" ", "")

                    If AnalisarRegras(strCombinacao) Then
                        lstCombinacoes.Add(strCombinacao)
                    End If

                    If dblCombinacao Mod 100000 = 0 Then
                        Debug.Print(dblCombinacao.ToString + " - " + lstCombinacoes.Count.ToString)
                    End If

                    aShtPtr(shtCombinacao_P) = CShort(aShtPtr(shtCombinacao_P) + 1)

                    If aShtPtr(shtCombinacao_P) > shtCombinacao_N Then
                        shtNivel = CShort((shtCombinacao_P - 1))
                        shtOffSet = 1
                        Do While aShtPtr(shtNivel) = shtCombinacao_N - shtOffSet
                            shtNivel = CShort(shtNivel - 1)
                            shtOffSet = CShort(shtOffSet + 1)
                        Loop

                        If shtNivel = 0 Then Exit Do

                        aShtPtr(shtNivel) = CShort(aShtPtr(shtNivel) + 1)
                        shtNivel = CShort(shtNivel + 1)
                        For shtPtr = shtNivel To shtCombinacao_P
                            aShtPtr(shtPtr) = CShort(aShtPtr(shtPtr - 1) + 1)
                        Next
                    End If
                Loop

            Catch ex As Exception
                Throw New Exception("Erro na equencia: " + strCombinacao, ex)
            End Try
            Return lstCombinacoes

        End Function

    End Class

End Namespace