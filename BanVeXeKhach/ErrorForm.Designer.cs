
namespace BanVeXeKhach
{
    partial class ErrorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorForm));
            this.panelHeaderBar = new System.Windows.Forms.Panel();
            this.btnTitle = new System.Windows.Forms.Button();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.pbCancel = new System.Windows.Forms.PictureBox();
            this.panelFooterBar = new System.Windows.Forms.Panel();
            this.lbFooter2 = new System.Windows.Forms.Label();
            this.lbFooter1 = new System.Windows.Forms.Label();
            this.pnSpace1 = new System.Windows.Forms.Panel();
            this.pnSpace2 = new System.Windows.Forms.Panel();
            this.pnSpace4 = new System.Windows.Forms.Panel();
            this.pnSpace3 = new System.Windows.Forms.Panel();
            this.pnMessage = new System.Windows.Forms.Panel();
            this.rtxtMessage = new System.Windows.Forms.RichTextBox();
            this.pnSpace8 = new System.Windows.Forms.Panel();
            this.lbMessage = new System.Windows.Forms.Label();
            this.pnSpace5 = new System.Windows.Forms.Panel();
            this.pnStackTrace = new System.Windows.Forms.Panel();
            this.rtxtStackTrace = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbStackTrace = new System.Windows.Forms.Label();
            this.panelHeaderBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).BeginInit();
            this.panelFooterBar.SuspendLayout();
            this.pnMessage.SuspendLayout();
            this.pnStackTrace.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeaderBar
            // 
            this.panelHeaderBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
            this.panelHeaderBar.Controls.Add(this.btnTitle);
            this.panelHeaderBar.Controls.Add(this.pbIcon);
            this.panelHeaderBar.Controls.Add(this.pbCancel);
            this.panelHeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderBar.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderBar.Name = "panelHeaderBar";
            this.panelHeaderBar.Size = new System.Drawing.Size(880, 29);
            this.panelHeaderBar.TabIndex = 7;
            this.panelHeaderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeaderBar_MouseDown);
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
            this.btnTitle.Size = new System.Drawing.Size(289, 29);
            this.btnTitle.TabIndex = 2;
            this.btnTitle.Text = "NGOẠI LỆ";
            this.btnTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTitle.UseVisualStyleBackColor = false;
            // 
            // pbIcon
            // 
            this.pbIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbIcon.Image = global::BanVeXeKhach.Properties.Resources._4469996;
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
            this.pbCancel.Location = new System.Drawing.Point(848, 0);
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
            this.panelFooterBar.Location = new System.Drawing.Point(0, 479);
            this.panelFooterBar.Name = "panelFooterBar";
            this.panelFooterBar.Size = new System.Drawing.Size(880, 35);
            this.panelFooterBar.TabIndex = 8;
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
            // lbFooter1
            // 
            this.lbFooter1.AutoSize = true;
            this.lbFooter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFooter1.Location = new System.Drawing.Point(15, 9);
            this.lbFooter1.Name = "lbFooter1";
            this.lbFooter1.Size = new System.Drawing.Size(264, 17);
            this.lbFooter1.TabIndex = 0;
            this.lbFooter1.Text = "Đồ án môn CN .NET, PTTKHTTT, CNPM";
            this.lbFooter1.Click += new System.EventHandler(this.lbFooter1_Click);
            // 
            // pnSpace1
            // 
            this.pnSpace1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSpace1.Location = new System.Drawing.Point(0, 29);
            this.pnSpace1.Name = "pnSpace1";
            this.pnSpace1.Size = new System.Drawing.Size(13, 450);
            this.pnSpace1.TabIndex = 13;
            // 
            // pnSpace2
            // 
            this.pnSpace2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSpace2.Location = new System.Drawing.Point(863, 29);
            this.pnSpace2.Name = "pnSpace2";
            this.pnSpace2.Size = new System.Drawing.Size(17, 450);
            this.pnSpace2.TabIndex = 14;
            // 
            // pnSpace4
            // 
            this.pnSpace4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnSpace4.Location = new System.Drawing.Point(13, 465);
            this.pnSpace4.Name = "pnSpace4";
            this.pnSpace4.Size = new System.Drawing.Size(850, 14);
            this.pnSpace4.TabIndex = 15;
            // 
            // pnSpace3
            // 
            this.pnSpace3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSpace3.Location = new System.Drawing.Point(13, 29);
            this.pnSpace3.Name = "pnSpace3";
            this.pnSpace3.Size = new System.Drawing.Size(850, 14);
            this.pnSpace3.TabIndex = 16;
            // 
            // pnMessage
            // 
            this.pnMessage.BackColor = System.Drawing.Color.White;
            this.pnMessage.Controls.Add(this.rtxtMessage);
            this.pnMessage.Controls.Add(this.pnSpace8);
            this.pnMessage.Controls.Add(this.lbMessage);
            this.pnMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMessage.Location = new System.Drawing.Point(13, 43);
            this.pnMessage.Name = "pnMessage";
            this.pnMessage.Size = new System.Drawing.Size(850, 96);
            this.pnMessage.TabIndex = 17;
            // 
            // rtxtMessage
            // 
            this.rtxtMessage.BackColor = System.Drawing.Color.Linen;
            this.rtxtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtMessage.Location = new System.Drawing.Point(0, 39);
            this.rtxtMessage.Name = "rtxtMessage";
            this.rtxtMessage.Size = new System.Drawing.Size(850, 57);
            this.rtxtMessage.TabIndex = 27;
            this.rtxtMessage.Text = "";
            // 
            // pnSpace8
            // 
            this.pnSpace8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnSpace8.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSpace8.Location = new System.Drawing.Point(0, 29);
            this.pnSpace8.Name = "pnSpace8";
            this.pnSpace8.Size = new System.Drawing.Size(850, 10);
            this.pnSpace8.TabIndex = 25;
            // 
            // lbMessage
            // 
            this.lbMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.Red;
            this.lbMessage.Location = new System.Drawing.Point(0, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(850, 29);
            this.lbMessage.TabIndex = 0;
            this.lbMessage.Text = "Thông báo lỗi";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnSpace5
            // 
            this.pnSpace5.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSpace5.Location = new System.Drawing.Point(13, 139);
            this.pnSpace5.Name = "pnSpace5";
            this.pnSpace5.Size = new System.Drawing.Size(850, 14);
            this.pnSpace5.TabIndex = 18;
            // 
            // pnStackTrace
            // 
            this.pnStackTrace.BackColor = System.Drawing.Color.White;
            this.pnStackTrace.Controls.Add(this.rtxtStackTrace);
            this.pnStackTrace.Controls.Add(this.panel1);
            this.pnStackTrace.Controls.Add(this.lbStackTrace);
            this.pnStackTrace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnStackTrace.Location = new System.Drawing.Point(13, 153);
            this.pnStackTrace.Name = "pnStackTrace";
            this.pnStackTrace.Size = new System.Drawing.Size(850, 312);
            this.pnStackTrace.TabIndex = 19;
            // 
            // rtxtStackTrace
            // 
            this.rtxtStackTrace.BackColor = System.Drawing.Color.Linen;
            this.rtxtStackTrace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtStackTrace.Location = new System.Drawing.Point(0, 39);
            this.rtxtStackTrace.Name = "rtxtStackTrace";
            this.rtxtStackTrace.Size = new System.Drawing.Size(850, 273);
            this.rtxtStackTrace.TabIndex = 26;
            this.rtxtStackTrace.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 10);
            this.panel1.TabIndex = 25;
            // 
            // lbStackTrace
            // 
            this.lbStackTrace.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbStackTrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStackTrace.ForeColor = System.Drawing.Color.Red;
            this.lbStackTrace.Location = new System.Drawing.Point(0, 0);
            this.lbStackTrace.Name = "lbStackTrace";
            this.lbStackTrace.Size = new System.Drawing.Size(850, 29);
            this.lbStackTrace.TabIndex = 1;
            this.lbStackTrace.Text = "Stack trace";
            this.lbStackTrace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 514);
            this.Controls.Add(this.pnStackTrace);
            this.Controls.Add(this.pnSpace5);
            this.Controls.Add(this.pnMessage);
            this.Controls.Add(this.pnSpace3);
            this.Controls.Add(this.pnSpace4);
            this.Controls.Add(this.pnSpace2);
            this.Controls.Add(this.pnSpace1);
            this.Controls.Add(this.panelFooterBar);
            this.Controls.Add(this.panelHeaderBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ErrorForm";
            this.Text = "ErrorForm";
            this.Load += new System.EventHandler(this.ErrorForm_Load);
            this.panelHeaderBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).EndInit();
            this.panelFooterBar.ResumeLayout(false);
            this.panelFooterBar.PerformLayout();
            this.pnMessage.ResumeLayout(false);
            this.pnStackTrace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeaderBar;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.PictureBox pbCancel;
        private System.Windows.Forms.Panel panelFooterBar;
        private System.Windows.Forms.Label lbFooter2;
        private System.Windows.Forms.Label lbFooter1;
        private System.Windows.Forms.Panel pnSpace1;
        private System.Windows.Forms.Panel pnSpace2;
        private System.Windows.Forms.Panel pnSpace4;
        private System.Windows.Forms.Panel pnSpace3;
        private System.Windows.Forms.Panel pnMessage;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Panel pnSpace5;
        private System.Windows.Forms.Panel pnStackTrace;
        private System.Windows.Forms.Label lbStackTrace;
        private System.Windows.Forms.RichTextBox rtxtMessage;
        private System.Windows.Forms.Panel pnSpace8;
        private System.Windows.Forms.RichTextBox rtxtStackTrace;
        private System.Windows.Forms.Panel panel1;
    }
}