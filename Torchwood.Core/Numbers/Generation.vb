Imports Torchwood.Struct.Combinacoes
Imports Torchwood.Core.Business
Imports Consumer.Math.Stats
Namespace Business
    Public Class Generation
        Implements IGeneration

        <Obsolete("Ver Classes do Namespace Busines.Combinacoes", True)> _
        Public Function ObterLotoFacil() As IList(Of LotoFacil) Implements IGeneration.ObterLotoFacil
            'será gerado as sequencias. 
            'depois de gerado, analisado uma a uma. e eliminadas as dezenas que estão impossiveis

            Dim oList As IList(Of LotoFacil)
            Dim oReturn As IList(Of LotoFacil)
            Dim oNumbers As INumbers
            Dim oSequence As ISequences
            Dim listWork As IList(Of Integer)
            Dim listSeq As IList(Of Integer)
            Dim oRules As Regras.LotoFacil


            'criando as instancias
            oNumbers = New Numbers()
            oSequence = New Sequences()
            oRules = New Regras.LotoFacil()
            'combina as dezenas para tratar
            oList = oNumbers.CombineLotoFacil

            oReturn = New List(Of LotoFacil)
            For Each oLotoFacil As LotoFacil In oList
                'cria a lista e joga as dezenas dentro
                listWork = New List(Of Integer)
                listWork = oSequence.Convert(oLotoFacil)

                'obtem as sequencias
                listSeq = oSequence.GetSequences(listWork)
                'analisa as regras, se alguma é true, nao segue a sequencia. pois torna-se desnecessário
                If Not oRules.AnalisaRepeticoes555(listSeq) Then
                    If Not oRules.AnalisaRepeticoes77(listSeq) Then
                        If Not oRules.AnalisaRepeticoes86(listSeq) Then
                            If Not oRules.AnalisaRepeticoesMaiorQue9(listSeq) Then
                                If Not oRules.AnalisaRepeticoes555(listSeq) Then
                                    oReturn.Add(oLotoFacil)
                                End If
                            End If
                        End If
                    End If
                End If
            Next

            Return oReturn

        End Function

    End Class
End Namespace
