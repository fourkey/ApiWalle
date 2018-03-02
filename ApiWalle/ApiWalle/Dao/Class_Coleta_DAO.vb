Imports MySql.Data.MySqlClient
Imports System.Text

Public Class Class_Coleta_DAO

    Private BD As New Connection

    Public Function ListAll(ByVal Sql As String) As List(Of Class_Coleta)

        Dim Lista As New List(Of Class_Coleta)
        Dim Conn As New MySqlConnection
        Dim Command As New MySqlCommand
        Dim Reader As MySqlDataReader
        Dim Item As New Class_Coleta

        Try

            Conn = BD.GetConexao()

            Command.Connection = Conn
            Command.CommandType = CommandType.Text
            Command.CommandText = Sql
            Command.CommandTimeout = 1000

            Reader = Command.ExecuteReader()

            If (Reader.HasRows() = True) Then
                While Reader.Read()

                    Item = New Class_Coleta With {
                        .Cod_Coleta = Reader("Cod_Coleta"),
                        .Cod_Cliente = Reader("Cod_Cliente"),
                        .Des_Usuario_Rede = Reader("Des_Usuario_Rede").ToString,
                        .Des_Processo = Reader("Des_Processo").ToString,
                        .Cod_Categoria_App = IIf(IsDBNull(Reader("Cod_Categoria_App")), 0, Reader("Cod_Categoria_App")),
                        .Des_Nome = Reader("Des_Nome").ToString,
                        .Cod_Categoria_Page = IIf(IsDBNull(Reader("Cod_Categoria_Page")), 0, Reader("Cod_Categoria_Page")),
                        .Des_URL = Reader("Des_URL").ToString,
                        .Cod_Categoria_Url = IIf(IsDBNull(Reader("Cod_Categoria_url")), 0, Reader("Cod_Categoria_url")),
                        .Des_Local = Reader("Des_Local"),
                        .Date_Hora_Inicio = Reader("Date_Hora_Inicio"),
                        .Date_Hora_Fim = Reader("Date_Hora_Fim"),
                        .Int_Tempo = IIf(IsDBNull(Reader("Int_Tempo")), 0, Reader("Int_Tempo")),
                        .Des_Identificador_PC = Reader("Des_Identificador_PC").ToString,
                        .Des_Chave_Processo = Reader("Des_Chave_Processo").ToString,
                        .Cod_Cliente_Usuario = IIf(IsDBNull(Reader("Cod_Cliente_Usuario")), 0, Reader("Cod_Cliente_Usuario")),
                        .Des_Versao = Reader("Des_Versao").ToString,
                        .Des_Rastrear = Reader("Des_Rastrear").ToString
                    }

                    Lista.Add(Item)
                    
                End While
            End If

        Catch ex As Exception

            'Log de erro do retriave da lista

        Finally


        End Try

        Return Lista


    End Function





End Class
