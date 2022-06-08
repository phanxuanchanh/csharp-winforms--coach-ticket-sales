using BanVeXeKhach.BUS_DAO.BUS;
using BanVeXeKhach.Common.Mail;
using BanVeXeKhach.Session;
using BanVeXeKhach.SubForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeXeKhach.UserControls
{
    public partial class UcTicketSales : UserControl
    {
        private Customer customer;
        private Invoice invoice;
        private Route route;
        private CoachTrip coachTrip;
        private List<Route> routes;

        public UcTicketSales()
        {
            InitializeComponent();
            customer = new Customer();
            invoice = new Invoice();
            route = new Route();
            coachTrip = new CoachTrip();
        }

        private async void UcTicketSales_Load(object sender, EventArgs e)
        {
            await LoadDefaultUserControl();
        }

        public async Task LoadDefaultUserControl()
        {
            try
            {
                txtCustomerName.Text = "";
                txtCustomerPhone.Text = "";
                txtCustomerEmail.Text = "";

                routes = await Route.GetRoutesAsync();
                cbRoute.DataSource = routes;
                cbRoute.DisplayMember = "Name";
                cbRoute.ValueMember = "RouteId";

                if (routes.Count > 0)
                    cbRoute.SelectedIndex = 0;

                txtNote.Text = "";
                txtSurcharge.Text = "";
                cbSeatSelection.Items.Clear();
                btnSellTicket_Complete.Enabled = false;
                btnSendMail.Enabled = false;

                lbInvoice_CustomerName.Text = "Tên khách hàng:...";
                lbInvoice_Employee.Text = "Tên nhân viên:...";
                lbInvoice_RouteName.Text = "Tên tuyến:...";
                lbInvoice_CoachTripName.Text = "Tên chuyến:...";
                lbInvoice_DepartureDate.Text = "Thời gian:...";
                lbTicketInfo.Text = "Thông tin vé:...";
                lbTotalMoney.Text = "Tổng tiền:...";

                lbInvoiceNumber.Text = "Số hóa đơn có trên hệ thống của khách hàng này là: 0";

                CustomerSession.SellTicket_SelectedCustomer = null;
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.ShowDialog();
            }
        }

        public void UpdateUserControl()
        {
            if(CustomerSession.SellTicket_SelectedCustomer != null)
            {
                customer = CustomerSession.SellTicket_SelectedCustomer;
                txtCustomerName.Text = customer.FullName;
                txtCustomerPhone.Text = customer.Phone;
                txtCustomerEmail.Text = customer.Email;
            }
        }

        public void CloseUserControl()
        {

        }

        private async void btnCustomerSelection_Click(object sender, EventArgs e)
        {
            try
            {
                if(CustomerSession.SellTicket_SelectedCustomer == null)
                {
                    MessageBox.Show("Vui lòng nhập thông tin khách hàng!", "Lỗi");
                }
                else
                {
                    lbInvoiceNumber.Text = string.Format("Số hóa đơn có trên hệ thống của khách hàng này là: {0}",
                        (await Invoice.CountInvoiceByCustomerIdAsync(customer.CustomerId)).ToString());

                    if (LoginSession.Role == "Employer" || LoginSession.Role == "Conductor")
                    {
                        invoice.Customer = customer;
                        invoice.Employee = new Employee { EmployeeId = LoginSession.EmployeeId };
                        if (await Invoice.CreateInvoiceAsync(invoice))
                        {
                            MessageBox.Show("Khởi tạo hóa đơn thành công!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Khởi tạo hóa đơn thất bại!", "Lỗi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn không có quyền thực hiện chức năng này!", "Lỗi");
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.ShowDialog();
            }
        }

        private void cbRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbRoute.SelectedValue is int)
                {
                    int routeId = (int)cbRoute.SelectedValue;

                    cbCoachTrip.DataSource = null;
                    cbCoachTrip.DataSource = CoachTrip.GetCoachTripsByRouteIdAndStatusName(routeId, "Chưa khởi hành");
                    cbCoachTrip.DisplayMember = "Name";
                    cbCoachTrip.ValueMember = "CoachTripId";

                    route = routes.SingleOrDefault(r => r.RouteId == routeId);
                    lbTicketPrice.Text = string.Format("Giá vé: {0}", route.Price.ToString("#,##0.00 VNĐ"));
                }
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.ShowDialog();
            }
        }

        private void cbCoachTrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbCoachTrip.SelectedValue is long)
                {
                    coachTrip = ((CoachTrip)cbCoachTrip.SelectedItem);
                    List<int> selectedSeatList = InvoiceDetail.GetSelectedSeatsByCoachTripId(coachTrip.CoachTripId);

                    SetSeats(selectedSeatList);
                    SelectSeat(selectedSeatList);
                }
                else
                {
                    SetSeats(null, true);
                    SelectSeat(null, true);
                }
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.ShowDialog();
            }
        }

        private void SetSeats(List<int> selectedSeatList, bool isDefault = false)
        {
            if (isDefault)
            {
                foreach (Control control1stFloor in xuiGradientPanel_1stFloor.Controls)
                {
                    if (control1stFloor is Button)
                        control1stFloor.BackColor = Color.DarkKhaki;
                }

                foreach (Control control2ndFloor in xuiGradientPanel_2ndFloor.Controls)
                {
                    if (control2ndFloor is Button)
                        control2ndFloor.BackColor = Color.DarkKhaki;
                }
            }
            else
            {
                foreach (Control control1stFloor in xuiGradientPanel_1stFloor.Controls)
                {
                    if (control1stFloor is Button)
                    {
                        if (selectedSeatList.Contains(int.Parse(control1stFloor.Text)))
                            control1stFloor.BackColor = Color.Red;
                        else
                            control1stFloor.BackColor = Color.Green;
                    }

                }

                foreach (Control control2ndFloor in xuiGradientPanel_2ndFloor.Controls)
                {
                    if (control2ndFloor is Button)
                    {
                        if (selectedSeatList.Contains(int.Parse(control2ndFloor.Text)))
                            control2ndFloor.BackColor = Color.Red;
                        else
                            control2ndFloor.BackColor = Color.Green;
                    }
                }
            }
        }

        private void SelectSeat(List<int> selectedSeatList, bool isDefault = false)
        {
            if (isDefault)
            {
                cbSeatSelection.Items.Clear();
            }
            else
            {
                cbSeatSelection.Items.Clear();
                for (int i = 1; i <= 40; i++)
                {
                    if (!selectedSeatList.Contains(i))
                        cbSeatSelection.Items.Add(i);
                }

                if (cbSeatSelection.Items.Count > 0)
                    cbSeatSelection.SelectedIndex = 0;
            }
        }

        private async void btnSellTicket_Click(object sender, EventArgs e)
        {
            try
            {
                string strSurcharge = txtSurcharge.Text;
                string note = txtNote.Text;
                if (Regex.IsMatch(strSurcharge, "^[0-9.]{1,}$"))
                {
                    if (invoice.InvoiceId > 0 && coachTrip.CoachTripId > 0)
                    {
                        int seatSelection = (int)cbSeatSelection.SelectedItem;
                        double surcharge = double.Parse(strSurcharge);

                        bool executionResult = await InvoiceDetail.CreateInvoiceDetailAsync(new InvoiceDetail
                        {
                            Invoice = invoice,
                            CoachTrip = coachTrip,
                            SeatPosition = seatSelection,
                            Price = route.Price,
                            Surcharge = surcharge,
                            Note = note,
                            IntoMoney = route.Price + surcharge,
                            Status = "Completed"
                        });

                        if (executionResult)
                        {
                            List<int> selectedSeatList = await InvoiceDetail.GetSelectedSeatsByCoachTripIdAsync(coachTrip.CoachTripId);

                            SetSeats(selectedSeatList);
                            SelectSeat(selectedSeatList);

                            btnSellTicket_Complete.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Đã có lỗi xảy ra trong khi thực hiện thêm dữ liệu vào hệ thống!", "Lỗi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng thực hiện đúng các thao tác trước khi thực tính năng này!", "Lỗi");
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu đầu vào không hợp lệ!", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.ShowDialog();
            }
        }

        private async void btnSellTicket_Complete_Click(object sender, EventArgs e)
        {
            try
            {
                lbInvoice_CustomerName.Text = string.Format("Tên khách hàng: {0}", customer.FullName);
                lbInvoice_RouteName.Text = string.Format("Tên tuyến: {0}", route.Name);
                lbInvoice_CoachTripName.Text = string.Format("Tên chuyến: {0}", coachTrip.Name);
                lbInvoice_Employee.Text = string.Format("Tên nhân viên: {0}", LoginSession.EmployeeName);

                lbInvoice_DepartureDate.Text = string.Format("Thời gian: {0}", coachTrip.DepartureDate);
                StringBuilder ticketInfo = new StringBuilder("Thông tin vé: ");
                List<InvoiceDetail> invoiceDetails = InvoiceDetail.GetInvoiceDetails(invoice.InvoiceId);
                invoice.TotalMoney = 0;
                int count = 0;
                foreach (InvoiceDetail invoiceDetail in invoiceDetails)
                {
                    invoice.TotalMoney += invoiceDetail.IntoMoney;
                    ticketInfo.Append(string.Format(
                        "Vé {0}: [ Số ghế: {1}; Giá vé: {2}; Phụ thu: {3}; Ghi chú: {4}; Thành tiền: {5} ] \n",
                        count++, invoiceDetail.SeatPosition, invoiceDetail.Price, invoiceDetail.Surcharge,
                        invoiceDetail.Note, invoiceDetail.IntoMoney));
                }

                lbTicketInfo.Text = ticketInfo.ToString();
                invoice.PurchaseDate = DateTime.Now;
                invoice.Status = "Completed";
                await invoice.UpdateInvoiceAsync();
                lbTotalMoney.Text = string.Format("Tổng tiền: {0}", invoice.TotalMoney.ToString("#,##0.00 VNĐ"));

                btnSellTicket_Complete.Enabled = false;
                btnSendMail.Enabled = true;
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.ShowDialog();
            }
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Run(() =>
                {
                    string emailContentTemplate = global::BanVeXeKhach.Properties.Resources.email;
                    string message = emailContentTemplate
                        .Replace("@customerName", lbInvoice_CustomerName.Text)
                        .Replace("@customerPhone", customer.Phone)
                        .Replace("@employeeName", lbInvoice_Employee.Text)
                        .Replace("@routeName", lbInvoice_RouteName.Text)
                        .Replace("@coachTripName", lbInvoice_CoachTripName.Text)
                        .Replace("@departureDate", lbInvoice_DepartureDate.Text)
                        .Replace("@tickets", lbTicketInfo.Text)
                        .Replace("@totalMoney", lbTotalMoney.Text);

                    SMTP.Send(customer.Email, "Xác nhận mua vé", message);
                    MessageBox.Show("Đã thực hiện gửi hóa đơn cho khách hàng qua email thành công!", "Thành công");
                });
                
                btnSendMail.Enabled = false;
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex);
                errorForm.ShowDialog();
            }
        }

        private void btnCustomerInfo_Click(object sender, EventArgs e)
        {
            SearchOrCreateCustomerForm searchOrCreateCustomer = new SearchOrCreateCustomerForm();
            searchOrCreateCustomer.ShowDialog();
        }
    }
}
