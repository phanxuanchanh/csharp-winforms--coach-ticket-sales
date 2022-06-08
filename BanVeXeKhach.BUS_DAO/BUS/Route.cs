using BanVeXeKhach.BUS_DAO.DAO;
using BanVeXeKhach.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeXeKhach.BUS_DAO.BUS
{
    public class Route
    {
        private int ID;
        private string name;
        private string origin;
        private string destination;
        private double price;

        public int RouteId { get => ID; set => ID = value; }
        public string Name { get => name; set => name = value; }
        public string Origin { get => origin; set => origin = value; }
        public double Price { get => price; set => price = value; }
        public string Destination { get => destination; set => destination = value; }

        public static List<Route> GetRoutes()
        {
            return RouteDAO.GetRoutes();
        }

        public static async Task<List<Route>> GetRoutesAsync()
        {
            return await RouteDAO.GetRoutesAsync();
        }

        public static Route GetRoute(int routeId)
        {
            return RouteDAO.GetRoute(routeId);
        }

        public static async Task<Route> GetRouteAsync(int routeId)
        {
            return await RouteDAO.GetRouteAsync(routeId);
        }

        public static List<Route> SearchByName(string routeName)
        {
            return RouteDAO.SearchByName(routeName);
        }

        public static async Task<List<Route>> SearchByNameAsync(string routeName)
        {
            return await RouteDAO.SearchByNameAsync(routeName);
        }

        public static List<Route> SearchByRouteOrigin(string routeOrigin)
        {
            return RouteDAO.SearchByRouteOrigin(routeOrigin);
        }

        public static async Task<List<Route>> SearchByRouteOriginAsync(string routeOrigin)
        {
            return await RouteDAO.SearchByRouteOriginAsync(routeOrigin);
        }

        public static List<Route> SearchByRouteDestination(string routeDestination)
        {
            return RouteDAO.SearchByRouteDestination(routeDestination);
        }

        public static async Task<List<Route>> SearchByRouteDestinationAsync(string routeDestination)
        {
            return await RouteDAO.SearchByRouteDestinationAsync(routeDestination);
        }

        public static bool CreateRoute(Route route)
        {
            bool result = RouteDAO.CreateRoute(route);
            if (result)
            {
                Route newRoute = RouteDAO.GetRouteByName(route.Name);
                route.ID = newRoute.ID;
            }

            return result;
        }

        public static async Task<bool> CreateRouteAsync(Route route)
        {
            bool result = await RouteDAO.CreateRouteAsync(route);
            if (result)
            {
                Route newRoute = await RouteDAO.GetRouteByNameAsync(route.Name);
                route.ID = newRoute.ID;
            }

            return result;
        }

        public bool UpdateRoute()
        {
            return RouteDAO.UpdateRoute(this);
        }

        public async Task<bool> UpdateRouteAsync()
        {
            return await RouteDAO.UpdateRouteAsync(this);
        }

        public bool DeleteRoute()
        {
            return RouteDAO.DeleteRoute(RouteId);
        }

        public async Task<bool> DeleteRouteAsync()
        {
            return await RouteDAO.DeleteRouteAsync(RouteId);
        }

        public static int CountRoute()
        {
            return RouteDAO.CountRoute();
        }

        public static async Task<int> CountRouteAsync()
        {
            return await RouteDAO.CountRouteAsync();
        }

    }
}