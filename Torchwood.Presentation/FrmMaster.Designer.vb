<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMaster
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
        Me.XpGradientPanel1 = New Steepvalley.Windows.Forms.Containers.XPGradientPanel
        Me.XpCaptionPane2 = New Steepvalley.Windows.Forms.XPCaptionPane
        Me.XpGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'XpGradientPanel1
        '
        Me.XpGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.XpGradientPanel1.Controls.Add(Me.XpCaptionPane2)
        Me.XpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XpGradientPanel1.EndColor = System.Drawing.Color.LightSteelBlue
        Me.XpGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.XpGradientPanel1.Name = "XpGradientPanel1"
        Me.XpGradientPanel1.Size = New System.Drawing.Size(435, 262)
        Me.XpGradientPanel1.StartColor = System.Drawing.Color.Lavender
        Me.XpGradientPanel1.TabIndex = 2
        '
        'XpCaptionPane2
        '
        Me.XpCaptionPane2.BackColor = System.Drawing.Color.Lavender
        Me.XpCaptionPane2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.XpCaptionPane2.CaptionControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.XpCaptionPane2.CaptionControl.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XpCaptionPane2.CaptionControl.Location = New System.Drawing.Point(1, 1)
        Me.XpCaptionPane2.CaptionControl.Name = "caption"
        Me.XpCaptionPane2.CaptionControl.Size = New System.Drawing.Size(335, 20)
        Me.XpCaptionPane2.CaptionControl.TabIndex = 0
        Me.XpCaptionPane2.CaptionControl.Text = "Loteria"
        Me.XpCaptionPane2.CaptionText = "Loteria"
        Me.XpCaptionPane2.Location = New System.Drawing.Point(12, 24)
        Me.XpCaptionPane2.Name = "XpCaptionPane2"
        Me.XpCaptionPane2.Padding = New System.Windows.Forms.Padding(1)
        Me.XpCaptionPane2.Size = New System.Drawing.Size(339, 125)
        Me.XpCaptionPane2.TabIndex = 49
        '
        'FrmMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 262)
        Me.Controls.Add(Me.XpGradientPanel1)
        Me.Name = "FrmMaster"
        Me.XpGradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XpGradientPanel1 As Steepvalley.Windows.Forms.Containers.XPGradientPanel
    Friend WithEvents XpCaptionPane2 As Steepvalley.Windows.Forms.XPCaptionPane

End Class
