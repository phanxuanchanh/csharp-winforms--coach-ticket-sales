using BanVeXeKhach.BUS_DAO.BUS;
using System;
using System.Windows.Forms;

namespace BanVeXeKhach.SubForms
{
    public partial class CoachTripDetailForm : Form
    {
        private CoachTrip coachTrip;

        public CoachTripDetailForm(CoachTrip coachTrip)
        {
            InitializeComponent();
            this.coachTrip = coachTrip;
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

        private void CoachTripDetailForm_Load(object sender, EventArgs e)
        {
            lbID.Text = string.Format("ID: {0}", coachTrip.CoachTripId);
            lbCoachTripName.Text = string.Format("Tên chuyến: {0}", coachTrip.Name);
            lbDepartureDate.Text = string.Format("Thời gian đi: {0}", coachTrip.DepartureDate);
            lbArrivalDate.Text = string.Format("Thời gian đến: {0}", coachTrip.ArrivalDate);
            lbCoachTripStatus.Text = string.Format("TT Chuyến: {0}", coachTrip.Status.Name);
            lbRouteId.Text = string.Format("Mã tuyến: {0}", coachTrip.Route.RouteId);
            lbRouteName.Text = string.Format("Tên tuyến: {0}", coachTrip.Route.Name);
            lbVehicleId.Text = string.Format("Mã xe: {0}", coachTrip.Vehicle.VehicleId);
            lbVehicleName.Text = string.Format("Tên xe: {0}", coachTrip.Vehicle.Name);
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {

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
    }
}
