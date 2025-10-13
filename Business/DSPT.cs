using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagerment_MVP.Business
{
    public class DSPT
    {
        public List<PT> pTs;
        public DSPT() { 
            pTs = new List<PT>();
        }

        public List<PT> getList() { return pTs; }
        public List<PT> getUA() { 
            return pTs.FindAll((i)=>i.trangThai==State.Inactive);
        }
        public List<PT> getA()
        {
            return pTs.FindAll((i) => i.trangThai == State.Active);
        }
        public List<PT> getM()
        {
            return pTs.FindAll((i) => i.gioiTinh == Gender.Male);
        }
        public List<PT> getF()
        {
            return pTs.FindAll((i) => i.gioiTinh == Gender.Female);
        }
        public List<PT> getD()
        {
            return pTs.FindAll((i) => i.thoiGianXoa != (DateTime?)null);
        }
    }
}
