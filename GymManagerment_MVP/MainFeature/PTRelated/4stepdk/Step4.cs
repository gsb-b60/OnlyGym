using Business;
using DataAccess.Object;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymManagerment_MVP.MainFeature.HoaDonRelated.PT._4stepdk
{
    public partial class Step4 : UserControl
    {
        public GoiPT goi;
        public int IDPT;
        List<PTSession> list = new List<PTSession>();
        public Business.PT pt;
        public DateTime currentWeekStart;
        List<PTSession> BookList=new List<PTSession>();
        public int SoBuoiConLai;
        public event Action<List<PTSession>> SetToBill;
        public event Action<HopDong> SendHopDong;

        public Step4()
        {
            InitializeComponent();
        }

        public Step4(GoiPT goi, int idPT)
        {
            InitializeComponent();

            SetUp(goi, idPT);

            SessionBL sess = new SessionBL();
            list = sess.GetByIDPT(idPT);

            currentWeekStart = GetStartOfWeek(DateTime.Now);

            LoadWeekData(currentWeekStart);
            SetCurrentWeek();
        }
        
        private void LoadWeekData(DateTime startOfWeek)
        {
            var lichTapList = GenerateLichTapList(list, startOfWeek,BookList);
            dgvLichPT.DataSource = lichTapList;
            LoadTile(currentWeekStart); 
        }
        
        public void LoadTile(DateTime startOfWeek)
        {
            lblWeekRange.Text = $"{startOfWeek:dd/MM} - {startOfWeek.AddDays(6):dd/MM}";
            for (int i = 1; i <= 7; i++)
            {
                string baseHeader = dgvLichPT.Columns[i].HeaderText.Split('-')[0].Trim();
                dgvLichPT.Columns[i].HeaderText = $"{baseHeader}-{startOfWeek.AddDays(i - 1):dd}";
            }
        }

        private void Step4_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            currentWeekStart = GetStartOfWeek(e.Start);
            LoadWeekData(currentWeekStart);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selected = e.Start;

            int diff = selected.DayOfWeek - DayOfWeek.Monday;
            DateTime monday = selected.AddDays(-diff);
            // Chủ Nhật
            DateTime sunday = monday.AddDays(6);
            // Ép MonthCalendar highlight cả tuần
            mcChonTuan.SelectionStart = monday;
            mcChonTuan.SelectionEnd = sunday;

        }
        private void dataGridView4_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvLichPT.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == 0) continue; // bỏ cột khung giờ

                    if (cell.Value is BookState status)
                    {
                        switch (status)
                        {
                            case BookState.Booked:
                                cell.Style.BackColor = Color.Red;
                                cell.ReadOnly = true;
                                break;

                            case BookState.Set:
                                cell.Style.BackColor = Color.LightGreen;
                                cell.ReadOnly = false;
                                break;

                            case BookState.Free:
                                cell.Style.BackColor = Color.White;
                                cell.ReadOnly = false;
                                break;
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HienThiLichPTfrm frm = new HienThiLichPTfrm();
            frm.ShowDialog();
        }
        private List<LichTap> GenerateLichTapList(List<PTSession> sessions, DateTime startOfWeek,List<PTSession> setList)
        {
            var khungGioList = new List<(TimeSpan start, TimeSpan end)>
    {
        (TimeSpan.FromHours(5), TimeSpan.FromHours(6.5)),
        (TimeSpan.FromHours(8), TimeSpan.FromHours(9.5)),
        (TimeSpan.FromHours(10), TimeSpan.FromHours(11.5)),
        (TimeSpan.FromHours(12), TimeSpan.FromHours(13.5)),
        (TimeSpan.FromHours(14), TimeSpan.FromHours(15.5)),
        (TimeSpan.FromHours(16), TimeSpan.FromHours(17.5)),
        (TimeSpan.FromHours(18), TimeSpan.FromHours(19.5)),
        (TimeSpan.FromHours(20), TimeSpan.FromHours(21.5))
    };

            var lichTapList = new List<LichTap>();

            foreach (var khung in khungGioList)
            {
                var lich = new LichTap($"{khung.start:hh\\:mm} - {khung.end:hh\\:mm}");
                for (int i = 0; i < 7; i++)
                {
                    DateTime day = startOfWeek.AddDays(i);
                    BookState isBusy = sessions.Any(s =>
                 s.TGBatDau.HasValue &&
                 s.TGBatDau.Value.Date == day.Date &&
                 s.TGBatDau.Value.TimeOfDay == khung.start)?BookState.Booked:BookState.Free;

                    switch (i)
                    {
                        case 0: lich.Thu2 = isBusy; break;
                        case 1: lich.Thu3 = isBusy; break;
                        case 2: lich.Thu4 = isBusy; break;
                        case 3: lich.Thu5 = isBusy; break;
                        case 4: lich.Thu6 = isBusy; break;
                        case 5: lich.Thu7 = isBusy; break;
                        case 6: lich.CN = isBusy; break;
                    }
                }
                lichTapList.Add(lich);
            }
            //string str = "";
            //foreach(var i in lichTapList)
            //{
            //    str+=i.Thu2.ToString()+"\\\\";
                
            //}
            //MessageBox.Show(str);
            return lichTapList;
        }


        private void dgvLichPT_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 1) return;

            var cell = dgvLichPT.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.ReadOnly) return; // bỏ qua ô bị khóa

            var lichTap = (LichTap)dgvLichPT.Rows[e.RowIndex].DataBoundItem;
            var startOfWeek = currentWeekStart;

            DateTime day = startOfWeek.AddDays(e.ColumnIndex - 1);
            var khung = lichTap.KhungGio.Split('-');
            var start = DateTime.Parse($"{day:yyyy-MM-dd} {khung[0].Trim()}");
            var end = DateTime.Parse($"{day:yyyy-MM-dd} {khung[1].Trim()}");

            // Lấy status hiện tại
            if (cell.Value == null || !(cell.Value is BookState))
                return;

            var status = (BookState)cell.Value;
            MessageBox.Show("my value is" + status.ToString());

            // Nếu đang là Free → chuyển sang TempBooked
            if (status == BookState.Free)
            {
                if (SoBuoiConLai == 0)
                {
                    MessageBox.Show("Bạn đã chọn đủ số buổi cho phép!", "Giới hạn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string key = GenerateKey(start);

                // tạo session tạm
                PTSession sess = createSess(start, end);
                sess.LyDoHuy = key;
                BookList.Add(sess);

                // đổi trạng thái
                SetCellStatus(cell, BookState.Set);
            }
            // Nếu đang là TempBooked → bỏ chọn
            else
            {
                string key = GenerateKey(start);

                var removeSess = BookList.FirstOrDefault(s => s.LyDoHuy == key);
                if (removeSess != null) BookList.Remove(removeSess);

                // đổi trạng thái về Free
                SetCellStatus(cell, BookState.Free);
            }

            setDGVChon();
        }
        private void SetCellStatus(DataGridViewCell cell, BookState status)
        {
            dgvLichPT.CellValueChanged -= dgvLichPT_CellValueChanged_1;

            cell.Value = status;

            dgvLichPT.CellValueChanged += dgvLichPT_CellValueChanged_1;
            cell.Value = status;
            switch (status)
            {
                case BookState.Booked:
                    cell.Style.BackColor = Color.Red;
                    cell.ReadOnly = true;
                    //MessageBox.Show("Im change to set");
                    break;

                case BookState.Set:
                    cell.Style.BackColor = Color.LightGreen;
                    cell.ReadOnly = false;
                    MessageBox.Show("Im change to set");
                    break;

                case BookState.Free:
                    cell.Style.BackColor = Color.White;
                    cell.ReadOnly = false;
                    MessageBox.Show("Im change to free");
                    break;
            }
        }

        private void setDGVChon()
        {
            dgvBuoiChon.DataSource = null;
            dgvBuoiChon.DataSource = BookList;
            SoBuoiConLai=goi.soBuoi- (BookList.Count);
            lblSoBuoiConLai.Text = SoBuoiConLai.ToString();
        }
        private PTSession createSess(DateTime start,DateTime end)
        {
            return new PTSession { 
                TGBatDau=start,
                TGKetThuc=end,
                TrangThai=TrangThaiBuoi.Booked, 
            };
        }
        private string GenerateKey(DateTime start)
        {
            return start.ToString("yyyyMMdd_HHmm");
        }

        private DateTime GetStartOfWeek(DateTime date)
        {
            int diff = (7 + (date.DayOfWeek - DayOfWeek.Monday)) % 7;
            return date.AddDays(-1 * diff).Date;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DateTime currentMonday = mcChonTuan.SelectionStart;

            // Cộng thêm 7 ngày để sang tuần kế
            DateTime nextMonday = currentMonday.AddDays(7);
            DateTime nextSunday = nextMonday.AddDays(6);

            // Ép MonthCalendar highlight trọn tuần mới
            mcChonTuan.SelectionStart = nextMonday;
            mcChonTuan.SelectionEnd = nextSunday;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DateTime currentMonday = mcChonTuan.SelectionStart;
            DateTime prevMonday = currentMonday.AddDays(-7);
            DateTime prevSunday = prevMonday.AddDays(6);
            mcChonTuan.SelectionStart = prevMonday;
            mcChonTuan.SelectionEnd = prevSunday;
        }

        private void btnNow_Click(object sender, EventArgs e)
        {
            SetCurrentWeek();
        }
        public void SetCurrentWeek()
        {
            DateTime currentMonday =GetStartOfWeek(DateTime.Now);
            Debug.WriteLine(currentMonday.ToString());
            DateTime sunday = currentMonday.AddDays(7);
            mcChonTuan.SelectionStart = currentMonday;
            mcChonTuan.SelectionEnd = sunday;
        }
        private void SetUp(GoiPT goi, int idPT)
        {
            lblSoBuoiConLai.Text = goi.soBuoi.ToString();
            lblTenGoi.Text = goi.tenGoi;
            lblTongBuoi.Text = goi.soBuoi.ToString();
            tbPTTen.Text = idPT.ToString();
            PTRepositoryBL ptbl = new PTRepositoryBL();
            pt = ptbl.GetPTByID(idPT);
            this.goi= goi;
            tbTenLot.Text = pt.tenLot;
            tbPTTen.Text = pt.name;
            mtbSDT.Text = pt.sDT;
            cbPTTrangThai.SelectedIndex = pt.trangThai == State.Inactive ? 1 : 0;
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
            SoBuoiConLai = goi.soBuoi;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(SoBuoiConLai==0)
            {
                HopDong hopDong = new HopDong { 
                    IDHocVien= 0,
                    IDPT=pt.id,
                    ID_PT_Package=goi.id,
                    TongBuoi=goi.soBuoi,
                    ConBuoi=goi.soBuoi,
                    trangThai = DataAccess.Object.TrangThai.active,
                };
                
                SetToBill.Invoke(BookList);
                SendHopDong.Invoke(hopDong);
            }
            else
            {
                MessageBox.Show("Con Buoi Chua Chon");
            }
        }

        private void dgvLichPT_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex == 0) return;

            if (e.Value is bool b)
            {
                // true → Set (người đang chọn)
                // false → Free
                e.Value = b ? BookState.Set : BookState.Free;
                e.ParsingApplied = true;
            }
        }


        private void dgvLichPT_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex == 0) return; // bỏ cột khung giờ

            if (dgvLichPT.Rows[e.RowIndex].DataBoundItem is LichTap lich)
            {
                BookState state = GetThuStatusByColumnIndex(lich, e.ColumnIndex);

                // Checkbox true nếu Booked hoặc Set
                e.Value = (state == BookState.Booked || state == BookState.Set);
                e.FormattingApplied = true;
            }
        }
        private BookState GetThuStatusByColumnIndex(LichTap lich, int colIndex)
        {
            switch (colIndex)
            {
                case 1: return lich.Thu2;
                case 2: return lich.Thu3;
                case 3: return lich.Thu4;
                case 4: return lich.Thu5;
                case 5: return lich.Thu6;
                case 6: return lich.Thu7;
                case 7: return lich.CN;
                default: return BookState.Free;
            }
        }


    }
    public enum BookState {
        Free=0,
        Booked,
        Set
    };
    public class LichTap
    {
        public string KhungGio { get; set; }
        public BookState Thu2 { get; set; }
        public BookState Thu3 { get; set; }
        public BookState Thu4 { get; set; }
        public BookState Thu5 { get; set; }
        public BookState Thu6 { get; set; }
        public BookState Thu7 { get; set; }
        public BookState CN { get; set; }

        public LichTap(string khungGio)
        {
            KhungGio = khungGio;
        }
    }
}

