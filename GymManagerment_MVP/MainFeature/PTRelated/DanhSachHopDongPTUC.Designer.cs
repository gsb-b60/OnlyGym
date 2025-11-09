namespace GymManagerment_MVP.MainFeature.HoaDonRelated.PT
{
    partial class DanhSachHopDongPTUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachHopDongPTUC));
            this.pnlDanhSach = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.cbFindB = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTuoi = new System.Windows.Forms.Label();
            this.lblKyHieu = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPFGoiHT = new System.Windows.Forms.Label();
            this.lblPFTrangThai = new System.Windows.Forms.Label();
            this.lblPFSDT = new System.Windows.Forms.Label();
            this.lblPFTen = new System.Windows.Forms.Label();
            this.pnlLoc = new System.Windows.Forms.Panel();
            this.chgCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chgSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSDTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTBuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.chEND = new System.Windows.Forms.CheckBox();
            this.cbH = new System.Windows.Forms.CheckBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.gbLastCheck = new System.Windows.Forms.GroupBox();
            this.dtpDenCheckin = new System.Windows.Forms.DateTimePicker();
            this.btnLoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTu = new System.Windows.Forms.Label();
            this.dtpTuCheckin = new System.Windows.Forms.DateTimePicker();
            this.pnlDanhSach.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLoc.SuspendLayout();
            this.gbLastCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDanhSach
            // 
            this.pnlDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDanhSach.Controls.Add(this.panel3);
            this.pnlDanhSach.Controls.Add(this.panel2);
            this.pnlDanhSach.Controls.Add(this.pnlLoc);
            this.pnlDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDanhSach.Location = new System.Drawing.Point(0, 0);
            this.pnlDanhSach.Name = "pnlDanhSach";
            this.pnlDanhSach.Size = new System.Drawing.Size(1264, 703);
            this.pnlDanhSach.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.btnTim);
            this.panel3.Controls.Add(this.cbFindB);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(172, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20);
            this.panel3.Size = new System.Drawing.Size(811, 701);
            this.panel3.TabIndex = 30;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(706, 13);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // cbFindB
            // 
            this.cbFindB.FormattingEnabled = true;
            this.cbFindB.Items.AddRange(new object[] {
            "Code",
            "Họ",
            "Tên",
            "SDT",
            ""});
            this.cbFindB.Location = new System.Drawing.Point(41, 15);
            this.cbFindB.Name = "cbFindB";
            this.cbFindB.Size = new System.Drawing.Size(121, 21);
            this.cbFindB.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(481, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chgCode,
            this.cTen,
            this.chgSDT,
            this.cTenPT,
            this.cSDTPT,
            this.cTBuoi,
            this.cTrangThai,
            this.cNgayTao});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(20, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(771, 631);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(983, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(19);
            this.panel2.Size = new System.Drawing.Size(279, 701);
            this.panel2.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.Controls.Add(this.lblTuoi);
            this.panel4.Controls.Add(this.lblKyHieu);
            this.panel4.Controls.Add(this.lblSex);
            this.panel4.Controls.Add(this.btnChiTiet);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.lblPFGoiHT);
            this.panel4.Controls.Add(this.lblPFTrangThai);
            this.panel4.Controls.Add(this.lblPFSDT);
            this.panel4.Controls.Add(this.lblPFTen);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(19, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 663);
            this.panel4.TabIndex = 2;
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
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(155, 166);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(75, 23);
            this.btnChiTiet.TabIndex = 26;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(116, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lblPFGoiHT
            // 
            this.lblPFGoiHT.AutoSize = true;
            this.lblPFGoiHT.Location = new System.Drawing.Point(136, 126);
            this.lblPFGoiHT.Name = "lblPFGoiHT";
            this.lblPFGoiHT.Size = new System.Drawing.Size(68, 13);
            this.lblPFGoiHT.TabIndex = 13;
            this.lblPFGoiHT.Text = "Gói : 1 tháng";
            // 
            // lblPFTrangThai
            // 
            this.lblPFTrangThai.AutoSize = true;
            this.lblPFTrangThai.Location = new System.Drawing.Point(136, 139);
            this.lblPFTrangThai.Name = "lblPFTrangThai";
            this.lblPFTrangThai.Size = new System.Drawing.Size(47, 13);
            this.lblPFTrangThai.TabIndex = 12;
            this.lblPFTrangThai.Text = "Còn hạn";
            // 
            // lblPFSDT
            // 
            this.lblPFSDT.AutoSize = true;
            this.lblPFSDT.Location = new System.Drawing.Point(136, 113);
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
            // pnlLoc
            // 
            this.pnlLoc.AutoScroll = true;
            this.pnlLoc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLoc.Controls.Add(this.checkBox2);
            this.pnlLoc.Controls.Add(this.checkBox1);
            this.pnlLoc.Controls.Add(this.btnXoa);
            this.pnlLoc.Controls.Add(this.chEND);
            this.pnlLoc.Controls.Add(this.cbH);
            this.pnlLoc.Controls.Add(this.lblTrangThai);
            this.pnlLoc.Controls.Add(this.gbLastCheck);
            this.pnlLoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLoc.Location = new System.Drawing.Point(0, 0);
            this.pnlLoc.Name = "pnlLoc";
            this.pnlLoc.Padding = new System.Windows.Forms.Padding(20);
            this.pnlLoc.Size = new System.Drawing.Size(172, 701);
            this.pnlLoc.TabIndex = 28;
            // 
            // chgCode
            // 
            this.chgCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.chgCode.HeaderText = "ID";
            this.chgCode.Name = "chgCode";
            this.chgCode.Width = 43;
            // 
            // cTen
            // 
            this.cTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cTen.HeaderText = "Tên Học Viên";
            this.cTen.Name = "cTen";
            this.cTen.Width = 98;
            // 
            // chgSDT
            // 
            this.chgSDT.HeaderText = "SDT";
            this.chgSDT.Name = "chgSDT";
            // 
            // cTenPT
            // 
            this.cTenPT.HeaderText = "Tên PT";
            this.cTenPT.Name = "cTenPT";
            // 
            // cSDTPT
            // 
            this.cSDTPT.HeaderText = "SDT PT";
            this.cSDTPT.Name = "cSDTPT";
            // 
            // cTBuoi
            // 
            this.cTBuoi.HeaderText = "Tổng Buổi";
            this.cTBuoi.Name = "cTBuoi";
            // 
            // cTrangThai
            // 
            this.cTrangThai.HeaderText = "Trạng Thái";
            this.cTrangThai.Name = "cTrangThai";
            // 
            // cNgayTao
            // 
            this.cNgayTao.HeaderText = "Ngày Tạo";
            this.cNgayTao.Name = "cNgayTao";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(18, 118);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(45, 17);
            this.checkBox2.TabIndex = 58;
            this.checkBox2.Text = "Hủy";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 95);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(52, 17);
            this.checkBox1.TabIndex = 57;
            this.checkBox1.Text = "Dừng";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(18, 636);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(131, 23);
            this.btnXoa.TabIndex = 56;
            this.btnXoa.Text = "Xóa tất cả";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // chEND
            // 
            this.chEND.AutoSize = true;
            this.chEND.Location = new System.Drawing.Point(18, 72);
            this.chEND.Name = "chEND";
            this.chEND.Size = new System.Drawing.Size(114, 17);
            this.chEND.TabIndex = 55;
            this.chEND.Text = "Chưa Hoàn Thành";
            this.chEND.UseVisualStyleBackColor = true;
            // 
            // cbH
            // 
            this.cbH.AutoSize = true;
            this.cbH.Location = new System.Drawing.Point(18, 49);
            this.cbH.Name = "cbH";
            this.cbH.Size = new System.Drawing.Size(86, 17);
            this.cbH.TabIndex = 54;
            this.cbH.Text = "Hoàn Thành";
            this.cbH.UseVisualStyleBackColor = true;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(15, 8);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(59, 13);
            this.lblTrangThai.TabIndex = 53;
            this.lblTrangThai.Text = "Trạng Thái";
            // 
            // gbLastCheck
            // 
            this.gbLastCheck.Controls.Add(this.dtpDenCheckin);
            this.gbLastCheck.Controls.Add(this.btnLoc);
            this.gbLastCheck.Controls.Add(this.label1);
            this.gbLastCheck.Controls.Add(this.lblTu);
            this.gbLastCheck.Controls.Add(this.dtpTuCheckin);
            this.gbLastCheck.Location = new System.Drawing.Point(18, 499);
            this.gbLastCheck.Name = "gbLastCheck";
            this.gbLastCheck.Size = new System.Drawing.Size(131, 131);
            this.gbLastCheck.TabIndex = 52;
            this.gbLastCheck.TabStop = false;
            this.gbLastCheck.Text = "Thời Gian Tạo";
            // 
            // dtpDenCheckin
            // 
            this.dtpDenCheckin.CustomFormat = "dd/MM/yyyy";
            this.dtpDenCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenCheckin.Location = new System.Drawing.Point(6, 90);
            this.dtpDenCheckin.Name = "dtpDenCheckin";
            this.dtpDenCheckin.Size = new System.Drawing.Size(105, 20);
            this.dtpDenCheckin.TabIndex = 24;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Đến";
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
            // dtpTuCheckin
            // 
            this.dtpTuCheckin.CustomFormat = "dd/MM/yyyy";
            this.dtpTuCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuCheckin.Location = new System.Drawing.Point(6, 51);
            this.dtpTuCheckin.Name = "dtpTuCheckin";
            this.dtpTuCheckin.Size = new System.Drawing.Size(105, 20);
            this.dtpTuCheckin.TabIndex = 21;
            // 
            // DanhSachHopDongPTUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDanhSach);
            this.Name = "DanhSachHopDongPTUC";
            this.Size = new System.Drawing.Size(1264, 703);
            this.pnlDanhSach.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLoc.ResumeLayout(false);
            this.pnlLoc.PerformLayout();
            this.gbLastCheck.ResumeLayout(false);
            this.gbLastCheck.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDanhSach;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cbFindB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSDTPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTBuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgayTao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTuoi;
        private System.Windows.Forms.Label lblKyHieu;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPFGoiHT;
        private System.Windows.Forms.Label lblPFTrangThai;
        private System.Windows.Forms.Label lblPFSDT;
        private System.Windows.Forms.Label lblPFTen;
        private System.Windows.Forms.Panel pnlLoc;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.CheckBox chEND;
        private System.Windows.Forms.CheckBox cbH;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.GroupBox gbLastCheck;
        private System.Windows.Forms.DateTimePicker dtpDenCheckin;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtpTuCheckin;
    }
}
