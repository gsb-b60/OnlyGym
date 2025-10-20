using GymManagerment_MVP.MainFeature.HocVienRelated;
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
    public partial class ThongTinHocVien : UserControl
    {
        public ThongTinHocVien()
        {
            InitializeComponent();
        }

        private void lblPFCongNo_Click(object sender, EventArgs e)
        {

        }

        private void gbThongTinHD_Enter(object sender, EventArgs e)
        {

        }

        private void gbThongTinGoiTap_Enter(object sender, EventArgs e)
        {

        }

        private void lvThongTinHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblGoi_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void lvLichSuTap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvThongTinPT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ThongTinHocVien_Load(object sender, EventArgs e)
        {
            ThongTinGoiTapUC goitap = new ThongTinGoiTapUC();
            goitap.Dock= DockStyle.Fill;
            tabGoi.Controls.Add(goitap);
            goitap.BringToFront();


            ThongTinCheckInUC thongTinCheckInUC = new ThongTinCheckInUC();
            thongTinCheckInUC.Dock = DockStyle.Fill;
            tabCheckIn.Controls.Add(thongTinCheckInUC);
            thongTinCheckInUC.BringToFront();


            ThongTinGoiTapPTUC thongTinGoiTapPTUC=new ThongTinGoiTapPTUC();
            thongTinGoiTapPTUC.Dock = DockStyle.Fill;
            tabLichSuPT.Controls.Add(thongTinGoiTapPTUC);
            thongTinGoiTapPTUC.BringToFront();

            ThongTinHoaDonUC thongTinHoaDonUC = new ThongTinHoaDonUC();
            thongTinHoaDonUC.Dock = DockStyle.Fill;
            tabHóaĐơn.Controls.Add(thongTinHoaDonUC);
            thongTinHoaDonUC.BringToFront();
        }
    }
}
