using GymManagerment_MVP.MainFeature.HoaDonRelated.PT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace GymManagerment_MVP.MainFeature.Main
{
    public partial class DanhSachPTUC : UserControl
    {
        public DanhSachPTUC()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemPTfrm frm = new ThemPTfrm();
            frm.ShowDialog();
        }

        private void DanhSachPTUC_Load(object sender, EventArgs e)
        {
            dgvDSPT.Rows.Clear();
            Config config = new Config();
            SqlConnection sqlConnection = new SqlConnection(config.connection);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select * from PT";
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("PT");
            adapter.Fill(dt);

            dgvDSPT.DataSource = dt;
            sqlConnection.Close();
            sqlConnection.Dispose();
            adapter.Dispose();

                
        }
    }
}
