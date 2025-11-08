using DataAccess.Ultilities;
using GymManagerment_MVP.Business;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
    }
}
