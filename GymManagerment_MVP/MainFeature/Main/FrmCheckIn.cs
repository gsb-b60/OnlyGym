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
        public FrmCheckIn()
        {
            InitializeComponent();

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
    }
}
