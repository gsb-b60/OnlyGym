using GymManagerment_MVP.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagerment_MVP.MainFeature.HoaDonRelated.PT._4stepdk
{
    public partial class Step1 : UserControl
    {
        List<GoiPT> goiPTs = new List<GoiPT>();
        public event Action<GoiPT> SetToBill;
        public Step1()
        {
            
            InitializeComponent();
        }

        private void s1flp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Step1_Load(object sender, EventArgs e)
        {
            //for (int i = 1; i <= 8; i++)
            //{
            //    GoiPTUC goiTapUC = new GoiPTUC();
            //    goiTapUC.setPacketIndor($"goi {i}", $"{i}0 Buổi", 0);
            //    s1flp.Controls.Add(goiTapUC);
            //}
            using(SqlConnection connection=new SqlConnection(Config.connection))
            {
                string query = "select * from GoiPT";
                using (SqlCommand cmd=new SqlCommand(query,connection))
                {
                    connection.Open();
                    using(SqlDataReader reader= cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            GoiPT goiRead= new GoiPT { 
                                id= int.Parse(reader["ID"].ToString()),
                                tenGoi = reader["TenGoi"].ToString(),
                                soBuoi = int.Parse(reader["SoBuoi"].ToString()),
                                trangThai = bool.Parse(reader["TrangThai"].ToString()),
                                giaTien = Convert.ToInt64(reader["GiaTien"]),
                                discount = reader["Discount"] != DBNull.Value ? Convert.ToInt64(reader["Discount"]):0,
                            };
                            goiPTs.Add(goiRead);
                        }
                    }
                }
            }
            foreach(GoiPT goi in goiPTs)
            {
                Debug.WriteLine(goi.ToString());
                GoiPTUC goiUC = new GoiPTUC(goi);
                goiUC.BuyPackage += GoiUC_BuyPackage;
                s1flp.Controls.Add(goiUC);
            }
        }

        private void GoiUC_BuyPackage(GoiPT obj)
        {
            SetToBill.Invoke(obj);
        }
    }
}
