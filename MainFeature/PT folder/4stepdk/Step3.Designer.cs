namespace GymManagerment_MVP.MainFeature.HoaDonRelated.PT._4stepdk
{
    partial class Step3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Step3));
            this.pnlDanhSach = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDSPT = new System.Windows.Forms.DataGridView();
            this.chGID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chgHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chgTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chgSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chgTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chgSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chgXoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAvatar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbTim = new System.Windows.Forms.TextBox();
            this.pnInfor = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnChon = new System.Windows.Forms.Button();
            this.lbChuyenMon = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTuoi = new System.Windows.Forms.Label();
            this.lblKyHieu = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.lblPFTrangThai = new System.Windows.Forms.Label();
            this.lblPFSDT = new System.Windows.Forms.Label();
            this.lblPFTen = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDanhSach.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPT)).BeginInit();
            this.pnInfor.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDanhSach
            // 
            this.pnlDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDanhSach.Controls.Add(this.panel3);
            this.pnlDanhSach.Controls.Add(this.pnInfor);
            this.pnlDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDanhSach.Location = new System.Drawing.Point(0, 0);
            this.pnlDanhSach.Name = "pnlDanhSach";
            this.pnlDanhSach.Size = new System.Drawing.Size(920, 540);
            this.pnlDanhSach.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.dgvDSPT);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.tbTim);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20);
            this.panel3.Size = new System.Drawing.Size(633, 538);
            this.panel3.TabIndex = 30;
            // 
            // dgvDSPT
            // 
            this.dgvDSPT.AllowDrop = true;
            this.dgvDSPT.AllowUserToOrderColumns = true;
            this.dgvDSPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chGID,
            this.chgHo,
            this.chgTen,
            this.chgSDT,
            this.chgTrangThai,
            this.chgSex,
            this.cNgaySinh,
            this.chgXoa,
            this.cAvatar});
            this.dgvDSPT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDSPT.Location = new System.Drawing.Point(20, 71);
            this.dgvDSPT.Name = "dgvDSPT";
            this.dgvDSPT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSPT.Size = new System.Drawing.Size(593, 447);
            this.dgvDSPT.TabIndex = 4;
            this.dgvDSPT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPT_CellClick);
            this.dgvDSPT.DoubleClick += new System.EventHandler(this.dgvDSPT_DoubleClick);
            // 
            // chGID
            // 
            this.chGID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.chGID.DataPropertyName = "ID";
            this.chGID.HeaderText = "ID";
            this.chGID.Name = "chGID";
            this.chGID.Visible = false;
            // 
            // chgHo
            // 
            this.chgHo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chgHo.DataPropertyName = "tenLot";
            this.chgHo.HeaderText = "Ho";
            this.chgHo.Name = "chgHo";
            // 
            // chgTen
            // 
            this.chgTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.chgTen.DataPropertyName = "name";
            this.chgTen.HeaderText = "Tên";
            this.chgTen.Name = "chgTen";
            this.chgTen.Width = 51;
            // 
            // chgSDT
            // 
            this.chgSDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.chgSDT.DataPropertyName = "SDT";
            this.chgSDT.HeaderText = "SDT";
            this.chgSDT.Name = "chgSDT";
            this.chgSDT.Width = 54;
            // 
            // chgTrangThai
            // 
            this.chgTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.chgTrangThai.DataPropertyName = "TrangThai";
            this.chgTrangThai.HeaderText = "Trạng Thái";
            this.chgTrangThai.Name = "chgTrangThai";
            this.chgTrangThai.Visible = false;
            // 
            // chgSex
            // 
            this.chgSex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.chgSex.DataPropertyName = "GioiTinh";
            this.chgSex.HeaderText = "Gioi Tinh";
            this.chgSex.Name = "chgSex";
            this.chgSex.Width = 74;
            // 
            // cNgaySinh
            // 
            this.cNgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cNgaySinh.DataPropertyName = "NgaySinh";
            this.cNgaySinh.HeaderText = "Ngay Sinh";
            this.cNgaySinh.Name = "cNgaySinh";
            this.cNgaySinh.Visible = false;
            // 
            // chgXoa
            // 
            this.chgXoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.chgXoa.DataPropertyName = "thoiGianXoa";
            this.chgXoa.HeaderText = "Xóa";
            this.chgXoa.Name = "chgXoa";
            this.chgXoa.Visible = false;
            // 
            // cAvatar
            // 
            this.cAvatar.DataPropertyName = "AvatarUrl";
            this.cAvatar.HeaderText = "Avatar";
            this.cAvatar.Name = "cAvatar";
            this.cAvatar.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(535, 18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // tbTim
            // 
            this.tbTim.Location = new System.Drawing.Point(20, 18);
            this.tbTim.Name = "tbTim";
            this.tbTim.Size = new System.Drawing.Size(494, 20);
            this.tbTim.TabIndex = 1;
            // 
            // pnInfor
            // 
            this.pnInfor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnInfor.Controls.Add(this.panel4);
            this.pnInfor.Controls.Add(this.panel1);
            this.pnInfor.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnInfor.Location = new System.Drawing.Point(633, 0);
            this.pnInfor.Name = "pnInfor";
            this.pnInfor.Padding = new System.Windows.Forms.Padding(19);
            this.pnInfor.Size = new System.Drawing.Size(285, 538);
            this.pnInfor.TabIndex = 29;
            this.pnInfor.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.Controls.Add(this.btnChon);
            this.panel4.Controls.Add(this.lbChuyenMon);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lblTuoi);
            this.panel4.Controls.Add(this.lblKyHieu);
            this.panel4.Controls.Add(this.lblSex);
            this.panel4.Controls.Add(this.pbAvatar);
            this.panel4.Controls.Add(this.lblPFTrangThai);
            this.panel4.Controls.Add(this.lblPFSDT);
            this.panel4.Controls.Add(this.lblPFTen);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(19, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 456);
            this.panel4.TabIndex = 2;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(150, 417);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 45;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            // 
            // lbChuyenMon
            // 
            this.lbChuyenMon.FormattingEnabled = true;
            this.lbChuyenMon.Items.AddRange(new object[] {
            "Hồi Phục Chức Năng",
            "Thi Đấu Thể Hình",
            "Giảm Cân Người Lớn Tuổi",
            "Giảm Cân Nữ",
            "Giảm Cân Nam",
            "Huấn Luyện Thể Lực",
            "Thi Đấu Cử tạ",
            "Tăng Cường Sức Mạnh"});
            this.lbChuyenMon.Location = new System.Drawing.Point(14, 223);
            this.lbChuyenMon.Name = "lbChuyenMon";
            this.lbChuyenMon.Size = new System.Drawing.Size(216, 160);
            this.lbChuyenMon.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Chuyên Môn";
            // 
            // lblTuoi
            // 
            this.lblTuoi.AutoSize = true;
            this.lblTuoi.Location = new System.Drawing.Point(186, 49);
            this.lblTuoi.Name = "lblTuoi";
            this.lblTuoi.Size = new System.Drawing.Size(19, 13);
            this.lblTuoi.TabIndex = 31;
            this.lblTuoi.Text = "20";
            // 
            // lblKyHieu
            // 
            this.lblKyHieu.AutoSize = true;
            this.lblKyHieu.Location = new System.Drawing.Point(171, 49);
            this.lblKyHieu.Name = "lblKyHieu";
            this.lblKyHieu.Size = new System.Drawing.Size(9, 13);
            this.lblKyHieu.TabIndex = 30;
            this.lblKyHieu.Text = "|";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(136, 49);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(29, 13);
            this.lblSex.TabIndex = 29;
            this.lblSex.Text = "Nam";
            // 
            // pbAvatar
            // 
            this.pbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pbAvatar.Image")));
            this.pbAvatar.Location = new System.Drawing.Point(14, 8);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Padding = new System.Windows.Forms.Padding(10);
            this.pbAvatar.Size = new System.Drawing.Size(116, 181);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 19;
            this.pbAvatar.TabStop = false;
            // 
            // lblPFTrangThai
            // 
            this.lblPFTrangThai.AutoSize = true;
            this.lblPFTrangThai.Location = new System.Drawing.Point(136, 169);
            this.lblPFTrangThai.Name = "lblPFTrangThai";
            this.lblPFTrangThai.Size = new System.Drawing.Size(110, 13);
            this.lblPFTrangThai.TabIndex = 12;
            this.lblPFTrangThai.Text = "Nhận Thêm Học Viên";
            // 
            // lblPFSDT
            // 
            this.lblPFSDT.AutoSize = true;
            this.lblPFSDT.Location = new System.Drawing.Point(136, 143);
            this.lblPFSDT.Name = "lblPFSDT";
            this.lblPFSDT.Size = new System.Drawing.Size(89, 13);
            this.lblPFSDT.TabIndex = 11;
            this.lblPFSDT.Text = "SDT: 012345678";
            // 
            // lblPFTen
            // 
            this.lblPFTen.AutoSize = true;
            this.lblPFTen.Location = new System.Drawing.Point(136, 23);
            this.lblPFTen.Name = "lblPFTen";
            this.lblPFTen.Size = new System.Drawing.Size(94, 13);
            this.lblPFTen.TabIndex = 10;
            this.lblPFTen.Text = "Nguyễn Đình Hiếu";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(19, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 44);
            this.panel1.TabIndex = 1;
            // 
            // Step3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDanhSach);
            this.Name = "Step3";
            this.Size = new System.Drawing.Size(920, 540);
            this.pnlDanhSach.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPT)).EndInit();
            this.pnInfor.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDanhSach;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbTim;
        private System.Windows.Forms.Panel pnInfor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox lbChuyenMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTuoi;
        private System.Windows.Forms.Label lblKyHieu;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label lblPFTrangThai;
        private System.Windows.Forms.Label lblPFSDT;
        private System.Windows.Forms.Label lblPFTen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.DataGridView dgvDSPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn chGID;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAvatar;
    }
}
