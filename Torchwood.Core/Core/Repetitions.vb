Imports Torchwood.Struct
Namespace Business
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
            Dim blnRetorno As Boolean

            Dim oData As IRepetitions
            Dim oSequences As ISequences
            Dim oResults As Data.Resultados
            Dim lstResultados As List(Of LotoFacil)
            Dim lstSequencia As IList(Of Integer)
            Dim lstResults As IList(Of Integer)

            Try
                'criando instancia dos objetos
                oData = New Data.Repetitions
                oSequences = New Sequences
                oResults = New Data.Resultados(strKey)

                '´processando a busca dos resultados
                lstResultados = oResults.GetLotoFacilResults
                'destrui a classe de resultados
                oResults = Nothing

                'processando os concursos
                For Each oItem As LotoFacil In lstResultados
                    'verificando se já existe o concurso gravado
                    If Not VerifyConcurso(TipoLoteria.LotoFacil, Convert.ToInt32(oItem.Concurso.ToString())) Then
                        'criando a lista
                        lstSequencia = New List(Of Integer)
                        lstSequencia.Add(Convert.ToInt32(oItem.Dezena01.ToString()))
                        lstSequencia.Add(Convert.ToInt32(oItem.Dezena02.ToString()))
                        lstSequencia.Add(Convert.ToInt32(oItem.Dezena03.ToString()))
                        lstSequencia.Add(Convert.ToInt32(oItem.Dezena04.ToString()))
                        lstSequencia.Add(Convert.ToInt32(oItem.Dezena05.ToString()))
                        lstSequencia.Add(Convert.ToInt32(oItem.Dezena06.ToString()))
                        lstSequencia.Add(Convert.ToInt32(oItem.Dezena07.ToString()))
                        lstSequencia.Add(Convert.ToInt32(oItem.Dezena08.ToString()))
                        lstSequencia.Add(Convert.ToInt32(oItem.Dezena09.ToString()))
                        lstSequencia.Add(Convert.ToInt32(oItem.Dezena10.ToString()))
                        lstSequencia.Add(Convert.ToInt32(oItem.Dezena11.ToString()))
                        lstSequencia.Add(Convert.ToInt32(oItem.Dezena12.ToString()))
                        lstSequencia.Add(Convert.ToInt32(oItem.Dezena13.ToString()))
                        lstSequencia.Add(Convert.ToInt32(oItem.Dezena14.ToString()))
                        lstSequencia.Add(Convert.ToInt32(oItem.Dezena15.ToString()))
                        lstResults = oSequences.GetSequences(lstSequencia)
                        For Each intOcorrencias As Integer In lstResults
                            GravaRepeticoes(TipoLoteria.LotoFacil, _
                                            Convert.ToInt32(oItem.Concurso.ToString()), _
                                            intOcorrencias)
                        Next

                    End If
                Next

                'destruindo o restante dos objetos
                oData = Nothing
                oSequences = Nothing

            Catch ex As Exception
                oData = Nothing
                oSequences = Nothing
                oResults = Nothing
                Throw ex
            End Try

            blnRetorno = False
            Return blnRetorno

        End Function

        Public Function ProcessaMegaSena() As Boolean Implements IRepetitions.ProcessaMegaSena
            Dim blnRetorno As Boolean

            Dim oData As IRepetitions
            Dim oSequences As ISequences
            Dim oResults As Data.Resultados
            Dim lstResultados As List(Of MegaSena)
            Dim lstSequencia As IList(Of Integer)
            Dim lstResults As IList(Of Integer)

            Try
                'criando instancia dos objetos
                oData = New Data.Repetitions
                oSequences = New Sequences
                oResults = New Data.Resultados(strKey)

                '´processando a busca dos resultados
                lstResultados = oResults.GetMegaSenaResults
                'destrui a classe de resultados
                oResults = Nothing

                'processando os concursos
                For Each dr As MegaSena In lstResultados
                    'verificando se já existe o concurso gravado
                    If Not VerifyConcurso(TipoLoteria.MegaSena, Convert.ToInt32(dr.Concurso.ToString())) Then
                        'criando a lista
                        lstSequencia = New List(Of Integer)
                        lstSequencia.Add(Convert.ToInt32(dr.Dezena01.ToString()))
                        lstSequencia.Add(Convert.ToInt32(dr.Dezena02.ToString()))
                        lstSequencia.Add(Convert.ToInt32(dr.Dezena03.ToString()))
                        lstSequencia.Add(Convert.ToInt32(dr.Dezena04.ToString()))
                        lstSequencia.Add(Convert.ToInt32(dr.Dezena05.ToString()))
                        lstSequencia.Add(Convert.ToInt32(dr.Dezena06.ToString()))
                        lstResults = oSequences.GetSequences(lstSequencia)
                        For Each intOcorrencias As Integer In lstResults
                            GravaRepeticoes(TipoLoteria.MegaSena, _
                                            Convert.ToInt32(dr.Concurso.ToString()), _
                                            intOcorrencias)
                        Next

                    End If
                Next

                'destruindo o restante dos objetos
                oData = Nothing
                oSequences = Nothing

            Catch ex As Exception
                oData = Nothing
                oSequences = Nothing
                oResults = Nothing
                Throw ex
            End Try

            blnRetorno = False
            Return blnRetorno

        End Function

        Public Function VerifyConcurso(ByVal intLoteria As TipoLoteria, _
                                        ByVal intConcurso As Integer) As Boolean Implements IRepetitions.VerifyConcurso
            Dim blnRetorno As Boolean
            Dim oData As IRepetitions

            oData = New Data.Repetitions(strKey)

            blnRetorno = oData.VerifyConcurso(intLoteria, intConcurso)

            Return blnRetorno

        End Function

        Public Function GravaRepeticoes(ByVal intLoteria As TipoLoteria, _
                                        ByVal intConcurso As Integer, _
                                        ByVal intOcorencias As Integer) As Boolean Implements IRepetitions.GravaRepeticoes

            Dim blnRetorno As Boolean
            Dim oData As IRepetitions

            oData = New Data.Repetitions(Me.Key)

            blnRetorno = oData.GravaRepeticoes(intLoteria, intConcurso, intOcorencias)

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
