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
        DSPT dSPT;
        DSSpecialties dSSpecialties;
        public DanhSachPTUC()
        {
            InitializeComponent();
            dSPT = new DSPT();
            dSSpecialties = new DSSpecialties();
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




            using (SqlConnection sqlConnection = new SqlConnection(Config.connection))
            {
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "select * from PT";
                sqlConnection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PT ptInsert = new PT
                        {
                            id = int.Parse(reader["ID"].ToString()),
                            tenLot = reader["Ho"].ToString(),
                            name = reader["Ten"].ToString(),
                            sDT = reader["SDT"].ToString(),
                            trangThai = Convert.ToBoolean(reader["TrangThai"]) ? State.Active : State.Inactive,
                            thoiGianXoa = reader["ThoiGianXoa"] != DBNull.Value ? Convert.ToDateTime(reader["ThoiGianXoa"].ToString()) : (DateTime?)null,
                            gioiTinh = Convert.ToBoolean(reader["GioiTinh"]) ? Gender.Male : Gender.Female,
                            ngaySinh = reader["NgaySinh"] != DBNull.Value ? Convert.ToDateTime(reader["NgaySinh"].ToString()) : (DateTime?)null,
                            AvatarUrl = reader["AvartarUrl"].ToString(),
                        };
                        dSPT.pTs.Add(ptInsert);
                    }
                }

                cmd.CommandText = "select * from Specialties";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Specialties newspecialty = new Specialties
                        {
                            id = int.Parse(reader["ID"].ToString()),
                            specialty = reader["Specialties"].ToString(),
                            notes = reader["notes"] != DBNull.Value ? reader["notes"].ToString() : ""
                        };
                        dSSpecialties.specialtiesList.Add(newspecialty);
                        Debug.WriteLine(newspecialty);
                    }

                }
            }
            //create dictionary
            var ptDict = dSPT.pTs.ToDictionary(pt => pt.id);
            var spDict = dSSpecialties.specialtiesList.ToDictionary(sp => sp.id, sp => sp.specialty);



            using (SqlConnection sqlConnection = new SqlConnection(Config.connection))
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "select * from PTSpecialties";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int idPT = Convert.ToInt32(reader["PT_ID"].ToString());
                        int idSP = Convert.ToInt32(reader["Specialties_ID"].ToString());
                        //string addsp = dSSpecialties.specialtiesList.Find((i) => i.id == idSP).specialty;
                        //dSPT.pTs.Find((i) => i.id == idPT).specialties.Add(addsp);
                        if (ptDict.TryGetValue(idPT, out var pt) && spDict.TryGetValue(idSP, out var spName))
                        {
                            pt.specialties.Add(spName);
                        }
                    }

                }
            }
            Debug.WriteLine(dSPT);


            //cmd.CommandText = "select * from PTSpecialties";
            //reader=cmd.ExecuteReader();
            //while (reader.Read())
            //{

            //}

            Debug.WriteLine(dSSpecialties);


            //set up form
            dgvDSPT.DataSource = dSPT.pTs;

            int iaCount = 0;
            int aCount = 0;
            int male = 0;
            int fe = 0;
            int xoa = 0;
            foreach (var i in dSPT.pTs)
            {
                if (i.trangThai == State.Inactive)
                {
                    iaCount++;
                }
                else
                {
                    aCount++;
                }
                if (i.gioiTinh == Gender.Male)
                {
                    male++;
                }
                else if (i.gioiTinh == Gender.Female)
                {
                    fe++;
                }
                if (i.thoiGianXoa != (DateTime?)null)
                {
                    xoa++;
                }
            }
            lblTKActive.Text = aCount.ToString();
            lblTKUnactive.Text = iaCount.ToString();
            lblTKDeleted.Text = xoa.ToString();
            lblNam.Text = male.ToString();
            lblNu.Text = fe.ToString();
        }

        private void cbNhanLich_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNhanLich.Checked)
            {
                dgvDSPT.DataSource = dSPT.getA();
            }
            else
            {
                dgvDSPT.DataSource = dSPT.getList();
            }
        }

        private void chEND_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUnactive.Checked)
            {
                dgvDSPT.DataSource = dSPT.getUA();
            }
            else
            {
                dgvDSPT.DataSource = dSPT.getList();
            }
        }

        private void pnlLoc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNu_Click(object sender, EventArgs e)
        {

        }

        private void cbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNam.Checked)
            {
                dgvDSPT.DataSource = dSPT.getM();
            }
            else
            {
                dgvDSPT.DataSource = dSPT.getList();
            }
        }

        private void cbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNu.Checked)
            {
                dgvDSPT.DataSource = dSPT.getF();
            }
            else
            {
                dgvDSPT.DataSource = dSPT.getList();
            }
        }

        private void cbXoa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbXoa.Checked)
            {
                dgvDSPT.DataSource = dSPT.getD();
            }
            else
            {
                dgvDSPT.DataSource = dSPT.getList();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cbXoa.Checked = false;
            cbNu.Checked = false;
            cbNam.Checked = false;
            cbUnactive.Checked = false;
            cbNhanLich.Checked = false;
            cbXoa.Checked = false;

        }

        private void dgvDSPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvDSPT.Rows[e.RowIndex];

            PT pt=dSPT.pTs.Find((i) => i.id == int.Parse(row.Cells["chGID"].Value.ToString()));

            Debug.WriteLine($"u clicked me {row.Cells["chGID"].Value}");
            lblPFTen.Text = $"{row.Cells["chgHo"].Value} {row.Cells["chgTen"].Value}";
            lblPFTrangThai.Text = row.Cells["chgTrangThai"].Value.ToString() == "Active" ? "Nhận thêm lịch" : "Ngừng nhận lịch";
            lblTuoi.Text = DateTime.Parse(row.Cells["cNgaySinh"].Value.ToString()) == (DateTime?)null ? "" : (DateTime.Now.Year - DateTime.Parse(row.Cells["cNgaySinh"].Value.ToString()).Year).ToString();
            lblPFSDT.Text = row.Cells["chgSDT"].Value.ToString();

            pbAvatar.Image = row.Cells["cAvatar"].Value != null ? Image.FromFile(@"PTPicture\" + row.Cells["cAvatar"].Value) : Image.FromFile(@"PTPicture\" + "NoShow.jpg");
            lbChuyenMon.Items.Clear();
            foreach(string sp in pt.specialties)
            {
                lbChuyenMon.Items.Add(sp);
            }
        }

        private void lblPFSDT_Click(object sender, EventArgs e)
        {

        }
    }
}
