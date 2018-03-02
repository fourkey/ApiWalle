Public Interface IColetaRepositorio

    Function GetTodos() As IEnumerable(Of Class_Coleta)
    Function GetPorID(Cod_Coleta As Integer) As Class_Coleta
    Function Adicionar(Obj As Class_Coleta) As Class_Coleta
    Sub Remover(Cod_Coleta As Integer)
    Function Atualizar(Obj As Class_Coleta) As Boolean

End Interface
