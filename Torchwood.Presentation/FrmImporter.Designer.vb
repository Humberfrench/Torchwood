<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImporter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImporter))
        Me.ofdImportar = New System.Windows.Forms.OpenFileDialog()
        Me.XpGradientPanel1 = New Steepvalley.Windows.Forms.Containers.XPGradientPanel()
        Me.XpCaptionPane1 = New Steepvalley.Windows.Forms.XPCaptionPane()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFilename = New System.Windows.Forms.TextBox()
        Me.lvResults = New System.Windows.Forms.ListView()
        Me.colLoteria = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colConcursos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.XpCaptionPane2 = New Steepvalley.Windows.Forms.XPCaptionPane()
        Me.chkMegaSena = New System.Windows.Forms.CheckBox()
        Me.chkDuplaSena1 = New System.Windows.Forms.CheckBox()
        Me.chkTimeMania = New System.Windows.Forms.CheckBox()
        Me.chkDuplaSena2 = New System.Windows.Forms.CheckBox()
        Me.chkLotoFacil = New System.Windows.Forms.CheckBox()
        Me.chkLotoMania = New System.Windows.Forms.CheckBox()
        Me.chkQuina = New System.Windows.Forms.CheckBox()
        Me.btnFechar = New Flowsight.Windows.Forms.CrystalButton()
        Me.btnImportar = New Flowsight.Windows.Forms.CrystalButton()
        Me.btnLocate = New Flowsight.Windows.Forms.CrystalButton()
        Me.pbAndamento = New System.Windows.Forms.ProgressBar()
        Me.picLoteria = New System.Windows.Forms.PictureBox()
        Me.XpGradientPanel1.SuspendLayout()
        Me.XpCaptionPane1.SuspendLayout()
        Me.XpCaptionPane2.SuspendLayout()
        CType(Me.picLoteria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ofdImportar
        '
        Me.ofdImportar.Filter = "Arquivos Excel 2007 | *.xlsx|Arquivos Excel | *.xls"
        Me.ofdImportar.InitialDirectory = "c:\"
        '
        'XpGradientPanel1
        '
        Me.XpGradientPanel1.Controls.Add(Me.picLoteria)
        Me.XpGradientPanel1.Controls.Add(Me.XpCaptionPane1)
        Me.XpGradientPanel1.Controls.Add(Me.XpCaptionPane2)
        Me.XpGradientPanel1.Controls.Add(Me.btnFechar)
        Me.XpGradientPanel1.Controls.Add(Me.btnImportar)
        Me.XpGradientPanel1.Controls.Add(Me.btnLocate)
        Me.XpGradientPanel1.Controls.Add(Me.pbAndamento)
        Me.XpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XpGradientPanel1.EndColor = System.Drawing.Color.LightSteelBlue
        Me.XpGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.XpGradientPanel1.Name = "XpGradientPanel1"
        Me.XpGradientPanel1.Size = New System.Drawing.Size(598, 244)
        Me.XpGradientPanel1.StartColor = System.Drawing.Color.Lavender
        Me.XpGradientPanel1.TabIndex = 0
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
        Me.XpCaptionPane1.CaptionControl.Size = New System.Drawing.Size(267, 20)
        Me.XpCaptionPane1.CaptionControl.TabIndex = 0
        Me.XpCaptionPane1.CaptionControl.Text = "Dados"
        Me.XpCaptionPane1.CaptionText = "Dados"
        Me.XpCaptionPane1.Controls.Add(Me.Label1)
        Me.XpCaptionPane1.Controls.Add(Me.txtFilename)
        Me.XpCaptionPane1.Controls.Add(Me.lvResults)
        Me.XpCaptionPane1.Location = New System.Drawing.Point(15, 12)
        Me.XpCaptionPane1.Name = "XpCaptionPane1"
        Me.XpCaptionPane1.Padding = New System.Windows.Forms.Padding(1)
        Me.XpCaptionPane1.Size = New System.Drawing.Size(271, 187)
        Me.XpCaptionPane1.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 15)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Selecione Caminho do Arquivo"
        '
        'txtFilename
        '
        Me.txtFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilename.Location = New System.Drawing.Point(13, 44)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.Size = New System.Drawing.Size(237, 20)
        Me.txtFilename.TabIndex = 32
        '
        'lvResults
        '
        Me.lvResults.BackColor = System.Drawing.SystemColors.Info
        Me.lvResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvResults.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colLoteria, Me.colConcursos})
        Me.lvResults.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvResults.Location = New System.Drawing.Point(13, 70)
        Me.lvResults.Name = "lvResults"
        Me.lvResults.Size = New System.Drawing.Size(237, 109)
        Me.lvResults.TabIndex = 28
        Me.lvResults.UseCompatibleStateImageBehavior = False
        Me.lvResults.View = System.Windows.Forms.View.Details
        '
        'colLoteria
        '
        Me.colLoteria.Text = "Loteria"
        Me.colLoteria.Width = 140
        '
        'colConcursos
        '
        Me.colConcursos.Text = "Concursos"
        Me.colConcursos.Width = 75
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
        Me.XpCaptionPane2.CaptionControl.Size = New System.Drawing.Size(147, 20)
        Me.XpCaptionPane2.CaptionControl.TabIndex = 0
        Me.XpCaptionPane2.CaptionControl.Text = "Importadar Loterias"
        Me.XpCaptionPane2.CaptionText = "Importadar Loterias"
        Me.XpCaptionPane2.Controls.Add(Me.chkMegaSena)
        Me.XpCaptionPane2.Controls.Add(Me.chkDuplaSena1)
        Me.XpCaptionPane2.Controls.Add(Me.chkTimeMania)
        Me.XpCaptionPane2.Controls.Add(Me.chkDuplaSena2)
        Me.XpCaptionPane2.Controls.Add(Me.chkLotoFacil)
        Me.XpCaptionPane2.Controls.Add(Me.chkLotoMania)
        Me.XpCaptionPane2.Controls.Add(Me.chkQuina)
        Me.XpCaptionPane2.Location = New System.Drawing.Point(297, 12)
        Me.XpCaptionPane2.Name = "XpCaptionPane2"
        Me.XpCaptionPane2.Padding = New System.Windows.Forms.Padding(1)
        Me.XpCaptionPane2.Size = New System.Drawing.Size(151, 187)
        Me.XpCaptionPane2.TabIndex = 61
        '
        'chkMegaSena
        '
        Me.chkMegaSena.AutoSize = True
        Me.chkMegaSena.BackColor = System.Drawing.Color.Transparent
        Me.chkMegaSena.Checked = True
        Me.chkMegaSena.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMegaSena.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkMegaSena.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMegaSena.ForeColor = System.Drawing.Color.Black
        Me.chkMegaSena.Location = New System.Drawing.Point(4, 28)
        Me.chkMegaSena.Name = "chkMegaSena"
        Me.chkMegaSena.Size = New System.Drawing.Size(82, 17)
        Me.chkMegaSena.TabIndex = 34
        Me.chkMegaSena.Text = "Mega-Sena"
        Me.chkMegaSena.UseVisualStyleBackColor = False
        '
        'chkDuplaSena1
        '
        Me.chkDuplaSena1.AutoSize = True
        Me.chkDuplaSena1.BackColor = System.Drawing.Color.Transparent
        Me.chkDuplaSena1.Checked = True
        Me.chkDuplaSena1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDuplaSena1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkDuplaSena1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDuplaSena1.ForeColor = System.Drawing.Color.Black
        Me.chkDuplaSena1.Location = New System.Drawing.Point(4, 51)
        Me.chkDuplaSena1.Name = "chkDuplaSena1"
        Me.chkDuplaSena1.Size = New System.Drawing.Size(93, 17)
        Me.chkDuplaSena1.TabIndex = 35
        Me.chkDuplaSena1.Text = "Dupla-Sena 1"
        Me.chkDuplaSena1.UseVisualStyleBackColor = False
        '
        'chkTimeMania
        '
        Me.chkTimeMania.AutoSize = True
        Me.chkTimeMania.BackColor = System.Drawing.Color.Transparent
        Me.chkTimeMania.Checked = True
        Me.chkTimeMania.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTimeMania.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkTimeMania.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTimeMania.ForeColor = System.Drawing.Color.Black
        Me.chkTimeMania.Location = New System.Drawing.Point(3, 166)
        Me.chkTimeMania.Name = "chkTimeMania"
        Me.chkTimeMania.Size = New System.Drawing.Size(83, 17)
        Me.chkTimeMania.TabIndex = 40
        Me.chkTimeMania.Text = "Time-Mania"
        Me.chkTimeMania.UseVisualStyleBackColor = False
        '
        'chkDuplaSena2
        '
        Me.chkDuplaSena2.AutoSize = True
        Me.chkDuplaSena2.BackColor = System.Drawing.Color.Transparent
        Me.chkDuplaSena2.Checked = True
        Me.chkDuplaSena2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDuplaSena2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkDuplaSena2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDuplaSena2.ForeColor = System.Drawing.Color.Black
        Me.chkDuplaSena2.Location = New System.Drawing.Point(4, 74)
        Me.chkDuplaSena2.Name = "chkDuplaSena2"
        Me.chkDuplaSena2.Size = New System.Drawing.Size(93, 17)
        Me.chkDuplaSena2.TabIndex = 36
        Me.chkDuplaSena2.Text = "Dupla-Sena 2"
        Me.chkDuplaSena2.UseVisualStyleBackColor = False
        '
        'chkLotoFacil
        '
        Me.chkLotoFacil.AutoSize = True
        Me.chkLotoFacil.BackColor = System.Drawing.Color.Transparent
        Me.chkLotoFacil.Checked = True
        Me.chkLotoFacil.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLotoFacil.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkLotoFacil.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLotoFacil.ForeColor = System.Drawing.Color.Black
        Me.chkLotoFacil.Location = New System.Drawing.Point(4, 120)
        Me.chkLotoFacil.Name = "chkLotoFacil"
        Me.chkLotoFacil.Size = New System.Drawing.Size(74, 17)
        Me.chkLotoFacil.TabIndex = 38
        Me.chkLotoFacil.Text = "Loto-Fácil"
        Me.chkLotoFacil.UseVisualStyleBackColor = False
        '
        'chkLotoMania
        '
        Me.chkLotoMania.AutoSize = True
        Me.chkLotoMania.BackColor = System.Drawing.Color.Transparent
        Me.chkLotoMania.Checked = True
        Me.chkLotoMania.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLotoMania.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkLotoMania.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLotoMania.ForeColor = System.Drawing.Color.Black
        Me.chkLotoMania.Location = New System.Drawing.Point(4, 97)
        Me.chkLotoMania.Name = "chkLotoMania"
        Me.chkLotoMania.Size = New System.Drawing.Size(83, 17)
        Me.chkLotoMania.TabIndex = 37
        Me.chkLotoMania.Text = "Loto-Mania"
        Me.chkLotoMania.UseVisualStyleBackColor = False
        '
        'chkQuina
        '
        Me.chkQuina.AutoSize = True
        Me.chkQuina.BackColor = System.Drawing.Color.Transparent
        Me.chkQuina.Checked = True
        Me.chkQuina.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkQuina.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkQuina.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkQuina.ForeColor = System.Drawing.Color.Black
        Me.chkQuina.Location = New System.Drawing.Point(4, 143)
        Me.chkQuina.Name = "chkQuina"
        Me.chkQuina.Size = New System.Drawing.Size(56, 17)
        Me.chkQuina.TabIndex = 39
        Me.chkQuina.Text = "Quina"
        Me.chkQuina.UseVisualStyleBackColor = False
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnFechar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = Global.Torchwood.Presentation.My.Resources.Resources.door_in
        Me.btnFechar.Location = New System.Drawing.Point(454, 93)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(131, 34)
        Me.btnFechar.TabIndex = 60
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnImportar
        '
        Me.btnImportar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnImportar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnImportar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportar.Image = Global.Torchwood.Presentation.My.Resources.Resources.control_play
        Me.btnImportar.Location = New System.Drawing.Point(454, 52)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(131, 34)
        Me.btnImportar.TabIndex = 30
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImportar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnLocate
        '
        Me.btnLocate.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnLocate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLocate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocate.Image = Global.Torchwood.Presentation.My.Resources.Resources.doc_excel_table
        Me.btnLocate.Location = New System.Drawing.Point(454, 12)
        Me.btnLocate.Name = "btnLocate"
        Me.btnLocate.Size = New System.Drawing.Size(131, 34)
        Me.btnLocate.TabIndex = 29
        Me.btnLocate.Text = "Arquivo"
        Me.btnLocate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLocate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'pbAndamento
        '
        Me.pbAndamento.Location = New System.Drawing.Point(15, 205)
        Me.pbAndamento.Maximum = 7
        Me.pbAndamento.Name = "pbAndamento"
        Me.pbAndamento.Size = New System.Drawing.Size(433, 23)
        Me.pbAndamento.TabIndex = 27
        '
        'picLoteria
        '
        Me.picLoteria.Location = New System.Drawing.Point(454, 133)
        Me.picLoteria.Name = "picLoteria"
        Me.picLoteria.Size = New System.Drawing.Size(140, 64)
        Me.picLoteria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picLoteria.TabIndex = 63
        Me.picLoteria.TabStop = False
        '
        'FrmImporter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 244)
        Me.Controls.Add(Me.XpGradientPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmImporter"
        Me.Text = "Torchwood Importer"
        Me.XpGradientPanel1.ResumeLayout(False)
        Me.XpCaptionPane1.ResumeLayout(False)
        Me.XpCaptionPane1.PerformLayout()
        Me.XpCaptionPane2.ResumeLayout(False)
        Me.XpCaptionPane2.PerformLayout()
        CType(Me.picLoteria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ofdImportar As System.Windows.Forms.OpenFileDialog
    Friend WithEvents XpGradientPanel1 As Steepvalley.Windows.Forms.Containers.XPGradientPanel
    Friend WithEvents chkTimeMania As System.Windows.Forms.CheckBox
    Friend WithEvents chkLotoFacil As System.Windows.Forms.CheckBox
    Friend WithEvents btnImportar As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents chkQuina As System.Windows.Forms.CheckBox
    Friend WithEvents btnLocate As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents pbAndamento As System.Windows.Forms.ProgressBar
    Friend WithEvents chkLotoMania As System.Windows.Forms.CheckBox
    Friend WithEvents txtFilename As System.Windows.Forms.TextBox
    Friend WithEvents lvResults As System.Windows.Forms.ListView
    Friend WithEvents colLoteria As System.Windows.Forms.ColumnHeader
    Friend WithEvents colConcursos As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkDuplaSena2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDuplaSena1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkMegaSena As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnFechar As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents XpCaptionPane1 As Steepvalley.Windows.Forms.XPCaptionPane
    Friend WithEvents XpCaptionPane2 As Steepvalley.Windows.Forms.XPCaptionPane
    Friend WithEvents picLoteria As System.Windows.Forms.PictureBox

End Class
