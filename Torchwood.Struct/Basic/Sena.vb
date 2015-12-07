Imports Torchwood.Struct.Exceptions
<System.Serializable()> Public Class Sena
    Implements IDisposable

    Private disposedValue As Boolean = False        ' To detect redundant calls
    Private intLoteria As TipoLoteria
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

        intLoteria = TipoLoteria.MegaSena
        intConcurso = 0
        datConcurso = DateTime.Now
        intDezena01 = 0
        intDezena02 = 0
        intDezena03 = 0
        intDezena04 = 0
        intDezena05 = 0
        intDezena06 = 0

    End Sub

    Public Sub New(ByVal pStrDezena1 As String, _
                   ByVal pStrDezena2 As String, _
                   ByVal pStrDezena3 As String, _
                   ByVal pStrDezena4 As String, _
                   ByVal pStrDezena5 As String, _
                   ByVal pStrDezena6 As String)

        Me.New()

        intDezena01 = Convert.ToInt32(pStrDezena1)
        intDezena02 = Convert.ToInt32(pStrDezena2)
        intDezena03 = Convert.ToInt32(pStrDezena3)
        intDezena04 = Convert.ToInt32(pStrDezena4)
        intDezena05 = Convert.ToInt32(pStrDezena5)
        intDezena06 = Convert.ToInt32(pStrDezena6)

    End Sub

    Public Sub New(ByVal aStrDezenas() As String)

        Me.New()
        Try
            'verificação da qtde de dezenas para Mega.
            If aStrDezenas.Length <> 6 Then
                Throw New InvalidDezenas("O vetor de dezenas deve conter 6 itens.")
            End If
            intDezena01 = Convert.ToInt32(aStrDezenas(0))
            intDezena02 = Convert.ToInt32(aStrDezenas(1))
            intDezena03 = Convert.ToInt32(aStrDezenas(2))
            intDezena04 = Convert.ToInt32(aStrDezenas(3))
            intDezena05 = Convert.ToInt32(aStrDezenas(4))
            intDezena06 = Convert.ToInt32(aStrDezenas(5))
        Catch ex As InvalidDezenas
            Throw New InvalidDezenas(ex.Message.ToString)
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString)
        End Try

    End Sub

#End Region

#Region " Propriedades"

    Public Property Loteria() As TipoLoteria
        Get
            Return intLoteria
        End Get
        Set(ByVal value As TipoLoteria)
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
                intLoteria = Nothing
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
