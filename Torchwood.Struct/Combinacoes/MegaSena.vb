Imports Torchwood.Struct.Exceptions
Namespace Combinacoes
    <System.Serializable()> Public Class MegaSena
        Implements IDisposable

#Region "variaveis"

        Private disposedValue As Boolean = False        ' To detect redundant calls
        Private intDezena01 As Integer
        Private intDezena02 As Integer
        Private intDezena03 As Integer
        Private intDezena04 As Integer
        Private intDezena05 As Integer
        Private intDezena06 As Integer

#End Region

#Region " Constutores"

        Public Sub New()

            intDezena01 = 0
            intDezena02 = 0
            intDezena03 = 0
            intDezena04 = 0
            intDezena05 = 0
            intDezena06 = 0

        End Sub

        Public Sub New(ByVal pintDezena1 As Integer, _
                       ByVal pintDezena2 As Integer, _
                       ByVal pintDezena3 As Integer, _
                       ByVal pintDezena4 As Integer, _
                       ByVal pintDezena5 As Integer, _
                       ByVal pintDezena6 As Integer, _
                       ByVal pintConcurso As Integer, _
                       ByVal pintData As DateTime)

            intDezena01 = pintDezena1
            intDezena02 = pintDezena2
            intDezena03 = pintDezena3
            intDezena04 = pintDezena4
            intDezena05 = pintDezena5
            intDezena06 = pintDezena6

        End Sub

        Public Sub New(ByVal aIntDezenas() As Integer)

            Try
                'verificação da qtde de dezenas para Mega.
                If aIntDezenas.Length <> 6 Then
                    Throw New InvalidDezenas("O vetor de dezenas deve conter 6 itens.")
                End If

                intDezena01 = aIntDezenas(0)
                intDezena02 = aIntDezenas(1)
                intDezena03 = aIntDezenas(2)
                intDezena04 = aIntDezenas(3)
                intDezena05 = aIntDezenas(4)
                intDezena06 = aIntDezenas(5)

            Catch ex As InvalidDezenas
                Throw New InvalidDezenas(ex.Message.ToString)
            Catch ex As Exception
                Throw New Exception(ex.Message.ToString)
            End Try

        End Sub


#End Region

#Region " Propriedades"

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
                    Finalize()
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

        Protected Overrides Sub Finalize()

            MyBase.Finalize()
            intDezena01 = Nothing
            intDezena02 = Nothing
            intDezena03 = Nothing
            intDezena04 = Nothing
            intDezena05 = Nothing
            intDezena06 = Nothing

        End Sub
#End Region

    End Class

End Namespace