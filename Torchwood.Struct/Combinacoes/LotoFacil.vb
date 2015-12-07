Imports Torchwood.Struct.Exceptions
Namespace Combinacoes
    <System.Serializable()> Public Class LotoFacil
        Implements IDisposable

        Private disposedValue As Boolean = False        ' To detect redundant calls
        Private intDezena01 As Integer
        Private intDezena02 As Integer
        Private intDezena03 As Integer
        Private intDezena04 As Integer
        Private intDezena05 As Integer
        Private intDezena06 As Integer
        Private intDezena07 As Integer
        Private intDezena08 As Integer
        Private intDezena09 As Integer
        Private intDezena10 As Integer
        Private intDezena11 As Integer
        Private intDezena12 As Integer
        Private intDezena13 As Integer
        Private intDezena14 As Integer
        Private intDezena15 As Integer

#Region " Construtores"

        Public Sub New()

            intDezena01 = 0
            intDezena02 = 0
            intDezena03 = 0
            intDezena04 = 0
            intDezena05 = 0
            intDezena06 = 0
            intDezena07 = 0
            intDezena08 = 0
            intDezena09 = 0
            intDezena10 = 0
            intDezena11 = 0
            intDezena12 = 0
            intDezena13 = 0
            intDezena14 = 0
            intDezena15 = 0

        End Sub

        Public Sub New(ByVal pintDezena01 As Integer, _
                       ByVal pintDezena02 As Integer, _
                       ByVal pintDezena03 As Integer, _
                       ByVal pintDezena04 As Integer, _
                       ByVal pintDezena05 As Integer, _
                       ByVal pintDezena06 As Integer, _
                       ByVal pintDezena07 As Integer, _
                       ByVal pintDezena08 As Integer, _
                       ByVal pintDezena09 As Integer, _
                       ByVal pintDezena10 As Integer, _
                       ByVal pintDezena11 As Integer, _
                       ByVal pintDezena12 As Integer, _
                       ByVal pintDezena13 As Integer, _
                       ByVal pintDezena14 As Integer, _
                       ByVal pintDezena15 As Integer)

            Me.New()
            intDezena01 = pintDezena01
            intDezena02 = pintDezena02
            intDezena03 = pintDezena03
            intDezena04 = pintDezena04
            intDezena05 = pintDezena05
            intDezena06 = pintDezena06
            intDezena07 = pintDezena07
            intDezena08 = pintDezena08
            intDezena09 = pintDezena09
            intDezena10 = pintDezena11
            intDezena11 = pintDezena11
            intDezena12 = pintDezena12
            intDezena13 = pintDezena13
            intDezena14 = pintDezena14
            intDezena15 = pintDezena15

        End Sub

        Public Sub New(ByVal aIntDezenas() As Integer)

            Try
                'verificação da qtde de dezenas para Mega.
                If aIntDezenas.Length <> 15 Then
                    Throw New InvalidDezenas("O vetor de dezenas deve conter 6 itens.")
                End If

                intDezena01 = aIntDezenas(0)
                intDezena02 = aIntDezenas(1)
                intDezena03 = aIntDezenas(2)
                intDezena04 = aIntDezenas(3)
                intDezena05 = aIntDezenas(4)
                intDezena06 = aIntDezenas(5)
                intDezena07 = aIntDezenas(6)
                intDezena08 = aIntDezenas(7)
                intDezena09 = aIntDezenas(8)
                intDezena10 = aIntDezenas(9)
                intDezena11 = aIntDezenas(10)
                intDezena12 = aIntDezenas(11)
                intDezena13 = aIntDezenas(12)
                intDezena14 = aIntDezenas(13)
                intDezena15 = aIntDezenas(14)

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

        Public Property Dezena07() As Integer
            Get
                Return intDezena07
            End Get
            Set(ByVal value As Integer)
                intDezena07 = value
            End Set
        End Property

        Public Property Dezena08() As Integer
            Get
                Return intDezena08
            End Get
            Set(ByVal value As Integer)
                intDezena08 = value
            End Set
        End Property

        Public Property Dezena09() As Integer
            Get
                Return intDezena09
            End Get
            Set(ByVal value As Integer)
                intDezena09 = value
            End Set
        End Property

        Public Property Dezena10() As Integer
            Get
                Return intDezena10
            End Get
            Set(ByVal value As Integer)
                intDezena10 = value
            End Set
        End Property

        Public Property Dezena11() As Integer
            Get
                Return intDezena11
            End Get
            Set(ByVal value As Integer)
                intDezena11 = value
            End Set
        End Property

        Public Property Dezena12() As Integer
            Get
                Return intDezena12
            End Get
            Set(ByVal value As Integer)
                intDezena12 = value
            End Set
        End Property

        Public Property Dezena13() As Integer
            Get
                Return intDezena13
            End Get
            Set(ByVal value As Integer)
                intDezena13 = value
            End Set
        End Property

        Public Property Dezena14() As Integer
            Get
                Return intDezena14
            End Get
            Set(ByVal value As Integer)
                intDezena14 = value
            End Set
        End Property

        Public Property Dezena15() As Integer
            Get
                Return intDezena15
            End Get
            Set(ByVal value As Integer)
                intDezena15 = value
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
            intDezena07 = Nothing
            intDezena08 = Nothing
            intDezena09 = Nothing
            intDezena10 = Nothing
            intDezena11 = Nothing
            intDezena12 = Nothing
            intDezena13 = Nothing
            intDezena14 = Nothing
            intDezena15 = Nothing

        End Sub
#End Region

    End Class
End Namespace