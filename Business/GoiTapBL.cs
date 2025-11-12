using DataAccess.Object;
using DataAccess.Ultilities;
using GymManagerment_MVP.Business;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class GoiTapBL
    {
        public GoiTapDA goiDa=new GoiTapDA();
        public List<GoiTap> GetPackage()
        {
            return goiDa.GetPackage();
        }
        public void addGoiTapHocVien(GoiTapHocVien gthv)
        {
            goiDa.InsertGoiTapHocVien(gthv);
        }
    }
}
