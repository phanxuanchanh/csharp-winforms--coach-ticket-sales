using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BanVeXeKhach.SqlServer
{
    public partial class SqlExecution : IDisposable
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlDataAdapter;
        private SqlMapping sqlMapping;
        private bool _disposed;

        public SqlExecution()
        {
            _disposed = false;
            sqlConnection = new SqlConnection(SqlConfig.ConnnecionString);
            sqlCommand = sqlConnection.CreateCommand();
            sqlMapping = new SqlMapping();
        }

        public void Connect()
        {
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
        }

        public void Disconnect()
        {
            if (sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
        }

        public void SetCommand(string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            sqlCommand.Parameters.Clear();

            sqlCommand.CommandType = commandType;
            sqlCommand.CommandText = commandText;
            if (sqlParameters != null)
                sqlCommand.Parameters.AddRange(sqlParameters);
        }

        public int ExecuteNonQuery(string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            if (string.IsNullOrEmpty(commandText))
                throw new Exception("@'commandText' must not be null or empty");

            Connect();
            SetCommand(commandText, commandType, sqlParameters);
            return sqlCommand.ExecuteNonQuery();
        }

        public object ExecuteScalar(string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            if (string.IsNullOrEmpty(commandText))
                throw new Exception("@'commandText' must not be null or empty");

            Connect();
            SetCommand(commandText, commandType, sqlParameters);
            return sqlCommand.ExecuteScalar();
        }

        public SqlDataReader ExecuteReader(string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            if (string.IsNullOrEmpty(commandText))
                throw new Exception("@'commandText' must not be null or empty");

            Connect();
            SetCommand(commandText, commandType, sqlParameters);
            return sqlCommand.ExecuteReader();
        }

        public DataSet GetDataSet(string commandText, string srcTable, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            if (string.IsNullOrEmpty(commandText))
                throw new Exception("@'commandText' must not be null or empty");

            SetCommand(commandText, commandType, sqlParameters);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, srcTable);
            return dataSet;
        }

        public DataTable GetDataTable(string tableName, string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            DataSet dataSet = GetDataSet(commandText, tableName, commandType, sqlParameters);
            return dataSet.Tables[tableName];
        }

        public int UpdateDataSet(DataSet dataSet)
        {
            if (dataSet == null)
                throw new Exception("@'dataSet' must not be null or empty");

            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            return sqlDataAdapter.Update(dataSet);
        }

        public int UpdateDataTable(DataTable dataTable)
        {
            if (dataTable == null)
                throw new Exception("@'dataTable' must not be null or empty");

            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            return sqlDataAdapter.Update(dataTable);
        }

        public T To<T>(string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            SqlDataReader sqlDataReader = null;
            try
            {
                sqlDataReader = ExecuteReader(commandText, commandType, sqlParameters);
                sqlMapping.SqlDataReader = sqlDataReader;
                return sqlMapping.To<T>();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred during data mapping", ex);
            }
            finally
            {
                if (sqlDataReader != null)
                    sqlDataReader.Close();
            }
        }

        public List<T> ToList<T>(string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            SqlDataReader sqlDataReader = null;
            try
            {
                sqlDataReader = ExecuteReader(commandText, commandType, sqlParameters);
                sqlMapping.SqlDataReader = sqlDataReader;
                return sqlMapping.ToList<T>();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred during data mapping", ex);
            }
            finally
            {
                if (sqlDataReader != null)
                    sqlDataReader.Close();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    sqlCommand.Dispose();
                    sqlConnection.Dispose();
                }
            }
            _disposed = true;
        }
    }
}
