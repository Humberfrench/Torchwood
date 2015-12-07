Public Class DezenaStats

    Private intDezena As Integer
    Private dblPercentualNormal As Double
    Private dblPercentualPar As Double
    Private dblPercentualImpar As Double
    Private dblPercentualTres As Double
    Private dblPercentualQuatro As Double
    Private dblPercentualCinco As Double
    Private dblPercentualSeis As Double
    Private dblPercentualSete As Double
    Private dblPercentualOito As Double
    Private dblPercentualNove As Double
    Private dblPercentualDez As Double
    Private dblPercentualQuinze As Double
    Private dblPercentualVinte As Double
    Private dblPercentualVinteCinco As Double
    Private dblPercentualExtraUm As Double
    Private dblPercentualExtraDois As Double
    Private strPercentualExtraUm As String
    Private strPercentualExtraDois As String

    Public Sub New()

        intDezena = 0
        dblPercentualNormal = 0
        dblPercentualPar = 0
        dblPercentualImpar = 0
        dblPercentualTres = 0
        dblPercentualQuatro = 0
        dblPercentualCinco = 0
        dblPercentualSeis = 0
        dblPercentualSete = 0
        dblPercentualOito = 0
        dblPercentualNove = 0
        dblPercentualDez = 0
        dblPercentualQuinze = 0
        dblPercentualVinte = 0
        dblPercentualVinteCinco = 0
        dblPercentualExtraUm = 0
        dblPercentualExtraDois = 0
        strPercentualExtraUm = String.Empty
        strPercentualExtraDois = String.Empty

    End Sub

    Public Property PercentualNormal() As Double
        Get
            Return dblPercentualNormal
        End Get
        Set(ByVal value As Double)
            dblPercentualNormal = value
        End Set
    End Property

    Public Property PercentualPar() As Double
        Get
            Return dblPercentualPar
        End Get
        Set(ByVal value As Double)
            dblPercentualPar = value
        End Set
    End Property

    Public Property PercentualImpar() As Double
        Get
            Return dblPercentualImpar
        End Get
        Set(ByVal value As Double)
            dblPercentualImpar = value
        End Set
    End Property

    Public Property PercentualTres() As Double
        Get
            Return dblPercentualTres
        End Get
        Set(ByVal value As Double)
            dblPercentualTres = value
        End Set
    End Property

    Public Property PercentualQuatro() As Double
        Get
            Return dblPercentualQuatro
        End Get
        Set(ByVal value As Double)
            dblPercentualQuatro = value
        End Set
    End Property

    Public Property PercentualCinco() As Double
        Get
            Return dblPercentualCinco
        End Get
        Set(ByVal value As Double)
            dblPercentualCinco = value
        End Set
    End Property

    Public Property PercentualSeis() As Double
        Get
            Return dblPercentualSeis
        End Get
        Set(ByVal value As Double)
            dblPercentualSeis = value
        End Set
    End Property

    Public Property PercentualSete() As Double
        Get
            Return dblPercentualSete
        End Get
        Set(ByVal value As Double)
            dblPercentualSete = value
        End Set
    End Property

    Public Property PercentualOito() As Double
        Get
            Return dblPercentualOito
        End Get
        Set(ByVal value As Double)
            dblPercentualOito = value
        End Set
    End Property

    Public Property PercentualNove() As Double
        Get
            Return dblPercentualNove
        End Get
        Set(ByVal value As Double)
            dblPercentualNove = value
        End Set
    End Property

    Public Property PercentualDez() As Double
        Get
            Return dblPercentualDez
        End Get
        Set(ByVal value As Double)
            dblPercentualDez = value
        End Set
    End Property

    Public Property PercentualQuinze() As Double
        Get
            Return dblPercentualQuinze
        End Get
        Set(ByVal value As Double)
            dblPercentualQuinze = value
        End Set
    End Property

    Public Property PercentualVinte() As Double
        Get
            Return dblPercentualVinte
        End Get
        Set(ByVal value As Double)
            dblPercentualVinte = value
        End Set
    End Property

    Public Property PercentualVinteCinco() As Double
        Get
            Return dblPercentualVinteCinco
        End Get
        Set(ByVal value As Double)
            dblPercentualVinteCinco = value
        End Set
    End Property

    Public Property PercentualExtraUm() As Double
        Get
            Return dblPercentualExtraUm
        End Get
        Set(ByVal value As Double)
            dblPercentualExtraUm = value
        End Set
    End Property

    Public Property PercentualExtraDois() As Double
        Get
            Return dblPercentualExtraDois
        End Get
        Set(ByVal value As Double)
            dblPercentualExtraDois = value
        End Set
    End Property

    Public Property DescricaoPercentualExtraUm() As String
        Get
            Return strPercentualExtraUm
        End Get
        Set(ByVal value As String)
            strPercentualExtraUm = value
        End Set
    End Property

    Public Property DescricaoPercentualExtraDois() As String
        Get
            Return strPercentualExtraDois
        End Get
        Set(ByVal value As String)
            strPercentualExtraDois = value
        End Set
    End Property

End Class
