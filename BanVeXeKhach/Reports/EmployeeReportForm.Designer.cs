
namespace BanVeXeKhach.Reports
{
    partial class EmployeeReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeReportForm));
            this.panelHeaderBar = new System.Windows.Forms.Panel();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.pnSpace22 = new System.Windows.Forms.Panel();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbDefaultOrMaximize = new System.Windows.Forms.PictureBox();
            this.btnTitle = new System.Windows.Forms.Button();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.pbCancel = new System.Windows.Forms.PictureBox();
            this.panelFooterBar = new System.Windows.Forms.Panel();
            this.lbFooter2 = new System.Windows.Forms.Label();
            this.lbFooter1 = new System.Windows.Forms.Label();
            this.crystalReportViewer_Staff = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.employeeReport = new BanVeXeKhach.Reports.EmployeeReport();
            this.panelHeaderBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefaultOrMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).BeginInit();
            this.panelFooterBar.SuspendLayout();
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
            this.panelHeaderBar.Size = new System.Drawing.Size(1309, 29);
            this.panelHeaderBar.TabIndex = 7;
            this.panelHeaderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeaderBar_MouseDown);
            // 
            // pbRefresh
            // 
            this.pbRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbRefresh.Image = global::BanVeXeKhach.Properties.Resources._5110581;
            this.pbRefresh.Location = new System.Drawing.Point(1171, 0);
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
            this.pnSpace22.Location = new System.Drawing.Point(1203, 0);
            this.pnSpace22.Name = "pnSpace22";
            this.pnSpace22.Size = new System.Drawing.Size(10, 29);
            this.pnSpace22.TabIndex = 22;
            // 
            // pbMinimize
            // 
            this.pbMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbMinimize.Image = global::BanVeXeKhach.Properties.Resources.icons8_subtract_80;
            this.pbMinimize.Location = new System.Drawing.Point(1213, 0);
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
            this.pbDefaultOrMaximize.Location = new System.Drawing.Point(1245, 0);
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
            this.btnTitle.Size = new System.Drawing.Size(412, 29);
            this.btnTitle.TabIndex = 2;
            this.btnTitle.Text = "BÁN VÉ XE KHÁCH - XUẤT BÁO CÁO NHÂN VIÊN";
            this.btnTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTitle.UseVisualStyleBackColor = false;
            // 
            // pbIcon
            // 
            this.pbIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbIcon.Image = global::BanVeXeKhach.Properties.Resources._003_bus_ticket_1;
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
            this.pbCancel.Location = new System.Drawing.Point(1277, 0);
            this.pbCancel.Name = "pbCancel";
            this.pbCancel.Size = new System.Drawing.Size(32, 29);
            this.pbCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCancel.TabIndex = 0;
            this.pbCancel.TabStop = false;
            this.pbCancel.Click += new System.EventHandler(this.pbCancel_Click);
            // 
            // panelFooterBar
            // 
            this.panelFooterBar.BackColor = System.Drawing.Color.White;
            this.panelFooterBar.Controls.Add(this.lbFooter2);
            this.panelFooterBar.Controls.Add(this.lbFooter1);
            this.panelFooterBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooterBar.Location = new System.Drawing.Point(0, 708);
            this.panelFooterBar.Name = "panelFooterBar";
            this.panelFooterBar.Size = new System.Drawing.Size(1309, 35);
            this.panelFooterBar.TabIndex = 8;
            // 
            // lbFooter2
            // 
            this.lbFooter2.AutoSize = true;
            this.lbFooter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFooter2.Location = new System.Drawing.Point(335, 9);
            this.lbFooter2.Name = "lbFooter2";
            this.lbFooter2.Size = new System.Drawing.Size(104, 17);
            this.lbFooter2.TabIndex = 1;
            this.lbFooter2.Text = "Version:1.2.1.0";
            // 
            // lbFooter1
            // 
            this.lbFooter1.AutoSize = true;
            this.lbFooter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFooter1.Location = new System.Drawing.Point(15, 9);
            this.lbFooter1.Name = "lbFooter1";
            this.lbFooter1.Size = new System.Drawing.Size(302, 17);
            this.lbFooter1.TabIndex = 0;
            this.lbFooter1.Text = "Author: Phan Xuân Chánh - Hồ Thái Phong Ba\r\n";
            // 
            // crystalReportViewer_Staff
            // 
            this.crystalReportViewer_Staff.ActiveViewIndex = 0;
            this.crystalReportViewer_Staff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_Staff.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_Staff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer_Staff.Location = new System.Drawing.Point(0, 29);
            this.crystalReportViewer_Staff.Name = "crystalReportViewer_Staff";
            this.crystalReportViewer_Staff.ReportSource = this.employeeReport;
            this.crystalReportViewer_Staff.Size = new System.Drawing.Size(1309, 679);
            this.crystalReportViewer_Staff.TabIndex = 9;
            // 
            // EmployeeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 743);
            this.Controls.Add(this.crystalReportViewer_Staff);
            this.Controls.Add(this.panelFooterBar);
            this.Controls.Add(this.panelHeaderBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeReportForm";
            this.Text = "EmployeeReportForm";
            this.Load += new System.EventHandler(this.EmployeeReportForm_Load);
            this.panelHeaderBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefaultOrMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).EndInit();
            this.panelFooterBar.ResumeLayout(false);
            this.panelFooterBar.PerformLayout();
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
        private System.Windows.Forms.Panel panelFooterBar;
        private System.Windows.Forms.Label lbFooter2;
        private System.Windows.Forms.Label lbFooter1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_Staff;
        private EmployeeReport employeeReport;
    }
}