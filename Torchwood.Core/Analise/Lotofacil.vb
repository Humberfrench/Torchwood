Namespace Analise
    Public Class Lotofacil

        Public Sub New()

        End Sub

        Public Function Obter() As List(Of String)
            Dim lstDados As List(Of String) = Nothing
            Dim oBusiness As Business.Combinacoes.LotoFacil = Nothing
            Dim oCoreSequence As Core.ISequences = Nothing
            Dim lstReturn As List(Of String) = Nothing
            Dim lstTempDados As List(Of Integer) = Nothing

            Try
                oBusiness = New Torchwood.Core.Business.Combinacoes.LotoFacil()
                oCoreSequence = New Core.Business.Sequences()
                lstReturn = New List(Of String)
                lstDados = oBusiness.CombinarValoresLotoFacil()

                For Each strCombinado As String In lstDados
                    lstTempDados = oCoreSequence.Convert(strCombinado).ToList()
                    If AnalisaRegras(lstTempDados) Then
                        lstReturn.Add(strCombinado)
                    End If
                Next

            Catch ex As Exception
                Throw ex
            End Try

            Return lstDados ' lstReturn
        End Function

        ''' <summary>
        ''' Analise das Regras 
        ''' Selecione as que tem no TOP 5 de Best Dezenas
        ''' Top 5 das Que tem nos Atrasos
        ''' Top 5 das que não dão
        ''' </summary>
        ''' <param name="lstDados"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function AnalisaRegras(lstDados As List(Of Integer)) As Boolean


        End Function

        Public Function AnalisaBest(lstDados As List(Of Integer)) As Boolean

            Dim oCore As Core.Statistics.GameStats = Nothing
            Dim lstTemp As List(Of Struct.BestDezenas) = Nothing
            Dim blnReturn As Boolean = False
            Dim intTop1 As Integer = 0

            Try
                oCore = New Core.Statistics.GameStats()
                lstTemp = oCore.GetBestDezenas()

                For Each intDado As Integer In lstDados
                    'lstDados.Contains()
                Next

            Catch ex As Exception
                blnReturn = False
                Throw ex
            Finally
                oCore = Nothing
            End Try

            Return blnReturn

        End Function

        Public Function AnalisaAtraso(lstDados As List(Of Integer)) As Boolean

            Dim oCore As Core.Statistics.GameStats
            Dim blnReturn As Boolean = False
            Try
                oCore = New Core.Statistics.GameStats()

            Catch ex As Exception
                blnReturn = False
                Throw ex
            Finally
                oCore = Nothing
            End Try

            Return blnReturn

        End Function

        Public Function AnalisaWorst(lstDados As List(Of Integer)) As Boolean

            Dim oCore As Core.Statistics.GameStats
            Dim blnReturn As Boolean = False
            Try
                oCore = New Core.Statistics.GameStats()

            Catch ex As Exception
                blnReturn = False
                Throw ex
            Finally
                oCore = Nothing
            End Try

            Return blnReturn

        End Function

    End Class

End Namespace
