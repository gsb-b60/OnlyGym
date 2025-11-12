using DataAccess.Object;
using GymManagerment_MVP.Business;
using GymManagerment_MVP.MainFeature.HoaDonRelated.PT;
using GymManagerment_MVP.MainFeature.HoaDonRelated.PT._4stepdk;
using GymManagerment_MVP.MainFeature.HoaDonRelated.PT.HopDongPT;
using GymManagerment_MVP.MainFeature.Main;
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
        private FrmCheckIn frm;
        public User user=new User();

        public Mainfrm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1280, 800);
            loadUserControl(new MuaHang());
            // Test Form
        }
        public Mainfrm(User user)
        {
            InitializeComponent();
            this.user= user;
            this.MinimumSize = new Size(1280, 800);
            loadUserControl(new MuaHang());
            // Test Form
            lblAccName.Text = user.TenTK;
            lblChucVu.Text = user.TrangThai.ToString();
            if(user.TrangThai==TrangThaiTK.Admin)
            {
                btnTaiKhoan.Visible = true;
            }
            //FrmCheckIn frm = new FrmCheckIn();
            ////frm.Show();

            //if (frm== null || frm.IsDisposed)
            //{
            //    frm = frm = new FrmCheckIn();
            //    frm.Show();// Not blocking
            //}
            //else
            //{
            //    frm.Focus(); // Bring to front if already open
            //}
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
            loadUserControl(new MuaHang());
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            loadUserControl(new XuatHoaDonUC());
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
            //loadUserControl(new ThongTinHocVien());
            OpenHocVienUC();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            loadUserControl(new DanhSachHocVienUC_v2());
        }

        private void thôngTinChuyênMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadUserControl(new ThongTinChuyenMonUC());
        }


        private void btnDSPT_Click(object sender, EventArgs e)
        {
            loadUserControl(new DanhSachPTUC());
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            loadUserControl(new DanhSachHopDongPTUC());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            loadUserControl(new ThongTinHopDongPTUC());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadUserControl(new DanhSachHoaDonUC());
        }
        public void MoMuaHang()
        {
            loadUserControl(new MuaHang());
        }
        public void OpenHocVienUC(string code = null)
        {
            // Giả sử bạn đã có một panel để chứa user control, ví dụ: pnlMain
            pnlContent.Controls.Clear();

            // Khởi tạo hoặc tái sử dụng UserControl thông tin học viên
            var thongTinUC = new ThongTinHocVien(); // hoặc dùng tên thật của UC thông tin học viên
            pnlContent.Controls.Add(thongTinUC);
            thongTinUC.Dock = DockStyle.Fill;

            // Gọi hàm hiển thị chi tiết học viên
            if (!string.IsNullOrEmpty(code))
            {
                thongTinUC.DisplayThoTinHocVien(code);
            }
        }
        public void OpenMuaHang(string code)
        {
            loadUserControl(new MuaHang(code,user));
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            loadUserControl(new QLTaiKhoanUC());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Retry;
            this.Close();
        }
    }
}
