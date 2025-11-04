using GymManagerment_MVP.Business;
using GymManagerment_MVP.MainFeature.HoaDonRelated;
using GymManagerment_MVP.MainFeature.HoaDonRelated.PT;
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
    public partial class MuaHang : UserControl
    {

        public MuaHang()
        {
            InitializeComponent();

        }

        private void flpMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MuaHang_Load(object sender, EventArgs e)
        {

            BanGoi banGoi = new BanGoi();
            banGoi.Dock = DockStyle.Fill;
            pnGoiTap.Controls.Add(banGoi);
            banGoi.BringToFront();

            banGoi.SetToBill += BanGoi_SetToBill;


            DangKyPT dangKyPT = new DangKyPT();
            dangKyPT.Dock = DockStyle.Fill;
            pnPT.Controls.Add(dangKyPT);
            dangKyPT.BringToFront();

           

            DangKyPTVer2 dangKyPT2 = new DangKyPTVer2();
            dangKyPT2.Dock = DockStyle.Fill;
            pnPTV2.Controls.Add(dangKyPT2);
            dangKyPT.BringToFront();

            dangKyPT2.SetForBuy += DangKyPT2_SetForBuy;

        }

        private void DangKyPT2_SetForBuy(GoiPT obj)
        {
            int i = dgvBill.Rows.Add(obj.tenGoi, 1, obj.giaTien);
            dgvBill.Rows[i].Tag = obj;
            SetTotal();
        }

        private void BanGoi_SetToBill(GoiTap obj)
        {

            int i=dgvBill.Rows.Add(obj.tenGoi,1,obj.giaTien);
            dgvBill.Rows[i].Tag= obj;
            SetTotal();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pnPT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }


        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvBill.SelectedRows.Count == 0) return;
            dgvBill.Rows.Remove(dgvBill.SelectedRows[0]);
            SetTotal();
        }
        private void SetTotal()
        {
            if (dgvBill.Rows.Count == 0) return;

            decimal discount = 0;
            decimal price = 0;

            foreach (DataGridViewRow row in dgvBill.Rows)
            {
                if (row.Cells["ctt"].Value != null)
                {
                    decimal value;
                    if (decimal.TryParse(row.Cells["ctt"].Value.ToString(), out value))
                    {
                        price += value;
                    }
                }
                var obj = row.Tag;

                if (obj is GoiTap goi)
                {
                    discount+= goi.discount;    
                }
                if(obj is GoiPT goipt)
                {
                    discount += goipt.discount;
                }

            }

            lblTongTienHang.Text = string.Format("{0:N0} đ", price);
            lblDiscount.Text = string.Format("{0:N0} đ", discount);
            lblTongThanhToan.Text= string.Format("{0:N0} đ", price-discount);
        }
    }
}
