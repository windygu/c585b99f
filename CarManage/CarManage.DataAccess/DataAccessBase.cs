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


        protected int ExecuteNonQuery(string commandText, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                IDbCommand command = new MySqlCommand(commandText);
                command.Connection = connection;

                return command.ExecuteNonQuery();
            }
        }

        protected int ExecuteNonQuery(IDbCommand command)
        {
            if (command.Connection == null)
            {
                using (IDbConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    command.Connection = connection;

                    return command.ExecuteNonQuery();
                }
            }
            else
            {
                return command.ExecuteNonQuery();
            }
        }

        protected int ExecuteNonQuery(string connectionString, IDbCommand command)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;

                return command.ExecuteNonQuery();
            }
        }

        protected int ExecuteNonQuery(string commandText, IDbConnection connection)
        {
            if (connection.State.Equals(ConnectionState.Closed))
                connection.Open();

            IDbCommand command = new MySqlCommand(commandText);
            command.Connection = connection;

            return command.ExecuteNonQuery();
        }

        protected int ExecuteNonQuery(IDbConnection connection, IDbCommand command)
        {
            if (connection.State.Equals(ConnectionState.Closed))
                connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            return command.ExecuteNonQuery();
        }

        protected int ExecuteNonQuery(string commandText, IDbConnection connection, IDbTransaction transaction)
        {
            if (connection.State.Equals(ConnectionState.Closed))
                connection.Open();

            if (transaction == null)
                transaction = connection.BeginTransaction();

            IDbCommand command = new MySqlCommand(commandText);
            command.Connection = connection;
            command.Transaction = transaction;

            return command.ExecuteNonQuery();
        }

        protected int ExecuteNonQuery(IDbConnection connection, IDbTransaction transaction, IDbCommand command)
        {
            if (connection.State.Equals(ConnectionState.Closed))
                connection.Open();

            if (transaction == null)
                transaction = connection.BeginTransaction();

            command.Connection = connection;
            command.Transaction = transaction;

            return command.ExecuteNonQuery();
        }

        protected int Execute(string commandText, IDbConnection connection, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null, object param = null)
        {
            if (connection.State.Equals(ConnectionState.Closed))
                connection.Open();

            return connection.Execute(commandText, param, transaction, commandTimeout, commandType);
        }

        protected object ExecuteScalar(string commandText, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                IDbCommand command = new MySqlCommand(commandText);
                command.Connection = connection;

                return command.ExecuteScalar();
            }
        }

        protected object ExecuteScalar(IDbCommand command)
        {
            if (command.Connection == null)
            {
                using (IDbConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    command.Connection = connection;

                    return command.ExecuteScalar();
                }
            }
            else
            {
                return command.ExecuteScalar();
            }
        }

        protected object ExecuteScalar(string connectionString, IDbCommand command)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;

                return command.ExecuteScalar();
            }
        }

        protected object ExecuteScalar(string commandText, IDbConnection connection)
        {
            if (connection.State.Equals(ConnectionState.Closed))
                connection.Open();

            IDbCommand command = new MySqlCommand(commandText);
            command.Connection = connection;

            return command.ExecuteScalar();
        }

        protected object ExecuteScalar(IDbConnection connection, IDbCommand command)
        {
            if (connection.State.Equals(ConnectionState.Closed))
                connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            return command.ExecuteScalar();
        }

        protected object ExecuteScalar(string commandText, IDbConnection connection, IDbTransaction transaction)
        {
            if (connection.State.Equals(ConnectionState.Closed))
                connection.Open();

            if (transaction == null)
                transaction = connection.BeginTransaction();

            IDbCommand command = new MySqlCommand(commandText);
            command.Connection = connection;
            command.Transaction = transaction;

            return command.ExecuteScalar();
        }

        protected object ExecuteScalar(IDbConnection connection, IDbTransaction transaction, IDbCommand command)
        {
            if (connection.State.Equals(ConnectionState.Closed))
                connection.Open();

            if (transaction == null)
                transaction = connection.BeginTransaction();

            command.Connection = connection;
            command.Transaction = transaction;

            return command.ExecuteScalar();
        }

        public object ExecuteObject(string commandText, IDbConnection connection, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null, object param = null)
        {
            if (connection.State.Equals(ConnectionState.Closed))
                connection.Open();

            return connection.ExecuteScalar(commandText, param, transaction, commandTimeout, commandType);
        }

        public T ExecuteObject<T>(string commandText, IDbConnection connection, IDbTransaction transaction = null,
           int? commandTimeout = null, CommandType? commandType = null, object param = null)
        {
            if (connection.State.Equals(ConnectionState.Closed))
                connection.Open();

            return connection.ExecuteScalar<T>(commandText, param, transaction, commandTimeout, commandType);
        }

        protected IDataReader ExecuteReader(string commandText, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                IDbCommand command = new MySqlCommand(commandText);
                command.Connection = connection;

                return command.ExecuteReader();
            }
        }

        protected IDataReader ExecuteReader(IDbCommand command)
        {
            if (command.Connection == null)
            {
                using (IDbConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    command.Connection = connection;

                    return command.ExecuteReader();
                }
            }
            else
            {
                return command.ExecuteReader();
            }
        }

        protected IDataReader ExecuteReader(string connectionString, IDbCommand command)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;

                return command.ExecuteReader();
            }
        }

        protected IDataReader ExecuteReader(string commandText, IDbConnection connection)
        {
            if (connection.State.Equals(ConnectionState.Closed))
                connection.Open();

            IDbCommand command = new MySqlCommand(commandText);
            command.Connection = connection;

            return command.ExecuteReader();
        }

        protected IDataReader ExecuteReader(IDbConnection connection, IDbCommand command)
        {
            if (connection.State.Equals(ConnectionState.Closed))
                connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            return command.ExecuteReader();
        }

        protected IDataReader ExecuteReader(IDbConnection connection, IDbTransaction transaction, IDbCommand command)
        {
            if (connection.State.Equals(ConnectionState.Closed))
                connection.Open();

            if (transaction == null)
                transaction = connection.BeginTransaction();

            command.Connection = connection;
            command.Transaction = transaction;

            return command.ExecuteReader();
        }

        public IDataReader ExecuteResult(string commandText, IDbConnection connection, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null, object param = null)
        {
            if (connection.State.Equals(ConnectionState.Closed))
                connection.Open();

            return connection.ExecuteReader(commandText, param, transaction, commandTimeout, commandType);
        }

        public IEnumerable<T> Query<T>(string commandText, IDbConnection connection, IDbTransaction transaction = null,
            bool buffered = true, int? commandTimeout = null, CommandType? commandType = null, object param = null)
        {
            if (connection.State.Equals(ConnectionState.Closed))
                connection.Open();

            return connection.Query<T>(commandText, param, transaction, buffered, commandTimeout, commandType);
        }

        public IEnumerable<dynamic> Query(string commandText, IDbConnection connection, IDbTransaction transaction = null,
            bool buffered = true, int? commandTimeout = null, CommandType? commandType = null, object param = null)
        {
            if (connection.State.Equals(ConnectionState.Closed))
                connection.Open();

            return connection.Query(commandText, param, transaction, buffered, commandTimeout, commandType);
        }

        public IEnumerable<object> Query(Type type, string commandText, IDbConnection connection,
            IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null,
            CommandType? commandType = null, object param = null)
        {
            return connection.Query(type, commandText, param, transaction, buffered, commandTimeout, commandType);
        }

        public static IEnumerable<TReturn> Query<TFirst, TSecond, TReturn>(string commandText,
            Func<TFirst, TSecond, TReturn> map, IDbConnection connection, IDbTransaction transaction = null,
            bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null,
            object param = null)
        {
            return connection.Query(commandText, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public static IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(string commandText,
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, IDbConnection connection,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null,
            CommandType? commandType = null, object param = null)
        {
            return connection.Query(commandText, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public static IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(string commandText,
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, IDbConnection connection,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null,
            CommandType? commandType = null, object param = null)
        {
            return connection.Query(commandText, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public static IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(string commandText,
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, IDbConnection connection,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null,
            CommandType? commandType = null, object param = null)
        {
            return connection.Query(commandText, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public static IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TReturn>(string commandText,
            Func<TFirst, TSecond, TThird, TFourth, TReturn> map, IDbConnection connection, IDbTransaction transaction = null,
            bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null,
            object param = null)
        {
            return connection.Query(commandText, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public static IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TReturn>(string commandText,
            Func<TFirst, TSecond, TThird, TReturn> map, IDbConnection connection, IDbTransaction transaction = null,
            bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null,
            object param = null)
        {
            return connection.Query(commandText, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        //public IEnumerable<TReturn> Query<TReturn>(string commandText, Type[] types, Func<object[], TReturn> map,
        //    IDbConnection connection, IDbTransaction transaction = null, bool buffered = true,
        //    string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null, dynamic param = null)
        //{
        //    if (connection.State.Equals(ConnectionState.Closed))
        //        connection.Open();

        //    return connection.Query<TReturn>(commandText, types, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        //}
        //public static SqlMapper.GridReader QueryMultiple(this IDbConnection cnn, CommandDefinition command);
        //public static SqlMapper.GridReader QueryMultiple(this IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
    }
}
