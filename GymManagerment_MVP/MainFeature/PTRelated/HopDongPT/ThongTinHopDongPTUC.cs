using Business;
using DataAccess.Object;
using GymManagerment_MVP.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        public HocVien hv = new HocVien();
        public List<PTSession> sessions = new List<PTSession>();
        public ThongTinHopDongPTUC()
        {
            InitializeComponent();
        }
        public ThongTinHopDongPTUC(HopDong hd)
        {

            InitializeComponent();
            this.hd = hd;
            setupHopDongInfor();
        }
        private void setupHopDongInfor()
        {
            SessionBL sessionBL = new SessionBL();
            sessions = sessionBL.GetByHopDong(hd);
            dgvDSBuoiTap.DataSource = sessions;

            PTRepositoryBL ptbl = new PTRepositoryBL();
            this.pt = ptbl.GetPTByID(hd.IDPT);

            HocVienBL hocVienBL = new HocVienBL();
            this.hv = hocVienBL.GetByID(hd.IDHocVien);

            khTen.Text = hv.Ten;
            khCode.Text = hv.code;
            khID.Text = hv.id.ToString();
            KhSDT.Text = hv.SDT;
            khTrangThai.Text = hv.TrangThai;
            khGioiTinh.Text = hv.GioiTinh ? "Nam" : "Nu";

            btnHV.Tag = hv;

            ptTen.Text = pt.tenLot + " " + pt.name;
            ptSDT.Text = pt.sDT;
            ptGender.Text = pt.gioiTinh == Gender.Male ? "Nam" : "Nu";
            ptTuoi.Text = pt.ngaySinh != null ? (DateTime.Now.Year - pt.ngaySinh?.Year).ToString() : "";
            ptState.Text = pt.trangThai == State.Active ? "Nhan them hoc vien" : "ngung nhan hoc vien";

            btnPT.Tag = pt;

            hdTongBuoi.Text = hd.TongBuoi.ToString();
            hdBuoicon.Text = hd.ConBuoi.ToString();
            hdTrangThai.Text = hd.trangThai.ToString();
            hdNgayTao.Text = hd.NgayTao.ToString();
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chEND_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
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
            if (btnHV.Tag != null)
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
            if (btnPT.Tag != null)
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

        private void dgvDSBuoiTap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSBuoiTap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSBuoiTap.SelectedRows.Count > 0)
            {
                PTSession sess = dgvDSBuoiTap.SelectedRows[0].DataBoundItem as PTSession;

                lblTGBatDau.Text = sess.TGBatDau.ToString();
                cbState.SelectedIndex = (int)sess.TrangThai;
                lblThoiGianTao.Text = sess.ThoiGianTao.ToString();
                lblThoiGianHuy.Text = sess.ThoiGianHuy.ToString();
                rtbGhiChu.Text = sess.LyDoHuy;
                btnCapNhat.Tag = sess.ID;
            }
        }
        public void ApplyFilter()
        {
            List<PTSession> re = sessions;
            List<TrangThaiBuoi> filterlist = new List<TrangThaiBuoi>();

            if (cbBooked.Checked) filterlist.Add(TrangThaiBuoi.Booked);
            if (cbCheckIn.Checked) filterlist.Add(TrangThaiBuoi.Checkedin);
            if (cbDone.Checked) filterlist.Add(TrangThaiBuoi.Done);
            if (cbNoShow.Checked) filterlist.Add(TrangThaiBuoi.NoShow);
            if (cbPTfault.Checked) filterlist.Add(TrangThaiBuoi.PT_Fault);

            if (filterlist.Count > 0)
            {
                re = re.Where(r => filterlist.Contains(r.TrangThai)).ToList();
            }


            dgvDSBuoiTap.DataSource = re;

        }
        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void cbBooked_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cbDone_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cbNoShow_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cbCancel_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cbPTfault_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cbBooked.Checked = false;
            cbCheckIn.Checked = false;
            cbDone.Checked = false;
            cbNoShow.Checked = false;
            cbPTfault.Checked = false;
            ApplyFilter();
        }

        private void dgvDSBuoiTap_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PTSession sess = dgvDSBuoiTap.Rows[e.RowIndex].DataBoundItem as PTSession;
            DataGridViewRow row = dgvDSBuoiTap.Rows[e.RowIndex];
            if (sess == null) return;

            Color color = Color.White; // default

            var now = DateTime.Now;
            var tgkt = sess.TGBatDau?.AddHours(1.5);
            var untilStart = sess.TGBatDau - now;

            // 1️⃣ Ưu tiên trạng thái đặc biệt
            switch (sess.TrangThai)
            {
                case (TrangThaiBuoi)2: color = Color.Green; break;
                case (TrangThaiBuoi)3: color = Color.LightGray; break; // đã kết thúc
                case (TrangThaiBuoi)4: color = Color.OrangeRed; break;  // client not showing
                case (TrangThaiBuoi)5: color = Color.Gray; break;       // cancelled
                case (TrangThaiBuoi)6: color = Color.Purple; break;     // pt fault
                default:
                    // 2️⃣ Buổi đang diễn ra
                    if (sess.TGBatDau <= now && now <= tgkt) color = Color.Green;

                    // 3️⃣ Sắp bắt đầu trong 30 phút
                    else if (untilStart?.TotalMinutes > 0 && untilStart?.TotalMinutes <= 30) color = Color.Gold;
                    break;
            }

            row.DefaultCellStyle.BackColor = color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Bạn chắc chắn muốn dừng hợp đồng này?\n\n⚠️ Hành động này không thể hoàn tác.",
                "Xác nhận hủy hợp đồng",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );

            if (result == DialogResult.Yes)
            {
                if(hd!=null)
                {
                    HopDongBL hdbl = new HopDongBL();
                    hdbl.CancelContract(hd.ID??-1);
                    setupHopDongInfor();
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(btnCapNhat.Tag!=null)
            {
                int id = (int)btnCapNhat.Tag;
                SessionBL sbl = new SessionBL();
                sbl.UpdateLydo(rtbGhiChu.Text, id);
                setupHopDongInfor();
            }
        }
    }
}
