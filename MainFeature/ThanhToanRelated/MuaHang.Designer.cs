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
            this.cmsDsHangMua = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiBoHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXoaBot = new System.Windows.Forms.ToolStripMenuItem();
            this.MuaHangUC = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpNgayMua = new System.Windows.Forms.DateTimePicker();
            this.chbInHoaDon = new System.Windows.Forms.CheckBox();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.tbThanhTien = new System.Windows.Forms.TextBox();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbSDTKhanhMua = new System.Windows.Forms.TextBox();
            this.tbGiamGia = new System.Windows.Forms.TextBox();
            this.tbKhachDua = new System.Windows.Forms.TextBox();
            this.tbTenKhanhMua = new System.Windows.Forms.TextBox();
            this.cbHinhThuc = new System.Windows.Forms.ComboBox();
            this.cbNhanVienLap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbConLai = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThemDM = new System.Windows.Forms.Button();
            this.btnThemHang = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTimDanhMuc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTimTheo = new System.Windows.Forms.ComboBox();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.flpDanhMuc = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvDSHang = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lvHangMua = new System.Windows.Forms.ListView();
            this.chSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIDHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNhomHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDVT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmsDsHangMua.SuspendLayout();
            this.MuaHangUC.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsDsHangMua
            // 
            this.cmsDsHangMua.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBoHang,
            this.tsmiXoaBot});
            this.cmsDsHangMua.Name = "cmsDsHangMua";
            this.cmsDsHangMua.Size = new System.Drawing.Size(119, 48);
            this.cmsDsHangMua.Opening += new System.ComponentModel.CancelEventHandler(this.cmsDsHangMua_Opening);
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
            // MuaHangUC
            // 
            this.MuaHangUC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MuaHangUC.Controls.Add(this.panel4);
            this.MuaHangUC.Controls.Add(this.panel2);
            this.MuaHangUC.Controls.Add(this.panel1);
            this.MuaHangUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MuaHangUC.Location = new System.Drawing.Point(0, 0);
            this.MuaHangUC.Name = "MuaHangUC";
            this.MuaHangUC.Size = new System.Drawing.Size(1264, 703);
            this.MuaHangUC.TabIndex = 28;
            this.MuaHangUC.Paint += new System.Windows.Forms.PaintEventHandler(this.MuaHangUC_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtpNgayMua);
            this.panel4.Controls.Add(this.chbInHoaDon);
            this.panel4.Controls.Add(this.btnHoanTat);
            this.panel4.Controls.Add(this.tbThanhTien);
            this.panel4.Controls.Add(this.tbTongTien);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.tbSDTKhanhMua);
            this.panel4.Controls.Add(this.tbGiamGia);
            this.panel4.Controls.Add(this.tbKhachDua);
            this.panel4.Controls.Add(this.tbTenKhanhMua);
            this.panel4.Controls.Add(this.cbHinhThuc);
            this.panel4.Controls.Add(this.cbNhanVienLap);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.lbConLai);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label8);
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
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // dtpNgayMua
            // 
            this.dtpNgayMua.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayMua.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMua.Location = new System.Drawing.Point(20, 210);
            this.dtpNgayMua.Name = "dtpNgayMua";
            this.dtpNgayMua.Size = new System.Drawing.Size(204, 23);
            this.dtpNgayMua.TabIndex = 14;
            this.dtpNgayMua.ValueChanged += new System.EventHandler(this.dtpNgayMua_ValueChanged);
            // 
            // chbInHoaDon
            // 
            this.chbInHoaDon.AutoSize = true;
            this.chbInHoaDon.Location = new System.Drawing.Point(42, 516);
            this.chbInHoaDon.Name = "chbInHoaDon";
            this.chbInHoaDon.Size = new System.Drawing.Size(84, 17);
            this.chbInHoaDon.TabIndex = 13;
            this.chbInHoaDon.Text = "In Hóa Đơn ";
            this.chbInHoaDon.UseVisualStyleBackColor = true;
            this.chbInHoaDon.CheckedChanged += new System.EventHandler(this.chbInHoaDon_CheckedChanged);
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Location = new System.Drawing.Point(334, 510);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(75, 23);
            this.btnHoanTat.TabIndex = 12;
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
            this.tbThanhTien.TextChanged += new System.EventHandler(this.tbThanhTien_TextChanged);
            // 
            // tbTongTien
            // 
            this.tbTongTien.Location = new System.Drawing.Point(20, 295);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.ReadOnly = true;
            this.tbTongTien.Size = new System.Drawing.Size(133, 20);
            this.tbTongTien.TabIndex = 10;
            this.tbTongTien.Text = "0";
            this.tbTongTien.TextChanged += new System.EventHandler(this.tbTongTien_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(152, 374);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 17);
            this.label16.TabIndex = 9;
            this.label16.Text = ".000 đồng";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(152, 298);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 17);
            this.label15.TabIndex = 9;
            this.label15.Text = ".000 đồng";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // tbSDTKhanhMua
            // 
            this.tbSDTKhanhMua.Location = new System.Drawing.Point(270, 98);
            this.tbSDTKhanhMua.Name = "tbSDTKhanhMua";
            this.tbSDTKhanhMua.Size = new System.Drawing.Size(204, 20);
            this.tbSDTKhanhMua.TabIndex = 8;
            this.tbSDTKhanhMua.TextChanged += new System.EventHandler(this.tbSDTKhanhMua_TextChanged);
            // 
            // tbGiamGia
            // 
            this.tbGiamGia.Location = new System.Drawing.Point(271, 295);
            this.tbGiamGia.Name = "tbGiamGia";
            this.tbGiamGia.Size = new System.Drawing.Size(204, 20);
            this.tbGiamGia.TabIndex = 8;
            this.tbGiamGia.Text = "0";
            this.tbGiamGia.TextChanged += new System.EventHandler(this.tbGiamGia_TextChanged);
            // 
            // tbKhachDua
            // 
            this.tbKhachDua.Location = new System.Drawing.Point(271, 371);
            this.tbKhachDua.Name = "tbKhachDua";
            this.tbKhachDua.Size = new System.Drawing.Size(133, 20);
            this.tbKhachDua.TabIndex = 8;
            this.tbKhachDua.Text = "0";
            this.tbKhachDua.TextChanged += new System.EventHandler(this.tbKhachDua_TextChanged);
            // 
            // tbTenKhanhMua
            // 
            this.tbTenKhanhMua.Location = new System.Drawing.Point(20, 98);
            this.tbTenKhanhMua.Name = "tbTenKhanhMua";
            this.tbTenKhanhMua.Size = new System.Drawing.Size(204, 20);
            this.tbTenKhanhMua.TabIndex = 8;
            this.tbTenKhanhMua.TextChanged += new System.EventHandler(this.tbTenKhanhMua_TextChanged);
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
            this.cbHinhThuc.TabIndex = 7;
            this.cbHinhThuc.SelectedIndexChanged += new System.EventHandler(this.cbHinhThuc_SelectedIndexChanged);
            // 
            // cbNhanVienLap
            // 
            this.cbNhanVienLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhanVienLap.FormattingEnabled = true;
            this.cbNhanVienLap.Location = new System.Drawing.Point(270, 210);
            this.cbNhanVienLap.Name = "cbNhanVienLap";
            this.cbNhanVienLap.Size = new System.Drawing.Size(205, 24);
            this.cbNhanVienLap.TabIndex = 7;
            this.cbNhanVienLap.SelectedIndexChanged += new System.EventHandler(this.cbNhanVienLap_SelectedIndexChanged);
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
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(403, 374);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 17);
            this.label17.TabIndex = 4;
            this.label17.Text = ".000 đồng";
            this.label17.Click += new System.EventHandler(this.label17_Click);
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
            this.label9.Click += new System.EventHandler(this.label9_Click);
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
            this.lbConLai.Click += new System.EventHandler(this.lbConLai_Click);
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
            this.label13.Click += new System.EventHandler(this.label13_Click);
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
            this.label8.Click += new System.EventHandler(this.label8_Click);
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
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            this.label11.Click += new System.EventHandler(this.label11_Click);
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
            this.label10.Click += new System.EventHandler(this.label10_Click);
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThemDM);
            this.panel2.Controls.Add(this.btnThemHang);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.flpDanhMuc);
            this.panel2.Controls.Add(this.dgvDSHang);
            this.panel2.Location = new System.Drawing.Point(3, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 351);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTimTheo);
            this.groupBox1.Controls.Add(this.tbTimKiem);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Location = new System.Drawing.Point(202, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 46);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm mặt hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbTimTheo
            // 
            this.cbTimTheo.FormattingEnabled = true;
            this.cbTimTheo.Items.AddRange(new object[] {
            "Theo mã hàng",
            "Theo tên hàng"});
            this.cbTimTheo.Location = new System.Drawing.Point(17, 18);
            this.cbTimTheo.Name = "cbTimTheo";
            this.cbTimTheo.Size = new System.Drawing.Size(179, 21);
            this.cbTimTheo.TabIndex = 1;
            this.cbTimTheo.Text = "Tìm theo";
            this.cbTimTheo.SelectedIndexChanged += new System.EventHandler(this.cbTimTheo_SelectedIndexChanged);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(202, 20);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(262, 20);
            this.tbTimKiem.TabIndex = 2;
            this.tbTimKiem.Text = "Nhập tên hàng ";
            this.tbTimKiem.TextChanged += new System.EventHandler(this.tbTimKiem_TextChanged);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(470, 18);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
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
            this.label19.Click += new System.EventHandler(this.label19_Click);
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
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // flpDanhMuc
            // 
            this.flpDanhMuc.Location = new System.Drawing.Point(6, 71);
            this.flpDanhMuc.Name = "flpDanhMuc";
            this.flpDanhMuc.Size = new System.Drawing.Size(190, 277);
            this.flpDanhMuc.TabIndex = 5;
            this.flpDanhMuc.Paint += new System.Windows.Forms.PaintEventHandler(this.flpDanhMuc_Paint);
            // 
            // dgvDSHang
            // 
            this.dgvDSHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHang,
            this.TenHang,
            this.DVT,
            this.DonGia});
            this.dgvDSHang.ContextMenuStrip = this.cmsDsHangMua;
            this.dgvDSHang.Location = new System.Drawing.Point(202, 71);
            this.dgvDSHang.Name = "dgvDSHang";
            this.dgvDSHang.Size = new System.Drawing.Size(552, 277);
            this.dgvDSHang.TabIndex = 4;
            this.dgvDSHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHang_CellContentClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // MaHang
            // 
            this.MaHang.HeaderText = "Mã hàng";
            this.MaHang.Name = "MaHang";
            // 
            // TenHang
            // 
            this.TenHang.HeaderText = "Tên hàng";
            this.TenHang.Name = "TenHang";
            this.TenHang.Width = 150;
            // 
            // DVT
            // 
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.Name = "DVT";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
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
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách hàng mua";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.lvHangMua.GridLines = true;
            this.lvHangMua.HideSelection = false;
            this.lvHangMua.Location = new System.Drawing.Point(4, 21);
            this.lvHangMua.Name = "lvHangMua";
            this.lvHangMua.Size = new System.Drawing.Size(750, 314);
            this.lvHangMua.TabIndex = 1;
            this.lvHangMua.UseCompatibleStateImageBehavior = false;
            this.lvHangMua.View = System.Windows.Forms.View.Details;
            this.lvHangMua.SelectedIndexChanged += new System.EventHandler(this.lvHangMua_SelectedIndexChanged);
            // 
            // chSTT
            // 
            this.chSTT.Text = "STT";
            this.chSTT.Width = 50;
            // 
            // chIDHang
            // 
            this.chIDHang.Text = "Mã hàng ";
            this.chIDHang.Width = 80;
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
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(763, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 695);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // MuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MuaHangUC);
            this.Name = "MuaHang";
            this.Size = new System.Drawing.Size(1264, 703);
            this.cmsDsHangMua.ResumeLayout(false);
            this.MuaHangUC.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsDsHangMua;
        private System.Windows.Forms.ToolStripMenuItem tsmiBoHang;
        private System.Windows.Forms.Panel MuaHangUC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbTimDanhMuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTimTheo;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.FlowLayoutPanel flpDanhMuc;
        private System.Windows.Forms.DataGridView dgvDSHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvHangMua;
        private System.Windows.Forms.ColumnHeader chSTT;
        private System.Windows.Forms.ColumnHeader chIDHang;
        private System.Windows.Forms.ColumnHeader chNhomHang;
        private System.Windows.Forms.ColumnHeader chTen;
        private System.Windows.Forms.ColumnHeader chDVT;
        private System.Windows.Forms.ColumnHeader chSoLuong;
        private System.Windows.Forms.ColumnHeader chDonGia;
        private System.Windows.Forms.ColumnHeader chThanhTien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnThemDM;
        private System.Windows.Forms.Button btnThemHang;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox chbInHoaDon;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.TextBox tbThanhTien;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbSDTKhanhMua;
        private System.Windows.Forms.TextBox tbGiamGia;
        private System.Windows.Forms.TextBox tbKhachDua;
        private System.Windows.Forms.TextBox tbTenKhanhMua;
        private System.Windows.Forms.ComboBox cbHinhThuc;
        private System.Windows.Forms.ComboBox cbNhanVienLap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbConLai;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayMua;
        private System.Windows.Forms.ToolStripMenuItem tsmiXoaBot;
    }
}
