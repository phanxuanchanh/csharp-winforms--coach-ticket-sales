using BanVeXeKhach.BUS_DAO.BUS;
using BanVeXeKhach.SqlServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace BanVeXeKhach.BUS_DAO.DAO
{
    public class InvoiceDAO
    {
        private static SqlExecution sqlExecution = DataAccessConfiguration.GetSqlExecution();

        public static DataTable GetVW_Invoice()
        {
            string commandText = "Select * from vw_Invoice";
            return sqlExecution.GetDataTable("vwInvoice", commandText, CommandType.Text);
        }

        public static List<Invoice> GetInvoices()
        {
            string commandText = @"
                Select Invoice.*, Customer.ID as 'customer.CustomerId', Customer.fullName as 'customer.FullName',
                    Customer.phone as 'customer.Phone', Customer.email as 'customer.Email', 
                    Employee.ID as 'employee.EmployeeId', Employee.fullName as 'employee.FullName',
                    Employee.phone as 'employee.Phone', Employee.email as 'employee.Email'
                from Invoice, Customer, Employee 
                where Invoice.customerId = Customer.ID
                    and Invoice.employeeId = Employee.ID";

            return sqlExecution.ToList<Invoice>(commandText, CommandType.Text);
        }

        public static async Task<List<Invoice>> GetInvoicesAsync()
        {
            string commandText = @"
                Select Invoice.*, Customer.ID as 'customer.CustomerId', Customer.fullName as 'customer.FullName',
                    Customer.phone as'customer.Phone', Customer.email as'customer.Email', 
                    Employee.ID as 'employee.EmployeeId', Employee.fullName as'employee.FullName',
                    Employee.phone as 'employee.Phone', Employee.email as 'employee.Email'
                from Invoice, Customer, Employee 
                where Invoice.customerId = Customer.ID
                    and Invoice.employeeId = Employee.ID";

            return await sqlExecution.ToListAsync<Invoice>(commandText, CommandType.Text);
        }

        public static List<Invoice> GetInvoicesByCustomerId(long customerId)
        {
            string commandText = @"
                Select Invoice.*, Customer.ID as 'customer.CustomerId', Customer.fullName as 'customer.FullName',
                    Customer.phone as'customer.Phone', Customer.email as'customer.Email', 
                    Employee.ID as 'employee.EmployeeId', Employee.fullName as 'employee.FullName',
                    Employee.phone as 'employee.Phone', Employee.email as 'employee.Email'
                from Invoice, Customer, Employee 
                where Invoice.customerId = Customer.ID and Invoice.employeeId = Employee.ID
                    and Customer.ID = @customerId";

            return sqlExecution
                .ToList<Invoice>(commandText, CommandType.Text, new SqlParameter("@customerId", customerId));
        }

        public static async Task<List<Invoice>> GetInvoicesByCustomerIdAsync(long customerId)
        {
            string commandText = @"
                Select Invoice.*, Customer.ID as 'customer.CustomerId', Customer.fullName as 'customer.FullName',
                    Customer.phone as'customer.Phone', Customer.email as'customer.Email', 
                    Employee.ID as 'employee.EmployeeId', Employee.fullName as 'employee.FullName',
                    Employee.phone as 'employee.Phone', Employee.email as 'employee.Email'
                from Invoice, Customer, Employee 
                where Invoice.customerId = Customer.ID and Invoice.employeeId = Employee.ID
                    and Customer.ID = @customerId";

            return await sqlExecution
                .ToListAsync<Invoice>(commandText, CommandType.Text, new SqlParameter("@customerId", customerId));
        }

        public static Invoice GetInvoice(long invoiceId)
        {
            string commandText = @"Select Invoice.*, Customer.ID as 'customer.ID', Customer.fullName as 'customer.FullName',
              Customer.phone as'customer.Phone', Customer.email as'customer.Email', Employee.ID as'employee.ID', Employee.fullName as'employee.FullName',
              Employee.phone as'employee.Phone', Employee.email as'employee.Email'
            from Invoice, Customer, Employee 
            where Invoice.customerId = Customer.ID
                    and Invoice.employeeId = Employee.ID and Invoice.ID = @invoiceId";
            return sqlExecution.To<Invoice>(commandText, CommandType.Text, new SqlParameter("@invoiceId", invoiceId));
        }

        public static async Task<Invoice> GetInvoiceAsync(long invoiceId)
        {
            string commandText = @"Select Invoice.*, Customer.ID as 'customer.ID', Customer.fullName as 'customer.FullName',
              Customer.phone as'customer.Phone', Customer.email as'customer.Email', Employee.ID as'employee.ID', Employee.fullName as'employee.FullName',
              Employee.phone as'employee.Phone', Employee.email as'employee.Email'
            from Invoice, Customer, Employee 
            where Invoice.customerId = Customer.ID
                    and Invoice.employeeId = Employee.ID and Invoice.ID = @invoiceId";
            return await sqlExecution.ToAsync<Invoice>(commandText, CommandType.Text, new SqlParameter("@invoiceId", invoiceId));
        }

        public static Invoice GetIncompleteInvoice(long customerId, string employeeId)
        {
            string commandText = @"
                Select Invoice.*, Customer.ID as 'customer.ID', Customer.fullName as 'customer.FullName',
                    Customer.phone as'customer.Phone', Customer.email as'customer.Email', 
                    Employee.ID as'employee.ID', Employee.fullName as'employee.FullName',
                    Employee.phone as'employee.Phone', Employee.email as'employee.Email'
                from Invoice, Customer, Employee 
                where Invoice.customerId = Customer.ID and Invoice.employeeId = Employee.ID 
                    and Invoice.status = 'Incomplete'
                    and Invoice.customerId = @customerId and Invoice.employeeId = @employeeId";

            return sqlExecution.To<Invoice>(
                commandText, CommandType.Text, 
                new SqlParameter("@customerId", customerId),
                new SqlParameter("@employeeId", employeeId)
            );
        }

        public static async Task<Invoice> GetIncompleteInvoiceAsync(long customerId, string employeeId)
        {
            string commandText = @"
                Select Invoice.*, Customer.ID as 'customer.ID', Customer.fullName as 'customer.FullName',
                    Customer.phone as'customer.Phone', Customer.email as'customer.Email', 
                    Employee.ID as'employee.ID', Employee.fullName as'employee.FullName',
                    Employee.phone as'employee.Phone', Employee.email as'employee.Email'
                from Invoice, Customer, Employee 
                where Invoice.customerId = Customer.ID and Invoice.employeeId = Employee.ID 
                    and Invoice.status = 'Incomplete'
                    and Invoice.customerId = @customerId and Invoice.employeeId = @employeeId";

            return await sqlExecution.ToAsync<Invoice>(
                commandText, CommandType.Text,
                new SqlParameter("@customerId", customerId),
                new SqlParameter("@employeeId", employeeId)
            );
        }

        public static List<Invoice> SearchByCustomerName(string customerName)
        {
            string commandText = @"Select Invoice.*, Customer.ID as 'customer.ID', Customer.fullName as 'customer.FullName',
              Customer.phone as'customer.Phone', Customer.email as'customer.Email', Employee.ID as'employee.ID', Employee.fullName as'employee.FullName',
              Employee.phone as'employee.Phone', Employee.email as'employee.Email'
            from Invoice, Customer, Employee 
            where Invoice.customerId = Customer.ID
                    and Invoice.employeeId = Employee.ID  and Customer.fullName like @customerName";
            return sqlExecution.ToList<Invoice>(commandText, CommandType.Text, new SqlParameter("@customerName", "%" + customerName + "%"));
        }

        public static async Task<List<Invoice>> SearchByCustomerNameAsync(string customerName)
        {
            string commandText = @"Select Invoice.*, Customer.ID as 'customer.ID', Customer.fullName as 'customer.FullName',
              Customer.phone as'customer.Phone', Customer.email as'customer.Email', Employee.ID as'employee.ID', Employee.fullName as'employee.FullName',
              Employee.phone as'employee.Phone', Employee.email as'employee.Email'
            from Invoice, Customer, Employee 
            where Invoice.customerId = Customer.ID
                    and Invoice.employeeId = Employee.ID  and Customer.fullName like @customerName";
            return await sqlExecution.ToListAsync<Invoice>(commandText, CommandType.Text, new SqlParameter("@customerName", "%" + customerName + "%"));
        }

        public static List<Invoice> SearchByEmployeeName(string employeeName)
        {
            string commandText = @"Select Invoice.*, Customer.ID as 'customer.ID', Customer.fullName as 'customer.FullName',
              Customer.phone as'customer.Phone', Customer.email as'customer.Email', Employee.ID as'employee.ID', Employee.fullName as'employee.FullName',
              Employee.phone as'employee.Phone', Employee.email as'employee.Email'
            from Invoice, Customer, Employee 
            where Invoice.customerId = Customer.ID
                    and Invoice.employeeId = Employee.ID  and Employee.fullName like @employeeName";
            return sqlExecution.ToList<Invoice>(commandText, CommandType.Text, new SqlParameter("@employeeName", "%" + employeeName + "%"));
        }

        public static async Task<List<Invoice>> SearchByEmployeeNameAsync(string employeeName)
        {
             string commandText = @"Select Invoice.*, Customer.ID as 'customer.ID', Customer.fullName as 'customer.FullName',
              Customer.phone as'customer.Phone', Customer.email as'customer.Email', Employee.ID as'employee.ID', Employee.fullName as'employee.FullName',
              Employee.phone as'employee.Phone', Employee.email as'employee.Email'
            from Invoice, Customer, Employee 
            where Invoice.customerId = Customer.ID
                    and Invoice.employeeId = Employee.ID  and Employee.fullName like @employeeName";
            return await sqlExecution.ToListAsync<Invoice>(commandText, CommandType.Text, new SqlParameter("@employeeName", "%" + employeeName + "%"));
        }

        public static List<Invoice> SearchByPurchaseDate(string purchaseDate)
        {
            string commandText = @"Select Invoice.*, Customer.ID as 'customer.ID', Customer.fullName as 'customer.FullName',
              Customer.phone as'customer.Phone', Customer.email as'customer.Email', Employee.ID as'employee.ID', Employee.fullName as'employee.FullName',
              Employee.phone as'employee.Phone', Employee.email as'employee.Email'
            from Invoice, Customer, Employee 
            where Invoice.customerId = Customer.ID
                    and Invoice.employeeId = Employee.ID  and Invoice.purchaseDate like @purchaseDate";
            return sqlExecution.ToList<Invoice>(commandText, CommandType.Text, new SqlParameter("@purchaseDate", "%" + purchaseDate + "%"));
        }

        public static async Task<List<Invoice>> SearchByPurchaseDateAsync(string purchaseDate)
        {
            string commandText = @"Select Invoice.*, Customer.ID as 'customer.ID', Customer.fullName as 'customer.FullName',
              Customer.phone as'customer.Phone', Customer.email as'customer.Email', Employee.ID as'employee.ID', Employee.fullName as'employee.FullName',
              Employee.phone as'employee.Phone', Employee.email as'employee.Email'
            from Invoice, Customer, Employee 
            where Invoice.customerId = Customer.ID
                    and Invoice.employeeId = Employee.ID  and Invoice.purchaseDate like @purchaseDate";
            return await sqlExecution.ToListAsync<Invoice>(commandText, CommandType.Text, new SqlParameter("@purchaseDate", "%" + purchaseDate + "%"));
        }

        public static bool CreateInvoice(Invoice invoice)
        {
            string commandText = "Insert into Invoice values (@customerId, @employeeId, 0, NULL, 'Incomplete')";
            int affected =sqlExecution.ExecuteNonQuery(
                commandText, CommandType.Text,
                new SqlParameter("@customerId", invoice.Customer.CustomerId),
                new SqlParameter("@employeeId", invoice.Employee.EmployeeId)
            );

            return affected > 0;
        }

        public static async Task<bool> CreateInvoiceAsync(Invoice invoice)
        {
            string commandText = "Insert into Invoice values (@customerId, @employeeId, 0, NULL, 'Incomplete')";
            int affected = await sqlExecution.ExecuteNonQueryAsync(
                commandText, CommandType.Text,
                new SqlParameter("@customerId", invoice.Customer.CustomerId),
                new SqlParameter("@employeeId", invoice.Employee.EmployeeId)
            );

            return affected > 0;
        }

        public static bool UpdateInvoice(Invoice invoice)
        {
            string commandText = @"
                Update Invoice 
                    set [customerId] = @customerId, employeeId = @employeeId, 
                    totalMoney = @totalMoney, purchaseDate = @purchaseDate, status = @status
                where ID = @invoiceId";

            int affected = sqlExecution.ExecuteNonQuery(
                commandText, CommandType.Text,
                new SqlParameter("@customerId", invoice.Customer.CustomerId),
                new SqlParameter("@employeeId", invoice.Employee.EmployeeId),
                new SqlParameter("@totalMoney", invoice.TotalMoney),
                new SqlParameter("@purchaseDate", invoice.PurchaseDate),
                new SqlParameter("@status", invoice.Status),
                new SqlParameter("@invoiceId", invoice.InvoiceId)
            );

            return affected > 0;
        }

        public static async Task<bool> UpdateInvoiceAsync(Invoice invoice)
        {
            string commandText = @"
                Update Invoice 
                    set [customerId] = @customerId, employeeId = @employeeId, 
                    totalMoney = @totalMoney, purchaseDate = @purchaseDate, status = @status
                where ID = @invoiceId";

            int affected = await sqlExecution.ExecuteNonQueryAsync(
                commandText, CommandType.Text,
                new SqlParameter("@customerId", invoice.Customer.CustomerId),
                new SqlParameter("@employeeId", invoice.Employee.EmployeeId),
                new SqlParameter("@totalMoney", invoice.TotalMoney),
                new SqlParameter("@purchaseDate", invoice.PurchaseDate),
                new SqlParameter("@status", invoice.Status),
                new SqlParameter("@invoiceId", invoice.InvoiceId)
            );

            return affected > 0;
        }

        public static bool DeleteInvoice(long invoiceId)
        {
            string commandText = "Select count(*) from InvoiceDetail where invoiceId = @invoiceId";
            int count = (int)sqlExecution.ExecuteScalar(commandText, CommandType.Text, new SqlParameter("@invoiceId", invoiceId));

            if (count > 0)
                return false;

            commandText = "Delete from Invoice where ID = @invoiceId";
            int affected = sqlExecution.ExecuteNonQuery(commandText, CommandType.Text, new SqlParameter("@invoiceId", invoiceId));
            return affected > 0;
        }

        public static async Task<bool> DeleteInvoiceAsync(long invoiceId)
        {
            string commandText = "Select count(*) from InvoiceDetail where invoiceId = @invoiceId";
            int count = (int)await sqlExecution.ExecuteScalarAsync(commandText, CommandType.Text, new SqlParameter("@invoiceId", invoiceId));

            if (count > 0)
                return false;

            commandText = "Delete from Invoice where ID = @invoiceId";
            int affected = await sqlExecution.ExecuteNonQueryAsync(commandText, CommandType.Text, new SqlParameter("@invoiceId", invoiceId));
            return affected > 0;
        }

        public static int CountInvoice()
        {
            string commandText = "Select count(*) from Invoice";
            return (int)sqlExecution.ExecuteScalar(commandText, CommandType.Text);
        }

        public static async Task<int> CountInvoiceAsync()
        {
            string commandText = "Select count(*) from Invoice";
            return (int)await sqlExecution.ExecuteScalarAsync(commandText, CommandType.Text);
        }

        public static int CountInvoiceByCustomerId(long customerId)
        {
            string commandText = "Select count(*) from Invoice where customerId = @customerId";
            return (int)sqlExecution
                .ExecuteScalar(commandText, CommandType.Text, new SqlParameter("@customerId", customerId));
        }

        public static async Task<int> CountInvoiceByCustomerIdAsync(long customerId)
        {
            string commandText = "Select count(*) from Invoice where customerId = @customerId";
            return (int)await sqlExecution
                .ExecuteScalarAsync(commandText, CommandType.Text, new SqlParameter("@customerId", customerId));
        }
    }
}
