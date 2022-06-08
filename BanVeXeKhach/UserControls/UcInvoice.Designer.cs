
namespace BanVeXeKhach.UserControls
{
    partial class UcInvoice
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
            this.pnSpace3 = new System.Windows.Forms.Panel();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lbList = new System.Windows.Forms.Label();
            this.lbTool = new System.Windows.Forms.Label();
            this.pnSpace4 = new System.Windows.Forms.Panel();
            this.pnTool = new System.Windows.Forms.Panel();
            this.lbDataManager = new System.Windows.Forms.Label();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.xuiRadio_SearchBy3 = new XanderUI.XUIRadio();
            this.xuiRadio_SearchBy2 = new XanderUI.XUIRadio();
            this.xuiRadio_SearchBy1 = new XanderUI.XUIRadio();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSeacrh = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.pnSpace5 = new System.Windows.Forms.Panel();
            this.pnSpace6 = new System.Windows.Forms.Panel();
            this.pnList = new System.Windows.Forms.Panel();
            this.dgvInvoiceListByStaff = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nhanVienId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnStatistics = new System.Windows.Forms.Panel();
            this.lbInvoiceNumberByStaff = new System.Windows.Forms.Label();
            this.pnHeader.SuspendLayout();
            this.pnTool.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceListByStaff)).BeginInit();
            this.pnStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSpace1
            // 
            this.pnSpace1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSpace1.Location = new System.Drawing.Point(0, 0);
            this.pnSpace1.Name = "pnSpace1";
            this.pnSpace1.Size = new System.Drawing.Size(10, 679);
            this.pnSpace1.TabIndex = 35;
            // 
            // pnSpace2
            // 
            this.pnSpace2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSpace2.Location = new System.Drawing.Point(1321, 0);
            this.pnSpace2.Name = "pnSpace2";
            this.pnSpace2.Size = new System.Drawing.Size(10, 679);
            this.pnSpace2.TabIndex = 36;
            // 
            // pnSpace3
            // 
            this.pnSpace3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnSpace3.Location = new System.Drawing.Point(10, 669);
            this.pnSpace3.Name = "pnSpace3";
            this.pnSpace3.Size = new System.Drawing.Size(1311, 10);
            this.pnSpace3.TabIndex = 37;
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.lbList);
            this.pnHeader.Controls.Add(this.lbTool);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(10, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1311, 37);
            this.pnHeader.TabIndex = 38;
            // 
            // lbList
            // 
            this.lbList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbList.Location = new System.Drawing.Point(0, 0);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(933, 37);
            this.lbList.TabIndex = 16;
            this.lbList.Text = "DANH SÁCH HÓA ĐƠN DO BẠN THỰC HIỆN";
            this.lbList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTool
            // 
            this.lbTool.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTool.Location = new System.Drawing.Point(933, 0);
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
            this.pnSpace4.Size = new System.Drawing.Size(1311, 10);
            this.pnSpace4.TabIndex = 39;
            // 
            // pnTool
            // 
            this.pnTool.Controls.Add(this.lbDataManager);
            this.pnTool.Controls.Add(this.pnSearch);
            this.pnTool.Controls.Add(this.lbSearch);
            this.pnTool.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnTool.Location = new System.Drawing.Point(813, 47);
            this.pnTool.Name = "pnTool";
            this.pnTool.Size = new System.Drawing.Size(508, 622);
            this.pnTool.TabIndex = 40;
            // 
            // lbDataManager
            // 
            this.lbDataManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDataManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataManager.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbDataManager.Location = new System.Drawing.Point(0, 151);
            this.lbDataManager.Name = "lbDataManager";
            this.lbDataManager.Size = new System.Drawing.Size(508, 32);
            this.lbDataManager.TabIndex = 15;
            this.lbDataManager.Text = "Quản lý dữ liệu";
            this.lbDataManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.xuiRadio_SearchBy3);
            this.pnSearch.Controls.Add(this.xuiRadio_SearchBy2);
            this.pnSearch.Controls.Add(this.xuiRadio_SearchBy1);
            this.pnSearch.Controls.Add(this.txtSearch);
            this.pnSearch.Controls.Add(this.btnSeacrh);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearch.Location = new System.Drawing.Point(0, 32);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(508, 119);
            this.pnSearch.TabIndex = 14;
            // 
            // xuiRadio_SearchBy3
            // 
            this.xuiRadio_SearchBy3.Checked = false;
            this.xuiRadio_SearchBy3.ForeColor = System.Drawing.Color.Black;
            this.xuiRadio_SearchBy3.Location = new System.Drawing.Point(173, 55);
            this.xuiRadio_SearchBy3.Name = "xuiRadio_SearchBy3";
            this.xuiRadio_SearchBy3.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuiRadio_SearchBy3.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiRadio_SearchBy3.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.xuiRadio_SearchBy3.Size = new System.Drawing.Size(133, 16);
            this.xuiRadio_SearchBy3.TabIndex = 5;
            this.xuiRadio_SearchBy3.Text = "#3";
            // 
            // xuiRadio_SearchBy2
            // 
            this.xuiRadio_SearchBy2.Checked = false;
            this.xuiRadio_SearchBy2.ForeColor = System.Drawing.Color.Black;
            this.xuiRadio_SearchBy2.Location = new System.Drawing.Point(93, 55);
            this.xuiRadio_SearchBy2.Name = "xuiRadio_SearchBy2";
            this.xuiRadio_SearchBy2.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuiRadio_SearchBy2.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiRadio_SearchBy2.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.xuiRadio_SearchBy2.Size = new System.Drawing.Size(126, 16);
            this.xuiRadio_SearchBy2.TabIndex = 4;
            this.xuiRadio_SearchBy2.Text = "#2";
            // 
            // xuiRadio_SearchBy1
            // 
            this.xuiRadio_SearchBy1.Checked = true;
            this.xuiRadio_SearchBy1.ForeColor = System.Drawing.Color.Black;
            this.xuiRadio_SearchBy1.Location = new System.Drawing.Point(6, 55);
            this.xuiRadio_SearchBy1.Name = "xuiRadio_SearchBy1";
            this.xuiRadio_SearchBy1.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuiRadio_SearchBy1.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiRadio_SearchBy1.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.xuiRadio_SearchBy1.Size = new System.Drawing.Size(133, 16);
            this.xuiRadio_SearchBy1.TabIndex = 3;
            this.xuiRadio_SearchBy1.Text = "#1";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Linen;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(6, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(496, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSeacrh
            // 
            this.btnSeacrh.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSeacrh.FlatAppearance.BorderSize = 0;
            this.btnSeacrh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeacrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeacrh.Location = new System.Drawing.Point(393, 81);
            this.btnSeacrh.Name = "btnSeacrh";
            this.btnSeacrh.Size = new System.Drawing.Size(109, 35);
            this.btnSeacrh.TabIndex = 0;
            this.btnSeacrh.Text = "Thực hiện";
            this.btnSeacrh.UseVisualStyleBackColor = false;
            // 
            // lbSearch
            // 
            this.lbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbSearch.Location = new System.Drawing.Point(0, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(508, 32);
            this.lbSearch.TabIndex = 13;
            this.lbSearch.Text = "Tìm kiếm và lọc";
            this.lbSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnSpace5
            // 
            this.pnSpace5.BackColor = System.Drawing.Color.Bisque;
            this.pnSpace5.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSpace5.Location = new System.Drawing.Point(803, 47);
            this.pnSpace5.Name = "pnSpace5";
            this.pnSpace5.Size = new System.Drawing.Size(10, 622);
            this.pnSpace5.TabIndex = 42;
            // 
            // pnSpace6
            // 
            this.pnSpace6.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSpace6.Location = new System.Drawing.Point(793, 47);
            this.pnSpace6.Name = "pnSpace6";
            this.pnSpace6.Size = new System.Drawing.Size(10, 622);
            this.pnSpace6.TabIndex = 43;
            // 
            // pnList
            // 
            this.pnList.Controls.Add(this.dgvInvoiceListByStaff);
            this.pnList.Controls.Add(this.pnStatistics);
            this.pnList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnList.Location = new System.Drawing.Point(10, 47);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(783, 622);
            this.pnList.TabIndex = 44;
            // 
            // dgvInvoiceListByStaff
            // 
            this.dgvInvoiceListByStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInvoiceListByStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceListByStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.khachHang,
            this.nhanVienId,
            this.tongTien,
            this.ngayMua});
            this.dgvInvoiceListByStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoiceListByStaff.Location = new System.Drawing.Point(0, 0);
            this.dgvInvoiceListByStaff.Name = "dgvInvoiceListByStaff";
            this.dgvInvoiceListByStaff.RowHeadersWidth = 51;
            this.dgvInvoiceListByStaff.RowTemplate.Height = 24;
            this.dgvInvoiceListByStaff.Size = new System.Drawing.Size(783, 540);
            this.dgvInvoiceListByStaff.TabIndex = 24;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // khachHang
            // 
            this.khachHang.DataPropertyName = "khachHang";
            this.khachHang.HeaderText = "Khách hàng";
            this.khachHang.MinimumWidth = 6;
            this.khachHang.Name = "khachHang";
            this.khachHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.khachHang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.khachHang.Width = 125;
            // 
            // nhanVienId
            // 
            this.nhanVienId.DataPropertyName = "nhanVienId";
            this.nhanVienId.HeaderText = "Nhân viên";
            this.nhanVienId.MinimumWidth = 6;
            this.nhanVienId.Name = "nhanVienId";
            this.nhanVienId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nhanVienId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nhanVienId.Width = 125;
            // 
            // tongTien
            // 
            this.tongTien.DataPropertyName = "tongTien";
            this.tongTien.HeaderText = "Tổng tiền";
            this.tongTien.MinimumWidth = 6;
            this.tongTien.Name = "tongTien";
            this.tongTien.Width = 125;
            // 
            // ngayMua
            // 
            this.ngayMua.DataPropertyName = "ngayMua";
            this.ngayMua.HeaderText = "Ngày mua";
            this.ngayMua.MinimumWidth = 6;
            this.ngayMua.Name = "ngayMua";
            this.ngayMua.Width = 125;
            // 
            // pnStatistics
            // 
            this.pnStatistics.Controls.Add(this.lbInvoiceNumberByStaff);
            this.pnStatistics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnStatistics.Location = new System.Drawing.Point(0, 540);
            this.pnStatistics.Name = "pnStatistics";
            this.pnStatistics.Size = new System.Drawing.Size(783, 82);
            this.pnStatistics.TabIndex = 0;
            // 
            // lbInvoiceNumberByStaff
            // 
            this.lbInvoiceNumberByStaff.AutoSize = true;
            this.lbInvoiceNumberByStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvoiceNumberByStaff.ForeColor = System.Drawing.Color.Red;
            this.lbInvoiceNumberByStaff.Location = new System.Drawing.Point(6, 24);
            this.lbInvoiceNumberByStaff.Name = "lbInvoiceNumberByStaff";
            this.lbInvoiceNumberByStaff.Size = new System.Drawing.Size(248, 20);
            this.lbInvoiceNumberByStaff.TabIndex = 14;
            this.lbInvoiceNumberByStaff.Text = "Số hóa đơn của bạn hiện có:";
            this.lbInvoiceNumberByStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UcInvoice
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
            this.Name = "UcInvoice";
            this.Size = new System.Drawing.Size(1331, 679);
            this.Load += new System.EventHandler(this.UcInvoice_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnTool.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceListByStaff)).EndInit();
            this.pnStatistics.ResumeLayout(false);
            this.pnStatistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSpace1;
        private System.Windows.Forms.Panel pnSpace2;
        private System.Windows.Forms.Panel pnSpace3;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label lbTool;
        private System.Windows.Forms.Label lbList;
        private System.Windows.Forms.Panel pnSpace4;
        private System.Windows.Forms.Panel pnTool;
        private System.Windows.Forms.Label lbDataManager;
        private System.Windows.Forms.Panel pnSearch;
        private XanderUI.XUIRadio xuiRadio_SearchBy3;
        private XanderUI.XUIRadio xuiRadio_SearchBy2;
        private XanderUI.XUIRadio xuiRadio_SearchBy1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSeacrh;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Panel pnSpace5;
        private System.Windows.Forms.Panel pnSpace6;
        private System.Windows.Forms.Panel pnList;
        private System.Windows.Forms.Panel pnStatistics;
        private System.Windows.Forms.Label lbInvoiceNumberByStaff;
        private System.Windows.Forms.DataGridView dgvInvoiceListByStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn khachHang;
        private System.Windows.Forms.DataGridViewComboBoxColumn nhanVienId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayMua;
    }
}
