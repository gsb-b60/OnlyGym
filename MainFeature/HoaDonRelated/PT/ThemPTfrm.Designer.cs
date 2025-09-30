namespace GymManagerment_MVP.MainFeature.HoaDonRelated.PT
{
    partial class ThemPTfrm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbSex = new System.Windows.Forms.GroupBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.btnChonHinh = new System.Windows.Forms.Button();
            this.tbDuongDan = new System.Windows.Forms.TextBox();
            this.lblHinhHocVien = new System.Windows.Forms.Label();
            this.tbPFSDT = new System.Windows.Forms.TextBox();
            this.tbPFTen = new System.Windows.Forms.TextBox();
            this.lblPFSDT = new System.Windows.Forms.Label();
            this.lblPFTen = new System.Windows.Forms.Label();
            this.pbAvartar = new System.Windows.Forms.PictureBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gbSex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvartar)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Hồi Phục Chức Năng",
            "Thi Đấu Thể Hình",
            "Giảm Cân Người Lớn Tuổi",
            "Giảm Cân Nữ",
            "Giảm Cân Nam",
            "Huấn Luyện Thể Lực",
            "Thi Đấu Cử tạ",
            "Tăng Cường Sức Mạnh"});
            this.listBox1.Location = new System.Drawing.Point(30, 307);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(155, 121);
            this.listBox1.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Chuyên Môn";
            // 
            // gbSex
            // 
            this.gbSex.Controls.Add(this.rdNu);
            this.gbSex.Controls.Add(this.rdNam);
            this.gbSex.Location = new System.Drawing.Point(184, 138);
            this.gbSex.Name = "gbSex";
            this.gbSex.Size = new System.Drawing.Size(271, 50);
            this.gbSex.TabIndex = 67;
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
            this.dtpNgaysinh.Location = new System.Drawing.Point(267, 92);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(277, 20);
            this.dtpNgaysinh.TabIndex = 66;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(189, 98);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(56, 13);
            this.lblNgaySinh.TabIndex = 65;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Location = new System.Drawing.Point(339, 253);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(36, 23);
            this.btnChonHinh.TabIndex = 63;
            this.btnChonHinh.Text = "...";
            this.btnChonHinh.UseVisualStyleBackColor = true;
            // 
            // tbDuongDan
            // 
            this.tbDuongDan.Location = new System.Drawing.Point(125, 255);
            this.tbDuongDan.Name = "tbDuongDan";
            this.tbDuongDan.ReadOnly = true;
            this.tbDuongDan.Size = new System.Drawing.Size(179, 20);
            this.tbDuongDan.TabIndex = 62;
            // 
            // lblHinhHocVien
            // 
            this.lblHinhHocVien.AutoSize = true;
            this.lblHinhHocVien.Location = new System.Drawing.Point(14, 258);
            this.lblHinhHocVien.Name = "lblHinhHocVien";
            this.lblHinhHocVien.Size = new System.Drawing.Size(46, 13);
            this.lblHinhHocVien.TabIndex = 61;
            this.lblHinhHocVien.Text = "Hình PT";
            // 
            // tbPFSDT
            // 
            this.tbPFSDT.Location = new System.Drawing.Point(267, 55);
            this.tbPFSDT.Name = "tbPFSDT";
            this.tbPFSDT.Size = new System.Drawing.Size(277, 20);
            this.tbPFSDT.TabIndex = 58;
            // 
            // tbPFTen
            // 
            this.tbPFTen.Location = new System.Drawing.Point(267, 26);
            this.tbPFTen.Name = "tbPFTen";
            this.tbPFTen.Size = new System.Drawing.Size(277, 20);
            this.tbPFTen.TabIndex = 56;
            // 
            // lblPFSDT
            // 
            this.lblPFSDT.AutoSize = true;
            this.lblPFSDT.Location = new System.Drawing.Point(189, 62);
            this.lblPFSDT.Name = "lblPFSDT";
            this.lblPFSDT.Size = new System.Drawing.Size(29, 13);
            this.lblPFSDT.TabIndex = 57;
            this.lblPFSDT.Text = "SDT";
            // 
            // lblPFTen
            // 
            this.lblPFTen.AutoSize = true;
            this.lblPFTen.Location = new System.Drawing.Point(189, 29);
            this.lblPFTen.Name = "lblPFTen";
            this.lblPFTen.Size = new System.Drawing.Size(26, 13);
            this.lblPFTen.TabIndex = 55;
            this.lblPFTen.Text = "Ten";
            // 
            // pbAvartar
            // 
            this.pbAvartar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAvartar.Location = new System.Drawing.Point(12, 12);
            this.pbAvartar.Name = "pbAvartar";
            this.pbAvartar.Padding = new System.Windows.Forms.Padding(10);
            this.pbAvartar.Size = new System.Drawing.Size(166, 214);
            this.pbAvartar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvartar.TabIndex = 54;
            this.pbAvartar.TabStop = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(339, 307);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(155, 121);
            this.listBox2.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Chuyên Môn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 76;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 23);
            this.button2.TabIndex = 77;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(381, 481);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 23);
            this.button3.TabIndex = 78;
            this.button3.Text = "Tạo PT";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ThemPTfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 516);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbSex);
            this.Controls.Add(this.dtpNgaysinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.btnChonHinh);
            this.Controls.Add(this.tbDuongDan);
            this.Controls.Add(this.lblHinhHocVien);
            this.Controls.Add(this.tbPFSDT);
            this.Controls.Add(this.tbPFTen);
            this.Controls.Add(this.lblPFSDT);
            this.Controls.Add(this.lblPFTen);
            this.Controls.Add(this.pbAvartar);
            this.Name = "ThemPTfrm";
            this.Text = "ThemPTfrm";
            this.gbSex.ResumeLayout(false);
            this.gbSex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvartar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbSex;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Button btnChonHinh;
        private System.Windows.Forms.TextBox tbDuongDan;
        private System.Windows.Forms.Label lblHinhHocVien;
        private System.Windows.Forms.TextBox tbPFSDT;
        private System.Windows.Forms.TextBox tbPFTen;
        private System.Windows.Forms.Label lblPFSDT;
        private System.Windows.Forms.Label lblPFTen;
        private System.Windows.Forms.PictureBox pbAvartar;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}