using BanVeXeKhach.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeXeKhach.BUS_DAO.DAO
{
    public class DataAccessConfiguration
    {
        private static SqlExecution sqlExecution;

        public static SqlExecution GetSqlExecution()
        {
            SqlConfig.ReadConfigFile("QuanLyBanVeXe");

            if (sqlExecution == null)
                sqlExecution = new SqlExecution();

            return sqlExecution;
        }

        public static void Dispose()
        {
            if (sqlExecution != null)
                sqlExecution.Dispose();
        }
    }
}
