namespace GymManagerment_MVP
{
    partial class GiaHan
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
            this.lblNgayGiaHan = new System.Windows.Forms.Label();
            this.dtpNgayGiaHan = new System.Windows.Forms.DateTimePicker();
            this.lblGoiTap = new System.Windows.Forms.Label();
            this.cbGoiTap = new System.Windows.Forms.ComboBox();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.btnInBill = new System.Windows.Forms.Button();
            this.lblKhachDua = new System.Windows.Forms.Label();
            this.tbKhachDua = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.lblThoiTien = new System.Windows.Forms.Label();
            this.tbThoi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNgayGiaHan
            // 
            this.lblNgayGiaHan.AutoSize = true;
            this.lblNgayGiaHan.Location = new System.Drawing.Point(89, 70);
            this.lblNgayGiaHan.Name = "lblNgayGiaHan";
            this.lblNgayGiaHan.Size = new System.Drawing.Size(74, 13);
            this.lblNgayGiaHan.TabIndex = 0;
            this.lblNgayGiaHan.Text = "Ngày Gia Hạn";
            // 
            // dtpNgayGiaHan
            // 
            this.dtpNgayGiaHan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayGiaHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayGiaHan.Location = new System.Drawing.Point(204, 62);
            this.dtpNgayGiaHan.Name = "dtpNgayGiaHan";
            this.dtpNgayGiaHan.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayGiaHan.TabIndex = 1;
            // 
            // lblGoiTap
            // 
            this.lblGoiTap.AutoSize = true;
            this.lblGoiTap.Location = new System.Drawing.Point(89, 130);
            this.lblGoiTap.Name = "lblGoiTap";
            this.lblGoiTap.Size = new System.Drawing.Size(45, 13);
            this.lblGoiTap.TabIndex = 2;
            this.lblGoiTap.Text = "Gói Tập";
            // 
            // cbGoiTap
            // 
            this.cbGoiTap.FormattingEnabled = true;
            this.cbGoiTap.Items.AddRange(new object[] {
            "1 Tháng ",
            "2 Tháng",
            "3 Tháng",
            "6 Tháng",
            "1 Năm",
            "2 Năm",
            "3 Năm"});
            this.cbGoiTap.Location = new System.Drawing.Point(204, 127);
            this.cbGoiTap.Name = "cbGoiTap";
            this.cbGoiTap.Size = new System.Drawing.Size(200, 21);
            this.cbGoiTap.TabIndex = 3;
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.Location = new System.Drawing.Point(329, 481);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(75, 23);
            this.btnGiaHan.TabIndex = 4;
            this.btnGiaHan.Text = "Gia Hạn";
            this.btnGiaHan.UseVisualStyleBackColor = true;
            // 
            // btnInBill
            // 
            this.btnInBill.Location = new System.Drawing.Point(125, 481);
            this.btnInBill.Name = "btnInBill";
            this.btnInBill.Size = new System.Drawing.Size(158, 23);
            this.btnInBill.TabIndex = 5;
            this.btnInBill.Text = "Xuất Hóa Đơn";
            this.btnInBill.UseVisualStyleBackColor = true;
            // 
            // lblKhachDua
            // 
            this.lblKhachDua.AutoSize = true;
            this.lblKhachDua.Location = new System.Drawing.Point(92, 337);
            this.lblKhachDua.Name = "lblKhachDua";
            this.lblKhachDua.Size = new System.Drawing.Size(61, 13);
            this.lblKhachDua.TabIndex = 6;
            this.lblKhachDua.Text = "Khách Đưa";
            // 
            // tbKhachDua
            // 
            this.tbKhachDua.Location = new System.Drawing.Point(204, 337);
            this.tbKhachDua.Name = "tbKhachDua";
            this.tbKhachDua.Size = new System.Drawing.Size(100, 20);
            this.tbKhachDua.TabIndex = 7;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(92, 301);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(56, 13);
            this.lblTongTien.TabIndex = 8;
            this.lblTongTien.Text = "Tổng Tiền";
            // 
            // tbTongTien
            // 
            this.tbTongTien.Location = new System.Drawing.Point(204, 301);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.Size = new System.Drawing.Size(100, 20);
            this.tbTongTien.TabIndex = 9;
            // 
            // lblThoiTien
            // 
            this.lblThoiTien.AutoSize = true;
            this.lblThoiTien.Location = new System.Drawing.Point(92, 382);
            this.lblThoiTien.Name = "lblThoiTien";
            this.lblThoiTien.Size = new System.Drawing.Size(52, 13);
            this.lblThoiTien.TabIndex = 10;
            this.lblThoiTien.Text = "Thối Tiền";
            // 
            // tbThoi
            // 
            this.tbThoi.Location = new System.Drawing.Point(204, 382);
            this.tbThoi.Name = "tbThoi";
            this.tbThoi.Size = new System.Drawing.Size(100, 20);
            this.tbThoi.TabIndex = 11;
            // 
            // GiaHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbThoi);
            this.Controls.Add(this.lblThoiTien);
            this.Controls.Add(this.tbTongTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.tbKhachDua);
            this.Controls.Add(this.lblKhachDua);
            this.Controls.Add(this.btnInBill);
            this.Controls.Add(this.btnGiaHan);
            this.Controls.Add(this.cbGoiTap);
            this.Controls.Add(this.lblGoiTap);
            this.Controls.Add(this.dtpNgayGiaHan);
            this.Controls.Add(this.lblNgayGiaHan);
            this.Name = "GiaHan";
            this.Size = new System.Drawing.Size(1064, 667);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNgayGiaHan;
        private System.Windows.Forms.DateTimePicker dtpNgayGiaHan;
        private System.Windows.Forms.Label lblGoiTap;
        private System.Windows.Forms.ComboBox cbGoiTap;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.Button btnInBill;
        private System.Windows.Forms.Label lblKhachDua;
        private System.Windows.Forms.TextBox tbKhachDua;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.Label lblThoiTien;
        private System.Windows.Forms.TextBox tbThoi;
    }
}
