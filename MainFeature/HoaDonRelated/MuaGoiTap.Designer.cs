namespace GymManagerment_MVP.MainFeature.HoaDonRelated
{
    partial class MuaGoiTap
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
            this.gbLastCheck = new System.Windows.Forms.GroupBox();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.btnLoc = new System.Windows.Forms.Button();
            this.lblDen = new System.Windows.Forms.Label();
            this.lblTu = new System.Windows.Forms.Label();
            this.dtpTu = new System.Windows.Forms.DateTimePicker();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.lblTenGoi = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblGiaTri = new System.Windows.Forms.Label();
            this.lblDicount = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.rtbThongTinGoi = new System.Windows.Forms.RichTextBox();
            this.gbLastCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLastCheck
            // 
            this.gbLastCheck.Controls.Add(this.dtpDen);
            this.gbLastCheck.Controls.Add(this.btnLoc);
            this.gbLastCheck.Controls.Add(this.lblDen);
            this.gbLastCheck.Controls.Add(this.lblTu);
            this.gbLastCheck.Controls.Add(this.dtpTu);
            this.gbLastCheck.Location = new System.Drawing.Point(12, 171);
            this.gbLastCheck.Name = "gbLastCheck";
            this.gbLastCheck.Size = new System.Drawing.Size(167, 131);
            this.gbLastCheck.TabIndex = 26;
            this.gbLastCheck.TabStop = false;
            this.gbLastCheck.Text = "Thời Gian Tạo";
            // 
            // dtpDen
            // 
            this.dtpDen.CustomFormat = "dd/MM/yyyy";
            this.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDen.Location = new System.Drawing.Point(6, 90);
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.Size = new System.Drawing.Size(105, 20);
            this.dtpDen.TabIndex = 24;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(33, 135);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(83, 23);
            this.btnLoc.TabIndex = 13;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(3, 74);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(27, 13);
            this.lblDen.TabIndex = 23;
            this.lblDen.Text = "Đến";
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Location = new System.Drawing.Point(3, 35);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(20, 13);
            this.lblTu.TabIndex = 22;
            this.lblTu.Text = "Từ";
            // 
            // dtpTu
            // 
            this.dtpTu.CustomFormat = "dd/MM/yyyy";
            this.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTu.Location = new System.Drawing.Point(6, 51);
            this.dtpTu.Name = "dtpTu";
            this.dtpTu.Size = new System.Drawing.Size(105, 20);
            this.dtpTu.TabIndex = 21;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(216, 278);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(103, 23);
            this.btnXacNhan.TabIndex = 27;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // lblTenGoi
            // 
            this.lblTenGoi.AutoSize = true;
            this.lblTenGoi.Location = new System.Drawing.Point(12, 13);
            this.lblTenGoi.Name = "lblTenGoi";
            this.lblTenGoi.Size = new System.Drawing.Size(45, 13);
            this.lblTenGoi.TabIndex = 28;
            this.lblTenGoi.Text = "Tên Gói";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(12, 42);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(59, 13);
            this.lblDuration.TabIndex = 29;
            this.lblDuration.Text = "Độ Dài Gói";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(183, 186);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(38, 13);
            this.lbl1.TabIndex = 30;
            this.lbl1.Text = "Giá Trị";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(183, 241);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(62, 13);
            this.lbl2.TabIndex = 31;
            this.lbl2.Text = "Thành Tiền";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(183, 212);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(49, 13);
            this.lbl3.TabIndex = 32;
            this.lbl3.Text = "Discount";
            // 
            // lblGiaTri
            // 
            this.lblGiaTri.AutoSize = true;
            this.lblGiaTri.Location = new System.Drawing.Point(301, 186);
            this.lblGiaTri.Name = "lblGiaTri";
            this.lblGiaTri.Size = new System.Drawing.Size(46, 13);
            this.lblGiaTri.TabIndex = 33;
            this.lblGiaTri.Text = "329.000";
            // 
            // lblDicount
            // 
            this.lblDicount.AutoSize = true;
            this.lblDicount.Location = new System.Drawing.Point(307, 212);
            this.lblDicount.Name = "lblDicount";
            this.lblDicount.Size = new System.Drawing.Size(40, 13);
            this.lblDicount.TabIndex = 34;
            this.lblDicount.Text = "50.000";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(304, 241);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(46, 13);
            this.lblThanhTien.TabIndex = 35;
            this.lblThanhTien.Text = "279.000";
            // 
            // rtbThongTinGoi
            // 
            this.rtbThongTinGoi.Location = new System.Drawing.Point(15, 70);
            this.rtbThongTinGoi.Name = "rtbThongTinGoi";
            this.rtbThongTinGoi.Size = new System.Drawing.Size(314, 95);
            this.rtbThongTinGoi.TabIndex = 36;
            this.rtbThongTinGoi.Text = "";
            // 
            // MuaGoiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 314);
            this.Controls.Add(this.rtbThongTinGoi);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.lblDicount);
            this.Controls.Add(this.lblGiaTri);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblTenGoi);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.gbLastCheck);
            this.Name = "MuaGoiTap";
            this.Text = "MuaGoiTap";
            this.gbLastCheck.ResumeLayout(false);
            this.gbLastCheck.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLastCheck;
        private System.Windows.Forms.DateTimePicker dtpDen;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtpTu;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label lblTenGoi;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblGiaTri;
        private System.Windows.Forms.Label lblDicount;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.RichTextBox rtbThongTinGoi;
    }
}