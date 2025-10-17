using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagerment_MVP.Business
{
    public class GoiTap
    {
        public int id { get; set; }
        public string tenGoi { get; set; }
        public int loaiGoi { get; set; }
        public int thoiHanNgay { get; set; }
        public int thoiHanBuoi { get; set; }
        public long giaTien { get; set; }
        public string thongTin {  get; set; } 
        public bool hoatDong { get; set; }
        public long discount { get; set; }
        public DateTime startSellingDate { get; set; }
        public DateTime endSellingDate { get; set; }
        public GoiTap() { }
        public GoiTap(int id, string tenGoi, int loaiGoi, int thoiHanNgay, int thoiHanBuoi, long giaTien, string thongTin, bool hoatDong, long discount, DateTime startSellingDate, DateTime endSellingDate)
        {
            this.id = id;
            this.tenGoi = tenGoi;
            this.loaiGoi = loaiGoi;
            this.thoiHanNgay = thoiHanNgay;
            this.thoiHanBuoi = thoiHanBuoi;
            this.giaTien = giaTien;
            this.thongTin = thongTin;
            this.hoatDong = hoatDong;
            this.discount = discount;
            this.startSellingDate = startSellingDate;
            this.endSellingDate = endSellingDate;
        }
    }
}
