using GymManagerment_MVP.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagerment_MVP.MainFeature.HoaDonRelated.PT
{
    public partial class ThemPTfrm : Form
    {
        public Business.PT addPT { get; set; }
        public ThemPTfrm()
        {
            
            InitializeComponent();
            lblCatchSDT.Text = "";
            lblCatchSpec.Text = "";
            lblCatchTen.Text = "";
            lblCatchHo.Text = "";
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
                openFile.Title = "Select a image";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pbAvartar.Image = Image.FromFile(openFile.FileName);
                        tbDuongDan.Text = openFile.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        

        private void btnCreatePT_Click(object sender, EventArgs e)
        {
            List<CheckBox> spec = new List<CheckBox>() {
                cbPhucHoiChucNang,
                cbThiDauTT,
                cbGiamCanLT,
                cbGiamCanNu,
                cbGiamCan,
                cbHuanLuyenTheLuc,
                cbThiDauCuTa,
                cbTangCuongSucManh,
                cbBoxFit,
                cbFuncTrain,
                cbYoga,
                cbHLDD,
            };
            List<string> ptSpec= new List<string>();
            foreach (CheckBox checkBox in spec)
            {
                if(checkBox.Checked)
                {
                    ptSpec.Add(checkBox.Text);
                }
            }

            

            if(ptSpec.Count==0)
            {
                lblCatchSpec.Text = "⚠️ Vui lòng chọn ít nhất 1 chuyên môn";
                return;
            }

            lblCatchSDT.Text = "";
            lblCatchSpec.Text = "";
            lblCatchTen.Text = "";
            lblCatchHo.Text = "";
            string tenLot = tbHo.Text.Trim();
            string ten = tbPFTen.Text.Trim();
            string sdt = mtbPFSDT.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenLot))
            {
                lblCatchTen.Text = "⚠️ Vui lòng nhập ten lot.";
                tbPFTen.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(ten))
            {
                lblCatchTen.Text = "⚠️ Vui lòng nhập ten.";
                tbPFTen.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(sdt))
            {
                lblCatchSDT.Text = "⚠️ Vui lòng nhập số điện thoại.";
                mtbPFSDT.Focus();
                return;
            }

            // Optional: check that SDT is numeric or has correct length
            if (!System.Text.RegularExpressions.Regex.IsMatch(sdt, @"^\d{9,10}$"))
            {
                lblCatchSDT.Text = "⚠️ Số điện thoại không hợp lệ (phải có 9–10 chữ số).";
                mtbPFSDT.Focus();
                return;
            }

            addPT = new Business.PT
            {
                tenLot = tbHo.Text,
                name = tbPFTen.Text,
                sDT = mtbPFSDT.Text,
                ngaySinh = dtpNgaysinh.Value,
                gioiTinh = rdNam.Checked ? Gender.Male : Gender.Female,
                AvatarUrl = tbDuongDan.Text,
                specialties=ptSpec,
                trangThai=cbNhanLich.Checked?State.Active:State.Inactive,
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
