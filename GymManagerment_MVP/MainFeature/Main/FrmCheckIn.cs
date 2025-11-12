using DataAccess.Ultilities;
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

namespace GymManagerment_MVP.MainFeature.Main
{
    public partial class FrmCheckIn : Form
    {
        CheckinKhachVaoUC _uc;
        public FrmCheckIn()
        {
            InitializeComponent();

            LoadData();
        }
        public FrmCheckIn(CheckinKhachVaoUC _uc)
        {
            InitializeComponent();
            this._uc = _uc;
            LoadData();
        }
        private void LoadData()
        {
            SqlConnection con = new SqlConnection(Ultilities.ConnectionString);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "exec sp_TaiDanhSachHocVien";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            con.Open();
            adapter.Fill(table);

            con.Close();
            con.Dispose();

            dgvHocVien.DataSource = table;
        }

        private void dgvHocVien_DoubleClick(object sender, EventArgs e)
        {
            if (dgvHocVien.CurrentRow == null) return;

            // Lấy code học viên từ dòng đang chọn
            string code = dgvHocVien.CurrentRow.Cells["chgCode"].Value?.ToString();
            if (string.IsNullOrEmpty(code)) return;

            _uc.DisplayHocVien(code);
        }

        private void dgvHocVien_SelectionChanged(object sender, EventArgs e)
        {
           
        }
    }
}
