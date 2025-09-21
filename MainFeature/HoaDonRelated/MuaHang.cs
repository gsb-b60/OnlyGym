using GymManagerment_MVP.MainFeature.HoaDonRelated;
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

            for (int i = 1; i <= 5; i++)
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
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {

        }
    }
}
