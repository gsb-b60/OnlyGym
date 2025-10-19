using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagerment_MVP.SideFeature
{
    public class ThietBi
    {
        public int ID { get; set; }

        public string TenTB { get; set; }

        public string HangThietBi { get; set; }

        public string ViTri { get; set; }

        public int SoLuong { get; set; }

        public string TinhTrang { get; set; }

        public ThietBi()
        {

        }

        public ThietBi(int id, string tenTB, string hangThietBi, string viTri, int soLuong, string tinhTrang)
        {
            ID = id;
            TenTB = tenTB;
            HangThietBi = hangThietBi;
            ViTri = viTri;
            SoLuong = soLuong;
            TinhTrang = tinhTrang;
        }
    }
}
