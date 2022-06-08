using BanVeXeKhach.Session;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;

namespace BanVeXeKhach
{
    public partial class ErrorForm : Form
    {
        private Exception exception;
        public ErrorForm(Exception exception)
        {
            InitializeComponent();
            this.exception = exception;
        }

        private bool IsLogin()
        {
            if (string.IsNullOrEmpty(LoginSession.EmployeeId))
                return false;
            return true;
        }

        private bool IsAdmin()
        {
            return (LoginSession.Role == "Employer");
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {
            rtxtMessage.Text = exception.Message;
            if (IsLogin())
            {
                if (IsAdmin())
                    rtxtStackTrace.Text = exception.StackTrace;
                else
                    rtxtStackTrace.Text = "Stack trace chỉ hiện khi bạn là quản trị viên";
            }
            else
            {
                rtxtStackTrace.Text = "Stack trace chỉ hiện khi bạn là quản trị viên";
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

        private void lbFooter1_Click(object sender, EventArgs e)
        {
            Process.Start(ConfigurationManager.AppSettings["ProjectDetailURL"]);
        }
    }
}
