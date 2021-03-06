using MySql.Data.MySqlClient;
using System;
using System.Data;

public class ConexaoMySql
{
    static MySqlConnection conexao = new MySqlConnection()
    {
        ConnectionString = "server=localhost;User Id=meu usuario;database=petshop; password=minha senha"
    };

    public static void ComandoSemRetorno(string query)
    {

        try
        {
            conexao.Open();
            MySqlCommand Command = new MySqlCommand(query, conexao);
            Command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally 
        {
            conexao.Close();
        }

    }
    public static DataTable ComandoComRetorno(string query)
    {
        DataTable dtRetorno = new DataTable();

        try
        {
            conexao.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexao);
            adapter.Fill(dtRetorno);

        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            conexao.Close();
        }

        return dtRetorno;
    }

}