Imports MySql.Data.MySqlClient

Public Class Connection


    ''' <summary>
    ''' Abre a conexao com o banco de dados do sistema
    ''' </summary>
    ''' <returns></returns>
    Public Function GetConexao() As MySqlConnection

        Try

            Dim Conexao As New MySqlConnection

            Conexao.ConnectionString = "Server=dbwallev4.c6amkagluzst.us-east-2.rds.amazonaws.com;Port=3306;Database=Db_Walle_v4;Uid=admin_walle;Pwd='bgt5BGT%'"

            Conexao.Open()

            Return Conexao

        Catch ex As Exception

            'Log de erro de abertura de conexao
            Throw

        End Try

    End Function


    ''' <summary>
    ''' Fecha a conexao com o banco de dados de acordo com a conexao informada
    ''' </summary>
    ''' <param name="Conexao"></param>
    Public Sub CloseConexao(ByVal Conexao As MySqlConnection)

        Try

            If Conexao.State = ConnectionState.Open Then
                Conexao.Close()
            End If

        Catch ex As Exception

            'Log de erro de fechamento de conexao

        End Try

    End Sub

End Class
