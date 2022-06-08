using BanVeXeKhach.Settings;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace BanVeXeKhach
{
    public partial class InstallationForm : Form
    {
        public InstallationForm()
        {
            InitializeComponent();
        }

        private void InstallationForm_Load(object sender, EventArgs e)
        {
            rtxtDescription.Text += "\n\n";

            if (AppSetting.ConfiguredEmail)
            {
                rtxtDescription.Text += "Thiết lập cấu hình Email: Đã thực hiện\n";
                txtSmtpHost.Enabled = false;
                txtSmtpPort.Enabled = false;
                txtSmtpUsername.Enabled = false;
                txtSmtpPassword.Enabled = false;
            }
            else
            {
                rtxtDescription.Text += "Thiết lập cấu hình Email: Chưa thực hiện\n";
            }


            if (AppSetting.ConfiguredSqlServer)
            {
                rtxtDescription.Text += "Thiết lập cấu hình SqlServer: Đã thực hiện\n";
                txtSqlServerName.Enabled = false;
                txtDatabaseName.Enabled = false;
                txtSqlServerUserId.Enabled = false;
                txtSqlServerPassword.Enabled = false;
            }
            else
            {
                rtxtDescription.Text += "Thiết lập cấu hình SqlServer: Chưa thực hiện\n";
            }
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {

        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelHeaderBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                panelHeaderBar.Capture = false;

                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }

        private void xuiSuperButton_RunInstallationProcess_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            if (!AppSetting.ConfiguredEmail)
            {
                config.AppSettings.Settings.Remove("SMTP_Host");
                config.AppSettings.Settings.Add("SMTP_Host", txtSmtpHost.Text);
                config.AppSettings.Settings.Remove("SMTP_Port");
                config.AppSettings.Settings.Add("SMTP_Port", txtSmtpPort.Text);
                config.AppSettings.Settings.Remove("SMTP_UserName");
                config.AppSettings.Settings.Add("SMTP_UserName", txtSmtpUsername.Text);
                config.AppSettings.Settings.Remove("SMTP_Password");
                config.AppSettings.Settings.Add("SMTP_Password", txtSmtpPassword.Text);
            }

            if (!AppSetting.ConfiguredSqlServer)
            {
                ConnectionStringsSection connectionStringsSection = config.ConnectionStrings;

                string connectionString = string.Format(
                    "Data Source={0};Initial Catalog={1};User ID={2};Password={3}",
                    txtSqlServerName.Text, txtDatabaseName.Text, txtSqlServerUserId.Text, txtSqlServerPassword.Text
                );
                connectionStringsSection.ConnectionStrings["QuanLyBanVeXe"].ConnectionString = connectionString;
                connectionStringsSection
                    .ConnectionStrings["BanVeXeKhach.Properties.Settings.QuanLyBanVeXeKhachConnectionString"]
                    .ConnectionString = connectionString;
            }

            config.Save(ConfigurationSaveMode.Minimal);

            MessageBox.Show("Đã thực hiện các thiết lập thành công, chương trình sẽ được khởi động lại!", "Thông báo");
            
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
