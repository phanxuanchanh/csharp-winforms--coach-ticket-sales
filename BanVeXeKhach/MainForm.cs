using BanVeXeKhach.BUS_DAO.BUS;
using BanVeXeKhach.Session;
using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace BanVeXeKhach
{
    public partial class MainForm : Form
    {
        private Employee employee;
        private string avatarFolderPath;

        public MainForm()
        {
            InitializeComponent();
            InitializeSecondaryComponent();

            employee = new Employee();
            avatarFolderPath = string.Format(@"{0}\Avatars", Path.GetDirectoryName(Application.ExecutablePath));
        }

        private void InitializeSecondaryComponent()
        {
            ucLabel_Header1.SetText("CHƯƠNG TRÌNH BÁN VÉ XE KHÁCH");
            ucLabel_Header2.SetText("TÀI KHOẢN");
            ucLabel_Header2.SetImage(global::BanVeXeKhach.Properties.Resources.businessapplication_edit_male_user_thepencil_theclient_negocio_2321);
            ucLabel_Header2_2.SetText("THỐNG KÊ ĐƠN GIẢN");
            ucLabel_Header2_2.SetImage(global::BanVeXeKhach.Properties.Resources._004_business_report);
            ucLabel_Header2_3.SetText("CÁC CHỨC NĂNG");
            ucLabel_Header2_3.SetImage(global::BanVeXeKhach.Properties.Resources._2825990);
        }

        private bool IsLogin()
        {
            if (string.IsNullOrEmpty(LoginSession.EmployeeId))
                return false;
            return true;
        }

        private bool IsAdmin()
        {
            return (LoginSession.Role == "Admin");
        }

        private bool IsAvatarExists(string avatar)
        {
            return !string.IsNullOrEmpty(avatar);
        }

        private void LoadDefaultForm()
        {
            lbDescription.Text = "Hệ thống phát hiện bạn chưa đăng nhập, hãy nhấn vào nút bên phải để thực hiện.";
            xuiSuperButton_LoginAndLogout.ButtonText = "Đăng nhập";
            xuiSuperButton_LoginAndLogout.BackgroundColor = System.Drawing.Color.FromArgb(24, 202, 142);
            xuiSuperButton_LoginAndLogout.HoverBackgroundColor = System.Drawing.Color.FromArgb(102, 217, 174);
            xuiSuperButton_LoginAndLogout.SelectedBackColor = System.Drawing.Color.FromArgb(24, 202, 142);
            lbUsername.Text = "Tên ND: username";
            lbMail.Text = "Email: example@mail.com";
            lbPhoneNumber.Text = "SĐT: 000000000";
            lbRole.Text = "Chức danh: ...";

            xuiCard_CustomerNumber.Text2 = "0";
            xuiCard_RouteNumber.Text2 = "0";
            xuiCard_EmployeeNumber.Text2 = "0";

            xuiSuperButton_AccountInfo.Enabled = false;
            xuiSuperButton_AdminTool.Enabled = false;
            xuiSuperButton_EmployeeTool.Enabled = false;

            pbAvatar.Image = global::BanVeXeKhach.Properties.Resources._006_businessman;

            lbReloadInfo.Text = string.Format("Dữ liệu được cập nhật vào lúc {0}", DateTime.Now);
        }

        public void UpdateAvatar(string avatar)
        {
            pbAvatar.Image.Dispose();

            if (string.IsNullOrEmpty(avatar))
                pbAvatar.Image = global::BanVeXeKhach.Properties.Resources._006_businessman;
            else 
                pbAvatar.Image = System.Drawing
                    .Image.FromFile(string.Format(@"{0}\{1}", avatarFolderPath, avatar));
        }

        private async void UpdateForm()
        {
            try
            {
                lbDescription.Text = "Để đăng xuất khỏi hệ thống, hãy nhấn vào nút bên phải để thực hiện.";
                xuiSuperButton_LoginAndLogout.ButtonText = "Đăng xuất";
                xuiSuperButton_LoginAndLogout.BackgroundColor = System.Drawing.Color.Red;
                xuiSuperButton_LoginAndLogout.HoverBackgroundColor = System.Drawing.Color.Brown;
                xuiSuperButton_LoginAndLogout.SelectedBackColor = System.Drawing.Color.Red;

                employee = await Employee.GetEmployeeAsync(LoginSession.EmployeeId);

                lbUsername.Text = string.Format("Tên ND: {0}", employee.EmployeeId);
                lbMail.Text = string.Format("Email: {0}", employee.Email); 
                lbPhoneNumber.Text = string.Format("SĐT: {0}", employee.Phone);
                lbRole.Text = string.Format("Chức danh: {0}", employee.Title);

                xuiCard_CustomerNumber.Text2 = (await Customer.CountCustomerAsync()).ToString();
                xuiCard_RouteNumber.Text2 = (await Route.CountRouteAsync()).ToString();
                xuiCard_EmployeeNumber.Text2 = (await Employee.CountEmployeeAsync()).ToString();

                if (IsAdmin())
                {
                    xuiSuperButton_AdminTool.Enabled = true;
                    xuiSuperButton_EmployeeTool.Enabled = false;
                }
                else
                {
                    xuiSuperButton_AdminTool.Enabled = false;
                    xuiSuperButton_EmployeeTool.Enabled = true;
                }
                    
                xuiSuperButton_AccountInfo.Enabled = true;
                timerUpdateForm.Enabled = false;

                if (IsAvatarExists(employee.Avatar))
                    pbAvatar.Image = System.Drawing
                        .Image.FromFile(string.Format(@"{0}\{1}", avatarFolderPath, employee.Avatar));
                else
                    pbAvatar.Image = global::BanVeXeKhach.Properties.Resources._006_businessman;

                lbReloadInfo.Text = string.Format("Dữ liệu được cập nhật vào lúc {0}", DateTime.Now);
            }
            catch(Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.ShowDialog();
            }
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {

            if ((MessageBox.Show("Bạn có muốn đóng chương trình này hay không?", "Xác nhận thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                Application.Exit();
            }
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

        private void xuiSuperButton_LoginAndLogout_Click(object sender, EventArgs e)
        {
            if (IsLogin())
            {
                LoginSession.EmployeeId = null;
                LoginSession.Role = null;
                LoginSession.LoginTime = default(DateTime);
                LoadDefaultForm();
                timerUpdateForm.Enabled = true;
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void xuiSuperButton_AdminTool_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void xuiSuperButton_EmployeeTool_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbDefaultOrMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            if (IsLogin())
                UpdateForm();
            else
                LoadDefaultForm();
        }

        private void timerUpdateForm_Tick(object sender, EventArgs e)
        {
            if (IsLogin())
                UpdateForm();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDefaultForm();
        }

        private void xuiSuperButton_AccountInfo_Click(object sender, EventArgs e)
        {
            AccountInfoForm accountInfoForm = new AccountInfoForm(this);
            accountInfoForm.ShowDialog();
        }

        private void lbFooter1_Click(object sender, EventArgs e)
        {
            Process.Start(ConfigurationManager.AppSettings["ProjectDetailURL"]);
        }
    }
}
