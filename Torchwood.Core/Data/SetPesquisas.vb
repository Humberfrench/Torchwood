Imports Consumer.Data
Imports Torchwood.Struct

Namespace Data
    Public Class SetPesquisas
        Implements IDisposable

#Region "Construtores"
        Private strKey As String
        Private disposedValue As Boolean = False        ' To detect redundant calls
        Private oSet As SetPesquisa
        Private blnLoadAll As Boolean

        ''' <summary>
        ''' Construtor
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()
            strKey = ""
            blnLoadAll = False
            oSet = New SetPesquisa
        End Sub

        ''' <summary>
        ''' Construtor
        ''' </summary>
        ''' <param name="pstrKey">Chave de conexão com o Banco de Dados</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal pstrKey As String)

            Me.New()
            strKey = pstrKey
            oSet = New SetPesquisa
        End Sub

        ''' <summary>
        ''' Construtor
        ''' </summary>
        ''' <param name="pIntCodigoSet">Código do Set</param>
        ''' <param name="pIntLoteria">Código da Loteria</param>
        ''' <param name="pStrNome">Nome do Set de Consulta</param>
        ''' <param name="pDatConsulta">Data da Consulta</param>
        ''' <param name="pLstDezenas">Lista de Dezenas</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal pIntCodigoSet As Integer, _
               ByVal pIntLoteria As Integer, _
               ByVal pStrNome As String, _
               ByVal pDatConsulta As DateTime, _
               ByVal pLstDezenas As List(Of Integer))

            Me.New()
            oSet = New SetPesquisa(pIntCodigoSet, pIntLoteria, pStrNome, pDatConsulta, pLstDezenas)

        End Sub

        ''' <summary>
        ''' Construtor
        ''' </summary>
        ''' <param name="pstrKey">Chave de conexão com o Banco de Dados</param>
        ''' <param name="pIntCodigoSet">Código do Set</param>
        ''' <param name="pIntLoteria">Código da Loteria</param>
        ''' <param name="pStrNome">Nome do Set de Consulta</param>
        ''' <param name="pDatConsulta">Data da Consulta</param>
        ''' <param name="pLstDezenas">Lista de Dezenas</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal pstrKey As String, _
                       ByVal pIntCodigoSet As Integer, _
                       ByVal pIntLoteria As Integer, _
                       ByVal pStrNome As String, _
                       ByVal pDatConsulta As DateTime, _
                       ByVal pLstDezenas As List(Of Integer))

            Me.New()
            strKey = pstrKey
            oSet = New SetPesquisa(pIntCodigoSet, pIntLoteria, pStrNome, pDatConsulta, pLstDezenas)

        End Sub

        ''' <summary>
        ''' Construtor
        ''' </summary>
        ''' <param name="pstrKey">Chave de conexão com o Banco de Dados</param>
        ''' <param name="pIntCodigoSet">Código do Set</param>
        ''' <param name="pIntLoteria">Código da Loteria</param>
        ''' <param name="pIntConcursoInicial">Concurso Inicial</param>
        ''' <param name="pIntConcursoFinal">Concurso Final</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal pstrKey As String, _
                        ByVal pIntCodigoSet As Integer, _
                        ByVal pIntLoteria As Integer, _
                        ByVal pIntConcursoInicial As Integer, _
                        ByVal pIntConcursoFinal As Integer)

            Me.New()
            strKey = pstrKey
            oSet = New SetPesquisa(pIntCodigoSet, pIntLoteria, pIntConcursoInicial, pIntConcursoFinal)

        End Sub

#End Region

#Region "Propriedades"

        ''' <summary>
        ''' Valor do Set de Pesquisa
        ''' </summary>
        ''' <value>SetPesquisa</value>
        ''' <returns>SetPesquisa</returns>
        ''' <remarks></remarks>
        Public ReadOnly Property Item() As SetPesquisa
            Get
                Return oSet
            End Get
        End Property

        ''' <summary>
        ''' Chave de Conexão do Banco de Dados
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
        ''' Se true, carrega as Dezenas do Set na lista.
        ''' </summary>
        ''' <value>Boolean</value>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Property LoadAll() As Boolean
            Get
                Return blnLoadAll
            End Get
            Set(ByVal value As Boolean)
                blnLoadAll = value
            End Set
        End Property

