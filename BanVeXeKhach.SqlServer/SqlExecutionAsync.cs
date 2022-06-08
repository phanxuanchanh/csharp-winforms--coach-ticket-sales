using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BanVeXeKhach.SqlServer
{
    public partial class SqlExecution
    {
        public async Task ConnectAsync()
        {
            if (sqlConnection.State == ConnectionState.Closed)
                await sqlConnection.OpenAsync();
        }

        public async Task<int> ExecuteNonQueryAsync(string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            if (string.IsNullOrEmpty(commandText))
                throw new Exception("@'commandText' must not be null or empty");

            Connect();
            SetCommand(commandText, commandType, sqlParameters);
            return await sqlCommand.ExecuteNonQueryAsync();
        }

        public async Task<object> ExecuteScalarAsync(string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            if (string.IsNullOrEmpty(commandText))
                throw new Exception("@'commandText' must not be null or empty");

            Connect();
            SetCommand(commandText, commandType, sqlParameters);
            return await sqlCommand.ExecuteScalarAsync();
        }

        public async Task<SqlDataReader> ExecuteReaderAsync(string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            if (string.IsNullOrEmpty(commandText))
                throw new Exception("@'commandText' must not be null or empty");

            Connect();
            SetCommand(commandText, commandType, sqlParameters);
            return await sqlCommand.ExecuteReaderAsync();
        }

        public async Task<T> ToAsync<T>(string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            SqlDataReader sqlDataReader = null;
            try
            {
                sqlDataReader = await ExecuteReaderAsync(commandText, commandType, sqlParameters);
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

        public async Task<List<T>> ToListAsync<T>(string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            SqlDataReader sqlDataReader = null;
            try
            {
                sqlDataReader = await ExecuteReaderAsync(commandText, commandType, sqlParameters);
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
    }
}
