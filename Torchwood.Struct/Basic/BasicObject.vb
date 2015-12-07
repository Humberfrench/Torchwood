Public Class BasicObject

    Public Property Codigo As Integer
    Public Property Descricao As String
    Public Overrides Function toString() As String
        Return Descricao
    End Function
End Class
