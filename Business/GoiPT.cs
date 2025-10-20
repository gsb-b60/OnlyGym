using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagerment_MVP.Business
{
    internal class GoiPT
    {
        public int id { get; set; }
        public string tenGoi  { get; set; }
        public string soBuoi { get; set; }
        public bool trangThai { get; set; }
        public long giaTien { get; set; }
        public string thongTin { get; set; }
        public GoiPT() { }
        public GoiPT(int id, string tenGoi, string soBuoi, bool trangThai, long giaTien, string thongTin)
        {
            this.id = id;
            this.tenGoi = tenGoi;
            this.soBuoi = soBuoi;
            this.trangThai = trangThai;
            this.giaTien = giaTien;
            this.thongTin = thongTin;
        }
    }
}
