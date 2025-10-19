using GymManagerment_MVP.Business;
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

namespace GymManagerment_MVP.MainFeature.HoaDonRelated.PT
{
    public partial class ThongTinPT : UserControl
    {
        public ThongTinPT()
        {
            InitializeComponent();
        }
        public ThongTinPT(Business.PT pt)
        {
            InitializeComponent();
            SetUpPT(pt);

        }
        private void SetUpPT(Business.PT pt)
        {
            tbPTSDT.Text = pt.sDT;
            tbDuongDan.Text = pt.AvatarUrl;
            tbPTTen.Text = pt.name;
            cbPTTrangThai.SelectedIndex = pt.trangThai == State.Active ? 1 : 0;
            if (pt.thoiGianXoa.HasValue)
            {
                dtpXoa.Value = pt.thoiGianXoa.Value;
                dtpXoa.Checked = true;
            }
            else
            {
                dtpXoa.Checked = false; // hides the value visually
            }
            if (pt.ngaySinh.HasValue)
            {
                dtpNgaysinh.Value = pt.ngaySinh.Value;
                dtpNgaysinh.Checked = true;
            }
            else
            {
                dtpNgaysinh.Checked = false; // hides the value visually
            }
            if (pt.AvatarUrl != null)
            {
                if (pt.AvatarUrl.StartsWith("pt"))
                {
                    pbAvartar.Image = Image.FromFile(@"PTPicture\" + pt.AvatarUrl);
                }
                else
                {
                    try
                    {
                        pbAvartar.Image = Image.FromFile(pt.AvatarUrl.ToString());
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine(e);
                    }
                }

            }
            else
            {
                pbAvartar.Image = Image.FromFile(@"PTPicture\" + "NoShow.jpg");
            }
            if (pt.gioiTinh == Gender.Female)
            {
                rdNu.Checked = true;
            }
            else
            {
                rdNam.Checked = true;
            }
            lbChuyenMon.Items.Clear();
            foreach (string sp in pt.specialties)
            {
                lbChuyenMon.Items.Add(sp);
            }
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
