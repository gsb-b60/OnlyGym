using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Ultilities
{
    public class Ultilities
    {
        private static string StrName = "ConnectionStringName";
        public static string ConnectionString = ConfigurationManager.ConnectionStrings[StrName].ConnectionString;

        public static string InsertHopDong= "InsertHopDongPT";
        public static string InsertSession = "InsertBuoiTapPT";

        public static string InserCheckIn = "insertCheckIn";

        public static string VarifyCheckIn = "sp_CheckHocVienGoiTapConHieuLuc";
    }
}
