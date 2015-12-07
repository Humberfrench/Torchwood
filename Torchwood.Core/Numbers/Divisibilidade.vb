Namespace Business
    ''' <summary>
    ''' Verificação de Divisibilidades
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Divisibilidade

        ''' <summary>
        ''' Verifica se o número é divisível por Dois
        ''' </summary>
        ''' <param name="intNumber">Número para verificar</param>
        ''' <returns>True: É divisivel
        ''' False: Não é divisível</returns>
        ''' <remarks></remarks>
        Public Function DivisivelPorDois(ByVal intNumber As Integer) As Boolean
            Return DivisivelPorN(intNumber, 2)
        End Function

        ''' <summary>
        ''' Verifica se o número é divisível por Três
        ''' </summary>
        ''' <param name="intNumber">Número para verificar</param>
        ''' <returns>True: É divisivel
        ''' False: Não é divisível</returns>
        ''' <remarks></remarks>
        Public Function DivisivelPorTres(ByVal intNumber As Integer) As Boolean
            Return DivisivelPorN(intNumber, 3)
        End Function

        ''' <summary>
        ''' Verifica se o número é divisível por Quatro
        ''' </summary>
        ''' <param name="intNumber">Número para verificar</param>
        ''' <returns>True: É divisivel
        ''' False: Não é divisível</returns>
        ''' <remarks></remarks>
        Public Function DivisivelPorQuatro(ByVal intNumber As Integer) As Boolean
            Return DivisivelPorN(intNumber, 3)
        End Function

        ''' <summary>
        ''' Verifica se o número é divisível por Cinco
        ''' </summary>
        ''' <param name="intNumber">Número para verificar</param>
        ''' <returns>True: É divisivel
        ''' False: Não é divisível</returns>
        ''' <remarks></remarks>
        Public Function DivisivelPorCinco(ByVal intNumber As Integer) As Boolean
            Return DivisivelPorN(intNumber, 5)
        End Function

        ''' <summary>
        ''' Verifica se o número é divisível por Seis
        ''' </summary>
        ''' <param name="intNumber">Número para verificar</param>
        ''' <returns>True: É divisivel
        ''' False: Não é divisível</returns>
        ''' <remarks></remarks>
        Public Function DivisivelPorSeis(ByVal intNumber As Integer) As Boolean
            Return DivisivelPorN(intNumber, 6)
        End Function

        ''' <summary>
        ''' Verifica se o número é divisível por Sete
        ''' </summary>
        ''' <param name="intNumber">Número para verificar</param>
        ''' <returns>True: É divisivel
        ''' False: Não é divisível</returns>
        ''' <remarks></remarks>
        Public Function DivisivelPorSete(ByVal intNumber As Integer) As Boolean
            Return DivisivelPorN(intNumber, 7)
        End Function

        ''' <summary>
        ''' Verifica se o número é divisível por Oito
        ''' </summary>
        ''' <param name="intNumber">Número para verificar</param>
        ''' <returns>True: É divisivel
        ''' False: Não é divisível</returns>
        ''' <remarks></remarks>
        Public Function DivisivelPorOito(ByVal intNumber As Integer) As Boolean
            Return DivisivelPorN(intNumber, 8)
        End Function

        ''' <summary>
        ''' Verifica se o número é divisível por Nove
        ''' </summary>
        ''' <param name="intNumber">Número para verificar</param>
        ''' <returns>True: É divisivel
        ''' False: Não é divisível</returns>
        ''' <remarks></remarks>
        Public Function DivisivelPorNove(ByVal intNumber As Integer) As Boolean
            Return DivisivelPorN(intNumber, 9)
        End Function

        ''' <summary>
        ''' Verifica se o número é divisível por Dez
        ''' </summary>
        ''' <param name="intNumber">Número para verificar</param>
        ''' <returns>True: É divisivel
        ''' False: Não é divisível</returns>
        ''' <remarks></remarks>
        Public Function DivisivelPorDez(ByVal intNumber As Integer) As Boolean
            Return DivisivelPorN(intNumber, 10)
        End Function

        ''' <summary>
        ''' Verifica se o número é divisível por Onze
        ''' </summary>
        ''' <param name="intNumber">Número para verificar</param>
        ''' <returns>True: É divisivel
        ''' False: Não é divisível</returns>
        ''' <remarks></remarks>
        Public Function DivisivelPorOnze(ByVal intNumber As Integer) As Boolean
            Return DivisivelPorN(intNumber, 11)
        End Function

        ''' <summary>
        ''' Verifica se o número é divisível por Doze
        ''' </summary>
        ''' <param name="intNumber">Número para verificar</param>
        ''' <returns>True: É divisivel
        ''' False: Não é divisível</returns>
        ''' <remarks></remarks>
        Public Function DivisivelPorDoze(ByVal intNumber As Integer) As Boolean
            Return DivisivelPorN(intNumber, 12)
        End Function

        ''' <summary>
        ''' Verifica se o número é divisível por Treze
        ''' </summary>
        ''' <param name="intNumber">Número para verificar</param>
        ''' <returns>True: É divisivel
        ''' False: Não é divisível</returns>
        ''' <remarks></remarks>
        Public Function DivisivelPorTreze(ByVal intNumber As Integer) As Boolean
            Return DivisivelPorN(intNumber, 13)
        End Function

        ''' <summary>
        ''' Verifica se o número é divisível por um número qualquer Chamado N
        ''' </summary>
        ''' <param name="intNumber">Número para verificar</param>
        ''' <param name="intDivisor">Divisor para ser efetuado a Divisão</param>
        ''' <returns>True: É divisivel
        ''' False: Não é divisível</returns>
        ''' <remarks></remarks>
        Protected Function DivisivelPorN(ByVal intNumber As Integer, _
                                         ByVal intDivisor As Integer) As Boolean

            If intDivisor = 0 Then
                Throw New Exceptions.ImpossibleCalc("Não é possível dividir números por Zero")
            End If

            If (intNumber Mod intDivisor) = 0 Then
                Return True
            Else
                Return False
            End If
        End Function


        Public Function ObterDivisores(ByVal intNumber As Integer) As List(Of Integer)

            Dim lstRetorno As List(Of Integer)
            Dim intTemp1 As Integer
            'Dim intTemp2 As Integer

            lstRetorno = New List(Of Integer)

            'obter divisiveis por 2
            intTemp1 = intNumber
            For intValor As Integer = 2 To 12
                If DivisivelPorN(intTemp1, intValor) Then
                    lstRetorno.Add(intTemp1)
                    If (intTemp1 <> intValor) Then
                        lstRetorno.Add(intValor)
                    End If
                    While DivisivelPorN(intTemp1, intValor)
                        intTemp1 = CInt(intTemp1 / intValor)
                        If DivisivelPorN(intTemp1, intValor) Then
                            lstRetorno.Add(intTemp1)
                        End If
                    End While
                End If
            Next
            If intTemp1 > 12 Then
                lstRetorno.Add(intTemp1)
            End If

            lstRetorno.Sort()
            Return lstRetorno

        End Function

    End Class
End Namespace
