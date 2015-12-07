Namespace Business
    Public Class Sequences
        Implements ISequences

#Region "Sequencias Simples"

        ''' <summary>
        ''' Faz a verificaçãodas sequencias de dados. Dentro do método verifica
        ''' as seuqencias e grava os tipos se são de 2, 3, 4, etc numeros sequenciais
        ''' </summary>
        ''' <param name="lstNumber">Dezenas para serem anlalisadas</param>
        ''' <param name="indiceNumber">Posição da Sequencia, de onde começa</param>
        ''' <returns>Tipo ReturnData</returns>
        ''' <remarks></remarks>
        Friend Function VerificaSequencias(ByRef lstNumber As IList(Of Integer), _
                                           ByRef indiceNumber As Integer) As ReturnData Implements ISequences.VerificaSequencias

            Dim intValor As Integer
            Dim oReturn As ReturnData
            Dim intNextNumber As Integer
            Dim intOccor As Integer
            Dim intContador As Integer
            Dim intUltimoItem As Integer

            'contador de ocorrencias.
            'é a quantidade de valores que um grupo de sequencia tem
            'exemplo um numero unico é 1, se a sequencia é 10, 11 retorna 2
            'se a sequencia é 11,12,13 retorna 3.
            intOccor = 1

            'marca o ponto de retorno, como sendo o ultimo indice do array.
            'Pois, se acabar a repeticao, retorna o indice atual do array.
            intUltimoItem = lstNumber.Count - 1

            'looop
            For intContador = indiceNumber To intUltimoItem
                'seto o valor comparador
                intValor = lstNumber(intContador)
                'o valor somado mais um.
                intNextNumber = intValor + 1
                'verifico se o indice é maior.
                If intUltimoItem >= intContador + 1 Then
                    'compara se o atual, somado mais um é igual ao ao posterior
                    If (intNextNumber = lstNumber(intContador + 1)) Then
                        'resposta positiva, soma mais um na ocorrencia
                        intOccor = intOccor + 1
                    Else
                        'não é. fim da sequencia.
                        'retorna o indice atual para contar na proxima
                        'passa para o proximo ser analizado se nao continua do ultimo
                        intUltimoItem = intContador + 1
                        Exit For
                    End If
                Else
                    'não é. fim da sequencia.
                    'retorna o indice atual para contar na proxima
                    'passa para o proximo ser analizado se nao continua do ultimo
                    intUltimoItem = intContador + 1
                    Exit For
                End If
            Next

            'retorno.
            oReturn = New ReturnData(intOccor, intUltimoItem)
            Return oReturn

        End Function

        ''' <summary>
        ''' Obtem todas as sequencias, trabalha em conjunto com o método VerificaSequencias
        ''' que faz verificações unitárias, e devolve a este, que organiza a informação e segue
        ''' analisando as dezenas seguintes até finalizar a lista
        ''' </summary>
        ''' <param name="lstSequencia">Lista de Dezenas</param>
        ''' <returns>Lista contendo objetos do tipo inteiro mostrando a forma de sequencias
        ''' Exemplo 3,4,1,1,1,1,2 onde temos uma sequencia de 3, depois de 4, várias dezenas
        ''' independentes e depois uma sequencia de dois</returns>
        ''' <remarks></remarks>
        Function GetSequences(ByVal lstSequencia As IList(Of Integer)) As IList(Of Integer) Implements ISequences.GetSequences

            Dim lstReturn As IList(Of Integer) 'array das dezenas
            Dim intPontoInicial As Integer 'marca do ponto inicial para proxima analise
            Dim oReturn As ReturnData

            lstReturn = New List(Of Integer)
            intPontoInicial = 0

            'loop de analize
            'se o retorno for menor que a qtde de indices totais do array, faz mais analises
            Do While intPontoInicial < lstSequencia.Count
                'analisa a sequencia
                'VerificaSequencias(arrSeq(0), arrSeq, intPontoInicial, intRetornoQtde, intRetornoPonto)
                oReturn = VerificaSequencias(lstSequencia, intPontoInicial)
                'grava o retorno de qtde de itens da sequencia
                lstReturn.Add(oReturn.Ocorrencias)
                'remarca o ponto inicial, para proxima verifiacao
                intPontoInicial = oReturn.Posicao
            Loop

            oReturn = Nothing

            'devolvendo o resltado. no exemplo será visto 3;1;2 observe que a soma dos indices
            'das sequencias resulta no valor total do numero de indices do array.
            Return lstReturn

        End Function

