namespace GymManagerment_MVP
{
    partial class ThemHocVienfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemHocVienfrm));
            this.gbSex = new System.Windows.Forms.GroupBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.btnChonHinh = new System.Windows.Forms.Button();
            this.tbDuongDan = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblPFSDT = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.lblPFTen = new System.Windows.Forms.Label();
            this.pbAvartar = new System.Windows.Forms.PictureBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtMua = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTag = new System.Windows.Forms.NumericUpDown();
            this.gbSex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvartar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTag)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSex
            // 
            this.gbSex.Controls.Add(this.rdNu);
            this.gbSex.Controls.Add(this.rdNam);
            this.gbSex.Location = new System.Drawing.Point(288, 189);
            this.gbSex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSex.Name = "gbSex";
            this.gbSex.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSex.Size = new System.Drawing.Size(364, 77);
            this.gbSex.TabIndex = 74;
            this.gbSex.TabStop = false;
            this.gbSex.Text = "Giới Tính";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(198, 29);
            this.rdNu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(54, 24);
            this.rdNu.TabIndex = 1;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(46, 29);
            this.rdNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(67, 24);
            this.rdNam.TabIndex = 0;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaysinh.Location = new System.Drawing.Point(400, 138);
            this.dtpNgaysinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(252, 26);
            this.dtpNgaysinh.TabIndex = 73;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(284, 148);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(81, 20);
            this.lblNgaySinh.TabIndex = 72;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Location = new System.Drawing.Point(560, 421);
            this.btnChonHinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(92, 35);
            this.btnChonHinh.TabIndex = 71;
            this.btnChonHinh.Text = "...";
            this.btnChonHinh.UseVisualStyleBackColor = true;
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
            // 
            // tbDuongDan
            // 
            this.tbDuongDan.Location = new System.Drawing.Point(18, 425);
            this.tbDuongDan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDuongDan.Name = "tbDuongDan";
            this.tbDuongDan.ReadOnly = true;
            this.tbDuongDan.Size = new System.Drawing.Size(493, 26);
            this.tbDuongDan.TabIndex = 70;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(400, 85);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(252, 26);
            this.txtSDT.TabIndex = 60;
            // 
            // lblPFSDT
            // 
            this.lblPFSDT.AutoSize = true;
            this.lblPFSDT.Location = new System.Drawing.Point(284, 94);
            this.lblPFSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPFSDT.Name = "lblPFSDT";
            this.lblPFSDT.Size = new System.Drawing.Size(41, 20);
            this.lblPFSDT.TabIndex = 59;
            this.lblPFSDT.Text = "SDT";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(400, 40);
            this.tbTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(252, 26);
            this.tbTen.TabIndex = 58;
            // 
            // lblPFTen
            // 
            this.lblPFTen.AutoSize = true;
            this.lblPFTen.Location = new System.Drawing.Point(284, 45);
            this.lblPFTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPFTen.Name = "lblPFTen";
            this.lblPFTen.Size = new System.Drawing.Size(36, 20);
            this.lblPFTen.TabIndex = 57;
            this.lblPFTen.Text = "Ten";
            // 
            // pbAvartar
            // 
            this.pbAvartar.Image = ((System.Drawing.Image)(resources.GetObject("pbAvartar.Image")));
            this.pbAvartar.Location = new System.Drawing.Point(18, 18);
            this.pbAvartar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbAvartar.Name = "pbAvartar";
            this.pbAvartar.Padding = new System.Windows.Forms.Padding(15);
            this.pbAvartar.Size = new System.Drawing.Size(256, 277);
            this.pbAvartar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvartar.TabIndex = 56;
            this.pbAvartar.TabStop = false;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(544, 469);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(108, 35);
            this.btnXacNhan.TabIndex = 75;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(18, 469);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(108, 35);
            this.btnHuy.TabIndex = 78;
            this.btnHuy.Text = "Cancel";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtMua
            // 
            this.txtMua.Location = new System.Drawing.Point(422, 469);
            this.txtMua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMua.Name = "txtMua";
            this.txtMua.Size = new System.Drawing.Size(112, 35);
            this.txtMua.TabIndex = 79;
            this.txtMua.Text = "Mua Hàng";
            this.txtMua.UseVisualStyleBackColor = true;
            this.txtMua.Click += new System.EventHandler(this.txtMua_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(400, 326);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(252, 73);
            this.txtNote.TabIndex = 80;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 329);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 72;
            this.label1.Text = "Ghi Chú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 81;
            this.label2.Text = "Thẻ";
            // 
            // nudTag
            // 
            this.nudTag.Location = new System.Drawing.Point(400, 283);
            this.nudTag.Name = "nudTag";
            this.nudTag.Size = new System.Drawing.Size(252, 26);
            this.nudTag.TabIndex = 82;
            // 
            // ThemHocVienfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 540);
            this.Controls.Add(this.nudTag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtMua);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.gbSex);
            this.Controls.Add(this.dtpNgaysinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.btnChonHinh);
            this.Controls.Add(this.tbDuongDan);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblPFSDT);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.lblPFTen);
            this.Controls.Add(this.pbAvartar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ThemHocVienfrm";
            this.Text = "ThemHocVienfrm";
            this.gbSex.ResumeLayout(false);
            this.gbSex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvartar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbSex;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Button btnChonHinh;
        private System.Windows.Forms.TextBox tbDuongDan;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblPFSDT;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label lblPFTen;
        private System.Windows.Forms.PictureBox pbAvartar;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button txtMua;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTag;
    }
}