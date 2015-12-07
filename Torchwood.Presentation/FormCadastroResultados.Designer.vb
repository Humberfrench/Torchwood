<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCadastroResultados
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
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.picLoteria = New System.Windows.Forms.PictureBox()
        Me.chkAtivo = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDezTotais = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ddlLoteria = New System.Windows.Forms.ComboBox()
        Me.txtTotalDezenas = New System.Windows.Forms.TextBox()
        Me.txtPremMax = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalConcursos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDezFinal = New System.Windows.Forms.TextBox()
        Me.txtPremMin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDezInicial = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDezSorteio = New System.Windows.Forms.TextBox()
        CType(Me.picLoteria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(641, 52)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(146, 35)
        Me.btnFechar.TabIndex = 126
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnPesquisar
        '
        Me.btnPesquisar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPesquisar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesquisar.Location = New System.Drawing.Point(641, 6)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(146, 35)
        Me.btnPesquisar.TabIndex = 125
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = False
        '
        'picLoteria
        '
        Me.picLoteria.Location = New System.Drawing.Point(411, 9)
        Me.picLoteria.Name = "picLoteria"
        Me.picLoteria.Size = New System.Drawing.Size(223, 77)
        Me.picLoteria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picLoteria.TabIndex = 124
        Me.picLoteria.TabStop = False
        '
        'chkAtivo
        '
        Me.chkAtivo.AutoSize = True
        Me.chkAtivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkAtivo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAtivo.Location = New System.Drawing.Point(411, 94)
        Me.chkAtivo.Name = "chkAtivo"
        Me.chkAtivo.Size = New System.Drawing.Size(89, 19)
        Me.chkAtivo.TabIndex = 123
        Me.chkAtivo.Text = "Loteria Ativa"
        Me.chkAtivo.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(210, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 15)
        Me.Label10.TabIndex = 121
        Me.Label10.Text = "TT Dezenas:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(210, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 15)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "Dez. Final:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(210, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 15)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "Prem. Máxima:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDezTotais
        '
        Me.txtDezTotais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDezTotais.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDezTotais.Location = New System.Drawing.Point(333, 37)
        Me.txtDezTotais.Name = "txtDezTotais"
        Me.txtDezTotais.ReadOnly = True
        Me.txtDezTotais.Size = New System.Drawing.Size(58, 23)
        Me.txtDezTotais.TabIndex = 119
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 15)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Loteria:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ddlLoteria
        '
        Me.ddlLoteria.BackColor = System.Drawing.SystemColors.Control
        Me.ddlLoteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlLoteria.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ddlLoteria.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlLoteria.FormattingEnabled = True
        Me.ddlLoteria.Location = New System.Drawing.Point(134, 6)
        Me.ddlLoteria.Name = "ddlLoteria"
        Me.ddlLoteria.Size = New System.Drawing.Size(256, 23)
        Me.ddlLoteria.Sorted = True
        Me.ddlLoteria.TabIndex = 111
        '
        'txtTotalDezenas
        '
        Me.txtTotalDezenas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalDezenas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDezenas.Location = New System.Drawing.Point(333, 144)
        Me.txtTotalDezenas.Name = "txtTotalDezenas"
        Me.txtTotalDezenas.ReadOnly = True
        Me.txtTotalDezenas.Size = New System.Drawing.Size(58, 23)
        Me.txtTotalDezenas.TabIndex = 114
        '
        'txtPremMax
        '
        Me.txtPremMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPremMax.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPremMax.Location = New System.Drawing.Point(333, 74)
        Me.txtPremMax.Name = "txtPremMax"
        Me.txtPremMax.ReadOnly = True
        Me.txtPremMax.Size = New System.Drawing.Size(58, 23)
        Me.txtPremMax.TabIndex = 115
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 15)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Dez. Sorteio:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalConcursos
        '
        Me.txtTotalConcursos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalConcursos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalConcursos.Location = New System.Drawing.Point(134, 144)
        Me.txtTotalConcursos.Name = "txtTotalConcursos"
        Me.txtTotalConcursos.ReadOnly = True
        Me.txtTotalConcursos.Size = New System.Drawing.Size(68, 23)
        Me.txtTotalConcursos.TabIndex = 112
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 15)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Dez. Inicial:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDezFinal
        '
        Me.txtDezFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDezFinal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDezFinal.Location = New System.Drawing.Point(333, 111)
        Me.txtDezFinal.Name = "txtDezFinal"
        Me.txtDezFinal.ReadOnly = True
        Me.txtDezFinal.Size = New System.Drawing.Size(58, 23)
        Me.txtDezFinal.TabIndex = 113
        '
        'txtPremMin
        '
        Me.txtPremMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPremMin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPremMin.Location = New System.Drawing.Point(134, 74)
        Me.txtPremMin.Name = "txtPremMin"
        Me.txtPremMin.ReadOnly = True
        Me.txtPremMin.Size = New System.Drawing.Size(68, 23)
        Me.txtPremMin.TabIndex = 118
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(210, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 15)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Dez. Totais:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 15)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Prem. Mínima:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDezInicial
        '
        Me.txtDezInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDezInicial.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDezInicial.Location = New System.Drawing.Point(134, 111)
        Me.txtDezInicial.Name = "txtDezInicial"
        Me.txtDezInicial.ReadOnly = True
        Me.txtDezInicial.Size = New System.Drawing.Size(68, 23)
        Me.txtDezInicial.TabIndex = 116
        '
        'Label9
        '
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 15)
        Me.Label9.TabIndex = 107
        Me.Label9.Text = "Tt Concursos:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDezSorteio
        '
        Me.txtDezSorteio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDezSorteio.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDezSorteio.Location = New System.Drawing.Point(134, 37)
        Me.txtDezSorteio.Name = "txtDezSorteio"
        Me.txtDezSorteio.ReadOnly = True
        Me.txtDezSorteio.Size = New System.Drawing.Size(68, 23)
        Me.txtDezSorteio.TabIndex = 117
        '
        'FormCadastroResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 378)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.picLoteria)
        Me.Controls.Add(Me.chkAtivo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDezTotais)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ddlLoteria)
        Me.Controls.Add(Me.txtTotalDezenas)
        Me.Controls.Add(Me.txtPremMax)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotalConcursos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDezFinal)
        Me.Controls.Add(Me.txtPremMin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDezInicial)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDezSorteio)
        Me.Name = "FormCadastroResultados"
        Me.Text = "FormCadastroResultados"
        CType(Me.picLoteria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents btnPesquisar As System.Windows.Forms.Button
    Friend WithEvents picLoteria As System.Windows.Forms.PictureBox
    Friend WithEvents chkAtivo As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDezTotais As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ddlLoteria As System.Windows.Forms.ComboBox
    Friend WithEvents txtTotalDezenas As System.Windows.Forms.TextBox
    Friend WithEvents txtPremMax As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotalConcursos As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDezFinal As System.Windows.Forms.TextBox
    Friend WithEvents txtPremMin As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDezInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDezSorteio As System.Windows.Forms.TextBox
End Class
