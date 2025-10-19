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
    public partial class Mainfrm : Form
    {
        public Mainfrm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1280, 800);
            // Test Form
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {
           //pnlMenu.BorderStyle = BorderStyle.FixedSingle;
           //pnlMenu.borde

        }
        public void loadUserControl(UserControl userControl)
        {
            pnlContent.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnDanhSachKhachHang_Click(object sender, EventArgs e)
        {
            loadUserControl(new DanhSachHocVienUC());
        }

        private void btnDanhSachThietBi_Click(object sender, EventArgs e)
        {
            loadUserControl(new DanhSachThietBiUC());
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            loadUserControl(new ThongKeDoanhThuUC());
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            loadUserControl(new QuanLyNhanVienUC());
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            loadUserControl(new DanhSachHoaDonUC());
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            loadUserControl(new CheckinKhachVaoUC());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDanfrm frm=new HuongDanfrm();
            frm.ShowDialog();
        }

        private void btnHDPT_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadUserControl(new DanhSachHocVienUC_v2());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadUserControl(new ThongTinHocVien());
        }
    }
}
