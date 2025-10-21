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

namespace GymManagerment_MVP.MainFeature.HoaDonRelated.HoaDon
{
    public partial class frmThemMoi : Form
    {
        public ComboBox CbNhomHang
        {
            get { return cbNhomHang; }
        }
        public TextBox TbTenHangMoi
        {
            get { return tbTenHangMoi; }
        }
        public TextBox TbDVTMoi
        {
            get { return tbDVTMoi; }
        }
        public TextBox TbDonGiaMoi
        {
            get { return tbDonGiaMoi; }
        }
        public TextBox TbDanhMucMoi
        {
            get { return tbDanhMucMoi; }
        }


        string connectionString = "server = LAPTOP-470KBPRO; database = GymManagement; integrated security = true";
        public frmThemMoi()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (tbDanhMucMoi.Enabled == true)
            {
                ThemDMMoi();
            }
            else if(tbDanhMucMoi.Enabled == false)
            {
                ThemHangMoi();
            }

        }

        private void ThemDMMoi()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO NhomHang (TenNhom) VALUES (@TenNhom)";
                sqlConnection.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@TenNhom", tbDanhMucMoi.Text);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
            MessageBox.Show("Thêm danh mục thành công!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void ThemHangMoi()
        {
            string maHangMoi = string.Empty;
            string maNhom = string.Empty;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                // Lookup MaNhom by TenNhom
                using (SqlCommand cmd = new SqlCommand("SELECT MaNhom FROM NhomHang WHERE TenNhom = @TenNhom", sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@TenNhom", cbNhomHang.Text);
                    var result = cmd.ExecuteScalar();
                    if (result != null) maNhom = result.ToString();
                }
                // Generate MaHang
                using (SqlCommand cmd = new SqlCommand("SELECT dbo.TaoMaHangMoi(@TenNhom)", sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@TenNhom", cbNhomHang.Text);
                    var result = cmd.ExecuteScalar();
                    maHangMoi = result != null ? result.ToString() : string.Empty;
                }
                //Insert Hang
                string query = "INSERT INTO Hang (MaHang, MaNhom, TenHang, DVT, DonGia) VALUES (@MaHang, @MaNhom, @TenHang, @DVT, @DonGia)";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@MaHang", maHangMoi);
                    cmd.Parameters.AddWithValue("@MaNhom", maNhom);
                    cmd.Parameters.AddWithValue("@TenHang", tbTenHangMoi.Text);
                    cmd.Parameters.AddWithValue("@DVT", tbDVTMoi.Text);
                    cmd.Parameters.AddWithValue("@DonGia", int.Parse(tbDonGiaMoi.Text.Replace(",", "")));
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
            MessageBox.Show("Thêm hàng mới thành công!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //public void UpdateNhomHang(string oldTenNhom, string newTenNhom)
        //{
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();
        //        string query = "UPDATE NhomHang SET TenNhom = @NewTenNhom WHERE TenNhom = @OldTenNhom";
        //        using (SqlCommand cmd = new SqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@NewTenNhom", newTenNhom);
        //            cmd.Parameters.AddWithValue("@OldTenNhom", oldTenNhom);
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}

            //public void UpdateHang(string maHang, string tenHang, string dvt, int donGia)
            //{
            //    using (SqlConnection conn = new SqlConnection(connectionString))
            //    {
            //        conn.Open();
            //        string query = "UPDATE Hang SET TenHang = @TenHang, DVT = @DVT, DonGia = @DonGia WHERE MaHang = @MaHang";
            //        using (SqlCommand cmd = new SqlCommand(query, conn))
            //        {
            //            cmd.Parameters.AddWithValue("@TenHang", tenHang);
            //            cmd.Parameters.AddWithValue("@DVT", dvt);
            //            cmd.Parameters.AddWithValue("@DonGia", donGia);
            //            cmd.Parameters.AddWithValue("@MaHang", maHang);
            //            cmd.ExecuteNonQuery();
            //        }
            //    }
            //}

     public void TaoHangMoi()
        {
            string tenNhom = cbNhomHang.Text;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string query = "SELECT dbo.TaoMaHangMoi(@TenNhom)";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@TenNhom", tenNhom);
                    var result = cmd.ExecuteScalar();
                    cbNhomHang.Text = result != null ? result.ToString() : string.Empty;
                }
                sqlConnection.Close();
            }
        }

        private void frmThemMoi_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TenNhom FROM NhomHang";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    cbNhomHang.Items.Clear();
                    while (reader.Read())
                    {
                        cbNhomHang.Items.Add(reader["TenNhom"].ToString());
                    }
                }
            }
        }
    }
}
