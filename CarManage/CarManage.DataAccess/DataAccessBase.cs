using System;
using System.Collections.Generic;
using System.Data;

using MySql.Data.MySqlClient;

using ClassLibrary.Configuration;

namespace CarManage.DataAccess.MySql
{
    public class DataAccessBase
    {
        private string connectionString = CarManageConfig.Instance.ConnectionString;

        protected IDbConnection CreateConnection()
        {
            IDbConnection connection = new MySqlConnection(connectionString);
            return connection;
        }

        protected IDbConnection CreateConnection(string connectionString)
        {
            IDbConnection connection = new MySqlConnection(connectionString);
            return connection;
        }

        protected IDbConnection CreateConnection(bool open)
        {
            IDbConnection connection = new MySqlConnection(connectionString);

            if (open)
                connection.Open();

            return connection;
        }

        protected IDbConnection CreateConnection(string connectionString, bool open)
        {
            IDbConnection connection = new MySqlConnection(connectionString);

            if (open)
                connection.Open();

            return connection;
        }
    }
}
