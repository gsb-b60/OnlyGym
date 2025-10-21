namespace GymManagerment_MVP.MainFeature.HoaDonRelated.PT
{
    partial class GoiPTUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoiPTUC));
            this.pbSetting = new System.Windows.Forms.PictureBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblTenGoi = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblGiaTri = new System.Windows.Forms.Label();
            this.lblLoaiHang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetting)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbSetting
            // 
            this.pbSetting.Image = ((System.Drawing.Image)(resources.GetObject("pbSetting.Image")));
            this.pbSetting.Location = new System.Drawing.Point(168, 129);
            this.pbSetting.Name = "pbSetting";
            this.pbSetting.Size = new System.Drawing.Size(22, 22);
            this.pbSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSetting.TabIndex = 10;
            this.pbSetting.TabStop = false;
            this.pbSetting.Click += new System.EventHandler(this.pbSetting_Click);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(46, 129);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 8;
            this.btnChon.Text = "Chon";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnMuaGoi_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.Teal;
            this.pnlContent.Controls.Add(this.lblDiscount);
            this.pnlContent.Controls.Add(this.lblThanhTien);
            this.pnlContent.Controls.Add(this.lblTenGoi);
            this.pnlContent.Controls.Add(this.lblState);
            this.pnlContent.Controls.Add(this.lblGiaTri);
            this.pnlContent.Controls.Add(this.lblLoaiHang);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(204, 123);
            this.pnlContent.TabIndex = 7;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(12, 91);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(77, 20);
            this.lblDiscount.TabIndex = 12;
            this.lblDiscount.Text = "discount";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblThanhTien.Location = new System.Drawing.Point(85, 91);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(107, 23);
            this.lblThanhTien.TabIndex = 11;
            this.lblThanhTien.Text = "Thanh Tien";
            this.lblThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTenGoi
            // 
            this.lblTenGoi.AutoSize = true;
            this.lblTenGoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTenGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenGoi.Location = new System.Drawing.Point(13, 35);
            this.lblTenGoi.Name = "lblTenGoi";
            this.lblTenGoi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTenGoi.Size = new System.Drawing.Size(70, 25);
            this.lblTenGoi.TabIndex = 10;
            this.lblTenGoi.Text = "label1";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblState.Location = new System.Drawing.Point(117, 8);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(59, 13);
            this.lblState.TabIndex = 8;
            this.lblState.Text = "Tình Trạng";
            // 
            // lblGiaTri
            // 
            this.lblGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGiaTri.Location = new System.Drawing.Point(85, 60);
            this.lblGiaTri.Name = "lblGiaTri";
            this.lblGiaTri.Size = new System.Drawing.Size(107, 31);
            this.lblGiaTri.TabIndex = 9;
            this.lblGiaTri.Text = "giá trị gói";
            this.lblGiaTri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLoaiHang
            // 
            this.lblLoaiHang.AutoSize = true;
            this.lblLoaiHang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLoaiHang.Location = new System.Drawing.Point(13, 8);
            this.lblLoaiHang.Name = "lblLoaiHang";
            this.lblLoaiHang.Size = new System.Drawing.Size(56, 13);
            this.lblLoaiHang.TabIndex = 7;
            this.lblLoaiHang.Text = "Loại Hàng";
            // 
            // GoiPTUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pbSetting);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.pnlContent);
            this.Name = "GoiPTUC";
            this.Size = new System.Drawing.Size(204, 154);
            ((System.ComponentModel.ISupportInitialize)(this.pbSetting)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSetting;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblTenGoi;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblGiaTri;
        private System.Windows.Forms.Label lblLoaiHang;
    }
}
