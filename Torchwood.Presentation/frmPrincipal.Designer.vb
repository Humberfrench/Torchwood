<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.tstlStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ttstAmbiente = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tstlUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tstlVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tstlCulture = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tstlData = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tstlHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ttddAmbiente = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ttckDev = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttckProd = New System.Windows.Forms.ToolStripMenuItem()
        Me.DadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeDezenasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraçãoDeLoteriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImportaçãoDeResultadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerarTabelaDeLoteriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstatísticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultadosTodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BestDezenasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtrasosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BestDezenasEAtrasosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerformanceDasDezenasPorFaixasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CockPitDeDadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SetDePesquisasDeHistoricosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MontagemDeCenáriosDePesquisasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.HistogramasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreOProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstlStatus, Me.ttstAmbiente, Me.tstlUsername, Me.tstlVersion, Me.tstlCulture, Me.tstlData, Me.tstlHora, Me.ttddAmbiente})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 429)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(728, 24)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'tstlStatus
        '
        Me.tstlStatus.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tstlStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.tstlStatus.Name = "tstlStatus"
        Me.tstlStatus.Size = New System.Drawing.Size(144, 19)
        Me.tstlStatus.Spring = True
        Me.tstlStatus.Text = "Status"
        Me.tstlStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ttstAmbiente
        '
        Me.ttstAmbiente.AutoSize = False
        Me.ttstAmbiente.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ttstAmbiente.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.ttstAmbiente.Name = "ttstAmbiente"
        Me.ttstAmbiente.Size = New System.Drawing.Size(90, 19)
        '
        'tstlUsername
        '
        Me.tstlUsername.AutoSize = False
        Me.tstlUsername.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tstlUsername.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.tstlUsername.Name = "tstlUsername"
        Me.tstlUsername.Size = New System.Drawing.Size(200, 19)
        Me.tstlUsername.Text = "UserName"
        '
        'tstlVersion
        '
        Me.tstlVersion.AutoSize = False
        Me.tstlVersion.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tstlVersion.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.tstlVersion.Name = "tstlVersion"
        Me.tstlVersion.Size = New System.Drawing.Size(75, 19)
        Me.tstlVersion.Text = "Version"
        '
        'tstlCulture
        '
        Me.tstlCulture.AutoSize = False
        Me.tstlCulture.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tstlCulture.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.tstlCulture.Name = "tstlCulture"
        Me.tstlCulture.Size = New System.Drawing.Size(50, 19)
        Me.tstlCulture.Text = "pt-Br"
        '
        'tstlData
        '
        Me.tstlData.AutoSize = False
        Me.tstlData.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tstlData.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.tstlData.Name = "tstlData"
        Me.tstlData.Size = New System.Drawing.Size(75, 19)
        Me.tstlData.Text = "00/00/0000"
        '
        'tstlHora
        '
        Me.tstlHora.AutoSize = False
        Me.tstlHora.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tstlHora.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.tstlHora.Name = "tstlHora"
        Me.tstlHora.Size = New System.Drawing.Size(50, 19)
        Me.tstlHora.Text = "00:00"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DadosToolStripMenuItem, Me.EstatísticasToolStripMenuItem, Me.SobreToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(728, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ttddAmbiente
        '
        Me.ttddAmbiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ttddAmbiente.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttckDev, Me.ttckProd})
        Me.ttddAmbiente.Image = Global.Torchwood.Presentation.My.Resources.Resources.computer
        Me.ttddAmbiente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ttddAmbiente.Name = "ttddAmbiente"
        Me.ttddAmbiente.Size = New System.Drawing.Size(29, 20)
        Me.ttddAmbiente.Text = "ToolStripDropDownButton1"
        '
        'ttckDev
        '
        Me.ttckDev.CheckOnClick = True
        Me.ttckDev.Image = Global.Torchwood.Presentation.My.Resources.Resources.lightbulb_off
        Me.ttckDev.Name = "ttckDev"
        Me.ttckDev.Size = New System.Drawing.Size(166, 22)
        Me.ttckDev.Text = "Desenvolvimento"
        '
        'ttckProd
        '
        Me.ttckProd.CheckOnClick = True
        Me.ttckProd.Image = Global.Torchwood.Presentation.My.Resources.Resources.lightbulb
        Me.ttckProd.Name = "ttckProd"
        Me.ttckProd.Size = New System.Drawing.Size(166, 22)
        Me.ttckProd.Text = "Produção"
        '
        'DadosToolStripMenuItem
        '
        Me.DadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeDezenasToolStripMenuItem, Me.ConfiguraçãoDeLoteriasToolStripMenuItem, Me.ToolStripMenuItem3, Me.ImportaçãoDeResultadosToolStripMenuItem, Me.GerarTabelaDeLoteriasToolStripMenuItem, Me.ToolStripMenuItem1, Me.SairToolStripMenuItem})
        Me.DadosToolStripMenuItem.Image = Global.Torchwood.Presentation.My.Resources.Resources.databases
        Me.DadosToolStripMenuItem.Name = "DadosToolStripMenuItem"
        Me.DadosToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.DadosToolStripMenuItem.Text = "Dados"
        '
        'CadastroDeDezenasToolStripMenuItem
        '
        Me.CadastroDeDezenasToolStripMenuItem.Image = Global.Torchwood.Presentation.My.Resources.Resources.textfield_rename
        Me.CadastroDeDezenasToolStripMenuItem.Name = "CadastroDeDezenasToolStripMenuItem"
        Me.CadastroDeDezenasToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.CadastroDeDezenasToolStripMenuItem.Text = "Cadastro de Dezenas"
        '
        'ConfiguraçãoDeLoteriasToolStripMenuItem
        '
        Me.ConfiguraçãoDeLoteriasToolStripMenuItem.Image = Global.Torchwood.Presentation.My.Resources.Resources.buildings
        Me.ConfiguraçãoDeLoteriasToolStripMenuItem.Name = "ConfiguraçãoDeLoteriasToolStripMenuItem"
        Me.ConfiguraçãoDeLoteriasToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ConfiguraçãoDeLoteriasToolStripMenuItem.Text = "Configuração de Loterias"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(208, 6)
        '
        'ImportaçãoDeResultadosToolStripMenuItem
        '
        Me.ImportaçãoDeResultadosToolStripMenuItem.Image = Global.Torchwood.Presentation.My.Resources.Resources.doc_excel_table
        Me.ImportaçãoDeResultadosToolStripMenuItem.Name = "ImportaçãoDeResultadosToolStripMenuItem"
        Me.ImportaçãoDeResultadosToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ImportaçãoDeResultadosToolStripMenuItem.Text = "Importação de Resultados"
        '
        'GerarTabelaDeLoteriasToolStripMenuItem
        '
        Me.GerarTabelaDeLoteriasToolStripMenuItem.Image = Global.Torchwood.Presentation.My.Resources.Resources.databases
        Me.GerarTabelaDeLoteriasToolStripMenuItem.Name = "GerarTabelaDeLoteriasToolStripMenuItem"
        Me.GerarTabelaDeLoteriasToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.GerarTabelaDeLoteriasToolStripMenuItem.Text = "Gerar Tabela de Loterias"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(208, 6)
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Image = Global.Torchwood.Presentation.My.Resources.Resources.door_in
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.SairToolStripMenuItem.Text = "Sai&r"
        '
        'EstatísticasToolStripMenuItem
        '
        Me.EstatísticasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResultadosToolStripMenuItem, Me.ResultadosTodosToolStripMenuItem, Me.ToolStripSeparator1, Me.BestDezenasToolStripMenuItem, Me.AtrasosToolStripMenuItem, Me.BestDezenasEAtrasosToolStripMenuItem, Me.PerformanceDasDezenasPorFaixasToolStripMenuItem, Me.ToolStripMenuItem2, Me.CockPitDeDadosToolStripMenuItem, Me.ToolStripSeparator2, Me.SetDePesquisasDeHistoricosToolStripMenuItem, Me.MontagemDeCenáriosDePesquisasToolStripMenuItem, Me.ToolStripSeparator3, Me.HistogramasToolStripMenuItem})
        Me.EstatísticasToolStripMenuItem.Image = Global.Torchwood.Presentation.My.Resources.Resources.chart_pie
        Me.EstatísticasToolStripMenuItem.Name = "EstatísticasToolStripMenuItem"
        Me.EstatísticasToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.EstatísticasToolStripMenuItem.Text = "Estatísticas"
        '
        'ResultadosToolStripMenuItem
        '
        Me.ResultadosToolStripMenuItem.Image = Global.Torchwood.Presentation.My.Resources.Resources.table
        Me.ResultadosToolStripMenuItem.Name = "ResultadosToolStripMenuItem"
        Me.ResultadosToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.ResultadosToolStripMenuItem.Text = "Resultados Individual"
        '
        'ResultadosTodosToolStripMenuItem
        '
        Me.ResultadosTodosToolStripMenuItem.Image = Global.Torchwood.Presentation.My.Resources.Resources.table
        Me.ResultadosTodosToolStripMenuItem.Name = "ResultadosTodosToolStripMenuItem"
        Me.ResultadosTodosToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.ResultadosTodosToolStripMenuItem.Text = "Resultados Todos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(265, 6)
        '
        'BestDezenasToolStripMenuItem
        '
        Me.BestDezenasToolStripMenuItem.Image = Global.Torchwood.Presentation.My.Resources.Resources.rosette
        Me.BestDezenasToolStripMenuItem.Name = "BestDezenasToolStripMenuItem"
        Me.BestDezenasToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.BestDezenasToolStripMenuItem.Text = "Best Dezenas"
        '
        'AtrasosToolStripMenuItem
        '
        Me.AtrasosToolStripMenuItem.Image = Global.Torchwood.Presentation.My.Resources.Resources.alarm
        Me.AtrasosToolStripMenuItem.Name = "AtrasosToolStripMenuItem"
        Me.AtrasosToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.AtrasosToolStripMenuItem.Text = "Atrasos"
        '
        'BestDezenasEAtrasosToolStripMenuItem
        '
        Me.BestDezenasEAtrasosToolStripMenuItem.Image = Global.Torchwood.Presentation.My.Resources.Resources.chart_pie
        Me.BestDezenasEAtrasosToolStripMenuItem.Name = "BestDezenasEAtrasosToolStripMenuItem"
        Me.BestDezenasEAtrasosToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.BestDezenasEAtrasosToolStripMenuItem.Text = "Best Dezenas e Atrasos"
        '
        'PerformanceDasDezenasPorFaixasToolStripMenuItem
        '
        Me.PerformanceDasDezenasPorFaixasToolStripMenuItem.Image = Global.Torchwood.Presentation.My.Resources.Resources.vector
        Me.PerformanceDasDezenasPorFaixasToolStripMenuItem.Name = "PerformanceDasDezenasPorFaixasToolStripMenuItem"
        Me.PerformanceDasDezenasPorFaixasToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.PerformanceDasDezenasPorFaixasToolStripMenuItem.Text = "Performance das Dezenas Por Faixas"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(265, 6)
        '
        'CockPitDeDadosToolStripMenuItem
        '
        Me.CockPitDeDadosToolStripMenuItem.Image = Global.Torchwood.Presentation.My.Resources.Resources.color_swatch_2
        Me.CockPitDeDadosToolStripMenuItem.Name = "CockPitDeDadosToolStripMenuItem"
        Me.CockPitDeDadosToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.CockPitDeDadosToolStripMenuItem.Text = "CockPit de Dados"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(265, 6)
        '
        'SetDePesquisasDeHistoricosToolStripMenuItem
        '
        Me.SetDePesquisasDeHistoricosToolStripMenuItem.Image = Global.Torchwood.Presentation.My.Resources.Resources.clock
        Me.SetDePesquisasDeHistoricosToolStripMenuItem.Name = "SetDePesquisasDeHistoricosToolStripMenuItem"
        Me.SetDePesquisasDeHistoricosToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.SetDePesquisasDeHistoricosToolStripMenuItem.Text = "Set de Pesquisas de Historicos"
        '
        'MontagemDeCenáriosDePesquisasToolStripMenuItem
        '
        Me.MontagemDeCenáriosDePesquisasToolStripMenuItem.Image = Global.Torchwood.Presentation.My.Resources.Resources.page_lightning
        Me.MontagemDeCenáriosDePesquisasToolStripMenuItem.Name = "MontagemDeCenáriosDePesquisasToolStripMenuItem"
        Me.MontagemDeCenáriosDePesquisasToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.MontagemDeCenáriosDePesquisasToolStripMenuItem.Text = "Montagem de Cenários de Pesquisas"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(265, 6)
        '
        'HistogramasToolStripMenuItem
        '
        Me.HistogramasToolStripMenuItem.Image = Global.Torchwood.Presentation.My.Resources.Resources.chart_bar
        Me.HistogramasToolStripMenuItem.Name = "HistogramasToolStripMenuItem"
        Me.HistogramasToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.HistogramasToolStripMenuItem.Text = "Histogramas"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreOProgramaToolStripMenuItem})
        Me.SobreToolStripMenuItem.Image = Global.Torchwood.Presentation.My.Resources.Resources.ajuda
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'SobreOProgramaToolStripMenuItem
        '
        Me.SobreOProgramaToolStripMenuItem.Image = Global.Torchwood.Presentation.My.Resources.Resources.ajuda
        Me.SobreOProgramaToolStripMenuItem.Name = "SobreOProgramaToolStripMenuItem"
        Me.SobreOProgramaToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.SobreOProgramaToolStripMenuItem.Text = "Sobre o Programa"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 453)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmPrincipal"
        Me.Text = "Torchwood Systems"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents tstlStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroDeDezenasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraçãoDeLoteriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportaçãoDeResultadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstatísticasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResultadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BestDezenasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreOProgramaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResultadosTodosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CockPitDeDadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tstlHora As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tstlData As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tstlUsername As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tstlVersion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tstlCulture As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ttddAmbiente As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ttckDev As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttckProd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttstAmbiente As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AtrasosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetDePesquisasDeHistoricosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MontagemDeCenáriosDePesquisasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistogramasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PerformanceDasDezenasPorFaixasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GerarTabelaDeLoteriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BestDezenasEAtrasosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
