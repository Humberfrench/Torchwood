Imports Consumer.Data
Imports Torchwood.Struct
Namespace Statistics
    Public Class GameStats
        Implements IDisposable
#Region "Variables"

        Private strKey As String
        Private disposedValue As Boolean = False        ' To detect redundant calls
        Private intLoteria As TipoLoteria
        Private intConcursoIni As Integer
        Private intConcursoFim As Integer
        Private intQtDezenasMinima As Integer()

#End Region

#Region "Constructor"

        ''' <summary>
        ''' Construtor da Classe
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()

            ReDim intQtDezenasMinima(6)
            intQtDezenasMinima(0) = 0
            intQtDezenasMinima(1) = 3
            intQtDezenasMinima(2) = 5
            intQtDezenasMinima(3) = 3
            intQtDezenasMinima(4) = 15
            intQtDezenasMinima(5) = 10
            intQtDezenasMinima(6) = 2
            intLoteria = TipoLoteria.MegaSena
            intConcursoIni = 0
            intConcursoFim = 0

        End Sub

        ''' <summary>
        ''' Construtor da Classe
        ''' </summary>
        ''' <param name="pstrKey">Chave do Banco</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal pstrKey As String)

            Me.New()
            strKey = pstrKey

        End Sub

#End Region

#Region "Métodos"

        ''' <summary>
        ''' Lista as Dezenas, e a quantidades de concursos em atraso
        ''' </summary>
        ''' <returns>DataTable</returns>
        ''' <remarks></remarks>
        Public Function ListaAtraso() As List(Of Struct.Atrasos)
            'pr_tor_sel_atraso

            Dim dtResults As New DataTable
            Dim parDados As New Parameter
            Dim lstReturn As List(Of Struct.Atrasos) = Nothing

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_sel_atraso"

                    parDados = New Parameter
                    parDados.Name = "@id_loteria"
                    parDados.Value = intLoteria
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    dtResults = cmdDados.GetDataTable
                    lstReturn = Me.LoadDataForStructAtrasos(dtResults)
                    dtResults = Nothing

                Catch ex As Exception
                    dtResults = Nothing
                    lstReturn = Nothing
                    Throw ex
                End Try
            End Using

            Return lstReturn
        End Function

        ''' <summary>
        ''' Lista as Dezenas, e a quantidades de concursos impares em atraso
        ''' </summary>
        ''' <returns>DataTable</returns>
        ''' <remarks></remarks>
        Public Function ListaAtrasoImpar() As List(Of Struct.Atrasos)
            'pr_tor_sel_atraso

            Dim dtResults As New DataTable
            Dim parDados As New Parameter
            Dim lstReturn As List(Of Struct.Atrasos) = Nothing

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_sel_atraso_impar"

                    parDados = New Parameter
                    parDados.Name = "@id_loteria"
                    parDados.Value = intLoteria
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    dtResults = cmdDados.GetDataTable
                    lstReturn = Me.LoadDataForStructAtrasos(dtResults)
                    dtResults = Nothing

                Catch ex As Exception
                    dtResults = Nothing
                    lstReturn = Nothing
                    Throw ex
                End Try
            End Using

            Return lstReturn
        End Function

        ''' <summary>
        ''' Lista as Dezenas, e a quantidades de concursos top n em atraso
        ''' </summary>
        ''' <param name="intOcorrencias">N o multiplo desejado do concurso</param>
        ''' <returns>DataTable</returns>
        ''' <remarks></remarks>
        Public Function ListaAtrasoTop(ByVal intOcorrencias As Integer) As List(Of Struct.Atrasos)
            'pr_tor_sel_atraso

            Dim dtResults As New DataTable
            Dim parDados As New Parameter
            Dim lstReturn As List(Of Struct.Atrasos) = Nothing

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_sel_atraso_top"

                    parDados = New Parameter
                    parDados.Name = "@id_loteria"
                    parDados.Value = intLoteria
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    parDados = New Parameter
                    parDados.Name = "@nr_multiplo"
                    parDados.Value = intOcorrencias
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    dtResults = cmdDados.GetDataTable
                    lstReturn = Me.LoadDataForStructAtrasos(dtResults)
                    dtResults = Nothing

                Catch ex As Exception
                    dtResults = Nothing
                    lstReturn = Nothing
                    Throw ex
                End Try
            End Using

            Return lstReturn
        End Function
        ''' <summary>
        ''' Carrega a Estrutura - Compartilhada, para melhor economia de codigo e reaproveitamento
        ''' </summary>
        ''' <param name="dtDados">DataTable</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function LoadDataForStructAtrasos(ByVal dtDados As DataTable) As List(Of Struct.Atrasos)

            Dim lstReturn As List(Of Struct.Atrasos) = New List(Of Struct.Atrasos)
            Dim objReturn As Struct.Atrasos = Nothing

            For Each dr As DataRow In dtDados.Rows
                objReturn = New Struct.Atrasos
                objReturn.Dezena = CInt(dr.Item("nr_dezena"))
                objReturn.QuantidadeDezena = CInt(dr.Item("qt_atrasos"))
                objReturn.QuantidadeDezenaMaximo = CInt(dr.Item("qt_max_atraso"))
                lstReturn.Add(objReturn)
            Next

            Return lstReturn

        End Function
        ''' <summary>
        ''' Carrega a Estrutura - Compartilhada, para melhor economia de codigo e reaproveitamento
        ''' </summary>
        ''' <param name="dtDados">DataTable</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function LoadDataForStruct(ByVal dtDados As DataTable) As List(Of Struct.BestDezenas)

            Dim lstReturn As List(Of Struct.BestDezenas) = New List(Of Struct.BestDezenas)
            Dim objReturn As Struct.BestDezenas = Nothing

            For Each dr As DataRow In dtDados.Rows
                objReturn = New Struct.BestDezenas
                objReturn.Dezena = CInt(dr.Item("nr_dezena"))
                objReturn.QuantidadeDezena = CInt(dr.Item("qt_dezena"))
                objReturn.PercentualDezena = CDbl(dr.Item("pc_dezena"))
                objReturn.PercentualDezenaTotal = CDbl(dr.Item("pc_dezena_total"))
                objReturn.NumeroConcursos = CInt(dr.Item("total_concursos"))
                objReturn.TotalDezenas = CInt(dr.Item("total_dezenas"))
                lstReturn.Add(objReturn)
            Next

            Return lstReturn

        End Function

        ''' <summary>
        '''Pega as melhores Dezenas
        ''' </summary>
        ''' <returns>Lista dos dados</returns>
        ''' <remarks></remarks>
        Public Function GetBestDezenas() As List(Of Struct.BestDezenas)
            'pr_tor_get_best_dezenas

            Dim dtResults As New DataTable
            Dim parDados As New Parameter
            Dim lstReturn As List(Of Struct.BestDezenas) = Nothing

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_get_best_dezenas"

                    parDados = New Parameter
                    parDados.Name = "@id_loteria"
                    parDados.Value = Me.Loteria
                    parDados.DbType = DbType.Int16
                    cmdDados.Parameters.Add(parDados)

                    dtResults = cmdDados.GetDataTable
                    lstReturn = Me.LoadDataForStruct(dtResults)
                    dtResults = Nothing
                    parDados = Nothing

                Catch ex As Exception
                    lstReturn = Nothing
                    parDados = Nothing
                    dtResults = Nothing
                    Throw ex
                End Try
            End Using

            Return lstReturn

        End Function

        ''' <summary>
        ''' Pega as melhores Dezenas - By Top - Top seria o número do multiplo
        ''' </summary>
        ''' <param name="intOcorrencias">Qtde de Ocorrencias</param>
        ''' <returns>Lista dos dados</returns>
        ''' <remarks></remarks>
        Public Function GetBestDezenasTop(ByVal intOcorrencias As Integer) As List(Of Struct.BestDezenas)

            'pr_tor_get_best_dezenas_top

            Dim dtResults As New DataTable
            Dim parDados As New Parameter
            Dim lstReturn As List(Of Struct.BestDezenas) = Nothing

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_get_best_dezenas_top"

                    parDados = New Parameter
                    parDados.Name = "@id_loteria"
                    parDados.Value = Me.Loteria
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    parDados = New Parameter
                    parDados.Name = "@occurs"
                    parDados.Value = intOcorrencias
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    dtResults = cmdDados.GetDataTable
                    lstReturn = Me.LoadDataForStruct(dtResults)
                    dtResults = Nothing
                    parDados = Nothing

                Catch ex As Exception
                    lstReturn = Nothing
                    parDados = Nothing
                    dtResults = Nothing
                    Throw ex
                End Try
            End Using


            Return lstReturn
        End Function

        ''' <summary>
        '''Pega as melhores de uma loteria, para com o qual seria 
        ''' passado as dezena anteriormente na tabela temporaria com o guid
        ''' </summary>
        ''' <returns>DataTable</returns>
        ''' <remarks></remarks>
        Public Function GetBestDezenasTopImpar() As List(Of Struct.BestDezenas)

            'pr_tor_get_best_dezenas_top_impar

            Dim dtResults As New DataTable
            Dim parDados As New Parameter
            Dim lstReturn As List(Of Struct.BestDezenas) = Nothing

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_get_best_dezenas_top_impar"

                    parDados = New Parameter
                    parDados.Name = "@id_loteria"
                    parDados.Value = Me.Loteria
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    dtResults = cmdDados.GetDataTable
                    lstReturn = Me.LoadDataForStruct(dtResults)
                    dtResults = Nothing
                    parDados = Nothing

                Catch ex As Exception
                    lstReturn = Nothing
                    parDados = Nothing
                    dtResults = Nothing
                    Throw ex
                End Try
            End Using

            Return lstReturn
        End Function

        ''' <summary>
        '''Pega as melhores Dezenas - Dentro das Faixas de um ROL estatístico
        ''' </summary>
        ''' <returns>Lista dos dados</returns>
        ''' <remarks></remarks>
        Public Function GetBestDezenasByRol() As DataTable
            'pr_tor_get_best_dezenas_byrol

            Dim dtResults As New DataTable
            Dim parDados As New Parameter

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_get_best_dezenas_byrol"

                    parDados = New Parameter
                    parDados.Name = "@id_loteria"
                    parDados.Value = Me.Loteria
                    parDados.DbType = DbType.Int16
                    cmdDados.Parameters.Add(parDados)

                    dtResults = cmdDados.GetDataTable
                    parDados = Nothing

                Catch ex As Exception
                    dtResults = Nothing
                    parDados = Nothing
                    Throw ex
                End Try
            End Using

            Return dtResults
        End Function

        ''' <summary>
        '''Pega as melhores Dezenas, com limite de ocorrencias mínimas pela loteria.
        ''' </summary>
        ''' <returns>DataTable</returns>
        ''' <remarks></remarks>
        Public Function GetBestResults(ByVal strGUID As String, _
                                       Optional ByVal intConcursoInicial As Integer = 0, _
                                       Optional ByVal intConcursoFinal As Integer = 0) As DataTable
            'pr_tor_get_best_results

            Dim dtResults As New DataTable
            Dim parDados As New Parameter

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_get_best_results"

                    parDados = New Parameter
                    parDados.Name = "@id_loteria"
                    parDados.Value = Me.Loteria
                    parDados.DbType = DbType.Int16
                    cmdDados.Parameters.Add(parDados)

                    parDados = New Parameter
                    parDados.Name = "@id_guid"
                    parDados.Value = strGUID
                    parDados.DbType = DbType.Guid
                    cmdDados.Parameters.Add(parDados)

                    parDados = New Parameter
                    parDados.Name = "@conc_ini"
                    parDados.Value = intConcursoInicial
                    parDados.DbType = DbType.Int16
                    cmdDados.Parameters.Add(parDados)

                    parDados = New Parameter
                    parDados.Name = "@conc_fim"
                    parDados.Value = intConcursoFinal
                    parDados.DbType = DbType.Int16
                    cmdDados.Parameters.Add(parDados)

                    dtResults = cmdDados.GetDataTable

                Catch ex As Exception
                    Throw ex
                End Try
            End Using

            Return dtResults
        End Function

        ''' <summary>
        '''Pega as melhores Dezenas. Todas sem limite de ocorrencia mínima.
        ''' </summary>
        ''' <returns>DataTable</returns>
        ''' <remarks></remarks>
        Public Function GetBestResultsAll(ByVal strGUID As String, _
                                          Optional ByVal intConcursoInicial As Integer = 0, _
                                          Optional ByVal intConcursoFinal As Integer = 0) As DataTable
            'pr_tor_get_best_results

            Dim dtResults As New DataTable
            Dim parDados As New Parameter

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_get_best_results_all"

                    parDados = New Parameter
                    parDados.Name = "@id_loteria"
                    parDados.Value = Me.Loteria
                    parDados.DbType = DbType.Int16
                    cmdDados.Parameters.Add(parDados)

                    parDados = New Parameter
                    parDados.Name = "@id_guid"
                    parDados.Value = strGUID
                    parDados.DbType = DbType.Guid
                    cmdDados.Parameters.Add(parDados)

                    parDados = New Parameter
                    parDados.Name = "@conc_ini"
                    parDados.Value = intConcursoInicial
                    parDados.DbType = DbType.Int16
                    cmdDados.Parameters.Add(parDados)

                    parDados = New Parameter
                    parDados.Name = "@conc_fim"
                    parDados.Value = intConcursoFinal
                    parDados.DbType = DbType.Int16
                    cmdDados.Parameters.Add(parDados)

                    dtResults = cmdDados.GetDataTable

                Catch ex As Exception
                    Throw ex
                End Try
            End Using

            Return dtResults
        End Function

        ''' <summary>
        ''' Retorna resultados da distribuição
        ''' </summary>
        ''' <returns>DataTable</returns>
        ''' <remarks></remarks>
        Public Function GetResultsByDistribute() As DataTable

            Dim dtResult As New DataTable
            Dim blnParameters As Boolean = True

            'verifica-se os parametors estão preenchido
            If Me.Loteria = 0 Then
                'erro
                dtResult = Nothing
                blnParameters = False
            End If

            If Me.ConcursoIni = 0 Then
                'erro
                dtResult = Nothing
                blnParameters = False
            End If

            If Me.ConcursoFim = 0 Then
                'erro
                dtResult = Nothing
                blnParameters = False
            End If

            If blnParameters Then
                Using cmdDados As Command = New Command(Me.Key)

                    Dim parData As Parameter

                    Try
                        cmdDados.CommandType = CommandType.StoredProcedure
                        cmdDados.CommandText = "pr_tor_get_best_dezenas_byrol_in_range"

                        parData = cmdDados.CreateParameter()
                        parData.DbType = DbType.Int16
                        parData.Value = Me.Loteria
                        parData.Name = "@id_loteria"
                        cmdDados.Parameters.Add(parData)

                        parData = cmdDados.CreateParameter()
                        parData.DbType = DbType.Int16
                        parData.Value = Me.ConcursoIni
                        parData.Name = "@conc_ini"
                        cmdDados.Parameters.Add(parData)

                        parData = cmdDados.CreateParameter()
                        parData.DbType = DbType.Int16
                        parData.Value = Me.ConcursoFim
                        parData.Name = "@conc_fim"
                        cmdDados.Parameters.Add(parData)

                        dtResult = cmdDados.GetDataTable

                    Catch ex As Exception
                        dtResult = Nothing
                        Throw ex
                    Finally
                        cmdDados.Dispose()
                    End Try

                End Using
            End If

            Return dtResult
        End Function


#End Region

#Region "Properties"

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
        ''' Código da Loteria
        ''' </summary>
        ''' <value>Inteiro</value>
        ''' <returns>Inteiro</returns>
        ''' <remarks></remarks>
        Public Property Loteria() As TipoLoteria
            Get
                If intLoteria = 0 Then intLoteria = TipoLoteria.MegaSena
                Return intLoteria
            End Get
            Set(ByVal value As TipoLoteria)
                intLoteria = value
            End Set
        End Property

        ''' <summary>
        ''' Número do Concurso inicial da Faixa
        ''' </summary>
        ''' <value>Inteiro</value>
        ''' <returns>Inteiro</returns>
        ''' <remarks></remarks>
        Public Property ConcursoIni() As Integer
            Get
                Return intConcursoIni
            End Get
            Set(ByVal value As Integer)
                intConcursoIni = value
            End Set
        End Property

        ''' <summary>
        ''' Número do Concurso final da Faixa
        ''' </summary>
        ''' <value>Inteiro</value>
        ''' <returns>Inteiro</returns>
        ''' <remarks></remarks>
        Public Property ConcursoFim() As Integer
            Get
                Return intConcursoFim
            End Get
            Set(ByVal value As Integer)
                intConcursoFim = value
            End Set
        End Property

#End Region

#Region " IDisposable Support "
        ' IDisposable
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    ' TODO: free unmanaged resources when explicitly called
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