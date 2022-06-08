using BanVeXeKhach.BUS_DAO.BUS;
using BanVeXeKhach.SqlServer;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BanVeXeKhach.BUS_DAO.DAO
{
    public class EmployeeDAO
    {
        private static SqlExecution sqlExecution = DataAccessConfiguration.GetSqlExecution();

        public static bool LogIn(string employeeId, string password)
        {
            string commandText = "Select ID, password from Employee where ID = @employeeId";
            using (
                SqlDataReader sqlDataReader = sqlExecution
                .ExecuteReader(commandText, CommandType.Text, new SqlParameter("@employeeId", employeeId))
            )
            {
                if (sqlDataReader.Read())
                {
                    string passwordFromDB = sqlDataReader["password"].ToString();
                    if (BCrypt.Net.BCrypt.Verify(password, passwordFromDB))
                        return true;
                    
                    return false;
                }
                return false;
            }
        }

        public static async Task<bool> LogInAsync(string employeeId, string password)
        {
            string commandText = "Select ID, password from Employee where ID = @employeeId";
            using (
                SqlDataReader sqlDataReader = await sqlExecution
                .ExecuteReaderAsync(commandText, CommandType.Text, new SqlParameter("@employeeId", employeeId))
            )
            {
                if (sqlDataReader.Read())
                {
                    string passwordFromDB = sqlDataReader["password"].ToString();
                    if (BCrypt.Net.BCrypt.Verify(password, passwordFromDB))
                        return true;

                    return false;
                }
                return false;
            }
        }

        public static bool UpdateAvatar(string employeeId, string avatar)
        {
            string commandText = "Update Employee set avatar = @avatar where ID = @employeeId";
            int affected = sqlExecution.ExecuteNonQuery(
                commandText, CommandType.Text,
                new SqlParameter("@avatar", avatar),
                new SqlParameter("@employeeId", employeeId)
            );

            return affected > 0;
        }

        public static async Task<bool> UpdateAvatarAsync(string employeeId, string avatar)
        {
            string commandText = "Update Employee set avatar = @avatar where ID = @employeeId";
            int affected = await sqlExecution.ExecuteNonQueryAsync(
                commandText, CommandType.Text,
                new SqlParameter("@avatar", avatar),
                new SqlParameter("@employeeId", employeeId)
            );

            return affected > 0;
        }

        public static List<Employee> GetEmployees()
        {
            string commandText = "Select * from Employee";
            return sqlExecution.ToList<Employee>(commandText, CommandType.Text);
        }

        public static async Task<List<Employee>> GetEmployeesAsync()
        {
            string commandText = "Select * from Employee";
            return await sqlExecution.ToListAsync<Employee>(commandText, CommandType.Text);
        }

        public static Employee GetEmployee(string employeeId)
        {
            string commandText = "Select * from Employee where ID = @employeeId";
            return sqlExecution.To<Employee>(commandText, CommandType.Text, new SqlParameter("@employeeId", employeeId));
        }

        public static async Task<Employee> GetEmployeeAsync(string employeeId)
        {
            string commandText = "Select * from Employee where ID = @employeeId";
            return await sqlExecution.ToAsync<Employee>(commandText, CommandType.Text, new SqlParameter("@employeeId", employeeId));
        }

        public static List<Employee> SearchByFullName(string employeeName)
        {
            string commandText = "Select * from Employee where fullName like @employeeName";
            return sqlExecution.ToList<Employee>(commandText, CommandType.Text, new SqlParameter("@employeeName", "%" + employeeName + "%"));
        }

        public static async Task<List<Employee>> SearchByFullNameAsync(string employeeName)
        {
            string commandText = "Select * from Employee Where fullName like @employeeName";
            return await sqlExecution.ToListAsync<Employee>(commandText, CommandType.Text, new SqlParameter("@employeeName", "%" + employeeName + "%"));
        }

        public static List<Employee> SearchByPhone(string employeePhone)
        {
            string commandText = "Select * from Employee where phone like @employeePhone";
            return sqlExecution.ToList<Employee>(commandText, CommandType.Text, new SqlParameter("@employeePhone", "%" + employeePhone + "%"));
        }

        public static async Task<List<Employee>> SearchByPhoneAsync(string employeePhone)
        {
            string commandText = "Select * from Employee where phone like @employeePhone";
            return await sqlExecution.ToListAsync<Employee>(commandText, CommandType.Text, new SqlParameter("@employeePhone", "%" + employeePhone + "%"));
        }

        public static List<Employee> SearchByEmail(string employeeEmail)
        {
            string commandText = "Select * from Employee where email like @employeeEmail";
            return sqlExecution.ToList<Employee>(commandText, CommandType.Text, new SqlParameter("@employeeEmail", "%" + employeeEmail + "%"));
        }

        public static async Task<List<Employee>> SearchByEmailAsync(string employeeEmail)
        {
            string commandText = "Select * from Employee where email like @employeeEmail";
            return await sqlExecution.ToListAsync<Employee>(commandText, CommandType.Text, new SqlParameter("@employeeEmail", "%" + employeeEmail + "%"));
        }

        public static List<Employee> SearchByAddress(string employeeAddress)
        {
            string commandText = "Select * from Employee where address like @employeeAddress";
            return sqlExecution.ToList<Employee>(commandText, CommandType.Text, new SqlParameter("@employeeAddress", "%" + employeeAddress + "%"));
        }

        public static async Task<List<Employee>> SearchByAddressAsync(string employeeAddress)
        {
            string commandText = "Select * from Employee where address like @employeeAddress";
            return await sqlExecution.ToListAsync<Employee>(commandText, CommandType.Text, new SqlParameter("@employeeAddress", "%" + employeeAddress + "%"));
        }

        public static bool CreateEmployee(Employee employee)
        {
            string commandText = @"Select count(*) from Employee where phone = @phone or email = @email";
            int count = (int)sqlExecution.ExecuteScalar(
                commandText, CommandType.Text,
                new SqlParameter("@phone", employee.Phone),
                new SqlParameter("@email", employee.Email)
            );

            if (count > 0)
                return false;

            commandText = @"
                Insert into Employee 
                    values (@employeeId, @employeeName, @phone, @email, @birthday, @address, @avatar, @password, @title, @description)";

            int affected = sqlExecution.ExecuteNonQuery(
                commandText, CommandType.Text,
                new SqlParameter("@employeeId", employee.EmployeeId),
                new SqlParameter("@employeeName", employee.FullName),
                new SqlParameter("@phone", employee.Phone),
                new SqlParameter("@email", employee.Email),
                new SqlParameter("@birthday", employee.Birthday),
                new SqlParameter("@address", employee.Address),
                new SqlParameter("@avatar", employee.Avatar),
                new SqlParameter("@password", BCrypt.Net.BCrypt.HashPassword(employee.Password, workFactor: 12)),
                new SqlParameter("@title", employee.Title),
                new SqlParameter("@description", employee.Description)
            );

            return affected > 0;
        }

        public static async Task<bool> CreateEmployeeAsync(Employee employee)
        {
            string commandText = @"Select count(*) from Employee where phone = @phone or email = @email";
            int count = (int)await sqlExecution.ExecuteScalarAsync(
                commandText, CommandType.Text,
                new SqlParameter("@phone", employee.Phone),
                new SqlParameter("@email", employee.Email)
            );

            if (count > 0)
                return false;

            commandText = @"
                Insert into Employee 
                    values (@employeeId, @employeeName, @phone, @email, @birthday, @address, @avatar, @password, @title, @description)";

            int affected = await sqlExecution.ExecuteNonQueryAsync(
                commandText, CommandType.Text,
                new SqlParameter("@employeeId", employee.EmployeeId),
                new SqlParameter("@employeeName", employee.FullName),
                new SqlParameter("@phone", employee.Phone),
                new SqlParameter("@email", employee.Email),
                new SqlParameter("@birthday", employee.Birthday),
                new SqlParameter("@address", employee.Address),
                new SqlParameter("@avatar", employee.Avatar),
                new SqlParameter("@password", employee.Password),
                new SqlParameter("@title", employee.Title),
                new SqlParameter("@description", employee.Description)
            );

            return affected > 0;
        }

        public static bool UpdateEmployee(Employee employee)
        {
            string commandText = @"
                Select count(*) from Employee 
                    where phone = @phone and email = @email and ID != @employeeId";

            int count = (int)sqlExecution.ExecuteScalar(
                commandText, CommandType.Text,
                new SqlParameter("@phone", employee.Phone),
                new SqlParameter("@email", employee.Email),
                new SqlParameter("@employeeId", employee.EmployeeId)
            );

            if (count > 0)
                return false;

            commandText = @"
                Update Employee 
                    set [fullName] = @employeeName, phone = @phone, email = @email, 
                        birthday = @birthday, address = @address, title = @title, description = @description
                where ID = @employeeId";

            int affected = sqlExecution.ExecuteNonQuery(
                commandText, CommandType.Text,
                new SqlParameter("@employeeName", employee.FullName),
                new SqlParameter("@phone", employee.Phone),
                new SqlParameter("@email", employee.Email),
                new SqlParameter("@birthday", employee.Birthday),
                new SqlParameter("@address", employee.Address),
                new SqlParameter("@avatar", employee.Avatar),
                new SqlParameter("@password", employee.Password),
                new SqlParameter("@title", employee.Title),
                new SqlParameter("@description", employee.Description),
                new SqlParameter("@employeeId", employee.EmployeeId)
            );

            return affected > 0;
        }

        public static async Task<bool> UpdateEmployeeAsync(Employee employee)
        {
            string commandText = @"
                Select count(*) from Employee 
                    where phone = @phone and email = @email and ID != @employeeId";

            int count = (int)await sqlExecution.ExecuteScalarAsync(
                commandText, CommandType.Text,
                new SqlParameter("@phone", employee.Phone),
                new SqlParameter("@email", employee.Email),
                new SqlParameter("@employeeId", employee.EmployeeId)
            );

            if (count > 0)
                return false;

            commandText = @"
                Update Employee 
                    set [fullName] = @employeeName, phone = @phone, email = @email, 
                        birthday = @birthday, address = @address, title = @title, description = @description
                where ID = @employeeId";

            int affected = await sqlExecution.ExecuteNonQueryAsync(
                commandText, CommandType.Text,
                new SqlParameter("@employeeName", employee.FullName),
                new SqlParameter("@phone", employee.Phone),
                new SqlParameter("@email", employee.Email),
                new SqlParameter("@birthday", employee.Birthday),
                new SqlParameter("@address", employee.Address),
                new SqlParameter("@avatar", employee.Avatar),
                new SqlParameter("@password", employee.Password),
                new SqlParameter("@title", employee.Title),
                new SqlParameter("@description", employee.Description),
                new SqlParameter("@employeeId", employee.EmployeeId)
            );

            return affected > 0;
        }

        public static bool DeleteEmployee(string employeeId)
        {
            string commandText = "Select count(*) from Invoice where employeeId = @employeeId";
            int count = (int)sqlExecution.ExecuteScalar(commandText, CommandType.Text, 
                new SqlParameter("@employeeId", employeeId));

            if (count > 0)
                return false;

            commandText = "Delete from Employee where ID = @employeeId"; 
            int affected = sqlExecution.ExecuteNonQuery(commandText, CommandType.Text, 
                new SqlParameter("@employeeId", employeeId));
            return affected > 0;
        }

        public static async Task<bool> DeleteEmployeeAsync(string employeeId)
        {
            string commandText = "Select count(*) from Invoice where employeeId = @employeeId";
            int count = (int)await sqlExecution.ExecuteScalarAsync(commandText, CommandType.Text, 
                new SqlParameter("@employeeId", employeeId));

            if (count > 0)
                return false;

            commandText = "Delete from Employee where ID = @employeeId";
            int affected = await sqlExecution.ExecuteNonQueryAsync(commandText, CommandType.Text, 
                new SqlParameter("@employeeId", employeeId));
            return affected > 0;
        }

        public static int CountEmployee()
        {
            string commandText = "Select count(*) from Employee";
            return (int)sqlExecution.ExecuteScalar(commandText, CommandType.Text);
        }

        public static async Task<int> CountEmployeeAsync()
        {
            string commandText = "Select count(*) from Employee";
            return (int)await sqlExecution.ExecuteScalarAsync(commandText, CommandType.Text);
        }
    }
}
