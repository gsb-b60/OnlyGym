using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagerment_MVP.SideFeature
{
    public class HangHoa
    {
        public int STT { get; set; }
        public int ID { get; set; }
        public string TenHang { get; set; }
        public string DonViTinh { get; set; }
        public decimal DonGia { get; set; }

        public HangHoa()
        {

        }
        public HangHoa(int stt, int id, string tenHang, string donViTinh, decimal donGia)
        {
            STT = stt;
            ID = id;
            TenHang = tenHang;
            DonViTinh = donViTinh;
            DonGia = donGia;
        }
    }
}
