Namespace Data
    Public Class Excel
        Private strKey As String

#Region "Construtor"

        ''' <summary>
        ''' Construtor da Classe
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()

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
        ''' Executa a leiruta do excel chamando componete Business, 
        ''' e grava as dezenas importadas
        ''' </summary>
        ''' <param name="strFileName">Caminho do Arquivo</param>
        ''' <param name="intPlanilha">Número da Planilha</param>
        ''' <returns>Quantodade de concursos Importados</returns>
        ''' <remarks></remarks>
        Public Function ImportsMegaSena(ByVal strFileName As String, _
                                        ByVal intPlanilha As Integer) As Integer

            Dim oData As Data.Dezenas
            Dim intRetorno As Integer
            Dim oExcel As Business.Excel
            Dim lMegaSena As List(Of Struct.MegaSena)

            Try

                intRetorno = 0
                oExcel = New Business.Excel(Me.Key)
                oData = New Data.Dezenas(Me.Key)
                lMegaSena = oExcel.ImportarMegaSena(strFileName, intPlanilha)

                For Each oMegaSena As Struct.MegaSena In lMegaSena
                    oData.Sena.Concurso = oMegaSena.Concurso
                    oData.Sena.Data = oMegaSena.Data
                    oData.Sena.Dezena01 = oMegaSena.Dezena01
                    oData.Sena.Dezena02 = oMegaSena.Dezena02
                    oData.Sena.Dezena03 = oMegaSena.Dezena03
                    oData.Sena.Dezena04 = oMegaSena.Dezena04
                    oData.Sena.Dezena05 = oMegaSena.Dezena05
                    oData.Sena.Dezena06 = oMegaSena.Dezena06
                    oData.GravarMegaSena()
                Next

                intRetorno = lMegaSena.Count
                lMegaSena = Nothing
                oExcel = Nothing
                oData = Nothing

            Catch ex As Exception
                lMegaSena = Nothing
                oExcel = Nothing
                oData = Nothing
                intRetorno = 0
                Throw ex
            End Try

            Return intRetorno

        End Function

        ''' <summary>
        ''' Executa a leiruta do excel chamando componete Business, 
        ''' e grava as dezenas importadas
        ''' </summary>
        ''' <param name="strFileName">Caminho do Arquivo</param>
        ''' <param name="intPlanilha">Número da Planilha</param>
        ''' <returns>Quantodade de concursos Importados</returns>
        ''' <remarks></remarks>
        Public Function ImportsDuplaSenaS1(ByVal strFileName As String, _
                                           ByVal intPlanilha As Integer) As Integer

            Dim oData As Data.Dezenas
            Dim intRetorno As Integer
            Dim oExcel As Business.Excel
            Dim lDuplaSena As List(Of Struct.DuplaSena)

            Try

                intRetorno = 0
                oExcel = New Business.Excel(Me.Key)
                oData = New Data.Dezenas(Me.Key)
                lDuplaSena = oExcel.ImportarDuplaSenaS1(strFileName, intPlanilha)

                For Each oDuplaSena As Struct.DuplaSena In lDuplaSena
                    oData.Sena.Concurso = oDuplaSena.Concurso
                    oData.Sena.Data = oDuplaSena.Data
                    oData.Sena.Dezena01 = oDuplaSena.Dezena01
                    oData.Sena.Dezena02 = oDuplaSena.Dezena02
                    oData.Sena.Dezena03 = oDuplaSena.Dezena03
                    oData.Sena.Dezena04 = oDuplaSena.Dezena04
                    oData.Sena.Dezena05 = oDuplaSena.Dezena05
                    oData.Sena.Dezena06 = oDuplaSena.Dezena06
                    oData.GravarDuplaSenaS1()
                Next

                intRetorno = lDuplaSena.Count
                lDuplaSena = Nothing
                oExcel = Nothing
                oData = Nothing

            Catch ex As Exception
                lDuplaSena = Nothing
                oExcel = Nothing
                oData = Nothing
                intRetorno = 0
                Throw ex
            End Try

            Return intRetorno

        End Function

        ''' <summary>
        ''' Executa a leiruta do excel chamando componete Business, 
        ''' e grava as dezenas importadas
        ''' </summary>
        ''' <param name="strFileName">Caminho do Arquivo</param>
        ''' <param name="intPlanilha">Número da Planilha</param>
        ''' <returns>Quantodade de concursos Importados</returns>
        ''' <remarks></remarks>
        Public Function ImportsDuplaSenaS2(ByVal strFileName As String, _
                                           ByVal intPlanilha As Integer) As Integer

            Dim oData As Data.Dezenas
            Dim intRetorno As Integer
            Dim oExcel As Business.Excel
            Dim lDuplaSena As List(Of Struct.DuplaSena)

            Try

                intRetorno = 0
                oExcel = New Business.Excel(Me.Key)
                oData = New Data.Dezenas(Me.Key)
                lDuplaSena = oExcel.ImportarDuplaSenaS2(strFileName, intPlanilha)

                For Each oDuplaSena As Struct.DuplaSena In lDuplaSena
                    oData.Sena.Concurso = oDuplaSena.Concurso
                    oData.Sena.Data = oDuplaSena.Data
                    oData.Sena.Dezena01 = oDuplaSena.Dezena01
                    oData.Sena.Dezena02 = oDuplaSena.Dezena02
                    oData.Sena.Dezena03 = oDuplaSena.Dezena03
                    oData.Sena.Dezena04 = oDuplaSena.Dezena04
                    oData.Sena.Dezena05 = oDuplaSena.Dezena05
                    oData.Sena.Dezena06 = oDuplaSena.Dezena06
                    oData.GravarDuplaSenaS2()
                Next

                intRetorno = lDuplaSena.Count
                lDuplaSena = Nothing
                oExcel = Nothing
                oData = Nothing

            Catch ex As Exception
                lDuplaSena = Nothing
                oExcel = Nothing
                oData = Nothing
                intRetorno = 0
                Throw ex
            End Try

            Return intRetorno

        End Function

        ''' <summary>
        ''' Executa a leiruta do excel chamando componete Business, 
        ''' e grava as dezenas importadas
        ''' </summary>
        ''' <param name="strFileName">Caminho do Arquivo</param>
        ''' <param name="intPlanilha">Número da Planilha</param>
        ''' <returns>Quantodade de concursos Importados</returns>
        ''' <remarks></remarks>
        Public Function ImportsQuina(ByVal strFileName As String, _
                                     ByVal intPlanilha As Integer) As Integer

            Dim oData As Data.Dezenas
            Dim intRetorno As Integer
            Dim oExcel As Business.Excel
            Dim lQuina As List(Of Struct.Quina)

            Try

                intRetorno = 0
                oExcel = New Business.Excel(Me.Key)
                oData = New Data.Dezenas(Me.Key)
                lQuina = oExcel.ImportarQuina(strFileName, intPlanilha)

                For Each oQuina As Struct.Quina In lQuina
                    oData.Quina.Concurso = oQuina.Concurso
                    oData.Quina.Data = oQuina.Data
                    oData.Quina.Dezena01 = oQuina.Dezena01
                    oData.Quina.Dezena02 = oQuina.Dezena02
                    oData.Quina.Dezena03 = oQuina.Dezena03
                    oData.Quina.Dezena04 = oQuina.Dezena04
                    oData.Quina.Dezena05 = oQuina.Dezena05
                    oData.GravarQuina()
                Next

                intRetorno = lQuina.Count
                lQuina = Nothing
                oExcel = Nothing
                oData = Nothing

            Catch ex As Exception
                lQuina = Nothing
                oExcel = Nothing
                oData = Nothing
                intRetorno = 0
                Throw ex
            End Try

            Return intRetorno

        End Function

        ''' <summary>
        ''' Executa a leiruta do excel chamando componete Business, 
        ''' e grava as dezenas importadas
        ''' </summary>
        ''' <param name="strFileName">Caminho do Arquivo</param>
        ''' <param name="intPlanilha">Número da Planilha</param>
        ''' <returns>Quantodade de concursos Importados</returns>
        ''' <remarks></remarks>
        Public Function ImportsLotoFacil(ByVal strFileName As String, _
                                         ByVal intPlanilha As Integer) As Integer

            Dim oData As Data.Dezenas
            Dim intRetorno As Integer
            Dim oExcel As Business.Excel
            Dim lLotoFacil As List(Of Struct.LotoFacil)

            Try

                intRetorno = 0
                oExcel = New Business.Excel(Me.Key)
                oData = New Data.Dezenas(Me.Key)
                lLotoFacil = oExcel.ImportarLotoFacil(strFileName, intPlanilha)

                For Each oLotoFacil As Struct.LotoFacil In lLotoFacil
                    oData.LotoFacil.Concurso = oLotoFacil.Concurso
                    oData.LotoFacil.Data = oLotoFacil.Data
                    oData.LotoFacil.Dezena01 = oLotoFacil.Dezena01
                    oData.LotoFacil.Dezena02 = oLotoFacil.Dezena02
                    oData.LotoFacil.Dezena03 = oLotoFacil.Dezena03
                    oData.LotoFacil.Dezena04 = oLotoFacil.Dezena04
                    oData.LotoFacil.Dezena05 = oLotoFacil.Dezena05
                    oData.LotoFacil.Dezena06 = oLotoFacil.Dezena06
                    oData.LotoFacil.Dezena07 = oLotoFacil.Dezena07
                    oData.LotoFacil.Dezena08 = oLotoFacil.Dezena08
                    oData.LotoFacil.Dezena09 = oLotoFacil.Dezena09
                    oData.LotoFacil.Dezena10 = oLotoFacil.Dezena10
                    oData.LotoFacil.Dezena11 = oLotoFacil.Dezena11
                    oData.LotoFacil.Dezena12 = oLotoFacil.Dezena12
                    oData.LotoFacil.Dezena13 = oLotoFacil.Dezena13
                    oData.LotoFacil.Dezena14 = oLotoFacil.Dezena14
                    oData.LotoFacil.Dezena15 = oLotoFacil.Dezena15
                    oData.GravarLotoFacil()
                Next

                intRetorno = lLotoFacil.Count
                lLotoFacil = Nothing
                oExcel = Nothing
                oData = Nothing

            Catch ex As Exception
                lLotoFacil = Nothing
                oExcel = Nothing
                oData = Nothing
                intRetorno = 0
                Throw ex
            End Try

            Return intRetorno


        End Function

        ''' <summary>
        ''' Executa a leiruta do excel chamando componete Business, 
        ''' e grava as dezenas importadas
        ''' </summary>
        ''' <param name="strFileName">Caminho do Arquivo</param>
        ''' <param name="intPlanilha">Número da Planilha</param>
        ''' <returns>Quantodade de concursos Importados</returns>
        ''' <remarks></remarks>
        Public Function ImportsLotoMania(ByVal strFileName As String, _
                                          ByVal intPlanilha As Integer) As Integer

            Dim oData As Data.Dezenas
            Dim intRetorno As Integer
            Dim oExcel As Business.Excel
            Dim lLotoMania As List(Of Struct.LotoMania)

            Try

                intRetorno = 0
                oExcel = New Business.Excel(Me.Key)
                oData = New Data.Dezenas(Me.Key)
                lLotoMania = oExcel.ImportarLotoMania(strFileName, intPlanilha)

                For Each oLotoMania As Struct.LotoMania In lLotoMania
                    oData.LotoMania.Concurso = oLotoMania.Concurso
                    oData.LotoMania.Data = oLotoMania.Data
                    oData.LotoMania.Dezena01 = oLotoMania.Dezena01
                    oData.LotoMania.Dezena02 = oLotoMania.Dezena02
                    oData.LotoMania.Dezena03 = oLotoMania.Dezena03
                    oData.LotoMania.Dezena04 = oLotoMania.Dezena04
                    oData.LotoMania.Dezena05 = oLotoMania.Dezena05
                    oData.LotoMania.Dezena06 = oLotoMania.Dezena06
                    oData.LotoMania.Dezena07 = oLotoMania.Dezena07
                    oData.LotoMania.Dezena08 = oLotoMania.Dezena08
                    oData.LotoMania.Dezena09 = oLotoMania.Dezena09
                    oData.LotoMania.Dezena10 = oLotoMania.Dezena10
                    oData.LotoMania.Dezena11 = oLotoMania.Dezena11
                    oData.LotoMania.Dezena12 = oLotoMania.Dezena12
                    oData.LotoMania.Dezena13 = oLotoMania.Dezena13
                    oData.LotoMania.Dezena14 = oLotoMania.Dezena14
                    oData.LotoMania.Dezena15 = oLotoMania.Dezena15
                    oData.LotoMania.Dezena16 = oLotoMania.Dezena16
                    oData.LotoMania.Dezena17 = oLotoMania.Dezena17
                    oData.LotoMania.Dezena18 = oLotoMania.Dezena18
                    oData.LotoMania.Dezena19 = oLotoMania.Dezena19
                    oData.LotoMania.Dezena20 = oLotoMania.Dezena20
                    oData.GravarLotoMania()
                Next

                intRetorno = lLotoMania.Count
                lLotoMania = Nothing
                oExcel = Nothing
                oData = Nothing

            Catch ex As Exception
                lLotoMania = Nothing
                oExcel = Nothing
                oData = Nothing
                intRetorno = 0
                Throw ex
            End Try

            Return intRetorno

        End Function

        ''' <summary>
        ''' Executa a leiruta do excel chamando componete Business, 
        ''' e grava as dezenas importadas
        ''' </summary>
        ''' <param name="strFileName">Caminho do Arquivo</param>
        ''' <param name="intPlanilha">Número da Planilha</param>
        ''' <returns>Quantodade de concursos Importados</returns>
        ''' <remarks></remarks>
        Public Function ImportsTimeMania(ByVal strFileName As String, _
                                         ByVal intPlanilha As Integer, _
                                         ByRef strConcursos As String) As Integer

            Dim oData As Data.Dezenas
            Dim intRetorno As Integer
            Dim oExcel As Business.Excel
            Dim lTimeMania As List(Of Struct.TimeMania)


            Try

                strConcursos = String.Empty
                intRetorno = 0
                oExcel = New Business.Excel(Me.Key)
                oData = New Data.Dezenas(Me.Key)
                lTimeMania = oExcel.ImportarTimeMania(strFileName, intPlanilha, strConcursos)

                For Each oTimemania As Struct.TimeMania In lTimeMania
                    oData.TimeMania.Concurso = oTimemania.Concurso
                    oData.TimeMania.Data = oTimemania.Data
                    oData.TimeMania.Dezena01 = oTimemania.Dezena01
                    oData.TimeMania.Dezena02 = oTimemania.Dezena02
                    oData.TimeMania.Dezena03 = oTimemania.Dezena03
                    oData.TimeMania.Dezena04 = oTimemania.Dezena04
                    oData.TimeMania.Dezena05 = oTimemania.Dezena05
                    oData.TimeMania.Dezena06 = oTimemania.Dezena06
                    oData.TimeMania.Dezena07 = oTimemania.Dezena07
                    oData.TimeMania.Time = oTimemania.Time
                    oData.GravarTimeMania()
                Next

                intRetorno = lTimeMania.Count
                lTimeMania = Nothing
                oExcel = Nothing
                oData = Nothing

            Catch ex As Exception
                lTimeMania = Nothing
                oExcel = Nothing
                oData = Nothing
                intRetorno = 0
                Throw ex
            End Try

            Return intRetorno

        End Function

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

    End Class
End Namespace