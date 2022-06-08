using BanVeXeKhach.BUS_DAO.DAO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BanVeXeKhach.BUS_DAO.BUS
{
    public class Customer
    {
        public Customer()
        {

        }

        private long ID;
        private string fullName;
        private string phone;
        private string email;
        private DateTime birthday;
        private string address;

        public long CustomerId { get => ID; set => ID = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Address { get => address; set => address = value; }

        public static List<Customer> GetCustomers()
        {
            return CustomerDAO.GetCustomers();
        }

        public static async Task<List<Customer>> GetCustomersAsync()
        {
            return await CustomerDAO.GetCustomersAsync();
        }

        public static Customer GetCustomer(long customerId)
        {
            return CustomerDAO.GetCustomer(customerId);
        }

        public static async Task<Customer> GetCustomerAsync(long customerId)
        {
            return await CustomerDAO.GetCustomerAsync(customerId);
        }

        public static List<Customer> SearchByFullName(string customerName)
        {
            return CustomerDAO.SearchByFullName(customerName);
        }

        public static async Task<List<Customer>> SearchByFullNameAsync(string customerName)
        {
            return await CustomerDAO.SearchByFullNameAsync(customerName);
        }

        public static List<Customer> SearchByPhone(string customerPhone)
        {
            return CustomerDAO.SearchByPhone(customerPhone);
        }

        public static async Task<List<Customer>> SearchByPhoneAsync(string customerPhone)
        {
            return await CustomerDAO.SearchByPhoneAsync(customerPhone);
        }

        public static List<Customer> SearchByEmail(string customerEmail)
        {
            return CustomerDAO.SearchByEmail(customerEmail);
        }

        public static async Task<List<Customer>> SearchByEmailAsync(string customerEmail)
        {
            return await CustomerDAO.SearchByEmailAsync(customerEmail);
        }

        public static List<Customer> SearchByAddress(string customerAddress)
        {
            return CustomerDAO.SearchByAddress(customerAddress);
        }

        public static async Task<List<Customer>> SearchByAddressAsync(string customerAddress)
        {
            return await CustomerDAO.SearchByAddressAsync(customerAddress);
        }

        public static bool CreateCustomer(Customer customer)
        {
            bool result = CustomerDAO.CreateCustomer(customer);
            if (result)
            {
                Customer newCustomer = CustomerDAO.GetCustomerByPhone(customer.Phone);
                customer.ID = newCustomer.ID;
            }

            return result;
        }

        public static async Task<bool> CreateCutomerAsync(Customer customer)
        {
            bool result = await CustomerDAO.CreateCutomerAsync(customer);
            if (result)
            {
                Customer newCustomer = await CustomerDAO.GetCustomerByPhoneAsync(customer.Phone);
                customer.ID = newCustomer.ID;
            }

            return result;
        }

        public  bool UpdateCustomer(Customer customer)
        {
            return CustomerDAO.UpdateCustomer(customer);
        }

        public  async Task<bool> UpdateCustomerAsync(Customer customer)
        {
            return await CustomerDAO.UpdateCustomerAsync(customer);
        }

        public  bool DeleteCustomer(long customerId)
        {
            return CustomerDAO.DeleteCustomer(customerId);
        }

        public  async Task<bool> DeleteCustomerAsync(long customerId)
        {
            return await CustomerDAO.DeleteCustomerAsync(customerId);
        }

        public static int CountCustomer()
        {
            return CustomerDAO.CountCustomer();
        }

        public static async Task<int> CountCustomerAsync()
        {
            return await CustomerDAO.CountCustomerAsync();
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}
