using DataAccess;
using DataAccess.Repo;
using GymManagerment_MVP.Business;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PTRepositoryBL
    {
        PTRepositoryDA ptDA = new PTRepositoryDA();
        public List<PT> GetAll()
        {
            return ptDA.GetAll();
        }
        public List<Specialties> GetSpecialties()
        {
            return ptDA.GetSpecialties();
        }
        public void InsertPT(PT PTpara)
        {
            ptDA.InsertPT(PTpara);
        }
        public PT GetPTByID(int ID)
        {
            return ptDA.GetByID(ID);
        }
        public List<PT> GetBySpecID(int id)
        {
    //        return ptDA.GetAll().Where(pt => pt.specialties.Any(s => s == spec))
    //.ToList();
              return ptDA.GetBySpecID(id);
        }
    }
}
