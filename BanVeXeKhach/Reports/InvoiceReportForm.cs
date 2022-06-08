using BanVeXeKhach.BUS_DAO.BUS;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeXeKhach.Reports
{
    public partial class InvoiceReportForm : Form
    {
        public InvoiceReportForm()
        {
            InitializeComponent();
        }

        private void InvoiceReportForm_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                LoadReport();
            });
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbDefaultOrMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                LoadReport();
            });
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

        public void LoadReport()
        {
            try
            {
                invoiceReport.SetDataSource(Invoice.GetVW_Invoice());
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.ShowDialog();
            }
        }
    }
}
