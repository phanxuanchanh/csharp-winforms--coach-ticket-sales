using BanVeXeKhach.BUS_DAO.DAO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BanVeXeKhach.BUS_DAO.BUS
{
    public class Employee
    {
        private string ID;
        private string fullName;
        private string phone;
        private string email;
        private DateTime birthday;
        private string address;
        private string avatar;
        private string password;
        private string title;
        private string description;

        public string EmployeeId { get => ID; set => ID = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Address { get => address; set => address = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        public string Password { get => password; set => password = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }

        public static List<Employee> GetEmployees()
        {
            return EmployeeDAO.GetEmployees();
        }

        public static async Task<List<Employee>> GetEmployeesAsync()
        {
            return await EmployeeDAO.GetEmployeesAsync();
        }

        public static Employee GetEmployee(string employeeId)
        {
            return EmployeeDAO.GetEmployee(employeeId);
        }

        public static async Task<Employee> GetEmployeeAsync(string employeeId)
        {
            return await EmployeeDAO.GetEmployeeAsync(employeeId);
        }

        public static List<Employee> SearchByFullName(string employeeName)
        {
            return EmployeeDAO.SearchByFullName(employeeName);
        }

        public static async Task<List<Employee>> SearchByFullNameAsync(string employeeName)
        {
            return await EmployeeDAO.SearchByFullNameAsync(employeeName);
        }

        public static List<Employee> SearchByPhone(string employeePhone)
        {
            return EmployeeDAO.SearchByPhone(employeePhone);
        }

        public static async Task<List<Employee>> SearchByPhoneAsync(string employeePhone)
        {
            return await EmployeeDAO.SearchByPhoneAsync(employeePhone);
        }

        public static List<Employee> SearchByEmail(string employeeEmail)
        {
            return EmployeeDAO.SearchByEmail(employeeEmail);
        }

        public static async Task<List<Employee>> SearchByEmailAsync(string employeeEmail)
        {
            return await EmployeeDAO.SearchByEmailAsync(employeeEmail);
        }

        public static List<Employee> SearchByAddress(string employeeAddress)
        {
            return EmployeeDAO.SearchByAddress(employeeAddress);
        }

        public static async Task<List<Employee>> SearchByAddressAsync(string employeeAddress)
        {
            return await EmployeeDAO.SearchByAddressAsync(employeeAddress);
        }

        public static bool CreateEmployee(Employee employee)
        {
            return EmployeeDAO.CreateEmployee(employee);
        }

        public static async Task<bool> CreateEmployeeAsync(Employee employee)
        {
            return await EmployeeDAO.CreateEmployeeAsync(employee);
        }

        public bool LogIn()
        {
            bool result = EmployeeDAO.LogIn(EmployeeId, Password);
            if (result)
            {
                Employee employee = EmployeeDAO.GetEmployee(EmployeeId);
                EmployeeId = employee.ID;
                FullName = employee.FullName;
                Phone = employee.Phone;
                Email = employee.Email;
                Birthday = employee.Birthday;
                Address = employee.Address;
                Title = employee.Title;
            }

            return result;
        }

        public async Task<bool> LogInAsync()
        {
            bool result = await EmployeeDAO.LogInAsync(EmployeeId, Password);
            if (result)
            {
                Employee employee = await EmployeeDAO.GetEmployeeAsync(EmployeeId);
                EmployeeId = employee.ID;
                FullName = employee.FullName;
                Phone = employee.Phone;
                Email = employee.Email;
                Birthday = employee.Birthday;
                Address = employee.Address;
                Title = employee.Title;
            }

            return result;
        }

        public bool UpdateEmployee()
        {
            return EmployeeDAO.UpdateEmployee(this);
        }

        public async Task<bool> UpdateEmployeeAsync()
        {
            return await EmployeeDAO.UpdateEmployeeAsync(this);
        }

        public bool UpdateAvatar()
        {
            return EmployeeDAO.UpdateAvatar(EmployeeId, Avatar);
        }

        public async Task<bool> UpdateAvatarAsync()
        {
            return await EmployeeDAO.UpdateAvatarAsync(EmployeeId, Avatar);
        }

        public bool DeleteEmployee(string employeeId)
        {
            return EmployeeDAO.DeleteEmployee(employeeId);
        }

        public async Task<bool> DeleteEmployeeAsync(string employeeId)
        {
            return await EmployeeDAO.DeleteEmployeeAsync(employeeId);
        }

        public static int CountEmployee()
        {
            return EmployeeDAO.CountEmployee();
        }

        public static async Task<int> CountEmployeeAsync()
        {
            return await EmployeeDAO.CountEmployeeAsync();
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}
