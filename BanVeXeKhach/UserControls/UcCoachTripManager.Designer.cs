
namespace BanVeXeKhach.UserControls
{
    partial class UcCoachTripManager
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
            this.xuiRadio_SearchByStartTime = new XanderUI.XUIRadio();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.pnSpace5 = new System.Windows.Forms.Panel();
            this.xuiRadio_SearchByCoachTripName = new XanderUI.XUIRadio();
            this.txtCoachTripName = new System.Windows.Forms.TextBox();
            this.lbCoachTripName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbArrivalDate = new System.Windows.Forms.Label();
            this.lbDepartureDate = new System.Windows.Forms.Label();
            this.lbRoute = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbDataManager = new System.Windows.Forms.Label();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.xuiRadio_SearchByEndTime = new XanderUI.XUIRadio();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnAdvancedEditingForm = new System.Windows.Forms.Button();
            this.pnDataManager = new System.Windows.Forms.Panel();
            this.dtpArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.lbCoach = new System.Windows.Forms.Label();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.cbVehicle = new System.Windows.Forms.ComboBox();
            this.cbCoachTripStatus = new System.Windows.Forms.ComboBox();
            this.lbCoachTripStatus = new System.Windows.Forms.Label();
            this.cbRoute = new System.Windows.Forms.ComboBox();
            this.pnTool = new System.Windows.Forms.Panel();
            this.pnSpace4 = new System.Windows.Forms.Panel();
            this.lbList = new System.Windows.Forms.Label();
            this.lbTool = new System.Windows.Forms.Label();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pnSpace3 = new System.Windows.Forms.Panel();
            this.pnSpace1 = new System.Windows.Forms.Panel();
            this.pnSpace2 = new System.Windows.Forms.Panel();
            this.pnSpace6 = new System.Windows.Forms.Panel();
            this.pnList = new System.Windows.Forms.Panel();
            this.dgvCoachTripList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoachTripName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnStatistics = new System.Windows.Forms.Panel();
            this.lbCoachTripNumber = new System.Windows.Forms.Label();
            this.pnSearch.SuspendLayout();
            this.pnDataManager.SuspendLayout();
            this.pnTool.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.pnList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoachTripList)).BeginInit();
            this.pnStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiRadio_SearchByStartTime
            // 
            this.xuiRadio_SearchByStartTime.Checked = false;
            this.xuiRadio_SearchByStartTime.ForeColor = System.Drawing.Color.Black;
            this.xuiRadio_SearchByStartTime.Location = new System.Drawing.Point(161, 55);
            this.xuiRadio_SearchByStartTime.Name = "xuiRadio_SearchByStartTime";
            this.xuiRadio_SearchByStartTime.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuiRadio_SearchByStartTime.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiRadio_SearchByStartTime.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.xuiRadio_SearchByStartTime.Size = new System.Drawing.Size(112, 16);
            this.xuiRadio_SearchByStartTime.TabIndex = 4;
            this.xuiRadio_SearchByStartTime.Text = "Theo TG đi";
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
            this.pnSpace5.TabIndex = 39;
            // 
            // xuiRadio_SearchByCoachTripName
            // 
            this.xuiRadio_SearchByCoachTripName.Checked = true;
            this.xuiRadio_SearchByCoachTripName.ForeColor = System.Drawing.Color.Black;
            this.xuiRadio_SearchByCoachTripName.Location = new System.Drawing.Point(6, 55);
            this.xuiRadio_SearchByCoachTripName.Name = "xuiRadio_SearchByCoachTripName";
            this.xuiRadio_SearchByCoachTripName.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuiRadio_SearchByCoachTripName.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiRadio_SearchByCoachTripName.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.xuiRadio_SearchByCoachTripName.Size = new System.Drawing.Size(149, 16);
            this.xuiRadio_SearchByCoachTripName.TabIndex = 3;
            this.xuiRadio_SearchByCoachTripName.Text = "Theo tên chuyến";
            // 
            // txtCoachTripName
            // 
            this.txtCoachTripName.BackColor = System.Drawing.Color.Linen;
            this.txtCoachTripName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCoachTripName.Enabled = false;
            this.txtCoachTripName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoachTripName.Location = new System.Drawing.Point(118, 40);
            this.txtCoachTripName.Name = "txtCoachTripName";
            this.txtCoachTripName.Size = new System.Drawing.Size(254, 19);
            this.txtCoachTripName.TabIndex = 15;
            // 
            // lbCoachTripName
            // 
            this.lbCoachTripName.AutoSize = true;
            this.lbCoachTripName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoachTripName.Location = new System.Drawing.Point(6, 39);
            this.lbCoachTripName.Name = "lbCoachTripName";
            this.lbCoachTripName.Size = new System.Drawing.Size(100, 20);
            this.lbCoachTripName.TabIndex = 14;
            this.lbCoachTripName.Text = "Tên chuyến:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Linen;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(118, 15);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(254, 19);
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
            this.btnSave.Location = new System.Drawing.Point(256, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 35);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbArrivalDate
            // 
            this.lbArrivalDate.AutoSize = true;
            this.lbArrivalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArrivalDate.Location = new System.Drawing.Point(6, 119);
            this.lbArrivalDate.Name = "lbArrivalDate";
            this.lbArrivalDate.Size = new System.Drawing.Size(69, 20);
            this.lbArrivalDate.TabIndex = 9;
            this.lbArrivalDate.Text = "TG đến:";
            // 
            // lbDepartureDate
            // 
            this.lbDepartureDate.AutoSize = true;
            this.lbDepartureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartureDate.Location = new System.Drawing.Point(6, 94);
            this.lbDepartureDate.Name = "lbDepartureDate";
            this.lbDepartureDate.Size = new System.Drawing.Size(55, 20);
            this.lbDepartureDate.TabIndex = 7;
            this.lbDepartureDate.Text = "TG đi:";
            // 
            // lbRoute
            // 
            this.lbRoute.AutoSize = true;
            this.lbRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoute.Location = new System.Drawing.Point(6, 65);
            this.lbRoute.Name = "lbRoute";
            this.lbRoute.Size = new System.Drawing.Size(59, 20);
            this.lbRoute.TabIndex = 5;
            this.lbRoute.Text = "Tuyến:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(256, 214);
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
            this.btnUpdate.Location = new System.Drawing.Point(138, 214);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 35);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Chỉnh sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.pnSearch.Controls.Add(this.xuiRadio_SearchByEndTime);
            this.pnSearch.Controls.Add(this.xuiRadio_SearchByStartTime);
            this.pnSearch.Controls.Add(this.xuiRadio_SearchByCoachTripName);
            this.pnSearch.Controls.Add(this.txtSearch);
            this.pnSearch.Controls.Add(this.btnSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearch.Location = new System.Drawing.Point(0, 32);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(378, 119);
            this.pnSearch.TabIndex = 14;
            // 
            // xuiRadio_SearchByEndTime
            // 
            this.xuiRadio_SearchByEndTime.Checked = false;
            this.xuiRadio_SearchByEndTime.ForeColor = System.Drawing.Color.Black;
            this.xuiRadio_SearchByEndTime.Location = new System.Drawing.Point(6, 90);
            this.xuiRadio_SearchByEndTime.Name = "xuiRadio_SearchByEndTime";
            this.xuiRadio_SearchByEndTime.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuiRadio_SearchByEndTime.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiRadio_SearchByEndTime.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.xuiRadio_SearchByEndTime.Size = new System.Drawing.Size(133, 16);
            this.xuiRadio_SearchByEndTime.TabIndex = 5;
            this.xuiRadio_SearchByEndTime.Text = "Theo TG đến";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(6, 214);
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
            this.btnAdvancedEditingForm.Location = new System.Drawing.Point(6, 255);
            this.btnAdvancedEditingForm.Name = "btnAdvancedEditingForm";
            this.btnAdvancedEditingForm.Size = new System.Drawing.Size(244, 35);
            this.btnAdvancedEditingForm.TabIndex = 1;
            this.btnAdvancedEditingForm.Text = "Biểu mẫu chỉnh sửa nâng cao";
            this.btnAdvancedEditingForm.UseVisualStyleBackColor = false;
            // 
            // pnDataManager
            // 
            this.pnDataManager.Controls.Add(this.dtpArrivalDate);
            this.pnDataManager.Controls.Add(this.lbCoach);
            this.pnDataManager.Controls.Add(this.dtpDepartureDate);
            this.pnDataManager.Controls.Add(this.btnAdvancedEditingForm);
            this.pnDataManager.Controls.Add(this.cbVehicle);
            this.pnDataManager.Controls.Add(this.cbCoachTripStatus);
            this.pnDataManager.Controls.Add(this.lbCoachTripStatus);
            this.pnDataManager.Controls.Add(this.cbRoute);
            this.pnDataManager.Controls.Add(this.txtCoachTripName);
            this.pnDataManager.Controls.Add(this.lbCoachTripName);
            this.pnDataManager.Controls.Add(this.txtID);
            this.pnDataManager.Controls.Add(this.lbID);
            this.pnDataManager.Controls.Add(this.btnSave);
            this.pnDataManager.Controls.Add(this.lbArrivalDate);
            this.pnDataManager.Controls.Add(this.lbDepartureDate);
            this.pnDataManager.Controls.Add(this.lbRoute);
            this.pnDataManager.Controls.Add(this.btnDelete);
            this.pnDataManager.Controls.Add(this.btnUpdate);
            this.pnDataManager.Controls.Add(this.btnCreate);
            this.pnDataManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDataManager.Location = new System.Drawing.Point(0, 183);
            this.pnDataManager.Name = "pnDataManager";
            this.pnDataManager.Size = new System.Drawing.Size(378, 312);
            this.pnDataManager.TabIndex = 16;
            // 
            // dtpArrivalDate
            // 
            this.dtpArrivalDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrivalDate.Location = new System.Drawing.Point(118, 120);
            this.dtpArrivalDate.Name = "dtpArrivalDate";
            this.dtpArrivalDate.Size = new System.Drawing.Size(254, 22);
            this.dtpArrivalDate.TabIndex = 16;
            // 
            // lbCoach
            // 
            this.lbCoach.AutoSize = true;
            this.lbCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoach.Location = new System.Drawing.Point(6, 179);
            this.lbCoach.Name = "lbCoach";
            this.lbCoach.Size = new System.Drawing.Size(34, 20);
            this.lbCoach.TabIndex = 20;
            this.lbCoach.Text = "Xe:";
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepartureDate.Location = new System.Drawing.Point(118, 92);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(254, 22);
            this.dtpDepartureDate.TabIndex = 15;
            // 
            // cbVehicle
            // 
            this.cbVehicle.BackColor = System.Drawing.Color.Linen;
            this.cbVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVehicle.FormattingEnabled = true;
            this.cbVehicle.Location = new System.Drawing.Point(118, 175);
            this.cbVehicle.Name = "cbVehicle";
            this.cbVehicle.Size = new System.Drawing.Size(254, 24);
            this.cbVehicle.TabIndex = 19;
            this.cbVehicle.SelectedIndexChanged += new System.EventHandler(this.cbVehicle_SelectedIndexChanged);
            // 
            // cbCoachTripStatus
            // 
            this.cbCoachTripStatus.BackColor = System.Drawing.Color.Linen;
            this.cbCoachTripStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCoachTripStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCoachTripStatus.FormattingEnabled = true;
            this.cbCoachTripStatus.Location = new System.Drawing.Point(118, 145);
            this.cbCoachTripStatus.Name = "cbCoachTripStatus";
            this.cbCoachTripStatus.Size = new System.Drawing.Size(254, 24);
            this.cbCoachTripStatus.TabIndex = 18;
            // 
            // lbCoachTripStatus
            // 
            this.lbCoachTripStatus.AutoSize = true;
            this.lbCoachTripStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoachTripStatus.Location = new System.Drawing.Point(6, 149);
            this.lbCoachTripStatus.Name = "lbCoachTripStatus";
            this.lbCoachTripStatus.Size = new System.Drawing.Size(95, 20);
            this.lbCoachTripStatus.TabIndex = 17;
            this.lbCoachTripStatus.Text = "TT Chuyến:";
            // 
            // cbRoute
            // 
            this.cbRoute.BackColor = System.Drawing.Color.Linen;
            this.cbRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoute.FormattingEnabled = true;
            this.cbRoute.Location = new System.Drawing.Point(118, 65);
            this.cbRoute.Name = "cbRoute";
            this.cbRoute.Size = new System.Drawing.Size(254, 24);
            this.cbRoute.TabIndex = 16;
            this.cbRoute.SelectedIndexChanged += new System.EventHandler(this.cbRoute_SelectedIndexChanged);
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
            this.pnTool.TabIndex = 38;
            // 
            // pnSpace4
            // 
            this.pnSpace4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSpace4.Location = new System.Drawing.Point(10, 37);
            this.pnSpace4.Name = "pnSpace4";
            this.pnSpace4.Size = new System.Drawing.Size(1019, 10);
            this.pnSpace4.TabIndex = 37;
            // 
            // lbList
            // 
            this.lbList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbList.Location = new System.Drawing.Point(0, 0);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(641, 37);
            this.lbList.TabIndex = 14;
            this.lbList.Text = "DANH SÁCH CHUYẾN XE";
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
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.lbList);
            this.pnHeader.Controls.Add(this.lbTool);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(10, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1019, 37);
            this.pnHeader.TabIndex = 36;
            // 
            // pnSpace3
            // 
            this.pnSpace3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnSpace3.Location = new System.Drawing.Point(10, 548);
            this.pnSpace3.Name = "pnSpace3";
            this.pnSpace3.Size = new System.Drawing.Size(1019, 10);
            this.pnSpace3.TabIndex = 35;
            // 
            // pnSpace1
            // 
            this.pnSpace1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSpace1.Location = new System.Drawing.Point(0, 0);
            this.pnSpace1.Name = "pnSpace1";
            this.pnSpace1.Size = new System.Drawing.Size(10, 558);
            this.pnSpace1.TabIndex = 33;
            // 
            // pnSpace2
            // 
            this.pnSpace2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSpace2.Location = new System.Drawing.Point(1029, 0);
            this.pnSpace2.Name = "pnSpace2";
            this.pnSpace2.Size = new System.Drawing.Size(10, 558);
            this.pnSpace2.TabIndex = 34;
            // 
            // pnSpace6
            // 
            this.pnSpace6.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSpace6.Location = new System.Drawing.Point(631, 47);
            this.pnSpace6.Name = "pnSpace6";
            this.pnSpace6.Size = new System.Drawing.Size(10, 501);
            this.pnSpace6.TabIndex = 41;
            // 
            // pnList
            // 
            this.pnList.Controls.Add(this.dgvCoachTripList);
            this.pnList.Controls.Add(this.pnStatistics);
            this.pnList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnList.Location = new System.Drawing.Point(10, 47);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(621, 501);
            this.pnList.TabIndex = 43;
            // 
            // dgvCoachTripList
            // 
            this.dgvCoachTripList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCoachTripList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoachTripList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CoachTripName,
            this.DepartureDate,
            this.ArrivalDate});
            this.dgvCoachTripList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCoachTripList.Location = new System.Drawing.Point(0, 0);
            this.dgvCoachTripList.Name = "dgvCoachTripList";
            this.dgvCoachTripList.RowHeadersWidth = 51;
            this.dgvCoachTripList.RowTemplate.Height = 24;
            this.dgvCoachTripList.Size = new System.Drawing.Size(621, 419);
            this.dgvCoachTripList.TabIndex = 22;
            this.dgvCoachTripList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoachTripList_CellClick);
            this.dgvCoachTripList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoachTripList_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "CoachTripId";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // CoachTripName
            // 
            this.CoachTripName.DataPropertyName = "Name";
            this.CoachTripName.HeaderText = "Tên chuyến";
            this.CoachTripName.MinimumWidth = 6;
            this.CoachTripName.Name = "CoachTripName";
            this.CoachTripName.Width = 125;
            // 
            // DepartureDate
            // 
            this.DepartureDate.DataPropertyName = "DepartureDate";
            this.DepartureDate.HeaderText = "Thời gian đi";
            this.DepartureDate.MinimumWidth = 6;
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.Width = 125;
            // 
            // ArrivalDate
            // 
            this.ArrivalDate.DataPropertyName = "ArrivalDate";
            this.ArrivalDate.HeaderText = "Thời gian đến";
            this.ArrivalDate.MinimumWidth = 6;
            this.ArrivalDate.Name = "ArrivalDate";
            this.ArrivalDate.Width = 125;
            // 
            // pnStatistics
            // 
            this.pnStatistics.Controls.Add(this.lbCoachTripNumber);
            this.pnStatistics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnStatistics.Location = new System.Drawing.Point(0, 419);
            this.pnStatistics.Name = "pnStatistics";
            this.pnStatistics.Size = new System.Drawing.Size(621, 82);
            this.pnStatistics.TabIndex = 0;
            // 
            // lbCoachTripNumber
            // 
            this.lbCoachTripNumber.AutoSize = true;
            this.lbCoachTripNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoachTripNumber.ForeColor = System.Drawing.Color.Red;
            this.lbCoachTripNumber.Location = new System.Drawing.Point(6, 24);
            this.lbCoachTripNumber.Name = "lbCoachTripNumber";
            this.lbCoachTripNumber.Size = new System.Drawing.Size(194, 20);
            this.lbCoachTripNumber.TabIndex = 14;
            this.lbCoachTripNumber.Text = "Số chuyến xe hiện có:";
            this.lbCoachTripNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UcCoachTripManager
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
            this.Name = "UcCoachTripManager";
            this.Size = new System.Drawing.Size(1039, 558);
            this.Load += new System.EventHandler(this.UcCoachTripManager_Load);
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnDataManager.ResumeLayout(false);
            this.pnDataManager.PerformLayout();
            this.pnTool.ResumeLayout(false);
            this.pnHeader.ResumeLayout(false);
            this.pnList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoachTripList)).EndInit();
            this.pnStatistics.ResumeLayout(false);
            this.pnStatistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIRadio xuiRadio_SearchByStartTime;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Panel pnSpace5;
        private XanderUI.XUIRadio xuiRadio_SearchByCoachTripName;
        private System.Windows.Forms.TextBox txtCoachTripName;
        private System.Windows.Forms.Label lbCoachTripName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbArrivalDate;
        private System.Windows.Forms.Label lbDepartureDate;
        private System.Windows.Forms.Label lbRoute;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbDataManager;
        private System.Windows.Forms.Panel pnSearch;
        private XanderUI.XUIRadio xuiRadio_SearchByEndTime;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnAdvancedEditingForm;
        private System.Windows.Forms.Panel pnDataManager;
        private System.Windows.Forms.Panel pnTool;
        private System.Windows.Forms.Panel pnSpace4;
        private System.Windows.Forms.Label lbList;
        private System.Windows.Forms.Label lbTool;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnSpace3;
        private System.Windows.Forms.Panel pnSpace1;
        private System.Windows.Forms.Panel pnSpace2;
        private System.Windows.Forms.Panel pnSpace6;
        private System.Windows.Forms.Panel pnList;
        private System.Windows.Forms.Panel pnStatistics;
        private System.Windows.Forms.Label lbCoachTripNumber;
        private System.Windows.Forms.DataGridView dgvCoachTripList;
        private System.Windows.Forms.Label lbCoach;
        private System.Windows.Forms.ComboBox cbVehicle;
        private System.Windows.Forms.ComboBox cbCoachTripStatus;
        private System.Windows.Forms.Label lbCoachTripStatus;
        private System.Windows.Forms.ComboBox cbRoute;
        private System.Windows.Forms.DateTimePicker dtpDepartureDate;
        private System.Windows.Forms.DateTimePicker dtpArrivalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoachTripName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalDate;
    }
}
