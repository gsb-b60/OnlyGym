using DataAccess.Object;
using DataAccess.Ultilities;
using GymManagerment_MVP.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class GoiTapDA
    {
        public List<GoiTap> GetPackage()
        {
            List<GoiTap> list = new List<GoiTap>();
            using (SqlConnection connection = new SqlConnection(Ultilities.ConnectionString))
            {
                string query = "select * from GoiTap";

                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GoiTap goiTap = new GoiTap
                            {
                                id = Convert.ToInt32(reader["ID"]),
                                tenGoi = reader["TenGoi"].ToString(),
                                loaiGoi = Convert.ToInt32(reader["LoaiGoi"]),
                                thoiHanNgay = reader["ThoiHanNgay"] == DBNull.Value ? 0 : Convert.ToInt32(reader["ThoiHanNgay"]),
                                thoiHanBuoi = reader["ThoiHanBuoi"] == DBNull.Value ? 0 : Convert.ToInt32(reader["ThoiHanBuoi"]),
                                giaTien = Convert.ToInt64(reader["GiaTien"]),
                                thongTin = reader["ThongTin"] != DBNull.Value ? reader["ThongTin"].ToString() : "",
                                hoatDong = Convert.ToBoolean(reader["HoatDong"]),
                                discount = reader["Discount"] != DBNull.Value ? Convert.ToInt64(reader["Discount"]) : 0,
                                startSellingDate = reader["StartSellingDate"] != DBNull.Value ? Convert.ToDateTime(reader["StartSellingDate"]) : DateTime.MinValue,
                                endSellingDate = reader["EndSellingDate"] != DBNull.Value ? Convert.ToDateTime(reader["EndSellingDate"]) : DateTime.MinValue,

                            };
                            list.Add(goiTap);
                        }
                    }
                }
           }
            return list;
        }
        public void InsertGoiTapHocVien(GoiTapHocVien gthv)
        {
            using (SqlConnection con=new SqlConnection(Ultilities.ConnectionString))
            {
                string query = "insert into GoiTapCuaHocVien(id_HocVien,id_GoiTap,ngayBatDau,ngayKetThuc,buoiConLai,tienTra,giamGia,ngayTao,TrangThai)\r\n" +
                    "values(@idhocvien,@idgoi,@tgbd,@tgkt,@buoi,@tien,@dis,@ngaytao,@state);";
                using (SqlCommand cmd =new SqlCommand(query,con))
                {
                    con.Open();
                    cmd.Parameters.Add("@idhocvien",SqlDbType.Int).Value=gthv.HocVien.id;
                    cmd.Parameters.Add("@idgoi", SqlDbType.Int).Value = gthv.GoiTap.id;
                    if(gthv.GoiTap.loaiGoi==1)
                    {
                        cmd.Parameters.Add("@tgbd", SqlDbType.DateTime).Value = DateTime.Now;
                        cmd.Parameters.Add("@tgkt", SqlDbType.DateTime).Value = DateTime.Now.AddDays(gthv.GoiTap.thoiHanNgay);
                        cmd.Parameters.Add("@buoi", SqlDbType.Int).Value = DBNull.Value;
                        
                    }
                    else
                    {
                        cmd.Parameters.Add("@tgbd", SqlDbType.DateTime).Value = DBNull.Value;
                        cmd.Parameters.Add("@tgkt", SqlDbType.DateTime).Value = DBNull.Value;
                    }
                    cmd.Parameters.Add("@tien", SqlDbType.Decimal).Value = gthv.GoiTap.giaTien;
                    cmd.Parameters.Add("@dis", SqlDbType.Decimal).Value = gthv.GoiTap.discount;
                    cmd.Parameters.Add("@state", SqlDbType.Int).Value = (int)gthv.TrangThai;
                    cmd.Parameters.Add("@ngaytao", SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