#End Region

#Region "Métodos"

        ''' <summary>
        ''' Cria um Novo Set de Dados
        ''' </summary>
        ''' <returns>Integer, Código do Set</returns>
        ''' <remarks></remarks>
        Public Function Add() As Integer

            Dim intCodigo As Integer
            Using cmdDados As Command = New Command(Me.Key)
                Try

                    intCodigo = 0

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_add_set_dados"


                    cmdDados.CreateParameter("@id_loteria", _
                                             DbType.Int32, _
                                             0, _
                                             Item.Loteria)

                    cmdDados.CreateParameter("@ds_nome", _
                                             DbType.String, _
                                             50, _
                                             Item.Nome)

                    intCodigo = CInt(cmdDados.ExecuteScalar())
                    Me.Item.Codigo = intCodigo
                    AddDezena()

                Catch ex As Exception
                    intCodigo = 0
                    Throw ex
                End Try
            End Using

            Return intCodigo

        End Function

        ''' <summary>
        ''' Adiciona todas as Dezenas da Lista
        ''' </summary>
        ''' <returns>Boolean, true se OK</returns>
        ''' <remarks></remarks>
        Public Function AddDezena() As Boolean

            Try
                For Each intDezena As Integer In Item.Dezenas
                    AddDezena(intDezena)
                Next
            Catch ex As Exception
                Throw ex
            End Try

            Return True

        End Function

        ''' <summary>
        ''' Adiciona uma Dezena no set
        ''' </summary>
        ''' <returns>Boolean, true se OK</returns>
        ''' <remarks></remarks>
        Public Function AddDezena(ByVal intDezena As Integer) As Boolean
            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_add_set_dados_dezenas"


                    cmdDados.CreateParameter("@id_set", _
                                             DbType.Int32, _
                                             0, _
                                             Item.Codigo)

                    cmdDados.CreateParameter("@nr_dezena", _
                                             DbType.Int32, _
                                             0, _
                                             intDezena)

                    cmdDados.ExecuteNonQuery()


                Catch ex As Exception
                    Throw ex
                End Try
            End Using

            Return True


        End Function

        ''' <summary>
        ''' Obtem um registro do Set de Dados
        ''' </summary>
        ''' <returns>Boolean, true se ok</returns>
        ''' <remarks></remarks>
        Public Function [Get]() As Boolean
            Dim dtResults As New DataTable

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_get_set_dados"


                    cmdDados.CreateParameter("@id_set", _
                                             DbType.Int32, _
                                             0, _
                                             Item.Codigo)

                    dtResults = cmdDados.GetDataTable

                    If dtResults.Rows.Count > 0 Then
                        Item.DataConsulta = CDate(dtResults.Rows(0).Item("dt_consulta"))
                        Item.Loteria = CInt(dtResults.Rows(0).Item("id_loteria"))
                        Item.Nome = dtResults.Rows(0).Item("ds_nome").ToString()
                        Item.NomeLoteria = dtResults.Rows(0).Item("nm_loteria").ToString()
                    End If

                    'carrega as dezenas
                    Item.Dezenas.AddRange(Me.GetDezenas)

                    dtResults.Dispose()
                    dtResults = Nothing

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    Throw ex
                End Try
            End Using

            Return True

        End Function

        ''' <summary>
        ''' Lista todas as Pesquisas. 
        ''' Caso a propriedade LoadAll esteja setada para True, lista as dezenas e acopla na lista
        ''' </summary>
        ''' <returns>List(Of SetPesquisa)</returns>
        ''' <remarks></remarks>
        Public Function List() As List(Of SetPesquisa)

            Dim dtResults As New DataTable
            Dim lstResultado As List(Of SetPesquisa)
            Dim oSetPesquisa As SetPesquisa

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_list_set_dados"

                    dtResults = cmdDados.GetDataTable

                    lstResultado = New List(Of SetPesquisa)
                    For Each dr As DataRow In dtResults.Rows
                        oSetPesquisa = New SetPesquisa
                        oSetPesquisa.Codigo = CInt(dr.Item("id_set"))
                        oSetPesquisa.DataConsulta = CDate(dr.Item("dt_consulta"))
                        oSetPesquisa.Loteria = CInt(dr.Item("id_loteria"))
                        oSetPesquisa.Nome = dr.Item("ds_nome").ToString()
                        oSetPesquisa.NomeLoteria = dr.Item("nm_loteria").ToString()
                        If LoadAll Then
                            Item.Codigo = oSetPesquisa.Codigo
                            oSetPesquisa.Dezenas.AddRange(Me.GetDezenas)
                        End If
                        lstResultado.Add(oSetPesquisa)
                    Next

                    Item.Codigo = 0
                    dtResults.Dispose()
                    dtResults = Nothing
                    oSetPesquisa = Nothing

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    lstResultado = Nothing
                    oSetPesquisa = Nothing
                    Throw ex
                End Try
            End Using

            Return lstResultado
        End Function

        ''' <summary>
        ''' Obtem as dezenas do Set de Pesquisa
        ''' </summary>
        ''' <returns>Lista com as Dezenas</returns>
        ''' <remarks></remarks>
        Public Function GetDezenas() As List(Of Integer)

            Dim dtResults As New DataTable
            Dim lstResultado As List(Of Integer)

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_list_set_dados_dezenas"

                    cmdDados.CreateParameter("@id_set", _
                                             DbType.Int32, _
                                             0, _
                                             Item.Codigo)

                    dtResults = cmdDados.GetDataTable

                    lstResultado = New List(Of Integer)
                    For Each dr As DataRow In dtResults.Rows
                        lstResultado.Add(CInt(dr.Item("nr_dezena")))
                    Next

                    dtResults.Dispose()
                    dtResults = Nothing

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    lstResultado = Nothing
                    Throw ex
                End Try
            End Using

            Return lstResultado

        End Function

        ''' <summary>
        ''' Exclui um Set de Pesquisas, incluindo as dezenas
        ''' </summary>
        ''' <returns>True, se OK</returns>
        ''' <remarks></remarks>
        Public Function Del() As Boolean

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_del_set_dados"


                    cmdDados.CreateParameter("@id_set", _
                                             DbType.Int32, _
                                             0, _
                                             Item.Codigo)

                    cmdDados.ExecuteNonQuery()


                Catch ex As Exception
                    Throw ex
                End Try
            End Using

            Return True


        End Function

        ''' <summary>
        ''' Exclui as dezenas de um Set de Pesquisas
        ''' </summary>
        ''' <returns>True se OK</returns>
        ''' <remarks></remarks>
        Public Function DelDezenas() As Boolean

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_del_set_dados_dezenas_all"


                    cmdDados.CreateParameter("@id_set", _
                                             DbType.Int32, _
                                             0, _
                                             Item.Codigo)

                    cmdDados.ExecuteNonQuery()


                Catch ex As Exception
                    Throw ex
                End Try
            End Using

            Return True


        End Function

        ''' <summary>
        ''' Exclui as dezenas de um Set de Pesquisas
        ''' </summary>
        ''' <param name="intDezena">Dezena a ser excluida</param>
        ''' <returns>True se OK</returns>
        ''' <remarks></remarks>
        Public Function DelDezenas(ByVal intDezena As Integer) As Boolean

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_del_set_dados_dezenas"


                    cmdDados.CreateParameter("@id_set", _
                                             DbType.Int32, _
                                             0, _
                                             Item.Codigo)

                    cmdDados.CreateParameter("@id_nr_dezena", _
                                            DbType.Int16, _
                                            0, _
                                            intDezena)

                    cmdDados.ExecuteNonQuery()


                Catch ex As Exception
                    Throw ex
                End Try
            End Using

            Return True


        End Function

        ''' <summary>
        ''' Atualiza o Set de Dados e as Dezenas.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Update() As Boolean

            Try

                Me.DelDezenas()
                Me.AddDezena()

            Catch ex As Exception
                Throw ex
            End Try

            Return True

        End Function

        ''' <summary>
        ''' Método que pegaas dezenas de um set considerando a quantidade mínima de ocorrências
        ''' </summary>
        ''' <returns>Lista de Resultados</returns>
        ''' <remarks></remarks>
        Public Function GetDezenaSet() As List(Of Struct.SetResults)

            Return GetDezenasSets("pr_tor_get_results_set")

        End Function

        ''' <summary>
        ''' Método de Apoio do GetDezenaSet e GetDezenaSetAll, como são os mesmos, chamam os 
        ''' mesmos resultados apenas por procs diferetes, unifica-se o método para reaproveitamento melhor
        ''' do Código
        ''' </summary>
        ''' <param name="strProcedure">Nome da procedure</param>
        ''' <returns>Lista de Resultados</returns>
        ''' <remarks></remarks>
        Private Function GetDezenasSets(ByVal strProcedure As String) As List(Of Struct.SetResults)

            Dim dtResults As New DataTable
            Dim lstResultado As List(Of SetResults)
            Dim oSetPesquisa As SetResults

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = strProcedure
                    cmdDados.CreateParameter("@id_loteria", DbType.Int32, 0, Item.Loteria)
                    cmdDados.CreateParameter("@id_set", DbType.Int32, 0, Item.Codigo)
                    cmdDados.CreateParameter("@conc_ini", DbType.Int32, 0, Item.ConcursoInicial)
                    cmdDados.CreateParameter("@conc_fim", DbType.Int32, 0, Item.ConcursoFinal)

                    dtResults = cmdDados.GetDataTable

                    lstResultado = LoadDezenas(dtResults)

                    dtResults.Dispose()
                    dtResults = Nothing
                    oSetPesquisa = Nothing

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    lstResultado = Nothing
                    oSetPesquisa = Nothing
                    Throw ex
                End Try
            End Using

            Return lstResultado
        End Function

        ''' <summary>
        ''' Método que pega todas as dezenas de um set NÃO considerando a quantidade mínima de ocorrências
        ''' </summary>
        ''' <returns>Lista de Resultados</returns>
        ''' <remarks></remarks>
        Public Function GetDezenasSetAll() As List(Of Struct.SetResults)

            Return GetDezenasSets("pr_tor_get_results_set_all")

        End Function

        ''' <summary>
        ''' Método de Apoio dos Gets de Dezenas para carregar os dados centralizados de forma única.
        ''' </summary>
        ''' <param name="dtResults">DataSet</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function LoadDezenas(ByRef dtResults As DataTable) As List(Of Struct.SetResults)

            Dim lstResultado As List(Of SetResults)
            Dim oSetPesquisa As SetResults

            lstResultado = New List(Of SetResults)
            For Each dr As DataRow In dtResults.Rows
                oSetPesquisa = New SetResults
                oSetPesquisa.Concurso = CInt(dr.Item("nr_concurso"))
                oSetPesquisa.DataConcurso = CDate(dr.Item("dt_concurso"))
                oSetPesquisa.PercentualEficiencia = CDbl(dr.Item("pc_eficiencia"))
                oSetPesquisa.QuantidadeDezenas = CInt(dr.Item("qt_dezenas"))
                lstResultado.Add(oSetPesquisa)
            Next

            Return lstResultado

        End Function

#End Region

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