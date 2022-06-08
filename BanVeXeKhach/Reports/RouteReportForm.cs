using BanVeXeKhach.BUS_DAO.BUS;
using BanVeXeKhach.Session;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeXeKhach.Reports
{
    public partial class RouteReportForm : Form
    {
        public RouteReportForm()
        {
            InitializeComponent();
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

        private async void pbRefresh_Click(object sender, EventArgs e)
        {
            await LoadReport();
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

        private async void RouteReportForm_Load(object sender, EventArgs e)
        {
            await LoadReport();
        }

        private async Task LoadReport()
        {
            try
            {
                routeReport.SetDataSource(await Route.GetRoutesAsync());
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.ShowDialog();
            }
        }
    }
}
