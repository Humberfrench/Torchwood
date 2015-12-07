Imports Torchwood.Struct.Exceptions
Namespace Combinacoes
    <System.Serializable()> Public Class DuplaSena
        Implements IDisposable

        Private disposedValue As Boolean = False        ' To detect redundant calls

#Region " Construtores"

        Public Sub New()

        End Sub

        Public Sub New(ByVal pintDezena01 As Integer, _
                       ByVal pintDezena02 As Integer, _
                       ByVal pintDezena03 As Integer, _
                       ByVal pintDezena04 As Integer, _
                       ByVal pintDezena05 As Integer, _
                       ByVal pintDezena06 As Integer, _
                       ByVal pintConcurso As Integer, _
                       ByVal pintData As DateTime)

            Dezena01 = pintDezena01
            Dezena02 = pintDezena02
            Dezena03 = pintDezena03
            Dezena04 = pintDezena04
            Dezena05 = pintDezena05
            Dezena06 = pintDezena06

        End Sub

#End Region

#Region " Propriedades"

        Public Property Dezena01() As Integer
        Public Property Dezena02() As Integer
        Public Property Dezena03() As Integer
        Public Property Dezena04() As Integer
        Public Property Dezena05() As Integer
        Public Property Dezena06() As Integer
   

#End Region

#Region " IDisposable Support "
        ' IDisposable
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    MyBase.Finalize()
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
End Namespace
