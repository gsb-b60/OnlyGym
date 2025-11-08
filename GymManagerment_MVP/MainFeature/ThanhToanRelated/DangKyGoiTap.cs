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
    public partial class DangKyGoiTap : Form
    {
        public DangKyGoiTap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTienMat_Click(object sender, EventArgs e)
        {
            LoadThongTin(new ThanhToanTienMatUCcs());
        }
        private void LoadThongTin(UserControl userControl)
        {
            pnThanhToan.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnThanhToan.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadThongTin(new ThanhToanChuyenKhoanUC());
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
