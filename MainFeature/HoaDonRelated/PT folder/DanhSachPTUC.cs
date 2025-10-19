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
using System.Data.SqlClient;
using GymManagerment_MVP.Business;
using System.Diagnostics;

namespace GymManagerment_MVP.MainFeature.Main
{
    public partial class DanhSachPTUC : UserControl
    {
        DSPT dSPT;
        DSSpecialties dSSpecialties;
        DSPT filterList;
        DSPT sourceList;
        private bool isNameSortedAsc = true;
        public DanhSachPTUC()
        {

            filterList = new DSPT();
            sourceList = new DSPT();
            InitializeComponent();
            cbFindB.SelectedIndex = 1;
            dSPT = new DSPT();
            dSSpecialties = new DSSpecialties();
            sourceList.pTs = dSPT.pTs;
            filterList.pTs = dSPT.pTs;

            dgvDSPT.Columns["chgTen"].SortMode = DataGridViewColumnSortMode.Automatic;


        }
        private void DanhSachPTUC_Load(object sender, EventArgs e)
        {
            LoadDBPT();

            DisplayList(dSPT.pTs);
            DisplayAnalist();

        }
        private void DisplayAnalist()
        {
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
            lblChuaXoa.Text = (dSPT.pTs.Count - xoa).ToString();
        }
        private void LoadDBPT()
        {
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
            DisplayList(dSPT.pTs);
        }
        private void ApplyAllFiltersAndSearch()
        {
            // Step 1: start from full source
            var result = sourceList.pTs;

            // ====== FILTER: Gender ======
            bool filterMale = cbNam.Checked;
            bool filterFemale = cbNu.Checked;

            if (filterMale && !filterFemale)
                result = result.Where(pt => pt.gioiTinh == Gender.Male).ToList();
            else if (!filterMale && filterFemale)
                result = result.Where(pt => pt.gioiTinh == Gender.Female).ToList();
            // if both unchecked or both checked => no gender filter


            // ====== FILTER: Active ======
            bool filterActive = cbNhanLich.Checked;
            bool filterInactive = cbUnactive.Checked;

            if (filterActive && !filterInactive)
                result = result.Where(pt => pt.trangThai == State.Active).ToList();
            else if (!filterActive && filterInactive)
                result = result.Where(pt => pt.trangThai == State.Inactive).ToList();


            //====== FILTER deleted=======
            bool filterDeleted = cbXoa.Checked;
            bool filterUndeleted = cbChuaXoa.Checked;
            if (filterDeleted && !filterUndeleted)
            {
                result = result.Where(pt => pt.thoiGianXoa != (DateTime?)null).ToList();
            }
            else if (!filterDeleted && filterUndeleted)
            {
                result = result.Where(pt => pt.thoiGianXoa == (DateTime?)null).ToList();
            }


            // ====== FILTER: Specialties ======
            List<string> selectedSpecialties = new List<string>();
            if (cbPhucHoiChucNang.Checked) selectedSpecialties.Add(cbPhucHoiChucNang.Text);
            if (cbThiDauTT.Checked) selectedSpecialties.Add(cbThiDauTT.Text);
            if (cbGiamCanLT.Checked) selectedSpecialties.Add(cbGiamCanLT.Text);
            if (cbGiamCanNu.Checked) selectedSpecialties.Add(cbGiamCanNu.Text);
            if (cbGiamCan.Checked) selectedSpecialties.Add(cbGiamCan.Text);
            if (cbHuanLuyenTheLuc.Checked) selectedSpecialties.Add(cbHuanLuyenTheLuc.Text);
            if (cbThiDauCuTa.Checked) selectedSpecialties.Add(cbThiDauCuTa.Text);
            if (cbTangCuongSucManh.Checked) selectedSpecialties.Add(cbTangCuongSucManh.Text);
            if (cbBoxFit.Checked) selectedSpecialties.Add(cbBoxFit.Text);
            if (cbFuncTrain.Checked) selectedSpecialties.Add(cbFuncTrain.Text);
            if (cbYoga.Checked) selectedSpecialties.Add(cbYoga.Text);
            if (cbHLDD.Checked) selectedSpecialties.Add(cbHLDD.Text);

            if (selectedSpecialties.Count > 0)
            {
                result = result
                    .Where(pt => selectedSpecialties.All(s => pt.specialties.Contains(s)))
                    .ToList();
            }

            // ====== FILTER: Search keyword ======
            string keyword = tbTim.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(keyword) || keyword != "")
            {
                if (cbFindB.SelectedIndex == 1)
                {
                    result = result
                    .Where(pt => pt.name.ToLower().Contains(keyword)
                              || pt.sDT.Contains(keyword))
                    .ToList();
                }
                else // Search by ID
                {
                    if (int.TryParse(tbTim.Text, out int id))
                    {
                        result = result
                            .Where(pt => pt.id == id)
                            .ToList();
                    }
                    else
                    {
                        // Optional: if input is not a valid number, show empty result
                        result = new List<PT>();
                    }
                }

            }

