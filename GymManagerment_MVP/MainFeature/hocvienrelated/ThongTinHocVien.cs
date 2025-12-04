using Business;
using GymManagerment_MVP.Business;
using GymManagerment_MVP.MainFeature.HocVienRelated;
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

namespace GymManagerment_MVP
{
    public partial class ThongTinHocVien : UserControl
    {
        public ThongTinHocVien()
        {
            InitializeComponent();
        }

        private void lblPFCongNo_Click(object sender, EventArgs e)
        {

        }

        private void gbThongTinHD_Enter(object sender, EventArgs e)
        {

        }

        private void gbThongTinGoiTap_Enter(object sender, EventArgs e)
        {

        }

        private void lvThongTinHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblGoi_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void lvLichSuTap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvThongTinPT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public string query = Config.connection;

        private void LoadGoiTap()
        {
            string cmd = "SELECT ID, tenGoi FROM GoiTap";
            using (SqlConnection con = new SqlConnection(query))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbPFGHT.DataSource = dt;
                cbPFGHT.DisplayMember = "tenGoi";
                cbPFGHT.ValueMember = "ID";
            }
        }

        private void LoadTag()
        {
            string cmd = "select tag from HocVien";
            using (SqlConnection con = new SqlConnection(query))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbPFThe.DataSource = dt;
                cbPFThe.DisplayMember = "tag";
            }
        }
        public void DisplayThoTinHocVien(string code)
        {
            using (SqlConnection con = new SqlConnection(query))
            using (SqlCommand cmd = new SqlCommand("sp_GetThongTinHocVien", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@code", code);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    tbPFTen.Text = row["TenHV"].ToString();
                    tbPFSDT.Text = row["sdt"].ToString();
                    string tthai = row["TrangThai"].ToString();
                    cbPFTrangThai.Text = tthai == "1" ? "Hoạt động" : "Ngừng hoạt động";
                    cbPFGHT.Text = row["TenGoiTap"].ToString();

                    if (row["ngaySinh"] != DBNull.Value)
                        dtpNgaysinh.Value = Convert.ToDateTime(row["ngaySinh"]);

                    rdNam.Checked = row["GioiTinh"].ToString() == "Nam";
                    rdNu.Checked = row["GioiTinh"].ToString() == "Nữ";
                    txtGhiChu.Text = row["ghiChu"].ToString();

                    if (row["thoiGianTao"] != DBNull.Value)
                        dtpTao.Value = Convert.ToDateTime(row["thoiGianTao"]);
                    if (row["thoiGianSua"] != DBNull.Value)
                        dtpNgaySua.Value = Convert.ToDateTime(row["thoiGianSua"]);
                    if (row["ngayXoa"] != DBNull.Value)
                        dtpXoa.Value = Convert.ToDateTime(row["ngayXoa"]);
                }
            }
            btnSua.Enabled = true;
            HocVienBL hvbl = new HocVienBL();
            HocVien hv = hvbl.GetByCode(code);
            btnBuy.Tag = hv.code;
            SetUpPanel(hv);
        }
        private void SetUpPanel(HocVien hv)
        {
            ThongTinGoiTapUC goitap = new ThongTinGoiTapUC(hv);
            goitap.Dock = DockStyle.Fill;
            tabGoi.Controls.Add(goitap);
            goitap.BringToFront();


            ThongTinCheckInUC thongTinCheckInUC = new ThongTinCheckInUC(hv);
            thongTinCheckInUC.Dock = DockStyle.Fill;
            tabCheckIn.Controls.Add(thongTinCheckInUC);
            thongTinCheckInUC.BringToFront();


            ThongTinGoiTapPTUC thongTinGoiTapPTUC = new ThongTinGoiTapPTUC(hv);
            thongTinGoiTapPTUC.Dock = DockStyle.Fill;
            tabLichSuPT.Controls.Add(thongTinGoiTapPTUC);
            thongTinGoiTapPTUC.BringToFront();

            ThongTinHoaDonUC thongTinHoaDonUC = new ThongTinHoaDonUC();
            thongTinHoaDonUC.Dock = DockStyle.Fill;
            tabHóaĐơn.Controls.Add(thongTinHoaDonUC);
            thongTinHoaDonUC.BringToFront();
            btnSua.Enabled = false;
            LoadGoiTap();
            LoadTag();
        }
        private void ThongTinHocVien_Load(object sender, EventArgs e)
        {
            
        }
    
        public void Update_HVien()
        {
            int gioiTinh = rdNam.Checked ? 1 : 0;
            int trangthai = (cbPFTrangThai.Text == "Hoạt động") ? 1 : 0;
            using (SqlConnection con = new SqlConnection(query))
            using (SqlCommand cmd = new SqlCommand("Update_HV", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenHV", tbPFTen.Text);
                cmd.Parameters.AddWithValue("@SDT", tbPFSDT.Text);
                cmd.Parameters.Add("@ngaysinh", SqlDbType.SmallDateTime).Value = dtpNgaysinh.Value;
                cmd.Parameters.AddWithValue("@gioitinh", gioiTinh);
                cmd.Parameters.Add("@tgianTao", SqlDbType.SmallDateTime).Value = dtpTao.Value;
                cmd.Parameters.Add("@tgianSua", SqlDbType.SmallDateTime).Value = dtpNgaySua.Value;
                cmd.Parameters.Add("@tgianXoa", SqlDbType.SmallDateTime).Value = dtpXoa.Value;
                cmd.Parameters.AddWithValue("@tthai", trangthai);
                cmd.Parameters.AddWithValue("@tenGoi", cbPFGHT.Text);
                cmd.Parameters.AddWithValue("@ghichu", txtGhiChu.Text);
                con.Open();
                int tb = cmd.ExecuteNonQuery();
                if (tb > 0)
                {
                    MessageBox.Show("Cập nhật thông tin học viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin học viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                con.Dispose();
            }
        }

        public void reset()
        {
            tbPFTen.Text = "";
            tbPFSDT.Text = "";
            dtpNgaysinh.Value = DateTime.Now;
            rdNam.Checked = true;
            cbPFTrangThai.SelectedIndex = -1;
            cbPFGHT.SelectedIndex = -1;
            txtGhiChu.Text = "";
            dtpTao.Value = DateTime.Now;
            dtpNgaySua.Value = DateTime.Now;
            dtpXoa.Value = DateTime.Now;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            Update_HVien();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            reset();
            btnSua.Enabled = false;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (btnBuy.Tag != null)
            {
                Mainfrm main = Application.OpenForms.OfType<Mainfrm>().FirstOrDefault();
                if (main != null)
                {
                    main.OpenMuaHang(btnBuy.Tag.ToString());
                }
                else
                {
                    MessageBox.Show("Không tìm thấy form chính (Mainfrm).", "Lỗi");
                }
            }
        }
    }
}
