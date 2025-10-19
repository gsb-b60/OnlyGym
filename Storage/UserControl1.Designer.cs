namespace GymManagerment_MVP
{
    partial class UserControl1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Nguyễn Đình Hiếu",
            "0123456789",
            "Active",
            "1 tháng",
            "17/9/2025 06:10",
            "vip",
            "13/9/2025 06:05",
            "0",
            "không"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "27/08/2025-06:10",
            "Accept",
            ""}, -1);
            this.pnlDS = new System.Windows.Forms.Panel();
            this.lvDanhSachHV = new System.Windows.Forms.ListView();
            this.chTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSĐT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHetHan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLastcheckin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCongNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.gbLichSuTap = new System.Windows.Forms.GroupBox();
            this.btnChiTietLS = new System.Windows.Forms.Button();
            this.lvLichSuTap = new System.Windows.Forms.ListView();
            this.chThoigian = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chKQ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGhiChú = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSua = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.btnChonHinh = new System.Windows.Forms.Button();
            this.tbDuongDan = new System.Windows.Forms.TextBox();
            this.lblHinhHocVien = new System.Windows.Forms.Label();
            this.btnPFDangKyPT = new System.Windows.Forms.Button();
            this.tbPFCongNo = new System.Windows.Forms.TextBox();
            this.lblPFCongNo = new System.Windows.Forms.Label();
            this.cbPFThe = new System.Windows.Forms.ComboBox();
            this.lblPFThe = new System.Windows.Forms.Label();
            this.cbPFGHT = new System.Windows.Forms.ComboBox();
            this.lblPFGoiHT = new System.Windows.Forms.Label();
            this.cbPFTrangThai = new System.Windows.Forms.ComboBox();
            this.lblPFTrangThai = new System.Windows.Forms.Label();
            this.tbPFSDT = new System.Windows.Forms.TextBox();
            this.lblPFSDT = new System.Windows.Forms.Label();
            this.tbPFTen = new System.Windows.Forms.TextBox();
            this.lblPFTen = new System.Windows.Forms.Label();
            this.pbAvartar = new System.Windows.Forms.PictureBox();
            this.pnlDS.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            this.gbLichSuTap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvartar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDS
            // 
            this.pnlDS.Controls.Add(this.lvDanhSachHV);
            this.pnlDS.Controls.Add(this.pnlProfile);
            this.pnlDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDS.Location = new System.Drawing.Point(0, 0);
            this.pnlDS.Name = "pnlDS";
            this.pnlDS.Size = new System.Drawing.Size(1665, 707);
            this.pnlDS.TabIndex = 16;
            // 
            // lvDanhSachHV
            // 
            this.lvDanhSachHV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTen,
            this.chSĐT,
            this.chTrangThai,
            this.chGoi,
            this.chHetHan,
            this.chTag,
            this.chLastcheckin,
            this.chCongNo,
            this.chPT});
            this.lvDanhSachHV.GridLines = true;
            this.lvDanhSachHV.HideSelection = false;
            listViewItem1.UseItemStyleForSubItems = false;
            this.lvDanhSachHV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvDanhSachHV.Location = new System.Drawing.Point(33, 20);
            this.lvDanhSachHV.Name = "lvDanhSachHV";
            this.lvDanhSachHV.Size = new System.Drawing.Size(1086, 460);
            this.lvDanhSachHV.TabIndex = 1;
            this.lvDanhSachHV.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachHV.View = System.Windows.Forms.View.Details;
            // 
            // chTen
            // 
            this.chTen.Text = "Tên";
            this.chTen.Width = 218;
            // 
            // chSĐT
            // 
            this.chSĐT.Text = "SĐT";
            this.chSĐT.Width = 202;
            // 
            // chTrangThai
            // 
            this.chTrangThai.Text = "Trạng Thái";
            this.chTrangThai.Width = 170;
            // 
            // chGoi
            // 
            this.chGoi.Text = "Gói hiện tại";
            this.chGoi.Width = 133;
            // 
            // chHetHan
            // 
            this.chHetHan.Text = "Hết hạn";
            this.chHetHan.Width = 126;
            // 
            // chTag
            // 
            this.chTag.DisplayIndex = 6;
            this.chTag.Text = "Thẻ";
            this.chTag.Width = 42;
            // 
            // chLastcheckin
            // 
            this.chLastcheckin.DisplayIndex = 5;
            this.chLastcheckin.Text = "Last Checkin";
            this.chLastcheckin.Width = 138;
            // 
            // chCongNo
            // 
            this.chCongNo.Text = "Công Nợ";
            this.chCongNo.Width = 73;
            // 
            // chPT
            // 
            this.chPT.Text = "Đang Đăng Ký PT";
            this.chPT.Width = 164;
            // 
            // pnlProfile
            // 
            this.pnlProfile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlProfile.Controls.Add(this.gbLichSuTap);
            this.pnlProfile.Controls.Add(this.btnSua);
            this.pnlProfile.Controls.Add(this.btnChiTiet);
            this.pnlProfile.Controls.Add(this.btnThoat);
            this.pnlProfile.Controls.Add(this.btnGiaHan);
            this.pnlProfile.Controls.Add(this.btnChonHinh);
            this.pnlProfile.Controls.Add(this.tbDuongDan);
            this.pnlProfile.Controls.Add(this.lblHinhHocVien);
            this.pnlProfile.Controls.Add(this.btnPFDangKyPT);
            this.pnlProfile.Controls.Add(this.tbPFCongNo);
            this.pnlProfile.Controls.Add(this.lblPFCongNo);
            this.pnlProfile.Controls.Add(this.cbPFThe);
            this.pnlProfile.Controls.Add(this.lblPFThe);
            this.pnlProfile.Controls.Add(this.cbPFGHT);
            this.pnlProfile.Controls.Add(this.lblPFGoiHT);
            this.pnlProfile.Controls.Add(this.cbPFTrangThai);
            this.pnlProfile.Controls.Add(this.lblPFTrangThai);
            this.pnlProfile.Controls.Add(this.tbPFSDT);
            this.pnlProfile.Controls.Add(this.lblPFSDT);
            this.pnlProfile.Controls.Add(this.tbPFTen);
            this.pnlProfile.Controls.Add(this.lblPFTen);
            this.pnlProfile.Controls.Add(this.pbAvartar);
            this.pnlProfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlProfile.Location = new System.Drawing.Point(1125, 0);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(540, 707);
            this.pnlProfile.TabIndex = 2;
            this.pnlProfile.Visible = false;
            // 
            // gbLichSuTap
            // 
            this.gbLichSuTap.Controls.Add(this.btnChiTietLS);
            this.gbLichSuTap.Controls.Add(this.lvLichSuTap);
            this.gbLichSuTap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbLichSuTap.Location = new System.Drawing.Point(0, 530);
            this.gbLichSuTap.Name = "gbLichSuTap";
            this.gbLichSuTap.Size = new System.Drawing.Size(540, 177);
            this.gbLichSuTap.TabIndex = 28;
            this.gbLichSuTap.TabStop = false;
            this.gbLichSuTap.Text = "Lich Su Tap";
            // 
            // btnChiTietLS
            // 
            this.btnChiTietLS.Location = new System.Drawing.Point(393, 149);
            this.btnChiTietLS.Name = "btnChiTietLS";
            this.btnChiTietLS.Size = new System.Drawing.Size(134, 23);
            this.btnChiTietLS.TabIndex = 1;
            this.btnChiTietLS.Text = "Xem Thêm Lịch Sử";
            this.btnChiTietLS.UseVisualStyleBackColor = true;
            // 
            // lvLichSuTap
            // 
            this.lvLichSuTap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chThoigian,
            this.chKQ,
            this.chGhiChú});
            this.lvLichSuTap.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvLichSuTap.GridLines = true;
            this.lvLichSuTap.HideSelection = false;
            this.lvLichSuTap.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvLichSuTap.Location = new System.Drawing.Point(3, 16);
            this.lvLichSuTap.Name = "lvLichSuTap";
            this.lvLichSuTap.Size = new System.Drawing.Size(534, 127);
            this.lvLichSuTap.TabIndex = 0;
            this.lvLichSuTap.UseCompatibleStateImageBehavior = false;
            this.lvLichSuTap.View = System.Windows.Forms.View.Details;
            // 
            // chThoigian
            // 
            this.chThoigian.Text = "Thời gian";
            this.chThoigian.Width = 117;
            // 
            // chKQ
            // 
            this.chKQ.Text = "Kết Quả";
            this.chKQ.Width = 66;
            // 
            // chGhiChú
            // 
            this.chGhiChú.Text = "Ghi Chú";
            this.chGhiChú.Width = 173;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(103, 285);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(196, 285);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(75, 23);
            this.btnChiTiet.TabIndex = 25;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(298, 284);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.Location = new System.Drawing.Point(393, 284);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(84, 23);
            this.btnGiaHan.TabIndex = 23;
            this.btnGiaHan.Text = "Gia Hạn";
            this.btnGiaHan.UseVisualStyleBackColor = true;
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Location = new System.Drawing.Point(337, 221);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(36, 23);
            this.btnChonHinh.TabIndex = 17;
            this.btnChonHinh.Text = "...";
            this.btnChonHinh.UseVisualStyleBackColor = true;
            // 
            // tbDuongDan
            // 
            this.tbDuongDan.Location = new System.Drawing.Point(123, 223);
            this.tbDuongDan.Name = "tbDuongDan";
            this.tbDuongDan.ReadOnly = true;
            this.tbDuongDan.Size = new System.Drawing.Size(179, 20);
            this.tbDuongDan.TabIndex = 16;
            // 
            // lblHinhHocVien
            // 
            this.lblHinhHocVien.AutoSize = true;
            this.lblHinhHocVien.Location = new System.Drawing.Point(12, 226);
            this.lblHinhHocVien.Name = "lblHinhHocVien";
            this.lblHinhHocVien.Size = new System.Drawing.Size(76, 13);
            this.lblHinhHocVien.TabIndex = 15;
            this.lblHinhHocVien.Text = "Hình Học Viên";
            // 
            // btnPFDangKyPT
            // 
            this.btnPFDangKyPT.Location = new System.Drawing.Point(492, 285);
            this.btnPFDangKyPT.Name = "btnPFDangKyPT";
            this.btnPFDangKyPT.Size = new System.Drawing.Size(75, 23);
            this.btnPFDangKyPT.TabIndex = 13;
            this.btnPFDangKyPT.Text = "Đăng Ký PT";
            this.btnPFDangKyPT.UseVisualStyleBackColor = true;
            // 
            // tbPFCongNo
            // 
            this.tbPFCongNo.Location = new System.Drawing.Point(276, 188);
            this.tbPFCongNo.Name = "tbPFCongNo";
            this.tbPFCongNo.Size = new System.Drawing.Size(251, 20);
            this.tbPFCongNo.TabIndex = 12;
            // 
            // lblPFCongNo
            // 
            this.lblPFCongNo.AutoSize = true;
            this.lblPFCongNo.Location = new System.Drawing.Point(193, 188);
            this.lblPFCongNo.Name = "lblPFCongNo";
            this.lblPFCongNo.Size = new System.Drawing.Size(49, 13);
            this.lblPFCongNo.TabIndex = 11;
            this.lblPFCongNo.Text = "Công Nợ";
            // 
            // cbPFThe
            // 
            this.cbPFThe.FormattingEnabled = true;
            this.cbPFThe.Location = new System.Drawing.Point(276, 149);
            this.cbPFThe.Name = "cbPFThe";
            this.cbPFThe.Size = new System.Drawing.Size(272, 21);
            this.cbPFThe.TabIndex = 10;
            // 
            // lblPFThe
            // 
            this.lblPFThe.AutoSize = true;
            this.lblPFThe.Location = new System.Drawing.Point(190, 152);
            this.lblPFThe.Name = "lblPFThe";
            this.lblPFThe.Size = new System.Drawing.Size(26, 13);
            this.lblPFThe.TabIndex = 9;
            this.lblPFThe.Text = "Thẻ";
            // 
            // cbPFGHT
            // 
            this.cbPFGHT.FormattingEnabled = true;
            this.cbPFGHT.Location = new System.Drawing.Point(276, 103);
            this.cbPFGHT.Name = "cbPFGHT";
            this.cbPFGHT.Size = new System.Drawing.Size(272, 21);
            this.cbPFGHT.TabIndex = 8;
            // 
            // lblPFGoiHT
            // 
            this.lblPFGoiHT.AutoSize = true;
            this.lblPFGoiHT.Location = new System.Drawing.Point(190, 106);
            this.lblPFGoiHT.Name = "lblPFGoiHT";
            this.lblPFGoiHT.Size = new System.Drawing.Size(66, 13);
            this.lblPFGoiHT.TabIndex = 7;
            this.lblPFGoiHT.Text = "Gói Hiện Tại";
            // 
            // cbPFTrangThai
            // 
            this.cbPFTrangThai.FormattingEnabled = true;
            this.cbPFTrangThai.Location = new System.Drawing.Point(276, 68);
            this.cbPFTrangThai.Name = "cbPFTrangThai";
            this.cbPFTrangThai.Size = new System.Drawing.Size(272, 21);
            this.cbPFTrangThai.TabIndex = 6;
            // 
            // lblPFTrangThai
            // 
            this.lblPFTrangThai.AutoSize = true;
            this.lblPFTrangThai.Location = new System.Drawing.Point(190, 68);
            this.lblPFTrangThai.Name = "lblPFTrangThai";
            this.lblPFTrangThai.Size = new System.Drawing.Size(59, 13);
            this.lblPFTrangThai.TabIndex = 5;
            this.lblPFTrangThai.Text = "Trang Thai";
            // 
            // tbPFSDT
            // 
            this.tbPFSDT.Location = new System.Drawing.Point(276, 33);
            this.tbPFSDT.Name = "tbPFSDT";
            this.tbPFSDT.Size = new System.Drawing.Size(251, 20);
            this.tbPFSDT.TabIndex = 4;
            // 
            // lblPFSDT
            // 
            this.lblPFSDT.AutoSize = true;
            this.lblPFSDT.Location = new System.Drawing.Point(190, 36);
            this.lblPFSDT.Name = "lblPFSDT";
            this.lblPFSDT.Size = new System.Drawing.Size(29, 13);
            this.lblPFSDT.TabIndex = 3;
            this.lblPFSDT.Text = "SDT";
            // 
            // tbPFTen
            // 
            this.tbPFTen.Location = new System.Drawing.Point(276, 4);
            this.tbPFTen.Name = "tbPFTen";
            this.tbPFTen.Size = new System.Drawing.Size(251, 20);
            this.tbPFTen.TabIndex = 2;
            // 
            // lblPFTen
            // 
            this.lblPFTen.AutoSize = true;
            this.lblPFTen.Location = new System.Drawing.Point(190, 4);
            this.lblPFTen.Name = "lblPFTen";
            this.lblPFTen.Size = new System.Drawing.Size(26, 13);
            this.lblPFTen.TabIndex = 1;
            this.lblPFTen.Text = "Ten";
            // 
            // pbAvartar
            // 
            this.pbAvartar.Location = new System.Drawing.Point(12, 3);
            this.pbAvartar.Name = "pbAvartar";
            this.pbAvartar.Size = new System.Drawing.Size(166, 214);
            this.pbAvartar.TabIndex = 0;
            this.pbAvartar.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDS);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1665, 707);
            this.pnlDS.ResumeLayout(false);
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            this.gbLichSuTap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvartar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDS;
        private System.Windows.Forms.ListView lvDanhSachHV;
        private System.Windows.Forms.ColumnHeader chTen;
        private System.Windows.Forms.ColumnHeader chSĐT;
        private System.Windows.Forms.ColumnHeader chTrangThai;
        private System.Windows.Forms.ColumnHeader chGoi;
        private System.Windows.Forms.ColumnHeader chHetHan;
        private System.Windows.Forms.ColumnHeader chTag;
        private System.Windows.Forms.ColumnHeader chLastcheckin;
        private System.Windows.Forms.ColumnHeader chCongNo;
        private System.Windows.Forms.ColumnHeader chPT;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.GroupBox gbLichSuTap;
        private System.Windows.Forms.Button btnChiTietLS;
        private System.Windows.Forms.ListView lvLichSuTap;
        private System.Windows.Forms.ColumnHeader chThoigian;
        private System.Windows.Forms.ColumnHeader chKQ;
        private System.Windows.Forms.ColumnHeader chGhiChú;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.Button btnChonHinh;
        private System.Windows.Forms.TextBox tbDuongDan;
        private System.Windows.Forms.Label lblHinhHocVien;
        private System.Windows.Forms.Button btnPFDangKyPT;
        private System.Windows.Forms.TextBox tbPFCongNo;
        private System.Windows.Forms.Label lblPFCongNo;
        private System.Windows.Forms.ComboBox cbPFThe;
        private System.Windows.Forms.Label lblPFThe;
        private System.Windows.Forms.ComboBox cbPFGHT;
        private System.Windows.Forms.Label lblPFGoiHT;
        private System.Windows.Forms.ComboBox cbPFTrangThai;
        private System.Windows.Forms.Label lblPFTrangThai;
        private System.Windows.Forms.TextBox tbPFSDT;
        private System.Windows.Forms.Label lblPFSDT;
        private System.Windows.Forms.TextBox tbPFTen;
        private System.Windows.Forms.Label lblPFTen;
        private System.Windows.Forms.PictureBox pbAvartar;
    }
}
