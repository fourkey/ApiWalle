Public Interface IColetaRepositorio

    Function GetTodos() As IEnumerable(Of Class_Coleta)
    Function GetPorID(Cod_Coleta As Integer) As Class_Coleta
    Function Adicionar(Obj As List(Of Class_Coleta)) As List(Of String)
    Sub Remover(Cod_Coleta As Integer)
    Function Atualizar(Obj As Class_Coleta) As Boolean

End Interface
