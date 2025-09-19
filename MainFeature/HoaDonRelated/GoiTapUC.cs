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
    }
}
