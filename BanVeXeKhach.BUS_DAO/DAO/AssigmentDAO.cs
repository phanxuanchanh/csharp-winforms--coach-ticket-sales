using BanVeXeKhach.BUS_DAO.BUS;
using BanVeXeKhach.BUS_DAO.DAO;
using BanVeXeKhach.SqlServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeXeKhach.BUS_DAO.DAO
{
    class AssigmentDAO
    {
        private static SqlExecution sqlExecution = DataAccessConfiguration.GetSqlExecution();

        public static List<Assigment> GetAssigments()
        {
            string commandText = "Select * from Assigment";
            return sqlExecution.ToList<Assigment>(commandText, CommandType.Text);
        }

        public static async Task<List<Assigment>> GetAssigmentsAsync()
        {
            string commandText = "Select * from Assigment";
            return await sqlExecution.ToListAsync<Assigment>(commandText, CommandType.Text);
        }
        public static Assigment GetAssigment(string role)
        {
            string commandText = "Select * from Assigment where role = @role";
            return sqlExecution.To<Assigment>(commandText, CommandType.Text, new SqlParameter("@role", role));
        }

        public static async Task<Assigment> GetAssigmentAsync(string role)
        {
            string commandText = "Select * from Assigment where role = @role";
            return await sqlExecution.ToAsync<Assigment>(commandText, CommandType.Text, new SqlParameter("@role", role));
        }

        public static List<Assigment> SearchByEmployee(Employee employee)
        {
            string commandText = "Select * from Assigment where employeeId like @employee";
            return sqlExecution.ToList<Assigment>(commandText, CommandType.Text, new SqlParameter("@employee", "%" + employee + "%"));
        }
        public static async Task<List<Assigment>> SearchByEmployeeAsync(Employee employee)
        {
            string commandText = "Select * from Assigment Where employeeId like @employee";
            return await sqlExecution.ToListAsync<Assigment>(commandText, CommandType.Text, new SqlParameter("@employee", "%" + employee + "%"));
        }

        public static List<Assigment> SearchByCoachTrip(CoachTrip coachTrip)
        {
            string commandText = "Select * from Assigment where coachTripId like @coachTrip";
            return sqlExecution.ToList<Assigment>(commandText, CommandType.Text, new SqlParameter("@coachTrip", "%" + coachTrip + "%"));
        }

        public static async Task<List<Assigment>> SearchByCoachTripAsync(CoachTrip coachTrip)
        {
            string commandText = "Select * from Assigment where coachTripId like @coachTrip";
            return  await sqlExecution.ToListAsync<Assigment>(commandText, CommandType.Text, new SqlParameter("@coachTrip", "%" + coachTrip + "%"));
        }

        public static List<Assigment> SearchByRole(string role)
        {
            string commandText = "Select * from Assigment where role like @role";
            return sqlExecution.ToList<Assigment>(commandText, CommandType.Text, new SqlParameter("@role", "%" + role + "%"));
        }

        public static async Task<List<Assigment>> SearchByRoleAsync(string role)
        {
            string commandText = "Select * from Assigment where role like @role";
            return await sqlExecution.ToListAsync<Assigment>(commandText, CommandType.Text, new SqlParameter("@role", "%" + role + "%"));
        }

    }
}
