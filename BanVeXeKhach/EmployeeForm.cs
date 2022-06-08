using BanVeXeKhach.UserControls;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;

namespace BanVeXeKhach
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
            InitializeSecondaryComponent();
        }

        private void InitializeSecondaryComponent()
        {
            ucLabel_Header2.SetText("CÁC CHỨC NĂNG");
            ucLabel_Header2.SetImage(global::BanVeXeKhach.Properties.Resources.businessapplication_edit_male_user_thepencil_theclient_negocio_2321);
            ucLabel_Header2_2.SetText("CHƯA CHỌN CHỨC NĂNG CỤ THỂ");
            ucLabel_Header2_2.SetImage(global::BanVeXeKhach.Properties.Resources.bus__3_);
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            ClearUserControl_pnMainWorkArea();
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
            if (pnMainWorkArea.Controls.Count > 0)
            {
                Control control = pnMainWorkArea.Controls[0];

                if (control is UcTicketSales)
                    await (control as UcTicketSales).LoadDefaultUserControl();

                if (control is UcTicketCancellation)
                    await (control as UcTicketCancellation).LoadDefaultUserControl();

                lbReloadInfo.Text = string.Format("Dữ liệu được cập nhật vào lúc {0}", DateTime.Now);
            }
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

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            lbReloadInfo.Text = string.Format("Dữ liệu được cập nhật vào lúc {0}", DateTime.Now);
        }

        private void ClearUserControl_pnMainWorkArea()
        {
            if (pnMainWorkArea.Controls.Count > 0)
            {
                Control control = pnMainWorkArea.Controls[0];

                if (control is UcTicketSales)
                    (control as UcTicketSales).CloseUserControl();

                if (control is UcTicketCancellation)
                    (control as UcTicketCancellation).CloseUserControl();

                pnMainWorkArea.Controls.Clear();
            }
        }

        private void xuiSuperButton_TicketSales_Click(object sender, EventArgs e)
        {
            ucLabel_Header2_2.SetText("BÁN VÉ");
            ucLabel_Header2_2.SetImage(global::BanVeXeKhach.Properties.Resources._001_bus_ticket);

            ClearUserControl_pnMainWorkArea();
            UcTicketSales ucTicketSales = new UcTicketSales();
            ucTicketSales.Dock = DockStyle.Fill;
            pnMainWorkArea.Controls.Add(ucTicketSales);

            lbReloadInfo.Text = string.Format("Dữ liệu được cập nhật vào lúc {0}", DateTime.Now);
        }

        private void xuiSuperButton_Invoice_Click(object sender, EventArgs e)
        {
            ucLabel_Header2_2.SetText("HÓA ĐƠN BÁN VÉ");
            ucLabel_Header2_2.SetImage(global::BanVeXeKhach.Properties.Resources._030_budget);

            ClearUserControl_pnMainWorkArea();
            UcInvoice ucInvoice = new UcInvoice();
            ucInvoice.Dock = DockStyle.Fill;
            pnMainWorkArea.Controls.Add(ucInvoice);

            lbReloadInfo.Text = string.Format("Dữ liệu được cập nhật vào lúc {0}", DateTime.Now);
        }

        private void timerUpdateForm_Tick(object sender, EventArgs e)
        {
            if (pnMainWorkArea.Controls.Count > 0)
            {
                Control control = pnMainWorkArea.Controls[0];

                if (control is UcTicketSales)
                    (control as UcTicketSales).UpdateUserControl();
            }
        }

        private void xuiSuperButton_TicketCancellation_Click(object sender, EventArgs e)
        {
            ucLabel_Header2_2.SetText("HỦY VÉ");
            ucLabel_Header2_2.SetImage(global::BanVeXeKhach.Properties.Resources._001_bus_ticket);

            ClearUserControl_pnMainWorkArea();
            UcTicketCancellation ucTicketCancellation = new UcTicketCancellation();
            ucTicketCancellation.Dock = DockStyle.Fill;
            pnMainWorkArea.Controls.Add(ucTicketCancellation);

            lbReloadInfo.Text = string.Format("Dữ liệu được cập nhật vào lúc {0}", DateTime.Now);
        }

        private void lbFooter1_Click(object sender, EventArgs e)
        {
            Process.Start(ConfigurationManager.AppSettings["ProjectDetailURL"]);
        }
    }
}
