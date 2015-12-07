Imports System

Public Class frmAnaliseLotoFacil

    Private Sub frmAnaliseLoterias_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'inicialmente este forme serve para teste de dados da sena.
        'a ideia é ver as combinacoes quie podemos ter na Loto-Fácil!

        Dim lstDados As List(Of String) = Nothing
        Dim oBusiness As Torchwood.Core.Analise.Lotofacil = Nothing

        Try
            oBusiness = New Torchwood.Core.Analise.Lotofacil()
            lstDados = oBusiness.Obter()

        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Erro Captando Dezenas da Loto-Fácil", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        MessageBox.Show(lstDados.Count.ToString, "Quantidade de Ocorrências Válidas", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class