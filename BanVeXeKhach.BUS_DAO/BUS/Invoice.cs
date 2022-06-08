using BanVeXeKhach.BUS_DAO.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BanVeXeKhach.BUS_DAO.BUS
{
    public class Invoice
    {
        private long ID;
        private Customer customer;
        private Employee employee;
        private double totalMoney;
        private DateTime purchaseDate;
        private string status;

        public long InvoiceId { get => ID; set => ID = value; }
        public Customer Customer { get => customer; set => customer = value; }
        public Employee Employee { get => employee; set => employee = value; }
        public double TotalMoney { get => totalMoney; set => totalMoney = value; }
        public DateTime PurchaseDate { get => purchaseDate; set => purchaseDate = value; }
        public string Status { get => status; set => status = value; }

        public static DataTable GetVW_Invoice()
        {
            return InvoiceDAO.GetVW_Invoice();
        }

        public static List<Invoice> GetInvoices()
        {
            return InvoiceDAO.GetInvoices();
        }

        public static async Task<List<Invoice>> GetInvoicesAsync()
        {
            return await InvoiceDAO.GetInvoicesAsync();
        }

        public static List<Invoice> GetInvoicesByCustomerId(long customerId)
        {
            return InvoiceDAO.GetInvoicesByCustomerId(customerId);
        }

        public static async Task<List<Invoice>> GetInvoicesByCustomerIdAsync(long customerId)
        {
            return await InvoiceDAO.GetInvoicesByCustomerIdAsync(customerId);
        }

        public static Invoice GetInvoice(long invoiceId)
        {
            return InvoiceDAO.GetInvoice(invoiceId);
        }

        public static async Task<Invoice> GetInvoiceAsync(long invoiceId)
        {
            return await InvoiceDAO.GetInvoiceAsync(invoiceId);
        }

        public static List<Invoice> SearchByCustomerName(string customerName)
        {
            return  InvoiceDAO.SearchByCustomerName(customerName);
        }

        public static async Task<List<Invoice>> SearchByCustomerNameAsync(string customerName)
        {
            return await InvoiceDAO.SearchByCustomerNameAsync(customerName);
        }

        public static List<Invoice> SearchByEmployeeName(string employeeName)
        {
            return InvoiceDAO.SearchByEmployeeName(employeeName);
        }

        public static async Task<List<Invoice>> SearchByEmployeeNameAsync(string employeeName)
        {
            return await InvoiceDAO.SearchByEmployeeNameAsync(employeeName);
        }

        public static List<Invoice> SearchByPurchaseDate(string purchaseDate)
        {
            return InvoiceDAO.SearchByPurchaseDate(purchaseDate);
        }

        public static async Task<List<Invoice>> SearchByPurchaseDateAsync(string purchaseDate)
        {
            return await InvoiceDAO.SearchByPurchaseDateAsync(purchaseDate);
        }

        public static bool CreateInvoice(Invoice invoice)
        {
            bool result = InvoiceDAO.CreateInvoice(invoice);
            if (result)
            {
                Invoice newInvoice = InvoiceDAO.GetIncompleteInvoice(invoice.Customer.CustomerId, invoice.Employee.EmployeeId);
                invoice.InvoiceId = newInvoice.InvoiceId;
            }

            return result;
        }

        public static async Task<bool> CreateInvoiceAsync(Invoice invoice)
        {
            bool result = await InvoiceDAO.CreateInvoiceAsync(invoice);
            if (result)
            {
                Invoice newInvoice = await InvoiceDAO
                    .GetIncompleteInvoiceAsync(invoice.Customer.CustomerId, invoice.Employee.EmployeeId);
                invoice.InvoiceId = newInvoice.InvoiceId;
            }

            return result;
        }

        public  bool UpdateInvoice()
        {
            return InvoiceDAO.UpdateInvoice(this);
        }

        public async Task<bool> UpdateInvoiceAsync()
        {
            return await InvoiceDAO.UpdateInvoiceAsync(this);
        }

        public  bool DeleteInvoice()
        {
            return InvoiceDAO.DeleteInvoice(InvoiceId);
        }

        public  async Task<bool> DeleteInvoiceAsync()
        {
            return await InvoiceDAO.DeleteInvoiceAsync(InvoiceId);
        }

        public static int CountInvoice()
        {
            return InvoiceDAO.CountInvoice();
        }

        public static async Task<int> CountInvoiceAsync()
        {
            return await InvoiceDAO.CountInvoiceAsync();
        }

        public static int CountInvoiceByCustomerId(long customerId)
        {
            return InvoiceDAO.CountInvoiceByCustomerId(customerId);
        }

        public static async Task<int> CountInvoiceByCustomerIdAsync(long customerId)
        {
            return await InvoiceDAO.CountInvoiceByCustomerIdAsync(customerId);
        }

        public override string ToString()
        {
            return ID.ToString();
        }
    }

}
