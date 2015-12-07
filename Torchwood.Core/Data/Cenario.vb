Imports Torchwood.Struct
Imports Consumer.Data
Namespace Data

    Public Class Cenario
        Implements IDisposable

#Region "Variáveis"
        Private strKey As String
        Private disposedValue As Boolean = False        ' To detect redundant calls
        Private blnGetAll As Boolean
        Private oItem As Struct.Cenario
#End Region

#Region "Construtor"

        ''' <summary>
        ''' Construtor da Classe
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()

            oItem = New Struct.Cenario
            blnGetAll = False

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
        ''' Adiciona um novo cenário
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function AddCenario() As Boolean

            Dim blnRetorno As Boolean

            blnRetorno = False

            Using cmdDados As Command = New Command(Me.strKey)

                Dim parDados As New Parameter

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_add_cenario")

                    'id_loteria
                    parDados = New Parameter
                    parDados.Name = "@id_loteria"
                    parDados.Value = Item.Loteria
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'ds_cenario
                    parDados = New Parameter
                    parDados.Name = "@ds_cenario"
                    parDados.Value = Item.Cenario
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_conc_ini
                    parDados = New Parameter
                    parDados.Name = "@nr_conc_ini"
                    parDados.Value = Item.ConcursoInicial
                    parDados.DbType = DbType.DateTime
                    cmdDados.Parameters.Add(parDados)

                    'nr_conc_fim
                    parDados = New Parameter
                    parDados.Name = "@nr_conc_fim"
                    parDados.Value = Item.ConcursoFinal
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'id_cenario
                    parDados = New Parameter
                    parDados.Name = "@id_cenario"
                    parDados.Value = Item.Codigo
                    parDados.DbType = DbType.Int32
                    parDados.Direction = ParameterDirection.Output
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

        ''' <summary>
        ''' Adiciona um Item do Cenário
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function AddCenarioItem() As Boolean

            Dim blnRetorno As Boolean

            blnRetorno = False

            Using cmdDados As Command = New Command(Me.strKey)

                Dim parDados As New Parameter

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_add_cenario_item")


                    For Each iItem As Struct.CenarioItem In Item.Items
                        'zerando os parameters

                        cmdDados.Parameters.Clear()

                        'id_cenario
                        parDados = New Parameter
                        parDados.Name = "@id_cenario"
                        parDados.Value = iItem.Cenario
                        parDados.DbType = DbType.Int32
                        cmdDados.Parameters.Add(parDados)

                        'id_loteria
                        parDados = New Parameter
                        parDados.Name = "@nr_item"
                        parDados.Value = iItem.Item
                        parDados.DbType = DbType.Int32
                        cmdDados.Parameters.Add(parDados)

                        'ds_cenario
                        parDados = New Parameter
                        parDados.Name = "@nr_faixa_de"
                        parDados.Value = iItem.FaixaInicial
                        parDados.DbType = DbType.Int32
                        cmdDados.Parameters.Add(parDados)

                        'nr_conc_ini
                        parDados = New Parameter
                        parDados.Name = "@nr_faixa_ate"
                        parDados.Value = iItem.FaixaFinal
                        parDados.DbType = DbType.DateTime
                        cmdDados.Parameters.Add(parDados)

                        'nr_conc_fim
                        parDados = New Parameter
                        parDados.Name = "@ds_ponto_medio"
                        parDados.Value = iItem.PontoMedio
                        parDados.DbType = DbType.Int32
                        cmdDados.Parameters.Add(parDados)

                        cmdDados.Execute()

                    Next

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

        ''' <summary>
        ''' Obtem dados do Cenario
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetCenario() As Boolean

            Dim dtResults As DataTable = Nothing
            Dim parDados As Parameter
            Dim blnRetorno As Boolean

            Using cmdDados As New Command(Me.strKey)

                Try

                    blnRetorno = False

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_get_cenario")

                    'id_loteria
                    parDados = New Parameter
                    parDados.Name = "@id_cenario"
                    parDados.Value = Item.Codigo
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    dtResults = cmdDados.GetDataTable

                    Item.Codigo = CInt(dtResults.Rows(0)("id_cenario").ToString())
                    Item.Cenario = dtResults.Rows(0)("ds_cenario").ToString()
                    Item.ConcursoInicial = CInt(dtResults.Rows(0)("nr_conc_ini").ToString())
                    Item.ConcursoFinal = CInt(dtResults.Rows(0)("nr_conc_fim").ToString())
                    Item.Data = Convert.ToDateTime(dtResults.Rows(0)("dt_cenario").ToString())
                    Item.Loteria = CInt(dtResults.Rows(0)("id_loteria").ToString())
                    Item.LoteriaNome = dtResults.Rows(0)("nm_loteria").ToString()

                    cmdDados.Dispose()
                    dtResults = Nothing
                    blnRetorno = True

                Catch ex As Exception
                    blnRetorno = False
                    cmdDados.Dispose()
                    dtResults.Dispose()
                    dtResults = Nothing
                End Try
            End Using

            Return blnRetorno

        End Function

        ''' <summary>
        ''' Obtem os itens do Cenario
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetCenarioItem() As List(Of Struct.CenarioItem)

            Dim dtResults As DataTable = Nothing
            Dim parDados As Parameter
            Dim oItem As Struct.CenarioItem
            Dim lstItems As List(Of Struct.CenarioItem)

            Using cmdDados As New Command(Me.strKey)

                Try
                    lstItems = New List(Of Struct.CenarioItem)

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_get_cenario_item")

                    'id_loteria
                    parDados = New Parameter
                    parDados.Name = "@id_cenario"
                    parDados.Value = Item.Codigo
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    dtResults = cmdDados.GetDataTable

                    For Each dr As DataRow In dtResults.Rows

                        oItem = New Struct.CenarioItem
                        oItem.Cenario = Convert.ToInt16(dr("id_cenario").ToString())
                        oItem.FaixaFinal = CInt(dr("ds_cenario").ToString())
                        oItem.FaixaFinal = CInt(dr("nr_conc_ini").ToString())
                        oItem.PontoMedio = CInt(dr("nr_conc_fim").ToString())
                        oItem.ValorFrequenciaAbsoluta = CDbl(dr("dt_cenario").ToString())
                        oItem.ValorFrequenciaAcumulada = CDbl(dr("id_loteria").ToString())
                        oItem.PercentualFrequenciaAbsoluta = CDbl(dr("nm_loteria").ToString())
                        oItem.PercentualFrequenciaAcumulada = CDbl(dr("nm_loteria").ToString())
                        lstItems.Add(oItem)

                    Next
                    oItem = Nothing
                    cmdDados.Dispose()
                    dtResults = Nothing

                Catch ex As Exception
                    oItem = Nothing
                    lstItems = Nothing
                    cmdDados.Dispose()
                    dtResults.Dispose()
                    dtResults = Nothing
                End Try
            End Using

            Return lstItems

        End Function

        ''' <summary>
        ''' List todos os dados dos Cenarios.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ListaCenario() As List(Of Struct.Cenario)

            Dim dtResults As DataTable = Nothing
            Dim parDados As Parameter
            Dim oItem As Struct.Cenario
            Dim lstItems As List(Of Struct.Cenario)

            Using cmdDados As New Command(Me.strKey)

                Try
                    lstItems = New List(Of Struct.Cenario)

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_get_cenario_item")

                    'id_loteria
                    parDados = New Parameter
                    parDados.Name = "@id_cenario"
                    parDados.Value = Item.Codigo
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    dtResults = cmdDados.GetDataTable

                    For Each dr As DataRow In dtResults.Rows

                        oItem = New Struct.Cenario
                        Item.Codigo = CInt(dr("id_cenario").ToString())
                        oItem.Codigo = Item.Codigo
                        oItem.Cenario = dr("ds_cenario").ToString()
                        oItem.ConcursoInicial = CInt(dr("nr_conc_ini").ToString())
                        oItem.ConcursoFinal = CInt(dr("nr_conc_fim").ToString())
                        oItem.Data = Convert.ToDateTime(dr("dt_cenario").ToString())
                        oItem.Loteria = CInt(dr("id_loteria").ToString())
                        oItem.LoteriaNome = dr("nm_loteria").ToString()
                        If GetAll Then
                            oItem.Items.AddRange(Me.GetCenarioItem())
                        End If
                        lstItems.Add(oItem)

                    Next
                    oItem = Nothing
                    cmdDados.Dispose()
                    dtResults = Nothing

                Catch ex As Exception
                    oItem = Nothing
                    lstItems = Nothing
                    cmdDados.Dispose()
                    dtResults.Dispose()
                    dtResults = Nothing
                End Try
            End Using

            Return lstItems

        End Function

        Public Function DelCenario() As Boolean

            Dim blnRetorno As Boolean

            blnRetorno = False

            Using cmdDados As Command = New Command(Me.strKey)

                Dim parDados As New Parameter

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_del_cenario")

                    'id_loteria
                    parDados = New Parameter
                    parDados.Name = "@id_cenario"
                    parDados.Value = Item.Codigo
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

        ''' <summary>
        ''' Exclui um item do cenário
        ''' </summary>
        ''' <param name="intItem">Número do Item</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function DelCenarioItem(ByVal intItem As Integer) As Boolean

            Dim blnRetorno As Boolean

            blnRetorno = False

            Using cmdDados As Command = New Command(Me.Key)

                Dim parDados As New Parameter

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_del_cenario_item")

                    'id_loteria
                    parDados = New Parameter
                    parDados.Name = "@id_cenario"
                    parDados.Value = Item.Codigo
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'id_loteria
                    parDados = New Parameter
                    parDados.Name = "@id_item"
                    parDados.Value = intItem
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

        ''' <summary>
        ''' Exclui os items item do cenário
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function DelCenarioItem() As Boolean

            Dim blnRetorno As Boolean

            blnRetorno = False

            Using cmdDados As Command = New Command(Me.Key)

                Dim parDados As New Parameter

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_del_cenario_item_all")

                    'id_loteria
                    parDados = New Parameter
                    parDados.Name = "@id_cenario"
                    parDados.Value = Item.Codigo
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

        ''' <summary>
        ''' Processa os cálculos do cenário e atualiza-o
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function CalculaCenario() As Boolean

            Dim blnRetorno As Boolean

            blnRetorno = False

            Using cmdDados As Command = New Command(Me.Key)

                Dim parDados As New Parameter

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_calcula_cenario")

                    'id_loteria
                    parDados = New Parameter
                    parDados.Name = "@id_cenario"
                    parDados.Value = Item.Codigo
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

#End Region

#Region "Propriedades"
        ''' <summary>
        ''' Se traz todos os itens ou não.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GetAll() As Boolean
            Get
                Return blnGetAll
            End Get
            Set(ByVal value As Boolean)
                blnGetAll = value
            End Set
        End Property

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
        ''' Dados do Cenário
        ''' </summary>
        ''' <value>Inteiro</value>
        ''' <returns>Inteiro</returns>
        ''' <remarks></remarks>
        Public Property Item() As Struct.Cenario
            Get
                Return oItem
            End Get
            Set(ByVal value As Struct.Cenario)
                oItem = value
            End Set
        End Property

#End Region

#Region " IDisposable Support "
        ' IDisposable
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    oItem = Nothing
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