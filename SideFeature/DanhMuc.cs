using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagerment_MVP.SideFeature
{
    internal class DanhMuc
    {
        public int ID { get; set; }

        public string TenHang { get; set; }

        public DanhMuc()
        {

        }

        public DanhMuc(int id, string tenHang)
        {
            ID = id;
            TenHang = tenHang;
        }
    }
}
