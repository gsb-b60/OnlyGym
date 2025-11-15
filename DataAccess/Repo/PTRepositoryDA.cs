using DataAccess.Object;
using DataAccess.Ultilities;
using GymManagerment_MVP.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess.Repo
{
    public class PTRepositoryDA
    {
        
        public PT GetByID(int ID)
        {
            PT pt = new PT();
            using (SqlConnection con =new SqlConnection(Ultilities.Ultilities.ConnectionString))
            {
                string query = "select * from PT where ID=@id";
                using (SqlCommand cmd= new SqlCommand(query,con))
                {
                    con.Open();
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value= ID;
                    using (SqlDataReader reader=cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            PT ptsearch = new PT
                            {
                                id = int.Parse(reader["ID"].ToString()),
                                tenLot = reader["Ho"].ToString(),
                                name = reader["Ten"].ToString(),
                                sDT = reader["SDT"].ToString(),
                                trangThai = Convert.ToBoolean(reader["TrangThai"]) ? State.Active : State.Inactive,
                                thoiGianXoa = reader["ThoiGianXoa"] != DBNull.Value ? Convert.ToDateTime(reader["ThoiGianXoa"].ToString()) : (DateTime?)null,
                                gioiTinh = Convert.ToBoolean(reader["GioiTinh"]) ? Gender.Male : Gender.Female,
                                ngaySinh = reader["NgaySinh"] != DBNull.Value ? Convert.ToDateTime(reader["NgaySinh"].ToString()) : (DateTime?)null,
                                AvatarUrl = reader["AvartarUrl"].ToString(),
                            };
                            pt = ptsearch;
                        }
                        
                    }
                }
            }
            return pt;
        }
        public List<PT> GetAll()
        {
            List<PT> list = new List<PT>();
            using (SqlConnection sqlConnection = new SqlConnection(Ultilities.Ultilities.ConnectionString))
            {
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "select * from PT";
                sqlConnection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PT ptInsert = new PT
                        {
                            id = int.Parse(reader["ID"].ToString()),
                            tenLot = reader["Ho"].ToString(),
                            name = reader["Ten"].ToString(),
                            sDT = reader["SDT"].ToString(),
                            trangThai = Convert.ToBoolean(reader["TrangThai"]) ? State.Active : State.Inactive,
                            thoiGianXoa = reader["ThoiGianXoa"] != DBNull.Value ? Convert.ToDateTime(reader["ThoiGianXoa"].ToString()) : (DateTime?)null,
                            gioiTinh = Convert.ToBoolean(reader["GioiTinh"]) ? Gender.Male : Gender.Female,
                            ngaySinh = reader["NgaySinh"] != DBNull.Value ? Convert.ToDateTime(reader["NgaySinh"].ToString()) : (DateTime?)null,
                            AvatarUrl = reader["AvartarUrl"].ToString(),
                        };
                        list.Add(ptInsert);
                    }
                }
            }
            var ptDict = list.ToDictionary(pt => pt.id);
            var spDict = GetSpecialties().ToDictionary(sp => sp.id, sp => sp.specialty);

            using (SqlConnection sqlConnection = new SqlConnection(Ultilities.Ultilities.ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "select * from PTSpecialties";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int idPT = Convert.ToInt32(reader["PT_ID"].ToString());
                        int idSP = Convert.ToInt32(reader["Specialties_ID"].ToString());
                        //string addsp = dSSpecialties.specialtiesList.Find((i) => i.id == idSP).specialty;
                        //dSPT.pTs.Find((i) => i.id == idPT).specialties.Add(addsp);
                        if (ptDict.TryGetValue(idPT, out var pt) && spDict.TryGetValue(idSP, out var spName))
                        {
                            pt.specialties.Add(spName);
                        }
                    }

                }
            }

            return list;
        }
        public List<Specialties> GetSpecialties()
        {
            List<Specialties> list = new List<Specialties>();
            using (SqlConnection sqlConnection = new SqlConnection(Ultilities.Ultilities.ConnectionString))
            {
                sqlConnection.Open();
                string query = "select * from Specialties";
                using (SqlCommand cmd=new SqlCommand(query,sqlConnection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Specialties newspecialty = new Specialties
                            {
                                id = int.Parse(reader["ID"].ToString()),
                                specialty = reader["Specialties"].ToString(),
                                notes = reader["notes"] != DBNull.Value ? reader["notes"].ToString() : ""
                            };
                            list.Add(newspecialty);

                        }

                    }
                }
            }

            return list;
        }
        public void InsertPT(PT ptPara)
        {
            using (SqlConnection connection = new SqlConnection(Ultilities.Ultilities.ConnectionString))
            {
                string query = @"INSERT INTO PT (Ho, Ten, SDT, TrangThai, GioiTinh, NgaySinh, AvartarUrl)
                                 VALUES (@TenLot, @Ten, @SDT,@TrangThai , @GioiTinh, @NgaySinh, @AvatarUrl);";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@TenLot", ptPara.tenLot);
                    cmd.Parameters.AddWithValue("@Ten", ptPara.name);
                    cmd.Parameters.AddWithValue("@SDT", ptPara.sDT);
                    cmd.Parameters.AddWithValue("@TrangThai", ptPara.trangThai == State.Active ? 1 : 0);
                    cmd.Parameters.AddWithValue("@GioiTinh", ptPara.gioiTinh == Gender.Male ? 1 : 0);
                    cmd.Parameters.AddWithValue("@NgaySinh", ptPara.ngaySinh);
                    cmd.Parameters.AddWithValue("@AvatarUrl", ptPara.AvatarUrl);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public List<PT> GetBySpecID(int id)
        {
            List<PT> list = new List<PT>();
            using (SqlConnection sqlConnection = new SqlConnection(Ultilities.Ultilities.ConnectionString))
            {
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "select PT.*\r\n" +
                    "from PT\r\n" +
                    "join PTSpecialties on PTSpecialties.PT_ID=PT.ID\r\n" +
                    "where PTSpecialties.Specialties_ID=@id and PT.TrangThai=1";
                sqlConnection.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        PT ptInsert = new PT
                        {
                            id = int.Parse(reader["ID"].ToString()),
                            tenLot = reader["Ho"].ToString(),
                            name = reader["Ten"].ToString(),
                            sDT = reader["SDT"].ToString(),
                            trangThai = Convert.ToBoolean(reader["TrangThai"]) ? State.Active : State.Inactive,
                            thoiGianXoa = reader["ThoiGianXoa"] != DBNull.Value ? Convert.ToDateTime(reader["ThoiGianXoa"].ToString()) : (DateTime?)null,
                            gioiTinh = Convert.ToBoolean(reader["GioiTinh"]) ? Gender.Male : Gender.Female,
                            ngaySinh = reader["NgaySinh"] != DBNull.Value ? Convert.ToDateTime(reader["NgaySinh"].ToString()) : (DateTime?)null,
                            AvatarUrl = reader["AvartarUrl"].ToString(),
                        };
                        list.Add(ptInsert);
                    }
                }
            }
            var ptDict = list.ToDictionary(pt => pt.id);
            var spDict = GetSpecialties().ToDictionary(sp => sp.id, sp => sp.specialty);

            using (SqlConnection sqlConnection = new SqlConnection(Ultilities.Ultilities.ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "select * from PTSpecialties";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int idPT = Convert.ToInt32(reader["PT_ID"].ToString());
                        int idSP = Convert.ToInt32(reader["Specialties_ID"].ToString());
                        //string addsp = dSSpecialties.specialtiesList.Find((i) => i.id == idSP).specialty;
                        //dSPT.pTs.Find((i) => i.id == idPT).specialties.Add(addsp);
                        if (ptDict.TryGetValue(idPT, out var pt) && spDict.TryGetValue(idSP, out var spName))
                        {
                            pt.specialties.Add(spName);
                        }
                    }

                }
            }

            return list;
        }
    }
}
