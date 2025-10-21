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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymManagerment_MVP
{
    public partial class DanhSachHocVienUC_v2 : UserControl
    {
        public DanhSachHocVienUC_v2()
        {
            InitializeComponent();
        }

        private void pnlProfile_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void pnlDanhSach_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form frm=new ThemHocVienfrm();
            frm.ShowDialog();
        }

        //public SqlConnection con = new SqlConnection("server = TUNN\\ANHTUAN; database = gymManagement;Integrated Security=True");
        private void LoadHV()
        {
            SqlConnection con = new SqlConnection("server = TUNN\\ANHTUAN; database = gymManagement;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select b.code, b.ten, b.sdt, b.tag, b.thoiGianTao, b.ngayXoa, a.TrangThai, c.tenGoi from GoiTapCuaHocVien a, HocVien b, GoiTap c where a.id_HocVien = b.id and a.id_GoiTap = c.id";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            con.Open();
            adapter.Fill(table);

            con.Close();
            con.Dispose();
            
            dgvHocVien.DataSource = table;
        }
        private void DanhSachHocVienUC_v2_Load(object sender, EventArgs e)
        {
            LoadHV();
        }

        public void TimHV()
        {
            SqlConnection con = new SqlConnection("server = TUNN\\ANHTUAN; database = gymManagement;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            
            if (cbFindB.Text == "Code" )
            {
                cmd.CommandText = "exec sp_TimKiemTheoCode @keyword = @code";
                cmd.Parameters.AddWithValue("@code", txtTimHV.Text);
            }
            if (cbFindB.Text == "Tên")
            {
                cmd.CommandText = "exec sp_TimKiemTheoTen @keyword = @ten";
                cmd.Parameters.AddWithValue("@ten", txtTimHV.Text);
            }
            if (cbFindB.Text == "SDT")
            {
                cmd.CommandText = "exec sp_TimKiemTheoSDT @keyword = @sdt";
                cmd.Parameters.AddWithValue("@sdt", txtTimHV.Text);
            }    

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            con.Open();
            adapter.Fill(table);
            con.Close();
            con.Dispose();
            dgvHocVien.DataSource = table;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(cbFindB.Text) && !string.IsNullOrWhiteSpace(txtTimHV.Text))
                TimHV();
            else
                MessageBox.Show("Vui lòng chọn tiêu chí hoặc tư khóa tìm kiếm!");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadHV();
        }
    }
}
