<System.Serializable()> Public Class SetPesquisa
    Implements IDisposable

#Region "Variaveis"
    Private intCodigoSet As Integer
    Private intLoteria As Integer
    <VBFixedString(50)> Private strNome As String
    <VBFixedString(50)> Private strLoteria As String
    Private datConsulta As DateTime
    Private lstDezenas As List(Of Integer)
    Private intConcursoInicial As Integer
    Private intConcursoFinal As Integer
#End Region

#Region "Construtores"
    Public Sub New()

        intCodigoSet = 0
        intLoteria = 0
        strNome = String.Empty
        strLoteria = String.Empty
        datConsulta = New DateTime
        lstDezenas = New List(Of Integer)
        intConcursoInicial = 0
        intConcursoFinal = 0


    End Sub

    Public Sub New(ByVal pIntCodigoSet As Integer, _
                   ByVal pIntLoteria As Integer, _
                   ByVal pIntConcursoInicial As Integer, _
                   ByVal pIntConcursoFinal As Integer)

        Me.New()
        intCodigoSet = pIntCodigoSet
        intLoteria = pIntLoteria
        intConcursoInicial = pIntConcursoInicial
        intConcursoFinal = pIntConcursoFinal

    End Sub

    Public Sub New(ByVal pIntCodigoSet As Integer, _
                   ByVal pIntLoteria As Integer, _
                   ByVal pStrNome As String, _
                   ByVal pDatConsulta As DateTime, _
                   ByVal pLstDezenas As List(Of Integer))

        Me.New()
        intCodigoSet = pIntCodigoSet
        intLoteria = pIntLoteria
        strNome = pStrNome
        datConsulta = pDatConsulta
        lstDezenas = pLstDezenas

    End Sub

#End Region

#Region "Propriedades"

    Public Property Codigo() As Integer
        Get
            Return intCodigoSet
        End Get
        Set(ByVal value As Integer)
            intCodigoSet = value
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
    Public Property Nome() As String
        Get
            Return strNome
        End Get
        Set(ByVal value As String)
            strNome = value
        End Set
    End Property
    Public Property NomeLoteria() As String
        Get
            Return strLoteria
        End Get
        Set(ByVal value As String)
            strLoteria = value
        End Set
    End Property
    Public Property DataConsulta() As DateTime
        Get
            Return datConsulta
        End Get
        Set(ByVal value As DateTime)
            datConsulta = value
        End Set
    End Property
    Public ReadOnly Property Dezenas() As List(Of Integer)
        Get
            Return lstDezenas
        End Get
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

#End Region

#Region "Overload ToString() para Devolver Dado da Propriedade"

    Public Overrides Function ToString() As String
        Return strNome
    End Function
#End Region

#Region " IDisposable Support "

    Private disposedValue As Boolean = False        ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                intCodigoSet = Nothing
                intConcursoInicial = Nothing
                intConcursoFinal = Nothing
                intLoteria = Nothing
                strNome = Nothing
                datConsulta = Nothing
                lstDezenas = Nothing
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
