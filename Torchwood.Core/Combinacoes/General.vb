Namespace Business.Combinacoes
    Friend Class General

        Friend Shared Function Trans(ByVal strValue1 As String, _
                                     ByVal strValue2 As String, _
                                     ByVal strValue3 As String) As String

            Dim intLastPos As Integer
            Dim intPos As Integer
            Dim intSize As Integer
            Dim strTempString As String
            Dim strTemp As String

            strTempString = ""
            intLastPos = 1
            intSize = Len(strValue2)
            intPos = InStr(1, strValue1, strValue2, 0)

            Do While intPos > 0
                strTempString = strTempString & Mid(strValue1, intLastPos, intPos - intLastPos) & strValue3
                intLastPos = intPos + intSize
                intPos = InStr(intLastPos, strValue1, strValue2, 0)
            Loop

            strTemp = strTempString & Mid(strValue1, intLastPos)

            Return strTemp

        End Function

    End Class
End Namespace
