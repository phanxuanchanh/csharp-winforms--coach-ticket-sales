
namespace BanVeXeKhach.UserControls
{
    partial class UcRouteManager
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
            this.pnSpace2 = new System.Windows.Forms.Panel();
            this.pnSpace1 = new System.Windows.Forms.Panel();
            this.pnSpace3 = new System.Windows.Forms.Panel();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lbList = new System.Windows.Forms.Label();
            this.lbTool = new System.Windows.Forms.Label();
            this.pnSpace4 = new System.Windows.Forms.Panel();
            this.pnTool = new System.Windows.Forms.Panel();
            this.pnDataManager = new System.Windows.Forms.Panel();
            this.txtRouteName = new System.Windows.Forms.TextBox();
            this.lbRouteName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtRouteDestination = new System.Windows.Forms.TextBox();
            this.lbRouteDestination = new System.Windows.Forms.Label();
            this.txtRouteOrigin = new System.Windows.Forms.TextBox();
            this.lbRouteOrigin = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnAdvancedEditingForm = new System.Windows.Forms.Button();
            this.lbDataManager = new System.Windows.Forms.Label();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.xuiRadio_SearchByRouteDestination = new XanderUI.XUIRadio();
            this.xuiRadio_SearchByRouteOrigin = new XanderUI.XUIRadio();
            this.xuiRadio_SearchByRouteName = new XanderUI.XUIRadio();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.pnSpace5 = new System.Windows.Forms.Panel();
            this.pnSpace6 = new System.Windows.Forms.Panel();
            this.pnList = new System.Windows.Forms.Panel();
            this.dgvRouteList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnStatistics = new System.Windows.Forms.Panel();
            this.lbRouteNumber = new System.Windows.Forms.Label();
            this.pnHeader.SuspendLayout();
            this.pnTool.SuspendLayout();
            this.pnDataManager.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRouteList)).BeginInit();
            this.pnStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSpace2
            // 
            this.pnSpace2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSpace2.Location = new System.Drawing.Point(1029, 0);
            this.pnSpace2.Name = "pnSpace2";
            this.pnSpace2.Size = new System.Drawing.Size(10, 558);
            this.pnSpace2.TabIndex = 11;
            // 
            // pnSpace1
            // 
            this.pnSpace1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSpace1.Location = new System.Drawing.Point(0, 0);
            this.pnSpace1.Name = "pnSpace1";
            this.pnSpace1.Size = new System.Drawing.Size(10, 558);
            this.pnSpace1.TabIndex = 10;
            // 
            // pnSpace3
            // 
            this.pnSpace3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnSpace3.Location = new System.Drawing.Point(10, 548);
            this.pnSpace3.Name = "pnSpace3";
            this.pnSpace3.Size = new System.Drawing.Size(1019, 10);
            this.pnSpace3.TabIndex = 14;
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.lbList);
            this.pnHeader.Controls.Add(this.lbTool);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(10, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1019, 37);
            this.pnHeader.TabIndex = 15;
            // 
            // lbList
            // 
            this.lbList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbList.Location = new System.Drawing.Point(0, 0);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(641, 37);
            this.lbList.TabIndex = 14;
            this.lbList.Text = "DANH SÁCH TUYẾN ĐƯỜNG";
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
            this.pnSpace4.TabIndex = 27;
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
            this.pnTool.TabIndex = 28;
            // 
            // pnDataManager
            // 
            this.pnDataManager.Controls.Add(this.txtRouteName);
            this.pnDataManager.Controls.Add(this.lbRouteName);
            this.pnDataManager.Controls.Add(this.txtID);
            this.pnDataManager.Controls.Add(this.lbID);
            this.pnDataManager.Controls.Add(this.btnSave);
            this.pnDataManager.Controls.Add(this.txtPrice);
            this.pnDataManager.Controls.Add(this.lbPrice);
            this.pnDataManager.Controls.Add(this.txtRouteDestination);
            this.pnDataManager.Controls.Add(this.lbRouteDestination);
            this.pnDataManager.Controls.Add(this.txtRouteOrigin);
            this.pnDataManager.Controls.Add(this.lbRouteOrigin);
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
            // txtRouteName
            // 
            this.txtRouteName.BackColor = System.Drawing.Color.Linen;
            this.txtRouteName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRouteName.Enabled = false;
            this.txtRouteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRouteName.Location = new System.Drawing.Point(102, 49);
            this.txtRouteName.Name = "txtRouteName";
            this.txtRouteName.Size = new System.Drawing.Size(270, 19);
            this.txtRouteName.TabIndex = 15;
            // 
            // lbRouteName
            // 
            this.lbRouteName.AutoSize = true;
            this.lbRouteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRouteName.Location = new System.Drawing.Point(6, 48);
            this.lbRouteName.Name = "lbRouteName";
            this.lbRouteName.Size = new System.Drawing.Size(87, 20);
            this.lbRouteName.TabIndex = 14;
            this.lbRouteName.Text = "Tên tuyến:";
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
            this.btnSave.Location = new System.Drawing.Point(256, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 35);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Linen;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(102, 152);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(270, 19);
            this.txtPrice.TabIndex = 10;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(6, 151);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(40, 20);
            this.lbPrice.TabIndex = 9;
            this.lbPrice.Text = "Giá:";
            // 
            // txtRouteDestination
            // 
            this.txtRouteDestination.BackColor = System.Drawing.Color.Linen;
            this.txtRouteDestination.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRouteDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRouteDestination.Location = new System.Drawing.Point(102, 117);
            this.txtRouteDestination.Name = "txtRouteDestination";
            this.txtRouteDestination.Size = new System.Drawing.Size(270, 19);
            this.txtRouteDestination.TabIndex = 8;
            this.txtRouteDestination.TextChanged += new System.EventHandler(this.txtRouteDestination_TextChanged);
            // 
            // lbRouteDestination
            // 
            this.lbRouteDestination.AutoSize = true;
            this.lbRouteDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRouteDestination.Location = new System.Drawing.Point(6, 116);
            this.lbRouteDestination.Name = "lbRouteDestination";
            this.lbRouteDestination.Size = new System.Drawing.Size(85, 20);
            this.lbRouteDestination.TabIndex = 7;
            this.lbRouteDestination.Text = "Điểm đến:";
            // 
            // txtRouteOrigin
            // 
            this.txtRouteOrigin.BackColor = System.Drawing.Color.Linen;
            this.txtRouteOrigin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRouteOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRouteOrigin.Location = new System.Drawing.Point(102, 83);
            this.txtRouteOrigin.Name = "txtRouteOrigin";
            this.txtRouteOrigin.Size = new System.Drawing.Size(270, 19);
            this.txtRouteOrigin.TabIndex = 6;
            this.txtRouteOrigin.TextChanged += new System.EventHandler(this.txtRouteOrigin_TextChanged);
            // 
            // lbRouteOrigin
            // 
            this.lbRouteOrigin.AutoSize = true;
            this.lbRouteOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRouteOrigin.Location = new System.Drawing.Point(6, 82);
            this.lbRouteOrigin.Name = "lbRouteOrigin";
            this.lbRouteOrigin.Size = new System.Drawing.Size(71, 20);
            this.lbRouteOrigin.TabIndex = 5;
            this.lbRouteOrigin.Text = "Điểm đi:";
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
            this.btnAdvancedEditingForm.Location = new System.Drawing.Point(5, 254);
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
            this.pnSearch.Controls.Add(this.xuiRadio_SearchByRouteDestination);
            this.pnSearch.Controls.Add(this.xuiRadio_SearchByRouteOrigin);
            this.pnSearch.Controls.Add(this.xuiRadio_SearchByRouteName);
            this.pnSearch.Controls.Add(this.txtSearch);
            this.pnSearch.Controls.Add(this.btnSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearch.Location = new System.Drawing.Point(0, 32);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(378, 119);
            this.pnSearch.TabIndex = 14;
            // 
            // xuiRadio_SearchByRouteDestination
            // 
            this.xuiRadio_SearchByRouteDestination.Checked = false;
            this.xuiRadio_SearchByRouteDestination.ForeColor = System.Drawing.Color.Black;
            this.xuiRadio_SearchByRouteDestination.Location = new System.Drawing.Point(6, 90);
            this.xuiRadio_SearchByRouteDestination.Name = "xuiRadio_SearchByRouteDestination";
            this.xuiRadio_SearchByRouteDestination.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuiRadio_SearchByRouteDestination.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiRadio_SearchByRouteDestination.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.xuiRadio_SearchByRouteDestination.Size = new System.Drawing.Size(133, 16);
            this.xuiRadio_SearchByRouteDestination.TabIndex = 5;
            this.xuiRadio_SearchByRouteDestination.Text = "Theo điểm đến";
            // 
            // xuiRadio_SearchByRouteOrigin
            // 
            this.xuiRadio_SearchByRouteOrigin.Checked = false;
            this.xuiRadio_SearchByRouteOrigin.ForeColor = System.Drawing.Color.Black;
            this.xuiRadio_SearchByRouteOrigin.Location = new System.Drawing.Point(145, 55);
            this.xuiRadio_SearchByRouteOrigin.Name = "xuiRadio_SearchByRouteOrigin";
            this.xuiRadio_SearchByRouteOrigin.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuiRadio_SearchByRouteOrigin.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiRadio_SearchByRouteOrigin.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.xuiRadio_SearchByRouteOrigin.Size = new System.Drawing.Size(126, 16);
            this.xuiRadio_SearchByRouteOrigin.TabIndex = 4;
            this.xuiRadio_SearchByRouteOrigin.Text = "Theo điểm đi";
            // 
            // xuiRadio_SearchByRouteName
            // 
            this.xuiRadio_SearchByRouteName.Checked = true;
            this.xuiRadio_SearchByRouteName.ForeColor = System.Drawing.Color.Black;
            this.xuiRadio_SearchByRouteName.Location = new System.Drawing.Point(6, 55);
            this.xuiRadio_SearchByRouteName.Name = "xuiRadio_SearchByRouteName";
            this.xuiRadio_SearchByRouteName.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuiRadio_SearchByRouteName.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiRadio_SearchByRouteName.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.xuiRadio_SearchByRouteName.Size = new System.Drawing.Size(133, 16);
            this.xuiRadio_SearchByRouteName.TabIndex = 3;
            this.xuiRadio_SearchByRouteName.Text = "Theo tên tuyến";
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
            this.pnSpace5.TabIndex = 29;
            // 
            // pnSpace6
            // 
            this.pnSpace6.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSpace6.Location = new System.Drawing.Point(631, 47);
            this.pnSpace6.Name = "pnSpace6";
            this.pnSpace6.Size = new System.Drawing.Size(10, 501);
            this.pnSpace6.TabIndex = 30;
            // 
            // pnList
            // 
            this.pnList.Controls.Add(this.dgvRouteList);
            this.pnList.Controls.Add(this.pnStatistics);
            this.pnList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnList.Location = new System.Drawing.Point(10, 47);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(621, 501);
            this.pnList.TabIndex = 32;
            // 
            // dgvRouteList
            // 
            this.dgvRouteList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRouteList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRouteList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.RouteName,
            this.Origin,
            this.Destination,
            this.Price});
            this.dgvRouteList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRouteList.Location = new System.Drawing.Point(0, 0);
            this.dgvRouteList.Name = "dgvRouteList";
            this.dgvRouteList.RowHeadersWidth = 51;
            this.dgvRouteList.RowTemplate.Height = 24;
            this.dgvRouteList.Size = new System.Drawing.Size(621, 419);
            this.dgvRouteList.TabIndex = 20;
            this.dgvRouteList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRouteList_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "RouteId";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // RouteName
            // 
            this.RouteName.DataPropertyName = "Name";
            this.RouteName.HeaderText = "Tên tuyến đường";
            this.RouteName.MinimumWidth = 6;
            this.RouteName.Name = "RouteName";
            this.RouteName.Width = 125;
            // 
            // Origin
            // 
            this.Origin.DataPropertyName = "Origin";
            this.Origin.HeaderText = "Điểm đi";
            this.Origin.MinimumWidth = 6;
            this.Origin.Name = "Origin";
            this.Origin.Width = 125;
            // 
            // Destination
            // 
            this.Destination.DataPropertyName = "Destination";
            this.Destination.HeaderText = "Điểm đến";
            this.Destination.MinimumWidth = 6;
            this.Destination.Name = "Destination";
            this.Destination.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // pnStatistics
            // 
            this.pnStatistics.Controls.Add(this.lbRouteNumber);
            this.pnStatistics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnStatistics.Location = new System.Drawing.Point(0, 419);
            this.pnStatistics.Name = "pnStatistics";
            this.pnStatistics.Size = new System.Drawing.Size(621, 82);
            this.pnStatistics.TabIndex = 0;
            // 
            // lbRouteNumber
            // 
            this.lbRouteNumber.AutoSize = true;
            this.lbRouteNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRouteNumber.ForeColor = System.Drawing.Color.Red;
            this.lbRouteNumber.Location = new System.Drawing.Point(6, 24);
            this.lbRouteNumber.Name = "lbRouteNumber";
            this.lbRouteNumber.Size = new System.Drawing.Size(211, 20);
            this.lbRouteNumber.TabIndex = 14;
            this.lbRouteNumber.Text = "Số tuyến đường hiện có:";
            this.lbRouteNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UcRouteManager
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
            this.Name = "UcRouteManager";
            this.Size = new System.Drawing.Size(1039, 558);
            this.Load += new System.EventHandler(this.UcRouteManager_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnTool.ResumeLayout(false);
            this.pnDataManager.ResumeLayout(false);
            this.pnDataManager.PerformLayout();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRouteList)).EndInit();
            this.pnStatistics.ResumeLayout(false);
            this.pnStatistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSpace2;
        private System.Windows.Forms.Panel pnSpace1;
        private System.Windows.Forms.Panel pnSpace3;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label lbTool;
        private System.Windows.Forms.Label lbList;
        private System.Windows.Forms.Panel pnSpace4;
        private System.Windows.Forms.Panel pnTool;
        private System.Windows.Forms.Panel pnDataManager;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnAdvancedEditingForm;
        private System.Windows.Forms.Label lbDataManager;
        private System.Windows.Forms.Panel pnSearch;
        private XanderUI.XUIRadio xuiRadio_SearchByRouteDestination;
        private XanderUI.XUIRadio xuiRadio_SearchByRouteOrigin;
        private XanderUI.XUIRadio xuiRadio_SearchByRouteName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Panel pnSpace5;
        private System.Windows.Forms.Panel pnSpace6;
        private System.Windows.Forms.Panel pnList;
        private System.Windows.Forms.Panel pnStatistics;
        private System.Windows.Forms.Label lbRouteNumber;
        private System.Windows.Forms.DataGridView dgvRouteList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txtRouteDestination;
        private System.Windows.Forms.Label lbRouteDestination;
        private System.Windows.Forms.TextBox txtRouteOrigin;
        private System.Windows.Forms.Label lbRouteOrigin;
        private System.Windows.Forms.TextBox txtRouteName;
        private System.Windows.Forms.Label lbRouteName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}
