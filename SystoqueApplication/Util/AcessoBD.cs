using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace SystoqueApplication.Util
{
    public class AcessoBD
    {
        MySqlConnection connection = new MySqlConnection();
        public MySqlConnection abreconexao()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SystoqueDB"].ConnectionString;
            connection.ConnectionString = connectionString;
            connection.Open();

            return connection;
        }

        public void ComandoSQL(string sql)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = sql;
            comando.Connection = abreconexao();
            comando.ExecuteNonQuery();
            connection.Close();
            connection.Dispose();
        }

     

        public DataTable Consulta(string sql)
        {
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, abreconexao());
            dataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }
    }
}