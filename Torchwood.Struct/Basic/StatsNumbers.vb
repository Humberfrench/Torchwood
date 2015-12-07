Imports Torchwood.Struct.Exceptions
<System.Serializable()> _
Public Class StatsNumbers
    Implements IDisposable

    'id_guid                              
    'id_faixa    
    'ds_faixa                                           
    'id_faixa_ini 
    'id_faixa_fim 
    'nr_dezena   
    'qt_dezena                               
    'pc_dezena                               
    'pc_dezena_total                         
    'media_arit_sorteio                      
    'total_concursos                         
    'total_dezenas                           
    'pc_media_faixa                          
    'pc_media_faixa_round                    
    'ind_dezena_sup_faixa 
    'ind_dezena_sup_round 
    'qt_dezena_sup_faixa 
    'qt_dezena_sup_round

#Region "Declaraçõese Construtores"

    Private intFaixa As Integer
    Private strDescFaixa As String
    Private intFaixaInicio As Integer
    Private intFaixaFinal As Integer
    Private intDezena As Integer
    Private dblQtdeDezena As Double
    Private dblPcDezena As Double
    Private dblPcDezenaTotal As Double
    Private dblMediaAritimetica As Double
    Private dblTotalConcursos As Double
    Private dblTotalDezenas As Double
    Private dblMediaFaixa As Double
    Private dblMediaFaixaRound As Double
    Private strIsSuperiorFaixa As String
    Private strIsSuperiorRound As String
    Private dblQdDezenaSuperiorFaixa As Double
    Private dblQdDezenaSuperiorRound As Double

    Public Sub New()

        intFaixa = 0
        strDescFaixa = ""
        intFaixaInicio = 0
        intFaixaFinal = 0
        intDezena = 0
        dblQtdeDezena = 0
        dblPcDezena = 0
        dblPcDezenaTotal = 0
        dblMediaAritimetica = 0
        dblTotalConcursos = 0
        dblTotalDezenas = 0
        dblMediaFaixa = 0
        dblMediaFaixaRound = 0
        strIsSuperiorFaixa = ""
        strIsSuperiorRound = ""
        dblQdDezenaSuperiorFaixa = 0
        dblQdDezenaSuperiorRound = 0

    End Sub

#End Region

#Region "Properties"

    Public Property Faixa() As Integer
        Get
            Return intFaixa
        End Get
        Set(ByVal value As Integer)
            intFaixa = value
        End Set
    End Property

    Public Property DescFaixa() As String
        Get
            Return strDescFaixa
        End Get
        Set(ByVal value As String)
            strDescFaixa = value
        End Set
    End Property

    Public Property FaixaInicio() As Integer
        Get
            Return intFaixaInicio
        End Get
        Set(ByVal value As Integer)
            intFaixaInicio = value
        End Set
    End Property

    Public Property FaixaFinal() As Integer
        Get
            Return intFaixaFinal
        End Get
        Set(ByVal value As Integer)
            intFaixaFinal = value
        End Set
    End Property

    Public Property Dezena() As Integer
        Get
            Return intDezena
        End Get
        Set(ByVal value As Integer)
            intDezena = value
        End Set
    End Property

    Public Property QuantidadeDezenas() As Double
        Get
            Return dblQtdeDezena
        End Get
        Set(ByVal value As Double)
            dblQtdeDezena = value
        End Set
    End Property

    Public Property PercentualDezena() As Double
        Get
            Return dblPcDezena
        End Get
        Set(ByVal value As Double)
            dblPcDezena = value
        End Set
    End Property

    Public Property PercentualDezenaTotal() As Double
        Get
            Return dblPcDezenaTotal
        End Get
        Set(ByVal value As Double)
            dblPcDezenaTotal = value
        End Set
    End Property

    Public Property MediaAritimetica() As Double
        Get
            Return dblMediaAritimetica
        End Get
        Set(ByVal value As Double)
            dblMediaAritimetica = value
        End Set
    End Property

    Public Property TotalConcursos() As Double
        Get
            Return dblTotalConcursos
        End Get
        Set(ByVal value As Double)
            dblTotalConcursos = value
        End Set
    End Property

    Public Property TotalDezenas() As Double
        Get
            Return dblTotalDezenas
        End Get
        Set(ByVal value As Double)
            dblTotalDezenas = value
        End Set
    End Property

    Public Property MediaFaixa() As Double
        Get
            Return dblMediaFaixa
        End Get
        Set(ByVal value As Double)
            dblMediaFaixa = value
        End Set
    End Property

    Public Property MediaFaixaRound() As Double
        Get
            Return dblMediaFaixaRound
        End Get
        Set(ByVal value As Double)
            dblMediaFaixaRound = value
        End Set
    End Property

    Public Property IsSuperiorFaixa() As String
        Get
            Return strIsSuperiorFaixa
        End Get
        Set(ByVal value As String)
            strIsSuperiorFaixa = value
        End Set
    End Property

    Public Property IsSuperiorRound() As String
        Get
            Return strIsSuperiorRound
        End Get
        Set(ByVal value As String)
            strIsSuperiorRound = value
        End Set
    End Property

    Public Property QuantidadeDezenaSuperiorFaixa() As Double
        Get
            Return dblQdDezenaSuperiorFaixa
        End Get
        Set(ByVal value As Double)
            dblQdDezenaSuperiorFaixa = value
        End Set
    End Property

    Public Property QuantidadeDezenaSuperiorRound() As Double
        Get
            Return dblQdDezenaSuperiorRound
        End Get
        Set(ByVal value As Double)
            dblQdDezenaSuperiorRound = value
        End Set
    End Property

#End Region

#Region " IDisposable Support "
    Private disposedValue As Boolean = False        ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                intFaixa = 0
                strDescFaixa = ""
                intFaixaInicio = 0
                intFaixaFinal = 0
                intDezena = 0
                dblQtdeDezena = 0
                dblPcDezena = 0
                dblPcDezenaTotal = 0
                dblMediaAritimetica = 0
                dblTotalConcursos = 0
                dblTotalDezenas = 0
                dblMediaFaixa = 0
                dblMediaFaixaRound = 0
                strIsSuperiorFaixa = ""
                strIsSuperiorRound = ""
                dblQdDezenaSuperiorFaixa = 0
                dblQdDezenaSuperiorRound = 0
            End If

            ' TODO: free your own state (unmanaged objects).
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
