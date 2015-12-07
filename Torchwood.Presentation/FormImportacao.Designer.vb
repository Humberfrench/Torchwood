<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormImportacao
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFilename = New System.Windows.Forms.TextBox()
        Me.lvResults = New System.Windows.Forms.ListView()
        Me.colLoteria = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colConcursos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chkMegaSena = New System.Windows.Forms.CheckBox()
        Me.chkDuplaSena1 = New System.Windows.Forms.CheckBox()
        Me.chkTimeMania = New System.Windows.Forms.CheckBox()
        Me.chkDuplaSena2 = New System.Windows.Forms.CheckBox()
        Me.chkLotoFacil = New System.Windows.Forms.CheckBox()
        Me.chkLotoMania = New System.Windows.Forms.CheckBox()
        Me.chkQuina = New System.Windows.Forms.CheckBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnLocate = New System.Windows.Forms.Button()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.picLoteria = New System.Windows.Forms.PictureBox()
        Me.pbAndamento = New System.Windows.Forms.ProgressBar()
        Me.ofdImportar = New System.Windows.Forms.OpenFileDialog()
        CType(Me.picLoteria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 15)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Selecione Caminho do Arquivo"
        '
        'txtFilename
        '
        Me.txtFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilename.Location = New System.Drawing.Point(191, 16)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.Size = New System.Drawing.Size(321, 20)
        Me.txtFilename.TabIndex = 35
        '
        'lvResults
        '
        Me.lvResults.BackColor = System.Drawing.SystemColors.Info
        Me.lvResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvResults.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colLoteria, Me.colConcursos})
        Me.lvResults.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvResults.Location = New System.Drawing.Point(15, 98)
        Me.lvResults.Name = "lvResults"
        Me.lvResults.Size = New System.Drawing.Size(237, 109)
        Me.lvResults.TabIndex = 34
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
        'chkMegaSena
        '
        Me.chkMegaSena.BackColor = System.Drawing.Color.Transparent
        Me.chkMegaSena.Checked = True
        Me.chkMegaSena.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMegaSena.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkMegaSena.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMegaSena.ForeColor = System.Drawing.Color.Black
        Me.chkMegaSena.Location = New System.Drawing.Point(15, 52)
        Me.chkMegaSena.Name = "chkMegaSena"
        Me.chkMegaSena.Size = New System.Drawing.Size(90, 17)
        Me.chkMegaSena.TabIndex = 41
        Me.chkMegaSena.Text = "Mega-Sena"
        Me.chkMegaSena.UseVisualStyleBackColor = False
        '
        'chkDuplaSena1
        '
        Me.chkDuplaSena1.BackColor = System.Drawing.Color.Transparent
        Me.chkDuplaSena1.Checked = True
        Me.chkDuplaSena1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDuplaSena1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkDuplaSena1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDuplaSena1.ForeColor = System.Drawing.Color.Black
        Me.chkDuplaSena1.Location = New System.Drawing.Point(111, 52)
        Me.chkDuplaSena1.Name = "chkDuplaSena1"
        Me.chkDuplaSena1.Size = New System.Drawing.Size(90, 17)
        Me.chkDuplaSena1.TabIndex = 42
        Me.chkDuplaSena1.Text = "Dupla-Sena 1"
        Me.chkDuplaSena1.UseVisualStyleBackColor = False
        '
        'chkTimeMania
        '
        Me.chkTimeMania.BackColor = System.Drawing.Color.Transparent
        Me.chkTimeMania.Checked = True
        Me.chkTimeMania.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTimeMania.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkTimeMania.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTimeMania.ForeColor = System.Drawing.Color.Black
        Me.chkTimeMania.Location = New System.Drawing.Point(207, 75)
        Me.chkTimeMania.Name = "chkTimeMania"
        Me.chkTimeMania.Size = New System.Drawing.Size(90, 17)
        Me.chkTimeMania.TabIndex = 47
        Me.chkTimeMania.Text = "Time-Mania"
        Me.chkTimeMania.UseVisualStyleBackColor = False
        '
        'chkDuplaSena2
        '
        Me.chkDuplaSena2.BackColor = System.Drawing.Color.Transparent
        Me.chkDuplaSena2.Checked = True
        Me.chkDuplaSena2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDuplaSena2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkDuplaSena2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDuplaSena2.ForeColor = System.Drawing.Color.Black
        Me.chkDuplaSena2.Location = New System.Drawing.Point(207, 52)
        Me.chkDuplaSena2.Name = "chkDuplaSena2"
        Me.chkDuplaSena2.Size = New System.Drawing.Size(90, 17)
        Me.chkDuplaSena2.TabIndex = 43
        Me.chkDuplaSena2.Text = "Dupla-Sena 2"
        Me.chkDuplaSena2.UseVisualStyleBackColor = False
        '
        'chkLotoFacil
        '
        Me.chkLotoFacil.BackColor = System.Drawing.Color.Transparent
        Me.chkLotoFacil.Checked = True
        Me.chkLotoFacil.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLotoFacil.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkLotoFacil.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLotoFacil.ForeColor = System.Drawing.Color.Black
        Me.chkLotoFacil.Location = New System.Drawing.Point(15, 75)
        Me.chkLotoFacil.Name = "chkLotoFacil"
        Me.chkLotoFacil.Size = New System.Drawing.Size(90, 17)
        Me.chkLotoFacil.TabIndex = 45
        Me.chkLotoFacil.Text = "Loto-Fácil"
        Me.chkLotoFacil.UseVisualStyleBackColor = False
        '
        'chkLotoMania
        '
        Me.chkLotoMania.BackColor = System.Drawing.Color.Transparent
        Me.chkLotoMania.Checked = True
        Me.chkLotoMania.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLotoMania.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkLotoMania.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLotoMania.ForeColor = System.Drawing.Color.Black
        Me.chkLotoMania.Location = New System.Drawing.Point(303, 52)
        Me.chkLotoMania.Name = "chkLotoMania"
        Me.chkLotoMania.Size = New System.Drawing.Size(90, 17)
        Me.chkLotoMania.TabIndex = 44
        Me.chkLotoMania.Text = "Loto-Mania"
        Me.chkLotoMania.UseVisualStyleBackColor = False
        '
        'chkQuina
        '
        Me.chkQuina.BackColor = System.Drawing.Color.Transparent
        Me.chkQuina.Checked = True
        Me.chkQuina.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkQuina.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkQuina.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkQuina.ForeColor = System.Drawing.Color.Black
        Me.chkQuina.Location = New System.Drawing.Point(111, 75)
        Me.chkQuina.Name = "chkQuina"
        Me.chkQuina.Size = New System.Drawing.Size(90, 17)
        Me.chkQuina.TabIndex = 46
        Me.chkQuina.Text = "Quina"
        Me.chkQuina.UseVisualStyleBackColor = False
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(518, 94)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(146, 35)
        Me.btnFechar.TabIndex = 104
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnLocate
        '
        Me.btnLocate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLocate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLocate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocate.Location = New System.Drawing.Point(518, 12)
        Me.btnLocate.Name = "btnLocate"
        Me.btnLocate.Size = New System.Drawing.Size(146, 35)
        Me.btnLocate.TabIndex = 103
        Me.btnLocate.Text = "Arquivo"
        Me.btnLocate.UseVisualStyleBackColor = False
        '
        'btnImportar
        '
        Me.btnImportar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImportar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportar.Location = New System.Drawing.Point(518, 53)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(146, 35)
        Me.btnImportar.TabIndex = 105
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.UseVisualStyleBackColor = False
        '
        'picLoteria
        '
        Me.picLoteria.Location = New System.Drawing.Point(258, 98)
        Me.picLoteria.Name = "picLoteria"
        Me.picLoteria.Size = New System.Drawing.Size(254, 109)
        Me.picLoteria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picLoteria.TabIndex = 106
        Me.picLoteria.TabStop = False
        '
        'pbAndamento
        '
        Me.pbAndamento.Location = New System.Drawing.Point(15, 213)
        Me.pbAndamento.Maximum = 7
        Me.pbAndamento.Name = "pbAndamento"
        Me.pbAndamento.Size = New System.Drawing.Size(649, 23)
        Me.pbAndamento.TabIndex = 107
        Me.pbAndamento.Visible = False
        '
        'ofdImportar
        '
        Me.ofdImportar.Filter = "Arquivos Excel 2007 | *.xlsx|Arquivos Excel | *.xls"
        Me.ofdImportar.InitialDirectory = "c:\"
        '
        'FormImportacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 243)
        Me.Controls.Add(Me.pbAndamento)
        Me.Controls.Add(Me.picLoteria)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnLocate)
        Me.Controls.Add(Me.chkMegaSena)
        Me.Controls.Add(Me.chkDuplaSena1)
        Me.Controls.Add(Me.chkTimeMania)
        Me.Controls.Add(Me.chkDuplaSena2)
        Me.Controls.Add(Me.chkLotoFacil)
        Me.Controls.Add(Me.chkLotoMania)
        Me.Controls.Add(Me.chkQuina)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFilename)
        Me.Controls.Add(Me.lvResults)
        Me.Name = "FormImportacao"
        Me.Text = "Importacao"
        CType(Me.picLoteria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFilename As System.Windows.Forms.TextBox
    Friend WithEvents lvResults As System.Windows.Forms.ListView
    Friend WithEvents colLoteria As System.Windows.Forms.ColumnHeader
    Friend WithEvents colConcursos As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkMegaSena As System.Windows.Forms.CheckBox
    Friend WithEvents chkDuplaSena1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkTimeMania As System.Windows.Forms.CheckBox
    Friend WithEvents chkDuplaSena2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkLotoFacil As System.Windows.Forms.CheckBox
    Friend WithEvents chkLotoMania As System.Windows.Forms.CheckBox
    Friend WithEvents chkQuina As System.Windows.Forms.CheckBox
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents btnLocate As System.Windows.Forms.Button
    Friend WithEvents btnImportar As System.Windows.Forms.Button
    Friend WithEvents picLoteria As System.Windows.Forms.PictureBox
    Friend WithEvents pbAndamento As System.Windows.Forms.ProgressBar
    Friend WithEvents ofdImportar As System.Windows.Forms.OpenFileDialog
End Class
