using DataAccess.Object;
using DataAccess.Repo;
using GymManagerment_MVP.Business;
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
        HocVienDA hocVienDA=new HocVienDA();
        public void UpdateNote(string note, int id)
        {
            ciDA.UpdateNote(note, id);
        }
        public int InsertCheckIn(CheckIn cv)
        {
            return ciDA.insertCheckIn(cv);
        }
        public List<CheckIn> GetCheckIns()
        {
            List<HocVien> listHocVien = hocVienDA.GetHocVien();
            List<CheckIn> listCheckIn= ciDA.GetAllCheckIn();
            var hocvienDic = listHocVien.ToDictionary(hv => hv.id, hv => hv);
            foreach(var cv in listCheckIn)
            {
                if (hocvienDic.TryGetValue(cv.HocVien.id,out var hv))
                {
                    cv.HocVien = hv;
                }
                
            }
            return listCheckIn;
        }
        public List<CheckIn> GetDailyCheckin()
        {
            List<HocVien> listHocVien = hocVienDA.GetHocVien();
            List<CheckIn> listCheckIn = ciDA.GetDailyCheckIn();
            var hocvienDic = listHocVien.ToDictionary(hv => hv.id, hv => hv);
            foreach (var cv in listCheckIn)
            {
                if (hocvienDic.TryGetValue(cv.HocVien.id, out var hv))
                {
                    cv.HocVien = hv;
                }

            }
            return listCheckIn;
        }
    }
}
