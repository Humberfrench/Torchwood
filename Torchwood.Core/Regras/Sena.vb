Imports Torchwood.Struct.Combinacoes
Namespace Business.Regras
    Public Class Senas

#Region "Regras para sequencias unitarias um a um e algumas servem para n a n"
        ''' <summary>
        ''' Analisa Todas as Regras impostas. 
        ''' Para a Lista de Dezenas poder Passar, deve ser todas negados, 
        ''' ou seja retornar false em todas as análises
        ''' </summary>
        ''' <param name="oList">Lista das Dezenas para analisar</param>
        ''' <returns>Booleano</returns>
        ''' <remarks></remarks>
        Public Function AnalisarRegrasUnitarias(ByVal oList As IList(Of Integer)) As Boolean

            If Not AnalisaRepeticoes3(oList) Then
                If Not AnalisaRepeticoes4(oList) Then
                    If Not AnalisaRepeticoes5(oList) Then
                        If Not AnalisaRepeticoes6(oList) Then
                            If Not AnalisaRepeticoesUnitarias(oList, 0) Then
                                If Not AnalisaRepeticoesUnitarias(oList, 1) Then
                                    If Not AnalisaRepeticoesUnitarias(oList, 2) Then
                                        If Not AnalisaRepeticoesUnitarias(oList, 3) Then
                                            If Not AnalisaRepeticoesUnitarias(oList, 4) Then
                                                If Not AnalisaRepeticoesUnitarias(oList, 5) Then
                                                    If Not AnalisaRepeticoesUnitarias(oList, 6) Then
                                                        If Not AnalisaRepeticoesUnitarias(oList, 7) Then
                                                            If Not AnalisaRepeticoesUnitarias(oList, 8) Then
                                                                If Not AnalisaRepeticoesUnitarias(oList, 9) Then
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
                Else
                    Return True
                End If
            Else
                Return True
            End If

        End Function

        ''' <summary>
        ''' Analisa regra de repeticoes para dezenas de sequencias com 6 itens
        ''' </summary>
        ''' <param name="oList">Lista das ocorrencias</param>
        ''' <returns>Booleano caso aconteça</returns>
        ''' <remarks></remarks>
        Public Function AnalisaRepeticoes6(ByVal oList As IList(Of Integer)) As Boolean

            Dim bln6Rept As Boolean = False

            'regra de 6 repeticoes 
            For Each intValue As Integer In oList
                If intValue = 6 Then
                    bln6Rept = True
                End If
            Next

            If bln6Rept Then
                Return True
            Else
                Return False
            End If

        End Function

        ''' <summary>
        ''' Analisa regra de repeticoes para dezenas de sequencias de quinas na Sena
        ''' </summary>
        ''' <param name="oList">Lista das ocorrencias</param>
        ''' <returns>Booleano caso aconteça</returns>
        ''' <remarks></remarks>
        Public Function AnalisaRepeticoes5(ByVal oList As IList(Of Integer)) As Boolean

            Dim bln5Rept As Boolean = False

            'regra de 6 repeticoes 
            For Each intValue As Integer In oList
                If intValue = 5 Then
                    bln5Rept = True
                End If
            Next

            If bln5Rept Then
                Return True
            Else
                Return False
            End If

        End Function

        ''' <summary>
        ''' Analisa regra de repeticoes para dezenas de sequencias de quadras na Sena
        ''' </summary>
        ''' <param name="oList">Lista das ocorrencias</param>
        ''' <returns>Booleano caso aconteça</returns>
        ''' <remarks></remarks>
        Public Function AnalisaRepeticoes4(ByVal oList As IList(Of Integer)) As Boolean

            Dim bln4Rept As Boolean = False

            For Each intValue As Integer In oList
                If intValue = 4 Then
                    bln4Rept = True
                End If
            Next

            If bln4Rept Then
                Return True
            Else
                Return False
            End If

        End Function

        ''' <summary>
        ''' Analisa regra de repeticoes para dezenas de triplas, dois ternos separados
        ''' </summary>
        ''' <param name="oList">Lista das ocorrencias</param>
        ''' <returns>Booleando caso aconteça</returns>
        ''' <remarks></remarks>
        Public Function AnalisaRepeticoes3(ByVal oList As IList(Of Integer)) As Boolean

            Dim intCont As Integer = 0
            Dim bln3Rept As Boolean = False

            'regra de 3 repeticoes
            For Each intValue As Integer In oList
                If intValue = 3 Then
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
        ''' Analisa regra de repeticoes para dezenas de sequencias com unidades ou seja 10, 20, 30, 40, 11,21,31,...
        ''' </summary>
        ''' <param name="oList">Lista das ocorrencias</param>
        ''' <returns>Booleando caso aconteça</returns>
        ''' <remarks></remarks>
        Public Function AnalisaRepeticoesUnitarias(ByVal oList As IList(Of Integer), ByVal intUnidade As Integer) As Boolean

            Dim bln10Rept As Boolean = False
            Dim intResto As Integer = 0
            Dim intCont As Integer = 0

            'regra de 8 repeticoes com 7 repeticoes
            'pegar as dezenas provenientes e analisar se tem resto igual a inidade
            For Each intValue As Integer In oList
                If intValue Mod 10 = intUnidade Then
                    intCont = intCont + 1
                End If
            Next

            If intCont >= 5 Then
                Return True
            Else
                Return False
            End If

        End Function

#End Region

#Region "Regras para sequencias N, N a N"

        ''' <summary>
        ''' Análise geral de todas as regras duo a duo
        ''' </summary>
        ''' <param name="oList">lista das sequencias ja analisadas</param>
        ''' <returns>Boolean se o set de dezena está ok</returns>
        ''' <remarks></remarks>
        Public Function AnalisaRegrasNbyN(ByVal oList As IList(Of Integer)) As Boolean

            If Not AnalisaRepeticoes3(oList) Then
                If Not AnalisaRepeticoes4(oList) Then
                    If Not AnalisaRepeticoes5(oList) Then
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

        End Function

#End Region

    End Class
End Namespace
