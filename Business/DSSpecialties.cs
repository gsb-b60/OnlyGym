using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagerment_MVP.Business
{
    public class DSSpecialties
    {
        public List<Specialties> specialtiesList;
        public DSSpecialties() {
            specialtiesList=new List<Specialties>();
        }
        public List<Specialties> GetList()
        {
            return specialtiesList;
        }
        public override string ToString()
        {
            if (specialtiesList == null || specialtiesList.Count == 0)
                return "🩺 No specialties found.\n";

            var sb = new StringBuilder();
            sb.AppendLine("📚 Specialties List:");
            sb.AppendLine(new string('=', 30));

            int index = 1;
            foreach (var specialty in specialtiesList)
            {
                sb.AppendLine($"#{index++} 🔹 ID: {specialty.id}");
                sb.AppendLine($"   🧠 Specialty: {specialty.specialty}");
                sb.AppendLine($"   🗒️ Notes: {specialty.notes}");
                sb.AppendLine(new string('-', 30));
            }

            sb.AppendLine($"✨ Total: {specialtiesList.Count} item(s).");
            return sb.ToString();
        }

    }
}
