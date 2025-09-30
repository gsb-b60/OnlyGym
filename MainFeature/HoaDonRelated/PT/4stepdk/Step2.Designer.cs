namespace GymManagerment_MVP.MainFeature.HoaDonRelated.PT._4stepdk
{
    partial class Step2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Step2));
            this.pns2Content = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblChiTiet = new System.Windows.Forms.Label();
            this.rtbChiTiet = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbChuyenMon = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pns2Content.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pns2Content
            // 
            this.pns2Content.Controls.Add(this.panel2);
            this.pns2Content.Controls.Add(this.panel1);
            this.pns2Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pns2Content.Location = new System.Drawing.Point(0, 0);
            this.pns2Content.Name = "pns2Content";
            this.pns2Content.Padding = new System.Windows.Forms.Padding(40);
            this.pns2Content.Size = new System.Drawing.Size(969, 540);
            this.pns2Content.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblChiTiet);
            this.panel2.Controls.Add(this.rtbChiTiet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(240, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 460);
            this.panel2.TabIndex = 1;
            // 
            // lblChiTiet
            // 
            this.lblChiTiet.AutoSize = true;
            this.lblChiTiet.Location = new System.Drawing.Point(36, 9);
            this.lblChiTiet.Name = "lblChiTiet";
            this.lblChiTiet.Size = new System.Drawing.Size(106, 13);
            this.lblChiTiet.TabIndex = 48;
            this.lblChiTiet.Text = "Chi Tiết Chuyên Môn";
            // 
            // rtbChiTiet
            // 
            this.rtbChiTiet.AcceptsTab = true;
            this.rtbChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbChiTiet.Location = new System.Drawing.Point(39, 25);
            this.rtbChiTiet.Name = "rtbChiTiet";
            this.rtbChiTiet.Size = new System.Drawing.Size(629, 499);
            this.rtbChiTiet.TabIndex = 47;
            this.rtbChiTiet.Text = resources.GetString("rtbChiTiet.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbChuyenMon);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(40, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 460);
            this.panel1.TabIndex = 0;
            // 
            // lbChuyenMon
            // 
            this.lbChuyenMon.FormattingEnabled = true;
            this.lbChuyenMon.Items.AddRange(new object[] {
            "Hồi Phục Chức Năng",
            "Thi Đấu Thể Hình",
            "Giảm Cân Người Lớn Tuổi",
            "Giảm Cân Nữ",
            "Giảm Cân Nam",
            "Huấn Luyện Thể Lực",
            "Thi Đấu Cử tạ",
            "Tăng Cường Sức Mạnh"});
            this.lbChuyenMon.Location = new System.Drawing.Point(24, 56);
            this.lbChuyenMon.Name = "lbChuyenMon";
            this.lbChuyenMon.Size = new System.Drawing.Size(156, 394);
            this.lbChuyenMon.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Chuyên Môn";
            // 
            // Step2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pns2Content);
            this.Name = "Step2";
            this.Size = new System.Drawing.Size(969, 540);
            this.pns2Content.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pns2Content;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbChuyenMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblChiTiet;
        private System.Windows.Forms.RichTextBox rtbChiTiet;
    }
}
