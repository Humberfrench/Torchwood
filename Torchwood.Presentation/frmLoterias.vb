Imports Torchwood.Core
Imports Torchwood.Struct
Imports System.Configuration.ConfigurationManager
Imports System.Threading.Thread
Imports System.Globalization
Imports System

Public Class frmLoterias

    Dim FlagNovo As Boolean
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Carega o combo e a grid
        LoadCombo()
        LoadGrid()

        'Seta para novo registro        
        FlagNovo = True

        Novo()

    End Sub

    Sub Novo()

        'seta os botoes
        Me.btnAltStatus.Enabled = False
        Me.btnExcluir.Enabled = False
        Me.ddlLoteria.SelectedIndex = -1
        Me.txtDezSorteio.Text = ""
        Me.txtDezTotais.Text = ""
        Me.txtDezInicial.Text = ""
        Me.txtDezFinal.Text = ""
        Me.txtPremMin.Text = ""
        Me.txtPremMax.Text = ""

    End Sub

    Sub LoadCombo()
        Dim oLoterias As Core.Data.Loterias
        Dim lLoterias As List(Of Struct.Loteria)

        oLoterias = New Core.Data.Loterias(GetKey())
        lLoterias = oLoterias.ListAll

        For Each oItem As Struct.Loteria In lLoterias
            Me.ddlLoteria.Items.Add(oItem)
        Next

        oLoterias = Nothing
        lLoterias = Nothing

    End Sub

    Sub LoadGrid()

        Dim lstResult As List(Of Struct.Loteria) = Nothing
        Dim oTorch As Core.Data.Loterias
        Dim oItemGrid As ListViewItem = Nothing

        Try
            oTorch = New Core.Data.Loterias(GetKey())
            lstResult = oTorch.ListAll

            'carregando o grid
            'Me.lvLoterias.Items.Clear 
            For Each oDado As Struct.Loteria In lstResult
                oItemGrid = New ListViewItem
                oItemGrid.Text = oDado.Codigo.ToString()
                oItemGrid.SubItems.Add(oDado.Descricao)
                oItemGrid.SubItems.Add(oDado.DezMinima.ToString())
                oItemGrid.SubItems.Add(oDado.DezMaxima.ToString())
                oItemGrid.SubItems.Add(oDado.QtdeDezenas.ToString())
                oItemGrid.SubItems.Add(oDado.QtdeMinOccurs.ToString())
                oItemGrid.SubItems.Add(oDado.QtdeDezenasTotais.ToString())
                'status
                If oDado.Status.ToString() = "A" Then
                    oItemGrid.SubItems.Add("Ativo")
                Else
                    oItemGrid.SubItems.Add("Inativo")
                End If
                Me.lvLoterias.Items.Add(oItemGrid)
            Next
        Catch ex As Exception
            lstResult = Nothing
            oTorch = Nothing
            oItemGrid = Nothing
            MessageBox.Show("Ocorreu o seguinte Erro:" + vbNewLine + ex.Message.ToString(), _
                            "Erro Ocorrido", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub LerDadosCombo()
        Dim oLoteria As Struct.Loteria

        Try

            oLoteria = ddlLoteria.SelectedItem
            If IsNothing(oLoteria) Then
                Exit Sub
            End If

            Me.txtDezSorteio.Text = oLoteria.QtdeDezenas.ToString()
            Me.txtDezTotais.Text = oLoteria.QtdeDezenasTotais.ToString()
            Me.txtDezInicial.Text = oLoteria.DezMinima.ToString()
            Me.txtDezFinal.Text = oLoteria.DezMaxima.ToString()
            Me.txtPremMin.Text = oLoteria.QtdeMinOccurs.ToString()
            Me.txtPremMax.Text = oLoteria.QtdeDezenas.ToString()

            If oLoteria.Status = "A" Then
                chkAtivo.Checked = True
            Else
                chkAtivo.Checked = False
            End If

            oLoteria = Nothing

        Catch ex As Exception
            oLoteria = Nothing
            MessageBox.Show("Ocorreu o seguinte Erro:" + vbNewLine + ex.Message.ToString(), _
                            "Erro Ocorrido", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

    End Sub

    Private Sub ddlLoteria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlLoteria.SelectedIndexChanged
        LerDadosCombo()
    End Sub
End Class
