using Business;
using DataAccess.Object;
using GymManagerment_MVP.Business;
using GymManagerment_MVP.MainFeature.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagerment_MVP
{
    public partial class CheckinKhachVaoUC : UserControl
    {
        HocVien hv=null;
        List<CheckIn> list;
        public CheckinKhachVaoUC()
        {
            InitializeComponent();
        }


        private void pnlThongTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckinKhachVaoUC_Load(object sender, EventArgs e)
        {
            LoadCheckIn();
        }
        private void LoadCheckIn()
        {
            CheckInBL cibl=new CheckInBL();
            list= cibl.GetCheckIns();
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
            
            HocVienBL hvbl=new HocVienBL();
            hv=hvbl.GetByCode(code);
            HienThiHocVien(hv);
            
        }
        private void HienThiHocVien(HocVien hvPara)
        {
            lblName.Text=hvPara.Ten;
            lblPhone.Text= hvPara.SDT;
            lblStatus.Text = hvPara.TrangThai;
            btnChiTiet.Tag = hvPara.code;
            dtpVao.Value = DateTime.Now;
            CheckIn cv = new CheckIn
            {
                HocVien = hv,
                ThoiGianCheckIn = DateTime.Now,
                LyDo = CheckInState.allow,
                GhiChu = ""
            };
            CheckInBL cibl = new CheckInBL();
            int lancheckin = cibl.InsertCheckIn(cv);
            lblCheckintimes.Text=lancheckin.ToString();
            LoadCheckIn();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnChiTiet_Click_1(object sender, EventArgs e)
        {
            if(btnChiTiet.Tag!=null)
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
            if(hv !=null)
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
    }
}
