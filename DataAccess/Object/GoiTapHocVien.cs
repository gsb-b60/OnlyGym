using GymManagerment_MVP.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Object
{
    public class GoiTapHocVien
    {
        public int Id { get; set; }
        public int Id_HocVien { get; set; }
        public HocVien HocVien { get; set; }  // optional navigation property
        public int Id_GoiTap { get; set; }
        public GoiTap GoiTap { get; set; }    // optional navigation property

        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int BuoiConLai { get; set; }
        public decimal TienTra { get; set; }
        public decimal GiamGia { get; set; }
        public DateTime NgayTao { get; set; }
        public GoiTapState TrangThai { get; set; }
    }
    public enum GoiTapState
    {
        finish=1,
        active,
        pending,
        unuse,
        cancel

    };
}