            // ====== DISPLAY ======
            DisplayList(result);
        }

        public void CheckChange()
        {

            bool filterMale = cbNam.Checked;
            bool filterFemale = cbNu.Checked;

            List<string> selectedSpecialties = new List<string>();


            if (filterMale && filterFemale)
            {
                filterList = sourceList;
            }
            else if (filterMale)
            {
                filterList.pTs = sourceList.getM();
            }
            else if (filterFemale)
            {
                filterList.pTs = sourceList.getF();
            }
            else
            {
                filterList.pTs = sourceList.pTs;
            }




            bool filterActive = cbNhanLich.Checked;
            bool filterInactive = cbUnactive.Checked;

            if (filterActive && !filterInactive)
            {
                filterList.pTs = filterList.getA();
            }
            else if (!filterActive && filterInactive)
            {
                filterList.pTs = filterList.getUA();
            }
            else if (!filterActive && !filterInactive)
            {

            }


            if (cbPhucHoiChucNang.Checked) selectedSpecialties.Add(cbPhucHoiChucNang.Text);
            if (cbThiDauTT.Checked) selectedSpecialties.Add(cbThiDauTT.Text);
            if (cbGiamCanLT.Checked) selectedSpecialties.Add(cbGiamCanLT.Text);
            if (cbGiamCanNu.Checked) selectedSpecialties.Add(cbGiamCanNu.Text);
            if (cbGiamCan.Checked) selectedSpecialties.Add(cbGiamCan.Text);
            if (cbHuanLuyenTheLuc.Checked) selectedSpecialties.Add(cbHuanLuyenTheLuc.Text);
            if (cbThiDauCuTa.Checked) selectedSpecialties.Add(cbThiDauCuTa.Text);
            if (cbTangCuongSucManh.Checked) selectedSpecialties.Add(cbTangCuongSucManh.Text);
            if (cbBoxFit.Checked) selectedSpecialties.Add(cbBoxFit.Text);
            if (cbFuncTrain.Checked) selectedSpecialties.Add(cbFuncTrain.Text);
            if (cbYoga.Checked) selectedSpecialties.Add(cbYoga.Text);
            if (cbHLDD.Checked) selectedSpecialties.Add(cbHLDD.Text);
            if (selectedSpecialties.Count > 0)
            {
                filterList.pTs = filterList.pTs.Where(pt => selectedSpecialties.All(s => pt.specialties.Contains(s))).ToList();
            }

            DisplayList(filterList.pTs);

        }



        public void DisplayList(List<PT> listPara)
        {
            dgvDSPT.DataSource = listPara;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            Mainfrm main = (Mainfrm)this.FindForm();
            main.loadUserControl(new ThongTinPT(dSPT.pTs[0]));
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemPTfrm frm = new ThemPTfrm();

            DialogResult re = frm.ShowDialog();
            if (re == DialogResult.OK)
            {
                MessageBox.Show(frm.addPT.ToString());
                AddPTDB(frm.addPT);
                LoadDBPT();
            }
            else
            {
                MessageBox.Show("Huy Them PT");
            }
        }


