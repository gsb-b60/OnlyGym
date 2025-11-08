namespace GymManagerment_MVP
{
    partial class ThanhToanChuyenKhoanUC
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
            this.lblThongTinCK = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblThongTinCK
            // 
            this.lblThongTinCK.AutoSize = true;
            this.lblThongTinCK.Location = new System.Drawing.Point(28, 21);
            this.lblThongTinCK.Name = "lblThongTinCK";
            this.lblThongTinCK.Size = new System.Drawing.Size(93, 13);
            this.lblThongTinCK.TabIndex = 0;
            this.lblThongTinCK.Text = "0877777631 || MB";
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Location = new System.Drawing.Point(31, 71);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(129, 13);
            this.lblThongTin.TabIndex = 1;
            this.lblThongTin.Text = "Thông Tin Chuyển Khoản";
            // 
            // ThanhToanChuyenKhoanUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.lblThongTinCK);
            this.Name = "ThanhToanChuyenKhoanUC";
            this.Size = new System.Drawing.Size(716, 164);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongTinCK;
        private System.Windows.Forms.Label lblThongTin;
    }
}
