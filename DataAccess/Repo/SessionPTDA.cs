using DataAccess.Object;
using DataAccess.Ultilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class SessionPTDA
    {
        public void UpdateLyDo(int id, string lydo)
        {
            using (SqlConnection con = new SqlConnection(Ultilities.ConnectionString))
            {
                string query = "update buoiTapPT\r\nset buoiTapPT.lyDoHuy=@l\r\nwhere pub=@i";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.Add("@l", SqlDbType.NVarChar).Value = lydo;
                    cmd.Parameters.Add("@i", SqlDbType.Int).Value = id;
                    cmd.ExecuteNonQuery();
                }
            }
        }
        
        public void UpdateStateSess(int id ,int state)
        {
            using (SqlConnection con=new SqlConnection(Ultilities.ConnectionString))
            {
                string query = "\r\nupdate buoiTapPT\r\nset trangThai=@s\r\nwhere pub=@i";
                using (SqlCommand cmd =new SqlCommand(query,con))
                {
                    con.Open();
                    cmd.Parameters.Add("@s", SqlDbType.Int).Value = state;
                    cmd.Parameters.Add("@i",SqlDbType.Int).Value=id;
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<PTSession> GetByHD(int HopDongID)
        {
            List<PTSession> list = new List<PTSession>();
            using (SqlConnection con = new SqlConnection(Ultilities.ConnectionString))
            {
                string query = "\r\nselect * from buoiTapPT\r\n" +
                    "where buoiTapPT.id_HopDong= @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.Add("@id",SqlDbType.Int).Value=HopDongID;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PTSession session = new PTSession()
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("pub")),
                                IDHopDong = reader.GetInt32(reader.GetOrdinal("id_HopDong")),
                                TGBatDau = reader.IsDBNull(reader.GetOrdinal("tg_BatDau"))
   ? (DateTime?)null
   : reader.GetDateTime(reader.GetOrdinal("tg_BatDau")),
                                TGKetThuc = reader.IsDBNull(reader.GetOrdinal("tg_KetThuc"))
   ? (DateTime?)null
   : reader.GetDateTime(reader.GetOrdinal("tg_KetThuc")),
                                TrangThai = (TrangThaiBuoi)reader.GetInt32(reader.GetOrdinal("trangThai")),
                                ThoiGianTao = reader.IsDBNull(reader.GetOrdinal("tgTao"))
   ? (DateTime?)null
   : reader.GetDateTime(reader.GetOrdinal("tgTao")),
                                ThoiGianHuy = reader.IsDBNull(reader.GetOrdinal("tg_Huy"))
   ? (DateTime?)null
   : reader.GetDateTime(reader.GetOrdinal("tg_Huy")),
                                LyDoHuy = reader.IsDBNull(reader.GetOrdinal("lyDoHuy"))
   ? null
   : reader.GetString(reader.GetOrdinal("lyDoHuy"))

                            };
                            list.Add(session);
                        }
                    }
                }
            }
            return list;
        }
        public List<PTSession> GetDaily()
        {
            List<PTSession> list = new List<PTSession>();
            using (SqlConnection con=new SqlConnection(Ultilities.ConnectionString))
            {
                string query = "select * from buoiTapPT \r\n" +
                    "where tg_BatDau >=CAST(GETDATE() as date)\r\n" +
                    "and tg_BatDau<=DATEADD(DAY,1,cast( GETDATE() as date))";
                using (SqlCommand cmd=new SqlCommand(query,con))
                {
                    con.Open();
                    using (SqlDataReader reader=cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PTSession session = new PTSession()
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("pub")),
                                IDHopDong = reader.GetInt32(reader.GetOrdinal("id_HopDong")),
                                TGBatDau = reader.IsDBNull(reader.GetOrdinal("tg_BatDau"))
   ? (DateTime?)null
   : reader.GetDateTime(reader.GetOrdinal("tg_BatDau")),
                                TGKetThuc = reader.IsDBNull(reader.GetOrdinal("tg_KetThuc"))
   ? (DateTime?)null
   : reader.GetDateTime(reader.GetOrdinal("tg_KetThuc")),
                                TrangThai = (TrangThaiBuoi)reader.GetInt32(reader.GetOrdinal("trangThai")),
                                ThoiGianTao = reader.IsDBNull(reader.GetOrdinal("tgTao"))
   ? (DateTime?)null
   : reader.GetDateTime(reader.GetOrdinal("tgTao")),
                                ThoiGianHuy = reader.IsDBNull(reader.GetOrdinal("tg_Huy"))
   ? (DateTime?)null
   : reader.GetDateTime(reader.GetOrdinal("tg_Huy")),
                                LyDoHuy = reader.IsDBNull(reader.GetOrdinal("lyDoHuy"))
   ? null
   : reader.GetString(reader.GetOrdinal("lyDoHuy"))

                            };
                            list.Add(session);
                        }
                    }
                }
            }
            return list;
        }
        public List<PTSession> GetByPTID(int id)
        {
            List<PTSession> list=new List<PTSession>();
            using (SqlConnection con=new SqlConnection(Ultilities.ConnectionString))
            {
                string query = "select * \r\nfrom buoiTapPT b\r\njoin HopDongPT h on h.ID=b.id_HopDong\r\nwhere h.id_pt=@id\r\n";
                using (SqlCommand cmd =new SqlCommand(query,con))
                {
                    con.Open();
                    cmd.Parameters.Add("@id",SqlDbType.Int).Value=id;
                    using (SqlDataReader reader=cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PTSession session = new PTSession() 
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("pub")),
                                IDHopDong = reader.GetInt32(reader.GetOrdinal("id_HopDong")),
                                TGBatDau = reader.IsDBNull(reader.GetOrdinal("tg_BatDau"))
    ? (DateTime?)null
    : reader.GetDateTime(reader.GetOrdinal("tg_BatDau")),
                                TGKetThuc = reader.IsDBNull(reader.GetOrdinal("tg_KetThuc"))
    ? (DateTime?)null
    : reader.GetDateTime(reader.GetOrdinal("tg_KetThuc")),
                                TrangThai = (TrangThaiBuoi)reader.GetInt32(reader.GetOrdinal("trangThai")),
                                ThoiGianTao = reader.IsDBNull(reader.GetOrdinal("tgTao"))
    ? (DateTime?)null
    : reader.GetDateTime(reader.GetOrdinal("tgTao")),
                                ThoiGianHuy = reader.IsDBNull(reader.GetOrdinal("tg_Huy"))
    ? (DateTime?)null
    : reader.GetDateTime(reader.GetOrdinal("tg_Huy")),
                                LyDoHuy = reader.IsDBNull(reader.GetOrdinal("lyDoHuy"))
    ? null
    : reader.GetString(reader.GetOrdinal("lyDoHuy"))

                            };
                            list.Add(session);
                        }
                    }
                }
            }
            return list;
        }
        public void InsertSession()
        {

        }
        public void SetStateSesssion()
        {
            using (SqlConnection con=new SqlConnection(Ultilities.ConnectionString))
            {
            
                using (SqlCommand cmd=new SqlCommand("[dbo].[sp_UpdateState]", con))
                {
                    con.Open();
                    cmd.CommandType= CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
            }

        }
        
    }
}
