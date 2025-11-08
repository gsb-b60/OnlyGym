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

namespace GymManagerment_MVP.MainFeature.HoaDonRelated
{
    public partial class BanGoi : UserControl
    {
        public event Action<Business.GoiTap> SetToBill;
        List<Business.GoiTap> list;
        public BanGoi()
        {
            InitializeComponent();
        }

        private void BanGoi_Load(object sender, EventArgs e)
        {
            GoiTapBL goiBL=new GoiTapBL();
            list = goiBL.GetPackage().OrderByDescending(goi => goi.hoatDong).ToList();

            foreach (var p in list)
            {
                GoiTapUC goiTapUC = new GoiTapUC(p);
                //goiTapUC.setPacketIndor(p.tenGoi, p.thoiHanNgay, p.hoatDong);
                //goiTapUC.setPacketIndoor(p);
                goiTapUC.BuyPackge += GoiTapUC_BuyPackge;

                if(p.loaiGoi==1)
                {
                    flpGoiThang.Controls.Add(goiTapUC);
                }
                else
                {
                    flpGoiBuoi.Controls.Add(goiTapUC);
                }
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
    }
}
