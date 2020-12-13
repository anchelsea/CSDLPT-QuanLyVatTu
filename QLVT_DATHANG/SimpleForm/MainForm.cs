using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QLVT_DATHANG
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
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

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

 

        private void barbtnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(NhanVienForm));
            if (form != null) form.Activate();
            else
            {
                Program.nhanVienForm = new NhanVienForm();
                //Program.nhanVienForm.MdiParent = this;
                Program.nhanVienForm.Show();
            }
        }
    }
}