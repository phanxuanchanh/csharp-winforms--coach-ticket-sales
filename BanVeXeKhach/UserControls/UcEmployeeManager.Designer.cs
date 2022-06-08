
namespace BanVeXeKhach.UserControls
{
    partial class UcEmployeeManager
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
            this.pnSpace3 = new System.Windows.Forms.Panel();
            this.lbTool = new System.Windows.Forms.Label();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lbList = new System.Windows.Forms.Label();
            this.pnSpace4 = new System.Windows.Forms.Panel();
            this.pnTool = new System.Windows.Forms.Panel();
            this.pnDataManager = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdateToDB = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbDataManager = new System.Windows.Forms.Label();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.xuiRadio_SearchByPhone = new XanderUI.XUIRadio();
            this.xuiRadio_SearchByEmail = new XanderUI.XUIRadio();
            this.xuiRadio_SearchByFullName = new XanderUI.XUIRadio();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.pnSpace5 = new System.Windows.Forms.Panel();
            this.pnSpace2 = new System.Windows.Forms.Panel();
            this.pnSpace6 = new System.Windows.Forms.Panel();
            this.pnList = new System.Windows.Forms.Panel();
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnStatistics = new System.Windows.Forms.Panel();
            this.lbEmployeeNumber = new System.Windows.Forms.Label();
            this.pnHeader.SuspendLayout();
            this.pnTool.SuspendLayout();
            this.pnDataManager.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.pnStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSpace1
            // 
            this.pnSpace1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSpace1.Location = new System.Drawing.Point(0, 0);
            this.pnSpace1.Name = "pnSpace1";
            this.pnSpace1.Size = new System.Drawing.Size(10, 558);
            this.pnSpace1.TabIndex = 8;
            // 
            // pnSpace3
            // 
            this.pnSpace3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnSpace3.Location = new System.Drawing.Point(10, 548);
            this.pnSpace3.Name = "pnSpace3";
            this.pnSpace3.Size = new System.Drawing.Size(1019, 10);
            this.pnSpace3.TabIndex = 11;
            // 
            // lbTool
            // 
            this.lbTool.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTool.Location = new System.Drawing.Point(641, 0);
            this.lbTool.Name = "lbTool";
            this.lbTool.Size = new System.Drawing.Size(378, 37);
            this.lbTool.TabIndex = 12;
            this.lbTool.Text = "CÁC CHỨC NĂNG";
            this.lbTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.lbList);
            this.pnHeader.Controls.Add(this.lbTool);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(10, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1019, 37);
            this.pnHeader.TabIndex = 14;
            // 
            // lbList
            // 
            this.lbList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbList.Location = new System.Drawing.Point(0, 0);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(641, 37);
            this.lbList.TabIndex = 13;
            this.lbList.Text = "DANH SÁCH NHÂN VIÊN";
            this.lbList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnSpace4
            // 
            this.pnSpace4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSpace4.Location = new System.Drawing.Point(10, 37);
            this.pnSpace4.Name = "pnSpace4";
            this.pnSpace4.Size = new System.Drawing.Size(1019, 10);
            this.pnSpace4.TabIndex = 26;
            // 
            // pnTool
            // 
            this.pnTool.Controls.Add(this.pnDataManager);
            this.pnTool.Controls.Add(this.lbDataManager);
            this.pnTool.Controls.Add(this.pnSearch);
            this.pnTool.Controls.Add(this.lbSearch);
            this.pnTool.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnTool.Location = new System.Drawing.Point(651, 47);
            this.pnTool.Name = "pnTool";
            this.pnTool.Size = new System.Drawing.Size(378, 501);
            this.pnTool.TabIndex = 27;
            // 
            // pnDataManager
            // 
            this.pnDataManager.Controls.Add(this.btnCreate);
            this.pnDataManager.Controls.Add(this.btnSave);
            this.pnDataManager.Controls.Add(this.btnUpdateToDB);
            this.pnDataManager.Controls.Add(this.btnDelete);
            this.pnDataManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDataManager.Location = new System.Drawing.Point(0, 183);
            this.pnDataManager.Name = "pnDataManager";
            this.pnDataManager.Size = new System.Drawing.Size(378, 142);
            this.pnDataManager.TabIndex = 16;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(6, 14);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(126, 35);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Tạo mới";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(256, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 35);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdateToDB
            // 
            this.btnUpdateToDB.BackColor = System.Drawing.Color.SandyBrown;
            this.btnUpdateToDB.FlatAppearance.BorderSize = 0;
            this.btnUpdateToDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateToDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateToDB.Location = new System.Drawing.Point(148, 77);
            this.btnUpdateToDB.Name = "btnUpdateToDB";
            this.btnUpdateToDB.Size = new System.Drawing.Size(224, 35);
            this.btnUpdateToDB.TabIndex = 1;
            this.btnUpdateToDB.Text = "Cập nhật vào database";
            this.btnUpdateToDB.UseVisualStyleBackColor = false;
            this.btnUpdateToDB.Click += new System.EventHandler(this.btnUpdateToDB_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(138, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbDataManager
            // 
            this.lbDataManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDataManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataManager.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbDataManager.Location = new System.Drawing.Point(0, 151);
            this.lbDataManager.Name = "lbDataManager";
            this.lbDataManager.Size = new System.Drawing.Size(378, 32);
            this.lbDataManager.TabIndex = 15;
            this.lbDataManager.Text = "Quản lý dữ liệu";
            this.lbDataManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.xuiRadio_SearchByPhone);
            this.pnSearch.Controls.Add(this.xuiRadio_SearchByEmail);
            this.pnSearch.Controls.Add(this.xuiRadio_SearchByFullName);
            this.pnSearch.Controls.Add(this.txtSearch);
            this.pnSearch.Controls.Add(this.btnSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearch.Location = new System.Drawing.Point(0, 32);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(378, 119);
            this.pnSearch.TabIndex = 14;
            // 
            // xuiRadio_SearchByPhone
            // 
            this.xuiRadio_SearchByPhone.Checked = false;
            this.xuiRadio_SearchByPhone.ForeColor = System.Drawing.Color.Black;
            this.xuiRadio_SearchByPhone.Location = new System.Drawing.Point(245, 55);
            this.xuiRadio_SearchByPhone.Name = "xuiRadio_SearchByPhone";
            this.xuiRadio_SearchByPhone.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuiRadio_SearchByPhone.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiRadio_SearchByPhone.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.xuiRadio_SearchByPhone.Size = new System.Drawing.Size(100, 16);
            this.xuiRadio_SearchByPhone.TabIndex = 5;
            this.xuiRadio_SearchByPhone.Text = "Theo SĐT";
            // 
            // xuiRadio_SearchByEmail
            // 
            this.xuiRadio_SearchByEmail.Checked = false;
            this.xuiRadio_SearchByEmail.ForeColor = System.Drawing.Color.Black;
            this.xuiRadio_SearchByEmail.Location = new System.Drawing.Point(126, 55);
            this.xuiRadio_SearchByEmail.Name = "xuiRadio_SearchByEmail";
            this.xuiRadio_SearchByEmail.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuiRadio_SearchByEmail.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiRadio_SearchByEmail.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.xuiRadio_SearchByEmail.Size = new System.Drawing.Size(113, 16);
            this.xuiRadio_SearchByEmail.TabIndex = 4;
            this.xuiRadio_SearchByEmail.Text = "Theo email";
            // 
            // xuiRadio_SearchByFullName
            // 
            this.xuiRadio_SearchByFullName.Checked = true;
            this.xuiRadio_SearchByFullName.ForeColor = System.Drawing.Color.Black;
            this.xuiRadio_SearchByFullName.Location = new System.Drawing.Point(6, 55);
            this.xuiRadio_SearchByFullName.Name = "xuiRadio_SearchByFullName";
            this.xuiRadio_SearchByFullName.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuiRadio_SearchByFullName.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiRadio_SearchByFullName.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.xuiRadio_SearchByFullName.Size = new System.Drawing.Size(114, 16);
            this.xuiRadio_SearchByFullName.TabIndex = 3;
            this.xuiRadio_SearchByFullName.Text = "Theo tên";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Linen;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(6, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(366, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(263, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 35);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Thực hiện";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbSearch
            // 
            this.lbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbSearch.Location = new System.Drawing.Point(0, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(378, 32);
            this.lbSearch.TabIndex = 13;
            this.lbSearch.Text = "Tìm kiếm và lọc";
            this.lbSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnSpace5
            // 
            this.pnSpace5.BackColor = System.Drawing.Color.Bisque;
            this.pnSpace5.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSpace5.Location = new System.Drawing.Point(641, 47);
            this.pnSpace5.Name = "pnSpace5";
            this.pnSpace5.Size = new System.Drawing.Size(10, 501);
            this.pnSpace5.TabIndex = 28;
            // 
            // pnSpace2
            // 
            this.pnSpace2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSpace2.Location = new System.Drawing.Point(1029, 0);
            this.pnSpace2.Name = "pnSpace2";
            this.pnSpace2.Size = new System.Drawing.Size(10, 558);
            this.pnSpace2.TabIndex = 9;
            // 
            // pnSpace6
            // 
            this.pnSpace6.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSpace6.Location = new System.Drawing.Point(631, 47);
            this.pnSpace6.Name = "pnSpace6";
            this.pnSpace6.Size = new System.Drawing.Size(10, 501);
            this.pnSpace6.TabIndex = 29;
            // 
            // pnList
            // 
            this.pnList.Controls.Add(this.dgvEmployeeList);
            this.pnList.Controls.Add(this.pnStatistics);
            this.pnList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnList.Location = new System.Drawing.Point(10, 47);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(621, 501);
            this.pnList.TabIndex = 31;
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.AllowUserToAddRows = false;
            this.dgvEmployeeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.FullName,
            this.Phone,
            this.email,
            this.Title});
            this.dgvEmployeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeeList.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.ReadOnly = true;
            this.dgvEmployeeList.RowHeadersWidth = 51;
            this.dgvEmployeeList.RowTemplate.Height = 24;
            this.dgvEmployeeList.Size = new System.Drawing.Size(621, 419);
            this.dgvEmployeeList.TabIndex = 18;
            this.dgvEmployeeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffList_CellContentClick);
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "EmployeeId";
            this.EmployeeId.HeaderText = "ID";
            this.EmployeeId.MinimumWidth = 6;
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            this.EmployeeId.Width = 125;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Tên khách hàng";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 125;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "SĐT";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 125;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Chức Danh";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 125;
            // 
            // pnStatistics
            // 
            this.pnStatistics.Controls.Add(this.lbEmployeeNumber);
            this.pnStatistics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnStatistics.Location = new System.Drawing.Point(0, 419);
            this.pnStatistics.Name = "pnStatistics";
            this.pnStatistics.Size = new System.Drawing.Size(621, 82);
            this.pnStatistics.TabIndex = 0;
            // 
            // lbEmployeeNumber
            // 
            this.lbEmployeeNumber.AutoSize = true;
            this.lbEmployeeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployeeNumber.ForeColor = System.Drawing.Color.Red;
            this.lbEmployeeNumber.Location = new System.Drawing.Point(6, 26);
            this.lbEmployeeNumber.Name = "lbEmployeeNumber";
            this.lbEmployeeNumber.Size = new System.Drawing.Size(190, 20);
            this.lbEmployeeNumber.TabIndex = 15;
            this.lbEmployeeNumber.Text = "Số nhân viên hiện có:";
            this.lbEmployeeNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UcEmployeeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnList);
            this.Controls.Add(this.pnSpace6);
            this.Controls.Add(this.pnSpace5);
            this.Controls.Add(this.pnTool);
            this.Controls.Add(this.pnSpace4);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.pnSpace3);
            this.Controls.Add(this.pnSpace2);
            this.Controls.Add(this.pnSpace1);
            this.Name = "UcEmployeeManager";
            this.Size = new System.Drawing.Size(1039, 558);
            this.Load += new System.EventHandler(this.UcEmployeeManager_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnTool.ResumeLayout(false);
            this.pnDataManager.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.pnStatistics.ResumeLayout(false);
            this.pnStatistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnSpace1;
        private System.Windows.Forms.Panel pnSpace3;
        private System.Windows.Forms.Label lbTool;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnSpace4;
        private System.Windows.Forms.Panel pnTool;
        private System.Windows.Forms.Panel pnSpace5;
        private System.Windows.Forms.Label lbList;
        private System.Windows.Forms.Panel pnDataManager;
        private System.Windows.Forms.Label lbDataManager;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Panel pnSpace2;
        private System.Windows.Forms.Panel pnSpace6;
        private System.Windows.Forms.Panel pnList;
        private System.Windows.Forms.Panel pnStatistics;
        private System.Windows.Forms.Label lbEmployeeNumber;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdateToDB;
        private XanderUI.XUIRadio xuiRadio_SearchByPhone;
        private XanderUI.XUIRadio xuiRadio_SearchByEmail;
        private XanderUI.XUIRadio xuiRadio_SearchByFullName;
        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
    }
}
