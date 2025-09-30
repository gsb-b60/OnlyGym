using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagerment_MVP.Business
{
    internal class PT
    {
        int id { get; set; }
        string tenLot {  get; set; }
        string sDT { get; set; }
        string trangThai { get; set; }
        DateTime thoiGianXoa { get; set; }
        bool gioiTinh { get; set; }
        DateTime ngaySinh { get; set; }
        string AvatarUrl { get; set; }

        public PT() { }
        public PT(int id, string tenLot, string sDT, string trangThai, DateTime thoiGianXoa, bool gioiTinh, DateTime ngaySinh, string avatarUrl)
        {
            this.id = id;
            this.tenLot = tenLot;
            this.sDT = sDT;
            this.trangThai = trangThai;
            this.thoiGianXoa = thoiGianXoa;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            AvatarUrl = avatarUrl;
        }
    }
}
