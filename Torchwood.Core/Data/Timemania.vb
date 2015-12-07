Imports Consumer.Data
Imports Torchwood.Core.Exceptions

Namespace Data
    Public Class Timemania
        Implements IDisposable

#Region "Variáveis"
        Private disposedValue As Boolean = False        ' To detect redundant calls
        Private strKey As String
#End Region

#Region "Construtor"

        Public Sub New()

            strKey = ""

        End Sub

        Public Sub New(ByVal pstrKey As String)

            Me.New()
            strKey = pstrKey

        End Sub

#End Region

#Region "IDisposable Support"
        ' IDisposable
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    strKey = Nothing
                End If
            End If
            Me.disposedValue = True
        End Sub
        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
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

#End Region

#Region "Métodos"

        ''' <summary>
        ''' Lista Todas Os Times Ativas
        ''' </summary>
        ''' <returns>Lista dos Times</returns>
        ''' <remarks></remarks>
        Public Function List() As List(Of Struct.TimeManiaTimes)
            Dim dtResults As DataTable = Nothing
            Dim oResults As IList(Of Struct.TimeManiaTimes) = Nothing
            Dim oStruct As Struct.TimeManiaTimes = Nothing

            Using cmdDados As New Command(Me.Key)

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("[pr_tor_list_timemania")

                    dtResults = cmdDados.GetDataTable
                    oResults = New List(Of Struct.TimeManiaTimes)

                    For Each dr As DataRow In dtResults.Rows
                        oStruct = New Struct.TimeManiaTimes
                        oStruct.Codigo = Convert.ToInt16(dr("id_time").ToString())
                        oStruct.Time = dr("nm_time").ToString()
                        oStruct.UFTime = dr("uf_time").ToString()
                        oResults.Add(oStruct)
                    Next

                    cmdDados.Dispose()
                    dtResults = Nothing

                Catch ex As Exception
                    cmdDados.Dispose()
                    dtResults = Nothing
                End Try
            End Using

            Return CType(oResults, List(Of Struct.TimeManiaTimes))

        End Function


        ''' <summary>
        ''' Obtem o Código do Time, de acordo com o nome e a UF. Para Loteria de Time Mania
        ''' </summary>
        ''' <param name="strTime">Nome do Time</param>
        ''' <param name="strUF">Nome da UF</param>
        ''' <returns>Estrutura com os dados Completos</returns>
        ''' <remarks></remarks>
        Public Function ObterTime(ByVal strTime As String, _
                                  ByVal strUF As String) As Struct.TimeManiaTimes

            Dim oReturn As Struct.TimeManiaTimes
            Dim parDados As New Parameter

            Using cmdDados As Command = New Command(Me.Key)

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_get_Time")

                    'nr_concurso
                    parDados = New Parameter
                    parDados.Name = "@id_time"
                    parDados.Direction = ParameterDirection.Output
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_concurso
                    parDados = New Parameter
                    parDados.Name = "@nm_time"
                    parDados.Value = strTime
                    parDados.Size = 50
                    parDados.DbType = DbType.String
                    cmdDados.Parameters.Add(parDados)

                    'dt_concurso
                    parDados = New Parameter
                    parDados.Name = "@nm_uf"
                    parDados.Value = strUF
                    parDados.Size = 2
                    parDados.DbType = DbType.String
                    cmdDados.Parameters.Add(parDados)

                    cmdDados.ExecuteNonQuery()

                    oReturn = New Struct.TimeManiaTimes()
                    If (IsDBNull(cmdDados.Parameters(0).Value)) Then
                        oReturn.Codigo = 0
                    Else
                        oReturn.Codigo = CInt(cmdDados.Parameters(0).Value.ToString)
                    End If
                    oReturn.Time = strTime
                    oReturn.UFTime = strUF

                    parDados.Dispose()
                    parDados = Nothing

                Catch ex As Exception
                    cmdDados.Dispose()
                    parDados.Dispose()
                    parDados = Nothing
                    Throw New Exception(ex.Message.ToString)
                End Try
            End Using

            Return oReturn

        End Function

#End Region
    End Class
End Namespace