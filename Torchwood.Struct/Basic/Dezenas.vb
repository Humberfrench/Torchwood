<System.Serializable()> Public Class Dezenas
    Implements IDisposable

#Region "Variáveis"
    Private intCodigo As Integer
    Private intLoteria As Integer
    Private intConcurso As Integer
    Private strDataConcurso As String
    Private intDezena As Integer
    Private disposedValue As Boolean = False        ' To detect redundant calls
#End Region

#Region "Destruidores"

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                Finalize()
            End If
        End If
        Me.disposedValue = True
    End Sub

    Protected Overrides Sub Finalize()
        intCodigo = Nothing
        intLoteria = Nothing
        intConcurso = Nothing
        strDataConcurso = Nothing
        intDezena = Nothing
        MyBase.Finalize()
    End Sub

#End Region

#Region "Construtores"

    Public Sub New()

        intCodigo = 0
        intLoteria = 0
        intConcurso = 0
        strDataConcurso = DateTime.Now.ToShortDateString
        intDezena = 0

    End Sub

    Public Sub New(ByVal pIntCodigo As Integer, _
                   ByVal pIntLoteria As Integer, _
                   ByVal pIntConcurso As Integer, _
                   ByVal pStrDataConcurso As String, _
                   ByVal pIntDezena As Integer)

        intCodigo = pIntCodigo
        intLoteria = pIntLoteria
        intConcurso = pIntConcurso
        strDataConcurso = pStrDataConcurso
        intDezena = pIntDezena

    End Sub

#End Region

#Region "Properties"

    Public Property Codigo() As Integer
        Get
            Return intCodigo
        End Get
        Set(ByVal value As Integer)
            intCodigo = value
        End Set
    End Property

    Public Property Loteria() As Integer
        Get
            Return intLoteria
        End Get
        Set(ByVal value As Integer)
            intLoteria = value
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

    Public Property Data() As String
        Get
            Return strDataConcurso
        End Get
        Set(ByVal value As String)
            strDataConcurso = value
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

#End Region

End Class
