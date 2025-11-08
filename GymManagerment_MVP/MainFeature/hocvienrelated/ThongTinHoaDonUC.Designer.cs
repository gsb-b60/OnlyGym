namespace GymManagerment_MVP.MainFeature.HocVienRelated
{
    partial class ThongTinHoaDonUC
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
            this.gbHoaDonThongTin = new System.Windows.Forms.GroupBox();
            this.chCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTongHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTongTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTrangThaiHoaDon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPhuongThuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvThongTinHoaDon = new System.Windows.Forms.ListView();
            this.chEND = new System.Windows.Forms.CheckBox();
            this.cbH = new System.Windows.Forms.CheckBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.gbLastCheck = new System.Windows.Forms.GroupBox();
            this.dtpDenCheckin = new System.Windows.Forms.DateTimePicker();
            this.btnLoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTu = new System.Windows.Forms.Label();
            this.dtpTuCheckin = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.gbHoaDonThongTin.SuspendLayout();
            this.gbLastCheck.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbHoaDonThongTin
            // 
            this.gbHoaDonThongTin.Controls.Add(this.groupBox1);
            this.gbHoaDonThongTin.Controls.Add(this.checkBox1);
            this.gbHoaDonThongTin.Controls.Add(this.checkBox2);
            this.gbHoaDonThongTin.Controls.Add(this.label2);
            this.gbHoaDonThongTin.Controls.Add(this.chEND);
            this.gbHoaDonThongTin.Controls.Add(this.cbH);
            this.gbHoaDonThongTin.Controls.Add(this.lblTrangThai);
            this.gbHoaDonThongTin.Controls.Add(this.btnXoa);
            this.gbHoaDonThongTin.Controls.Add(this.gbLastCheck);
            this.gbHoaDonThongTin.Controls.Add(this.lvThongTinHoaDon);
            this.gbHoaDonThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHoaDonThongTin.Location = new System.Drawing.Point(0, 0);
            this.gbHoaDonThongTin.Name = "gbHoaDonThongTin";
            this.gbHoaDonThongTin.Size = new System.Drawing.Size(1137, 324);
            this.gbHoaDonThongTin.TabIndex = 6;
            this.gbHoaDonThongTin.TabStop = false;
            this.gbHoaDonThongTin.Text = "Thông Tin Hóa Đơn";
            // 
            // chCode
            // 
            this.chCode.Text = "Hóa đơn #";
            this.chCode.Width = 80;
            // 
            // chDate
            // 
            this.chDate.Text = "Ngày";
            this.chDate.Width = 122;
            // 
            // chTongHang
            // 
            this.chTongHang.Text = "Xem Nhanh Hàng Hóa";
            this.chTongHang.Width = 274;
            // 
            // chTongTien
            // 
            this.chTongTien.Text = "Tổng Tiền";
            this.chTongTien.Width = 67;
            // 
            // chTrangThaiHoaDon
            // 
            this.chTrangThaiHoaDon.Text = "Trạng Thái";
            this.chTrangThaiHoaDon.Width = 86;
            // 
            // chPhuongThuc
            // 
            this.chPhuongThuc.Text = "Phương Thức";
            this.chPhuongThuc.Width = 182;
            // 
            // lvThongTinHoaDon
            // 
            this.lvThongTinHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCode,
            this.chDate,
            this.chTongHang,
            this.chTongTien,
            this.chTrangThaiHoaDon,
            this.chPhuongThuc});
            this.lvThongTinHoaDon.Dock = System.Windows.Forms.DockStyle.Right;
            this.lvThongTinHoaDon.GridLines = true;
            this.lvThongTinHoaDon.HideSelection = false;
            this.lvThongTinHoaDon.Location = new System.Drawing.Point(301, 16);
            this.lvThongTinHoaDon.Name = "lvThongTinHoaDon";
            this.lvThongTinHoaDon.Size = new System.Drawing.Size(833, 305);
            this.lvThongTinHoaDon.TabIndex = 0;
            this.lvThongTinHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvThongTinHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // chEND
            // 
            this.chEND.AutoSize = true;
            this.chEND.Location = new System.Drawing.Point(9, 72);
            this.chEND.Name = "chEND";
            this.chEND.Size = new System.Drawing.Size(114, 17);
            this.chEND.TabIndex = 44;
            this.chEND.Text = "Chưa Hoàn Thành";
            this.chEND.UseVisualStyleBackColor = true;
            // 
            // cbH
            // 
            this.cbH.AutoSize = true;
            this.cbH.Location = new System.Drawing.Point(9, 49);
            this.cbH.Name = "cbH";
            this.cbH.Size = new System.Drawing.Size(148, 17);
            this.cbH.TabIndex = 43;
            this.cbH.Text = "Hoàn Thành Thanh Toán";
            this.cbH.UseVisualStyleBackColor = true;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(6, 16);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(59, 13);
            this.lblTrangThai.TabIndex = 42;
            this.lblTrangThai.Text = "Trạng Thái";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(97, 295);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(131, 23);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xóa tất cả";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // gbLastCheck
            // 
            this.gbLastCheck.Controls.Add(this.dtpDenCheckin);
            this.gbLastCheck.Controls.Add(this.btnLoc);
            this.gbLastCheck.Controls.Add(this.label1);
            this.gbLastCheck.Controls.Add(this.lblTu);
            this.gbLastCheck.Controls.Add(this.dtpTuCheckin);
            this.gbLastCheck.Location = new System.Drawing.Point(9, 142);
            this.gbLastCheck.Name = "gbLastCheck";
            this.gbLastCheck.Size = new System.Drawing.Size(131, 131);
            this.gbLastCheck.TabIndex = 40;
            this.gbLastCheck.TabStop = false;
            this.gbLastCheck.Text = "Thời Gian Mua";
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(159, 72);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 47;
            this.checkBox1.Text = "Tiền Mặt";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(159, 49);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(96, 17);
            this.checkBox2.TabIndex = 46;
            this.checkBox2.Text = "Chuyển Khoản";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Phương Thức";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(159, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 131);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng Giá Trị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Từ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(7, 51);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 24;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(7, 94);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 25;
            // 
            // ThongTinHoaDonUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbHoaDonThongTin);
            this.Name = "ThongTinHoaDonUC";
            this.Size = new System.Drawing.Size(1137, 324);
            this.gbHoaDonThongTin.ResumeLayout(false);
            this.gbHoaDonThongTin.PerformLayout();
            this.gbLastCheck.ResumeLayout(false);
            this.gbLastCheck.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHoaDonThongTin;
        private System.Windows.Forms.ListView lvThongTinHoaDon;
        private System.Windows.Forms.ColumnHeader chCode;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chTongHang;
        private System.Windows.Forms.ColumnHeader chTongTien;
        private System.Windows.Forms.ColumnHeader chTrangThaiHoaDon;
        private System.Windows.Forms.ColumnHeader chPhuongThuc;
        private System.Windows.Forms.CheckBox chEND;
        private System.Windows.Forms.CheckBox cbH;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox gbLastCheck;
        private System.Windows.Forms.DateTimePicker dtpDenCheckin;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtpTuCheckin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
    }
}
