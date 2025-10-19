using GymManagerment_MVP.SideFeature;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagerment_MVP
{
    public partial class DanhSachThietBiUC : UserControl
    {
        private DataTable dtThietBi;
        private DataView dvThietBi;
        List<ThietBi> dstb = new List<ThietBi>();
        ThietBi tb = new ThietBi();
        public ThietBi ReturnedThietBi { get; private set; }
        public DanhSachThietBiUC()
        {
            InitializeComponent();
        }



        private void frmThietBi_Load(object sender, EventArgs e)
        {
            TaoTextInput();
            //DocDuLieuTBTuDB();
            //DocDuLieuGCTuDB();

        }

        public void DocDuLieuTBTuDB()
        {
            var connectionString = "server=LAPTOP-470KBPRO; database=GymManagement; integrated security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "Select * from DanhSachThietBi";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable("DanhSachThietBi");

            sqlConnection.Open();
            adapter.Fill(table);

            sqlConnection.Close();
            sqlConnection.Dispose();

            dgvThietBi.DataSource = table;
        }

        public void DocDuLieuGCTuDB()
        {
            var connectionString = "server=LAPTOP-470KBPRO; database=GymManagement; integrated security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "Select * from DanhSachGhiChu";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            sqlConnection.Open();
            adapter.Fill(table);
            sqlConnection.Close();
            sqlConnection.Dispose();

            dgvGhiChu.DataSource = table;
        }

        public void ThemThietBi()
        {
            var connectionString = "server=LAPTOP-470KBPRO; database=GymManagement; integrated security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();

            string ten = tbThemTenTB.Text;
            string hang = cbThemHang.Text;
            string viTri = cbThemViTri.Text;
            int soLuong = int.Parse(nThemSoLuong.Text);
            string tinhTrang = cbThemTinhTrang.Text;

            if (string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(hang) || string.IsNullOrWhiteSpace(viTri) || soLuong == 0 || string.IsNullOrWhiteSpace(tinhTrang))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm", "Thông báo");
            }
            else
            {
                cmd.CommandText = "Insert into DanhSachThietBi values (@ten, @hang, @viTri, @soLuong, @tinhTrang)";
                cmd.Parameters.AddWithValue("@ten", ten);
                cmd.Parameters.AddWithValue("@hang", hang);
                cmd.Parameters.AddWithValue("@viTri", viTri);
                cmd.Parameters.AddWithValue("@soLuong", soLuong);
                cmd.Parameters.AddWithValue("@tinhTrang", tinhTrang);

                sqlConnection.Open();
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK);
                    DocDuLieuTBTuDB();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra khi thêm mới.", "Thông báo", MessageBoxButtons.OK);
                }
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
        }


        public int ThemGhiChu(string lichSu, string ngay, string huongDan)
        {
            var connectionString = "server=LAPTOP-470KBPRO; database=GymManagement; integrated security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "Insert into DanhSachGhiChu values (@lichSu, @ngay, @huongDan)";
            cmd.Parameters.AddWithValue("@lichSu", lichSu);
            cmd.Parameters.AddWithValue("@ngay", ngay);
            cmd.Parameters.AddWithValue("@huongDan", huongDan);

            sqlConnection.Open();
            var soDong = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            sqlConnection.Dispose();
            return soDong;
        }


        public void CapNhatThietBi()
        {

            string ten = tbThemTenTB.Text;
            string hang = cbThemHang.Text;
            string viTri = cbThemViTri.Text;
            int soLuong = int.Parse(nThemSoLuong.Text);
            string tinhTrang = cbThemTinhTrang.Text;
            if (dgvThietBi.SelectedRows == null || dgvThietBi.SelectedRows.Count == 0 || dgvThietBi.SelectedRows[0].IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần cập nhật", "Thông báo", MessageBoxButtons.OK);

            }
            else
            {
                var connectionString = "server=LAPTOP-470KBPRO; database=GymManagement; integrated security = true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                SqlCommand cmd = sqlConnection.CreateCommand();
                int id = (dgvThietBi.SelectedRows[0].Index) + 1;
                cmd.CommandText = "exec CapNhatThietBi @ID =" + id + ", @ten = N'" + ten + "', @hang='" + hang + "', @viTri=N'" + viTri + "', @soLuong=" + soLuong + ", @tinhTrang=N'" + tinhTrang + "'";

                cmd.Parameters.AddWithValue("@ten", ten);
                cmd.Parameters.AddWithValue("@hang", hang);
                cmd.Parameters.AddWithValue("@viTri", viTri);
                cmd.Parameters.AddWithValue("@soLuong", soLuong);
                cmd.Parameters.AddWithValue("@tinhTrang", tinhTrang);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);


                sqlConnection.Open();
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK);
                    DocDuLieuTBTuDB();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra khi cập nhật.", "Thông báo", MessageBoxButtons.OK);
                }

                sqlConnection.Close();
                sqlConnection.Dispose();
            }
        }

        public int CapNhatGhiChu(string lichSu, string ngay, string huongDan)
        {
            var connectionString = "server=LAPTOP-470KBPRO; database=GymManagement; integrated security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "Update DanhSachGhiChu set where";
            cmd.Parameters.AddWithValue("@lichSu", lichSu);
            cmd.Parameters.AddWithValue("@ngay", ngay);
            cmd.Parameters.AddWithValue("@huongDan", huongDan);

            sqlConnection.Open();
            var soDong = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            sqlConnection.Dispose();
            return soDong;
        }

        public void XoaThietBi()
        {
            int id = (dgvThietBi.SelectedRows[0].Index) + 1;
            if (dgvThietBi.SelectedRows == null || dgvThietBi.SelectedRows.Count == 0 || dgvThietBi.SelectedRows[0].IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần xoá", "Thông báo", MessageBoxButtons.OK);

            }
            else
            {
                var connectionString = "server=LAPTOP-470KBPRO; database=GymManagement; integrated security = true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "exec XoaThietBi @ID = " + id;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);


                sqlConnection.Open();
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK);
                    DocDuLieuTBTuDB();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra khi xóa.", "Thông báo", MessageBoxButtons.OK);
                }

                sqlConnection.Close();
                sqlConnection.Dispose();

            }
        }


        public void XoaGhiChu()
        {
            var connectionString = "server=LAPTOP-470KBPRO; database=GymManagement; integrated security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "Delete from DanhSachGhiChu where ID = @id";
            cmd.Parameters.AddWithValue("@id", dgvGhiChu.SelectedRows[0].Index + 1);
            sqlConnection.Open();
            int num = cmd.ExecuteNonQuery();
            if (num > 0)
            {
                MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK);
                DocDuLieuGCTuDB();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra khi xóa.", "Thông báo", MessageBoxButtons.OK);
            }
            sqlConnection.Close();
            sqlConnection.Dispose();
        }

        private void TaoTextInput()
        {
            tbTimThietBi.Text = "Nhập tên thiết bị";
            tbTimGhiChu.Text = "Nhập ID thiết bị";

            tbTimThietBi.GotFocus += TbThietBiOnGotFocus;
            tbTimThietBi.LostFocus += TbThietBiOnLostFocus;

            tbTimGhiChu.GotFocus += TbGhiChuOnGotFocus;
            tbTimGhiChu.LostFocus += TbGhiChuOnLostFocus;
        }

        private void TbThietBiOnLostFocus(object sender, EventArgs e)
        {
            tbTimThietBi.Text = "Nhập tên thiết bị";

        }

        private void TbThietBiOnGotFocus(object sender, EventArgs e)
        {
            tbTimThietBi.Text = "";

        }

        private void TbGhiChuOnLostFocus(object sender, EventArgs e)
        {
            tbTimGhiChu.Text = "Nhập ID thiết bị";
        }

        private void TbGhiChuOnGotFocus(object sender, EventArgs e)
        {
            tbTimGhiChu.Text = "";
        }

        private void AddBinding()
        {
            tbThemTenTB.DataBindings.Add("Text", dgvThietBi.DataSource, "TenThietBi");
            cbThemHang.DataBindings.Add("Text", dgvThietBi.DataSource, "HangSanXuat");
            cbThemViTri.DataBindings.Add("Text", dgvThietBi.DataSource, "ViTri");
            nThemSoLuong.DataBindings.Add("Text", dgvThietBi.DataSource, "SoLuong");
            cbThemTinhTrang.DataBindings.Add("Text", dgvThietBi.DataSource, "TinhTrang");
        }

        private void cbLocHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hang = cbLocHang.Text;
            var connectionString = "server=LAPTOP-470KBPRO; database=GymManagement; integrated security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "Select * from LocThietBiTheoHang('" + hang + "')";

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            sqlConnection.Open();
            adapter.Fill(table);

            sqlConnection.Close();
            dgvThietBi.DataSource = table;

        }

        private void cbLocTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tinhTrang = cbLocTinhTrang.Text;
            var connectionString = "server=LAPTOP-470KBPRO; database=GymManagement; integrated security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "Select * from LocThietBiTheoTinhTrang(N'" + tinhTrang + "')";

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            sqlConnection.Open();
            adapter.Fill(table);

            sqlConnection.Close();
            dgvThietBi.DataSource = table;
        }

        private void cbLocViTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            var viTri = cbLocViTri.Text;
            var connectionString = "server=LAPTOP-470KBPRO; database=GymManagement; integrated security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "Select * from LocThietBiTheoViTri(N'" + viTri + "')";

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            sqlConnection.Open();
            adapter.Fill(table);

            sqlConnection.Close();
            dgvThietBi.DataSource = table;
        }

        public void LapCungNhau()
        {
            //var viTri = cbLocViTri.Text;
            //var hang = cbLocHang.Text;
            //var tinhTrang = cbLocTinhTrang.Text;

            //var connectionString = "server=LAPTOP-470KBPRO; database=GymManagement; integrated security = true";
            //SqlConnection sqlConnection = new SqlConnection(connectionString);

            //SqlCommand cmd = sqlConnection.CreateCommand();
            //if (chbHang.Checked && chbViTri.Checked)
            //{
            //    cmd.CommandText = "Select * from LocThietBiTheoViTri(N'" + viTri + "')" && "Select * from LocThietBiTheoHang(N'" + hang + "')";
            //}
            //DataTable table = new DataTable();
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            //sqlConnection.Open();
            //adapter.Fill(table);

            //sqlConnection.Close();
            //dgvThietBi.DataSource = table;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemThietBi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaThietBi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CapNhatThietBi();
        }


        private void dgvThietBi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThietBi.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvThietBi.SelectedRows[0];
                if (!row.IsNewRow)
                {
                    tbThemTenTB.Text = row.Cells[1].Value?.ToString();
                    cbThemHang.Text = row.Cells[2].Value?.ToString();
                    cbThemViTri.Text = row.Cells[3].Value?.ToString();
                    nThemSoLuong.Value = Convert.ToInt32(row.Cells[4].Value);
                    cbThemTinhTrang.Text = row.Cells[5].Value?.ToString();
                }

            }
        }

        private void tbTimThietBi_TextChanged(object sender, EventArgs e)
        {
            string filterText = tbTimThietBi.Text;
            if (string.IsNullOrWhiteSpace(filterText) || filterText == "Nhập tên thiết bị")
            {
                //DocDuLieuTBTuDB();
            }
            else
            {
                var connectionString = "server=LAPTOP-470KBPRO; database=GymManagement; integrated security = true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "Select * from TimKiemThietBi(N'" + filterText + "')";
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                sqlConnection.Open();
                adapter.Fill(table);
                sqlConnection.Close();
                dgvThietBi.DataSource = table;
            }
        }

        private void dgvThietBi_DoubleClick(object sender, EventArgs e)
        {
            if (dgvThietBi.SelectedRows == null || dgvThietBi.SelectedRows.Count == 0) return;

            var row = dgvThietBi.SelectedRows[0];
            if (row.Cells.Count == 0 || row.Cells[0].Value == null) return;

            if (!int.TryParse(row.Cells[0].Value.ToString(), out int tbID)) return;

            row = dgvThietBi.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["ID"].Value);
            string tenTB = row.Cells["TenTB"].Value?.ToString();
            string tinhTrang = row.Cells["TinhTrang"].Value?.ToString();

            using (var dialog = new frmGhiChu(id, tenTB, tinhTrang))
            {
                dialog.ShowDialog();
            }
        }

        public void TimGhiChu()
        {
            var NgayBD = dtpNgayBD.Text;
            var NgayKT = dtpNgayKT.Text;
            var connectionString = "server=LAPTOP-470KBPRO; database=GymManagement; integrated security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "Select * from TimTheoNgay('" + NgayBD + "', '" + NgayKT + "')";

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            sqlConnection.Open();
            adapter.Fill(table);

            sqlConnection.Close();
            dgvGhiChu.DataSource = table;
        }

        private void tsmiXoaGhiChu_Click(object sender, EventArgs e)
        {
            XoaGhiChu();
        }

        private void btnTimTheoNgay_Click(object sender, EventArgs e)
        {
            TimGhiChu();
        }

        private void tbTimGhiChu_TextChanged(object sender, EventArgs e)
        {
            string filterText = tbTimGhiChu.Text;
            if (string.IsNullOrWhiteSpace(filterText) || filterText == "Nhập ID thiết bị")
            {
                //DocDuLieuGCTuDB();
            }
            else
            {
                var connectionString = "server=LAPTOP-470KBPRO; database=GymManagement; integrated security = true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "Select * from TimKiemGhiChuTheoID(" + filterText + ")";
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                sqlConnection.Open();
                adapter.Fill(table);
                sqlConnection.Close();
                dgvGhiChu.DataSource = table;
            }
        }

        private void btnReloadTB_Click(object sender, EventArgs e)
        {
            DocDuLieuTBTuDB();
            cbLocHang.Text = "< Chọn hãng >";
            cbLocViTri.Text = "< Chọn vị trí >";
            cbLocTinhTrang.Text = "< Chọn hãng >";

            tbTimThietBi.Text = "Nhập tên thiết bị";
        }

        private void btnReloadGC_Click(object sender, EventArgs e)
        {
            DocDuLieuGCTuDB();
            tbTimGhiChu.Text = "Nhập ID thiết bị";
        }
    }
}

