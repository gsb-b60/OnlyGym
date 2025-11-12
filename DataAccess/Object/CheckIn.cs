using GymManagerment_MVP.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Object
{
    public class CheckIn
    {
        public int ID { get; set; }
        public HocVien HocVien { get; set; }
        public DateTime ThoiGianCheckIn { get; set; }
        public bool HopLe { get; set; }
        public CheckInState LyDo { get; set; }
        public int LanCheckIn { get; set; }
        public string GhiChu { get; set; }

        public string TenHocVien => HocVien.Ten;
        public string CodeHocVien => HocVien.code;

    }
    public enum CheckInState
    {
        allow = 1,
        runout,
        debt,
        syserro,
        blacklist,
    };
}
