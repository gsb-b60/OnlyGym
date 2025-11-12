using Business;
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
        public CheckinKhachVaoUC()
        {
            InitializeComponent();
        }


        private void pnlThongTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckinKhachVaoUC_Load(object sender, EventArgs e)
        {

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
            HocVienBL hvbl=new HocVienBL();
            HocVien hv=hvbl.GetByCode(code);
            HienThiHocVien(hv);
        }
        private void HienThiHocVien(HocVien hv)
        {
            lblName.Text=hv.Ten;
            lblPhone.Text=hv.SDT;
            lblStatus.Text = hv.TrangThai;
            btnChiTiet.Tag = hv.code;
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
    }
}
