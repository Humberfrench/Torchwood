Imports Consumer.Data
Imports System.Data

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oTransCmd As TransactCommand
        'Dim dtDados As DataTable

        oTransCmd = New TransactCommand("TesteBeto")
        oTransCmd.CommandText = "insert into tb_cidade (nm_cidade, sg_uf) VALUES ('Betinhopolis 3','SP')"
        oTransCmd.CommandType = CommandType.Text

        oTransCmd.BeginTransaction()

        oTransCmd.Execute()

        oTransCmd.RollBackTransaction()


        oTransCmd.Dispose()
        oTransCmd = Nothing

        'For Each dr As DataRow In dtDados.Rows
        'Me.ComboBox1.Items.Add(dr("nm_cidade").ToString)
        'Next

    End Sub

End Class
