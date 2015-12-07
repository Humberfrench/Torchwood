Imports Torchwood.Struct.Exceptions
<System.Serializable()> Public Class SetResults
    Implements IDisposable

    Private disposedValue As Boolean = False        ' To detect redundant calls
    Private intQtdeDezenas As Integer
    Private intConcurso As Integer
    Private dblPercEficiencia As Double
    Private datConcurso As DateTime


#Region " Construtores"

    Public Sub New()

        intQtdeDezenas = 0
        intConcurso = 0
        dblPercEficiencia = 0
        datConcurso = New DateTime

    End Sub

    Public Sub New(ByVal pIntQtdeDezenas As Integer, _
                   ByVal pintConcurso As Integer, _
                   ByVal pdblPercEficiencia As Double)

        Me.New()

        intQtdeDezenas = pIntQtdeDezenas
        intConcurso = pintConcurso
        dblPercEficiencia = pdblPercEficiencia

    End Sub

    Public Sub New(ByVal pIntQtdeDezenas As Integer, _
                   ByVal pintConcurso As Integer, _
                   ByVal pdblPercEficiencia As Double, _
                   ByVal pDatConcurso As DateTime)

        Me.New()

        intQtdeDezenas = pIntQtdeDezenas
        intConcurso = pintConcurso
        dblPercEficiencia = pdblPercEficiencia
        datConcurso = pDatConcurso

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

    Public Property Concurso() As Integer
        Get
            Return intConcurso
        End Get
        Set(ByVal value As Integer)
            intConcurso = value
        End Set
    End Property

    Public Property PercentualEficiencia() As Double
        Get
            Return dblPercEficiencia
        End Get
        Set(ByVal value As Double)
            dblPercEficiencia = value
        End Set
    End Property

    Public Property DataConcurso() As DateTime
        Get
            Return datConcurso
        End Get
        Set(ByVal value As DateTime)
            datConcurso = value
        End Set
    End Property

#Region " IDisposable Support "
    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                MyBase.Finalize()
                intQtdeDezenas = Nothing
                intConcurso = Nothing
                dblPercEficiencia = Nothing
                datConcurso = Nothing
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
