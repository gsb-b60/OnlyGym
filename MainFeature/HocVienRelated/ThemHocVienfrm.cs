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
    public partial class ThemHocVienfrm : Form
    {
        public ThemHocVienfrm()
        {
            InitializeComponent();
        }
        string query = Config.connection;
        private void AddHV()
        {
            using (SqlConnection con = new SqlConnection(query))
            using (SqlCommand cmd = new SqlCommand("sp_ThemHocVien", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ten", tbTen.Text);
                cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                cmd.Parameters.AddWithValue("@ngaySinh", dtpNgaysinh.Value);
                cmd.Parameters.AddWithValue("@gioiTinh", rdNam.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@tag", nudTag.Value);
                cmd.Parameters.AddWithValue("@ghiChu", txtNote.Text);
                cmd.Parameters.AddWithValue("@avatarUrl", (object)tbDuongDan.Text ?? DBNull.Value);

                con.Open();
                string newCode = cmd.ExecuteScalar()?.ToString();
                MessageBox.Show("Thêm học viên thành công! Mã mới: " + newCode);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            AddHV();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDKGoi_Click(object sender, EventArgs e)
        {
            Form frm = new DangKyGoiTap();
            frm.ShowDialog();
        }

        private void txtMua_Click(object sender, EventArgs e)
        {
            Mainfrm main = Application.OpenForms["Mainfrm"] as Mainfrm;
            if(main != null)
            {
                main.MoMuaHang();
            }
            this.Close();
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            
        }
    }
}
