using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagerment_MVP
{
    public partial class ThemHocVienfrm : Form
    {
        public ThemHocVienfrm()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDKGoi_Click(object sender, EventArgs e)
        {
            Form frm = new DangKyGoiTap();
            frm.ShowDialog();
        }
    }
}
