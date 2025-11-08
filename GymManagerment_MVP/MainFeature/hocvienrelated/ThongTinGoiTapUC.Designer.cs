namespace GymManagerment_MVP.MainFeature.HocVienRelated
{
    partial class ThongTinGoiTapUC
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
            this.gbThongTinGoiTap = new System.Windows.Forms.GroupBox();
            this.lvTTGoiTap = new System.Windows.Forms.ListView();
            this.chBD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNgayKetThuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chThe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGoiTap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBuoiCon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEND = new System.Windows.Forms.CheckBox();
            this.cbH = new System.Windows.Forms.CheckBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.gbLastCheck = new System.Windows.Forms.GroupBox();
            this.dtpDenCheckin = new System.Windows.Forms.DateTimePicker();
            this.btnLoc = new System.Windows.Forms.Button();
            this.lblDen = new System.Windows.Forms.Label();
            this.lblTu = new System.Windows.Forms.Label();
            this.dtpTuCheckin = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.gbThongTinGoiTap.SuspendLayout();
            this.gbLastCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbThongTinGoiTap
            // 
            this.gbThongTinGoiTap.Controls.Add(this.lvTTGoiTap);
            this.gbThongTinGoiTap.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbThongTinGoiTap.Location = new System.Drawing.Point(194, 0);
            this.gbThongTinGoiTap.Name = "gbThongTinGoiTap";
            this.gbThongTinGoiTap.Size = new System.Drawing.Size(943, 324);
            this.gbThongTinGoiTap.TabIndex = 7;
            this.gbThongTinGoiTap.TabStop = false;
            this.gbThongTinGoiTap.Text = "Thông tin gói tập";
            // 
            // lvTTGoiTap
            // 
            this.lvTTGoiTap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBD,
            this.chNgayKetThuc,
            this.chBuoiCon,
            this.chThe,
            this.chGoiTap,
            this.chTrangThai});
            this.lvTTGoiTap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTTGoiTap.GridLines = true;
            this.lvTTGoiTap.HideSelection = false;
            this.lvTTGoiTap.Location = new System.Drawing.Point(3, 16);
            this.lvTTGoiTap.Margin = new System.Windows.Forms.Padding(100);
            this.lvTTGoiTap.Name = "lvTTGoiTap";
            this.lvTTGoiTap.Size = new System.Drawing.Size(937, 305);
            this.lvTTGoiTap.TabIndex = 0;
            this.lvTTGoiTap.UseCompatibleStateImageBehavior = false;
            this.lvTTGoiTap.View = System.Windows.Forms.View.Details;
            // 
            // chBD
            // 
            this.chBD.Text = "Ngày Bắt Đầu";
            this.chBD.Width = 120;
            // 
            // chNgayKetThuc
            // 
            this.chNgayKetThuc.Text = "Ngày Kết Thúc";
            this.chNgayKetThuc.Width = 118;
            // 
            // chThe
            // 
            this.chThe.DisplayIndex = 2;
            this.chThe.Text = "Thẻ";
            this.chThe.Width = 59;
            // 
            // chGoiTap
            // 
            this.chGoiTap.DisplayIndex = 3;
            this.chGoiTap.Text = "Gói Tập";
            this.chGoiTap.Width = 74;
            // 
            // chTrangThai
            // 
            this.chTrangThai.DisplayIndex = 4;
            this.chTrangThai.Text = "Trạng Thái";
            this.chTrangThai.Width = 131;
            // 
            // chBuoiCon
            // 
            this.chBuoiCon.DisplayIndex = 5;
            this.chBuoiCon.Text = "Buổi Còn Lại";
            this.chBuoiCon.Width = 138;
            // 
            // chEND
            // 
            this.chEND.AutoSize = true;
            this.chEND.Location = new System.Drawing.Point(30, 72);
            this.chEND.Name = "chEND";
            this.chEND.Size = new System.Drawing.Size(93, 17);
            this.chEND.TabIndex = 44;
            this.chEND.Text = "Đang sử dụng";
            this.chEND.UseVisualStyleBackColor = true;
            // 
            // cbH
            // 
            this.cbH.AutoSize = true;
            this.cbH.Location = new System.Drawing.Point(30, 49);
            this.cbH.Name = "cbH";
            this.cbH.Size = new System.Drawing.Size(103, 17);
            this.cbH.TabIndex = 43;
            this.cbH.Text = "Đã Hoàn Thành";
            this.cbH.UseVisualStyleBackColor = true;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(27, 16);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(59, 13);
            this.lblTrangThai.TabIndex = 42;
            this.lblTrangThai.Text = "Trạng Thái";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(30, 292);
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
            this.gbLastCheck.Controls.Add(this.lblDen);
            this.gbLastCheck.Controls.Add(this.lblTu);
            this.gbLastCheck.Controls.Add(this.dtpTuCheckin);
            this.gbLastCheck.Location = new System.Drawing.Point(30, 171);
            this.gbLastCheck.Name = "gbLastCheck";
            this.gbLastCheck.Size = new System.Drawing.Size(131, 102);
            this.gbLastCheck.TabIndex = 40;
            this.gbLastCheck.TabStop = false;
            this.gbLastCheck.Text = "Thời Gian Check In";
            // 
            // dtpDenCheckin
            // 
            this.dtpDenCheckin.CustomFormat = "dd/MM/yyyy";
            this.dtpDenCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenCheckin.Location = new System.Drawing.Point(6, 79);
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
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(3, 63);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(27, 13);
            this.lblDen.TabIndex = 23;
            this.lblDen.Text = "Đến";
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Location = new System.Drawing.Point(3, 24);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(20, 13);
            this.lblTu.TabIndex = 22;
            this.lblTu.Text = "Từ";
            // 
            // dtpTuCheckin
            // 
            this.dtpTuCheckin.CustomFormat = "dd/MM/yyyy";
            this.dtpTuCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuCheckin.Location = new System.Drawing.Point(6, 40);
            this.dtpTuCheckin.Name = "dtpTuCheckin";
            this.dtpTuCheckin.Size = new System.Drawing.Size(105, 20);
            this.dtpTuCheckin.TabIndex = 21;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(30, 95);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 17);
            this.checkBox1.TabIndex = 45;
            this.checkBox1.Text = "pending";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(30, 118);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(96, 17);
            this.checkBox2.TabIndex = 46;
            this.checkBox2.Text = "Chưa Sử Dụng";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(30, 141);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(45, 17);
            this.checkBox3.TabIndex = 47;
            this.checkBox3.Text = "Hủy";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // ThongTinGoiTapUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.chEND);
            this.Controls.Add(this.cbH);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gbLastCheck);
            this.Controls.Add(this.gbThongTinGoiTap);
            this.Name = "ThongTinGoiTapUC";
            this.Size = new System.Drawing.Size(1137, 324);
            this.gbThongTinGoiTap.ResumeLayout(false);
            this.gbLastCheck.ResumeLayout(false);
            this.gbLastCheck.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongTinGoiTap;
        private System.Windows.Forms.ListView lvTTGoiTap;
        private System.Windows.Forms.ColumnHeader chBD;
        private System.Windows.Forms.ColumnHeader chNgayKetThuc;
        private System.Windows.Forms.ColumnHeader chThe;
        private System.Windows.Forms.ColumnHeader chGoiTap;
        private System.Windows.Forms.ColumnHeader chTrangThai;
        private System.Windows.Forms.ColumnHeader chBuoiCon;
        private System.Windows.Forms.CheckBox chEND;
        private System.Windows.Forms.CheckBox cbH;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox gbLastCheck;
        private System.Windows.Forms.DateTimePicker dtpDenCheckin;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtpTuCheckin;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}
