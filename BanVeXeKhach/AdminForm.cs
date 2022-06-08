using BanVeXeKhach.UserControls;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;

namespace BanVeXeKhach
{
    public partial class AdminForm : Form
    {
        public AdminForm()
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

        private void AdminForm_Load(object sender, EventArgs e)
        {
            lbReloadInfo.Text = string.Format("Dữ liệu được cập nhật vào lúc {0}", DateTime.Now);
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            ClearUserControl_pnMainWorkArea();
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

        private async void pbRefresh_Click(object sender, EventArgs e)
        {
            if(pnMainWorkArea.Controls.Count > 0)
            {
                Control control = pnMainWorkArea.Controls[0];

                if (control is UcEmployeeManager)
                    await (control as UcEmployeeManager).LoadDefaultUserControl();

                if (control is UcRouteManager)
                    await (control as UcRouteManager).LoadDefaultUserControl();

                if (control is UcCoachTripManager)
                    await (control as UcCoachTripManager).LoadDefaultUserControl();

                if (control is UcVehicleManager)
                    await (control as UcVehicleManager).LoadDefaultUserControl();

                lbReloadInfo.Text = string.Format("Dữ liệu được cập nhật vào lúc {0}", DateTime.Now);
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

        private void ClearUserControl_pnMainWorkArea()
        {
            if (pnMainWorkArea.Controls.Count > 0)
            {
                Control control = pnMainWorkArea.Controls[0];

                if (control is UcEmployeeManager)
                    (control as UcEmployeeManager).CloseUserControl();

                if (control is UcRouteManager)
                    (control as UcRouteManager).CloseUserControl();

                if (control is UcCoachTripManager)
                    (control as UcCoachTripManager).CloseUserControl();

                if (control is UcVehicleManager)
                    (control as UcVehicleManager).CloseUserControl();

                pnMainWorkArea.Controls.Clear();
            }
        }

        private void xuiSuperButton_StaffManager_Click(object sender, EventArgs e)
        {
            ucLabel_Header2_2.SetText("QUẢN LÝ NHÂN VIÊN");
            ucLabel_Header2_2.SetImage(global::BanVeXeKhach.Properties.Resources._003_man);

            ClearUserControl_pnMainWorkArea();
            UcEmployeeManager ucStaffManager = new UcEmployeeManager();
            ucStaffManager.Dock = DockStyle.Fill;
            pnMainWorkArea.Controls.Add(ucStaffManager);

            lbReloadInfo.Text = string.Format("Dữ liệu được cập nhật vào lúc {0}", DateTime.Now);
        }

        private void xuiSuperButton_RouteManager_Click(object sender, EventArgs e)
        {
            ucLabel_Header2_2.SetText("QUẢN LÝ TUYẾN ĐƯỜNG");
            ucLabel_Header2_2.SetImage(global::BanVeXeKhach.Properties.Resources.bus__4_);

            ClearUserControl_pnMainWorkArea();
            UcRouteManager ucRouteManager = new UcRouteManager();
            ucRouteManager.Dock = DockStyle.Fill;
            pnMainWorkArea.Controls.Add(ucRouteManager);

            lbReloadInfo.Text = string.Format("Dữ liệu được cập nhật vào lúc {0}", DateTime.Now);
        }

        private void xuiSuperButton_Export_Click(object sender, EventArgs e)
        {
            ucLabel_Header2_2.SetText("XUẤT BÁO CÁO");
            ucLabel_Header2_2.SetImage(global::BanVeXeKhach.Properties.Resources._003_report_2);

            ClearUserControl_pnMainWorkArea();
            UcReportManager ucReportManager = new UcReportManager();
            ucReportManager.Dock = DockStyle.Fill;
            pnMainWorkArea.Controls.Add(ucReportManager);
            lbReloadInfo.Text = string.Format("Dữ liệu được cập nhật vào lúc {0}", DateTime.Now);
        }

        private void xuiSuperButton_CoachTripManager_Click(object sender, EventArgs e)
        {
            ucLabel_Header2_2.SetText("QUẢN LÝ CHUYẾN XE");
            ucLabel_Header2_2.SetImage(global::BanVeXeKhach.Properties.Resources.bus__4_);

            ClearUserControl_pnMainWorkArea();
            UcCoachTripManager ucCoachTripManager = new UcCoachTripManager();
            ucCoachTripManager.Dock = DockStyle.Fill;
            pnMainWorkArea.Controls.Add(ucCoachTripManager);

            lbReloadInfo.Text = string.Format("Dữ liệu được cập nhật vào lúc {0}", DateTime.Now);
        }

        private void xuiSuperButton_CoachManager_Click(object sender, EventArgs e)
        {
            ucLabel_Header2_2.SetText("QUẢN LÝ XE");
            ucLabel_Header2_2.SetImage(global::BanVeXeKhach.Properties.Resources.bus__3_);

            ClearUserControl_pnMainWorkArea();
            UcVehicleManager ucCoachManager = new UcVehicleManager();
            ucCoachManager.Dock = DockStyle.Fill;
            pnMainWorkArea.Controls.Add(ucCoachManager);

            lbReloadInfo.Text = string.Format("Dữ liệu được cập nhật vào lúc {0}", DateTime.Now);
        }

        private void lbFooter1_Click(object sender, EventArgs e)
        {
            Process.Start(ConfigurationManager.AppSettings["ProjectDetailURL"]);
        }
    }
}
