using BanVeXeKhach.BUS_DAO.BUS;
using BanVeXeKhach.BUS_DAO.DAO;
using BanVeXeKhach.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeXeKhach.BUS_DAO.BUS
{
    class Assigment
    {
        private Employee employeeId;
        private CoachTrip coachTripId;
        private string role;


        public Employee EmployeeId { get => employeeId; set => employeeId = value; }
        public CoachTrip CoachTripId { get => coachTripId; set => coachTripId = value; }
        public string Role { get => role; set => role = value; }

        public static List<Assigment> GetAssigments()
        {
            return AssigmentDAO.GetAssigments();
        }

        public static async Task<List<Assigment>> GetAssigmentsAsync()
        {
            return await AssigmentDAO.GetAssigmentsAsync();
        }

        public static Assigment GetAssigment(string role)
        {
            return AssigmentDAO.GetAssigment(role);
        }

        public static async Task<Assigment> GetAssigmentAsync(string role)
        {
            return await AssigmentDAO.GetAssigmentAsync(role);
        }

        public static List<Assigment> SearchByEmployee(Employee employee)
        {
            return AssigmentDAO.SearchByEmployee(employee);
        }
        public static async Task<List<Assigment>> SearchByEmployeeAsync(Employee employee)
        {
            return await AssigmentDAO.SearchByEmployeeAsync(employee);

        }

        public static List<Assigment> SearchByCoachTrip(CoachTrip coachTrip)
        {
            return AssigmentDAO.SearchByCoachTrip(coachTrip);

        }

        public static async Task<List<Assigment>> SearchByCoachTripAsync(CoachTrip coachTrip)
        {
            return await AssigmentDAO.SearchByCoachTripAsync(coachTrip);

        }

        public static List<Assigment> SearchByRole(string role)
        {
            return AssigmentDAO.SearchByRole(role);

        }

        public static async Task<List<Assigment>> SearchByRoleAsync(string role)
        {
            return await AssigmentDAO.SearchByRoleAsync(role);

        }


    }

}
