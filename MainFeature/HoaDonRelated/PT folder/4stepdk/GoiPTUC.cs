using GymManagerment_MVP.MainFeature.HoaDonRelated.GoiTap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagerment_MVP.MainFeature.HoaDonRelated.PT
{
    public partial class GoiPTUC : UserControl
    {
        public GoiPTUC()
        {
            InitializeComponent();
        }

        private void btnMuaGoi_Click(object sender, EventArgs e)
        {

        }

        private void pbSetting_Click(object sender, EventArgs e)
        {
            ChangePackagefrm frm = new ChangePackagefrm();
            frm.ShowDialog();
        }
        public void setPacketIndor(string name, string duration, int status)
        {
            lblTenGoi.Text = name;
            lblLoaiHang.Text = duration;
            if (status == 0) { lblState.Text = "Đang Hoạt Động"; }
            else if (status == 1) { lblState.Text = "Không Hoạt Động"; }
        }
    }
}
