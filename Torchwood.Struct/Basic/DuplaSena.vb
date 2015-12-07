Imports Torchwood.Struct.Exceptions
<System.Serializable()> Public Class DuplaSena
    Implements IDisposable

    Private disposedValue As Boolean = False        ' To detect redundant calls
    Private intConcurso As Integer
    Private datConcurso As DateTime
    Private intDezena01 As Integer
    Private intDezena02 As Integer
    Private intDezena03 As Integer
    Private intDezena04 As Integer
    Private intDezena05 As Integer
    Private intDezena06 As Integer

#Region " Construtores"

    Public Sub New()

        intConcurso = 0
        datConcurso = DateTime.Now
        intDezena01 = 0
        intDezena02 = 0
        intDezena03 = 0
        intDezena04 = 0
        intDezena05 = 0
        intDezena06 = 0

    End Sub

    Public Sub New(ByVal pintDezena01 As Integer, _
                   ByVal pintDezena02 As Integer, _
                   ByVal pintDezena03 As Integer, _
                   ByVal pintDezena04 As Integer, _
                   ByVal pintDezena05 As Integer, _
                   ByVal pintDezena06 As Integer, _
                   ByVal pintConcurso As Integer, _
                   ByVal pintData As DateTime)

        intDezena01 = pintDezena01
        intDezena02 = pintDezena02
        intDezena03 = pintDezena03
        intDezena04 = pintDezena04
        intDezena05 = pintDezena05
        intDezena06 = pintDezena06
        intConcurso = pintConcurso
        datConcurso = pintData

    End Sub

#End Region

#Region " Propriedades"

    Public Property Concurso() As Integer
        Get
            Return intConcurso
        End Get
        Set(ByVal value As Integer)
            intConcurso = value
        End Set
    End Property

    Public Property Data() As DateTime
        Get
            Return datConcurso
        End Get
        Set(ByVal value As DateTime)
            datConcurso = value
        End Set
    End Property

    Public Property Dezena01() As Integer
        Get
            Return intDezena01
        End Get
        Set(ByVal value As Integer)
            intDezena01 = value
        End Set
    End Property

    Public Property Dezena02() As Integer
        Get
            Return intDezena02
        End Get
        Set(ByVal value As Integer)
            intDezena02 = value
        End Set
    End Property

    Public Property Dezena03() As Integer
        Get
            Return intDezena03
        End Get
        Set(ByVal value As Integer)
            intDezena03 = value
        End Set
    End Property

    Public Property Dezena04() As Integer
        Get
            Return intDezena04
        End Get
        Set(ByVal value As Integer)
            intDezena04 = value
        End Set
    End Property

    Public Property Dezena05() As Integer
        Get
            Return intDezena05
        End Get
        Set(ByVal value As Integer)
            intDezena05 = value
        End Set
    End Property

    Public Property Dezena06() As Integer
        Get
            Return intDezena06
        End Get
        Set(ByVal value As Integer)
            intDezena06 = value
        End Set
    End Property

#End Region

#Region " IDisposable Support "
    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                MyBase.Finalize()
                intConcurso = Nothing
                datConcurso = Nothing
                intDezena01 = Nothing
                intDezena02 = Nothing
                intDezena03 = Nothing
                intDezena04 = Nothing
                intDezena05 = Nothing
                intDezena06 = Nothing
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
