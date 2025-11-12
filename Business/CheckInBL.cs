using DataAccess.Object;
using DataAccess.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CheckInBL
    {
        CheckInDA ciDA = new CheckInDA();
        public int InsertCheckIn(CheckIn cv)
        {
            return ciDA.insertCheckIn(cv);
        }
    }
}
