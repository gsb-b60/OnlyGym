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
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendLine("🧠  PERSONAL TRAINER DIRECTORY");
            sb.AppendLine("═══════════════════════════════════════════════════════");
            sb.AppendLine($"📦 Total Trainers: {pTs.Count}");
            sb.AppendLine();

            if (pTs.Count == 0)
            {
                sb.AppendLine("⚠️  No PTs found in the system.");
                sb.AppendLine("═══════════════════════════════════════════════════════");
                return sb.ToString();
            }

            int index = 1;
            foreach (var pt in pTs)
            {
                sb.AppendLine($"[{index}] -------------------------------------------");
                sb.AppendLine(pt.ToString());
                index++;
            }

            sb.AppendLine("═══════════════════════════════════════════════════════");
            sb.AppendLine($"✔️  Loaded {pTs.Count} PT profiles successfully.");
            sb.AppendLine();

            return sb.ToString();
        }

    }
}
