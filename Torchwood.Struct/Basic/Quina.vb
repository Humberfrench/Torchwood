Imports Torchwood.Struct.Exceptions
<System.Serializable()> Public Class Quina
    Implements IDisposable

    Private disposedValue As Boolean = False        ' To detect redundant calls
    Private intConcurso As Integer
    Private datConcurso As DateTime
    Private intDezena01 As Integer
    Private intDezena02 As Integer
    Private intDezena03 As Integer
    Private intDezena04 As Integer
    Private intDezena05 As Integer

#Region " Construtores"
    Public Sub New()

        intConcurso = 0
        datConcurso = DateTime.Now
        intDezena01 = 0
        intDezena02 = 0
        intDezena03 = 0
        intDezena04 = 0
        intDezena05 = 0

    End Sub

    Public Sub New(ByVal pStrDezena01 As String, _
                   ByVal pStrDezena02 As String, _
                   ByVal pStrDezena03 As String, _
                   ByVal pStrDezena04 As String, _
                   ByVal pStrDezena05 As String, _
                   ByVal pStrDezena06 As String)

        Me.New()

        intDezena01 = Convert.ToInt32(pStrDezena01)
        intDezena02 = Convert.ToInt32(pStrDezena02)
        intDezena03 = Convert.ToInt32(pStrDezena03)
        intDezena04 = Convert.ToInt32(pStrDezena04)
        intDezena05 = Convert.ToInt32(pStrDezena05)

    End Sub

    Public Sub New(ByVal aStrDezenas() As String)

        Me.New()
        Try
            'verificação da qtde de dezenas para Quina.
            If aStrDezenas.Length <> 5 Then
                Throw New InvalidDezenas("O vetor de dezenas deve conter 5 itens.")
            End If
            intDezena01 = Convert.ToInt32(aStrDezenas(0))
            intDezena02 = Convert.ToInt32(aStrDezenas(1))
            intDezena03 = Convert.ToInt32(aStrDezenas(2))
            intDezena04 = Convert.ToInt32(aStrDezenas(3))
            intDezena05 = Convert.ToInt32(aStrDezenas(4))

        Catch ex As InvalidDezenas
            Throw New InvalidDezenas(ex.Message.ToString)
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString)
        End Try

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
