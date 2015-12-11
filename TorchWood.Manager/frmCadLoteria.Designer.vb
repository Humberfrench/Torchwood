<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadLoteria
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
        Me.txtDezenas = New System.Windows.Forms.TextBox
        Me.txtDtConcurso = New System.Windows.Forms.TextBox
        Me.txtConcurso = New System.Windows.Forms.TextBox
        Me.ddlLoterias = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnAjeitarDados = New System.Windows.Forms.Button
        Me.btnFechar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnGravaLoteria = New System.Windows.Forms.Button
        Me.ddlTime = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnNovo = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtDezenas
        '
        Me.txtDezenas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDezenas.Location = New System.Drawing.Point(204, 86)
        Me.txtDezenas.Name = "txtDezenas"
        Me.txtDezenas.Size = New System.Drawing.Size(350, 25)
        Me.txtDezenas.TabIndex = 7
        '
        'txtDtConcurso
        '
        Me.txtDtConcurso.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDtConcurso.Location = New System.Drawing.Point(470, 55)
        Me.txtDtConcurso.Name = "txtDtConcurso"
        Me.txtDtConcurso.Size = New System.Drawing.Size(115, 25)
        Me.txtDtConcurso.TabIndex = 7
        '
        'txtConcurso
        '
        Me.txtConcurso.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcurso.Location = New System.Drawing.Point(204, 55)
        Me.txtConcurso.Name = "txtConcurso"
        Me.txtConcurso.Size = New System.Drawing.Size(69, 25)
        Me.txtConcurso.TabIndex = 7
        '
        'ddlLoterias
        '
        Me.ddlLoterias.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlLoterias.FormattingEnabled = True
        Me.ddlLoterias.Location = New System.Drawing.Point(204, 24)
        Me.ddlLoterias.Name = "ddlLoterias"
        Me.ddlLoterias.Size = New System.Drawing.Size(263, 25)
        Me.ddlLoterias.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dezenas (Separadas por "";"")"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(279, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Data do Concurso:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAjeitarDados
        '
        Me.btnAjeitarDados.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAjeitarDados.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAjeitarDados.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjeitarDados.Image = Global.Torchwood.Manager.My.Resources.Resources.refresh
        Me.btnAjeitarDados.Location = New System.Drawing.Point(560, 87)
        Me.btnAjeitarDados.Name = "btnAjeitarDados"
        Me.btnAjeitarDados.Size = New System.Drawing.Size(30, 24)
        Me.btnAjeitarDados.TabIndex = 5
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnFechar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = Nothing
        Me.btnFechar.Location = New System.Drawing.Point(611, 82)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(85, 24)
        Me.btnFechar.TabIndex = 5
        Me.btnFechar.Text = "Fechar"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Loteria:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Número do Concurso:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnGravaLoteria
        '
        Me.btnGravaLoteria.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnGravaLoteria.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGravaLoteria.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGravaLoteria.Image = Nothing
        Me.btnGravaLoteria.Location = New System.Drawing.Point(611, 52)
        Me.btnGravaLoteria.Name = "btnGravaLoteria"
        Me.btnGravaLoteria.Size = New System.Drawing.Size(85, 24)
        Me.btnGravaLoteria.TabIndex = 5
        Me.btnGravaLoteria.Text = "Gravar"
        '
        'ddlTime
        '
        Me.ddlTime.Enabled = False
        Me.ddlTime.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlTime.FormattingEnabled = True
        Me.ddlTime.Location = New System.Drawing.Point(204, 117)
        Me.ddlTime.Name = "ddlTime"
        Me.ddlTime.Size = New System.Drawing.Size(350, 25)
        Me.ddlTime.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(185, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Time Sorteado:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnNovo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNovo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.Image = Nothing
        Me.btnNovo.Location = New System.Drawing.Point(611, 22)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(85, 24)
        Me.btnNovo.TabIndex = 11
        Me.btnNovo.Text = "Novo"
        '
        'frmCadLoteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 169)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.ddlTime)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDezenas)
        Me.Controls.Add(Me.txtDtConcurso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtConcurso)
        Me.Controls.Add(Me.btnGravaLoteria)
        Me.Controls.Add(Me.ddlLoterias)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnAjeitarDados)
        Me.Name = "frmCadLoteria"
        Me.Text = "Gravação dos Concursos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents btnGravaLoteria As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ddlLoterias As System.Windows.Forms.ComboBox
    Friend WithEvents txtDtConcurso As System.Windows.Forms.TextBox
    Friend WithEvents txtConcurso As System.Windows.Forms.TextBox
    Friend WithEvents txtDezenas As System.Windows.Forms.TextBox
    Friend WithEvents btnAjeitarDados As System.Windows.Forms.Button
    Friend WithEvents ddlTime As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnNovo As System.Windows.Forms.Button
End Class
