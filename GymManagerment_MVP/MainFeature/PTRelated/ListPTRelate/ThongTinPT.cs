using Business;
using DataAccess.Object;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagerment_MVP.MainFeature.HoaDonRelated.PT
{
    public partial class ThongTinPT : UserControl
    {
        Business.PT pt;
        List<HopDong> listHopDong=new List<HopDong>();
        public ThongTinPT()
        {
            InitializeComponent();
        }
        public ThongTinPT(Business.PT pt)
        {
            InitializeComponent();
            this.pt = pt;
            SetUpPT(pt);
            lblCatchSDT.Text = "";
            lblCatchTen.Text = "";
            lblCatchHo.Text = "";
        }
        private void SetUpPT(Business.PT pt)
        {
            this.pt = pt;
            lblCatchSDT.Text = "";
            lblCatchTen.Text = "";
            lblCatchHo.Text = "";
            tbTenLot.Text = pt.tenLot ?? "";
            mtbSDT.Text = pt.sDT;
            tbDuongDan.Text = pt.AvatarUrl;
            tbPTTen.Text = pt.name;
            cbPTTrangThai.SelectedIndex = pt.trangThai == State.Inactive ? 1 : 0;
            if (pt.thoiGianXoa.HasValue)
            {
                dtpXoa.Value = pt.thoiGianXoa.Value;
                dtpXoa.Checked = true;
                btnRestore.Enabled = true;
            }
            else
            {
                dtpXoa.Checked = false; // hides the value visually
                btnXoa.Enabled = true;
            }
            if (pt.ngaySinh.HasValue)
            {
                dtpNgaysinh.Value = pt.ngaySinh.Value;
                dtpNgaysinh.Checked = true;
            }
            else
            {
                dtpNgaysinh.Checked = false; // hides the value visually
            }
            if (pt.AvatarUrl != null)
            {
                if (pt.AvatarUrl.StartsWith("pt"))
                {
                    pbAvartar.Image = Image.FromFile(@"PTPicture\" + pt.AvatarUrl);
                }
                else
                {
                    try
                    {
                        pbAvartar.Image = Image.FromFile(pt.AvatarUrl.ToString());
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine(e);
                    }
                }

            }
            else
            {
                pbAvartar.Image = Image.FromFile(@"PTPicture\" + "NoShow.jpg");
            }
            if (pt.gioiTinh == Gender.Female)
            {
                rdNu.Checked = true;
            }
            else
            {
                rdNam.Checked = true;
            }
            lbChuyenMon.Items.Clear();
            foreach (string sp in pt.specialties)
            {
                lbChuyenMon.Items.Add(sp);
            }
            SessionBL sess = new SessionBL();

            dgvLichTuanNay.DataSource = sess.GetByIDPT(pt.id);

            HopDongBL hdbl=new HopDongBL();
            listHopDong = hdbl.GetAll().Where((hd) => hd.IDPT == pt.id).ToList();
            dgvDSHD.DataSource = listHopDong;
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Business.PT updatept = checkInput();
            if (updatept != null) UpdatePT(updatept);

        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
                openFile.Title = "Select a image";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pbAvartar.Image = Image.FromFile(openFile.FileName);
                        tbDuongDan.Text = openFile.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private Business.PT checkInput()
        {
            lblCatchSDT.Text = "";
            lblCatchTen.Text = "";
            lblCatchHo.Text = "";
            string tenLot = tbTenLot.Text.Trim();
            string ten = tbPTTen.Text.Trim();
            string sdt = mtbSDT.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenLot))
            {
                lblCatchHo.Text = "⚠️ Vui lòng nhập ten lot.";
                tbTenLot.Focus();
                return null;
            }

            if (string.IsNullOrWhiteSpace(ten))
            {
                lblCatchTen.Text = "⚠️ Vui lòng nhập ten.";
                tbPTTen.Focus();
                return null;
            }

            if (string.IsNullOrWhiteSpace(sdt))
            {
                lblCatchSDT.Text = "⚠️ Vui lòng nhập số điện thoại.";
                mtbSDT.Focus();
                return null;
            }

            // Optional: check that SDT is numeric or has correct length
            if (!System.Text.RegularExpressions.Regex.IsMatch(sdt, @"^0\d{3}-\d{3}-\d{3}$"))
            {
                Debug.WriteLine(sdt);
                lblCatchSDT.Text = "⚠️ Số điện thoại không hợp lệ (phải có 9–10 chữ số).";
                mtbSDT.Focus();
                return null;
            }

            Business.PT addPT = new Business.PT
            {
                id = this.pt.id,
                tenLot = tbTenLot.Text,
                name = tbPTTen.Text,
                sDT = Regex.Replace(mtbSDT.Text, "[^0-9]", ""),

                ngaySinh = dtpNgaysinh.Value,
                gioiTinh = rdNam.Checked ? Gender.Male : Gender.Female,
                AvatarUrl = tbDuongDan.Text,
                trangThai = cbPTTrangThai.SelectedIndex == 0 ? State.Active : State.Inactive,
                thoiGianXoa = dtpXoa.Checked ? dtpXoa.Value : (DateTime?)null
            };
            return addPT;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dtpXoa.Value = (DateTime.Now);
            dtpXoa.Checked = true;
            btnXoa.Enabled = false;
            btnRestore.Enabled = true;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            dtpXoa.Checked = false;
            btnXoa.Enabled = true;
            btnRestore.Enabled = false;
        }


        public void UpdatePT(Business.PT ptPara)
        {
            using (SqlConnection connection = new SqlConnection(Config.connection))
            {
                string query = "update PT " +
                    "set Ho=@Ho ," +
                    "Ten= @Ten ," +
                    "SDT=@SDT ," +
                    "TrangThai=@TrangThai ," +
                    "ThoiGianXoa=@ThoiGianXoa ," +
                    "GioiTinh=@GioiTinh ," +
                    "NgaySinh=@NgaySinh ," +
                    "AvartarUrl=@AvatarUrl " +
                    "where ID=@ID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Ho", ptPara.tenLot);
                    cmd.Parameters.AddWithValue("@Ten", ptPara.name);
                    cmd.Parameters.AddWithValue("@SDT", ptPara.sDT);
                    cmd.Parameters.AddWithValue("@TrangThai", ptPara.trangThai == State.Active ? 1 : 0);
                    cmd.Parameters.AddWithValue("@ThoiGianXoa", ptPara.thoiGianXoa ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@GioiTinh", ptPara.gioiTinh == Gender.Male ? 1 : 0);
                    cmd.Parameters.AddWithValue("@NgaySinh", ptPara.ngaySinh ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@AvatarUrl", ptPara.AvatarUrl ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ID", ptPara.id);

                    connection.Open();
                    int check = cmd.ExecuteNonQuery();
                    if (check == 1)
                    {
                        MessageBox.Show("cap nhat thanh cong");
                    }
                }
            }

        }
    }
}
