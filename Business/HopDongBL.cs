using DataAccess.Object;
using DataAccess.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class HopDongBL
    {
        HopDongRepoDA hopdonDA=new HopDongRepoDA();
        public List<HopDong> GetAll()
        {
            return hopdonDA.GetAll();
        }
        public void SetUpHopDong(HopDong hopDong,List<PTSession> bookedList)
        {
            hopdonDA.InsertHopDong(hopDong, bookedList);
        }
        public void CancelContract(int id)
        {
            if(id!=-1)
            {
                hopdonDA.CancelContract(id);
            }    
           
        }
    }
}
