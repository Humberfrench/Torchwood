Imports Consumer.Data
Imports Torchwood.Struct

Namespace Data
    Public Class Resultados
        Implements IDisposable
        Private strKey As String

        Private disposedValue As Boolean = False        ' To detect redundant calls

        Public Sub New()
            strKey = ""
        End Sub

        Public Sub New(ByVal pstrKey As String)

            Me.New()
            strKey = pstrKey

        End Sub

        ''' <summary>
        ''' Chave para a conexão com o banco
        ''' </summary>
        ''' <value>String</value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property Key() As String
            Get
                Return strKey
            End Get
            Set(ByVal value As String)
                strKey = value
            End Set
        End Property

        ''' <summary>
        ''' Obtem os Resultados da MegaSena
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetMegaSenaResults() As List(Of MegaSena)

            Dim dtResults As New DataTable
            Dim lstResultado As List(Of MegaSena)
            Dim oMega As MegaSena

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_get_resultados_mega_sena"

                    dtResults = cmdDados.GetDataTable

                    lstResultado = New List(Of MegaSena)
                    For Each dr As DataRow In dtResults.Rows
                        oMega = New MegaSena
                        oMega.Concurso = CInt(dr("nr_concurso"))
                        oMega.Data = CDate(dr("dt_concurso"))
                        oMega.Dezena01 = CInt(dr("nr_dezena1"))
                        oMega.Dezena02 = CInt(dr("nr_dezena2"))
                        oMega.Dezena03 = CInt(dr("nr_dezena3"))
                        oMega.Dezena04 = CInt(dr("nr_dezena4"))
                        oMega.Dezena05 = CInt(dr("nr_dezena5"))
                        oMega.Dezena06 = CInt(dr("nr_dezena6"))
                        lstResultado.Add(oMega)
                    Next
                    dtResults.Dispose()
                    dtResults = Nothing
                    oMega = Nothing

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    lstResultado = Nothing
                    oMega = Nothing
                    Throw ex
                End Try
            End Using

            Return lstResultado

        End Function

        ''' <summary>
        ''' Obtem os Resultados da Quina
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetQuinaResults() As List(Of Quina)

            Dim dtResults As New DataTable
            Dim lstResultado As List(Of Quina)
            Dim oQuina As Quina

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_get_resultados_quina"

                    dtResults = cmdDados.GetDataTable

                    lstResultado = New List(Of Quina)
                    For Each dr As DataRow In dtResults.Rows
                        oQuina = New Quina
                        oQuina.Concurso = CInt(dr("nr_concurso"))
                        oQuina.Data = CDate(dr("dt_concurso"))
                        oQuina.Dezena01 = CInt(dr("nr_dezena1"))
                        oQuina.Dezena02 = CInt(dr("nr_dezena2"))
                        oQuina.Dezena03 = CInt(dr("nr_dezena3"))
                        oQuina.Dezena04 = CInt(dr("nr_dezena4"))
                        oQuina.Dezena05 = CInt(dr("nr_dezena5"))
                        lstResultado.Add(oQuina)
                    Next
                    dtResults.Dispose()
                    dtResults = Nothing
                    oQuina = Nothing

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    lstResultado = Nothing
                    oQuina = Nothing
                    Throw ex
                End Try
            End Using

            Return lstResultado

        End Function

        ''' <summary>
        ''' Obtem os Resultados da DuplaSena Sorteio 1
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetDuplaSenaS1Results() As List(Of DuplaSena)

            Dim dtResults As New DataTable
            Dim lstResultado As List(Of DuplaSena)
            Dim oDuplaSena As DuplaSena

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_get_resultados_dupla_sena_s1"

                    dtResults = cmdDados.GetDataTable

                    lstResultado = New List(Of DuplaSena)
                    For Each dr As DataRow In dtResults.Rows
                        oDuplaSena = New DuplaSena
                        oDuplaSena.Concurso = CInt(dr("nr_concurso"))
                        oDuplaSena.Data = CDate(dr("dt_concurso"))
                        oDuplaSena.Dezena01 = CInt(dr("nr_dezena1"))
                        oDuplaSena.Dezena02 = CInt(dr("nr_dezena2"))
                        oDuplaSena.Dezena03 = CInt(dr("nr_dezena3"))
                        oDuplaSena.Dezena04 = CInt(dr("nr_dezena4"))
                        oDuplaSena.Dezena05 = CInt(dr("nr_dezena5"))
                        oDuplaSena.Dezena06 = CInt(dr("nr_dezena6"))
                        lstResultado.Add(oDuplaSena)
                    Next
                    dtResults.Dispose()
                    dtResults = Nothing
                    oDuplaSena = Nothing

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    lstResultado = Nothing
                    oDuplaSena = Nothing
                    Throw ex
                End Try
            End Using

            Return lstResultado

        End Function

        ''' <summary>
        ''' Obtem os Resultados da DuplaSena Sorteio 2
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetDuplaSenaS2Results() As List(Of DuplaSena)

            Dim dtResults As New DataTable
            Dim lstResultado As List(Of DuplaSena)
            Dim oDuplaSena As DuplaSena

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_get_resultados_dupla_sena_s2"

                    dtResults = cmdDados.GetDataTable

                    lstResultado = New List(Of DuplaSena)
                    For Each dr As DataRow In dtResults.Rows
                        oDuplaSena = New DuplaSena
                        oDuplaSena.Concurso = CInt(dr("nr_concurso"))
                        oDuplaSena.Data = CDate(dr("dt_concurso"))
                        oDuplaSena.Dezena01 = CInt(dr("nr_dezena1"))
                        oDuplaSena.Dezena02 = CInt(dr("nr_dezena2"))
                        oDuplaSena.Dezena03 = CInt(dr("nr_dezena3"))
                        oDuplaSena.Dezena04 = CInt(dr("nr_dezena4"))
                        oDuplaSena.Dezena05 = CInt(dr("nr_dezena5"))
                        oDuplaSena.Dezena06 = CInt(dr("nr_dezena6"))
                        lstResultado.Add(oDuplaSena)
                    Next
                    dtResults.Dispose()
                    dtResults = Nothing
                    oDuplaSena = Nothing

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    lstResultado = Nothing
                    oDuplaSena = Nothing
                    Throw ex
                End Try
            End Using

            Return lstResultado

        End Function

        ''' <summary>
        ''' Obtem os Resultados da LotoMania
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetLotoManiaResults() As List(Of LotoMania)

            Dim dtResults As New DataTable
            Dim lstResultado As List(Of LotoMania)
            Dim oLotoMania As LotoMania

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_get_resultados_lotomania"

                    dtResults = cmdDados.GetDataTable

                    lstResultado = New List(Of LotoMania)
                    For Each dr As DataRow In dtResults.Rows
                        oLotoMania = New LotoMania
                        oLotoMania.Concurso = CInt(dr("nr_concurso"))
                        oLotoMania.Data = CDate(dr("dt_concurso"))
                        oLotoMania.Dezena01 = CInt(dr("nr_dezena01"))
                        oLotoMania.Dezena02 = CInt(dr("nr_dezena02"))
                        oLotoMania.Dezena03 = CInt(dr("nr_dezena03"))
                        oLotoMania.Dezena04 = CInt(dr("nr_dezena04"))
                        oLotoMania.Dezena05 = CInt(dr("nr_dezena05"))
                        oLotoMania.Dezena06 = CInt(dr("nr_dezena06"))
                        oLotoMania.Dezena07 = CInt(dr("nr_dezena07"))
                        oLotoMania.Dezena08 = CInt(dr("nr_dezena08"))
                        oLotoMania.Dezena09 = CInt(dr("nr_dezena09"))
                        oLotoMania.Dezena10 = CInt(dr("nr_dezena10"))
                        oLotoMania.Dezena11 = CInt(dr("nr_dezena11"))
                        oLotoMania.Dezena12 = CInt(dr("nr_dezena12"))
                        oLotoMania.Dezena13 = CInt(dr("nr_dezena13"))
                        oLotoMania.Dezena14 = CInt(dr("nr_dezena14"))
                        oLotoMania.Dezena15 = CInt(dr("nr_dezena15"))
                        oLotoMania.Dezena16 = CInt(dr("nr_dezena16"))
                        oLotoMania.Dezena17 = CInt(dr("nr_dezena17"))
                        oLotoMania.Dezena18 = CInt(dr("nr_dezena18"))
                        oLotoMania.Dezena19 = CInt(dr("nr_dezena19"))
                        oLotoMania.Dezena20 = CInt(dr("nr_dezena20"))
                        lstResultado.Add(oLotoMania)
                    Next
                    dtResults.Dispose()
                    dtResults = Nothing
                    oLotoMania = Nothing

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    lstResultado = Nothing
                    oLotoMania = Nothing
                    Throw ex
                End Try
            End Using

            Return lstResultado

        End Function

        ''' <summary>
        ''' Obtem os Resultados da LotoFácil
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetLotoFacilResults() As List(Of LotoFacil)

            Dim dtResults As New DataTable
            Dim lstResultado As List(Of LotoFacil)
            Dim oLotoMania As LotoFacil

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_get_resultados_lotofacil"

                    dtResults = cmdDados.GetDataTable

                    lstResultado = New List(Of LotoFacil)
                    For Each dr As DataRow In dtResults.Rows
                        oLotoMania = New LotoFacil
                        oLotoMania.Concurso = CInt(dr("nr_concurso"))
                        oLotoMania.Data = CDate(dr("dt_concurso"))
                        oLotoMania.Dezena01 = CInt(dr("nr_dezena01"))
                        oLotoMania.Dezena02 = CInt(dr("nr_dezena02"))
                        oLotoMania.Dezena03 = CInt(dr("nr_dezena03"))
                        oLotoMania.Dezena04 = CInt(dr("nr_dezena04"))
                        oLotoMania.Dezena05 = CInt(dr("nr_dezena05"))
                        oLotoMania.Dezena06 = CInt(dr("nr_dezena06"))
                        oLotoMania.Dezena07 = CInt(dr("nr_dezena07"))
                        oLotoMania.Dezena08 = CInt(dr("nr_dezena08"))
                        oLotoMania.Dezena09 = CInt(dr("nr_dezena09"))
                        oLotoMania.Dezena10 = CInt(dr("nr_dezena10"))
                        oLotoMania.Dezena11 = CInt(dr("nr_dezena11"))
                        oLotoMania.Dezena12 = CInt(dr("nr_dezena12"))
                        oLotoMania.Dezena13 = CInt(dr("nr_dezena13"))
                        oLotoMania.Dezena14 = CInt(dr("nr_dezena14"))
                        oLotoMania.Dezena15 = CInt(dr("nr_dezena15"))
                        lstResultado.Add(oLotoMania)
                    Next
                    dtResults.Dispose()
                    dtResults = Nothing
                    oLotoMania = Nothing

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    lstResultado = Nothing
                    oLotoMania = Nothing
                    Throw ex
                End Try
            End Using

            Return lstResultado

        End Function

        ''' <summary>
        ''' Obtem os Resultados da TimeMania
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetTimeManiaResults() As List(Of Struct.TimeMania)

            Dim dtResults As New DataTable
            Dim lstResultado As List(Of Struct.TimeMania)
            Dim oTimeMania As Struct.TimeMania

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_get_resultados_lotofacil"

                    dtResults = cmdDados.GetDataTable

                    lstResultado = New List(Of Struct.TimeMania)
                    For Each dr As DataRow In dtResults.Rows
                        oTimeMania = New Struct.TimeMania
                        oTimeMania.Data = CDate(dr("dt_concurso"))
                        oTimeMania.Dezena01 = CInt(dr("nr_dezena1"))
                        oTimeMania.Dezena02 = CInt(dr("nr_dezena2"))
                        oTimeMania.Dezena03 = CInt(dr("nr_dezena3"))
                        oTimeMania.Dezena04 = CInt(dr("nr_dezena4"))
                        oTimeMania.Dezena05 = CInt(dr("nr_dezena5"))
                        oTimeMania.Dezena06 = CInt(dr("nr_dezena6"))
                        oTimeMania.Dezena07 = CInt(dr("nr_dezena7"))
                        oTimeMania.Time.Codigo = CInt(dr("nr_dezena7"))
                        oTimeMania.Time.Time = dr("nr_dezena7").ToString()
                        oTimeMania.Time.UFTime = dr("nr_dezena7").ToString()
                        lstResultado.Add(oTimeMania)
                    Next
                    dtResults.Dispose()
                    dtResults = Nothing
                    oTimeMania = Nothing

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    lstResultado = Nothing
                    oTimeMania = Nothing
                    Throw ex
                End Try
            End Using

            Return lstResultado

        End Function

        ''' <summary>
        ''' Obtem o Ultimo número de Concurso da Loteria Selecionada
        ''' </summary>
        ''' <param name="intLoteria">Código da Loteria</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetLastConcursNumber(ByVal intLoteria As Integer) As Integer

            Dim dtResults As New DataTable
            Dim intResults As Integer
            Dim parDados As New Parameter

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_get_last_concurso_number"
                    parDados.DbType = DbType.Int32
                    parDados.Name = "@id_loteria"
                    parDados.Value = intLoteria
                    'cmdDados.CreateParameter("@id_loteria", DbType.Int32, 0, CObj(intLoteria))
                    cmdDados.Parameters.Add(parDados)
                    dtResults = cmdDados.GetDataTable

                    intResults = Convert.ToInt32(dtResults.Rows(0).Item("nr_concurso").ToString)

                    dtResults.Dispose()
                    dtResults = Nothing

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    Throw ex
                End Try
            End Using

            Return intResults
        End Function

        ''' <summary>
        ''' Obtem o Ultimo número de Concurso de Cada Loteria
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetLastConcursNumber() As DataTable

            Dim dtResults As New DataTable
            Dim parDados As New Parameter

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_get_last_concurso_number"
                    'parDados = cmdDados.CreateParameter("@id_loteria", DbType.Int32, 0, 0)
                    cmdDados.Parameters.Add(parDados)
                    dtResults = cmdDados.GetDataTable

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    Throw ex
                End Try
            End Using

            Return dtResults
        End Function

        ''' <summary>
        '''Pega as Dezenas do ultimo concurso
        ''' </summary>
        ''' <param name="intLoteria">Código da Loteria</param>
        ''' <returns>DataTable</returns>
        ''' <remarks></remarks>       
        Public Function GetLastConcurs(ByVal intLoteria As Integer) As DataTable

            Dim dtResults As New DataTable
            Dim parDados As New Parameter

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_get_last_concurso"
                    parDados.DbType = DbType.Int32
                    parDados.Name = "@id_loteria"
                    parDados.Value = intLoteria
                    cmdDados.Parameters.Add(parDados)
                    dtResults = cmdDados.GetDataTable

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    Throw ex
                End Try
            End Using

            Return dtResults
        End Function

        ''' <summary>
        ''' Obter o Resultado dos Concursos de Todas as Loterias. Apenas o Ultimo Concurso
        ''' </summary>
        ''' <param name="intLoteria">Código da Loteria</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetLastResult(ByVal intLoteria As Integer) As DataTable

            Dim dtResults As New DataTable
            Dim parDados As New Parameter

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_get_last_concurso"
                    parDados.DbType = DbType.Int32
                    parDados.Name = "@id_loteria"
                    parDados.Value = intLoteria
                    cmdDados.Parameters.Add(parDados)
                    dtResults = cmdDados.GetDataTable

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    Throw ex
                End Try
            End Using

            Return dtResults

        End Function

        ''' <summary>
        ''' Obter o Resultado dos Concursos de Todas as Loterias. Apenas o Ultimo Concurso
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetLastResult() As DataTable

            Dim dtResults As New DataTable

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_get_last_concurso_all"
                    dtResults = cmdDados.GetDataTable

                    'TO DO: Colocar os resultados agrupados.

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    Throw ex
                End Try
            End Using

            Return dtResults

        End Function


#Region " IDisposable Support "
        ' IDisposable
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    strKey = Nothing
                End If

                ' TODO: free shared unmanaged resources
            End If
            Me.disposedValue = True
        End Sub
        ' This code added by Visual Basic to correctly implement the disposable pattern.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region

    End Class
End Namespace