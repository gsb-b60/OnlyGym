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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTenGoi = new System.Windows.Forms.Label();
            this.lblThoiHan = new System.Windows.Forms.Label();
            this.Giá = new System.Windows.Forms.Label();
            this.lblLoaiHang = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblState);
            this.panel1.Controls.Add(this.lblLoaiHang);
            this.panel1.Controls.Add(this.lblTenGoi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 89);
            this.panel1.TabIndex = 0;
            // 
            // lblTenGoi
            // 
            this.lblTenGoi.AutoSize = true;
            this.lblTenGoi.BackColor = System.Drawing.Color.Teal;
            this.lblTenGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenGoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTenGoi.Location = new System.Drawing.Point(56, 36);
            this.lblTenGoi.Name = "lblTenGoi";
            this.lblTenGoi.Size = new System.Drawing.Size(78, 24);
            this.lblTenGoi.TabIndex = 0;
            this.lblTenGoi.Text = "Tên Gói";
            // 
            // lblThoiHan
            // 
            this.lblThoiHan.AutoSize = true;
            this.lblThoiHan.Location = new System.Drawing.Point(8, 92);
            this.lblThoiHan.Name = "lblThoiHan";
            this.lblThoiHan.Size = new System.Drawing.Size(51, 13);
            this.lblThoiHan.TabIndex = 1;
            this.lblThoiHan.Text = "Thời Hạn";
            // 
            // Giá
            // 
            this.Giá.AutoSize = true;
            this.Giá.Location = new System.Drawing.Point(155, 92);
            this.Giá.Name = "Giá";
            this.Giá.Size = new System.Drawing.Size(35, 13);
            this.Giá.TabIndex = 2;
            this.Giá.Text = "label1";
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
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblState.Location = new System.Drawing.Point(106, 4);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(59, 13);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "Tình Trạng";
            // 
            // GoiTapUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.Giá);
            this.Controls.Add(this.lblThoiHan);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "GoiTapUC";
            this.Size = new System.Drawing.Size(209, 122);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTenGoi;
        private System.Windows.Forms.Label lblThoiHan;
        private System.Windows.Forms.Label lblLoaiHang;
        private System.Windows.Forms.Label Giá;
        private System.Windows.Forms.Label lblState;
    }
}
