using GymManagerment_MVP.MainFeature.HoaDonRelated.GoiTap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymManagerment_MVP.MainFeature.HoaDonRelated
{
    public partial class GoiTapUC : UserControl
    {
        Business.GoiTap goi;
        public event Action<Business.GoiTap> BuyPackge;

        public void setPacketIndor(string name,int duration,bool status)
        {
            lblTenGoi.Text = name;
            lblLoaiHang.Text = (duration/30).ToString();
            if (status == true) { lblState.Text = "Active"; }
            else if (status == false) { lblState.Text = "Unactive"; }

            

        }

        public void setPacketIndoor(Business.GoiTap goi)
        {
            
            //lblTenGoi.Parent = pnGoiContent;
            lblTenGoi.Text = goi.tenGoi;
            if (goi.loaiGoi == 1)
            {
                lblLoaiHang.Text = $"{goi.thoiHanNgay / 30} Thang";
            }
            else
            {
                lblLoaiHang.Text = $"{goi.thoiHanBuoi} Buoi";
            }

            if (goi.hoatDong == true)
            {
                lblState.Text = "Active";
                pnGoiContent.BackColor = Config.main1;
            }
            else
            {
                lblState.Text = "Unactive";
                pnGoiContent.BackColor = Config.main2;
            }


            if (goi.discount != 0)
            {
                lblDiscount.Text = "-" + Math.Round(((double)goi.giaTien / goi.discount)).ToString() + "%";
                lblGiaTri.Text = goi.giaTien.ToString();
                lblThanhTien.Text = (goi.giaTien - goi.discount).ToString();
            }
            else
            {
                lblThanhTien.Text = goi.giaTien.ToString();
            }
        }

        public GoiTapUC()
        {
            InitializeComponent();
        }
        public GoiTapUC(Business.GoiTap goiPara)
        {
            InitializeComponent();
            lblTenGoi.Text = goiPara.tenGoi;
            if (goiPara.loaiGoi == 1)
            {
                lblLoaiHang.Text = $"{goiPara.thoiHanNgay / 30} Thang";
            }
            else
            {
                lblLoaiHang.Text = $"{goiPara.thoiHanBuoi} Buoi";
            }

            if (goiPara.hoatDong == true)
            {
                lblState.Text = "Active";
                pnGoiContent.BackColor = Config.main1;
            }
            else
            {
                lblState.Text = "Unactive";
                pnGoiContent.BackColor = Config.main2;
            }


            if (goiPara.discount != 0)
            {
                lblDiscount.Text = "-" + Math.Round(((double)goiPara.giaTien / goiPara.discount)).ToString() + "%";
                lblGiaTri.Text = goiPara.giaTien.ToString();
                lblThanhTien.Text = (goiPara.giaTien - goiPara.discount).ToString();
            }
            else
            {
                lblThanhTien.Text = goiPara.giaTien.ToString();
            }
            goi = goiPara;

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pbSetting_Click(object sender, EventArgs e)
        {
            ChangePackagefrm frm = new ChangePackagefrm();
            frm.ShowDialog();
        }

        private void cmsConfig_Opening(object sender, CancelEventArgs e)
        {

        }

        private void GoiTapUC_Load(object sender, EventArgs e)
        {
            //pnGoiContent.BackColor = Config.main1;
        }

        private void lblTenGoi_Click(object sender, EventArgs e)
        {

        }

        private void lblThanhTien_Click(object sender, EventArgs e)
        {

        }

        private void btnMuaNgay_Click(object sender, EventArgs e)
        {
            //MuaHang uc = (MuaHang)this;
            BuyPackge?.Invoke(goi);

        }
        
    }
}
