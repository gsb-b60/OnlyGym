namespace GymManagerment_MVP
{
    partial class DanhSachThietBiUC
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
            this.MenuThietBi = new System.Windows.Forms.Panel();
            this.pnlThongTinThietBi = new System.Windows.Forms.Panel();
            this.pnlDanhSachThietBi = new System.Windows.Forms.Panel();
            this.lvDanhSachThietBi = new System.Windows.Forms.ListView();
            this.chTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTenTB = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblViTri = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.gbGhiChu = new System.Windows.Forms.GroupBox();
            this.gbDanhSachGhiChu = new System.Windows.Forms.GroupBox();
            this.lbDanhSachGhiChu = new System.Windows.Forms.ListView();
            this.chLichSu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNgay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHuongDanDB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.lblLichSu = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblHuongDan = new System.Windows.Forms.Label();
            this.tbTenTB = new System.Windows.Forms.TextBox();
            this.cbHang = new System.Windows.Forms.ComboBox();
            this.cbViTri = new System.Windows.Forms.ComboBox();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.nSoLuong = new System.Windows.Forms.NumericUpDown();
            this.tbLichSu = new System.Windows.Forms.TextBox();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.tbHuongDan = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemTB = new System.Windows.Forms.Button();
            this.btnXoaTB = new System.Windows.Forms.Button();
            this.btnSuaTB = new System.Windows.Forms.Button();
            this.MenuThietBi.SuspendLayout();
            this.pnlThongTinThietBi.SuspendLayout();
            this.pnlDanhSachThietBi.SuspendLayout();
            this.gbGhiChu.SuspendLayout();
            this.gbDanhSachGhiChu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuThietBi
            // 
            this.MenuThietBi.Controls.Add(this.btnSuaTB);
            this.MenuThietBi.Controls.Add(this.btnThemTB);
            this.MenuThietBi.Controls.Add(this.btnXoaTB);
            this.MenuThietBi.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuThietBi.Location = new System.Drawing.Point(0, 0);
            this.MenuThietBi.Name = "MenuThietBi";
            this.MenuThietBi.Size = new System.Drawing.Size(1064, 37);
            this.MenuThietBi.TabIndex = 0;
            // 
            // pnlThongTinThietBi
            // 
            this.pnlThongTinThietBi.Controls.Add(this.nSoLuong);
            this.pnlThongTinThietBi.Controls.Add(this.cbTinhTrang);
            this.pnlThongTinThietBi.Controls.Add(this.cbViTri);
            this.pnlThongTinThietBi.Controls.Add(this.cbHang);
            this.pnlThongTinThietBi.Controls.Add(this.tbTenTB);
            this.pnlThongTinThietBi.Controls.Add(this.lblTinhTrang);
            this.pnlThongTinThietBi.Controls.Add(this.gbGhiChu);
            this.pnlThongTinThietBi.Controls.Add(this.lblSoLuong);
            this.pnlThongTinThietBi.Controls.Add(this.lblViTri);
            this.pnlThongTinThietBi.Controls.Add(this.lbl);
            this.pnlThongTinThietBi.Controls.Add(this.lblTenTB);
            this.pnlThongTinThietBi.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlThongTinThietBi.Location = new System.Drawing.Point(673, 37);
            this.pnlThongTinThietBi.Name = "pnlThongTinThietBi";
            this.pnlThongTinThietBi.Size = new System.Drawing.Size(391, 630);
            this.pnlThongTinThietBi.TabIndex = 1;
            // 
            // pnlDanhSachThietBi
            // 
            this.pnlDanhSachThietBi.Controls.Add(this.lvDanhSachThietBi);
            this.pnlDanhSachThietBi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDanhSachThietBi.Location = new System.Drawing.Point(0, 37);
            this.pnlDanhSachThietBi.Name = "pnlDanhSachThietBi";
            this.pnlDanhSachThietBi.Size = new System.Drawing.Size(673, 630);
            this.pnlDanhSachThietBi.TabIndex = 2;
            // 
            // lvDanhSachThietBi
            // 
            this.lvDanhSachThietBi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTen});
            this.lvDanhSachThietBi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDanhSachThietBi.GridLines = true;
            this.lvDanhSachThietBi.HideSelection = false;
            this.lvDanhSachThietBi.Location = new System.Drawing.Point(0, 0);
            this.lvDanhSachThietBi.Name = "lvDanhSachThietBi";
            this.lvDanhSachThietBi.Size = new System.Drawing.Size(673, 630);
            this.lvDanhSachThietBi.TabIndex = 0;
            this.lvDanhSachThietBi.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachThietBi.View = System.Windows.Forms.View.Details;
            this.lvDanhSachThietBi.SelectedIndexChanged += new System.EventHandler(this.lvDanhSachThietBi_SelectedIndexChanged);
            // 
            // chTen
            // 
            this.chTen.Text = "Ten Thiet Bi";
            this.chTen.Width = 145;
            // 
            // lblTenTB
            // 
            this.lblTenTB.AutoSize = true;
            this.lblTenTB.Location = new System.Drawing.Point(7, 7);
            this.lblTenTB.Name = "lblTenTB";
            this.lblTenTB.Size = new System.Drawing.Size(65, 13);
            this.lblTenTB.TabIndex = 0;
            this.lblTenTB.Text = "Ten Thiet Bi";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(7, 48);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(85, 13);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Thong Tin Hang";
            // 
            // lblViTri
            // 
            this.lblViTri.AutoSize = true;
            this.lblViTri.Location = new System.Drawing.Point(7, 85);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(70, 13);
            this.lblViTri.TabIndex = 2;
            this.lblViTri.Text = "Vi Tri Thiet Bi";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(7, 130);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(83, 13);
            this.lblSoLuong.TabIndex = 3;
            this.lblSoLuong.Text = "So luong thiet bi";
            // 
            // gbGhiChu
            // 
            this.gbGhiChu.Controls.Add(this.btnSua);
            this.gbGhiChu.Controls.Add(this.btnXoa);
            this.gbGhiChu.Controls.Add(this.button2);
            this.gbGhiChu.Controls.Add(this.btnThem);
            this.gbGhiChu.Controls.Add(this.tbHuongDan);
            this.gbGhiChu.Controls.Add(this.dtpNgayBD);
            this.gbGhiChu.Controls.Add(this.tbLichSu);
            this.gbGhiChu.Controls.Add(this.lblHuongDan);
            this.gbGhiChu.Controls.Add(this.lblNgay);
            this.gbGhiChu.Controls.Add(this.lblLichSu);
            this.gbGhiChu.Controls.Add(this.gbDanhSachGhiChu);
            this.gbGhiChu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbGhiChu.Location = new System.Drawing.Point(0, 253);
            this.gbGhiChu.Name = "gbGhiChu";
            this.gbGhiChu.Size = new System.Drawing.Size(391, 377);
            this.gbGhiChu.TabIndex = 4;
            this.gbGhiChu.TabStop = false;
            this.gbGhiChu.Text = "Ghi Chu";
            // 
            // gbDanhSachGhiChu
            // 
            this.gbDanhSachGhiChu.Controls.Add(this.lbDanhSachGhiChu);
            this.gbDanhSachGhiChu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbDanhSachGhiChu.Location = new System.Drawing.Point(3, 143);
            this.gbDanhSachGhiChu.Name = "gbDanhSachGhiChu";
            this.gbDanhSachGhiChu.Size = new System.Drawing.Size(385, 231);
            this.gbDanhSachGhiChu.TabIndex = 0;
            this.gbDanhSachGhiChu.TabStop = false;
            this.gbDanhSachGhiChu.Text = "Danh Sach Ghi Chu";
            // 
            // lbDanhSachGhiChu
            // 
            this.lbDanhSachGhiChu.CheckBoxes = true;
            this.lbDanhSachGhiChu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLichSu,
            this.chNgay,
            this.chHuongDanDB});
            this.lbDanhSachGhiChu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDanhSachGhiChu.GridLines = true;
            this.lbDanhSachGhiChu.HideSelection = false;
            this.lbDanhSachGhiChu.Location = new System.Drawing.Point(3, 16);
            this.lbDanhSachGhiChu.Name = "lbDanhSachGhiChu";
            this.lbDanhSachGhiChu.Size = new System.Drawing.Size(379, 212);
            this.lbDanhSachGhiChu.TabIndex = 0;
            this.lbDanhSachGhiChu.UseCompatibleStateImageBehavior = false;
            this.lbDanhSachGhiChu.View = System.Windows.Forms.View.Details;
            // 
            // chLichSu
            // 
            this.chLichSu.Text = "Lich Su Bao Duong";
            this.chLichSu.Width = 170;
            // 
            // chNgay
            // 
            this.chNgay.Text = "Ngay";
            // 
            // chHuongDanDB
            // 
            this.chHuongDanDB.Text = "Huong Dan Dac Biet";
            this.chHuongDanDB.Width = 149;
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(7, 176);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(98, 13);
            this.lblTinhTrang.TabIndex = 5;
            this.lblTinhTrang.Text = "Tinh Trang Thiet Bi";
            // 
            // lblLichSu
            // 
            this.lblLichSu.AutoSize = true;
            this.lblLichSu.Location = new System.Drawing.Point(7, 33);
            this.lblLichSu.Name = "lblLichSu";
            this.lblLichSu.Size = new System.Drawing.Size(100, 13);
            this.lblLichSu.TabIndex = 1;
            this.lblLichSu.Text = "Lich Su Bao Duong";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(7, 67);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(53, 13);
            this.lblNgay.TabIndex = 2;
            this.lblNgay.Text = "Thoi Gian";
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.AutoSize = true;
            this.lblHuongDan.Location = new System.Drawing.Point(10, 100);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.Size = new System.Drawing.Size(59, 13);
            this.lblHuongDan.TabIndex = 3;
            this.lblHuongDan.Text = "HuongDan";
            // 
            // tbTenTB
            // 
            this.tbTenTB.Location = new System.Drawing.Point(109, 7);
            this.tbTenTB.Name = "tbTenTB";
            this.tbTenTB.Size = new System.Drawing.Size(121, 20);
            this.tbTenTB.TabIndex = 6;
            // 
            // cbHang
            // 
            this.cbHang.FormattingEnabled = true;
            this.cbHang.Items.AddRange(new object[] {
            "TechnoGym",
            "Hybird",
            "OceAA"});
            this.cbHang.Location = new System.Drawing.Point(109, 48);
            this.cbHang.Name = "cbHang";
            this.cbHang.Size = new System.Drawing.Size(121, 21);
            this.cbHang.TabIndex = 7;
            // 
            // cbViTri
            // 
            this.cbViTri.FormattingEnabled = true;
            this.cbViTri.Items.AddRange(new object[] {
            "Khu Tap Chan",
            "Khu Dumbbell",
            "Khu Da Nang",
            "Khu FreeWeight"});
            this.cbViTri.Location = new System.Drawing.Point(109, 85);
            this.cbViTri.Name = "cbViTri";
            this.cbViTri.Size = new System.Drawing.Size(121, 21);
            this.cbViTri.TabIndex = 8;
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Dang Hong",
            "Dang Tot",
            "Can Bao Tri",
            "Can Thay Moi"});
            this.cbTinhTrang.Location = new System.Drawing.Point(109, 176);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(121, 21);
            this.cbTinhTrang.TabIndex = 10;
            // 
            // nSoLuong
            // 
            this.nSoLuong.Location = new System.Drawing.Point(109, 130);
            this.nSoLuong.Name = "nSoLuong";
            this.nSoLuong.Size = new System.Drawing.Size(120, 20);
            this.nSoLuong.TabIndex = 11;
            // 
            // tbLichSu
            // 
            this.tbLichSu.Location = new System.Drawing.Point(109, 33);
            this.tbLichSu.Name = "tbLichSu";
            this.tbLichSu.Size = new System.Drawing.Size(138, 20);
            this.tbLichSu.TabIndex = 4;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(109, 67);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(138, 20);
            this.dtpNgayBD.TabIndex = 5;
            // 
            // tbHuongDan
            // 
            this.tbHuongDan.Location = new System.Drawing.Point(109, 100);
            this.tbHuongDan.Name = "tbHuongDan";
            this.tbHuongDan.Size = new System.Drawing.Size(138, 20);
            this.tbHuongDan.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(297, 100);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(297, 67);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(297, 33);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThemTB
            // 
            this.btnThemTB.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThemTB.Location = new System.Drawing.Point(79, 0);
            this.btnThemTB.Name = "btnThemTB";
            this.btnThemTB.Size = new System.Drawing.Size(98, 37);
            this.btnThemTB.TabIndex = 12;
            this.btnThemTB.Text = "Them Thiet Bi";
            this.btnThemTB.UseVisualStyleBackColor = true;
            this.btnThemTB.Click += new System.EventHandler(this.btnThemTB_Click);
            // 
            // btnXoaTB
            // 
            this.btnXoaTB.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXoaTB.Location = new System.Drawing.Point(0, 0);
            this.btnXoaTB.Name = "btnXoaTB";
            this.btnXoaTB.Size = new System.Drawing.Size(79, 37);
            this.btnXoaTB.TabIndex = 13;
            this.btnXoaTB.Text = "Xoa Thiet Bi";
            this.btnXoaTB.UseVisualStyleBackColor = true;
            this.btnXoaTB.Click += new System.EventHandler(this.btnXoaTB_Click);
            // 
            // btnSuaTB
            // 
            this.btnSuaTB.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSuaTB.Location = new System.Drawing.Point(177, 0);
            this.btnSuaTB.Name = "btnSuaTB";
            this.btnSuaTB.Size = new System.Drawing.Size(110, 37);
            this.btnSuaTB.TabIndex = 14;
            this.btnSuaTB.Text = "Sua Thiet Bi";
            this.btnSuaTB.UseVisualStyleBackColor = true;
            this.btnSuaTB.Click += new System.EventHandler(this.btnSuaTB_Click);
            // 
            // DanhSachThietBiUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDanhSachThietBi);
            this.Controls.Add(this.pnlThongTinThietBi);
            this.Controls.Add(this.MenuThietBi);
            this.Name = "DanhSachThietBiUC";
            this.Size = new System.Drawing.Size(1064, 667);
            this.MenuThietBi.ResumeLayout(false);
            this.pnlThongTinThietBi.ResumeLayout(false);
            this.pnlThongTinThietBi.PerformLayout();
            this.pnlDanhSachThietBi.ResumeLayout(false);
            this.gbGhiChu.ResumeLayout(false);
            this.gbGhiChu.PerformLayout();
            this.gbDanhSachGhiChu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuThietBi;
        private System.Windows.Forms.Panel pnlThongTinThietBi;
        private System.Windows.Forms.Panel pnlDanhSachThietBi;
        private System.Windows.Forms.Label lblTenTB;
        private System.Windows.Forms.ListView lvDanhSachThietBi;
        private System.Windows.Forms.ColumnHeader chTen;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblViTri;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.GroupBox gbGhiChu;
        private System.Windows.Forms.GroupBox gbDanhSachGhiChu;
        private System.Windows.Forms.ListView lbDanhSachGhiChu;
        private System.Windows.Forms.ColumnHeader chLichSu;
        private System.Windows.Forms.ColumnHeader chNgay;
        private System.Windows.Forms.ColumnHeader chHuongDanDB;
        private System.Windows.Forms.ComboBox cbHang;
        private System.Windows.Forms.TextBox tbTenTB;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label lblHuongDan;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblLichSu;
        private System.Windows.Forms.NumericUpDown nSoLuong;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.ComboBox cbViTri;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox tbHuongDan;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.TextBox tbLichSu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSuaTB;
        private System.Windows.Forms.Button btnXoaTB;
        private System.Windows.Forms.Button btnThemTB;
    }
}
