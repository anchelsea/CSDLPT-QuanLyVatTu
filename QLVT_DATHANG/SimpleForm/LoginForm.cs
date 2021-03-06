﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLVT_DATHANG
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet_PHANMANH.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DATHANGDataSet_PHANMANH.V_DS_PHANMANH);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_dang_nhap.Text.Trim() == "" || tb_mat_khau.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được bỏ trống");
                return;
            }
            Program.mlogin = tb_dang_nhap.Text.Trim();
            Program.password = tb_mat_khau.Text.Trim();
            Program.servername = cb_chi_nhanh.SelectedValue.ToString();

            if (Program.KetNoi() == 0) return;


            Program.mChinhanh = cb_chi_nhanh.SelectedIndex;
            Console.WriteLine(Program.mChinhanh);
            Program.bds_dspm = v_DS_PHANMANHBindingSource;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            String strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn không có quyền truy cập dữ liệu");
                return;
            }

            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Form frm = this.CheckExists(typeof(frmMain));
            if (frm != null) frm.Activate();
            else
            {
                this.Hide();
                frmMain f = new frmMain();
                f.Show();
               // NhanVienForm f = new NhanVienForm();
                //f.Show();
            }

            Program.myReader.Close();
            Program.conn.Close();
        }

        private void Exit(object sender, EventArgs e)
        {
            //this.Close();
            System.Windows.Forms.Application.Exit();
        }
    }
}