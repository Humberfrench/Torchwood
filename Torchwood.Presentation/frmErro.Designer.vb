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
        Me.txtErro = New System.Windows.Forms.TextBox()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.lblErrTitle = New System.Windows.Forms.Label()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtErro
        '
        Me.txtErro.BackColor = System.Drawing.Color.White
        Me.txtErro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtErro.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtErro.Location = New System.Drawing.Point(29, 73)
        Me.txtErro.Multiline = True
        Me.txtErro.Name = "txtErro"
        Me.txtErro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtErro.Size = New System.Drawing.Size(369, 107)
        Me.txtErro.TabIndex = 63
        '
        'lblSubTitle
        '
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTitle.ForeColor = System.Drawing.Color.Red
        Me.lblSubTitle.Location = New System.Drawing.Point(29, 49)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(369, 21)
        Me.lblSubTitle.TabIndex = 61
        Me.lblSubTitle.Text = "Sub-Titulo"
        '
        'lblErrTitle
        '
        Me.lblErrTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblErrTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrTitle.ForeColor = System.Drawing.Color.Red
        Me.lblErrTitle.Location = New System.Drawing.Point(29, 11)
        Me.lblErrTitle.Name = "lblErrTitle"
        Me.lblErrTitle.Size = New System.Drawing.Size(369, 28)
        Me.lblErrTitle.TabIndex = 62
        Me.lblErrTitle.Text = "Titulo"
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(132, 186)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(146, 35)
        Me.btnFechar.TabIndex = 109
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'frmErro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 233)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.txtErro)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.lblErrTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmErro"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Erro"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtErro As System.Windows.Forms.TextBox
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents lblErrTitle As System.Windows.Forms.Label
    Friend WithEvents btnFechar As System.Windows.Forms.Button
End Class
