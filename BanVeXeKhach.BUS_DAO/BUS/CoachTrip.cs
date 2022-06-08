using BanVeXeKhach.BUS_DAO.DAO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BanVeXeKhach.BUS_DAO.BUS
{
    public class CoachTrip
    {
        private long ID;
        private string name;
        private Route route;
        private DateTime departureDate;
        private DateTime arrivalDate;
        private CoachTripStatus status;
        private Vehicle vehicle;

        public long CoachTripId { get => ID; set => ID = value; }
        public string Name { get => name; set => name = value; }
        public Route Route { get => route; set => route = value; }
        public DateTime DepartureDate { get => departureDate; set => departureDate = value; }
        public DateTime ArrivalDate { get => arrivalDate; set => arrivalDate = value; }
        public CoachTripStatus Status { get => status; set => status = value; }
        public Vehicle Vehicle { get => vehicle; set => vehicle = value; }

        public static List<CoachTrip> GetCoachTrips()
        {
            return CoachTripDAO.GetCoachTrips();
        }

        public static async Task<List<CoachTrip>> GetCoachTripsAsync()
        {
            return await CoachTripDAO.GetCoachTripsAsync();
        }

        public static List<CoachTrip> GetCoachTripsByRouteId(int routeId)
        {
            return CoachTripDAO.GetCoachTripsByRouteId(routeId);
        }

        public static async Task<List<CoachTrip>> GetCoachTripsByRouteIdAsync(int routeId)
        {
            return await CoachTripDAO.GetCoachTripsByRouteIdAsync(routeId);
        }

        public static List<CoachTrip> GetCoachTripsByRouteIdAndStatusName(int routeId, string statusName)
        {
            return CoachTripDAO.GetCoachTripsByRouteIdAndStatusName(routeId, statusName);
        }

        public static async Task<List<CoachTrip>> GetCoachTripsByRouteIdAndStatusNameAsync(int routeId, string statusName)
        {
            return await CoachTripDAO.GetCoachTripsByRouteIdAndStatusNameAsync(routeId, statusName);
        }

        public static CoachTrip GetCoachTrip(long coachTripId)
        {
            return CoachTripDAO.GetCoachTrip(coachTripId);
        }

        public static async Task<CoachTrip> GetCoachTripAsync(long coachTripId)
        {
            return await CoachTripDAO.GetCoachTripAsync(coachTripId);
        }

        public static List<CoachTrip> SearchByName(string coachTripName)
        {
            return CoachTripDAO.SearchByName(coachTripName);
        }

        public static async Task<List<CoachTrip>> SearchByNameAsync(string coachTripName)
        {
            return await CoachTripDAO.SearchByNameAsync(coachTripName);
        }

        public static List<CoachTrip> SearchByDepartureDate(string departureDate)
        {
            return CoachTripDAO.SearchByDepartureDate(departureDate);
        }

        public static async Task<List<CoachTrip>> SearchByDepartureDateAsync(string departureDate)
        {
            return await CoachTripDAO.SearchByDepartureDateAsync(departureDate);
        }

        public static List<CoachTrip> SearchByArrivalDate(string arrivalDate)
        {
            return CoachTripDAO.SearchByArrivalDate(arrivalDate);
        }

        public static async Task<List<CoachTrip>> SearchByArrivalDateAsync(string arrivalDate)
        {
            return await CoachTripDAO.SearchByArrivalDateAsync(arrivalDate);
        }

        public static bool CreateCoachTrip(CoachTrip coachTrip)
        {
            return CoachTripDAO.CreateCoachTrip(coachTrip);
        }

        public static async Task<bool> CreateCoachTripAsync(CoachTrip coachTrip)
        {
            return await CoachTripDAO.CreateCoachTripAsync(coachTrip);
        }

        public bool UpdateCoachTrip()
        {
            return CoachTripDAO.UpdateCoachTrip(this);
        }

        public async Task<bool> UpdateCoachTripAsync()
        {
            return await CoachTripDAO.UpdateCoachTripAsync(this);
        }

        public bool DeleteCoachTrip()
        {
            return CoachTripDAO.DeleteCoachTrip(CoachTripId);
        }

        public async Task<bool> DeleteCoachTripAsync()
        {
            return await CoachTripDAO.DeleteCoachTripAsync(CoachTripId);
        }

        public static int CountCoachTrip()
        {
            return CoachTripDAO.CountCoachTrip();
        }

        public static async Task<int> CountCoachTripAsync()
        {
            return await CoachTripDAO.CountCoachTripAsync();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
