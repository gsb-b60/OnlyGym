using Business;
using DataAccess.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagerment_MVP.MainFeature.HoaDonRelated.PT.HopDongPT
{
    public partial class ThongTinHopDongPTUC : UserControl
    {
        HopDong hd = new HopDong();
        Business.PT pt = new Business.PT();
        List<PTSession> sessions=new List<PTSession>();
        public ThongTinHopDongPTUC()
        {
            InitializeComponent();
        }
        public ThongTinHopDongPTUC(HopDong hd)
        {

            InitializeComponent();
            this.hd = hd;
            SessionBL sessionBL = new SessionBL();
            sessions = sessionBL.GetByIDPT(hd.IDPT);
            dgvDSBuoiTap.DataSource= sessions;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chEND_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }
    }
}
