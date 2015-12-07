<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudyStats
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
        Me.ddlLoterias = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.XpGradientPanel1 = New Steepvalley.Windows.Forms.Containers.XPGradientPanel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.lvStats = New System.Windows.Forms.ListView
        Me.id = New System.Windows.Forms.ColumnHeader
        Me.nr_dezena = New System.Windows.Forms.ColumnHeader
        Me.qt_itens = New System.Windows.Forms.ColumnHeader
        Me.pc_total = New System.Windows.Forms.ColumnHeader
        Me.pc_conc = New System.Windows.Forms.ColumnHeader
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.lvDistrib = New System.Windows.Forms.ListView
        Me.col_faixa = New System.Windows.Forms.ColumnHeader
        Me.col_Frequencia = New System.Windows.Forms.ColumnHeader
        Me.col_percentual = New System.Windows.Forms.ColumnHeader
        Me.col_pto_medio = New System.Windows.Forms.ColumnHeader
        Me.col_freq_acumul = New System.Windows.Forms.ColumnHeader
        Me.btnConsulta = New Flowsight.Windows.Forms.CrystalButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ddlRangeFim = New System.Windows.Forms.ComboBox
        Me.ddlRangeIni = New System.Windows.Forms.ComboBox
        Me.XpGradientPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ddlLoterias
        '
        Me.ddlLoterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlLoterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ddlLoterias.Location = New System.Drawing.Point(166, 11)
        Me.ddlLoterias.Name = "ddlLoterias"
        Me.ddlLoterias.Size = New System.Drawing.Size(202, 24)
        Me.ddlLoterias.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(33, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selecione Loteria:"
        '
        'XpGradientPanel1
        '
        Me.XpGradientPanel1.Controls.Add(Me.TabControl1)
        Me.XpGradientPanel1.Controls.Add(Me.btnConsulta)
        Me.XpGradientPanel1.Controls.Add(Me.Label3)
        Me.XpGradientPanel1.Controls.Add(Me.Label5)
        Me.XpGradientPanel1.Controls.Add(Me.Label2)
        Me.XpGradientPanel1.Controls.Add(Me.Label4)
        Me.XpGradientPanel1.Controls.Add(Me.Label1)
        Me.XpGradientPanel1.Controls.Add(Me.ddlRangeFim)
        Me.XpGradientPanel1.Controls.Add(Me.ddlRangeIni)
        Me.XpGradientPanel1.Controls.Add(Me.ddlLoterias)
        Me.XpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XpGradientPanel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XpGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.XpGradientPanel1.Name = "XpGradientPanel1"
        Me.XpGradientPanel1.Size = New System.Drawing.Size(519, 404)
        Me.XpGradientPanel1.TabIndex = 4
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(15, 71)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(491, 318)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lvStats)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(483, 289)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Percentual de Acertos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lvStats
        '
        Me.lvStats.BackColor = System.Drawing.SystemColors.Info
        Me.lvStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvStats.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.nr_dezena, Me.qt_itens, Me.pc_total, Me.pc_conc})
        Me.lvStats.FullRowSelect = True
        Me.lvStats.Location = New System.Drawing.Point(6, 6)
        Me.lvStats.Name = "lvStats"
        Me.lvStats.Size = New System.Drawing.Size(466, 271)
        Me.lvStats.TabIndex = 6
        Me.lvStats.UseCompatibleStateImageBehavior = False
        Me.lvStats.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        '
        'nr_dezena
        '
        Me.nr_dezena.Text = "Dezena"
        Me.nr_dezena.Width = 80
        '
        'qt_itens
        '
        Me.qt_itens.Text = "Quantidade"
        Me.qt_itens.Width = 100
        '
        'pc_total
        '
        Me.pc_total.Text = "% do Total"
        Me.pc_total.Width = 100
        '
        'pc_conc
        '
        Me.pc_conc.Text = "%Concursos"
        Me.pc_conc.Width = 100
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lvDistrib)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(483, 289)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Distribuição"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lvDistrib
        '
        Me.lvDistrib.BackColor = System.Drawing.SystemColors.Info
        Me.lvDistrib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvDistrib.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_faixa, Me.col_Frequencia, Me.col_percentual, Me.col_pto_medio, Me.col_freq_acumul})
        Me.lvDistrib.FullRowSelect = True
        Me.lvDistrib.Location = New System.Drawing.Point(8, 9)
        Me.lvDistrib.Name = "lvDistrib"
        Me.lvDistrib.Size = New System.Drawing.Size(466, 271)
        Me.lvDistrib.TabIndex = 7
        Me.lvDistrib.UseCompatibleStateImageBehavior = False
        Me.lvDistrib.View = System.Windows.Forms.View.Details
        '
        'col_faixa
        '
        Me.col_faixa.Text = "Faixa"
        Me.col_faixa.Width = 78
        '
        'col_Frequencia
        '
        Me.col_Frequencia.Text = "Frequencia"
        Me.col_Frequencia.Width = 92
        '
        'col_percentual
        '
        Me.col_percentual.Text = "Percentual"
        Me.col_percentual.Width = 99
        '
        'col_pto_medio
        '
        Me.col_pto_medio.Text = "Ponto Médio"
        Me.col_pto_medio.Width = 96
        '
        'col_freq_acumul
        '
        Me.col_freq_acumul.Text = "Freq.Acumul."
        Me.col_freq_acumul.Width = 100
        '
        'btnConsulta
        '
        Me.btnConsulta.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnConsulta.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnConsulta.Image = Nothing
        Me.btnConsulta.Location = New System.Drawing.Point(374, 12)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(104, 24)
        Me.btnConsulta.TabIndex = 4
        Me.btnConsulta.Text = "Consultar"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(255, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Faixa Inicial:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(12, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 22)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Faixa Inicial:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(33, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Faixa Inicial:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(33, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 22)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Selecione Loteria:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ddlRangeFim
        '
        Me.ddlRangeFim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlRangeFim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ddlRangeFim.Location = New System.Drawing.Point(388, 42)
        Me.ddlRangeFim.Name = "ddlRangeFim"
        Me.ddlRangeFim.Size = New System.Drawing.Size(90, 24)
        Me.ddlRangeFim.TabIndex = 3
        '
        'ddlRangeIni
        '
        Me.ddlRangeIni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlRangeIni.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ddlRangeIni.Location = New System.Drawing.Point(145, 41)
        Me.ddlRangeIni.Name = "ddlRangeIni"
        Me.ddlRangeIni.Size = New System.Drawing.Size(90, 24)
        Me.ddlRangeIni.TabIndex = 1
        '
        'frmStudyStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 404)
        Me.Controls.Add(Me.XpGradientPanel1)
        Me.Name = "frmStudyStats"
        Me.Text = "Estatísticas por Faixa"
        Me.XpGradientPanel1.ResumeLayout(False)
        Me.XpGradientPanel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ddlLoterias As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents XpGradientPanel1 As Steepvalley.Windows.Forms.Containers.XPGradientPanel
    Friend WithEvents btnConsulta As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ddlRangeFim As System.Windows.Forms.ComboBox
    Friend WithEvents ddlRangeIni As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lvStats As System.Windows.Forms.ListView
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents nr_dezena As System.Windows.Forms.ColumnHeader
    Friend WithEvents qt_itens As System.Windows.Forms.ColumnHeader
    Friend WithEvents pc_total As System.Windows.Forms.ColumnHeader
    Friend WithEvents pc_conc As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lvDistrib As System.Windows.Forms.ListView
    Friend WithEvents col_faixa As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Frequencia As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_percentual As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_pto_medio As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_freq_acumul As System.Windows.Forms.ColumnHeader
End Class
