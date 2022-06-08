using BanVeXeKhach.BUS_DAO.BUS;
using BanVeXeKhach.SqlServer;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BanVeXeKhach.BUS_DAO.DAO
{
    public class RouteDAO
    {
        private static SqlExecution sqlExecution = DataAccessConfiguration.GetSqlExecution();

        public static List<Route> GetRoutes()
        {
            string commandText = "Select * from Route";
            return sqlExecution.ToList<Route>(commandText, CommandType.Text);
        }

        public static async Task<List<Route>> GetRoutesAsync()
        {
            string commandText = "Select * from Route";
            return await sqlExecution.ToListAsync<Route>(commandText, CommandType.Text);
        }

        public static Route GetRoute(int routeId)
        {
            string commandText = "Select * from Route where ID = @routeId";
            return sqlExecution.To<Route>(commandText, CommandType.Text, new SqlParameter("@routeId", routeId));
        }

        public static async Task<Route> GetRouteAsync(int routeId)
        {
            string commandText = "Select * from Route where ID = @routeId";
            return await sqlExecution.ToAsync<Route>(commandText, CommandType.Text, new SqlParameter("@routeId", routeId));
        }

        public static Route GetRouteByName(string routeName)
        {
            string commandText = "Select * from Route where [name] = @routeName";
            return sqlExecution.To<Route>(commandText, CommandType.Text, new SqlParameter("@routeName", routeName));
        }

        public static async Task<Route> GetRouteByNameAsync(string routeName)
        {
            string commandText = "Select * from Route where [name] = @routeName";
            return await sqlExecution.ToAsync<Route>(commandText, CommandType.Text, new SqlParameter("@routeName", routeName));
        }

        public static List<Route> SearchByName(string routeName)
        {
            string commandText = "Select * from Route where [name] like @routeName";
            return sqlExecution.ToList<Route>(commandText, CommandType.Text, new SqlParameter("@routeName", "%" + routeName + "%"));
        }

        public static async Task<List<Route>> SearchByNameAsync(string routeName)
        {
            string commandText = "Select * from Route Where [name] like @routeName";
            return await sqlExecution.ToListAsync<Route>(commandText, CommandType.Text, new SqlParameter("@routeName", "%" + routeName + "%"));
        }

        public static List<Route> SearchByRouteOrigin(string routeOrigin)
        {
            string commandText = "Select * from Route where origin like @routeOrigin";
            return sqlExecution.ToList<Route>(commandText, CommandType.Text, new SqlParameter("@routeOrigin", "%" + routeOrigin + "%"));
        }

        public static async Task<List<Route>> SearchByRouteOriginAsync(string routeOrigin)
        {
            string commandText = "Select * from Route where origin like @routeOrigin";
            return await sqlExecution.ToListAsync<Route>(commandText, CommandType.Text, new SqlParameter("@routeOrigin", "%" + routeOrigin + "%"));
        }

        public static List<Route> SearchByRouteDestination(string routeDestination)
        {
            string commandText = "Select * from Route where destination like @routeDestination";
            return sqlExecution.ToList<Route>(commandText, CommandType.Text, new SqlParameter("@routeDestination", "%" + routeDestination + "%"));
        }

        public static async Task<List<Route>> SearchByRouteDestinationAsync(string routeDestination)
        {
            string commandText = "Select * from Route where destination like @routeDestination";
            return await sqlExecution.ToListAsync<Route>(commandText, CommandType.Text, new SqlParameter("@routeDestination", "%" + routeDestination + "%"));
        }

        public static bool CreateRoute(Route route)
        {
            string commandText = @"Select count(*) from Route where origin = @routeOrigin and destination = @routeDestination";
            int count = (int)sqlExecution.ExecuteScalar(
                commandText, CommandType.Text,
                new SqlParameter("@routeOrigin", route.Origin),
                new SqlParameter("@routeDestination", route.Destination)
            );

            if (count > 0)
                return false;

            commandText = @"
                Insert into Route 
                    values (@routeName, @routeOrigin, @routeDestination, @price)";

            int affected = sqlExecution.ExecuteNonQuery(
                commandText, CommandType.Text,
                new SqlParameter("@routeName", route.Name),
                new SqlParameter("@routeOrigin", route.Origin),
                new SqlParameter("@routeDestination", route.Destination),
                new SqlParameter("@price", route.Price)
            );

            return affected > 0;
        }

        public static async Task<bool> CreateRouteAsync(Route route)
        {
            string commandText = @"
                Select count(*) from Route where origin = @routeOrigin and destination = @routeDestination";
            int count = (int)await sqlExecution.ExecuteScalarAsync(
                commandText, CommandType.Text,
                new SqlParameter("@routeOrigin", route.Origin),
                new SqlParameter("@routeDestination", route.Destination)
            );

            if (count > 0)
                return false;

            commandText = @"
                Insert into Route 
                    values (@routeName, @routeOrigin, @routeDestination, @price)";

            int affected = await sqlExecution.ExecuteNonQueryAsync(
                commandText, CommandType.Text,
                new SqlParameter("@routeName", route.Name),
                new SqlParameter("@routeOrigin", route.Origin),
                new SqlParameter("@routeDestination", route.Destination),
                new SqlParameter("@price", route.Price)
            );

            return affected > 0;
        }

        public static bool UpdateRoute(Route route)
        {
            string commandText = @"
                Select count(*) from Route 
                    where origin = @routeOrigin and destination = @routeDestination and ID != @routeId";

            int count = (int)sqlExecution.ExecuteScalar(
                commandText, CommandType.Text,
                new SqlParameter("@routeOrigin", route.Origin),
                new SqlParameter("@routeDestination", route.Destination),
                new SqlParameter("@routeId", route.RouteId)
            );

            if (count > 0)
                return false;

            commandText = @"
                Update Route 
                    set [name] = @routeName, origin = @routeOrigin, destination = @routeDestination, price = @price
                where ID = @routeId";

            int affected = sqlExecution.ExecuteNonQuery(
                commandText, CommandType.Text,
                new SqlParameter("@routeName", route.Name),
                new SqlParameter("@routeOrigin", route.Origin),
                new SqlParameter("@routeDestination", route.Destination),
                new SqlParameter("@price", route.Price),
                new SqlParameter("@routeId", route.RouteId)
            );

            return affected > 0;
        }

        public static async Task<bool> UpdateRouteAsync(Route route)
        {
            string commandText = @"
                Select count(*) from Route 
                    where origin = @routeOrigin and destination = @routeDestination and ID != @routeId";

            int count = (int)await sqlExecution.ExecuteScalarAsync(
                commandText, CommandType.Text,
                new SqlParameter("@routeOrigin", route.Origin),
                new SqlParameter("@routeDestination", route.Destination),
                new SqlParameter("@routeId", route.RouteId)
            );

            if (count > 0)
                return false;

            commandText = @"
                Update Route 
                    set [name] = @routeName, origin = @routeOrigin, destination = @routeDestination, price = @price
                where ID = @routeId";

            int affected = await sqlExecution.ExecuteNonQueryAsync(
                commandText, CommandType.Text,
                new SqlParameter("@routeName", route.Name),
                new SqlParameter("@routeOrigin", route.Origin),
                new SqlParameter("@routeDestination", route.Destination),
                new SqlParameter("@price", route.Price),
                new SqlParameter("@routeId", route.RouteId)
            );

            return affected > 0;
        }

        public static bool DeleteRoute(int routeId)
        {
            string commandText = "Select count(*) from CoachTrip where routeId = @routeId";
            int count = (int)sqlExecution
                .ExecuteScalar(commandText, CommandType.Text, new SqlParameter("@routeId", routeId));

            if (count > 0)
                return false;

            commandText = "Delete from Route where ID = @routeId";
            int affected = sqlExecution
                .ExecuteNonQuery(commandText, CommandType.Text, new SqlParameter("@routeId", routeId));

            return affected > 0;
        }

        public static async Task<bool> DeleteRouteAsync(int routeId)
        {
            string commandText = "Select count(*) from CoachTrip where routeId = @routeId";
            int count = (int)await sqlExecution
                .ExecuteScalarAsync(commandText, CommandType.Text, new SqlParameter("@routeId", routeId));

            if (count > 0)
                return false;

            commandText = "Delete from Route where ID = @routeId";
            int affected = await sqlExecution
                .ExecuteNonQueryAsync(commandText, CommandType.Text, new SqlParameter("@routeId", routeId));

            return affected > 0;
        }

        public static int CountRoute()
        {
            string commandText = "Select count(*) from Route";
            return (int)sqlExecution.ExecuteScalar(commandText, CommandType.Text);
        }

        public static async Task<int> CountRouteAsync()
        {
            string commandText = "Select count(*) from Route";
            return (int)await sqlExecution.ExecuteScalarAsync(commandText, CommandType.Text);
        }
    }
}
