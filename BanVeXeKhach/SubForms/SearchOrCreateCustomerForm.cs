using BanVeXeKhach.BUS_DAO.BUS;
using BanVeXeKhach.Session;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeXeKhach.SubForms
{
    public partial class SearchOrCreateCustomerForm : Form
    {
        private Customer customer;
        private List<Customer> customers;

        public SearchOrCreateCustomerForm()
        {
            InitializeComponent();
            customer = new Customer();
        }

        private async void SearchOrCreateCustomerForm_Load(object sender, EventArgs e)
        {
            await LoadDefaultForm();
        }

        private async Task LoadDefaultForm()
        {
            try
            {
                dgvCustomerList.AutoGenerateColumns = false;
                btnCreate.Enabled = true;
                btnSave.Enabled = false;
                btnSelectCustomer.Enabled = false;

                txtCustomerName.Enabled = false;
                txtCustomerPhone.Enabled = false;
                txtCustomerEmail.Enabled = false;
                dtpCustomerBirthday.Enabled = false;
                txtCustomerAddress.Enabled = false;

                txtID.Text = "";
                txtCustomerName.Text = "";
                txtCustomerPhone.Text = "";
                txtCustomerEmail.Text = "";
                dtpCustomerBirthday.Value = DateTime.Now;
                txtCustomerAddress.Text = "";

                await LoadDataGridView();
                LoadCombobox();
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.ShowDialog();
            }
        }

        public async Task LoadDataGridView()
        {
            customers = await Customer.GetCustomersAsync();
            dgvCustomerList.DataSource = customers;
        }

        public void LoadCombobox()
        {
            cbSearchSelection.Items.Clear();
            cbSearchSelection.Items.AddRange(new object[]
            {
                new KeyValuePair<string, string>("SearchByFullName", "Tìm kiếm theo tên"),
                new KeyValuePair<string, string>("SearchByPhone", "Tìm kiếm theo SĐT"),
                new KeyValuePair<string, string>("SearchByEmail", "Tìm kiếm theo Email")
            });

            cbSearchSelection.ValueMember = "Key";
            cbSearchSelection.DisplayMember = "Value";
            cbSearchSelection.SelectedIndex = 0;
        }

        private bool IsValidData(
            string customerName, string customerPhone, string customerEmail, 
            DateTime customerBirthday, string customerAddress
        )
        {
            if (!Regex.IsMatch(customerName, @"^[\p{L} ]+$"))
                return false;

            if (!Regex.IsMatch(customerPhone, @"^[0-9]{6,10}$"))
                return false;

            if (!Regex.IsMatch(customerEmail, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                return false;

            return true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtCustomerName.Text = "";
            txtCustomerPhone.Text = "";
            txtCustomerEmail.Text = "";
            dtpCustomerBirthday.Value = DateTime.Now;
            txtCustomerAddress.Text = "";

            btnCreate.Enabled = false;
            btnSave.Enabled = true;
            btnSelectCustomer.Enabled = false;

            txtCustomerName.Enabled = true;
            txtCustomerPhone.Enabled = true;
            txtCustomerEmail.Enabled = true;
            dtpCustomerBirthday.Enabled = true;
            txtCustomerAddress.Enabled = true;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string customerPhone = txtCustomerPhone.Text;
            string customerEmail = txtCustomerEmail.Text;
            DateTime customerBirthday = dtpCustomerBirthday.Value;
            string customerAddress = txtCustomerAddress.Text;

            if(IsValidData(customerName, customerPhone, customerEmail, customerBirthday, customerAddress))
            {
                customer.FullName = customerName;
                customer.Phone = customerPhone;
                customer.Email = customerEmail;
                customer.Birthday = customerBirthday;
                customer.Address = customerAddress;

                if(await Customer.CreateCutomerAsync(customer))
                {
                    await LoadDataGridView();

                    btnCreate.Enabled = true;
                    btnSave.Enabled = false;
                    btnSelectCustomer.Enabled = true;

                    txtID.Text = customer.CustomerId.ToString();

                    txtCustomerName.Enabled = false;
                    txtCustomerPhone.Enabled = false;
                    txtCustomerEmail.Enabled = false;
                    dtpCustomerBirthday.Enabled = false;
                    txtCustomerAddress.Enabled = false;
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
                    if (((KeyValuePair<string, string>)cbSearchSelection.SelectedItem).Key == "SearchByFullName")
                        LoadDataGridView(keyword, byFullName: true);
                    else if (((KeyValuePair<string, string>)cbSearchSelection.SelectedItem).Key == "SearchByPhone")
                        LoadDataGridView(keyword, byPhone: true);
                    else
                        LoadDataGridView(keyword, byEmail: true);
                }
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.ShowDialog();
            }
        }

        public async void LoadDataGridView(string keyword, bool byFullName = false, bool byPhone = false, bool byEmail = false)
        {
            if (byFullName && !byPhone && !byEmail)
                customers = await Customer.SearchByFullNameAsync(keyword);
            else if (byPhone && !byFullName && !byEmail)
                customers = await Customer.SearchByPhoneAsync(keyword);
            else if (byEmail && !byFullName && !byPhone)
                customers = await Customer.SearchByEmailAsync(keyword);
            else
                throw new Exception("only 1 option");

            dgvCustomerList.DataSource = customers;
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

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void pbRefresh_Click(object sender, EventArgs e)
        {
            await LoadDefaultForm();
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            CustomerSession.SellTicket_SelectedCustomer = customer;
            this.Close();
        }

        private async void dgvCustomerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                customer = await Customer.GetCustomerAsync((long)dgvCustomerList["ID", e.RowIndex].Value);
                txtID.Text = customer.CustomerId.ToString();
                txtCustomerName.Text = customer.FullName;
                txtCustomerPhone.Text = customer.Phone;
                txtCustomerEmail.Text = customer.Email;
                dtpCustomerBirthday.Value = customer.Birthday;
                txtCustomerAddress.Text = customer.Address;

                btnSelectCustomer.Enabled = true;
            }
        }
    }
}
