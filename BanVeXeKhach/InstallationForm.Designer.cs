
namespace BanVeXeKhach
{
    partial class InstallationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallationForm));
            this.panelHeaderBar = new System.Windows.Forms.Panel();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.pnSpace22 = new System.Windows.Forms.Panel();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.btnTitle = new System.Windows.Forms.Button();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.pbCancel = new System.Windows.Forms.PictureBox();
            this.pnSpace1 = new System.Windows.Forms.Panel();
            this.pnSpace2 = new System.Windows.Forms.Panel();
            this.pnSpace3 = new System.Windows.Forms.Panel();
            this.pnSpace4 = new System.Windows.Forms.Panel();
            this.panelMainWorkArea = new System.Windows.Forms.Panel();
            this.txtSqlServerPassword = new System.Windows.Forms.TextBox();
            this.txtSqlServerUserId = new System.Windows.Forms.TextBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.txtSqlServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUserId = new System.Windows.Forms.Label();
            this.lbDatabaseName = new System.Windows.Forms.Label();
            this.lbSqlServerName = new System.Windows.Forms.Label();
            this.txtSmtpPassword = new System.Windows.Forms.TextBox();
            this.txtSmtpUsername = new System.Windows.Forms.TextBox();
            this.txtSmtpPort = new System.Windows.Forms.TextBox();
            this.txtSmtpHost = new System.Windows.Forms.TextBox();
            this.lbSmtpPassword = new System.Windows.Forms.Label();
            this.lbSmtpUsername = new System.Windows.Forms.Label();
            this.lbSmtpHostName = new System.Windows.Forms.Label();
            this.lbSmtpHost = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.xuiSuperButton_RunInstallationProcess = new XanderUI.XUISuperButton();
            this.panelHeaderBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).BeginInit();
            this.panelMainWorkArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeaderBar
            // 
            this.panelHeaderBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
            this.panelHeaderBar.Controls.Add(this.pbRefresh);
            this.panelHeaderBar.Controls.Add(this.pnSpace22);
            this.panelHeaderBar.Controls.Add(this.pbMinimize);
            this.panelHeaderBar.Controls.Add(this.btnTitle);
            this.panelHeaderBar.Controls.Add(this.pbIcon);
            this.panelHeaderBar.Controls.Add(this.pbCancel);
            this.panelHeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderBar.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderBar.Name = "panelHeaderBar";
            this.panelHeaderBar.Size = new System.Drawing.Size(692, 29);
            this.panelHeaderBar.TabIndex = 5;
            this.panelHeaderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeaderBar_MouseDown);
            // 
            // pbRefresh
            // 
            this.pbRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbRefresh.Image = global::BanVeXeKhach.Properties.Resources._5110581;
            this.pbRefresh.Location = new System.Drawing.Point(586, 0);
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
            this.pnSpace22.Location = new System.Drawing.Point(618, 0);
            this.pnSpace22.Name = "pnSpace22";
            this.pnSpace22.Size = new System.Drawing.Size(10, 29);
            this.pnSpace22.TabIndex = 22;
            // 
            // pbMinimize
            // 
            this.pbMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbMinimize.Image = global::BanVeXeKhach.Properties.Resources.icons8_subtract_80;
            this.pbMinimize.Location = new System.Drawing.Point(628, 0);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(32, 29);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimize.TabIndex = 4;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
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
            this.btnTitle.Size = new System.Drawing.Size(151, 29);
            this.btnTitle.TabIndex = 2;
            this.btnTitle.Text = "TRÌNH CÀI ĐẶT";
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
            this.pbCancel.Location = new System.Drawing.Point(660, 0);
            this.pbCancel.Name = "pbCancel";
            this.pbCancel.Size = new System.Drawing.Size(32, 29);
            this.pbCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCancel.TabIndex = 0;
            this.pbCancel.TabStop = false;
            this.pbCancel.Click += new System.EventHandler(this.pbCancel_Click);
            // 
            // pnSpace1
            // 
            this.pnSpace1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSpace1.Location = new System.Drawing.Point(0, 29);
            this.pnSpace1.Name = "pnSpace1";
            this.pnSpace1.Size = new System.Drawing.Size(13, 514);
            this.pnSpace1.TabIndex = 14;
            // 
            // pnSpace2
            // 
            this.pnSpace2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSpace2.Location = new System.Drawing.Point(675, 29);
            this.pnSpace2.Name = "pnSpace2";
            this.pnSpace2.Size = new System.Drawing.Size(17, 514);
            this.pnSpace2.TabIndex = 15;
            // 
            // pnSpace3
            // 
            this.pnSpace3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSpace3.Location = new System.Drawing.Point(13, 29);
            this.pnSpace3.Name = "pnSpace3";
            this.pnSpace3.Size = new System.Drawing.Size(662, 14);
            this.pnSpace3.TabIndex = 17;
            // 
            // pnSpace4
            // 
            this.pnSpace4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnSpace4.Location = new System.Drawing.Point(13, 529);
            this.pnSpace4.Name = "pnSpace4";
            this.pnSpace4.Size = new System.Drawing.Size(662, 14);
            this.pnSpace4.TabIndex = 18;
            // 
            // panelMainWorkArea
            // 
            this.panelMainWorkArea.BackColor = System.Drawing.Color.White;
            this.panelMainWorkArea.Controls.Add(this.txtSqlServerPassword);
            this.panelMainWorkArea.Controls.Add(this.txtSqlServerUserId);
            this.panelMainWorkArea.Controls.Add(this.txtDatabaseName);
            this.panelMainWorkArea.Controls.Add(this.txtSqlServerName);
            this.panelMainWorkArea.Controls.Add(this.label1);
            this.panelMainWorkArea.Controls.Add(this.lbUserId);
            this.panelMainWorkArea.Controls.Add(this.lbDatabaseName);
            this.panelMainWorkArea.Controls.Add(this.lbSqlServerName);
            this.panelMainWorkArea.Controls.Add(this.txtSmtpPassword);
            this.panelMainWorkArea.Controls.Add(this.txtSmtpUsername);
            this.panelMainWorkArea.Controls.Add(this.txtSmtpPort);
            this.panelMainWorkArea.Controls.Add(this.txtSmtpHost);
            this.panelMainWorkArea.Controls.Add(this.lbSmtpPassword);
            this.panelMainWorkArea.Controls.Add(this.lbSmtpUsername);
            this.panelMainWorkArea.Controls.Add(this.lbSmtpHostName);
            this.panelMainWorkArea.Controls.Add(this.lbSmtpHost);
            this.panelMainWorkArea.Controls.Add(this.rtxtDescription);
            this.panelMainWorkArea.Controls.Add(this.xuiSuperButton_RunInstallationProcess);
            this.panelMainWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainWorkArea.Location = new System.Drawing.Point(13, 43);
            this.panelMainWorkArea.Name = "panelMainWorkArea";
            this.panelMainWorkArea.Size = new System.Drawing.Size(662, 486);
            this.panelMainWorkArea.TabIndex = 19;
            // 
            // txtSqlServerPassword
            // 
            this.txtSqlServerPassword.BackColor = System.Drawing.Color.Linen;
            this.txtSqlServerPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSqlServerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSqlServerPassword.Location = new System.Drawing.Point(213, 379);
            this.txtSqlServerPassword.Name = "txtSqlServerPassword";
            this.txtSqlServerPassword.Size = new System.Drawing.Size(432, 23);
            this.txtSqlServerPassword.TabIndex = 64;
            this.txtSqlServerPassword.UseSystemPasswordChar = true;
            // 
            // txtSqlServerUserId
            // 
            this.txtSqlServerUserId.BackColor = System.Drawing.Color.Linen;
            this.txtSqlServerUserId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSqlServerUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSqlServerUserId.Location = new System.Drawing.Point(213, 345);
            this.txtSqlServerUserId.Name = "txtSqlServerUserId";
            this.txtSqlServerUserId.Size = new System.Drawing.Size(432, 23);
            this.txtSqlServerUserId.TabIndex = 63;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.BackColor = System.Drawing.Color.Linen;
            this.txtDatabaseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabaseName.Location = new System.Drawing.Point(213, 310);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(432, 23);
            this.txtDatabaseName.TabIndex = 62;
            // 
            // txtSqlServerName
            // 
            this.txtSqlServerName.BackColor = System.Drawing.Color.Linen;
            this.txtSqlServerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSqlServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSqlServerName.Location = new System.Drawing.Point(213, 276);
            this.txtSqlServerName.Name = "txtSqlServerName";
            this.txtSqlServerName.Size = new System.Drawing.Size(432, 23);
            this.txtSqlServerName.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "SQL Server - Password:";
            // 
            // lbUserId
            // 
            this.lbUserId.AutoSize = true;
            this.lbUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserId.Location = new System.Drawing.Point(6, 345);
            this.lbUserId.Name = "lbUserId";
            this.lbUserId.Size = new System.Drawing.Size(171, 20);
            this.lbUserId.TabIndex = 59;
            this.lbUserId.Text = "SQL Server - UserID:";
            // 
            // lbDatabaseName
            // 
            this.lbDatabaseName.AutoSize = true;
            this.lbDatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatabaseName.Location = new System.Drawing.Point(6, 313);
            this.lbDatabaseName.Name = "lbDatabaseName";
            this.lbDatabaseName.Size = new System.Drawing.Size(192, 20);
            this.lbDatabaseName.TabIndex = 58;
            this.lbDatabaseName.Text = "SQL Server - DB Name:";
            // 
            // lbSqlServerName
            // 
            this.lbSqlServerName.AutoSize = true;
            this.lbSqlServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSqlServerName.Location = new System.Drawing.Point(6, 279);
            this.lbSqlServerName.Name = "lbSqlServerName";
            this.lbSqlServerName.Size = new System.Drawing.Size(162, 20);
            this.lbSqlServerName.TabIndex = 57;
            this.lbSqlServerName.Text = "SQL Server - Name:";
            // 
            // txtSmtpPassword
            // 
            this.txtSmtpPassword.BackColor = System.Drawing.Color.Linen;
            this.txtSmtpPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSmtpPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSmtpPassword.Location = new System.Drawing.Point(213, 226);
            this.txtSmtpPassword.Name = "txtSmtpPassword";
            this.txtSmtpPassword.Size = new System.Drawing.Size(432, 23);
            this.txtSmtpPassword.TabIndex = 56;
            this.txtSmtpPassword.UseSystemPasswordChar = true;
            // 
            // txtSmtpUsername
            // 
            this.txtSmtpUsername.BackColor = System.Drawing.Color.Linen;
            this.txtSmtpUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSmtpUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSmtpUsername.Location = new System.Drawing.Point(213, 192);
            this.txtSmtpUsername.Name = "txtSmtpUsername";
            this.txtSmtpUsername.Size = new System.Drawing.Size(432, 23);
            this.txtSmtpUsername.TabIndex = 55;
            // 
            // txtSmtpPort
            // 
            this.txtSmtpPort.BackColor = System.Drawing.Color.Linen;
            this.txtSmtpPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSmtpPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSmtpPort.Location = new System.Drawing.Point(213, 157);
            this.txtSmtpPort.Name = "txtSmtpPort";
            this.txtSmtpPort.Size = new System.Drawing.Size(432, 23);
            this.txtSmtpPort.TabIndex = 54;
            // 
            // txtSmtpHost
            // 
            this.txtSmtpHost.BackColor = System.Drawing.Color.Linen;
            this.txtSmtpHost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSmtpHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSmtpHost.Location = new System.Drawing.Point(213, 123);
            this.txtSmtpHost.Name = "txtSmtpHost";
            this.txtSmtpHost.Size = new System.Drawing.Size(432, 23);
            this.txtSmtpHost.TabIndex = 53;
            // 
            // lbSmtpPassword
            // 
            this.lbSmtpPassword.AutoSize = true;
            this.lbSmtpPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSmtpPassword.Location = new System.Drawing.Point(6, 226);
            this.lbSmtpPassword.Name = "lbSmtpPassword";
            this.lbSmtpPassword.Size = new System.Drawing.Size(139, 20);
            this.lbSmtpPassword.TabIndex = 52;
            this.lbSmtpPassword.Text = "SMTP Password:";
            // 
            // lbSmtpUsername
            // 
            this.lbSmtpUsername.AutoSize = true;
            this.lbSmtpUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSmtpUsername.Location = new System.Drawing.Point(6, 192);
            this.lbSmtpUsername.Name = "lbSmtpUsername";
            this.lbSmtpUsername.Size = new System.Drawing.Size(145, 20);
            this.lbSmtpUsername.TabIndex = 51;
            this.lbSmtpUsername.Text = "SMTP UserName:";
            // 
            // lbSmtpHostName
            // 
            this.lbSmtpHostName.AutoSize = true;
            this.lbSmtpHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSmtpHostName.Location = new System.Drawing.Point(6, 160);
            this.lbSmtpHostName.Name = "lbSmtpHostName";
            this.lbSmtpHostName.Size = new System.Drawing.Size(96, 20);
            this.lbSmtpHostName.TabIndex = 50;
            this.lbSmtpHostName.Text = "SMTP Port:";
            // 
            // lbSmtpHost
            // 
            this.lbSmtpHost.AutoSize = true;
            this.lbSmtpHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSmtpHost.Location = new System.Drawing.Point(6, 126);
            this.lbSmtpHost.Name = "lbSmtpHost";
            this.lbSmtpHost.Size = new System.Drawing.Size(101, 20);
            this.lbSmtpHost.TabIndex = 49;
            this.lbSmtpHost.Text = "SMTP Host:";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.BackColor = System.Drawing.Color.Linen;
            this.rtxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtDescription.Location = new System.Drawing.Point(6, 6);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(650, 98);
            this.rtxtDescription.TabIndex = 8;
            this.rtxtDescription.Text = "Hệ thống phát hiện ra rằng dữ liệu trong hệ thống chưa đầy đủ, bạn cần chạy chức " +
    "năng này để hệ thống có thể hoạt động.\n\nTiến trình này sẽ chạy khi bạn nhấn vào " +
    "nút \"Thiết lập hệ thống\".";
            // 
            // xuiSuperButton_RunInstallationProcess
            // 
            this.xuiSuperButton_RunInstallationProcess.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.xuiSuperButton_RunInstallationProcess.ButtonImage = global::BanVeXeKhach.Properties.Resources._4469996;
            this.xuiSuperButton_RunInstallationProcess.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuiSuperButton_RunInstallationProcess.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSuperButton_RunInstallationProcess.ButtonText = "Thiết lập hệ thống";
            this.xuiSuperButton_RunInstallationProcess.CornerRadius = 5;
            this.xuiSuperButton_RunInstallationProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiSuperButton_RunInstallationProcess.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton_RunInstallationProcess.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiSuperButton_RunInstallationProcess.HoverTextColor = System.Drawing.Color.White;
            this.xuiSuperButton_RunInstallationProcess.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSuperButton_RunInstallationProcess.Location = new System.Drawing.Point(139, 440);
            this.xuiSuperButton_RunInstallationProcess.Name = "xuiSuperButton_RunInstallationProcess";
            this.xuiSuperButton_RunInstallationProcess.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.xuiSuperButton_RunInstallationProcess.SelectedTextColor = System.Drawing.Color.White;
            this.xuiSuperButton_RunInstallationProcess.Size = new System.Drawing.Size(336, 40);
            this.xuiSuperButton_RunInstallationProcess.SuperSelected = false;
            this.xuiSuperButton_RunInstallationProcess.TabIndex = 7;
            this.xuiSuperButton_RunInstallationProcess.TextColor = System.Drawing.Color.White;
            this.xuiSuperButton_RunInstallationProcess.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton_RunInstallationProcess.Click += new System.EventHandler(this.xuiSuperButton_RunInstallationProcess_Click);
            // 
            // InstallationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 543);
            this.Controls.Add(this.panelMainWorkArea);
            this.Controls.Add(this.pnSpace4);
            this.Controls.Add(this.pnSpace3);
            this.Controls.Add(this.pnSpace2);
            this.Controls.Add(this.pnSpace1);
            this.Controls.Add(this.panelHeaderBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstallationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstallationForm";
            this.Load += new System.EventHandler(this.InstallationForm_Load);
            this.panelHeaderBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).EndInit();
            this.panelMainWorkArea.ResumeLayout(false);
            this.panelMainWorkArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeaderBar;
        private System.Windows.Forms.PictureBox pbRefresh;
        private System.Windows.Forms.Panel pnSpace22;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.PictureBox pbCancel;
        private System.Windows.Forms.Panel pnSpace1;
        private System.Windows.Forms.Panel pnSpace2;
        private System.Windows.Forms.Panel pnSpace3;
        private System.Windows.Forms.Panel pnSpace4;
        private System.Windows.Forms.Panel panelMainWorkArea;
        private XanderUI.XUISuperButton xuiSuperButton_RunInstallationProcess;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label lbSmtpHostName;
        private System.Windows.Forms.Label lbSmtpHost;
        private System.Windows.Forms.Label lbSmtpPassword;
        private System.Windows.Forms.Label lbSmtpUsername;
        private System.Windows.Forms.TextBox txtSmtpHost;
        private System.Windows.Forms.TextBox txtSqlServerPassword;
        private System.Windows.Forms.TextBox txtSqlServerUserId;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.TextBox txtSqlServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUserId;
        private System.Windows.Forms.Label lbDatabaseName;
        private System.Windows.Forms.Label lbSqlServerName;
        private System.Windows.Forms.TextBox txtSmtpPassword;
        private System.Windows.Forms.TextBox txtSmtpUsername;
        private System.Windows.Forms.TextBox txtSmtpPort;
    }
}