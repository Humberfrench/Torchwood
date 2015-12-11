Imports System.Data
Imports MaterialSkin

Public Class Form1
    Inherits MaterialSkin.Controls.MaterialForm


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

        'Dim oTransCmd As TransactCommand
        ''Dim dtDados As DataTable

        'oTransCmd = New TransactCommand("TesteBeto")
        'oTransCmd.CommandText = "insert into tb_cidade (nm_cidade, sg_uf) VALUES ('Betinhopolis 3','SP')"
        'oTransCmd.CommandType = CommandType.Text

        'oTransCmd.BeginTransaction()

        'oTransCmd.Execute()

        'oTransCmd.RollBackTransaction()


        'oTransCmd.Dispose()
        'oTransCmd = Nothing

        ''For Each dr As DataRow In dtDados.Rows
        ''Me.ComboBox1.Items.Add(dr("nm_cidade").ToString)
        ''Next

        ' MaterialSkin.

    End Sub

End Class
