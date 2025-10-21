using GymManagerment_MVP.Business;
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

namespace GymManagerment_MVP.MainFeature.HoaDonRelated.PT._4stepdk
{
    public partial class Step2 : UserControl
    {
        List<Specialties> dSSpecialties = new List<Specialties>();
        public Step2()
        {
            InitializeComponent();
        }

        private void Step2_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Config.connection))
            {
                string query = "select * from Specialties";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Specialties newspecialty = new Specialties
                            {
                                id = int.Parse(reader["ID"].ToString()),
                                specialty = reader["Specialties"].ToString(),
                                notes = reader["notes"] != DBNull.Value ? reader["notes"].ToString() : ""
                            };
                            dSSpecialties.Add(newspecialty);
                        }
                    }
                }
            }
            lbChuyenMon.Items.Clear();
            foreach (var spec in dSSpecialties)
            {
                lbChuyenMon.Items.Add(spec.specialty);
            }
        }

        private void lbChuyenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbChuyenMon.SelectedItems.Count == 0)
                return;

            string selected = lbChuyenMon.SelectedItems[0].ToString();

            var spec = dSSpecialties.FirstOrDefault(
                s => string.Equals(s.specialty, selected, StringComparison.OrdinalIgnoreCase)
            );

            rtbChiTiet.Text = spec?.notes ?? "Không có ghi chú cho chuyên môn này.";
        }
    }
}
