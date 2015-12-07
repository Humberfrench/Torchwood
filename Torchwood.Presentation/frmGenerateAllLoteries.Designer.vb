<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerateAllLoteries
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
        Me.XpCaptionPane1 = New Steepvalley.Windows.Forms.XPCaptionPane
        Me.chkQuina = New System.Windows.Forms.CheckBox
        Me.chkLotoFacil = New System.Windows.Forms.CheckBox
        Me.chkLotoMania = New System.Windows.Forms.CheckBox
        Me.chkTimeMania = New System.Windows.Forms.CheckBox
        Me.chkDuplaSena2 = New System.Windows.Forms.CheckBox
        Me.chkDuplaSena1 = New System.Windows.Forms.CheckBox
        Me.chkMegaSena = New System.Windows.Forms.CheckBox
        Me.pbDados = New System.Windows.Forms.ProgressBar
        Me.XpGradientPanel1 = New Steepvalley.Windows.Forms.Containers.XPGradientPanel
        Me.btnGravaLoteria = New Flowsight.Windows.Forms.CrystalButton
        Me.btnFechar = New Flowsight.Windows.Forms.CrystalButton
        Me.chkTimeManiaTimes = New System.Windows.Forms.CheckBox
        Me.XpCaptionPane1.SuspendLayout()
        Me.XpGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.XpCaptionPane1.CaptionControl.Size = New System.Drawing.Size(326, 20)
        Me.XpCaptionPane1.CaptionControl.TabIndex = 0
        Me.XpCaptionPane1.CaptionControl.Text = "Importadar Loterias"
        Me.XpCaptionPane1.CaptionText = "Importadar Loterias"
        Me.XpCaptionPane1.Controls.Add(Me.pbDados)
        Me.XpCaptionPane1.Controls.Add(Me.chkMegaSena)
        Me.XpCaptionPane1.Controls.Add(Me.chkDuplaSena1)
        Me.XpCaptionPane1.Controls.Add(Me.chkDuplaSena2)
        Me.XpCaptionPane1.Controls.Add(Me.chkTimeMania)
        Me.XpCaptionPane1.Controls.Add(Me.chkTimeManiaTimes)
        Me.XpCaptionPane1.Controls.Add(Me.chkLotoMania)
        Me.XpCaptionPane1.Controls.Add(Me.chkLotoFacil)
        Me.XpCaptionPane1.Controls.Add(Me.chkQuina)
        Me.XpCaptionPane1.Location = New System.Drawing.Point(12, 12)
        Me.XpCaptionPane1.Name = "XpCaptionPane1"
        Me.XpCaptionPane1.Padding = New System.Windows.Forms.Padding(1)
        Me.XpCaptionPane1.Size = New System.Drawing.Size(330, 168)
        Me.XpCaptionPane1.TabIndex = 62
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
        Me.chkQuina.Location = New System.Drawing.Point(158, 51)
        Me.chkQuina.Name = "chkQuina"
        Me.chkQuina.Size = New System.Drawing.Size(56, 17)
        Me.chkQuina.TabIndex = 39
        Me.chkQuina.Text = "Quina"
        Me.chkQuina.UseVisualStyleBackColor = False
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
        Me.chkLotoFacil.Location = New System.Drawing.Point(158, 28)
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
        'chkTimeMania
        '
        Me.chkTimeMania.AutoSize = True
        Me.chkTimeMania.BackColor = System.Drawing.Color.Transparent
        Me.chkTimeMania.Checked = True
        Me.chkTimeMania.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTimeMania.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkTimeMania.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTimeMania.ForeColor = System.Drawing.Color.Black
        Me.chkTimeMania.Location = New System.Drawing.Point(157, 74)
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
        'pbDados
        '
        Me.pbDados.Location = New System.Drawing.Point(5, 120)
        Me.pbDados.Name = "pbDados"
        Me.pbDados.Size = New System.Drawing.Size(319, 34)
        Me.pbDados.TabIndex = 41
        '
        'XpGradientPanel1
        '
        Me.XpGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.XpGradientPanel1.Controls.Add(Me.btnGravaLoteria)
        Me.XpGradientPanel1.Controls.Add(Me.btnFechar)
        Me.XpGradientPanel1.Controls.Add(Me.XpCaptionPane1)
        Me.XpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XpGradientPanel1.EndColor = System.Drawing.Color.LightSteelBlue
        Me.XpGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.XpGradientPanel1.Name = "XpGradientPanel1"
        Me.XpGradientPanel1.Size = New System.Drawing.Size(445, 195)
        Me.XpGradientPanel1.StartColor = System.Drawing.Color.Lavender
        Me.XpGradientPanel1.TabIndex = 3
        '
        'btnGravaLoteria
        '
        Me.btnGravaLoteria.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnGravaLoteria.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGravaLoteria.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGravaLoteria.Image = Global.Torchwood.Presentation.My.Resources.Resources.gravar
        Me.btnGravaLoteria.Location = New System.Drawing.Point(348, 12)
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
        Me.btnFechar.Location = New System.Drawing.Point(348, 42)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(85, 24)
        Me.btnFechar.TabIndex = 63
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'chkTimeManiaTimes
        '
        Me.chkTimeManiaTimes.AutoSize = True
        Me.chkTimeManiaTimes.BackColor = System.Drawing.Color.Transparent
        Me.chkTimeManiaTimes.Checked = True
        Me.chkTimeManiaTimes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTimeManiaTimes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkTimeManiaTimes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTimeManiaTimes.ForeColor = System.Drawing.Color.Black
        Me.chkTimeManiaTimes.Location = New System.Drawing.Point(157, 97)
        Me.chkTimeManiaTimes.Name = "chkTimeManiaTimes"
        Me.chkTimeManiaTimes.Size = New System.Drawing.Size(121, 17)
        Me.chkTimeManiaTimes.TabIndex = 40
        Me.chkTimeManiaTimes.Text = "Time-Mania - Times"
        Me.chkTimeManiaTimes.UseVisualStyleBackColor = False
        '
        'frmGenerateAllLoteries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 195)
        Me.Controls.Add(Me.XpGradientPanel1)
        Me.Name = "frmGenerateAllLoteries"
        Me.Text = "frmGenerateAllLoteries"
        Me.XpCaptionPane1.ResumeLayout(False)
        Me.XpCaptionPane1.PerformLayout()
        Me.XpGradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XpCaptionPane1 As Steepvalley.Windows.Forms.XPCaptionPane
    Friend WithEvents pbDados As System.Windows.Forms.ProgressBar
    Friend WithEvents chkMegaSena As System.Windows.Forms.CheckBox
    Friend WithEvents chkDuplaSena1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDuplaSena2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkTimeMania As System.Windows.Forms.CheckBox
    Friend WithEvents chkLotoMania As System.Windows.Forms.CheckBox
    Friend WithEvents chkLotoFacil As System.Windows.Forms.CheckBox
    Friend WithEvents chkQuina As System.Windows.Forms.CheckBox
    Friend WithEvents XpGradientPanel1 As Steepvalley.Windows.Forms.Containers.XPGradientPanel
    Friend WithEvents btnGravaLoteria As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents btnFechar As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents chkTimeManiaTimes As System.Windows.Forms.CheckBox
End Class
