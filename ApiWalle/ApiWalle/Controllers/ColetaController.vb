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

    End Class


End Namespace