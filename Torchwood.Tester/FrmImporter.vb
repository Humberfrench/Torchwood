Imports Torchwood.Core
Imports Torchwood.Struct
Imports System.Configuration.ConfigurationManager
Imports System.Threading.Thread
Imports System.Globalization

Public Class FrmImporter

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click

        Dim oTorch As Data.Excel
        Dim intTorch As Integer
        Dim lDados As ListViewItem

        CurrentThread.CurrentCulture = New CultureInfo("en-US")
        Me.pbAndamento.Value = 0

        oTorch = New Data.Excel(strKey)
        intTorch = oTorch.ImportsMegaSena(AppSettings("ExcelFile").ToString(), 1)
        lDados = New ListViewItem
        lDados.Text = "Mega-Sena"
        lDados.SubItems.Add(intTorch.ToString())
        Me.lvResults.Items.Add(lDados)
        Me.pbAndamento.Value = 1

        intTorch = oTorch.ImportsDuplaSenaS1(AppSettings("ExcelFile").ToString(), 2)
        lDados = New ListViewItem
        lDados.Text = "Dupla-Sena Sorteio 1"
        lDados.SubItems.Add(intTorch.ToString())
        Me.lvResults.Items.Add(lDados)
        Me.pbAndamento.Value = 2

        intTorch = oTorch.ImportsDuplaSenaS2(AppSettings("ExcelFile").ToString(), 3)
        lDados = New ListViewItem
        lDados.Text = "Dupla-Sena Sorteio 2"
        lDados.SubItems.Add(intTorch.ToString())
        Me.lvResults.Items.Add(lDados)
        Me.pbAndamento.Value = 3

        intTorch = oTorch.ImportsLotoMania(AppSettings("ExcelFile").ToString(), 4)
        lDados = New ListViewItem
        lDados.Text = "LotoMania"
        lDados.SubItems.Add(intTorch.ToString())
        Me.lvResults.Items.Add(lDados)
        Me.pbAndamento.Value = 4

        intTorch = oTorch.ImportsLotoFacil(AppSettings("ExcelFile").ToString(), 5)
        lDados = New ListViewItem
        lDados.Text = "LotoFacil"
        lDados.SubItems.Add(intTorch.ToString())
        Me.lvResults.Items.Add(lDados)
        Me.pbAndamento.Value = 5

        intTorch = oTorch.ImportsQuina(AppSettings("ExcelFile").ToString(), 6)
        lDados = New ListViewItem
        lDados.Text = "Quina"
        lDados.SubItems.Add(intTorch.ToString())
        Me.lvResults.Items.Add(lDados)
        Me.pbAndamento.Value = 6

        'devolvendo a cultura
        CurrentThread.CurrentCulture = New CultureInfo("pt-BR")

        oTorch = Nothing

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        End
    End Sub
End Class
