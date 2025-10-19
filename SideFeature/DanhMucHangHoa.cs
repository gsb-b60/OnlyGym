using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagerment_MVP.SideFeature
{
    internal class DanhMucHangHoa
    {
        public static List<HangHoa> ListHang { get; set; }
        public static List<DanhMuc> ListDanhMuc { get; set; }
        HangHoa hangHoa = new HangHoa();

        private static List<DanhMuc> TaoDataDanhMucHangHoa()
        {
            var tenDanhMuc = new[] { "Tất cả", "Quần áo", "Nước uống và đồ ăn", "Phụ kiện tập luyện" };
            return tenDanhMuc
                .Select((ten, index) => new DanhMuc()
            {
                ID = index + 1,
                TenHang = ten
            })
                .ToList();
        }
    }
}
