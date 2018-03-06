Option Strict Off
Imports MySql.Data.MySqlClient
Imports System.Text

Public Class Class_Coleta_DAO

    Private BD As New Connection

    Public Function Insert(ByVal Lista As List(Of Class_Coleta)) As List(Of String)

        Dim Conn As New MySqlConnection
        Dim Command As MySqlCommand
        Dim Retorno As String = String.Empty
        Dim ListaRetorno As New List(Of String)

        Try

            Conn = BD.GetConexao()

            For Each Item As Class_Coleta In Lista

                Try

                    Dim Sql As New StringBuilder

                    Sql.Append("INSERT INTO Db_Walle_v4.tb_coleta (Cod_Cliente, Des_Usuario_Rede, Des_Processo, Cod_Categoria_App, Des_Nome, Cod_Categoria_Page, " &
                             "Des_URL, Cod_Categoria_url, Des_Local, Date_Hora_Inicio, Date_Hora_Fim, Int_Tempo, Des_Identificador_PC, Des_Chave_Processo, " &
                             "Cod_Cliente_Usuario, Des_Versao, Des_Rastrear) VALUES (@Cod_Cliente, @Des_Usuario_Rede, @Des_Processo, @Cod_Categoria_App, " &
                             "@Des_Nome, @Cod_Categoria_Page, @Des_URL, @Cod_Categoria_url, @Des_Local, @Date_Hora_Inicio, @Date_Hora_Fim, @Int_Tempo, " &
                             "@Des_Identificador_PC, @Des_Chave_Processo, @Cod_Cliente_Usuario, @Des_Versao, @Des_Rastrear)")

                    Command = New MySqlCommand
                    Command.Connection = Conn
                    Command.CommandType = CommandType.Text
                    Command.CommandText = Sql.ToString

                    Command.Parameters.AddWithValue("@Cod_Cliente", Item.Cod_Cliente)
                    Command.Parameters.AddWithValue("@Des_Usuario_Rede", Item.Des_Usuario_Rede)
                    Command.Parameters.AddWithValue("@Des_Processo", Item.Des_Processo)
                    Command.Parameters.AddWithValue("@Cod_Categoria_App", DBNull.Value)
                    Command.Parameters.AddWithValue("@Des_Nome", Item.Des_Nome)
                    Command.Parameters.AddWithValue("@Cod_Categoria_Page", DBNull.Value)
                    Command.Parameters.AddWithValue("@Des_URL", Item.Des_URL)
                    Command.Parameters.AddWithValue("@Cod_Categoria_url", DBNull.Value)
                    Command.Parameters.AddWithValue("@Des_Local", Item.Des_Local)
                    Command.Parameters.AddWithValue("@Date_Hora_Inicio", Item.Date_Hora_Inicio)
                    Command.Parameters.AddWithValue("@Date_Hora_Fim", Item.Date_Hora_Fim)
                    Command.Parameters.AddWithValue("@Int_Tempo", Item.Int_Tempo)
                    Command.Parameters.AddWithValue("@Des_Identificador_PC", Item.Des_Identificador_PC)
                    Command.Parameters.AddWithValue("@Des_Chave_Processo", Item.Des_Chave_Processo)
                    Command.Parameters.AddWithValue("@Cod_Cliente_Usuario", DBNull.Value)
                    Command.Parameters.AddWithValue("@Des_Versao", Item.Des_Versao)
                    Command.Parameters.AddWithValue("@Des_Rastrear", Item.Des_Rastrear)

                    Command.ExecuteNonQuery()

                    Retorno = Lista.IndexOf(Item).ToString & " - Sucesso"

                Catch ex As Exception

                    Retorno = Lista.IndexOf(Item).ToString & " - " & ex.Message

                End Try

                ListaRetorno.Add(Retorno)
            Next

        Catch ex As Exception

            Retorno = ex.Message
            ListaRetorno.Add(Retorno)
            'Log de erro do insert do dado

        Finally

            BD.CloseConexao(Conn)

        End Try

        Return ListaRetorno


    End Function


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

            BD.CloseConexao(Conn)

        End Try

        Return Lista


    End Function





End Class
