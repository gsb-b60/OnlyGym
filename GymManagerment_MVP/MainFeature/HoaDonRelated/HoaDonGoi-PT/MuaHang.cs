using Business;
using DataAccess.Object;
using GymManagerment_MVP.Business;
using GymManagerment_MVP.MainFeature.HoaDonRelated;
using GymManagerment_MVP.MainFeature.HoaDonRelated.PT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagerment_MVP
{
    public partial class MuaHang : UserControl
    {
        List<PTSession> bookedList;
        HocVien hv;
        User user;
        HopDong hd = new HopDong();
        public MuaHang()
        {
            InitializeComponent();

        }
        public MuaHang(string code, User user)
        {
            InitializeComponent();
            HocVienBL hvbl = new HocVienBL();
            hv = hvbl.GetByCode(code);
            this.user = user;
            SetProfile(hv);
        }
        private void SetProfile(HocVien hv)
        {
            lblPFTen.Text = hv.Ten;
            lblSex.Text = hv.GioiTinh ? "Nam" : "Nu";
            lblPFSDT.Text = $"SDT: {hv.SDT}";
            lblPFTrangThai.Text = hv.TrangThai; 
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

            DangKyPTVer2 dangKyPT2 = new DangKyPTVer2();
            dangKyPT2.Dock = DockStyle.Fill;
            pnPTV2.Controls.Add(dangKyPT2);
            dangKyPT2.BringToFront();
            dangKyPT2.SetForBuy += DangKyPT2_SetForBuy;
            dangKyPT2.HopDong += DangKyPT2_HopDong;
            dangKyPT2.ReturnList += DangKyPT2_ReturnList;
        }

        private void DangKyPT2_ReturnList(List<PTSession> obj)
        {
            HopDongBL hdbl = new HopDongBL();
            hd.IDHocVien= 1;
            if(obj.Count>0)
            {
                MessageBox.Show(obj.Count.ToString());
                hdbl.SetUpHopDong(hd, obj);
            }
            else
            {
                MessageBox.Show("nothing here");
            }
            
        }

        private void DangKyPT2_HopDong(HopDong obj)
        {
            hd = obj;
        }

        private void DangKyPT2_SetForBuy(GoiPT obj)
        {
            int i = dgvBill.Rows.Add(obj.tenGoi, 1, obj.giaTien);
            dgvBill.Rows[i].Tag = obj;
            SetTotal();
        }

        private void BanGoi_SetToBill(GoiTap obj)
        {

            int i = dgvBill.Rows.Add(obj.tenGoi, 1, obj.giaTien);
            dgvBill.Rows[i].Tag = obj;
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
                    discount += goi.discount;
                }
                if (obj is GoiPT goipt)
                {
                    discount += goipt.discount;
                }

            }

            lblTongTienHang.Text = string.Format("{0:N0} đ", price);
            lblDiscount.Text = string.Format("{0:N0} đ", discount);
            lblTongThanhToan.Text = string.Format("{0:N0} đ", price - discount);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            List<GoiTap> gois = new List<GoiTap>();
            //List<GoiPT> goipt = new List<GoiPT>();  
            foreach (DataGridViewRow row in dgvBill.Rows)
            {
                if (row.Tag is GoiTap goiTap)
                    gois.Add(goiTap);
                else if (row.Tag is GoiPT goiPT)
                {

                }
                    //bill.GoiPTs.Add(goiPT);
            }
            GoiTapHocVien gthv = new GoiTapHocVien { 
                HocVien=hv,
                GoiTap = gois[0],
                TrangThai=GoiTapState.active,
            };
            GoiTapBL goi = new GoiTapBL();
            goi.addGoiTapHocVien(gthv);
            DisplayBill();
        }
        private void DisplayBill()
        {
            DigitalBill bill = CreateBillFromDataGrid();
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.PaperSize = new PaperSize("Custom", 850, 1100); // A4-ish size
            pd.PrintPage += (s, ev) => PrintBill(ev, bill);

            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = pd,
                Width = 800,
                Height = 600,
                Text = "🔍 Xem trước hóa đơn - GYM FIT CENTER"
            };

            ((Form)preview).StartPosition = FormStartPosition.CenterScreen;
            PrintPreviewControl previewControl = null;
            foreach (Control c in preview.Controls)
            {
                if (c is PrintPreviewControl)
                {
                    previewControl = (PrintPreviewControl)c;
                    break;
                }
            }

            // If found, set zoom
            if (previewControl != null)
            {
                previewControl.AutoZoom = false;
                previewControl.Zoom = 1.0; // 100%
            }
            preview.ShowDialog();
        }
        private void PrintBill(PrintPageEventArgs e, DigitalBill bill)
        {
            Graphics g = e.Graphics;
            float y = 80;
            float left = 100;
            Font headerFont = new Font("Segoe UI", 16, FontStyle.Bold);
            Font subHeaderFont = new Font("Segoe UI", 12, FontStyle.Bold);
            Font textFont = new Font("Segoe UI", 10);
            Font smallFont = new Font("Segoe UI", 9, FontStyle.Italic);
            Pen grayPen = new Pen(Color.Gray, 1);

            // HEADER
            g.DrawString("ONLY GYM & FITNESS CENTER", headerFont, Brushes.Black, left + 130, y);
            y += 30;
            g.DrawString("ADD: 237 Đường Đoàn Thị Điểm, P.Xuan Huong, TP.Đà Lạt", textFont, Brushes.Black, left + 130, y);
            y += 20;
            g.DrawString(" 0823 777 631 |  dihieu2407@gmail.com", textFont, Brushes.Black, left + 130, y);
            y += 30;
            g.DrawLine(grayPen, left, y, left + 600, y);
            y += 30;

            // BILL INFO
            g.DrawString("GYM CHECK-IN BILL", subHeaderFont, Brushes.Black, left + 200, y);
            y += 30;

            g.DrawString($" Date: {bill.NgayLap:HH:mm dd/MM/yyyy}", textFont, Brushes.Black, left, y);
            y += 20;
            g.DrawString($" Customer: {bill.HocVien.Ten} ({bill.HocVien.code})", textFont, Brushes.Black, left, y);
            y += 20;
            g.DrawString($" Phone: {bill.HocVien.SDT}", textFont, Brushes.Black, left, y);
            y += 20;
            g.DrawLine(grayPen, left, y, left + 600, y);
            y += 25;

            // GÓI TẬP SECTION
            if (bill.GoiTaps.Any())
            {
                g.DrawString("Gói Tập:", subHeaderFont, Brushes.Black, left, y);
                y += 25;

                foreach (var gTap in bill.GoiTaps)
                {
                    g.DrawString($"- {gTap.tenGoi}", textFont, Brushes.Black, left + 20, y);
                    g.DrawString($"{gTap.giaTien:n0} VND", textFont, Brushes.Black, left + 400, y);
                    y += 20;
                    if (gTap.discount > 0)
                    {
                        g.DrawString($"  -- Giảm giá: {gTap.discount:n0} VND", smallFont, Brushes.DarkGreen, left + 40, y);
                        y += 15;
                    }
                }
                y += 10;
            }

            // GÓI PT SECTION
            if (bill.GoiPTs.Any())
            {
                g.DrawString("Gói PT (Huấn luyện viên cá nhân):", subHeaderFont, Brushes.Black, left, y);
                y += 25;

                foreach (var gPT in bill.GoiPTs)
                {
                    g.DrawString($"- {gPT.tenGoi} ({gPT.soBuoi} buổi)", textFont, Brushes.Black, left + 20, y);
                    g.DrawString($"{gPT.giaTien:n0} VND", textFont, Brushes.Black, left + 400, y);
                    y += 20;
                    if (gPT.discount > 0)
                    {
                        g.DrawString($"  -- Giảm giá: {gPT.discount:n0} VND", smallFont, Brushes.DarkGreen, left + 40, y);
                        y += 15;
                    }
                }
                y += 10;
            }

            // LINE SEPARATOR
            y += 10;
            g.DrawLine(grayPen, left, y, left + 600, y);
            y += 20;

            // TOTAL
            g.DrawString("TỔNG CỘNG:", new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Black, left, y);
            g.DrawString($"{bill.TongTien:n0} VND", new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Black, left + 400, y);
            y += 40;

            // FOOTER
            g.DrawString($"Người lập hóa đơn: {bill.NguoiTao.TenTK}", textFont, Brushes.Black, left, y);
            y += 20;
            g.DrawString($"Mã nhân viên: #{bill.NguoiTao.ID}", textFont, Brushes.Black, left, y);
            y += 30;

            g.DrawLine(grayPen, left, y, left + 600, y);
            y += 30;
            g.DrawString("Cảm ơn bạn đã tin tưởng Only Gym ", smallFont, Brushes.Gray, left + 160, y);
            y += 20;
            g.DrawString("Giữ hóa đơn này để xác nhận giao dịch!", smallFont, Brushes.Gray, left + 140, y);
        }



        private DigitalBill CreateBillFromDataGrid()
        {
            var bill = new DigitalBill
            {
                HocVien = hv,   // assume you have this info
                NguoiTao = user      // the logged-in employee
            };

            foreach (DataGridViewRow row in dgvBill.Rows)
            {
                if (row.Tag is GoiTap goiTap)
                    bill.GoiTaps.Add(goiTap);
                else if (row.Tag is GoiPT goiPT)
                    bill.GoiPTs.Add(goiPT);
            }

            return bill;
        }

        public class DigitalBill
        {
            public HocVien HocVien { get; set; }
            public User NguoiTao { get; set; }
            public List<GoiTap> GoiTaps { get; set; } = new List<GoiTap>();
            public List<GoiPT> GoiPTs { get; set; } = new List<GoiPT>();
            public DateTime NgayLap { get; set; } = DateTime.Now;

            public long TongTien
            {
                get
                {
                    long sum = 0;
                    foreach (var g in GoiTaps)
                        sum += g.giaTien - g.discount;
                    foreach (var g in GoiPTs)
                        sum += g.giaTien - g.discount;
                    return sum;
                }
            }
        }

    }
}
