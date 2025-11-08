namespace GymManagerment_MVP
{
    partial class ThanhToanTienMatUCcs
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
            this.lblKhachDua = new System.Windows.Forms.Label();
            this.tbTienKhachDua = new System.Windows.Forms.TextBox();
            this.lblThongtin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKhachDua
            // 
            this.lblKhachDua.AutoSize = true;
            this.lblKhachDua.Location = new System.Drawing.Point(36, 22);
            this.lblKhachDua.Name = "lblKhachDua";
            this.lblKhachDua.Size = new System.Drawing.Size(61, 13);
            this.lblKhachDua.TabIndex = 0;
            this.lblKhachDua.Text = "Khách Đưa";
            // 
            // tbTienKhachDua
            // 
            this.tbTienKhachDua.Location = new System.Drawing.Point(137, 19);
            this.tbTienKhachDua.Name = "tbTienKhachDua";
            this.tbTienKhachDua.Size = new System.Drawing.Size(100, 20);
            this.tbTienKhachDua.TabIndex = 1;
            // 
            // lblThongtin
            // 
            this.lblThongtin.AutoSize = true;
            this.lblThongtin.Location = new System.Drawing.Point(39, 113);
            this.lblThongtin.Name = "lblThongtin";
            this.lblThongtin.Size = new System.Drawing.Size(163, 13);
            this.lblThongtin.TabIndex = 2;
            this.lblThongtin.Text = "Thông Tin Thanh Toán Tiền Mặt";
            // 
            // ThanhToanTienMatUCcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblThongtin);
            this.Controls.Add(this.tbTienKhachDua);
            this.Controls.Add(this.lblKhachDua);
            this.Name = "ThanhToanTienMatUCcs";
            this.Size = new System.Drawing.Size(716, 164);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKhachDua;
        private System.Windows.Forms.TextBox tbTienKhachDua;
        private System.Windows.Forms.Label lblThongtin;
    }
}
