<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGetResults
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.ddlLoterias = New System.Windows.Forms.ComboBox
        Me.lvResults = New System.Windows.Forms.ListView
        Me.btnConsulta = New Flowsight.Windows.Forms.CrystalButton
        Me.XpGradientPanel1 = New Steepvalley.Windows.Forms.Containers.XPGradientPanel
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblDezSorteio = New System.Windows.Forms.Label
        Me.lblDezenaMaxima = New System.Windows.Forms.Label
        Me.lblOccurMinima = New System.Windows.Forms.Label
        Me.lblDezMinima = New System.Windows.Forms.Label
        Me.lblTotalDezenas = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnExport = New Flowsight.Windows.Forms.CrystalButton
        Me.XpGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Núm. Total de Dezenas:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ddlLoterias
        '
        Me.ddlLoterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlLoterias.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ddlLoterias.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlLoterias.FormattingEnabled = True
        Me.ddlLoterias.Location = New System.Drawing.Point(138, 9)
        Me.ddlLoterias.Name = "ddlLoterias"
        Me.ddlLoterias.Size = New System.Drawing.Size(194, 22)
        Me.ddlLoterias.TabIndex = 1
        '
        'lvResults
        '
        Me.lvResults.BackColor = System.Drawing.SystemColors.Info
        Me.lvResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvResults.FullRowSelect = True
        Me.lvResults.Location = New System.Drawing.Point(15, 112)
        Me.lvResults.Name = "lvResults"
        Me.lvResults.Size = New System.Drawing.Size(596, 308)
        Me.lvResults.TabIndex = 2
        Me.lvResults.UseCompatibleStateImageBehavior = False
        Me.lvResults.View = System.Windows.Forms.View.Details
        '
        'btnConsulta
        '
        Me.btnConsulta.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnConsulta.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnConsulta.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsulta.Image = Nothing
        Me.btnConsulta.Location = New System.Drawing.Point(526, 40)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(85, 24)
        Me.btnConsulta.TabIndex = 5
        Me.btnConsulta.Text = "Consultar"
        '
        'XpGradientPanel1
        '
        Me.XpGradientPanel1.Controls.Add(Me.ComboBox1)
        Me.XpGradientPanel1.Controls.Add(Me.lvResults)
        Me.XpGradientPanel1.Controls.Add(Me.Label5)
        Me.XpGradientPanel1.Controls.Add(Me.Label2)
        Me.XpGradientPanel1.Controls.Add(Me.lblDezSorteio)
        Me.XpGradientPanel1.Controls.Add(Me.lblDezenaMaxima)
        Me.XpGradientPanel1.Controls.Add(Me.lblOccurMinima)
        Me.XpGradientPanel1.Controls.Add(Me.lblDezMinima)
        Me.XpGradientPanel1.Controls.Add(Me.lblTotalDezenas)
        Me.XpGradientPanel1.Controls.Add(Me.Label8)
        Me.XpGradientPanel1.Controls.Add(Me.Label6)
        Me.XpGradientPanel1.Controls.Add(Me.Label3)
        Me.XpGradientPanel1.Controls.Add(Me.Label4)
        Me.XpGradientPanel1.Controls.Add(Me.Label1)
        Me.XpGradientPanel1.Controls.Add(Me.btnExport)
        Me.XpGradientPanel1.Controls.Add(Me.btnConsulta)
        Me.XpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XpGradientPanel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XpGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.XpGradientPanel1.Name = "XpGradientPanel1"
        Me.XpGradientPanel1.Size = New System.Drawing.Size(623, 432)
        Me.XpGradientPanel1.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ASC", "DESC"})
        Me.ComboBox1.Location = New System.Drawing.Point(485, 9)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(127, 22)
        Me.ComboBox1.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(338, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Ordenar Dezenas:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Selecione Loteria:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDezSorteio
        '
        Me.lblDezSorteio.BackColor = System.Drawing.Color.White
        Me.lblDezSorteio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDezSorteio.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDezSorteio.Location = New System.Drawing.Point(222, 75)
        Me.lblDezSorteio.Name = "lblDezSorteio"
        Me.lblDezSorteio.Size = New System.Drawing.Size(36, 22)
        Me.lblDezSorteio.TabIndex = 0
        Me.lblDezSorteio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDezenaMaxima
        '
        Me.lblDezenaMaxima.BackColor = System.Drawing.Color.White
        Me.lblDezenaMaxima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDezenaMaxima.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDezenaMaxima.Location = New System.Drawing.Point(485, 42)
        Me.lblDezenaMaxima.Name = "lblDezenaMaxima"
        Me.lblDezenaMaxima.Size = New System.Drawing.Size(36, 22)
        Me.lblDezenaMaxima.TabIndex = 0
        Me.lblDezenaMaxima.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOccurMinima
        '
        Me.lblOccurMinima.BackColor = System.Drawing.Color.White
        Me.lblOccurMinima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOccurMinima.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOccurMinima.Location = New System.Drawing.Point(485, 75)
        Me.lblOccurMinima.Name = "lblOccurMinima"
        Me.lblOccurMinima.Size = New System.Drawing.Size(36, 22)
        Me.lblOccurMinima.TabIndex = 0
        Me.lblOccurMinima.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDezMinima
        '
        Me.lblDezMinima.BackColor = System.Drawing.Color.White
        Me.lblDezMinima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDezMinima.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDezMinima.Location = New System.Drawing.Point(325, 42)
        Me.lblDezMinima.Name = "lblDezMinima"
        Me.lblDezMinima.Size = New System.Drawing.Size(36, 22)
        Me.lblDezMinima.TabIndex = 0
        Me.lblDezMinima.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalDezenas
        '
        Me.lblTotalDezenas.BackColor = System.Drawing.Color.White
        Me.lblTotalDezenas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDezenas.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDezenas.Location = New System.Drawing.Point(180, 42)
        Me.lblTotalDezenas.Name = "lblTotalDezenas"
        Me.lblTotalDezenas.Size = New System.Drawing.Size(36, 22)
        Me.lblTotalDezenas.TabIndex = 0
        Me.lblTotalDezenas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(204, 22)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Quantidade Dezenas - Sorteio:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(367, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Dezena Máxima:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(264, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Quantidade Ocorrência Mínima:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(222, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Dez. Mínima:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnExport.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnExport.Enabled = False
        Me.btnExport.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Image = Nothing
        Me.btnExport.Location = New System.Drawing.Point(527, 73)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(85, 24)
        Me.btnExport.TabIndex = 5
        Me.btnExport.Text = "Exportar"
        '
        'frmGetResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 432)
        Me.Controls.Add(Me.ddlLoterias)
        Me.Controls.Add(Me.XpGradientPanel1)
        Me.Name = "frmGetResults"
        Me.Text = "Obtenção de Resultados"
        Me.XpGradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ddlLoterias As System.Windows.Forms.ComboBox
    Friend WithEvents lvResults As System.Windows.Forms.ListView
    Friend WithEvents btnConsulta As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents XpGradientPanel1 As Steepvalley.Windows.Forms.Containers.XPGradientPanel
    Friend WithEvents btnExport As Flowsight.Windows.Forms.CrystalButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalDezenas As System.Windows.Forms.Label
    Friend WithEvents lblDezSorteio As System.Windows.Forms.Label
    Friend WithEvents lblDezenaMaxima As System.Windows.Forms.Label
    Friend WithEvents lblDezMinima As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblOccurMinima As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
