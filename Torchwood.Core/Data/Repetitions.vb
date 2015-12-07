Imports Torchwood.Struct
Imports Consumer.Data
Namespace Data
    Public Class Repetitions
        Implements IRepetitions
        Private strKey As String

#Region "Construtor"

        ''' <summary>
        ''' Construtor da Classe
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()
            strKey = ""
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

        Public Function ProcessaLotoFacil() As Boolean Implements IRepetitions.ProcessaLotoFacil


        End Function

        Public Function VerifyConcurso(ByVal intLoteria As TipoLoteria, _
                                       ByVal intConcurso As Integer) As Boolean Implements IRepetitions.VerifyConcurso

            Dim blnRetorno As Boolean

            blnRetorno = False

            Using cmdDados As Command = New Command(Me.Key)

                Dim parDados As New Parameter
                Dim dtDados As New DataTable

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_exist_sequencias_repetidas")

                    'id_loteria
                    parDados = New Parameter
                    parDados.Name = "@id_loteria"
                    parDados.Value = intLoteria
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'id_loteria
                    parDados = New Parameter
                    parDados.Name = "@nr_concurso"
                    parDados.Value = intConcurso
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    dtDados = cmdDados.GetDataTable()

                    If dtDados.Rows.Count > 0 Then
                        blnRetorno = True
                    Else
                        blnRetorno = False
                    End If

                    cmdDados.Dispose()
                    parDados.Dispose()
                    dtDados.Dispose()
                    dtDados = Nothing
                    parDados = Nothing

                Catch ex As Exception
                    dtDados = Nothing
                    cmdDados.Dispose()
                    parDados.Dispose()
                    dtDados.Dispose()
                    dtDados = Nothing
                    parDados = Nothing
                    Throw New Exception(ex.Message.ToString)
                End Try
            End Using

            Return blnRetorno

        End Function
        Public Function ProcessaMegaSena() As Boolean Implements IRepetitions.ProcessaMegaSena

        End Function

        Public Function GravaRepeticoes(ByVal intLoteria As TipoLoteria, _
                                        ByVal intConcurso As Integer, _
                                        ByVal intOcorencias As Integer) As Boolean Implements IRepetitions.GravaRepeticoes

            Dim blnRetorno As Boolean

            blnRetorno = False

            Using cmdDados As Command = New Command(Me.Key)

                Dim parDados As New Parameter

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_add_sequencias_repetidas")

                    'id_loteria
                    parDados = New Parameter
                    parDados.Name = "@id_loteria"
                    parDados.Value = intLoteria
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'concursos
                    parDados = New Parameter
                    parDados.Name = "@nr_concurso"
                    parDados.Value = intConcurso
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'ocorrencias
                    parDados = New Parameter
                    parDados.Name = "@qt_item_ocorrencias"
                    parDados.Value = intOcorencias
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    cmdDados.Execute()
                    blnRetorno = True

                    cmdDados.Dispose()
                    parDados.Dispose()
                    parDados = Nothing

                Catch ex As Exception
                    cmdDados.Dispose()
                    parDados.Dispose()
                    parDados = Nothing
                    Throw New Exception(ex.Message.ToString)
                End Try
            End Using

            Return blnRetorno

        End Function

#End Region

#Region "Properties"
        ''' <summary>
        ''' Chave para a conexão com o banco
        ''' </summary>
        ''' <value>String</value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property Key() As String Implements IRepetitions.Key
            Get
                Return strKey
            End Get
            Set(ByVal value As String)
                strKey = value
            End Set
        End Property
#End Region

    End Class
End Namespace
