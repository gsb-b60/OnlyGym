using GymManagerment_MVP.Business;
using GymManagerment_MVP.MainFeature.HoaDonRelated.GoiTap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagerment_MVP.MainFeature.HoaDonRelated.PT
{
    public partial class GoiPTUC : UserControl
    {
        GoiPT goi;

        public event Action<GoiPT> BuyPackage;
        public event Action Next;
        public GoiPTUC()
        {
            InitializeComponent();
        }
        public GoiPTUC(GoiPT goiPara)
        {
            InitializeComponent();
            setPacketIndoor(goiPara);
            goi = goiPara;
        }
        private void btnMuaGoi_Click(object sender, EventArgs e)
        {
            BuyPackage.Invoke(goi);
            Next.Invoke();
        }

        private void pbSetting_Click(object sender, EventArgs e)
        {
            ChangePackagefrm frm = new ChangePackagefrm();
            frm.ShowDialog();
        }
        public void setPacketIndoor(GoiPT goiPara)
        {
            lblTenGoi.Text = goiPara.tenGoi;
            lblLoaiHang.Text = $"{goiPara.soBuoi} Buoi";

            if (goiPara.trangThai== true)
            {
                lblState.Text = "Active";
                pnlContent.BackColor = Config.main1;
            }
            else
            {
                lblState.Text = "Unactive";
                pnlContent.BackColor = Config.main2;
            }


            if (goiPara.discount != 0)
            {
                lblDiscount.Text = "-" + Math.Round(((goiPara.discount / (double)goiPara.giaTien))*100).ToString() + "%";
                lblGiaTri.Text = string.Format("{0:N0} đ", goiPara.giaTien);
                lblThanhTien.Text = string.Format("{0:N0} đ", goiPara.giaTien - goiPara.discount);
            }
            else
            {
                lblThanhTien.Text = goiPara.giaTien.ToString();
            }
            btnChon.Enabled = goiPara.trangThai;
        }
    }
}
