using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagerment_MVP.Business
{
    public class GoiPT
    {
        public int id { get; set; }
        public string tenGoi { get; set; }
        public int soBuoi { get; set; }
        public bool trangThai { get; set; }
        public long giaTien { get; set; }
        public string thongTin { get; set; }
        public long discount { get; set; }
        public GoiPT() { }
        public GoiPT(int id, string tenGoi, int soBuoi, bool trangThai, long giaTien, string thongTin,long discount)
        {
            this.id = id;
            this.tenGoi = tenGoi;
            this.soBuoi = soBuoi;
            this.trangThai = trangThai;
            this.giaTien = giaTien;
            this.thongTin = thongTin;
            this.discount = discount;
        }
        public override string ToString()
        {
            return $@"
✨ PT PACKAGE ✨
────────────────────────────
🆔  ID:          {id}
📦  Name:        {tenGoi}
📅  Sessions:    {soBuoi}
💰  Price:       {giaTien:N0} VND
💸  Discount:    {discount:N0} VND
📋  Info:        {thongTin}
⚙️  Status:      {(trangThai ? "✅ Active" : "❌ Inactive")}
────────────────────────────";
        }


    }
}
