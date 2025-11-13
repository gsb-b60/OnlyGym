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

        private void dgvDSHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDSHD.SelectedRows.Count>0)
            {
                DataGridViewRow row = dgvDSHD.SelectedRows[0];
                int hocVienID = int.Parse( row.Cells["IDHocVien"].Value.ToString());
                int idHopDong= int.Parse(row.Cells["ID"].Value.ToString());
                HocVienBL hvbl = new HocVienBL();
                HocVien hv=hvbl.GetByID(hocVienID);


                lblTenKhach.Text = hv.Ten;
                lblCode.Text = hv.code;
                lblSDT.Text = hv.SDT;
                lblKhachHangState.Text = hv.TrangThai;
                GioiTinh.Text = hv.GioiTinh?"Nam":"Nu";

                btnChiTiet.Tag = hv.code;
                btnXemChiTietHD.Tag = idHopDong;
            }
        }
        public void ApplyFilter()
        {
            List<HopDong> re = listHopDong;

            List<TrangThai> states = new List<TrangThai>();

            if(cbHoanThanh.Checked)
            {
                states.Add(TrangThai.completed);
            }
            if(chChuaHoanThanh.Checked)
            {
                states.Add(TrangThai.active);
            }
            if(cbPending.Checked)
            {
                states.Add(TrangThai.paused);
            }
            if(cbCancel.Checked)
            {
                states.Add(TrangThai.cancelled);
            }
            if (states.Count > 0)
            {
                re = re.Where(hd => states.Contains(hd.trangThai)).ToList();
            }
            else
            {
                // optional: if no checkbox selected, return all
                re = listHopDong;
            }
            dgvDSHD.DataSource = re;
        }

        private void cbHoanThanh_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void chChuaHoanThanh_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cbPending_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cbCancel_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbHoanThanh.Checked = false;
            cbPending.Checked=false;
            cbCancel.Checked=false;
            chChuaHoanThanh.Checked = false;
            ApplyFilter();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if(btnChiTiet.Tag!=null)
            {
                Mainfrm main = Application.OpenForms.OfType<Mainfrm>().FirstOrDefault();
                if (main != null)
                {
                    main.OpenHocVienUC(btnChiTiet.Tag.ToString());
                }
                else
                {
                    MessageBox.Show("Không tìm thấy form chính (Mainfrm).", "Lỗi");
                }
            }
        }

        private void btnXemChiTietHD_Click(object sender, EventArgs e)
        {

        }
    }
}
