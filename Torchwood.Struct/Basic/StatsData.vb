Imports Torchwood.Struct.Exceptions
<System.Serializable()> Public Class StatsData
    Implements IDisposable

#Region "Variáveis"

    Private disposedValue As Boolean = False        ' To detect redundant calls
    Private intDezena As Integer
    Private oValueAll As StatsDataItem
    Private oValuePares As StatsDataItem
    Private oValueImpares As StatsDataItem
    Private oValueTop3 As StatsDataItem
    Private oValueTop4 As StatsDataItem
    Private oValueTop5 As StatsDataItem
    Private oValueTop6 As StatsDataItem
    Private oValueTop7 As StatsDataItem
    Private oValueTop8 As StatsDataItem
    Private oValueTop9 As StatsDataItem
    Private oValueTop10 As StatsDataItem
    Private oValueTop11 As StatsDataItem

#End Region

#Region "Construtor"

    Public Sub New()

        intDezena = 0
        oValueAll = New StatsDataItem
        oValuePares = New StatsDataItem
        oValueImpares = New StatsDataItem
        oValueTop3 = New StatsDataItem
        oValueTop4 = New StatsDataItem
        oValueTop5 = New StatsDataItem
        oValueTop6 = New StatsDataItem
        oValueTop7 = New StatsDataItem
        oValueTop8 = New StatsDataItem
        oValueTop9 = New StatsDataItem
        oValueTop10 = New StatsDataItem
        oValueTop11 = New StatsDataItem

    End Sub

    Public Sub New(ByVal pIntDezena As Integer)

        Me.New()
        intDezena = pintDezena

    End Sub

#End Region

#Region "Propriedades"

    Public Property Dezena() As Integer
        Get
            Return intDezena
        End Get
        Set(ByVal value As Integer)
            intDezena = value
        End Set
    End Property

    Public Property ValorTodos() As StatsDataItem
        Get
            Return oValueAll
        End Get
        Set(ByVal value As StatsDataItem)
            oValueAll = value
        End Set
    End Property

    Public Property ValorImpares() As StatsDataItem
        Get
            Return oValueImpares
        End Get
        Set(ByVal value As StatsDataItem)
            oValueImpares = value
        End Set
    End Property

    Public Property ValorPares() As StatsDataItem
        Get
            Return oValuePares
        End Get
        Set(ByVal value As StatsDataItem)
            oValuePares = value
        End Set
    End Property

    Public Property ValorTop3() As StatsDataItem
        Get
            Return oValueTop3
        End Get
        Set(ByVal value As StatsDataItem)
            oValueTop3 = value
        End Set
    End Property

    Public Property ValorTop4() As StatsDataItem
        Get
            Return oValueTop4
        End Get
        Set(ByVal value As StatsDataItem)
            oValueTop4 = value
        End Set
    End Property

    Public Property ValorTop5() As StatsDataItem
        Get
            Return oValueTop5
        End Get
        Set(ByVal value As StatsDataItem)
            oValueTop5 = value
        End Set
    End Property

    Public Property ValorTop6() As StatsDataItem
        Get
            Return oValueTop6
        End Get
        Set(ByVal value As StatsDataItem)
            oValueTop6 = value
        End Set
    End Property

    Public Property ValorTop7() As StatsDataItem
        Get
            Return oValueTop7
        End Get
        Set(ByVal value As StatsDataItem)
            oValueTop7 = value
        End Set
    End Property

    Public Property ValorTop8() As StatsDataItem
        Get
            Return oValueTop8
        End Get
        Set(ByVal value As StatsDataItem)
            oValueTop8 = value
        End Set
    End Property

    Public Property ValorTop9() As StatsDataItem
        Get
            Return oValueTop9
        End Get
        Set(ByVal value As StatsDataItem)
            oValueTop9 = value
        End Set
    End Property

    Public Property ValorTop10() As StatsDataItem
        Get
            Return oValueTop10
        End Get
        Set(ByVal value As StatsDataItem)
            oValueTop10 = value
        End Set
    End Property

    Public Property ValorTop11() As StatsDataItem
        Get
            Return oValueTop11
        End Get
        Set(ByVal value As StatsDataItem)
            oValueTop11 = value
        End Set
    End Property

#End Region

#Region " IDisposable Support "
    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                MyBase.Finalize()
                intDezena = Nothing
                oValueAll = Nothing
                oValuePares = Nothing
                oValueImpares = Nothing
                oValueTop3 = Nothing
                oValueTop4 = Nothing
                oValueTop5 = Nothing
                oValueTop6 = Nothing
                oValueTop7 = Nothing
                oValueTop8 = Nothing
                oValueTop9 = Nothing
                oValueTop10 = Nothing
                oValueTop11 = Nothing
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
