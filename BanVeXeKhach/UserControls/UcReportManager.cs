using BanVeXeKhach.Reports;
using System;
using System.Windows.Forms;

namespace BanVeXeKhach.UserControls
{
    public partial class UcReportManager : UserControl
    {
        public UcReportManager()
        {
            InitializeComponent();
        }

        private void xuiCard_RouteReport_Click(object sender, EventArgs e)
        {
            RouteReportForm routeReportForm = new RouteReportForm();
            routeReportForm.Show();
        }

        private void xuiCard_StaffReport_Click(object sender, EventArgs e)
        {
            EmployeeReportForm staffReportForm = new EmployeeReportForm();
            staffReportForm.Show();
        }

        private void xuiCard_InvoiceReport_Click(object sender, EventArgs e)
        {
            InvoiceReportForm invoiceReportForm = new InvoiceReportForm();
            invoiceReportForm.Show();
        }
    }
}
