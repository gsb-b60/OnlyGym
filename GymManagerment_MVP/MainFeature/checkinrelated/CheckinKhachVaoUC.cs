using Business;
using DataAccess.Object;
using GymManagerment_MVP.Business;
using GymManagerment_MVP.MainFeature.HoaDonRelated.PT;
using GymManagerment_MVP.MainFeature.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace GymManagerment_MVP
{
    public partial class CheckinKhachVaoUC : UserControl
    {
        HocVien hv = null;
        List<CheckIn> list;
        List<PTSession> sessList;
        public CheckinKhachVaoUC()
        {
            InitializeComponent();
            pnCheckin.Visible = false;
        }


        private void pnlThongTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckinKhachVaoUC_Load(object sender, EventArgs e)
        {
            LoadCheckIn();
            LoadSession();
        }
        private void LoadSession()
        {
            SessionBL sbl = new SessionBL();
            sessList = sbl.GetDaily();
            dgvSession.DataSource = sessList.OrderBy(c => c.TGBatDau).ToList();
            radioButton2.Checked = true;
        }
        private void LoadCheckIn()
        {
            CheckInBL cibl = new CheckInBL();
            list = cibl.GetDailyCheckin();
            dgvCheckIns.DataSource = list.OrderByDescending(c => c.ThoiGianCheckIn).ToList();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void lblNgayTap_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFakeCheckin_Click(object sender, EventArgs e)
        {
            FrmCheckIn frm = new FrmCheckIn(this);
            frm.Show();
        }
        public void DisplayHocVien(string code)
        {
            hv = null;
            HocVienBL hvbl = new HocVienBL();
            hv = hvbl.GetByCode(code);
            pnCheckin.Visible = true;
            HienThiHocVien(hv);

        }
        private void HienThiHocVien(HocVien hvPara)
        {
            HocVienBL hvbl = new HocVienBL();
            CheckInBL cibl = new CheckInBL();
            CheckIn cv;
            bool allow = hvbl.VerifyCheckIn(hv.code);

            if (allow)
            {
                cbAllow.Checked = true;
                lblLyDo.Text = "Hop Le";
                cv = new CheckIn
                {
                    HocVien = hv,
                    ThoiGianCheckIn = DateTime.Now,
                    LyDo = CheckInState.allow,
                    GhiChu = "",
                    HopLe = allow,

                };
                lblCheckintimes.ForeColor = Color.Black;
                lblLyDo.ForeColor = Color.Black;
            }
            else
            {
                lblLyDo.Text = "Het Han Goi";
                cbAllow.Checked = false;
                cv = new CheckIn
                {
                    HocVien = hv,
                    ThoiGianCheckIn = DateTime.Now,
                    LyDo = CheckInState.runout,
                    GhiChu = "",
                    HopLe = allow,

                };
                lblCheckintimes.ForeColor = Color.Red;
                lblLyDo.ForeColor = Color.Red;
            }

            lblName.Text = hvPara.Ten;
            lblPhone.Text = hvPara.SDT;
            lblStatus.Text = hvPara.TrangThai;
            btnChiTiet.Tag = hvPara.code;
            dtpVao.Value = DateTime.Now;
            rtbNote.Text = "";

            int lancheckin = cibl.InsertCheckIn(cv);
            lblCheckintimes.Text = lancheckin.ToString();


            displayPicture(hvPara.path);

            LoadCheckIn();
        }
        public void displayPicture(string path)
        {
            if (path != null)
            {

                if (File.Exists(@"PTPicture\" + path + ".jpg"))
                {
                    pbAvatar.Image = Image.FromFile(@"PTPicture\" + path + ".jpg");
                }
                else
                {
                    pbAvatar.Image = Image.FromFile("D:\\UNI\\nam3-hk1\\DESKTOP\\GymManagerment_MVP\\GymManagerment_MVP\\Media\\PTPicture\\NoShow.jpg");
                }

            }
            else
            {
                pbAvatar.Image = Image.FromFile(@"HVPicture\" + "NoShow.jpg");
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChiTiet_Click_1(object sender, EventArgs e)
        {
            if (btnChiTiet.Tag != null)
            {
                Mainfrm main = Application.OpenForms.OfType<Mainfrm>().FirstOrDefault();
                if (main != null)
                {
                    main.OpenHocVienUC(btnChiTiet.Tag.ToString());
                }
                else
                {
                    MessageBox.Show("Không tìm thấy form chính (Mainfrm).", "Lỗi");
                }
            }
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if (hv != null)
            {
                Mainfrm main = Application.OpenForms.OfType<Mainfrm>().FirstOrDefault();
                if (main != null)
                {
                    main.OpenMuaHang(hv.code);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy form chính (Mainfrm).", "Lỗi");
                }
            }

        }

        private void cbH_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void chEND_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
        public void ApplyFilter()
        {
            List<CheckIn> re = list;

            if (!cbH.Checked && chEND.Checked)
            {
                re = re.Where((cv) => cv.HopLe == false).ToList();
            }
            else if (cbH.Checked && !chEND.Checked)
            {
                re = re.Where((cv) => cv.HopLe == true).ToList();
            }
            if (textBox2.Text != "")
            {
                var keyword = textBox2.Text.Trim();
                if (!string.IsNullOrEmpty(keyword))
                {
                    re = re.Where(cv =>
       (cv.TenHocVien ?? "").IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
       (cv.GhiChu ?? "").IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0
   ).ToList();
                }
            }

            dgvCheckIns.DataSource = re.OrderByDescending(c => c.ThoiGianCheckIn).ToList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            ApplyFilter();
        }

        private void dgvSession_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dgvSession_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            PTSession sess = dgvSession.Rows[e.RowIndex].DataBoundItem as PTSession;
            DataGridViewRow row = dgvSession.Rows[e.RowIndex];
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Applylist();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Applylist();
        }
        public void Applylist()
        {
            List<PTSession> sess = sessList;
            if (radioButton2.Checked)
            {
                sess = sess.Where(s =>
                    s.TGBatDau != null &&
                    s.TGBatDau.Value.AddHours(3) >= DateTime.Now
                ).ToList();
            }
            if (textBox1.Text != "")
            {
                string keyword = textBox1.Text;
                if (!string.IsNullOrEmpty(keyword))
                {
                    sess = sess.Where(s =>
       (s.TenPT != null &&
        s.TenPT.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
       ||
       (s.TenHocVien != null &&
        s.TenHocVien.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
   ).ToList();
                }
            }

            dgvSession.DataSource = sess.OrderBy(c => c.TGBatDau).ToList();
        }

        private void btndisappear_Click(object sender, EventArgs e)
        {
            pnCheckin.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnCheckin.Visible = true;
        }

        private void dgvCheckIns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCheckIns_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCheckIns.SelectedRows.Count > 0)
            {
                CheckIn cv = dgvCheckIns.SelectedRows[0].DataBoundItem as CheckIn;
                if (cv != null)
                {
                    pnCheckin.Visible = true;
                    cbAllow.Checked = cv.HopLe;
                    lblLyDo.Text = cv.HopLe ? "Hop Le" : "Het Han Goi";
                    lblCheckintimes.ForeColor = cv.HopLe ? Color.Black : Color.Red;
                    lblLyDo.ForeColor = cv.HopLe ? Color.Black : Color.Red;

                    lblName.Text = cv.HocVien.Ten;
                    lblPhone.Text = cv.HocVien.SDT;
                    lblStatus.Text = cv.HocVien.TrangThai;
                    btnChiTiet.Tag = cv.HocVien.code;
                    dtpVao.Value = cv.ThoiGianCheckIn;


                    lblCheckintimes.Text = cv.LanCheckIn.ToString();
                    btnCapNhat.Tag = cv.ID;
                    btnCapNhat.Enabled = true;
                    rtbNote.Text = cv.GhiChu;
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (btnCapNhat.Tag != null)
            {
                CheckInBL cibl = new CheckInBL();
                int id = Convert.ToInt32(btnCapNhat.Tag);
                cibl.UpdateNote(rtbNote.Text, id);
                LoadCheckIn();
            }
        }

        private void pTTrễToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSession(6);
        }
        public void UpdateSession(int state)
        {
            if (dgvSession.SelectedRows.Count > 0)
            {
                PTSession pTSession = dgvSession.SelectedRows[0].DataBoundItem as PTSession;
                if (pTSession != null)
                {
                    int id = (int)pTSession.ID;
                    SessionBL sessionBL = new SessionBL();
                    sessionBL.manualUpdateState(id, state);
                    LoadSession();
                    Applylist();
                }
            }
        }

        private void kháchTrễToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSession(4);
        }

        private void hủyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSession(5);
        }

        private void bắtĐầuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSession(2);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Applylist();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Applylist();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void thongTinPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSession.SelectedRows.Count > 0)
            {
                PTSession pTSession = dgvSession.SelectedRows[0].DataBoundItem as PTSession;
                if (pTSession != null)
                {
                    Mainfrm main = Application.OpenForms.OfType<Mainfrm>().FirstOrDefault();
                    if (main != null)
                    {
                        PTRepositoryBL ptbl = new PTRepositoryBL();
                        PT pt = ptbl.GetPTByID(pTSession.hopDong.IDPT);
                        main.loadUserControl(new ThongTinPT(pt));
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy form chính (Mainfrm).", "Lỗi");
                    }
                }
            }
        }

        private void thongTinKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSession.SelectedRows.Count > 0)
            {
                PTSession pTSession = dgvSession.SelectedRows[0].DataBoundItem as PTSession;
                if (pTSession != null)
                {
                    Mainfrm main = Application.OpenForms.OfType<Mainfrm>().FirstOrDefault();
                    if (main != null)
                    {
                        HocVienBL hvbl = new HocVienBL();
                        HocVien hv = hvbl.GetByID(pTSession.hopDong.IDHocVien);
                        main.OpenHocVienUC(hv.code);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy form chính (Mainfrm).", "Lỗi");
                    }
                }
            }
        }
    }
}
