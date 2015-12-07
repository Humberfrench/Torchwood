<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadResultados
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadResultados))
        Me.XpGradientPanel1 = New Steepvalley.Windows.Forms.Containers.XPGradientPanel()
        Me.XpCaptionPane1 = New Steepvalley.Windows.Forms.XPCaptionPane()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtConcurso = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDataConcurso = New System.Windows.Forms.DateTimePicker()
        Me.txtDezenas = New System.Windows.Forms.TextBox()
        Me.lvDezenas = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDezena = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ddlTime = New System.Windows.Forms.ComboBox()
        Me.btnAddDezenas = New Flowsight.Windows.Forms.CrystalButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.XpCaptionPane2 = New Steepvalley.Windows.Forms.XPCaptionPane()
        Me.ddlLoterias = New System.Windows.Forms.ComboBox()
        Me.txtDezSorteio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPremMax = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDezFinal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPremMin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDezTotais = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDezInicial = New System.Windows.Forms.TextBox()
        Me.btnGravaLoteria = New Flowsight.Windows.Forms.CrystalButton()
        Me.btnFechar = New Flowsight.Windows.Forms.CrystalButton()
        Me.chkAtivo = New System.Windows.Forms.CheckBox()
        Me.btnNovo = New Flowsight.Windows.Forms.CrystalButton()
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
        Me.XpGradientPanel1.Controls.Add(Me.btnGravaLoteria)
        Me.XpGradientPanel1.Controls.Add(Me.btnFechar)
        Me.XpGradientPanel1.Controls.Add(Me.chkAtivo)
        Me.XpGradientPanel1.Controls.Add(Me.btnNovo)
        Me.XpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XpGradientPanel1.EndColor = System.Drawing.Color.LightSteelBlue
        Me.XpGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.XpGradientPanel1.Name = "XpGradientPanel1"
        Me.XpGradientPanel1.Size = New System.Drawing.Size(465, 351)
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
        Me.XpCaptionPane1.CaptionControl.Size = New System.Drawing.Size(436, 20)
        Me.XpCaptionPane1.CaptionControl.TabIndex = 0
        Me.XpCaptionPane1.CaptionControl.Text = "Dados"
        Me.XpCaptionPane1.CaptionText = "Dados"
        Me.XpCaptionPane1.Controls.Add(Me.Label2)
        Me.XpCaptionPane1.Controls.Add(Me.txtConcurso)
        Me.XpCaptionPane1.Controls.Add(Me.Label3)
        Me.XpCaptionPane1.Controls.Add(Me.dtpDataConcurso)
        Me.XpCaptionPane1.Controls.Add(Me.txtDezenas)
        Me.XpCaptionPane1.Controls.Add(Me.lvDezenas)
        Me.XpCaptionPane1.Controls.Add(Me.Label1)
        Me.XpCaptionPane1.Controls.Add(Me.ddlTime)
        Me.XpCaptionPane1.Controls.Add(Me.btnAddDezenas)
        Me.XpCaptionPane1.Controls.Add(Me.Label5)
        Me.XpCaptionPane1.Location = New System.Drawing.Point(12, 165)
        Me.XpCaptionPane1.Name = "XpCaptionPane1"
        Me.XpCaptionPane1.Padding = New System.Windows.Forms.Padding(1)
        Me.XpCaptionPane1.Size = New System.Drawing.Size(440, 164)
        Me.XpCaptionPane1.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 22)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Número do Concurso:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtConcurso
        '
        Me.txtConcurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConcurso.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcurso.Location = New System.Drawing.Point(144, 27)
        Me.txtConcurso.Name = "txtConcurso"
        Me.txtConcurso.Size = New System.Drawing.Size(69, 23)
        Me.txtConcurso.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 22)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Data do Concurso:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpDataConcurso
        '
        Me.dtpDataConcurso.CustomFormat = "dd/MM/yyyy"
        Me.dtpDataConcurso.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataConcurso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataConcurso.Location = New System.Drawing.Point(144, 56)
        Me.dtpDataConcurso.Name = "dtpDataConcurso"
        Me.dtpDataConcurso.Size = New System.Drawing.Size(113, 23)
        Me.dtpDataConcurso.TabIndex = 40
        '
        'txtDezenas
        '
        Me.txtDezenas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDezenas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDezenas.Location = New System.Drawing.Point(144, 85)
        Me.txtDezenas.Name = "txtDezenas"
        Me.txtDezenas.Size = New System.Drawing.Size(69, 23)
        Me.txtDezenas.TabIndex = 36
        '
        'lvDezenas
        '
        Me.lvDezenas.BackColor = System.Drawing.SystemColors.Info
        Me.lvDezenas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvDezenas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colDezena})
        Me.lvDezenas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDezenas.Location = New System.Drawing.Point(274, 27)
        Me.lvDezenas.Name = "lvDezenas"
        Me.lvDezenas.Size = New System.Drawing.Size(113, 81)
        Me.lvDezenas.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvDezenas.TabIndex = 41
        Me.lvDezenas.UseCompatibleStateImageBehavior = False
        Me.lvDezenas.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 30
        '
        'colDezena
        '
        Me.colDezena.Text = "Dezena"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 22)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Dezenas:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ddlTime
        '
        Me.ddlTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlTime.Enabled = False
        Me.ddlTime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlTime.FormattingEnabled = True
        Me.ddlTime.Location = New System.Drawing.Point(144, 114)
        Me.ddlTime.Name = "ddlTime"
        Me.ddlTime.Size = New System.Drawing.Size(243, 23)
        Me.ddlTime.TabIndex = 38
        '
        'btnAddDezenas
        '
        Me.btnAddDezenas.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAddDezenas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddDezenas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddDezenas.Image = Global.Torchwood.Presentation.My.Resources.Resources.add
        Me.btnAddDezenas.Location = New System.Drawing.Point(219, 84)
        Me.btnAddDezenas.Name = "btnAddDezenas"
        Me.btnAddDezenas.Size = New System.Drawing.Size(35, 24)
        Me.btnAddDezenas.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 22)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Time Sorteado:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.XpCaptionPane2.CaptionControl.Size = New System.Drawing.Size(335, 20)
        Me.XpCaptionPane2.CaptionControl.TabIndex = 0
        Me.XpCaptionPane2.CaptionControl.Text = "Loteria"
        Me.XpCaptionPane2.CaptionText = "Loteria"
        Me.XpCaptionPane2.Controls.Add(Me.ddlLoterias)
        Me.XpCaptionPane2.Controls.Add(Me.txtDezSorteio)
        Me.XpCaptionPane2.Controls.Add(Me.Label11)
        Me.XpCaptionPane2.Controls.Add(Me.Label10)
        Me.XpCaptionPane2.Controls.Add(Me.txtPremMax)
        Me.XpCaptionPane2.Controls.Add(Me.Label9)
        Me.XpCaptionPane2.Controls.Add(Me.txtDezFinal)
        Me.XpCaptionPane2.Controls.Add(Me.Label8)
        Me.XpCaptionPane2.Controls.Add(Me.txtPremMin)
        Me.XpCaptionPane2.Controls.Add(Me.Label6)
        Me.XpCaptionPane2.Controls.Add(Me.txtDezTotais)
        Me.XpCaptionPane2.Controls.Add(Me.Label7)
        Me.XpCaptionPane2.Controls.Add(Me.txtDezInicial)
        Me.XpCaptionPane2.Location = New System.Drawing.Point(12, 12)
        Me.XpCaptionPane2.Name = "XpCaptionPane2"
        Me.XpCaptionPane2.Padding = New System.Windows.Forms.Padding(1)
        Me.XpCaptionPane2.Size = New System.Drawing.Size(339, 147)
        Me.XpCaptionPane2.TabIndex = 58
        '
        'ddlLoterias
        '
        Me.ddlLoterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlLoterias.FormattingEnabled = True
        Me.ddlLoterias.Location = New System.Drawing.Point(5, 27)
        Me.ddlLoterias.Name = "ddlLoterias"
        Me.ddlLoterias.Size = New System.Drawing.Size(328, 21)
        Me.ddlLoterias.TabIndex = 1
        '
        'txtDezSorteio
        '
        Me.txtDezSorteio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDezSorteio.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDezSorteio.Location = New System.Drawing.Point(113, 54)
        Me.txtDezSorteio.Name = "txtDezSorteio"
        Me.txtDezSorteio.ReadOnly = True
        Me.txtDezSorteio.Size = New System.Drawing.Size(50, 23)
        Me.txtDezSorteio.TabIndex = 49
        '
        'Label11
        '
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 13)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Dez. Sorteio:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Dez. Inicial:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPremMax
        '
        Me.txtPremMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPremMax.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPremMax.Location = New System.Drawing.Point(274, 112)
        Me.txtPremMax.Name = "txtPremMax"
        Me.txtPremMax.ReadOnly = True
        Me.txtPremMax.Size = New System.Drawing.Size(50, 23)
        Me.txtPremMax.TabIndex = 51
        '
        'Label9
        '
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(169, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Dez. Totais:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDezFinal
        '
        Me.txtDezFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDezFinal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDezFinal.Location = New System.Drawing.Point(274, 83)
        Me.txtDezFinal.Name = "txtDezFinal"
        Me.txtDezFinal.ReadOnly = True
        Me.txtDezFinal.Size = New System.Drawing.Size(50, 23)
        Me.txtDezFinal.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Prem. Mínima:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPremMin
        '
        Me.txtPremMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPremMin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPremMin.Location = New System.Drawing.Point(113, 112)
        Me.txtPremMin.Name = "txtPremMin"
        Me.txtPremMin.ReadOnly = True
        Me.txtPremMin.Size = New System.Drawing.Size(50, 23)
        Me.txtPremMin.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(169, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Dez. Final:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDezTotais
        '
        Me.txtDezTotais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDezTotais.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDezTotais.Location = New System.Drawing.Point(274, 54)
        Me.txtDezTotais.Name = "txtDezTotais"
        Me.txtDezTotais.ReadOnly = True
        Me.txtDezTotais.Size = New System.Drawing.Size(50, 23)
        Me.txtDezTotais.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(169, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Prem. Máxima:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDezInicial
        '
        Me.txtDezInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDezInicial.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDezInicial.Location = New System.Drawing.Point(113, 83)
        Me.txtDezInicial.Name = "txtDezInicial"
        Me.txtDezInicial.ReadOnly = True
        Me.txtDezInicial.Size = New System.Drawing.Size(50, 23)
        Me.txtDezInicial.TabIndex = 53
        '
        'btnGravaLoteria
        '
        Me.btnGravaLoteria.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnGravaLoteria.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGravaLoteria.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGravaLoteria.Image = Global.Torchwood.Presentation.My.Resources.Resources.gravar
        Me.btnGravaLoteria.Location = New System.Drawing.Point(367, 39)
        Me.btnGravaLoteria.Name = "btnGravaLoteria"
        Me.btnGravaLoteria.Size = New System.Drawing.Size(85, 24)
        Me.btnGravaLoteria.TabIndex = 57
        Me.btnGravaLoteria.Text = "Gravar"
        Me.btnGravaLoteria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGravaLoteria.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnFechar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = Global.Torchwood.Presentation.My.Resources.Resources.door_in
        Me.btnFechar.Location = New System.Drawing.Point(367, 69)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(85, 24)
        Me.btnFechar.TabIndex = 56
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'chkAtivo
        '
        Me.chkAtivo.AutoSize = True
        Me.chkAtivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkAtivo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAtivo.Location = New System.Drawing.Point(361, 100)
        Me.chkAtivo.Name = "chkAtivo"
        Me.chkAtivo.Size = New System.Drawing.Size(90, 19)
        Me.chkAtivo.TabIndex = 55
        Me.chkAtivo.Text = "Loteria Ativa"
        Me.chkAtivo.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnNovo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNovo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.Image = Global.Torchwood.Presentation.My.Resources.Resources.novo
        Me.btnNovo.Location = New System.Drawing.Point(367, 9)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(85, 24)
        Me.btnNovo.TabIndex = 39
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'frmCadResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 351)
        Me.Controls.Add(Me.XpGradientPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadResultados"
        Me.Text = "Gravação dos Concursos"
        Me.XpGradientPanel1.ResumeLayout(False)
        Me.XpGradientPanel1.PerformLayout()
        Me.XpCaptionPane1.ResumeLayout(False)
        Me.XpCaptionPane1.PerformLayout()
        Me.XpCaptionPane2.ResumeLayout(False)
        Me.XpCaptionPane2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XpGradientPanel1 As Steepvalley.Windows.Forms.Containers.XPGradientPanel
    Friend WithEvents chkAtivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtPremMax As System.Windows.Forms.TextBox
    Friend WithEvents txtDezFinal As System.Windows.Forms.TextBox
    Friend WithEvents txtPremMin As System.Windows.Forms.TextBox
    Friend WithEvents txtDezTotais As System.Windows.Forms.TextBox
    Friend WithEvents txtDezInicial As System.Windows.Forms.TextBox
    Friend WithEvents txtDezSorteio As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnAddDezenas As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents lvDezenas As System.Windows.Forms.ListView
    Friend WithEvents colID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDezena As System.Windows.Forms.ColumnHeader
    Friend WithEvents dtpDataConcurso As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnNovo As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents ddlTime As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDezenas As System.Windows.Forms.TextBox
    Friend WithEvents txtConcurso As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGravaLoteria As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents btnFechar As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents XpCaptionPane2 As Steepvalley.Windows.Forms.XPCaptionPane
    Friend WithEvents ddlLoterias As System.Windows.Forms.ComboBox
    Friend WithEvents XpCaptionPane1 As Steepvalley.Windows.Forms.XPCaptionPane
End Class
