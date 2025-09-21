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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.Giá = new System.Windows.Forms.Label();
            this.lblLoaiHang = new System.Windows.Forms.Label();
            this.lblTenGoi = new System.Windows.Forms.Label();
            this.btnMuaGoi = new System.Windows.Forms.Button();
            this.btnMuaNgay = new System.Windows.Forms.Button();
            this.pbSetting = new System.Windows.Forms.PictureBox();
            this.cmsConfig = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tắtActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetting)).BeginInit();
            this.cmsConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblThanhTien);
            this.panel1.Controls.Add(this.lblState);
            this.panel1.Controls.Add(this.Giá);
            this.panel1.Controls.Add(this.lblLoaiHang);
            this.panel1.Controls.Add(this.lblTenGoi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 89);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(109, 69);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(62, 13);
            this.lblThanhTien.TabIndex = 3;
            this.lblThanhTien.Text = "Thành Tiền";
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
            // Giá
            // 
            this.Giá.AutoSize = true;
            this.Giá.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Giá.Location = new System.Drawing.Point(122, 56);
            this.Giá.Name = "Giá";
            this.Giá.Size = new System.Drawing.Size(49, 13);
            this.Giá.TabIndex = 2;
            this.Giá.Text = "giá trị gói";
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
            // lblTenGoi
            // 
            this.lblTenGoi.AutoSize = true;
            this.lblTenGoi.BackColor = System.Drawing.Color.Teal;
            this.lblTenGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenGoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTenGoi.Location = new System.Drawing.Point(41, 30);
            this.lblTenGoi.Name = "lblTenGoi";
            this.lblTenGoi.Size = new System.Drawing.Size(78, 24);
            this.lblTenGoi.TabIndex = 0;
            this.lblTenGoi.Text = "Tên Gói";
            // 
            // btnMuaGoi
            // 
            this.btnMuaGoi.Location = new System.Drawing.Point(84, 95);
            this.btnMuaGoi.Name = "btnMuaGoi";
            this.btnMuaGoi.Size = new System.Drawing.Size(75, 23);
            this.btnMuaGoi.TabIndex = 3;
            this.btnMuaGoi.Text = "Mua Gói";
            this.btnMuaGoi.UseVisualStyleBackColor = true;
            this.btnMuaGoi.Click += new System.EventHandler(this.btnMuaGoi_Click);
            // 
            // btnMuaNgay
            // 
            this.btnMuaNgay.Location = new System.Drawing.Point(3, 95);
            this.btnMuaNgay.Name = "btnMuaNgay";
            this.btnMuaNgay.Size = new System.Drawing.Size(75, 23);
            this.btnMuaNgay.TabIndex = 5;
            this.btnMuaNgay.Text = "Mua Ngay";
            this.btnMuaNgay.UseVisualStyleBackColor = true;
            // 
            // pbSetting
            // 
            this.pbSetting.ContextMenuStrip = this.cmsConfig;
            this.pbSetting.Image = ((System.Drawing.Image)(resources.GetObject("pbSetting.Image")));
            this.pbSetting.Location = new System.Drawing.Point(165, 95);
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
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "GoiTapUC";
            this.Size = new System.Drawing.Size(197, 126);
            this.Click += new System.EventHandler(this.GoiTapUC_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetting)).EndInit();
            this.cmsConfig.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTenGoi;
        private System.Windows.Forms.Label lblLoaiHang;
        private System.Windows.Forms.Label Giá;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btnMuaGoi;
        private System.Windows.Forms.Button btnMuaNgay;
        private System.Windows.Forms.PictureBox pbSetting;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.ContextMenuStrip cmsConfig;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tắtActiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeNowToolStripMenuItem;
    }
}
