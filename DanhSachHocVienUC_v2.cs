using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymManagerment_MVP
{
    public partial class DanhSachHocVienUC_v2 : UserControl
    {
        public DanhSachHocVienUC_v2()
        {
            InitializeComponent();
        }

        private void gbDanhSachHocVien_Enter(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void cbFindB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvDanhSachHV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSachHV.SelectedItems.Count > 0)
            {
                var selectedItem = lvDanhSachHV.SelectedItems[0];
                string memberId = selectedItem.SubItems[0].Text; // ví dụ cột 0 là ID
                pnlProfile.Visible = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = false;
        }

        private void pnlProfile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPFDangKyPT_Click(object sender, EventArgs e)
        {

        }
    }
}
