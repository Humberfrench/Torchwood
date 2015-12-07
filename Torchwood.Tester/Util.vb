Imports System.Configuration.ConfigurationManager

Module Util
    Public strKey As String = GetKey()

    Public Function GetKey() As String

        If AppSettings("Ambiente") Is Nothing Then
            Return "torchConnDev"
        Else
            If AppSettings("Ambiente") = "Prod" Then
                Return "torchConn"
            Else
                Return "torchConnDev"
            End If
        End If
    End Function
End Module
