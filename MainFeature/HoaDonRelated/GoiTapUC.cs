using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagerment_MVP.MainFeature.HoaDonRelated
{
    public partial class GoiTapUC : UserControl
    {
        string name {  get; set; }

        string duration { get; set; }


        public void setPacketIndor(string name,string duration,int status)
        {
            lblTenGoi.Text = name;
            lblLoaiHang.Text = duration;
            if (status == 0) { lblState.Text = "Đang Hoạt Động"; }
            else if (status == 1) { lblState.Text = "Không Hoạt Động"; }
        }
        public GoiTapUC()
        {
            InitializeComponent();
        }

        private void GoiTapUC_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void btnMuaGoi_Click(object sender, EventArgs e)
        {
            MuaGoiTap frm = new MuaGoiTap();
            frm.ShowDialog();
        }
    }
}
