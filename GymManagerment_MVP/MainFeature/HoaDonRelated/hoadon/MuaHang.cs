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


namespace GymManagerment_MVP.MainFeature.HoaDonRelated.HoaDon
{
    public partial class frmMuaHang : Form
    {
        string connectionString = Config.connection;
        public frmMuaHang()
        {
            InitializeComponent();
        }

        private void frmMuaHang_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
            LoadNhanVien();
            TaoTextInput();
            HienThiHinhThuc(null, null);
            dgvDSHang.Columns["MaNhom"].Visible = false;

        }

        private void LoadDanhMuc()
        {
            flpDanhMuc.Controls.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MaNhom, TenNhom FROM NhomHang";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                int y = 10;
                while (reader.Read())
                {
                    string maNhom = reader["MaNhom"].ToString();
                    string tenNhom = reader["TenNhom"].ToString();

                    Button btn = new Button();
                    btn.Text = tenNhom;
                    btn.Tag = maNhom; // Store MaNhom in Tag
                    btn.Size = new Size(180, 30);
                    btn.BackColor = Color.Aquamarine;

                    btn.Click += (s, e) => btnClick(btn);

                    flpDanhMuc.Controls.Add(btn);
                    y += btn.Height + 10;
                }

                reader.Close();
            }
        }

        private void LoadNhanVien()
        {
            cbNhanVienLap.Items.Clear();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "Select ID, Ten from NhanVien";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlConnection.Open();
            da.Fill(dt);
            sqlConnection.Close();
            sqlConnection.Dispose();
            cbNhanVienLap.DataSource = dt;
            cbNhanVienLap.DisplayMember = "Ten";
            cbNhanVienLap.ValueMember = "ID";
        }

        private void btnClick(Button btn)
        {
            btn.Focus(); // Ensure the clicked button is focused for selection logic
            string maNhom = btn.Tag.ToString();
            LoadHangTheoNhom(maNhom);
        }

        private void LoadHangTheoNhom(string maNhom)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query;
                if (maNhom == "1" || string.IsNullOrEmpty(maNhom) || maNhom == "Tất cả")
                {
                    query = "SELECT * FROM Hang";
                }
                else
                {
                    query = "SELECT * FROM Hang WHERE MaNhom = @MaNhom";
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    if (!(maNhom == "1" || string.IsNullOrEmpty(maNhom) || maNhom == "Tất cả"))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@MaNhom", maNhom);
                    }
                    adapter.Fill(dt);
                }
            }
            dgvDSHang.DataSource = dt;
            foreach (DataGridViewRow row in dgvDSHang.Rows)
            {
                if (row.IsNewRow) continue;
                var cell = row.Cells["DVT"];
                if (cell.Value != null && int.TryParse(cell.Value.ToString(), out int dvtValue))
                {
                    cell.Value = dvtValue.ToString("N0");
                }
            }
        }

        private void tbTimDanhMuc_TextChanged(object sender, EventArgs e)
        {
            // Find a category button whose Text matches the search text.
            string timKiem = tbTimDanhMuc.Text?.Trim();
            if (string.IsNullOrEmpty(timKiem))
            {
                // If empty, reload all categories
                LoadDanhMuc();
                return;
            }

            var match = flpDanhMuc.Controls.OfType<Button>()
                .FirstOrDefault(b => string.Equals(b.Text, timKiem, StringComparison.CurrentCultureIgnoreCase));

            if (match != null)
            {
                // set the button's Name to the search text and invoke its click logic
                match.Name = timKiem;
                btnClick(match); // FIX: pass the Button, not match.Text
            }
            else
            {
                // no exact match: optionally filter visible buttons by substring
                foreach (var b in flpDanhMuc.Controls.OfType<Button>())
                {
                    b.Visible = b.Text.IndexOf(timKiem, StringComparison.CurrentCultureIgnoreCase) >= 0;
                }
            }
        }

        private void TaoTextInput()
        {
            nudGiamGia.LostFocus += HienThiTien;
            tbKhachDua.LostFocus += HienThiTien;
            cbHinhThuc.LostFocus += HienThiHinhThuc;

            tbTimKiem.Text = "Nhập tên hàng";

            tbTimKiem.GotFocus += TbTimKiemOnGotFocus;
            tbTimKiem.LostFocus += TbTimKiemOnLostFocus;
        }

        private void TbTimKiemOnLostFocus(object sender, EventArgs e)
        {
            tbTimKiem.Text = "Nhập tên hàng";
        }

        private void TbTimKiemOnGotFocus(object sender, EventArgs e)
        {
            tbTimKiem.Text = "";
        }

        private void HienThiHinhThuc(object sender, EventArgs e)
        {
            
            if (cbHinhThuc.Text == "Chuyển khoản" || string.IsNullOrEmpty(cbHinhThuc.Text))
            {
                tbKhachDua.Text = "0";
                tbKhachDua.Enabled = false;
                btnChuyenKhoan.Enabled = true;
            }
            else
            {
                tbKhachDua.Enabled = true;
                btnChuyenKhoan.Enabled = false;
            }
        }


        private void TimKiem()
        {
            tbTimKiem.LostFocus -= TbTimKiemOnLostFocus;

            string timKiem = tbTimKiem.Text;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = sqlConnection.CreateCommand();
            string text = "";
            text = "Select * from TimKiemHangTheoTen(N'" + timKiem + "')";            
            cmd.CommandText = text;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            sqlConnection.Open();
            adapter.Fill(table);
            sqlConnection.Close();
            dgvDSHang.DataSource = table;


        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {

    
            string timKiem = tbTimKiem.Text;
            if (string.IsNullOrWhiteSpace(timKiem) || timKiem == "Nhập tên hàng")
            {
                LoadHangTheoNhom("Tất cả");
            }
            else
            {
                TimKiem();
            }
        }
        private void dgvDSHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow row in dgvDSHang.SelectedRows)
            {
                if(row.IsNewRow)
                {
                    MessageBox.Show("Dòng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (e.RowIndex < 0) return;

            // Lookup TenNhom from NhomHang table using MaNhom from selected row
            string maNhom = dgvDSHang.Rows[e.RowIndex].Cells["MaNhom"].Value.ToString();
            string tenNhom = "";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TenNhom FROM NhomHang WHERE MaNhom = @MaNhom";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNhom", maNhom);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        tenNhom = result.ToString();
                }
            }
            string selectedCategory = tenNhom;
            int soLuong = 1;
            string maHang = dgvDSHang.Rows[e.RowIndex].Cells["MaHang"].Value.ToString();
            string tenHang = dgvDSHang.Rows[e.RowIndex].Cells["TenHang"].Value.ToString();
            string donViTinh = dgvDSHang.Rows[e.RowIndex].Cells["DVT"].Value.ToString();
            int donGia = Convert.ToInt32(dgvDSHang.Rows[e.RowIndex].Cells["DonGia"].Value);
            bool daTonTai = false;
            foreach (ListViewItem item in lvHangMua.Items)
            {
                if (item.SubItems[1].Text == maHang)
                {
                    soLuong = int.Parse(item.SubItems[5].Text) + 1;
                    item.SubItems[5].Text = soLuong.ToString();
                    int thanhTien = donGia * soLuong;
                    item.SubItems[7].Text = thanhTien.ToString("N0");
                    daTonTai = true;
                    break;
                }
            }
            if (!daTonTai)
            {
                int stt = lvHangMua.Items.Count + 1;
                ListViewItem lvi = new ListViewItem(stt.ToString());
                lvi.SubItems.Add(maHang);
                lvi.SubItems.Add(selectedCategory);
                lvi.SubItems.Add(tenHang);
                lvi.SubItems.Add(donViTinh);
                lvi.SubItems.Add("1");
                lvi.SubItems.Add(donGia.ToString("N0"));
                lvi.SubItems.Add((donGia * soLuong).ToString("N0"));
                lvHangMua.Items.Add(lvi);
                RefreshStt();
            }
            HienThiTien(null, null);
        }

        private void HienThiTien(object sender, EventArgs e)
        {
            int tongTien = 0;
            int giamGia = int.Parse(nudGiamGia.Text);
            int khachDua = int.Parse(tbKhachDua.Text);
            int conLai = 0;
            foreach (ListViewItem item in lvHangMua.Items)
            {
                
                if (item.SubItems.Count >7)
                {
                    int val;
                    if (int.TryParse(item.SubItems[7].Text.Replace(".", ""), out val))
                    {
                        tongTien += val;
                    }    
                       

                    
                }
                else
                {
                    tbTongTien.Text = "0";
                    tbThanhTien.Text = "0";
                }
            }
            tbTongTien.Text = tongTien.ToString("N0");
            int thanhTien = tongTien - (tongTien * giamGia / 100);
            tbThanhTien.Text = thanhTien.ToString("N0");

            conLai = khachDua - thanhTien;
            lbConLai.Text = conLai.ToString("N0");
        }

      

        private void RefreshStt()
        {
            for (int i = 0; i < lvHangMua.Items.Count; i++)
            {
                lvHangMua.Items[i].Text = (i + 1).ToString();
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("ResetStt_Hang", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
            }

            // Refresh DataGridView STT column if exists
            if (dgvDSHang.Columns.Contains("STT"))
            {
                for (int i = 0; i < dgvDSHang.Rows.Count; i++)
                {
                    if (dgvDSHang.Rows[i].IsNewRow) continue;
                    dgvDSHang.Rows[i].Cells["STT"].Value = (i + 1).ToString();
                }
            }
        }

        private void tsmiBoHang_Click(object sender, EventArgs e)
        {
            if (lvHangMua.SelectedItems.Count > 0)

                foreach (ListViewItem item in lvHangMua.SelectedItems)
                {
                    lvHangMua.Items.Remove(item);

                }
            else
                MessageBox.Show("Phải chọn ít nhất 1 dòng", "Thông báo", MessageBoxButtons.OK);

            RefreshStt();

        }

        private void tsmiXoaBot_Click(object sender, EventArgs e)
        {
            if (lvHangMua.SelectedItems.Count > 0)

                foreach (ListViewItem item in lvHangMua.SelectedItems)
                {
                    if (item.SubItems[5].Text == "1")
                    {
                        lvHangMua.Items.Remove(item);
                    }
                    else
                    {
                        int soLuong = int.Parse(item.SubItems[5].Text) - 1;
                        item.SubItems[5].Text = soLuong.ToString();
                        int donGia = int.Parse(item.SubItems[6].Text, System.Globalization.NumberStyles.AllowThousands);
                        int thanhTien = donGia * soLuong;
                        item.SubItems[7].Text = thanhTien.ToString("N0");
                    }
                }
            else
                MessageBox.Show("Phải chọn ít nhất 1 dòng", "Thông báo", MessageBoxButtons.OK);

            RefreshStt();
        }

        private void btnChuyenKhoan_Click(object sender, EventArgs e)
        {
            var frm = new frmThanhToanChuyenKhoan();
            frm.ShowDialog();
        }

        private bool Empty()
        {
            bool isEmpty = false;
            if(tbKhachDua.Text == "" || mtbSDT.Text =="" || cbNhanVienLap.Text == "" || cbHinhThuc.Text == "")
            {
                isEmpty = true;
            }
            else
            {
                isEmpty = false;
            }
            return isEmpty;
        }
        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            string maMuaHang = "";
            string maHD = "";
            DateTime ngayBan = dtpNgayMua.Value;

            if (lvHangMua.Items.Count == 0)
            {
                MessageBox.Show("Chưa có hàng để lưu hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (Empty() == true)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Get new MaMuaHang
                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.TaoMaMuaHangMoi()", conn))
                    {
                        maMuaHang = cmd.ExecuteScalar()?.ToString();
                    }

                    // Get new MaHD with date parameter
                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.TaoMaHDMoi(@NgayBan)", conn))
                    {
                        cmd.Parameters.AddWithValue("@NgayBan", ngayBan.Date);
                        maHD = cmd.ExecuteScalar()?.ToString();
                    }

                    // Insert each item in lvHangMua to MuaHang
                    int stt = 1;
                    foreach (ListViewItem item in lvHangMua.Items)
                    {
                        string maHang = item.SubItems[1].Text;
                        string nhomHang = item.SubItems[2].Text;
                        string tenHang = item.SubItems[3].Text;
                        string dvt = item.SubItems[4].Text;
                        int soLuong = int.Parse(item.SubItems[5].Text);
                        int donGia = int.Parse(item.SubItems[6].Text, System.Globalization.NumberStyles.AllowThousands);
                        int thanhTien = int.Parse(item.SubItems[7].Text, System.Globalization.NumberStyles.AllowThousands);

                        string insertMuaHang = @"INSERT INTO MuaHang (MaMuaHang, STT, MaHang, NhomHang, TenHang, DVT, SoLuong, DonGia, ThanhTien) 
                VALUES (@MaMuaHang, @STT, @MaHang, @NhomHang, @TenHang, @DVT, @SoLuong, @DonGia, @ThanhTien)";
                        using (SqlCommand cmd = new SqlCommand(insertMuaHang, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaMuaHang", maMuaHang);
                            cmd.Parameters.AddWithValue("@STT", stt++);
                            cmd.Parameters.AddWithValue("@MaHang", maHang);
                            cmd.Parameters.AddWithValue("@NhomHang", nhomHang);
                            cmd.Parameters.AddWithValue("@TenHang", tenHang);
                            cmd.Parameters.AddWithValue("@DVT", dvt);
                            cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                            cmd.Parameters.AddWithValue("@DonGia", donGia);
                            cmd.Parameters.AddWithValue("@ThanhTien", thanhTien);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Insert invoice to HoaDon
                    string tenKhachHang = tbTenKhachMua.Text;
                    string sdt = mtbSDT.Text;
                    string nhanVienLap = cbNhanVienLap.Text;
                    int tongTien = int.Parse(tbTongTien.Text.Replace(".", ""));
                    int giamGia = int.Parse(nudGiamGia.Text);
                    int thanhTienHD = int.Parse(tbThanhTien.Text.Replace(".", ""));
                    int khachDua = int.Parse(tbKhachDua.Text);
                    string hinhThuc = cbHinhThuc.Text;
                    int conLai = 0;
                    int.TryParse(lbConLai.Text.Replace(",", ""), out conLai);
                    DateTime ngayBanStr = dtpNgayMua.Value;

                    string insertHoaDon = @"INSERT INTO HoaDon (MaHD, TenKhachHang, SDT, NgayBan, NhanVienLap, TongTien, GiamGia, ThanhTien, KhachDua, HinhThuc, ConLai) 
VALUES (@MaHD, @TenKhachHang, @SDT, @NgayBan, @NhanVienLap, @TongTien, @GiamGia, @ThanhTien, @KhachDua, @HinhThuc, @ConLai)";
                    using (SqlCommand cmd = new SqlCommand(insertHoaDon, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaHD", maHD);
                        cmd.Parameters.AddWithValue("@TenKhachHang", tenKhachHang);
                        cmd.Parameters.AddWithValue("@SDT", sdt);
                        cmd.Parameters.AddWithValue("@NgayBan", ngayBanStr);
                        cmd.Parameters.AddWithValue("@NhanVienLap", nhanVienLap);
                        cmd.Parameters.AddWithValue("@TongTien", tongTien);
                        cmd.Parameters.AddWithValue("@GiamGia", giamGia);
                        cmd.Parameters.AddWithValue("@ThanhTien", thanhTienHD);
                        cmd.Parameters.AddWithValue("@KhachDua", khachDua);
                        cmd.Parameters.AddWithValue("@HinhThuc", hinhThuc);
                        cmd.Parameters.AddWithValue("@ConLai", conLai);
                        cmd.ExecuteNonQuery();
                    }

                    // Insert to DanhSachHoaDon
                    string ngayTaoStr = DateTime.Now.ToString("dd/MM/yyyy");
                    string insertDSHD = @"INSERT INTO DanhSachHoaDon (MaHD, IDHocVien, NgayTao, KhachHang, TongTien, HinhThuc, NhanVienLap) 
VALUES (@MaHD, @IDHocVien, @NgayTao, @KhachHang, @TongTien, @HinhThuc, @NhanVienLap)";
                    using (SqlCommand cmd = new SqlCommand(insertDSHD, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaHD", maHD);
                        cmd.Parameters.AddWithValue("@IDHocVien", ""); // Set this if you have student ID
                        cmd.Parameters.AddWithValue("@NgayTao", ngayTaoStr);
                        cmd.Parameters.AddWithValue("@KhachHang", tenKhachHang);
                        cmd.Parameters.AddWithValue("@TongTien", tongTien);
                        cmd.Parameters.AddWithValue("@HinhThuc", hinhThuc);
                        cmd.Parameters.AddWithValue("@NhanVienLap", nhanVienLap);
                        cmd.ExecuteNonQuery();
                    }

                    // Insert into CTHD
                    string insertCTHD = @"INSERT INTO CTHD (MaHD, MaMuaHang, TenKhachHang, SDT, NgayBan, NhanVien, TongTien, GiamGia, ThanhTien, KhachDua, HinhThuc, ConLai)
VALUES (@MaHD, @MaMuaHang, @TenKhachHang, @SDT, @NgayBan, @NhanVien, @TongTien, @GiamGia, @ThanhTien, @KhachDua, @HinhThuc, @ConLai)";
                    using (SqlCommand cmd = new SqlCommand(insertCTHD, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaHD", maHD);
                        cmd.Parameters.AddWithValue("@MaMuaHang", maMuaHang);
                        cmd.Parameters.AddWithValue("@TenKhachHang", tenKhachHang);
                        cmd.Parameters.AddWithValue("@SDT", sdt);
                        cmd.Parameters.AddWithValue("@NgayBan", ngayBanStr);
                        cmd.Parameters.AddWithValue("@NhanVien", nhanVienLap);
                        cmd.Parameters.AddWithValue("@TongTien", tongTien);
                        cmd.Parameters.AddWithValue("@GiamGia", giamGia);
                        cmd.Parameters.AddWithValue("@ThanhTien", thanhTienHD);
                        cmd.Parameters.AddWithValue("@KhachDua", khachDua);
                        cmd.Parameters.AddWithValue("@HinhThuc", hinhThuc);
                        cmd.Parameters.AddWithValue("@ConLai", conLai);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Lưu hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // If chbInHoaDon is checked, show frmHoaDon and pass MaHD, MaMuaHang
                if (chbInHoaDon.Checked)
                {
                    var frm = new frmHoaDon(true); // pass true to indicate from MuaHang
                    frm.ShowDialog();
                    lvHangMua.Items.Clear();
                    tbTenKhachMua.Text = string.Empty;
                    mtbSDT.Text = string.Empty;
                    cbNhanVienLap.SelectedIndex = -1;
                    cbHinhThuc.SelectedIndex = -1;
                    tbTongTien.Text = "0";
                    nudGiamGia.Text = "0";

                    tbThanhTien.Text = "0";

                    tbKhachDua.Text = "0";

                    lbConLai.Text = "0";
                    chbInHoaDon.Checked = false;    
                }
                // Optionally: clear form or reload data
            }
        }

        public void ThemMoi()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                foreach (DataGridViewRow row in dgvDSHang.SelectedRows)
                {
                    var selectedBtn = flpDanhMuc.Controls.OfType<Button>().FirstOrDefault(b => b.Focused);

                    int maNhom = Convert.ToInt32(row.Cells[1].Value);
                    string tenNhom = selectedBtn.Text;
                    string tenHang = row.Cells[3].Value.ToString();
                    string dvt = row.Cells[4].Value.ToString();
                    int donGia = Convert.ToInt32(row.Cells[5].Value);

                    SqlCommand sqlCommand = conn.CreateCommand();

                    sqlCommand.CommandText = "exec ThemHangMoi " + maNhom + ", N'" + tenNhom + "', N'" + tenHang + "', " + dvt + ", " + donGia;

                    conn.Open();

                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

                    DataTable dt = new DataTable("ThemHangMoi");
                    da.Fill(dt);

                    dgvDSHang.DataSource = dt;

                    conn.Close();
                    conn.Dispose();
                    da.Dispose();

                    LoadHangTheoNhom(tenNhom);

                }
            }
        }

        public void CapNhat()
        {
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                foreach (DataGridViewRow row in dgvDSHang.SelectedRows)
                {
                    var selectedBtn = flpDanhMuc.Controls.OfType<Button>().FirstOrDefault(b => b.Focused);

                    string tenNhom = selectedBtn.Text;
                    int maNhom = Convert.ToInt32(row.Cells[1].Value);
                    int maHang = Convert.ToInt32(row.Cells[2].Value);
                    string tenHang = row.Cells[3].Value.ToString();
                    string dvt = row.Cells[4].Value.ToString();
                    int donGia = Convert.ToInt32(row.Cells[5].Value);

                    SqlCommand sqlCommand = conn.CreateCommand();

                    sqlCommand.CommandText = "exec CapNhatHang " + maHang + ", " + maNhom + ", N'" + tenHang + "', " + dvt + ", " + donGia;

                    conn.Open();

                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

                    DataTable dt = new DataTable("CapNhatHang");
                    da.Fill(dt);

                    dgvDSHang.DataSource = dt;

                    conn.Close();
                    conn.Dispose();
                    da.Dispose();

                    LoadHangTheoNhom(tenNhom);

                }
                }
        }




        private void btnThemDM_Click(object sender, EventArgs e)
        {
            var frm = new frmThemMoi();
            frm.FormClosed += (s, args) => { LoadDanhMuc(); }; // Reload after close
            frm.ShowDialog();
        }

        private void tsmiXoa_Click(object sender, EventArgs e)
        {
            
            // If a button in flpDanhMuc is focused, delete category
            var selectedBtn = flpDanhMuc.Controls.OfType<Button>().FirstOrDefault(b => b.Focused);
            //if()
            if (selectedBtn != null)
            {
                XoaDanhMuc();
                return;
            }
            // If an item in lvHangMua is selected, delete item
            if (lvHangMua.SelectedItems.Count > 0)
            {
                XoaHang();
                return;
            }
            // Optionally, show a message if nothing is selected
            MessageBox.Show("Vui lòng chọn danh mục hoặc hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void XoaDanhMuc()
        {
            var selectedBtn = flpDanhMuc.Controls.OfType<Button>().FirstOrDefault(b => b.Focused);

            int maNhom = int.Parse(selectedBtn.Tag.ToString());

            foreach (DataGridViewRow row in dgvDSHang.Rows)
            {
                //if (row.IsNewRow) continue;
                if (row.Cells["MaNhom"].Value != null && int.Parse(row.Cells["MaNhom"].Value.ToString()) == maNhom)
                {
                    MessageBox.Show("Vẫn còn hàng trong danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Bạn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {

                        string tenNhom = selectedBtn.Text;
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            string query = "DELETE FROM NhomHang WHERE TenNhom = @TenNhom";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@TenNhom", tenNhom);
                                cmd.ExecuteNonQuery();
                            }
                            // Call ResetStt_NhomHang after deletion
                            using (SqlCommand cmd = new SqlCommand("ResetStt_NhomHang", conn))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Xóa danh mục thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flpDanhMuc.Controls.Remove(selectedBtn);
                        LoadDanhMuc(); // Reload categories
                    }

                }
            }

        }
        public void XoaHang()
        {
            if (MessageBox.Show("Bạn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Remove selected items from Hang table and UI (using dgvDSHang)
                if (dgvDSHang.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvDSHang.SelectedRows)
                    {
                        if (row.Cells["MaHang"].Value != null)
                        {
                            string maHang = row.Cells["MaHang"].Value.ToString();
                            using (SqlConnection conn = new SqlConnection(connectionString))
                            {
                                conn.Open();
                                string query = "DELETE FROM Hang WHERE MaHang = @MaHang";
                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@MaHang", maHang);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            dgvDSHang.Rows.Remove(row);
                            MessageBox.Show("Xóa hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    LoadHangTheoNhom("Tất cả"); // Reload items
                    RefreshStt();
                }
            }
        }

        private void tsmiSua_Click(object sender, EventArgs e)
        {
            var selectedBtn = flpDanhMuc.Controls.OfType<Button>().FirstOrDefault(b => b.Focused);
            if (selectedBtn != null)
            {
                if (selectedBtn != null && selectedBtn.Text == "Tất cả")
                {
                    MessageBox.Show("Hãy chọn các danh mục ở dưới để thêm hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                    var frm = new frmThemMoi();

                // Set tbMaDanhMuc in frmThemMoi to btn.Tag (MaNrom)
                frm.TbMaDanhMuc.Text = selectedBtn.Tag.ToString();
                
                // Optionally set tbDanhMucMoi to current TenNhom for editing
                frm.TbDanhMucMoi.Text = selectedBtn.Text;
                frm.ShowDialog();
                // Optionally reload categories after editing
                LoadDanhMuc();
            }

            if (selectedBtn != null && selectedBtn.Text == "Tất cả")
            {
                MessageBox.Show("Hãy chọn các danh mục ở dưới để thêm hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //tbTenHang.Enabled = true;
                //tbDonGia.Enabled = true;
                //tbDVT.Enabled = true;

                if (dgvDSHang.SelectedRows.Count > 0)
                {
                    var row = dgvDSHang.SelectedRows[0];
                    var frm = new ThemHang();
                    // Lookup TenNhom by MaNhom from the selected row
                    string maNhom = row.Cells["MaNhom"].Value?.ToString();
                    string tenNhom = string.Empty;
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT TenNhom FROM NhomHang WHERE MaNhom = @MaNhom";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaNhom", maNhom);
                            var result = cmd.ExecuteScalar();
                            if (result != null)
                                tenNhom = result.ToString();
                        }
                    }
                    frm.TbMaHang.Text = row.Cells["MaHang"].Value?.ToString();
                    frm.TbTenHang.Text = row.Cells["TenHang"].Value?.ToString();
                    frm.TbDVT.Text = row.Cells["DVT"].Value?.ToString();
                    frm.TbDonGia.Text = row.Cells["DonGia"].Value?.ToString();
                    frm.CbNhomHang.Items.Clear();
                    if (!string.IsNullOrEmpty(tenNhom))
                    {
                        frm.CbNhomHang.Items.Add(tenNhom);
                        frm.CbNhomHang.SelectedIndex = 0;
                    }
                     // Disable changing category on edit
                    frm.Controls["tbMaNhom"].Text = maNhom;
                    frm.ShowDialog();
                    LoadHangTheoNhom(tenNhom); // Reload items after editing
                }
            }
        }

        private void mtbSDT_Validating(object sender, CancelEventArgs e)
        {
            MaskedTextBox mtxt = sender as MaskedTextBox;
            mtxt.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string soDienThoai = mtxt.Text;

            if (soDienThoai.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 số. Vui lòng kiểm tra lại.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }
            mtxt.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }

        private void tbKhachDua_Validating(object sender, CancelEventArgs e)
        {
            decimal thanhTien = decimal.Parse(tbThanhTien.Text);
            decimal khachDua  = decimal.Parse(tbKhachDua.Text);

            decimal conLai = khachDua - thanhTien;

            if(conLai < 0)
            {
                MessageBox.Show("Chưa trả đủ tiền.", "Lỗi thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbKhachDua.Text = "0";
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            var frm = new ThemHang();
            frm.LoadNhomHang();
            frm.CbNhomHang.SelectedIndexChanged += (s, args) =>
            {
                if (frm.CbNhomHang.SelectedItem != null)
                {
                    string tenNhom = frm.CbNhomHang.SelectedItem.ToString();
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT MaNhom FROM NhomHang WHERE TenNhom = @TenNhom";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@TenNhom", tenNhom);
                            var result = cmd.ExecuteScalar();
                            if (result != null)
                                frm.Controls["tbMaNhom"].Text = result.ToString();
                        }
                    }
                }
            };
            frm.ShowDialog();
        }

        private void cbHinhThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbHinhThuc.Text == "Chuyển khoản" || string.IsNullOrEmpty(cbHinhThuc.Text))
            {
                tbKhachDua.Text = "0";
                tbKhachDua.Enabled = false;
                btnChuyenKhoan.Enabled = true;
            }
            else
            {
                tbKhachDua.Enabled = true;
                btnChuyenKhoan.Enabled = false;
            }
        }

        private void dgvDSHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
