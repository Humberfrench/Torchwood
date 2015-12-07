Imports Torchwood.Core.Business

Friend Interface ISequences

    Function VerificaSequencias(ByRef arrNumber As IList(Of Integer), _
                                ByRef indiceNumber As Integer) As ReturnData

    Function GetSequences(ByVal lstSequencia As IList(Of Integer)) As IList(Of Integer)

    Function VerificaSequenciasNbyN(ByRef arrNumber As IList(Of Integer), _
                                    ByRef indiceNumber As Integer, _
                                    ByRef intIntervalo As Integer) As ReturnData

    Function GetSequencesNbyN(ByVal lstSequencia As IList(Of Integer), _
                              ByVal intIntervalo As Integer) As IList(Of Integer)

    Function Convert(ByVal oSena As Struct.Combinacoes.MegaSena) As IList(Of Integer)
    Function Convert(ByVal oSena As Struct.Combinacoes.DuplaSena) As IList(Of Integer)
    Function Convert(ByVal oLoto As Struct.Combinacoes.LotoFacil) As IList(Of Integer)
    Function Convert(ByVal oLoto As Struct.Combinacoes.LotoMania) As IList(Of Integer)
    Function Convert(ByVal oQuina As Struct.Combinacoes.Quina) As IList(Of Integer)
    Function Convert(ByVal strSena As String) As IList(Of Integer)

End Interface
