<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCockPit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCockPit))
        Me.XpGradientPanel1 = New Steepvalley.Windows.Forms.Containers.XPGradientPanel()
        Me.btnFechar = New Flowsight.Windows.Forms.CrystalButton()
        Me.btnPesquisar = New Flowsight.Windows.Forms.CrystalButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grdStats = New SourceGrid.Grid()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grdOccurs = New SourceGrid.Grid()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ddlLoteria = New System.Windows.Forms.ComboBox()
        Me.txtFaixas = New System.Windows.Forms.TextBox()
        Me.XpGradientPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'XpGradientPanel1
        '
        Me.XpGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.XpGradientPanel1.Controls.Add(Me.btnFechar)
        Me.XpGradientPanel1.Controls.Add(Me.btnPesquisar)
        Me.XpGradientPanel1.Controls.Add(Me.TabControl1)
        Me.XpGradientPanel1.Controls.Add(Me.Label1)
        Me.XpGradientPanel1.Controls.Add(Me.Label2)
        Me.XpGradientPanel1.Controls.Add(Me.ddlLoteria)
        Me.XpGradientPanel1.Controls.Add(Me.txtFaixas)
        Me.XpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XpGradientPanel1.EndColor = System.Drawing.Color.LightSteelBlue
        Me.XpGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.XpGradientPanel1.Name = "XpGradientPanel1"
        Me.XpGradientPanel1.Size = New System.Drawing.Size(734, 627)
        Me.XpGradientPanel1.StartColor = System.Drawing.Color.Lavender
        Me.XpGradientPanel1.TabIndex = 2
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnFechar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = Global.Torchwood.Presentation.My.Resources.Resources.door_in
        Me.btnFechar.Location = New System.Drawing.Point(637, 11)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(85, 24)
        Me.btnFechar.TabIndex = 61
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnPesquisar
        '
        Me.btnPesquisar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPesquisar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPesquisar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesquisar.Image = Global.Torchwood.Presentation.My.Resources.Resources.pesquisar
        Me.btnPesquisar.Location = New System.Drawing.Point(546, 11)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(85, 23)
        Me.btnPesquisar.TabIndex = 60
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(15, 41)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(707, 579)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.grdStats)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(699, 553)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Estudo Estatístico Detalhado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'grdStats
        '
        Me.grdStats.AutoStretchColumnsToFitWidth = False
        Me.grdStats.AutoStretchRowsToFitHeight = False
        Me.grdStats.BackColor = System.Drawing.SystemColors.Info
        Me.grdStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grdStats.CustomSort = False
        Me.grdStats.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdStats.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grdStats.Location = New System.Drawing.Point(11, 15)
        Me.grdStats.Name = "grdStats"
        Me.grdStats.Size = New System.Drawing.Size(682, 525)
        Me.grdStats.TabIndex = 8
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grdOccurs)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(699, 553)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Estudo de Ocorrencia Por Concursos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'grdOccurs
        '
        Me.grdOccurs.AutoStretchColumnsToFitWidth = False
        Me.grdOccurs.AutoStretchRowsToFitHeight = False
        Me.grdOccurs.BackColor = System.Drawing.SystemColors.Info
        Me.grdOccurs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grdOccurs.CustomSort = False
        Me.grdOccurs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdOccurs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grdOccurs.Location = New System.Drawing.Point(10, 15)
        Me.grdOccurs.Name = "grdOccurs"
        Me.grdOccurs.Size = New System.Drawing.Size(683, 525)
        Me.grdOccurs.TabIndex = 9
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(699, 553)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Outros"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.TabPage4.Controls.Add(Me.Label3)
        Me.TabPage4.Controls.Add(Me.TextBox2)
        Me.TabPage4.Controls.Add(Me.TextBox1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(699, 553)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Projeção"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(179, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Concursos Elegiveis, Multiplos de:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Próximo Concurso:"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(369, 12)
        Me.TextBox2.MaxLength = 6
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(241, 22)
        Me.TextBox2.TabIndex = 15
        Me.TextBox2.Text = "2-3-4-5-6-7-8-9-10-11-12"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(118, 12)
        Me.TextBox1.MaxLength = 6
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(45, 22)
        Me.TextBox1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Loteria:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(261, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Qtde p/ Faixa:"
        '
        'ddlLoteria
        '
        Me.ddlLoteria.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ddlLoteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlLoteria.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlLoteria.FormattingEnabled = True
        Me.ddlLoteria.Location = New System.Drawing.Point(68, 12)
        Me.ddlLoteria.Name = "ddlLoteria"
        Me.ddlLoteria.Size = New System.Drawing.Size(187, 21)
        Me.ddlLoteria.Sorted = True
        Me.ddlLoteria.TabIndex = 8
        '
        'txtFaixas
        '
        Me.txtFaixas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFaixas.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaixas.Location = New System.Drawing.Point(347, 12)
        Me.txtFaixas.MaxLength = 5
        Me.txtFaixas.Name = "txtFaixas"
        Me.txtFaixas.Size = New System.Drawing.Size(45, 22)
        Me.txtFaixas.TabIndex = 9
        Me.txtFaixas.Text = "10"
        '
        'frmCockPit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 627)
        Me.Controls.Add(Me.XpGradientPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCockPit"
        Me.Text = "CockPit de Estudo Lotérico"
        Me.XpGradientPanel1.ResumeLayout(False)
        Me.XpGradientPanel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XpGradientPanel1 As Steepvalley.Windows.Forms.Containers.XPGradientPanel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ddlLoteria As System.Windows.Forms.ComboBox
    Friend WithEvents txtFaixas As System.Windows.Forms.TextBox
    Friend WithEvents btnFechar As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents btnPesquisar As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents grdStats As SourceGrid.Grid
    Friend WithEvents grdOccurs As SourceGrid.Grid
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
