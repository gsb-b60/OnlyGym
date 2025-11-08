use GymManagement_1




select PT.Ho,PT.Ten,PT.SDT,PT.GioiTinh,PT.AvartarUrl,PT.ID,PT.NgaySinh
from PT
join PTSpecialties on PTSpecialties.PT_ID=PT.ID
where PTSpecialties.Specialties_ID=1 and PT.TrangThai=1