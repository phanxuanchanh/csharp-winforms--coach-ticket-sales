using BanVeXeKhach.BUS_DAO.BUS;
using BanVeXeKhach.Session;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeXeKhach
{
    public partial class LoginForm : Form
    {
        private Employee employee;

        public LoginForm()
        {
            InitializeComponent();
            employee = new Employee();
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

        private bool IsValidData(string employeeId, string password)
        {
            if (!Regex.IsMatch(employeeId, "^[A-Za-z0-9]{6,}$"))
                return false;

            if (string.IsNullOrEmpty(password))
                return false;

            return true;
        }

        private async Task LogIn()
        {
            try
            {
                employee.EmployeeId = txtEmployeeId.Text;
                employee.Password = txtPassword.Text;

                if (IsValidData(employee.EmployeeId, employee.Password))
                {
                    if (await employee.LogInAsync())
                    {
                        LoginSession.EmployeeId = employee.EmployeeId;
                        LoginSession.EmployeeName = employee.FullName;
                        LoginSession.Role = employee.Title;
                        LoginSession.LoginTime = DateTime.Now;
                        MessageBox.Show("Đăng nhập thành công!", "Thành công");

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập không thành công!", "Lỗi");
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu đầu vào không hợp lệ!", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.ShowDialog();
            }
        }

        private async void xuiSuperButton_Login_Click(object sender, EventArgs e)
        {
            await LogIn();
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
                await LogIn();
        }
    }
}
