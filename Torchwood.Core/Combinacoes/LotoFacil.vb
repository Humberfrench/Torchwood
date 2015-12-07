Imports Consumer.Math.Stats

Namespace Business.Combinacoes

    Public Class LotoFacil

        ''' <summary>
        ''' Aqui Analisa todas as MiniRegras
        ''' </summary>
        ''' <returns>Boolean - > True = sequencia pode ir pra lista</returns>
        ''' <remarks></remarks>
        Private Function AnalisarRegras(ByVal strCombinacao As String) As Boolean

            Dim oLotoFacilRegas As Business.Regras.LotoFacil
            Dim strData As String
            Dim blnRetorno As Boolean
            Dim oSequence As ISequences
            Dim oList As IList(Of Integer)
            Dim oListSeq As IList(Of Integer)

            blnRetorno = False

            oLotoFacilRegas = New Business.Regras.LotoFacil
            oSequence = New Business.Sequences
            oList = oSequence.Convert(strCombinacao)

            'verifica as sequencias unitárias.
            oListSeq = oSequence.GetSequences(oList)

            'analisa as sequencias passadas
            If oLotoFacilRegas.AnalisarRegras(oListSeq) Then
                blnRetorno = False
            Else
                'aqui é temporario e fke retirar o return abaixo qdo testar de verdsade
                Return True
                'Retornou false, significa não é sequencia, então agora analisemos
                'o procedimento passo a passo.
                '1 - ver com 15 dezenas da sequencia
                If Analisa15Dezenas(strCombinacao) Then ' tem quinas
                    blnRetorno = False
                Else
                    '2 - ver com 14 dezenas da sequencia
                    If Analisa14Dezenas(strCombinacao) Then ' tem quinas
                        blnRetorno = False
                    Else
                        '3 - ver com 13 dezenas da sequencia
                        If Analisa13Dezenas(strCombinacao) Then ' tem quinas
                            blnRetorno = False
                        Else
                            '4 - ver com 12 dezenas da sequencia
                            If Analisa12Dezenas(strCombinacao) Then ' tem quinas
                                blnRetorno = False
                            Else
                                blnRetorno = True
                            End If
                        End If
                    End If
                End If
            End If

            oLotoFacilRegas = Nothing
            strData = Nothing
            oSequence = Nothing
            oList = Nothing
            oListSeq = Nothing

            Return blnRetorno

        End Function

        ''' <summary>
        ''' Analisa se tem historico de concursos com 12 ocorrencias das 15 setadas.
        ''' </summary>
        ''' <param name="strSequence"></param>
        ''' <returns>True Se ocorrer alguma</returns>
        ''' <remarks></remarks>
        Private Function Analisa12Dezenas(ByVal strSequence As String) As Boolean

            Dim blnRetorno As Boolean
            Dim blnDado As Boolean
            Dim strArray As String()
            Dim oVerify As Data.Combinacoes
            Dim lstCombinado As List(Of String)
            Dim oCombine As Combinatory
            Dim oLotoFacil As Struct.Combinacoes.LotoFacil

            'criando objetos
            oCombine = New Combinatory
            oVerify = New Data.Combinacoes

            'inicando as variaveis
            blnDado = False
            blnRetorno = False
            lstCombinado = oCombine.CombinarValores(strSequence, 12)

            For Each strValor As String In lstCombinado

                oLotoFacil = New Struct.Combinacoes.LotoFacil
                strArray = strValor.Split(","c)
                oLotoFacil.Dezena01 = CInt(strArray(0))
                oLotoFacil.Dezena02 = CInt(strArray(1))
                oLotoFacil.Dezena03 = CInt(strArray(2))
                oLotoFacil.Dezena04 = CInt(strArray(3))
                oLotoFacil.Dezena05 = CInt(strArray(4))
                oLotoFacil.Dezena06 = CInt(strArray(5))
                oLotoFacil.Dezena07 = CInt(strArray(6))
                oLotoFacil.Dezena08 = CInt(strArray(7))
                oLotoFacil.Dezena09 = CInt(strArray(8))
                oLotoFacil.Dezena10 = CInt(strArray(9))
                oLotoFacil.Dezena11 = CInt(strArray(10))
                oLotoFacil.Dezena12 = CInt(strArray(11))

                blnDado = oVerify.Verifica12NaLotoFacil(oLotoFacil)
                'se ja tem, sai nem precisa analisar o resto
                If blnDado Then
                    blnRetorno = True
                    Exit For
                End If
            Next

            'destruindo objetos
            oCombine = Nothing
            oLotoFacil = Nothing
            oVerify = Nothing
            strArray = Nothing
            lstCombinado = Nothing

            Return blnRetorno

        End Function

        ''' <summary>
        ''' Analisa se tem historico de concursos com 13 ocorrencias das 15 setadas.
        ''' </summary>
        ''' <param name="strSequence"></param>
        ''' <returns>True Se ocorrer alguma</returns>
        ''' <remarks></remarks>
        Private Function Analisa13Dezenas(ByVal strSequence As String) As Boolean

            Dim blnRetorno As Boolean
            Dim blnDado As Boolean
            Dim strArray As String()
            Dim oVerify As Data.Combinacoes
            Dim lstCombinado As List(Of String)
            Dim oCombine As Combinatory
            Dim oLotoFacil As Struct.Combinacoes.LotoFacil

            'criando objetos
            oCombine = New Combinatory
            oVerify = New Data.Combinacoes

            'inicando as variaveis
            blnDado = False
            blnRetorno = False
            lstCombinado = oCombine.CombinarValores(strSequence, 13)

            For Each strValor As String In lstCombinado

                oLotoFacil = New Struct.Combinacoes.LotoFacil
                strArray = strValor.Split(","c)
                oLotoFacil.Dezena01 = CInt(strArray(0))
                oLotoFacil.Dezena02 = CInt(strArray(1))
                oLotoFacil.Dezena03 = CInt(strArray(2))
                oLotoFacil.Dezena04 = CInt(strArray(3))
                oLotoFacil.Dezena05 = CInt(strArray(4))
                oLotoFacil.Dezena06 = CInt(strArray(5))
                oLotoFacil.Dezena07 = CInt(strArray(6))
                oLotoFacil.Dezena08 = CInt(strArray(7))
                oLotoFacil.Dezena09 = CInt(strArray(8))
                oLotoFacil.Dezena10 = CInt(strArray(9))
                oLotoFacil.Dezena11 = CInt(strArray(10))
                oLotoFacil.Dezena12 = CInt(strArray(11))
                oLotoFacil.Dezena13 = CInt(strArray(12))

                blnDado = oVerify.Verifica13NaLotoFacil(oLotoFacil)
                'se ja tem, sai nem precisa analisar o resto
                If blnDado Then
                    blnRetorno = True
                    Exit For
                End If
            Next

            'destruindo objetos
            oCombine = Nothing
            oLotoFacil = Nothing
            oVerify = Nothing
            strArray = Nothing
            lstCombinado = Nothing

            Return blnRetorno

        End Function

        ''' <summary>
        ''' Analisa se tem historico de concursos com 14 ocorrencias das 15 setadas.
        ''' </summary>
        ''' <param name="strSequence"></param>
        ''' <returns>True Se ocorrer alguma</returns>
        ''' <remarks></remarks>
        Private Function Analisa14Dezenas(ByVal strSequence As String) As Boolean

            Dim blnRetorno As Boolean
            Dim blnDado As Boolean
            Dim strArray As String()
            Dim oVerify As Data.Combinacoes
            Dim lstCombinado As List(Of String)
            Dim oCombine As Combinatory
            Dim oLotoFacil As Struct.Combinacoes.LotoFacil

            'criando objetos
            oCombine = New Combinatory
            oVerify = New Data.Combinacoes

            'inicando as variaveis
            blnDado = False
            blnRetorno = False
            lstCombinado = oCombine.CombinarValores(strSequence, 14)

            For Each strValor As String In lstCombinado

                oLotoFacil = New Struct.Combinacoes.LotoFacil
                strArray = strValor.Split(","c)
                oLotoFacil.Dezena01 = CInt(strArray(0))
                oLotoFacil.Dezena02 = CInt(strArray(1))
                oLotoFacil.Dezena03 = CInt(strArray(2))
                oLotoFacil.Dezena04 = CInt(strArray(3))
                oLotoFacil.Dezena05 = CInt(strArray(4))
                oLotoFacil.Dezena06 = CInt(strArray(5))
                oLotoFacil.Dezena07 = CInt(strArray(6))
                oLotoFacil.Dezena08 = CInt(strArray(7))
                oLotoFacil.Dezena09 = CInt(strArray(8))
                oLotoFacil.Dezena10 = CInt(strArray(9))
                oLotoFacil.Dezena11 = CInt(strArray(10))
                oLotoFacil.Dezena12 = CInt(strArray(11))
                oLotoFacil.Dezena13 = CInt(strArray(12))
                oLotoFacil.Dezena14 = CInt(strArray(13))

                blnDado = oVerify.Verifica14NaLotoFacil(oLotoFacil)
                'se ja tem, sai nem precisa analisar o resto
                If blnDado Then
                    blnRetorno = True
                    Exit For
                End If
            Next

            'destruindo objetos
            oCombine = Nothing
            oLotoFacil = Nothing
            oVerify = Nothing
            strArray = Nothing
            lstCombinado = Nothing

            Return blnRetorno

        End Function

        ''' <summary>
        ''' Analisa se tem historico de concursos com 15 ocorrencias das 15 setadas.
        ''' </summary>
        ''' <param name="strSequence"></param>
        ''' <returns>True Se ocorrer alguma</returns>
        ''' <remarks></remarks>
        Private Function Analisa15Dezenas(ByVal strSequence As String) As Boolean

            Dim blnRetorno As Boolean
            Dim blnDado As Boolean
            Dim strArray As String()
            Dim oVerify As Data.Combinacoes
            Dim oLotoFacil As Struct.Combinacoes.LotoFacil

            'criando objetos
            oVerify = New Data.Combinacoes

            'inicando as variaveis
            blnDado = False
            blnRetorno = False

            oLotoFacil = New Struct.Combinacoes.LotoFacil
            strArray = strSequence.Split(","c)
            oLotoFacil.Dezena01 = CInt(strArray(0))
            oLotoFacil.Dezena02 = CInt(strArray(1))
            oLotoFacil.Dezena03 = CInt(strArray(2))
            oLotoFacil.Dezena04 = CInt(strArray(3))
            oLotoFacil.Dezena05 = CInt(strArray(4))
            oLotoFacil.Dezena06 = CInt(strArray(5))
            oLotoFacil.Dezena07 = CInt(strArray(6))
            oLotoFacil.Dezena08 = CInt(strArray(7))
            oLotoFacil.Dezena09 = CInt(strArray(8))
            oLotoFacil.Dezena10 = CInt(strArray(9))
            oLotoFacil.Dezena11 = CInt(strArray(10))
            oLotoFacil.Dezena12 = CInt(strArray(11))
            oLotoFacil.Dezena13 = CInt(strArray(12))
            oLotoFacil.Dezena14 = CInt(strArray(13))
            oLotoFacil.Dezena15 = CInt(strArray(14))

            blnDado = oVerify.Verifica15NaLotoFacil(oLotoFacil)
            'se ja tem, sai nem precisa analisar o resto
            If blnDado Then
                blnRetorno = True
            End If

            'destruindo objetos
            oLotoFacil = Nothing
            oVerify = Nothing
            strArray = Nothing

            Return blnRetorno

        End Function

        ''' <summary>
        ''' Gera n milhares de combinações da Lotofácil. Excluindo sequencias
        ''' repetidas e dados de concursos.
        ''' Inicialmente vamos remover apenas dados que existam exatamente em concursos,
        ''' </summary>
        ''' <returns>List(Of String) das Dezenas</returns>
        ''' <remarks></remarks>
        Public Function CombinarValoresLotoFacil() As List(Of String)

            Dim strElementos As String
            Dim shtCombinacao_N As Short
            Dim shtCombinacao_P As Short
            Dim dblCombinacao As Double
            Dim strCombinacao As String
            Dim shtContador As Short
            Dim shtPtr As Short
            Dim shtNivel As Short
            Dim shtOffSet As Short
            Dim lstCombinacoes As New List(Of String)
            Dim aStrElementos() As String
            Dim aShtPtr() As Short
            Dim strValues As String

            'monta a sequencia da mega sena de todas as dezenas
            strValues = ""
            For intCont As Integer = 1 To 25
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

            'lotofácil = 16
            shtCombinacao_N = CShort(UBound(aStrElementos))
            shtCombinacao_P = 15

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

                'If dblCombinacao Mod 10000 = 0 Then
                '    Debug.Print(dblCombinacao.ToString + " - " + lstCombinacoes.Count.ToString)
                'End If

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

            Return lstCombinacoes

        End Function

    End Class

End Namespace