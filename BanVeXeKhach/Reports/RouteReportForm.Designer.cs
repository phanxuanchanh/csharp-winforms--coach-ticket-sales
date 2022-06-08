
namespace BanVeXeKhach.Reports
{
    partial class RouteReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteReportForm));
            this.lbFooter1 = new System.Windows.Forms.Label();
            this.lbFooter2 = new System.Windows.Forms.Label();
            this.panelFooterBar = new System.Windows.Forms.Panel();
            this.pbCancel = new System.Windows.Forms.PictureBox();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.btnTitle = new System.Windows.Forms.Button();
            this.pbDefaultOrMaximize = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pnSpace22 = new System.Windows.Forms.Panel();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.panelHeaderBar = new System.Windows.Forms.Panel();
            this.pnMainWorkArea = new System.Windows.Forms.Panel();
            this.crystalReportViewer_Route = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.routeReport = new BanVeXeKhach.Reports.RouteReport();
            this.panelFooterBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefaultOrMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            this.panelHeaderBar.SuspendLayout();
            this.pnMainWorkArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFooter1
            // 
            this.lbFooter1.AutoSize = true;
            this.lbFooter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFooter1.Location = new System.Drawing.Point(15, 9);
            this.lbFooter1.Name = "lbFooter1";
            this.lbFooter1.Size = new System.Drawing.Size(264, 17);
            this.lbFooter1.TabIndex = 0;
            this.lbFooter1.Text = "Đồ án môn CN .NET, PTTKHTTT, CNPM";
            // 
            // lbFooter2
            // 
            this.lbFooter2.AutoSize = true;
            this.lbFooter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFooter2.Location = new System.Drawing.Point(335, 9);
            this.lbFooter2.Name = "lbFooter2";
            this.lbFooter2.Size = new System.Drawing.Size(108, 17);
            this.lbFooter2.TabIndex = 1;
            this.lbFooter2.Text = "Version: 2.8.1.1";
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
            this.panelFooterBar.TabIndex = 7;
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
            this.btnTitle.Text = "BÁN VÉ XE KHÁCH - XUẤT BÁO CÁO TUYẾN XE";
            this.btnTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTitle.UseVisualStyleBackColor = false;
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
            // pnSpace22
            // 
            this.pnSpace22.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSpace22.Location = new System.Drawing.Point(1203, 0);
            this.pnSpace22.Name = "pnSpace22";
            this.pnSpace22.Size = new System.Drawing.Size(10, 29);
            this.pnSpace22.TabIndex = 22;
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
            this.panelHeaderBar.TabIndex = 6;
            this.panelHeaderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeaderBar_MouseDown);
            // 
            // pnMainWorkArea
            // 
            this.pnMainWorkArea.Controls.Add(this.crystalReportViewer_Route);
            this.pnMainWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMainWorkArea.Location = new System.Drawing.Point(0, 29);
            this.pnMainWorkArea.Name = "pnMainWorkArea";
            this.pnMainWorkArea.Size = new System.Drawing.Size(1309, 679);
            this.pnMainWorkArea.TabIndex = 8;
            // 
            // crystalReportViewer_Route
            // 
            this.crystalReportViewer_Route.ActiveViewIndex = 0;
            this.crystalReportViewer_Route.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_Route.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_Route.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer_Route.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer_Route.Name = "crystalReportViewer_Route";
            this.crystalReportViewer_Route.ReportSource = this.routeReport;
            this.crystalReportViewer_Route.Size = new System.Drawing.Size(1309, 679);
            this.crystalReportViewer_Route.TabIndex = 0;
            // 
            // RouteReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1309, 743);
            this.Controls.Add(this.pnMainWorkArea);
            this.Controls.Add(this.panelFooterBar);
            this.Controls.Add(this.panelHeaderBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RouteReportForm";
            this.Text = "RouteReportForm";
            this.Load += new System.EventHandler(this.RouteReportForm_Load);
            this.panelFooterBar.ResumeLayout(false);
            this.panelFooterBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefaultOrMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            this.panelHeaderBar.ResumeLayout(false);
            this.pnMainWorkArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbFooter1;
        private System.Windows.Forms.Label lbFooter2;
        private System.Windows.Forms.Panel panelFooterBar;
        private System.Windows.Forms.PictureBox pbCancel;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.PictureBox pbDefaultOrMaximize;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.Panel pnSpace22;
        private System.Windows.Forms.PictureBox pbRefresh;
        private System.Windows.Forms.Panel panelHeaderBar;
        private System.Windows.Forms.Panel pnMainWorkArea;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_Route;
        private RouteReport routeReport;
    }
}