using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagerment_MVP.Business
{
    public enum Gender
    {
        Male,
        Female
    }
    public enum State
    {
        Active,
        Inactive,
    }
    public class PT
    {
        public int id { get; set; }
        public string tenLot {  get; set; }
        public string name { get; set; }
        public string sDT { get; set; }
        public State trangThai { get; set; }
        public DateTime? thoiGianXoa { get; set; }
        public Gender? gioiTinh { get; set; }
        public DateTime? ngaySinh { get; set; }
        public string AvatarUrl { get; set; }

        public List<string> specialties = new List<string>();
        public PT() { }
        public PT(int id,string tenLot, string name,string sDT, State trangThai, DateTime thoiGianXoa, Gender gioiTinh, DateTime? ngaySinh, string avatarUrl)
        {
            this.id = id;
            this.name = name;
            this.tenLot = tenLot;
            this.sDT = sDT;
            this.trangThai = trangThai;
            this.thoiGianXoa = thoiGianXoa;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            AvatarUrl = avatarUrl;
        }
        public PT(string specilty)
        {
            specialties.Add(specilty);
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            string genderIcon;

            switch (gioiTinh)
            {
                case Gender.Male:
                    genderIcon = "♂️";
                    break;
                case Gender.Female:
                    genderIcon = "♀️";
                    break;
                default:
                    genderIcon = "⚪";
                    break;
            }

            string stateColor = trangThai == State.Active
                ? "\u001b[32mACTIVE\u001b[0m"  // Green
                : "\u001b[31mINACTIVE\u001b[0m"; // Red

            string birth = ngaySinh.HasValue ? ngaySinh.Value.ToString("yyyy-MM-dd") : "Unknown";
            string delTime = thoiGianXoa.HasValue ? thoiGianXoa.Value.ToString("yyyy-MM-dd HH:mm:ss") : "None";

            string spList = specialties != null && specialties.Count > 0
                ? string.Join(", ", specialties)
                : "(none)";

            sb.AppendLine("┌───────────────────────────────────────────────");
            sb.AppendLine($"│  PT #{id}  {genderIcon}");
            sb.AppendLine("├───────────────────────────────────────────────");
            sb.AppendLine($"│  Name        : {tenLot} {name}");
            sb.AppendLine($"│  Phone       : {sDT}");
            sb.AppendLine($"│  Status      : {stateColor}");
            sb.AppendLine($"│  Birth Date  : {birth}");
            sb.AppendLine($"│  Deleted At  : {delTime}");
            sb.AppendLine($"│  Avatar URL  : {AvatarUrl}");
            sb.AppendLine($"│  Specialties : {spList}");
            sb.AppendLine("└───────────────────────────────────────────────");

            return sb.ToString();
        }
    }
}
