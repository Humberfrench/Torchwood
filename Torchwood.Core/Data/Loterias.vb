Imports Consumer.Data
Imports Torchwood.Core.Exceptions

Namespace Data
    Public Class Loterias
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
        ''' adiciona nova loteria na tabela
        ''' </summary>
        ''' <param name="objLoteria">objeto contendo dados da loteria</param>
        ''' <returns>true, se ocorreu tudo certo</returns>
        ''' <remarks></remarks>
        Public Function Add(ByVal objLoteria As Struct.Loteria) As Boolean

            Dim parDados As Parameter
            Dim blnReturn As Boolean

            Using cmdDados As New Command(Me.Key)

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_add_loteria")

                    'id_loteria
                    parDados = New Parameter
                    parDados.Name = "@id_loteria"
                    parDados.Value = objLoteria.Codigo
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nm_loteria
                    parDados = New Parameter
                    parDados.Name = "@nm_loteria"
                    parDados.Value = objLoteria.Descricao
                    parDados.DbType = DbType.String
                    parDados.Size = 50
                    cmdDados.Parameters.Add(parDados)

                    'nr_dez_min
                    parDados = New Parameter
                    parDados.Name = "@nr_dez_min"
                    parDados.Value = objLoteria.DezMinima
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dez_max
                    parDados = New Parameter
                    parDados.Name = "@nr_dez_max"
                    parDados.Value = objLoteria.DezMaxima
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'qt_dezenas
                    parDados = New Parameter
                    parDados.Name = "@qt_dezenas"
                    parDados.Value = objLoteria.QtdeDezenas
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_qt_dezenas_total
                    parDados = New Parameter
                    parDados.Name = "@nr_qt_dezenas_total"
                    parDados.Value = objLoteria.QtdeDezenasTotais
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'qt_min_occurs
                    parDados = New Parameter
                    parDados.Name = "@qt_min_occurs"
                    parDados.Value = objLoteria.QtdeMinOccurs
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'st_loteria
                    parDados = New Parameter
                    parDados.Name = "@st_loteria"
                    parDados.Value = objLoteria.Status
                    parDados.DbType = DbType.String
                    parDados.Size = 1
                    cmdDados.Parameters.Add(parDados)

                    cmdDados.ExecuteNonQuery()

                    blnReturn = True

                    cmdDados.Dispose()

                Catch ex As Exception
                    blnReturn = False
                    cmdDados.Dispose()
                    Throw ex
                End Try
            End Using

            Return blnReturn
        End Function

        ''' <summary>
        ''' remove loteria na tabela
        ''' </summary>
        ''' <param name="intLoteria">codigo da loteria</param>
        ''' <returns>true, se ocorreu tudo certo. false se der errado.</returns>
        ''' <remarks>Caso HAJA Dezenas, Ele fará Atualização de Status para Inativo</remarks>
        Public Function Delete(ByVal intLoteria As Integer) As Boolean

            Dim parDados As Parameter
            Dim blnReturn As Boolean

            Using cmdDados As New Command(Me.Key)

                Try

                    'Confere se existe
                    If VerificaLoteria(intLoteria) Then
                        'erro
                        Throw New DataExists("Não é possivel remover a Loteria. Existe Dezenas Sorteadas para esta Loteria.")
                    End If

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_del_loteria")

                    'id_loteria
                    parDados = New Parameter
                    parDados.Name = "@id_loteria"
                    parDados.Value = intLoteria
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    cmdDados.Execute()

                    blnReturn = True

                    cmdDados.Dispose()

                Catch exDados As DataExists
                    Throw New DataExists(exDados.Message)
                    blnReturn = False
                    cmdDados.Dispose()
                Catch ex As Exception
                    blnReturn = False
                    cmdDados.Dispose()
                    Throw ex

                End Try
            End Using

            Return blnReturn

        End Function

        ''' <summary>
        ''' atualiza dados da loteria na tabela
        ''' </summary>
        ''' <param name="objLoteria">objeto contendo dados da loteria</param>
        ''' <returns>true, se ocorreu tudo certo</returns>
        ''' <remarks></remarks>
        Public Function Update(ByVal objLoteria As Struct.Loteria) As Boolean


            Dim parDados As Parameter
            Dim blnReturn As Boolean

            Using cmdDados As New Command(Me.Key)

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_upd_loteria")

                    'id_loteria
                    parDados = New Parameter
                    parDados.Name = "@id_loteria"
                    parDados.Value = objLoteria.Codigo
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nm_loteria
                    parDados = New Parameter
                    parDados.Name = "@nm_loteria"
                    parDados.Value = objLoteria.Descricao
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dez_min
                    parDados = New Parameter
                    parDados.Name = "@nr_dez_min"
                    parDados.Value = objLoteria.DezMinima
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dez_max
                    parDados = New Parameter
                    parDados.Name = "@nr_dez_max"
                    parDados.Value = objLoteria.DezMaxima
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'qt_dezenas
                    parDados = New Parameter
                    parDados.Name = "@qt_dezenas"
                    parDados.Value = objLoteria.QtdeDezenas
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_qt_dezenas_total
                    parDados = New Parameter
                    parDados.Name = "@nr_qt_dezenas_total"
                    parDados.Value = objLoteria.QtdeDezenasTotais
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'qt_min_occurs
                    parDados = New Parameter
                    parDados.Name = "@qt_min_occurs"
                    parDados.Value = objLoteria.QtdeMinOccurs
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'st_loteria
                    parDados = New Parameter
                    parDados.Name = "@st_loteria"
                    parDados.Value = objLoteria.QtdeMinOccurs
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    cmdDados.ExecuteNonQuery()

                    blnReturn = True

                    cmdDados.Dispose()

                Catch ex As Exception
                    blnReturn = False
                    cmdDados.Dispose()
                    Throw ex

                End Try
            End Using

            Return blnReturn

        End Function

        ''' <summary>
        ''' Obtem um item da tabela de Loterias
        ''' </summary>
        ''' <param name="intLoteria">Código da Loteria</param>
        ''' <returns>Estrutura da Loteria</returns>
        ''' <remarks></remarks>
        Public Function [Get](ByVal intLoteria As Integer) As Struct.Loteria

            Dim dtResults As DataTable = Nothing
            Dim oStruct As Struct.Loteria = Nothing
            Dim parDados As Parameter

            Using cmdDados As New Command(Me.Key)

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_list_loteria")

                    'id_loteria
                    parDados = New Parameter
                    parDados.Name = "@id_loteria"
                    parDados.Value = intLoteria
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    dtResults = cmdDados.GetDataTable

                    oStruct = New Struct.Loteria
                    oStruct.Codigo = Convert.ToInt16(dtResults.Rows(0)("id_loteria").ToString())
                    oStruct.Descricao = dtResults.Rows(0)("nm_loteria").ToString()
                    oStruct.DezMinima = Convert.ToInt16(dtResults.Rows(0)("nr_dez_min").ToString())
                    oStruct.DezMaxima = Convert.ToInt16(dtResults.Rows(0)("nr_dez_max").ToString())
                    oStruct.QtdeDezenas = Convert.ToInt16(dtResults.Rows(0)("qt_dezenas").ToString())
                    oStruct.QtdeDezenasTotais = Convert.ToInt16(dtResults.Rows(0)("nr_qt_dezenas_total").ToString())
                    oStruct.QtdeMinOccurs = Convert.ToInt16(dtResults.Rows(0)("qt_min_occurs").ToString())
                    oStruct.Status = dtResults.Rows(0)("st_loteria").ToString()

                    cmdDados.Dispose()
                    dtResults = Nothing

                Catch ex As Exception
                    oStruct = Nothing
                    cmdDados.Dispose()
                    dtResults.Dispose()
                    dtResults = Nothing
                    Throw ex
                End Try
            End Using

            Return oStruct

        End Function

        ''' <summary>
        ''' Lista Todas as Loterias Ativas
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function List() As List(Of Struct.Loteria)
            Dim dtResults As DataTable = Nothing
            Dim oResults As IList(Of Struct.Loteria) = Nothing
            Dim oStruct As Struct.Loteria = Nothing

            Using cmdDados As New Command(Me.Key)

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_list_loteria")

                    dtResults = cmdDados.GetDataTable
                    oResults = New List(Of Struct.Loteria)

                    For Each dr As DataRow In dtResults.Rows
                        oStruct = New Struct.Loteria
                        oStruct.Codigo = Convert.ToInt16(dr("id_loteria").ToString())
                        oStruct.Descricao = dr("nm_loteria").ToString()
                        oStruct.DezMinima = Convert.ToInt16(dr("nr_dez_min").ToString())
                        oStruct.DezMaxima = Convert.ToInt16(dr("nr_dez_max").ToString())
                        oStruct.QtdeDezenas = Convert.ToInt16(dr("qt_dezenas").ToString())
                        oStruct.QtdeDezenasTotais = Convert.ToInt16(dr("nr_qt_dezenas_total").ToString())
                        oStruct.QtdeMinOccurs = Convert.ToInt16(dr("qt_min_occurs").ToString())
                        oStruct.Status = dr("st_loteria").ToString()
                        oResults.Add(oStruct)
                    Next

                    cmdDados.Dispose()
                    dtResults = Nothing

                Catch ex As Exception
                    cmdDados.Dispose()
                    dtResults = Nothing
                    Throw ex
                End Try
            End Using

            Return CType(oResults, List(Of Struct.Loteria))
        End Function

        ''' <summary>
        ''' Lista Todos os registros de Loteria, seja ativos e ou inativos
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ListAll() As List(Of Struct.Loteria)

            Dim dtResults As DataTable = Nothing
            Dim oResults As IList(Of Struct.Loteria) = Nothing
            Dim oStruct As Struct.Loteria = Nothing

            Using cmdDados As New Command(Me.Key)

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_list_loteria_all")

                    dtResults = cmdDados.GetDataTable
                    oResults = New List(Of Struct.Loteria)

                    For Each dr As DataRow In dtResults.Rows
                        oStruct = New Struct.Loteria
                        oStruct.Codigo = Convert.ToInt16(dr("id_loteria").ToString())
                        oStruct.Descricao = dr("nm_loteria").ToString()
                        oStruct.DezMinima = Convert.ToInt16(dr("nr_dez_min").ToString())
                        oStruct.DezMaxima = Convert.ToInt16(dr("nr_dez_max").ToString())
                        oStruct.QtdeDezenas = Convert.ToInt16(dr("qt_dezenas").ToString())
                        oStruct.QtdeDezenasTotais = Convert.ToInt16(dr("nr_qt_dezenas_total").ToString())
                        oStruct.QtdeMinOccurs = Convert.ToInt16(dr("qt_min_occurs").ToString())
                        oStruct.Status = dr("st_loteria").ToString()
                        oResults.Add(oStruct)
                    Next

                    cmdDados.Dispose()
                    dtResults = Nothing

                Catch ex As Exception
                    cmdDados.Dispose()
                    dtResults.Dispose()
                    dtResults = Nothing
                    Throw ex
                End Try
            End Using

            Return CType(oResults, List(Of Struct.Loteria))

        End Function

        ''' <summary>
        ''' Efetua a atualização do Status da Loteria
        ''' </summary>
        ''' <param name="intLoteria">Código da Loteria</param>
        ''' <param name="strStatus">Novo Status da Loteria</param>
        ''' <returns>True, se ocorreu tudo OK</returns>
        ''' <remarks></remarks>
        Public Function AtualizaStatus(ByVal intLoteria As Integer, _
                                       ByVal strStatus As String) As Boolean


            Dim parDados As Parameter
            Dim blnReturn As Boolean

            Using cmdDados As New Command(Me.Key)

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_upd_status_loteria")

                    'id_loteria
                    parDados = New Parameter
                    parDados.Name = "@id_loteria"
                    parDados.Value = intLoteria
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'st_status
                    parDados = New Parameter
                    parDados.Name = "@st_status"
                    parDados.Value = strStatus
                    parDados.DbType = DbType.String
                    parDados.Size = 1
                    cmdDados.Parameters.Add(parDados)

                    cmdDados.ExecuteNonQuery()

                    blnReturn = True

                    cmdDados.Dispose()

                Catch ex As Exception
                    blnReturn = False
                    cmdDados.Dispose()
                    Throw ex
                End Try
            End Using

            Return blnReturn
        End Function

        ''' <summary>
        ''' Verifica se existe Dezenas na loteria. 
        ''' Método Importante para conferencia de Deleção do Status.
        ''' </summary>
        ''' <param name="intLoteria">Código da Loteria</param>
        ''' <returns>True, se sim, tem dezenas Depentes. False, não tem.</returns>
        ''' <remarks></remarks>
        Public Function VerificaLoteria(ByVal intLoteria As Integer) As Boolean

            Dim dtResults As DataTable = Nothing
            Dim parDados As Parameter
            Dim blnReturn As Boolean

            Using cmdDados As New Command(Me.Key)

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_exist_loteria_dezena")

                    'id_loteria
                    parDados = New Parameter
                    parDados.Name = "@id_loteria"
                    parDados.Value = intLoteria
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    dtResults = cmdDados.GetDataTable

                    If dtResults.Rows.Count > 0 Then
                        blnReturn = True
                    Else
                        blnReturn = False
                    End If

                    cmdDados.Dispose()
                    dtResults = Nothing

                Catch ex As Exception
                    cmdDados.Dispose()
                    dtResults.Dispose()
                    dtResults = Nothing
                    Throw ex
                End Try
            End Using

            Return blnReturn

        End Function

#End Region

    End Class
End Namespace