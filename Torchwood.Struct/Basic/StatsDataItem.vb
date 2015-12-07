Imports Torchwood.Struct.Exceptions
<System.Serializable()> Public Class StatsDataItem
    Implements IDisposable

    Private disposedValue As Boolean = False        ' To detect redundant calls
    Private intQtdeDezenas As Integer
    Private intQtdeConcurso As Integer
    Private dblPercConcurso As Double
    Private dblPercTotal As Double

#Region " Construtores"

    Public Sub New()

        intQtdeDezenas = 0
        intQtdeConcurso = 0
        dblPercConcurso = 0
        dblPercTotal = 0

    End Sub

    Public Sub New(ByVal pIntQtdeDezenas As Integer, _
                   ByVal pIntQtdeConcurso As Integer, _
                   ByVal pDblPercConcurso As Double, _
                   ByVal pDblPercTotal As Double)

        Me.New()

        intQtdeDezenas = pIntQtdeDezenas
        intQtdeConcurso = pIntQtdeConcurso
        dblPercConcurso = pDblPercConcurso
        dblPercTotal = pDblPercTotal

    End Sub


#End Region

    Public Property QuantidadeDezenas() As Integer
        Get
            Return intQtdeDezenas
        End Get
        Set(ByVal value As Integer)
            intQtdeDezenas = value
        End Set
    End Property

    Public Property QuantidadeConcursos() As Integer
        Get
            Return intQtdeConcurso
        End Get
        Set(ByVal value As Integer)
            intQtdeConcurso = value
        End Set
    End Property

    Public Property PercentualConcursos() As Double
        Get
            Return dblPercConcurso
        End Get
        Set(ByVal value As Double)
            dblPercConcurso = value
        End Set
    End Property

    Public Property PercentualTotal() As Double
        Get
            Return dblPercTotal
        End Get
        Set(ByVal value As Double)
            dblPercTotal = value
        End Set
    End Property

#Region " IDisposable Support "
    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                MyBase.Finalize()
                intQtdeDezenas = Nothing
                intQtdeConcurso = Nothing
                dblPercConcurso = Nothing
                dblPercTotal = Nothing
            End If
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
