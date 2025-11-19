using GymManagerment_MVP.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Object
{
    public class GoiHV
    {
        public int id { get; set; }
        public HocVien hocVien { get; set; }
        public GoiTap goiTap { get; set; }
        public DateTime ngayBatDau { get; set; }
        public DateTime ngayKetThuc { get; set; }
        public int? buoiConLai { get; set; }
        public long tienTra { get; set; }
        public long? giamGia { get; set; }
        public DateTime NgayTao { get; set; }
        public TrangThaiGoi TrangThai { get; set; }
    }
    public enum TrangThaiGoi
    {
        Complete=0,
        Using,
        Pending,
        Unuse,
        Cancel
    }
}
