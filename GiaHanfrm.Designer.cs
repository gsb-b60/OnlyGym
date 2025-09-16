namespace GymManagerment_MVP
{
    partial class GiaHanfrm
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
            this.lblThongTinMua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblThongTinMua
            // 
            this.lblThongTinMua.AutoSize = true;
            this.lblThongTinMua.Location = new System.Drawing.Point(36, 35);
            this.lblThongTinMua.Name = "lblThongTinMua";
            this.lblThongTinMua.Size = new System.Drawing.Size(102, 13);
            this.lblThongTinMua.TabIndex = 0;
            this.lblThongTinMua.Text = "Thông tin mua hàng";
            // 
            // GiaHanfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 533);
            this.Controls.Add(this.lblThongTinMua);
            this.Name = "GiaHanfrm";
            this.Text = "GiaHanfrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongTinMua;
    }
}