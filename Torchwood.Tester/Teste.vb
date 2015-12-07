Public Class Teste

    Private Sub Teste_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim o As New Consumer.Math.Stats.Combinatory
        'Dim oArray As ArrayList = o.CombinarValores("12;25;26;27;35;39;45;48;57;59", 6)

        'Dim oTorch As New Torchwood.Core.Business.Numbers
        'Dim ret As IList(Of Torchwood.Struct.Combinacoes.LotoFacil)

        'ret = oTorch.CombineLotoFacil

        'Dim oProcessa As Torchwood.Core.IRepetitions

        'oProcessa = New Torchwood.Core.Business.Repetitions("torchConnDev")
        'oProcessa.ProcessaLotoFacil()
        'oProcessa.ProcessaMegaSena()

        Dim oGerador As New Torchwood.Core.Business.Generation
        Dim oSequencias As IList(Of Torchwood.Struct.Combinacoes.LotoFacil)

        oSequencias = oGerador.ObterLotoFacil

    End Sub
End Class