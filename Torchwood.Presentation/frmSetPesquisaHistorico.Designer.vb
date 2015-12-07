<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetPesquisaHistorico
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
        Dim colID As System.Windows.Forms.ColumnHeader
        Dim colDesc As System.Windows.Forms.ColumnHeader
        Dim colConcurso As System.Windows.Forms.ColumnHeader
        Dim colData1 As System.Windows.Forms.ColumnHeader
        Dim colLoteria1 As System.Windows.Forms.ColumnHeader
        Dim colDezena1 As System.Windows.Forms.ColumnHeader
        Dim ColData0 As System.Windows.Forms.ColumnHeader
        Dim colEficiencia As System.Windows.Forms.ColumnHeader
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetPesquisaHistorico))
        Me.XpGradientPanel1 = New Steepvalley.Windows.Forms.Containers.XPGradientPanel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnGravaLoteria = New Flowsight.Windows.Forms.CrystalButton()
        Me.btnFechar = New Flowsight.Windows.Forms.CrystalButton()
        Me.btnNovo = New Flowsight.Windows.Forms.CrystalButton()
        Me.btnExcluir = New Flowsight.Windows.Forms.CrystalButton()
        Me.XpCaptionPane1 = New Steepvalley.Windows.Forms.XPCaptionPane()
        Me.lvSets = New System.Windows.Forms.ListView()
        Me.colLoteria0 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDezena0 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.XpCaptionPane2 = New Steepvalley.Windows.Forms.XPCaptionPane()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd = New Flowsight.Windows.Forms.CrystalButton()
        Me.ddlLoteria = New System.Windows.Forms.ComboBox()
        Me.btnClear = New Flowsight.Windows.Forms.CrystalButton()
        Me.btnDel = New Flowsight.Windows.Forms.CrystalButton()
        Me.lstDezenas = New System.Windows.Forms.ListBox()
        Me.txtDezena = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQtdeDezenas = New System.Windows.Forms.TextBox()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.XpCaptionPane3 = New Steepvalley.Windows.Forms.XPCaptionPane()
        Me.lstDezenasSet = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lvPesquisas = New System.Windows.Forms.ListView()
        Me.XpCaptionPane4 = New Steepvalley.Windows.Forms.XPCaptionPane()
        Me.txtConcursoFinal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtConcursoInicial = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkAll = New System.Windows.Forms.CheckBox()
        Me.btnFechar2 = New Flowsight.Windows.Forms.CrystalButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPesquisar = New Flowsight.Windows.Forms.CrystalButton()
        Me.ddlSetDados = New System.Windows.Forms.ComboBox()
        colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        colDesc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        colConcurso = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        colData1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        colLoteria1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        colDezena1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        ColData0 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        colEficiencia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.XpGradientPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.XpCaptionPane1.SuspendLayout()
        Me.XpCaptionPane2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.XpCaptionPane3.SuspendLayout()
        Me.XpCaptionPane4.SuspendLayout()
        Me.SuspendLayout()
        '
        'colID
        '
        colID.Text = "ID"
        colID.Width = 40
        '
        'colDesc
        '
        colDesc.Text = "Descrição"
        colDesc.Width = 240
        '
        'colConcurso
        '
        colConcurso.Text = "Concurso"
        colConcurso.Width = 80
        '
        'colData1
        '
        colData1.Text = "Data"
        colData1.Width = 80
        '
        'colLoteria1
        '
        colLoteria1.Text = "Loteria"
        colLoteria1.Width = 100
        '
        'colDezena1
        '
        colDezena1.Text = "Qtde. Dez."
        colDezena1.Width = 80
        '
        'ColData0
        '
        ColData0.Text = "Data"
        ColData0.Width = 90
        '
        'colEficiencia
        '
        colEficiencia.Text = "% Eficiência"
        colEficiencia.Width = 80
        '
        'XpGradientPanel1
        '
        Me.XpGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.XpGradientPanel1.Controls.Add(Me.TabControl1)
        Me.XpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XpGradientPanel1.EndColor = System.Drawing.Color.LightSteelBlue
        Me.XpGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.XpGradientPanel1.Name = "XpGradientPanel1"
        Me.XpGradientPanel1.Size = New System.Drawing.Size(614, 381)
        Me.XpGradientPanel1.StartColor = System.Drawing.Color.Lavender
        Me.XpGradientPanel1.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(16, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(588, 357)
        Me.TabControl1.TabIndex = 50
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnGravaLoteria)
        Me.TabPage1.Controls.Add(Me.btnFechar)
        Me.TabPage1.Controls.Add(Me.btnNovo)
        Me.TabPage1.Controls.Add(Me.btnExcluir)
        Me.TabPage1.Controls.Add(Me.XpCaptionPane1)
        Me.TabPage1.Controls.Add(Me.XpCaptionPane2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(580, 331)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Set de Dados"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnGravaLoteria
        '
        Me.btnGravaLoteria.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnGravaLoteria.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGravaLoteria.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGravaLoteria.Image = Global.Torchwood.Presentation.My.Resources.Resources.gravar
        Me.btnGravaLoteria.Location = New System.Drawing.Point(487, 36)
        Me.btnGravaLoteria.Name = "btnGravaLoteria"
        Me.btnGravaLoteria.Size = New System.Drawing.Size(85, 24)
        Me.btnGravaLoteria.TabIndex = 64
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
        Me.btnFechar.Location = New System.Drawing.Point(487, 95)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(85, 24)
        Me.btnFechar.TabIndex = 63
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnNovo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNovo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.Image = Global.Torchwood.Presentation.My.Resources.Resources.novo
        Me.btnNovo.Location = New System.Drawing.Point(487, 6)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(85, 24)
        Me.btnNovo.TabIndex = 62
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
        Me.btnExcluir.Location = New System.Drawing.Point(487, 66)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(85, 23)
        Me.btnExcluir.TabIndex = 61
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
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
        Me.XpCaptionPane1.CaptionControl.Size = New System.Drawing.Size(562, 20)
        Me.XpCaptionPane1.CaptionControl.TabIndex = 0
        Me.XpCaptionPane1.CaptionControl.Text = "Lista de Set"
        Me.XpCaptionPane1.CaptionText = "Lista de Set"
        Me.XpCaptionPane1.Controls.Add(Me.lvSets)
        Me.XpCaptionPane1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XpCaptionPane1.Location = New System.Drawing.Point(6, 130)
        Me.XpCaptionPane1.Name = "XpCaptionPane1"
        Me.XpCaptionPane1.Padding = New System.Windows.Forms.Padding(1)
        Me.XpCaptionPane1.Size = New System.Drawing.Size(566, 195)
        Me.XpCaptionPane1.TabIndex = 49
        '
        'lvSets
        '
        Me.lvSets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvSets.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {colID, ColData0, colDesc, Me.colLoteria0, Me.colDezena0})
        Me.lvSets.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSets.FullRowSelect = True
        Me.lvSets.Location = New System.Drawing.Point(7, 27)
        Me.lvSets.Name = "lvSets"
        Me.lvSets.Size = New System.Drawing.Size(553, 162)
        Me.lvSets.TabIndex = 1
        Me.lvSets.UseCompatibleStateImageBehavior = False
        Me.lvSets.View = System.Windows.Forms.View.Details
        '
        'colLoteria0
        '
        Me.colLoteria0.Text = "Loteria"
        Me.colLoteria0.Width = 100
        '
        'colDezena0
        '
        Me.colDezena0.Text = "No. Dez."
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
        Me.XpCaptionPane2.CaptionControl.Size = New System.Drawing.Size(471, 20)
        Me.XpCaptionPane2.CaptionControl.TabIndex = 0
        Me.XpCaptionPane2.CaptionControl.Text = "Dados"
        Me.XpCaptionPane2.CaptionText = "Dados"
        Me.XpCaptionPane2.Controls.Add(Me.txtDescricao)
        Me.XpCaptionPane2.Controls.Add(Me.Label2)
        Me.XpCaptionPane2.Controls.Add(Me.btnAdd)
        Me.XpCaptionPane2.Controls.Add(Me.ddlLoteria)
        Me.XpCaptionPane2.Controls.Add(Me.btnClear)
        Me.XpCaptionPane2.Controls.Add(Me.btnDel)
        Me.XpCaptionPane2.Controls.Add(Me.lstDezenas)
        Me.XpCaptionPane2.Controls.Add(Me.txtDezena)
        Me.XpCaptionPane2.Controls.Add(Me.txtCodigo)
        Me.XpCaptionPane2.Controls.Add(Me.Label1)
        Me.XpCaptionPane2.Controls.Add(Me.Label3)
        Me.XpCaptionPane2.Controls.Add(Me.txtQtdeDezenas)
        Me.XpCaptionPane2.Controls.Add(Me.txtData)
        Me.XpCaptionPane2.Controls.Add(Me.Label5)
        Me.XpCaptionPane2.Controls.Add(Me.Label8)
        Me.XpCaptionPane2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XpCaptionPane2.Location = New System.Drawing.Point(6, 6)
        Me.XpCaptionPane2.Name = "XpCaptionPane2"
        Me.XpCaptionPane2.Padding = New System.Windows.Forms.Padding(1)
        Me.XpCaptionPane2.Size = New System.Drawing.Size(475, 118)
        Me.XpCaptionPane2.TabIndex = 49
        '
        'txtDescricao
        '
        Me.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescricao.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(110, 26)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(292, 22)
        Me.txtDescricao.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Set de Dados:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = Global.Torchwood.Presentation.My.Resources.Resources.add
        Me.btnAdd.Location = New System.Drawing.Point(146, 80)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(54, 24)
        Me.btnAdd.TabIndex = 63
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ddlLoteria
        '
        Me.ddlLoteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlLoteria.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlLoteria.FormattingEnabled = True
        Me.ddlLoteria.Location = New System.Drawing.Point(110, 54)
        Me.ddlLoteria.Name = "ddlLoteria"
        Me.ddlLoteria.Size = New System.Drawing.Size(126, 21)
        Me.ddlLoteria.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = Global.Torchwood.Presentation.My.Resources.Resources.novo
        Me.btnClear.Location = New System.Drawing.Point(266, 80)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(54, 24)
        Me.btnClear.TabIndex = 63
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Image = Global.Torchwood.Presentation.My.Resources.Resources.bin_closed
        Me.btnDel.Location = New System.Drawing.Point(206, 80)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(54, 24)
        Me.btnDel.TabIndex = 63
        Me.btnDel.Text = "Del"
        Me.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'lstDezenas
        '
        Me.lstDezenas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstDezenas.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDezenas.FormattingEnabled = True
        Me.lstDezenas.Location = New System.Drawing.Point(408, 26)
        Me.lstDezenas.Name = "lstDezenas"
        Me.lstDezenas.Size = New System.Drawing.Size(59, 80)
        Me.lstDezenas.TabIndex = 4
        '
        'txtDezena
        '
        Me.txtDezena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDezena.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDezena.Location = New System.Drawing.Point(110, 80)
        Me.txtDezena.MaxLength = 3
        Me.txtDezena.Name = "txtDezena"
        Me.txtDezena.Size = New System.Drawing.Size(30, 22)
        Me.txtDezena.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(237, 53)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(39, 22)
        Me.txtCodigo.TabIndex = 3
        Me.txtCodigo.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Loteria:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Dezena:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQtdeDezenas
        '
        Me.txtQtdeDezenas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQtdeDezenas.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdeDezenas.Location = New System.Drawing.Point(371, 81)
        Me.txtQtdeDezenas.Name = "txtQtdeDezenas"
        Me.txtQtdeDezenas.Size = New System.Drawing.Size(31, 22)
        Me.txtQtdeDezenas.TabIndex = 3
        '
        'txtData
        '
        Me.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.Location = New System.Drawing.Point(335, 52)
        Me.txtData.MaxLength = 3
        Me.txtData.Name = "txtData"
        Me.txtData.ReadOnly = True
        Me.txtData.Size = New System.Drawing.Size(67, 22)
        Me.txtData.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(260, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Data:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(326, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 15)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Qtde:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.XpCaptionPane3)
        Me.TabPage2.Controls.Add(Me.XpCaptionPane4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(580, 331)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pesquisas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'XpCaptionPane3
        '
        Me.XpCaptionPane3.BackColor = System.Drawing.Color.Lavender
        Me.XpCaptionPane3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.XpCaptionPane3.CaptionControl.Active = True
        Me.XpCaptionPane3.CaptionControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.XpCaptionPane3.CaptionControl.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XpCaptionPane3.CaptionControl.Location = New System.Drawing.Point(1, 1)
        Me.XpCaptionPane3.CaptionControl.Name = "caption"
        Me.XpCaptionPane3.CaptionControl.Size = New System.Drawing.Size(564, 20)
        Me.XpCaptionPane3.CaptionControl.TabIndex = 0
        Me.XpCaptionPane3.CaptionControl.Text = "Resultado da Pesquisa"
        Me.XpCaptionPane3.CaptionText = "Resultado da Pesquisa"
        Me.XpCaptionPane3.Controls.Add(Me.lstDezenasSet)
        Me.XpCaptionPane3.Controls.Add(Me.Label9)
        Me.XpCaptionPane3.Controls.Add(Me.lvPesquisas)
        Me.XpCaptionPane3.Location = New System.Drawing.Point(6, 103)
        Me.XpCaptionPane3.Name = "XpCaptionPane3"
        Me.XpCaptionPane3.Padding = New System.Windows.Forms.Padding(1)
        Me.XpCaptionPane3.Size = New System.Drawing.Size(568, 222)
        Me.XpCaptionPane3.TabIndex = 51
        '
        'lstDezenasSet
        '
        Me.lstDezenasSet.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDezenasSet.FormattingEnabled = True
        Me.lstDezenasSet.Location = New System.Drawing.Point(465, 53)
        Me.lstDezenasSet.Name = "lstDezenasSet"
        Me.lstDezenasSet.Size = New System.Drawing.Size(97, 160)
        Me.lstDezenasSet.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(462, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 15)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Dezenas:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lvPesquisas
        '
        Me.lvPesquisas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {colConcurso, colData1, colLoteria1, colDezena1, colEficiencia})
        Me.lvPesquisas.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPesquisas.FullRowSelect = True
        Me.lvPesquisas.Location = New System.Drawing.Point(7, 27)
        Me.lvPesquisas.Name = "lvPesquisas"
        Me.lvPesquisas.Size = New System.Drawing.Size(452, 189)
        Me.lvPesquisas.TabIndex = 1
        Me.lvPesquisas.UseCompatibleStateImageBehavior = False
        Me.lvPesquisas.View = System.Windows.Forms.View.Details
        '
        'XpCaptionPane4
        '
        Me.XpCaptionPane4.BackColor = System.Drawing.Color.Lavender
        Me.XpCaptionPane4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.XpCaptionPane4.CaptionControl.Active = True
        Me.XpCaptionPane4.CaptionControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.XpCaptionPane4.CaptionControl.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XpCaptionPane4.CaptionControl.Location = New System.Drawing.Point(1, 1)
        Me.XpCaptionPane4.CaptionControl.Name = "caption"
        Me.XpCaptionPane4.CaptionControl.Size = New System.Drawing.Size(564, 20)
        Me.XpCaptionPane4.CaptionControl.TabIndex = 0
        Me.XpCaptionPane4.CaptionControl.Text = "Pesquisa por Set"
        Me.XpCaptionPane4.CaptionText = "Pesquisa por Set"
        Me.XpCaptionPane4.Controls.Add(Me.txtConcursoFinal)
        Me.XpCaptionPane4.Controls.Add(Me.Label7)
        Me.XpCaptionPane4.Controls.Add(Me.txtConcursoInicial)
        Me.XpCaptionPane4.Controls.Add(Me.Label6)
        Me.XpCaptionPane4.Controls.Add(Me.chkAll)
        Me.XpCaptionPane4.Controls.Add(Me.btnFechar2)
        Me.XpCaptionPane4.Controls.Add(Me.Label4)
        Me.XpCaptionPane4.Controls.Add(Me.btnPesquisar)
        Me.XpCaptionPane4.Controls.Add(Me.ddlSetDados)
        Me.XpCaptionPane4.Location = New System.Drawing.Point(6, 6)
        Me.XpCaptionPane4.Name = "XpCaptionPane4"
        Me.XpCaptionPane4.Padding = New System.Windows.Forms.Padding(1)
        Me.XpCaptionPane4.Size = New System.Drawing.Size(568, 91)
        Me.XpCaptionPane4.TabIndex = 50
        '
        'txtConcursoFinal
        '
        Me.txtConcursoFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConcursoFinal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcursoFinal.Location = New System.Drawing.Point(322, 53)
        Me.txtConcursoFinal.MaxLength = 3
        Me.txtConcursoFinal.Name = "txtConcursoFinal"
        Me.txtConcursoFinal.Size = New System.Drawing.Size(58, 22)
        Me.txtConcursoFinal.TabIndex = 69
        Me.txtConcursoFinal.Text = "0"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(216, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 15)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Concurso Final:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtConcursoInicial
        '
        Me.txtConcursoInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConcursoInicial.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcursoInicial.Location = New System.Drawing.Point(110, 53)
        Me.txtConcursoInicial.MaxLength = 3
        Me.txtConcursoInicial.Name = "txtConcursoInicial"
        Me.txtConcursoInicial.Size = New System.Drawing.Size(58, 22)
        Me.txtConcursoInicial.TabIndex = 69
        Me.txtConcursoInicial.Text = "0"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 15)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Concurso Inicial:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkAll.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAll.Location = New System.Drawing.Point(386, 56)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(123, 17)
        Me.chkAll.TabIndex = 67
        Me.chkAll.Text = "Todas Ocorrências?"
        Me.chkAll.UseVisualStyleBackColor = True
        '
        'btnFechar2
        '
        Me.btnFechar2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnFechar2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFechar2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar2.Image = Global.Torchwood.Presentation.My.Resources.Resources.door_in
        Me.btnFechar2.Location = New System.Drawing.Point(477, 26)
        Me.btnFechar2.Name = "btnFechar2"
        Me.btnFechar2.Size = New System.Drawing.Size(85, 24)
        Me.btnFechar2.TabIndex = 65
        Me.btnFechar2.Text = "Fechar"
        Me.btnFechar2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechar2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Set de Dados:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnPesquisar
        '
        Me.btnPesquisar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPesquisar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPesquisar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesquisar.Image = Global.Torchwood.Presentation.My.Resources.Resources.pesquisar
        Me.btnPesquisar.Location = New System.Drawing.Point(386, 26)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(85, 24)
        Me.btnPesquisar.TabIndex = 64
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ddlSetDados
        '
        Me.ddlSetDados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlSetDados.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlSetDados.FormattingEnabled = True
        Me.ddlSetDados.Location = New System.Drawing.Point(110, 26)
        Me.ddlSetDados.Name = "ddlSetDados"
        Me.ddlSetDados.Size = New System.Drawing.Size(270, 21)
        Me.ddlSetDados.TabIndex = 2
        '
        'frmSetPesquisaHistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 381)
        Me.Controls.Add(Me.XpGradientPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSetPesquisaHistorico"
        Me.Text = "Set de Pesquisas Historicas"
        Me.XpGradientPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.XpCaptionPane1.ResumeLayout(False)
        Me.XpCaptionPane2.ResumeLayout(False)
        Me.XpCaptionPane2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.XpCaptionPane3.ResumeLayout(False)
        Me.XpCaptionPane4.ResumeLayout(False)
        Me.XpCaptionPane4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XpGradientPanel1 As Steepvalley.Windows.Forms.Containers.XPGradientPanel
    Friend WithEvents XpCaptionPane2 As Steepvalley.Windows.Forms.XPCaptionPane
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents XpCaptionPane1 As Steepvalley.Windows.Forms.XPCaptionPane
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ddlLoteria As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDezena As System.Windows.Forms.TextBox
    Friend WithEvents lstDezenas As System.Windows.Forms.ListBox
    Friend WithEvents lvSets As System.Windows.Forms.ListView
    Friend WithEvents colLoteria0 As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDezena0 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnGravaLoteria As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents btnFechar As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents btnNovo As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents btnExcluir As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents btnClear As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents btnDel As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents btnAdd As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents XpCaptionPane3 As Steepvalley.Windows.Forms.XPCaptionPane
    Friend WithEvents lvPesquisas As System.Windows.Forms.ListView
    Friend WithEvents XpCaptionPane4 As Steepvalley.Windows.Forms.XPCaptionPane
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ddlSetDados As System.Windows.Forms.ComboBox
    Friend WithEvents btnFechar2 As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents btnPesquisar As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents txtData As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtConcursoFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtConcursoInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkAll As System.Windows.Forms.CheckBox
    Friend WithEvents txtQtdeDezenas As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lstDezenasSet As System.Windows.Forms.ListBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
