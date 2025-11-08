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
using DataAccess;
using Business;

namespace GymManagerment_MVP.MainFeature.Main
{
    public partial class DanhSachPTUC : UserControl
    {
        //GymEntity context=new GymEntity();


        List<PT> pTs;
        List<Specialties> dSSpecialties;
        List<PT> filterList;
        List<PT> sourceList;
        public DanhSachPTUC()
        {

            filterList = new List<PT>();
            sourceList = new List<PT>();
            InitializeComponent();
            cbFindB.SelectedIndex = 1;
            pTs = new List<PT>();
            dSSpecialties = new List<Specialties>();


            dgvDSPT.Columns["chgTen"].SortMode = DataGridViewColumnSortMode.Automatic;
        }
        private void DanhSachPTUC_Load(object sender, EventArgs e)
        {
            LoadDBPT();

            DisplayList(pTs);
            DisplayAnalist();

        }
        private void DisplayAnalist()
        {
            int iaCount = 0;
            int aCount = 0;
            int male = 0;
            int fe = 0;
            int xoa = 0;
            foreach (var i in pTs)
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
            lblChuaXoa.Text = (pTs.Count - xoa).ToString();
        }
        private void LoadDBPT()
        {
            PTRepositoryBL ptbl=new PTRepositoryBL();

            pTs = ptbl.GetAll();
            dSSpecialties = ptbl.GetSpecialties();
            //create dictionary
            var ptDict = pTs.ToDictionary(pt => pt.id);
            var spDict = dSSpecialties.ToDictionary(sp => sp.id, sp => sp.specialty);
            DisplayList(pTs);
        }
        private void ApplyAllFiltersAndSearch()
        {
            // Step 1: start from full source
            var result = pTs;

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
            var pt = btnChiTiet.Tag as Business.PT;
            if (pt != null)
            {
                main.loadUserControl(new ThongTinPT(pt));
            }
            else
            {
                main.loadUserControl(new ThongTinPT(pTs[0]));
            }

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
            PTRepositoryBL ptbl = new PTRepositoryBL();
            ptbl.InsertPT(ptPara);
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

                PT pt = pTs.Find((i) => i.id == int.Parse(row.Cells["chGID"].Value.ToString()));

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
                btnChiTiet.Tag = pt;
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
                dgvDSPT.DataSource = pTs.OrderByDescending(pt => pt.name).ToList();
                dgvDSPT.Columns["chgTen"].HeaderCell.Style.ForeColor = Color.Red;
            }
        }
    }
}
