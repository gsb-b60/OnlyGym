using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagerment_MVP.MainFeature.HoaDonRelated.PT._4stepdk
{
    public partial class Step1 : UserControl
    {
        public Step1()
        {
            
            InitializeComponent();
        }

        private void s1flp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Step1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 8; i++)
            {
                GoiPTUC goiTapUC = new GoiPTUC();
                goiTapUC.setPacketIndor($"goi {i}", $"{i}0 Buổi", 0);
                s1flp.Controls.Add(goiTapUC);
            }
        }
    }
}
