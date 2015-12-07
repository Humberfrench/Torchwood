Imports Consumer.Structs
Imports TorchWood.Struct
Public Class frmStudyStats

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

    Sub LoadConcursos()

        Dim dtResult As DataTable
        Dim itnData As Struct.Loteria

        dtResult = New DataTable
        itnData = Me.ddlLoterias.SelectedItem

        Try

            Using objBusiness As TorchWood.Core.Data.GenericQueries = New TorchWood.Core.Data.GenericQueries("torchConn")
                objBusiness.Loteria = Convert.ToInt16(itnData.Codigo)
                dtResult = objBusiness.ListaConcursos
                objBusiness.Dispose()
            End Using

            If Not IsNothing(dtResult) AndAlso dtResult.Rows.Count > 0 Then

                For Each drDados As DataRow In dtResult.Rows
                    Me.ddlRangeIni.Items.Add(drDados.Item("nr_concurso"))
                    Me.ddlRangeFim.Items.Add(drDados.Item("nr_concurso"))
                Next

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            itnData.Dispose()
            itnData = Nothing
            dtResult.Dispose()
            dtResult = Nothing

        End Try

    End Sub

    Private Function VerifyData(ByRef intLoteria As TipoLoteria, _
                                ByRef intConcIni As Integer, _
                                ByRef intConcFim As Integer) As Boolean

        Dim itnData As New Struct.Loteria
        Dim blnReturn As Boolean = False

        'verificar se está preenchido os combos.

        Try
            If IsNothing(Me.ddlLoterias.SelectedItem) Then
                MessageBox.Show("É preciso preencher todos os parâmetros", "Stats Loteria", MessageBoxButtons.OK, MessageBoxIcon.Error)
                blnReturn = True
            Else
                If Me.ddlRangeIni.Text = "" AndAlso Me.ddlRangeFim.Text = "" Then
                    MessageBox.Show("É preciso preencher todos os parâmetros", "Stats Loteria", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    blnReturn = True
                End If
            End If
            itnData = Me.ddlLoterias.SelectedItem

            intLoteria = itnData.Codigo
            intConcIni = Me.ddlRangeIni.SelectedItem()
            intConcFim = Me.ddlRangeFim.SelectedItem()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            itnData.Dispose()
            itnData = Nothing
        End Try

        Return blnReturn

    End Function

    Sub CarregaGridPerc(ByVal intLoteria As TipoLoteria, _
                        ByVal intConcIni As Integer, _
                        ByVal intConcFim As Integer)

        Dim dtResult As DataTable
        Dim itmGrid As ListViewItem
        Dim intCont As Integer = 0

        dtResult = New DataTable
        itmGrid = New ListViewItem

        Try

            Using objBusiness As TorchWood.Core.Statistics.GameStats = New TorchWood.Core.Statistics.GameStats("torchConn")
                objBusiness.Loteria = intLoteria
                objBusiness.ConcursoIni = intConcIni
                objBusiness.ConcursoFim = intConcFim
                'dtResult = objBusiness.GetResultsByRange
                objBusiness.Dispose()
            End Using

            'nr_dezena qt_dezena pc_dezena_total pc_dezena_concursos
            For Each drDados As DataRow In dtResult.Rows
                intCont += 1
                itmGrid = New ListViewItem
                itmGrid.Text = intCont.ToString
                itmGrid.SubItems.Add(drDados.Item("nr_dezena").ToString)
                itmGrid.SubItems.Add(drDados.Item("qt_dezena").ToString)
                itmGrid.SubItems.Add(drDados.Item("pc_dezena_total").ToString)
                itmGrid.SubItems.Add(drDados.Item("pc_dezena_concursos").ToString)
                Me.lvStats.Items.Add(itmGrid)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            itmGrid = Nothing
            dtResult.Dispose()
            dtResult = Nothing
        End Try


    End Sub

    Sub CarregaGridDistrib(ByVal intLoteria As TipoLoteria, _
                           ByVal intConcIni As Integer, _
                           ByVal intConcFim As Integer)

        Dim dtResult As DataTable
        Dim itmGrid As ListViewItem
        Dim intFrequenciaAcumulada As Integer

        dtResult = New DataTable
        itmGrid = New ListViewItem

        Try

            Using objBusiness As TorchWood.Core.Statistics.GameStats = New TorchWood.Core.Statistics.GameStats("torchConn")
                objBusiness.Loteria = intLoteria
                objBusiness.ConcursoIni = intConcIni
                objBusiness.ConcursoFim = intConcFim
                dtResult = objBusiness.GetResultsByDistribute
                objBusiness.Dispose()
            End Using

            'nr_dezena qt_dezena pc_dezena_total pc_dezena_concursos
            intFrequenciaAcumulada = 0
            For Each drDados As DataRow In dtResult.Rows
                intFrequenciaAcumulada += Convert.ToInt16(drDados.Item("qt_dezena").ToString)
                itmGrid = New ListViewItem
                itmGrid.Text = drDados.Item("ds_rol").ToString '
                itmGrid.SubItems.Add(drDados.Item("qt_dezena").ToString)
                itmGrid.SubItems.Add(drDados.Item("pc_dezena").ToString)
                itmGrid.SubItems.Add(drDados.Item("ds_ponto_medio").ToString)
                itmGrid.SubItems.Add(intFrequenciaAcumulada.ToString)
                Me.lvDistrib.Items.Add(itmGrid)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            itmGrid = Nothing
            dtResult.Dispose()
            dtResult = Nothing
        End Try


    End Sub


    Private Sub btnConsulta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConsulta.Click

        Dim blnReturn As Boolean
        Dim intLoteria As TipoLoteria
        Dim intConcIni As Integer
        Dim intConcFim As Integer

        blnReturn = VerifyData(intLoteria, intConcIni, intConcFim)

        If blnReturn Then
            Exit Sub
        End If

        Me.CarregaGridPerc(intLoteria, intConcIni, intConcFim)
        Me.CarregaGridDistrib(intLoteria, intConcIni, intConcFim)

    End Sub

    Private Sub ddlLoterias_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlLoterias.SelectedIndexChanged
        LoadConcursos()
    End Sub

   
End Class