using BanVeXeKhach.BUS_DAO.DAO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BanVeXeKhach.BUS_DAO.BUS
{
    public class Vehicle
    {
        private long ID;
        private string name;
        private string description;
        private int seatNumber;
        private string licensePlate;


        public long VehicleId { get => ID; set => ID = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int SeatNumber { get => seatNumber; set => seatNumber = value; }
        public string LicensePlate { get => licensePlate; set => licensePlate = value; }


        public static List<Vehicle> GetVehicles()
        {
            return VehicleDAO.GetVehicles();
        }

        public static async Task<List<Vehicle>> GetVehiclesAsync()
        {
            return await VehicleDAO.GetVehiclesAsync();
        }

        public static Vehicle GetVehicle(long vehicleId)
        {
            return VehicleDAO.GetVehicle(vehicleId);
        }

        public static async Task<Vehicle> GetVehicleAsync(long vehicleId)
        {
            return await VehicleDAO.GetVehicleAsync(vehicleId);
        }

        public static List<Vehicle> SearchByName(string vehicleName)
        {
            return VehicleDAO.SearchByName(vehicleName);
        }

        public static async Task<List<Vehicle>> SearchByNameAsync(string vehicleName)
        {
            return await VehicleDAO.SearchByNameAsync(vehicleName);
        }

        public static List<Vehicle> SearchBySeatNumber(int seatNumber)
        {
            return VehicleDAO.SearchBySeatNumber(seatNumber);
        }

        public static async Task<List<Vehicle>> SearchBySeatNumberAsync(int seatNumber)
        {

            return await VehicleDAO.SearchBySeatNumberAsync(seatNumber);
        }

        public static List<Vehicle> SearchByLicensePlate(string licensePlate)
        {
            return VehicleDAO.SearchByLicensePlate(licensePlate);
        }

        public static async Task<List<Vehicle>> SearchByLicensePlateAsync(string licensePlate)
        {
            return await VehicleDAO.SearchByLicensePlateAsync(licensePlate);
        }
    
        public static bool CreateVehicle(Vehicle vehicle)
        {
            bool result = VehicleDAO.CreateVehicle(vehicle);
            if (result)
            {
                Vehicle newVehicle = VehicleDAO.GetVehicleByName(vehicle.Name);
                vehicle.ID = newVehicle.ID;
            }

            return result;
        }

        public static async Task<bool> CreateVehicleAsync(Vehicle vehicle)
        {
            bool result = await VehicleDAO.CreateVehicleAsync(vehicle);
            if (result)
            {
                Vehicle newVehicle = await VehicleDAO.GetVehicleByNameAsync(vehicle.Name);
                vehicle.ID = newVehicle.ID;
            }

            return result;
        }

        public bool UpdateVehicle()
        {
            return VehicleDAO.UpdateVehicle(this);
        }

        public async Task<bool> UpdateVehicleAsync()
        {
            return await VehicleDAO.UpdateVehicleAsync(this);
        }

        public bool DeleteVehicle()
        {
            return VehicleDAO.DeleteVehicle(VehicleId);
        }

        public async Task<bool> DeleteVehicleAsync()
        {
            return await VehicleDAO.DeleteVehicleAsync(VehicleId);
        }

        public static int CountVehicle()
        {
            return VehicleDAO.CountVehicle();
        }

        public static async Task<int> CountVehicleAsync()
        {
            return await VehicleDAO.CountVehicleAsync();
        }
    }
}
