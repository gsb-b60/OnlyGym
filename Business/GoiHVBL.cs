using DataAccess.Object;
using DataAccess.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class GoiHVBL
    {
        GoiHVDA goihvda = new GoiHVDA();
        List<GoiHV> getByIDHocVien(int id)
        {
            return goihvda.getGoiByIDHV(id);
        }
    }
}
