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

namespace GymManagerment_MVP.MainFeature.HoaDonRelated.PT._4stepdk
{
    public partial class Step4 : UserControl
    {
        List<LichTap> lichTapList = new List<LichTap>();
        public Step4()
        {
            InitializeComponent();
            lichTapList.Add(new LichTap("05:00 - 06:30", false, true, true, false, true, true, false));
            lichTapList.Add(new LichTap("08:00 - 09:30", true, false, true, false, false, true, false));
            lichTapList.Add(new LichTap("10:00 - 11:30", false, true, false, true, false, false, true));
            lichTapList.Add(new LichTap("12:00 - 13:30", false, true, false, false, true, false, true));
            lichTapList.Add(new LichTap("14:00 - 15:30", true, false, true, false, true, false, false));
            lichTapList.Add(new LichTap("16:00 - 17:30", false, true, true, false, false, true, false));
            lichTapList.Add(new LichTap("18:00 - 19:30", true, false, false, true, false, false, true));
            lichTapList.Add(new LichTap("20:00 - 21:30", true, false, true, false, true, false, false));
            dgvLichPT.DataSource = lichTapList;

        }

        private void Step4_Load(object sender, EventArgs e)
        {
            dgvLichPT.AutoGenerateColumns = true;
            dgvLichPT.AllowUserToAddRows = false;

            // Đặt tất cả cột bool thành CheckBoxColumn
            

            // Event xử lý cell vẽ màu
            dgvLichPT.CellFormatting += dataGridView4_CellFormatting;
            dgvLichPT.CellBeginEdit += dataGridView4_CellBeginEdit;
        }

        private void dataGridView4_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
           
        }

        private void dataGridView4_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selected = e.Start;

            // Lấy thứ 2 trong tuần đó
            int diff = selected.DayOfWeek - DayOfWeek.Monday;
            if (diff < 0) diff += 7; // nếu chọn Chủ Nhật thì lùi về tuần trước
            DateTime monday = selected.AddDays(-diff);

            // Chủ Nhật
            DateTime sunday = monday.AddDays(6);

            // Ép MonthCalendar highlight cả tuần
            mcChonTuan.SelectionStart = monday;
            mcChonTuan.SelectionEnd = sunday;

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = dgvLichPT.Rows[e.RowIndex].Cells[e.ColumnIndex];


                if (!cell.ReadOnly) // chỉ xử lý với ô user có thể chọn
                {
                    if ((bool?)cell.Value == true)
                        cell.Style.BackColor = Color.LightGreen; // user chọn thêm
                    else
                        cell.Style.BackColor = Color.White; // user bỏ chọn
                }
            }
        }

        private void dataGridView4_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView4_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvLichPT.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value is bool && (bool)cell.Value)
                    {
                        cell.ReadOnly = true;
                        cell.Style.BackColor = Color.Red;
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HienThiLichPTfrm frm=new HienThiLichPTfrm();
            frm.ShowDialog();
        }
    }
}
