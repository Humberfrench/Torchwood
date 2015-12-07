Imports System

Public Class frmAnaliseMegaSena

    Private Sub frmAnaliseLoterias_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'inicialmente este forme serve para teste de dados da sena.
        'a ideia é ver as combinacoes quie podemos ter na SENA!

        Dim lstDados As List(Of String) = Nothing
        Dim oBusiness As Torchwood.Core.Business.Combinacoes.MegaSena = Nothing

        Try
            oBusiness = New Torchwood.Core.Business.Combinacoes.MegaSena()
            lstDados = oBusiness.CombinarValoresSena()

        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Erro Captando Dezenas da Mega-Sena", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        MessageBox.Show(lstDados.Count.ToString, "Quantidade de Ocorrências Válidas", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class