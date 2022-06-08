using System.Configuration;

namespace BanVeXeKhach.SqlServer
{
    
    public class SqlConfig
    {
        public static string ConnnecionString;

        public static void ReadConfigFile(string connectionStringName)
        {
            ConnnecionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
        }
    }
}