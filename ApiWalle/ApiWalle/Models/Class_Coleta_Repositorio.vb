Imports ApiWalle

Public Class Class_Coleta_Repositorio

    Implements IColetaRepositorio

    Dim DAO As New Class_Coleta_DAO

    Public Sub Remover(Cod_Coleta As Integer) Implements IColetaRepositorio.Remover
        Throw New NotImplementedException()
    End Sub

    Public Function GetTodos() As IEnumerable(Of Class_Coleta) Implements IColetaRepositorio.GetTodos

        Return DAO.ListAll("SELECT * FROM Db_Walle_v4.tb_coleta ORDER BY Cod_Coleta DESC LIMIT 10")

    End Function

    Public Function GetPorID(Cod_Coleta As Integer) As Class_Coleta Implements IColetaRepositorio.GetPorID
        Throw New NotImplementedException()
    End Function

    Public Function Adicionar(Obj As List(Of Class_Coleta)) As List(Of String) Implements IColetaRepositorio.Adicionar

        Dim Status As List(Of String)
        Status = DAO.Insert(Obj)
        Return Status

    End Function

    Public Function Atualizar(Obj As Class_Coleta) As Boolean Implements IColetaRepositorio.Atualizar
        Throw New NotImplementedException()
    End Function

End Class
