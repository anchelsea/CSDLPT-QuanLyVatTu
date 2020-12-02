namespace QLVT_DATHANG
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.bt_dang_nhap = new System.Windows.Forms.Button();
            this.cb_chi_nhanh = new System.Windows.Forms.ComboBox();
            this.tb_dang_nhap = new System.Windows.Forms.TextBox();
            this.tb_mat_khau = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qLVT_DATHANGDataSet_PHANMANH = new QLVT_DATHANG.QLVT_DATHANGDataSet_PHANMANH();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new QLVT_DATHANG.QLVT_DATHANGDataSet_PHANMANHTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.QLVT_DATHANGDataSet_PHANMANHTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet_PHANMANH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_dang_nhap
            // 
            this.bt_dang_nhap.BackColor = System.Drawing.Color.LightCyan;
            this.bt_dang_nhap.Location = new System.Drawing.Point(158, 241);
            this.bt_dang_nhap.Name = "bt_dang_nhap";
            this.bt_dang_nhap.Size = new System.Drawing.Size(204, 49);
            this.bt_dang_nhap.TabIndex = 0;
            this.bt_dang_nhap.Text = "           Đăng nhập  ";
            this.bt_dang_nhap.UseVisualStyleBackColor = false;
            this.bt_dang_nhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_chi_nhanh
            // 
            this.cb_chi_nhanh.DataSource = this.v_DS_PHANMANHBindingSource;
            this.cb_chi_nhanh.DisplayMember = "TENCN";
            this.cb_chi_nhanh.FormattingEnabled = true;
            this.cb_chi_nhanh.Location = new System.Drawing.Point(242, 64);
            this.cb_chi_nhanh.Name = "cb_chi_nhanh";
            this.cb_chi_nhanh.Size = new System.Drawing.Size(151, 21);
            this.cb_chi_nhanh.TabIndex = 1;
            this.cb_chi_nhanh.ValueMember = "TENSERVER";
            // 
            // tb_dang_nhap
            // 
            this.tb_dang_nhap.Location = new System.Drawing.Point(242, 115);
            this.tb_dang_nhap.Name = "tb_dang_nhap";
            this.tb_dang_nhap.Size = new System.Drawing.Size(151, 21);
            this.tb_dang_nhap.TabIndex = 2;
            // 
            // tb_mat_khau
            // 
            this.tb_mat_khau.Location = new System.Drawing.Point(242, 168);
            this.tb_mat_khau.Name = "tb_mat_khau";
            this.tb_mat_khau.Size = new System.Drawing.Size(151, 21);
            this.tb_mat_khau.TabIndex = 3;
            this.tb_mat_khau.UseSystemPasswordChar = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.LightCyan;
            this.pictureBox4.Image = global::QLVT_DATHANG.Properties.Resources.enter;
            this.pictureBox4.Location = new System.Drawing.Point(173, 249);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QLVT_DATHANG.Properties.Resources._lock;
            this.pictureBox3.Location = new System.Drawing.Point(69, 152);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QLVT_DATHANG.Properties.Resources._6405579;
            this.pictureBox2.Location = new System.Drawing.Point(69, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLVT_DATHANG.Properties.Resources.branch;
            this.pictureBox1.Location = new System.Drawing.Point(69, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chi nhánh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mật khẩu";
            // 
            // qLVT_DATHANGDataSet_PHANMANH
            // 
            this.qLVT_DATHANGDataSet_PHANMANH.DataSetName = "QLVT_DATHANGDataSet_PHANMANH";
            this.qLVT_DATHANGDataSet_PHANMANH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.qLVT_DATHANGDataSet_PHANMANH;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.QLVT_DATHANGDataSet_PHANMANHTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 358);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_mat_khau);
            this.Controls.Add(this.tb_dang_nhap);
            this.Controls.Add(this.cb_chi_nhanh);
            this.Controls.Add(this.bt_dang_nhap);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet_PHANMANH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_dang_nhap;
        private System.Windows.Forms.ComboBox cb_chi_nhanh;
        private System.Windows.Forms.TextBox tb_dang_nhap;
        private System.Windows.Forms.TextBox tb_mat_khau;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private QLVT_DATHANGDataSet_PHANMANH qLVT_DATHANGDataSet_PHANMANH;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private QLVT_DATHANGDataSet_PHANMANHTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private QLVT_DATHANGDataSet_PHANMANHTableAdapters.TableAdapterManager tableAdapterManager;
    }
}