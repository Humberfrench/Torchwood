Public Class Atrasos

    Private intDezena As Integer
    Private intQtDezenaAtrasos As Integer
    Private intQtDezenaAtrasosMax As Integer

    Public Sub New()

        intDezena = 0
        intQtDezenaAtrasos = 0

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
            Return intQtDezenaAtrasos
        End Get
        Set(ByVal value As Integer)
            intQtDezenaAtrasos = value
        End Set
    End Property
    Public Property QuantidadeDezenaMaximo() As Integer
        Get
            Return intQtDezenaAtrasosMax
        End Get
        Set(ByVal value As Integer)
            intQtDezenaAtrasosMax = value
        End Set
    End Property

End Class
