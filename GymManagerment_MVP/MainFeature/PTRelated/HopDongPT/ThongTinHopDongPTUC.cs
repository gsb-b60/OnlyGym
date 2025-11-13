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

namespace GymManagerment_MVP.MainFeature.HoaDonRelated.PT.HopDongPT
{
    public partial class ThongTinHopDongPTUC : UserControl
    {
        public HopDong hd = new HopDong();
        public Business.PT pt = new Business.PT();
        public HocVien hv=new HocVien();
        public List<PTSession> sessions=new List<PTSession>();
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

            PTRepositoryBL ptbl = new PTRepositoryBL();
            this.pt= ptbl.GetPTByID(hd.IDPT);

            HocVienBL hocVienBL= new HocVienBL();
            this.hv = hocVienBL.GetByID(hd.IDHocVien);

            khTen.Text = hv.Ten;
            khCode.Text = hv.code;
            khID.Text = hv.id.ToString();
            KhSDT.Text = hv.SDT;
            khTrangThai.Text = hv.TrangThai;
            khGioiTinh.Text = hv.GioiTinh?"Nam":"Nu";

            btnHV.Tag= hv;

            ptTen.Text = pt.tenLot+" "+pt.name;
            ptSDT.Text = pt.sDT;
            ptGender.Text = pt.gioiTinh == Gender.Male ? "Nam" : "Nu";
            ptTuoi.Text = pt.ngaySinh!=null? (DateTime.Now.Year - pt.ngaySinh?.Year).ToString():"";
            ptState.Text=pt.trangThai==State.Active?"Nhan them hoc vien":"ngung nhan hoc vien";

            btnPT.Tag= pt;

            hdTongBuoi.Text = hd.TongBuoi.ToString();
            hdBuoicon.Text = hd.ConBuoi.ToString();
            hdTrangThai.Text=hd.trangThai.ToString();
            hdNgayTao.Text= hd.NgayTao.ToString();
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

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnHV_Click(object sender, EventArgs e)
        {
            if(btnHV.Tag!=null)
            {
                Mainfrm main = Application.OpenForms.OfType<Mainfrm>().FirstOrDefault();
                if (main != null)
                {
                    main.OpenHocVienUC(hv.code);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy form chính (Mainfrm).", "Lỗi");
                }
            }
        }

        private void btnPT_Click(object sender, EventArgs e)
        {
            if(btnPT.Tag!=null)
            {
                Mainfrm main = Application.OpenForms.OfType<Mainfrm>().FirstOrDefault();
                if (main != null)
                {
                    main.loadUserControl(new ThongTinPT(pt));
                }
                else
                {
                    MessageBox.Show("Không tìm thấy form chính (Mainfrm).", "Lỗi");
                }
            }
        }
    }
}
