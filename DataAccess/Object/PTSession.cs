using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Object
{
    public enum TrangThaiBuoi {
        Booked=1,
        Checkedin,
        Done,
        NoShow,
        Cancelled,
        PT_Fault
    };
    public class PTSession
    {
        public int? ID { get; set; }
        public int? IDHopDong { get; set; }
        public DateTime? TGBatDau {  get; set; }
        public DateTime? TGKetThuc { get;set; }
        public TrangThaiBuoi TrangThai { get; set; }
        public DateTime? ThoiGianTao { get; set; }
        public DateTime? ThoiGianHuy { get; set; }
        public string LyDoHuy { get; set; }
    }
}
