Imports Consumer.Data
Imports Torchwood.Struct
Namespace Data
    <Obsolete("Classe Descontinuada. Verifique SetPesquisas", True)> _
    Public Class GenericActions
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

        'ver se é igual a adddezenatemp
        Public Function AddDezenaWork(ByVal intDezena As Integer, _
                                      ByVal strGuid As String) As Boolean

            Dim blnRetorno As Boolean

            blnRetorno = False

            Using cmdDados As Command = New Command(Me.Key) 'Provider.SQL)

                Dim parDados As New Parameter

                Try
                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_add_dezena_temp")

                    'guid de filtro
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena"
                    parDados.Value = strGuid
                    parDados.DbType = DbType.String
                    parDados.Size = 16
                    cmdDados.Parameters.Add(parDados)

                    'Dezena
                    parDados = New Parameter
                    parDados.Name = "@id_guid_dezena"
                    parDados.Value = intDezena
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)


                    cmdDados.Execute()

                    'fim
                    blnRetorno = True
                    cmdDados.Dispose()
                    parDados.Dispose()
                    parDados = Nothing

                Catch ex As Exception
                    blnRetorno = False
                    cmdDados.Dispose()
                    parDados.Dispose()
                    parDados = Nothing
                    Throw New Exception(ex.Message.ToString)
                End Try
            End Using

            Return blnRetorno
        End Function

        Public Function AddDezenaTemp(ByVal strGuid As String, _
                              ByVal intDezena As Integer) As Boolean


            Dim blnRetorno As Boolean

            blnRetorno = False

            Using cmdDados As Command = New Command(Me.Key)

                Dim parDados As New Parameter

                '
                'CREATE PROCEDURE dbo.pr_tor_add_dezena_temp (
                '	                          @id_guid_dezena uniqueidentifier,
                '		             @nr_dezena int)

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_add_dezena_temp")

                    'nr_concurso
                    parDados = New Parameter
                    parDados.Name = "@id_guid_dezena"
                    parDados.Value = strGuid
                    parDados.DbType = DbType.Guid
                    cmdDados.Parameters.Add(parDados)

                    'dt_concurso
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena"
                    parDados.Value = intDezena
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    cmdDados.Execute()

                    'fim
                    blnRetorno = True
                    cmdDados.Dispose()
                    parDados.Dispose()
                    parDados = Nothing

                Catch ex As Exception
                    blnRetorno = False
                    cmdDados.Dispose()
                    parDados.Dispose()
                    parDados = Nothing
                    Throw New Exception(ex.Message.ToString)
                End Try
            End Using

            Return blnRetorno

        End Function

        Public Function AddDezenaTemp(ByVal strGuid As String, _
                                      ByVal lstDezena As List(Of Integer)) As Boolean


            Dim blnRetorno As Boolean

            blnRetorno = False

            Try

                For Each intDezena As Integer In lstDezena
                    Me.AddDezenaTemp(strGuid, intDezena)
                Next

            Catch ex As Exception
                blnRetorno = False
                Throw New Exception(ex.Message.ToString)
            End Try

            Return blnRetorno

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
