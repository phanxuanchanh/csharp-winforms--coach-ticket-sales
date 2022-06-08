using System.Net;
using System.Net.Mail;

namespace BanVeXeKhach.Common.Mail
{
    public class SMTP
    {
        public static string Host = null;
        public static int Port;
        public static string UserName = null;
        public static string Password = null;

        public static void Send(string sendTo, string subject, string message)
        {
            using (SmtpClient smtp = new SmtpClient())
            {
                smtp.Host = Host;
                smtp.Port = Port;
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(UserName, Password);
                smtp.Send(UserName, sendTo, subject, message);
            }
        }
    }
}
