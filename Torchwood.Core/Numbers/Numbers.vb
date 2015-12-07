Imports Torchwood.Struct.Combinacoes
Imports Consumer.Math.Stats

Namespace Business
    Public Class Numbers
        Implements INumbers

        Public Function CombineMegaSena() As IList(Of MegaSena) Implements INumbers.CombineMegaSena

            Dim oList As IList(Of MegaSena)
            Dim strDezenas As String
            Dim objCalc As New Combinatory
            Dim oArray As List(Of String)
            Dim aStrItens As String()
            Dim objSena As MegaSena
            strDezenas = ""

            For intContador As Integer = 1 To 60
                strDezenas = strDezenas + intContador.ToString() + ";"
            Next

            oList = New List(Of MegaSena)
            oArray = objCalc.CombinarValores(strDezenas, 6)

            For Each strItens As String In oArray
                'trocando "-" "." "," por ";".
                strItens = strItens.Replace(","c, ";"c)
                strItens = strItens.Replace("-"c, ";"c)
                strItens = strItens.Replace("."c, ";"c)

                'gerando o array
                aStrItens = strItens.Split(";"c)

                'gerando uma classe com as dezenas combinadas
                objSena = New MegaSena()
                objSena.Dezena01 = Convert.ToInt16(aStrItens(0))
                objSena.Dezena02 = Convert.ToInt16(aStrItens(1))
                objSena.Dezena03 = Convert.ToInt16(aStrItens(2))
                objSena.Dezena04 = Convert.ToInt16(aStrItens(3))
                objSena.Dezena05 = Convert.ToInt16(aStrItens(4))
                objSena.Dezena06 = Convert.ToInt16(aStrItens(5))

                'adicionando os itens na coleção que será devolvida
                oList.Add(objSena)
            Next

            Return oList

        End Function

        Public Function CombineLotoFacil() As IList(Of LotoFacil) Implements INumbers.CombineLotoFacil

            Dim oList As IList(Of LotoFacil)
            Dim strDezenas As String
            Dim objCalc As New Combinatory
            Dim oArray As List(Of String)
            Dim aStrItens As String()
            Dim objLotoFacil As LotoFacil
            strDezenas = ""

            For intContador As Integer = 1 To 25
                strDezenas = strDezenas + intContador.ToString() + ";"
            Next

            oList = New List(Of LotoFacil)
            oArray = objCalc.CombinarValores(strDezenas, 15)

            For Each strItens As String In oArray
                'trocando "-" "." "," por ";".
                strItens = strItens.Replace(","c, ";"c)
                strItens = strItens.Replace("-"c, ";"c)
                strItens = strItens.Replace("."c, ";"c)

                'gerando o array
                aStrItens = strItens.Split(";"c)

                'gerando uma classe com as dezenas combinadas
                objLotoFacil = New LotoFacil()
                objLotoFacil.Dezena01 = Convert.ToInt16(aStrItens(0))
                objLotoFacil.Dezena02 = Convert.ToInt16(aStrItens(1))
                objLotoFacil.Dezena03 = Convert.ToInt16(aStrItens(2))
                objLotoFacil.Dezena04 = Convert.ToInt16(aStrItens(3))
                objLotoFacil.Dezena05 = Convert.ToInt16(aStrItens(4))
                objLotoFacil.Dezena06 = Convert.ToInt16(aStrItens(5))
                objLotoFacil.Dezena07 = Convert.ToInt16(aStrItens(6))
                objLotoFacil.Dezena08 = Convert.ToInt16(aStrItens(7))
                objLotoFacil.Dezena09 = Convert.ToInt16(aStrItens(8))
                objLotoFacil.Dezena10 = Convert.ToInt16(aStrItens(9))
                objLotoFacil.Dezena11 = Convert.ToInt16(aStrItens(10))
                objLotoFacil.Dezena12 = Convert.ToInt16(aStrItens(11))
                objLotoFacil.Dezena13 = Convert.ToInt16(aStrItens(12))
                objLotoFacil.Dezena14 = Convert.ToInt16(aStrItens(13))
                objLotoFacil.Dezena15 = Convert.ToInt16(aStrItens(14))

                'adicionando os itens na coleção que será devolvida
                oList.Add(objLotoFacil)
            Next

            Return oList

        End Function

    End Class
End Namespace
