
namespace BanVeXeKhach.UserControls
{
    partial class UcVehicleManager
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
            this.pnSpace3 = new System.Windows.Forms.Panel();
            this.pnSpace1 = new System.Windows.Forms.Panel();
            this.pnSpace2 = new System.Windows.Forms.Panel();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lbList = new System.Windows.Forms.Label();
            this.lbTool = new System.Windows.Forms.Label();
            this.pnSpace4 = new System.Windows.Forms.Panel();
            this.pnTool = new System.Windows.Forms.Panel();
            this.pnDataManager = new System.Windows.Forms.Panel();
            this.txtVehicleName = new System.Windows.Forms.TextBox();
            this.lbVehicleName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.lbLicensePlate = new System.Windows.Forms.Label();
            this.txtSeatNumber = new System.Windows.Forms.TextBox();
            this.lbSeatNumber = new System.Windows.Forms.Label();
            this.txtVehicleDescription = new System.Windows.Forms.TextBox();
            this.lbVehicleDescription = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnAdvancedEditingForm = new System.Windows.Forms.Button();
            this.lbDataManager = new System.Windows.Forms.Label();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.xuiRadio_SearchByLicensePlate = new XanderUI.XUIRadio();
            this.xuiRadio_SearchBySeatNumber = new XanderUI.XUIRadio();
            this.xuiRadio_SearchByVehicleName = new XanderUI.XUIRadio();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSeacrh = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.pnSpace5 = new System.Windows.Forms.Panel();
            this.pnSpace6 = new System.Windows.Forms.Panel();
            this.lbVehicleNumber = new System.Windows.Forms.Label();
            this.pnStatistics = new System.Windows.Forms.Panel();
            this.pnList = new System.Windows.Forms.Panel();
            this.dgvVehicleList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensePlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnHeader.SuspendLayout();
            this.pnTool.SuspendLayout();
            this.pnDataManager.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnStatistics.SuspendLayout();
            this.pnList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSpace3
            // 
            this.pnSpace3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnSpace3.Location = new System.Drawing.Point(10, 548);
            this.pnSpace3.Name = "pnSpace3";
            this.pnSpace3.Size = new System.Drawing.Size(1019, 10);
            this.pnSpace3.TabIndex = 38;
            // 
            // pnSpace1
            // 
            this.pnSpace1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSpace1.Location = new System.Drawing.Point(0, 0);
            this.pnSpace1.Name = "pnSpace1";
            this.pnSpace1.Size = new System.Drawing.Size(10, 558);
            this.pnSpace1.TabIndex = 36;
            // 
            // pnSpace2
            // 
            this.pnSpace2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSpace2.Location = new System.Drawing.Point(1029, 0);
            this.pnSpace2.Name = "pnSpace2";
            this.pnSpace2.Size = new System.Drawing.Size(10, 558);
            this.pnSpace2.TabIndex = 37;
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.lbList);
            this.pnHeader.Controls.Add(this.lbTool);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(10, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1019, 37);
            this.pnHeader.TabIndex = 39;
            // 
            // lbList
            // 
            this.lbList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbList.Location = new System.Drawing.Point(0, 0);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(641, 37);
            this.lbList.TabIndex = 15;
            this.lbList.Text = "DANH SÁCH XE";
            this.lbList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTool
            // 
            this.lbTool.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTool.Location = new System.Drawing.Point(641, 0);
            this.lbTool.Name = "lbTool";
            this.lbTool.Size = new System.Drawing.Size(378, 37);
            this.lbTool.TabIndex = 13;
            this.lbTool.Text = "CÁC CHỨC NĂNG";
            this.lbTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnSpace4
            // 
            this.pnSpace4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSpace4.Location = new System.Drawing.Point(10, 37);
            this.pnSpace4.Name = "pnSpace4";
            this.pnSpace4.Size = new System.Drawing.Size(1019, 10);
            this.pnSpace4.TabIndex = 40;
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
            this.pnTool.TabIndex = 41;
            // 
            // pnDataManager
            // 
            this.pnDataManager.Controls.Add(this.txtVehicleName);
            this.pnDataManager.Controls.Add(this.lbVehicleName);
            this.pnDataManager.Controls.Add(this.txtID);
            this.pnDataManager.Controls.Add(this.lbID);
            this.pnDataManager.Controls.Add(this.btnSave);
            this.pnDataManager.Controls.Add(this.txtLicensePlate);
            this.pnDataManager.Controls.Add(this.lbLicensePlate);
            this.pnDataManager.Controls.Add(this.txtSeatNumber);
            this.pnDataManager.Controls.Add(this.lbSeatNumber);
            this.pnDataManager.Controls.Add(this.txtVehicleDescription);
            this.pnDataManager.Controls.Add(this.lbVehicleDescription);
            this.pnDataManager.Controls.Add(this.btnDelete);
            this.pnDataManager.Controls.Add(this.btnUpdate);
            this.pnDataManager.Controls.Add(this.btnCreate);
            this.pnDataManager.Controls.Add(this.btnAdvancedEditingForm);
            this.pnDataManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDataManager.Location = new System.Drawing.Point(0, 183);
            this.pnDataManager.Name = "pnDataManager";
            this.pnDataManager.Size = new System.Drawing.Size(378, 295);
            this.pnDataManager.TabIndex = 16;
            // 
            // txtVehicleName
            // 
            this.txtVehicleName.BackColor = System.Drawing.Color.Linen;
            this.txtVehicleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVehicleName.Enabled = false;
            this.txtVehicleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleName.Location = new System.Drawing.Point(102, 49);
            this.txtVehicleName.Name = "txtVehicleName";
            this.txtVehicleName.Size = new System.Drawing.Size(270, 19);
            this.txtVehicleName.TabIndex = 15;
            // 
            // lbVehicleName
            // 
            this.lbVehicleName.AutoSize = true;
            this.lbVehicleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVehicleName.Location = new System.Drawing.Point(6, 48);
            this.lbVehicleName.Name = "lbVehicleName";
            this.lbVehicleName.Size = new System.Drawing.Size(64, 20);
            this.lbVehicleName.TabIndex = 14;
            this.lbVehicleName.Text = "Tên xe:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Linen;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(102, 15);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(270, 19);
            this.txtID.TabIndex = 13;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(6, 14);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(31, 20);
            this.lbID.TabIndex = 12;
            this.lbID.Text = "ID:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(256, 252);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 35);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.BackColor = System.Drawing.Color.Linen;
            this.txtLicensePlate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLicensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicensePlate.Location = new System.Drawing.Point(102, 152);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(270, 19);
            this.txtLicensePlate.TabIndex = 10;
            // 
            // lbLicensePlate
            // 
            this.lbLicensePlate.AutoSize = true;
            this.lbLicensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicensePlate.Location = new System.Drawing.Point(6, 151);
            this.lbLicensePlate.Name = "lbLicensePlate";
            this.lbLicensePlate.Size = new System.Drawing.Size(71, 20);
            this.lbLicensePlate.TabIndex = 9;
            this.lbLicensePlate.Text = "Biển số:";
            // 
            // txtSeatNumber
            // 
            this.txtSeatNumber.BackColor = System.Drawing.Color.Linen;
            this.txtSeatNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeatNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeatNumber.Location = new System.Drawing.Point(102, 117);
            this.txtSeatNumber.Name = "txtSeatNumber";
            this.txtSeatNumber.Size = new System.Drawing.Size(270, 19);
            this.txtSeatNumber.TabIndex = 8;
            // 
            // lbSeatNumber
            // 
            this.lbSeatNumber.AutoSize = true;
            this.lbSeatNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeatNumber.Location = new System.Drawing.Point(6, 116);
            this.lbSeatNumber.Name = "lbSeatNumber";
            this.lbSeatNumber.Size = new System.Drawing.Size(66, 20);
            this.lbSeatNumber.TabIndex = 7;
            this.lbSeatNumber.Text = "Số ghế:";
            // 
            // txtVehicleDescription
            // 
            this.txtVehicleDescription.BackColor = System.Drawing.Color.Linen;
            this.txtVehicleDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVehicleDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleDescription.Location = new System.Drawing.Point(102, 83);
            this.txtVehicleDescription.Name = "txtVehicleDescription";
            this.txtVehicleDescription.Size = new System.Drawing.Size(270, 19);
            this.txtVehicleDescription.TabIndex = 6;
            // 
            // lbVehicleDescription
            // 
            this.lbVehicleDescription.AutoSize = true;
            this.lbVehicleDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVehicleDescription.Location = new System.Drawing.Point(6, 82);
            this.lbVehicleDescription.Name = "lbVehicleDescription";
            this.lbVehicleDescription.Size = new System.Drawing.Size(56, 20);
            this.lbVehicleDescription.TabIndex = 5;
            this.lbVehicleDescription.Text = "Mô tả:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(256, 189);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(138, 189);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 35);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Chỉnh sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(6, 189);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(126, 35);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Tạo mới";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnAdvancedEditingForm
            // 
            this.btnAdvancedEditingForm.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAdvancedEditingForm.FlatAppearance.BorderSize = 0;
            this.btnAdvancedEditingForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvancedEditingForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvancedEditingForm.Location = new System.Drawing.Point(6, 252);
            this.btnAdvancedEditingForm.Name = "btnAdvancedEditingForm";
            this.btnAdvancedEditingForm.Size = new System.Drawing.Size(244, 35);
            this.btnAdvancedEditingForm.TabIndex = 1;
            this.btnAdvancedEditingForm.Text = "Biểu mẫu chỉnh sửa nâng cao";
            this.btnAdvancedEditingForm.UseVisualStyleBackColor = false;
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
            this.pnSearch.Controls.Add(this.xuiRadio_SearchByLicensePlate);
            this.pnSearch.Controls.Add(this.xuiRadio_SearchBySeatNumber);
            this.pnSearch.Controls.Add(this.xuiRadio_SearchByVehicleName);
            this.pnSearch.Controls.Add(this.txtSearch);
            this.pnSearch.Controls.Add(this.btnSeacrh);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearch.Location = new System.Drawing.Point(0, 32);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(378, 119);
            this.pnSearch.TabIndex = 14;
            // 
            // xuiRadio_SearchByLicensePlate
            // 
            this.xuiRadio_SearchByLicensePlate.Checked = false;
            this.xuiRadio_SearchByLicensePlate.ForeColor = System.Drawing.Color.Black;
            this.xuiRadio_SearchByLicensePlate.Location = new System.Drawing.Point(243, 55);
            this.xuiRadio_SearchByLicensePlate.Name = "xuiRadio_SearchByLicensePlate";
            this.xuiRadio_SearchByLicensePlate.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuiRadio_SearchByLicensePlate.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiRadio_SearchByLicensePlate.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.xuiRadio_SearchByLicensePlate.Size = new System.Drawing.Size(116, 16);
            this.xuiRadio_SearchByLicensePlate.TabIndex = 5;
            this.xuiRadio_SearchByLicensePlate.Text = "Theo biển số";
            // 
            // xuiRadio_SearchBySeatNumber
            // 
            this.xuiRadio_SearchBySeatNumber.Checked = false;
            this.xuiRadio_SearchBySeatNumber.ForeColor = System.Drawing.Color.Black;
            this.xuiRadio_SearchBySeatNumber.Location = new System.Drawing.Point(123, 55);
            this.xuiRadio_SearchBySeatNumber.Name = "xuiRadio_SearchBySeatNumber";
            this.xuiRadio_SearchBySeatNumber.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuiRadio_SearchBySeatNumber.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiRadio_SearchBySeatNumber.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.xuiRadio_SearchBySeatNumber.Size = new System.Drawing.Size(114, 16);
            this.xuiRadio_SearchBySeatNumber.TabIndex = 4;
            this.xuiRadio_SearchBySeatNumber.Text = "Theo số ghế";
            // 
            // xuiRadio_SearchByVehicleName
            // 
            this.xuiRadio_SearchByVehicleName.Checked = true;
            this.xuiRadio_SearchByVehicleName.ForeColor = System.Drawing.Color.Black;
            this.xuiRadio_SearchByVehicleName.Location = new System.Drawing.Point(6, 55);
            this.xuiRadio_SearchByVehicleName.Name = "xuiRadio_SearchByVehicleName";
            this.xuiRadio_SearchByVehicleName.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuiRadio_SearchByVehicleName.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiRadio_SearchByVehicleName.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.xuiRadio_SearchByVehicleName.Size = new System.Drawing.Size(111, 16);
            this.xuiRadio_SearchByVehicleName.TabIndex = 3;
            this.xuiRadio_SearchByVehicleName.Text = "Theo tên xe";
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
            // btnSeacrh
            // 
            this.btnSeacrh.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSeacrh.FlatAppearance.BorderSize = 0;
            this.btnSeacrh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeacrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeacrh.Location = new System.Drawing.Point(263, 81);
            this.btnSeacrh.Name = "btnSeacrh";
            this.btnSeacrh.Size = new System.Drawing.Size(109, 35);
            this.btnSeacrh.TabIndex = 0;
            this.btnSeacrh.Text = "Thực hiện";
            this.btnSeacrh.UseVisualStyleBackColor = false;
            this.btnSeacrh.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.pnSpace5.TabIndex = 42;
            // 
            // pnSpace6
            // 
            this.pnSpace6.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSpace6.Location = new System.Drawing.Point(631, 47);
            this.pnSpace6.Name = "pnSpace6";
            this.pnSpace6.Size = new System.Drawing.Size(10, 501);
            this.pnSpace6.TabIndex = 43;
            // 
            // lbVehicleNumber
            // 
            this.lbVehicleNumber.AutoSize = true;
            this.lbVehicleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVehicleNumber.ForeColor = System.Drawing.Color.Red;
            this.lbVehicleNumber.Location = new System.Drawing.Point(6, 24);
            this.lbVehicleNumber.Name = "lbVehicleNumber";
            this.lbVehicleNumber.Size = new System.Drawing.Size(129, 20);
            this.lbVehicleNumber.TabIndex = 14;
            this.lbVehicleNumber.Text = "Số xe hiện có:";
            this.lbVehicleNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnStatistics
            // 
            this.pnStatistics.Controls.Add(this.lbVehicleNumber);
            this.pnStatistics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnStatistics.Location = new System.Drawing.Point(0, 419);
            this.pnStatistics.Name = "pnStatistics";
            this.pnStatistics.Size = new System.Drawing.Size(621, 82);
            this.pnStatistics.TabIndex = 0;
            // 
            // pnList
            // 
            this.pnList.Controls.Add(this.dgvVehicleList);
            this.pnList.Controls.Add(this.pnStatistics);
            this.pnList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnList.Location = new System.Drawing.Point(10, 47);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(621, 501);
            this.pnList.TabIndex = 44;
            // 
            // dgvVehicleList
            // 
            this.dgvVehicleList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.vehicleName,
            this.seatNumber,
            this.licensePlate});
            this.dgvVehicleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVehicleList.Location = new System.Drawing.Point(0, 0);
            this.dgvVehicleList.Name = "dgvVehicleList";
            this.dgvVehicleList.RowHeadersWidth = 51;
            this.dgvVehicleList.RowTemplate.Height = 24;
            this.dgvVehicleList.Size = new System.Drawing.Size(621, 419);
            this.dgvVehicleList.TabIndex = 21;
            this.dgvVehicleList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicleList_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "VehicleId";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // vehicleName
            // 
            this.vehicleName.DataPropertyName = "Name";
            this.vehicleName.HeaderText = "Tên xe";
            this.vehicleName.MinimumWidth = 6;
            this.vehicleName.Name = "vehicleName";
            this.vehicleName.Width = 125;
            // 
            // seatNumber
            // 
            this.seatNumber.DataPropertyName = "SeatNumber";
            this.seatNumber.HeaderText = "Số ghế";
            this.seatNumber.MinimumWidth = 6;
            this.seatNumber.Name = "seatNumber";
            this.seatNumber.Width = 125;
            // 
            // licensePlate
            // 
            this.licensePlate.DataPropertyName = "LicensePlate";
            this.licensePlate.HeaderText = "Biển số";
            this.licensePlate.MinimumWidth = 6;
            this.licensePlate.Name = "licensePlate";
            this.licensePlate.Width = 125;
            // 
            // UcVehicleManager
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
            this.Controls.Add(this.pnSpace1);
            this.Controls.Add(this.pnSpace2);
            this.Name = "UcVehicleManager";
            this.Size = new System.Drawing.Size(1039, 558);
            this.Load += new System.EventHandler(this.UcVehicleManager_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnTool.ResumeLayout(false);
            this.pnDataManager.ResumeLayout(false);
            this.pnDataManager.PerformLayout();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnStatistics.ResumeLayout(false);
            this.pnStatistics.PerformLayout();
            this.pnList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSpace3;
        private System.Windows.Forms.Panel pnSpace1;
        private System.Windows.Forms.Panel pnSpace2;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label lbTool;
        private System.Windows.Forms.Label lbList;
        private System.Windows.Forms.Panel pnSpace4;
        private System.Windows.Forms.Panel pnTool;
        private System.Windows.Forms.Panel pnDataManager;
        private System.Windows.Forms.TextBox txtVehicleName;
        private System.Windows.Forms.Label lbVehicleName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Label lbLicensePlate;
        private System.Windows.Forms.TextBox txtSeatNumber;
        private System.Windows.Forms.Label lbSeatNumber;
        private System.Windows.Forms.TextBox txtVehicleDescription;
        private System.Windows.Forms.Label lbVehicleDescription;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnAdvancedEditingForm;
        private System.Windows.Forms.Label lbDataManager;
        private System.Windows.Forms.Panel pnSearch;
        private XanderUI.XUIRadio xuiRadio_SearchByLicensePlate;
        private XanderUI.XUIRadio xuiRadio_SearchBySeatNumber;
        private XanderUI.XUIRadio xuiRadio_SearchByVehicleName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSeacrh;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Panel pnSpace5;
        private System.Windows.Forms.Panel pnSpace6;
        private System.Windows.Forms.Label lbVehicleNumber;
        private System.Windows.Forms.Panel pnStatistics;
        private System.Windows.Forms.Panel pnList;
        private System.Windows.Forms.DataGridView dgvVehicleList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlate;
    }
}
