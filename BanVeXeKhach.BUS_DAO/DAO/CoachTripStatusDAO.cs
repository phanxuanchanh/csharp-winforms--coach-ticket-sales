using BanVeXeKhach.BUS_DAO.BUS;
using BanVeXeKhach.SqlServer;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BanVeXeKhach.BUS_DAO.DAO
{
    public class CoachTripStatusDAO
    {
        private static SqlExecution sqlExecution = DataAccessConfiguration.GetSqlExecution();

        public static List<CoachTripStatus> GetCoachTripStatusList()
        {
            string commandText = "Select * from  CoachTripStatus";
            return sqlExecution.ToList<CoachTripStatus>(commandText, CommandType.Text);
        }

        public static async Task<List<CoachTripStatus>> GetCoachTripStatusListAsync()
        {
            string commandText = "Select * from  CoachTripStatus";
            return await sqlExecution.ToListAsync<CoachTripStatus>(commandText, CommandType.Text);
        }

        public static CoachTripStatus GetCoachTripStatus(int coachTripStatusId)
        {
            string commandText = "Select * from  CoachTripStatus where ID = @coachTripStatusId";
            return sqlExecution.To<CoachTripStatus>(commandText, CommandType.Text, new SqlParameter("@coachTripStatusId", coachTripStatusId));
        }

        public static async Task<CoachTripStatus> GetCoachTripStatusAsync(int coachTripStatusId)
        {
            string commandText = "Select * from  CoachTripStatus where ID = @coachTripStatusId";
            return await sqlExecution.ToAsync<CoachTripStatus>(commandText, CommandType.Text, new SqlParameter("@coachTripStatusId", coachTripStatusId));
        }

        public static List<CoachTripStatus> SearchByName(string coachTripStatusName)
        {
            string commandText = "Select * from CoachTripStatus where name like @coachTripStatusName";
            return sqlExecution.ToList<CoachTripStatus>(commandText, CommandType.Text, new SqlParameter("@coachTripStatusName", "%" + coachTripStatusName + "%"));
        }

        public static async Task<List<CoachTripStatus>> SearchByNameAsync(string coachTripStatusName)
        {
            string commandText = "Select * from CoachTripStatus Where name like @coachTripStatusName";
            return await sqlExecution.ToListAsync<CoachTripStatus>(commandText, CommandType.Text, new SqlParameter("@coachTripStatusName", "%" + coachTripStatusName + "%"));
        }

        public static bool CreateCoachTripStatus(CoachTripStatus coachTripStatus)
        {
            string commandText = @"Select count(*) from CoachTripStatus where [name] = @coachTripStatusName";
            int count = (int)sqlExecution.ExecuteScalar(
                commandText, CommandType.Text,
                new SqlParameter("@coachTripStatusName", coachTripStatus.Name)
            );

            if (count > 0)
                return false;

            commandText = @"Insert into CoachTripStatus ([name], description) values (@coachTripStatusName, @description)";

            int affected = sqlExecution.ExecuteNonQuery(
                commandText, CommandType.Text,
                new SqlParameter("@coachTripStatusName", coachTripStatus.Name),
                new SqlParameter("@description", coachTripStatus.Description)
            );

            return affected > 0;
        }

        public static async Task<bool> CreateCoachTripStatusAsync(CoachTripStatus coachTripStatus)
        {
            string commandText = @"Select count(*) from CoachTripStatus where [name] = @coachTripStatusName";
            int count = (int)await sqlExecution.ExecuteScalarAsync(
                commandText, CommandType.Text,
                new SqlParameter("@coachTripStatusName", coachTripStatus.Name)
            );

            if (count > 0)
                return false;

            commandText = @"Insert into CoachTripStatus ([name], description) values (@coachTripStatusName, @description)";

            int affected = await sqlExecution.ExecuteNonQueryAsync(
                commandText, CommandType.Text,
                new SqlParameter("@coachTripStatusName", coachTripStatus.Name),
                new SqlParameter("@description", coachTripStatus.Description)
            );

            return affected > 0;
        }
        public static bool UpdateCoachTripStatus(CoachTripStatus coachTripStatus)
        {
            string commandText = @"
                Select count(*) from  CoachTripStatus where [name] = @coachTripStatusName and ID != @coachTripStatusId";

            int count = (int)sqlExecution.ExecuteScalar(
                commandText, CommandType.Text,
                new SqlParameter("@coachTripStatusName", coachTripStatus.Name),
                new SqlParameter("@coachTripStatusId", coachTripStatus.CoachTripStatusId)
            );

            if (count > 0)
                return false;

            commandText = @"
                Update  CoachTripStatus 
                    set [name] = @coachTripStatusName, description = @description
                where ID = @coachTripStatusId";

            int affected = sqlExecution.ExecuteNonQuery(
                commandText, CommandType.Text,
                new SqlParameter("@coachTripStatusName", coachTripStatus.Name),
                new SqlParameter("@description", coachTripStatus.Description),
                new SqlParameter("@coachTripStatusId", coachTripStatus.CoachTripStatusId)
            );

            return affected > 0;
        }
        public static async Task<bool> UpdateCoachTripStatusAsync(CoachTripStatus coachTripStatus)
        {
            string commandText = @"
                Select count(*) from  CoachTripStatus where [name] = @coachTripStatusName and ID != @coachTripStatusId";

            int count = (int)await sqlExecution.ExecuteScalarAsync(
                commandText, CommandType.Text,
                new SqlParameter("@coachTripStatusName", coachTripStatus.Name),
                new SqlParameter("@coachTripStatusId", coachTripStatus.CoachTripStatusId)
            );

            if (count > 0)
                return false;

            commandText = @"
                Update  CoachTripStatus 
                    set [name] = @coachTripStatusName, description = @description
                where ID = @coachTripStatusId";

            int affected = await sqlExecution.ExecuteNonQueryAsync(
                commandText, CommandType.Text,
                new SqlParameter("@coachTripStatusName", coachTripStatus.Name),
                new SqlParameter("@description", coachTripStatus.Description),
                new SqlParameter("@coachTripStatusId", coachTripStatus.CoachTripStatusId)
            );

            return affected > 0;
        }

        public static bool DeleteCoachTripStatus(int coachTripStatusId)
        {
            string commandText = "Select count(*) from Coachtrip where statusId = @coachTripStatusId";
            int count = (int)sqlExecution.ExecuteScalar(commandText, CommandType.Text,
                new SqlParameter("@coachTripStatusId", coachTripStatusId));

            if (count > 0)
                return false;

            commandText = "Delete from CoachTripStatus where ID = @coachTripStatusId";
            int affected = sqlExecution.ExecuteNonQuery(commandText, CommandType.Text,
                new SqlParameter("@coachTripStatusId", coachTripStatusId));

            return affected > 0;
        }

        public static async Task<bool> DeleteCoachTripStatusAsync(int coachTripStatusId)
        {
            string commandText = "Select count(*) from Coachtrip where statusId = @coachTripStatusId";
            int count =(int)await sqlExecution.ExecuteScalarAsync(commandText, CommandType.Text,
                new SqlParameter("@coachTripStatusId", coachTripStatusId));

            if (count > 0)
                return false;

            commandText = "Delete from CoachTripStatus where ID = @coachTripStatusId";
            int affected = await sqlExecution.ExecuteNonQueryAsync(commandText, CommandType.Text,
                new SqlParameter("@coachTripStatusId", coachTripStatusId));

            return affected > 0;
        }

        public static int CountCoachTripStatus()
        {
            string commandText = "Select count(*) from  CoachTripStatus";
            return (int)sqlExecution.ExecuteScalar(commandText, CommandType.Text);
        }

        public static async Task<int> CountCoachTripStatusAsync()
        {
            string commandText = "Select count(*) from  CoachTripStatus";
            return (int)await sqlExecution.ExecuteScalarAsync(commandText, CommandType.Text);
        }
    }
}
