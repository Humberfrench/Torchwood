Public Class BestDezenas

    Private intDezena As Integer
    Private intQtDezena As Integer
    Private dblPCDezena As Double
    Private dblPCDezenaTotal As Double
    Private intConcursos As Integer
    Private intDezenas As Integer

    Public Sub New()

        intDezena = 0
        intQtDezena = 0
        dblPCDezena = 0
        dblPCDezenaTotal = 0
        intConcursos = 0
        intDezenas = 0

    End Sub

    Public Property Dezena() As Integer
        Get
            Return intDezena
        End Get
        Set(ByVal value As Integer)
            intDezena = value
        End Set
    End Property
    Public Property QuantidadeDezena() As Integer
        Get
            Return intQtDezena
        End Get
        Set(ByVal value As Integer)
            intQtDezena = value
        End Set
    End Property
    Public Property PercentualDezena() As Double
        Get
            Return dblPCDezena
        End Get
        Set(ByVal value As Double)
            dblPCDezena = value
        End Set
    End Property
    Public Property PercentualDezenaTotal() As Double
        Get
            Return dblPCDezenaTotal
        End Get
        Set(ByVal value As Double)
            dblPCDezenaTotal = value
        End Set
    End Property
    Public Property NumeroConcursos() As Integer
        Get
            Return intConcursos
        End Get
        Set(ByVal value As Integer)
            intConcursos = value
        End Set
    End Property
    Public Property TotalDezenas() As Integer
        Get
            Return intDezenas
        End Get
        Set(ByVal value As Integer)
            intDezenas = value
        End Set
    End Property

End Class
