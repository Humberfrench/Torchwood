<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCombinations
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
        Me.XpGradientPanel1 = New Steepvalley.Windows.Forms.Containers.XPGradientPanel
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.id = New System.Windows.Forms.ColumnHeader
        Me.nr_dezena = New System.Windows.Forms.ColumnHeader
        Me.qt_itens = New System.Windows.Forms.ColumnHeader
        Me.pc_total = New System.Windows.Forms.ColumnHeader
        Me.pc_conc = New System.Windows.Forms.ColumnHeader
        Me.btnConsulta = New Flowsight.Windows.Forms.CrystalButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ddlRangeFim = New System.Windows.Forms.ComboBox
        Me.ddlRangeIni = New System.Windows.Forms.ComboBox
        Me.ddlLoterias = New System.Windows.Forms.ComboBox
        Me.Panel1 = New ExtendedDotNET.Controls.Panels.Panel
        Me.XpGradientPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'XpGradientPanel1
        '
        Me.XpGradientPanel1.Controls.Add(Me.Panel1)
        Me.XpGradientPanel1.Controls.Add(Me.TextBox4)
        Me.XpGradientPanel1.Controls.Add(Me.TextBox2)
        Me.XpGradientPanel1.Controls.Add(Me.TextBox3)
        Me.XpGradientPanel1.Controls.Add(Me.TextBox1)
        Me.XpGradientPanel1.Controls.Add(Me.btnConsulta)
        Me.XpGradientPanel1.Controls.Add(Me.Label3)
        Me.XpGradientPanel1.Controls.Add(Me.Label5)
        Me.XpGradientPanel1.Controls.Add(Me.Label8)
        Me.XpGradientPanel1.Controls.Add(Me.Label6)
        Me.XpGradientPanel1.Controls.Add(Me.Label7)
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
        Me.XpGradientPanel1.Size = New System.Drawing.Size(751, 432)
        Me.XpGradientPanel1.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(378, 72)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(47, 23)
        Me.TextBox4.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(378, 41)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(47, 23)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(166, 72)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(47, 23)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(166, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(47, 23)
        Me.TextBox1.TabIndex = 6
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.Info
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.nr_dezena, Me.qt_itens, Me.pc_total, Me.pc_conc})
        Me.ListView1.Location = New System.Drawing.Point(12, 29)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(466, 108)
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
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
        Me.Label3.Location = New System.Drawing.Point(245, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Faixa Inicial:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(33, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 22)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Faixa Inicial:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(272, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Dez. Máxima:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(290, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Min.Ocorr.:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(68, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Dez. Mínima:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(91, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dezenas:"
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
        'ddlRangeFim
        '
        Me.ddlRangeFim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlRangeFim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ddlRangeFim.Location = New System.Drawing.Point(378, 101)
        Me.ddlRangeFim.Name = "ddlRangeFim"
        Me.ddlRangeFim.Size = New System.Drawing.Size(73, 24)
        Me.ddlRangeFim.TabIndex = 3
        '
        'ddlRangeIni
        '
        Me.ddlRangeIni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlRangeIni.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ddlRangeIni.Location = New System.Drawing.Point(166, 101)
        Me.ddlRangeIni.Name = "ddlRangeIni"
        Me.ddlRangeIni.Size = New System.Drawing.Size(73, 24)
        Me.ddlRangeIni.TabIndex = 1
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
        'Panel1
        '
        Me.Panel1.Border = True
        Me.Panel1.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderWidth = 1
        Me.Panel1.Caption = True
        Me.Panel1.CaptionBeginColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.CaptionEndColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.CaptionGradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Panel1.CaptionHeight = 24
        Me.Panel1.CaptionText = "Estatísticas"
        Me.Panel1.CaptionTextAlignment = System.Drawing.StringAlignment.Near
        Me.Panel1.CaptionTextColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Panel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Panel1.GradientEnd = System.Drawing.SystemColors.ControlLight
        Me.Panel1.GradientStart = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.IconVisible = False
        Me.Panel1.Location = New System.Drawing.Point(12, 142)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.PanelIcon = Nothing
        Me.Panel1.Size = New System.Drawing.Size(496, 143)
        Me.Panel1.Style = ExtendedDotNET.Controls.BorderStyle.[Single]
        Me.Panel1.TabIndex = 7
        Me.Panel1.TextAntialias = True
        '
        'frmCombinations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 432)
        Me.Controls.Add(Me.XpGradientPanel1)
        Me.Name = "frmCombinations"
        Me.Text = "frmCombinations"
        Me.XpGradientPanel1.ResumeLayout(False)
        Me.XpGradientPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XpGradientPanel1 As Steepvalley.Windows.Forms.Containers.XPGradientPanel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents nr_dezena As System.Windows.Forms.ColumnHeader
    Friend WithEvents qt_itens As System.Windows.Forms.ColumnHeader
    Friend WithEvents pc_total As System.Windows.Forms.ColumnHeader
    Friend WithEvents pc_conc As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnConsulta As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ddlRangeFim As System.Windows.Forms.ComboBox
    Friend WithEvents ddlRangeIni As System.Windows.Forms.ComboBox
    Friend WithEvents ddlLoterias As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As ExtendedDotNET.Controls.Panels.Panel
End Class
