Namespace Business
    Friend Class ReturnData

        Dim intOcorrencias As Integer
        Dim intPosicao As Integer

        Public Sub New()
            intOcorrencias = 0
            intPosicao = 0
        End Sub
        Public Sub New(ByVal pIntOcorrencias As Integer, ByVal pintPosicao As Integer)
            Me.New()
            intOcorrencias = pIntOcorrencias
            intPosicao = pintPosicao

        End Sub
        Public Property Ocorrencias() As Integer
            Get
                Return intOcorrencias
            End Get
            Set(ByVal value As Integer)
                intOcorrencias = value
            End Set
        End Property
        Public Property Posicao() As Integer
            Get
                Return intPosicao
            End Get
            Set(ByVal value As Integer)
                intPosicao = value
            End Set
        End Property

    End Class
End Namespace
