using BanVeXeKhach.Common.Mail;
using System.Configuration;

namespace BanVeXeKhach.Settings
{
    public static class EmailSetting
    {
        public static void ReadConfigFile()
        {
            SMTP.Host = ConfigurationManager.AppSettings["SMTP_Host"];
            SMTP.Port = int.Parse(ConfigurationManager.AppSettings["SMTP_Port"]);
            SMTP.UserName = ConfigurationManager.AppSettings["SMTP_UserName"];
            SMTP.Password = ConfigurationManager.AppSettings["SMTP_Password"];
        }
    }
}
