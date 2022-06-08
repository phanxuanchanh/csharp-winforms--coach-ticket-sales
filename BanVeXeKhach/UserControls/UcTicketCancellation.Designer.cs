
namespace BanVeXeKhach.UserControls
{
    partial class UcTicketCancellation
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnSpace1 = new System.Windows.Forms.Panel();
            this.pnSpace2 = new System.Windows.Forms.Panel();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.pnSpace3 = new System.Windows.Forms.Panel();
            this.pnSpace4 = new System.Windows.Forms.Panel();
            this.pnCustomer = new System.Windows.Forms.Panel();
            this.dgvCustomerList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.lbSearchSelection = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbSearchSelection = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.pnSpace5 = new System.Windows.Forms.Panel();
            this.pnSpace6 = new System.Windows.Forms.Panel();
            this.pnSpace7 = new System.Windows.Forms.Panel();
            this.pnTool = new System.Windows.Forms.Panel();
            this.pnTicketRefund = new System.Windows.Forms.Panel();
            this.lbRefundAmount = new System.Windows.Forms.Label();
            this.lbNewTotalMoney = new System.Windows.Forms.Label();
            this.lbOldTotalMoney = new System.Windows.Forms.Label();
            this.lbTicketRefund = new System.Windows.Forms.Label();
            this.pnSellTicket = new System.Windows.Forms.Panel();
            this.lbSurcharge = new System.Windows.Forms.Label();
            this.txtSurcharge = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbSeatPosition = new System.Windows.Forms.Label();
            this.txtSeatPosition = new System.Windows.Forms.TextBox();
            this.lbCoachTripName = new System.Windows.Forms.Label();
            this.txtCoachTripName = new System.Windows.Forms.TextBox();
            this.btnUpdateInvoice = new System.Windows.Forms.Button();
            this.lbNote = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnCancelTicket = new System.Windows.Forms.Button();
            this.lbCancelTicket = new System.Windows.Forms.Label();
            this.pnSpace8 = new System.Windows.Forms.Panel();
            this.pnSpace9 = new System.Windows.Forms.Panel();
            this.pnInvoice = new System.Windows.Forms.Panel();
            this.dgvInvoiceList = new System.Windows.Forms.DataGridView();
            this.InvoiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnSpace10 = new System.Windows.Forms.Panel();
            this.pnHeader2 = new System.Windows.Forms.Panel();
            this.lbHeader2 = new System.Windows.Forms.Label();
            this.pnInvoiceDetail = new System.Windows.Forms.Panel();
            this.dgvInvoiceDetailList = new System.Windows.Forms.DataGridView();
            this.InvoiceInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoachTripInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeatPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surcharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntoMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDetailStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnSpace11 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbHeader3 = new System.Windows.Forms.Label();
            this.pnHeader.SuspendLayout();
            this.pnCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            this.pnSearch.SuspendLayout();
            this.pnTool.SuspendLayout();
            this.pnTicketRefund.SuspendLayout();
            this.pnSellTicket.SuspendLayout();
            this.pnInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceList)).BeginInit();
            this.pnHeader2.SuspendLayout();
            this.pnInvoiceDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetailList)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSpace1
            // 
            this.pnSpace1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSpace1.Location = new System.Drawing.Point(0, 0);
            this.pnSpace1.Name = "pnSpace1";
            this.pnSpace1.Size = new System.Drawing.Size(10, 834);
            this.pnSpace1.TabIndex = 1;
            // 
            // pnSpace2
            // 
            this.pnSpace2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSpace2.Location = new System.Drawing.Point(1359, 0);
            this.pnSpace2.Name = "pnSpace2";
            this.pnSpace2.Size = new System.Drawing.Size(10, 834);
            this.pnSpace2.TabIndex = 2;
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.lbHeader);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(10, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1349, 37);
            this.pnHeader.TabIndex = 50;
            // 
            // lbHeader
            // 
            this.lbHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Location = new System.Drawing.Point(0, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(1349, 37);
            this.lbHeader.TabIndex = 14;
            this.lbHeader.Text = "THÔNG TIN KHÁCH HÀNG";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnSpace3
            // 
            this.pnSpace3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnSpace3.Location = new System.Drawing.Point(10, 824);
            this.pnSpace3.Name = "pnSpace3";
            this.pnSpace3.Size = new System.Drawing.Size(1349, 10);
            this.pnSpace3.TabIndex = 51;
            // 
            // pnSpace4
            // 
            this.pnSpace4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSpace4.Location = new System.Drawing.Point(10, 37);
            this.pnSpace4.Name = "pnSpace4";
            this.pnSpace4.Size = new System.Drawing.Size(1349, 10);
            this.pnSpace4.TabIndex = 52;
            // 
            // pnCustomer
            // 
            this.pnCustomer.Controls.Add(this.dgvCustomerList);
            this.pnCustomer.Controls.Add(this.pnSearch);
            this.pnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCustomer.Location = new System.Drawing.Point(10, 47);
            this.pnCustomer.Name = "pnCustomer";
            this.pnCustomer.Size = new System.Drawing.Size(1349, 141);
            this.pnCustomer.TabIndex = 53;
            // 
            // dgvCustomerList
            // 
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CustomerName,
            this.Phone,
            this.Email});
            this.dgvCustomerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerList.Location = new System.Drawing.Point(450, 0);
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.RowHeadersWidth = 51;
            this.dgvCustomerList.RowTemplate.Height = 24;
            this.dgvCustomerList.Size = new System.Drawing.Size(899, 141);
            this.dgvCustomerList.TabIndex = 3;
            this.dgvCustomerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerList_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "CustomerId";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "FullName";
            this.CustomerName.HeaderText = "Tên khách hàng";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 125;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "SĐT";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.lbSearchSelection);
            this.pnSearch.Controls.Add(this.btnSearch);
            this.pnSearch.Controls.Add(this.cbSearchSelection);
            this.pnSearch.Controls.Add(this.txtSearch);
            this.pnSearch.Controls.Add(this.lbSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSearch.Location = new System.Drawing.Point(0, 0);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(450, 141);
            this.pnSearch.TabIndex = 0;
            // 
            // lbSearchSelection
            // 
            this.lbSearchSelection.AutoSize = true;
            this.lbSearchSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchSelection.Location = new System.Drawing.Point(6, 59);
            this.lbSearchSelection.Name = "lbSearchSelection";
            this.lbSearchSelection.Size = new System.Drawing.Size(82, 20);
            this.lbSearchSelection.TabIndex = 54;
            this.lbSearchSelection.Text = "Tùy chọn:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(321, 104);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 31);
            this.btnSearch.TabIndex = 53;
            this.btnSearch.Text = "Thực hiện";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbSearchSelection
            // 
            this.cbSearchSelection.BackColor = System.Drawing.Color.Linen;
            this.cbSearchSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSearchSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchSelection.FormattingEnabled = true;
            this.cbSearchSelection.Location = new System.Drawing.Point(107, 59);
            this.cbSearchSelection.Name = "cbSearchSelection";
            this.cbSearchSelection.Size = new System.Drawing.Size(323, 24);
            this.cbSearchSelection.TabIndex = 52;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Linen;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(107, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(323, 21);
            this.txtSearch.TabIndex = 19;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(6, 16);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(82, 20);
            this.lbSearch.TabIndex = 18;
            this.lbSearch.Text = "Tìm kiếm:";
            // 
            // pnSpace5
            // 
            this.pnSpace5.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSpace5.Location = new System.Drawing.Point(10, 188);
            this.pnSpace5.Name = "pnSpace5";
            this.pnSpace5.Size = new System.Drawing.Size(1349, 10);
            this.pnSpace5.TabIndex = 54;
            // 
            // pnSpace6
            // 
            this.pnSpace6.BackColor = System.Drawing.Color.Bisque;
            this.pnSpace6.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSpace6.Location = new System.Drawing.Point(10, 198);
            this.pnSpace6.Name = "pnSpace6";
            this.pnSpace6.Size = new System.Drawing.Size(1349, 10);
            this.pnSpace6.TabIndex = 55;
            // 
            // pnSpace7
            // 
            this.pnSpace7.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSpace7.Location = new System.Drawing.Point(10, 208);
            this.pnSpace7.Name = "pnSpace7";
            this.pnSpace7.Size = new System.Drawing.Size(1349, 10);
            this.pnSpace7.TabIndex = 56;
            // 
            // pnTool
            // 
            this.pnTool.Controls.Add(this.pnTicketRefund);
            this.pnTool.Controls.Add(this.lbTicketRefund);
            this.pnTool.Controls.Add(this.pnSellTicket);
            this.pnTool.Controls.Add(this.lbCancelTicket);
            this.pnTool.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnTool.Location = new System.Drawing.Point(775, 218);
            this.pnTool.Name = "pnTool";
            this.pnTool.Size = new System.Drawing.Size(584, 606);
            this.pnTool.TabIndex = 57;
            // 
            // pnTicketRefund
            // 
            this.pnTicketRefund.Controls.Add(this.lbRefundAmount);
            this.pnTicketRefund.Controls.Add(this.lbNewTotalMoney);
            this.pnTicketRefund.Controls.Add(this.lbOldTotalMoney);
            this.pnTicketRefund.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTicketRefund.Location = new System.Drawing.Point(0, 394);
            this.pnTicketRefund.Name = "pnTicketRefund";
            this.pnTicketRefund.Size = new System.Drawing.Size(584, 121);
            this.pnTicketRefund.TabIndex = 16;
            // 
            // lbRefundAmount
            // 
            this.lbRefundAmount.AutoSize = true;
            this.lbRefundAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRefundAmount.ForeColor = System.Drawing.Color.Brown;
            this.lbRefundAmount.Location = new System.Drawing.Point(6, 82);
            this.lbRefundAmount.Name = "lbRefundAmount";
            this.lbRefundAmount.Size = new System.Drawing.Size(181, 20);
            this.lbRefundAmount.TabIndex = 44;
            this.lbRefundAmount.Text = "Số tiền cần hoàn trả: ...";
            // 
            // lbNewTotalMoney
            // 
            this.lbNewTotalMoney.AutoSize = true;
            this.lbNewTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewTotalMoney.Location = new System.Drawing.Point(6, 48);
            this.lbNewTotalMoney.Name = "lbNewTotalMoney";
            this.lbNewTotalMoney.Size = new System.Drawing.Size(115, 20);
            this.lbNewTotalMoney.TabIndex = 43;
            this.lbNewTotalMoney.Text = "Số tiền mới: ...";
            // 
            // lbOldTotalMoney
            // 
            this.lbOldTotalMoney.AutoSize = true;
            this.lbOldTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldTotalMoney.Location = new System.Drawing.Point(6, 14);
            this.lbOldTotalMoney.Name = "lbOldTotalMoney";
            this.lbOldTotalMoney.Size = new System.Drawing.Size(106, 20);
            this.lbOldTotalMoney.TabIndex = 42;
            this.lbOldTotalMoney.Text = "Số tiền cũ: ...";
            // 
            // lbTicketRefund
            // 
            this.lbTicketRefund.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTicketRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTicketRefund.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbTicketRefund.Location = new System.Drawing.Point(0, 362);
            this.lbTicketRefund.Name = "lbTicketRefund";
            this.lbTicketRefund.Size = new System.Drawing.Size(584, 32);
            this.lbTicketRefund.TabIndex = 15;
            this.lbTicketRefund.Text = "Hoàn tiền";
            this.lbTicketRefund.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnSellTicket
            // 
            this.pnSellTicket.Controls.Add(this.lbSurcharge);
            this.pnSellTicket.Controls.Add(this.txtSurcharge);
            this.pnSellTicket.Controls.Add(this.lbPrice);
            this.pnSellTicket.Controls.Add(this.txtPrice);
            this.pnSellTicket.Controls.Add(this.lbSeatPosition);
            this.pnSellTicket.Controls.Add(this.txtSeatPosition);
            this.pnSellTicket.Controls.Add(this.lbCoachTripName);
            this.pnSellTicket.Controls.Add(this.txtCoachTripName);
            this.pnSellTicket.Controls.Add(this.btnUpdateInvoice);
            this.pnSellTicket.Controls.Add(this.lbNote);
            this.pnSellTicket.Controls.Add(this.txtNote);
            this.pnSellTicket.Controls.Add(this.btnCancelTicket);
            this.pnSellTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSellTicket.Location = new System.Drawing.Point(0, 32);
            this.pnSellTicket.Name = "pnSellTicket";
            this.pnSellTicket.Size = new System.Drawing.Size(584, 330);
            this.pnSellTicket.TabIndex = 14;
            // 
            // lbSurcharge
            // 
            this.lbSurcharge.AutoSize = true;
            this.lbSurcharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSurcharge.Location = new System.Drawing.Point(6, 163);
            this.lbSurcharge.Name = "lbSurcharge";
            this.lbSurcharge.Size = new System.Drawing.Size(71, 20);
            this.lbSurcharge.TabIndex = 57;
            this.lbSurcharge.Text = "Phụ thu:";
            // 
            // txtSurcharge
            // 
            this.txtSurcharge.BackColor = System.Drawing.Color.Linen;
            this.txtSurcharge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurcharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurcharge.Location = new System.Drawing.Point(123, 163);
            this.txtSurcharge.Name = "txtSurcharge";
            this.txtSurcharge.Size = new System.Drawing.Size(455, 19);
            this.txtSurcharge.TabIndex = 56;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(6, 138);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(62, 20);
            this.lbPrice.TabIndex = 55;
            this.lbPrice.Text = "Giá vé:";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Linen;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(123, 138);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(455, 19);
            this.txtPrice.TabIndex = 54;
            // 
            // lbSeatPosition
            // 
            this.lbSeatPosition.AutoSize = true;
            this.lbSeatPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeatPosition.Location = new System.Drawing.Point(6, 113);
            this.lbSeatPosition.Name = "lbSeatPosition";
            this.lbSeatPosition.Size = new System.Drawing.Size(80, 20);
            this.lbSeatPosition.TabIndex = 53;
            this.lbSeatPosition.Text = "Chỗ ngồi:";
            // 
            // txtSeatPosition
            // 
            this.txtSeatPosition.BackColor = System.Drawing.Color.Linen;
            this.txtSeatPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeatPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeatPosition.Location = new System.Drawing.Point(123, 113);
            this.txtSeatPosition.Name = "txtSeatPosition";
            this.txtSeatPosition.Size = new System.Drawing.Size(455, 19);
            this.txtSeatPosition.TabIndex = 52;
            // 
            // lbCoachTripName
            // 
            this.lbCoachTripName.AutoSize = true;
            this.lbCoachTripName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoachTripName.Location = new System.Drawing.Point(6, 49);
            this.lbCoachTripName.Name = "lbCoachTripName";
            this.lbCoachTripName.Size = new System.Drawing.Size(100, 20);
            this.lbCoachTripName.TabIndex = 51;
            this.lbCoachTripName.Text = "Tên chuyến:";
            // 
            // txtCoachTripName
            // 
            this.txtCoachTripName.BackColor = System.Drawing.Color.Linen;
            this.txtCoachTripName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCoachTripName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoachTripName.Location = new System.Drawing.Point(123, 15);
            this.txtCoachTripName.Multiline = true;
            this.txtCoachTripName.Name = "txtCoachTripName";
            this.txtCoachTripName.Size = new System.Drawing.Size(455, 92);
            this.txtCoachTripName.TabIndex = 50;
            // 
            // btnUpdateInvoice
            // 
            this.btnUpdateInvoice.BackColor = System.Drawing.Color.SandyBrown;
            this.btnUpdateInvoice.Enabled = false;
            this.btnUpdateInvoice.FlatAppearance.BorderSize = 0;
            this.btnUpdateInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInvoice.Location = new System.Drawing.Point(401, 289);
            this.btnUpdateInvoice.Name = "btnUpdateInvoice";
            this.btnUpdateInvoice.Size = new System.Drawing.Size(177, 35);
            this.btnUpdateInvoice.TabIndex = 49;
            this.btnUpdateInvoice.Text = "Cập nhật hóa đơn";
            this.btnUpdateInvoice.UseVisualStyleBackColor = false;
            this.btnUpdateInvoice.Click += new System.EventHandler(this.btnUpdateInvoice_Click);
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.Location = new System.Drawing.Point(6, 216);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(72, 20);
            this.lbNote.TabIndex = 48;
            this.lbNote.Text = "Ghi chú:";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.Linen;
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(123, 188);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(455, 77);
            this.txtNote.TabIndex = 47;
            // 
            // btnCancelTicket
            // 
            this.btnCancelTicket.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCancelTicket.FlatAppearance.BorderSize = 0;
            this.btnCancelTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTicket.Location = new System.Drawing.Point(258, 289);
            this.btnCancelTicket.Name = "btnCancelTicket";
            this.btnCancelTicket.Size = new System.Drawing.Size(137, 35);
            this.btnCancelTicket.TabIndex = 0;
            this.btnCancelTicket.Text = "Hủy vé";
            this.btnCancelTicket.UseVisualStyleBackColor = false;
            this.btnCancelTicket.Click += new System.EventHandler(this.btnCancelTicket_Click);
            // 
            // lbCancelTicket
            // 
            this.lbCancelTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCancelTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCancelTicket.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbCancelTicket.Location = new System.Drawing.Point(0, 0);
            this.lbCancelTicket.Name = "lbCancelTicket";
            this.lbCancelTicket.Size = new System.Drawing.Size(584, 32);
            this.lbCancelTicket.TabIndex = 13;
            this.lbCancelTicket.Text = "Hủy vé";
            this.lbCancelTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnSpace8
            // 
            this.pnSpace8.BackColor = System.Drawing.Color.Bisque;
            this.pnSpace8.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSpace8.Location = new System.Drawing.Point(765, 218);
            this.pnSpace8.Name = "pnSpace8";
            this.pnSpace8.Size = new System.Drawing.Size(10, 606);
            this.pnSpace8.TabIndex = 58;
            // 
            // pnSpace9
            // 
            this.pnSpace9.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSpace9.Location = new System.Drawing.Point(755, 218);
            this.pnSpace9.Name = "pnSpace9";
            this.pnSpace9.Size = new System.Drawing.Size(10, 606);
            this.pnSpace9.TabIndex = 59;
            // 
            // pnInvoice
            // 
            this.pnInvoice.Controls.Add(this.dgvInvoiceList);
            this.pnInvoice.Controls.Add(this.pnSpace10);
            this.pnInvoice.Controls.Add(this.pnHeader2);
            this.pnInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInvoice.Location = new System.Drawing.Point(10, 218);
            this.pnInvoice.Name = "pnInvoice";
            this.pnInvoice.Size = new System.Drawing.Size(745, 248);
            this.pnInvoice.TabIndex = 60;
            // 
            // dgvInvoiceList
            // 
            this.dgvInvoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceId,
            this.CustomerInfo,
            this.EmployeeInfo,
            this.TotalMoney,
            this.PurchaseDate});
            this.dgvInvoiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoiceList.Location = new System.Drawing.Point(0, 47);
            this.dgvInvoiceList.Name = "dgvInvoiceList";
            this.dgvInvoiceList.RowHeadersWidth = 51;
            this.dgvInvoiceList.RowTemplate.Height = 24;
            this.dgvInvoiceList.Size = new System.Drawing.Size(745, 201);
            this.dgvInvoiceList.TabIndex = 40;
            this.dgvInvoiceList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoiceList_CellClick);
            // 
            // InvoiceId
            // 
            this.InvoiceId.DataPropertyName = "InvoiceId";
            this.InvoiceId.HeaderText = "ID";
            this.InvoiceId.MinimumWidth = 6;
            this.InvoiceId.Name = "InvoiceId";
            this.InvoiceId.Width = 125;
            // 
            // CustomerInfo
            // 
            this.CustomerInfo.DataPropertyName = "Customer";
            this.CustomerInfo.HeaderText = "Khách hàng";
            this.CustomerInfo.MinimumWidth = 6;
            this.CustomerInfo.Name = "CustomerInfo";
            this.CustomerInfo.Width = 125;
            // 
            // EmployeeInfo
            // 
            this.EmployeeInfo.DataPropertyName = "Employee";
            this.EmployeeInfo.HeaderText = "Nhân viên";
            this.EmployeeInfo.MinimumWidth = 6;
            this.EmployeeInfo.Name = "EmployeeInfo";
            this.EmployeeInfo.Width = 125;
            // 
            // TotalMoney
            // 
            this.TotalMoney.DataPropertyName = "TotalMoney";
            this.TotalMoney.HeaderText = "Tổng tiền";
            this.TotalMoney.MinimumWidth = 6;
            this.TotalMoney.Name = "TotalMoney";
            this.TotalMoney.Width = 125;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.DataPropertyName = "PurchaseDate";
            this.PurchaseDate.HeaderText = "Ngày thanh toán";
            this.PurchaseDate.MinimumWidth = 6;
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.Width = 125;
            // 
            // pnSpace10
            // 
            this.pnSpace10.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSpace10.Location = new System.Drawing.Point(0, 37);
            this.pnSpace10.Name = "pnSpace10";
            this.pnSpace10.Size = new System.Drawing.Size(745, 10);
            this.pnSpace10.TabIndex = 39;
            // 
            // pnHeader2
            // 
            this.pnHeader2.Controls.Add(this.lbHeader2);
            this.pnHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader2.Location = new System.Drawing.Point(0, 0);
            this.pnHeader2.Name = "pnHeader2";
            this.pnHeader2.Size = new System.Drawing.Size(745, 37);
            this.pnHeader2.TabIndex = 37;
            // 
            // lbHeader2
            // 
            this.lbHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbHeader2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader2.Location = new System.Drawing.Point(0, 0);
            this.lbHeader2.Name = "lbHeader2";
            this.lbHeader2.Size = new System.Drawing.Size(745, 37);
            this.lbHeader2.TabIndex = 13;
            this.lbHeader2.Text = "HÓA ĐƠN";
            this.lbHeader2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnInvoiceDetail
            // 
            this.pnInvoiceDetail.Controls.Add(this.dgvInvoiceDetailList);
            this.pnInvoiceDetail.Controls.Add(this.pnSpace11);
            this.pnInvoiceDetail.Controls.Add(this.panel2);
            this.pnInvoiceDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInvoiceDetail.Location = new System.Drawing.Point(10, 466);
            this.pnInvoiceDetail.Name = "pnInvoiceDetail";
            this.pnInvoiceDetail.Size = new System.Drawing.Size(745, 248);
            this.pnInvoiceDetail.TabIndex = 61;
            // 
            // dgvInvoiceDetailList
            // 
            this.dgvInvoiceDetailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceDetailList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceInfo,
            this.CoachTripInfo,
            this.SeatPosition,
            this.Price,
            this.Surcharge,
            this.Note,
            this.IntoMoney,
            this.InvoiceDetailStatus});
            this.dgvInvoiceDetailList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoiceDetailList.Location = new System.Drawing.Point(0, 47);
            this.dgvInvoiceDetailList.Name = "dgvInvoiceDetailList";
            this.dgvInvoiceDetailList.RowHeadersWidth = 51;
            this.dgvInvoiceDetailList.RowTemplate.Height = 24;
            this.dgvInvoiceDetailList.Size = new System.Drawing.Size(745, 201);
            this.dgvInvoiceDetailList.TabIndex = 40;
            this.dgvInvoiceDetailList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoiceDetailList_CellClick);
            // 
            // InvoiceInfo
            // 
            this.InvoiceInfo.DataPropertyName = "Invoice";
            this.InvoiceInfo.HeaderText = "Hóa đơn";
            this.InvoiceInfo.MinimumWidth = 6;
            this.InvoiceInfo.Name = "InvoiceInfo";
            this.InvoiceInfo.Width = 125;
            // 
            // CoachTripInfo
            // 
            this.CoachTripInfo.DataPropertyName = "CoachTrip";
            this.CoachTripInfo.HeaderText = "Chuyến xe";
            this.CoachTripInfo.MinimumWidth = 6;
            this.CoachTripInfo.Name = "CoachTripInfo";
            this.CoachTripInfo.Width = 125;
            // 
            // SeatPosition
            // 
            this.SeatPosition.DataPropertyName = "SeatPosition";
            this.SeatPosition.HeaderText = "Chỗ ngồi";
            this.SeatPosition.MinimumWidth = 6;
            this.SeatPosition.Name = "SeatPosition";
            this.SeatPosition.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Giá vé";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Surcharge
            // 
            this.Surcharge.DataPropertyName = "Surcharge";
            this.Surcharge.HeaderText = "Phụ thụ";
            this.Surcharge.MinimumWidth = 6;
            this.Surcharge.Name = "Surcharge";
            this.Surcharge.Width = 125;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Ghi chú";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.Width = 125;
            // 
            // IntoMoney
            // 
            this.IntoMoney.DataPropertyName = "IntoMoney";
            this.IntoMoney.HeaderText = "Thành tiền";
            this.IntoMoney.MinimumWidth = 6;
            this.IntoMoney.Name = "IntoMoney";
            this.IntoMoney.Width = 125;
            // 
            // InvoiceDetailStatus
            // 
            this.InvoiceDetailStatus.DataPropertyName = "Status";
            this.InvoiceDetailStatus.HeaderText = "Trạng thái";
            this.InvoiceDetailStatus.MinimumWidth = 6;
            this.InvoiceDetailStatus.Name = "InvoiceDetailStatus";
            this.InvoiceDetailStatus.Width = 125;
            // 
            // pnSpace11
            // 
            this.pnSpace11.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSpace11.Location = new System.Drawing.Point(0, 37);
            this.pnSpace11.Name = "pnSpace11";
            this.pnSpace11.Size = new System.Drawing.Size(745, 10);
            this.pnSpace11.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbHeader3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 37);
            this.panel2.TabIndex = 37;
            // 
            // lbHeader3
            // 
            this.lbHeader3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbHeader3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader3.Location = new System.Drawing.Point(0, 0);
            this.lbHeader3.Name = "lbHeader3";
            this.lbHeader3.Size = new System.Drawing.Size(745, 37);
            this.lbHeader3.TabIndex = 13;
            this.lbHeader3.Text = "CHI TIẾT HÓA ĐƠN";
            this.lbHeader3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UcTicketCancellation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnInvoiceDetail);
            this.Controls.Add(this.pnInvoice);
            this.Controls.Add(this.pnSpace9);
            this.Controls.Add(this.pnSpace8);
            this.Controls.Add(this.pnTool);
            this.Controls.Add(this.pnSpace7);
            this.Controls.Add(this.pnSpace6);
            this.Controls.Add(this.pnSpace5);
            this.Controls.Add(this.pnCustomer);
            this.Controls.Add(this.pnSpace4);
            this.Controls.Add(this.pnSpace3);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.pnSpace2);
            this.Controls.Add(this.pnSpace1);
            this.Name = "UcTicketCancellation";
            this.Size = new System.Drawing.Size(1369, 834);
            this.Load += new System.EventHandler(this.UcTicketCancellation_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnTool.ResumeLayout(false);
            this.pnTicketRefund.ResumeLayout(false);
            this.pnTicketRefund.PerformLayout();
            this.pnSellTicket.ResumeLayout(false);
            this.pnSellTicket.PerformLayout();
            this.pnInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceList)).EndInit();
            this.pnHeader2.ResumeLayout(false);
            this.pnInvoiceDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetailList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSpace1;
        private System.Windows.Forms.Panel pnSpace2;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnSpace3;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Panel pnSpace4;
        private System.Windows.Forms.Panel pnCustomer;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.ComboBox cbSearchSelection;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnSpace5;
        private System.Windows.Forms.DataGridView dgvCustomerList;
        private System.Windows.Forms.Label lbSearchSelection;
        private System.Windows.Forms.Panel pnSpace6;
        private System.Windows.Forms.Panel pnSpace7;
        private System.Windows.Forms.Panel pnTool;
        private System.Windows.Forms.Panel pnSellTicket;
        private System.Windows.Forms.Button btnUpdateInvoice;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnCancelTicket;
        private System.Windows.Forms.Label lbCancelTicket;
        private System.Windows.Forms.Panel pnSpace8;
        private System.Windows.Forms.Panel pnSpace9;
        private System.Windows.Forms.Panel pnInvoice;
        private System.Windows.Forms.Panel pnSpace10;
        private System.Windows.Forms.Panel pnHeader2;
        private System.Windows.Forms.Label lbHeader2;
        private System.Windows.Forms.DataGridView dgvInvoiceList;
        private System.Windows.Forms.Panel pnInvoiceDetail;
        private System.Windows.Forms.Panel pnSpace11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbHeader3;
        private System.Windows.Forms.DataGridView dgvInvoiceDetailList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoachTripInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeatPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surcharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntoMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDetailStatus;
        private System.Windows.Forms.Label lbSurcharge;
        private System.Windows.Forms.TextBox txtSurcharge;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbSeatPosition;
        private System.Windows.Forms.TextBox txtSeatPosition;
        private System.Windows.Forms.Label lbCoachTripName;
        private System.Windows.Forms.TextBox txtCoachTripName;
        private System.Windows.Forms.Label lbTicketRefund;
        private System.Windows.Forms.Panel pnTicketRefund;
        private System.Windows.Forms.Label lbRefundAmount;
        private System.Windows.Forms.Label lbNewTotalMoney;
        private System.Windows.Forms.Label lbOldTotalMoney;
    }
}
