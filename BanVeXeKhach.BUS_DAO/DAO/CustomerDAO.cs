using BanVeXeKhach.BUS_DAO.BUS;
using BanVeXeKhach.SqlServer;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BanVeXeKhach.BUS_DAO.DAO
{
    public class CustomerDAO
    {
        private static SqlExecution sqlExecution = DataAccessConfiguration.GetSqlExecution();

        public static List<Customer> GetCustomers()
        {
            string commandText = "Select * from Customer";
            return sqlExecution.ToList<Customer>(commandText, CommandType.Text);
        }

        public static async Task<List<Customer>> GetCustomersAsync()
        {
            string commandText = "Select * from Customer";
            return await sqlExecution.ToListAsync<Customer>(commandText, CommandType.Text);
        }

        public static Customer GetCustomer(long customerId)
        {
            string commandText = "Select * from Customer where ID = @customerId";
            return sqlExecution.To<Customer>(commandText, CommandType.Text, new SqlParameter("@customerId", customerId));
        }

        public static async Task<Customer> GetCustomerAsync(long customerId)
        {
            string commandText = "Select * from Customer where ID = @customerId";
            return await sqlExecution.ToAsync<Customer>(commandText, CommandType.Text, new SqlParameter("@customerId", customerId));
        }

        public static Customer GetCustomerByPhone(string customerPhone)
        {
            string commandText = "Select * from Customer where phone = @customerPhone";
            return sqlExecution.To<Customer>(commandText, CommandType.Text, new SqlParameter("@customerPhone", customerPhone));
        }

        public static async Task<Customer> GetCustomerByPhoneAsync(string customerPhone)
        {
            string commandText = "Select * from Customer where phone = @customerPhone";
            return await sqlExecution.ToAsync<Customer>(commandText, CommandType.Text, new SqlParameter("@customerPhone", customerPhone));
        }

        public static Customer GetCustomerByEmail(string customerEmail)
        {
            string commandText = "Select * from Customer where email = @customerEmail";
            return sqlExecution.To<Customer>(commandText, CommandType.Text, new SqlParameter("@customerEmail", customerEmail));
        }

        public static async Task<Customer> GetCustomerByEmailAsync(string customerEmail)
        {
            string commandText = "Select * from Customer where email = @customerEmail";
            return await sqlExecution.ToAsync<Customer>(commandText, CommandType.Text, new SqlParameter("@customerEmail", customerEmail));
        }

        public static List<Customer> SearchByFullName(string customerName)
        {
            string commandText = "Select * from Customer where fullName like @customerName";
            return sqlExecution.ToList<Customer>(commandText, CommandType.Text, new SqlParameter("@customerName", "%" + customerName + "%"));
        }

        public static async Task<List<Customer>> SearchByFullNameAsync(string customerName)
        {
            string commandText = "Select * from Customer Where fullName like @customerName";
            return await sqlExecution.ToListAsync<Customer>(commandText, CommandType.Text, new SqlParameter("@customerName", "%" + customerName + "%"));
        }

        public static List<Customer> SearchByPhone(string customerPhone)
        {
            string commandText = "Select * from Customer where phone like @customerPhone";
            return sqlExecution.ToList<Customer>(commandText, CommandType.Text, new SqlParameter("@customerPhone", "%" + customerPhone + "%"));
        }

        public static async Task<List<Customer>> SearchByPhoneAsync(string customerPhone)
        {
            string commandText = "Select * from Customer where phone like @customerPhone";
            return await sqlExecution.ToListAsync<Customer>(commandText, CommandType.Text, new SqlParameter("@customerPhone", "%" + customerPhone + "%"));
        }

        public static List<Customer> SearchByEmail(string customerEmail)
        {
            string commandText = "Select * from Customer where email like @customerEmail";
            return sqlExecution.ToList<Customer>(commandText, CommandType.Text, new SqlParameter("@customerEmail", "%" + customerEmail + "%"));
        }

        public static async Task<List<Customer>> SearchByEmailAsync(string customerEmail)
        {
            string commandText = "Select * from Customer where email like @customerEmail";
            return await sqlExecution.ToListAsync<Customer>(commandText, CommandType.Text, new SqlParameter("@customerEmail", "%" + customerEmail + "%"));
        }

        public static List<Customer> SearchByAddress(string customerAddress)
        {
            string commandText = "Select * from Customer where address like @customerAddress";
            return sqlExecution.ToList<Customer>(commandText, CommandType.Text, new SqlParameter("@customerAddress", "%" + customerAddress + "%"));
        }

        public static async Task<List<Customer>> SearchByAddressAsync(string customerAddress)
        {
            string commandText = "Select * from Customer where address like @customerAddress";
            return await sqlExecution.ToListAsync<Customer>(commandText, CommandType.Text, new SqlParameter("@customerAddress", "%" + customerAddress + "%"));
        }

        public static bool CreateCustomer(Customer customer)
        {
            string commandText = @"Select count(*) from Customer where phone = @phone or email = @email";
            int count = (int)sqlExecution.ExecuteScalar(
                commandText, CommandType.Text,
                new SqlParameter("@phone", customer.Phone),
                new SqlParameter("@email", customer.Email)
            );

            if (count > 0)
                return false;

            commandText = @"Insert into Customer values (@customerName, @phone, @email, @birthday, @address)";
            int affected = sqlExecution.ExecuteNonQuery(
                commandText, CommandType.Text,
                new SqlParameter("@customerName", customer.FullName),
                new SqlParameter("@phone", customer.Phone),
                new SqlParameter("@email", customer.Email),
                new SqlParameter("@birthday", customer.Birthday),
                new SqlParameter("@address", customer.Address)
            );

            return affected > 0;
        }

        public static async Task<bool> CreateCutomerAsync(Customer customer)
        {
            string commandText = @"Select count(*) from Customer where phone = @phone or email = @email";
            int count = (int)await sqlExecution.ExecuteScalarAsync(
                commandText, CommandType.Text,
                new SqlParameter("@phone", customer.Phone),
                new SqlParameter("@email", customer.Email)
            );

            if (count > 0)
                return false;

            commandText = @"Insert into Customer values (@customerName, @phone, @email, @birthday, @address)";
            int affected = await sqlExecution.ExecuteNonQueryAsync(
                commandText, CommandType.Text,
                new SqlParameter("@customerName", customer.FullName),
                new SqlParameter("@phone", customer.Phone),
                new SqlParameter("@email", customer.Email),
                new SqlParameter("@birthday", customer.Birthday),
                new SqlParameter("@address", customer.Address)
            );

            return affected > 0;
        }       

        public static bool UpdateCustomer(Customer customer)
        {
            string commandText = @"
                Select count(*) from Customer 
                    where phone = @phone and email = @email and ID != @customerId";

            int count = (int)sqlExecution.ExecuteScalar(
                commandText, CommandType.Text,
                new SqlParameter("@phone", customer.Phone),
                new SqlParameter("@email", customer.Email),
                new SqlParameter("@customerId", customer.CustomerId)
            );

            if (count > 0)
                return false;

            commandText = @"
                Update Customer 
                    set [fullName] = @customerName, phone = @phone, email = @email, birthday = @birthday, address = @address
                where ID = @customerId";

            int affected = (int)sqlExecution.ExecuteNonQuery(
                commandText, CommandType.Text,
                new SqlParameter("@fullName", customer.FullName),
                new SqlParameter("@phone", customer.Phone),
                new SqlParameter("@email", customer.Email),
                new SqlParameter("@birthday", customer.Birthday),
                new SqlParameter("@address", customer.Address),
                new SqlParameter("@customerId", customer.CustomerId)
            );

            return affected > 0;
        }

        public static async Task<bool> UpdateCustomerAsync(Customer customer)
        {
            string commandText = @"
                Select count(*) from Customer 
                    where phone = @phone and email = @email and ID != @customerId";

            int count = (int)await sqlExecution.ExecuteScalarAsync(
                commandText, CommandType.Text,
                new SqlParameter("@phone", customer.Phone),
                new SqlParameter("@email", customer.Email),
                new SqlParameter("@customerId", customer.CustomerId)
            );

            if (count > 0)
                return false;

            commandText = @"
                Update Customer 
                    set [fullName] = @customerName, phone = @phone, email = @email, birthday = @birthday, address = @address
                where ID = @customerId";

            int affected = (int)await sqlExecution.ExecuteNonQueryAsync(
                commandText, CommandType.Text,
                new SqlParameter("@fullName", customer.FullName),
                new SqlParameter("@phone", customer.Phone),
                new SqlParameter("@email", customer.Email),
                new SqlParameter("@birthday", customer.Birthday),
                new SqlParameter("@address", customer.Address),
                new SqlParameter("@customerId", customer.CustomerId)
            );

            return affected > 0;
        }

        public static bool DeleteCustomer(long customerId)
        {
            string commandText = "Select count(*) from Invoice where customerId = @customerId";
            int count = (int)sqlExecution.ExecuteScalar(commandText, CommandType.Text, new SqlParameter("@customerId", customerId));

            if (count > 0)
                return false;

            commandText = "Delete from Customer where ID = @customerId";
            int affected = sqlExecution.ExecuteNonQuery(commandText, CommandType.Text, new SqlParameter("@customerId", customerId));
            return affected > 0;
        }

        public static async Task<bool> DeleteCustomerAsync(long customerId)
        {
            string commandText = "Select count(*) from Invoice where customerId = @customerId";
            int count = (int)await sqlExecution.ExecuteScalarAsync(commandText, CommandType.Text, new SqlParameter("@customerId", customerId));

            if (count > 0)
                return false;

            commandText = "Delete from Customer where ID = @customerId";
            int affected = await sqlExecution.ExecuteNonQueryAsync(commandText, CommandType.Text, new SqlParameter("@customerId", customerId));
            return affected > 0;
        }

        public static int CountCustomer()
        {
            string commandText = "Select count(*) from Customer";
            return (int)sqlExecution.ExecuteScalar(commandText, CommandType.Text);
        }

        public static async Task<int> CountCustomerAsync()
        {
            string commandText = "Select count(*) from Customer";
            return (int)await sqlExecution.ExecuteScalarAsync(commandText, CommandType.Text);
        }
    }
}
