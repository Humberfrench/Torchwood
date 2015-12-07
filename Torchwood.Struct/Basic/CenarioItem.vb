<System.Serializable()> Public Class CenarioItem
    Implements IDisposable

    Private disposedValue As Boolean = False        ' To detect redundant calls
    Private intCenario As Integer    '  int	N/A	N	Código do Cenário
    Private intItem As Integer     'Tinyint	N/A	N	Código da Loteria
    Private intFaixaDe As Integer    'int	N/A	N	Código do Concurso Inicial
    Private intFaixaAte As Integer    'int	N/A	N	Código do Concurso Final
    Private intPontoMedio As Integer    '  int	N/A	N	Código do Cenário
    Private dblValFreqAbs As Double     'Tinyint	N/A	N	Código da Loteria
    Private dblValFreqAcum As Double    'int	N/A	N	Código do Concurso Inicial
    Private dblPcFreqAbs As Double    'int	N/A	N	Código do Concurso Inicial
    Private dblPcFreqAcum As Double    'int	N/A	N	Código do Concurso Final

#Region " IDisposable Support "
    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: free other state (managed objects).

                intCenario = Nothing
                intItem = Nothing
                intFaixaDe = Nothing
                intFaixaAte = Nothing
                intPontoMedio = Nothing
                dblValFreqAbs = Nothing
                intFaixaAte = Nothing
                dblPcFreqAbs = Nothing
                dblPcFreqAcum = Nothing

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

#Region "Construtor"

    Public Sub New()

        intCenario = 0
        intItem = 0
        intFaixaDe = 0
        intFaixaAte = 0
        intPontoMedio = 0
        dblValFreqAbs = 0
        intFaixaAte = 0
        dblPcFreqAbs = 0
        dblPcFreqAcum = 0

    End Sub

#End Region

#Region "Properties"

    Public Property Cenario() As Integer
        Get
            Return intCenario
        End Get
        Set(ByVal value As Integer)
            intCenario = value
        End Set
    End Property

    Public Property Item() As Integer
        Get
            Return intItem
        End Get
        Set(ByVal value As Integer)
            intItem = value
        End Set
    End Property

    Public Property FaixaInicial() As Integer
        Get
            Return intFaixaDe
        End Get
        Set(ByVal value As Integer)
            intFaixaDe = value
        End Set
    End Property

    Public Property FaixaFinal() As Integer
        Get
            Return intFaixaAte
        End Get
        Set(ByVal value As Integer)
            intFaixaAte = value
        End Set
    End Property

    Public Property PontoMedio() As Integer
        Get
            Return intPontoMedio
        End Get
        Set(ByVal value As Integer)
            intPontoMedio = value
        End Set
    End Property

    Public Property ValorFrequenciaAbsoluta() As Double
        Get
            Return dblValFreqAbs
        End Get
        Set(ByVal value As Double)
            dblValFreqAbs = value
        End Set
    End Property

    Public Property ValorFrequenciaAcumulada() As Double
        Get
            Return dblValFreqAcum
        End Get
        Set(ByVal value As Double)
            dblValFreqAcum = value
        End Set
    End Property

    Public Property PercentualFrequenciaAbsoluta() As Double
        Get
            Return dblPcFreqAbs
        End Get
        Set(ByVal value As Double)
            dblPcFreqAbs = value
        End Set
    End Property

    Public Property PercentualFrequenciaAcumulada() As Double
        Get
            Return dblPcFreqAcum
        End Get
        Set(ByVal value As Double)
            dblPcFreqAcum = value
        End Set
    End Property

#End Region

End Class