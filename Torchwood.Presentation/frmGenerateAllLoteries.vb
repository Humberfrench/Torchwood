Imports System

Public Class frmGenerateAllLoteries

    Private Sub btnGravaLoteria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGravaLoteria.Click

        Dim objDados As Torchwood.Core.Data.Loterias = Nothing
        Dim objLoteria As Torchwood.Struct.Loteria = Nothing

        Try

            Me.Cursor = Cursors.WaitCursor

            objDados = New Torchwood.Core.Data.Loterias("torchConn")
            
            If GetNumberOfUpdates() < 1 Then
                Me.Cursor = Cursors.Arrow
                'Erro
                objDados = Nothing
                objLoteria = Nothing
                Exit Sub
            End If

            pbDados.Minimum = 1
            pbDados.Maximum = GetNumberOfUpdates()

            'Mega-Sena
            objLoteria = New Torchwood.Struct.Loteria(1, "Mega Sena", "A")
            objLoteria.DezMaxima = 60
            objLoteria.DezMinima = 1
            objLoteria.QtdeDezenas = 60
            objLoteria.QtdeDezenasTotais = 60
            objLoteria.QtdeMinOccurs = 4
            objDados.Add(objLoteria)
            pbDados.Value = 1

            'Dupla-Sena-S01
            objLoteria = New Torchwood.Struct.Loteria(2, "Dupla Sena Sorteio 1", "A")
            objLoteria.DezMaxima = 60
            objLoteria.DezMinima = 1
            objLoteria.QtdeDezenas = 6
            objLoteria.QtdeDezenasTotais = 50
            objLoteria.QtdeMinOccurs = 4
            objDados.Add(objLoteria)
            pbDados.Value = 2

            'Dupla-Sena-S02
            objLoteria = New Torchwood.Struct.Loteria(3, "Dupla Sena Sorteio 2", "A")
            objLoteria.DezMaxima = 60
            objLoteria.DezMinima = 1
            objLoteria.QtdeDezenas = 6
            objLoteria.QtdeDezenasTotais = 50
            objLoteria.QtdeMinOccurs = 4
            objDados.Add(objLoteria)
            pbDados.Value = 3

            'Loto-Mania
            objLoteria = New Torchwood.Struct.Loteria(4, "Loto Mania", "A")
            objLoteria.DezMaxima = 100
            objLoteria.DezMinima = 1
            objLoteria.QtdeDezenas = 20
            objLoteria.QtdeDezenasTotais = 100
            objLoteria.QtdeMinOccurs = 16
            objDados.Add(objLoteria)
            pbDados.Value = 4

            'Loto-Fácil
            objLoteria = New Torchwood.Struct.Loteria(5, "Loto Fácil", "A")
            objLoteria.DezMaxima = 25
            objLoteria.DezMinima = 1
            objLoteria.QtdeDezenas = 15
            objLoteria.QtdeDezenasTotais = 25
            objLoteria.QtdeMinOccurs = 11
            objDados.Add(objLoteria)
            pbDados.Value = 5

            'Quina
            objLoteria = New Torchwood.Struct.Loteria(6, "Quina", "A")
            objLoteria.DezMaxima = 80
            objLoteria.DezMinima = 1
            objLoteria.QtdeDezenas = 5
            objLoteria.QtdeDezenasTotais = 80
            objLoteria.QtdeMinOccurs = 3
            objDados.Add(objLoteria)
            pbDados.Value = 6

            'Time-Mania-Dezenas
            objLoteria = New Torchwood.Struct.Loteria(7, "TimeMania Dezenas", "A")
            objLoteria.DezMaxima = 80
            objLoteria.DezMinima = 1
            objLoteria.QtdeDezenas = 7
            objLoteria.QtdeDezenasTotais = 80
            objLoteria.QtdeMinOccurs = 4
            objDados.Add(objLoteria)
            pbDados.Value = 7

            'Time-Mania-Times
            objLoteria = New Torchwood.Struct.Loteria(8, "TimeMania Times", "A")
            objLoteria.DezMaxima = 80
            objLoteria.DezMinima = 1
            objLoteria.QtdeDezenas = 1
            objLoteria.QtdeDezenasTotais = 80
            objLoteria.QtdeMinOccurs = 1
            objDados.Add(objLoteria)
            pbDados.Value = 8

            objDados = Nothing
            objLoteria = Nothing
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            'erro ocorrido at: pbDados.Value
            Me.Cursor = Cursors.Arrow
            objDados = Nothing
            objLoteria = Nothing

        End Try


    End Sub

    Function GetNumberOfUpdates() As Integer

        Dim intCont As Integer = 0

        If chkMegaSena.Checked Then
            intCont += 1
        End If

        If chkDuplaSena1.Checked Then
            intCont += 1
        End If

        If chkDuplaSena2.Checked Then
            intCont += 1
        End If

        If chkLotoMania.Checked Then
            intCont += 1
        End If

        If chkLotoFacil.Checked Then
            intCont += 1
        End If

        If chkQuina.Checked Then
            intCont += 1
        End If

        If chkTimeMania.Checked Then
            intCont += 1
        End If

        If chkTimeManiaTimes.Checked Then
            intCont += 1
        End If

        Return intCont

    End Function
End Class