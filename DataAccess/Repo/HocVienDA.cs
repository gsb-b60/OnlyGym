using DataAccess.Ultilities;
using GymManagerment_MVP.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repo
{
    public class HocVienDA
    {
        public HocVien GetByCode(string code)
        {
            HocVien hv = new HocVien();
            using (SqlConnection con = new SqlConnection(Ultilities.Ultilities.ConnectionString))
            {
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
                        string tthai = row["TrangThai"].ToString();
                        hv = new HocVien
                        {
                            id=Convert.ToInt32( row["id"]),
                            code = code,
                            Ten = row["TenHV"].ToString(),
                            SDT = row["sdt"].ToString(),
                            TrangThai = tthai == "1" ? "Hoạt động" : "Ngừng hoạt động",
                            GioiTinh = row["GioiTinh"].ToString() == "Nam" ? true : false,
                        };
                    }
                }
            }
            return hv;
        }
    }
}
