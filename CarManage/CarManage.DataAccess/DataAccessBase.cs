using System;
using System.Collections.Generic;
using System.Data;

using MySql.Data.MySqlClient;

using ClassLibrary.Configuration;
using Dapper;
using DapperExtensions;

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

        protected void CloseConnection(IDbConnection connection)
        {
            if (connection != null && connection.State.Equals(ConnectionState.Open))
                connection.Close();
        }

        protected IDbTransaction BeginTransaction(IDbConnection connection)
        {
            return connection.BeginTransaction();
        }

        protected void Commit(IDbTransaction transaction)
        {
            transaction.Commit();
        }

        protected void Rollback(IDbTransaction transaction)
        {
            transaction.Rollback();
        }

        protected IDbCommand CreateCommand(string commandText)
        {
            return new MySqlCommand(commandText);
        }


        protected IDbCommand CreateCommand(string commandText, IDbConnection connection)
        {
            MySqlConnection conn = connection as MySqlConnection;

            return new MySqlCommand(commandText, conn);
        }


        protected IDbCommand CreateCommand(string commandText, IDbConnection connection, IDbTransaction transaction)
        {
            MySqlConnection conn = connection as MySqlConnection;
            MySqlTransaction tran = transaction as MySqlTransaction;

            return new MySqlCommand(commandText, conn, tran);
        }


        protected void ExecuteNonQuery(string commandText, IDbConnection connection)
        {
            //connection.exe
        }

        protected void ExecuteNonQuery(IDbCommand command)
        {
            command.ExecuteNonQuery();
            //new MySqlCommand()
        }
    }
}
