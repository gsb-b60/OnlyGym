namespace GymManagerment_MVP
{
    partial class ThongKeDoanhThuUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.gbOverView = new System.Windows.Forms.GroupBox();
            this.lblTKTheo = new System.Windows.Forms.Label();
            this.cbThongKeTheo = new System.Windows.Forms.ComboBox();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lblSoLuongHD = new System.Windows.Forms.Label();
            this.lblDoanhThuTrungBinh = new System.Windows.Forms.Label();
            this.tbTongDoanhThu = new System.Windows.Forms.TextBox();
            this.tbSLHD = new System.Windows.Forms.TextBox();
            this.tbDoanhThuTB = new System.Windows.Forms.TextBox();
            this.gbTuyChon = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.charttest1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlTop.SuspendLayout();
            this.gbOverView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charttest1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.gbTuyChon);
            this.pnlTop.Controls.Add(this.gbOverView);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1064, 100);
            this.pnlTop.TabIndex = 0;
            // 
            // gbOverView
            // 
            this.gbOverView.Controls.Add(this.tbDoanhThuTB);
            this.gbOverView.Controls.Add(this.tbSLHD);
            this.gbOverView.Controls.Add(this.tbTongDoanhThu);
            this.gbOverView.Controls.Add(this.lblDoanhThuTrungBinh);
            this.gbOverView.Controls.Add(this.lblSoLuongHD);
            this.gbOverView.Controls.Add(this.lblTongDoanhThu);
            this.gbOverView.Controls.Add(this.cbThongKeTheo);
            this.gbOverView.Controls.Add(this.lblTKTheo);
            this.gbOverView.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbOverView.Location = new System.Drawing.Point(0, 0);
            this.gbOverView.Name = "gbOverView";
            this.gbOverView.Size = new System.Drawing.Size(526, 100);
            this.gbOverView.TabIndex = 0;
            this.gbOverView.TabStop = false;
            this.gbOverView.Text = "Thong Ke Tong Quat";
            // 
            // lblTKTheo
            // 
            this.lblTKTheo.AutoSize = true;
            this.lblTKTheo.Location = new System.Drawing.Point(7, 20);
            this.lblTKTheo.Name = "lblTKTheo";
            this.lblTKTheo.Size = new System.Drawing.Size(82, 13);
            this.lblTKTheo.TabIndex = 0;
            this.lblTKTheo.Text = "Thong Ke Theo";
            // 
            // cbThongKeTheo
            // 
            this.cbThongKeTheo.FormattingEnabled = true;
            this.cbThongKeTheo.Items.AddRange(new object[] {
            "Tuần này",
            "Tháng này",
            "Năm này"});
            this.cbThongKeTheo.Location = new System.Drawing.Point(106, 20);
            this.cbThongKeTheo.Name = "cbThongKeTheo";
            this.cbThongKeTheo.Size = new System.Drawing.Size(121, 21);
            this.cbThongKeTheo.TabIndex = 1;
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(255, 20);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(89, 13);
            this.lblTongDoanhThu.TabIndex = 2;
            this.lblTongDoanhThu.Text = "Tổng Doanh Thu";
            // 
            // lblSoLuongHD
            // 
            this.lblSoLuongHD.AutoSize = true;
            this.lblSoLuongHD.Location = new System.Drawing.Point(255, 48);
            this.lblSoLuongHD.Name = "lblSoLuongHD";
            this.lblSoLuongHD.Size = new System.Drawing.Size(105, 13);
            this.lblSoLuongHD.TabIndex = 3;
            this.lblSoLuongHD.Text = "Số Lượng Hợp Đồng";
            // 
            // lblDoanhThuTrungBinh
            // 
            this.lblDoanhThuTrungBinh.AutoSize = true;
            this.lblDoanhThuTrungBinh.Location = new System.Drawing.Point(255, 74);
            this.lblDoanhThuTrungBinh.Name = "lblDoanhThuTrungBinh";
            this.lblDoanhThuTrungBinh.Size = new System.Drawing.Size(116, 13);
            this.lblDoanhThuTrungBinh.TabIndex = 4;
            this.lblDoanhThuTrungBinh.Text = "Doanh Thu Trung Binh";
            // 
            // tbTongDoanhThu
            // 
            this.tbTongDoanhThu.Location = new System.Drawing.Point(392, 20);
            this.tbTongDoanhThu.Name = "tbTongDoanhThu";
            this.tbTongDoanhThu.ReadOnly = true;
            this.tbTongDoanhThu.Size = new System.Drawing.Size(100, 20);
            this.tbTongDoanhThu.TabIndex = 5;
            // 
            // tbSLHD
            // 
            this.tbSLHD.Location = new System.Drawing.Point(392, 48);
            this.tbSLHD.Name = "tbSLHD";
            this.tbSLHD.ReadOnly = true;
            this.tbSLHD.Size = new System.Drawing.Size(100, 20);
            this.tbSLHD.TabIndex = 6;
            // 
            // tbDoanhThuTB
            // 
            this.tbDoanhThuTB.Location = new System.Drawing.Point(392, 74);
            this.tbDoanhThuTB.Name = "tbDoanhThuTB";
            this.tbDoanhThuTB.ReadOnly = true;
            this.tbDoanhThuTB.Size = new System.Drawing.Size(100, 20);
            this.tbDoanhThuTB.TabIndex = 7;
            // 
            // gbTuyChon
            // 
            this.gbTuyChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTuyChon.Location = new System.Drawing.Point(526, 0);
            this.gbTuyChon.Name = "gbTuyChon";
            this.gbTuyChon.Size = new System.Drawing.Size(538, 100);
            this.gbTuyChon.TabIndex = 1;
            this.gbTuyChon.TabStop = false;
            this.gbTuyChon.Text = "Tuy Chon";
            // 
            // chart1
            // 
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(106, 120);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(177, 179);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // charttest1
            // 
            chartArea2.Name = "ChartArea1";
            this.charttest1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.charttest1.Legends.Add(legend2);
            this.charttest1.Location = new System.Drawing.Point(634, 120);
            this.charttest1.Name = "charttest1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.charttest1.Series.Add(series2);
            this.charttest1.Size = new System.Drawing.Size(300, 300);
            this.charttest1.TabIndex = 2;
            this.charttest1.Text = "chart2";
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(88, 353);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(300, 300);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chart2";
            // 
            // ThongKeDoanhThuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.charttest1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pnlTop);
            this.Name = "ThongKeDoanhThuUC";
            this.Size = new System.Drawing.Size(1064, 667);
            this.pnlTop.ResumeLayout(false);
            this.gbOverView.ResumeLayout(false);
            this.gbOverView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charttest1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.GroupBox gbOverView;
        private System.Windows.Forms.Label lblDoanhThuTrungBinh;
        private System.Windows.Forms.Label lblSoLuongHD;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.ComboBox cbThongKeTheo;
        private System.Windows.Forms.Label lblTKTheo;
        private System.Windows.Forms.GroupBox gbTuyChon;
        private System.Windows.Forms.TextBox tbDoanhThuTB;
        private System.Windows.Forms.TextBox tbSLHD;
        private System.Windows.Forms.TextBox tbTongDoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart charttest1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}
