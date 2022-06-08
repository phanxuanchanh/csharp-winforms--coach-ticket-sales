using BanVeXeKhach.BUS_DAO.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeXeKhach.UserControls
{
    public partial class UcTicketCancellation : UserControl
    {
        private Invoice invoice;
        private InvoiceDetail invoiceDetail;
        private List<Customer> customers;
        private List<InvoiceDetail> invoiceDetails;
        private double oldTotalMoney;

        public UcTicketCancellation()
        {
            InitializeComponent();
            invoice = new Invoice();
            invoiceDetail = new InvoiceDetail();
        }

        private async void UcTicketCancellation_Load(object sender, EventArgs e)
        {
            await LoadDefaultUserControl();
        }

        public void CloseUserControl()
        {

        }

        public async Task LoadDefaultUserControl()
        {
            try
            {
                dgvCustomerList.AutoGenerateColumns = false;
                dgvInvoiceList.AutoGenerateColumns = false;
                dgvInvoiceDetailList.AutoGenerateColumns = false;

                btnCancelTicket.Enabled = false;
                btnUpdateInvoice.Enabled = false;

                dgvInvoiceList.DataSource = null;
                dgvInvoiceDetailList.DataSource = null;

                txtCoachTripName.Text = "";
                txtSeatPosition.Text = "";
                txtPrice.Text = "";
                txtSurcharge.Text = "";
                txtNote.Text = "";

                lbOldTotalMoney.Text = "Số tiền cũ: ...";
                lbNewTotalMoney.Text = "Số tiền mới: ...";
                lbRefundAmount.Text = "Số tiền cần hoàn trả: ...";

                await LoadCustomerDataGridView();
                LoadCombobox();
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.ShowDialog();
            }
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

        public async Task LoadCustomerDataGridView()
        {
            customers = await Customer.GetCustomersAsync();
            dgvCustomerList.DataSource = customers;
        }

        public async Task LoadCustomerDataGridView(string keyword, bool byFullName = false, bool byPhone = false, bool byEmail = false)
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
                    if (((KeyValuePair<string, string>)cbSearchSelection.SelectedItem).Key == "SearchByFullName")
                        await LoadCustomerDataGridView(keyword, byFullName: true);
                    else if (((KeyValuePair<string, string>)cbSearchSelection.SelectedItem).Key == "SearchByPhone")
                        await LoadCustomerDataGridView(keyword, byPhone: true);
                    else
                        await LoadCustomerDataGridView(keyword, byEmail: true);
                }
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.ShowDialog();
            }
        }

        private async void dgvCustomerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                List<Invoice> invoices = await Invoice
                    .GetInvoicesByCustomerIdAsync((long)dgvCustomerList["ID", e.RowIndex].Value);
                dgvInvoiceList.DataSource = invoices;

                txtCoachTripName.Text = "";
                txtSeatPosition.Text = "";
                txtPrice.Text = "";
                txtSurcharge.Text = "";
                txtNote.Text = "";

                lbOldTotalMoney.Text = "Số tiền cũ: ...";
                lbNewTotalMoney.Text = "Số tiền mới: ...";
                lbRefundAmount.Text = "Số tiền cần hoàn trả: ...";
            }
        }

        private async void dgvInvoiceList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                invoice = (Invoice)dgvInvoiceList.Rows[e.RowIndex].DataBoundItem;
                invoiceDetails = await InvoiceDetail.GetInvoiceDetailsAsync(invoice.InvoiceId);
                dgvInvoiceDetailList.DataSource = invoiceDetails;

                txtCoachTripName.Text = "";
                txtSeatPosition.Text = "";
                txtPrice.Text = "";
                txtSurcharge.Text = "";
                txtNote.Text = "";

                lbOldTotalMoney.Text = "Số tiền cũ: ...";
                lbNewTotalMoney.Text = "Số tiền mới: ...";
                lbRefundAmount.Text = "Số tiền cần hoàn trả: ...";
            }
        }

        private void dgvInvoiceDetailList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                invoiceDetail = (InvoiceDetail)dgvInvoiceDetailList.Rows[e.RowIndex].DataBoundItem;
                txtCoachTripName.Text = invoiceDetail.CoachTrip.Name;
                txtSeatPosition.Text = invoiceDetail.SeatPosition.ToString();
                txtPrice.Text = invoiceDetail.Price.ToString();
                txtSurcharge.Text = invoiceDetail.Surcharge.ToString();
                txtNote.Text = invoiceDetail.Note;

                if (invoiceDetail.Status == "Cancelled")
                    btnCancelTicket.Enabled = false;
                else
                    btnCancelTicket.Enabled = true;
            }
        }

        private async void btnCancelTicket_Click(object sender, EventArgs e)
        {
            invoiceDetail.Status = "Cancelled";
            if (await invoiceDetail.UpdateInvoiceDetailAsync())
            {
                btnCancelTicket.Enabled = false;
                btnUpdateInvoice.Enabled = true;

                dgvInvoiceList.Refresh();

                MessageBox.Show("Đã hủy đặt trạng thái hủy cho vé này!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình cập nhật trạng thái hủy vào hệ thống!", "Lỗi");
            }
        }

        private async void btnUpdateInvoice_Click(object sender, EventArgs e)
        {
            oldTotalMoney = invoice.TotalMoney;
            invoice.TotalMoney = 0;

            foreach(InvoiceDetail invoiceDetail in invoiceDetails.Where(id => id.Status == "Completed").ToList())
            {
                invoice.TotalMoney += invoiceDetail.IntoMoney;
            }

            if(await invoice.UpdateInvoiceAsync())
            {
                btnUpdateInvoice.Enabled = false;

                lbOldTotalMoney.Text = string.Format("Số tiền cũ: {0}", oldTotalMoney.ToString("#,##0.00 VNĐ"));
                lbNewTotalMoney.Text = string.Format("Số tiền mới: {0}", invoice.TotalMoney.ToString("#,##0.00 VNĐ"));
                lbRefundAmount.Text = string.Format("Số tiền cần hoàn trả: {0}", (oldTotalMoney - invoice.TotalMoney).ToString("#,##0.00 VNĐ"));

                MessageBox.Show("Đã cập nhật hóa đơn thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình cập nhật lại hóa đơn!", "Lỗi");
            }
        }
    }
}
