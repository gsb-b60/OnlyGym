using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagerment_MVP.MainFeature.HoaDonRelated.HoaDon
{
    public partial class HoaDon : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        private string connectionString = "server = LAPTOP-470KBPRO; database = GymManagement; integrated security = true";
        DanhSachHoaDonUC dshd = new DanhSachHoaDonUC();

        public HoaDon()
        {
            InitializeComponent();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }



        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Example: Print simple invoice text
            string invoiceText = "Invoice\n\nCustomer: John Doe\nDate: " + DateTime.Now.ToShortDateString() + "\nTotal: $100.00";
            Font font = new Font("Arial", 12);
            e.Graphics.DrawString(invoiceText, font, Brushes.Black, new PointF(100, 100));
        }

        private Control FindControlRecursive(Control parent, Predicate<Control> match)
        {
            if (parent == null) return null;
            if (match(parent)) return parent;
            foreach (Control c in parent.Controls)
            {
                var found = FindControlRecursive(c, match);
                if (found != null) return found;
            }
            return null;
        }

        private DataGridView FindDanhSachHoaDonGrid()
        {
            foreach (Form f in Application.OpenForms)
            {
                var ctl = FindControlRecursive(f, c => c is DataGridView && c.Name == "dgvDanhSachHoaDon");
                if (ctl != null) return ctl as DataGridView;
            }
            return null;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                var ctrl = FindControlRecursive(f, c => c.Name == "lbTenKhach");
                if (ctrl is Label lbl && lbl.Text == "TenKhach")
                {
                    MessageBox.Show("Chưa chọn hóa đơn để xem", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            try
            {

                var dgv = FindDanhSachHoaDonGrid();
                if (dgv == null) { MessageBox.Show("Không tìm thấy danh sách hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                // Get MaHD from selected/current/selected cell
                string maHD = dgv.SelectedRows.Cast<DataGridViewRow>().Select(r => r.Cells.Cast<DataGridViewCell>().FirstOrDefault(c => string.Equals(c.OwningColumn.Name, "MaHD", StringComparison.OrdinalIgnoreCase))?.Value?.ToString()).FirstOrDefault(s => !string.IsNullOrEmpty(s))
                              ?? dgv.CurrentRow?.Cells.Cast<DataGridViewCell>().FirstOrDefault(c => string.Equals(c.OwningColumn.Name, "MaHD", StringComparison.OrdinalIgnoreCase))?.Value?.ToString()
                              ?? dgv.SelectedCells.Cast<DataGridViewCell>().Select(c => c.OwningRow.Cells.Cast<DataGridViewCell>().FirstOrDefault(x => string.Equals(x.OwningColumn.Name, "MaHD", StringComparison.OrdinalIgnoreCase))?.Value?.ToString()).FirstOrDefault(s => !string.IsNullOrEmpty(s));

                if (string.IsNullOrEmpty(maHD)) { MessageBox.Show("Vui lòng chọn một hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                // load CTHD
                var cthd = new DataTable();
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM CTHD WHERE MaHD=@MaHD";
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    new SqlDataAdapter(cmd).Fill(cthd);
                }
                if (cthd.Rows.Count == 0) return;

                // header labels from first row
                DataRow hdr = cthd.Rows[0];
                Func<string, string> G = col => hdr.Table.Columns.Contains(col) && hdr[col] != DBNull.Value ? hdr[col].ToString() : string.Empty;
                lbTenKhachMua.Text = G("TenKhachHang"); lbSDTKhachMua.Text = G("SDT"); lbNhanVienLap.Text = G("NhanVien");
                lbTongTien.Text = !string.IsNullOrEmpty(G("TongTien")) ? string.Format("{0:N0}", Convert.ToDecimal(hdr["TongTien"])) : string.Empty;
                lbGiamGa.Text = !string.IsNullOrEmpty(G("GiamGia")) ? string.Format("{0:N0}", Convert.ToDecimal(hdr["GiamGia"])) : string.Empty;
                lbThanhTien.Text = !string.IsNullOrEmpty(G("ThanhTien")) ? string.Format("{0:N0}", Convert.ToDecimal(hdr["ThanhTien"])) : string.Empty;
                lbKhachDua.Text = !string.IsNullOrEmpty(G("KhachDua")) ? string.Format("{0:N0}", Convert.ToDecimal(hdr["KhachDua"])) : string.Empty;
                lbConLai.Text = !string.IsNullOrEmpty(G("ConLai")) ? string.Format("{0:N0}", Convert.ToDecimal(hdr["ConLai"])) : string.Empty;
                lbHinhThuc.Text = G("HinhThuc"); if (DateTime.TryParse(G("NgayBan"), out DateTime nb)) lbNgayBan.Text = nb.ToString("dd/MM/yyyy");

                // collect MaMuaHang and query MuaHang
                var ids = cthd.AsEnumerable().Where(r => cthd.Columns.Contains("MaMuaHang") && r["MaMuaHang"] != DBNull.Value).Select(r => r["MaMuaHang"].ToString()).Distinct().ToArray();
                var mua = new DataTable();
                if (ids.Length > 0)
                {
                    using (var conn2 = new SqlConnection(connectionString))
                    using (var cmd2 = conn2.CreateCommand())
                    {
                        var ps = ids.Select((v, i) => "@p" + i).ToArray();
                        for (int i = 0; i < ps.Length; i++) cmd2.Parameters.AddWithValue(ps[i], ids[i]);
                        cmd2.CommandText = "SELECT MaMuaHang, TenHang, DVT, DonGia, SoLuong FROM MuaHang WHERE MaMuaHang IN (" + string.Join(",", ps) + ")";
                        new SqlDataAdapter(cmd2).Fill(mua);
                    }
                }

                // build lookup
                var lookup = mua.AsEnumerable().GroupBy(r => r.Field<string>("MaMuaHang")).ToDictionary(g => g.Key, g => g.ToList());

                // populate list
                lvHangMua.Items.Clear(); int stt = 1;
                foreach (DataRow r in cthd.Rows)
                {
                    var key = cthd.Columns.Contains("MaMuaHang") && r["MaMuaHang"] != DBNull.Value ? r["MaMuaHang"].ToString() : string.Empty;
                    var so = cthd.Columns.Contains("SoLuong") && r["SoLuong"] != DBNull.Value ? r["SoLuong"].ToString() : string.Empty;
                    if (!string.IsNullOrEmpty(key) && lookup.ContainsKey(key))
                    {
                        foreach (var m in lookup[key])
                        {
                            var ten = m.Table.Columns.Contains("TenHang") && m["TenHang"] != DBNull.Value ? m["TenHang"].ToString() : string.Empty;
                            var dvt = m.Table.Columns.Contains("DVT") && m["DVT"] != DBNull.Value ? m["DVT"].ToString() : string.Empty;
                            var dg = m.Table.Columns.Contains("DonGia") && m["DonGia"] != DBNull.Value ? string.Format("{0:N0}", Convert.ToDecimal(m["DonGia"])) : string.Empty;
                            var qty = m.Table.Columns.Contains("SoLuong") && m["SoLuong"] != DBNull.Value ? m["SoLuong"].ToString() : so;
                            var thanh = (decimal.TryParse(qty, out decimal qv) && decimal.TryParse(m["DonGia"]?.ToString() ?? "0", out decimal dv)) ? (qv * dv).ToString("N0") : string.Empty;
                            var lvi = new ListViewItem(stt.ToString());
                            lvi.SubItems.Add(ten); lvi.SubItems.Add(dvt); lvi.SubItems.Add(qty); lvi.SubItems.Add(dg); lvi.SubItems.Add(thanh);
                            lvHangMua.Items.Add(lvi); stt++;
                        }
                    }
                    else
                    {
                        var lvi = new ListViewItem(stt.ToString());
                        lvi.SubItems.Add(string.Empty); lvi.SubItems.Add(string.Empty); lvi.SubItems.Add(so); lvi.SubItems.Add(string.Empty); lvi.SubItems.Add(string.Empty);
                        lvHangMua.Items.Add(lvi); stt++;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi khi tải chi tiết hóa đơn: " + ex.Message); }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
