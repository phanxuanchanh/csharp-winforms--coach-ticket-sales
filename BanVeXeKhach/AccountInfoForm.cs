using BanVeXeKhach.BUS_DAO.BUS;
using BanVeXeKhach.Session;
using System;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeXeKhach
{
    public partial class AccountInfoForm : Form
    {
        private Employee employee;
        private string avatarFolderPath;
        private MainForm mainForm;

        public AccountInfoForm(MainForm mainForm)
        {
            InitializeComponent();
            employee = new Employee();
            avatarFolderPath = string.Format(@"{0}\Avatars", Path.GetDirectoryName(Application.ExecutablePath));

            this.mainForm = mainForm;
        }

        private bool IsAvatarExists()
        {
            if (string.IsNullOrEmpty(employee.Avatar))
                return false;

            return true;
        }

        private async void AccountInfoForm_Load(object sender, EventArgs e)
        {
            await RefreshForm();
        }

        public async Task RefreshForm()
        {
            try
            {
                employee = await Employee.GetEmployeeAsync(LoginSession.EmployeeId);
                txtEmail.Text = employee.Email;
                txtPhone.Text = employee.Phone;
                dtpBirthday.Value = employee.Birthday;
                txtAddress.Text = employee.Address;

                if (IsAvatarExists())
                    pbAvatar.Image = System.Drawing
                        .Image.FromFile(string.Format(@"{0}\{1}", avatarFolderPath, employee.Avatar));
                else
                    pbAvatar.Image = global::BanVeXeKhach.Properties.Resources._006_businessman;
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.Show();
            }
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private async Task DeleteAvatarIfExists()
        {
            try
            {
                if (IsAvatarExists())
                {
                    string oldAvatar = employee.Avatar;
                    employee.Avatar = "";
                    await employee.UpdateAvatarAsync();

                    mainForm.UpdateAvatar("");

                    await Task.Run(() =>
                    {
                        pbAvatar.Image.Dispose();
                        File.Delete(string.Format(@"{0}\{1}", avatarFolderPath, oldAvatar));
                    });
                }
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.Show();
            }
        }

        private async void xuiSuperButton_ChangeImage_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    await DeleteAvatarIfExists();
                    using (Bitmap bitmap = new Bitmap(openFileDialog.FileName))
                    {
                        string path = Path.GetDirectoryName(Application.ExecutablePath);
                        string avatarFolderPath = string.Format(@"{0}\Avatars", path);
                        if (!Directory.Exists(avatarFolderPath))
                        {
                            Directory.CreateDirectory(avatarFolderPath);
                        }
                        string fileName = string.Format("avartar_{0}.bmp", DateTime.Now.ToString("ddMMyyyy_HHmmss"));
                        string fullPath = string.Format(@"{0}\{1}", avatarFolderPath, fileName);

                        employee.Avatar = fileName;
                        await employee.UpdateAvatarAsync();
                        bitmap.Save(fullPath);

                        mainForm.UpdateAvatar(fileName);
                    }
                    await RefreshForm();
                }
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.Show();
            }
        }

        private async void xuiSuperButton_DefaultImage_Click(object sender, EventArgs e)
        {
            await DeleteAvatarIfExists();
            await RefreshForm();
        }

        private async void pbRefresh_Click(object sender, EventArgs e)
        {
            await RefreshForm();
        }

        private async void xuiSuperButton_UpdateAccountInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string employeePhone = txtPhone.Text;
                string employeeEmail = txtEmail.Text;
                DateTime employeeBirthday = dtpBirthday.Value;
                string employeeAddress = txtAddress.Text;

                if (IsValidData(employee.FullName, employeePhone, employeeEmail, employeeBirthday, employeeAddress))
                {
                    employee.Phone = employeePhone;
                    employee.Email = employeeEmail;
                    employee.Birthday = employeeBirthday;
                    employee.Address = employeeAddress;

                    if (await employee.UpdateEmployeeAsync())
                    {
                        MessageBox.Show("Đã cập thông tin tài khoản thành công!", "Thông báo");
                    }
                    else
                    {
                        string message = string.Format(
                            "{0}\n{1}",
                            "Dữ liệu chưa được cập nhật vào hệ thống!.",
                            "Nguyên nhân gây ra vấn đề này có thể là do bạn đã nhập dữ liệu bị trùng với các dữ liệu hiện có."
                        );
                        MessageBox.Show(message, "Lỗi");
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
                errorForm.Show();
            }
        }

        private void lbFooter1_Click(object sender, EventArgs e)
        {
            Process.Start(ConfigurationManager.AppSettings["ProjectDetailURL"]);
        }

        private bool IsValidData(
            string employeeName, string employeePhone, string employeeEmail,
            DateTime employeeBirthday, string employeeAddress
        )
        {
            if (!Regex.IsMatch(employeeName, @"^[\p{L}0-9 ]+$"))
                return false;

            if (!Regex.IsMatch(employeePhone, @"^[0-9]{6,10}$"))
                return false;

            if (!Regex.IsMatch(employeeEmail, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                return false;

            return true;
        }
    }
}
