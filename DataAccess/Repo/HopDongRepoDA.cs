using DataAccess.Object;
using DataAccess.Ultilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repo
{
    public class HopDongRepoDA
    {
        public List<HopDong> GetAll()
        {
            List<HopDong> list = new List<HopDong>();

            using (SqlConnection con = new SqlConnection(Ultilities.Ultilities.ConnectionString))
            {
                con.Open();
                string query = "select * \r\nfrom vw_HopDongPT2";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HopDong hopDong = new HopDong
                            {
                                // 1. Reading Integers (ID, IDHocVien, IDPT, etc.)
                                // Use GetInt32() for non-nullable int columns
                                ID = reader.GetInt32(reader.GetOrdinal("id")),


                                IDHocVien = reader.GetInt32(reader.GetOrdinal("ID_HocVien")),
                                IDPT = reader.GetInt32(reader.GetOrdinal("ID_PT")),
                                ID_PT_Package = reader.GetInt32(reader.GetOrdinal("IDPackage")),
                                TongBuoi = reader.GetInt32(reader.GetOrdinal("tongBuoi")),
                                ConBuoi = reader.GetInt32(reader.GetOrdinal("conBuoi")),

                                // 2. Reading Strings (TenHocVien, TenPT, TenGoi)
                                // Use GetString() for string columns. Use GetOrdinal() for column index.
                                TenHocVien = reader.GetString(reader.GetOrdinal("TenHocVien")),
                                TenPT = reader.GetString(reader.GetOrdinal("TenPT")),
                                TenGoi = reader.GetString(reader.GetOrdinal("TenGoi")),

                                // 3. Reading DateTime (NgayTao)
                                // Use GetDateTime() for DateTime columns
                                NgayTao = reader.GetDateTime(reader.GetOrdinal("NgayTao")),

                                // 4. Reading and Converting to Enum (trangThai)
                                // Assuming the database stores the Enum as an integer:
                                trangThai = (TrangThai)reader.GetInt32(reader.GetOrdinal("trangThai"))
                            };
                            list.Add(hopDong);
                        }
                    }
                }
            }
            return list;
        }
        public void InsertHopDong(HopDong hopDong,List<PTSession> bookedList)
        {
            int id;
            using (SqlConnection con = new SqlConnection(Ultilities.Ultilities.ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(Ultilities.Ultilities.InsertHopDong, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Input parameters
                    cmd.Parameters.Add("@id_HocVien", SqlDbType.Int).Value = hopDong.IDHocVien;
                    cmd.Parameters.Add("@id_pt", SqlDbType.Int).Value = hopDong.IDPT;
                    cmd.Parameters.Add("@id_pt_package", SqlDbType.Int).Value = hopDong.ID_PT_Package;
                    cmd.Parameters.Add("@tongBuoi", SqlDbType.Int).Value = hopDong.TongBuoi;
                    cmd.Parameters.Add("@conBuoi", SqlDbType.Int).Value = hopDong.ConBuoi;
                    cmd.Parameters.Add("@trangThai", SqlDbType.Int).Value = (int)hopDong.trangThai;

                    // Output parameter
                    SqlParameter outputId = cmd.Parameters.Add("@ID", SqlDbType.Int);
                    outputId.Direction = ParameterDirection.Output;


                    cmd.ExecuteNonQuery();

                    // Retrieve the output value
                    id = (int)outputId.Value;
                    if (id > 0)
                    {
                        Debug.WriteLine("done insertHopDong" + id);
                    }
                }
                foreach (var sess in bookedList)
                {
                    using (SqlCommand cmd = new SqlCommand(Ultilities.Ultilities.InsertSession, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Input parameters
                        cmd.Parameters.Add("@id_HopDong", SqlDbType.Int).Value = id;
                        cmd.Parameters.Add("@tg_BatDau", SqlDbType.DateTime).Value = sess.TGBatDau;
                        cmd.Parameters.Add("@tg_KetThuc", SqlDbType.Date).Value =  sess.TGBatDau?.AddHours(1.5);
                        cmd.Parameters.Add("@trangThai", SqlDbType.Int).Value = 1;

                        // Optional parameters
                        cmd.Parameters.Add("@tg_Huy", SqlDbType.Date).Value = DBNull.Value;
                        cmd.Parameters.Add("@lyDoHuy", SqlDbType.NVarChar, 1000).Value = DBNull.Value;

                        // Output parameter
                        SqlParameter outputId = cmd.Parameters.Add("@ID", SqlDbType.Int);
                        outputId.Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();
                        Debug.WriteLine($"Inserted session: {sess.TGBatDau:dd/MM HH:mm} - {sess.TGKetThuc:HH:mm}");

                        // Retrieve the output value
                    }
                }


            }
        }
        public void CancelContract(int id)
        {
            using (SqlConnection con=new SqlConnection(Ultilities.Ultilities.ConnectionString))
            {
                using (SqlCommand cmd=new SqlCommand("sp_CancelHopDong",con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@idHopDong",SqlDbType.Int).Value=id;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
