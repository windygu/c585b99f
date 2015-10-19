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

        protected IDbConnection CreateConnection(string connectionString, bool open = false)
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

        protected IDbCommand CreateCommand(string commandText, IDbConnection connection = null,
            IDbTransaction transaction = null)
        {
            IDbCommand command = new MySqlCommand(commandText);

            if (connection != null)
                command.Connection = connection;

            if (transaction != null)
                command.Transaction = transaction;

            return command;
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

        protected int ExecuteNonQuery(string commandText, IDbConnection connection, IDbTransaction transaction = null)
        {
            if (connection.State.Equals(ConnectionState.Closed))
                connection.Open();

            IDbCommand command = new MySqlCommand(commandText);
            command.Connection = connection;

            if (transaction != null)
                command.Transaction = transaction;

            return command.ExecuteNonQuery();
        }

        protected int ExecuteNonQuery(IDbConnection connection, IDbCommand command, IDbTransaction transaction = null)
        {
            if (connection.State.Equals(ConnectionState.Closed))
                connection.Open();

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

        public IEnumerable<TReturn> Query<TFirst, TSecond, TReturn>(string commandText,
            Func<TFirst, TSecond, TReturn> map, IDbConnection connection, IDbTransaction transaction = null,
            bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null,
            object param = null)
        {
            return connection.Query(commandText, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TReturn>(string commandText,
            Func<TFirst, TSecond, TThird, TReturn> map, IDbConnection connection, IDbTransaction transaction = null,
            bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null,
            object param = null)
        {
            return connection.Query(commandText, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TReturn>(string commandText,
            Func<TFirst, TSecond, TThird, TFourth, TReturn> map, IDbConnection connection, IDbTransaction transaction = null,
            bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null,
            object param = null)
        {
            return connection.Query(commandText, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(string commandText,
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, IDbConnection connection,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null,
            CommandType? commandType = null, object param = null)
        {
            return connection.Query(commandText, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(string commandText,
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, IDbConnection connection,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null,
            CommandType? commandType = null, object param = null)
        {
            return connection.Query(commandText, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(string commandText,
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, IDbConnection connection,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null,
            CommandType? commandType = null, object param = null)
        {
            return connection.Query(commandText, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TReturn>(string commandText, Type[] types, Func<object[], TReturn> map,
            IDbConnection connection, IDbTransaction transaction = null, bool buffered = true,
            string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null, object param = null)
        {
            if (connection.State.Equals(ConnectionState.Closed))
                connection.Open();

            return connection.Query<TReturn>(commandText, types, map, param, transaction,
                buffered, splitOn, commandTimeout, commandType);
        }

        public SqlMapper.GridReader QueryMultiple(string commandText, IDbConnection connection,
            IDbTransaction transaction = null, object param = null, int? commandTimeout = null,
                CommandType? commandType = null)
        {
            return connection.QueryMultiple(commandText, param, transaction, commandTimeout, commandType);
        }

        public dynamic Insert<T>(T entity, IDbConnection connection, IDbTransaction transaction = null,
            int? commandTimeout = null) where T : class
        {
            return connection.Insert<T>(entity, transaction, commandTimeout);
        }

        public void Insert<T>(IEnumerable<T> entities, IDbConnection connection,
            IDbTransaction transaction = null, int? commandTimeout = null) where T : class
        {
            connection.Insert<T>(entities, transaction, commandTimeout);
        }

        public bool Delete<T>(object predicate, IDbConnection connection, IDbTransaction transaction = null,
            int? commandTimeout = null) where T : class
        {
            return connection.Delete<T>(predicate, transaction, commandTimeout);
        }
        public bool Delete<T>(T entity, IDbConnection connection, IDbTransaction transaction = null,
            int? commandTimeout = null) where T : class
        {
            return connection.Delete<T>(entity, transaction, commandTimeout);
        }

        public bool Update<T>(T entity, IDbConnection connection, IDbTransaction transaction = null,
            int? commandTimeout = null) where T : class
        {
            return connection.Update<T>(entity, transaction, commandTimeout);
        }

        public T Get<T>(object id, IDbConnection connection, IDbTransaction transaction = null,
            int? commandTimeout = null) where T : class
        {
            return connection.Get<T>(id, transaction, commandTimeout);
        }

        public IEnumerable<T> GetList<T>(IDbConnection connection, object predicate = null,
            IList<ISort> sort = null, IDbTransaction transaction = null,
            int? commandTimeout = null, bool buffered = false) where T : class
        {
            return connection.GetList<T>(predicate, sort, transaction, commandTimeout, buffered);
        }

        public static int Count<T>(object predicate, IDbConnection connection, IDbTransaction transaction = null,
            int? commandTimeout = null) where T : class
        {
            return connection.Count<T>(predicate, transaction, commandTimeout);
        }
    }
}
