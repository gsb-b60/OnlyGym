using DataAccess.Object;
using DataAccess.Ultilities;
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
        public int insertCheckIn(CheckIn checkIn)
        {
            int lan;
            using (SqlConnection con =new SqlConnection(Ultilities.Ultilities.ConnectionString))
            {
                using (SqlCommand cmd=new SqlCommand(Ultilities.Ultilities.InserCheckIn,con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ID_HocVien", SqlDbType.Int).Value = checkIn.HocVien.id;
                    cmd.Parameters.Add("@HopLe", SqlDbType.Bit).Value = true;
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
