using DataAccess.Object;
using DataAccess.Ultilities;
using GymManagerment_MVP.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repo
{
    public class CheckInDA
    {
        public List<CheckIn> GetDailyCheckIn()
        {
            List<CheckIn> list = new List<CheckIn>();
            using (SqlConnection con = new SqlConnection(Ultilities.Ultilities.ConnectionString))
            {
                string query = "select * from CheckIn WHERE CAST(TGCheckIn AS DATE) = CAST(GETDATE() AS DATE);";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            HocVien hv = new HocVien
                            {
                                id = reader.GetInt32(reader.GetOrdinal("ID_HocVien"))
                            };
                            CheckIn cv = new CheckIn
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                                ThoiGianCheckIn = reader.GetDateTime(reader.GetOrdinal("TGCheckIn")),
                                HopLe = reader.IsDBNull(reader.GetOrdinal("HopLe"))
                                     ? true
                                     : reader.GetBoolean(reader.GetOrdinal("HopLe")),
                                LyDo = reader.IsDBNull(reader.GetOrdinal("LyDo")) ? CheckInState.allow : (CheckInState)reader.GetInt32(reader.GetOrdinal("LyDo")),
                                GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? "" : reader.GetString(reader.GetOrdinal("GhiChu")),
                                HocVien = hv,
                                LanCheckIn = reader.GetInt32(reader.GetOrdinal("lanCheckIn"))
                            };
                            list.Add(cv);
                        }
                    }
                }
                return list;
            }
        }
        public List<CheckIn> GetAllCheckIn()
        {
            List<CheckIn> list = new List<CheckIn>();
            using (SqlConnection con = new SqlConnection(Ultilities.Ultilities.ConnectionString))
            {
                string query = "select * from CheckIn";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            HocVien hv = new HocVien
                            {
                                id = reader.GetInt32(reader.GetOrdinal("ID_HocVien"))
                            };
                            CheckIn cv = new CheckIn
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                                ThoiGianCheckIn = reader.GetDateTime(reader.GetOrdinal("TGCheckIn")),
                                HopLe = reader.IsDBNull(reader.GetOrdinal("HopLe"))
                                     ? true
                                     : reader.GetBoolean(reader.GetOrdinal("HopLe")),
                                LyDo = reader.IsDBNull(reader.GetOrdinal("LyDo")) ? CheckInState.allow : (CheckInState)reader.GetInt32(reader.GetOrdinal("LyDo")),
                                GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? "" : reader.GetString(reader.GetOrdinal("GhiChu")),
                                HocVien = hv,
                                LanCheckIn = reader.GetInt32(reader.GetOrdinal("lanCheckIn"))
                            };
                            list.Add(cv);
                        }
                    }
                }
                return list;
            }
        }
        public int insertCheckIn(CheckIn checkIn)
        {
            int lan;
            using (SqlConnection con = new SqlConnection(Ultilities.Ultilities.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(Ultilities.Ultilities.InserCheckIn, con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ID_HocVien", SqlDbType.Int).Value = checkIn.HocVien.id;
                    cmd.Parameters.Add("@HopLe", SqlDbType.Bit).Value = checkIn.HopLe;
                    cmd.Parameters.Add("@LyDo", SqlDbType.Int).Value = (int)checkIn.LyDo;
                    cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = checkIn.GhiChu;
                    cmd.Parameters.Add("@LanCheckIn", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    lan = Convert.ToInt32(cmd.Parameters["@LanCheckIn"].Value);

                }
            }
            return lan;
        }
    }
}
