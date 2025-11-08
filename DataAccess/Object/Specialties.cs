using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagerment_MVP.Business
{
    public class Specialties
    {
        public int id { get; set; }
        public string specialty { get; set; }
        public string notes { get; set; }
        public Specialties() { }
        public Specialties(int id, string specialty, string notes)
        {
            this.id = id;
            this.specialty = specialty;
            this.notes = notes;
        }
        public override string ToString()
        {
            string divider = new string('─', 40);
            return
    $@"{divider}
🩺  Doctor Profile
{divider}
📘 Id         : {id}
💼 Specialty  : {specialty}
🗒️  Notes      : {notes}
{divider}";
        }
    }
}
