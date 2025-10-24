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
        public TextBox TbMaDanhMuc
        {
            get { return tbMaDanhMuc; }
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
            if (string.IsNullOrWhiteSpace(tbMaDanhMuc.Text))
            {
                ThemDMMoi();
                MessageBox.Show("Thêm danh mục thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                CapNhatNhomHang();
                MessageBox.Show("Cập nhật  danh mục thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
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
        }


        // Update NhomHang: CapNhatNhomHang
        public void CapNhatNhomHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE NhomHang SET TenNhom = @TenNhom WHERE MaNhom = @MaNhom";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenNhom", tbDanhMucMoi.Text);
                    cmd.Parameters.AddWithValue("@MaNhom", tbMaDanhMuc.Text);
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}
