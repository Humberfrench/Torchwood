Imports System.ComponentModel
<DefaultProperty("Descricao"), System.Serializable()> _
    Public Class Loteria
    Implements IDisposable

#Region "Variáveis"
    Private intCodigo As Integer
    Private strLoteria As String
    Private intQtdeDezenas As Integer
    Private intQtdeMinOccurs As Integer
    Private intDezMinima As Integer
    Private intDezMaxima As Integer
    Private intQtdeDezenasTotais As Integer
    Private strStatus As String
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
        strLoteria = Nothing
        strStatus = Nothing
        MyBase.Finalize()
    End Sub

#End Region

#Region "Construtores"


    Public Sub New()

        intCodigo = 0
        strLoteria = ""
        strStatus = ""
        intQtdeDezenas = 0
        intQtdeMinOccurs = 0
        intDezMinima = 0
        intDezMaxima = 0
        intQtdeDezenasTotais = 0


    End Sub

    Public Sub New(ByVal pIntCodigo As Integer, _
                   ByVal pStrLoteria As String, _
                   ByVal pStrStatus As String)

        intCodigo = pIntCodigo
        strLoteria = pStrLoteria
        strStatus = pStrStatus

    End Sub

#End Region

#Region "Properties"

    ''' <summary>
    ''' Código da Loteria no Banco de Dados
    ''' </summary>
    ''' <value>Integer</value>
    ''' <returns>Integer</returns>
    ''' <remarks></remarks>
    Public Property Codigo() As Integer
        Get
            Return intCodigo
        End Get
        Set(ByVal value As Integer)
            intCodigo = value
        End Set
    End Property

    ''' <summary>
    ''' Quantidade de Dezenas totais amostrais para o sorteio
    ''' </summary>
    ''' <value>Integer</value>
    ''' <returns>Integer</returns>
    ''' <remarks></remarks>
    Public Property QtdeDezenas() As Integer
        Get
            Return intQtdeDezenas
        End Get
        Set(ByVal value As Integer)
            intQtdeDezenas = value
        End Set
    End Property

    ''' <summary>
    ''' Quantidade mínima para a premiação
    ''' </summary>
    ''' <value>Integer</value>
    ''' <returns>Integer</returns>
    ''' <remarks></remarks>
    Public Property QtdeMinOccurs() As Integer
        Get
            Return intQtdeMinOccurs
        End Get
        Set(ByVal value As Integer)
            intQtdeMinOccurs = value
        End Set
    End Property

    ''' <summary>
    ''' número inicial mínimo da dezena
    ''' </summary>
    ''' <value>Integer</value>
    ''' <returns>Integer</returns>
    ''' <remarks></remarks>
    Public Property DezMinima() As Integer
        Get
            Return intDezMinima
        End Get
        Set(ByVal value As Integer)
            intDezMinima = value
        End Set
    End Property

    ''' <summary>
    ''' Número final da Dezena
    ''' </summary>
    ''' <value>Integer</value>
    ''' <returns>Integer</returns>
    ''' <remarks></remarks>
    Public Property DezMaxima() As Integer
        Get
            Return intDezMaxima
        End Get
        Set(ByVal value As Integer)
            intDezMaxima = value
        End Set
    End Property

    ''' <summary>
    ''' Nome da Loteria
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property Descricao() As String
        Get
            Return strLoteria
        End Get
        Set(ByVal value As String)
            strLoteria = value
        End Set
    End Property

    ''' <summary>
    ''' Status da Loteria
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property Status() As String
        Get
            Return strStatus
        End Get
        Set(ByVal value As String)
            strStatus = value
        End Set
    End Property

    ''' <summary>
    ''' Quantidade Total de Dezenas
    ''' </summary>
    ''' <value>Integer</value>
    ''' <returns>Integer</returns>
    ''' <remarks></remarks>
    Public Property QtdeDezenasTotais() As Integer
        Get
            Return intQtdeDezenasTotais
        End Get
        Set(ByVal value As Integer)
            intQtdeDezenasTotais = value
        End Set
    End Property
    Public Overrides Function toString() As String
        Return strLoteria
    End Function
#End Region

End Class