//if (e.RowIndex < 0 || e.ColumnIndex < 1) return; // bỏ qua cột khung giờ

//var cell = dgvLichPT.Rows[e.RowIndex].Cells[e.ColumnIndex];
//var lichTap = (LichTap)dgvLichPT.Rows[e.RowIndex].DataBoundItem;
//var startOfWeek = currentWeekStart; // biến global
//DateTime day = startOfWeek.AddDays(e.ColumnIndex - 1);

//var khung = lichTap.KhungGio.Split('-');
//var start = DateTime.Parse($"{day:yyyy-MM-dd} {khung[0].Trim()}");
//var end = DateTime.Parse($"{day:yyyy-MM-dd} {khung[1].Trim()}");
//if ((bool?)cell.Value == true)
//{
//    if(SoBuoiConLai==0)
//    {
//        cell.Value = false;
//        MessageBox.Show("Bạn đã chọn đủ số buổi cho phép!", "Giới hạn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//        return;
//    }

//    string key = GenerateKey(start);
//    // Lấy thời gian thực tế
//    cell.Style.BackColor = Color.LightGreen;

//    PTSession sess = createSess(start, end);
//    sess.LyDoHuy = key;

//    BookList.Add(sess);
//    setDGVChon();
//}
//else
//{
//    string key = GenerateKey(start);

//    var removeSess = BookList.FirstOrDefault(s => s.LyDoHuy == key);
//    if (removeSess != null) BookList.Remove(removeSess);

//    setDGVChon();

//    cell.Style.BackColor = Color.White;
//}