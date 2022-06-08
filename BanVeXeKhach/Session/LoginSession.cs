using System;

namespace BanVeXeKhach.Session
{
    public static class LoginSession
    {
        public static string EmployeeId { get; set; }
        public static string EmployeeName { get; set; }
        public static string Role { get; set; }
        public static DateTime LoginTime { get; set; }
    }
}