#End Region

#Region "Sequencias dois a dois"

        ''' <summary>
        ''' Faz a mesma tarefa do método VerificaSequencias, mas com intervalos n a n de números.
        ''' </summary>
        ''' <param name="lstNumber">Dezenas para serem anlalisadas</param>
        ''' <param name="indiceNumber">Posição da Sequencia, de onde começa</param>
        ''' <param name="intIntervalo">Intervalo a somar na sequencia para verificar</param>
        ''' <returns>Tipo ReturnData</returns>
        ''' <remarks></remarks>
        Friend Function VerificaSequenciasNbyN(ByRef lstNumber As IList(Of Integer), _
                                               ByRef indiceNumber As Integer, _
                                               ByRef intIntervalo As Integer) As ReturnData Implements ISequences.VerificaSequenciasNbyN

            Dim intValor As Integer
            Dim oReturn As ReturnData
            Dim intNextNumber As Integer
            Dim intOccor As Integer
            Dim intContador As Integer
            Dim intUltimoItem As Integer

            'contador de ocorrencias.
            'é a quantidade de valores que um grupo de sequencia tem
            'exemplo um numero unico é 1, se a sequencia é 10, 11 retorna 2
            'se a sequencia é 11,12,13 retorna 3.
            intOccor = 1

            'marca o ponto de retorno, como sendo o ultimo indice do array.
            'Pois, se acabar a repeticao, retorna o indice atual do array.
            intUltimoItem = lstNumber.Count - 1

            'loop
            For intContador = indiceNumber To intUltimoItem
                'seto o valor comparador
                intValor = lstNumber(intContador)
                'o valor somado mais intIntervalo (n a n).
                intNextNumber = intValor + intIntervalo
                'verifico se o indice é maior.
                If intUltimoItem >= intContador + 1 Then
                    'compara se o atual, somado mais um é igual ao ao posterior
                    If (intNextNumber = lstNumber(intContador + 1)) Then
                        'resposta positiva, soma mais um na ocorrencia
                        intOccor = intOccor + 1
                    Else
                        'não é. fim da sequencia.
                        'retorna o indice atual para contar na proxima
                        'passa para o proximo ser analizado se nao continua do ultimo
                        intUltimoItem = intContador + 1
                        Exit For
                    End If
                Else
                    'não é. fim da sequencia.
                    'retorna o indice atual para contar na proxima
                    'passa para o proximo ser analizado se nao continua do ultimo
                    intUltimoItem = intContador + 1
                    Exit For
                End If
            Next

            'retorno.
            oReturn = New ReturnData(intOccor, intUltimoItem)
            Return oReturn

        End Function

        ''' <summary>
        ''' Faz a mesma tarefa do método GetSequences, mas com intervalos n a n de números.
        ''' </summary>
        ''' <param name="lstSequencia">Lista de Dezenas</param>
        ''' <param name="intIntervalo">Intervalo a somar na sequencia para verificar</param>
        ''' <returns>Lista contendo objetos do tipo inteiro mostrando a forma de sequencias
        ''' Exemplo 3,4,1,1,1,1,2 onde temos uma sequencia de 3, depois de 4, várias dezenas
        ''' independentes e depois uma sequencia de dois</returns>
        ''' <remarks></remarks>
        Function GetSequencesNbyN(ByVal lstSequencia As IList(Of Integer), _
                                  ByVal intIntervalo As Integer) As IList(Of Integer) Implements ISequences.GetSequencesNbyN

            Dim lstReturn As IList(Of Integer) 'array das dezenas
            Dim intPontoInicial As Integer 'marca do ponto inicial para proxima analise
            Dim oReturn As ReturnData

            lstReturn = New List(Of Integer)
            intPontoInicial = 0

            'loop de analize
            'se o retorno for menor que a qtde de indices totais do array, faz mais analises
            Do While intPontoInicial < lstSequencia.Count
                'analisa a sequencia
                'VerificaSequencias(arrSeq(0), arrSeq, intPontoInicial, intRetornoQtde, intRetornoPonto)
                oReturn = VerificaSequenciasNbyN(lstSequencia, intPontoInicial, intIntervalo)
                'grava o retorno de qtde de itens da sequencia
                lstReturn.Add(oReturn.Ocorrencias)
                'remarca o ponto inicial, para proxima verifiacao
                intPontoInicial = oReturn.Posicao
            Loop

            oReturn = Nothing

            'devolvendo o resltado. no exemplo será visto 3;1;2 observe que a soma dos indices
            'das sequencias resulta no valor total do numero de indices do array.
            Return lstReturn

        End Function

#End Region

#Region "Conversores"

        ''' <summary>
        ''' Converte uma string separada por algum separador como "," ou ";" para um tipo IList(Integer)
        ''' </summary>
        ''' <param name="strValor">string separada por algum separador como "," ou ";"</param>
        ''' <returns>IList(Integer)</returns>
        ''' <remarks></remarks>
        Public Function Convert(ByVal strValor As String) As IList(Of Integer) Implements ISequences.Convert

            Dim lstReturn As IList(Of Integer) 'array das dezenas
            Dim aList As String()

            strValor = strValor.Replace(" ", "")
            strValor = strValor.Replace(",", ";")
            strValor = strValor.Replace(".", ";")
            strValor = strValor.Replace("-", ";")

            aList = strValor.Split(";"c)

            lstReturn = New List(Of Integer)
            For intCont As Integer = LBound(aList) To UBound(aList)
                lstReturn.Add(CInt(aList(intCont)))
            Next

            Return lstReturn

        End Function

        ''' <summary>
        ''' Converte dados de um objeto de Mega Sena para IList(Integer)
        ''' </summary>
        ''' <param name="oSena"></param>
        ''' <returns>IList(Integer)</returns>
        ''' <remarks></remarks>
        Function Convert(ByVal oSena As Struct.Combinacoes.MegaSena) As IList(Of Integer) Implements ISequences.Convert

            Dim lstReturn As IList(Of Integer) 'array das dezenas

            lstReturn = New List(Of Integer)
            lstReturn.Add(oSena.Dezena01)
            lstReturn.Add(oSena.Dezena02)
            lstReturn.Add(oSena.Dezena03)
            lstReturn.Add(oSena.Dezena04)
            lstReturn.Add(oSena.Dezena05)
            lstReturn.Add(oSena.Dezena06)

            Return lstReturn

        End Function

        ''' <summary>
        ''' Converte dados de um objeto de Dupla Sena para IList(Integer)
        ''' </summary>
        ''' <param name="oSena"></param>
        ''' <returns>IList(Integer)</returns>
        ''' <remarks></remarks>
        Function Convert(ByVal oSena As Struct.Combinacoes.DuplaSena) As IList(Of Integer) Implements ISequences.Convert

            Dim lstReturn As IList(Of Integer) 'array das dezenas

            lstReturn = New List(Of Integer)
            lstReturn.Add(oSena.Dezena01)
            lstReturn.Add(oSena.Dezena02)
            lstReturn.Add(oSena.Dezena03)
            lstReturn.Add(oSena.Dezena04)
            lstReturn.Add(oSena.Dezena05)
            lstReturn.Add(oSena.Dezena06)

            Return lstReturn

        End Function

        ''' <summary>
        ''' Converte dados de um objeto de LotoFácil para IList(Integer)
        ''' </summary>
        ''' <param name="oLoto"></param>
        ''' <returns>IList(Integer)</returns>
        ''' <remarks></remarks>
        Function Convert(ByVal oLoto As Struct.Combinacoes.LotoFacil) As IList(Of Integer) Implements ISequences.Convert

            Dim lstReturn As IList(Of Integer) 'array das dezenas

            lstReturn = New List(Of Integer)
            lstReturn.Add(oLoto.Dezena01)
            lstReturn.Add(oLoto.Dezena02)
            lstReturn.Add(oLoto.Dezena03)
            lstReturn.Add(oLoto.Dezena04)
            lstReturn.Add(oLoto.Dezena05)
            lstReturn.Add(oLoto.Dezena06)
            lstReturn.Add(oLoto.Dezena07)
            lstReturn.Add(oLoto.Dezena08)
            lstReturn.Add(oLoto.Dezena09)
            lstReturn.Add(oLoto.Dezena10)
            lstReturn.Add(oLoto.Dezena11)
            lstReturn.Add(oLoto.Dezena12)
            lstReturn.Add(oLoto.Dezena13)
            lstReturn.Add(oLoto.Dezena14)
            lstReturn.Add(oLoto.Dezena15)

            Return lstReturn

        End Function

        ''' <summary>
        ''' Converte dados de um objeto de LotoMania para IList(Integer)
        ''' </summary>
        ''' <param name="oLoto"></param>
        ''' <returns>IList(Integer)</returns>
        ''' <remarks></remarks>
        Function Convert(ByVal oLoto As Struct.Combinacoes.LotoMania) As IList(Of Integer) Implements ISequences.Convert

            Dim lstReturn As IList(Of Integer) 'array das dezenas

            lstReturn = New List(Of Integer)
            lstReturn.Add(oLoto.Dezena01)
            lstReturn.Add(oLoto.Dezena02)
            lstReturn.Add(oLoto.Dezena03)
            lstReturn.Add(oLoto.Dezena04)
            lstReturn.Add(oLoto.Dezena05)
            lstReturn.Add(oLoto.Dezena06)
            lstReturn.Add(oLoto.Dezena07)
            lstReturn.Add(oLoto.Dezena08)
            lstReturn.Add(oLoto.Dezena09)
            lstReturn.Add(oLoto.Dezena10)
            lstReturn.Add(oLoto.Dezena11)
            lstReturn.Add(oLoto.Dezena12)
            lstReturn.Add(oLoto.Dezena13)
            lstReturn.Add(oLoto.Dezena14)
            lstReturn.Add(oLoto.Dezena15)
            lstReturn.Add(oLoto.Dezena16)
            lstReturn.Add(oLoto.Dezena17)
            lstReturn.Add(oLoto.Dezena18)
            lstReturn.Add(oLoto.Dezena10)
            lstReturn.Add(oLoto.Dezena20)

            Return lstReturn

        End Function

        ''' <summary>
        ''' Converte dados de um objeto de Quina para IList(Integer)
        ''' </summary>
        ''' <param name="oQuina"></param>
        ''' <returns>IList(Integer)</returns>
        ''' <remarks></remarks>
        Function Convert(ByVal oQuina As Struct.Combinacoes.Quina) As IList(Of Integer) Implements ISequences.Convert

            Dim lstReturn As IList(Of Integer) 'array das dezenas

            lstReturn = New List(Of Integer)
            lstReturn.Add(oQuina.Dezena01)
            lstReturn.Add(oQuina.Dezena02)
            lstReturn.Add(oQuina.Dezena03)
            lstReturn.Add(oQuina.Dezena04)
            lstReturn.Add(oQuina.Dezena05)

            Return lstReturn

        End Function

#End Region

    End Class

End Namespace
