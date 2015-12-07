Imports Torchwood.Struct.Combinacoes
Namespace Business.Regras
    Public Class LotoFacil

#Region "Regras de Sequencias"

        ''' <summary>
        ''' Analise sintética de todas as regras da Lotofácil
        ''' </summary>
        ''' <param name="oList">Lista de dados das sequencias já obtidas</param>
        ''' <returns>booleano, onde true é permitido o uso</returns>
        ''' <remarks></remarks>
        Public Function AnalisarRegras(ByVal oList As IList(Of Integer)) As Boolean

            If Not AnalisaRepeticoesMaiorQue9(oList) Then
                If Not AnalisaRepeticoes78(oList) Then
                    If Not AnalisaRepeticoes77(oList) Then
                        If Not AnalisaRepeticoes96(oList) Then
                            If Not AnalisaRepeticoes86(oList) Then
                                If Not AnalisaRepeticoes555(oList) Then
                                    Return False
                                Else
                                    Return True
                                End If
                            Else
                                Return True
                            End If
                        Else
                            Return True
                        End If
                    Else
                        Return True
                    End If
                Else
                    Return True
                End If
            Else
                Return True
            End If

        End Function

        ''' <summary>
        ''' Analisa regra de repeticoes para dezenas de sequencias com 7 e 8 itens
        ''' </summary>
        ''' <param name="oList">Lista das ocorrencias</param>
        ''' <returns>Booleando caso aconteça</returns>
        ''' <remarks></remarks>
        Public Function AnalisaRepeticoes78(ByVal oList As IList(Of Integer)) As Boolean

            Dim bln7Rept As Boolean = False
            Dim bln8Rept As Boolean = False

            'regra de 8 repeticoes com 7 repeticoes
            For Each intValue As Integer In oList
                If intValue = 8 Then
                    bln8Rept = True
                End If
                If intValue = 7 Then
                    bln7Rept = True
                End If
            Next

            If bln7Rept And bln8Rept Then
                Return True
            Else
                Return False
            End If

        End Function

        ''' <summary>
        ''' Analisa regra de repeticoes para dezenas de sequencias com 7 e 7 itens 
        ''' Duas sequencias de 7 e uma ddezena qualquer
        ''' </summary>
        ''' <param name="oList">Lista das ocorrencias</param>
        ''' <returns>Booleando caso aconteça</returns>
        ''' <remarks></remarks>
        Public Function AnalisaRepeticoes77(ByVal oList As IList(Of Integer)) As Boolean

            Dim intCont As Integer = 0
            Dim bln8Rept As Boolean = False

            'regra de 8 repeticoes com 7 repeticoes
            For Each intValue As Integer In oList
                If intValue = 7 Then
                    intCont = intCont + 1
                End If
            Next

            If intCont > 1 Then
                Return True
            Else
                Return False
            End If

        End Function

        ''' <summary>
        ''' Analisa regra de repeticoes para dezenas de sequencias com 5 e 5 e 5 de novo.
        ''' Três sequencias de 5. Tal sequencia já ocorreu uma vez no concurso 419 do lotofacil
        ''' </summary>
        ''' <param name="oList">Lista das ocorrencias</param>
        ''' <returns>Booleando caso aconteça</returns>
        ''' <remarks></remarks>
        Public Function AnalisaRepeticoes555(ByVal oList As IList(Of Integer)) As Boolean

            Dim intCont As Integer = 0
            Dim bln8Rept As Boolean = False

            'regra de 8 repeticoes com 5 repeticoes
            For Each intValue As Integer In oList
                If intValue = 5 Then
                    intCont = intCont + 1
                End If
            Next

            If intCont > 2 Then
                Return True
            Else
                Return False
            End If

        End Function

        ''' <summary>
        ''' Analisa regra de repeticoes para dezenas de sequencias com 8 e 6 itens 
        ''' </summary>
        ''' <param name="oList">Lista das ocorrencias</param>
        ''' <returns>Booleando caso aconteça</returns>
        ''' <remarks></remarks>
        Public Function AnalisaRepeticoes86(ByVal oList As IList(Of Integer)) As Boolean

            Dim bln6Rept As Boolean = False
            Dim bln8Rept As Boolean = False

            'regra de 8 repeticoes com 7 repeticoes
            For Each intValue As Integer In oList
                If intValue = 8 Then
                    bln8Rept = True
                End If
                If intValue = 6 Then
                    bln6Rept = True
                End If
            Next

            If bln6Rept And bln8Rept Then
                Return True
            Else
                Return False
            End If

        End Function

        ''' <summary>
        ''' Analisa regra de repeticoes para dezenas de sequencias com 9 e 6 itens 
        ''' </summary>
        ''' <param name="oList">Lista das ocorrencias</param>
        ''' <returns>Booleando caso aconteça</returns>
        ''' <remarks></remarks>
        Public Function AnalisaRepeticoes96(ByVal oList As IList(Of Integer)) As Boolean

            Dim bln6Rept As Boolean = False
            Dim bln9Rept As Boolean = False

            'regra de 9 repeticoes com 7 repeticoes
            For Each intValue As Integer In oList
                If intValue = 9 Then
                    bln9Rept = True
                End If
                If intValue = 6 Then
                    bln6Rept = True
                End If
            Next

            If bln6Rept And bln9Rept Then
                Return True
            Else
                Return False
            End If

        End Function

        ''' <summary>
        ''' Analisa regra de repeticoes para dezenas de sequencias com 9 itens 
        ''' </summary>
        ''' <param name="oList">Lista das ocorrencias</param>
        ''' <returns>Booleando caso aconteça</returns>
        ''' <remarks></remarks>
        Public Function AnalisaRepeticoesMaiorQue9(ByVal oList As IList(Of Integer)) As Boolean

            Dim blnRept As Boolean = False

            'regra de 9 repeticoes, ou maiores (10,11,12,13,14,15)
            For Each intValue As Integer In oList
                If intValue >= 8 Then
                    blnRept = True
                End If
            Next

            Return blnRept

        End Function

#End Region
    End Class
End Namespace
