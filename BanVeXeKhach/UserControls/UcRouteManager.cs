using BanVeXeKhach.BUS_DAO.BUS;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeXeKhach.UserControls
{
    public partial class UcRouteManager : UserControl
    {
        private Route route;
        private List<Route> routes;
        private bool isCreating;

        public UcRouteManager()
        {
            InitializeComponent();
            route = new Route();
        }

        private async void UcRouteManager_Load(object sender, EventArgs e)
        {
            await LoadDefaultUserControl();
        }

        public async Task LoadDefaultUserControl()
        {
            try
            {
                isCreating = false;

                dgvRouteList.AutoGenerateColumns = false;
                btnCreate.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnSave.Enabled = false;

                txtRouteOrigin.Enabled = false;
                txtRouteDestination.Enabled = false;
                txtPrice.Enabled = false;

                txtID.Text = "";
                txtRouteName.Text = "";
                txtRouteOrigin.Text = "";
                txtRouteDestination.Text = "";
                txtPrice.Text = "";

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
            routes = await Route.GetRoutesAsync();
            dgvRouteList.DataSource = routes;

            lbRouteNumber.Text = string.Format("Số tuyến đường hiện có: {0}", dgvRouteList.Rows.Count);
        }

        public async Task LoadDataGridView(string keyword, bool byRouteName = false, bool byRouteOrigin = false, bool byRouteDestination = false)
        {
            if (byRouteName && !byRouteOrigin && !byRouteDestination)
                routes = await Route.SearchByNameAsync(keyword);
            else if (byRouteOrigin && !byRouteName && !byRouteDestination)
                routes = await Route.SearchByRouteOriginAsync(keyword);
            else if (byRouteDestination && !byRouteName && !byRouteOrigin)
                routes = await Route.SearchByRouteDestinationAsync(keyword);
            else
                throw new Exception("only 1 option");

            lbRouteNumber.Text = string
                    .Format("Số tuyến đường theo từ khóa tìm kiếm: {0}", routes.Count);
            dgvRouteList.DataSource = routes;
        }

        public void CloseUserControl()
        {

        }

        private bool IsValidData(string routeOrigin, string routeDestination, string price)
        {
            if (!Regex.IsMatch(routeOrigin, @"^[\p{L},0-9 ]+$"))
                return false;

            if (!Regex.IsMatch(routeDestination, @"^[\p{L},0-9 ]+$"))
                return false;

            if (!Regex.IsMatch(price, "^[0-9.]{4,}$"))
                return false;

            return true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            isCreating = true;

            txtID.Text = "";
            txtRouteName.Text = "";
            txtRouteOrigin.Text = "";
            txtRouteDestination.Text = "";
            txtPrice.Text = "";

            btnCreate.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;

            txtRouteOrigin.Enabled = true;
            txtRouteDestination.Enabled = true;
            txtPrice.Enabled = true;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string routeName = txtRouteName.Text;
            string routeOrigin = txtRouteOrigin.Text;
            string routeDestination = txtRouteDestination.Text;
            string strPrice = txtPrice.Text;

            if (IsValidData(routeOrigin, routeDestination, strPrice))
            {
                route.Name = routeName;
                route.Origin = routeOrigin;
                route.Destination = routeDestination;
                route.Price = double.Parse(strPrice);

                bool executionResult = false;

                if (isCreating)
                {
                    if(await Route.CreateRouteAsync(route))
                    {
                        txtID.Text = route.RouteId.ToString();
                        executionResult = true;
                    }
                }
                else
                {
                    if (await route.UpdateRouteAsync())
                        executionResult = true;
                }

                if (executionResult)
                {
                    await LoadDataGridView();

                    btnCreate.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;

                    txtRouteOrigin.Enabled = false;
                    txtRouteDestination.Enabled = false;
                    txtPrice.Enabled = false;
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

            txtRouteOrigin.Enabled = true;
            txtRouteDestination.Enabled = true;
            txtPrice.Enabled = true;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                await route.DeleteRouteAsync();
                await LoadDefaultUserControl();
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.ShowDialog();
            }
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
                    if (xuiRadio_SearchByRouteName.Checked)
                        await LoadDataGridView(keyword, byRouteName: true);
                    else if (xuiRadio_SearchByRouteOrigin.Checked)
                        await LoadDataGridView(keyword, byRouteOrigin: true);
                    else
                        await LoadDataGridView(keyword, byRouteDestination: true);
                }
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.ShowDialog();
            }
        }

        private void dgvRouteList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                route = (Route)dgvRouteList.Rows[e.RowIndex].DataBoundItem;
                txtID.Text = route.RouteId.ToString();
                txtRouteName.Text = route.Name;
                txtRouteOrigin.Text = route.Origin;
                txtRouteDestination.Text = route.Destination;
                txtPrice.Text = route.Price.ToString();

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void txtRouteDestination_TextChanged(object sender, EventArgs e)
        {
            txtRouteName.Text = string.Format("{0} - {1}", txtRouteOrigin.Text, txtRouteDestination.Text);
        }

        private void txtRouteOrigin_TextChanged(object sender, EventArgs e)
        {
            txtRouteName.Text = string.Format("{0} - {1}", txtRouteOrigin.Text, txtRouteDestination.Text);
        }
    }
}
