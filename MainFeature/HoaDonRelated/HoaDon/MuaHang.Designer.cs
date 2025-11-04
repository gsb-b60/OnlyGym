namespace GymManagerment_MVP.MainFeature.HoaDonRelated.HoaDon
{
    partial class frmMuaHang
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
            this.components = new System.ComponentModel.Container();
            this.chIDHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvHangMua = new System.Windows.Forms.ListView();
            this.chSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNhomHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDVT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsDsHangMua = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiBoHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXoaBot = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpNgayMua = new System.Windows.Forms.DateTimePicker();
            this.chbInHoaDon = new System.Windows.Forms.CheckBox();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.tbThanhTien = new System.Windows.Forms.TextBox();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbKhachDua = new System.Windows.Forms.TextBox();
            this.tbTenKhachMua = new System.Windows.Forms.TextBox();
            this.cbHinhThuc = new System.Windows.Forms.ComboBox();
            this.cbNhanVienLap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDSHang = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DsHang = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSua = new System.Windows.Forms.ToolStripMenuItem();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbConLai = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.flpDanhMuc = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MuaHangUC = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nudGiamGia = new System.Windows.Forms.NumericUpDown();
            this.mtbSDT = new System.Windows.Forms.MaskedTextBox();
            this.btnChuyenKhoan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.btnThemDM = new System.Windows.Forms.Button();
            this.btnThemHang = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTimDanhMuc = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.cmsDsHangMua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHang)).BeginInit();
            this.DsHang.SuspendLayout();
            this.MuaHangUC.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chIDHang
            // 
            this.chIDHang.Text = "Mã hàng ";
            this.chIDHang.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách hàng mua";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lvHangMua);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 338);
            this.panel1.TabIndex = 0;
            // 
            // lvHangMua
            // 
            this.lvHangMua.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSTT,
            this.chIDHang,
            this.chNhomHang,
            this.chTen,
            this.chDVT,
            this.chSoLuong,
            this.chDonGia,
            this.chThanhTien});
            this.lvHangMua.ContextMenuStrip = this.cmsDsHangMua;
            this.lvHangMua.FullRowSelect = true;
            this.lvHangMua.GridLines = true;
            this.lvHangMua.HideSelection = false;
            this.lvHangMua.Location = new System.Drawing.Point(4, 21);
            this.lvHangMua.Name = "lvHangMua";
            this.lvHangMua.Size = new System.Drawing.Size(750, 314);
            this.lvHangMua.TabIndex = 1;
            this.lvHangMua.UseCompatibleStateImageBehavior = false;
            this.lvHangMua.View = System.Windows.Forms.View.Details;
            // 
            // chSTT
            // 
            this.chSTT.Text = "STT";
            this.chSTT.Width = 50;
            // 
            // chNhomHang
            // 
            this.chNhomHang.Text = "Nhóm hàng";
            this.chNhomHang.Width = 80;
            // 
            // chTen
            // 
            this.chTen.Text = "Tên hàng";
            this.chTen.Width = 150;
            // 
            // chDVT
            // 
            this.chDVT.Text = "Đơn vị tính";
            this.chDVT.Width = 90;
            // 
            // chSoLuong
            // 
            this.chSoLuong.Text = "Số lượng";
            this.chSoLuong.Width = 90;
            // 
            // chDonGia
            // 
            this.chDonGia.Text = "Đơn giá";
            this.chDonGia.Width = 90;
            // 
            // chThanhTien
            // 
            this.chThanhTien.Text = "Thành tiền";
            this.chThanhTien.Width = 110;
            // 
            // cmsDsHangMua
            // 
            this.cmsDsHangMua.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBoHang,
            this.tsmiXoaBot});
            this.cmsDsHangMua.Name = "cmsDsHangMua";
            this.cmsDsHangMua.Size = new System.Drawing.Size(119, 48);
            // 
            // tsmiBoHang
            // 
            this.tsmiBoHang.Name = "tsmiBoHang";
            this.tsmiBoHang.Size = new System.Drawing.Size(118, 22);
            this.tsmiBoHang.Text = "Bỏ hàng";
            this.tsmiBoHang.Click += new System.EventHandler(this.tsmiBoHang_Click);
            // 
            // tsmiXoaBot
            // 
            this.tsmiXoaBot.Name = "tsmiXoaBot";
            this.tsmiXoaBot.Size = new System.Drawing.Size(118, 22);
            this.tsmiXoaBot.Text = "Xóa bớt";
            this.tsmiXoaBot.Click += new System.EventHandler(this.tsmiXoaBot_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(763, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 695);
            this.panel3.TabIndex = 0;
            // 
            // dtpNgayMua
            // 
            this.dtpNgayMua.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayMua.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMua.Location = new System.Drawing.Point(20, 210);
            this.dtpNgayMua.Name = "dtpNgayMua";
            this.dtpNgayMua.Size = new System.Drawing.Size(204, 23);
            this.dtpNgayMua.TabIndex = 2;
            // 
            // chbInHoaDon
            // 
            this.chbInHoaDon.AutoSize = true;
            this.chbInHoaDon.Location = new System.Drawing.Point(42, 516);
            this.chbInHoaDon.Name = "chbInHoaDon";
            this.chbInHoaDon.Size = new System.Drawing.Size(84, 17);
            this.chbInHoaDon.TabIndex = 7;
            this.chbInHoaDon.Text = "In Hóa Đơn ";
            this.chbInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Location = new System.Drawing.Point(334, 510);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(75, 23);
            this.btnHoanTat.TabIndex = 8;
            this.btnHoanTat.Text = "Hoàn tất";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // tbThanhTien
            // 
            this.tbThanhTien.Location = new System.Drawing.Point(20, 371);
            this.tbThanhTien.Name = "tbThanhTien";
            this.tbThanhTien.ReadOnly = true;
            this.tbThanhTien.Size = new System.Drawing.Size(133, 20);
            this.tbThanhTien.TabIndex = 10;
            this.tbThanhTien.Text = "0";
            // 
            // tbTongTien
            // 
            this.tbTongTien.Location = new System.Drawing.Point(20, 295);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.ReadOnly = true;
            this.tbTongTien.Size = new System.Drawing.Size(133, 20);
            this.tbTongTien.TabIndex = 10;
            this.tbTongTien.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(152, 374);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 17);
            this.label16.TabIndex = 9;
            this.label16.Text = "đồng";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(152, 298);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 17);
            this.label15.TabIndex = 9;
            this.label15.Text = "đồng";
            // 
            // tbKhachDua
            // 
            this.tbKhachDua.Location = new System.Drawing.Point(271, 371);
            this.tbKhachDua.Name = "tbKhachDua";
            this.tbKhachDua.Size = new System.Drawing.Size(133, 20);
            this.tbKhachDua.TabIndex = 4;
            this.tbKhachDua.Text = "0";
            this.tbKhachDua.Validating += new System.ComponentModel.CancelEventHandler(this.tbKhachDua_Validating);
            // 
            // tbTenKhachMua
            // 
            this.tbTenKhachMua.Location = new System.Drawing.Point(20, 98);
            this.tbTenKhachMua.Name = "tbTenKhachMua";
            this.tbTenKhachMua.Size = new System.Drawing.Size(204, 20);
            this.tbTenKhachMua.TabIndex = 0;
            // 
            // cbHinhThuc
            // 
            this.cbHinhThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHinhThuc.FormattingEnabled = true;
            this.cbHinhThuc.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản"});
            this.cbHinhThuc.Location = new System.Drawing.Point(19, 458);
            this.cbHinhThuc.Name = "cbHinhThuc";
            this.cbHinhThuc.Size = new System.Drawing.Size(205, 24);
            this.cbHinhThuc.TabIndex = 5;
            this.cbHinhThuc.Text = "Chọn hình thức";
            this.cbHinhThuc.SelectedIndexChanged += new System.EventHandler(this.cbHinhThuc_SelectedIndexChanged);
            // 
            // cbNhanVienLap
            // 
            this.cbNhanVienLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhanVienLap.FormattingEnabled = true;
            this.cbNhanVienLap.Location = new System.Drawing.Point(270, 210);
            this.cbNhanVienLap.Name = "cbNhanVienLap";
            this.cbNhanVienLap.Size = new System.Drawing.Size(205, 24);
            this.cbNhanVienLap.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhân viên lập:";
            // 
            // dgvDSHang
            // 
            this.dgvDSHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaNhom,
            this.MaHang,
            this.TenHang,
            this.DVT,
            this.DonGia});
            this.dgvDSHang.ContextMenuStrip = this.DsHang;
            this.dgvDSHang.Location = new System.Drawing.Point(202, 71);
            this.dgvDSHang.Name = "dgvDSHang";
            this.dgvDSHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSHang.Size = new System.Drawing.Size(552, 277);
            this.dgvDSHang.TabIndex = 4;
            this.dgvDSHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHang_CellDoubleClick);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // MaNhom
            // 
            this.MaNhom.DataPropertyName = "MaNhom";
            this.MaNhom.HeaderText = "Mã nhóm";
            this.MaNhom.Name = "MaNhom";
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "Mã hàng";
            this.MaHang.Name = "MaHang";
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "TenHang";
            this.TenHang.HeaderText = "Tên hàng";
            this.TenHang.Name = "TenHang";
            this.TenHang.Width = 150;
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.Name = "DVT";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            // 
            // DsHang
            // 
            this.DsHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiXoa,
            this.tsmiSua});
            this.DsHang.Name = "DsHang";
            this.DsHang.Size = new System.Drawing.Size(95, 48);
            // 
            // tsmiXoa
            // 
            this.tsmiXoa.Name = "tsmiXoa";
            this.tsmiXoa.Size = new System.Drawing.Size(94, 22);
            this.tsmiXoa.Text = "Xóa";
            this.tsmiXoa.Click += new System.EventHandler(this.tsmiXoa_Click);
            // 
            // tsmiSua
            // 
            this.tsmiSua.Name = "tsmiSua";
            this.tsmiSua.Size = new System.Drawing.Size(94, 22);
            this.tsmiSua.Text = "Sửa";
            this.tsmiSua.Click += new System.EventHandler(this.tsmiSua_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 56);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Danh mục mặt hàng";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(403, 374);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 17);
            this.label17.TabIndex = 4;
            this.label17.Text = "đồng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Hình thức thanh toán:";
            // 
            // lbConLai
            // 
            this.lbConLai.AutoSize = true;
            this.lbConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConLai.Location = new System.Drawing.Point(331, 423);
            this.lbConLai.Name = "lbConLai";
            this.lbConLai.Size = new System.Drawing.Size(16, 17);
            this.lbConLai.TabIndex = 4;
            this.lbConLai.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(267, 423);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Còn lại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(267, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Khách đưa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Thành tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng tiền:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(267, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Số điện thoại:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Tên khách mua:";
            // 
            // flpDanhMuc
            // 
            this.flpDanhMuc.ContextMenuStrip = this.DsHang;
            this.flpDanhMuc.Location = new System.Drawing.Point(6, 71);
            this.flpDanhMuc.Name = "flpDanhMuc";
            this.flpDanhMuc.Size = new System.Drawing.Size(190, 277);
            this.flpDanhMuc.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(267, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Giảm giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày bán:";
            // 
            // MuaHangUC
            // 
            this.MuaHangUC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MuaHangUC.Controls.Add(this.panel4);
            this.MuaHangUC.Controls.Add(this.panel2);
            this.MuaHangUC.Controls.Add(this.panel1);
            this.MuaHangUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MuaHangUC.Location = new System.Drawing.Point(0, 0);
            this.MuaHangUC.Name = "MuaHangUC";
            this.MuaHangUC.Size = new System.Drawing.Size(1264, 699);
            this.MuaHangUC.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nudGiamGia);
            this.panel4.Controls.Add(this.mtbSDT);
            this.panel4.Controls.Add(this.dtpNgayMua);
            this.panel4.Controls.Add(this.chbInHoaDon);
            this.panel4.Controls.Add(this.btnChuyenKhoan);
            this.panel4.Controls.Add(this.btnThoat);
            this.panel4.Controls.Add(this.btnHoanTat);
            this.panel4.Controls.Add(this.tbThanhTien);
            this.panel4.Controls.Add(this.tbTongTien);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.tbKhachDua);
            this.panel4.Controls.Add(this.tbTenKhachMua);
            this.panel4.Controls.Add(this.cbHinhThuc);
            this.panel4.Controls.Add(this.cbNhanVienLap);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.lbConLai);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(769, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(490, 693);
            this.panel4.TabIndex = 0;
            // 
            // nudGiamGia
            // 
            this.nudGiamGia.Location = new System.Drawing.Point(271, 296);
            this.nudGiamGia.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudGiamGia.Name = "nudGiamGia";
            this.nudGiamGia.Size = new System.Drawing.Size(51, 20);
            this.nudGiamGia.TabIndex = 11;
            // 
            // mtbSDT
            // 
            this.mtbSDT.BeepOnError = true;
            this.mtbSDT.Location = new System.Drawing.Point(270, 98);
            this.mtbSDT.Mask = "0000000000";
            this.mtbSDT.Name = "mtbSDT";
            this.mtbSDT.Size = new System.Drawing.Size(204, 20);
            this.mtbSDT.TabIndex = 1;
            this.mtbSDT.Validating += new System.ComponentModel.CancelEventHandler(this.mtbSDT_Validating);
            // 
            // btnChuyenKhoan
            // 
            this.btnChuyenKhoan.Enabled = false;
            this.btnChuyenKhoan.Location = new System.Drawing.Point(286, 459);
            this.btnChuyenKhoan.Name = "btnChuyenKhoan";
            this.btnChuyenKhoan.Size = new System.Drawing.Size(171, 23);
            this.btnChuyenKhoan.TabIndex = 6;
            this.btnChuyenKhoan.Text = "Thông tin chuyển khoản";
            this.btnChuyenKhoan.UseVisualStyleBackColor = true;
            this.btnChuyenKhoan.Click += new System.EventHandler(this.btnChuyenKhoan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(218, 661);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(327, 295);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thông tin hóa đơn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.tbTimKiem);
            this.panel2.Controls.Add(this.btnThemDM);
            this.panel2.Controls.Add(this.btnThemHang);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.flpDanhMuc);
            this.panel2.Controls.Add(this.dgvDSHang);
            this.panel2.Location = new System.Drawing.Point(3, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 351);
            this.panel2.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(260, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Tìm kiếm mặt hàng";
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(362, 24);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(251, 20);
            this.tbTimKiem.TabIndex = 2;
            this.tbTimKiem.Text = "Nhập tên hàng ";
            this.tbTimKiem.TextChanged += new System.EventHandler(this.tbTimKiem_TextChanged);
            // 
            // btnThemDM
            // 
            this.btnThemDM.Location = new System.Drawing.Point(176, 49);
            this.btnThemDM.Name = "btnThemDM";
            this.btnThemDM.Size = new System.Drawing.Size(20, 23);
            this.btnThemDM.TabIndex = 9;
            this.btnThemDM.Text = "+";
            this.btnThemDM.UseVisualStyleBackColor = true;
            this.btnThemDM.Click += new System.EventHandler(this.btnThemDM_Click);
            // 
            // btnThemHang
            // 
            this.btnThemHang.Location = new System.Drawing.Point(734, 49);
            this.btnThemHang.Name = "btnThemHang";
            this.btnThemHang.Size = new System.Drawing.Size(20, 23);
            this.btnThemHang.TabIndex = 9;
            this.btnThemHang.Text = "+";
            this.btnThemHang.UseVisualStyleBackColor = true;
            this.btnThemHang.Click += new System.EventHandler(this.btnThemHang_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTimDanhMuc);
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 46);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm danh mục";
            // 
            // tbTimDanhMuc
            // 
            this.tbTimDanhMuc.Location = new System.Drawing.Point(9, 19);
            this.tbTimDanhMuc.Name = "tbTimDanhMuc";
            this.tbTimDanhMuc.Size = new System.Drawing.Size(175, 20);
            this.tbTimDanhMuc.TabIndex = 2;
            this.tbTimDanhMuc.Text = "Nhập danh mục";
            this.tbTimDanhMuc.TextChanged += new System.EventHandler(this.tbTimDanhMuc_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(199, 54);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "Danh sách mặt hàng";
            // 
            // frmMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 699);
            this.Controls.Add(this.MuaHangUC);
            this.Name = "frmMuaHang";
            this.Text = "Mua Hàng";
            this.Load += new System.EventHandler(this.frmMuaHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cmsDsHangMua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHang)).EndInit();
            this.DsHang.ResumeLayout(false);
            this.MuaHangUC.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader chIDHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvHangMua;
        private System.Windows.Forms.ColumnHeader chSTT;
        private System.Windows.Forms.ColumnHeader chNhomHang;
        private System.Windows.Forms.ColumnHeader chTen;
        private System.Windows.Forms.ColumnHeader chDVT;
        private System.Windows.Forms.ColumnHeader chSoLuong;
        private System.Windows.Forms.ColumnHeader chDonGia;
        private System.Windows.Forms.ColumnHeader chThanhTien;
        private System.Windows.Forms.ContextMenuStrip cmsDsHangMua;
        private System.Windows.Forms.ToolStripMenuItem tsmiBoHang;
        private System.Windows.Forms.ToolStripMenuItem tsmiXoaBot;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpNgayMua;
        private System.Windows.Forms.CheckBox chbInHoaDon;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.TextBox tbThanhTien;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbKhachDua;
        private System.Windows.Forms.TextBox tbTenKhachMua;
        private System.Windows.Forms.ComboBox cbHinhThuc;
        private System.Windows.Forms.ComboBox cbNhanVienLap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDSHang;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbConLai;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel flpDanhMuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel MuaHangUC;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThemDM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbTimDanhMuc;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox mtbSDT;
        private System.Windows.Forms.Button btnChuyenKhoan;
        private System.Windows.Forms.ContextMenuStrip DsHang;
        private System.Windows.Forms.ToolStripMenuItem tsmiXoa;
        private System.Windows.Forms.ToolStripMenuItem tsmiSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.Button btnThemHang;
        private System.Windows.Forms.NumericUpDown nudGiamGia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label18;
    }
}