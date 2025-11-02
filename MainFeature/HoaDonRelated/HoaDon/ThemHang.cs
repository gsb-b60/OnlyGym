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
    public partial class ThemHang : Form
    {
        public ComboBox CbNhomHang
        {
            get { return cbNhomHang; }
        }
        public TextBox TbMaHang
        {
            get { return tbMaHang; }
        }
        public TextBox TbTenHang
        {
            get { return tbTenHang; }
        }
        public TextBox TbDVT
        {
            get { return tbDVT; }
        }
        public TextBox TbDonGia
        {
            get { return tbDonGia; }
        }
        public TextBox TbMaNhom
        {
            get { return tbMaNhom; }
        }


        public ThemHang()
        {
            InitializeComponent();
        }
        string connectionString = Config.connection;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMaHang.Text))
            {
                ThemHangMoi();
                MessageBox.Show("Thêm hàng thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                CapNhatHang();
                MessageBox.Show("Cập nhật hàng thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        public void LoadNhomHang()
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string query = "SELECT TenNhom FROM NhomHang";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbNhomHang.Items.Add(reader["TenNhom"].ToString());
                        }
                    }
                }
                sqlConnection.Close();
            }
        }

        private void ThemHangMoi()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("ThemHangMoi", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNhom", tbMaNhom.Text);
                    cmd.Parameters.AddWithValue("@TenNhom", cbNhomHang.Text);
                    cmd.Parameters.AddWithValue("@TenHang", tbTenHang.Text);
                    cmd.Parameters.AddWithValue("@DVT", tbDVT.Text);
                    cmd.Parameters.AddWithValue("@DonGia", tbDonGia.Text);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CapNhatHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("CapNhatHang", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHang", tbMaHang.Text);
                    cmd.Parameters.AddWithValue("@MaNhom", tbMaNhom.Text);
                    cmd.Parameters.AddWithValue("@TenHang", tbTenHang.Text);
                    cmd.Parameters.AddWithValue("@DVT", tbDVT.Text);
                    cmd.Parameters.AddWithValue("@DonGia", tbDonGia.Text);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            cbNhomHang.SelectedIndexChanged += CbNhomHang_SelectedIndexChanged;
        }
        private void CbNhomHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNhomHang.SelectedItem != null)
            {
                string tenNhom = cbNhomHang.SelectedItem.ToString();
                if (cbNhomHang.Text == "Tất cả")
                {
                    tbTenHang.Enabled = false;
                    tbDonGia.Enabled = false;
                    tbDVT.Enabled = false;
                    return;
                }
                else
                {
                    tbTenHang.Enabled = true;
                    tbDonGia.Enabled = true;
                    tbDVT.Enabled = true;
                }
                    using (SqlConnection conn = new SqlConnection(connectionString))

                    {
                        conn.Open();
                        string query = "SELECT MaNhom FROM NhomHang WHERE TenNhom = @TenNhom";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@TenNhom", tenNhom);
                            var result = cmd.ExecuteScalar();
                            if (result != null)
                                tbMaNhom.Text = result.ToString();
                        
                        }
                    }
            }
        }

    }
}
