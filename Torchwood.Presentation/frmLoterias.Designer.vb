<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoterias
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
        Dim colLoteria As System.Windows.Forms.ColumnHeader
        Dim colDezInicial As System.Windows.Forms.ColumnHeader
        Dim colDezFinal As System.Windows.Forms.ColumnHeader
        Dim colQtMinOccurs As System.Windows.Forms.ColumnHeader
        Dim colQtMaxOccurs As System.Windows.Forms.ColumnHeader
        Dim colTotal As System.Windows.Forms.ColumnHeader
        Dim colStatus As System.Windows.Forms.ColumnHeader
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoterias))
        Me.XpGradientPanel1 = New Steepvalley.Windows.Forms.Containers.XPGradientPanel()
        Me.XpCaptionPane1 = New Steepvalley.Windows.Forms.XPCaptionPane()
        Me.lvLoterias = New System.Windows.Forms.ListView()
        Me.colCodigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.XpCaptionPane2 = New Steepvalley.Windows.Forms.XPCaptionPane()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkAtivo = New System.Windows.Forms.CheckBox()
        Me.btnAltStatus = New Flowsight.Windows.Forms.CrystalButton()
        Me.txtDezSorteio = New System.Windows.Forms.TextBox()
        Me.ddlLoteria = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPremMax = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDezFinal = New System.Windows.Forms.TextBox()
        Me.txtDezInicial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPremMin = New System.Windows.Forms.TextBox()
        Me.txtDezTotais = New System.Windows.Forms.TextBox()
        Me.btnGravaLoteria = New Flowsight.Windows.Forms.CrystalButton()
        Me.btnFechar = New Flowsight.Windows.Forms.CrystalButton()
        Me.btnNovo = New Flowsight.Windows.Forms.CrystalButton()
        Me.btnExcluir = New Flowsight.Windows.Forms.CrystalButton()
        colLoteria = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        colDezInicial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        colDezFinal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        colQtMinOccurs = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        colQtMaxOccurs = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        colTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        colStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.XpGradientPanel1.SuspendLayout()
        Me.XpCaptionPane1.SuspendLayout()
        Me.XpCaptionPane2.SuspendLayout()
        Me.SuspendLayout()
        '
        'colLoteria
        '
        colLoteria.Text = "Loteria"
        colLoteria.Width = 140
        '
        'colDezInicial
        '
        colDezInicial.Text = "Dez. Ini."
        colDezInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'colDezFinal
        '
        colDezFinal.Text = "Dez. Fim"
        colDezFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'colQtMinOccurs
        '
        colQtMinOccurs.Text = "Prem. Mín."
        colQtMinOccurs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        colQtMinOccurs.Width = 70
        '
        'colQtMaxOccurs
        '
        colQtMaxOccurs.Text = "Prem. Máx"
        colQtMaxOccurs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        colQtMaxOccurs.Width = 70
        '
        'colTotal
        '
        colTotal.Text = "Ttl Dez."
        colTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'colStatus
        '
        colStatus.Text = "Status"
        colStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'XpGradientPanel1
        '
        Me.XpGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.XpGradientPanel1.Controls.Add(Me.XpCaptionPane1)
        Me.XpGradientPanel1.Controls.Add(Me.XpCaptionPane2)
        Me.XpGradientPanel1.Controls.Add(Me.btnGravaLoteria)
        Me.XpGradientPanel1.Controls.Add(Me.btnFechar)
        Me.XpGradientPanel1.Controls.Add(Me.btnNovo)
        Me.XpGradientPanel1.Controls.Add(Me.btnExcluir)
        Me.XpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XpGradientPanel1.EndColor = System.Drawing.Color.LightSteelBlue
        Me.XpGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.XpGradientPanel1.Name = "XpGradientPanel1"
        Me.XpGradientPanel1.Size = New System.Drawing.Size(618, 454)
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
        Me.XpCaptionPane1.CaptionControl.Size = New System.Drawing.Size(590, 20)
        Me.XpCaptionPane1.CaptionControl.TabIndex = 0
        Me.XpCaptionPane1.CaptionControl.Text = "Loteria"
        Me.XpCaptionPane1.CaptionText = "Loteria"
        Me.XpCaptionPane1.Controls.Add(Me.lvLoterias)
        Me.XpCaptionPane1.Location = New System.Drawing.Point(12, 171)
        Me.XpCaptionPane1.Name = "XpCaptionPane1"
        Me.XpCaptionPane1.Padding = New System.Windows.Forms.Padding(1)
        Me.XpCaptionPane1.Size = New System.Drawing.Size(594, 271)
        Me.XpCaptionPane1.TabIndex = 62
        '
        'lvLoterias
        '
        Me.lvLoterias.BackColor = System.Drawing.SystemColors.Info
        Me.lvLoterias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvLoterias.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colCodigo, colLoteria, colDezInicial, colDezFinal, colQtMinOccurs, colQtMaxOccurs, colTotal, colStatus})
        Me.lvLoterias.FullRowSelect = True
        Me.lvLoterias.Location = New System.Drawing.Point(6, 25)
        Me.lvLoterias.Name = "lvLoterias"
        Me.lvLoterias.Size = New System.Drawing.Size(581, 237)
        Me.lvLoterias.TabIndex = 46
        Me.lvLoterias.UseCompatibleStateImageBehavior = False
        Me.lvLoterias.View = System.Windows.Forms.View.Details
        '
        'colCodigo
        '
        Me.colCodigo.Text = "Cód"
        Me.colCodigo.Width = 40
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
        Me.XpCaptionPane2.CaptionControl.Size = New System.Drawing.Size(489, 20)
        Me.XpCaptionPane2.CaptionControl.TabIndex = 0
        Me.XpCaptionPane2.CaptionControl.Text = "Loteria"
        Me.XpCaptionPane2.CaptionText = "Loteria"
        Me.XpCaptionPane2.Controls.Add(Me.Label1)
        Me.XpCaptionPane2.Controls.Add(Me.Label5)
        Me.XpCaptionPane2.Controls.Add(Me.Label7)
        Me.XpCaptionPane2.Controls.Add(Me.chkAtivo)
        Me.XpCaptionPane2.Controls.Add(Me.btnAltStatus)
        Me.XpCaptionPane2.Controls.Add(Me.txtDezSorteio)
        Me.XpCaptionPane2.Controls.Add(Me.ddlLoteria)
        Me.XpCaptionPane2.Controls.Add(Me.Label6)
        Me.XpCaptionPane2.Controls.Add(Me.txtPremMax)
        Me.XpCaptionPane2.Controls.Add(Me.Label3)
        Me.XpCaptionPane2.Controls.Add(Me.txtDezFinal)
        Me.XpCaptionPane2.Controls.Add(Me.txtDezInicial)
        Me.XpCaptionPane2.Controls.Add(Me.Label2)
        Me.XpCaptionPane2.Controls.Add(Me.Label4)
        Me.XpCaptionPane2.Controls.Add(Me.txtPremMin)
        Me.XpCaptionPane2.Controls.Add(Me.txtDezTotais)
        Me.XpCaptionPane2.Location = New System.Drawing.Point(12, 12)
        Me.XpCaptionPane2.Name = "XpCaptionPane2"
        Me.XpCaptionPane2.Padding = New System.Windows.Forms.Padding(1)
        Me.XpCaptionPane2.Size = New System.Drawing.Size(493, 153)
        Me.XpCaptionPane2.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Loteria:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(188, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Dez. Final:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(188, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Prem. Máxima:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkAtivo
        '
        Me.chkAtivo.AutoSize = True
        Me.chkAtivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkAtivo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAtivo.Location = New System.Drawing.Point(356, 114)
        Me.chkAtivo.Name = "chkAtivo"
        Me.chkAtivo.Size = New System.Drawing.Size(90, 19)
        Me.chkAtivo.TabIndex = 53
        Me.chkAtivo.Text = "Loteria Ativa"
        Me.chkAtivo.UseVisualStyleBackColor = True
        '
        'btnAltStatus
        '
        Me.btnAltStatus.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAltStatus.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAltStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltStatus.Image = Global.Torchwood.Presentation.My.Resources.Resources.arrow_refresh
        Me.btnAltStatus.Location = New System.Drawing.Point(356, 84)
        Me.btnAltStatus.Name = "btnAltStatus"
        Me.btnAltStatus.Size = New System.Drawing.Size(85, 23)
        Me.btnAltStatus.TabIndex = 42
        Me.btnAltStatus.Text = "Status"
        Me.btnAltStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAltStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'txtDezSorteio
        '
        Me.txtDezSorteio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDezSorteio.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDezSorteio.Location = New System.Drawing.Point(123, 56)
        Me.txtDezSorteio.Name = "txtDezSorteio"
        Me.txtDezSorteio.ReadOnly = True
        Me.txtDezSorteio.Size = New System.Drawing.Size(50, 23)
        Me.txtDezSorteio.TabIndex = 50
        '
        'ddlLoteria
        '
        Me.ddlLoteria.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ddlLoteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlLoteria.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlLoteria.FormattingEnabled = True
        Me.ddlLoteria.Location = New System.Drawing.Point(123, 27)
        Me.ddlLoteria.Name = "ddlLoteria"
        Me.ddlLoteria.Size = New System.Drawing.Size(220, 23)
        Me.ddlLoteria.Sorted = True
        Me.ddlLoteria.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Prem. Mínima:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPremMax
        '
        Me.txtPremMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPremMax.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPremMax.Location = New System.Drawing.Point(293, 114)
        Me.txtPremMax.Name = "txtPremMax"
        Me.txtPremMax.ReadOnly = True
        Me.txtPremMax.Size = New System.Drawing.Size(50, 23)
        Me.txtPremMax.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(188, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Dez. Totais:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDezFinal
        '
        Me.txtDezFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDezFinal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDezFinal.Location = New System.Drawing.Point(293, 85)
        Me.txtDezFinal.Name = "txtDezFinal"
        Me.txtDezFinal.ReadOnly = True
        Me.txtDezFinal.Size = New System.Drawing.Size(50, 23)
        Me.txtDezFinal.TabIndex = 47
        '
        'txtDezInicial
        '
        Me.txtDezInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDezInicial.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDezInicial.Location = New System.Drawing.Point(123, 85)
        Me.txtDezInicial.Name = "txtDezInicial"
        Me.txtDezInicial.ReadOnly = True
        Me.txtDezInicial.Size = New System.Drawing.Size(50, 23)
        Me.txtDezInicial.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Dez. Sorteio:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Dez. Inicial:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPremMin
        '
        Me.txtPremMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPremMin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPremMin.Location = New System.Drawing.Point(123, 114)
        Me.txtPremMin.Name = "txtPremMin"
        Me.txtPremMin.ReadOnly = True
        Me.txtPremMin.Size = New System.Drawing.Size(50, 23)
        Me.txtPremMin.TabIndex = 51
        '
        'txtDezTotais
        '
        Me.txtDezTotais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDezTotais.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDezTotais.Location = New System.Drawing.Point(293, 56)
        Me.txtDezTotais.Name = "txtDezTotais"
        Me.txtDezTotais.ReadOnly = True
        Me.txtDezTotais.Size = New System.Drawing.Size(50, 23)
        Me.txtDezTotais.TabIndex = 52
        '
        'btnGravaLoteria
        '
        Me.btnGravaLoteria.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnGravaLoteria.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGravaLoteria.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGravaLoteria.Image = Global.Torchwood.Presentation.My.Resources.Resources.gravar
        Me.btnGravaLoteria.Location = New System.Drawing.Point(515, 42)
        Me.btnGravaLoteria.Name = "btnGravaLoteria"
        Me.btnGravaLoteria.Size = New System.Drawing.Size(85, 24)
        Me.btnGravaLoteria.TabIndex = 60
        Me.btnGravaLoteria.Text = "Gravar"
        Me.btnGravaLoteria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGravaLoteria.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnFechar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = Global.Torchwood.Presentation.My.Resources.Resources.door_in
        Me.btnFechar.Location = New System.Drawing.Point(515, 101)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(85, 24)
        Me.btnFechar.TabIndex = 59
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnNovo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNovo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.Image = Global.Torchwood.Presentation.My.Resources.Resources.novo
        Me.btnNovo.Location = New System.Drawing.Point(515, 12)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(85, 24)
        Me.btnNovo.TabIndex = 58
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnExcluir.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnExcluir.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Image = Global.Torchwood.Presentation.My.Resources.Resources.cross
        Me.btnExcluir.Location = New System.Drawing.Point(515, 72)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(85, 23)
        Me.btnExcluir.TabIndex = 44
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'frmLoterias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 454)
        Me.Controls.Add(Me.XpGradientPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLoterias"
        Me.Text = "Cadastro de Loterias"
        Me.XpGradientPanel1.ResumeLayout(False)
        Me.XpCaptionPane1.ResumeLayout(False)
        Me.XpCaptionPane2.ResumeLayout(False)
        Me.XpCaptionPane2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XpGradientPanel1 As Steepvalley.Windows.Forms.Containers.XPGradientPanel
    Friend WithEvents chkAtivo As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ddlLoteria As System.Windows.Forms.ComboBox
    Friend WithEvents txtPremMax As System.Windows.Forms.TextBox
    Friend WithEvents txtDezFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPremMin As System.Windows.Forms.TextBox
    Friend WithEvents txtDezTotais As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDezInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDezSorteio As System.Windows.Forms.TextBox
    Friend WithEvents btnExcluir As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents btnAltStatus As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lvLoterias As System.Windows.Forms.ListView
    Friend WithEvents colCodigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnGravaLoteria As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents btnFechar As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents btnNovo As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents XpCaptionPane2 As Steepvalley.Windows.Forms.XPCaptionPane
    Friend WithEvents XpCaptionPane1 As Steepvalley.Windows.Forms.XPCaptionPane

End Class
