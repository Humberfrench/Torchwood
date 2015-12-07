<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImporter
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
        Me.pbAndamento = New System.Windows.Forms.ProgressBar
        Me.lvResults = New System.Windows.Forms.ListView
        Me.btnImportar = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'pbAndamento
        '
        Me.pbAndamento.Location = New System.Drawing.Point(23, 115)
        Me.pbAndamento.Maximum = 6
        Me.pbAndamento.Name = "pbAndamento"
        Me.pbAndamento.Size = New System.Drawing.Size(316, 23)
        Me.pbAndamento.TabIndex = 0
        '
        'lvResults
        '
        Me.lvResults.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvResults.Location = New System.Drawing.Point(23, 12)
        Me.lvResults.Name = "lvResults"
        Me.lvResults.Size = New System.Drawing.Size(228, 97)
        Me.lvResults.TabIndex = 1
        Me.lvResults.UseCompatibleStateImageBehavior = False
        Me.lvResults.View = System.Windows.Forms.View.Details
        '
        'btnImportar
        '
        Me.btnImportar.Location = New System.Drawing.Point(264, 12)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(75, 23)
        Me.btnImportar.TabIndex = 2
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(264, 41)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Loteria"
        Me.ColumnHeader1.Width = 137
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Concursos"
        Me.ColumnHeader2.Width = 67
        '
        'FrmImporter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 154)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.lvResults)
        Me.Controls.Add(Me.pbAndamento)
        Me.Name = "FrmImporter"
        Me.Text = "Torchwood Importer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbAndamento As System.Windows.Forms.ProgressBar
    Friend WithEvents lvResults As System.Windows.Forms.ListView
    Friend WithEvents btnImportar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader

End Class
