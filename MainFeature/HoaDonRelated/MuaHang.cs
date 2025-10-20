using GymManagerment_MVP.Business;
using GymManagerment_MVP.MainFeature.HoaDonRelated;
using GymManagerment_MVP.MainFeature.HoaDonRelated.PT;
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

        public MuaHang()
        {
            InitializeComponent();

        }

        private void flpMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MuaHang_Load(object sender, EventArgs e)
        {

            BanGoi banGoi = new BanGoi();
            banGoi.Dock = DockStyle.Fill;
            pnGoiTap.Controls.Add(banGoi);
            banGoi.BringToFront();

            banGoi.SetToBill += BanGoi_SetToBill;


            DangKyPT dangKyPT = new DangKyPT();
            dangKyPT.Dock = DockStyle.Fill;
            pnPT.Controls.Add(dangKyPT);
            dangKyPT.BringToFront();

            DangKyPTVer2 dangKyPT2 = new DangKyPTVer2();
            dangKyPT2.Dock = DockStyle.Fill;
            pnPTV2.Controls.Add(dangKyPT2);
            dangKyPT.BringToFront();



        }

        private void BanGoi_SetToBill(GoiTap obj)
        {
            ListViewItem item = new ListViewItem();
            item.SubItems[0].Text = obj.tenGoi;
            lvHoaDon.Items.Add(item);
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pnPT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        public void SetBill(GoiTap goi)
        {
            //lvHoaDon.
            ListViewItem item = new ListViewItem();
            item.SubItems[0].Text = goi.tenGoi;
            lvHoaDon.Items.Add(item);

        }
    }
}
