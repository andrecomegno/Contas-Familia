using MySql.Data.MySqlClient;

namespace Contas_Familia.Script
{
    class configdb
    {
        private MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; database = FamilyPayDay; password = 123456");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
