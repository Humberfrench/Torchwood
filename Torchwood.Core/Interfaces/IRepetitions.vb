Imports Torchwood.Struct
Public Interface IRepetitions

    Function ProcessaLotoFacil() As Boolean
    Function ProcessaMegaSena() As Boolean
    Function VerifyConcurso(ByVal intLoteria As TipoLoteria, ByVal intConcurso As Integer) As Boolean
    Function GravaRepeticoes(ByVal intLoteria As TipoLoteria, _
                             ByVal intConcurso As Integer, _
                             ByVal intOcorencias As Integer) As Boolean
    Property Key() As String

End Interface
