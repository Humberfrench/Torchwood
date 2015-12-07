Imports Torchwood.Struct
Imports Consumer.Data
Namespace Data

    Public Class GenericQueries
        Implements IDisposable

#Region "Variáveis"
        Private strKey As String
        Private disposedValue As Boolean = False        ' To detect redundant calls
        Private intLoteria As TipoLoteria
#End Region

#Region "Construtor"

        ''' <summary>
        ''' Construtor da Classe
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()

            intLoteria = TipoLoteria.MegaSena

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
        ''' importante para verificação da planilha excel se existe ou não o concurso para a loteria
        ''' </summary>
        ''' <param name="intLoteria">nuemro da loteria</param>
        ''' <param name="intConcurso">numero do concurso desejado</param>
        ''' <returns>boolean de acordo com o resultado</returns>
        ''' <remarks></remarks>
        Public Function CheckConcoursAndLotery(ByVal intLoteria As Integer, _
                                               ByVal intConcurso As Integer) As Boolean

            Dim blnRetorno As Boolean

            blnRetorno = False

            Using cmdDados As Command = New Command(Me.Key)

                Dim parDados As New Parameter
                Dim dtDados As New DataTable

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_get_exists_concurs")

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

        Public Function ListaConcursos() As DataTable

            Dim dtResult As New DataTable
            Dim blnParameters As Boolean = True

            'verifica-se os parametors estão preenchido
            If Me.Loteria = 0 Then
                'erro
                dtResult = Nothing
                blnParameters = False
            End If

            If blnParameters Then
                Using cmdDados As Command = New Command(Me.Key)

                    Dim parData As Parameter

                    Try

                        cmdDados.CommandText = "pr_tor_list_concurso"
                        cmdDados.CommandType = CommandType.StoredProcedure

                        parData = cmdDados.CreateParameter()
                        parData.DbType = DbType.Int16
                        parData.Value = Me.Loteria
                        parData.Name = "@id_loteria"
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

        Public Function ListTimeMania() As DataTable

            '
            Dim dtResult As New DataTable
            Dim blnParameters As Boolean = True

            'verifica-se os parametors estão preenchido
            If Me.Loteria = 0 Then
                'erro
                dtResult = Nothing
                blnParameters = False
            End If

            If blnParameters Then
                Using cmdDados As Command = New Command(Me.Key)

                    Try
                        cmdDados.CommandText = "pr_tor_get_times_timemania"
                        cmdDados.CommandType = CommandType.StoredProcedure

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

#Region "Propriedades"

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

#End Region

#Region " IDisposable Support "
        ' IDisposable
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then

                End If
            End If
            Me.disposedValue = True
        End Sub
        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region

    End Class
End Namespace