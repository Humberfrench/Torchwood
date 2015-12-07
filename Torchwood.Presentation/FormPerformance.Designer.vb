<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPerformance
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
        Dim colIDFim As System.Windows.Forms.ColumnHeader
        Dim colDezena As System.Windows.Forms.ColumnHeader
        Me.colQtdeDez = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPercDez = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPercDezTT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMedArtmSort = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTTConc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTTDez = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPercMedFx = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPercMedFxRnd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colISDezFx = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colISDezFxRnd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colQtDezMedFx = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colQtDezFxRnd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ddlLoteria = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQtdeFaixas = New System.Windows.Forms.TextBox()
        Me.lvLoterias = New System.Windows.Forms.ListView()
        Me.colIDIni = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ddlFaixa = New System.Windows.Forms.ComboBox()
        colIDFim = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        colDezena = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'colIDFim
        '
        colIDFim.Text = "Fx.Fim"
        '
        'colDezena
        '
        colDezena.Text = "Dezena"
        colDezena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colQtdeDez
        '
        Me.colQtdeDez.Text = "Qt. Dez."
        Me.colQtdeDez.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colPercDez
        '
        Me.colPercDez.Text = "% Max."
        Me.colPercDez.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colPercDez.Width = 80
        '
        'colPercDezTT
        '
        Me.colPercDezTT.Text = "% Total"
        Me.colPercDezTT.Width = 80
        '
        'colMedArtmSort
        '
        Me.colMedArtmSort.Text = "Média"
        Me.colMedArtmSort.Width = 80
        '
        'colTTConc
        '
        Me.colTTConc.Text = "TT. Conc."
        Me.colTTConc.Width = 70
        '
        'colTTDez
        '
        Me.colTTDez.Text = "TT. Dez."
        Me.colTTDez.Width = 70
        '
        'colPercMedFx
        '
        Me.colPercMedFx.Text = "% Med Fx."
        Me.colPercMedFx.Width = 80
        '
        'colPercMedFxRnd
        '
        Me.colPercMedFxRnd.Text = "% Med Ar."
        Me.colPercMedFxRnd.Width = 80
        '
        'colISDezFx
        '
        Me.colISDezFx.Text = "Sup. Fx.?"
        '
        'colISDezFxRnd
        '
        Me.colISDezFxRnd.Text = "Sup. Fx.?"
        '
        'colQtDezMedFx
        '
        Me.colQtDezMedFx.Text = "Qt. Sup."
        Me.colQtDezMedFx.Width = 70
        '
        'colQtDezFxRnd
        '
        Me.colQtDezFxRnd.Text = "Qt. Sup. A"
        Me.colQtDezFxRnd.Width = 70
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(935, 13)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(146, 35)
        Me.btnFechar.TabIndex = 108
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnPesquisar
        '
        Me.btnPesquisar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPesquisar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesquisar.Location = New System.Drawing.Point(783, 13)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(146, 35)
        Me.btnPesquisar.TabIndex = 107
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
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
        Me.ddlLoteria.Location = New System.Drawing.Point(117, 20)
        Me.ddlLoteria.Name = "ddlLoteria"
        Me.ddlLoteria.Size = New System.Drawing.Size(221, 23)
        Me.ddlLoteria.Sorted = True
        Me.ddlLoteria.TabIndex = 105
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Faixas - Qtde:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQtdeFaixas
        '
        Me.txtQtdeFaixas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQtdeFaixas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdeFaixas.Location = New System.Drawing.Point(450, 21)
        Me.txtQtdeFaixas.MaxLength = 3
        Me.txtQtdeFaixas.Name = "txtQtdeFaixas"
        Me.txtQtdeFaixas.Size = New System.Drawing.Size(47, 23)
        Me.txtQtdeFaixas.TabIndex = 106
        Me.txtQtdeFaixas.Text = "50"
        '
        'lvLoterias
        '
        Me.lvLoterias.BackColor = System.Drawing.SystemColors.Info
        Me.lvLoterias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvLoterias.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colIDIni, colIDFim, colDezena, Me.colQtdeDez, Me.colPercDez, Me.colPercDezTT, Me.colMedArtmSort, Me.colTTConc, Me.colTTDez, Me.colPercMedFx, Me.colPercMedFxRnd, Me.colISDezFx, Me.colISDezFxRnd, Me.colQtDezMedFx, Me.colQtDezFxRnd})
        Me.lvLoterias.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLoterias.FullRowSelect = True
        Me.lvLoterias.GridLines = True
        Me.lvLoterias.Location = New System.Drawing.Point(14, 54)
        Me.lvLoterias.Name = "lvLoterias"
        Me.lvLoterias.Size = New System.Drawing.Size(1067, 594)
        Me.lvLoterias.TabIndex = 110
        Me.lvLoterias.UseCompatibleStateImageBehavior = False
        Me.lvLoterias.View = System.Windows.Forms.View.Details
        '
        'colIDIni
        '
        Me.colIDIni.Text = "Fx.Ini"
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(503, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 15)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Faixas:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ddlFaixa
        '
        Me.ddlFaixa.BackColor = System.Drawing.SystemColors.Control
        Me.ddlFaixa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlFaixa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ddlFaixa.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlFaixa.FormattingEnabled = True
        Me.ddlFaixa.Location = New System.Drawing.Point(609, 20)
        Me.ddlFaixa.Name = "ddlFaixa"
        Me.ddlFaixa.Size = New System.Drawing.Size(168, 23)
        Me.ddlFaixa.TabIndex = 112
        '
        'FormPerformance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 660)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ddlFaixa)
        Me.Controls.Add(Me.lvLoterias)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ddlLoteria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtQtdeFaixas)
        Me.Name = "FormPerformance"
        Me.Text = "FormPerformance"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents btnPesquisar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ddlLoteria As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQtdeFaixas As System.Windows.Forms.TextBox
    Friend WithEvents lvLoterias As System.Windows.Forms.ListView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ddlFaixa As System.Windows.Forms.ComboBox
    Friend WithEvents colQtdeDez As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPercDez As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPercDezTT As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMedArtmSort As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTTConc As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTTDez As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPercMedFx As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPercMedFxRnd As System.Windows.Forms.ColumnHeader
    Friend WithEvents colISDezFx As System.Windows.Forms.ColumnHeader
    Friend WithEvents colISDezFxRnd As System.Windows.Forms.ColumnHeader
    Friend WithEvents colQtDezMedFx As System.Windows.Forms.ColumnHeader
    Friend WithEvents colQtDezFxRnd As System.Windows.Forms.ColumnHeader
    Friend WithEvents colIDIni As System.Windows.Forms.ColumnHeader
End Class
