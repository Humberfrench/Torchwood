<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmResultados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmResultados))
        Me.XpGradientPanel1 = New Steepvalley.Windows.Forms.Containers.XPGradientPanel()
        Me.XpCaptionPane1 = New Steepvalley.Windows.Forms.XPCaptionPane()
        Me.lvLoterias = New System.Windows.Forms.ListView()
        Me.XpCaptionPane2 = New Steepvalley.Windows.Forms.XPCaptionPane()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ddlLoteria = New System.Windows.Forms.ComboBox()
        Me.txtPremMax = New System.Windows.Forms.TextBox()
        Me.btnFechar = New Flowsight.Windows.Forms.CrystalButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPesquisar = New Flowsight.Windows.Forms.CrystalButton()
        Me.txtDezFinal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkAtivo = New System.Windows.Forms.CheckBox()
        Me.txtPremMin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDezTotais = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDezInicial = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDezSorteio = New System.Windows.Forms.TextBox()
        Me.XpGradientPanel1.SuspendLayout()
        Me.XpCaptionPane1.SuspendLayout()
        Me.XpCaptionPane2.SuspendLayout()
        Me.SuspendLayout()
        '
        'XpGradientPanel1
        '
        Me.XpGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.XpGradientPanel1.Controls.Add(Me.XpCaptionPane1)
        Me.XpGradientPanel1.Controls.Add(Me.XpCaptionPane2)
        Me.XpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XpGradientPanel1.EndColor = System.Drawing.Color.LightSteelBlue
        Me.XpGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.XpGradientPanel1.Name = "XpGradientPanel1"
        Me.XpGradientPanel1.Size = New System.Drawing.Size(604, 409)
        Me.XpGradientPanel1.StartColor = System.Drawing.Color.Lavender
        Me.XpGradientPanel1.TabIndex = 2
        '
        'XpCaptionPane1
        '
        Me.XpCaptionPane1.BackColor = System.Drawing.Color.Lavender
        Me.XpCaptionPane1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.XpCaptionPane1.CaptionControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.XpCaptionPane1.CaptionControl.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XpCaptionPane1.CaptionControl.Location = New System.Drawing.Point(1, 1)
        Me.XpCaptionPane1.CaptionControl.Name = "caption"
        Me.XpCaptionPane1.CaptionControl.Size = New System.Drawing.Size(576, 20)
        Me.XpCaptionPane1.CaptionControl.TabIndex = 0
        Me.XpCaptionPane1.CaptionControl.Text = "Dados"
        Me.XpCaptionPane1.CaptionText = "Dados"
        Me.XpCaptionPane1.Controls.Add(Me.lvLoterias)
        Me.XpCaptionPane1.Location = New System.Drawing.Point(12, 158)
        Me.XpCaptionPane1.Name = "XpCaptionPane1"
        Me.XpCaptionPane1.Padding = New System.Windows.Forms.Padding(1)
        Me.XpCaptionPane1.Size = New System.Drawing.Size(580, 239)
        Me.XpCaptionPane1.TabIndex = 61
        '
        'lvLoterias
        '
        Me.lvLoterias.BackColor = System.Drawing.SystemColors.Info
        Me.lvLoterias.FullRowSelect = True
        Me.lvLoterias.Location = New System.Drawing.Point(10, 26)
        Me.lvLoterias.Name = "lvLoterias"
        Me.lvLoterias.Size = New System.Drawing.Size(564, 207)
        Me.lvLoterias.TabIndex = 19
        Me.lvLoterias.UseCompatibleStateImageBehavior = False
        Me.lvLoterias.View = System.Windows.Forms.View.Details
        '
        'XpCaptionPane2
        '
        Me.XpCaptionPane2.BackColor = System.Drawing.Color.Lavender
        Me.XpCaptionPane2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.XpCaptionPane2.CaptionControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.XpCaptionPane2.CaptionControl.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XpCaptionPane2.CaptionControl.Location = New System.Drawing.Point(1, 1)
        Me.XpCaptionPane2.CaptionControl.Name = "caption"
        Me.XpCaptionPane2.CaptionControl.Size = New System.Drawing.Size(576, 20)
        Me.XpCaptionPane2.CaptionControl.TabIndex = 0
        Me.XpCaptionPane2.CaptionControl.Text = "Loteria"
        Me.XpCaptionPane2.CaptionText = "Loteria"
        Me.XpCaptionPane2.Controls.Add(Me.Label1)
        Me.XpCaptionPane2.Controls.Add(Me.ddlLoteria)
        Me.XpCaptionPane2.Controls.Add(Me.txtPremMax)
        Me.XpCaptionPane2.Controls.Add(Me.btnFechar)
        Me.XpCaptionPane2.Controls.Add(Me.Label2)
        Me.XpCaptionPane2.Controls.Add(Me.btnPesquisar)
        Me.XpCaptionPane2.Controls.Add(Me.txtDezFinal)
        Me.XpCaptionPane2.Controls.Add(Me.Label5)
        Me.XpCaptionPane2.Controls.Add(Me.Label4)
        Me.XpCaptionPane2.Controls.Add(Me.chkAtivo)
        Me.XpCaptionPane2.Controls.Add(Me.txtPremMin)
        Me.XpCaptionPane2.Controls.Add(Me.Label3)
        Me.XpCaptionPane2.Controls.Add(Me.txtDezTotais)
        Me.XpCaptionPane2.Controls.Add(Me.Label6)
        Me.XpCaptionPane2.Controls.Add(Me.txtDezInicial)
        Me.XpCaptionPane2.Controls.Add(Me.Label7)
        Me.XpCaptionPane2.Controls.Add(Me.txtDezSorteio)
        Me.XpCaptionPane2.Location = New System.Drawing.Point(12, 12)
        Me.XpCaptionPane2.Name = "XpCaptionPane2"
        Me.XpCaptionPane2.Padding = New System.Windows.Forms.Padding(1)
        Me.XpCaptionPane2.Size = New System.Drawing.Size(580, 140)
        Me.XpCaptionPane2.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Loteria:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ddlLoteria
        '
        Me.ddlLoteria.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ddlLoteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlLoteria.FormattingEnabled = True
        Me.ddlLoteria.Location = New System.Drawing.Point(122, 28)
        Me.ddlLoteria.Name = "ddlLoteria"
        Me.ddlLoteria.Size = New System.Drawing.Size(259, 21)
        Me.ddlLoteria.Sorted = True
        Me.ddlLoteria.TabIndex = 16
        '
        'txtPremMax
        '
        Me.txtPremMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPremMax.Location = New System.Drawing.Point(331, 107)
        Me.txtPremMax.Name = "txtPremMax"
        Me.txtPremMax.Size = New System.Drawing.Size(50, 20)
        Me.txtPremMax.TabIndex = 22
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnFechar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = Global.Torchwood.Presentation.My.Resources.Resources.door_in
        Me.btnFechar.Location = New System.Drawing.Point(489, 26)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(85, 24)
        Me.btnFechar.TabIndex = 59
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Dez. Sorteio:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnPesquisar
        '
        Me.btnPesquisar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPesquisar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPesquisar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesquisar.Image = Global.Torchwood.Presentation.My.Resources.Resources.pesquisar
        Me.btnPesquisar.Location = New System.Drawing.Point(398, 27)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(85, 23)
        Me.btnPesquisar.TabIndex = 58
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'txtDezFinal
        '
        Me.txtDezFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDezFinal.Location = New System.Drawing.Point(331, 81)
        Me.txtDezFinal.Name = "txtDezFinal"
        Me.txtDezFinal.Size = New System.Drawing.Size(50, 20)
        Me.txtDezFinal.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(226, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Dez. Final:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Dez. Inicial:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkAtivo
        '
        Me.chkAtivo.AutoSize = True
        Me.chkAtivo.BackColor = System.Drawing.Color.Transparent
        Me.chkAtivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkAtivo.Location = New System.Drawing.Point(387, 58)
        Me.chkAtivo.Name = "chkAtivo"
        Me.chkAtivo.Size = New System.Drawing.Size(129, 17)
        Me.chkAtivo.TabIndex = 26
        Me.chkAtivo.Text = "Esta Loteria está ativa"
        Me.chkAtivo.UseVisualStyleBackColor = False
        '
        'txtPremMin
        '
        Me.txtPremMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPremMin.Location = New System.Drawing.Point(122, 107)
        Me.txtPremMin.Name = "txtPremMin"
        Me.txtPremMin.Size = New System.Drawing.Size(50, 20)
        Me.txtPremMin.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(226, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Dez. Totais:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDezTotais
        '
        Me.txtDezTotais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDezTotais.Location = New System.Drawing.Point(331, 55)
        Me.txtDezTotais.Name = "txtDezTotais"
        Me.txtDezTotais.Size = New System.Drawing.Size(50, 20)
        Me.txtDezTotais.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Prem. Mínima:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDezInicial
        '
        Me.txtDezInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDezInicial.Location = New System.Drawing.Point(122, 81)
        Me.txtDezInicial.Name = "txtDezInicial"
        Me.txtDezInicial.Size = New System.Drawing.Size(50, 20)
        Me.txtDezInicial.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(226, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Prem. Máxima:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDezSorteio
        '
        Me.txtDezSorteio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDezSorteio.Location = New System.Drawing.Point(122, 55)
        Me.txtDezSorteio.Name = "txtDezSorteio"
        Me.txtDezSorteio.Size = New System.Drawing.Size(50, 20)
        Me.txtDezSorteio.TabIndex = 24
        '
        'FrmResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 409)
        Me.Controls.Add(Me.XpGradientPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmResultados"
        Me.Text = "Resultados de Loterias"
        Me.XpGradientPanel1.ResumeLayout(False)
        Me.XpCaptionPane1.ResumeLayout(False)
        Me.XpCaptionPane2.ResumeLayout(False)
        Me.XpCaptionPane2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XpGradientPanel1 As Steepvalley.Windows.Forms.Containers.XPGradientPanel
    Friend WithEvents txtPremMax As System.Windows.Forms.TextBox
    Friend WithEvents txtDezFinal As System.Windows.Forms.TextBox
    Friend WithEvents txtPremMin As System.Windows.Forms.TextBox
    Friend WithEvents txtDezTotais As System.Windows.Forms.TextBox
    Friend WithEvents txtDezInicial As System.Windows.Forms.TextBox
    Friend WithEvents txtDezSorteio As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkAtivo As System.Windows.Forms.CheckBox
    Friend WithEvents lvLoterias As System.Windows.Forms.ListView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ddlLoteria As System.Windows.Forms.ComboBox
    Friend WithEvents btnFechar As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents btnPesquisar As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents XpCaptionPane2 As Steepvalley.Windows.Forms.XPCaptionPane
    Friend WithEvents XpCaptionPane1 As Steepvalley.Windows.Forms.XPCaptionPane
End Class
