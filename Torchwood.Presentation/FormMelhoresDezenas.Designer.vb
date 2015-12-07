<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMelhoresDezenas
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
        Dim colDezena As System.Windows.Forms.ColumnHeader
        Dim colQtde As System.Windows.Forms.ColumnHeader
        Dim colPcTotal As System.Windows.Forms.ColumnHeader
        Dim colPcDezena As System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ddlLoteria = New System.Windows.Forms.ComboBox()
        Me.txtTotalDezenas = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPremMax = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalConcursos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDezFinal = New System.Windows.Forms.TextBox()
        Me.ddlTipo = New System.Windows.Forms.ComboBox()
        Me.txtPremMin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDezInicial = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDezSorteio = New System.Windows.Forms.TextBox()
        Me.txtDezTotais = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkAtivo = New System.Windows.Forms.CheckBox()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.lvLoterias = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.picLoteria = New System.Windows.Forms.PictureBox()
        colDezena = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        colQtde = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        colPcTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        colPcDezena = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.picLoteria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colDezena
        '
        colDezena.Text = "Dezena"
        colDezena.Width = 64
        '
        'colQtde
        '
        colQtde.Text = "Quantitdade"
        colQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        colQtde.Width = 99
        '
        'colPcTotal
        '
        colPcTotal.Text = "% do Total"
        colPcTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        colPcTotal.Width = 104
        '
        'colPcDezena
        '
        colPcDezena.Text = "% Concursos"
        colPcDezena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        colPcDezena.Width = 101
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 15)
        Me.Label1.TabIndex = 55
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
        Me.ddlLoteria.Location = New System.Drawing.Point(129, 14)
        Me.ddlLoteria.Name = "ddlLoteria"
        Me.ddlLoteria.Size = New System.Drawing.Size(256, 23)
        Me.ddlLoteria.Sorted = True
        Me.ddlLoteria.TabIndex = 63
        '
        'txtTotalDezenas
        '
        Me.txtTotalDezenas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalDezenas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDezenas.Location = New System.Drawing.Point(328, 152)
        Me.txtTotalDezenas.Name = "txtTotalDezenas"
        Me.txtTotalDezenas.ReadOnly = True
        Me.txtTotalDezenas.Size = New System.Drawing.Size(58, 23)
        Me.txtTotalDezenas.TabIndex = 66
        '
        'Label8
        '
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(404, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 15)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Tipo:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPremMax
        '
        Me.txtPremMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPremMax.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPremMax.Location = New System.Drawing.Point(328, 82)
        Me.txtPremMax.Name = "txtPremMax"
        Me.txtPremMax.ReadOnly = True
        Me.txtPremMax.Size = New System.Drawing.Size(58, 23)
        Me.txtPremMax.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 15)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Dez. Sorteio:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalConcursos
        '
        Me.txtTotalConcursos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalConcursos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalConcursos.Location = New System.Drawing.Point(129, 152)
        Me.txtTotalConcursos.Name = "txtTotalConcursos"
        Me.txtTotalConcursos.ReadOnly = True
        Me.txtTotalConcursos.Size = New System.Drawing.Size(68, 23)
        Me.txtTotalConcursos.TabIndex = 64
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 15)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Dez. Inicial:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDezFinal
        '
        Me.txtDezFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDezFinal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDezFinal.Location = New System.Drawing.Point(328, 119)
        Me.txtDezFinal.Name = "txtDezFinal"
        Me.txtDezFinal.ReadOnly = True
        Me.txtDezFinal.Size = New System.Drawing.Size(58, 23)
        Me.txtDezFinal.TabIndex = 65
        '
        'ddlTipo
        '
        Me.ddlTipo.BackColor = System.Drawing.SystemColors.Control
        Me.ddlTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ddlTipo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlTipo.FormattingEnabled = True
        Me.ddlTipo.Location = New System.Drawing.Point(526, 15)
        Me.ddlTipo.Name = "ddlTipo"
        Me.ddlTipo.Size = New System.Drawing.Size(256, 23)
        Me.ddlTipo.Sorted = True
        Me.ddlTipo.TabIndex = 62
        '
        'txtPremMin
        '
        Me.txtPremMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPremMin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPremMin.Location = New System.Drawing.Point(129, 82)
        Me.txtPremMin.Name = "txtPremMin"
        Me.txtPremMin.ReadOnly = True
        Me.txtPremMin.Size = New System.Drawing.Size(68, 23)
        Me.txtPremMin.TabIndex = 70
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(205, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 15)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Dez. Totais:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 15)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Prem. Mínima:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDezInicial
        '
        Me.txtDezInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDezInicial.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDezInicial.Location = New System.Drawing.Point(129, 119)
        Me.txtDezInicial.Name = "txtDezInicial"
        Me.txtDezInicial.ReadOnly = True
        Me.txtDezInicial.Size = New System.Drawing.Size(68, 23)
        Me.txtDezInicial.TabIndex = 68
        '
        'Label9
        '
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 15)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Tt Concursos:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDezSorteio
        '
        Me.txtDezSorteio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDezSorteio.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDezSorteio.Location = New System.Drawing.Point(129, 45)
        Me.txtDezSorteio.Name = "txtDezSorteio"
        Me.txtDezSorteio.ReadOnly = True
        Me.txtDezSorteio.Size = New System.Drawing.Size(68, 23)
        Me.txtDezSorteio.TabIndex = 69
        '
        'txtDezTotais
        '
        Me.txtDezTotais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDezTotais.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDezTotais.Location = New System.Drawing.Point(328, 45)
        Me.txtDezTotais.Name = "txtDezTotais"
        Me.txtDezTotais.ReadOnly = True
        Me.txtDezTotais.Size = New System.Drawing.Size(58, 23)
        Me.txtDezTotais.TabIndex = 71
        '
        'Label10
        '
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(205, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 15)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "TT Dezenas:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(205, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 15)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Dez. Final:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(205, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 15)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Prem. Máxima:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkAtivo
        '
        Me.chkAtivo.AutoSize = True
        Me.chkAtivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkAtivo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAtivo.Location = New System.Drawing.Point(407, 133)
        Me.chkAtivo.Name = "chkAtivo"
        Me.chkAtivo.Size = New System.Drawing.Size(89, 19)
        Me.chkAtivo.TabIndex = 75
        Me.chkAtivo.Text = "Loteria Ativa"
        Me.chkAtivo.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPesquisar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesquisar.Location = New System.Drawing.Point(637, 45)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(146, 35)
        Me.btnPesquisar.TabIndex = 77
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = False
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(637, 91)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(146, 35)
        Me.btnFechar.TabIndex = 78
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'lvLoterias
        '
        Me.lvLoterias.BackColor = System.Drawing.SystemColors.Info
        Me.lvLoterias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvLoterias.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, colDezena, colQtde, colPcTotal, colPcDezena})
        Me.lvLoterias.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLoterias.FullRowSelect = True
        Me.lvLoterias.GridLines = True
        Me.lvLoterias.Location = New System.Drawing.Point(24, 186)
        Me.lvLoterias.Name = "lvLoterias"
        Me.lvLoterias.Size = New System.Drawing.Size(758, 397)
        Me.lvLoterias.TabIndex = 79
        Me.lvLoterias.UseCompatibleStateImageBehavior = False
        Me.lvLoterias.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.Text = "Ordem"
        Me.colID.Width = 66
        '
        'picLoteria
        '
        Me.picLoteria.Location = New System.Drawing.Point(407, 48)
        Me.picLoteria.Name = "picLoteria"
        Me.picLoteria.Size = New System.Drawing.Size(223, 77)
        Me.picLoteria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picLoteria.TabIndex = 76
        Me.picLoteria.TabStop = False
        '
        'FormMelhoresDezenas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(807, 606)
        Me.Controls.Add(Me.lvLoterias)
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
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPremMax)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotalConcursos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDezFinal)
        Me.Controls.Add(Me.ddlTipo)
        Me.Controls.Add(Me.txtPremMin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDezInicial)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDezSorteio)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormMelhoresDezenas"
        Me.Text = "Melhores Dezenas Sorteadas"
        CType(Me.picLoteria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ddlLoteria As System.Windows.Forms.ComboBox
    Friend WithEvents txtTotalDezenas As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPremMax As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotalConcursos As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDezFinal As System.Windows.Forms.TextBox
    Friend WithEvents ddlTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtPremMin As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDezInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDezSorteio As System.Windows.Forms.TextBox
    Friend WithEvents txtDezTotais As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents picLoteria As System.Windows.Forms.PictureBox
    Friend WithEvents chkAtivo As System.Windows.Forms.CheckBox
    Friend WithEvents btnPesquisar As System.Windows.Forms.Button
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents lvLoterias As System.Windows.Forms.ListView
    Friend WithEvents colID As System.Windows.Forms.ColumnHeader
End Class
