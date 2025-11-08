using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Object
{
    public enum TrangThaiTK {
        Xoa=0,
        Active,
        Admin,
        Cashier
    };
    
       
    public class User
    {
        public int? ID { get; set; }
        public string TenTK { get; set; }
        public string MatKhau { get; set; }
        public string email { get; set; }
        public TrangThaiTK TrangThai { get;set; }
        public DateTime Create_At { get;set; }
    }
}
