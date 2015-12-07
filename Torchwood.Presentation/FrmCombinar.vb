Imports Consumer.Math.Stats
Imports System

Public Class FrmCombinar

    Private Sub FrmCombinar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        LoadCombo()
        Me.lvLoterias.Columns.Clear()

    End Sub

    Sub LoadCombo()
        Dim oLoterias As Core.Data.Loterias
        Dim lLoterias As List(Of Struct.Loteria)

        oLoterias = New Core.Data.Loterias(GetKey())
        lLoterias = oLoterias.List

        For Each oItem As Struct.Loteria In lLoterias
            Me.ddlLoteria.Items.Add(oItem)
        Next

        oLoterias = Nothing
        lLoterias = Nothing

    End Sub

    Private Sub btnGerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerar.Click

        Dim oLoteria As Struct.Loteria
        Dim strValues As String

        oLoteria = ddlLoteria.SelectedItem
        If IsNothing(oLoteria) Then
            Exit Sub
        End If

        If lstDezenas.Items.Count <= oLoteria.QtdeDezenas Then
            ShowErro("Quantidade de Dezenas insuficiente para esta Loteria!", "Combinações", "FrmCombinar")
            Exit Sub
        End If

        ObterGrid(oLoteria)

        strValues = ""
        For intCont As Integer = 0 To lstDezenas.Items.Count - 1
            strValues = lstDezenas.Items(intCont).ToString + ","
        Next

        Select Case oLoteria.Codigo
            Case 1, 2, 3
                CarregaDadosCombinadosSena(strValues)
            Case 4
                CarregaDadosCombinadosLotoMania(strValues)
            Case 5
                CarregaDadosCombinadosLotoFacil(strValues)
            Case 6
                CarregaDadosCombinadosQuina(strValues)
            Case 7, 8
                CarregaDadosCombinadosTimeMania(strValues)
            Case Else
                ShowErro("Loteria Inválida!", "Combinações", "FrmCombinar")
                Exit Sub
        End Select
    End Sub

    Sub ObterGrid(ByVal oLoteria As Struct.Loteria)

        Dim oColum As ColumnHeader

        Me.lvLoterias.Columns.Clear()
        Me.lvLoterias.Scrollable = False

        'primeira coluna
        oColum = New ColumnHeader()
        oColum.Text = "ID"
        oColum.Width = 60
        Me.lvLoterias.Columns.Add(oColum)

        For intCont As Integer = 1 To oLoteria.QtdeDezenas
            'Coluna de Dezenas
            oColum = New ColumnHeader()
            oColum.Text = "Dez. " + intCont.ToString()
            oColum.Width = 50
            Me.lvLoterias.Columns.Add(oColum)
        Next
        Me.lvLoterias.Scrollable = True
        Me.lvLoterias.Update()
        oColum = Nothing

    End Sub

    Sub CarregaDadosCombinadosSena(ByVal strValues As String)

        Dim oMath As Combinatory
        Dim lstCombinados As List(Of String)
        Dim itnDados As ListViewItem
        Dim aDados As String()
        Dim intCont As Integer

        Try

            oMath = New Combinatory
            lstCombinados = oMath.CombinarValores(strValues, 6)
            intCont = 0

            For Each strDado As String In lstCombinados
                intCont = intCont + 1
                aDados = strDado.Split(","c)
                itnDados = New ListViewItem
                itnDados.Text = "C-" + intCont.ToString
                itnDados.SubItems.Add(aDados(0))
                itnDados.SubItems.Add(aDados(1))
                itnDados.SubItems.Add(aDados(2))
                itnDados.SubItems.Add(aDados(3))
                itnDados.SubItems.Add(aDados(4))
                itnDados.SubItems.Add(aDados(5))
                lvLoterias.Items.Add(itnDados)
            Next

            lstCombinados = Nothing
            oMath = Nothing
            itnDados = Nothing

        Catch ex As Exception
            lstCombinados = Nothing
            oMath = Nothing
            itnDados = Nothing
            ShowErro(ex, "Erro Combinando Dados", "FrmCombinar")
        End Try

    End Sub

    Sub CarregaDadosCombinadosQuina(ByVal strValues As String)

        Dim oMath As Combinatory
        Dim lstCombinados As List(Of String)
        Dim itnDados As ListViewItem
        Dim aDados As String()
        Dim intCont As Integer

        Try

            oMath = New Combinatory
            lstCombinados = oMath.CombinarValores(strValues, 5)
            intCont = 0

            For Each strDado As String In lstCombinados
                intCont = intCont + 1
                aDados = strDado.Split(","c)
                itnDados = New ListViewItem
                itnDados.Text = "C-" + intCont.ToString
                itnDados.SubItems.Add(aDados(0))
                itnDados.SubItems.Add(aDados(1))
                itnDados.SubItems.Add(aDados(2))
                itnDados.SubItems.Add(aDados(3))
                itnDados.SubItems.Add(aDados(4))
                lvLoterias.Items.Add(itnDados)
            Next

            lstCombinados = Nothing
            oMath = Nothing
            itnDados = Nothing

        Catch ex As Exception
            lstCombinados = Nothing
            oMath = Nothing
            itnDados = Nothing
            ShowErro(ex, "Erro Combinando Dados", "FrmCombinar")
        End Try

    End Sub

    Sub CarregaDadosCombinadosLotoFacil(ByVal strValues As String)

        Dim oMath As Combinatory
        Dim lstCombinados As List(Of String)
        Dim itnDados As ListViewItem
        Dim aDados As String()
        Dim intCont As Integer

        Try

            oMath = New Combinatory
            lstCombinados = oMath.CombinarValores(strValues, 15)
            intCont = 0

            For Each strDado As String In lstCombinados
                intCont = intCont + 1
                aDados = strDado.Split(","c)
                itnDados = New ListViewItem
                itnDados.Text = "C-" + intCont.ToString
                itnDados.SubItems.Add(aDados(0))
                itnDados.SubItems.Add(aDados(1))
                itnDados.SubItems.Add(aDados(2))
                itnDados.SubItems.Add(aDados(3))
                itnDados.SubItems.Add(aDados(4))
                itnDados.SubItems.Add(aDados(5))
                itnDados.SubItems.Add(aDados(6))
                itnDados.SubItems.Add(aDados(7))
                itnDados.SubItems.Add(aDados(8))
                itnDados.SubItems.Add(aDados(9))
                itnDados.SubItems.Add(aDados(10))
                itnDados.SubItems.Add(aDados(11))
                itnDados.SubItems.Add(aDados(12))
                itnDados.SubItems.Add(aDados(13))
                itnDados.SubItems.Add(aDados(14))
                lvLoterias.Items.Add(itnDados)
            Next

            lstCombinados = Nothing
            oMath = Nothing
            itnDados = Nothing

        Catch ex As Exception
            lstCombinados = Nothing
            oMath = Nothing
            itnDados = Nothing
            ShowErro(ex, "Erro Combinando Dados", "FrmCombinar")
        End Try

    End Sub

    Sub CarregaDadosCombinadosLotoMania(ByVal strValues As String)

        Dim oMath As Combinatory
        Dim lstCombinados As List(Of String)
        Dim itnDados As ListViewItem
        Dim aDados As String()
        Dim intCont As Integer

        Try

            oMath = New Combinatory
            lstCombinados = oMath.CombinarValores(strValues, 50)
            intCont = 0

            For Each strDado As String In lstCombinados
                intCont = intCont + 1
                aDados = strDado.Split(","c)
                itnDados = New ListViewItem
                itnDados.Text = "C-" + intCont.ToString
                itnDados.SubItems.Add(aDados(0))
                itnDados.SubItems.Add(aDados(1))
                itnDados.SubItems.Add(aDados(2))
                itnDados.SubItems.Add(aDados(3))
                itnDados.SubItems.Add(aDados(4))
                itnDados.SubItems.Add(aDados(5))
                itnDados.SubItems.Add(aDados(6))
                itnDados.SubItems.Add(aDados(7))
                itnDados.SubItems.Add(aDados(8))
                itnDados.SubItems.Add(aDados(9))
                itnDados.SubItems.Add(aDados(10))
                itnDados.SubItems.Add(aDados(11))
                itnDados.SubItems.Add(aDados(12))
                itnDados.SubItems.Add(aDados(13))
                itnDados.SubItems.Add(aDados(14))
                itnDados.SubItems.Add(aDados(15))
                itnDados.SubItems.Add(aDados(16))
                itnDados.SubItems.Add(aDados(17))
                itnDados.SubItems.Add(aDados(18))
                itnDados.SubItems.Add(aDados(19))
                itnDados.SubItems.Add(aDados(20))
                itnDados.SubItems.Add(aDados(21))
                itnDados.SubItems.Add(aDados(22))
                itnDados.SubItems.Add(aDados(23))
                itnDados.SubItems.Add(aDados(24))
                itnDados.SubItems.Add(aDados(25))
                itnDados.SubItems.Add(aDados(26))
                itnDados.SubItems.Add(aDados(27))
                itnDados.SubItems.Add(aDados(28))
                itnDados.SubItems.Add(aDados(29))
                itnDados.SubItems.Add(aDados(30))
                itnDados.SubItems.Add(aDados(31))
                itnDados.SubItems.Add(aDados(32))
                itnDados.SubItems.Add(aDados(33))
                itnDados.SubItems.Add(aDados(34))
                itnDados.SubItems.Add(aDados(35))
                itnDados.SubItems.Add(aDados(36))
                itnDados.SubItems.Add(aDados(37))
                itnDados.SubItems.Add(aDados(38))
                itnDados.SubItems.Add(aDados(39))
                itnDados.SubItems.Add(aDados(40))
                itnDados.SubItems.Add(aDados(41))
                itnDados.SubItems.Add(aDados(42))
                itnDados.SubItems.Add(aDados(43))
                itnDados.SubItems.Add(aDados(44))
                itnDados.SubItems.Add(aDados(45))
                itnDados.SubItems.Add(aDados(46))
                itnDados.SubItems.Add(aDados(47))
                itnDados.SubItems.Add(aDados(48))
                itnDados.SubItems.Add(aDados(49))
                lvLoterias.Items.Add(itnDados)
            Next

            lstCombinados = Nothing
            oMath = Nothing
            itnDados = Nothing

        Catch ex As Exception
            lstCombinados = Nothing
            oMath = Nothing
            itnDados = Nothing
            ShowErro(ex, "Erro Combinando Dados", "FrmCombinar")
        End Try

    End Sub

    Sub CarregaDadosCombinadosTimeMania(ByVal strValues As String)

        Dim oMath As Combinatory
        Dim lstCombinados As List(Of String)
        Dim itnDados As ListViewItem
        Dim aDados As String()
        Dim intCont As Integer

        Try

            oMath = New Combinatory
            lstCombinados = oMath.CombinarValores(strValues, 7)
            intCont = 0

            For Each strDado As String In lstCombinados
                intCont = intCont + 1
                aDados = strDado.Split(","c)
                itnDados = New ListViewItem
                itnDados.Text = "C-" + intCont.ToString
                itnDados.SubItems.Add(aDados(0))
                itnDados.SubItems.Add(aDados(1))
                itnDados.SubItems.Add(aDados(2))
                itnDados.SubItems.Add(aDados(3))
                itnDados.SubItems.Add(aDados(4))
                itnDados.SubItems.Add(aDados(5))
                itnDados.SubItems.Add(aDados(6))
                lvLoterias.Items.Add(itnDados)
            Next

            lstCombinados = Nothing
            oMath = Nothing
            itnDados = Nothing

        Catch ex As Exception
            lstCombinados = Nothing
            oMath = Nothing
            itnDados = Nothing
            ShowErro(ex, "Erro Combinando Dados", "FrmCombinar")
        End Try

    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class