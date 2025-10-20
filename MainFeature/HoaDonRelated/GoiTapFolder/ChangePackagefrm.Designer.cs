namespace GymManagerment_MVP.MainFeature.HoaDonRelated.GoiTap
{
    partial class ChangePackagefrm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdCheckTime = new System.Windows.Forms.RadioButton();
            this.gbLastCheck = new System.Windows.Forms.GroupBox();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.lblDen = new System.Windows.Forms.Label();
            this.lblTu = new System.Windows.Forms.Label();
            this.dtpTu = new System.Windows.Forms.DateTimePicker();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.tbGiaTri = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.gbLoaiGoi = new System.Windows.Forms.GroupBox();
            this.nudThoiGianGoi = new System.Windows.Forms.NumericUpDown();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rbBuoi = new System.Windows.Forms.RadioButton();
            this.rdThang = new System.Windows.Forms.RadioButton();
            this.lblDuration = new System.Windows.Forms.Label();
            this.tbTenGoi = new System.Windows.Forms.TextBox();
            this.rtbThongTinGoi = new System.Windows.Forms.RichTextBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblTenGoi = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.gbLastCheck.SuspendLayout();
            this.gbLoaiGoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThoiGianGoi)).BeginInit();
            this.SuspendLayout();
            // 
            // rdCheckTime
            // 
            this.rdCheckTime.AutoSize = true;
            this.rdCheckTime.Location = new System.Drawing.Point(35, 192);
            this.rdCheckTime.Name = "rdCheckTime";
            this.rdCheckTime.Size = new System.Drawing.Size(115, 17);
            this.rdCheckTime.TabIndex = 69;
            this.rdCheckTime.TabStop = true;
            this.rdCheckTime.Text = "Giới Hạn Thời Gian";
            this.rdCheckTime.UseVisualStyleBackColor = true;
            // 
            // gbLastCheck
            // 
            this.gbLastCheck.Controls.Add(this.dtpDen);
            this.gbLastCheck.Controls.Add(this.lblDen);
            this.gbLastCheck.Controls.Add(this.lblTu);
            this.gbLastCheck.Controls.Add(this.dtpTu);
            this.gbLastCheck.Location = new System.Drawing.Point(17, 215);
            this.gbLastCheck.Name = "gbLastCheck";
            this.gbLastCheck.Size = new System.Drawing.Size(336, 138);
            this.gbLastCheck.TabIndex = 68;
            this.gbLastCheck.TabStop = false;
            this.gbLastCheck.Text = "Thời Gian Áp Dụng";
            // 
            // dtpDen
            // 
            this.dtpDen.CustomFormat = "dd/MM/yyyy";
            this.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDen.Location = new System.Drawing.Point(18, 99);
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.Size = new System.Drawing.Size(105, 20);
            this.dtpDen.TabIndex = 28;
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(15, 83);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(27, 13);
            this.lblDen.TabIndex = 27;
            this.lblDen.Text = "Đến";
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Location = new System.Drawing.Point(15, 29);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(20, 13);
            this.lblTu.TabIndex = 26;
            this.lblTu.Text = "Từ";
            // 
            // dtpTu
            // 
            this.dtpTu.CustomFormat = "dd/MM/yyyy";
            this.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTu.Location = new System.Drawing.Point(18, 45);
            this.dtpTu.Name = "dtpTu";
            this.dtpTu.Size = new System.Drawing.Size(105, 20);
            this.dtpTu.TabIndex = 25;
            // 
            // tbDiscount
            // 
            this.tbDiscount.Location = new System.Drawing.Point(253, 523);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(100, 20);
            this.tbDiscount.TabIndex = 67;
            // 
            // tbGiaTri
            // 
            this.tbGiaTri.Location = new System.Drawing.Point(253, 494);
            this.tbGiaTri.Name = "tbGiaTri";
            this.tbGiaTri.Size = new System.Drawing.Size(100, 20);
            this.tbGiaTri.TabIndex = 66;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(9, 369);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(56, 13);
            this.lblGhiChu.TabIndex = 65;
            this.lblGhiChu.Text = "Thông Tin";
            // 
            // gbLoaiGoi
            // 
            this.gbLoaiGoi.Controls.Add(this.nudThoiGianGoi);
            this.gbLoaiGoi.Controls.Add(this.rdNam);
            this.gbLoaiGoi.Controls.Add(this.rbBuoi);
            this.gbLoaiGoi.Controls.Add(this.rdThang);
            this.gbLoaiGoi.Controls.Add(this.lblDuration);
            this.gbLoaiGoi.Location = new System.Drawing.Point(12, 46);
            this.gbLoaiGoi.Name = "gbLoaiGoi";
            this.gbLoaiGoi.Size = new System.Drawing.Size(341, 129);
            this.gbLoaiGoi.TabIndex = 64;
            this.gbLoaiGoi.TabStop = false;
            this.gbLoaiGoi.Text = "Loại Gói";
            // 
            // nudThoiGianGoi
            // 
            this.nudThoiGianGoi.Location = new System.Drawing.Point(23, 80);
            this.nudThoiGianGoi.Name = "nudThoiGianGoi";
            this.nudThoiGianGoi.Size = new System.Drawing.Size(291, 20);
            this.nudThoiGianGoi.TabIndex = 3;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(267, 19);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 2;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Năm";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rbBuoi
            // 
            this.rbBuoi.AutoSize = true;
            this.rbBuoi.Location = new System.Drawing.Point(153, 19);
            this.rbBuoi.Name = "rbBuoi";
            this.rbBuoi.Size = new System.Drawing.Size(46, 17);
            this.rbBuoi.TabIndex = 1;
            this.rbBuoi.TabStop = true;
            this.rbBuoi.Text = "Buổi";
            this.rbBuoi.UseVisualStyleBackColor = true;
            // 
            // rdThang
            // 
            this.rdThang.AutoSize = true;
            this.rdThang.Location = new System.Drawing.Point(23, 19);
            this.rdThang.Name = "rdThang";
            this.rdThang.Size = new System.Drawing.Size(56, 17);
            this.rdThang.TabIndex = 0;
            this.rdThang.TabStop = true;
            this.rdThang.Text = "Tháng";
            this.rdThang.UseVisualStyleBackColor = true;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(20, 51);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(59, 13);
            this.lblDuration.TabIndex = 40;
            this.lblDuration.Text = "Độ Dài Gói";
            // 
            // tbTenGoi
            // 
            this.tbTenGoi.Location = new System.Drawing.Point(91, 10);
            this.tbTenGoi.Name = "tbTenGoi";
            this.tbTenGoi.Size = new System.Drawing.Size(235, 20);
            this.tbTenGoi.TabIndex = 63;
            // 
            // rtbThongTinGoi
            // 
            this.rtbThongTinGoi.Location = new System.Drawing.Point(12, 385);
            this.rtbThongTinGoi.Name = "rtbThongTinGoi";
            this.rtbThongTinGoi.Size = new System.Drawing.Size(342, 95);
            this.rtbThongTinGoi.TabIndex = 62;
            this.rtbThongTinGoi.Text = "";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(250, 552);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(92, 13);
            this.lblThanhTien.TabIndex = 61;
            this.lblThanhTien.Text = "Giá Trị Tính Toán";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(173, 523);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(49, 13);
            this.lbl3.TabIndex = 60;
            this.lbl3.Text = "Discount";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(173, 552);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(62, 13);
            this.lbl2.TabIndex = 59;
            this.lbl2.Text = "Thành Tiền";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(173, 497);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(38, 13);
            this.lbl1.TabIndex = 58;
            this.lbl1.Text = "Giá Trị";
            // 
            // lblTenGoi
            // 
            this.lblTenGoi.AutoSize = true;
            this.lblTenGoi.Location = new System.Drawing.Point(9, 13);
            this.lblTenGoi.Name = "lblTenGoi";
            this.lblTenGoi.Size = new System.Drawing.Size(45, 13);
            this.lblTenGoi.TabIndex = 57;
            this.lblTenGoi.Text = "Tên Gói";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(132, 590);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(103, 23);
            this.btnXacNhan.TabIndex = 56;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // ChangePackagefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 625);
            this.Controls.Add(this.rdCheckTime);
            this.Controls.Add(this.gbLastCheck);
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.tbGiaTri);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.gbLoaiGoi);
            this.Controls.Add(this.tbTenGoi);
            this.Controls.Add(this.rtbThongTinGoi);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblTenGoi);
            this.Controls.Add(this.btnXacNhan);
            this.Name = "ChangePackagefrm";
            this.Text = "ChangePackagefrm";
            this.gbLastCheck.ResumeLayout(false);
            this.gbLastCheck.PerformLayout();
            this.gbLoaiGoi.ResumeLayout(false);
            this.gbLoaiGoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThoiGianGoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdCheckTime;
        private System.Windows.Forms.GroupBox gbLastCheck;
        private System.Windows.Forms.DateTimePicker dtpDen;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtpTu;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.TextBox tbGiaTri;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.GroupBox gbLoaiGoi;
        private System.Windows.Forms.NumericUpDown nudThoiGianGoi;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rbBuoi;
        private System.Windows.Forms.RadioButton rdThang;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox tbTenGoi;
        private System.Windows.Forms.RichTextBox rtbThongTinGoi;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblTenGoi;
        private System.Windows.Forms.Button btnXacNhan;
    }
}