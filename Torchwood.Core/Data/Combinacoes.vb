Imports Consumer.Data

Namespace Data
    Public Class Combinacoes
        Implements IDisposable
        Private strKey As String

        Private disposedValue As Boolean = False        ' To detect redundant calls

        Public Sub New()

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

#Region "Analise da MegaSena"

        ''' <summary>
        ''' Verifica a existencia de senas no historico com as dezenas selecionadas
        ''' Desta forma elimina se das analises os jogos já sorteados
        ''' </summary>
        ''' <param name="oMegaSena">Dezenas para serem analisadas</param>
        ''' <returns>True se houver uma ocorrencia</returns>
        ''' <remarks></remarks>
        Public Function VerificaSenasNaMega(ByVal oMegaSena As Struct.Combinacoes.MegaSena) As Boolean

            Dim dtResults As DataTable = Nothing
            Dim blnResults As Boolean
            Dim oParameter As Parameter

            Using cmdDados As Command = New Command(Me.Key)
                Try
                    blnResults = True

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_ver_sena_megasena"

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena01"
                    oParameter.Value = oMegaSena.Dezena01
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena02"
                    oParameter.Value = oMegaSena.Dezena02
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena03"
                    oParameter.Value = oMegaSena.Dezena03
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena04"
                    oParameter.Value = oMegaSena.Dezena04
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena05"
                    oParameter.Value = oMegaSena.Dezena05
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena06"
                    oParameter.Value = oMegaSena.Dezena06
                    cmdDados.Parameters.Add(oParameter)

                    dtResults = cmdDados.GetDataTable

                    If dtResults.Rows.Count > 0 Then
                        blnResults = True
                    Else
                        blnResults = False
                    End If

                    dtResults = Nothing
                    cmdDados.Dispose()

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    blnResults = True
                    Throw ex
                End Try
            End Using

            Return blnResults

        End Function

        ''' <summary>
        ''' Verifica a existencia de quinas no historico com as dezenas selecionadas
        ''' </summary>
        ''' <param name="oMegaSena">Dezenas para serem analisadas</param>
        ''' <returns>True se houver uma ocorrencia</returns>
        ''' <remarks></remarks>
        Public Function VerificaQuinasNaMega(ByVal oMegaSena As Struct.Combinacoes.MegaSena) As Boolean

            Dim dtResults As DataTable = Nothing
            Dim blnResults As Boolean
            Dim oParameter As Parameter

            Using cmdDados As Command = New Command(Me.Key)
                Try
                    blnResults = True

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_ver_quina_megasena"

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena01"
                    oParameter.Value = oMegaSena.Dezena01
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena02"
                    oParameter.Value = oMegaSena.Dezena02
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena03"
                    oParameter.Value = oMegaSena.Dezena03
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena04"
                    oParameter.Value = oMegaSena.Dezena04
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena05"
                    oParameter.Value = oMegaSena.Dezena05
                    cmdDados.Parameters.Add(oParameter)

                    dtResults = cmdDados.GetDataTable

                    If dtResults.Rows.Count > 0 Then
                        blnResults = True
                    Else
                        blnResults = False
                    End If

                    dtResults = Nothing
                    cmdDados.Dispose()

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    blnResults = True
                    Throw ex
                End Try
            End Using

            Return blnResults

        End Function

        ''' <summary>
        ''' Verifica a existencia de quadras no historico com as dezenas selecionadas
        ''' </summary>
        ''' <param name="oMegaSena">Dezenas para serem analisadas</param>
        ''' <returns>True se houver uma ocorrencia</returns>
        ''' <remarks></remarks>
        Public Function VerificaQuadrasNaMega(ByVal oMegaSena As Struct.Combinacoes.MegaSena) As Boolean

            Dim dtResults As DataTable = Nothing
            Dim blnResults As Boolean
            Dim oParameter As Parameter

            Using cmdDados As Command = New Command(Me.Key)
                Try
                    blnResults = True

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_ver_quadra_megasena"

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena01"
                    oParameter.Value = oMegaSena.Dezena01
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena02"
                    oParameter.Value = oMegaSena.Dezena02
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena03"
                    oParameter.Value = oMegaSena.Dezena03
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena04"
                    oParameter.Value = oMegaSena.Dezena04
                    cmdDados.Parameters.Add(oParameter)

                    dtResults = cmdDados.GetDataTable

                    If dtResults.Rows.Count > 0 Then
                        blnResults = True
                    Else
                        blnResults = False
                    End If

                    dtResults = Nothing
                    cmdDados.Dispose()

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    blnResults = True
                    Throw ex
                End Try
            End Using

            Return blnResults

        End Function

#End Region

#Region "Análise da Lotofácil"

        ''' <summary>
        ''' Verifica a existencia de senas no historico com as dezenas selecionadas
        ''' Desta forma elimina se das analises os jogos já sorteados
        ''' </summary>
        ''' <param name="oLotoFacil">Dezenas para serem analisadas</param> 
        ''' <returns>True se houver uma ocorrencia</returns>
        ''' <remarks></remarks>
        Public Function Verifica15NaLotoFacil(ByVal oLotoFacil As Struct.Combinacoes.LotoFacil) As Boolean

            Dim dtResults As DataTable = Nothing
            Dim blnResults As Boolean
            Dim oParameter As Parameter

            Using cmdDados As Command = New Command(Me.Key)
                Try
                    blnResults = True

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_ver_15_lotofacil"

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena01"
                    oParameter.Value = oLotoFacil.Dezena01
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena02"
                    oParameter.Value = oLotoFacil.Dezena02
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena03"
                    oParameter.Value = oLotoFacil.Dezena03
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena04"
                    oParameter.Value = oLotoFacil.Dezena04
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena05"
                    oParameter.Value = oLotoFacil.Dezena05
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena06"
                    oParameter.Value = oLotoFacil.Dezena06
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena07"
                    oParameter.Value = oLotoFacil.Dezena07
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena08"
                    oParameter.Value = oLotoFacil.Dezena08
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena09"
                    oParameter.Value = oLotoFacil.Dezena09
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena10"
                    oParameter.Value = oLotoFacil.Dezena10
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena11"
                    oParameter.Value = oLotoFacil.Dezena11
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena12"
                    oParameter.Value = oLotoFacil.Dezena12
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena13"
                    oParameter.Value = oLotoFacil.Dezena13
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena14"
                    oParameter.Value = oLotoFacil.Dezena14
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena15"
                    oParameter.Value = oLotoFacil.Dezena15
                    cmdDados.Parameters.Add(oParameter)


                    dtResults = cmdDados.GetDataTable

                    If dtResults.Rows.Count > 0 Then
                        blnResults = True
                    Else
                        blnResults = False
                    End If

                    dtResults = Nothing
                    cmdDados.Dispose()

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    blnResults = True
                    Throw ex
                End Try
            End Using

            Return blnResults

        End Function

        ''' <summary>
        ''' Verifica a existencia de 14 dezenas no historico com as dezenas selecionadas
        ''' Desta forma elimina se das analises os jogos já sorteados
        ''' </summary>
        ''' <param name="oLotoFacil">Dezenas para serem analisadas</param> 
        ''' <returns>True se houver uma ocorrencia</returns>
        ''' <remarks></remarks>
        Public Function Verifica14NaLotoFacil(ByVal oLotoFacil As Struct.Combinacoes.LotoFacil) As Boolean

            Dim dtResults As DataTable = Nothing
            Dim blnResults As Boolean
            Dim oParameter As Parameter

            Using cmdDados As Command = New Command(Me.Key)
                Try
                    blnResults = True

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_ver_14_lotofacil"

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena01"
                    oParameter.Value = oLotoFacil.Dezena01
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena02"
                    oParameter.Value = oLotoFacil.Dezena02
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena03"
                    oParameter.Value = oLotoFacil.Dezena03
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena04"
                    oParameter.Value = oLotoFacil.Dezena04
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena05"
                    oParameter.Value = oLotoFacil.Dezena05
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena06"
                    oParameter.Value = oLotoFacil.Dezena06
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena07"
                    oParameter.Value = oLotoFacil.Dezena07
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena08"
                    oParameter.Value = oLotoFacil.Dezena08
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena09"
                    oParameter.Value = oLotoFacil.Dezena09
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena10"
                    oParameter.Value = oLotoFacil.Dezena10
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena11"
                    oParameter.Value = oLotoFacil.Dezena11
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena12"
                    oParameter.Value = oLotoFacil.Dezena12
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena13"
                    oParameter.Value = oLotoFacil.Dezena13
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena14"
                    oParameter.Value = oLotoFacil.Dezena14
                    cmdDados.Parameters.Add(oParameter)

                    dtResults = cmdDados.GetDataTable

                    If dtResults.Rows.Count > 0 Then
                        blnResults = True
                    Else
                        blnResults = False
                    End If

                    dtResults = Nothing
                    cmdDados.Dispose()

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    blnResults = True
                    Throw ex
                End Try
            End Using

            Return blnResults

        End Function

        ''' <summary>
        ''' Verifica a existencia de 13 dezenas no historico com as dezenas selecionadas
        ''' Desta forma elimina se das analises os jogos já sorteados
        ''' </summary>
        ''' <param name="oLotoFacil">Dezenas para serem analisadas</param> 
        ''' <returns>True se houver uma ocorrencia</returns>
        ''' <remarks></remarks>
        Public Function Verifica13NaLotoFacil(ByVal oLotoFacil As Struct.Combinacoes.LotoFacil) As Boolean

            Dim dtResults As DataTable = Nothing
            Dim blnResults As Boolean
            Dim oParameter As Parameter

            Using cmdDados As Command = New Command(Me.Key)
                Try
                    blnResults = True

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_ver_13_lotofacil"

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena01"
                    oParameter.Value = oLotoFacil.Dezena01
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena02"
                    oParameter.Value = oLotoFacil.Dezena02
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena03"
                    oParameter.Value = oLotoFacil.Dezena03
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena04"
                    oParameter.Value = oLotoFacil.Dezena04
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena05"
                    oParameter.Value = oLotoFacil.Dezena05
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena06"
                    oParameter.Value = oLotoFacil.Dezena06
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena07"
                    oParameter.Value = oLotoFacil.Dezena07
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena08"
                    oParameter.Value = oLotoFacil.Dezena08
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena09"
                    oParameter.Value = oLotoFacil.Dezena09
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena10"
                    oParameter.Value = oLotoFacil.Dezena10
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena11"
                    oParameter.Value = oLotoFacil.Dezena11
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena12"
                    oParameter.Value = oLotoFacil.Dezena12
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena13"
                    oParameter.Value = oLotoFacil.Dezena13
                    cmdDados.Parameters.Add(oParameter)

                    dtResults = cmdDados.GetDataTable

                    If dtResults.Rows.Count > 0 Then
                        blnResults = True
                    Else
                        blnResults = False
                    End If

                    dtResults = Nothing
                    cmdDados.Dispose()

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    blnResults = True
                    Throw ex
                End Try
            End Using

            Return blnResults

        End Function

        ''' <summary>
        ''' Verifica a existencia de 12 dezenas no historico com as dezenas selecionadas
        ''' Desta forma elimina se das analises os jogos já sorteados
        ''' </summary>
        ''' <param name="oLotoFacil">Dezenas para serem analisadas</param> 
        ''' <returns>True se houver uma ocorrencia</returns>
        ''' <remarks></remarks>
        Public Function Verifica12NaLotoFacil(ByVal oLotoFacil As Struct.Combinacoes.LotoFacil) As Boolean

            Dim dtResults As DataTable = Nothing
            Dim blnResults As Boolean
            Dim oParameter As Parameter

            Using cmdDados As Command = New Command(Me.Key)
                Try
                    blnResults = True

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_ver_12_lotofacil"

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena01"
                    oParameter.Value = oLotoFacil.Dezena01
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena02"
                    oParameter.Value = oLotoFacil.Dezena02
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena03"
                    oParameter.Value = oLotoFacil.Dezena03
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena04"
                    oParameter.Value = oLotoFacil.Dezena04
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena05"
                    oParameter.Value = oLotoFacil.Dezena05
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena06"
                    oParameter.Value = oLotoFacil.Dezena06
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena07"
                    oParameter.Value = oLotoFacil.Dezena07
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena08"
                    oParameter.Value = oLotoFacil.Dezena08
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena09"
                    oParameter.Value = oLotoFacil.Dezena09
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena10"
                    oParameter.Value = oLotoFacil.Dezena10
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena11"
                    oParameter.Value = oLotoFacil.Dezena11
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_dezena12"
                    oParameter.Value = oLotoFacil.Dezena12
                    cmdDados.Parameters.Add(oParameter)

                    dtResults = cmdDados.GetDataTable

                    If dtResults.Rows.Count > 0 Then
                        blnResults = True
                    Else
                        blnResults = False
                    End If

                    dtResults = Nothing
                    cmdDados.Dispose()

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    blnResults = True
                    Throw ex
                End Try
            End Using

            Return blnResults

        End Function

#End Region

#Region " IDisposable Support "
        ' IDisposable
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    ' TODO: free managed resources when explicitly called
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