        private void AddPTDB(PT ptPara)
        {
            using (SqlConnection connection = new SqlConnection(Config.connection))
            {
                string query = @"INSERT INTO PT (Ho, Ten, SDT, TrangThai, GioiTinh, NgaySinh, AvartarUrl)
                                 VALUES (@TenLot, @Ten, @SDT,@TrangThai , @GioiTinh, @NgaySinh, @AvatarUrl);";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@TenLot", ptPara.tenLot);
                    cmd.Parameters.AddWithValue("@Ten", ptPara.name);
                    cmd.Parameters.AddWithValue("@SDT", ptPara.sDT);
                    cmd.Parameters.AddWithValue("@TrangThai", ptPara.trangThai == State.Active ? 1 : 0);
                    cmd.Parameters.AddWithValue("@GioiTinh", ptPara.gioiTinh == Gender.Male ? 1 : 0);
                    cmd.Parameters.AddWithValue("@NgaySinh", ptPara.ngaySinh);
                    cmd.Parameters.AddWithValue("@AvatarUrl", ptPara.AvatarUrl);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        private void cbNhanLich_CheckedChanged(object sender, EventArgs e)
        {
            ApplyAllFiltersAndSearch();
        }

        private void chEND_CheckedChanged(object sender, EventArgs e)
        {
            ApplyAllFiltersAndSearch();
        }

        private void pnlLoc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNu_Click(object sender, EventArgs e)
        {

        }

        private void cbNam_CheckedChanged(object sender, EventArgs e)
        {
            ApplyAllFiltersAndSearch();
        }

        private void cbNu_CheckedChanged(object sender, EventArgs e)
        {
            ApplyAllFiltersAndSearch();
        }

        private void cbXoa_CheckedChanged(object sender, EventArgs e)
        {
            ApplyAllFiltersAndSearch();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cbXoa.Checked = false;
            cbNu.Checked = false;
            cbNam.Checked = false;
            cbUnactive.Checked = false;
            cbNhanLich.Checked = false;
            cbXoa.Checked = false;
            cbPhucHoiChucNang.Checked = false;
            cbThiDauTT.Checked = false;
            cbGiamCanLT.Checked = false;
            cbGiamCanNu.Checked = false;
            cbGiamCan.Checked = false;
            cbHuanLuyenTheLuc.Checked = false;
            cbThiDauCuTa.Checked = false;
            cbTangCuongSucManh.Checked = false;
            cbBoxFit.Checked = false;
            cbFuncTrain.Checked = false;
            cbYoga.Checked = false;
            cbHLDD.Checked = false;
            cbChuaXoa.Checked = false;
            ApplyAllFiltersAndSearch();
        }

        private void dgvDSPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDSPT.Rows[e.RowIndex];

                PT pt = dSPT.pTs.Find((i) => i.id == int.Parse(row.Cells["chGID"].Value.ToString()));

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
                lblTuoi.Text = DateTime.Parse(row.Cells["cNgaySinh"].Value.ToString()) == (DateTime?)null ? "" : (DateTime.Now.Year - DateTime.Parse(row.Cells["cNgaySinh"].Value.ToString()).Year).ToString();
                lblPFSDT.Text = row.Cells["chgSDT"].Value.ToString();


                lbChuyenMon.Items.Clear();
                foreach (string sp in pt.specialties)
                {
                    lbChuyenMon.Items.Add(sp);
                }
            }

        }

        private void lblPFSDT_Click(object sender, EventArgs e)
        {
            ApplyAllFiltersAndSearch();
        }

        private void cbKhac_CheckedChanged(object sender, EventArgs e)
        {
            ApplyAllFiltersAndSearch();
        }

        private void lblTKUnactive_Click(object sender, EventArgs e)
        {

        }

        private void tbTim_TextChanged(object sender, EventArgs e)
        {
            ApplyAllFiltersAndSearch();

        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            tbTim.Text = "";
            ApplyAllFiltersAndSearch();
        }

        private void cbFindB_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTim.Text = "";
            ApplyAllFiltersAndSearch();
        }

        private void cbChuaXoa_CheckedChanged(object sender, EventArgs e)
        {
            ApplyAllFiltersAndSearch();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDSPT.SelectedRows.Count == 0) return;
            //Debug.WriteLine("hi");
            //Debug.WriteLine(dgvDSPT.SelectedRows[0].Cells["chGID"]);
            dgvDSPT.SelectedRows[0].Cells["chgXoa"].Value = DateTime.Now.ToString();

        }

        private void dgvDSPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSPT_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvDSPT.Columns[e.ColumnIndex].Name == "chgTen")
            {
                //// Get your current data
                //List<PT> currentList = dSPT.pTs;

                //// Sort ascending or descending
                //if (isNameSortedAsc)
                //    currentList = currentList.OrderBy(pt => pt.name).ToList();
                //else
                //    currentList = currentList.OrderByDescending(pt => pt.name).ToList();

                //// Flip sort direction for next click
                //isNameSortedAsc = !isNameSortedAsc;

                //// Re-bind to grid
                //dgvDSPT.DataSource = null;
                //dgvDSPT.DataSource = currentList;

                //// Highlight the header
                //foreach (DataGridViewColumn col in dgvDSPT.Columns)
                //    col.HeaderCell.Style.ForeColor = Color.Black; // reset others

                //dgvDSPT.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Red; // mark active

                //Debug.WriteLine($"Sorted by name {(isNameSortedAsc ? "ascending" : "descending")}");
                dgvDSPT.DataSource=filterList.pTs.OrderByDescending(pt => pt.name).ToList();
                dgvDSPT.Columns["chgTen"].HeaderCell.Style.ForeColor = Color.Red;
                //dgvDSPT.Columns.
            }
        }
    }
}
