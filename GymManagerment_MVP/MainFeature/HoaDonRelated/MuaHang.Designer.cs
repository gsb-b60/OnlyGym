namespace GymManagerment_MVP
{
    partial class MuaHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDanhSach = new System.Windows.Forms.Panel();
            this.tpMuaHang = new System.Windows.Forms.TabControl();
            this.tabPT = new System.Windows.Forms.TabPage();
            this.pnPTV2 = new System.Windows.Forms.Panel();
            this.pnKhachHang = new System.Windows.Forms.Panel();
            this.pnThongTinMuaHang = new System.Windows.Forms.Panel();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.csp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsXoa = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTongThanhToan = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTongTienHang = new System.Windows.Forms.Label();
            this.lblTTT = new System.Windows.Forms.Label();
            this.lblDC = new System.Windows.Forms.Label();
            this.lbltth = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblTuoi = new System.Windows.Forms.Label();
            this.lblKyHieu = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.lblPFTrangThai = new System.Windows.Forms.Label();
            this.lblPFSDT = new System.Windows.Forms.Label();
            this.lblPFTen = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnGoiTap = new System.Windows.Forms.Panel();
            this.tabGoiTap = new System.Windows.Forms.TabPage();
            this.pnlDanhSach.SuspendLayout();
            this.tpMuaHang.SuspendLayout();
            this.tabPT.SuspendLayout();
            this.pnKhachHang.SuspendLayout();
            this.pnThongTinMuaHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.cmsXoa.SuspendLayout();
            this.tabGoiTap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDanhSach
            // 
            this.pnlDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDanhSach.Controls.Add(this.tpMuaHang);
            this.pnlDanhSach.Controls.Add(this.pnKhachHang);
            this.pnlDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDanhSach.Location = new System.Drawing.Point(0, 0);
            this.pnlDanhSach.Name = "pnlDanhSach";
            this.pnlDanhSach.Size = new System.Drawing.Size(1264, 703);
            this.pnlDanhSach.TabIndex = 27;
            // 
            // tpMuaHang
            // 
            this.tpMuaHang.Controls.Add(this.tabGoiTap);
            this.tpMuaHang.Controls.Add(this.tabPT);
            this.tpMuaHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpMuaHang.ItemSize = new System.Drawing.Size(100, 45);
            this.tpMuaHang.Location = new System.Drawing.Point(0, 0);
            this.tpMuaHang.Name = "tpMuaHang";
            this.tpMuaHang.Padding = new System.Drawing.Point(10, 3);
            this.tpMuaHang.SelectedIndex = 0;
            this.tpMuaHang.Size = new System.Drawing.Size(940, 701);
            this.tpMuaHang.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tpMuaHang.TabIndex = 30;
            // 
            // tabPT
            // 
            this.tabPT.Controls.Add(this.pnPTV2);
            this.tabPT.Location = new System.Drawing.Point(4, 49);
            this.tabPT.Name = "tabPT";
            this.tabPT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPT.Size = new System.Drawing.Size(932, 648);
            this.tabPT.TabIndex = 3;
            this.tabPT.Text = "Đăng Ký PT";
            this.tabPT.UseVisualStyleBackColor = true;
            // 
            // pnPTV2
            // 
            this.pnPTV2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPTV2.Location = new System.Drawing.Point(3, 3);
            this.pnPTV2.Name = "pnPTV2";
            this.pnPTV2.Size = new System.Drawing.Size(926, 642);
            this.pnPTV2.TabIndex = 0;
            // 
            // pnKhachHang
            // 
            this.pnKhachHang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnKhachHang.Controls.Add(this.pnThongTinMuaHang);
            this.pnKhachHang.Controls.Add(this.panel1);
            this.pnKhachHang.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnKhachHang.Location = new System.Drawing.Point(940, 0);
            this.pnKhachHang.Name = "pnKhachHang";
            this.pnKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.pnKhachHang.Size = new System.Drawing.Size(322, 701);
            this.pnKhachHang.TabIndex = 29;
            // 
            // pnThongTinMuaHang
            // 
            this.pnThongTinMuaHang.AutoScroll = true;
            this.pnThongTinMuaHang.BackColor = System.Drawing.Color.Azure;
            this.pnThongTinMuaHang.Controls.Add(this.dgvBill);
            this.pnThongTinMuaHang.Controls.Add(this.lblTongThanhToan);
            this.pnThongTinMuaHang.Controls.Add(this.lblDiscount);
            this.pnThongTinMuaHang.Controls.Add(this.lblTongTienHang);
            this.pnThongTinMuaHang.Controls.Add(this.lblTTT);
            this.pnThongTinMuaHang.Controls.Add(this.lblDC);
            this.pnThongTinMuaHang.Controls.Add(this.lbltth);
            this.pnThongTinMuaHang.Controls.Add(this.btnThanhToan);
            this.pnThongTinMuaHang.Controls.Add(this.lblTuoi);
            this.pnThongTinMuaHang.Controls.Add(this.lblKyHieu);
            this.pnThongTinMuaHang.Controls.Add(this.lblSex);
            this.pnThongTinMuaHang.Controls.Add(this.btnChiTiet);
            this.pnThongTinMuaHang.Controls.Add(this.lblPFTrangThai);
            this.pnThongTinMuaHang.Controls.Add(this.lblPFSDT);
            this.pnThongTinMuaHang.Controls.Add(this.lblPFTen);
            this.pnThongTinMuaHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnThongTinMuaHang.Location = new System.Drawing.Point(3, 33);
            this.pnThongTinMuaHang.Name = "pnThongTinMuaHang";
            this.pnThongTinMuaHang.Size = new System.Drawing.Size(316, 640);
            this.pnThongTinMuaHang.TabIndex = 3;
            // 
            // dgvBill
            // 
            this.dgvBill.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.csp,
            this.csl,
            this.ctt});
            this.dgvBill.ContextMenuStrip = this.cmsXoa;
            this.dgvBill.Location = new System.Drawing.Point(3, 128);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.Size = new System.Drawing.Size(310, 346);
            this.dgvBill.TabIndex = 50;
            // 
            // csp
            // 
            this.csp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.csp.HeaderText = "Sản Phẩm";
            this.csp.Name = "csp";
            this.csp.ReadOnly = true;
            this.csp.Width = 81;
            // 
            // csl
            // 
            this.csl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.csl.HeaderText = "Số Lượng";
            this.csl.Name = "csl";
            this.csl.ReadOnly = true;
            this.csl.Width = 78;
            // 
            // ctt
            // 
            this.ctt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C0";
            dataGridViewCellStyle2.NullValue = null;
            this.ctt.DefaultCellStyle = dataGridViewCellStyle2;
            this.ctt.HeaderText = "Thành Tiền";
            this.ctt.Name = "ctt";
            this.ctt.ReadOnly = true;
            // 
            // cmsXoa
            // 
            this.cmsXoa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem});
            this.cmsXoa.Name = "cmsXoa";
            this.cmsXoa.Size = new System.Drawing.Size(95, 26);
            this.cmsXoa.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // lblTongThanhToan
            // 
            this.lblTongThanhToan.Location = new System.Drawing.Point(201, 557);
            this.lblTongThanhToan.Name = "lblTongThanhToan";
            this.lblTongThanhToan.Size = new System.Drawing.Size(110, 13);
            this.lblTongThanhToan.TabIndex = 49;
            this.lblTongThanhToan.Text = "279.000";
            this.lblTongThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Location = new System.Drawing.Point(213, 516);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(98, 13);
            this.lblDiscount.TabIndex = 48;
            this.lblDiscount.Text = "0.000";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTongTienHang
            // 
            this.lblTongTienHang.Location = new System.Drawing.Point(201, 477);
            this.lblTongTienHang.Name = "lblTongTienHang";
            this.lblTongTienHang.Size = new System.Drawing.Size(110, 13);
            this.lblTongTienHang.TabIndex = 47;
            this.lblTongTienHang.Text = "279.000";
            this.lblTongTienHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTTT
            // 
            this.lblTTT.AutoSize = true;
            this.lblTTT.Location = new System.Drawing.Point(79, 557);
            this.lblTTT.Name = "lblTTT";
            this.lblTTT.Size = new System.Drawing.Size(94, 13);
            this.lblTTT.TabIndex = 46;
            this.lblTTT.Text = "Tổng Thanh Toán";
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Location = new System.Drawing.Point(79, 516);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(49, 13);
            this.lblDC.TabIndex = 45;
            this.lblDC.Text = "Discount";
            // 
            // lbltth
            // 
            this.lbltth.AutoSize = true;
            this.lbltth.Location = new System.Drawing.Point(79, 477);
            this.lbltth.Name = "lbltth";
            this.lbltth.Size = new System.Drawing.Size(85, 13);
            this.lbltth.TabIndex = 44;
            this.lbltth.Text = "Tổng Tiền Hàng";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.Location = new System.Drawing.Point(210, 592);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(101, 32);
            this.btnThanhToan.TabIndex = 33;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lblTuoi
            // 
            this.lblTuoi.AutoSize = true;
            this.lblTuoi.Location = new System.Drawing.Point(61, 49);
            this.lblTuoi.Name = "lblTuoi";
            this.lblTuoi.Size = new System.Drawing.Size(19, 13);
            this.lblTuoi.TabIndex = 31;
            this.lblTuoi.Text = "20";
            // 
            // lblKyHieu
            // 
            this.lblKyHieu.AutoSize = true;
            this.lblKyHieu.Location = new System.Drawing.Point(46, 49);
            this.lblKyHieu.Name = "lblKyHieu";
            this.lblKyHieu.Size = new System.Drawing.Size(9, 13);
            this.lblKyHieu.TabIndex = 30;
            this.lblKyHieu.Text = "|";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(11, 49);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(29, 13);
            this.lblSex.TabIndex = 29;
            this.lblSex.Text = "Nam";
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(238, 76);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(75, 23);
            this.btnChiTiet.TabIndex = 26;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            // 
            // lblPFTrangThai
            // 
            this.lblPFTrangThai.AutoSize = true;
            this.lblPFTrangThai.Location = new System.Drawing.Point(203, 47);
            this.lblPFTrangThai.Name = "lblPFTrangThai";
            this.lblPFTrangThai.Size = new System.Drawing.Size(47, 13);
            this.lblPFTrangThai.TabIndex = 12;
            this.lblPFTrangThai.Text = "Còn hạn";
            // 
            // lblPFSDT
            // 
            this.lblPFSDT.AutoSize = true;
            this.lblPFSDT.Location = new System.Drawing.Point(203, 23);
            this.lblPFSDT.Name = "lblPFSDT";
            this.lblPFSDT.Size = new System.Drawing.Size(89, 13);
            this.lblPFSDT.TabIndex = 11;
            this.lblPFSDT.Text = "SDT: 012345678";
            // 
            // lblPFTen
            // 
            this.lblPFTen.AutoSize = true;
            this.lblPFTen.Location = new System.Drawing.Point(11, 23);
            this.lblPFTen.Name = "lblPFTen";
            this.lblPFTen.Size = new System.Drawing.Size(94, 13);
            this.lblPFTen.TabIndex = 10;
            this.lblPFTen.Text = "Nguyễn Đình Hiếu";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 30);
            this.panel1.TabIndex = 0;
            // 
            // pnGoiTap
            // 
            this.pnGoiTap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGoiTap.Location = new System.Drawing.Point(3, 3);
            this.pnGoiTap.Name = "pnGoiTap";
            this.pnGoiTap.Size = new System.Drawing.Size(926, 642);
            this.pnGoiTap.TabIndex = 1;
            // 
            // tabGoiTap
            // 
            this.tabGoiTap.Controls.Add(this.pnGoiTap);
            this.tabGoiTap.Location = new System.Drawing.Point(4, 49);
            this.tabGoiTap.Name = "tabGoiTap";
            this.tabGoiTap.Padding = new System.Windows.Forms.Padding(3);
            this.tabGoiTap.Size = new System.Drawing.Size(932, 648);
            this.tabGoiTap.TabIndex = 0;
            this.tabGoiTap.Text = "Gói Tập";
            this.tabGoiTap.UseVisualStyleBackColor = true;
            this.tabGoiTap.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // MuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDanhSach);
            this.Name = "MuaHang";
            this.Size = new System.Drawing.Size(1264, 703);
            this.Load += new System.EventHandler(this.MuaHang_Load);
            this.pnlDanhSach.ResumeLayout(false);
            this.tpMuaHang.ResumeLayout(false);
            this.tabPT.ResumeLayout(false);
            this.pnKhachHang.ResumeLayout(false);
            this.pnThongTinMuaHang.ResumeLayout(false);
            this.pnThongTinMuaHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.cmsXoa.ResumeLayout(false);
            this.tabGoiTap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDanhSach;
        private System.Windows.Forms.Panel pnKhachHang;
        private System.Windows.Forms.TabControl tpMuaHang;
        private System.Windows.Forms.Panel pnThongTinMuaHang;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblTuoi;
        private System.Windows.Forms.Label lblKyHieu;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Label lblPFTrangThai;
        private System.Windows.Forms.Label lblPFSDT;
        private System.Windows.Forms.Label lblPFTen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPT;
        private System.Windows.Forms.Panel pnPTV2;
        private System.Windows.Forms.Label lblTongThanhToan;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTongTienHang;
        private System.Windows.Forms.Label lblTTT;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.Label lbltth;
        private System.Windows.Forms.ContextMenuStrip cmsXoa;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn csp;
        private System.Windows.Forms.DataGridViewTextBoxColumn csl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctt;
        private System.Windows.Forms.TabPage tabGoiTap;
        private System.Windows.Forms.Panel pnGoiTap;
    }
}
