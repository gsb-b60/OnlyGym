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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.Giá = new System.Windows.Forms.Label();
            this.lblLoaiHang = new System.Windows.Forms.Label();
            this.lblTenGoi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetting)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbSetting
            // 
            this.pbSetting.Image = ((System.Drawing.Image)(resources.GetObject("pbSetting.Image")));
            this.pbSetting.Location = new System.Drawing.Point(166, 95);
            this.pbSetting.Name = "pbSetting";
            this.pbSetting.Size = new System.Drawing.Size(22, 22);
            this.pbSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSetting.TabIndex = 10;
            this.pbSetting.TabStop = false;
            this.pbSetting.Click += new System.EventHandler(this.pbSetting_Click);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(44, 95);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 8;
            this.btnChon.Text = "Chon";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnMuaGoi_Click);
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
            this.panel1.Size = new System.Drawing.Size(204, 89);
            this.panel1.TabIndex = 7;
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
            // GoiPTUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pbSetting);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.panel1);
            this.Name = "GoiPTUC";
            this.Size = new System.Drawing.Size(204, 126);
            ((System.ComponentModel.ISupportInitialize)(this.pbSetting)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSetting;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label Giá;
        private System.Windows.Forms.Label lblLoaiHang;
        private System.Windows.Forms.Label lblTenGoi;
    }
}
