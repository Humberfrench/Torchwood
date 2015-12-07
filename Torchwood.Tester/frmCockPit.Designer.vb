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
        Dim colGUID As System.Windows.Forms.ColumnHeader
        Dim colFaixa As System.Windows.Forms.ColumnHeader
        Dim colDescricao As System.Windows.Forms.ColumnHeader
        Dim colFxInicial As System.Windows.Forms.ColumnHeader
        Dim colFxFinal As System.Windows.Forms.ColumnHeader
        Dim colDezena As System.Windows.Forms.ColumnHeader
        Dim colQtDezena As System.Windows.Forms.ColumnHeader
        Dim colPcDezena As System.Windows.Forms.ColumnHeader
        Dim colQtdeConcursos As System.Windows.Forms.ColumnHeader
        Dim colTotal As System.Windows.Forms.ColumnHeader
        Dim colMedia As System.Windows.Forms.ColumnHeader
        Dim colMediaFaixa As System.Windows.Forms.ColumnHeader
        Dim colIsSuperior As System.Windows.Forms.ColumnHeader
        Dim colQtdeDezSuperior As System.Windows.Forms.ColumnHeader
        Dim ColMediaFxArred As System.Windows.Forms.ColumnHeader
        Dim colIsSuperiorArr As System.Windows.Forms.ColumnHeader
        Dim colQtdeDezArred As System.Windows.Forms.ColumnHeader
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCockPit))
        Me.Label1 = New System.Windows.Forms.Label
        Me.ddlLoteria = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFaixas = New System.Windows.Forms.TextBox
        Me.GradientPanel1 = New Ascend.Windows.Forms.GradientPanel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.lvStats = New System.Windows.Forms.ListView
        Me.colPcTotal = New System.Windows.Forms.ColumnHeader
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btnFechar = New Flowsight.Windows.Forms.CrystalButton
        Me.btnPesquisar = New Flowsight.Windows.Forms.CrystalButton
        Me.ListView1 = New System.Windows.Forms.ListView
        colGUID = New System.Windows.Forms.ColumnHeader
        colFaixa = New System.Windows.Forms.ColumnHeader
        colDescricao = New System.Windows.Forms.ColumnHeader
        colFxInicial = New System.Windows.Forms.ColumnHeader
        colFxFinal = New System.Windows.Forms.ColumnHeader
        colDezena = New System.Windows.Forms.ColumnHeader
        colQtDezena = New System.Windows.Forms.ColumnHeader
        colPcDezena = New System.Windows.Forms.ColumnHeader
        colQtdeConcursos = New System.Windows.Forms.ColumnHeader
        colTotal = New System.Windows.Forms.ColumnHeader
        colMedia = New System.Windows.Forms.ColumnHeader
        colMediaFaixa = New System.Windows.Forms.ColumnHeader
        colIsSuperior = New System.Windows.Forms.ColumnHeader
        colQtdeDezSuperior = New System.Windows.Forms.ColumnHeader
        ColMediaFxArred = New System.Windows.Forms.ColumnHeader
        colIsSuperiorArr = New System.Windows.Forms.ColumnHeader
        colQtdeDezArred = New System.Windows.Forms.ColumnHeader
        Me.GradientPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'colGUID
        '
        colGUID.Text = "GUID"
        colGUID.Width = 0
        '
        'colFaixa
        '
        colFaixa.Text = "Faixa"
        colFaixa.Width = 40
        '
        'colDescricao
        '
        colDescricao.Text = "Descrição"
        colDescricao.Width = 120
        '
        'colFxInicial
        '
        colFxInicial.Text = "Fx.Ini."
        colFxInicial.Width = 0
        '
        'colFxFinal
        '
        colFxFinal.Text = "Fx.Fim"
        colFxFinal.Width = 0
        '
        'colDezena
        '
        colDezena.Text = "Dezena"
        colDezena.Width = 50
        '
        'colQtDezena
        '
        colQtDezena.Text = "Qt.Dez."
        colQtDezena.Width = 50
        '
        'colPcDezena
        '
        colPcDezena.Text = "% Dez."
        colPcDezena.Width = 50
        '
        'colQtdeConcursos
        '
        colQtdeConcursos.DisplayIndex = 10
        colQtdeConcursos.Text = "Qt.Con."
        colQtdeConcursos.Width = 50
        '
        'colTotal
        '
        colTotal.DisplayIndex = 11
        colTotal.Text = "Total"
        colTotal.Width = 50
        '
        'colMedia
        '
        colMedia.DisplayIndex = 8
        colMedia.Text = "Media"
        colMedia.Width = 50
        '
        'colMediaFaixa
        '
        colMediaFaixa.Text = "Med.Fx."
        colMediaFaixa.Width = 50
        '
        'colIsSuperior
        '
        colIsSuperior.Text = "Sup?"
        colIsSuperior.Width = 40
        '
        'colQtdeDezSuperior
        '
        colQtdeDezSuperior.Text = "Qt.D.Sp."
        colQtdeDezSuperior.Width = 55
        '
        'ColMediaFxArred
        '
        ColMediaFxArred.Text = "M.Fx.Arr."
        '
        'colIsSuperiorArr
        '
        colIsSuperiorArr.Text = "Sup?"
        colIsSuperiorArr.Width = 40
        '
        'colQtdeDezArred
        '
        colQtdeDezArred.Text = "Qt.D.Ar."
        colQtdeDezArred.Width = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Loteria:"
        '
        'ddlLoteria
        '
        Me.ddlLoteria.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ddlLoteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlLoteria.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ddlLoteria.FormattingEnabled = True
        Me.ddlLoteria.Location = New System.Drawing.Point(78, 13)
        Me.ddlLoteria.Name = "ddlLoteria"
        Me.ddlLoteria.Size = New System.Drawing.Size(187, 21)
        Me.ddlLoteria.Sorted = True
        Me.ddlLoteria.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(271, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Qtde por Faixa:"
        '
        'txtFaixas
        '
        Me.txtFaixas.Location = New System.Drawing.Point(371, 13)
        Me.txtFaixas.Name = "txtFaixas"
        Me.txtFaixas.Size = New System.Drawing.Size(81, 20)
        Me.txtFaixas.TabIndex = 2
        Me.txtFaixas.Text = "10"
        '
        'GradientPanel1
        '
        Me.GradientPanel1.AntiAlias = True
        Me.GradientPanel1.Controls.Add(Me.TabControl1)
        Me.GradientPanel1.Controls.Add(Me.btnFechar)
        Me.GradientPanel1.Controls.Add(Me.btnPesquisar)
        Me.GradientPanel1.Controls.Add(Me.Label1)
        Me.GradientPanel1.Controls.Add(Me.Label2)
        Me.GradientPanel1.Controls.Add(Me.ddlLoteria)
        Me.GradientPanel1.Controls.Add(Me.txtFaixas)
        Me.GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GradientPanel1.GradientHighColor = System.Drawing.Color.PowderBlue
        Me.GradientPanel1.GradientLowColor = System.Drawing.Color.AliceBlue
        Me.GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanel1.Name = "GradientPanel1"
        Me.GradientPanel1.Size = New System.Drawing.Size(896, 515)
        Me.GradientPanel1.TabIndex = 4
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 40)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(872, 463)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lvStats)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(864, 437)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Estudo Estatístico Detalhado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lvStats
        '
        Me.lvStats.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {colGUID, colFaixa, colDescricao, colFxInicial, colFxFinal, colDezena, colQtDezena, colPcDezena, colQtdeConcursos, colTotal, Me.colPcTotal, colMedia, colMediaFaixa, colIsSuperior, colQtdeDezSuperior, ColMediaFxArred, colIsSuperiorArr, colQtdeDezArred})
        Me.lvStats.FullRowSelect = True
        Me.lvStats.Location = New System.Drawing.Point(9, 44)
        Me.lvStats.Name = "lvStats"
        Me.lvStats.Size = New System.Drawing.Size(848, 387)
        Me.lvStats.TabIndex = 8
        Me.lvStats.UseCompatibleStateImageBehavior = False
        Me.lvStats.View = System.Windows.Forms.View.Details
        '
        'colPcTotal
        '
        Me.colPcTotal.DisplayIndex = 9
        Me.colPcTotal.Text = "%Total"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(62, 17)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(187, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Faixas:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(864, 437)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Histórico"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.Color.LightBlue
        Me.btnFechar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFechar.Image = Nothing
        Me.btnFechar.Location = New System.Drawing.Point(798, 10)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(75, 23)
        Me.btnFechar.TabIndex = 5
        Me.btnFechar.Text = "Fechar"
        '
        'btnPesquisar
        '
        Me.btnPesquisar.BackColor = System.Drawing.Color.LightBlue
        Me.btnPesquisar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPesquisar.Image = Nothing
        Me.btnPesquisar.Location = New System.Drawing.Point(717, 11)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(75, 23)
        Me.btnPesquisar.TabIndex = 5
        Me.btnPesquisar.Text = "Pesquisar"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(9, 6)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(121, 97)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'frmCockPit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 515)
        Me.Controls.Add(Me.GradientPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCockPit"
        Me.Text = "CockPit de Estudo Lotérico"
        Me.GradientPanel1.ResumeLayout(False)
        Me.GradientPanel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ddlLoteria As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFaixas As System.Windows.Forms.TextBox
    Friend WithEvents GradientPanel1 As Ascend.Windows.Forms.GradientPanel
    Friend WithEvents btnFechar As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents btnPesquisar As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lvStats As System.Windows.Forms.ListView
    Friend WithEvents colPcTotal As System.Windows.Forms.ColumnHeader
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
End Class
