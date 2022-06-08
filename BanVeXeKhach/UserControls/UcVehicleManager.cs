using BanVeXeKhach.BUS_DAO.BUS;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeXeKhach.UserControls
{
    public partial class UcVehicleManager : UserControl
    {
        private Vehicle vehicle;
        private List<Vehicle> vehicles;
        private bool isCreating;

        public UcVehicleManager()
        {
            InitializeComponent();
            vehicle = new Vehicle();
            
        }

        private async void UcVehicleManager_Load(object sender, EventArgs e)
        {
            await LoadDefaultUserControl();
        }

        public async Task LoadDefaultUserControl()
        {
            try
            {
                isCreating = false;

                dgvVehicleList.AutoGenerateColumns = false;
                btnCreate.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnSave.Enabled = false;

                txtVehicleName.Enabled = false;
                txtVehicleDescription.Enabled = false;
                txtSeatNumber.Enabled = false;
                txtLicensePlate.Enabled = false;

                txtID.Text = "";
                txtVehicleName.Text = "";
                txtVehicleDescription.Text = "";
                txtSeatNumber.Text = "";
                txtLicensePlate.Text = "";

                await LoadDataGridView(); 
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.ShowDialog();
            }
        }

        public async Task LoadDataGridView()
        {
            vehicles = await Vehicle.GetVehiclesAsync();
            dgvVehicleList.DataSource = vehicles;

            lbVehicleNumber.Text = string.Format("Số xe hiện có: {0}", dgvVehicleList.Rows.Count);
        }

        public async Task LoadDataGridView(string keyword, bool byVehicleName = false, bool bySeatNumber = false, bool byLicensePlate = false)
        {
            if (byVehicleName && !bySeatNumber && !byLicensePlate)
                vehicles = await Vehicle.SearchByNameAsync(keyword);
            else if (bySeatNumber && !byVehicleName && !byLicensePlate)
                vehicles = await Vehicle.SearchBySeatNumberAsync(int.Parse(keyword));
            else if (byLicensePlate && !byVehicleName && !bySeatNumber)
                vehicles = await Vehicle.SearchByLicensePlateAsync(keyword);
            else
                throw new Exception("only 1 option");

            lbVehicleNumber.Text = string.Format("Số xe theo từ khóa tìm kiếm: {0}", vehicles.Count);
            dgvVehicleList.DataSource = vehicles;
        }

        public void CloseUserControl()
        {
            
        }

        private bool IsValidData(string vehicleName, string seatNumber, string licensePlate)
        {
            if (!Regex.IsMatch(vehicleName, @"^[\p{L}-,0-9. ]+$"))
                return false;

            if (!Regex.IsMatch(seatNumber, @"^[0-9]{1,2}$"))
                return false;

            if (!Regex.IsMatch(licensePlate, "^[A-Za-z0-9]{1,3}-[0-9]{1,3}[.][0-9]{1,2}$"))
                return false;

            return true;
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
                    if (xuiRadio_SearchByVehicleName.Checked)
                        await LoadDataGridView(keyword, byVehicleName: true);
                    else if (xuiRadio_SearchBySeatNumber.Checked)
                        await LoadDataGridView(keyword, bySeatNumber: true);
                    else
                        await LoadDataGridView(keyword, byLicensePlate: true);
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
            txtVehicleName.Text = "";
            txtVehicleDescription.Text = "";
            txtSeatNumber.Text = "";
            txtLicensePlate.Text = "";

            btnCreate.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;

            txtVehicleName.Enabled = true;
            txtVehicleDescription.Enabled = true;
            txtSeatNumber.Enabled = true;
            txtLicensePlate.Enabled = true;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string vehicleName = txtVehicleName.Text;
            string vehicleDescription = txtVehicleDescription.Text;
            string strSeatNumber = txtSeatNumber.Text;
            string licensePlate = txtLicensePlate.Text;

            if (IsValidData(vehicleName, strSeatNumber, licensePlate))
            {
                vehicle.Name = vehicleName;
                vehicle.Description = vehicleDescription;
                vehicle.SeatNumber = int.Parse(strSeatNumber);
                vehicle.LicensePlate = licensePlate;

                bool executionResult = false;

                if (isCreating)
                {
                    if (await Vehicle.CreateVehicleAsync(vehicle))
                    {
                        txtID.Text = vehicle.VehicleId.ToString();
                        executionResult = true;
                    }
                }
                else
                {
                    if(await vehicle.UpdateVehicleAsync())
                        executionResult = true;
                }

                if (executionResult)
                {
                    await LoadDataGridView ();

                    btnCreate.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;

                    txtVehicleName.Enabled = false;
                    txtVehicleDescription.Enabled = false;
                    txtSeatNumber.Enabled = false;
                    txtLicensePlate.Enabled = false;
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

            txtVehicleName.Enabled = true;
            txtVehicleDescription.Enabled = true;
            txtSeatNumber.Enabled = true;
            txtLicensePlate.Enabled = true;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                await vehicle.DeleteVehicleAsync();
                await LoadDefaultUserControl();
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.ShowDialog();
            }
        }

        private void dgvVehicleList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                vehicle = (Vehicle)dgvVehicleList.Rows[e.RowIndex].DataBoundItem;
                txtID.Text = vehicle.VehicleId.ToString();
                txtVehicleName.Text = vehicle.Name;
                txtVehicleDescription.Text = vehicle.Description;
                txtSeatNumber.Text = vehicle.SeatNumber.ToString();
                txtLicensePlate.Text = vehicle.LicensePlate;

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
    }
}
