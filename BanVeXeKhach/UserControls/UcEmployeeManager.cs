using BanVeXeKhach.BUS_DAO.BUS;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeXeKhach.UserControls
{
    public partial class UcEmployeeManager : UserControl
    {
        private Employee employee;
        private List<Employee> employees;

        public UcEmployeeManager()
        {
            InitializeComponent();
            employee = new Employee();
        }

        private async void UcEmployeeManager_Load(object sender, EventArgs e)
        {
            await LoadDefaultUserControl();
        }

        public async Task LoadDefaultUserControl()
        {
            try
            {
                dgvEmployeeList.AutoGenerateColumns = false;
                btnCreate.Enabled = true;
                btnDelete.Enabled = false;
                btnSave.Enabled = false;

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
            employees = await Employee.GetEmployeesAsync();
            dgvEmployeeList.DataSource = employees;

            lbEmployeeNumber.Text = string.Format("Số nhân viên hiện có: {0}", dgvEmployeeList.Rows.Count);
        }

        public async void LoadDataGridView(string keyword, bool byFullName = false, bool byEmail = false, bool byPhone = false)
        {
            if (byFullName && !byEmail && !byPhone)
                employees = await Employee.SearchByFullNameAsync(keyword);
            else if (byEmail && !byFullName && !byPhone)
                employees = await Employee.SearchByEmailAsync(keyword);
            else if (byPhone && !byFullName && !byEmail)
                employees = await Employee.SearchByPhoneAsync(keyword);
            else
                throw new Exception("only 1 option");

            lbEmployeeNumber.Text = string.Format("Số nhân viên theo từ khóa tìm kiếm: {0}", employees.Count);
            dgvEmployeeList.DataSource = employees;
        }

        public void CloseUserControl()
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                    if (xuiRadio_SearchByFullName.Checked)
                        LoadDataGridView(keyword, byFullName: true);
                    else if (xuiRadio_SearchByEmail.Checked)
                        LoadDataGridView(keyword, byEmail: true);
                    else
                        LoadDataGridView(keyword, byPhone: true);
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
            btnCreate.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployeeList.SelectedCells.Count > 0)
                {
                    //int index = dgvEmployeeList.SelectedCells[0].RowIndex;
                    //string tenNguoiDung = dgvEmployeeList.Rows[index].Cells["tenNguoiDung"].Value.ToString();
                    //DataRow deleteRow = staffList.Rows.Find(tenNguoiDung);
                    //if (deleteRow != null)
                    //{
                    //    deleteRow.Delete();
                    //}
                }
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.ShowDialog();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnCreate.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnUpdateToDB_Click(object sender, EventArgs e)
        {
            try
            {
               

                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.ShowDialog();
            }
        }

        private void dgvStaffList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
        }
    }
}
