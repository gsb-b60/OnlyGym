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
using System.Data.Sql;
using System.Data.SqlClient;
using GymManagerment_MVP.Business;
using System.Diagnostics;
using System.Net.Http.Headers;
using Business;
using System.Diagnostics.Eventing.Reader;
using System.Net.Security;

namespace GymManagerment_MVP.MainFeature.HoaDonRelated
{
    public partial class BanGoi : UserControl
    {
        public event Action<Business.GoiTap> SetToBill;
        List<Business.GoiTap> ListByMonth=new List<Business.GoiTap>();
        List<Business.GoiTap> ListBySess= new List<Business.GoiTap>();
        List<Business.GoiTap> list;
        public BanGoi()
        {
            InitializeComponent();
        }

        private void BanGoi_Load(object sender, EventArgs e)
        {
            SetUp();

        }
        public void SetUp()
        {
            ListByMonth.Clear();
            ListBySess.Clear();
            GoiTapBL goiBL = new GoiTapBL();
            list = goiBL.GetPackage().OrderByDescending(goi => goi.hoatDong).ToList();
            flpGoiThang.Controls.Clear();
            flpGoiBuoi.Controls.Clear();
            foreach (var p in list)
            {
                GoiTapUC goiTapUC = new GoiTapUC(p);
                goiTapUC.BuyPackge += GoiTapUC_BuyPackge;

                if (p.loaiGoi == 1)
                {
                    ListByMonth.Add(p);
                    flpGoiThang.Controls.Add(goiTapUC);
                }
                else
                {
                    ListBySess.Add(p);
                    flpGoiBuoi.Controls.Add(goiTapUC);
                }
            }
            lblDHD.Text=ListByMonth.Count.ToString();
            lblKHD.Text=ListBySess.Count.ToString();
            lblTKTong.Text=list.Count.ToString();
        }
        public void ApplyFilter()
        {
            List<Business.GoiTap> reMonth = ListByMonth;
            List<Business.GoiTap> reSess = ListBySess;

            if (cbActive.Checked && !cbUnActive.Checked)
            {
                reMonth = reMonth.Where((g) => g.hoatDong == true).ToList();
                reSess = reSess.Where((g) => g.hoatDong == true).ToList();
            }
            else if(!cbActive.Checked && cbUnActive.Checked)
            {
                reMonth = reMonth.Where((g) => g.hoatDong == false).ToList();
                reSess = reSess.Where((g) => g.hoatDong == false).ToList();
            }
            flpGoiThang.Controls.Clear();
            flpGoiBuoi.Controls.Clear();
            foreach (var p in reMonth)
            {
                flpGoiThang.Controls.Add(new GoiTapUC(p));
            }
            foreach (var p in reSess)
            {
                flpGoiBuoi.Controls.Add(new GoiTapUC(p));
            }
        }

        private void GoiTapUC_BuyPackge(Business.GoiTap obj)
        {
            SetToBill.Invoke(obj);
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

        private void cbActive_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cbUnActive_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cbActive.Checked = false;
            cbUnActive.Checked = false;
            SetUp();
        }

        private void lblTKUnactive_Click(object sender, EventArgs e)
        {

        }
    }
}
