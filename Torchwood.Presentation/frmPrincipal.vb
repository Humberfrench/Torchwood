Imports System.Windows.Forms
Imports System.Configuration.ConfigurationManager
Imports System.Threading.Thread
Imports System.Globalization
Imports System

Public Class frmPrincipal

    Private Sub ConfiguraçãoDeLoteriasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraçãoDeLoteriasToolStripMenuItem.Click

        Dim oForm As frmLoterias
        oForm = New frmLoterias
        oForm.MdiParent = Me
        oForm.Show()

    End Sub

    Private Sub CadastroDeDezenasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroDeDezenasToolStripMenuItem.Click

        Dim oForm As FrmMaster
        oForm = New FrmMaster
        oForm.MdiParent = Me
        oForm.Show()

    End Sub

    Private Sub ImportaçãoDeResultadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportaçãoDeResultadosToolStripMenuItem.Click

        Dim oForm As FormImportacao
        oForm = New FormImportacao
        oForm.MdiParent = Me
        oForm.Show()

    End Sub

    Private Sub ResultadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResultadosToolStripMenuItem.Click

        Dim oForm As FrmMaster
        oForm = New FrmMaster
        oForm.MdiParent = Me
        oForm.Show()

    End Sub

    Private Sub BestDezenasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BestDezenasToolStripMenuItem.Click

        Dim oForm As FormMelhoresDezenas
        oForm = New FormMelhoresDezenas
        oForm.MdiParent = Me
        oForm.Show()

    End Sub

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'setando a cultura
        CurrentThread.CurrentCulture = New CultureInfo("pt-BR")
        SetStatus()

    End Sub

    Sub SetStatus()

        tstlUsername.Text = My.User.Name
        tstlCulture.Text = My.Application.Culture.ToString()
        tstlStatus.Text = My.Application.Info.Title
        tstlVersion.Text = My.Application.Info.Version.Major.ToString() + "." + _
                           My.Application.Info.Version.Minor.ToString() + "." + _
                           My.Application.Info.Version.Build.ToString()

        'data e hora
        SetDateTime()
        SetAmbiente()

    End Sub
    Sub SetDateTime()

        tstlData.Text = DateTime.Now.ToShortDateString()
        tstlHora.Text = DateTime.Now.ToShortTimeString()

    End Sub
    Sub SetAmbiente()

        If strAmbiente.Trim() = "" Then
            strAmbiente = AppSettings("Ambiente")
        End If
        If strAmbiente = "Prod" Then
            Me.ttstAmbiente.Text = "Produção"
        Else
            Me.ttstAmbiente.Text = "Desenvolvimento"
        End If

    End Sub

    Private Sub ttckDev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ttckDev.Click

        ttckDev.Checked = True
        ttckProd.Checked = False
        strAmbiente = "Dev"

    End Sub

    Private Sub ttckProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ttckProd.Click

        ttckDev.Checked = False
        ttckProd.Checked = True
        strAmbiente = "Prod"

    End Sub

    Private Sub CockPitDeDadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CockPitDeDadosToolStripMenuItem.Click

        Dim oForm As frmCockPit
        oForm = New frmCockPit
        oForm.MdiParent = Me
        oForm.Show()

    End Sub

    Private Sub AtrasosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtrasosToolStripMenuItem.Click

        Dim oForm As FormAtrasos
        oForm = New FormAtrasos
        oForm.MdiParent = Me
        oForm.Show()

    End Sub

    Private Sub SetDePesquisasDeHistoricosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetDePesquisasDeHistoricosToolStripMenuItem.Click

        Dim oForm As frmSetPesquisaHistorico
        oForm = New frmSetPesquisaHistorico
        oForm.MdiParent = Me
        oForm.Show()

    End Sub

    Private Sub PerformanceDasDezenasPorFaixasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerformanceDasDezenasPorFaixasToolStripMenuItem.Click

        Dim oForm As FormPerformance
        oForm = New FormPerformance
        oForm.MdiParent = Me
        oForm.Show()

    End Sub

    Private Sub GerarTabelaDeLoteriasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GerarTabelaDeLoteriasToolStripMenuItem.Click

        Dim oForm As frmGenerateAllLoteries
        oForm = New frmGenerateAllLoteries
        oForm.MdiParent = Me
        oForm.Show()

    End Sub

    Private Sub BestDezenasEAtrasosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BestDezenasEAtrasosToolStripMenuItem.Click

        Dim oForm As FormBestDezenasAtrasos
        oForm = New FormBestDezenasAtrasos
        oForm.MdiParent = Me
        oForm.Show()


    End Sub

    Private Sub SobreOProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreOProgramaToolStripMenuItem.Click

        Dim oForm As AboutBoxTorchwood
        oForm = New AboutBoxTorchwood
        oForm.ShowDialog()


    End Sub
End Class
