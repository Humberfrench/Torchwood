<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmErro
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
        Me.brnFechar = New Flowsight.Windows.Forms.CrystalButton
        Me.lblSubTitle = New System.Windows.Forms.Label
        Me.lblErrTitle = New System.Windows.Forms.Label
        Me.txtErro = New System.Windows.Forms.TextBox
        Me.XpGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'XpGradientPanel1
        '
        Me.XpGradientPanel1.Controls.Add(Me.txtErro)
        Me.XpGradientPanel1.Controls.Add(Me.brnFechar)
        Me.XpGradientPanel1.Controls.Add(Me.lblSubTitle)
        Me.XpGradientPanel1.Controls.Add(Me.lblErrTitle)
        Me.XpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XpGradientPanel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XpGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.XpGradientPanel1.Name = "XpGradientPanel1"
        Me.XpGradientPanel1.Size = New System.Drawing.Size(424, 172)
        Me.XpGradientPanel1.TabIndex = 6
        '
        'brnFechar
        '
        Me.brnFechar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.brnFechar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.brnFechar.Image = Nothing
        Me.brnFechar.Location = New System.Drawing.Point(148, 136)
        Me.brnFechar.Name = "brnFechar"
        Me.brnFechar.Size = New System.Drawing.Size(104, 24)
        Me.brnFechar.TabIndex = 4
        Me.brnFechar.Text = "Fechar"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTitle.ForeColor = System.Drawing.Color.Red
        Me.lblSubTitle.Location = New System.Drawing.Point(27, 25)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(369, 16)
        Me.lblSubTitle.TabIndex = 2
        '
        'lblErrTitle
        '
        Me.lblErrTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblErrTitle.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrTitle.ForeColor = System.Drawing.Color.Red
        Me.lblErrTitle.Location = New System.Drawing.Point(27, 9)
        Me.lblErrTitle.Name = "lblErrTitle"
        Me.lblErrTitle.Size = New System.Drawing.Size(369, 16)
        Me.lblErrTitle.TabIndex = 2
        Me.lblErrTitle.Text = "Titulo"
        '
        'txtErro
        '
        Me.txtErro.BackColor = System.Drawing.Color.White
        Me.txtErro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtErro.Location = New System.Drawing.Point(30, 45)
        Me.txtErro.Multiline = True
        Me.txtErro.Name = "txtErro"
        Me.txtErro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtErro.Size = New System.Drawing.Size(366, 85)
        Me.txtErro.TabIndex = 5
        '
        'frmErro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 172)
        Me.Controls.Add(Me.XpGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmErro"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Erro"
        Me.TopMost = True
        Me.XpGradientPanel1.ResumeLayout(False)
        Me.XpGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XpGradientPanel1 As Steepvalley.Windows.Forms.Containers.XPGradientPanel
    Friend WithEvents brnFechar As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents lblErrTitle As System.Windows.Forms.Label
    Friend WithEvents txtErro As System.Windows.Forms.TextBox
End Class
