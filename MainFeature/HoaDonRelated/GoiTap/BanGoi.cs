using GymManagerment_MVP.MainFeature.HoaDonRelated.GoiTap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagerment_MVP.MainFeature.HoaDonRelated
{
    public partial class BanGoi : UserControl
    {
        public BanGoi()
        {
            InitializeComponent();
        }

        private void BanGoi_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <=19; i++)
            {
                GoiTapUC goiTapUC = new GoiTapUC();
                goiTapUC.setPacketIndor($"goi {i}", $"{i}0 Buổi", 0);
                tb2flp.Controls.Add(goiTapUC);
            }
            for (int i = 1; i <= 5; i++)
            {
                GoiTapUC goiTapUC = new GoiTapUC();
                goiTapUC.setPacketIndor($"goi {i}", $"{i} Tháng", 0);
                tb1flp1.Controls.Add(goiTapUC);
            }
            for (int i = 1; i <= 3; i++)
            {
                GoiTapUC goiTapUC = new GoiTapUC();
                goiTapUC.setPacketIndor($"goi {i}", $"{i} Năm", 0);
                tb3flp1.Controls.Add(goiTapUC);
            }
        }

        private void btnChinhSuaGoi_Click(object sender, EventArgs e)
        {
            ThemGoiTapfrm frm=new ThemGoiTapfrm();
            frm.ShowDialog();
        }

        private void tb2flp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tab2flp1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDaXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
