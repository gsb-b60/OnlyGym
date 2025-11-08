using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Object
{
    public enum TrangThai
    {
        
        active=1,
        paused,
        completed,
        cancelled,
    };
    public class HopDong
    {
        public int? ID { get; set; }
        public int IDHocVien { get; set; }
        public int IDPT { get; set; }
        public int ID_PT_Package { get; set; }
        public string TenHocVien { get; set; }
        public string TenPT { get; set; }
        public string TenGoi { get; set; }
        public int TongBuoi { get; set; }
        public int ConBuoi { get; set; }
        public TrangThai trangThai { get; set; }
        public DateTime NgayTao { get; set; }
    }
}
