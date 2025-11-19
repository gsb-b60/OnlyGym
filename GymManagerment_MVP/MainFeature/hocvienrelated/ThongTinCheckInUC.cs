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
    public partial class ThongTinCheckInUC : UserControl
    {
        public ThongTinCheckInUC()
        {
            InitializeComponent();
        }
        public ThongTinCheckInUC(HocVien hv)
        {
            InitializeComponent();
            CheckInBL cibl = new CheckInBL();
            
            List<CheckIn> listCV = cibl.GetCheckIns();
            listCV = listCV.Where(l => l.CodeHocVien == hv.code).ToList();
            dgvSession.DataSource = listCV;
        }

        private void ThongTinCheckInUC_Load(object sender, EventArgs e)
        {
            CheckInBL cibl = new CheckInBL();
            cibl.GetCheckIns();
            
        }
    }
}
