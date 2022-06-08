using System;
using System.Windows.Forms;

namespace BanVeXeKhach.UserControls
{
    public partial class UcInvoice : UserControl
    {
        public UcInvoice()
        {
            InitializeComponent();
        }

        private void UcInvoice_Load(object sender, EventArgs e)
        {
            DefaultUserControl();
        }

        public void DefaultUserControl()
        {
            try
            {
                dgvInvoiceListByStaff.AutoGenerateColumns = false;
                ReloadDataTableAndDGridView();
                lbInvoiceNumberByStaff.Text = string.Format(
                    "Số hóa đơn của bạn hiện có: {0}", 0);
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

        public void ReloadDataTableAndDGridView()
        {

        }
    }
}
