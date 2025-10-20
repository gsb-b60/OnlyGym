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
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using GymManagerment_MVP.Business;
using System.Diagnostics;

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
            //for (int i = 1; i <=19; i++)
            //{
            //    GoiTapUC goiTapUC = new GoiTapUC();
            //    goiTapUC.setPacketIndor($"goi {i}", $"{i}0 Buổi", 0);
            //    tb2flp.Controls.Add(goiTapUC);
            //}
            //for (int i = 1; i <= 5; i++)
            //{
            //    GoiTapUC goiTapUC = new GoiTapUC();
            //    goiTapUC.setPacketIndor($"goi {i}", $"{i} Tháng", 0);
            //    ptlGoiThang.Controls.Add(goiTapUC);
            //}
            //for (int i = 1; i <= 3; i++)
            //{
            //    GoiTapUC goiTapUC = new GoiTapUC();
            //    goiTapUC.setPacketIndor($"goi {i}", $"{i} Năm", 0);
            //    tb3flp1.Controls.Add(goiTapUC);
            //}
            //Config config=new Config();
            //SqlConnection connection = new SqlConnection(Config.connection);
            //SqlCommand sqlCommand = connection.CreateCommand();

            //List<Business.GoiTap> package=new List<Business.GoiTap>();

            //sqlCommand.CommandText = "select * from GoiTap";
            //connection.Open();
            //using (SqlDataReader reader = sqlCommand.ExecuteReader()) {
            //    while (reader.Read()) {
            //        Business.GoiTap goiTap = new Business.GoiTap {
            //            id = Convert.ToInt32(reader["ID"]),
            //            tenGoi = reader["TenGoi"].ToString(),
            //            loaiGoi = Convert.ToInt32(reader["LoaiGoi"]),
            //            thoiHanNgay = reader["ThoiHanNgay"] == DBNull.Value ? 0 : Convert.ToInt32(reader["ThoiHanNgay"]),
            //            thoiHanBuoi = reader["ThoiHanBuoi"] == DBNull.Value ? 0 : Convert.ToInt32(reader["ThoiHanBuoi"]),
            //            giaTien = Convert.ToInt64(reader["GiaTien"]),
            //            thongTin = reader["ThongTin"] != DBNull.Value ? reader["ThongTin"].ToString() : "",
            //            hoatDong = Convert.ToBoolean(reader["HoatDong"]),
            //            discount= reader["Discount"]!=DBNull.Value? Convert.ToInt64(reader["Discount"]):0,
            //            startSellingDate = reader["StartSellingDate"] != DBNull.Value ? Convert.ToDateTime(reader["StartSellingDate"]):DateTime.MinValue,
            //            endSellingDate = reader["EndSellingDate"] != DBNull.Value ? Convert.ToDateTime(reader["EndSellingDate"]):DateTime.MinValue,

            //        };  
            //        package.Add(goiTap);
            //    }
            //}
            //connection.Close();
            //foreach(var p in package)
            //{
            //    GoiTapUC goiTapUC = new GoiTapUC();
            //    //goiTapUC.setPacketIndor(p.tenGoi, p.thoiHanNgay, p.hoatDong);
            //    goiTapUC.setPacketIndoor(p);


            //    if(p.loaiGoi==1)
            //    {
            //        flpGoiThang.Controls.Add(goiTapUC);
            //    }
            //    else
            //    {
            //        flpGoiBuoi.Controls.Add(goiTapUC);
            //    }
            //}

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
