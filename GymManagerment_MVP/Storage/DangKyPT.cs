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
    public partial class DangKyPT : UserControl
    {
        List<LichTap> lichTapList = new List<LichTap>();

        public DangKyPT()
        {
            InitializeComponent();
            lichTapList.Add(new LichTap("05:00 - 06:30", false, true, true, false, true, true, false));
            lichTapList.Add(new LichTap("08:00 - 09:30", true, false, true, false, false, true, false));

            // Khung gio 2: 10:00 - 11:30
            lichTapList.Add(new LichTap("10:00 - 11:30", false, true, false, true, false, false, true));

            // Khung gio 3: 12:00 - 13:30
            lichTapList.Add(new LichTap("12:00 - 13:30", false, true, false, false, true, false, true));

            // Khung gio 4: 14:00 - 15:30
            lichTapList.Add(new LichTap("14:00 - 15:30", true, false, true, false, true, false, false));

            // Khung gio 5: 16:00 - 17:30
            lichTapList.Add(new LichTap("16:00 - 17:30", false, true, true, false, false, true, false));

            // Khung gio 6: 18:00 - 19:30
            lichTapList.Add(new LichTap("18:00 - 19:30", true, false, false, true, false, false, true));

            // Khung gio 7: 20:00 - 21:30
            lichTapList.Add(new LichTap("20:00 - 21:30", true, false, true, false, true, false, false));

            Debug.WriteLine(lichTapList[1].ThoiGian);
            dataGridView4.DataSource=lichTapList;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dataGridView4_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridView4.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                // Lấy giá trị của ô checkbox
                bool isChecked = (bool)dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Nếu checkbox đang được chọn (true), hủy việc chỉnh sửa
                if (isChecked)
                {
                    e.Cancel = true;
                   
                }
            }
        }

        private void dataGridView4_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView4.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                // Kiểm tra xem giá trị của ô có phải là true không
                if (e.Value != null && (bool)e.Value == true)
                {
                    // Nếu là true, thay đổi màu nền của ô
                    e.CellStyle.BackColor = System.Drawing.Color.Red;
                    e.CellStyle.SelectionBackColor = System.Drawing.Color.DarkRed; // Màu khi chọn
                    e.CellStyle.ForeColor = System.Drawing.Color.Black; // Giữ màu chữ
                }
                else
                {
                    // Nếu là false, đảm bảo màu trở về mặc định
                    e.CellStyle.BackColor = dataGridView4.DefaultCellStyle.BackColor;
                    e.CellStyle.SelectionBackColor = dataGridView4.DefaultCellStyle.SelectionBackColor;
                    e.CellStyle.ForeColor = dataGridView4.DefaultCellStyle.ForeColor;
                }
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    class LichTap
    {
        public string ThoiGian { get; set; }
        public bool t2 { get; set; }
        public bool t3 { get; set; }
        public bool t4 { get; set; }
        public bool t5 { get; set; }
        public bool t6 { get; set; }
        public bool t7 { get; set; }
        public bool cn { get; set; }

        public LichTap(string thoiGian, bool t2, bool t3, bool t4, bool t5, bool t6, bool t7, bool cn)
        {
            ThoiGian = thoiGian;
            this.t2 = t2;
            this.t3 = t3;
            this.t4 = t4;
            this.t5 = t5;
            this.t6 = t6;
            this.t7 = t7;
            this.cn = cn;
        }
    }
}
