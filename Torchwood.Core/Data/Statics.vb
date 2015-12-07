Imports Consumer.Data

Namespace Data
    Public Class Statics
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

        Public Function GenerateStatsData(ByVal intLoteria As Integer, _
                                          ByVal intFaixa As Integer) As IList(Of Struct.StatsNumbers)

            Dim dtResults As DataTable = Nothing
            Dim oResults As IList(Of Struct.StatsNumbers) = Nothing
            Dim oStruct As Struct.StatsNumbers
            Dim oParameter As Parameter

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_get_stats_all"

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_loteria"
                    oParameter.Value = intLoteria
                    cmdDados.Parameters.Add(oParameter)

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@faixa"
                    oParameter.Value = intFaixa
                    cmdDados.Parameters.Add(oParameter)

                    dtResults = cmdDados.GetDataTable

                    oResults = New List(Of Struct.StatsNumbers)
                    For Each dr As DataRow In dtResults.Rows
                        oStruct = New Struct.StatsNumbers
                        oStruct.Faixa = Convert.ToInt32(dr("id_faixa").ToString())
                        oStruct.FaixaInicio = Convert.ToInt32(dr("id_faixa_ini").ToString())
                        oStruct.FaixaFinal = Convert.ToInt32(dr("id_faixa_fim").ToString())
                        oStruct.Dezena = Convert.ToInt32(dr("nr_dezena").ToString())
                        oStruct.DescFaixa = dr("ds_faixa").ToString()
                        oStruct.IsSuperiorFaixa = dr("ind_dezena_sup_faixa").ToString()
                        oStruct.IsSuperiorRound = dr("ind_dezena_sup_round").ToString()
                        oStruct.MediaAritimetica = Convert.ToDouble(dr("media_arit_sorteio").ToString())
                        oStruct.MediaFaixa = Convert.ToDouble(dr("pc_media_faixa").ToString())
                        oStruct.MediaFaixaRound = Convert.ToDouble(dr("pc_media_faixa_round").ToString())
                        oStruct.PercentualDezena = Convert.ToDouble(dr("pc_dezena").ToString())
                        oStruct.PercentualDezenaTotal = Convert.ToDouble(dr("pc_dezena_total").ToString())
                        oStruct.QuantidadeDezenas = Convert.ToDouble(dr("qt_dezena").ToString())
                        oStruct.QuantidadeDezenaSuperiorFaixa = Convert.ToDouble(dr("qt_dezena_sup_faixa").ToString())
                        oStruct.QuantidadeDezenaSuperiorRound = Convert.ToDouble(dr("qt_dezena_sup_round").ToString())
                        oStruct.TotalConcursos = Convert.ToDouble(dr("total_concursos").ToString())
                        oStruct.TotalDezenas = Convert.ToDouble(dr("total_dezenas").ToString())
                        oResults.Add(oStruct)
                    Next

                    dtResults = Nothing
                    cmdDados.Dispose()

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    oResults = Nothing
                    Throw ex
                End Try
            End Using

            Return oResults

        End Function

        Public Function GenerateStatsDataDezenas(ByVal intLoteria As Integer) As IList(Of Struct.StatsData)

            Dim dtResults As DataTable = Nothing
            Dim oResults As IList(Of Struct.StatsData) = Nothing
            Dim oStruct As Struct.StatsData
            Dim oParameter As Parameter

            Using cmdDados As Command = New Command(Me.Key)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandText = "pr_tor_sel_stats_best_dezenas"

                    oParameter = New Parameter
                    oParameter.DbType = DbType.Int16
                    oParameter.Name = "@id_loteria"
                    oParameter.Value = intLoteria
                    cmdDados.Parameters.Add(oParameter)

                    dtResults = cmdDados.GetDataTable

                    oResults = New List(Of Struct.StatsData)

                    For Each dr As DataRow In dtResults.Rows
                        oStruct = New Struct.StatsData
                        With oStruct
                            .Dezena = CInt(dr("nr_dezena"))
                            .ValorTodos = New Struct.StatsDataItem(CInt(dr("qt_occur_all")), _
                                                                   CInt(dr("qt_concursos_all")), _
                                                                   CDbl(dr("pc_relativo_all")), _
                                                                   CDbl(dr("pc_total_all")))
                            .ValorImpares = New Struct.StatsDataItem(CInt(dr("qt_occur_top_i")), _
                                                                     CInt(dr("qt_concursos_top_i")), _
                                                                     CDbl(dr("pc_relativo_top_i")), _
                                                                     CDbl(dr("pc_total_top_i")))
                            .ValorPares = New Struct.StatsDataItem(CInt(dr("qt_occur_top_2")), _
                                                                   CInt(dr("qt_concursos_top_2")), _
                                                                   CDbl(dr("pc_relativo_top_2")), _
                                                                   CDbl(dr("pc_total_top_2")))
                            .ValorTop3 = New Struct.StatsDataItem(CInt(dr("qt_occur_top_3")), _
                                                                  CInt(dr("qt_concursos_top_3")), _
                                                                  CDbl(dr("pc_relativo_top_3")), _
                                                                  CDbl(dr("pc_total_top_3")))
                            .ValorTop4 = New Struct.StatsDataItem(CInt(dr("qt_occur_top_4")), _
                                                                  CInt(dr("qt_concursos_top_4")), _
                                                                  CDbl(dr("pc_relativo_top_4")), _
                                                                  CDbl(dr("pc_total_top_4")))
                            .ValorTop5 = New Struct.StatsDataItem(CInt(dr("qt_occur_top_5")), _
                                                                  CInt(dr("qt_concursos_top_5")), _
                                                                  CDbl(dr("pc_relativo_top_5")), _
                                                                  CDbl(dr("pc_total_top_5")))
                            .ValorTop6 = New Struct.StatsDataItem(CInt(dr("qt_occur_top_6")), _
                                                                  CInt(dr("qt_concursos_top_6")), _
                                                                  CDbl(dr("pc_relativo_top_6")), _
                                                                  CDbl(dr("pc_total_top_6")))
                            .ValorTop7 = New Struct.StatsDataItem(CInt(dr("qt_occur_top_7")), _
                                                                  CInt(dr("qt_concursos_top_7")), _
                                                                  CDbl(dr("pc_relativo_top_7")), _
                                                                  CDbl(dr("pc_total_top_7")))
                            .ValorTop8 = New Struct.StatsDataItem(CInt(dr("qt_occur_top_8")), _
                                                                  CInt(dr("qt_concursos_top_8")), _
                                                                  CDbl(dr("pc_relativo_top_8")), _
                                                                  CDbl(dr("pc_total_top_8")))
                            .ValorTop9 = New Struct.StatsDataItem(CInt(dr("qt_occur_top_9")), _
                                                                  CInt(dr("qt_concursos_top_9")), _
                                                                  CDbl(dr("pc_relativo_top_9")), _
                                                                  CDbl(dr("pc_total_top_9")))
                            .ValorTop10 = New Struct.StatsDataItem(CInt(dr("qt_occur_top_10")), _
                                                                  CInt(dr("qt_concursos_top_10")), _
                                                                  CDbl(dr("pc_relativo_top_10")), _
                                                                  CDbl(dr("pc_total_top_10")))
                            .ValorTop11 = New Struct.StatsDataItem(CInt(dr("qt_occur_top_11")), _
                                                                   CInt(dr("qt_concursos_top_11")), _
                                                                   CDbl(dr("pc_relativo_top_11")), _
                                                                   CDbl(dr("pc_total_top_11")))
                        End With
                        oResults.Add(oStruct)
                    Next

                    dtResults = Nothing
                    cmdDados.Dispose()

                Catch ex As Exception
                    dtResults.Dispose()
                    dtResults = Nothing
                    oResults = Nothing
                    Throw ex
                End Try
            End Using

            Return oResults

        End Function

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