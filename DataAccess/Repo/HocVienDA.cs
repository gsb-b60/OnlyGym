using DataAccess.Ultilities;
using GymManagerment_MVP.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repo
{
    public class HocVienDA
    {
        public bool VarifyCheckIn(string code)
        {
            bool allow = false;
            using (SqlConnection con =new SqlConnection(Ultilities.Ultilities.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(Ultilities.Ultilities.VarifyCheckIn, con))
                {
                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.Add("@HocVienCode", SqlDbType.NVarChar).Value = code;
                    cmd.Parameters.Add("@Allow",SqlDbType.Bit).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();
                    allow = Convert.ToBoolean( cmd.Parameters["@Allow"].Value);
                }
            }
            return allow;
        }
        public List<HocVien> GetHocVien()
        {
            List<HocVien> list=new List<HocVien>();
            using (SqlConnection con =new SqlConnection(Ultilities.Ultilities.ConnectionString))
            {
                string query = "select * from HocVien";
                using (SqlCommand cmd= new SqlCommand(query,con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HocVien hv = new HocVien {
                                id = reader.GetInt32(reader.GetOrdinal("id")),
                                code = reader.GetString(reader.GetOrdinal("code")),
                                Ten = reader.GetString(reader.GetOrdinal("ten")),
                                SDT = reader.GetString(reader.GetOrdinal("sdt")),
                                path = reader.GetString(reader.GetOrdinal("FilePath")),
                                TrangThai = "Hoạt động",
                                GioiTinh = reader.GetBoolean(reader.GetOrdinal("GioiTinh")),
                            };
                            list.Add(hv);
                        }
                    }
                }
            }
            return list;
        }
        public HocVien GetByID(int id)
        {
            HocVien hv=new HocVien();
            using (SqlConnection con = new SqlConnection(Ultilities.Ultilities.ConnectionString))
            {
                string query = "select * from HocVien where id=@ID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.Add("@ID",SqlDbType.Int).Value= id;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            hv = new HocVien
                            {
                                id = reader.GetInt32(reader.GetOrdinal("id")),
                                code = reader.GetString(reader.GetOrdinal("code")),
                                Ten = reader.GetString(reader.GetOrdinal("ten")),
                                SDT = reader.GetString(reader.GetOrdinal("sdt")),
                                path = reader.GetString(reader.GetOrdinal("FilePath")),
                                TrangThai = "Hoạt động",
                                GioiTinh = reader.GetBoolean(reader.GetOrdinal("GioiTinh")),
                            };
                            
                        }
                    }
                }
            }
            return hv;
        }
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
                            id = Convert.ToInt32(row["id"]),
                            code = code,
                            Ten = row["TenHV"].ToString(),
                            SDT = row["sdt"].ToString(),
                            TrangThai = tthai == "1" ? "Hoạt động" : "Ngừng hoạt động",
                            GioiTinh = row["GioiTinh"].ToString() == "Nam" ? true : false,
                            path = row["FilePath"].ToString()
                        };
                    }
                }
            }
            return hv;
        }
    }
}
