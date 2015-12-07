<System.Serializable()> Public Class Cenario
    Implements IDisposable

    Private disposedValue As Boolean = False        ' To detect redundant calls
    Private intCenario As Integer    '  int	N/A	N	Código do Cenário
    Private intLoteria As Integer     'Tinyint	N/A	N	Código da Loteria
    Private intConcursoInicial As Integer    'int	N/A	N	Código do Concurso Inicial
    Private intConcursoFinal As Integer    'int	N/A	N	Código do Concurso Final
    Private strCenario As String   'varchar	50	N	Descrição do Cenário
    Private strLoteriaNome As String   'varchar	50	N	Descrição do Cenário
    Private datCenario As DateTime  'Smalldatetime	N/A	N	Data do Cenário
    Private oCenarioItem As List(Of CenarioItem)

#Region " IDisposable Support "
    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: free other state (managed objects).

                intCenario = Nothing
                intLoteria = Nothing
                intConcursoInicial = Nothing
                intConcursoFinal = Nothing
                strCenario = Nothing
                strLoteriaNome = Nothing
                datCenario = Nothing
                oCenarioItem = Nothing

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
        intLoteria = 0
        intConcursoInicial = 0
        intConcursoFinal = 0
        strCenario = String.Empty
        strLoteriaNome = String.Empty
        datCenario = New DateTime
        oCenarioItem = New List(Of CenarioItem)

    End Sub

#End Region

#Region "Properties"

    Public Property Codigo() As Integer
        Get
            Return intCenario
        End Get
        Set(ByVal value As Integer)
            intCenario = value
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

    Public Property ConcursoInicial() As Integer
        Get
            Return intConcursoInicial
        End Get
        Set(ByVal value As Integer)
            intConcursoInicial = value
        End Set
    End Property

    Public Property ConcursoFinal() As Integer
        Get
            Return intConcursoFinal
        End Get
        Set(ByVal value As Integer)
            intConcursoFinal = value
        End Set
    End Property

    Public Property Cenario() As String
        Get
            Return strCenario
        End Get
        Set(ByVal value As String)
            strCenario = value
        End Set
    End Property

    Public Property LoteriaNome() As String
        Get
            Return strLoteriaNome
        End Get
        Set(ByVal value As String)
            strLoteriaNome = value
        End Set
    End Property

    Public Property Data() As DateTime
        Get
            Return datCenario
        End Get
        Set(ByVal value As DateTime)
            datCenario = value
        End Set
    End Property

    Public ReadOnly Property Items() As List(Of CenarioItem)
        Get
            Return oCenarioItem
        End Get
    End Property

#End Region

#Region "Métodos"

    Public Overrides Function ToString() As String
        Return strCenario.ToString()
    End Function

#End Region

End Class
