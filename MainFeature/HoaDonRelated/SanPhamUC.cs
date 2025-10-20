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

namespace GymManagerment_MVP.MainFeature.HoaDonRelated
{
    public partial class SanPhamUC : UserControl
    {

        string connectionString = "server = LAPTOP-470KBPRO; database = GymManagement; integrated security = true";
        public SanPhamUC()
        {
            InitializeComponent();
        }

        private void frmMuaHang_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
            TaoTextInput();
        }

        private void LoadDanhMuc()
        {
            flpDanhMuc.Controls.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TenNhom FROM NhomHang";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                int y = 10;
                while (reader.Read())
                {
                    string tenNhom = reader["TenNhom"].ToString();

                    Button btn = new Button();
                    btn.Text = tenNhom;
                    btn.Size = new Size(180, 30);
                    btn.BackColor = Color.Aquamarine;

                    btn.Click += (s, e) => btnClick(tenNhom);

                    flpDanhMuc.Controls.Add(btn);
                    y += btn.Height + 10;
                }

                reader.Close();
            }
        }

        private void btnClick(string tenNhom)
        {
            Button btn = (Button)flpDanhMuc.Controls.Cast<Control>().FirstOrDefault(c => c.Text == tenNhom);
            LoadHangTheoNhom(tenNhom);
            string selectedCategory = btn.Text;
        }

        private void LoadHangTheoNhom(string tenNhom)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string query = "";

            if (tenNhom == "Tất cả")
            {
                query = "SELECT * FROM Hang";
            }
            else if (tenNhom == "Nước uống và đồ ăn")
            {
                query = "SELECT * FROM Hang " +
                        "WHERE Left(MaHang, 2) = 'NA'";
            }
            else if (tenNhom == "Phụ kiện tập luyện")
            {
                query = "SELECT * FROM Hang " +
                        "WHERE Left(MaHang, 2) = 'PK'";
            }
            else if (tenNhom == "Quần áo")
            {
                query = "SELECT * FROM Hang " +
                        "WHERE Left(MaHang, 2) = 'QA'";
            }

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt);


            dgvDSHang.DataSource = dt;
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
                btnClick(match.Text);
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
            tbGiamGia.LostFocus += HienThiTien;
            tbKhachDua.LostFocus += HienThiTien;
            cbHinhThuc.LostFocus += HienThiHinhThuc;

            tbTimKiem.Text = "Nhập hàng";

            tbTimKiem.GotFocus += TbTimKiemOnGotFocus;
            tbTimKiem.LostFocus += TbTimKiemOnLostFocus;
        }

        private void TbTimKiemOnLostFocus(object sender, EventArgs e)
        {
            tbTimKiem.Text = "Nhập hàng";
        }

        private void TbTimKiemOnGotFocus(object sender, EventArgs e)
        {
            tbTimKiem.Text = "";
        }

        private void HienThiHinhThuc(object sender, EventArgs e)
        {
            if (cbHinhThuc.Text == "Chuyển khoản")
            {
                tbKhachDua.Enabled = false;
                btnChuyenKhoan.Enabled = true;
            }
            else
            {
                tbKhachDua.Enabled = true;
                btnChuyenKhoan.Enabled = false;
            }
        }

        private void cbTimTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTimTheo.Text == "Tìm theo")
            {
                tbTimKiem.Enabled = false;
            }
            else
            {
                tbTimKiem.Enabled = true;
            }
        }

        private void TimKiem()
        {
            tbTimKiem.LostFocus -= TbTimKiemOnLostFocus;

            string timKiem = tbTimKiem.Text;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = sqlConnection.CreateCommand();
            string text = "";

            if (cbTimTheo.Text == "Theo mã hàng")
            {
                text = "Select * from TimKiemHangTheoMa(N'" + timKiem + "')";
            }
            else if (cbTimTheo.Text == "Theo tên hàng")
            {
                text = "Select * from TimKiemHangTheoTen(N'" + timKiem + "')";

            }
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
            if (cbTimTheo.Text != "Tìm theo")
            {
                tbTimKiem.Enabled = true;
            }
            else
            {
                tbTimKiem.Enabled = false;
            }
            string timKiem = tbTimKiem.Text;
            if (string.IsNullOrWhiteSpace(timKiem) || timKiem == "Nhập hàng")
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

            string selectedCategory = "Tất cả";

            int soLuong = 1;

            if (e.RowIndex < 0) return;

            string maHang = dgvDSHang.Rows[e.RowIndex].Cells["MaHang"].Value.ToString();
            string tenHang = dgvDSHang.Rows[e.RowIndex].Cells["TenHang"].Value.ToString();
            string donViTinh = dgvDSHang.Rows[e.RowIndex].Cells["DVT"].Value.ToString();
            int donGia = Convert.ToInt32(dgvDSHang.Rows[e.RowIndex].Cells["DonGia"].Value);

            string tenNhom = selectedCategory;

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
                lvi.SubItems.Add(tenNhom);
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
            int giamGia = int.Parse(tbGiamGia.Text);
            int khachDua = int.Parse(tbKhachDua.Text);
            int conLai = 0;
            foreach (ListViewItem item in lvHangMua.Items)
            {
                if (item.SubItems.Count > 7)
                {
                    int val;
                    if (int.TryParse(item.SubItems[7].Text.Replace(",", ""), out val))
                        tongTien += val;
                }
            }
            tbTongTien.Text = tongTien.ToString("N0");
            int thanhTien = tongTien - (tongTien * giamGia / 100);
            tbThanhTien.Text = thanhTien.ToString("N0");

            conLai = khachDua - thanhTien;
            lbConLai.Text = conLai.ToString("N0");
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {

        }

        private void RefreshStt()
        {
            for (int i = 0; i < lvHangMua.Items.Count; i++)
            {
                lvHangMua.Items[i].Text = (i + 1).ToString();
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

    }
}
