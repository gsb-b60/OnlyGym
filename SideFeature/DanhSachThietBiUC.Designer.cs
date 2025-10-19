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
            this.components = new System.ComponentModel.Container();
            this.btnReloadTB = new System.Windows.Forms.Button();
            this.nThemSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbThemTinhTrang = new System.Windows.Forms.ComboBox();
            this.cbThemViTri = new System.Windows.Forms.ComboBox();
            this.cbThemHang = new System.Windows.Forms.ComboBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsGhiChu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiXoaGhiChu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSuaGhiChu = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTimGhiChu = new System.Windows.Forms.TextBox();
            this.btnTimTheoNgay = new System.Windows.Forms.Button();
            this.btnReloadGC = new System.Windows.Forms.Button();
            this.tbThemTenTB = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblViTri = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblTenTB = new System.Windows.Forms.Label();
            this.dgvGhiChu = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbLocViTri = new System.Windows.Forms.ComboBox();
            this.cbLocTinhTrang = new System.Windows.Forms.ComboBox();
            this.dgvThietBi = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HangSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbLocHang = new System.Windows.Forms.ComboBox();
            this.gbGhiChu = new System.Windows.Forms.GroupBox();
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.tbTimThietBi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nThemSoLuong)).BeginInit();
            this.cmsGhiChu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGhiChu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).BeginInit();
            this.gbGhiChu.SuspendLayout();
            this.gbTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReloadTB
            // 
            this.btnReloadTB.Location = new System.Drawing.Point(2, 81);
            this.btnReloadTB.Name = "btnReloadTB";
            this.btnReloadTB.Size = new System.Drawing.Size(41, 36);
            this.btnReloadTB.TabIndex = 58;
            this.btnReloadTB.Text = "Tải lại";
            this.btnReloadTB.UseVisualStyleBackColor = true;
            // 
            // nThemSoLuong
            // 
            this.nThemSoLuong.Location = new System.Drawing.Point(1046, 28);
            this.nThemSoLuong.Name = "nThemSoLuong";
            this.nThemSoLuong.Size = new System.Drawing.Size(120, 20);
            this.nThemSoLuong.TabIndex = 56;
            // 
            // cbThemTinhTrang
            // 
            this.cbThemTinhTrang.FormattingEnabled = true;
            this.cbThemTinhTrang.Items.AddRange(new object[] {
            "Đang hoạt động",
            "Cần bảo dưỡng",
            "Đang bảo dưỡng",
            "Hỏng, chờ sửa chữa"});
            this.cbThemTinhTrang.Location = new System.Drawing.Point(1046, 74);
            this.cbThemTinhTrang.Name = "cbThemTinhTrang";
            this.cbThemTinhTrang.Size = new System.Drawing.Size(121, 21);
            this.cbThemTinhTrang.TabIndex = 55;
            // 
            // cbThemViTri
            // 
            this.cbThemViTri.FormattingEnabled = true;
            this.cbThemViTri.Items.AddRange(new object[] {
            "Khu Cardio",
            "Khu Tạ Máy",
            "Khu Tạ Tự Do",
            "Phòng Yoga",
            "Quầy lễ tân"});
            this.cbThemViTri.Location = new System.Drawing.Point(782, 104);
            this.cbThemViTri.Name = "cbThemViTri";
            this.cbThemViTri.Size = new System.Drawing.Size(121, 21);
            this.cbThemViTri.TabIndex = 54;
            // 
            // cbThemHang
            // 
            this.cbThemHang.FormattingEnabled = true;
            this.cbThemHang.Items.AddRange(new object[] {
            "Life Fitness",
            "Technogym",
            "Impulse",
            "Rogue",
            "Eleiko",
            "Adidas",
            "InBody",
            "Concept2",
            "Reebok",
            "TRX"});
            this.cbThemHang.Location = new System.Drawing.Point(782, 65);
            this.cbThemHang.Name = "cbThemHang";
            this.cbThemHang.Size = new System.Drawing.Size(121, 21);
            this.cbThemHang.TabIndex = 53;
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(944, 74);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(89, 13);
            this.lblTinhTrang.TabIndex = 51;
            this.lblTinhTrang.Text = "Tình trạng thiết bị";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "STT";
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 35;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "IDTB";
            this.Column7.HeaderText = "ID Thiết Bị";
            this.Column7.Name = "Column7";
            this.Column7.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "VanDe";
            this.dataGridViewTextBoxColumn2.HeaderText = "Vấn đề thiết bị";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NgayGhiChu";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày bảo dưỡng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 115;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "HuongDan";
            this.dataGridViewTextBoxColumn4.HeaderText = "Hướng dẫn bảo dưỡng";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 175;
            // 
            // cmsGhiChu
            // 
            this.cmsGhiChu.AllowDrop = true;
            this.cmsGhiChu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiXoaGhiChu,
            this.tsmiSuaGhiChu});
            this.cmsGhiChu.Name = "cmsGhiChu";
            this.cmsGhiChu.Size = new System.Drawing.Size(138, 48);
            // 
            // tsmiXoaGhiChu
            // 
            this.tsmiXoaGhiChu.Name = "tsmiXoaGhiChu";
            this.tsmiXoaGhiChu.Size = new System.Drawing.Size(137, 22);
            this.tsmiXoaGhiChu.Text = "Xóa ghi chú";
            // 
            // tsmiSuaGhiChu
            // 
            this.tsmiSuaGhiChu.Name = "tsmiSuaGhiChu";
            this.tsmiSuaGhiChu.Size = new System.Drawing.Size(137, 22);
            this.tsmiSuaGhiChu.Text = "Sửa ghi chú";
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.Location = new System.Drawing.Point(439, 17);
            this.dtpNgayKT.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(123, 20);
            this.dtpNgayKT.TabIndex = 17;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(257, 17);
            this.dtpNgayBD.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(120, 20);
            this.dtpNgayBD.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "tới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Từ ngày";
            // 
            // tbTimGhiChu
            // 
            this.tbTimGhiChu.Location = new System.Drawing.Point(9, 19);
            this.tbTimGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.tbTimGhiChu.Name = "tbTimGhiChu";
            this.tbTimGhiChu.Size = new System.Drawing.Size(143, 20);
            this.tbTimGhiChu.TabIndex = 14;
            this.tbTimGhiChu.Text = "Nhập ID thiết bị";
            // 
            // btnTimTheoNgay
            // 
            this.btnTimTheoNgay.Location = new System.Drawing.Point(373, 45);
            this.btnTimTheoNgay.Name = "btnTimTheoNgay";
            this.btnTimTheoNgay.Size = new System.Drawing.Size(75, 23);
            this.btnTimTheoNgay.TabIndex = 23;
            this.btnTimTheoNgay.Text = "Tìm";
            this.btnTimTheoNgay.UseVisualStyleBackColor = true;
            // 
            // btnReloadGC
            // 
            this.btnReloadGC.Location = new System.Drawing.Point(661, 283);
            this.btnReloadGC.Name = "btnReloadGC";
            this.btnReloadGC.Size = new System.Drawing.Size(41, 48);
            this.btnReloadGC.TabIndex = 57;
            this.btnReloadGC.Text = "Tải lại";
            this.btnReloadGC.UseVisualStyleBackColor = true;
            // 
            // tbThemTenTB
            // 
            this.tbThemTenTB.Location = new System.Drawing.Point(782, 24);
            this.tbThemTenTB.Name = "tbThemTenTB";
            this.tbThemTenTB.Size = new System.Drawing.Size(121, 20);
            this.tbThemTenTB.TabIndex = 52;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(944, 28);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(83, 13);
            this.lblSoLuong.TabIndex = 50;
            this.lblSoLuong.Text = "Số lượng thiết bị";
            // 
            // lblViTri
            // 
            this.lblViTri.AutoSize = true;
            this.lblViTri.Location = new System.Drawing.Point(680, 104);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(63, 13);
            this.lblViTri.TabIndex = 49;
            this.lblViTri.Text = "Vị trí thiết bị";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(680, 65);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(79, 13);
            this.lbl.TabIndex = 48;
            this.lbl.Text = "Thông tin hãng";
            // 
            // lblTenTB
            // 
            this.lblTenTB.AutoSize = true;
            this.lblTenTB.Location = new System.Drawing.Point(680, 24);
            this.lblTenTB.Name = "lblTenTB";
            this.lblTenTB.Size = new System.Drawing.Size(60, 13);
            this.lblTenTB.TabIndex = 47;
            this.lblTenTB.Text = "Tên thiết bị";
            // 
            // dgvGhiChu
            // 
            this.dgvGhiChu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGhiChu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column7,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvGhiChu.ContextMenuStrip = this.cmsGhiChu;
            this.dgvGhiChu.Location = new System.Drawing.Point(661, 283);
            this.dgvGhiChu.Name = "dgvGhiChu";
            this.dgvGhiChu.Size = new System.Drawing.Size(565, 295);
            this.dgvGhiChu.TabIndex = 46;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1022, 146);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 42;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(819, 146);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(918, 146);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 44;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // cbLocViTri
            // 
            this.cbLocViTri.FormattingEnabled = true;
            this.cbLocViTri.Items.AddRange(new object[] {
            "<none>",
            "Khu Cardio",
            "Khu Tạ Máy",
            "Khu Tạ Tự Do",
            "Phòng Yoga",
            "Quầy lễ tân"});
            this.cbLocViTri.Location = new System.Drawing.Point(345, 19);
            this.cbLocViTri.Margin = new System.Windows.Forms.Padding(2);
            this.cbLocViTri.Name = "cbLocViTri";
            this.cbLocViTri.Size = new System.Drawing.Size(138, 21);
            this.cbLocViTri.TabIndex = 15;
            this.cbLocViTri.Text = "< Chọn vị trí  >";
            // 
            // cbLocTinhTrang
            // 
            this.cbLocTinhTrang.FormattingEnabled = true;
            this.cbLocTinhTrang.Items.AddRange(new object[] {
            "<none>",
            "Đang hoạt động",
            "Cần bảo dưỡng",
            "Đang bảo dưỡng",
            "Hỏng, chờ sửa chữa"});
            this.cbLocTinhTrang.Location = new System.Drawing.Point(511, 20);
            this.cbLocTinhTrang.Margin = new System.Windows.Forms.Padding(2);
            this.cbLocTinhTrang.Name = "cbLocTinhTrang";
            this.cbLocTinhTrang.Size = new System.Drawing.Size(138, 21);
            this.cbLocTinhTrang.TabIndex = 15;
            this.cbLocTinhTrang.Text = "< Chọn tình trạng >";
            // 
            // dgvThietBi
            // 
            this.dgvThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TenTB,
            this.HangSanXuat,
            this.ViTri,
            this.SoLuong,
            this.TinhTrang});
            this.dgvThietBi.Location = new System.Drawing.Point(2, 81);
            this.dgvThietBi.Name = "dgvThietBi";
            this.dgvThietBi.Size = new System.Drawing.Size(653, 497);
            this.dgvThietBi.TabIndex = 45;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 35;
            // 
            // TenTB
            // 
            this.TenTB.DataPropertyName = "TenTB";
            this.TenTB.HeaderText = "Tên thiết bị";
            this.TenTB.Name = "TenTB";
            this.TenTB.Width = 150;
            // 
            // HangSanXuat
            // 
            this.HangSanXuat.DataPropertyName = "HangSanXuat";
            this.HangSanXuat.HeaderText = "Thông tin hãng";
            this.HangSanXuat.Name = "HangSanXuat";
            // 
            // ViTri
            // 
            this.ViTri.DataPropertyName = "ViTri";
            this.ViTri.HeaderText = "Vị trí thiết bị";
            this.ViTri.Name = "ViTri";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 75;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 150;
            // 
            // cbLocHang
            // 
            this.cbLocHang.FormattingEnabled = true;
            this.cbLocHang.Items.AddRange(new object[] {
            "<none>",
            "Life Fitness",
            "Technogym",
            "Impulse",
            "Rogue",
            "Eleiko",
            "Adidas",
            "InBody",
            "Concept2",
            "Reebok",
            "TRX"});
            this.cbLocHang.Location = new System.Drawing.Point(175, 18);
            this.cbLocHang.Margin = new System.Windows.Forms.Padding(2);
            this.cbLocHang.Name = "cbLocHang";
            this.cbLocHang.Size = new System.Drawing.Size(138, 21);
            this.cbLocHang.TabIndex = 15;
            this.cbLocHang.Text = "< Chọn hãng >";
            // 
            // gbGhiChu
            // 
            this.gbGhiChu.Controls.Add(this.dtpNgayKT);
            this.gbGhiChu.Controls.Add(this.dtpNgayBD);
            this.gbGhiChu.Controls.Add(this.label2);
            this.gbGhiChu.Controls.Add(this.label3);
            this.gbGhiChu.Controls.Add(this.tbTimGhiChu);
            this.gbGhiChu.Controls.Add(this.btnTimTheoNgay);
            this.gbGhiChu.Location = new System.Drawing.Point(661, 197);
            this.gbGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.gbGhiChu.Name = "gbGhiChu";
            this.gbGhiChu.Padding = new System.Windows.Forms.Padding(2);
            this.gbGhiChu.Size = new System.Drawing.Size(566, 68);
            this.gbGhiChu.TabIndex = 41;
            this.gbGhiChu.TabStop = false;
            this.gbGhiChu.Text = "Tìm kiếm/Lọc ghi chú";
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.cbLocViTri);
            this.gbTimKiem.Controls.Add(this.cbLocTinhTrang);
            this.gbTimKiem.Controls.Add(this.cbLocHang);
            this.gbTimKiem.Controls.Add(this.tbTimThietBi);
            this.gbTimKiem.Location = new System.Drawing.Point(1, 4);
            this.gbTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Padding = new System.Windows.Forms.Padding(2);
            this.gbTimKiem.Size = new System.Drawing.Size(653, 58);
            this.gbTimKiem.TabIndex = 40;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm kiếm/Lọc thiết bị";
            // 
            // tbTimThietBi
            // 
            this.tbTimThietBi.Location = new System.Drawing.Point(9, 19);
            this.tbTimThietBi.Margin = new System.Windows.Forms.Padding(2);
            this.tbTimThietBi.Name = "tbTimThietBi";
            this.tbTimThietBi.Size = new System.Drawing.Size(143, 20);
            this.tbTimThietBi.TabIndex = 14;
            this.tbTimThietBi.Text = "Nhập tên thiết bị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Danh sách ghi chú";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(-1, 65);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "Danh sách thiết bị";
            // 
            // DanhSachThietBiUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReloadTB);
            this.Controls.Add(this.nThemSoLuong);
            this.Controls.Add(this.cbThemTinhTrang);
            this.Controls.Add(this.cbThemViTri);
            this.Controls.Add(this.cbThemHang);
            this.Controls.Add(this.lblTinhTrang);
            this.Controls.Add(this.btnReloadGC);
            this.Controls.Add(this.tbThemTenTB);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblViTri);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblTenTB);
            this.Controls.Add(this.dgvGhiChu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvThietBi);
            this.Controls.Add(this.gbGhiChu);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label19);
            this.Name = "DanhSachThietBiUC";
            this.Size = new System.Drawing.Size(1231, 582);
            ((System.ComponentModel.ISupportInitialize)(this.nThemSoLuong)).EndInit();
            this.cmsGhiChu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGhiChu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).EndInit();
            this.gbGhiChu.ResumeLayout(false);
            this.gbGhiChu.PerformLayout();
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReloadTB;
        private System.Windows.Forms.NumericUpDown nThemSoLuong;
        private System.Windows.Forms.ComboBox cbThemTinhTrang;
        private System.Windows.Forms.ComboBox cbThemViTri;
        private System.Windows.Forms.ComboBox cbThemHang;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ContextMenuStrip cmsGhiChu;
        private System.Windows.Forms.ToolStripMenuItem tsmiXoaGhiChu;
        private System.Windows.Forms.ToolStripMenuItem tsmiSuaGhiChu;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTimGhiChu;
        private System.Windows.Forms.Button btnTimTheoNgay;
        private System.Windows.Forms.Button btnReloadGC;
        private System.Windows.Forms.TextBox tbThemTenTB;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblViTri;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblTenTB;
        private System.Windows.Forms.DataGridView dgvGhiChu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbLocViTri;
        private System.Windows.Forms.ComboBox cbLocTinhTrang;
        private System.Windows.Forms.DataGridView dgvThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn HangSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.ComboBox cbLocHang;
        private System.Windows.Forms.GroupBox gbGhiChu;
        private System.Windows.Forms.GroupBox gbTimKiem;
        private System.Windows.Forms.TextBox tbTimThietBi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
    }
}
