Imports Consumer.Math.Stats

Namespace Business
    Public Class Calculation
        Implements IDisposable

        Private disposedValue As Boolean = False        ' To detect redundant calls

        Public Sub New()

        End Sub

        ''' <summary>
        ''' Combinar n dezenas para jogos da megasena
        ''' </summary>
        ''' <param name="strDezenas">dezenas preferivelmenteseparadas por ;</param>
        ''' <returns>Estrutura dos jogos</returns>
        ''' <remarks></remarks>
        <Obsolete("Analisar este Método.", True)> _
        Public Function CombineMegaSena(ByVal strDezenas As String) As List(Of Struct.Sena)

            Dim arrSena As New List(Of String)
            Dim objCalc As New Combinatory
            Dim lstSena As List(Of Struct.Sena)
            Dim objSena As Struct.Sena
            Dim aStrItens As String()

            Try
                lstSena = New List(Of Struct.Sena)()
                arrSena = objCalc.CombinarValores(strDezenas, 6)

                For Each strItens As String In arrSena
                    'trocando "-" "." "," por ";".
                    strItens = strItens.Replace(","c, ";"c)
                    strItens = strItens.Replace("-"c, ";"c)
                    strItens = strItens.Replace("."c, ";"c)

                    'gerando o array
                    aStrItens = strItens.Split(";"c)

                    'gerando uma classe com as dezenas combinadas
                    objSena = New Struct.Sena(aStrItens)

                    'adicionando os itens na coleção que será devolvida
                    lstSena.Add(objSena)
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message.ToString)
            End Try

            Return lstSena

        End Function

        ''' <summary>
        ''' Combinar n dezenas para jogos da duplasena
        ''' </summary>
        ''' <param name="strDezenas">dezenas preferivelmenteseparadas por ;</param>
        ''' <returns>Estrutura dos jogos</returns>
        ''' <remarks></remarks>
        Public Function CombineDuplaSena(ByVal strDezenas As String) As List(Of Struct.Sena)

            Dim arrSena As New List(Of String)
            Dim objCalc As New Combinatory
            Dim lstSena As List(Of Struct.Sena)
            Dim objSena As Struct.Sena
            Dim aStrItens As String()

            Try
                lstSena = New List(Of Struct.Sena)()
                arrSena = objCalc.CombinarValores(strDezenas, 6)

                For Each strItens As String In arrSena
                    'trocando "-" "." "," por ";".
                    strItens = strItens.Replace(","c, ";"c)
                    strItens = strItens.Replace("-"c, ";"c)
                    strItens = strItens.Replace("."c, ";"c)

                    'gerando o array
                    aStrItens = strItens.Split(";"c)

                    'gerando uma classe com as dezenas combinadas
                    objSena = New Struct.Sena(aStrItens)

                    'adicionando os itens na coleção que será devolvida
                    lstSena.Add(objSena)
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message.ToString)
            End Try

            Return lstSena

        End Function

        ''' <summary>
        ''' Combinar n dezenas para jogos da quina
        ''' </summary>
        ''' <param name="strDezenas">dezenas preferivelmenteseparadas por ;</param>
        ''' <returns>Estrutura dos jogos</returns>
        ''' <remarks></remarks>
        Public Function CombineQuina(ByVal strDezenas As String) As List(Of Struct.Quina)

            Dim arrQuina As New List(Of String)
            Dim objCalc As New Combinatory
            Dim lstQuina As List(Of Struct.Quina)
            Dim objQuina As Struct.Quina
            Dim aStrItens As String()

            Try
                lstQuina = New List(Of Struct.Quina)()
                arrQuina = objCalc.CombinarValores(strDezenas, 5)

                For Each strItens As String In arrQuina
                    'trocando "-" "." "," por ";".
                    strItens = strItens.Replace(","c, ";"c)
                    strItens = strItens.Replace("-"c, ";"c)
                    strItens = strItens.Replace("."c, ";"c)

                    'gerando o array
                    aStrItens = strItens.Split(";"c)

                    'gerando uma classe com as dezenas combinadas
                    objQuina = New Struct.Quina(aStrItens)

                    'adicionando os itens na coleção que será devolvida
                    lstQuina.Add(objQuina)
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message.ToString)
            End Try

            Return lstQuina

        End Function

#Region " IDisposable Support "
        ' IDisposable
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    ' TODO: free managed resources when explicitly called
                End If

                ' TODO: free shared unmanaged resources
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
End Namespace 'Loteria.Engine
