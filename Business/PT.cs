using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagerment_MVP.Business
{
    public class PT
    {
        public int id { get; set; }
        public string tenLot {  get; set; }
        public string name { get; set; }
        public string sDT { get; set; }
        public string trangThai { get; set; }
        public DateTime? thoiGianXoa { get; set; }
        public bool? gioiTinh { get; set; }
        public DateTime? ngaySinh { get; set; }
        public string AvatarUrl { get; set; }

        public PT() { }
        public PT(int id,string tenLot, string name,string sDT, string trangThai, DateTime thoiGianXoa, bool gioiTinh, DateTime? ngaySinh, string avatarUrl)
        {
            this.id = id;
            this.name = name;
            this.tenLot = tenLot;
            this.sDT = sDT;
            this.trangThai = trangThai;
            this.thoiGianXoa = thoiGianXoa;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            AvatarUrl = avatarUrl;
        }
        public override string ToString()
        {
            return $"{id} {name} {tenLot} {sDT} {trangThai} {thoiGianXoa?.Year} {gioiTinh} {ngaySinh?.Year} {AvatarUrl}";
        }
    }
}
