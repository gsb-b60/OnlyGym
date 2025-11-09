namespace GymManagerment_MVP.MainFeature.HoaDonRelated.PT._4stepdk
{
    partial class HienThiLichPTfrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chgGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chgBỏ = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTuoi = new System.Windows.Forms.Label();
            this.lblKyHieu = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblPFSDT = new System.Windows.Forms.Label();
            this.lblPFTen = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.chgGio,
            this.chgBỏ});
            this.dataGridView1.Location = new System.Drawing.Point(12, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 304);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Buổi Thứ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ngày";
            this.Column2.Name = "Column2";
            // 
            // chgGio
            // 
            this.chgGio.HeaderText = "Giờ";
            this.chgGio.Name = "chgGio";
            // 
            // chgBỏ
            // 
            this.chgBỏ.HeaderText = "Bỏ";
            this.chgBỏ.Name = "chgBỏ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên PT";
            // 
            // lblTuoi
            // 
            this.lblTuoi.AutoSize = true;
            this.lblTuoi.Location = new System.Drawing.Point(122, 34);
            this.lblTuoi.Name = "lblTuoi";
            this.lblTuoi.Size = new System.Drawing.Size(19, 13);
            this.lblTuoi.TabIndex = 45;
            this.lblTuoi.Text = "20";
            // 
            // lblKyHieu
            // 
            this.lblKyHieu.AutoSize = true;
            this.lblKyHieu.Location = new System.Drawing.Point(107, 34);
            this.lblKyHieu.Name = "lblKyHieu";
            this.lblKyHieu.Size = new System.Drawing.Size(9, 13);
            this.lblKyHieu.TabIndex = 44;
            this.lblKyHieu.Text = "|";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(72, 34);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(29, 13);
            this.lblSex.TabIndex = 43;
            this.lblSex.Text = "Nam";
            // 
            // lblPFSDT
            // 
            this.lblPFSDT.AutoSize = true;
            this.lblPFSDT.Location = new System.Drawing.Point(72, 62);
            this.lblPFSDT.Name = "lblPFSDT";
            this.lblPFSDT.Size = new System.Drawing.Size(89, 13);
            this.lblPFSDT.TabIndex = 42;
            this.lblPFSDT.Text = "SDT: 012345678";
            // 
            // lblPFTen
            // 
            this.lblPFTen.AutoSize = true;
            this.lblPFTen.Location = new System.Drawing.Point(72, 9);
            this.lblPFTen.Name = "lblPFTen";
            this.lblPFTen.Size = new System.Drawing.Size(94, 13);
            this.lblPFTen.TabIndex = 41;
            this.lblPFTen.Text = "Nguyễn Đình Hiếu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "Xuất File Exel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 47;
            this.button2.Text = "Hoàn Thành";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // HienThiLichPTfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 509);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTuoi);
            this.Controls.Add(this.lblKyHieu);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblPFSDT);
            this.Controls.Add(this.lblPFTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HienThiLichPTfrm";
            this.Text = "HienThiLichPTfrm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgGio;
        private System.Windows.Forms.DataGridViewButtonColumn chgBỏ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTuoi;
        private System.Windows.Forms.Label lblKyHieu;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblPFSDT;
        private System.Windows.Forms.Label lblPFTen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}