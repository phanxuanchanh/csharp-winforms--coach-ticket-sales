using BanVeXeKhach.BUS_DAO.DAO;
using BanVeXeKhach.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeXeKhach.BUS_DAO.BUS
{
    public class CoachTripStatus
    {
        private int ID;
        private string name;
        private string description ;
       
        public int CoachTripStatusId { get => ID; set => ID = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
     

        public static List<CoachTripStatus> GetCoachTripStatusList()
        {
            return CoachTripStatusDAO.GetCoachTripStatusList();
        }

        public static async Task<List<CoachTripStatus>> GetCoachTripStatusListAsync()
        {
            return await CoachTripStatusDAO.GetCoachTripStatusListAsync();
        }

        public static CoachTripStatus GetCoachTripStatus(int coachTripStatusId)
        {
            return CoachTripStatusDAO.GetCoachTripStatus(coachTripStatusId);
        }

        public static async Task<CoachTripStatus> GetCoachTripStatusAsync(int coachTripStatusId)
        {
            return await CoachTripStatusDAO.GetCoachTripStatusAsync(coachTripStatusId);
        }

        public static bool CreateCoachTripStatus(CoachTripStatus coachTripStatus)
        {
            return CoachTripStatusDAO.CreateCoachTripStatus(coachTripStatus);
        }

        public static async Task<bool> CreateCoachTripStatusAsync(CoachTripStatus coachTripStatus)
        {
            return await CoachTripStatusDAO.CreateCoachTripStatusAsync(coachTripStatus);
        }

        public static int CountCoachTripStatus()
        {
            return CoachTripStatusDAO.CountCoachTripStatus();
        }

        public static async Task<int> CountCoachTripStatusAsync()
        {
            return await CoachTripStatusDAO.CountCoachTripStatusAsync();
        }
    }
}
