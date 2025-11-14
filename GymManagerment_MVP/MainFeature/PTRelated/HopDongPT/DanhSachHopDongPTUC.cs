using Business;
using DataAccess.Object;
using GymManagerment_MVP.Business;
using GymManagerment_MVP.MainFeature.HoaDonRelated.PT.HopDongPT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagerment_MVP.MainFeature.HoaDonRelated.PT
{
    public partial class DanhSachHopDongPTUC : UserControl
    {
        public List<HopDong> sourceList;
        public DanhSachHopDongPTUC()
        {
            InitializeComponent();
        }

        private void DanhSachHopDongPTUC_Load(object sender, EventArgs e)
        {
            SetData();
            DisplayAnalist();
            pnInfor.Visible = false;
        }

        public void SetData()
        {
            HopDongBL hopDong = new HopDongBL();
            sourceList = hopDong.GetAll();
            DisplayList(sourceList);
        }
        public void DisplayList(List<HopDong> list)
        {
            dgvDanhSachHopDong.DataSource = list;
        }
        private void DisplayAnalist()
        {
            int activeCount = 0;
            int pausedCount = 0;
            int completedCount = 0;
            int cancelledCount = 0;

            foreach (var i in sourceList)
            {
                switch (i.trangThai)
                {
                    case TrangThai.active:
                        activeCount++;
                        break;
                    case TrangThai.paused:
                        pausedCount++;
                        break;
                    case TrangThai.completed:
                        completedCount++;
                        break;
                    case TrangThai.cancelled:
                        cancelledCount++;
                        break;
                }

            }

            lblActive.Text = activeCount.ToString();
            lblPending.Text = pausedCount.ToString();
            lblFinish.Text = completedCount.ToString();
            lblCancel.Text = cancelledCount.ToString();
        }

        private void ApplyAllFiltersAndSearch()
        {
            // Step 1: start from full source
            var result = sourceList;



            List<TrangThai> selectedStates = new List<TrangThai>();

            if (cbChuaHoanThanh.Checked) selectedStates.Add(TrangThai.active);
            if (cbPend.Checked) selectedStates.Add(TrangThai.paused);
            if (cbH.Checked) selectedStates.Add(TrangThai.completed);
            if (cbCancel.Checked) selectedStates.Add(TrangThai.cancelled);


            if (selectedStates.Count > 0)
            {
                result = result
                    .Where(hd => selectedStates.Contains(hd.trangThai))
                    .ToList();
            }
            string keyword = tbSearch.Text;

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                var terms = keyword.ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                result = result
                    .ToList() // ensure local filtering if using EF
                    .Where(hd =>
                        terms.All(term =>
                            hd.ID.ToString().Contains(term) ||
                            hd.IDHocVien.ToString().Contains(term) ||
                            (hd.TenHocVien?.ToLower().Contains(term) ?? false) ||
                            (hd.TenPT?.ToLower().Contains(term) ?? false) ||
                            hd.NgayTao.ToString("dd/MM/yyyy").ToLower().Contains(term) ||
                            hd.trangThai.ToString().ToLower().Contains(term) ||
                            hd.TenGoi.ToLower().Contains(term)
                        )
                    )
                    .ToList();
            }


            DisplayList(result);
        }

        private void cbChuaHoanThanh_CheckedChanged(object sender, EventArgs e)
        {
            ApplyAllFiltersAndSearch();
        }

        private void cbH_CheckedChanged(object sender, EventArgs e)
        {
            ApplyAllFiltersAndSearch();
        }

        private void cbPend_CheckedChanged(object sender, EventArgs e)
        {
            ApplyAllFiltersAndSearch();
        }

        private void cbCancel_CheckedChanged(object sender, EventArgs e)
        {
            ApplyAllFiltersAndSearch();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cbChuaHoanThanh.Checked = false;
            cbPend.Checked = false;
            cbH.Checked = false;
            cbCancel.Checked = false;

            DisplayList(sourceList);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyAllFiltersAndSearch();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            tbSearch.Text = string.Empty;
            ApplyAllFiltersAndSearch();
        }

        private void dgvDanhSachHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSachHopDong.Rows[e.RowIndex];
                HopDong hd = row.DataBoundItem as HopDong;
                //lblID.Text = row.Cells["ID"].Value?.ToString();
                lblIDHopDong.Text = row.Cells["IDHocVien"].Value?.ToString();
                lblPTID.Text = row.Cells["IDPT"].Value?.ToString();
                lblIDPackage.Text = row.Cells["ID_PT_Package"].Value?.ToString();

                lblTen.Text = row.Cells["TenHocVien"].Value?.ToString();
                lblTenPT.Text = row.Cells["TenPT"].Value?.ToString();
                lblTenGoi.Text = row.Cells["TenGoi"].Value?.ToString();

                lblBuoi.Text = row.Cells["TongBuoi"].Value?.ToString() + "/" + row.Cells["ConBuoi"].Value?.ToString();

                cbTrangThai.SelectedItem = row.Cells["trangThai"].Value?.ToString();
                btnChiTietHopDong.Tag = hd;

                cbTrangThai.SelectedIndex = (int)hd.trangThai;

                //if (DateTime.TryParse(row.Cells["NgayTao"].Value?.ToString(), out DateTime ngayTao))
                //{
                //    dtpNgayTao.Value = ngayTao;
                //}
                pnInfor.Visible= true;

                SessionBL cibl = new SessionBL();
                List<PTSession> sesss= cibl.GetByHopDong(hd);
                dgvSession.DataSource = sesss;
            }
        }

        private void btnChiTietHopDong_Click(object sender, EventArgs e)
        {
            if (btnChiTietHopDong.Tag != null)
            {
                Mainfrm main = Application.OpenForms.OfType<Mainfrm>().FirstOrDefault();
                if (main != null)
                {
                    main.loadUserControl(new ThongTinHopDongPTUC(btnChiTietHopDong.Tag as HopDong));
                }
                else
                {
                    MessageBox.Show("Không tìm thấy form chính (Mainfrm).", "Lỗi");
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            pnInfor.Visible = false;
        }

        private void dgvSession_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvSession.RowHeadersDefaultCellStyle.ForeColor))
            {
                string rowNumber = (e.RowIndex + 1).ToString(); // +1 để bắt đầu từ 1
                e.Graphics.DrawString(rowNumber, e.InheritedRowStyle.Font, b,
                    e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 4);
            }
        }

        private void dgvSession_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void dgvDanhSachHopDong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            HopDong hdp = dgvDanhSachHopDong.Rows[e.RowIndex].DataBoundItem as HopDong;
            DataGridViewRow row = dgvDanhSachHopDong.Rows[e.RowIndex];
            if (hdp == null) return;

            Color color = Color.White; // default

            // 1️⃣ Ưu tiên trạng thái đặc biệt
            switch (hdp.trangThai)
            {
                case (TrangThai)2: color = Color.Green; break;
                case (TrangThai)3: color = Color.LightGray; break;
                case (TrangThai)4: color = Color.OrangeRed; break;  
            }

            row.DefaultCellStyle.BackColor = color;
        }
    }
}
