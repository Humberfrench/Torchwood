<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCombinar
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
        Me.XpGradientPanel1 = New Steepvalley.Windows.Forms.Containers.XPGradientPanel()
        Me.XpCaptionPane3 = New Steepvalley.Windows.Forms.XPCaptionPane()
        Me.lvLoterias = New System.Windows.Forms.ListView()
        Me.XpCaptionPane2 = New Steepvalley.Windows.Forms.XPCaptionPane()
        Me.ddlLoteria = New System.Windows.Forms.ComboBox()
        Me.XpCaptionPane1 = New Steepvalley.Windows.Forms.XPCaptionPane()
        Me.lstDezenas = New System.Windows.Forms.ListBox()
        Me.txtDezenas = New System.Windows.Forms.TextBox()
        Me.btnAddDezenas = New Flowsight.Windows.Forms.CrystalButton()
        Me.btnDelDezenas = New Flowsight.Windows.Forms.CrystalButton()
        Me.btnClrDezenas = New Flowsight.Windows.Forms.CrystalButton()
        Me.btnGerar = New Flowsight.Windows.Forms.CrystalButton()
        Me.btnFechar = New Flowsight.Windows.Forms.CrystalButton()
        Me.XpGradientPanel1.SuspendLayout()
        Me.XpCaptionPane3.SuspendLayout()
        Me.XpCaptionPane2.SuspendLayout()
        Me.XpCaptionPane1.SuspendLayout()
        Me.SuspendLayout()
        '
        'XpGradientPanel1
        '
        Me.XpGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.XpGradientPanel1.Controls.Add(Me.XpCaptionPane3)
        Me.XpGradientPanel1.Controls.Add(Me.XpCaptionPane2)
        Me.XpGradientPanel1.Controls.Add(Me.XpCaptionPane1)
        Me.XpGradientPanel1.Controls.Add(Me.btnGerar)
        Me.XpGradientPanel1.Controls.Add(Me.btnFechar)
        Me.XpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XpGradientPanel1.EndColor = System.Drawing.Color.LightSteelBlue
        Me.XpGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.XpGradientPanel1.Name = "XpGradientPanel1"
        Me.XpGradientPanel1.Size = New System.Drawing.Size(454, 223)
        Me.XpGradientPanel1.StartColor = System.Drawing.Color.Lavender
        Me.XpGradientPanel1.TabIndex = 2
        '
        'XpCaptionPane3
        '
        Me.XpCaptionPane3.BackColor = System.Drawing.Color.Lavender
        Me.XpCaptionPane3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.XpCaptionPane3.CaptionControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.XpCaptionPane3.CaptionControl.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XpCaptionPane3.CaptionControl.Location = New System.Drawing.Point(1, 1)
        Me.XpCaptionPane3.CaptionControl.Name = "caption"
        Me.XpCaptionPane3.CaptionControl.Size = New System.Drawing.Size(296, 20)
        Me.XpCaptionPane3.CaptionControl.TabIndex = 0
        Me.XpCaptionPane3.CaptionControl.Text = "Dezenas"
        Me.XpCaptionPane3.CaptionText = "Dezenas"
        Me.XpCaptionPane3.Controls.Add(Me.lvLoterias)
        Me.XpCaptionPane3.Location = New System.Drawing.Point(142, 72)
        Me.XpCaptionPane3.Name = "XpCaptionPane3"
        Me.XpCaptionPane3.Padding = New System.Windows.Forms.Padding(1)
        Me.XpCaptionPane3.Size = New System.Drawing.Size(300, 139)
        Me.XpCaptionPane3.TabIndex = 48
        '
        'lvLoterias
        '
        Me.lvLoterias.BackColor = System.Drawing.SystemColors.Info
        Me.lvLoterias.FullRowSelect = True
        Me.lvLoterias.Location = New System.Drawing.Point(4, 29)
        Me.lvLoterias.Name = "lvLoterias"
        Me.lvLoterias.Size = New System.Drawing.Size(290, 104)
        Me.lvLoterias.TabIndex = 20
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
        Me.XpCaptionPane2.CaptionControl.Size = New System.Drawing.Size(335, 20)
        Me.XpCaptionPane2.CaptionControl.TabIndex = 0
        Me.XpCaptionPane2.CaptionControl.Text = "Loteria"
        Me.XpCaptionPane2.CaptionText = "Loteria"
        Me.XpCaptionPane2.Controls.Add(Me.ddlLoteria)
        Me.XpCaptionPane2.Location = New System.Drawing.Point(12, 12)
        Me.XpCaptionPane2.Name = "XpCaptionPane2"
        Me.XpCaptionPane2.Padding = New System.Windows.Forms.Padding(1)
        Me.XpCaptionPane2.Size = New System.Drawing.Size(339, 54)
        Me.XpCaptionPane2.TabIndex = 48
        '
        'ddlLoteria
        '
        Me.ddlLoteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlLoteria.FormattingEnabled = True
        Me.ddlLoteria.Location = New System.Drawing.Point(5, 27)
        Me.ddlLoteria.Name = "ddlLoteria"
        Me.ddlLoteria.Size = New System.Drawing.Size(328, 21)
        Me.ddlLoteria.TabIndex = 1
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
        Me.XpCaptionPane1.CaptionControl.Size = New System.Drawing.Size(120, 20)
        Me.XpCaptionPane1.CaptionControl.TabIndex = 0
        Me.XpCaptionPane1.CaptionControl.Text = "Dezenas"
        Me.XpCaptionPane1.CaptionText = "Dezenas"
        Me.XpCaptionPane1.Controls.Add(Me.lstDezenas)
        Me.XpCaptionPane1.Controls.Add(Me.txtDezenas)
        Me.XpCaptionPane1.Controls.Add(Me.btnAddDezenas)
        Me.XpCaptionPane1.Controls.Add(Me.btnDelDezenas)
        Me.XpCaptionPane1.Controls.Add(Me.btnClrDezenas)
        Me.XpCaptionPane1.Location = New System.Drawing.Point(12, 72)
        Me.XpCaptionPane1.Name = "XpCaptionPane1"
        Me.XpCaptionPane1.Padding = New System.Windows.Forms.Padding(1)
        Me.XpCaptionPane1.Size = New System.Drawing.Size(124, 139)
        Me.XpCaptionPane1.TabIndex = 48
        '
        'lstDezenas
        '
        Me.lstDezenas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstDezenas.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDezenas.FormattingEnabled = True
        Me.lstDezenas.Location = New System.Drawing.Point(5, 59)
        Me.lstDezenas.Name = "lstDezenas"
        Me.lstDezenas.Size = New System.Drawing.Size(68, 67)
        Me.lstDezenas.TabIndex = 46
        '
        'txtDezenas
        '
        Me.txtDezenas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDezenas.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDezenas.Location = New System.Drawing.Point(4, 29)
        Me.txtDezenas.Name = "txtDezenas"
        Me.txtDezenas.Size = New System.Drawing.Size(69, 22)
        Me.txtDezenas.TabIndex = 44
        '
        'btnAddDezenas
        '
        Me.btnAddDezenas.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAddDezenas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddDezenas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddDezenas.Image = Global.Torchwood.Presentation.My.Resources.Resources.add
        Me.btnAddDezenas.Location = New System.Drawing.Point(79, 29)
        Me.btnAddDezenas.Name = "btnAddDezenas"
        Me.btnAddDezenas.Size = New System.Drawing.Size(35, 24)
        Me.btnAddDezenas.TabIndex = 45
        '
        'btnDelDezenas
        '
        Me.btnDelDezenas.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDelDezenas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDelDezenas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelDezenas.Image = Global.Torchwood.Presentation.My.Resources.Resources.cross
        Me.btnDelDezenas.Location = New System.Drawing.Point(79, 59)
        Me.btnDelDezenas.Name = "btnDelDezenas"
        Me.btnDelDezenas.Size = New System.Drawing.Size(35, 24)
        Me.btnDelDezenas.TabIndex = 45
        '
        'btnClrDezenas
        '
        Me.btnClrDezenas.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnClrDezenas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClrDezenas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClrDezenas.Image = Global.Torchwood.Presentation.My.Resources.Resources.bin_closed
        Me.btnClrDezenas.Location = New System.Drawing.Point(79, 89)
        Me.btnClrDezenas.Name = "btnClrDezenas"
        Me.btnClrDezenas.Size = New System.Drawing.Size(35, 24)
        Me.btnClrDezenas.TabIndex = 45
        '
        'btnGerar
        '
        Me.btnGerar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnGerar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGerar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGerar.Image = Global.Torchwood.Presentation.My.Resources.Resources.control_play
        Me.btnGerar.Location = New System.Drawing.Point(357, 12)
        Me.btnGerar.Name = "btnGerar"
        Me.btnGerar.Size = New System.Drawing.Size(85, 24)
        Me.btnGerar.TabIndex = 47
        Me.btnGerar.Text = "Gerar"
        Me.btnGerar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGerar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnFechar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = Global.Torchwood.Presentation.My.Resources.Resources.door_in
        Me.btnFechar.Location = New System.Drawing.Point(357, 42)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(85, 24)
        Me.btnFechar.TabIndex = 46
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'FrmCombinar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 223)
        Me.Controls.Add(Me.XpGradientPanel1)
        Me.Name = "FrmCombinar"
        Me.Text = "FrmCombinar"
        Me.XpGradientPanel1.ResumeLayout(False)
        Me.XpCaptionPane3.ResumeLayout(False)
        Me.XpCaptionPane2.ResumeLayout(False)
        Me.XpCaptionPane1.ResumeLayout(False)
        Me.XpCaptionPane1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XpGradientPanel1 As Steepvalley.Windows.Forms.Containers.XPGradientPanel
    Friend WithEvents btnAddDezenas As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents txtDezenas As System.Windows.Forms.TextBox
    Friend WithEvents btnGerar As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents btnFechar As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents XpCaptionPane1 As Steepvalley.Windows.Forms.XPCaptionPane
    Friend WithEvents lstDezenas As System.Windows.Forms.ListBox
    Friend WithEvents btnDelDezenas As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents btnClrDezenas As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents XpCaptionPane3 As Steepvalley.Windows.Forms.XPCaptionPane
    Friend WithEvents XpCaptionPane2 As Steepvalley.Windows.Forms.XPCaptionPane
    Friend WithEvents ddlLoteria As System.Windows.Forms.ComboBox
    Friend WithEvents lvLoterias As System.Windows.Forms.ListView
End Class
