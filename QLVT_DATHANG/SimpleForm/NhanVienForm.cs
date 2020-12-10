using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QLVT_DATHANG
{
    public partial class NhanVienForm : DevExpress.XtraEditors.XtraForm
    {
        private int position;
        private string maCN = "";
        public NhanVienForm()
        {
            InitializeComponent();
        }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet_DS_NHANVIEN.ChiNhanh' table. You can move, or remove it, as needed.
            this.chiNhanhTableAdapter.Fill(this.qLVT_DATHANGDataSet.ChiNhanh);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet_DS_NHANVIEN.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);



            this.cbChiNhanh.DataSource = Program.bds_dspm; //DataSource của cbChiNhanh tham chiếu đến bindingSource ở LoginForm
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";
        }

        public static int newMANV()
        {
            string query = "SELECT MAX(MANV) FROM QLVT_DATHANG.DBO.NHANVIEN";

            int maNvNew = 0;


            using (SqlConnection sqlConnection = new SqlConnection(Program.connstr))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                try
                {
                    maNvNew = (Int32)sqlCommand.ExecuteScalar();

                    return maNvNew + 1;    //Nếu duyệt từ bé đến lớn trong dãy không có MANV mới sẽ +1 lên
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm Mã Nhân Viên mới! \n" + ex.Message, "Notification", MessageBoxButtons.OK);

                }
            }

            return -1;  //Không tìm thấy trả -1 đánh dấu Dừng chương trình
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gb_tt_nhanvien_Enter(object sender, EventArgs e)
        {

        }

        private void trangThaiXoaCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }


        private bool checkValidate(NumericUpDown nu, string str)
        {
            if (nu.Value == 0)
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nu.Focus();
                return false;
            }
            return true;
        }

        private bool checkValidate(TextEdit tb, string str)
        {
            if (tb.Text.Trim().Equals(""))
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;
            }
            return true;
        }

        //Button
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = nhanVienBindingSource.Position;
            this.nhanVienBindingSource.AddNew();
            //Giá trị mặc định khi Thêm NV
            mANVNumericUpDown.Value = newMANV();
            lUONGSpinEdit.Value = 4000000;
            ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["LUONG"] = 4000000;
            mACNTextEdit.Text = maCN;
            trangThaiXoaCheckBox.Checked = trangThaiXoaCheckBox.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = gcNhanVien.Enabled = false;
            btnChuyenCN.Enabled = btnRefresh.Enabled = false;
            btnUndo.Enabled = gb_thongtinNV.Enabled = btnLuu.Enabled = true;
            Program.flagCloseFormNV = false;    //Bật cờ lên để chặn tắt Form đột ngột khi nhập liệu
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkValidate(mANVNumericUpDown, "Mã NV is not empty!")) return;
            if (!checkValidate(hOTextEdit, "Họ is not empty!")) return;
            if (!checkValidate(tENTextEdit, "Tên is not empty!")) return;
            if (nGAYSINHDateEdit.Text.Equals(""))
            {
                MessageBox.Show("Ngày sinh is not empty!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nGAYSINHDateEdit.Focus();
                return;
            }


            string query = "DECLARE	@result int " +
                           "EXEC @result = SP_CheckID @p1, @p2 " +
                           "SELECT 'result' = @result";


            SqlDataReader dataReader = null;


            using (SqlConnection sqlConnection = new SqlConnection(Program.connstr))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand1 = new SqlCommand(query, sqlConnection);
                sqlCommand1.CommandType = CommandType.Text;
                sqlCommand1.Parameters.AddWithValue("@p1", mANVNumericUpDown.Value);
                sqlCommand1.Parameters.AddWithValue("@p2", "MANV");
                try
                {
                    dataReader = sqlCommand1.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực thi Database!\n" + ex.Message, "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                dataReader.Read();
                int result = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();

                int positionMANV = nhanVienBindingSource.Find("MANV", mANVNumericUpDown.Value);
                int postionCurrent = nhanVienBindingSource.Position;
                //Bỏ qua TH tồn tại ở CN hiện tại khi vị trí MANV đang nhập đúng băng vị trí đang đứng
                if (result == 1 && (positionMANV != postionCurrent))
                {
                    MessageBox.Show("Mã NV đã tồn tại ở Chi Nhánh hiện tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (result == 2)
                {
                    MessageBox.Show("Mã NV đã tồn tại ở Chi Nhánh khác!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        try
                        {
                            Program.flagCloseFormNV = true; //Bật cờ cho phép tắt Form NV
                            btnThem.Enabled = btnXoa.Enabled = gcNhanVien.Enabled = true;
                            btnChuyenCN.Enabled = btnRefresh.Enabled = true;
                            btnUndo.Enabled = gb_thongtinNV.Enabled = btnLuu.Enabled = false;
                            this.nhanVienBindingSource.EndEdit();
                            this.nhanVienTableAdapter.Update(this.qLVT_DATHANGDataSet.NhanVien);
                            nhanVienBindingSource.Position = position;
                        }
                        catch (Exception ex)
                        {
                            //Khi Update database lỗi thì xóa record vừa thêm trong bds
                            nhanVienBindingSource.RemoveCurrent();
                            MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}