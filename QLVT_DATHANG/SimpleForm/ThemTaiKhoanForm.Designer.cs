﻿namespace QLVT_DATHANG
{
    partial class ThemTaiKhoanForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.rdUser = new System.Windows.Forms.RadioButton();
            this.rdChiNhanh = new System.Windows.Forms.RadioButton();
            this.rdCongTy = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.cbShow = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1163, 571);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.rdUser);
            this.panel1.Controls.Add(this.rdChiNhanh);
            this.panel1.Controls.Add(this.rdCongTy);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbUser);
            this.panel1.Controls.Add(this.cbShow);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(565, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 420);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLVT_DATHANG.Properties.Resources.add_user__1_;
            this.pictureBox1.Location = new System.Drawing.Point(252, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Location = new System.Drawing.Point(243, 300);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(135, 49);
            this.btnSubmit.TabIndex = 39;
            this.btnSubmit.Text = "Thêm tài khoản";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnUser.Location = new System.Drawing.Point(411, 230);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(31, 21);
            this.btnUser.TabIndex = 34;
            this.btnUser.Text = "...";
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // rdUser
            // 
            this.rdUser.AutoSize = true;
            this.rdUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdUser.Location = new System.Drawing.Point(369, 266);
            this.rdUser.Name = "rdUser";
            this.rdUser.Size = new System.Drawing.Size(52, 20);
            this.rdUser.TabIndex = 38;
            this.rdUser.TabStop = true;
            this.rdUser.Text = "User";
            this.rdUser.UseVisualStyleBackColor = true;
            // 
            // rdChiNhanh
            // 
            this.rdChiNhanh.AutoSize = true;
            this.rdChiNhanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdChiNhanh.Location = new System.Drawing.Point(282, 266);
            this.rdChiNhanh.Name = "rdChiNhanh";
            this.rdChiNhanh.Size = new System.Drawing.Size(83, 20);
            this.rdChiNhanh.TabIndex = 37;
            this.rdChiNhanh.TabStop = true;
            this.rdChiNhanh.Text = "Chi nhánh";
            this.rdChiNhanh.UseVisualStyleBackColor = true;
            // 
            // rdCongTy
            // 
            this.rdCongTy.AutoSize = true;
            this.rdCongTy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdCongTy.Location = new System.Drawing.Point(205, 266);
            this.rdCongTy.Name = "rdCongTy";
            this.rdCongTy.Size = new System.Drawing.Size(69, 20);
            this.rdCongTy.TabIndex = 36;
            this.rdCongTy.TabStop = true;
            this.rdCongTy.Text = "Công ty";
            this.rdCongTy.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Chức vụ:";
            // 
            // tbUser
            // 
            this.tbUser.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbUser.Enabled = false;
            this.tbUser.Location = new System.Drawing.Point(204, 230);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(201, 23);
            this.tbUser.TabIndex = 33;
            // 
            // cbShow
            // 
            this.cbShow.AutoSize = true;
            this.cbShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShow.Location = new System.Drawing.Point(411, 198);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(109, 20);
            this.cbShow.TabIndex = 32;
            this.cbShow.Text = "Hiện mật khẩu";
            this.cbShow.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nhân viên:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(204, 196);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(201, 23);
            this.tbPassword.TabIndex = 30;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Mật khẩu:";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(204, 162);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(201, 23);
            this.tbLogin.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // ThemTaiKhoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 571);
            this.Controls.Add(this.groupBox2);
            this.IconOptions.Image = global::QLVT_DATHANG.Properties.Resources.add_user__1_;
            this.Name = "ThemTaiKhoanForm";
            this.Text = "Thêm tài khoản";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.RadioButton rdUser;
        private System.Windows.Forms.RadioButton rdChiNhanh;
        private System.Windows.Forms.RadioButton rdCongTy;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.CheckBox cbShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label1;
    }
}