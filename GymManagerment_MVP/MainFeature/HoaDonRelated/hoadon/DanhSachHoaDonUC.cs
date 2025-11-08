using GymManagerment_MVP.MainFeature.HoaDonRelated;
using GymManagerment_MVP.MainFeature.HoaDonRelated.HoaDon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GymManagerment_MVP
{
    public partial class DanhSachHoaDonUC : UserControl
    {
        string connectionString = Config.connection;
        public DanhSachHoaDonUC()
        {

            InitializeComponent();

        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            var frm = new frmMuaHang();
            frm.ShowDialog();
        }
        private void DanhSachHoaDonUC_Load(object sender, EventArgs e)
        {
            TaoTextInput();
            LoadDanhSachHoaDon();
            tbTimKiem.Enabled = false;
            cbTimTheo.SelectedIndexChanged += cbTimTheo_SelectedIndexChanged;

        }

        private void LoadDanhSachHoaDon()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "Select * from DanhSachHoaDon";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("DanhSachHoaDon");

            sqlConnection.Open();
            adapter.Fill(dt);
            sqlConnection.Close();
            sqlConnection.Dispose();

            dgvDanhSachHoaDon.DataSource = dt;
            dgvDanhSachHoaDon.Columns["IDHocVien"].Visible = false;
            //foreach (DataGridViewRow row in dgvDanhSachHoaDon.Rows)
            //{
            //    var cell = row.Cells["TongTien"];
            //    if (cell.Value != null)
            //    {
            //        cell.Value = dvtValue.ToString("N0");
            //    }
            //}
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadDanhSachHoaDon();
            rdChuyenKhoan.Checked = false;
            rdTienMat.Checked = false;
            cbTimTheo.Text = "Tìm theo";
            tbTimKiem.Text = "Nhập thông tin";
            dtpTuNgay.Value = DateTime.Parse("1/1/2025");
            dtpDenNgay.Value = DateTime.Parse("31/12/2025");
        }

        public void DoTogether()
        {

        }


        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachHoaDon.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                XcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgvDanhSachHoaDon.Columns.Count + 1; i++)
                {
                    XcelApp.Cells[1, i] = dgvDanhSachHoaDon.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvDanhSachHoaDon.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvDanhSachHoaDon.Columns.Count; j++)
                    {
                        var cellValue = dgvDanhSachHoaDon.Rows[i].Cells[j].Value;
                        XcelApp.Cells[i + 2, j + 1] = cellValue != null ? cellValue.ToString() : "";
                    }
                }

                XcelApp.Columns.AutoFit();
                XcelApp.Visible = true;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất Excel!");
            }
        }




        private void btnLoc_Click(object sender, EventArgs e)
        {
            //if (dtpDenNgay.Value <= dtpTuNgay.Value)
            //{
            //    MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //var ngayBD = dtpTuNgay.Value.ToString("dd/MM/yyyy");
            //var ngayKT = dtpDenNgay.Value.ToString("dd/MM/yyyy");
            //SqlConnection sqlConnection = new SqlConnection(connectionString);

            //SqlCommand cmd = sqlConnection.CreateCommand();
            //cmd.CommandText = "Select * from TimTheoNgay('" + ngayBD + "', '" + ngayKT + "')";

            //DataTable table = new DataTable("TimTheoNgay");
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            //sqlConnection.Open();
            //adapter.Fill(table);

            //sqlConnection.Close();
            //sqlConnection.Dispose();

            //dgvDanhSachHoaDon.DataSource = table;
            TimVaLoc();
        }

        private void TimKiem()
        {
            tbTimKiem.LostFocus -= TbTimKiemOnLostFocus;

            string timKiem = tbTimKiem.Text;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = sqlConnection.CreateCommand();
            string text = "";

            if (cbTimTheo.Text == "Theo mã hóa đơn")
            {
                text = "Select * from TimKiemHoaDonTheoMa(N'" + timKiem + "')";
            }
            else if (cbTimTheo.Text == "Theo khách hàng")
            {
                text = "Select * from TimKiemHoaDonTheoKH(N'" + timKiem + "')";

            }
            cmd.CommandText = text;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            sqlConnection.Open();
            adapter.Fill(table);
            sqlConnection.Close();
            dgvDanhSachHoaDon.DataSource = table;


        }


        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            tbTimKiem.LostFocus -= TbTimKiemOnLostFocus;
            if (cbTimTheo.Text != "Tìm theo")
            {
                tbTimKiem.Enabled = true;
            }
            else
            {
                tbTimKiem.Enabled = false;
            }
            string timKiem = tbTimKiem.Text;
            if (string.IsNullOrWhiteSpace(timKiem) || timKiem == "Nhập thông tin")
            {
                LoadDanhSachHoaDon();
            }
            else
                //{
                //    if(!rdChuyenKhoan.Checked || !rdTienMat.Checked || dtpTuNgay.Value == dtpDenNgay.Value)
                //    TimKiem();
                //    else
                TimVaLoc();

                //}
        }

        private void TaoTextInput()
        {


            tbTimKiem.Text = "Nhập thông tin";

            tbTimKiem.GotFocus += TbTimKiemOnGotFocus;
            tbTimKiem.LostFocus += TbTimKiemOnLostFocus;
        }

        private void TbTimKiemOnLostFocus(object sender, EventArgs e)
        {
            tbTimKiem.Text = "Nhập thông tin";
        }

        private void TbTimKiemOnGotFocus(object sender, EventArgs e)
        {
            tbTimKiem.Text = "";
        }

        private void LocHinhThuc()
        {
            var hinhThuc = "";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = sqlConnection.CreateCommand();
            if (rdChuyenKhoan.Checked)
            {
                hinhThuc = "Chuyển khoản";
            }
            else if (rdTienMat.Checked)
            {
                hinhThuc = "Tiền mặt";
            }
            else
            {
                hinhThuc = "";
            }
            cmd.CommandText = "Select * from LocDanhSach(N'" + hinhThuc + "')";
            DataTable table = new DataTable("LocDanhSach");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            sqlConnection.Open();
            adapter.Fill(table);

            sqlConnection.Close();
            sqlConnection.Dispose();

            dgvDanhSachHoaDon.DataSource = table;
        }

        private void rdTienMat_CheckedChanged(object sender, EventArgs e)
        {
            //if (dtpDenNgay.Value == dtpTuNgay.Value || tbTimKiem.Text != "" || tbTimKiem.Text != "Nhập thông tin")
            //    LocHinhThuc();
            //else
            //TimVaLoc();

        }

        private void rdChuyenKhoan_CheckedChanged(object sender, EventArgs e)
        {
            //if (dtpDenNgay.Value == dtpTuNgay.Value || tbTimKiem.Text != "" || tbTimKiem.Text != "Nhập thông tin")
            //    LocHinhThuc();
            //else
            //TimVaLoc();
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

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (lbTenKhach != null && lbTenKhach.Text == "TenKhach")
            {
                MessageBox.Show("Chưa chọn hóa đơn để xem", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                var frm = new frmHoaDon();
                frm.ShowDialog();
            }
        }

        private void dgvDanhSachHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // If label indicates no invoice selected, inform user

            if (e.RowIndex < 0) return;

            string maHD = dgvDanhSachHoaDon.Rows[e.RowIndex].Cells["MaHD"].Value.ToString();

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                SqlCommand cmd = sqlConnection.CreateCommand();
                // get CTHD rows for the invoice
                cmd.CommandText = @"SELECT * FROM CTHD WHERE MaHD = @MaHD";
                cmd.Parameters.AddWithValue("@MaHD", maHD);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable("CTHD");

                sqlConnection.Open();
                adapter.Fill(table);
                sqlConnection.Close();

                // --- Hiển thị danh sách hàng trong ListView ---
                lvHangDaMua.Items.Clear();

                // Collect distinct MaMuaHang values from CTHD
                var maMuaHangList = new List<string>();
                foreach (DataRow row in table.Rows)
                {
                    if (table.Columns.Contains("MaMuaHang") && row["MaMuaHang"] != DBNull.Value)
                    {
                        var mm = row["MaMuaHang"].ToString();
                        if (!string.IsNullOrEmpty(mm) && !maMuaHangList.Contains(mm))
                            maMuaHangList.Add(mm);
                    }
                }

                // If there are MaMuaHang values, query MuaHang for those exact rows
                DataTable muaTable = new DataTable("MuaHang");
                if (maMuaHangList.Count > 0)
                {
                    using (SqlConnection conn2 = new SqlConnection(connectionString))
                    using (SqlCommand cmd2 = conn2.CreateCommand())
                    {
                        var paramNames = new List<string>();
                        for (int i = 0; i < maMuaHangList.Count; i++)
                        {
                            var pname = "@p" + i;
                            paramNames.Add(pname);
                            cmd2.Parameters.AddWithValue(pname, maMuaHangList[i]);
                        }

                        cmd2.CommandText = "SELECT MaMuaHang, TenHang, SoLuong, DonGia FROM MuaHang WHERE MaMuaHang IN (" + string.Join(",", paramNames) + ")";

                        SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
                        conn2.Open();
                        adapter2.Fill(muaTable);
                        conn2.Close();
                    }
                }

                // Build dictionary for fast lookup
                var muaDict = new Dictionary<string, List<DataRow>>();
                foreach (DataRow r in muaTable.Rows)
                {
                    var key = r.Table.Columns.Contains("MaMuaHang") && r["MaMuaHang"] != DBNull.Value ? r["MaMuaHang"].ToString() : string.Empty;
                    if (string.IsNullOrEmpty(key)) continue;
                    if (!muaDict.ContainsKey(key)) muaDict[key] = new List<DataRow>();
                    muaDict[key].Add(r);
                }

                // For each CTHD row, show all matching MuaHang rows (same MaMuaHang)
                foreach (DataRow cthdRow in table.Rows)
                {
                    var key = cthdRow.Table.Columns.Contains("MaMuaHang") && cthdRow["MaMuaHang"] != DBNull.Value ? cthdRow["MaMuaHang"].ToString() : string.Empty;
                    if (string.IsNullOrEmpty(key)) continue;

                    if (muaDict.ContainsKey(key))
                    {
                        foreach (var muaRow in muaDict[key])
                        {
                            string tenHang = muaRow.Table.Columns.Contains("TenHang") && muaRow["TenHang"] != DBNull.Value ? muaRow["TenHang"].ToString() : string.Empty;
                            string soLuong = muaRow.Table.Columns.Contains("SoLuong") && muaRow["SoLuong"] != DBNull.Value ? muaRow["SoLuong"].ToString() : string.Empty;
                            string donGia = string.Empty;
                            if (muaRow.Table.Columns.Contains("DonGia") && muaRow["DonGia"] != DBNull.Value)
                            {
                                decimal dg;
                                if (decimal.TryParse(muaRow["DonGia"].ToString(), out dg))
                                    donGia = string.Format("{0:N0}", dg);
                                else
                                    donGia = muaRow["DonGia"].ToString();
                            }

                            ListViewItem item = new ListViewItem(tenHang);
                            item.SubItems.Add(soLuong);
                            item.SubItems.Add(donGia);
                            lvHangDaMua.Items.Add(item);
                        }
                    }
                    else
                    {
                        // No matching MuaHang rows found: fallback to show SoLuong from CTHD and blank TenHang/DonGia
                        string soLuongCt = cthdRow.Table.Columns.Contains("SoLuong") && cthdRow["SoLuong"] != DBNull.Value ? cthdRow["SoLuong"].ToString() : string.Empty;
                        ListViewItem item = new ListViewItem(string.Empty);
                        item.SubItems.Add(soLuongCt);
                        item.SubItems.Add(string.Empty);
                        lvHangDaMua.Items.Add(item);
                    }
                }

                if (table.Rows.Count > 0)
                {
                    DataRow info = table.Rows[0];
                    lbTenKhach.Text = info["TenKhachHang"].ToString();
                    lbSDT.Text = info["SDT"].ToString();
                    lbNhanVienLap.Text = info["NhanVien"].ToString();
                    lbTongTien.Text = string.Format("{0:N0}", info["TongTien"]);
                    lbGiamGia.Text = string.Format("{0:N0}", info["GiamGia"]);
                    lbKhachDua.Text = string.Format("{0:N0}", info["KhachDua"]);
                    lbConLai.Text = string.Format("{0:N0}", info["ConLai"]);
                    lbHinhThuc.Text = info["HinhThuc"].ToString();
                    lbNgayBan.Text = Convert.ToDateTime(info["NgayBan"]).ToString("dd/MM/yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết hóa đơn: " + ex.Message);
            }

        }
        public void TimVaLoc()
        {
            // --- Xử lý trạng thái ---
            object hinhthuc = DBNull.Value;
            if (rdTienMat.Checked && !rdChuyenKhoan.Checked)
                hinhthuc = "Tiền mặt"; // Hoạt động
            else if (!rdTienMat.Checked && rdChuyenKhoan.Checked)
                hinhthuc = "Chuyển khoản"; // Không hoạt động

            // --- Xử lý tiêu chí tìm kiếm chính ---
            string mahd = null, tenkh = null;
            if (cbTimTheo.Text == "Theo mã hóa đơn")
                mahd = tbTimKiem.Text.Trim();
            else if (cbTimTheo.Text == "Theo khách hàng")
                tenkh = tbTimKiem.Text.Trim();


            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("TimVaLoc", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // --- Thêm tham số ---
                cmd.Parameters.AddWithValue("@mahd", (object)mahd ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@tenkh", (object)tenkh ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@hinhthuc", hinhthuc);

                //Kiểm tra logic ngày(nếu cả hai đều chọn)
                    if (dtpTuNgay.Checked && dtpDenNgay.Checked && dtpTuNgay.Value > dtpDenNgay.Value)
                {
                    MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cmd.Parameters.AddWithValue("@ngaymin",
                        dtpTuNgay.Checked ? dtpTuNgay.Value.Date : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ngaymax",
                        dtpDenNgay.Checked ? dtpDenNgay.Value.Date : (object)DBNull.Value);
                
                    // Không tìm theo ngày sinh → truyền NULL
                    //cmd.Parameters.AddWithValue("@ngaymin", DBNull.Value);
                    //cmd.Parameters.AddWithValue("@ngaymax", DBNull.Value);
                

                // --- Thực thi và hiển thị ---
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvDanhSachHoaDon.DataSource = table;
            }
        }
    }
}