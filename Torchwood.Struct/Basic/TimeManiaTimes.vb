Imports System.ComponentModel
<DefaultProperty("Descricao"), System.Serializable()> _
    Public Class TimeManiaTimes
    Implements IDisposable

#Region "Variáveis"
    Private intCodigo As Integer
    Private strTime As String
    Private strUFTime As String
    Private disposedValue As Boolean = False        ' To detect redundant calls
#End Region

#Region "Construtores"

    Public Sub New()

        intCodigo = 0
        strTime = ""
        strUFTime = ""

    End Sub

    Public Sub New(ByVal pIntCodigo As Integer, _
                   ByVal pStrTime As String, _
                   ByVal pStrUFTime As String)

        intCodigo = pIntCodigo
        strTime = pStrTime
        strUFTime = pStrUFTime

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

    Public Property Time() As String
        Get
            Return strTime
        End Get
        Set(ByVal value As String)
            strTime = value
        End Set
    End Property

    Public Property UFTime() As String
        Get
            Return strUFTime
        End Get
        Set(ByVal value As String)
            strUFTime = value
        End Set
    End Property
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
        strTime = Nothing
        strUFTime = Nothing
        MyBase.Finalize()
    End Sub

#End Region

End Class
