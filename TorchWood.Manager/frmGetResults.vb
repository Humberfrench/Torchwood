Imports Consumer.Structs
Imports Consumer
Imports Consumer.Misc
Imports System.Text
Public Class frmGetResults

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'carregar Combos
        CarregaComboLoteria()

    End Sub
    Sub CarregaComboLoteria()

        Dim lstResult As List(Of Struct.Loteria)
        Dim itnData As New ItemData

        Using objBusiness As TorchWood.Core.Data.Loterias = New TorchWood.Core.Data.Loterias("torchConn")
            lstResult = objBusiness.List
            objBusiness.Dispose()
        End Using

        If Not IsNothing(lstResult) AndAlso lstResult.Count > 0 Then

            For Each itnDados As Struct.Loteria In lstResult
                Me.ddlLoterias.Items.Add(itnDados)
            Next

            itnData.Dispose()
            itnData = Nothing
            lstResult = Nothing

        End If


    End Sub

    Sub TratarGrid(ByVal objLoteria As TorchWood.Struct.Loteria)

        Me.lvResults.Items.Clear()
        Me.lvResults.Columns.Clear()
        'add colunas

        lvResults.Columns.Add("Conc.", 60)
        lvResults.Columns.Add("Data", 120)
        For intContador As Integer = 1 To objLoteria.QtdeDezenas
            lvResults.Columns.Add("Dez." + intContador.ToString, 50)
        Next

        Me.lblDezenaMaxima.Text = objLoteria.DezMaxima
        Me.lblDezMinima.Text = objLoteria.DezMinima
        Me.lblDezSorteio.Text = objLoteria.QtdeDezenas
        Me.lblTotalDezenas.Text = objLoteria.QtdeDezenasTotais
        Me.lblOccurMinima.Text = objLoteria.QtdeMinOccurs

    End Sub

    Private Sub ddlLoterias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlLoterias.SelectedIndexChanged
        Dim objLoteria As TorchWood.Struct.Loteria
        objLoteria = CType(ddlLoterias.SelectedItem, TorchWood.Struct.Loteria)
        TratarGrid(objLoteria)
    End Sub

    Private Sub btnConsulta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConsulta.Click

        'consultar resultados

        Dim dtResult As New DataTable
        Dim itnResult As ListViewItem
        Dim objLoteria As TorchWood.Struct.Loteria

        objLoteria = CType(ddlLoterias.SelectedItem, TorchWood.Struct.Loteria)

        Using objBusiness As TorchWood.Core.Statistics.GameStats = New TorchWood.Core.Statistics.GameStats("torchConn")
            objBusiness.Loteria = objLoteria.Codigo
            'dtResult = objBusiness.GetResults
            objBusiness.Dispose()
        End Using

        If Not IsNothing(dtResult) AndAlso dtResult.Rows.Count > 0 Then

            For Each drDados As DataRow In dtResult.Rows
                itnResult = New ListViewItem
                itnResult.Text = drDados.Item("nr_concurso").ToString
                itnResult.SubItems.Add(FormatDateTime(drDados.Item("dt_concurso").ToString))
                Select Case objLoteria.Codigo
                    Case 1, 2, 3
                        itnResult.SubItems.Add(drDados.Item(2).ToString)
                        itnResult.SubItems.Add(drDados.Item(3).ToString)
                        itnResult.SubItems.Add(drDados.Item(4).ToString)
                        itnResult.SubItems.Add(drDados.Item(5).ToString)
                        itnResult.SubItems.Add(drDados.Item(6).ToString)
                        itnResult.SubItems.Add(drDados.Item(7).ToString)
                    Case 4
                        itnResult.SubItems.Add(drDados.Item(2).ToString)
                        itnResult.SubItems.Add(drDados.Item(3).ToString)
                        itnResult.SubItems.Add(drDados.Item(4).ToString)
                        itnResult.SubItems.Add(drDados.Item(5).ToString)
                        itnResult.SubItems.Add(drDados.Item(6).ToString)
                        itnResult.SubItems.Add(drDados.Item(7).ToString)
                        itnResult.SubItems.Add(drDados.Item(8).ToString)
                        itnResult.SubItems.Add(drDados.Item(9).ToString)
                        itnResult.SubItems.Add(drDados.Item(10).ToString)
                        itnResult.SubItems.Add(drDados.Item(11).ToString)
                        itnResult.SubItems.Add(drDados.Item(12).ToString)
                        itnResult.SubItems.Add(drDados.Item(13).ToString)
                        itnResult.SubItems.Add(drDados.Item(14).ToString)
                        itnResult.SubItems.Add(drDados.Item(15).ToString)
                        itnResult.SubItems.Add(drDados.Item(16).ToString)
                        itnResult.SubItems.Add(drDados.Item(17).ToString)
                        itnResult.SubItems.Add(drDados.Item(18).ToString)
                        itnResult.SubItems.Add(drDados.Item(19).ToString)
                        itnResult.SubItems.Add(drDados.Item(20).ToString)
                        itnResult.SubItems.Add(drDados.Item(21).ToString)
                    Case 5
                        itnResult.SubItems.Add(drDados.Item(2).ToString)
                        itnResult.SubItems.Add(drDados.Item(3).ToString)
                        itnResult.SubItems.Add(drDados.Item(4).ToString)
                        itnResult.SubItems.Add(drDados.Item(5).ToString)
                        itnResult.SubItems.Add(drDados.Item(6).ToString)
                        itnResult.SubItems.Add(drDados.Item(7).ToString)
                        itnResult.SubItems.Add(drDados.Item(8).ToString)
                        itnResult.SubItems.Add(drDados.Item(9).ToString)
                        itnResult.SubItems.Add(drDados.Item(10).ToString)
                        itnResult.SubItems.Add(drDados.Item(11).ToString)
                        itnResult.SubItems.Add(drDados.Item(12).ToString)
                        itnResult.SubItems.Add(drDados.Item(13).ToString)
                        itnResult.SubItems.Add(drDados.Item(14).ToString)
                        itnResult.SubItems.Add(drDados.Item(15).ToString)
                        itnResult.SubItems.Add(drDados.Item(16).ToString)
                    Case 6
                        itnResult.SubItems.Add(drDados.Item(2).ToString)
                        itnResult.SubItems.Add(drDados.Item(3).ToString)
                        itnResult.SubItems.Add(drDados.Item(4).ToString)
                        itnResult.SubItems.Add(drDados.Item(5).ToString)
                        itnResult.SubItems.Add(drDados.Item(6).ToString)
                End Select
                lvResults.Items.Add(itnResult)

            Next
            Me.btnExport.Enabled = True
        End If

    End Sub

    Private Sub btnExport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExport.Click

        'Exportar para HTML
        'consttrua o HTML
        Dim arrDados As ArrayList
        Dim lstArrDados As List(Of ArrayList)
        Dim strTable As String = ""
        Dim strFileName As String = ""
        Dim strPageTitle As String = ""
        Dim stbHtml As New StringBuilder
        Dim objLoteria As TorchWood.Struct.Loteria

        objLoteria = CType(ddlLoterias.SelectedItem, TorchWood.Struct.Loteria)

        lstArrDados = New List(Of ArrayList)
        arrDados = New ArrayList
        For Each colHeader As ColumnHeader In lvResults.Columns
            arrDados.Add(colHeader.Text)
        Next
        lstArrDados.Add(arrDados)

        For Each itnDados As ListViewItem In lvResults.Items
            arrDados = New ArrayList
            arrDados.Add(itnDados.Text)
            For intCont As Integer = 1 To itnDados.SubItems.Count - 1
                arrDados.Add(itnDados.SubItems.Item(intCont).Text)
            Next
            lstArrDados.Add(arrDados)
        Next

        'gerar html
        Select Case objLoteria.Codigo
            Case 1
                strFileName = "c:\ResultadoMegaSena.html"
                strPageTitle = "Resultado da MegaSena"
            Case 2
                strFileName = "c:\ResultadoDuplaSenaS1.html"
                strPageTitle = "Resultado da DuplaSena Primeiro Sorteio"
            Case 3
                strFileName = "c:\ResultadoDuplaSenaS2.html"
                strPageTitle = "Resultado da DuplaSena Segundo Sorteio"
            Case 4
                strFileName = "c:\ResultadoLotoMania.html"
                strPageTitle = "Resultado da LotoMania"
            Case 5
                strFileName = "c:\ResultadoLotoFacil.html"
                strPageTitle = "Resultado da LotoFacil"
            Case 6
                strFileName = "c:\ResultadoQuina.html"
                strPageTitle = "Resultado da Quina"
        End Select

        '???
        'strTable = tableClass.RenderTableLines(lstArrDados)
        stbHtml.Append("<html>" + vbNewLine)
        stbHtml.Append("<title>" + strPageTitle + "</title>" + vbNewLine)
        stbHtml.Append("<body>" + vbNewLine)
        stbHtml.Append("<table width='100%'>" + vbNewLine)
        stbHtml.Append(strTable + vbNewLine)
        stbHtml.Append("</table>" + vbNewLine)
        stbHtml.Append("</body>" + vbNewLine)
        stbHtml.Append("</html>" + vbNewLine)

        'InputOutPut.File.Save(strFileName, stbHtml.ToString, False)

    End Sub
End Class
