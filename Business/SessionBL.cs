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
        public HopDongRepoDA hdda = new HopDongRepoDA();

        public void UpdateLydo(string lydo,int id)
        {
            sessDa.UpdateLyDo(id, lydo);
        }
        public List<PTSession> GetByIDPT(int id)
        {
            return sessDa.GetByPTID(id);
        }
        public List<PTSession> GetDaily()
        {
            List<HopDong> hds = hdda.GetAll();
            List<PTSession> pTSessions= sessDa.GetDaily();
            var hdDic = hds.ToDictionary(h => h.ID, h => h);
            foreach (var s in pTSessions)
            {
                if(hdDic.TryGetValue(s.IDHopDong,out var hd))
                {
                    s.hopDong = hd;
                }
            }

            return pTSessions;
        }
        public List<PTSession> GetByHopDong(HopDong hd)
        {
            List<PTSession> list = sessDa.GetByHD((int)(hd.ID!=null?hd.ID:19));
            foreach(var s in list)
            {
                s.hopDong=hd;
            }
            return list;
        }
        public void UpdateSessionState()
        {
            sessDa.SetStateSesssion();
        }
        public void manualUpdateState(int id, int state)
        {
            sessDa.UpdateStateSess(id, state);
        }
    }
}
