Imports Consumer.Structs

Public Class frmCombinations

    Private Sub frmCombinations_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadCombo()
    End Sub

    Sub LoadCombo()

        Dim lstResult As List(Of Struct.Loteria)
        Dim itnData As New ItemData

        Using objBusiness As TorchWood.Core.Data.Loterias = New TorchWood.Core.Data.Loterias("torchConn")
            lstResult = objBusiness.List
            objBusiness.Dispose()
        End Using

        If Not IsNothing(lstResult) AndAlso lstResult.Count > 0 Then

            For Each itnDados As Struct.Loteria In lstResult
                Me.ddlLoterias.Items.Add(itnDados)
            Next

            itnData.Dispose()
            itnData = Nothing
            lstResult = Nothing

        End If

    End Sub

End Class