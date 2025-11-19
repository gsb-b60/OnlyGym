using Business;
using DataAccess.Object;
using GymManagerment_MVP.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagerment_MVP.MainFeature.HocVienRelated
{
    public partial class ThongTinGoiTapPTUC : UserControl
    {
        public ThongTinGoiTapPTUC()
        {
            InitializeComponent();
        }
        public ThongTinGoiTapPTUC(HocVien hv)
        {
            InitializeComponent();
            HopDongBL hdbl = new HopDongBL();
            List<HopDong> list = hdbl.GetAll();
            list = list.Where(l => l.IDHocVien == hv.id).ToList();
            dgvDanhSachHopDong.DataSource = list;
        }

    }
}
