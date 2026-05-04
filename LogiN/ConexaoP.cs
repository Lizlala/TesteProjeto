using System;
using MySql.Data.MySqlClient;

namespace LogiN
{
    internal class ConexaoP
    {
        private string connectionString = "server=localhost;database=Projeto;uid=root;pwd=;";

        public MySqlConnection Conectar()
        {
            return new MySqlConnection(connectionString);
        }
    }
}