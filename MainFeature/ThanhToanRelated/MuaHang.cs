using GymManagerment_MVP.SideFeature;
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
    public partial class MuaHang : UserControl
    {
        HangHoa hh = new HangHoa();

        public MuaHang()
        {
            InitializeComponent();

        }

        private void MuaHang_Load(object sender, EventArgs e)
        {
            //LoadDanhMuc(DanhMucHangHoa.ListDanhMuc);
        }

        private void tbThanhTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemDM_Click(object sender, EventArgs e)
        {

        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cmsDsHangMua_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tsmiBoHang_Click(object sender, EventArgs e)
        {

        }

        private void tsmiXoaBot_Click(object sender, EventArgs e)
        {

        }

        private void MuaHangUC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lvHangMua_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayMua_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chbInHoaDon_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void tbSDTKhanhMua_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbGiamGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbKhachDua_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTenKhanhMua_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbHinhThuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbNhanVienLap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lbConLai_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tbTimDanhMuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbTimTheo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void flpDanhMuc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDSHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        //private void LoadDanhMuc()
        //{
        //    flpDanhMuc.Controls.Clear();
        //    foreach (var danhMuc in list)
        //    {
        //        var btn = new Button();
        //        btn.Text = danhMuc.TenHang;
        //        btn.Size = new Size(205, 30);
        //        btn.BackColor = Color.LightBlue;
        //        btn.Tag = danhMuc.ID;
        //        //btn.Click += HangHoaButton_Click;

        //        flpDanhMuc.Controls.Add(btn);
        //    }
        //}


    }
}
