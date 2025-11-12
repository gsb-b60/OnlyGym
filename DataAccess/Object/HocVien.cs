using DataAccess.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GymManagerment_MVP.Business
{
    public class HocVien
    {
        public int id { get; set; }
        public string code { get; set; }
        public string Ten { get; set; }
        public string SDT { get; set; }
        public string TrangThai { get; set; }
        public bool GioiTinh { get; set; }

    }
}
