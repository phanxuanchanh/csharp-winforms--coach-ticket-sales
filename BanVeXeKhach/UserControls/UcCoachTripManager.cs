using BanVeXeKhach.BUS_DAO.BUS;
using BanVeXeKhach.SubForms;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeXeKhach.UserControls
{
    public partial class UcCoachTripManager : UserControl
    {
        private CoachTrip coachTrip;
        private List<CoachTrip> coachTrips;
        private bool isCreating;

        public UcCoachTripManager()
        {
            InitializeComponent();
            coachTrip = new CoachTrip();
        }

        public async Task LoadDefaultUserControl()
        {
            try
            {
                isCreating = false;

                dgvCoachTripList.AutoGenerateColumns = false;
                btnCreate.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnSave.Enabled = false;

                txtCoachTripName.Enabled = false;
                cbRoute.Enabled = false;
                dtpDepartureDate.Enabled = false;
                dtpArrivalDate.Enabled = false;
                cbCoachTripStatus.Enabled = false;
                cbVehicle.Enabled = false;

                txtID.Text = "";
                txtCoachTripName.Text = "";
                dtpDepartureDate.Value = DateTime.Now;
                dtpArrivalDate.Value = DateTime.Now;

                await LoadComboboxes();
                await LoadDataGridView();

            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.ShowDialog();
            }
        }

        public void CloseUserControl()
        {

        }

        public async Task LoadDataGridView()
        {
            coachTrips = await CoachTrip.GetCoachTripsAsync();
            dgvCoachTripList.DataSource = coachTrips;

            lbCoachTripNumber.Text = string.Format("Số chuyến xe hiện có: {0}", dgvCoachTripList.Rows.Count);
        }

        public async Task LoadComboboxes()
        {
            cbRoute.DataSource = await Route.GetRoutesAsync();
            cbRoute.DisplayMember = "Name";
            cbRoute.ValueMember = "RouteId";
            cbRoute.SelectedIndex = 0;

            cbVehicle.DataSource = await Vehicle.GetVehiclesAsync();
            cbVehicle.DisplayMember = "Name";
            cbVehicle.ValueMember = "VehicleId";
            cbVehicle.SelectedIndex = 0;

            cbCoachTripStatus.DataSource = await CoachTripStatus.GetCoachTripStatusListAsync();
            cbCoachTripStatus.DisplayMember = "Name";
            cbCoachTripStatus.ValueMember = "CoachTripStatusId";
            cbCoachTripStatus.SelectedIndex = 0;
        }

        private async void UcCoachTripManager_Load(object sender, EventArgs e)
        {
            await LoadDefaultUserControl();
        }

        public async Task LoadDataGridView(string keyword, bool byCoachTripName = false, bool byDepartureDate = false, bool byArrivalDate = false)
        {
            if (byCoachTripName && !byDepartureDate && !byArrivalDate)
                coachTrips = await CoachTrip.SearchByNameAsync(keyword);
            else if (byDepartureDate && !byCoachTripName && !byArrivalDate)
                coachTrips = await CoachTrip.SearchByDepartureDateAsync(keyword);
            else if (byArrivalDate && !byCoachTripName && !byDepartureDate)
                coachTrips = await CoachTrip.SearchByArrivalDateAsync(keyword);
            else
                throw new Exception("only 1 option");

            lbCoachTripNumber.Text = string.Format("Số chuyến xe theo từ khóa tìm kiếm: {0}", coachTrips.Count);
            dgvCoachTripList.DataSource = coachTrips;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearch.Text;
                if (string.IsNullOrEmpty(keyword))
                {
                    MessageBox.Show("Từ khóa tìm kiếm không được để trống", "Lỗi");
                }
                else
                {
                    if (xuiRadio_SearchByCoachTripName.Checked)
                        await LoadDataGridView(keyword, byCoachTripName: true);
                    else if (xuiRadio_SearchByStartTime.Checked)
                        await LoadDataGridView(keyword, byDepartureDate: true);
                    else
                        await LoadDataGridView (keyword, byArrivalDate: true);
                }
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.ShowDialog();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            isCreating = true;

            txtID.Text = "";
            txtCoachTripName.Text = "";
            dtpDepartureDate.Value = DateTime.Now;
            dtpArrivalDate.Value = DateTime.Now;

            btnCreate.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;

            txtCoachTripName.Enabled = true;
            cbRoute.Enabled = true;
            dtpDepartureDate.Enabled = true;
            dtpArrivalDate.Enabled = true;
            cbCoachTripStatus.Enabled = true;
            cbVehicle.Enabled = true;
        }

        private bool IsValidData(string coachTripName, DateTime departureDate, DateTime arrivalDate)
        {
            if (!Regex.IsMatch(coachTripName, @"^[\p{L}0-9-,\[\]/:. ]+$"))
                return false;

            /*if (!Regex.IsMatch(departureDate, @"^[0-9]{2}\/[0-9]{2}\/[0-9]{4}( - )[0-9]{2}:[0-9]{2}:[0-9]{2}$"))
                return false;

            if (!Regex.IsMatch(arrivalDate, @"^[0-9]{2}\/[0-9]{2}\/[0-9]{4}( - )[0-9]{2}:[0-9]{2}:[0-9]{2}$"))
                return false;*/

            return true;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string coachTripName = txtCoachTripName.Text;
            int routeId = (int)cbRoute.SelectedValue;
            DateTime departureDate = dtpDepartureDate.Value;
            DateTime arrivalDate = dtpArrivalDate.Value;
            int statusId = (int)cbCoachTripStatus.SelectedValue;
            long vehicleId = (long)cbVehicle.SelectedValue;

            if (IsValidData(coachTripName, departureDate, arrivalDate))
            {
                coachTrip.Name = coachTripName;
                coachTrip.DepartureDate = departureDate;
                coachTrip.ArrivalDate = arrivalDate;
                coachTrip.Route = new Route { RouteId = routeId };
                coachTrip.Status = new CoachTripStatus { CoachTripStatusId = statusId };
                coachTrip.Vehicle = new Vehicle { VehicleId = vehicleId };

                bool executionResult = false;

                if (isCreating)
                {
                    if(await CoachTrip.CreateCoachTripAsync(coachTrip))
                    {
                        txtID.Text = coachTrip.CoachTripId.ToString();
                        executionResult = true;
                    }
                }
                else
                {
                    if (await coachTrip.UpdateCoachTripAsync())
                        executionResult = true;
                }

                if (executionResult)
                {
                    await LoadDataGridView();

                    btnCreate.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;

                    txtCoachTripName.Enabled = false;
                    cbRoute.Enabled = false;
                    dtpDepartureDate.Enabled = false;
                    dtpArrivalDate.Enabled = false;
                    cbCoachTripStatus.Enabled = false;
                    cbVehicle.Enabled = false;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            isCreating = false;

            btnCreate.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;

            txtCoachTripName.Enabled = true;
            cbRoute.Enabled = true;
            dtpDepartureDate.Enabled = true;
            dtpArrivalDate.Enabled = true;
            cbCoachTripStatus.Enabled = true;
            cbVehicle.Enabled = true;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                await coachTrip.DeleteCoachTripAsync();
                await LoadDefaultUserControl();
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.ShowDialog();
            }
        }

        private void cbRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRoute.SelectedIndex != -1 && cbCoachTripStatus.SelectedIndex != -1 && cbVehicle.SelectedIndex != -1)
                txtCoachTripName.Text = string.Format("Chuyến [{0}]///[{1}, {2}]",
                    ((Route)cbRoute.SelectedItem).Name, dtpArrivalDate.Value, ((Vehicle)cbVehicle.SelectedItem).Name);
        }

        private void dgvCoachTripList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                coachTrip = (CoachTrip)dgvCoachTripList.Rows[e.RowIndex].DataBoundItem;
                txtID.Text = coachTrip.CoachTripId.ToString();
                txtCoachTripName.Text = coachTrip.Name;
                cbRoute.SelectedIndex = cbRoute.FindStringExact(coachTrip.Route.Name);
                cbCoachTripStatus.SelectedIndex = cbCoachTripStatus.FindStringExact(coachTrip.Status.Name);
                cbVehicle.SelectedIndex = cbVehicle.FindStringExact(coachTrip.Vehicle.Name);
                dtpDepartureDate.Value = coachTrip.DepartureDate;
                dtpArrivalDate.Value = coachTrip.ArrivalDate;

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void cbVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRoute.SelectedIndex != -1 && cbCoachTripStatus.SelectedIndex != -1 && cbVehicle.SelectedIndex != -1)
                txtCoachTripName.Text = string.Format("Chuyến [{0}]///[{1}, {2}]",
                    ((Route)cbRoute.SelectedItem).Name, dtpArrivalDate.Value, ((Vehicle)cbVehicle.SelectedItem).Name);
        }

        private void dgvCoachTripList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                coachTrip = (CoachTrip)dgvCoachTripList.Rows[e.RowIndex].DataBoundItem;
                CoachTripDetailForm coachTripDetailForm = new CoachTripDetailForm(coachTrip);
                coachTripDetailForm.ShowDialog();
            }
        }
    }
}
