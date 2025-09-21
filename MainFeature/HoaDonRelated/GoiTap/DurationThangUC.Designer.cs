namespace GymManagerment_MVP.MainFeature.HoaDonRelated.GoiTap
{
    partial class DurationThangUC
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
            this.nupDuration = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.rdThang = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nupDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // nupDuration
            // 
            this.nupDuration.Location = new System.Drawing.Point(82, 17);
            this.nupDuration.Name = "nupDuration";
            this.nupDuration.Size = new System.Drawing.Size(120, 20);
            this.nupDuration.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Độ Dài Gói";
            // 
            // rdThang
            // 
            this.rdThang.AutoSize = true;
            this.rdThang.Location = new System.Drawing.Point(20, 58);
            this.rdThang.Name = "rdThang";
            this.rdThang.Size = new System.Drawing.Size(56, 17);
            this.rdThang.TabIndex = 2;
            this.rdThang.TabStop = true;
            this.rdThang.Text = "Tháng";
            this.rdThang.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(130, 58);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 3;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Năm";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // DurationThangUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.rdThang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupDuration);
            this.Name = "DurationThangUC";
            this.Size = new System.Drawing.Size(218, 106);
            ((System.ComponentModel.ISupportInitialize)(this.nupDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nupDuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdThang;
        private System.Windows.Forms.RadioButton rdNam;
    }
}
