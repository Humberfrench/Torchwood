Imports Microsoft.Office.Interop.Excel
Namespace Business
    ''' <summary>
    ''' Classe válida apenas para Excel até 2007
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Excel

#Region "Variáveis"
        Private strKey As String
        Private intLoteria As Integer
#End Region

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

        Private Function LerArquivoExcel(ByVal strNomeArquivo As String, _
                                         ByVal intPlanilha As Integer) As List(Of String)

            Dim oExcel As New Application
            Dim oWrkBook As Workbook
            Dim oSheet As Worksheet
            Dim oRange As Range

            Dim objDados As New List(Of String)
            Dim intLinhas As Integer


            Try
                If Len(strNomeArquivo) > 0 Then
                    'Abrir o arquivo do Excel 
                    oWrkBook = oExcel.Workbooks.Open(strNomeArquivo)

                    ' definir qual a planilha de trabalho
                    oSheet = CType(oWrkBook.Worksheets.Item(1), Worksheet)
                    oSheet.Select()

                    'Obtem o conteúdo da célula na posição (Lin,Col)
                    For intLinhas = 1 To oSheet.Rows.Count 'Lê da linha a até a linha 60

                        oRange = CType(oSheet.Cells(intLinhas, 1), Range)

                        If IsNothing(oRange.Value) Then
                            Exit For
                        End If

                        objDados.Add(oRange.Value.ToString)

                    Next intLinhas
                    oWrkBook.Close(False)

                End If
            Catch ex As Exception
                objDados = Nothing
            Finally
                ' Fechar a planilha sem salvar alterações (para salvar mude False para True)
                oExcel.Quit()

                ' Libera a memória
                oWrkBook = Nothing
                oExcel = Nothing
                oSheet = Nothing
            End Try

            Return objDados

        End Function

        ''' <summary>
        ''' Executa a leitura da planilha, e carrega dados para a estrutura para um objeto
        ''' </summary>
        ''' <param name="strNomeArquivo">Nome do Arquivo do Excel</param>
        ''' <returns>Lista Generics, com lista da estrutura da loteria com os dados importados</returns>
        ''' <remarks></remarks>
        Public Function ImportarMegaSena(ByVal strNomeArquivo As String, _
                                         ByVal intPlanilha As Integer) As List(Of Struct.MegaSena)

            Dim oExcel As New Application
            Dim oWrkBook As Workbook
            Dim oSheet As Worksheet
            Dim oRange As Range
            Dim objConcurso As Data.GenericQueries
            Dim lstMegaSena As New List(Of Struct.MegaSena)
            Dim objMegaSena As Struct.MegaSena
            Dim intLinhas As Integer
            Dim intConcurso As Integer


            Try
                intLoteria = 1
                If Len(strNomeArquivo) > 0 Then
                    'Abrir o arquivo do Excel 
                    oWrkBook = oExcel.Workbooks.Open(strNomeArquivo)

                    ' definir qual a planilha de trabalho
                    oSheet = CType(oWrkBook.Worksheets.Item(intPlanilha), Worksheet)
                    oSheet.Select()

                    'Obtem o conteúdo da célula na posição (Lin,Col)
                    'Ler a partir da Linha dois, pois considera-se a existência do cabeçalho
                    For intLinhas = 2 To oSheet.Rows.Count 'Lê da linha a até a linha 60

                        oRange = CType(oSheet.Cells(intLinhas, 1), Range)

                        If IsNothing(oRange.Value) Then
                            Exit For
                        End If

                        intConcurso = Convert.ToInt32(oRange.Value.ToString)
                        objConcurso = New Data.GenericQueries(Me.Key)

                        If Not (objConcurso.CheckConcoursAndLotery(intLoteria, intConcurso)) Then

                            objMegaSena = New Struct.MegaSena
                            objMegaSena.Concurso = intConcurso
                            'data do concurso
                            oRange = CType(oSheet.Cells(intLinhas, 2), Range)
                            objMegaSena.Data = Convert.ToDateTime(oRange.Value.ToString)

                            'Dezena Um
                            oRange = CType(oSheet.Cells(intLinhas, 3), Range)
                            objMegaSena.Dezena01 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Dois
                            oRange = CType(oSheet.Cells(intLinhas, 4), Range)
                            objMegaSena.Dezena02 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Três
                            oRange = CType(oSheet.Cells(intLinhas, 5), Range)
                            objMegaSena.Dezena03 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Quatro
                            oRange = CType(oSheet.Cells(intLinhas, 6), Range)
                            objMegaSena.Dezena04 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Cinco
                            oRange = CType(oSheet.Cells(intLinhas, 7), Range)
                            objMegaSena.Dezena05 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Seis
                            oRange = CType(oSheet.Cells(intLinhas, 8), Range)
                            objMegaSena.Dezena06 = Convert.ToInt32(oRange.Value.ToString)

                            lstMegaSena.Add(objMegaSena)

                        End If

                    Next intLinhas
                    objMegaSena = Nothing
                    oWrkBook.Close(False)

                End If
            Catch ex As Exception
                objMegaSena = Nothing
                lstMegaSena = Nothing
            Finally
                ' Fechar a planilha sem salvar alterações (para salvar mude False para True)
                oExcel.Quit()

                ' Libera a memória
                oWrkBook = Nothing
                oExcel = Nothing
                oSheet = Nothing
            End Try

            Return lstMegaSena

        End Function

        ''' <summary>
        ''' Executa a leitura da planilha, e carrega dados para a estrutura para um objeto
        ''' </summary>
        ''' <param name="strNomeArquivo">Nome do Arquivo do Excel</param>
        ''' <returns>Lista Generics, com lista da estrutura da loteria com os dados importados</returns>
        ''' <remarks></remarks>
        Public Function ImportarDuplaSenaS1(ByVal strNomeArquivo As String, _
                                            ByVal intPlanilha As Integer) As List(Of Struct.DuplaSena)

            Dim oExcel As New Application
            Dim oWrkBook As Workbook
            Dim oSheet As Worksheet
            Dim oRange As Range
            Dim objConcurso As Data.GenericQueries
            Dim lstDuplaSenaS1 As New List(Of Struct.DuplaSena)
            Dim objDuplaSenaS1 As Struct.DuplaSena
            Dim intLinhas As Integer
            Dim intConcurso As Integer


            Try
                intLoteria = 2
                If Len(strNomeArquivo) > 0 Then
                    'Abrir o arquivo do Excel 
                    oWrkBook = oExcel.Workbooks.Open(strNomeArquivo)

                    ' definir qual a planilha de trabalho
                    oSheet = CType(oWrkBook.Worksheets.Item(intPlanilha), Worksheet)
                    oSheet.Select()

                    'Obtem o conteúdo da célula na posição (Lin,Col)
                    'Ler a partir da Linha dois, pois considera-se a existência do cabeçalho
                    For intLinhas = 2 To oSheet.Rows.Count 'Lê da linha a até a linha 60

                        oRange = CType(oSheet.Cells(intLinhas, 1), Range)

                        If IsNothing(oRange.Value) Then
                            Exit For
                        End If

                        intConcurso = Convert.ToInt32(oRange.Value.ToString)
                        objConcurso = New Data.GenericQueries(Me.Key)

                        If Not (objConcurso.CheckConcoursAndLotery(intLoteria, intConcurso)) Then

                            objDuplaSenaS1 = New Struct.DuplaSena
                            objDuplaSenaS1.Concurso = intConcurso
                            'data do concurso
                            oRange = CType(oSheet.Cells(intLinhas, 2), Range)
                            objDuplaSenaS1.Data = Convert.ToDateTime(oRange.Value.ToString)

                            'Dezena Um
                            oRange = CType(oSheet.Cells(intLinhas, 3), Range)
                            objDuplaSenaS1.Dezena01 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Dois
                            oRange = CType(oSheet.Cells(intLinhas, 4), Range)
                            objDuplaSenaS1.Dezena02 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Três
                            oRange = CType(oSheet.Cells(intLinhas, 5), Range)
                            objDuplaSenaS1.Dezena03 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Quatro
                            oRange = CType(oSheet.Cells(intLinhas, 6), Range)
                            objDuplaSenaS1.Dezena04 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Cinco
                            oRange = CType(oSheet.Cells(intLinhas, 7), Range)
                            objDuplaSenaS1.Dezena05 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Seis
                            oRange = CType(oSheet.Cells(intLinhas, 8), Range)
                            objDuplaSenaS1.Dezena06 = Convert.ToInt32(oRange.Value.ToString)

                            lstDuplaSenaS1.Add(objDuplaSenaS1)

                        End If

                    Next intLinhas
                    oWrkBook.Close(False)

                End If
            Catch ex As Exception
                lstDuplaSenaS1 = Nothing
            Finally
                ' Fechar a planilha sem salvar alterações (para salvar mude False para True)
                oExcel.Quit()

                ' Libera a memória
                oWrkBook = Nothing
                oExcel = Nothing
                oSheet = Nothing
            End Try

            Return lstDuplaSenaS1

        End Function

        ''' <summary>
        ''' Executa a leitura da planilha, e carrega dados para a estrutura para um objeto
        ''' </summary>
        ''' <param name="strNomeArquivo">Nome do Arquivo do Excel</param>
        ''' <returns>Lista Generics, com lista da estrutura da loteria com os dados importados</returns>
        ''' <remarks></remarks>
        Public Function ImportarDuplaSenaS2(ByVal strNomeArquivo As String, _
                                            ByVal intPlanilha As Integer) As List(Of Struct.DuplaSena)

            Dim oExcel As New Application
            Dim oWrkBook As Workbook
            Dim oSheet As Worksheet
            Dim oRange As Range
            Dim objConcurso As Data.GenericQueries
            Dim lstDuplaSenaS2 As New List(Of Struct.DuplaSena)
            Dim objDuplaSenaS2 As Struct.DuplaSena
            Dim intLinhas As Integer
            Dim intConcurso As Integer


            Try
                intLoteria = 3
                If Len(strNomeArquivo) > 0 Then
                    'Abrir o arquivo do Excel 
                    oWrkBook = oExcel.Workbooks.Open(strNomeArquivo)

                    ' definir qual a planilha de trabalho
                    oSheet = CType(oWrkBook.Worksheets.Item(intLoteria), Worksheet)
                    oSheet.Select()

                    'Obtem o conteúdo da célula na posição (Lin,Col)
                    'Ler a partir da Linha dois, pois considera-se a existência do cabeçalho
                    For intLinhas = 2 To oSheet.Rows.Count 'Lê da linha a até a linha 60

                        oRange = CType(oSheet.Cells(intLinhas, 1), Range)

                        If IsNothing(oRange.Value) Then
                            Exit For
                        End If

                        intConcurso = Convert.ToInt32(oRange.Value.ToString)
                        objConcurso = New Data.GenericQueries(Me.Key)

                        If Not (objConcurso.CheckConcoursAndLotery(intPlanilha, intConcurso)) Then

                            objDuplaSenaS2 = New Struct.DuplaSena
                            objDuplaSenaS2.Concurso = intConcurso
                            'data do concurso
                            oRange = CType(oSheet.Cells(intLinhas, 2), Range)
                            objDuplaSenaS2.Data = Convert.ToDateTime(oRange.Value.ToString)

                            'Dezena Um
                            oRange = CType(oSheet.Cells(intLinhas, 3), Range)
                            objDuplaSenaS2.Dezena01 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Dois
                            oRange = CType(oSheet.Cells(intLinhas, 4), Range)
                            objDuplaSenaS2.Dezena02 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Três
                            oRange = CType(oSheet.Cells(intLinhas, 5), Range)
                            objDuplaSenaS2.Dezena03 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Quatro
                            oRange = CType(oSheet.Cells(intLinhas, 6), Range)
                            objDuplaSenaS2.Dezena04 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Cinco
                            oRange = CType(oSheet.Cells(intLinhas, 7), Range)
                            objDuplaSenaS2.Dezena05 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Seis
                            oRange = CType(oSheet.Cells(intLinhas, 8), Range)
                            objDuplaSenaS2.Dezena06 = Convert.ToInt32(oRange.Value.ToString)

                            lstDuplaSenaS2.Add(objDuplaSenaS2)

                        End If

                    Next intLinhas
                    objDuplaSenaS2 = Nothing
                    oWrkBook.Close(False)

                End If
            Catch ex As Exception
                objDuplaSenaS2 = Nothing
                lstDuplaSenaS2 = Nothing
            Finally
                ' Fechar a planilha sem salvar alterações (para salvar mude False para True)
                oExcel.Quit()

                ' Libera a memória
                oWrkBook = Nothing
                oExcel = Nothing
                oSheet = Nothing
            End Try

            Return lstDuplaSenaS2

        End Function

        ''' <summary>
        ''' Executa a leitura da planilha, e carrega dados para a estrutura para um objeto
        ''' </summary>
        ''' <param name="strNomeArquivo">Nome do Arquivo do Excel</param>
        ''' <returns>Lista Generics, com lista da estrutura da loteria com os dados importados</returns>
        ''' <remarks></remarks>
        Public Function ImportarQuina(ByVal strNomeArquivo As String, _
                                      ByVal intPlanilha As Integer) As List(Of Struct.Quina)

            Dim oExcel As New Application
            Dim oWrkBook As Workbook
            Dim oSheet As Worksheet
            Dim oRange As Range
            Dim objConcurso As Data.GenericQueries
            Dim lstQuina As New List(Of Struct.Quina)
            Dim objQuina As Struct.Quina
            Dim intLinhas As Integer
            Dim intConcurso As Integer

            Try
                intLoteria = 6
                If Len(strNomeArquivo) > 0 Then
                    'Abrir o arquivo do Excel 
                    oWrkBook = oExcel.Workbooks.Open(strNomeArquivo)

                    ' definir qual a planilha de trabalho
                    oSheet = CType(oWrkBook.Worksheets.Item(intPlanilha), Worksheet)
                    oSheet.Select()

                    'Obtem o conteúdo da célula na posição (Lin,Col)
                    'Ler a partir da Linha dois, pois considera-se a existência do cabeçalho
                    For intLinhas = 2 To oSheet.Rows.Count 'Lê da linha a até a linha 60

                        oRange = CType(oSheet.Cells(intLinhas, 1), Range)

                        If IsNothing(oRange.Value) Then
                            Exit For
                        End If

                        intConcurso = Convert.ToInt32(oRange.Value.ToString)
                        objConcurso = New Data.GenericQueries(Me.Key)

                        If Not (objConcurso.CheckConcoursAndLotery(intLoteria, intConcurso)) Then

                            objQuina = New Struct.Quina
                            objQuina.Concurso = intConcurso
                            'data do concurso
                            oRange = CType(oSheet.Cells(intLinhas, 2), Range)
                            objQuina.Data = Convert.ToDateTime(oRange.Value.ToString)

                            'Dezena Um
                            oRange = CType(oSheet.Cells(intLinhas, 3), Range)
                            objQuina.Dezena01 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Dois
                            oRange = CType(oSheet.Cells(intLinhas, 4), Range)
                            objQuina.Dezena02 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Três
                            oRange = CType(oSheet.Cells(intLinhas, 5), Range)
                            objQuina.Dezena03 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Quatro
                            oRange = CType(oSheet.Cells(intLinhas, 6), Range)
                            objQuina.Dezena04 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Cinco
                            oRange = CType(oSheet.Cells(intLinhas, 7), Range)
                            objQuina.Dezena05 = Convert.ToInt32(oRange.Value.ToString)

                            lstQuina.Add(objQuina)

                        End If

                    Next intLinhas
                    objQuina = Nothing
                    oWrkBook.Close(False)

                End If
            Catch ex As Exception
                objQuina = Nothing
                lstQuina = Nothing
            Finally
                ' Fechar a planilha sem salvar alterações (para salvar mude False para True)
                oExcel.Quit()

                ' Libera a memória
                oWrkBook = Nothing
                oExcel = Nothing
                oSheet = Nothing
            End Try

            Return lstQuina

        End Function

        ''' <summary>
        ''' Executa a leitura da planilha, e carrega dados para a estrutura para um objeto
        ''' </summary>
        ''' <param name="strNomeArquivo">Nome do Arquivo do Excel</param>
        ''' <returns>Lista Generics, com lista da estrutura da loteria com os dados importados</returns>
        ''' <remarks></remarks>
        Public Function ImportarLotoFacil(ByVal strNomeArquivo As String, _
                                          ByVal intPlanilha As Integer) As List(Of Struct.LotoFacil)

            Dim oExcel As New Application
            Dim oWrkBook As Workbook
            Dim oSheet As Worksheet
            Dim oRange As Range
            Dim objConcurso As Data.GenericQueries
            Dim lstLotoFacil As New List(Of Struct.LotoFacil)
            Dim objLotoFacil As Struct.LotoFacil
            Dim intLinhas As Integer
            Dim intConcurso As Integer

            Try
                intLoteria = 5
                If Len(strNomeArquivo) > 0 Then
                    'Abrir o arquivo do Excel 
                    oWrkBook = oExcel.Workbooks.Open(strNomeArquivo)

                    ' definir qual a planilha de trabalho
                    oSheet = CType(oWrkBook.Worksheets.Item(intPlanilha), Worksheet)
                    oSheet.Select()

                    'Obtem o conteúdo da célula na posição (Lin,Col)
                    'Ler a partir da Linha dois, pois considera-se a existência do cabeçalho
                    For intLinhas = 2 To oSheet.Rows.Count 'Lê da linha a até a linha 60

                        oRange = CType(oSheet.Cells(intLinhas, 1), Range)

                        If IsNothing(oRange.Value) Then
                            Exit For
                        End If

                        intConcurso = Convert.ToInt32(oRange.Value.ToString)
                        objConcurso = New Data.GenericQueries(Me.Key)

                        If Not (objConcurso.CheckConcoursAndLotery(intLoteria, intConcurso)) Then

                            objLotoFacil = New Struct.LotoFacil
                            objLotoFacil.Concurso = intConcurso
                            'data do concurso
                            oRange = CType(oSheet.Cells(intLinhas, 2), Range)
                            objLotoFacil.Data = Convert.ToDateTime(oRange.Value.ToString)

                            'Dezena Um
                            oRange = CType(oSheet.Cells(intLinhas, 3), Range)
                            objLotoFacil.Dezena01 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Dois
                            oRange = CType(oSheet.Cells(intLinhas, 4), Range)
                            objLotoFacil.Dezena02 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Três
                            oRange = CType(oSheet.Cells(intLinhas, 5), Range)
                            objLotoFacil.Dezena03 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Quatro
                            oRange = CType(oSheet.Cells(intLinhas, 6), Range)
                            objLotoFacil.Dezena04 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Cinco
                            oRange = CType(oSheet.Cells(intLinhas, 7), Range)
                            objLotoFacil.Dezena05 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Seis
                            oRange = CType(oSheet.Cells(intLinhas, 8), Range)
                            objLotoFacil.Dezena06 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Sete
                            oRange = CType(oSheet.Cells(intLinhas, 9), Range)
                            objLotoFacil.Dezena07 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Oito
                            oRange = CType(oSheet.Cells(intLinhas, 10), Range)
                            objLotoFacil.Dezena08 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Nove
                            oRange = CType(oSheet.Cells(intLinhas, 11), Range)
                            objLotoFacil.Dezena09 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Dez
                            oRange = CType(oSheet.Cells(intLinhas, 12), Range)
                            objLotoFacil.Dezena10 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Onze
                            oRange = CType(oSheet.Cells(intLinhas, 13), Range)
                            objLotoFacil.Dezena11 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Doze
                            oRange = CType(oSheet.Cells(intLinhas, 14), Range)
                            objLotoFacil.Dezena12 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Treze
                            oRange = CType(oSheet.Cells(intLinhas, 15), Range)
                            objLotoFacil.Dezena13 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Quatorze
                            oRange = CType(oSheet.Cells(intLinhas, 16), Range)
                            objLotoFacil.Dezena14 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Quinze
                            oRange = CType(oSheet.Cells(intLinhas, 17), Range)
                            objLotoFacil.Dezena15 = Convert.ToInt32(oRange.Value.ToString)

                            lstLotoFacil.Add(objLotoFacil)

                        End If

                    Next intLinhas
                    objLotoFacil = Nothing
                    oWrkBook.Close(False)




                End If
            Catch ex As Exception
                objLotoFacil = Nothing
                lstLotoFacil = Nothing
            Finally
                ' Fechar a planilha sem salvar alterações (para salvar mude False para True)
                oExcel.Quit()
                oRange = Nothing
                ' Libera a memória
                oWrkBook = Nothing
                oExcel = Nothing
                oSheet = Nothing
            End Try

            Return lstLotoFacil

        End Function

        ''' <summary>
        ''' Executa a leitura da planilha, e carrega dados para a estrutura para um objeto
        ''' </summary>
        ''' <param name="strNomeArquivo">Nome do Arquivo do Excel</param>
        ''' <returns>Lista Generics, com lista da estrutura da loteria com os dados importados</returns>
        ''' <remarks></remarks>
        Public Function ImportarLotoMania(ByVal strNomeArquivo As String, _
                                          ByVal intPlanilha As Integer) As List(Of Struct.LotoMania)

            Dim oExcel As New Application
            Dim oWrkBook As Workbook
            Dim oSheet As Worksheet
            Dim oRange As Range
            Dim objConcurso As Data.GenericQueries
            Dim lstLotoMania As New List(Of Struct.LotoMania)
            Dim objLotoMania As Struct.LotoMania
            Dim intLinhas As Integer
            Dim intConcurso As Integer

            Try
                intLoteria = 4
                If Len(strNomeArquivo) > 0 Then
                    'Abrir o arquivo do Excel 
                    oWrkBook = oExcel.Workbooks.Open(strNomeArquivo)

                    ' definir qual a planilha de trabalho
                    oSheet = CType(oWrkBook.Worksheets.Item(intPlanilha), Worksheet)
                    oSheet.Select()

                    'Obtem o conteúdo da célula na posição (Lin,Col)
                    'Ler a partir da Linha dois, pois considera-se a existência do cabeçalho
                    For intLinhas = 2 To oSheet.Rows.Count 'Lê da linha a até a linha 60

                        oRange = CType(oSheet.Cells(intLinhas, 1), Range)

                        If IsNothing(oRange.Value) Then
                            Exit For
                        End If

                        intConcurso = Convert.ToInt32(oRange.Value.ToString)
                        objConcurso = New Data.GenericQueries(Me.Key)

                        If Not (objConcurso.CheckConcoursAndLotery(intLoteria, intConcurso)) Then

                            objLotoMania = New Struct.LotoMania
                            objLotoMania.Concurso = intConcurso
                            'data do concurso
                            oRange = CType(oSheet.Cells(intLinhas, 2), Range)
                            objLotoMania.Data = Convert.ToDateTime(oRange.Value.ToString)

                            'Dezena Um
                            oRange = CType(oSheet.Cells(intLinhas, 3), Range)
                            objLotoMania.Dezena01 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Dois
                            oRange = CType(oSheet.Cells(intLinhas, 4), Range)
                            objLotoMania.Dezena02 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Três
                            oRange = CType(oSheet.Cells(intLinhas, 5), Range)
                            objLotoMania.Dezena03 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Quatro
                            oRange = CType(oSheet.Cells(intLinhas, 6), Range)
                            objLotoMania.Dezena04 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Cinco
                            oRange = CType(oSheet.Cells(intLinhas, 7), Range)
                            objLotoMania.Dezena05 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Seis
                            oRange = CType(oSheet.Cells(intLinhas, 8), Range)
                            objLotoMania.Dezena06 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Sete
                            oRange = CType(oSheet.Cells(intLinhas, 9), Range)
                            objLotoMania.Dezena07 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Oito
                            oRange = CType(oSheet.Cells(intLinhas, 10), Range)
                            objLotoMania.Dezena08 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Nove
                            oRange = CType(oSheet.Cells(intLinhas, 11), Range)
                            objLotoMania.Dezena09 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Dez
                            oRange = CType(oSheet.Cells(intLinhas, 12), Range)
                            objLotoMania.Dezena10 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Onze
                            oRange = CType(oSheet.Cells(intLinhas, 13), Range)
                            objLotoMania.Dezena11 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Doze
                            oRange = CType(oSheet.Cells(intLinhas, 14), Range)
                            objLotoMania.Dezena12 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Treze
                            oRange = CType(oSheet.Cells(intLinhas, 15), Range)
                            objLotoMania.Dezena13 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Quatorze
                            oRange = CType(oSheet.Cells(intLinhas, 16), Range)
                            objLotoMania.Dezena14 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Quinze
                            oRange = CType(oSheet.Cells(intLinhas, 17), Range)
                            objLotoMania.Dezena15 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Dezesseis
                            oRange = CType(oSheet.Cells(intLinhas, 18), Range)
                            objLotoMania.Dezena16 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Dezessete
                            oRange = CType(oSheet.Cells(intLinhas, 19), Range)
                            objLotoMania.Dezena17 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Dezoito
                            oRange = CType(oSheet.Cells(intLinhas, 20), Range)
                            objLotoMania.Dezena18 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Dezenove
                            oRange = CType(oSheet.Cells(intLinhas, 21), Range)
                            objLotoMania.Dezena19 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Vinte
                            oRange = CType(oSheet.Cells(intLinhas, 22), Range)
                            objLotoMania.Dezena20 = Convert.ToInt32(oRange.Value.ToString)

                            lstLotoMania.Add(objLotoMania)

                        End If

                    Next intLinhas
                    objLotoMania = Nothing
                    oWrkBook.Close(False)

                End If
            Catch ex As Exception
                objLotoMania = Nothing
                lstLotoMania = Nothing
            Finally
                ' Fechar a planilha sem salvar alterações (para salvar mude False para True)
                oExcel.Quit()

                ' Libera a memória
                oWrkBook = Nothing
                oExcel = Nothing
                oSheet = Nothing
            End Try

            Return lstLotoMania

        End Function

        ''' <summary>
        ''' Executa a leitura da planilha, e carrega dados para a estrutura para um objeto
        ''' </summary>
        ''' <param name="strNomeArquivo">Nome do Arquivo do Excel</param>
        ''' <returns>Lista Generics, com lista da estrutura da loteria com os dados importados</returns>
        ''' <remarks></remarks>
        Public Function ImportarTimeMania(ByVal strNomeArquivo As String, _
                                          ByVal intPlanilha As Integer, _
                                          ByRef strConcursos As String) As List(Of Struct.TimeMania)

            Dim oExcel As New Application
            Dim oWrkBook As Workbook
            Dim oSheet As Worksheet
            Dim oRange As Range
            Dim objConcurso As Data.GenericQueries
            Dim objTimes As Data.Timemania
            Dim lstTimeMania As New List(Of Struct.TimeMania)
            Dim objTimeMania As Struct.TimeMania
            Dim intLinhas As Integer
            Dim intConcurso As Integer
            Dim strTimes As String()



            Try
                strConcursos = String.Empty
                intLoteria = 7
                If Len(strNomeArquivo) > 0 Then
                    'Abrir o arquivo do Excel 
                    oWrkBook = oExcel.Workbooks.Open(strNomeArquivo)

                    ' definir qual a planilha de trabalho
                    oSheet = CType(oWrkBook.Worksheets.Item(intPlanilha), Worksheet)
                    oSheet.Select()

                    'Obtem o conteúdo da célula na posição (Lin,Col)
                    'Ler a partir da Linha dois, pois considera-se a existência do cabeçalho
                    For intLinhas = 2 To oSheet.Rows.Count 'Lê da linha a até a linha 60

                        oRange = CType(oSheet.Cells(intLinhas, 1), Range)

                        If IsNothing(oRange.Value) Then
                            Exit For
                        End If

                        intConcurso = Convert.ToInt32(oRange.Value.ToString)
                        objConcurso = New Data.GenericQueries(Me.Key)
                        objTimes = New Data.Timemania(Me.Key)

                        If Not (objConcurso.CheckConcoursAndLotery(intLoteria, intConcurso)) Then

                            objTimeMania = New Struct.TimeMania
                            objTimeMania.Concurso = intConcurso
                            'data do concurso
                            oRange = CType(oSheet.Cells(intLinhas, 2), Range)
                            objTimeMania.Data = Convert.ToDateTime(oRange.Value.ToString)

                            'Dezena Um
                            oRange = CType(oSheet.Cells(intLinhas, 3), Range)
                            objTimeMania.Dezena01 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Dois
                            oRange = CType(oSheet.Cells(intLinhas, 4), Range)
                            objTimeMania.Dezena02 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Três
                            oRange = CType(oSheet.Cells(intLinhas, 5), Range)
                            objTimeMania.Dezena03 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Quatro
                            oRange = CType(oSheet.Cells(intLinhas, 6), Range)
                            objTimeMania.Dezena04 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Cinco
                            oRange = CType(oSheet.Cells(intLinhas, 7), Range)
                            objTimeMania.Dezena05 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Seis
                            oRange = CType(oSheet.Cells(intLinhas, 8), Range)
                            objTimeMania.Dezena06 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Sete
                            oRange = CType(oSheet.Cells(intLinhas, 9), Range)
                            objTimeMania.Dezena07 = Convert.ToInt32(oRange.Value.ToString)

                            'Dezena Time
                            oRange = CType(oSheet.Cells(intLinhas, 10), Range)
                            strTimes = (oRange.Value.ToString).Split("/"c)
                            objTimeMania.Time = objTimes.ObterTime(strTimes(0).Trim(), strTimes(1).Trim())
                            'implementar veroficacao de inconsistencia, se o time nao tiver sido consistido nao adicionar
                            'e devolver msg dizendo que tal concurso nao foi transmitido.
                            If objTimeMania.Time.Codigo > 0 Then
                                lstTimeMania.Add(objTimeMania)
                            Else
                                strConcursos = strConcursos + objTimeMania.Concurso.ToString() + ";"
                            End If
                        End If

                    Next intLinhas
                    objTimeMania = Nothing
                    oWrkBook.Close(False)

                End If
            Catch ex As Exception
                Throw ex
                objTimeMania = Nothing
                lstTimeMania = Nothing
            Finally
                ' Fechar a planilha sem salvar alterações (para salvar mude False para True)
                oExcel.Quit()

                ' Libera a memória
                oWrkBook = Nothing
                oExcel = Nothing
                oSheet = Nothing
            End Try

            Return lstTimeMania

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
#End Region

    End Class

End Namespace