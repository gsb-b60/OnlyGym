namespace GymManagerment_MVP
{
    partial class CheckinKhachVaoUC
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupThongTin = new System.Windows.Forms.GroupBox();
            this.dtpVao = new System.Windows.Forms.DateTimePicker();
            this.lblNgayTap = new System.Windows.Forms.Label();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.dtpNgayTap = new System.Windows.Forms.DateTimePicker();
            this.tbNgayCon = new System.Windows.Forms.TextBox();
            this.lblGoiToi = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblGioVao = new System.Windows.Forms.Label();
            this.lblSoNgayCon = new System.Windows.Forms.Label();
            this.dtpGoiToi = new System.Windows.Forms.DateTimePicker();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.cbGoiTap = new System.Windows.Forms.ComboBox();
            this.lblGoiTap = new System.Windows.Forms.Label();
            this.btnDkPT = new System.Windows.Forms.Button();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lblkq = new System.Windows.Forms.Label();
            this.gbKetQuaCheckin = new System.Windows.Forms.GroupBox();
            this.cbKQ = new System.Windows.Forms.ComboBox();
            this.groupThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbKetQuaCheckin.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 690);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // groupThongTin
            // 
            this.groupThongTin.Controls.Add(this.gbKetQuaCheckin);
            this.groupThongTin.Controls.Add(this.dtpVao);
            this.groupThongTin.Controls.Add(this.lblNgayTap);
            this.groupThongTin.Controls.Add(this.btnChiTiet);
            this.groupThongTin.Controls.Add(this.dtpNgayTap);
            this.groupThongTin.Controls.Add(this.tbNgayCon);
            this.groupThongTin.Controls.Add(this.lblGoiToi);
            this.groupThongTin.Controls.Add(this.comboBox1);
            this.groupThongTin.Controls.Add(this.lblGioVao);
            this.groupThongTin.Controls.Add(this.lblSoNgayCon);
            this.groupThongTin.Controls.Add(this.dtpGoiToi);
            this.groupThongTin.Controls.Add(this.lblTinhTrang);
            this.groupThongTin.Controls.Add(this.tbTen);
            this.groupThongTin.Controls.Add(this.lblTen);
            this.groupThongTin.Controls.Add(this.tbSDT);
            this.groupThongTin.Controls.Add(this.lblSDT);
            this.groupThongTin.Controls.Add(this.cbGoiTap);
            this.groupThongTin.Controls.Add(this.lblGoiTap);
            this.groupThongTin.Controls.Add(this.pictureBox1);
            this.groupThongTin.Controls.Add(this.lbl);
            this.groupThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupThongTin.Location = new System.Drawing.Point(3, 0);
            this.groupThongTin.Name = "groupThongTin";
            this.groupThongTin.Size = new System.Drawing.Size(908, 490);
            this.groupThongTin.TabIndex = 7;
            this.groupThongTin.TabStop = false;
            this.groupThongTin.Text = "Thông tin học viên";
            // 
            // dtpVao
            // 
            this.dtpVao.CustomFormat = "dd/MM/yyyy";
            this.dtpVao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVao.Location = new System.Drawing.Point(141, 346);
            this.dtpVao.Name = "dtpVao";
            this.dtpVao.Size = new System.Drawing.Size(200, 20);
            this.dtpVao.TabIndex = 23;
            // 
            // lblNgayTap
            // 
            this.lblNgayTap.AutoSize = true;
            this.lblNgayTap.Location = new System.Drawing.Point(66, 431);
            this.lblNgayTap.Name = "lblNgayTap";
            this.lblNgayTap.Size = new System.Drawing.Size(54, 13);
            this.lblNgayTap.TabIndex = 28;
            this.lblNgayTap.Text = "Ngày Tập";
            this.lblNgayTap.Click += new System.EventHandler(this.lblNgayTap_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(363, 303);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(137, 23);
            this.btnChiTiet.TabIndex = 30;
            this.btnChiTiet.Text = "Chi tiết thông tin ...";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // dtpNgayTap
            // 
            this.dtpNgayTap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTap.Location = new System.Drawing.Point(141, 425);
            this.dtpNgayTap.Name = "dtpNgayTap";
            this.dtpNgayTap.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayTap.TabIndex = 29;
            // 
            // tbNgayCon
            // 
            this.tbNgayCon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbNgayCon.Location = new System.Drawing.Point(482, 258);
            this.tbNgayCon.Name = "tbNgayCon";
            this.tbNgayCon.ReadOnly = true;
            this.tbNgayCon.Size = new System.Drawing.Size(326, 20);
            this.tbNgayCon.TabIndex = 21;
            // 
            // lblGoiToi
            // 
            this.lblGoiToi.AutoSize = true;
            this.lblGoiToi.Location = new System.Drawing.Point(66, 388);
            this.lblGoiToi.Name = "lblGoiToi";
            this.lblGoiToi.Size = new System.Drawing.Size(41, 13);
            this.lblGoiToi.TabIndex = 18;
            this.lblGoiToi.Text = "Gói Tới";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(482, 212);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(326, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // lblGioVao
            // 
            this.lblGioVao.AutoSize = true;
            this.lblGioVao.Location = new System.Drawing.Point(66, 352);
            this.lblGioVao.Name = "lblGioVao";
            this.lblGioVao.Size = new System.Drawing.Size(45, 13);
            this.lblGioVao.TabIndex = 16;
            this.lblGioVao.Text = "Giờ Vào";
            // 
            // lblSoNgayCon
            // 
            this.lblSoNgayCon.AutoSize = true;
            this.lblSoNgayCon.Location = new System.Drawing.Point(360, 263);
            this.lblSoNgayCon.Name = "lblSoNgayCon";
            this.lblSoNgayCon.Size = new System.Drawing.Size(70, 13);
            this.lblSoNgayCon.TabIndex = 14;
            this.lblSoNgayCon.Text = "Số Ngày Còn";
            // 
            // dtpGoiToi
            // 
            this.dtpGoiToi.CustomFormat = "dd/MM/yyyy";
            this.dtpGoiToi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGoiToi.Location = new System.Drawing.Point(141, 382);
            this.dtpGoiToi.Name = "dtpGoiToi";
            this.dtpGoiToi.Size = new System.Drawing.Size(200, 20);
            this.dtpGoiToi.TabIndex = 24;
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(360, 210);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(59, 13);
            this.lblTinhTrang.TabIndex = 15;
            this.lblTinhTrang.Text = "Tình Trạng";
            // 
            // tbTen
            // 
            this.tbTen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbTen.Location = new System.Drawing.Point(482, 87);
            this.tbTen.Name = "tbTen";
            this.tbTen.ReadOnly = true;
            this.tbTen.Size = new System.Drawing.Size(326, 20);
            this.tbTen.TabIndex = 20;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(360, 94);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(29, 13);
            this.lblTen.TabIndex = 19;
            this.lblTen.Text = "TÊN";
            // 
            // tbSDT
            // 
            this.tbSDT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbSDT.Location = new System.Drawing.Point(482, 123);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.ReadOnly = true;
            this.tbSDT.Size = new System.Drawing.Size(326, 20);
            this.tbSDT.TabIndex = 25;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(360, 131);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(29, 13);
            this.lblSDT.TabIndex = 17;
            this.lblSDT.Text = "SDT";
            // 
            // cbGoiTap
            // 
            this.cbGoiTap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbGoiTap.FormattingEnabled = true;
            this.cbGoiTap.Location = new System.Drawing.Point(482, 163);
            this.cbGoiTap.Name = "cbGoiTap";
            this.cbGoiTap.Size = new System.Drawing.Size(326, 21);
            this.cbGoiTap.TabIndex = 27;
            // 
            // lblGoiTap
            // 
            this.lblGoiTap.AutoSize = true;
            this.lblGoiTap.Location = new System.Drawing.Point(360, 164);
            this.lblGoiTap.Name = "lblGoiTap";
            this.lblGoiTap.Size = new System.Drawing.Size(50, 13);
            this.lblGoiTap.TabIndex = 26;
            this.lblGoiTap.Text = "GÓI TẬP";
            // 
            // btnDkPT
            // 
            this.btnDkPT.Location = new System.Drawing.Point(355, 51);
            this.btnDkPT.Name = "btnDkPT";
            this.btnDkPT.Size = new System.Drawing.Size(75, 23);
            this.btnDkPT.TabIndex = 10;
            this.btnDkPT.Text = "Đăng ký PT";
            this.btnDkPT.UseVisualStyleBackColor = true;
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.Location = new System.Drawing.Point(355, 88);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(75, 23);
            this.btnGiaHan.TabIndex = 9;
            this.btnGiaHan.Text = "Gia Hạn";
            this.btnGiaHan.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(60, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 240);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(280, 16);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(302, 37);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "Checkin Information";
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(37, 51);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(84, 13);
            this.lblkq.TabIndex = 11;
            this.lblkq.Text = "kết quả checkin";
            // 
            // gbKetQuaCheckin
            // 
            this.gbKetQuaCheckin.Controls.Add(this.cbKQ);
            this.gbKetQuaCheckin.Controls.Add(this.lblkq);
            this.gbKetQuaCheckin.Controls.Add(this.btnDkPT);
            this.gbKetQuaCheckin.Controls.Add(this.btnGiaHan);
            this.gbKetQuaCheckin.Location = new System.Drawing.Point(363, 346);
            this.gbKetQuaCheckin.Name = "gbKetQuaCheckin";
            this.gbKetQuaCheckin.Size = new System.Drawing.Size(545, 144);
            this.gbKetQuaCheckin.TabIndex = 8;
            this.gbKetQuaCheckin.TabStop = false;
            this.gbKetQuaCheckin.Text = "kết quả check in";
            // 
            // cbKQ
            // 
            this.cbKQ.FormattingEnabled = true;
            this.cbKQ.Location = new System.Drawing.Point(159, 51);
            this.cbKQ.Name = "cbKQ";
            this.cbKQ.Size = new System.Drawing.Size(121, 21);
            this.cbKQ.TabIndex = 12;
            // 
            // CheckinKhachVaoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupThongTin);
            this.Controls.Add(this.splitter1);
            this.Name = "CheckinKhachVaoUC";
            this.Size = new System.Drawing.Size(911, 690);
            this.Load += new System.EventHandler(this.CheckinKhachVaoUC_Load);
            this.groupThongTin.ResumeLayout(false);
            this.groupThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbKetQuaCheckin.ResumeLayout(false);
            this.gbKetQuaCheckin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupThongTin;
        private System.Windows.Forms.DateTimePicker dtpVao;
        private System.Windows.Forms.Label lblNgayTap;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.DateTimePicker dtpNgayTap;
        private System.Windows.Forms.TextBox tbNgayCon;
        private System.Windows.Forms.Label lblGoiToi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblGioVao;
        private System.Windows.Forms.Label lblSoNgayCon;
        private System.Windows.Forms.DateTimePicker dtpGoiToi;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.ComboBox cbGoiTap;
        private System.Windows.Forms.Label lblGoiTap;
        private System.Windows.Forms.Button btnDkPT;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.GroupBox gbKetQuaCheckin;
        private System.Windows.Forms.ComboBox cbKQ;
    }
}
