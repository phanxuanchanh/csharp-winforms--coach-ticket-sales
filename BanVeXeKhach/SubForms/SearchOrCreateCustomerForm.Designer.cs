
namespace BanVeXeKhach.SubForms
{
    partial class SearchOrCreateCustomerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchOrCreateCustomerForm));
            this.panelHeaderBar = new System.Windows.Forms.Panel();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.pnSpace22 = new System.Windows.Forms.Panel();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbDefaultOrMaximize = new System.Windows.Forms.PictureBox();
            this.btnTitle = new System.Windows.Forms.Button();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.pbCancel = new System.Windows.Forms.PictureBox();
            this.pnSpace2 = new System.Windows.Forms.Panel();
            this.pnSpace1 = new System.Windows.Forms.Panel();
            this.pnSpace4 = new System.Windows.Forms.Panel();
            this.pnSpace3 = new System.Windows.Forms.Panel();
            this.pnMainWorkArea = new System.Windows.Forms.Panel();
            this.dgvCustomerList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnDataManager = new System.Windows.Forms.Panel();
            this.pnDataManager_Layer2 = new System.Windows.Forms.Panel();
            this.dtpCustomerBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnSelectCustomer = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.lbCustomerAddress = new System.Windows.Forms.Label();
            this.lbCustomerBirthday = new System.Windows.Forms.Label();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.lbCustomerEmail = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.lbCustomerPhone = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.pnSpace7 = new System.Windows.Forms.Panel();
            this.pnSpace6 = new System.Windows.Forms.Panel();
            this.pnSpace5 = new System.Windows.Forms.Panel();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.cbSearchSelection = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.panelHeaderBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefaultOrMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).BeginInit();
            this.pnMainWorkArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            this.pnDataManager.SuspendLayout();
            this.pnDataManager_Layer2.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeaderBar
            // 
            this.panelHeaderBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
            this.panelHeaderBar.Controls.Add(this.pbRefresh);
            this.panelHeaderBar.Controls.Add(this.pnSpace22);
            this.panelHeaderBar.Controls.Add(this.pbMinimize);
            this.panelHeaderBar.Controls.Add(this.pbDefaultOrMaximize);
            this.panelHeaderBar.Controls.Add(this.btnTitle);
            this.panelHeaderBar.Controls.Add(this.pbIcon);
            this.panelHeaderBar.Controls.Add(this.pbCancel);
            this.panelHeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderBar.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderBar.Name = "panelHeaderBar";
            this.panelHeaderBar.Size = new System.Drawing.Size(956, 29);
            this.panelHeaderBar.TabIndex = 6;
            this.panelHeaderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeaderBar_MouseDown);
            // 
            // pbRefresh
            // 
            this.pbRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbRefresh.Image = global::BanVeXeKhach.Properties.Resources._5110581;
            this.pbRefresh.Location = new System.Drawing.Point(818, 0);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(32, 29);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefresh.TabIndex = 23;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // pnSpace22
            // 
            this.pnSpace22.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSpace22.Location = new System.Drawing.Point(850, 0);
            this.pnSpace22.Name = "pnSpace22";
            this.pnSpace22.Size = new System.Drawing.Size(10, 29);
            this.pnSpace22.TabIndex = 22;
            // 
            // pbMinimize
            // 
            this.pbMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbMinimize.Image = global::BanVeXeKhach.Properties.Resources.icons8_subtract_80;
            this.pbMinimize.Location = new System.Drawing.Point(860, 0);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(32, 29);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimize.TabIndex = 4;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pbDefaultOrMaximize
            // 
            this.pbDefaultOrMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbDefaultOrMaximize.Image = global::BanVeXeKhach.Properties.Resources.icons8_maximize_button_961;
            this.pbDefaultOrMaximize.Location = new System.Drawing.Point(892, 0);
            this.pbDefaultOrMaximize.Name = "pbDefaultOrMaximize";
            this.pbDefaultOrMaximize.Size = new System.Drawing.Size(32, 29);
            this.pbDefaultOrMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDefaultOrMaximize.TabIndex = 3;
            this.pbDefaultOrMaximize.TabStop = false;
            this.pbDefaultOrMaximize.Click += new System.EventHandler(this.pbDefaultOrMaximize_Click);
            // 
            // btnTitle
            // 
            this.btnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
            this.btnTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTitle.FlatAppearance.BorderSize = 0;
            this.btnTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitle.ForeColor = System.Drawing.Color.White;
            this.btnTitle.Location = new System.Drawing.Point(39, 0);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(302, 29);
            this.btnTitle.TabIndex = 2;
            this.btnTitle.Text = "BÁN VÉ - THÔNG TIN KHÁCH HÀNG";
            this.btnTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTitle.UseVisualStyleBackColor = false;
            // 
            // pbIcon
            // 
            this.pbIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbIcon.Image = global::BanVeXeKhach.Properties.Resources._021_add;
            this.pbIcon.Location = new System.Drawing.Point(0, 0);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(39, 29);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 1;
            this.pbIcon.TabStop = false;
            // 
            // pbCancel
            // 
            this.pbCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbCancel.Image = ((System.Drawing.Image)(resources.GetObject("pbCancel.Image")));
            this.pbCancel.Location = new System.Drawing.Point(924, 0);
            this.pbCancel.Name = "pbCancel";
            this.pbCancel.Size = new System.Drawing.Size(32, 29);
            this.pbCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCancel.TabIndex = 0;
            this.pbCancel.TabStop = false;
            this.pbCancel.Click += new System.EventHandler(this.pbCancel_Click);
            // 
            // pnSpace2
            // 
            this.pnSpace2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSpace2.Location = new System.Drawing.Point(939, 29);
            this.pnSpace2.Name = "pnSpace2";
            this.pnSpace2.Size = new System.Drawing.Size(17, 546);
            this.pnSpace2.TabIndex = 10;
            // 
            // pnSpace1
            // 
            this.pnSpace1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSpace1.Location = new System.Drawing.Point(0, 29);
            this.pnSpace1.Name = "pnSpace1";
            this.pnSpace1.Size = new System.Drawing.Size(13, 546);
            this.pnSpace1.TabIndex = 9;
            // 
            // pnSpace4
            // 
            this.pnSpace4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnSpace4.Location = new System.Drawing.Point(13, 561);
            this.pnSpace4.Name = "pnSpace4";
            this.pnSpace4.Size = new System.Drawing.Size(926, 14);
            this.pnSpace4.TabIndex = 12;
            // 
            // pnSpace3
            // 
            this.pnSpace3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSpace3.Location = new System.Drawing.Point(13, 29);
            this.pnSpace3.Name = "pnSpace3";
            this.pnSpace3.Size = new System.Drawing.Size(926, 14);
            this.pnSpace3.TabIndex = 11;
            // 
            // pnMainWorkArea
            // 
            this.pnMainWorkArea.BackColor = System.Drawing.Color.White;
            this.pnMainWorkArea.Controls.Add(this.dgvCustomerList);
            this.pnMainWorkArea.Controls.Add(this.pnDataManager);
            this.pnMainWorkArea.Controls.Add(this.pnSpace6);
            this.pnMainWorkArea.Controls.Add(this.pnSpace5);
            this.pnMainWorkArea.Controls.Add(this.pnSearch);
            this.pnMainWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMainWorkArea.Location = new System.Drawing.Point(13, 43);
            this.pnMainWorkArea.Name = "pnMainWorkArea";
            this.pnMainWorkArea.Size = new System.Drawing.Size(926, 518);
            this.pnMainWorkArea.TabIndex = 13;
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
            this.dgvCustomerList.Location = new System.Drawing.Point(0, 63);
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.RowHeadersWidth = 51;
            this.dgvCustomerList.RowTemplate.Height = 24;
            this.dgvCustomerList.Size = new System.Drawing.Size(926, 297);
            this.dgvCustomerList.TabIndex = 33;
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
            // pnDataManager
            // 
            this.pnDataManager.Controls.Add(this.pnDataManager_Layer2);
            this.pnDataManager.Controls.Add(this.pnSpace7);
            this.pnDataManager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnDataManager.Location = new System.Drawing.Point(0, 360);
            this.pnDataManager.Name = "pnDataManager";
            this.pnDataManager.Size = new System.Drawing.Size(926, 158);
            this.pnDataManager.TabIndex = 32;
            // 
            // pnDataManager_Layer2
            // 
            this.pnDataManager_Layer2.Controls.Add(this.dtpCustomerBirthday);
            this.pnDataManager_Layer2.Controls.Add(this.btnSelectCustomer);
            this.pnDataManager_Layer2.Controls.Add(this.txtID);
            this.pnDataManager_Layer2.Controls.Add(this.lbID);
            this.pnDataManager_Layer2.Controls.Add(this.btnSave);
            this.pnDataManager_Layer2.Controls.Add(this.btnCreate);
            this.pnDataManager_Layer2.Controls.Add(this.txtCustomerAddress);
            this.pnDataManager_Layer2.Controls.Add(this.lbCustomerAddress);
            this.pnDataManager_Layer2.Controls.Add(this.lbCustomerBirthday);
            this.pnDataManager_Layer2.Controls.Add(this.txtCustomerEmail);
            this.pnDataManager_Layer2.Controls.Add(this.lbCustomerEmail);
            this.pnDataManager_Layer2.Controls.Add(this.txtCustomerPhone);
            this.pnDataManager_Layer2.Controls.Add(this.lbCustomerPhone);
            this.pnDataManager_Layer2.Controls.Add(this.txtCustomerName);
            this.pnDataManager_Layer2.Controls.Add(this.lbCustomerName);
            this.pnDataManager_Layer2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnDataManager_Layer2.Location = new System.Drawing.Point(10, 0);
            this.pnDataManager_Layer2.Name = "pnDataManager_Layer2";
            this.pnDataManager_Layer2.Size = new System.Drawing.Size(906, 158);
            this.pnDataManager_Layer2.TabIndex = 1;
            // 
            // dtpCustomerBirthday
            // 
            this.dtpCustomerBirthday.Location = new System.Drawing.Point(617, 42);
            this.dtpCustomerBirthday.Name = "dtpCustomerBirthday";
            this.dtpCustomerBirthday.Size = new System.Drawing.Size(283, 22);
            this.dtpCustomerBirthday.TabIndex = 51;
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSelectCustomer.FlatAppearance.BorderSize = 0;
            this.btnSelectCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectCustomer.Location = new System.Drawing.Point(740, 117);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(160, 35);
            this.btnSelectCustomer.TabIndex = 50;
            this.btnSelectCustomer.Text = "Chọn khách hàng";
            this.btnSelectCustomer.UseVisualStyleBackColor = false;
            this.btnSelectCustomer.Click += new System.EventHandler(this.btnSelectCustomer_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Linen;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(159, 11);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(283, 19);
            this.txtID.TabIndex = 49;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(3, 11);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(127, 20);
            this.lbID.TabIndex = 48;
            this.lbID.Text = "Mã khách hàng:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(617, 117);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 35);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(483, 117);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(126, 35);
            this.btnCreate.TabIndex = 44;
            this.btnCreate.Text = "Tạo mới";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.BackColor = System.Drawing.Color.Linen;
            this.txtCustomerAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerAddress.Location = new System.Drawing.Point(617, 78);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(283, 19);
            this.txtCustomerAddress.TabIndex = 43;
            // 
            // lbCustomerAddress
            // 
            this.lbCustomerAddress.AutoSize = true;
            this.lbCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerAddress.Location = new System.Drawing.Point(479, 77);
            this.lbCustomerAddress.Name = "lbCustomerAddress";
            this.lbCustomerAddress.Size = new System.Drawing.Size(66, 20);
            this.lbCustomerAddress.TabIndex = 42;
            this.lbCustomerAddress.Text = "Địa chỉ:";
            // 
            // lbCustomerBirthday
            // 
            this.lbCustomerBirthday.AutoSize = true;
            this.lbCustomerBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerBirthday.Location = new System.Drawing.Point(479, 44);
            this.lbCustomerBirthday.Name = "lbCustomerBirthday";
            this.lbCustomerBirthday.Size = new System.Drawing.Size(88, 20);
            this.lbCustomerBirthday.TabIndex = 40;
            this.lbCustomerBirthday.Text = "Ngày sinh:";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.BackColor = System.Drawing.Color.Linen;
            this.txtCustomerEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerEmail.Location = new System.Drawing.Point(617, 11);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(283, 19);
            this.txtCustomerEmail.TabIndex = 39;
            // 
            // lbCustomerEmail
            // 
            this.lbCustomerEmail.AutoSize = true;
            this.lbCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerEmail.Location = new System.Drawing.Point(479, 10);
            this.lbCustomerEmail.Name = "lbCustomerEmail";
            this.lbCustomerEmail.Size = new System.Drawing.Size(56, 20);
            this.lbCustomerEmail.TabIndex = 38;
            this.lbCustomerEmail.Text = "Email:";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.BackColor = System.Drawing.Color.Linen;
            this.txtCustomerPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhone.Location = new System.Drawing.Point(159, 77);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(283, 19);
            this.txtCustomerPhone.TabIndex = 37;
            // 
            // lbCustomerPhone
            // 
            this.lbCustomerPhone.AutoSize = true;
            this.lbCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerPhone.Location = new System.Drawing.Point(3, 77);
            this.lbCustomerPhone.Name = "lbCustomerPhone";
            this.lbCustomerPhone.Size = new System.Drawing.Size(111, 20);
            this.lbCustomerPhone.TabIndex = 36;
            this.lbCustomerPhone.Text = "Số điện thoại:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.Linen;
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(159, 44);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(283, 19);
            this.txtCustomerName.TabIndex = 35;
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerName.Location = new System.Drawing.Point(3, 44);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(132, 20);
            this.lbCustomerName.TabIndex = 34;
            this.lbCustomerName.Text = "Tên khách hàng:";
            // 
            // pnSpace7
            // 
            this.pnSpace7.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSpace7.Location = new System.Drawing.Point(916, 0);
            this.pnSpace7.Name = "pnSpace7";
            this.pnSpace7.Size = new System.Drawing.Size(10, 158);
            this.pnSpace7.TabIndex = 0;
            // 
            // pnSpace6
            // 
            this.pnSpace6.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSpace6.Location = new System.Drawing.Point(0, 53);
            this.pnSpace6.Name = "pnSpace6";
            this.pnSpace6.Size = new System.Drawing.Size(926, 10);
            this.pnSpace6.TabIndex = 31;
            // 
            // pnSpace5
            // 
            this.pnSpace5.BackColor = System.Drawing.Color.Bisque;
            this.pnSpace5.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSpace5.Location = new System.Drawing.Point(0, 43);
            this.pnSpace5.Name = "pnSpace5";
            this.pnSpace5.Size = new System.Drawing.Size(926, 10);
            this.pnSpace5.TabIndex = 30;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.cbSearchSelection);
            this.pnSearch.Controls.Add(this.btnSearch);
            this.pnSearch.Controls.Add(this.txtSearch);
            this.pnSearch.Controls.Add(this.lbSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearch.Location = new System.Drawing.Point(0, 0);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(926, 43);
            this.pnSearch.TabIndex = 0;
            // 
            // cbSearchSelection
            // 
            this.cbSearchSelection.BackColor = System.Drawing.Color.Linen;
            this.cbSearchSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSearchSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchSelection.FormattingEnabled = true;
            this.cbSearchSelection.Location = new System.Drawing.Point(549, 10);
            this.cbSearchSelection.Name = "cbSearchSelection";
            this.cbSearchSelection.Size = new System.Drawing.Size(256, 24);
            this.cbSearchSelection.TabIndex = 51;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(811, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 31);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Thực hiện";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Linen;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(94, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(449, 21);
            this.txtSearch.TabIndex = 17;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(6, 12);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(82, 20);
            this.lbSearch.TabIndex = 16;
            this.lbSearch.Text = "Tìm kiếm:";
            // 
            // SearchOrCreateCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 575);
            this.Controls.Add(this.pnMainWorkArea);
            this.Controls.Add(this.pnSpace4);
            this.Controls.Add(this.pnSpace3);
            this.Controls.Add(this.pnSpace2);
            this.Controls.Add(this.pnSpace1);
            this.Controls.Add(this.panelHeaderBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchOrCreateCustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.SearchOrCreateCustomerForm_Load);
            this.panelHeaderBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefaultOrMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).EndInit();
            this.pnMainWorkArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            this.pnDataManager.ResumeLayout(false);
            this.pnDataManager_Layer2.ResumeLayout(false);
            this.pnDataManager_Layer2.PerformLayout();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeaderBar;
        private System.Windows.Forms.PictureBox pbRefresh;
        private System.Windows.Forms.Panel pnSpace22;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbDefaultOrMaximize;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.PictureBox pbCancel;
        private System.Windows.Forms.Panel pnSpace2;
        private System.Windows.Forms.Panel pnSpace1;
        private System.Windows.Forms.Panel pnSpace4;
        private System.Windows.Forms.Panel pnSpace3;
        private System.Windows.Forms.Panel pnMainWorkArea;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Panel pnSpace5;
        private System.Windows.Forms.DataGridView dgvCustomerList;
        private System.Windows.Forms.Panel pnDataManager;
        private System.Windows.Forms.Panel pnSpace6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbSearchSelection;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Panel pnDataManager_Layer2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label lbCustomerAddress;
        private System.Windows.Forms.Label lbCustomerBirthday;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label lbCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label lbCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Panel pnSpace7;
        private System.Windows.Forms.Button btnSelectCustomer;
        private System.Windows.Forms.DateTimePicker dtpCustomerBirthday;
    }
}