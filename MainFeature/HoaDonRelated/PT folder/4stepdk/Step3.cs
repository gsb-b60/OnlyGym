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
    public partial class Step3 : UserControl
    {
        List<Business.PT> list=new List<Business.PT>();  
        public Step3()
        {
            InitializeComponent();
        }
        public Step3(List<Business.PT> listPara)
        {
            InitializeComponent();
        }
        public Step3(Specialties specPara)
        {
            InitializeComponent();
            using (SqlConnection connection = new SqlConnection(Config.connection))
            {
                string query = "select PT.Ho,PT.Ten,PT.SDT,PT.GioiTinh,PT.AvartarUrl,PT.ID" +
                    "\r\nfrom PT\r\n" +
                    "join PTSpecialties on PTSpecialties.PT_ID=PT.ID\r\n" +
                    "where PTSpecialties.Specialties_ID=@ID_Spec and PT.TrangThai=1";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@ID_spec", specPara.id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Business.PT ptInsert = new Business.PT
                            {
                                id = int.Parse(reader["ID"].ToString()),
                                tenLot = reader["Ho"].ToString(),
                                name = reader["Ten"].ToString(),
                                sDT = reader["SDT"].ToString(),
                                gioiTinh = Convert.ToBoolean(reader["GioiTinh"]) ? Gender.Male : Gender.Female,
                                AvatarUrl = reader["AvartarUrl"].ToString(),
                            };
                            list.Add(ptInsert);
                        }
                    }
                }
            }
            SetUpList(list);
        }
        private void SetUpList(List<Business.PT> listPara)
        {
            dgvDSPT.DataSource = listPara;
        }

        private void dgvDSPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDSPT.Rows[e.RowIndex];

                Business.PT pt = list.Find((i) => i.id == int.Parse(row.Cells["chGID"].Value.ToString()));

                if (row.Cells["cAvatar"].Value != null)
                {
                    if (row.Cells["cAvatar"].Value.ToString().StartsWith("pt"))
                    {
                        pbAvatar.Image = Image.FromFile(@"PTPicture\" + row.Cells["cAvatar"].Value);
                    }
                    else
                    {
                        try
                        {
                            pbAvatar.Image = Image.FromFile(row.Cells["cAvatar"].Value.ToString());
                        }
                        catch
                        {
                            Debug.WriteLine(e);
                        }
                    }

                }
                else
                {
                    pbAvatar.Image = Image.FromFile(@"PTPicture\" + "NoShow.jpg");
                }


                lblPFTen.Text = $"{row.Cells["chgHo"].Value} {row.Cells["chgTen"].Value}";
                lblPFTrangThai.Text = row.Cells["chgTrangThai"].Value.ToString() == "Active" ? "Nhận thêm lịch" : "Ngừng nhận lịch";
                //lblTuoi.Text = DateTime.Parse(row.Cells["cNgaySinh"].Value.ToString()) == (DateTime?)null ? "" : (DateTime.Now.Year - DateTime.Parse(row.Cells["cNgaySinh"].Value.ToString()).Year).ToString();
                lblPFSDT.Text = row.Cells["chgSDT"].Value.ToString();


                lbChuyenMon.Items.Clear();
                foreach (string sp in pt.specialties)
                {
                    lbChuyenMon.Items.Add(sp);
                }
            }
            
        }
    }
}
