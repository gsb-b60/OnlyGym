using Business;
using DataAccess.Object;
using GymManagerment_MVP.Business;
using GymManagerment_MVP.MainFeature.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            pnCheckin.Visible=true;
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


            int lancheckin = cibl.InsertCheckIn(cv);
            lblCheckintimes.Text = lancheckin.ToString();




            LoadCheckIn();
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

            dgvCheckIns.DataSource = re.OrderByDescending(c => c.ThoiGianCheckIn).ToList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void dgvSession_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dgvSession_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            PTSession sess = dgvSession.Rows[e.RowIndex].DataBoundItem as PTSession;
            DataGridViewRow row = dgvSession.Rows[e.RowIndex];
            var now = DateTime.Now;
            var tgkt = sess.TGBatDau?.AddHours(1.5);
            var untilStart = sess.TGBatDau - now;
            if (sess != null)
            {
                if (sess.TGBatDau <= now && now <= tgkt)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
                if (untilStart?.TotalMinutes > 0 && untilStart?.TotalMinutes <= 30)
                {
                    row.DefaultCellStyle.BackColor = Color.Gold;
                    return;
                }

                // 3. Đã kết thúc → XÁM
                if (tgkt < now)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                    return;
                }
            }

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

            dgvSession.DataSource = sess.OrderBy(c => c.TGBatDau).ToList();
        }

        private void btndisappear_Click(object sender, EventArgs e)
        {
            pnCheckin.Visible= false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnCheckin.Visible = true;
        }
    }
}
