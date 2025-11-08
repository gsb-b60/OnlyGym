namespace GymManagerment_MVP.MainFeature.HoaDonRelated
{
    partial class GoiTapUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoiTapUC));
            this.pnGoiContent = new System.Windows.Forms.Panel();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblTenGoi = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblGiaTri = new System.Windows.Forms.Label();
            this.lblLoaiHang = new System.Windows.Forms.Label();
            this.btnMuaGoi = new System.Windows.Forms.Button();
            this.btnMuaNgay = new System.Windows.Forms.Button();
            this.pbSetting = new System.Windows.Forms.PictureBox();
            this.cmsConfig = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tắtActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnGoiContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetting)).BeginInit();
            this.cmsConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnGoiContent
            // 
            this.pnGoiContent.BackColor = System.Drawing.Color.Teal;
            this.pnGoiContent.Controls.Add(this.lblDiscount);
            this.pnGoiContent.Controls.Add(this.lblThanhTien);
            this.pnGoiContent.Controls.Add(this.lblTenGoi);
            this.pnGoiContent.Controls.Add(this.lblState);
            this.pnGoiContent.Controls.Add(this.lblGiaTri);
            this.pnGoiContent.Controls.Add(this.lblLoaiHang);
            this.pnGoiContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnGoiContent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnGoiContent.Location = new System.Drawing.Point(0, 0);
            this.pnGoiContent.Name = "pnGoiContent";
            this.pnGoiContent.Size = new System.Drawing.Size(197, 110);
            this.pnGoiContent.TabIndex = 0;
            this.pnGoiContent.Click += new System.EventHandler(this.panel1_Click);
            this.pnGoiContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(7, 87);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(77, 20);
            this.lblDiscount.TabIndex = 6;
            this.lblDiscount.Text = "discount";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblThanhTien.Location = new System.Drawing.Point(80, 87);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(107, 23);
            this.lblThanhTien.TabIndex = 5;
            this.lblThanhTien.Text = "Thanh Tien";
            this.lblThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblThanhTien.Click += new System.EventHandler(this.lblThanhTien_Click);
            // 
            // lblTenGoi
            // 
            this.lblTenGoi.AutoSize = true;
            this.lblTenGoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTenGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenGoi.Location = new System.Drawing.Point(8, 31);
            this.lblTenGoi.Name = "lblTenGoi";
            this.lblTenGoi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTenGoi.Size = new System.Drawing.Size(70, 25);
            this.lblTenGoi.TabIndex = 4;
            this.lblTenGoi.Text = "label1";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblState.Location = new System.Drawing.Point(112, 4);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(59, 13);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "Tình Trạng";
            // 
            // lblGiaTri
            // 
            this.lblGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGiaTri.Location = new System.Drawing.Point(80, 56);
            this.lblGiaTri.Name = "lblGiaTri";
            this.lblGiaTri.Size = new System.Drawing.Size(107, 31);
            this.lblGiaTri.TabIndex = 2;
            this.lblGiaTri.Text = "giá trị gói";
            this.lblGiaTri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLoaiHang
            // 
            this.lblLoaiHang.AutoSize = true;
            this.lblLoaiHang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLoaiHang.Location = new System.Drawing.Point(8, 4);
            this.lblLoaiHang.Name = "lblLoaiHang";
            this.lblLoaiHang.Size = new System.Drawing.Size(56, 13);
            this.lblLoaiHang.TabIndex = 1;
            this.lblLoaiHang.Text = "Loại Hàng";
            // 
            // btnMuaGoi
            // 
            this.btnMuaGoi.Location = new System.Drawing.Point(84, 116);
            this.btnMuaGoi.Name = "btnMuaGoi";
            this.btnMuaGoi.Size = new System.Drawing.Size(75, 23);
            this.btnMuaGoi.TabIndex = 3;
            this.btnMuaGoi.Text = "Mua Gói";
            this.btnMuaGoi.UseVisualStyleBackColor = true;
            this.btnMuaGoi.Click += new System.EventHandler(this.btnMuaGoi_Click);
            // 
            // btnMuaNgay
            // 
            this.btnMuaNgay.Location = new System.Drawing.Point(3, 116);
            this.btnMuaNgay.Name = "btnMuaNgay";
            this.btnMuaNgay.Size = new System.Drawing.Size(75, 23);
            this.btnMuaNgay.TabIndex = 5;
            this.btnMuaNgay.Text = "Mua Ngay";
            this.btnMuaNgay.UseVisualStyleBackColor = true;
            this.btnMuaNgay.Click += new System.EventHandler(this.btnMuaNgay_Click);
            // 
            // pbSetting
            // 
            this.pbSetting.ContextMenuStrip = this.cmsConfig;
            this.pbSetting.Image = ((System.Drawing.Image)(resources.GetObject("pbSetting.Image")));
            this.pbSetting.Location = new System.Drawing.Point(165, 116);
            this.pbSetting.Name = "pbSetting";
            this.pbSetting.Size = new System.Drawing.Size(22, 22);
            this.pbSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSetting.TabIndex = 6;
            this.pbSetting.TabStop = false;
            this.pbSetting.Click += new System.EventHandler(this.pbSetting_Click);
            // 
            // cmsConfig
            // 
            this.cmsConfig.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem,
            this.tắtActiveToolStripMenuItem,
            this.activeNowToolStripMenuItem});
            this.cmsConfig.Name = "cmsConfig";
            this.cmsConfig.Size = new System.Drawing.Size(136, 70);
            this.cmsConfig.Opening += new System.ComponentModel.CancelEventHandler(this.cmsConfig_Opening);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // tắtActiveToolStripMenuItem
            // 
            this.tắtActiveToolStripMenuItem.Name = "tắtActiveToolStripMenuItem";
            this.tắtActiveToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.tắtActiveToolStripMenuItem.Text = "Tắt Active";
            // 
            // activeNowToolStripMenuItem
            // 
            this.activeNowToolStripMenuItem.Name = "activeNowToolStripMenuItem";
            this.activeNowToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.activeNowToolStripMenuItem.Text = "Active Now";
            // 
            // GoiTapUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pbSetting);
            this.Controls.Add(this.btnMuaNgay);
            this.Controls.Add(this.btnMuaGoi);
            this.Controls.Add(this.pnGoiContent);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "GoiTapUC";
            this.Size = new System.Drawing.Size(197, 141);
            this.Load += new System.EventHandler(this.GoiTapUC_Load);
            this.Click += new System.EventHandler(this.GoiTapUC_Click);
            this.pnGoiContent.ResumeLayout(false);
            this.pnGoiContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetting)).EndInit();
            this.cmsConfig.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnGoiContent;
        private System.Windows.Forms.Label lblLoaiHang;
        private System.Windows.Forms.Label lblGiaTri;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btnMuaGoi;
        private System.Windows.Forms.Button btnMuaNgay;
        private System.Windows.Forms.PictureBox pbSetting;
        private System.Windows.Forms.ContextMenuStrip cmsConfig;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tắtActiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeNowToolStripMenuItem;
        private System.Windows.Forms.Label lblTenGoi;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblDiscount;
    }
}
