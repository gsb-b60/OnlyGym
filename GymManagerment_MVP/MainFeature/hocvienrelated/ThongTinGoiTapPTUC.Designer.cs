namespace GymManagerment_MVP.MainFeature.HocVienRelated
{
    partial class ThongTinGoiTapPTUC
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
            this.gbThongTinPT = new System.Windows.Forms.GroupBox();
            this.lvThongTinPT = new System.Windows.Forms.ListView();
            this.chTenPT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTenGoiTap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNgayDangKy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTrangThaiHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEND = new System.Windows.Forms.CheckBox();
            this.cbH = new System.Windows.Forms.CheckBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.gbLastCheck = new System.Windows.Forms.GroupBox();
            this.dtpDenCheckin = new System.Windows.Forms.DateTimePicker();
            this.btnLoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTu = new System.Windows.Forms.Label();
            this.dtpTuCheckin = new System.Windows.Forms.DateTimePicker();
            this.chGiaTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoa = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.gbThongTinPT.SuspendLayout();
            this.gbLastCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbThongTinPT
            // 
            this.gbThongTinPT.Controls.Add(this.checkBox2);
            this.gbThongTinPT.Controls.Add(this.checkBox1);
            this.gbThongTinPT.Controls.Add(this.btnXoa);
            this.gbThongTinPT.Controls.Add(this.chEND);
            this.gbThongTinPT.Controls.Add(this.cbH);
            this.gbThongTinPT.Controls.Add(this.lblTrangThai);
            this.gbThongTinPT.Controls.Add(this.gbLastCheck);
            this.gbThongTinPT.Controls.Add(this.lvThongTinPT);
            this.gbThongTinPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbThongTinPT.Location = new System.Drawing.Point(0, 0);
            this.gbThongTinPT.Name = "gbThongTinPT";
            this.gbThongTinPT.Size = new System.Drawing.Size(1137, 324);
            this.gbThongTinPT.TabIndex = 8;
            this.gbThongTinPT.TabStop = false;
            this.gbThongTinPT.Text = "Thông tin đăng ký PT";
            // 
            // lvThongTinPT
            // 
            this.lvThongTinPT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTenPT,
            this.chTenGoiTap,
            this.chNgayDangKy,
            this.chTrangThaiHD,
            this.chNotes,
            this.chGiaTien});
            this.lvThongTinPT.Dock = System.Windows.Forms.DockStyle.Right;
            this.lvThongTinPT.GridLines = true;
            this.lvThongTinPT.HideSelection = false;
            this.lvThongTinPT.Location = new System.Drawing.Point(152, 16);
            this.lvThongTinPT.Name = "lvThongTinPT";
            this.lvThongTinPT.Size = new System.Drawing.Size(982, 305);
            this.lvThongTinPT.TabIndex = 0;
            this.lvThongTinPT.UseCompatibleStateImageBehavior = false;
            this.lvThongTinPT.View = System.Windows.Forms.View.Details;
            // 
            // chTenPT
            // 
            this.chTenPT.Text = "Tên PT";
            this.chTenPT.Width = 145;
            // 
            // chTenGoiTap
            // 
            this.chTenGoiTap.Text = "Tên Gói Tập";
            this.chTenGoiTap.Width = 141;
            // 
            // chNgayDangKy
            // 
            this.chNgayDangKy.Text = "Ngày Đăng Ký";
            this.chNgayDangKy.Width = 190;
            // 
            // chTrangThaiHD
            // 
            this.chTrangThaiHD.Text = "Trạng Thái Hợp Đồng";
            this.chTrangThaiHD.Width = 156;
            // 
            // chNotes
            // 
            this.chNotes.Text = "Notes";
            this.chNotes.Width = 202;
            // 
            // chEND
            // 
            this.chEND.AutoSize = true;
            this.chEND.Location = new System.Drawing.Point(9, 72);
            this.chEND.Name = "chEND";
            this.chEND.Size = new System.Drawing.Size(114, 17);
            this.chEND.TabIndex = 48;
            this.chEND.Text = "Chưa Hoàn Thành";
            this.chEND.UseVisualStyleBackColor = true;
            // 
            // cbH
            // 
            this.cbH.AutoSize = true;
            this.cbH.Location = new System.Drawing.Point(9, 49);
            this.cbH.Name = "cbH";
            this.cbH.Size = new System.Drawing.Size(86, 17);
            this.cbH.TabIndex = 47;
            this.cbH.Text = "Hoàn Thành";
            this.cbH.UseVisualStyleBackColor = true;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(6, 33);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(59, 13);
            this.lblTrangThai.TabIndex = 46;
            this.lblTrangThai.Text = "Trạng Thái";
            // 
            // gbLastCheck
            // 
            this.gbLastCheck.Controls.Add(this.dtpDenCheckin);
            this.gbLastCheck.Controls.Add(this.btnLoc);
            this.gbLastCheck.Controls.Add(this.label1);
            this.gbLastCheck.Controls.Add(this.lblTu);
            this.gbLastCheck.Controls.Add(this.dtpTuCheckin);
            this.gbLastCheck.Location = new System.Drawing.Point(9, 157);
            this.gbLastCheck.Name = "gbLastCheck";
            this.gbLastCheck.Size = new System.Drawing.Size(131, 131);
            this.gbLastCheck.TabIndex = 45;
            this.gbLastCheck.TabStop = false;
            this.gbLastCheck.Text = "Thời Gian Đăng Ký";
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
            // chGiaTien
            // 
            this.chGiaTien.Text = "Giá Tiền";
            this.chGiaTien.Width = 80;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(15, 292);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(131, 23);
            this.btnXoa.TabIndex = 49;
            this.btnXoa.Text = "Xóa tất cả";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 95);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(52, 17);
            this.checkBox1.TabIndex = 50;
            this.checkBox1.Text = "Dừng";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 118);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(45, 17);
            this.checkBox2.TabIndex = 51;
            this.checkBox2.Text = "Hủy";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // ThongTinGoiTapUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbThongTinPT);
            this.Name = "ThongTinGoiTapUC";
            this.Size = new System.Drawing.Size(1137, 324);
            this.gbThongTinPT.ResumeLayout(false);
            this.gbThongTinPT.PerformLayout();
            this.gbLastCheck.ResumeLayout(false);
            this.gbLastCheck.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongTinPT;
        private System.Windows.Forms.ListView lvThongTinPT;
        private System.Windows.Forms.ColumnHeader chTenPT;
        private System.Windows.Forms.ColumnHeader chTenGoiTap;
        private System.Windows.Forms.ColumnHeader chNgayDangKy;
        private System.Windows.Forms.ColumnHeader chTrangThaiHD;
        private System.Windows.Forms.ColumnHeader chNotes;
        private System.Windows.Forms.CheckBox chEND;
        private System.Windows.Forms.CheckBox cbH;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.GroupBox gbLastCheck;
        private System.Windows.Forms.DateTimePicker dtpDenCheckin;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtpTuCheckin;
        private System.Windows.Forms.ColumnHeader chGiaTien;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnXoa;
    }
}
