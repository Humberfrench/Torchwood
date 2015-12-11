<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.XpWatermark1 = New Steepvalley.Windows.Forms.XPWatermark()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(187, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'XpWatermark1
        '
        Me.XpWatermark1.BackColor = System.Drawing.Color.Transparent
        Me.XpWatermark1.Gamma = 1.0!
        Me.XpWatermark1.Location = New System.Drawing.Point(236, 50)
        Me.XpWatermark1.Name = "XpWatermark1"
        Me.XpWatermark1.Opacity = 0.2!
        Me.XpWatermark1.Size = New System.Drawing.Size(100, 100)
        Me.XpWatermark1.TabIndex = 1
        Me.XpWatermark1.TransparentColor.High = System.Drawing.Color.Empty
        Me.XpWatermark1.TransparentColor.Low = System.Drawing.Color.Empty
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 211)
        Me.Controls.Add(Me.XpWatermark1)
        Me.Controls.Add(Me.ComboBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents XpWatermark1 As Steepvalley.Windows.Forms.XPWatermark
End Class
