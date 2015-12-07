Imports Torchwood.Core
Imports Torchwood.Struct
Imports System.Configuration.ConfigurationManager
Imports System.Threading.Thread
Imports System.Globalization
Imports System
Imports System.Text

Public Class FrmImporter

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Width = 614
        Me.Height = 282

    End Sub


    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click

        Dim oTorch As Data.Excel
        Dim intTorch As Integer
        Dim lDados As ListViewItem
        Dim strConcursos As String = String.Empty
        Dim aStrConcurso As String()
        Dim stbResult As StringBuilder
        If txtFilename.Text.Trim() = "" Then
            'erro
            MessageBox.Show("É preciso selecionar um arquivo para a importação.", "Torchwood Importer", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            CurrentThread.CurrentCulture = New CultureInfo("en-US")
            Me.pbAndamento.Value = 0
            oTorch = New Data.Excel(strKey)

            Me.lvResults.Items.Clear()

            If chkMegaSena.Checked Then
                picLoteria.ImageLocation = "1.gif"
                Me.Refresh()
                intTorch = oTorch.ImportsMegaSena(txtFilename.Text.ToString(), 1)
                lDados = New ListViewItem
                lDados.Text = "Mega-Sena"
                lDados.SubItems.Add(intTorch.ToString())
                Me.lvResults.Items.Add(lDados)
            End If
            Me.pbAndamento.Value = 1

            If chkDuplaSena1.Checked Then
                picLoteria.ImageLocation = "2.gif"
                Me.Refresh()
                intTorch = oTorch.ImportsDuplaSenaS1(txtFilename.Text.ToString(), 2)
                lDados = New ListViewItem
                lDados.Text = "Dupla-Sena Sorteio 1"
                lDados.SubItems.Add(intTorch.ToString())
                Me.lvResults.Items.Add(lDados)
            End If
            Me.pbAndamento.Value = 2

            If chkDuplaSena2.Checked Then
                picLoteria.ImageLocation = "3.gif"
                Me.Refresh()
                intTorch = oTorch.ImportsDuplaSenaS2(txtFilename.Text.ToString(), 3)
                lDados = New ListViewItem
                lDados.Text = "Dupla-Sena Sorteio 2"
                lDados.SubItems.Add(intTorch.ToString())
                Me.lvResults.Items.Add(lDados)
            End If
            Me.pbAndamento.Value = 3

            If chkLotoMania.Checked Then
                picLoteria.ImageLocation = "4.gif"
                Me.Refresh()
                intTorch = oTorch.ImportsLotoMania(txtFilename.Text.ToString(), 4)
                lDados = New ListViewItem
                lDados.Text = "LotoMania"
                lDados.SubItems.Add(intTorch.ToString())
                Me.lvResults.Items.Add(lDados)
            End If
            Me.pbAndamento.Value = 4

            If chkLotoFacil.Checked Then
                picLoteria.ImageLocation = "5.gif"
                Me.Refresh()
                intTorch = oTorch.ImportsLotoFacil(txtFilename.Text.ToString(), 5)
                lDados = New ListViewItem
                lDados.Text = "LotoFacil"
                lDados.SubItems.Add(intTorch.ToString())
                Me.lvResults.Items.Add(lDados)
            End If
            Me.pbAndamento.Value = 5

            If chkQuina.Checked Then
                picLoteria.ImageLocation = "6.gif"
                Me.Refresh()
                intTorch = oTorch.ImportsQuina(txtFilename.Text.ToString(), 6)
                lDados = New ListViewItem
                lDados.Text = "Quina"
                lDados.SubItems.Add(intTorch.ToString())
                Me.lvResults.Items.Add(lDados)
            End If
            Me.pbAndamento.Value = 6

            If chkTimeMania.Checked Then
                picLoteria.ImageLocation = "7.gif"
                Me.Refresh()
                intTorch = oTorch.ImportsTimeMania(txtFilename.Text.ToString(), 7, strConcursos)
                lDados = New ListViewItem
                lDados.Text = "Time Mania"
                lDados.SubItems.Add(intTorch.ToString())
                Me.lvResults.Items.Add(lDados)
                If Not (strConcursos = String.Empty) Then
                    aStrConcurso = strConcursos.Split(";"c)
                    stbResult = New StringBuilder()
                    For intCont As Integer = 0 To aStrConcurso.Length - 1
                        stbResult.Append("O Concurso ")
                        stbResult.Append(aStrConcurso(intCont))
                        stbResult.Append(" não foi processado. Time não encontrado!")
                        stbResult.Append(vbNewLine)
                    Next
                    Util.ShowErro(stbResult.ToString(), "Concursos não processados", "FrmImporter.btnImportar_Click()")
                End If
            End If
            Me.pbAndamento.Value = 7

            'devolvendo a cultura
            CurrentThread.CurrentCulture = New CultureInfo("pt-BR")
            Me.Cursor = Cursors.Arrow
            oTorch = Nothing
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            oTorch = Nothing
            Util.ShowErro(ex, "Erro", "FrmImporter.btnImportar_Click()")

        End Try

    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
        'FrmImporter = Nothing
    End Sub


    Private Sub btnLocate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocate.Click

        Dim objResult As DialogResult

        'buscar os arquivos
        objResult = ofdImportar.ShowDialog()

        If objResult = Windows.Forms.DialogResult.OK Then
            txtFilename.Text = ofdImportar.FileName
        End If

    End Sub

End Class
