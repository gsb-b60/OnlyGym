using DataAccess.Repo;
using GymManagerment_MVP.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class HocVienBL
    {
        HocVienDA hvDA=new HocVienDA();
        public HocVien GetByCode(string code)
        {
            return hvDA.GetByCode(code);
        }
        public bool VerifyCheckIn(string code)
        {
            return hvDA.VarifyCheckIn(code);
        }
        public HocVien GetByID(int id)
        {
            return hvDA.GetByID(id);    
        }
    }
}
