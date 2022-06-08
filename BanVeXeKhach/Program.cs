using BanVeXeKhach.BUS_DAO.DAO;
using BanVeXeKhach.Settings;
using System;
using System.Windows.Forms;

namespace BanVeXeKhach
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new StartupForm());

                if (AppSetting.RunInstallationProcess)
                    Application.Run(new InstallationForm());

                if (!AppSetting.RunInstallationProcess)
                    Application.Run(new MainForm());
            }
            catch(Exception ex)
            {
                Application.Run(new ErrorForm(ex));
            }
            finally
            {
                DataAccessConfiguration.Dispose();
            }
        }
    }
}
