using DataAccess.Object;
using DataAccess.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class SessionBL
    {
        public SessionPTDA sessDa=new SessionPTDA();
        public List<PTSession> GetByIDPT(int id)
        {
            return sessDa.GetByPTID(id);
        }
    }
}
