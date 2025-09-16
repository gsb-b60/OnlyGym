namespace GymManagerment_MVP
{
    partial class Mainfrm
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
            this.pnlHome = new System.Windows.Forms.Panel();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblAccName = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnDanhSachKH = new System.Windows.Forms.Button();
            this.btnThongTinKH = new System.Windows.Forms.Button();
            this.btnHDPT = new System.Windows.Forms.Button();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.btnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.btnThongKeDoanhThu = new System.Windows.Forms.Button();
            this.btnDanhSachThietBi = new System.Windows.Forms.Button();
            this.btnDanhSachKhachHang = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.thôngTinGóiTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinGóiTậpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinGóiPTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinHãngSảnXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinChuyểnKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pnlHome.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlHome.Controls.Add(this.lblChucVu);
            this.pnlHome.Controls.Add(this.lblAccName);
            this.pnlHome.Controls.Add(this.menuStrip1);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHome.Location = new System.Drawing.Point(0, 0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1264, 27);
            this.pnlHome.TabIndex = 0;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(1121, 9);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(60, 13);
            this.lblChucVu.TabIndex = 7;
            this.lblChucVu.Text = "Chu Phong";
            // 
            // lblAccName
            // 
            this.lblAccName.AutoSize = true;
            this.lblAccName.Location = new System.Drawing.Point(941, 9);
            this.lblAccName.Name = "lblAccName";
            this.lblAccName.Size = new System.Drawing.Size(94, 13);
            this.lblAccName.TabIndex = 6;
            this.lblAccName.Text = "Nguyen Dinh Hieu";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlMenu.Controls.Add(this.btnDanhSachKH);
            this.pnlMenu.Controls.Add(this.btnThongTinKH);
            this.pnlMenu.Controls.Add(this.btnHDPT);
            this.pnlMenu.Controls.Add(this.btnCheckin);
            this.pnlMenu.Controls.Add(this.btnXuatHoaDon);
            this.pnlMenu.Controls.Add(this.btnQuanLyNhanVien);
            this.pnlMenu.Controls.Add(this.btnThongKeDoanhThu);
            this.pnlMenu.Controls.Add(this.btnDanhSachThietBi);
            this.pnlMenu.Controls.Add(this.btnDanhSachKhachHang);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 27);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1264, 31);
            this.pnlMenu.TabIndex = 1;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // btnDanhSachKH
            // 
            this.btnDanhSachKH.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDanhSachKH.Location = new System.Drawing.Point(1114, 0);
            this.btnDanhSachKH.Name = "btnDanhSachKH";
            this.btnDanhSachKH.Size = new System.Drawing.Size(139, 31);
            this.btnDanhSachKH.TabIndex = 8;
            this.btnDanhSachKH.Text = "Danh Sach Khac Hang";
            this.btnDanhSachKH.UseVisualStyleBackColor = true;
            this.btnDanhSachKH.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnThongTinKH
            // 
            this.btnThongTinKH.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThongTinKH.Location = new System.Drawing.Point(975, 0);
            this.btnThongTinKH.Name = "btnThongTinKH";
            this.btnThongTinKH.Size = new System.Drawing.Size(139, 31);
            this.btnThongTinKH.TabIndex = 7;
            this.btnThongTinKH.Text = "Thông Tin Khách Hàng";
            this.btnThongTinKH.UseVisualStyleBackColor = true;
            this.btnThongTinKH.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnHDPT
            // 
            this.btnHDPT.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHDPT.Location = new System.Drawing.Point(814, 0);
            this.btnHDPT.Name = "btnHDPT";
            this.btnHDPT.Size = new System.Drawing.Size(161, 31);
            this.btnHDPT.TabIndex = 6;
            this.btnHDPT.Text = "Quản  Lý Huấn Luyện Viên";
            this.btnHDPT.UseVisualStyleBackColor = true;
            this.btnHDPT.Click += new System.EventHandler(this.btnHDPT_Click);
            // 
            // btnCheckin
            // 
            this.btnCheckin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCheckin.Location = new System.Drawing.Point(748, 0);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(66, 31);
            this.btnCheckin.TabIndex = 5;
            this.btnCheckin.Text = "Check In";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXuatHoaDon.Location = new System.Drawing.Point(600, 0);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(148, 31);
            this.btnXuatHoaDon.TabIndex = 4;
            this.btnXuatHoaDon.Text = "Xuat Hoa Don";
            this.btnXuatHoaDon.UseVisualStyleBackColor = true;
            this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(434, 0);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(166, 31);
            this.btnQuanLyNhanVien.TabIndex = 3;
            this.btnQuanLyNhanVien.Text = "Quan Ly Nhan Vien";
            this.btnQuanLyNhanVien.UseVisualStyleBackColor = true;
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            // 
            // btnThongKeDoanhThu
            // 
            this.btnThongKeDoanhThu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThongKeDoanhThu.Location = new System.Drawing.Point(269, 0);
            this.btnThongKeDoanhThu.Name = "btnThongKeDoanhThu";
            this.btnThongKeDoanhThu.Size = new System.Drawing.Size(165, 31);
            this.btnThongKeDoanhThu.TabIndex = 2;
            this.btnThongKeDoanhThu.Text = "Thong Ke Doanh Thu";
            this.btnThongKeDoanhThu.UseVisualStyleBackColor = true;
            this.btnThongKeDoanhThu.Click += new System.EventHandler(this.btnThongKeDoanhThu_Click);
            // 
            // btnDanhSachThietBi
            // 
            this.btnDanhSachThietBi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDanhSachThietBi.Location = new System.Drawing.Point(139, 0);
            this.btnDanhSachThietBi.Name = "btnDanhSachThietBi";
            this.btnDanhSachThietBi.Size = new System.Drawing.Size(130, 31);
            this.btnDanhSachThietBi.TabIndex = 1;
            this.btnDanhSachThietBi.Text = "Danh Sach Thiet Bi";
            this.btnDanhSachThietBi.UseVisualStyleBackColor = true;
            this.btnDanhSachThietBi.Click += new System.EventHandler(this.btnDanhSachThietBi_Click);
            // 
            // btnDanhSachKhachHang
            // 
            this.btnDanhSachKhachHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDanhSachKhachHang.Location = new System.Drawing.Point(0, 0);
            this.btnDanhSachKhachHang.Name = "btnDanhSachKhachHang";
            this.btnDanhSachKhachHang.Size = new System.Drawing.Size(139, 31);
            this.btnDanhSachKhachHang.TabIndex = 0;
            this.btnDanhSachKhachHang.Text = "Danh Sach Khac Hang";
            this.btnDanhSachKhachHang.UseVisualStyleBackColor = true;
            this.btnDanhSachKhachHang.Click += new System.EventHandler(this.btnDanhSachKhachHang_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 58);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1264, 703);
            this.pnlContent.TabIndex = 2;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // thôngTinGóiTậpToolStripMenuItem
            // 
            this.thôngTinGóiTậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinGóiTậpToolStripMenuItem1,
            this.thôngTinGóiPTToolStripMenuItem,
            this.thôngTinHãngSảnXuấtToolStripMenuItem1});
            this.thôngTinGóiTậpToolStripMenuItem.Name = "thôngTinGóiTậpToolStripMenuItem";
            this.thôngTinGóiTậpToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.thôngTinGóiTậpToolStripMenuItem.Text = "Thông Tin";
            // 
            // thôngTinGóiTậpToolStripMenuItem1
            // 
            this.thôngTinGóiTậpToolStripMenuItem1.Name = "thôngTinGóiTậpToolStripMenuItem1";
            this.thôngTinGóiTậpToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.thôngTinGóiTậpToolStripMenuItem1.Text = "Thông tin gói tập";
            // 
            // thôngTinGóiPTToolStripMenuItem
            // 
            this.thôngTinGóiPTToolStripMenuItem.Name = "thôngTinGóiPTToolStripMenuItem";
            this.thôngTinGóiPTToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.thôngTinGóiPTToolStripMenuItem.Text = "Thông tin gói PT";
            // 
            // thôngTinHãngSảnXuấtToolStripMenuItem1
            // 
            this.thôngTinHãngSảnXuấtToolStripMenuItem1.Name = "thôngTinHãngSảnXuấtToolStripMenuItem1";
            this.thôngTinHãngSảnXuấtToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.thôngTinHãngSảnXuấtToolStripMenuItem1.Text = "Thông tin hãng sản xuất";
            // 
            // thôngTinChuyểnKhoảnToolStripMenuItem
            // 
            this.thôngTinChuyểnKhoảnToolStripMenuItem.Name = "thôngTinChuyểnKhoảnToolStripMenuItem";
            this.thôngTinChuyểnKhoảnToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.thôngTinChuyểnKhoảnToolStripMenuItem.Text = "Thông Tin Chuyển Khoản";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng Dẫn Sử Dụng";
            this.hướngDẫnSửDụngToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnSửDụngToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinGóiTậpToolStripMenuItem,
            this.thôngTinChuyểnKhoảnToolStripMenuItem,
            this.hướngDẫnSửDụngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHome);
            this.Name = "Mainfrm";
            this.Text = "Mainfrm";
            this.Load += new System.EventHandler(this.Mainfrm_Load);
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnDanhSachKhachHang;
        private System.Windows.Forms.Button btnQuanLyNhanVien;
        private System.Windows.Forms.Button btnThongKeDoanhThu;
        private System.Windows.Forms.Button btnDanhSachThietBi;
        private System.Windows.Forms.Button btnXuatHoaDon;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblAccName;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Button btnHDPT;
        private System.Windows.Forms.Button btnThongTinKH;
        private System.Windows.Forms.Button btnDanhSachKH;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinGóiTậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinGóiTậpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinGóiPTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinHãngSảnXuấtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinChuyểnKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
    }
}