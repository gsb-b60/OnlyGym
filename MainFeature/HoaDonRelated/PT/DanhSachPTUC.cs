using GymManagerment_MVP.MainFeature.HoaDonRelated.PT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using GymManagerment_MVP.Business;
using System.Diagnostics;

namespace GymManagerment_MVP.MainFeature.Main
{
    public partial class DanhSachPTUC : UserControl
    {
        public DanhSachPTUC()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemPTfrm frm = new ThemPTfrm();
            frm.ShowDialog();
        }

        private void DanhSachPTUC_Load(object sender, EventArgs e)
        {
            //dgvDSPT.Rows.Clear();
            //SqlConnection sqlConnection = new SqlConnection(Config.connection);
            //SqlCommand sqlCommand = sqlConnection.CreateCommand();
            //sqlCommand.CommandText = "select * from PT";
            //sqlConnection.Open();
            //SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            //DataTable dt = new DataTable("PT");
            //adapter.Fill(dt);

            //dgvDSPT.DataSource = dt;
            //sqlConnection.Close();
            //sqlConnection.Dispose();
            //adapter.Dispose();

            List<PT> list= new List<PT>();

            SqlConnection sqlConnection1 = new SqlConnection(Config.connection);
            SqlCommand cmd=sqlConnection1.CreateCommand();
            cmd.CommandText = "select * from PT";
            sqlConnection1.Open();
            SqlDataReader reader=cmd.ExecuteReader();
            while (reader.Read()) {
                PT ptInsert = new PT
                {
                    id = int.Parse(reader["ID"].ToString()),
                    tenLot = reader["Ho"].ToString(),
                    name = reader["Ten"].ToString(),
                    sDT = reader["SDT"].ToString(),
                    trangThai = Convert.ToBoolean(reader["TrangThai"]) ? State.Active: State.Inactive,
                    thoiGianXoa = reader["ThoiGianXoa"]!=DBNull.Value? Convert.ToDateTime(reader["ThoiGianXoa"].ToString()):(DateTime?)null,
                    gioiTinh = Convert.ToBoolean(reader["GioiTinh"])?Gender.Male:Gender.Female,
                    ngaySinh = reader["NgaySinh"] != DBNull.Value? Convert.ToDateTime(reader["NgaySinh"].ToString()) : (DateTime?)null,
                    AvatarUrl = reader["AvartarUrl"].ToString(),
                };
                list.Add(ptInsert);
            }
            sqlConnection1.Close();
            sqlConnection1.Dispose();
            foreach (PT pt in list) {
                Debug.WriteLine(pt);
            }
            Debug.WriteLine(0);
            dgvDSPT.DataSource= list;

            //PT ptInsert=new PT { 
            //    id = 1,
            //    tenLot="xin choa",
            //    name="name",
            //    sDT="sdt",
            //    trangThai="true",
            //    thoiGianXoa=DateTime.Now,
            //    gioiTinh=false,
            //    ngaySinh=DateTime.Now,
            //    AvatarUrl="assets/pt/"
            //};

                
        }
    }
}
