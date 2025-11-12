using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymManagerment_MVP
{
    public partial class DanhSachHocVienUC_v2 : UserControl
    {
        public DanhSachHocVienUC_v2()
        {
            InitializeComponent();
        }

        private void pnlProfile_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void pnlDanhSach_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form frm=new ThemHocVienfrm();
            frm.ShowDialog();
        }

        public string query = Config.connection;

        private void LoadHV()
        {
            
            SqlConnection con = new SqlConnection(query);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "exec sp_TaiDanhSachHocVien";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            con.Open();
            adapter.Fill(table);

            con.Close();
            con.Dispose();
            
            dgvHocVien.DataSource = table;
        }
        private void DanhSachHocVienUC_v2_Load(object sender, EventArgs e)
        {
            LoadHV();
        }

        public void TimHV()
        {
            // --- Xử lý trạng thái ---
            object tthai = DBNull.Value;
            if (cbH.Checked && !chEND.Checked)
                tthai = 1; // Hoạt động
            else if (!cbH.Checked && chEND.Checked)
                tthai = 0; // Không hoạt động

            // --- Xử lý giới tính ---
            object gtinh = DBNull.Value;
            if (cbNam.Checked && !cbNu.Checked)
                gtinh = 1; // Nam
            else if (!cbNam.Checked && cbNu.Checked)
                gtinh = 0; // Nữ

            // --- Xử lý gói tập ---
            List<int> dsGoi = new List<int>();
            if (cb1thang.Checked) dsGoi.Add(1);
            if (cb3Thang.Checked) dsGoi.Add(2);
            if (cbGoiBuoi.Checked) dsGoi.Add(3);
            if (cb6Thang.Checked) dsGoi.Add(4);
            if (cb1Nam.Checked) dsGoi.Add(5);
            if (cb2Nam.Checked) dsGoi.Add(6);

            string dsGoiText = dsGoi.Count > 0 ? string.Join(",", dsGoi) : null;

            // --- Xử lý tiêu chí tìm kiếm chính ---
            string code = null, ten = null, sdt = null;
            if (cbFindB.Text == "Code")
                code = txtTimHV.Text.Trim();
            else if (cbFindB.Text == "Tên")
                ten = txtTimHV.Text.Trim();
            else if (cbFindB.Text == "SDT")
                sdt = txtTimHV.Text.Trim();

            using (SqlConnection con = new SqlConnection(query))
            using (SqlCommand cmd = new SqlCommand("sp_TimKiemHocVien", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // --- Thêm tham số ---
                cmd.Parameters.AddWithValue("@code", (object)code ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ten", (object)ten ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@sdt", (object)sdt ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@trangthai", tthai);
                cmd.Parameters.AddWithValue("@gioitinh", gtinh);
                cmd.Parameters.AddWithValue("@dsGoi", (object)dsGoiText ?? DBNull.Value);
                if (cbCheck.Checked) // chỉ khi radio được chọn
                {
                    // Kiểm tra logic ngày (nếu cả hai đều chọn)
                    if (dtpTuCheckin.Checked && dtpDenCheckin.Checked && dtpTuCheckin.Value > dtpDenCheckin.Value)
                    {
                        MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    cmd.Parameters.AddWithValue("@ngaymin",
                        dtpTuCheckin.Checked ? dtpTuCheckin.Value.Date : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ngaymax",
                        dtpDenCheckin.Checked ? dtpDenCheckin.Value.Date : (object)DBNull.Value);
                }
                else
                {
                    // Không tìm theo ngày sinh → truyền NULL
                    cmd.Parameters.AddWithValue("@ngaymin", DBNull.Value);
                    cmd.Parameters.AddWithValue("@ngaymax", DBNull.Value);
                }

                // --- Thực thi và hiển thị ---
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvHocVien.DataSource = table;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimHV();
        }

        private void Reset()
        {
            LoadHV();
            cbH.Checked = false;
            chEND.Checked = false;
            cbNam.Checked = false;
            cbNu.Checked = false;
            cb1thang.Checked = false;
            cb3Thang.Checked = false;
            cbGoiBuoi.Checked = false;
            cb6Thang.Checked = false;
            cb1Nam.Checked = false;
            cb2Nam.Checked = false;
            cbDKPT.Checked = false;
            cbFindB.SelectedIndex = -1;
            txtTimHV.Clear();
            cbCheck.Checked = false;
            dtpTuCheckin.Value = DateTime.Now;
            dtpDenCheckin.Value = DateTime.Now;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void HienThiThongTinHocVien(string code)
        {
            string query1 = @"
        SELECT 
            a.ten, 
            a.gioiTinh, 
            a.ngaySinh, 
            a.sdt, 
            c.tenGoi, 
            b.TrangThai
        FROM HocVien a
        JOIN GoiTapCuaHocVien b ON a.id = b.id_HocVien
        JOIN GoiTap c ON b.id_GoiTap = c.id
        WHERE a.code = @code";

            using (SqlConnection con = new SqlConnection(query))
            using (SqlCommand cmd = new SqlCommand(query1, con))
            {

                cmd.Parameters.AddWithValue("@code", code);
                con.Open();

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    // --- Tên học viên ---
                    lblTen.Text = rd["ten"].ToString();

                    // --- Giới tính ---
                    bool gioiTinh = rd["gioiTinh"] != DBNull.Value && Convert.ToBoolean(rd["gioiTinh"]);
                    lblGioiTinh.Text = gioiTinh ? "Nam" : "Nữ";

                    // --- Tuổi ---
                    if (rd["ngaySinh"] != DBNull.Value)
                    {
                        DateTime ngaySinh = Convert.ToDateTime(rd["ngaySinh"]);
                        int tuoi = DateTime.Now.Year - ngaySinh.Year;
                        //if (ngaySinh > DateTime.Now.AddYears(-tuoi)) tuoi--;
                        lblTuoi.Text = tuoi.ToString() + " tuổi";
                    }
                    else
                    {
                        lblTuoi.Text = "Không rõ";
                    }

                    // --- Số điện thoại ---
                    lblSDT.Text = rd["sdt"].ToString();

                    // --- Gói tập ---
                    lblGoiTap.Text = rd["tenGoi"].ToString();

                    // --- Trạng thái gói tập (bit) ---
                    bool trangThai = rd["TrangThai"] != DBNull.Value && Convert.ToBoolean(rd["TrangThai"]);
                    if (trangThai)
                    {
                        lblTThai.ForeColor = Color.Green;
                        lblTThai.Text = "Hoạt động";
                    }
                    else
                    {
                        lblTThai.ForeColor = Color.Red;
                        lblTThai.Text = "Ngừng hoạt động";
                    }
                }
                else
                {
                    lblTen.Text = lblGioiTinh.Text = lblTuoi.Text =
                        lblSDT.Text = lblGoiTap.Text = lblTThai.Text = "-";
                }

                rd.Close();
            }
        }

        private void dgvHocVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHocVien.CurrentRow == null) return;

            // Lấy code học viên từ dòng đang chọn
            string code = dgvHocVien.CurrentRow.Cells["chgCode"].Value?.ToString();
            if (string.IsNullOrEmpty(code)) return;

            HienThiThongTinHocVien(code);
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvHocVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvHocVien.SelectedRows[0];
                string code = selectedRow.Cells["chgCode"].Value?.ToString();

                if (code != null)
                {
                    Mainfrm main = Application.OpenForms.OfType<Mainfrm>().FirstOrDefault();
                    if (main != null)
                    {
                        main.OpenHocVienUC(code);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy form chính (Mainfrm).", "Lỗi");
                    }
                }
            }
        }

        private void cbNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            if (dgvHocVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvHocVien.SelectedRows[0];
                string code = selectedRow.Cells["chgCode"].Value?.ToString();

                if (code != null)
                {
                    Mainfrm main = Application.OpenForms.OfType<Mainfrm>().FirstOrDefault();
                    if (main != null)
                    {
                        main.OpenMuaHang(code);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy form chính (Mainfrm).", "Lỗi");
                    }
                }
            }
        }

        private void dgvHocVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
