'Enuns

'Consts
Module Principal

    'erros
    Friend Const ERR_BIG_OCCURS As String = "Quantidade de itens � superior a capacidade que se possa combinar para esta quantidade de mem�ria dispon�vel."
    Friend Const ERR_DIV_ZERO As String = "N�o est� sendo poss�vel calcular a probabilidade de um evento qualquer para nenhuma totalidade de eventos e amostra. Est� sendo obtido divis�o de qualquer valor por ZERO!"


    'combinatoria
    'Friend Const TAG_SENHA As String = "tonhao"
    Friend Const TAG_SEPARADOR As String = ",;-"
    Friend Const TAG_COL_INIC As Integer = 3


End Module

Interface ICadastro
    Inherits IDisposable

    Function Add() As Boolean
    Function Del() As Boolean
    Function [Get]() As Boolean
    Function List() As DataTable
    Function Update() As Boolean

End Interface

Interface ITorchWood
    Inherits IDisposable

    Property Key() As String

End Interface

