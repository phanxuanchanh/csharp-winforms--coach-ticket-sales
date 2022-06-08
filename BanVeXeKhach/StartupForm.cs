using BanVeXeKhach.BUS_DAO.BUS;
using BanVeXeKhach.Settings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace BanVeXeKhach
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        private void StartupForm_Load(object sender, EventArgs e)
        {
            timerCloseForm.Enabled = true;

            AppSetting.ConfiguredEmail = !(
                string.IsNullOrEmpty(ConfigurationManager.AppSettings["SMTP_Host"])
                || string.IsNullOrEmpty(ConfigurationManager.AppSettings["SMTP_Port"])
                || string.IsNullOrEmpty(ConfigurationManager.AppSettings["SMTP_UserName"])
                || string.IsNullOrEmpty(ConfigurationManager.AppSettings["SMTP_Password"])
            );

            AppSetting.ConfiguredSqlServer = !(
                string.IsNullOrEmpty(ConfigurationManager.ConnectionStrings["QuanLyBanVeXe"].ConnectionString)
                || string.IsNullOrEmpty(
                    ConfigurationManager
                        .ConnectionStrings["BanVeXeKhach.Properties.Settings.QuanLyBanVeXeKhachConnectionString"].ConnectionString
                )
            );

            if (!AppSetting.ConfiguredEmail || !AppSetting.ConfiguredSqlServer)
            {
                AppSetting.RunInstallationProcess = true;
            }
            else
            {
                EmailSetting.ReadConfigFile();

                if (CoachTripStatus.CountCoachTripStatus() == 0)
                    InsertCoachTripStatusList();

                if (Employee.CountEmployee() == 0)
                    InsertEmployees();

                AppSetting.RunInstallationProcess = false;
            }
        }

        private void InsertEmployees()
        {
            if (Employee.CountEmployee() == 0)
            {
                List<Employee> employees = new List<Employee>
                {
                    new Employee
                    {
                        EmployeeId = "employer1",
                        FullName = "Người chủ 1",
                        Phone = "1234123499",
                        Email = "employee1@damh_banvexekhach.com",
                        Birthday = new DateTime(2001, 01, 01),
                        Address = "Ho Chi Minh",
                        Avatar = "",
                        Description = "",
                        Password = "1234",
                        Title = "Employer"
                    },
                    new Employee
                    {
                        EmployeeId = "conductor1",
                        FullName = "Nhân viên bán vé 1",
                        Phone = "4321432199",
                        Email = "conductor1@damh_banvexekhach.com",
                        Birthday = new DateTime(2001, 01, 01),
                        Address = "Ho Chi Minh",
                        Avatar = "",
                        Description = "",
                        Password = "1234",
                        Title = "Conductor"
                    },
                    new Employee
                    {
                        EmployeeId = "conductor2",
                        FullName = "Nhân viên bán vé 2",
                        Phone = "9876987611",
                        Email = "conductor2@damh_banvexekhach.com",
                        Birthday = new DateTime(2001, 01, 01),
                        Address = "Ho Chi Minh",
                        Avatar = "",
                        Description = "",
                        Password = "1234",
                        Title = "Conductor"
                    }
                };

                foreach (Employee employee in employees)
                {
                    Employee.CreateEmployee(employee);
                }
            }
        }

        private void InsertCoachTripStatusList()
        {
            if (CoachTripStatus.CountCoachTripStatus() == 0)
            {
                List<CoachTripStatus> coachTripStatusList = new List<CoachTripStatus>
                {
                    new CoachTripStatus{ Name = "Chưa khởi hành", Description = "" },
                    new CoachTripStatus{ Name = "Đang di chuyển", Description = "" },
                    new CoachTripStatus{ Name = "Đang hoàn thành chuyến", Description = "" }
                };

                foreach (CoachTripStatus coachTripStatus in coachTripStatusList)
                {
                    CoachTripStatus.CreateCoachTripStatus(coachTripStatus);
                }
            }
        }

        private void timerCloseForm_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
