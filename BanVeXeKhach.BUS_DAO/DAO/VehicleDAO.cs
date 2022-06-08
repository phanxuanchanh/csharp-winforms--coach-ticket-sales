using BanVeXeKhach.BUS_DAO.BUS;
using BanVeXeKhach.SqlServer;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BanVeXeKhach.BUS_DAO.DAO
{
    public class VehicleDAO
    {
        private static SqlExecution sqlExecution = DataAccessConfiguration.GetSqlExecution();

        public static List<Vehicle> GetVehicles()
        {
            string commandText = "Select * from Vehicle";
            return sqlExecution.ToList<Vehicle>(commandText, CommandType.Text);
        }

        public static async Task<List<Vehicle>> GetVehiclesAsync()
        {
            string commandText = "Select * from Vehicle";
            return await sqlExecution.ToListAsync<Vehicle>(commandText, CommandType.Text);
        }

        public static Vehicle GetVehicle(long vehicleId)
        {
            string commandText = "Select * from Vehicle where ID = @vehicleId";
            return sqlExecution.To<Vehicle>(commandText, CommandType.Text, new SqlParameter("@vehicleId", vehicleId));
        }

        public static async Task<Vehicle> GetVehicleAsync(long vehicleId)
        {
            string commandText = "Select * from Vehicle where ID = @vehicleId";
            return await sqlExecution.ToAsync<Vehicle>(commandText, CommandType.Text, new SqlParameter("@vehicleId", vehicleId));
        }

        public static Vehicle GetVehicleByName(string vehicleName)
        {
            string commandText = "Select * from Vehicle where [name] = @vehicleName";
            return sqlExecution.To<Vehicle>(commandText, CommandType.Text, new SqlParameter("@vehicleName", vehicleName));
        }

        public static async Task<Vehicle> GetVehicleByNameAsync(string vehicleName)
        {
            string commandText = "Select * from Vehicle where [name] = @vehicleName";
            return await sqlExecution.ToAsync<Vehicle>(commandText, CommandType.Text, new SqlParameter("@vehicleName", vehicleName));
        }

        public static List<Vehicle> SearchByName(string vehicleName)
        {
            string commandText = "Select * from Vehicle where [name] like @vehicleName";
            return sqlExecution.ToList<Vehicle>(commandText, CommandType.Text, new SqlParameter("@vehicleName", "%" + vehicleName + "%"));
        }

        public static async Task<List<Vehicle>> SearchByNameAsync(string vehicleName)
        {
            string commandText = "Select * from Vehicle Where [name] like @vehicleName";
            return await sqlExecution.ToListAsync<Vehicle>(commandText, CommandType.Text, new SqlParameter("@vehicleName", "%" + vehicleName + "%"));
        }

        public static List<Vehicle> SearchBySeatNumber(int seatNumber)
        {
            string commandText = "Select * from Vehicle Where seatNumber like @seatNumber";
            return sqlExecution.ToList<Vehicle>(commandText, CommandType.Text, new SqlParameter("@vehicleName", "%" + seatNumber + "%"));
        }

        public static async Task<List<Vehicle>> SearchBySeatNumberAsync(int seatNumber)
        {
            string commandText = "Select * from Vehicle Where seatNumber like @seatNumber";
            return await sqlExecution.ToListAsync<Vehicle>(commandText, CommandType.Text, new SqlParameter("@seatNumber", "%" + seatNumber + "%"));
        }

        public static List<Vehicle> SearchByLicensePlate(string licensePlate)
        {
            string commandText = "Select * from Vehicle where licensePlate like @licensePlate";
            return sqlExecution.ToList<Vehicle>(commandText, CommandType.Text, new SqlParameter("@licensePlate", "%" + licensePlate + "%"));
        }

        public static async Task<List<Vehicle>> SearchByLicensePlateAsync(string licensePlate)
        {
            string commandText = "Select * from Vehicle where licensePlate like @licensePlate";
            return await sqlExecution.ToListAsync<Vehicle>(commandText, CommandType.Text, new SqlParameter("@licensePlate", "%" + licensePlate + "%"));
        }

        public static bool CreateVehicle(Vehicle vehicle)
        {
            string commandText = @"Select count(*) from Vehicle where [name] = @vehicleName or licensePlate = @licensePlate";
            int count = (int)sqlExecution.ExecuteScalar(
                commandText, CommandType.Text,
                new SqlParameter("@vehicleName", vehicle.Name),
                new SqlParameter("@licensePlate", vehicle.LicensePlate)
            );

            if (count > 0)
                return false;

            commandText = "Insert into Vehicle values (@vehicleName, @description, @seatNumber, @licensePlate)";
            int affected = sqlExecution.ExecuteNonQuery(
                commandText, CommandType.Text,
                new SqlParameter("@vehicleName", vehicle.Name),
                new SqlParameter("@description", vehicle.Description),
                new SqlParameter("@seatNumber", vehicle.SeatNumber),
                new SqlParameter("@licensePlate", vehicle.LicensePlate)
            );

            return affected > 0;
        }

        public static async Task<bool> CreateVehicleAsync(Vehicle vehicle)
        {
            string commandText = @"Select count(*) from Vehicle where [name] = @vehicleName or licensePlate = @licensePlate";
            int count = (int)await sqlExecution.ExecuteScalarAsync(
                commandText, CommandType.Text,
                new SqlParameter("@vehicleName", vehicle.Name),
                new SqlParameter("@licensePlate", vehicle.LicensePlate)
            );

            if (count > 0)
                return false;

            commandText = "Insert into Vehicle values (@vehicleName, @description, @seatNumber, @licensePlate)";
            int affected = await sqlExecution.ExecuteNonQueryAsync(
                commandText, CommandType.Text,
                new SqlParameter("@vehicleName", vehicle.Name),
                new SqlParameter("@description", vehicle.Description),
                new SqlParameter("@seatNumber", vehicle.SeatNumber),
                new SqlParameter("@licensePlate", vehicle.LicensePlate)
            );

            return affected > 0;
        }

        public static bool UpdateVehicle(Vehicle vehicle)
        {
            string commandText = @"
                Select count(*) from Vehicle 
                    where [name] = @vehicleName and licensePlate = @licensePlate and ID != @vehicleId";

            int count = (int)sqlExecution.ExecuteScalar(
                commandText, CommandType.Text,
                new SqlParameter("@vehicleName", vehicle.Name),
                new SqlParameter("@licensePlate", vehicle.LicensePlate),
                new SqlParameter("@vehicleId", vehicle.VehicleId)
            );

            if (count > 0)
                return false;

            commandText = @"
                Update Vehicle 
                    set [name] = @vehicleName, description = @description, seatNumber = @seatNumber, licensePlate = @licensePlate 
                where ID = @vehicleId ";

            int affected = (int)sqlExecution.ExecuteNonQuery(
                commandText, CommandType.Text,
                new SqlParameter("@vehicleName", vehicle.Name),
                new SqlParameter("@description", vehicle.Description),
                new SqlParameter("@seatNumber", vehicle.SeatNumber),
                new SqlParameter("@licensePlate", vehicle.LicensePlate),
                new SqlParameter("@vehicleId", vehicle.VehicleId)
            );

            return affected > 0;
        }

        public static async Task<bool> UpdateVehicleAsync(Vehicle vehicle)
        {
            string commandText = @"
                Select count(*) from Vehicle 
                    where [name] = @vehicleName and licensePlate = @licensePlate and ID != @vehicleId";

            int count = (int)await sqlExecution.ExecuteScalarAsync(
                commandText, CommandType.Text,
                new SqlParameter("@vehicleName", vehicle.Name),
                new SqlParameter("@licensePlate", vehicle.LicensePlate),
                new SqlParameter("@vehicleId", vehicle.VehicleId)
            );

            if (count > 0)
                return false;

            commandText = @"
                Update Vehicle 
                    set [name] = @vehicleName, description = @description, seatNumber = @seatNumber, licensePlate = @licensePlate 
                where ID = @vehicleId ";

            int affected = (int)await sqlExecution.ExecuteNonQueryAsync(
                commandText, CommandType.Text,
                new SqlParameter("@vehicleName", vehicle.Name),
                new SqlParameter("@description", vehicle.Description),
                new SqlParameter("@seatNumber", vehicle.SeatNumber),
                new SqlParameter("@licensePlate", vehicle.LicensePlate),
                new SqlParameter("@vehicleId", vehicle.VehicleId)
            );

            return affected > 0;
        }

        public static bool DeleteVehicle(long vehicleId)
        {
            string commandText = "Select count(*) from CoachTrip where vehicleId = @vehicleId";
            int count = (int)sqlExecution.ExecuteScalar(commandText, CommandType.Text, new SqlParameter("@vehicleId", vehicleId));

            if (count > 0)
                return false;

            commandText = "Delete from Vehicle where ID = @vehicleId";
            int affected = sqlExecution.ExecuteNonQuery(commandText, CommandType.Text, new SqlParameter("@vehicleId", vehicleId));
            return affected > 0;
        }

        public static async Task<bool> DeleteVehicleAsync(long vehicleId)
        {
            string commandText = "Select count(*) from CoachTrip where vehicleId = @vehicleId";
            int count = (int)await sqlExecution.ExecuteScalarAsync(commandText, CommandType.Text, new SqlParameter("@vehicleId", vehicleId));

            if (count > 0)
                return false;

            commandText = "Delete from Vehicle where ID = @vehicleId";
            int affected = await sqlExecution.ExecuteNonQueryAsync(commandText, CommandType.Text, new SqlParameter("@vehicleId", vehicleId));
            return affected > 0;
        }

        public static int CountVehicle()
        {
            string commandText = "Select count(*) from Vehicle";
            return (int)sqlExecution.ExecuteScalar(commandText, CommandType.Text);
        }

        public static async Task<int> CountVehicleAsync()
        {
            string commandText = "Select count(*) from Vehicle";
            return (int)await sqlExecution.ExecuteScalarAsync(commandText, CommandType.Text);
        }
    }
}
