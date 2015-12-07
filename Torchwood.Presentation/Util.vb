Imports System.Configuration.ConfigurationManager
Imports System

Module Util
    Public strKey As String = GetKey()
    Public strAmbiente As String = ""

    Public Function GetKey() As String

        If strAmbiente = "" Then
            If AppSettings("Ambiente") Is Nothing Then
                Return "torchConnDev"
            Else
                If AppSettings("Ambiente") = "Prod" Then
                    Return "torchConn"
                Else
                    Return "torchConnDev"
                End If
            End If
        Else
            If strAmbiente = "Prod" Then
                Return "torchConn"
            Else
                Return "torchConnDev"
            End If
        End If

    End Function

    Public Sub ShowErro(ByVal ex As Exception, _
                        ByVal strTitulo As String, _
                        ByVal strFormName As String)

        ShowErro(ex.Message.ToString, strTitulo, strFormName)

    End Sub

    Public Sub ShowErro(ByVal strMensagem As String, _
                        ByVal strTitulo As String, _
                        ByVal strFormName As String)

        Dim objFrmErro As frmErro
        objFrmErro = New frmErro

        objFrmErro.Text = "Erro ocorrido"
        objFrmErro.txtErro.Text = strMensagem
        objFrmErro.lblErrTitle.Text = strTitulo
        objFrmErro.lblSubTitle.Text = "Source:" + strFormName

        objFrmErro.ShowDialog()
        objFrmErro = Nothing

    End Sub

End Module