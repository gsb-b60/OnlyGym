using DataAccess.Object;
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
    public class GoiHVDA
    {
        public List<GoiHV> getAll()
        {
            return new List<GoiHV>();
        }
        public List<GoiHV> getGoiByIDHV(int id)
        {
            List<GoiHV> gois=new List<GoiHV>();
            using (SqlConnection con=new SqlConnection(Ultilities.Ultilities.ConnectionString))
            {
                string query = "select * from GoiTapCuaHocVien where id_HocVien=@i";
                using (SqlCommand cmd=new SqlCommand(query,con))
                {
                    con.Open();
                    cmd.Parameters.Add("@i", SqlDbType.Int).Value=id;
                    using (SqlDataReader reader=cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            HocVien hv= new HocVien();
                            hv.id=Convert.ToInt32(reader["id_HocVien"]);
                            GoiTap gt=new GoiTap();
                            gt.id = Convert.ToInt32(reader["id_GoiTap"]);
                            GoiHV goiHV = new GoiHV
                            {
                                id = reader.GetInt32(reader.GetOrdinal("ïd")),
                                hocVien = hv,
                                goiTap = gt,
                                ngayBatDau = Convert.ToDateTime(reader["ngayBatDau"]),
                                ngayKetThuc = Convert.ToDateTime(reader["ngayKetThuc"]),
                                buoiConLai = Convert.ToInt32(reader["buoiConLai"]),
                                tienTra = (long)Convert.ToDecimal(reader["tienTra"]),
                                giamGia = (long)Convert.ToDecimal(reader["giamGia"]),
                                NgayTao = Convert.ToDateTime(reader["ngayTao"]),
                                TrangThai = (TrangThaiGoi)Convert.ToInt32(reader["TrangThai"]),
                            };
                            gois.Add(goiHV);
                        }
                    }
                }
            }
            return gois;
        }
    }
}
