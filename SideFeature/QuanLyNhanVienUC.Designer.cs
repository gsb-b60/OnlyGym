namespace GymManagerment_MVP
{
    partial class QuanLyNhanVienUC
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
            this.components = new System.ComponentModel.Container();
            this.gpThongTin = new System.Windows.Forms.GroupBox();
            this.gbDanhSach = new System.Windows.Forms.GroupBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lvDanhSach = new System.Windows.Forms.ListView();
            this.chTenNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chChucVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNgayVaoLam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNgayVaoLam = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.chThuNhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbTen = new System.Windows.Forms.TextBox();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.dtpNgayVao = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.tbHinh = new System.Windows.Forms.TextBox();
            this.btnHinh = new System.Windows.Forms.Button();
            this.gbHopDong = new System.Windows.Forms.GroupBox();
            this.lblCD = new System.Windows.Forms.Label();
            this.lblMHD = new System.Windows.Forms.Label();
            this.lblNgayKT = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.gpThongTin.SuspendLayout();
            this.gbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.gbHopDong.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpThongTin
            // 
            this.gpThongTin.Controls.Add(this.btnSua);
            this.gpThongTin.Controls.Add(this.btnXoa);
            this.gpThongTin.Controls.Add(this.btnThem);
            this.gpThongTin.Controls.Add(this.gbHopDong);
            this.gpThongTin.Controls.Add(this.btnHinh);
            this.gpThongTin.Controls.Add(this.tbHinh);
            this.gpThongTin.Controls.Add(this.pbHinh);
            this.gpThongTin.Controls.Add(this.numericUpDown1);
            this.gpThongTin.Controls.Add(this.dtpNgayVao);
            this.gpThongTin.Controls.Add(this.cbChucVu);
            this.gpThongTin.Controls.Add(this.tbTen);
            this.gpThongTin.Controls.Add(this.lblLuong);
            this.gpThongTin.Controls.Add(this.lblNgayVaoLam);
            this.gpThongTin.Controls.Add(this.lblChucVu);
            this.gpThongTin.Controls.Add(this.lblTen);
            this.gpThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpThongTin.Location = new System.Drawing.Point(0, 0);
            this.gpThongTin.Name = "gpThongTin";
            this.gpThongTin.Size = new System.Drawing.Size(1064, 254);
            this.gpThongTin.TabIndex = 0;
            this.gpThongTin.TabStop = false;
            this.gpThongTin.Text = "groupBox1";
            // 
            // gbDanhSach
            // 
            this.gbDanhSach.Controls.Add(this.lvDanhSach);
            this.gbDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDanhSach.Location = new System.Drawing.Point(0, 254);
            this.gbDanhSach.Name = "gbDanhSach";
            this.gbDanhSach.Size = new System.Drawing.Size(1064, 413);
            this.gbDanhSach.TabIndex = 1;
            this.gbDanhSach.TabStop = false;
            this.gbDanhSach.Text = "Danh Sach Nhan Vien";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(233, 32);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(79, 13);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Ten Nhan Vien";
            this.lblTen.Click += new System.EventHandler(this.lblTen_Click);
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(233, 69);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(48, 13);
            this.lblChucVu.TabIndex = 1;
            this.lblChucVu.Text = "Chuc Vu";
            this.lblChucVu.Click += new System.EventHandler(this.lblChucVu_Click);
            // 
            // lvDanhSach
            // 
            this.lvDanhSach.CheckBoxes = true;
            this.lvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTenNhanVien,
            this.chChucVu,
            this.chNgayVaoLam,
            this.chThuNhap});
            this.lvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDanhSach.GridLines = true;
            this.lvDanhSach.HideSelection = false;
            this.lvDanhSach.Location = new System.Drawing.Point(3, 16);
            this.lvDanhSach.Name = "lvDanhSach";
            this.lvDanhSach.Size = new System.Drawing.Size(1058, 394);
            this.lvDanhSach.TabIndex = 0;
            this.lvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lvDanhSach.View = System.Windows.Forms.View.Details;
            this.lvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lvDanhSach_SelectedIndexChanged);
            // 
            // chTenNhanVien
            // 
            this.chTenNhanVien.Text = "Ten Nhan Vien";
            this.chTenNhanVien.Width = 144;
            // 
            // chChucVu
            // 
            this.chChucVu.Text = "Chuc Vu";
            this.chChucVu.Width = 166;
            // 
            // chNgayVaoLam
            // 
            this.chNgayVaoLam.Text = "Ngay Vao Lam";
            this.chNgayVaoLam.Width = 205;
            // 
            // lblNgayVaoLam
            // 
            this.lblNgayVaoLam.AutoSize = true;
            this.lblNgayVaoLam.Location = new System.Drawing.Point(233, 110);
            this.lblNgayVaoLam.Name = "lblNgayVaoLam";
            this.lblNgayVaoLam.Size = new System.Drawing.Size(77, 13);
            this.lblNgayVaoLam.TabIndex = 2;
            this.lblNgayVaoLam.Text = "Ngay Vao Lam";
            this.lblNgayVaoLam.Click += new System.EventHandler(this.lblNgayVaoLam_Click);
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(233, 150);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(55, 13);
            this.lblLuong.TabIndex = 3;
            this.lblLuong.Text = "Thu Nhap";
            this.lblLuong.Click += new System.EventHandler(this.lblLuong_Click);
            // 
            // chThuNhap
            // 
            this.chThuNhap.Text = "Thu Nhap";
            this.chThuNhap.Width = 381;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(356, 24);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(230, 20);
            this.tbTen.TabIndex = 4;
            this.tbTen.TextChanged += new System.EventHandler(this.tbTen_TextChanged);
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(356, 69);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(230, 21);
            this.cbChucVu.TabIndex = 5;
            this.cbChucVu.SelectedIndexChanged += new System.EventHandler(this.cbChucVu_SelectedIndexChanged);
            // 
            // dtpNgayVao
            // 
            this.dtpNgayVao.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayVao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayVao.Location = new System.Drawing.Point(356, 110);
            this.dtpNgayVao.Name = "dtpNgayVao";
            this.dtpNgayVao.Size = new System.Drawing.Size(230, 20);
            this.dtpNgayVao.TabIndex = 6;
            this.dtpNgayVao.ValueChanged += new System.EventHandler(this.dtpNgayVao_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(356, 150);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(230, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.ThousandsSeparator = true;
            this.numericUpDown1.Value = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // pbHinh
            // 
            this.pbHinh.Location = new System.Drawing.Point(21, 28);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(164, 205);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinh.TabIndex = 8;
            this.pbHinh.TabStop = false;
            // 
            // tbHinh
            // 
            this.tbHinh.Location = new System.Drawing.Point(236, 192);
            this.tbHinh.Name = "tbHinh";
            this.tbHinh.ReadOnly = true;
            this.tbHinh.Size = new System.Drawing.Size(256, 20);
            this.tbHinh.TabIndex = 9;
            // 
            // btnHinh
            // 
            this.btnHinh.Location = new System.Drawing.Point(511, 188);
            this.btnHinh.Name = "btnHinh";
            this.btnHinh.Size = new System.Drawing.Size(75, 23);
            this.btnHinh.TabIndex = 10;
            this.btnHinh.Text = "...";
            this.btnHinh.UseVisualStyleBackColor = true;
            // 
            // gbHopDong
            // 
            this.gbHopDong.Controls.Add(this.dtpNgayKT);
            this.gbHopDong.Controls.Add(this.tbGhiChu);
            this.gbHopDong.Controls.Add(this.maskedTextBox2);
            this.gbHopDong.Controls.Add(this.maskedTextBox1);
            this.gbHopDong.Controls.Add(this.lblGhiChu);
            this.gbHopDong.Controls.Add(this.lblNgayKT);
            this.gbHopDong.Controls.Add(this.lblMHD);
            this.gbHopDong.Controls.Add(this.lblCD);
            this.gbHopDong.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbHopDong.Location = new System.Drawing.Point(592, 16);
            this.gbHopDong.Name = "gbHopDong";
            this.gbHopDong.Size = new System.Drawing.Size(469, 235);
            this.gbHopDong.TabIndex = 11;
            this.gbHopDong.TabStop = false;
            this.gbHopDong.Text = "Hop Dong";
            // 
            // lblCD
            // 
            this.lblCD.AutoSize = true;
            this.lblCD.Location = new System.Drawing.Point(7, 20);
            this.lblCD.Name = "lblCD";
            this.lblCD.Size = new System.Drawing.Size(73, 13);
            this.lblCD.TabIndex = 0;
            this.lblCD.Text = "CCCD/CMND";
            // 
            // lblMHD
            // 
            this.lblMHD.AutoSize = true;
            this.lblMHD.Location = new System.Drawing.Point(10, 56);
            this.lblMHD.Name = "lblMHD";
            this.lblMHD.Size = new System.Drawing.Size(74, 13);
            this.lblMHD.TabIndex = 1;
            this.lblMHD.Text = "Ma Hop Dong";
            // 
            // lblNgayKT
            // 
            this.lblNgayKT.AutoSize = true;
            this.lblNgayKT.Location = new System.Drawing.Point(10, 100);
            this.lblNgayKT.Name = "lblNgayKT";
            this.lblNgayKT.Size = new System.Drawing.Size(131, 13);
            this.lblNgayKT.TabIndex = 2;
            this.lblNgayKT.Text = "Ngay Ket Thuc Hop Dong";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(10, 134);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(52, 13);
            this.lblGhiChu.TabIndex = 3;
            this.lblGhiChu.Text = "lblGhiChu";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(164, 20);
            this.maskedTextBox1.Mask = "000000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(164, 53);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 5;
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Location = new System.Drawing.Point(164, 133);
            this.tbGhiChu.Multiline = true;
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(279, 84);
            this.tbGhiChu.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.Location = new System.Drawing.Point(164, 100);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayKT.TabIndex = 8;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(236, 219);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(375, 219);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(495, 219);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // QuanLyNhanVienUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbDanhSach);
            this.Controls.Add(this.gpThongTin);
            this.Name = "QuanLyNhanVienUC";
            this.Size = new System.Drawing.Size(1064, 667);
            this.gpThongTin.ResumeLayout(false);
            this.gpThongTin.PerformLayout();
            this.gbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.gbHopDong.ResumeLayout(false);
            this.gbHopDong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpThongTin;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.GroupBox gbDanhSach;
        private System.Windows.Forms.ListView lvDanhSach;
        private System.Windows.Forms.ColumnHeader chTenNhanVien;
        private System.Windows.Forms.ColumnHeader chChucVu;
        private System.Windows.Forms.ColumnHeader chNgayVaoLam;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblNgayVaoLam;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dtpNgayVao;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.ColumnHeader chThuNhap;
        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.Button btnHinh;
        private System.Windows.Forms.TextBox tbHinh;
        private System.Windows.Forms.GroupBox gbHopDong;
        private System.Windows.Forms.Label lblMHD;
        private System.Windows.Forms.Label lblCD;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblNgayKT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}
