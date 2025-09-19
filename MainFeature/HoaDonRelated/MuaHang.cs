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
            flpMain.Controls.Clear();

            string duration = "Buoi";
            int count;
            
            for (int i = 1; i < 20; i++)
            {
                int status = i % 2==0 ? 1 : 0;
                if (i > 4)
                {
                    duration = "Tháng";
                    count = i - 4;
                }
                else
                {
                    count = (i+1)*10;
                }
                GoiTapUC goiTapUC = new GoiTapUC();
                goiTapUC.setPacketIndor($"goi {i}", $"{count} {duration}",status );
                flpMain.Controls.Add(goiTapUC);
            }
        }
    }
}
