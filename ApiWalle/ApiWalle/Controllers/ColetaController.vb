Imports System.Net
Imports System.Net.Http
Imports System.Web.Http

Namespace Controllers
    Public Class ColetaController
        Inherits ApiController

        Shared ReadOnly repository As IColetaRepositorio = New Class_Coleta_Repositorio()

        Public Function GetAllColeta() As IEnumerable(Of Class_Coleta)
            Return repository.GetTodos()
        End Function

        Public Function PostColeta(item As List(Of Class_Coleta)) As List(Of String)
            Return repository.Adicionar(item)
        End Function

    End Class


End Namespace