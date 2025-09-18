namespace GymManagerment_MVP
{
    partial class ThemHocVienfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemHocVienfrm));
            this.gbSex = new System.Windows.Forms.GroupBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.btnChonHinh = new System.Windows.Forms.Button();
            this.tbDuongDan = new System.Windows.Forms.TextBox();
            this.tbPFSDT = new System.Windows.Forms.TextBox();
            this.lblPFSDT = new System.Windows.Forms.Label();
            this.tbPFTen = new System.Windows.Forms.TextBox();
            this.lblPFTen = new System.Windows.Forms.Label();
            this.pbAvartar = new System.Windows.Forms.PictureBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnDKPT = new System.Windows.Forms.Button();
            this.btnDKGoi = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.gbSex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvartar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSex
            // 
            this.gbSex.Controls.Add(this.rdNu);
            this.gbSex.Controls.Add(this.rdNam);
            this.gbSex.Location = new System.Drawing.Point(192, 176);
            this.gbSex.Name = "gbSex";
            this.gbSex.Size = new System.Drawing.Size(251, 50);
            this.gbSex.TabIndex = 74;
            this.gbSex.TabStop = false;
            this.gbSex.Text = "Giới Tính";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(132, 19);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 1;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(31, 19);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 0;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaysinh.Location = new System.Drawing.Point(267, 90);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(169, 20);
            this.dtpNgaysinh.TabIndex = 73;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(189, 96);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(56, 13);
            this.lblNgaySinh.TabIndex = 72;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Location = new System.Drawing.Point(382, 232);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(61, 23);
            this.btnChonHinh.TabIndex = 71;
            this.btnChonHinh.Text = "...";
            this.btnChonHinh.UseVisualStyleBackColor = true;
            // 
            // tbDuongDan
            // 
            this.tbDuongDan.Location = new System.Drawing.Point(16, 232);
            this.tbDuongDan.Name = "tbDuongDan";
            this.tbDuongDan.ReadOnly = true;
            this.tbDuongDan.Size = new System.Drawing.Size(347, 20);
            this.tbDuongDan.TabIndex = 70;
            // 
            // tbPFSDT
            // 
            this.tbPFSDT.Location = new System.Drawing.Point(267, 55);
            this.tbPFSDT.Name = "tbPFSDT";
            this.tbPFSDT.Size = new System.Drawing.Size(169, 20);
            this.tbPFSDT.TabIndex = 60;
            // 
            // lblPFSDT
            // 
            this.lblPFSDT.AutoSize = true;
            this.lblPFSDT.Location = new System.Drawing.Point(189, 61);
            this.lblPFSDT.Name = "lblPFSDT";
            this.lblPFSDT.Size = new System.Drawing.Size(29, 13);
            this.lblPFSDT.TabIndex = 59;
            this.lblPFSDT.Text = "SDT";
            // 
            // tbPFTen
            // 
            this.tbPFTen.Location = new System.Drawing.Point(267, 26);
            this.tbPFTen.Name = "tbPFTen";
            this.tbPFTen.Size = new System.Drawing.Size(169, 20);
            this.tbPFTen.TabIndex = 58;
            // 
            // lblPFTen
            // 
            this.lblPFTen.AutoSize = true;
            this.lblPFTen.Location = new System.Drawing.Point(189, 29);
            this.lblPFTen.Name = "lblPFTen";
            this.lblPFTen.Size = new System.Drawing.Size(26, 13);
            this.lblPFTen.TabIndex = 57;
            this.lblPFTen.Text = "Ten";
            // 
            // pbAvartar
            // 
            this.pbAvartar.Image = ((System.Drawing.Image)(resources.GetObject("pbAvartar.Image")));
            this.pbAvartar.Location = new System.Drawing.Point(12, 12);
            this.pbAvartar.Name = "pbAvartar";
            this.pbAvartar.Padding = new System.Windows.Forms.Padding(10);
            this.pbAvartar.Size = new System.Drawing.Size(166, 214);
            this.pbAvartar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvartar.TabIndex = 56;
            this.pbAvartar.TabStop = false;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(371, 299);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(72, 23);
            this.btnXacNhan.TabIndex = 75;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnDKPT
            // 
            this.btnDKPT.Location = new System.Drawing.Point(12, 299);
            this.btnDKPT.Name = "btnDKPT";
            this.btnDKPT.Size = new System.Drawing.Size(110, 23);
            this.btnDKPT.TabIndex = 76;
            this.btnDKPT.Text = "Đăng ký PT";
            this.btnDKPT.UseVisualStyleBackColor = true;
            // 
            // btnDKGoi
            // 
            this.btnDKGoi.Location = new System.Drawing.Point(12, 258);
            this.btnDKGoi.Name = "btnDKGoi";
            this.btnDKGoi.Size = new System.Drawing.Size(110, 23);
            this.btnDKGoi.TabIndex = 77;
            this.btnDKGoi.Text = "Đăng Ký Gói Tập";
            this.btnDKGoi.UseVisualStyleBackColor = true;
            this.btnDKGoi.Click += new System.EventHandler(this.btnDKGoi_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(291, 299);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(72, 23);
            this.btnHuy.TabIndex = 78;
            this.btnHuy.Text = "Cancel";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // ThemHocVienfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 334);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDKGoi);
            this.Controls.Add(this.btnDKPT);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.gbSex);
            this.Controls.Add(this.dtpNgaysinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.btnChonHinh);
            this.Controls.Add(this.tbDuongDan);
            this.Controls.Add(this.tbPFSDT);
            this.Controls.Add(this.lblPFSDT);
            this.Controls.Add(this.tbPFTen);
            this.Controls.Add(this.lblPFTen);
            this.Controls.Add(this.pbAvartar);
            this.Name = "ThemHocVienfrm";
            this.Text = "ThemHocVienfrm";
            this.gbSex.ResumeLayout(false);
            this.gbSex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvartar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbSex;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Button btnChonHinh;
        private System.Windows.Forms.TextBox tbDuongDan;
        private System.Windows.Forms.TextBox tbPFSDT;
        private System.Windows.Forms.Label lblPFSDT;
        private System.Windows.Forms.TextBox tbPFTen;
        private System.Windows.Forms.Label lblPFTen;
        private System.Windows.Forms.PictureBox pbAvartar;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnDKPT;
        private System.Windows.Forms.Button btnDKGoi;
        private System.Windows.Forms.Button btnHuy;
    }
}