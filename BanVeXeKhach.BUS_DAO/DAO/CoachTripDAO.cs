using BanVeXeKhach.BUS_DAO.BUS;
using BanVeXeKhach.SqlServer;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BanVeXeKhach.BUS_DAO.DAO
{
    public class CoachTripDAO
    {
        private static SqlExecution sqlExecution = DataAccessConfiguration.GetSqlExecution();

        public static List<CoachTrip> GetCoachTrips()
        {
            string commandText = @"
                Select 
                    CoachTrip.*, Route.ID as 'route.ID', Route.[name] as 'route.Name',
                    CoachTripStatus.ID as 'status.ID', CoachTripStatus.[name] as 'status.Name',
                    Vehicle.ID as 'vehicle.ID', Vehicle.[name] as 'vehicle.Name'
                from CoachTrip, Route, CoachTripStatus, Vehicle
                where CoachTrip.routeId = Route.ID 
                    and CoachTrip.statusId = CoachTripStatus.ID and CoachTrip.vehicleId = Vehicle.ID";

            return sqlExecution.ToList<CoachTrip>(commandText, CommandType.Text);
        }

        public static async Task<List<CoachTrip>> GetCoachTripsAsync()
        {
            string commandText = @"
                Select 
                    CoachTrip.*, Route.ID as 'route.ID', Route.[name] as 'route.Name',
                    CoachTripStatus.ID as 'status.ID', CoachTripStatus.[name] as 'status.Name',
                    Vehicle.ID as 'vehicle.ID', Vehicle.[name] as 'vehicle.Name'
                from CoachTrip, Route, CoachTripStatus, Vehicle
                where CoachTrip.routeId = Route.ID 
                    and CoachTrip.statusId = CoachTripStatus.ID and CoachTrip.vehicleId = Vehicle.ID";

            return await sqlExecution.ToListAsync<CoachTrip>(commandText, CommandType.Text);
        }

        public static List<CoachTrip> GetCoachTripsByRouteId(int routeId)
        {
            string commandText = @"
                Select 
                    CoachTrip.*, Route.ID as 'route.ID', Route.[name] as 'route.Name',
                    CoachTripStatus.ID as 'status.ID', CoachTripStatus.[name] as 'status.Name',
                    Vehicle.ID as 'vehicle.ID', Vehicle.[name] as 'vehicle.Name'
                from CoachTrip, Route, CoachTripStatus, Vehicle
                where CoachTrip.routeId = Route.ID and CoachTrip.statusId = CoachTripStatus.ID 
                    and CoachTrip.vehicleId = Vehicle.ID and Route.ID = @routeId";

            return sqlExecution.ToList<CoachTrip>(commandText, CommandType.Text, new SqlParameter("@routeId", routeId));
        }

        public static async Task<List<CoachTrip>> GetCoachTripsByRouteIdAsync(int routeId)
        {
            string commandText = @"
                Select 
                    CoachTrip.*, Route.ID as 'route.ID', Route.[name] as 'route.Name',
                    CoachTripStatus.ID as 'status.ID', CoachTripStatus.[name] as 'status.Name',
                    Vehicle.ID as 'vehicle.ID', Vehicle.[name] as 'vehicle.Name'
                from CoachTrip, Route, CoachTripStatus, Vehicle
                where CoachTrip.routeId = Route.ID and CoachTrip.statusId = CoachTripStatus.ID 
                    and CoachTrip.vehicleId = Vehicle.ID and Route.ID = @routeId";

            return await sqlExecution
                .ToListAsync<CoachTrip>(commandText, CommandType.Text, new SqlParameter("@routeId", routeId));
        }

        public static List<CoachTrip> GetCoachTripsByRouteIdAndStatusName(int routeId, string statusName)
        {
            string commandText = @"
                Select 
                    CoachTrip.*, Route.ID as 'route.ID', Route.[name] as 'route.Name',
                    CoachTripStatus.ID as 'status.ID', CoachTripStatus.[name] as 'status.Name',
                    Vehicle.ID as 'vehicle.ID', Vehicle.[name] as 'vehicle.Name'
                from CoachTrip, Route, CoachTripStatus, Vehicle
                where CoachTrip.routeId = Route.ID and CoachTrip.statusId = CoachTripStatus.ID 
                    and CoachTrip.vehicleId = Vehicle.ID and Route.ID = @routeId 
                    and CoachTripStatus.[name] = @statusName";

            return sqlExecution.ToList<CoachTrip>(
                commandText, CommandType.Text, 
                new SqlParameter("@routeId", routeId),
                new SqlParameter("@statusName", statusName)
            );
        }

        public static async Task<List<CoachTrip>> GetCoachTripsByRouteIdAndStatusNameAsync(int routeId, string statusName)
        {
            string commandText = @"
                Select 
                    CoachTrip.*, Route.ID as 'route.ID', Route.[name] as 'route.Name',
                    CoachTripStatus.ID as 'status.ID', CoachTripStatus.[name] as 'status.Name',
                    Vehicle.ID as 'vehicle.ID', Vehicle.[name] as 'vehicle.Name'
                from CoachTrip, Route, CoachTripStatus, Vehicle
                where CoachTrip.routeId = Route.ID and CoachTrip.statusId = CoachTripStatus.ID 
                    and CoachTrip.vehicleId = Vehicle.ID and Route.ID = @routeId 
                    and CoachTripStatus.[name] = @statusName";

            return await sqlExecution.ToListAsync<CoachTrip>(
                commandText, CommandType.Text,
                new SqlParameter("@routeId", routeId),
                new SqlParameter("@statusName", statusName)
            );
        }

        public static CoachTrip GetCoachTrip(long coachTripId)
        {
            string commandText = @"
                Select 
                    CoachTrip.*, Route.ID as 'route.ID', Route.[name] as 'route.Name',
                    CoachTripStatus.ID as 'status.ID', CoachTripStatus.[name] as 'status.Name',
                    Vehicle.ID as 'vehicle.ID', Vehicle.[name] as 'vehicle.Name'
                from CoachTrip, Route, CoachTripStatus, Vehicle
                where CoachTrip.routeId = Route.ID
                    and CoachTrip.statusId = CoachTripStatus.ID and CoachTrip.vehicleId = Vehicle.ID and CoachTrip.ID = @coachTripId";

            return sqlExecution.To<CoachTrip>(commandText, CommandType.Text, new SqlParameter("@coachTripId", coachTripId));
        }

        public static async Task<CoachTrip> GetCoachTripAsync(long coachTripId)
        {
            string commandText = @"
                Select 
                    CoachTrip.*, Route.ID as 'route.ID', Route.[name] as 'route.Name',
                    CoachTripStatus.ID as 'status.ID', CoachTripStatus.[name] as 'status.Name',
                    Vehicle.ID as 'vehicle.ID', Vehicle.[name] as 'vehicle.Name'
                from CoachTrip, Route, CoachTripStatus, Vehicle
                where CoachTrip.routeId = Route.ID
                    and CoachTrip.statusId = CoachTripStatus.ID and CoachTrip.vehicleId = Vehicle.ID and CoachTrip.ID = @coachTripId";

            return await sqlExecution.ToAsync<CoachTrip>(commandText, CommandType.Text, new SqlParameter("@coachTripId", coachTripId));
        }

        public static CoachTrip GetCoachTripByName(string coachTripName)
        {
            string commandText = @"
                Select 
                    CoachTrip.*, Route.ID as 'route.ID', Route.[name] as 'route.Name',
                    CoachTripStatus.ID as 'status.ID', CoachTripStatus.[name] as 'status.Name',
                    Vehicle.ID as 'vehicle.ID', Vehicle.[name] as 'vehicle.Name'
                from CoachTrip, Route, CoachTripStatus, Vehicle
                where CoachTrip.routeId = Route.ID
                    and CoachTrip.statusId = CoachTripStatus.ID and CoachTrip.vehicleId = Vehicle.ID and CoachTrip.[name] = @coachTripName";
            
            return sqlExecution.To<CoachTrip>(commandText, CommandType.Text, new SqlParameter("@coachTripName", coachTripName));
        }

        public static async Task<CoachTrip> GetCoachTripByNameAsync(string coachTripName)
        {
            string commandText = @"
                Select 
                    CoachTrip.*, Route.ID as 'route.ID', Route.[name] as 'route.Name',
                    CoachTripStatus.ID as 'status.ID', CoachTripStatus.[name] as 'status.Name',
                    Vehicle.ID as 'vehicle.ID', Vehicle.[name] as 'vehicle.Name'
                from CoachTrip, Route, CoachTripStatus, Vehicle
                where CoachTrip.routeId = Route.ID
                    and CoachTrip.statusId = CoachTripStatus.ID and CoachTrip.vehicleId = Vehicle.ID and CoachTrip.[name] = @coachTripName";
            
            return await sqlExecution.ToAsync<CoachTrip>(commandText, CommandType.Text, new SqlParameter("@coachTripName", coachTripName));
        }

        public static List<CoachTrip> SearchByName(string coachTripName)
        {
            string commandText = @"
                Select 
                    CoachTrip.*, Route.ID as 'route.ID', Route.[name] as 'route.Name',
                    CoachTripStatus.ID as 'status.ID', CoachTripStatus.[name] as 'status.Name',
                    Vehicle.ID as 'vehicle.ID', Vehicle.[name] as 'vehicle.Name'
                from CoachTrip, Route, CoachTripStatus, Vehicle
                where CoachTrip.routeId = Route.ID
                    and CoachTrip.statusId = CoachTripStatus.ID and CoachTrip.vehicleId = Vehicle.ID and CoachTrip.[name] like @coachTripName";

            return sqlExecution.ToList<CoachTrip>(commandText, CommandType.Text, new SqlParameter("@coachTripName", "%" + coachTripName + "%"));
        }

        public static async Task<List<CoachTrip>> SearchByNameAsync(string coachTripName)
        {
            string commandText = @"
                Select 
                    CoachTrip.*, Route.ID as 'route.ID', Route.[name] as 'route.Name',
                    CoachTripStatus.ID as 'status.ID', CoachTripStatus.[name] as 'status.Name',
                    Vehicle.ID as 'vehicle.ID', Vehicle.[name] as 'vehicle.Name'
                from CoachTrip, Route, CoachTripStatus, Vehicle
                where CoachTrip.routeId = Route.ID
                    and CoachTrip.statusId = CoachTripStatus.ID and CoachTrip.vehicleId = Vehicle.ID and CoachTrip.[name] like @coachTripName";

            return await sqlExecution.ToListAsync<CoachTrip>(commandText, CommandType.Text, new SqlParameter("@coachTripName", "%" + coachTripName + "%"));
        }

        public static List<CoachTrip> SearchByDepartureDate(string departureDate)
        {
            string commandText = @"
                Select 
                    CoachTrip.*, Route.ID as 'route.ID', Route.[name] as 'route.Name',
                    CoachTripStatus.ID as 'status.ID', CoachTripStatus.[name] as 'status.Name',
                    Vehicle.ID as 'vehicle.ID', Vehicle.[name] as 'vehicle.Name'
                from CoachTrip, Route, CoachTripStatus, Vehicle
                where CoachTrip.routeId = Route.ID
                    and CoachTrip.statusId = CoachTripStatus.ID and CoachTrip.vehicleId = Vehicle.ID and CoachTrip.departureDate like @departureDate";

            return sqlExecution.ToList<CoachTrip>(commandText, CommandType.Text, new SqlParameter("@departureDate", "%" + departureDate + "%"));
        }

        public static async Task<List<CoachTrip>> SearchByDepartureDateAsync(string departureDate)
        {
            string commandText = @"
                Select 
                    CoachTrip.*, Route.ID as 'route.ID', Route.[name] as 'route.Name',
                    CoachTripStatus.ID as 'status.ID', CoachTripStatus.[name] as 'status.Name',
                    Vehicle.ID as 'vehicle.ID', Vehicle.[name] as 'vehicle.Name'
                from CoachTrip, Route, CoachTripStatus, Vehicle
                where CoachTrip.routeId = Route.ID
                    and CoachTrip.statusId = CoachTripStatus.ID and CoachTrip.vehicleId = Vehicle.ID and CoachTrip.departureDate like @departureDate";

            return await sqlExecution.ToListAsync<CoachTrip>(commandText, CommandType.Text, new SqlParameter("@departureDate", "%" + departureDate + "%"));
        }

        public static List<CoachTrip> SearchByArrivalDate(string arrivalDate)
        {
            string commandText = @"
                Select 
                    CoachTrip.*, Route.ID as 'route.ID', Route.[name] as 'route.Name',
                    CoachTripStatus.ID as 'status.ID', CoachTripStatus.[name] as 'status.Name',
                    Vehicle.ID as 'vehicle.ID', Vehicle.[name] as 'vehicle.Name'
                from CoachTrip, Route, CoachTripStatus, Vehicle
                where CoachTrip.routeId = Route.ID
                    and CoachTrip.statusId = CoachTripStatus.ID and CoachTrip.vehicleId = Vehicle.ID and CoachTrip.arrivalDate like @arrivalDate";

            return sqlExecution.ToList<CoachTrip>(commandText, CommandType.Text, new SqlParameter("@arrivalDate", "%" + arrivalDate + "%"));
        }

        public static async Task<List<CoachTrip>> SearchByArrivalDateAsync(string arrivalDate)
        {
            string commandText = @"
                Select 
                    CoachTrip.*, Route.ID as 'route.ID', Route.[name] as 'route.Name',
                    CoachTripStatus.ID as 'status.ID', CoachTripStatus.[name] as 'status.Name',
                    Vehicle.ID as 'vehicle.ID', Vehicle.[name] as 'vehicle.Name'
                from CoachTrip, Route, CoachTripStatus, Vehicle
                where CoachTrip.routeId = Route.ID
                    and CoachTrip.statusId = CoachTripStatus.ID and CoachTrip.vehicleId = Vehicle.ID and CoachTrip.arrivalDate like @arrivalDate";

            return await sqlExecution.ToListAsync<CoachTrip>(commandText, CommandType.Text, new SqlParameter("@arrivalDate", "%" + arrivalDate + "%"));
        }

        public static bool CreateCoachTrip(CoachTrip coachTrip)
        {
            string commandText = @"Select count(*) from CoachTrip where [name] = @coachTripName";
            int count = (int)sqlExecution.ExecuteScalar(
                commandText, CommandType.Text,
                new SqlParameter("@coachTripName", coachTrip.Name)
            );

            if (count > 0)
                return false;

            commandText = @"
                Insert into CoachTrip 
                    values (@coachTripName, @routeId, @departureDate, @arrivalDate, @statusId, @vehicleId)";

            int affected = sqlExecution.ExecuteNonQuery(
                commandText, CommandType.Text,
                new SqlParameter("@coachTripId", coachTrip.CoachTripId),
                new SqlParameter("@coachTripName", coachTrip.Name),
                new SqlParameter("@routeId", coachTrip.Route.RouteId),
                new SqlParameter("@departureDate", coachTrip.DepartureDate),
                new SqlParameter("@arrivalDate", coachTrip.ArrivalDate),
                new SqlParameter("@statusId", coachTrip.Status.CoachTripStatusId),
                new SqlParameter("@vehicleId", coachTrip.Vehicle.VehicleId)
            );

            return affected > 0;
        }

        public static async Task<bool> CreateCoachTripAsync(CoachTrip coachTrip)
        {
            string commandText = @"Select count(*) from CoachTrip where [name] = @coachTripName";
            int count = (int)await sqlExecution.ExecuteScalarAsync(
                commandText, CommandType.Text,
                new SqlParameter("@coachTripName", coachTrip.Name)
            );

            if (count > 0)
                return false;

            commandText = @"
                Insert into CoachTrip 
                    values (@coachTripName, @routeId, @departureDate, @arrivalDate, @statusId, @vehicleId)";

            int affected = await sqlExecution.ExecuteNonQueryAsync(
                commandText, CommandType.Text,
                new SqlParameter("@coachTripId", coachTrip.CoachTripId),
                new SqlParameter("@coachTripName", coachTrip.Name),
                new SqlParameter("@routeId", coachTrip.Route.RouteId),
                new SqlParameter("@departureDate", coachTrip.DepartureDate),
                new SqlParameter("@arrivalDate", coachTrip.ArrivalDate),
                new SqlParameter("@statusId", coachTrip.Status.CoachTripStatusId),
                new SqlParameter("@vehicleId", coachTrip.Vehicle.VehicleId)
            );

            return affected > 0;
        }

        public static bool UpdateCoachTrip(CoachTrip coachTrip)
        {
            string commandText = @"
                Select count(*) from CoachTrip 
                    where [name] = @coachTripName and ID != @coachTripId";

            int count = (int)sqlExecution.ExecuteScalar(
                commandText, CommandType.Text,
                new SqlParameter("@coachTripName", coachTrip.Name),
                new SqlParameter("@coachTripId", coachTrip.CoachTripId)
            );

            if (count > 0)
                return false;

            commandText = @"
                Update CoachTrip 
                    set [name] = @coachTripName, routeId = @routeId, departureDate = @departureDate, 
                        arrivalDate = @arrivalDate, statusId = @statusId, vehicleId = @vehicleId
                where ID = @coachTripId";

            int affected = sqlExecution.ExecuteNonQuery(
                commandText, CommandType.Text,
                new SqlParameter("@coachTripName", coachTrip.Name),
                new SqlParameter("@routeId", coachTrip.Route.RouteId),
                new SqlParameter("@departureDate", coachTrip.DepartureDate),
                new SqlParameter("@arrivalDate", coachTrip.ArrivalDate),
                new SqlParameter("@statusId", coachTrip.Status.CoachTripStatusId),
                new SqlParameter("@vehicleId", coachTrip.Vehicle.VehicleId),
                new SqlParameter("@coachTripId", coachTrip.CoachTripId)
            );

            return affected > 0;
        }

        public static async Task<bool> UpdateCoachTripAsync(CoachTrip coachTrip)
        {
            string commandText = @"
                Select count(*) from CoachTrip 
                    where [name] = @coachTripName and ID != @coachTripId";

            int count = (int)await sqlExecution.ExecuteScalarAsync(
                commandText, CommandType.Text,
                new SqlParameter("@coachTripName", coachTrip.Name),
                new SqlParameter("@routeId", coachTrip.Route.RouteId),
                new SqlParameter("@coachTripId", coachTrip.CoachTripId)
            );

            if (count > 0)
                return false;

            commandText = @"
                Update CoachTrip 
                    set [name] = @coachTripName, routeId = @routeId, departureDate = @departureDate, 
                        arrivalDate = @arrivalDate, statusId = @statusId, vehicleId = @vehicleId
                where ID = @coachTripId";

            int affected = await sqlExecution.ExecuteNonQueryAsync(
                commandText, CommandType.Text,
                new SqlParameter("@coachTripName", coachTrip.Name),
                new SqlParameter("@routeId", coachTrip.Route.RouteId),
                new SqlParameter("@departureDate", coachTrip.DepartureDate),
                new SqlParameter("@arrivalDate", coachTrip.ArrivalDate),
                new SqlParameter("@statusId", coachTrip.Status.CoachTripStatusId),
                new SqlParameter("@vehicleId", coachTrip.Vehicle.VehicleId),
                new SqlParameter("@coachTripId", coachTrip.CoachTripId)
            );

            return affected > 0;
        }

        public static bool DeleteCoachTrip(long coachTripId)
        {
            string commandText = "Select count(*) from InvoiceDetail where coachTripId = @coachTripId";
            int count = (int)sqlExecution.ExecuteScalar(commandText, CommandType.Text,
                new SqlParameter("@coachTripId", coachTripId));

            if (count > 0)
                return false;

            commandText = "Select count(*) from Assignment where coachTripId = @coachTripId";
            count = (int)sqlExecution.ExecuteScalar(commandText, CommandType.Text,
                new SqlParameter("@coachTripId", coachTripId));

            if (count > 0)
                return false;


            commandText = "Delete from CoachTrip where ID = @coachTripId";
            int affected = sqlExecution.ExecuteNonQuery(commandText, CommandType.Text,
                new SqlParameter("@coachTripId", coachTripId));

            return affected > 0;
        }

        public static async Task<bool> DeleteCoachTripAsync(long coachTripId)
        {
            string commandText = "Select count(*) from InvoiceDetail where coachTripId = @coachTripId";
            int count = (int)await sqlExecution.ExecuteScalarAsync(commandText, CommandType.Text,
                new SqlParameter("@coachTripId", coachTripId));

            if (count > 0)
                return false;

            commandText = "Select count(*) from Assignment where coachTripId = @coachTripId";
            count = (int)await sqlExecution.ExecuteScalarAsync(commandText, CommandType.Text,
                new SqlParameter("@coachTripId", coachTripId));

            if (count > 0)
                return false;


            commandText = "Delete from CoachTrip where ID = @coachTripId";
            int affected = sqlExecution.ExecuteNonQuery(commandText, CommandType.Text,
                new SqlParameter("@coachTripId", coachTripId));

            return affected > 0;
        }

        public static int CountCoachTrip()
        {
            string commandText = "Select count(*) from CoachTrip";
            return (int)sqlExecution.ExecuteScalar(commandText, CommandType.Text);
        }

        public static async Task<int> CountCoachTripAsync()
        {
            string commandText = "Select count(*) from CoachTrip";
            return (int)await sqlExecution.ExecuteScalarAsync(commandText, CommandType.Text);
        }





    }
}
