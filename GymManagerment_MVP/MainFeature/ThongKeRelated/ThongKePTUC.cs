using Business;
using DataAccess.Object;
using GymManagerment_MVP.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagerment_MVP.MainFeature.ThongKeRelated
{
    public partial class ThongKePTUC : UserControl
    {
        List<PT> listPT=new List<PT>();
        List<HopDong> listHopDong = new List<HopDong>();
        List<GoiTapHocVien> listGoiTapHocVien = new List<GoiTapHocVien>();

        public ThongKePTUC()
        {
            InitializeComponent();
        }

        private void ThongKePTUC_Load(object sender, EventArgs e)
        {
            PTRepositoryBL ptbl = new PTRepositoryBL();
            listPT = ptbl.GetAll();

            HopDongBL hopbl = new HopDongBL();
            listHopDong = hopbl.GetAll();

            GoiTapBL goiTapBL = new GoiTapBL();

            //HocVienBL
            //listGoiTapHocVien = goiTapBL.GetPackage();


            var now = DateTime.Now;

            // lọc hợp đồng trong tháng này
            var hopDongTrongThang = listHopDong
                .Where(h => h.NgayTao.Month == now.Month && h.NgayTao.Year == now.Year)
                .ToList();

            // group theo PT
            var thongKe = hopDongTrongThang
                .GroupBy(h => h.IDPT)
                .Select(g => new
                {
                    IDPT = g.Key,
                    TenPT = g.First().TenPT,
                    SoHopDong = g.Count()
                })
                .OrderByDescending(x => x.SoHopDong)
                .ToList();

            var topPT = thongKe.FirstOrDefault();

            dgvThongKe.DataSource = thongKe;
            ThongKeGoi();
        }

        private void ThongKeGoi()
        {
            var now = DateTime.Now;

            var thongKePT = listHopDong
                .Where(h => h.NgayTao.Month == now.Month && h.NgayTao.Year == now.Year)
                .GroupBy(h => h.IDPT)
                .Select(g => new
                {
                    IDPT = g.Key,
                    TenPT = g.First().TenPT,
                    SoHopDong = g.Count()
                })
                .OrderByDescending(x => x.SoHopDong)
                .ToList();
            chartPT.Series.Clear();
            chartPT.ChartAreas[0].AxisX.Interval = 1;

            var series = chartPT.Series.Add("Số hợp đồng");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            foreach (var item in thongKePT)
            {
                series.Points.AddXY(item.TenPT, item.SoHopDong);
            }

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            

        }
    }
}
