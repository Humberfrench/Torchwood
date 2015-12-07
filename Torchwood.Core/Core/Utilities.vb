Imports System.Text
Namespace Business
    Public Class Utilities

        Friend Shared Function GenerateStringIn(ByVal strItens As List(Of String)) As String

            Dim stbIn As StringBuilder

            stbIn = New StringBuilder
            stbIn.Append("(")

            For intCont As Integer = 0 To strItens.Count - 2
                stbIn.Append(strItens(intCont))
                stbIn.Append(",")
            Next

            stbIn.Append(strItens(strItens.Count - 1))
            stbIn.Append(")")

            Return strItens.ToString

        End Function

    End Class

End Namespace
